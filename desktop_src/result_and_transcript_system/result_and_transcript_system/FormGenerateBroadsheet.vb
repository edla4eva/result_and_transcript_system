Imports System.ComponentModel

Public Class FormGenerateBroadsheet
    Dim course_dept_idr As Integer = 1 '
    Dim session_idr As String = "2018/2019"
    Dim course_level = "300"

    Dim dictDepts As New Dictionary(Of String, String)
    'Dim dictCourses As New Dictionary(Of String, String)
    Dim dictSessions As New Dictionary(Of String, String)

    Private Sub TextBoxDepartment_TextChanged(sender As Object, e As EventArgs) Handles TextBoxDepartment.TextChanged

    End Sub

    Private Sub FormGenerateBroadsheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = RGBColors.colorBlack2


    End Sub

    Private Sub ButtonProcessBroadsheet_Click(sender As Object, e As EventArgs) Handles ButtonProcessBroadsheet.Click
        PanelMenu.Visible = True

    End Sub
    Private Sub processBroadsheetExcelInteropMethod()   'todo: orphaned sub
        Dim tmpDS As DataSet
        Dim tmpDV As DataView
        Dim dSession As String = "2018/2019"
        Dim dLevel As Integer = 300
        Dim dCourseCode As String = "CPE375"
        Dim strapprovedCourses As String
        Dim arrayapprovedCourses() As String
        tmpDS = mappDB.GetDataWhere(String.Format(STR_SQL_ALL_BROADSHEET, dSession, dLevel))
        tmpDV = tmpDS.Tables(0).DefaultView
        For i = 0 To tmpDS.Tables(0).Rows.Count - 1

        Next
        '#Get couses approved for session
        'public STR_SQL_APPROVED_COURSES = "SELECT approved_courses_300 from sessions WHERE session_id='{0}';
        strapprovedCourses = mappDB.GetRecordWhere(String.Format(STR_SQL_APPROVED_COURSES, dSession))
        arrayapprovedCourses = strapprovedCourses.Split(";")
        For j = 0 To arrayapprovedCourses.Count - 1
            tmpDS.Tables(0).Columns.Add(arrayapprovedCourses(j))
        Next

        DataGridViewBroadSheet.DataSource = tmpDS.Tables(0).DefaultView
        '#use dlookup to add specific results to col
        'string.Format(str_dlookup_sql
        objBroadsheet.broadsheetFileName = My.Application.Info.DirectoryPath & "\templates\broadsheet - Copy3.xlsm"
        objBroadsheet.updateExcelBroadSheetInterop(tmpDV, objBroadsheet.broadsheetFileName, My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData & "\GeneratedResultBroadsheet" & TextBoxLevel.Text & ".xlsm")


        ' objBroadsheet.updateExcelBroadSheetInterop(objBroadsheet.broadsheetFileName, tmpDV)
        'end if
    End Sub


    Private Sub ButtonSaveBroadsheet_Click(sender As Object, e As EventArgs) Handles ButtonSaveBroadsheet.Click
        'Save to database
        '
        Dim dv As DataView = DataGridViewBroadSheet.DataSource
        Dim dtSource As DataTable
        Dim ds As New DataSet ' = dv.ToTable

        dtSource = dv.ToTable
        Using xconn As New OleDb.OleDbConnection(ModuleGeneral.STR_connectionString32)
            Dim adapter As New OleDb.OleDbDataAdapter("SELECT * FROM Broadsheets", xconn)
            'Dim insert As OleDb.OleDbCommand("INSERT INTO Broadsheet (matno) VALUES (@matno)", xconn)
            Dim builder As New OleDb.OleDbCommandBuilder(adapter)       'easy way for single table

            'Dim titleParam As New OleDb.OleDbParameter("@matno", Str)
            'cmd.Parameters.Add(titleParam)
            'adapter.InsertCommand = insert

            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey


            'fill it
            adapter.Fill(ds)
            DataGridViewTemp.DataSource = ds.Tables(0).DefaultView
            MsgBox("After fresh fill")
            'edit it

            For i = 0 To dtSource.Rows.Count - 1
                ds.Tables(0).Rows.Add({Rnd(1).ToString})

                For j = 0 To 30 'dtSource.Columns.Count - 1
                    ds.Tables(0).Rows(i).Item(j) = dtSource.Rows(i).Item(j)
                Next
            Next
            DataGridViewTemp.DataSource = ds.Tables(0).DefaultView
            MsgBox("After add to datatable")
            DataGridViewTemp.Refresh()
            DataGridViewTemp.EndEdit()
            MsgBox("After refresh")
            'save
            adapter.Update(ds)
        End Using



    End Sub
    Sub saveData()

    End Sub
    Private Sub SelectBroadsheetTemplate_Click(sender As Object, e As EventArgs) Handles SelectBroadsheetTemplate.Click
        Dim FileOpenDialogBroadsheet As New OpenFileDialog()
        Dim resultFileName As String = ""

        If Not FileOpenDialogBroadsheet.ShowDialog = DialogResult.Cancel Then
            resultFileName = FileOpenDialogBroadsheet.FileName()
        End If
        Me.TextBoxTemplateFileName.Text = resultFileName
        objExcelFile.excelFileName = resultFileName

        showButtons("Process", False)
    End Sub

    Sub showButtons(ButtonName As String, enableOnly As Boolean)
        Select Case ButtonName
            Case "Process"
                If enableOnly Then Me.ButtonProcessBroadsheet.Enabled = True Else Me.ButtonProcessBroadsheet.Visible = True

        End Select
    End Sub
    Sub hideButtons(ButtonName As String, disableOnly As Boolean)
        Select Case ButtonName
            Case "Process"
                If disableOnly Then Me.ButtonProcessBroadsheet.Enabled = False Else Me.ButtonProcessBroadsheet.Visible = False

        End Select
    End Sub

    Private Sub ButtonUpload_Click(sender As Object, e As EventArgs) Handles ButtonUpload.Click
        DataGridViewBroadSheet.AllowUserToAddRows = True
        DataGridViewBroadSheet.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken
    End Sub


    Function getCoursesList() As String()
        Dim str As New List(Of String)
        str.Add("PRE571")
        str.Add("CPE571")
        str.Add("CPE591")

        Return str.ToArray
    End Function

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles LabelClosePanelModify.Click
        PanelModify.Visible = False
    End Sub

    Private Sub ButtonAdjustTemplate_Click(sender As Object, e As EventArgs) Handles ButtonAdjustTemplate.Click
        If PanelModify.Visible = False Then
            PanelModify.Visible = True
        Else
            PanelModify.Visible = False
        End If
    End Sub

    Private Sub FormGenerateBroadsheet_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        On Error Resume Next
        'Me.TextBoxTemplateFileName.Text = My.Application.Info.DirectoryPath & "\templates\broadsheet.xltx"
        bgwLoad.RunWorkerAsync()
    End Sub

    Private Sub TimerBS_Tick(sender As Object, e As EventArgs) Handles TimerBS.Tick
        ProgressBarBS.Value = CInt(objBroadsheet.progress)
    End Sub

    Private Sub BgWProcess_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BgWProcess.DoWork
        Select Case CInt(e.Argument)
            Case 1 'interop
                objBroadsheet.broadsheetDataDS = objBroadsheet.createBroadsheetData(course_dept_idr.ToString, session_idr, course_level, True)
        'objBroadsheet.broadsheetDataDS = objBroadsheet.createBroadsheetData(1.ToString, "2018/2019", 100.ToString)

            Case 2
                objBroadsheet.broadsheetDataDS = objBroadsheet.createBroadsheetData(course_dept_idr.ToString, session_idr, course_level, False)
            Case Else

        End Select
    End Sub

    Private Sub BgWProcess_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BgWProcess.RunWorkerCompleted
        DataGridViewBroadSheet.DataSource = objBroadsheet.broadsheetDataDS.Tables(0).DefaultView
        TimerBS.Stop()
        ButtonProcessBroadsheet.Enabled = True
        Me.ProgressBarBS.Value = 100
    End Sub

    Private Sub bgwExportToExcel_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwExportToExcel.DoWork

        Select Case CInt(e.Argument)
            Case 1
                'interop
                objBroadsheet.updateExcelBroadSheetInterop(DataGridViewBroadSheet.DataSource, My.Application.Info.DirectoryPath & "\templates\broadsheet - Copy3.xlsm", My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData & "\GeneratedResultBroadsheet" & TextBoxLevel.Text & ".xlsm")

            Case 2
                'objExcelFile.modifyExcelFile_NPOI(My.Application.Info.DirectoryPath & "\templates\broadsheet_plain.xlsx", DataGridViewBroadSheet.DataSource) 'worked but NPOI corrupted excel fileobjExcelFile.
                objExcelFile.exportBroadsheettoExcelFile_NPOI(DataGridViewBroadSheet.DataSource, My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData & "\GeneratedResultBroadsheet" & TextBoxLevel.Text & ".xlsx")
            Case Else

        End Select
        'objExcelFile.createExcelFile_NPOI(My.Application.Info.DirectoryPath & "\samples\generated_broadsheet.xlsx") 'worked
    End Sub
    Private Sub bgwExportToExcel_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgwExportToExcel.RunWorkerCompleted
        'copy the file
        'TODO: access denied
        'My.Computer.FileSystem.CopyFile(My.Application.Info.DirectoryPath & "\templates\broadsheet - Copy3.xlsm", My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\GeneratedResultBroadsheet" & TextBoxLevel.Text & ".xlsm", True)
        'replace template with fresh copy

        MsgBox("Done: GeneratedResultBroadsheet.xlsm " & My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData & "\GeneratedResultBroadsheet" & TextBoxLevel.Text & ".xlsx")
        Me.TextBoxTemplateFileName.Text = My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData & "\GeneratedResultBroadsheet" & TextBoxLevel.Text & ".xlsx"
        ButtonExportToExcel.Enabled = True
        TimerBS.Stop()
        ButtonProcessBroadsheet.Enabled = True
        Me.ProgressBarBS.Value = 100
    End Sub
    Private Sub ButtonCloud_Click(sender As Object, e As EventArgs) Handles ButtonCloud.Click
        testDB()
    End Sub
    Sub testDB()
        Try
            Using xConn As New OleDb.OleDbConnection(ModuleGeneral.STR_connectionString)
                Try
                    xConn.Open()
                Catch ex1 As Exception
                    xConn.ConnectionString = ModuleGeneral.STR_connectionString
                    xConn.Open()
                End Try

                Dim cmdLocal As New OleDb.OleDbCommand(ModuleGeneral.STR_SQL_ALL_DEPARTMENTS_COMBO, xConn)
                Dim myDA As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(cmdLocal)
                Dim myDataSet As DataSet = New DataSet()
                myDA.Fill(myDataSet, "Table")
                'dgw.DataSource = myDataSet.Tables("Result").DefaultView

                xConn.Close() 'safely close it
                MsgBox("I got it " & myDataSet.Tables(0).Rows(0).ItemArray(1).ToString)
            End Using
        Catch ex As Exception
            MsgBox("Database access problem, connect and try again" & vbCrLf & ex.Message)
            'MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub ButtonExportToExcel_Click(sender As Object, e As EventArgs) Handles ButtonExportToExcel.Click
        ButtonExportToExcel.Enabled = False
        ButtonProcessBroadsheet.Enabled = False

        TimerBS.Enabled = True
        TimerBS.Start()


        'get broadsheetDatta from result and students table


        If MessageBox.Show("Are you sure you want to expoer to excel? Click yes to use Exce, Click No to create file without launching Excel", "Export", MessageBoxButtons.YesNoCancel) = MsgBoxResult.Yes Then
            bgwExportToExcel.RunWorkerAsync(1)  'runs  objBroadsheet.updateExcelBroadSheetInterop(My.Application.Info.DirectoryPath & "\templates\broadsheet - Copy3.xlsm", DataGridViewBroadSheet.DataSource)

        Else
            bgwExportToExcel.RunWorkerAsync(2)
        End If

    End Sub

    Private Sub ProgressBarBS_Click(sender As Object, e As EventArgs) Handles ProgressBarBS.Click

    End Sub

    Private Sub ButtonDownload_Click(sender As Object, e As EventArgs) Handles ButtonDownload.Click
        Try

            'objResult.resultTemplateFileName
            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                My.Computer.FileSystem.CopyFile(TextBoxTemplateFileName.Text, SaveFileDialog1.FileName & ".xlmx")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ComboBoxDepartments_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxDepartments.SelectedIndexChanged
        ' On Error Resume Next 'TextBoxDepartment.Text = ComboBoxDepartments.Items(ComboBoxDepartments.SelectedIndex).ToString()
        Try
            TextBoxDepartment.Text = ComboBoxDepartments.SelectedItem.ToString 'its a data view

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ComboBoxLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxLevel.SelectedIndexChanged
        Try
            TextBoxLevel.Text = ComboBoxLevel.Items(ComboBoxLevel.SelectedIndex).ToString()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ComboBoxSessions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSessions.SelectedIndexChanged
        Try
            TextBoxSession.Text = ComboBoxSessions.SelectedItem.ToString

        Catch ex As Exception

        End Try
    End Sub

    Private Sub bgwLoad_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgwLoad.DoWork
        dictDepts = combolistDict(STR_SQL_ALL_DEPARTMENTS_COMBO, "dept_id", "dept_name")

        dictSessions = combolistDict(STR_SQL_ALL_SESSIONS_COMBO, "session_id", "session_id")


    End Sub

    Private Sub bgwLoad_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgwLoad.RunWorkerCompleted
        'for dictonaries

        ComboBoxDepartments.Items.Clear()
        For Each key In dictDepts.Keys
            ComboBoxDepartments.Items.Add(dictDepts(key))
        Next
        TextBoxDepartment.Text = ComboBoxDepartments.Items(0).ToString


        ComboBoxSessions.Items.Clear()
        For Each key In dictSessions.Keys
            ComboBoxSessions.Items.Add(dictSessions(key))
        Next
        TextBoxSession.Text = ComboBoxSessions.Items(0).ToString
    End Sub

    Private Sub ButtonClosePanelMenu_Click(sender As Object, e As EventArgs) Handles ButtonClosePanelMenu.Click
        PanelMenu.Visible = False

    End Sub

    Private Sub ButtonProcessExcelInteropPlain_Click(sender As Object, e As EventArgs) Handles ButtonProcessExcelInteropPlain.Click

        ButtonProcessBroadsheet.Enabled = False
        TimerBS.Enabled = True
        TimerBS.Start()
        objBroadsheet.broadsheetFileName = My.Application.Info.DirectoryPath & "\templates\broadsheet.xltx"
        objBroadsheet.broadsheetSemester = 2

        'get broadsheetDatta from result and students table
        course_dept_idr = 1 '  ComboBoxDepartments.SelectedIndex + 1
        session_idr = TextBoxSession.Text 'ComboBoxSessions.SelectedItem.ToString
        course_level = TextBoxLevel.Text '.SelectedItem.ToString  'not databound

        ' objBroadsheet.broadsheetDataDS = objBroadsheet.createBroadsheetData(course_dept_idr.ToString, session_idr, course_level)
        'objBroadsheet.broadsheetDataDS = objBroadsheet.createBroadsheetData(1.ToString, "2018/2019", 100.ToString)
        BgWProcess.RunWorkerAsync(1)  'runs objBroadsheet.broadsheetDataDS = objBroadsheet.createBroadsheetData().Tables(0).DefaultView


        ' DataGridView1.DataSource = objBroadsheet.createBroadsheetData().Tables(0).DefaultView

        'add formula
        'Dim fsFml, ssFml As String
        'Dim fml As String()
        'fml = objBroadsheet.generateFormulaCO()
        'fsFml = fml(0)
        'ssFml = fml(1)
        'objExcelFile.excelFileName = PROG_DIRECTORY & "\templates\broadsheet.xltx"
        '##-----METHOD One Interop
        'processBroadsheetExcelInteropMethod()

        'objExcelFile.excelFileName = PROG_DIRECTORY & "\samples\broadsheet.xlsx"
        '##-----Method TWO - file


        'DataGridViewBroadSheet.DataSource = objExcelFile.processBroadsheetFileMethod().Tables(0).DefaultView
        'DataGridViewBroadSheet.Refresh()
        ' MsgBox("done updating")

    End Sub

    Private Sub ButtonprocessExceFilePlain_Click(sender As Object, e As EventArgs) Handles ButtonprocessExceFilePlain.Click
        ButtonProcessBroadsheet.Enabled = False
        TimerBS.Enabled = True
        TimerBS.Start()
        objBroadsheet.broadsheetFileName = My.Application.Info.DirectoryPath & "\templates\broadsheet.xltx"
        objBroadsheet.broadsheetSemester = 2
        'get broadsheetDatta from result and students table
        course_dept_idr = 1 '  ComboBoxDepartments.SelectedIndex + 1
        session_idr = TextBoxSession.Text 'ComboBoxSessions.SelectedItem.ToString
        course_level = TextBoxLevel.Text '.SelectedItem.ToString  'not databound
        BgWProcess.RunWorkerAsync(2)  'runs objBroadsheet.broadsheetDataDS = excelFile
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub FormGenerateBroadsheet_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MainForm.doCloseForm()
    End Sub
End Class

