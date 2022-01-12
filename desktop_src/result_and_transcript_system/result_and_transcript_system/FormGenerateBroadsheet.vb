Imports System.ComponentModel

Public Class FormGenerateBroadsheet
    Dim course_dept_idr As Integer = 1 '
    Dim session_idr As String = "2018/2019"
    Dim course_level = "300"

    Dim strRegisteredStudents As String() = {}
    Dim strParamsSessionDeptLevel As String()

    Dim footers(3) As String
    Dim retFileName As String = ""

    Dim dtScores, dtGrades As DataTable
    Dim dvScores, dvGrades As DataView

    'Dim dictDepts As New Dictionary(Of String, String)
    'Dim dictCourses As New Dictionary(Of String, String)
    'Dim dictAllCourses As New Dictionary(Of String, String)
    'Dim dictSessions As New Dictionary(Of String, String)


    Private Sub FormGenerateBroadsheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        Me.BackColor = RGBColors.colorBackground
        Me.DataGridViewBroadSheet.BackgroundColor = RGBColors.colorBackground
        Me.DataGridViewBroadSheet.RowsDefaultCellStyle.BackColor = RGBColors.colorForeground
        Me.DataGridViewBroadSheet.RowsDefaultCellStyle.ForeColor = RGBColors.colorBackground
        Me.DataGridViewTemp.BackgroundColor = RGBColors.colorBackground
        Me.DataGridViewTemp.RowsDefaultCellStyle.BackColor = RGBColors.colorForeground
        Me.DataGridViewTemp.RowsDefaultCellStyle.ForeColor = RGBColors.colorBackground
    End Sub

    Private Sub ButtonProcessBroadsheet_Click(sender As Object, e As EventArgs) Handles ButtonProcessBroadsheet.Click
        Try
            If MsgBox("Are you sure you wat to generate brodsheet data? Existing data will be deleted." & vbCrLf & "Note that approved broadsheets can not be changed", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                Exit Sub
            End If

            footers(0) = TextBoxCourseAdviser.Text
            footers(1) = TextBoxDean.Text
            footers(2) = TextBoxHOD.Text

            ButtonProcessBroadsheet.Enabled = False
            TimerBS.Enabled = True
            TimerBS.Start()
            'session_idr = TextBoxSession.Text 'ComboBoxSessions.SelectedItem.ToString
            'course_level = dLevel '.SelectedItem.ToString  'not databound
            'course_dept_idr = mappDB.getDeptID(TextBoxDepartment.Text)
            objBroadsheet.DeptId = course_dept_idr
            objBroadsheet.Level = course_level
            objBroadsheet.Session = session_idr

            If CheckBoxSecondSemester.Checked Then
                objBroadsheet.broadsheetSemester = 2
            Else
                objBroadsheet.broadsheetSemester = 1
            End If
            objBroadsheet.DepartmentName = mappDB.getDeptName(course_dept_idr)
            objBroadsheet.FacultyName = "Faculty of Engineering"    'TODO: remove hard code
            objBroadsheet.SchoolName = "University of Benin"

            objBroadsheet.HOD = TextBoxHOD.Text
            objBroadsheet.CourseAdviser = TextBoxCourseAdviser.Text
            objBroadsheet.Dean = TextBoxDean.Text
            'objBroadsheet.levelCGPaPercentages = ""   'todo get from settings
            '_levelCGPAPercentages(0) = 0.05
            '_levelCGPAPercentages(1) = 0.1
            '_levelCGPAPercentages(2) = 0.15
            '_levelCGPAPercentages(3) = 0.2
            '_levelCGPAPercentages(4) = 0.5
            '_levelCGPAPercentages(5) = 0
            '_levelCGPAPercentages(6) = 0
            '_levelCGPAPercentages(7) = 0
            '_levelCGPAPercentages(8) = 0
            'objBroadsheet.levelCGPaPercentagesUME
            'objBroadsheet.levelCGPaPercentagesDE2
            'objBroadsheet.levelCGPaPercentagesDE3
            'objBroadsheet.levelCGPaPercentagesDIP

            If RadioButtonUseBuiltIn.Checked = True Then
                objBroadsheet.broadsheetFileName = My.Application.Info.DirectoryPath & "\templates\broadsheet.xltx"
                'get broadsheetDatta from result and students table
                BgWProcess.RunWorkerAsync(BGW_PROCESS_BUILTIN_NPOI_LEVEL)  'runs objBroadsheet.broadsheetDataDS = excelFile
            ElseIf RadioButtonUseExcel.Checked = True Then
                objBroadsheet.broadsheetFileName = My.Application.Info.DirectoryPath & "\templates\broadsheet.xlsm"
                'get broadsheetDatta from result and students table
                BgWProcess.RunWorkerAsync(BGW_PROCESS_INTERROP_YR_SCORES)  'runs objBroadsheet.broadsheetDataDS = objBroadsheet.createBroadsheetData().Tables(0).DefaultView
            ElseIf RadioButtonUseBuiltInFormula.Checked = True Then
                objBroadsheet.broadsheetFileName = My.Application.Info.DirectoryPath & "\templates\broadsheet.xltx"
                'get broadsheetDatta from result and students table
                BgWProcess.RunWorkerAsync(BGW_PROCESS_BUILTIN_NPOI_LEVEL)  'runs objBroadsheet.broadsheetDataDS = excelFile
            Else

            End If
        Catch ex As Exception
            MsgBox("Broadsheet process failed due to an error, see log for details")
            ButtonProcessBroadsheet.Enabled = True
            logError(ex.ToString)
        End Try
    End Sub
    Private Sub processBroadsheetExcelInteropMethod()   'todo: orphaned sub
        Dim tmpDS As DataSet
        Dim tmpDV As DataView
        Dim dSession As String = "2018/2019"
        Dim dLevel As Integer = 300
        Dim dCourseCode As String = "CPE375"
        Dim strapprovedCourses As String
        Dim arrayapprovedCourses() As String
        Try
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
            objBroadsheet.updateExcelBroadSheetInterop(tmpDV, objBroadsheet.broadsheetFileName, My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData & "\GeneratedResultBroadsheet" & dLevel & ".xlsm")


            ' objBroadsheet.updateExcelBroadSheetInterop(objBroadsheet.broadsheetFileName, tmpDV)
            'end if
        Catch ex As Exception
            MsgBox("Error occured, see log for details" & vbCrLf & ex.Message)
            logError(ex.ToString)
        End Try
    End Sub
    Function tableExists() As Boolean
        'Return Len(dbName.tabledefs(dName).name)
        Return False
    End Function
    Public Function getBroadheetTableName(dSession As String, dDeptID As String, dLevel As String) As String
        Return String.Format("Broadsheet_all_{0}_{1}_{2}", dSession.Replace("/", "x"), dDeptID, dLevel)
    End Function

    Public Sub createBroadsheetTables(dSession As String, dDeptID As String, dLevel As String)
        Dim strSQL As String
        Dim tblName As String = getBroadheetTableName(dSession, dDeptID, dLevel)
        'tblName = "broadsheets_all" 'todo: remove
        'If Not tableexists(tblName) Then
        Try
            'check if table exists or blindly delete table
            Try
                'strSQL = String.Format("SELECT sn FROM {0} WHERE sn='0'", tblName)
                'If mappDB.GetDataWhere(strSQL) Is Nothing Then 'getBroadheetTableName'.Tables(0).Columns.Count > 0 Then
                mappDB.doQuery(String.Format("DROP Table {0}", tblName))
                'End If
            Catch ex As Exception

            End Try
            strSQL = "Create Table " & tblName & "( "
            For i = 0 To DataGridViewBroadSheet.Columns.Count - 1
                If i = REPEATED_1_COL Or i = REPEATED_1_COL Or i = REPEATED_ALL_COL Or i = COURSE_FAIL_COL Then
                    strSQL += "[" & DataGridViewBroadSheet.Columns(i).Name & "] " & "longtext" & ","    'repeated courses
                ElseIf (i >= COURSE_START_COL And i <= COURSE_END_COL) Or (i >= COURSE_START_COL_2 And i <= LAST_COL) Then
                    strSQL += "[" & DataGridViewBroadSheet.Columns(i).Name & "] " & "varchar(50)" & ","
                    'strSQL += "[" & "ColUNIQUE" & i.ToString & "] " & "varchar(50)" & ","
                ElseIf i = DataGridViewBroadSheet.Columns.Count - 1 Then
                    strSQL += "[" & DataGridViewBroadSheet.Columns(i).Name & "] " & "varchar(100))"
                Else
                    strSQL += "[" & DataGridViewBroadSheet.Columns(i).Name & "] " & "longtext" & ","    'todo:wasteful
                End If
            Next
            If mappDB.doQuery(strSQL) Then
                MsgBox("Broadsheet data has been created and auto-saved")

            Else
                MsgBox("Could create table to save generated broadsheet data")
            End If
        Catch ex As Exception
            MsgBox("Error occured, see log For details" & vbCrLf & ex.Message)
            logError(ex.ToString)
        End Try
    End Sub

    Private Sub ButtonSaveBroadsheet_Click(sender As Object, e As EventArgs) Handles ButtonSaveBroadsheet.Click
        Try
            Dim strSQL As String = "SELECT * FROM broadsheets_all_Colnames_tablenames"
            Dim dv As DataView = DataGridViewBroadSheet.DataSource
            Dim dtSource As DataTable
            Dim dtDestination As New DataTable
            dtSource = dv.ToTable

            Dim lv, ss, dept As String
            Dim dtColNames As DataTable
            If DataGridViewBroadSheet.Rows.Count > 0 Then
                'todo validate
                lv = DataGridViewBroadSheet.Rows(0).Cells("bs_level").Value.ToString
                dept = DataGridViewBroadSheet.Rows(0).Cells("dept_idr").Value.ToString
                ss = DataGridViewBroadSheet.Rows(0).Cells("bs_session").Value.ToString
                dtDestination = mappDB.bulkInsertDBUsingDataAdapter(dtSource, getBroadheetTableName(ss, dept, lv))
                'now add colnames to seperate table
                dtColNames = mappDB.GetDataWhere(strSQL).Tables(0)
                dtColNames.Rows.Clear()
                dtColNames.Rows.Add({"mock"})
                For j = 0 To dtSource.Columns.Count - 1
                    If j > dtColNames.Columns.Count - 1 Then Exit For
                    dtColNames.Rows(0).Item(j) = dtSource.Columns(j).ColumnName
                Next
                mappDB.genericManualInsertDTtoDB(dtColNames, "broadsheets_all_Colnames_tablenames", LEVEL_COL)

                DataGridViewTemp.DataSource = dtSource.DefaultView
                'transction?
            End If

            'HIDE UNECESSARY COLS
            For Each col In DataGridViewTemp.Columns
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
            DataGridViewTemp.Columns(0).Width = 25   's/N
            DataGridViewTemp.Columns(1).Width = 100   'Mat
            DataGridViewTemp.Columns(2).Width = 150   'Name
            DataGridViewTemp.Columns(3).Visible = False   'hide
            DataGridViewTemp.Columns(4).Visible = False   'hide
            DataGridViewTemp.Columns(5).Visible = False   'hide
            DataGridViewTemp.Columns(0).Frozen = True
            DataGridViewTemp.Columns(1).Frozen = True

            DataGridViewTemp.Refresh()
            DataGridViewTemp.EndEdit()
        Catch ex As Exception
            MsgBox("Error occured, see log for details" & vbCrLf & ex.Message)
            logError(ex.ToString)
        End Try
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
        If RadioButtonScores.Checked = True Then RadioButtonScores.Checked = False Else RadioButtonScores.Checked = True
    End Sub

    Sub showGrades()
        Try

            'dvScores = DataGridViewBroadSheet.DataSource
            'dtScores = dvScores.ToTable
            'dtGrades = objBroadsheet.createBroadsheetGrades(dtScores)   'TODO: Fix
            'dvGrades = dtGrades.DefaultView    'TODO: Fix
            dtGrades = objBroadsheet.dataTablesScoresAndGrades(1)
            If dtGrades Is Nothing Then Exit Sub
            dvGrades = dtGrades.DefaultView
            DataGridViewBroadSheet.DataSource = dtGrades.DefaultView    'TODO: Fix
            'DataGridViewBroadSheet.AllowUserToAddRows = True
            'DataGridViewBroadSheet.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken
        Catch ex As Exception
            MsgBox("Broadsheet scores have to be generated first before grades")
            logError(ex.ToString)
        End Try
    End Sub
    Sub showScores()
        Try

            'dvScores = DataGridViewBroadSheet.DataSource
            'dtScores = dvScores.ToTable
            'dtGrades = objBroadsheet.createBroadsheetGrades(dtScores)   'TODO: Fix
            'dvGrades = dtGrades.DefaultView    'TODO: Fix
            dtScores = objBroadsheet.dataTablesScoresAndGrades(0)
            If dtScores Is Nothing Then Exit Sub
            dvScores = dtScores.DefaultView
            DataGridViewBroadSheet.DataSource = dtScores.DefaultView    'TODO: Fix
            'DataGridViewBroadSheet.AllowUserToAddRows = True
            'DataGridViewBroadSheet.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken
        Catch ex As Exception
            MsgBox("Broadsheet scores have to be generated first before grades")
            logError(ex.ToString)
        End Try
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
            Case BGW_PROCESS_INTERROP_YR_SCORES 'interop
                objBroadsheet.broadsheetDataDS = objBroadsheet.createBroadsheetData(course_dept_idr.ToString, session_idr, course_level, True)

            Case BGW_PROCESS_BUILTIN_NPOI_LEVEL  'use formula
                objBroadsheet.broadsheetDataDS = objBroadsheet.createBroadsheetData(course_dept_idr.ToString, session_idr, course_level, False)
            Case Else
                objBroadsheet.broadsheetDataDS = objBroadsheet.createBroadsheetData(course_dept_idr.ToString, session_idr, course_level, False)
        End Select
    End Sub

    Private Sub BgWProcess_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BgWProcess.RunWorkerCompleted
        Try
            If objBroadsheet.broadsheetDataDS.Tables(0).Columns(0).ColumnName.Contains("Error") Then
                DataGridViewBroadSheet.DataSource = objBroadsheet.broadsheetDataDS.Tables(0).DefaultView
                DataGridViewBroadSheet.Columns(0).Width = 340
                ButtonProcessBroadsheet.Enabled = True
                Exit Sub
            ElseIf objBroadsheet.broadsheetDataDS.Tables(0).Rows.Count < 1 Then
                MsgBox("No broadsheet data generated, students must be registered")
                ButtonProcessBroadsheet.Enabled = True
                Exit Sub
            End If

            DataGridViewBroadSheet.DataSource = objBroadsheet.dataTablesScoresAndGrades(0).DefaultView
            dvScores = objBroadsheet.dataTablesScoresAndGrades(0).DefaultView
            dtScores = dvScores.ToTable
            'create tmp database table an store the result
            Dim lv, ss, dept As String
            If DataGridViewBroadSheet.Rows.Count > 0 Then
                'todo validate
                lv = DataGridViewBroadSheet.Rows(0).Cells("bs_level").Value.ToString
                dept = DataGridViewBroadSheet.Rows(0).Cells("dept_idr").Value.ToString
                ss = DataGridViewBroadSheet.Rows(0).Cells("bs_session").Value.ToString
                createBroadsheetTables(ss, dept, lv)
                ButtonSaveBroadsheet.PerformClick()   'save datasheet
            End If
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
            DataGridViewBroadSheet.Columns(0).Frozen = True
            DataGridViewBroadSheet.Columns(1).Frozen = True
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
            ButtonProcessBroadsheet.Enabled = True
            MsgBox("An error occured during the creation of the broadsheet" & vbCrLf & vbCrLf & ex.Message)
        End Try


    End Sub

    Private Sub bgwExportToExcel_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwExportToExcel.DoWork
        Dim tmpFileName As String
        tmpFileName = My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData & "\GeneratedResultBroadsheet" & objBroadsheet.Level & ".xlsx"
        tmpFileName = My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData & "\GeneratedResultBroadsheet" & objBroadsheet.Level & ".xlsx"

        'TODO: create UI to configure order

        'TODO: get all the data (such as level, dept, fac, hod etc) from the datagrivView only

        footers(0) = TextBoxCourseAdviser.Text
        footers(1) = TextBoxDean.Text
        footers(2) = TextBoxHOD.Text
        '1-interrp  2. built in     -2 grades
        '4-diploma
        Select Case System.Math.Abs(CInt(e.Argument))
            Case Is > 1000  'interop Template based
                objBroadsheet.updateExcelBroadSheetInterop(DataGridViewBroadSheet.DataSource, My.Application.Info.DirectoryPath & "\templates\broadsheet - Copy3.xlsm", My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData & "\GeneratedResultBroadsheet" & objBroadsheet.Level & ".xlsm")
                ' Case Is < 1000 'interop grades  'todo
                'objBroadsheet.updateExcelBroadSheetInterop(DataGridViewBroadSheet.DataSource, My.Application.Info.DirectoryPath & "\templates\broadsheet - Copy3.xlsm", My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData & "\GeneratedResultBroadsheet" & objBroadsheet.Level & ".xlsm")
                'Public BGW_EXPORT_EXCEL_1ST_SEM_SCORES As Integer = 1
                'Public BGW_EXPORT_EXCEL_2ND_SEM_SCORES As Integer = 2
                'Public BGW_EXPORT_EXCEL_ALL_SEM_SCORES As Integer = 3
            Case Else  ' NPOI
                If CInt(e.Argument) > BGW_EXPORT_EXCEL_GRADES_BASE_CONSTANT Then 'grades    'will not need this anymore
                    retFileName = objExcelFile.exportBroadsheettoExcelFile_NPOI(dvScores, tmpFileName, objBroadsheet, dictAllCourseCodeKeyAndCourseUnitVal, footers, e.Argument, True, dvGrades)
                ElseIf CInt(e.Argument) < BGW_EXPORT_EXCEL_GRADES_BASE_CONSTANT Then    'scores 'todo eror when selected yr.1
                    retFileName = objExcelFile.exportBroadsheettoExcelFile_NPOI(dvScores, tmpFileName, objBroadsheet, dictAllCourseCodeKeyAndCourseUnitVal, footers, e.Argument, False)
                ElseIf CInt(e.Argument) < BGW_EXPORT_EXCEL_YR_MILTIPLIER Then    'scores 'todo eror when selected yr.1
                    retFileName = objExcelFile.exportBroadsheettoExcelFile_NPOI(dvScores, tmpFileName, objBroadsheet, dictAllCourseCodeKeyAndCourseUnitVal, footers, e.Argument, False)
                Else 'default
                    retFileName = objExcelFile.exportBroadsheettoExcelFile_NPOI(dvScores, tmpFileName, objBroadsheet, dictAllCourseCodeKeyAndCourseUnitVal, footers, e.Argument, False)
                End If

        End Select
        'objExcelFile.createExcelFile_NPOI(My.Application.Info.DirectoryPath & "\samples\generated_broadsheet.xlsx") 'worked
    End Sub
    Private Sub bgwExportToExcel_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgwExportToExcel.RunWorkerCompleted
        If DataGridViewBroadSheet.DataSource Is Nothing Then Exit Sub
        'copy the file
        'TODO: access denied
        'My.Computer.FileSystem.CopyFile(My.Application.Info.DirectoryPath & "\templates\broadsheet - Copy3.xlsm", My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\GeneratedResultBroadsheet" & dlevel & ".xlsm", True)
        'replace template with fresh copy
        If CheckBoxFirsrSemester.Checked = False Then
            'hide em
        ElseIf CheckBoxSecondSemester.Checked = False Then
            'Hide em
        End If

        MsgBox("Done: GeneratedResultBroadsheet - " & retFileName)
        Me.TextBoxTemplateFileName.Text = retFileName
        ButtonExportToExcel.Enabled = True
        TimerBS.Stop()
        ButtonProcessBroadsheet.Enabled = True
        Me.ProgressBarBS.Value = 100
    End Sub
    Private Sub ButtonCloud_Click(sender As Object, e As EventArgs) Handles ButtonCloud.Click

        'testDB()
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
                MsgBox("Database Test Success: " & myDataSet.Tables(0).Rows(0).ItemArray(1).ToString)
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
        If DataGridViewBroadSheet.DataSource Is Nothing Then
            Exit Sub
        Else
            If dvScores Is Nothing Then dvScores = DataGridViewBroadSheet.DataSource
        End If

        ButtonExportToExcel.Enabled = False
        ButtonProcessBroadsheet.Enabled = False

        TimerBS.Enabled = True
        TimerBS.Start()


        'get broadsheetDatta from result and students table
        Dim tmpPARAM As Integer = 0
        objBroadsheet.processedBroadsheetFileName = My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData & "\GeneratedResultBroadsheet" & course_level & ".xlsx"

        If RadioButtonScores.Checked = True Then
                If CheckBoxSecondSemester.Checked = True And CheckBoxFirsrSemester.Checked = False Then
                tmpPARAM = BGW_EXPORT_EXCEL_1ST_SEM_SCORES
                objBroadsheet.broadsheetSemester = 1
            ElseIf CheckBoxSecondSemester.Checked = False And CheckBoxSecondSemester.Checked = True Then
                tmpPARAM = (BGW_EXPORT_EXCEL_1ST_SEM_SCORES)
                objBroadsheet.broadsheetSemester = 2
            Else
                tmpPARAM = (BGW_EXPORT_EXCEL_ALL_SEM_SCORES)
                objBroadsheet.broadsheetSemester = 2
            End If
            If RadioButtonDIP.Checked Then
                tmpPARAM = BGW_EXPORT_EXCEL_YR_MILTIPLIER * tmpPARAM
            End If
        Else
                If dvGrades Is Nothing Then ButtonGrades.PerformClick() 'todo: call function computeGrades
                tmpPARAM = BGW_EXPORT_EXCEL_GRADES_BASE_CONSTANT + tmpPARAM
            If RadioButtonDIP.Checked Then
                tmpPARAM = BGW_EXPORT_EXCEL_YR_MILTIPLIER * tmpPARAM
            End If
        End If

        If Me.RadioButtonUseExcel.Checked = True Or Me.RadioButtonUseExcelWithFormula.Checked = True Then
            objBroadsheet.processedBroadsheetFileName = My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData & "\GeneratedResultBroadsheet" & objBroadsheet.Level & ".xlsm"
            tmpPARAM = BGW_EXPORT_EXCEL_TEMPLATE_BASE_CONSTANT + tmpPARAM
        End If

        If CheckBoxSecondSemester.Checked Then
            objBroadsheet.broadsheetSemester = 2
        Else
            objBroadsheet.broadsheetSemester = 1
        End If
        bgwExportToExcel.RunWorkerAsync(tmpPARAM)

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






    Public Function getRegisteredStudents() As String()
        Dim retList As New List(Of String)
        Dim tmpDT As DataTable
        Dim tmpRecordEntry As String = ""
        tmpDT = mappDB.GetDataWhere(STR_SQL_ALL_REG_SUMMARY).Tables(0)
        If tmpDT.Rows.Count > 0 Then
            For i = 0 To tmpDT.Rows.Count - 1
                If dictSessions.ContainsKey(tmpDT.Rows(i).Item("session_idr")) And CInt(tmpDT.Rows(i).Item("level")) > 99 And CInt(tmpDT.Rows(i).Item("dept_idr")) >= 0 Then
                    tmpRecordEntry = tmpDT.Rows(i).Item("session_idr") & "," & mappDB.getDeptName(tmpDT.Rows(i).Item("dept_idr")) & "," & tmpDT.Rows(i).Item("level")
                    retList.Add(tmpRecordEntry)
                End If
            Next
        End If
        'todo: list all regs in Regs and call a function to use the reg if it is selected
        Return retList.ToArray
    End Function
    Private Sub bgwLoad_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgwLoad.DoWork
        getDeptSessionsIntoDictionaries()
        strRegisteredStudents = getRegisteredStudents()
    End Sub

    Private Sub bgwLoad_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgwLoad.RunWorkerCompleted
        Me.ButtonProcessBroadsheet.Enabled = True
        Me.ButtonExportToExcel.Enabled = True
        Me.ButtonExportPDF.Enabled = True

        If strRegisteredStudents.Count > 0 Then
            ComboBoxRegisteredStudents.Items.Clear()
            ComboBoxRegisteredStudents.Items.AddRange(strRegisteredStudents)
            ComboBoxRegisteredStudents.SelectedIndex = 0

            strParamsSessionDeptLevel = ComboBoxRegisteredStudents.SelectedItem.ToString.Split(",")
            session_idr = strParamsSessionDeptLevel(0)
            course_dept_idr = mappDB.getDeptID(strParamsSessionDeptLevel(1))
            course_level = strParamsSessionDeptLevel(2)


        Else
            ComboBoxRegisteredStudents.Items.Clear()
            ComboBoxRegisteredStudents.Text = "NO REGISTERED STUDENTS"
            course_level = 100
            course_dept_idr = 1
            session_idr = "2018/2019"
        End If





    End Sub



    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub FormGenerateBroadsheet_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MainForm.doCloseForm()
    End Sub

    Public Sub importBroadsheetData(dv As DataView)
        Me.DataGridViewBroadSheet.DataSource = dv
        'TODO: department etc
    End Sub


    Private Sub ButtonExportPDF_Click(sender As Object, e As EventArgs) Handles ButtonExportPDF.Click
        MsgBox("You can save excel file as PDF. Direct covertion to PDF is availiable in enterprise version")
        'Dim obj As New ClassPDF
        'If My.Computer.FileSystem.FileExists(objBroadsheet.processedBroadsheetFileName) Then
        '    obj.ExcelPDFLateBinding()
        '    MsgBox("Saved as PDF in: " & objBroadsheet.processedBroadsheetFileName)
        'End If
    End Sub



    Private Sub ButtonAddSession_Click(sender As Object, e As EventArgs)
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

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        On Error Resume Next
        If MsgBox("Are you sure you want to cancel?", MsgBoxStyle.YesNo) = vbYes Then

            BgWProcess.CancelAsync()
            bgwExportToExcel.CancelAsync()
            TimerBS.Stop()
            ButtonProcessBroadsheet.Enabled = True
        End If
    End Sub

    Private Sub ButtonTest_Click(sender As Object, e As EventArgs) Handles ButtonTest.Click
        'objExcelFile.modifyExcelFile_NPOI(My.Application.Info.DirectoryPath & "\templates\broadsheet_plain.xlsx", DataGridViewBroadSheet.DataSource) 'worked but NPOI corrupted excel fileobjExcelFile.
    End Sub

    Private Sub RadioButtonScores_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonScores.CheckedChanged
        If RadioButtonScores.Checked Then
            showScores()
        Else
            showGrades()
        End If

    End Sub

    Private Sub ComboBoxRegisteredStudents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxRegisteredStudents.SelectedIndexChanged
        Try

            strParamsSessionDeptLevel = ComboBoxRegisteredStudents.SelectedItem.ToString.Split(",") 'session,dep,level
            course_level = strParamsSessionDeptLevel(2)
            course_dept_idr = mappDB.getDeptID(strParamsSessionDeptLevel(1))
            session_idr = strParamsSessionDeptLevel(0)

            ' bgwCourses.RunWorkerAsync()
            getCoursesOrderIntoDictionaries(session_idr, course_dept_idr, course_level)

            'load previously generated broadsheet if availiable
            'TODO: show spinner




            'todo: validations
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonLoadSavedBS_Click(sender As Object, e As EventArgs) Handles ButtonLoadSavedBS.Click
        On Error Resume Next
        Dim tmpDT As New DataTable
        tmpDT = mappDB.GetDataWhere("SELECT * FROM " & getBroadheetTableName(session_idr, course_dept_idr, course_level)).Tables(0)
        If tmpDT.Rows.Count > 0 Then
            DataGridViewBroadSheet.DataSource = tmpDT.DefaultView
        End If
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

