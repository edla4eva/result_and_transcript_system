Imports System.ComponentModel

Public Class FormGenerateBroadsheet
    Dim course_dept_idr As Integer = 1 '
    Dim session_idr As String = "2018/2019"
    Dim course_level = "300"

    Dim footers(3) As String
    Dim retFileName As String = ""

    Dim dtScores, dtGrades As DataTable
    Dim dvScores, dvGrades As DataView

    'Dim dictDepts As New Dictionary(Of String, String)
    'Dim dictCourses As New Dictionary(Of String, String)
    'Dim dictAllCourses As New Dictionary(Of String, String)
    'Dim dictSessions As New Dictionary(Of String, String)

    Private Sub TextBoxDepartment_TextChanged(sender As Object, e As EventArgs) Handles TextBoxDepartment.TextChanged

    End Sub

    Private Sub FormGenerateBroadsheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = RGBColors.colorBlack2
        Me.DataGridViewBroadSheet.BackgroundColor = RGBColors.colorBlack2
        Me.DataGridViewBroadSheet.RowsDefaultCellStyle.BackColor = RGBColors.colorSilver
        Me.DataGridViewBroadSheet.RowsDefaultCellStyle.ForeColor = RGBColors.colorBlack
        Me.DataGridViewTemp.BackgroundColor = RGBColors.colorBlack2
        Me.DataGridViewTemp.RowsDefaultCellStyle.BackColor = RGBColors.colorSilver
        Me.DataGridViewTemp.RowsDefaultCellStyle.ForeColor = RGBColors.colorBlack
    End Sub

    Private Sub ButtonProcessBroadsheet_Click(sender As Object, e As EventArgs) Handles ButtonProcessBroadsheet.Click
        ButtonProcessBroadsheet.Enabled = False
        TimerBS.Enabled = True
        TimerBS.Start()
        course_dept_idr = mappDB.getDeptID(TextBoxDepartment.Text)
        session_idr = TextBoxSession.Text 'ComboBoxSessions.SelectedItem.ToString
        course_level = TextBoxLevel.Text '.SelectedItem.ToString  'not databound
        objBroadsheet.broadsheetSemester = 1
        objBroadsheet.departmentName = TextBoxDepartment.Text
        objBroadsheet.facultyName = "Faculty of Engineering"
        objBroadsheet.SchoolName = "University of Benin"
        objBroadsheet.DeptId = course_dept_idr
        objBroadsheet.HOD = TextBoxHOD.Text
        objBroadsheet.CourseAdviser = TextBoxCourseAdviser.Text
        objBroadsheet.Dean = TextBoxDean.Text

        If RadioButtonUseBuiltIn.Checked = True Then
            objBroadsheet.broadsheetFileName = My.Application.Info.DirectoryPath & "\templates\broadsheet.xltx"
            'get broadsheetDatta from result and students table
            BgWProcess.RunWorkerAsync(2)  'runs objBroadsheet.broadsheetDataDS = excelFile
        ElseIf RadioButtonUseExcel.Checked = True Then
            objBroadsheet.broadsheetFileName = My.Application.Info.DirectoryPath & "\templates\broadsheet.xlsm"
            'get broadsheetDatta from result and students table
            BgWProcess.RunWorkerAsync(1)  'runs objBroadsheet.broadsheetDataDS = objBroadsheet.createBroadsheetData().Tables(0).DefaultView
        ElseIf RadioButtonUseBuiltInFormula.Checked = True Then
            objBroadsheet.broadsheetFileName = My.Application.Info.DirectoryPath & "\templates\broadsheet.xltx"
            'get broadsheetDatta from result and students table
            BgWProcess.RunWorkerAsync(2)  'runs objBroadsheet.broadsheetDataDS = excelFile
        Else

        End If
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
    Public Sub createBroadsheetTables()
        Dim strSQL As String
        strSQL = "Create Table Broadsheet500 ("
        For i = 0 To LAST_COL + 5 'broadshetCols+ headings(comma seperated), session, dept, level,CA,HOD,Dean,Summary1(comma seperated)
            If i = 6 Or i = 81 Then
                strSQL += "[" & "Col" & i.ToString & "] " & "varchar(500)" & ","    'repeated courses
            Else
                strSQL += "[" & "Col" & i.ToString & "] " & "varchar(50)" & ","
            End If

        Next
        strSQL += "[" & "ColNames" & "] " & "varchar(200)" & ")"
        mappDB.doQuery(strSQL)
        Debug.Print("")
        ''#FirstTime--delete tmpBroadsheet table
        'strSQL = "DROP Table tmpBroadsheet"
        'mappDB.doQuery(strSQL)
        ''Create table on the fly
        ''create the table
        'strSQL = "Create Table tmpBroadsheet ("
        'For i = 0 To dtSource.Columns.Count - 1
        '    strSQL += "[" & "Col" & i.ToString & "] " & "nvarchar(50)" & ","
        'Next
        'strSQL += "[" & "ColNames" & "] " & "nvarchar(200)" & ")"
        ''For Each column As DataColumn In dtSource.Columns
        ''    strSQL += "[" & column.ColumnName & "] " & "nvarchar(50)" & ","
        ''Next
        ''strSQL = strSQL.TrimEnd(New Char() {","c}) & ")"
        'mappDB.bulkInsertDB(dtDestination, strSQL, "tmpBroadsheet")

        '#Subsequently---'Save to database
        '
    End Sub

    Private Sub ButtonSaveBroadsheet_Click(sender As Object, e As EventArgs) Handles ButtonSaveBroadsheet.Click
        Dim strSQL As String
        Dim dv As DataView = DataGridViewBroadSheet.DataSource
        Dim dtSource As DataTable
        Dim dtDestination As New DataTable
        Dim dSFtomDB As New DataSet ' = dv.ToTable
        dtSource = dv.ToTable

        'createBroadsheetTables()
        strSQL = "SELECT * FROM Broadsheets_all" ' WHERE session_idr={1}"

        Using xconn As New OleDb.OleDbConnection(ModuleGeneral.STR_connectionString32)
            Try
                xconn.Open()
            Catch ex1 As Exception
                xconn.ConnectionString = ModuleGeneral.STR_connectionString32
                xconn.Open()
            End Try
            Dim adapter As New OleDb.OleDbDataAdapter(strSQL, xconn)
            'Dim insert As OleDb.OleDbCommand("INSERT INTO Broadsheet (matno) VALUES (@matno)", xconn)
            Dim builder As New OleDb.OleDbCommandBuilder(adapter)       'easy way for single table
            'Dim titleParam As New OleDb.OleDbParameter("@matno", Str)
            'cmd.Parameters.Add(titleParam)
            'adapter.InsertCommand = insert

            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey

            'fill it
            adapter.Fill(dSFtomDB)
            'put it in a datagrid view and all the manipulations can happen there, afterwards an update is used to save in database
            DataGridViewTemp.DataSource = dSFtomDB.Tables(0).DefaultView
            'MsgBox("After fresh fill")
            'edit it
            dSFtomDB.Tables(0).Clear()
            adapter.Update(dSFtomDB)
            Dim dRow As DataRow
            Dim strColNames As String = ""
            Dim nExtraCols As Integer = 1
            'MsgBox("After empty db")
            'Note col85 and Col6 are for repeated courses hence Text datatype
            For i = 0 To dtSource.Rows.Count - 1
                dRow = dSFtomDB.Tables(0).Rows.Add("MOCK00" & i.ToString) 'add mock row
                For j = 0 To dSFtomDB.Tables(0).Columns.Count - 1 - nExtraCols      'Take as much as we have cols for to avoid errors
                    If j > dtSource.Rows.Count - 1 Then Exit For
                    dSFtomDB.Tables(0).Rows(i).Item(j) = dtSource.Rows(i).Item(j)   'update the row with data
                    strColNames = strColNames & "," & dtSource.Columns(j).ColumnName
                Next
                dRow.Item("ColNames") = strColNames
            Next

            DataGridViewTemp.DataSource = dSFtomDB.Tables(0).DefaultView

            'MsgBox("After add to datatable")
            DataGridViewTemp.Refresh()
            DataGridViewTemp.EndEdit()
            ' MsgBox("After refresh")
            'save
            adapter.Update(dSFtomDB)
        End Using

    End Sub
    Sub saveData()

    End Sub
    Private Sub SelectBroadsheetTemplate_Click(sender As Object, e As EventArgs)
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

    Private Sub ButtonGrades_Click(sender As Object, e As EventArgs) Handles ButtonGrades.Click
        dvScores = DataGridViewBroadSheet.DataSource
        dtScores = dvScores.ToTable
        dtGrades = objBroadsheet.createBroadsheetGrades(dtScores)   'TODO: Fix
        dvGrades = dtGrades.DefaultView    'TODO: Fix
        DataGridViewBroadSheet.DataSource = dtGrades.DefaultView    'TODO: Fix
        'DataGridViewBroadSheet.AllowUserToAddRows = True
        'DataGridViewBroadSheet.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken
    End Sub


    Function getCoursesList() As String()
        Dim str As New List(Of String)
        str.Add("PRE571")
        str.Add("CPE571")
        str.Add("CPE591")

        Return str.ToArray
    End Function

    Private Sub Label7_Click(sender As Object, e As EventArgs)
        PanelModify.Visible = False
    End Sub



    Private Sub FormGenerateBroadsheet_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        On Error Resume Next
        'Me.TextBoxTemplateFileName.Text = My.Application.Info.DirectoryPath & "\templates\broadsheet.xltx"
        Me.ButtonProcessBroadsheet.Enabled = False
        Me.ButtonExportToExcel.Enabled = False
        Me.ButtonExportPDF.Enabled = False
        bgwLoad.RunWorkerAsync()
    End Sub

    Private Sub TimerBS_Tick(sender As Object, e As EventArgs) Handles TimerBS.Tick
        If objBroadsheet.progress <= 100 Then ProgressBarBS.Value = CInt(objBroadsheet.progress)
        Me.LabelProgress.Text = (objBroadsheet.progress).ToString & "% - " & objBroadsheet.progressStr
    End Sub

    Private Sub BgWProcess_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BgWProcess.DoWork
        Select Case CInt(e.Argument)
            Case 1 'interop
                objBroadsheet.broadsheetDataDS = objBroadsheet.createBroadsheetData(course_dept_idr.ToString, session_idr, course_level, True)
        'objBroadsheet.broadsheetDataDS = objBroadsheet.createBroadsheetData(1.ToString, "2018/2019", 100.ToString)

            Case 2  'use formula
                objBroadsheet.broadsheetDataDS = objBroadsheet.createBroadsheetData(course_dept_idr.ToString, session_idr, course_level, False)

            Case Else

        End Select
    End Sub

    Private Sub BgWProcess_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BgWProcess.RunWorkerCompleted
        Try
            DataGridViewBroadSheet.DataSource = objBroadsheet.broadsheetDataDS.Tables(0).DefaultView
            dvScores = objBroadsheet.broadsheetDataDS.Tables(0).DefaultView
            dtScores = dvScores.ToTable
            'HIDE UNECESSARY COLS
            For Each col In DataGridViewBroadSheet.Columns
                If col.name.contains("ColUNIQUE") Then col.visible = False
                If col.name.contains("Repeat") Then col.width = 120
                If dictAllCourseCodeKeyAndCourseLevelVal.ContainsKey(col.name) Then
                    If Not dictAllCourseCodeKeyAndCourseLevelVal(col.name) = objBroadsheet.Level Then
                        col.visible = False
                    Else
                        col.width = 65
                    End If
                End If
            Next
            DataGridViewBroadSheet.Columns(0).Width = 25   's/N
            DataGridViewBroadSheet.Columns(1).Width = 100   'Mat
            DataGridViewBroadSheet.Columns(2).Width = 150   'Name
            DataGridViewBroadSheet.Columns(3).Visible = False   'hide
            DataGridViewBroadSheet.Columns(4).Visible = False   'hide
            DataGridViewBroadSheet.Columns(5).Visible = False   'hide
            If RadioButtonScores.Checked = True Then

            Else
                Me.ButtonGrades.PerformClick()
            End If

            If CheckBoxFirsrSemester.Checked = False Then
                'hide em
            ElseIf CheckBoxSecondSemester.Checked = False Then
                'Hide em
            End If

            TextBoxTemplateFileName.Text = retFileName
            Me.ProgressBarBS.Value = 100
            TimerBS.Stop()
            ButtonProcessBroadsheet.Enabled = True
            Me.ProgressBarBS.Value = 100
        Catch ex As Exception
            MsgBox("An error occured during the creation of the broadsheet" & vbCrLf & vbCrLf & ex.Message)
        End Try


    End Sub

    Private Sub bgwExportToExcel_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwExportToExcel.DoWork
        'TODO: create UI to configure order
        footers(0) = TextBoxCourseAdviser.Text
        footers(1) = TextBoxDean.Text
        footers(2) = TextBoxHOD.Text
        Select Case CInt(e.Argument)
            Case 1
                'interop
                objBroadsheet.updateExcelBroadSheetInterop(DataGridViewBroadSheet.DataSource, My.Application.Info.DirectoryPath & "\templates\broadsheet - Copy3.xlsm", My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData & "\GeneratedResultBroadsheet" & TextBoxLevel.Text & ".xlsm")

            Case 2
                'objExcelFile.modifyExcelFile_NPOI(My.Application.Info.DirectoryPath & "\templates\broadsheet_plain.xlsx", DataGridViewBroadSheet.DataSource) 'worked but NPOI corrupted excel fileobjExcelFile.
                retFileName = objExcelFile.exportBroadsheettoExcelFile_NPOI(dvScores, My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData & "\GeneratedResultBroadsheet" & TextBoxLevel.Text & ".xlsx", objBroadsheet, dictAllCourseCodeKeyAndCourseUnitVal, footers, False)
            Case -2     'grades
                retFileName = objExcelFile.exportBroadsheettoExcelFile_NPOI(dvScores, My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData & "\GeneratedResultBroadsheet" & TextBoxLevel.Text & ".xlsx", objBroadsheet, dictAllCourseCodeKeyAndCourseUnitVal, footers, True, dvGrades)



            Case Else

        End Select
        'objExcelFile.createExcelFile_NPOI(My.Application.Info.DirectoryPath & "\samples\generated_broadsheet.xlsx") 'worked
    End Sub
    Private Sub bgwExportToExcel_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgwExportToExcel.RunWorkerCompleted
        If DataGridViewBroadSheet.DataSource Is Nothing Then Exit Sub
        'copy the file
        'TODO: access denied
        'My.Computer.FileSystem.CopyFile(My.Application.Info.DirectoryPath & "\templates\broadsheet - Copy3.xlsm", My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\GeneratedResultBroadsheet" & TextBoxLevel.Text & ".xlsm", True)
        'replace template with fresh copy

        MsgBox("Done: GeneratedResultBroadsheet - " & retFileName)
        Me.TextBoxTemplateFileName.Text = retFileName
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
        If MessageBox.Show("Are you sure you want to export to excel?", "Export", MessageBoxButtons.YesNoCancel) = MsgBoxResult.Yes Then
        Else
            Exit Sub
        End If
        If DataGridViewBroadSheet.DataSource Is Nothing Then Exit Sub

        ButtonExportToExcel.Enabled = False
        ButtonProcessBroadsheet.Enabled = False

        TimerBS.Enabled = True
        TimerBS.Start()


        'get broadsheetDatta from result and students table

        If Me.RadioButtonUseBuiltIn.Checked = True Or RadioButtonUseBuiltInFormula.Checked = True Then
            objBroadsheet.processedBroadsheetFileName = My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData & "\GeneratedResultBroadsheet" & TextBoxLevel.Text & ".xlsx"
            If RadioButtonScores.Checked = True Then
                bgwExportToExcel.RunWorkerAsync(2)
            Else
                If CheckBoxFirsrSemester.Checked = False Then
                    'hide em
                ElseIf CheckBoxSecondSemester.Checked = False Then
                    'Hide em
                End If
                If dvGrades Is Nothing Then ButtonGrades.PerformClick() Else 'todo: call function computeGrades
                bgwExportToExcel.RunWorkerAsync(-2)
            End If


        ElseIf Me.RadioButtonUseExcel.Checked = True Or Me.RadioButtonUseExcelWithFormula.Checked = True Then
            objBroadsheet.processedBroadsheetFileName = My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData & "\GeneratedResultBroadsheet" & TextBoxLevel.Text & ".xlsm"

            bgwExportToExcel.RunWorkerAsync(1)  'runs  objBroadsheet.updateExcelBroadSheetInterop(My.Application.Info.DirectoryPath & "\templates\broadsheet - Copy3.xlsm", DataGridViewBroadSheet.DataSource)
        End If


    End Sub

    Private Sub ProgressBarBS_Click(sender As Object, e As EventArgs) Handles ProgressBarBS.Click

    End Sub

    Private Sub ButtonDownload_Click(sender As Object, e As EventArgs) Handles ButtonDownload.Click
        Try

            'objResult.resultTemplateFileName
            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                My.Computer.FileSystem.CopyFile(TextBoxTemplateFileName.Text, SaveFileDialog1.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ComboBoxDepartments_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxDepartments.SelectedIndexChanged
        ' On Error Resume Next 'TextBoxDepartment.Text = ComboBoxDepartments.Items(ComboBoxDepartments.SelectedIndex).ToString()
        Try

            course_dept_idr = mappDB.getDeptID(ComboBoxDepartments.SelectedItem.ToString)
            TextBoxDepartment.Text = ComboBoxDepartments.SelectedItem.ToString 'its a data view
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ComboBoxLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxLevel.SelectedIndexChanged
        Try
            TextBoxLevel.Text = ComboBoxLevel.Items(ComboBoxLevel.SelectedIndex).ToString()

            ' bgwCourses.RunWorkerAsync()

            dictCourses = combolistDict(String.Format(STR_SQL_ALL_COURSES_ORDER, session_idr, course_dept_idr), "FS" & TextBoxLevel.Text & "L", "FS" & TextBoxLevel.Text & "L")

            dictCoursesOrderFS = combolistDict(String.Format(STR_SQL_ALL_COURSES_ORDER, session_idr, course_dept_idr), "FS" & TextBoxLevel.Text & "L", "FS" & TextBoxLevel.Text & "L")
            dictCoursesOrderSS = combolistDict(String.Format(STR_SQL_ALL_COURSES_ORDER, session_idr, course_dept_idr), "SS" & TextBoxLevel.Text & "L", "SS" & TextBoxLevel.Text & "L")
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
        If e.Argument = "CoursesOnly" Then
            dictCourses = combolistDict(String.Format(STR_SQL_ALL_COURSES_ORDER, session_idr, course_dept_idr), "FS" & TextBoxLevel.Text & "L", "FS" & TextBoxLevel.Text & "L")
            ' dictCoursesOrderFS = combolistDict(String.Format(STR_SQL_ALL_COURSES_ORDER, session_idr, course_dept_idr), "FS" & TextBoxLevel.Text, "FS" & TextBoxLevel.Text)
            dictCoursesOrderSS = combolistDict(String.Format(STR_SQL_ALL_COURSES_ORDER, session_idr, course_dept_idr), "SS" & TextBoxLevel.Text & "L", "SS" & TextBoxLevel.Text & "L")

        Else

            dictDepts = combolistDict(STR_SQL_ALL_DEPARTMENTS_COMBO, "dept_id", "dept_name")

            dictSessions = combolistDict(STR_SQL_ALL_SESSIONS_COMBO, "session_id", "session_id")

            dictCourses = combolistDict(String.Format(STR_SQL_ALL_COURSES_ORDER, session_idr, course_dept_idr), "all_courses_1", "all_courses_1")
            'dictCoursesOrderFS = combolistDict(String.Format(STR_SQL_ALL_COURSES_ORDER, session_idr, course_dept_idr), "FS" & TextBoxLevel.Text, "FS" & TextBoxLevel.Text)
            dictCoursesOrderSS = combolistDict(String.Format(STR_SQL_ALL_COURSES_ORDER, session_idr, course_dept_idr), "SS" & TextBoxLevel.Text & "L", "SS" & TextBoxLevel.Text & "L")

            dictAllCourses = combolistDict(STR_SQL_ALL_COURSES, "course_code", "course_code")

        End If
    End Sub

    Private Sub bgwLoad_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgwLoad.RunWorkerCompleted
        Me.ButtonProcessBroadsheet.Enabled = True
        Me.ButtonExportToExcel.Enabled = True
        Me.ButtonExportPDF.Enabled = True
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



    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub FormGenerateBroadsheet_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MainForm.doCloseForm()
    End Sub



    Private Sub ButtonExportPDF_Click(sender As Object, e As EventArgs) Handles ButtonExportPDF.Click
        Dim obj As New ClassPDF
        If My.Computer.FileSystem.FileExists(objBroadsheet.processedBroadsheetFileName) Then
            obj.ExcelPDFLateBinding()
            MsgBox("Saved as PDF in: " & objBroadsheet.processedBroadsheetFileName)
        End If
    End Sub



    Private Sub ButtonAddSession_Click(sender As Object, e As EventArgs) Handles ButtonAddSession.Click
        FormAddNewStuff.ShowDialog()
        ' FormAddNewStuff.AddEm()
        'FormAddNewStuff.AddEm()

        'referesh combo
        'combolist
    End Sub

    Private Sub ButtonOpen_Click(sender As Object, e As EventArgs) Handles ButtonOpen.Click
        Try

            System.Diagnostics.Process.Start(TextBoxTemplateFileName.Text)
        Catch ex As Exception
            MsgBox("Could not open excel file" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub DataGridViewBroadSheet_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewBroadSheet.CellContentClick

    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub
    Private Sub UpgradeTo40ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpgradeTo40ToolStripMenuItem.Click
        If DataGridViewBroadSheet.CurrentCell.ColumnIndex >= 7 Then
            DataGridViewBroadSheet.CurrentCell().Value = 40

            'effect change in audit dgv
            'DataGridViewBroadSheet_audit.rows(currentcell.rowindex).cell(currentcekk.columnindex).value = "Ugraded from x to 40 by CA"
        End If
    End Sub
    Private Sub ApplyChangeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApplyChangeToolStripMenuItem.Click

        DataGridViewBroadSheet.CurrentCell().Value = ToolStripTextBox1.Text
        'log it

        'effect change in audit dgv
        'DataGridViewBroadSheet_audit.rows(currentcell.rowindex).cell(currentcekk.columnindex).value = "Ugraded from x to 40 by CA"

    End Sub

    Private Sub UpgradeWith2MarksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpgradeWith2MarksToolStripMenuItem.Click
        If DataGridViewBroadSheet.CurrentCell.ColumnIndex >= 7 Then
            DataGridViewBroadSheet.CurrentCell().Value = DataGridViewBroadSheet.CurrentCell().Value + 2

            'effect change in audit dgv
            'DataGridViewBroadSheet_audit.rows(currentcell.rowindex).cell(currentcekk.columnindex).value = "Ugraded from x to 40 by CA"
        End If
    End Sub

    Private Sub UpgradeWith1MarkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpgradeWith1MarkToolStripMenuItem.Click
        Dim rI, cI As Integer
        Dim cellVal As Integer = 0
        cellVal = CInt(DataGridViewBroadSheet.CurrentCell().Value)
        rI = DataGridViewBroadSheet.CurrentCell().RowIndex
        cI = DataGridViewBroadSheet.CurrentCell().ColumnIndex
        If DataGridViewBroadSheet.CurrentCell.ColumnIndex >= 7 Then
            DataGridViewBroadSheet.CurrentCell().Value = +2

            'effect change in audit dgv
            'DataGridViewBroadsheetAudit.Rows(rI).Cells(cI).Value = "Ugraded from " & cellVal & " to 40 by " & mappDB.UserName
        End If
    End Sub
End Class

