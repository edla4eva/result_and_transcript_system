Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class FormResultsTranscripts
    Dim con As MySqlConnection
    Dim cmd As MySqlCommand
    Dim conLocal As OleDb.OleDbConnection
    Dim cmdLocal As OleDb.OleDbCommand
    Dim strSQL As String
    Dim strConnectionString As String

    Dim retFileName As String
    Dim DTTranscripts As DataTable
    Dim tmpDSStudentName As DataSet

    Private Sub FormResultsTranscript_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        Me.BackColor = RGBColors.colorBackground
        Me.dgvTranscripts.BackgroundColor = RGBColors.colorBackground
        Me.dgvTranscripts.RowsDefaultCellStyle.BackColor = RGBColors.colorForeground
        Me.dgvTranscripts.RowsDefaultCellStyle.ForeColor = RGBColors.colorBackground

        Me.dgvCourses.BackgroundColor = RGBColors.colorBackground
        Me.dgvCourses.RowsDefaultCellStyle.BackColor = RGBColors.colorForeground
        Me.dgvCourses.RowsDefaultCellStyle.ForeColor = RGBColors.colorBackground

        Me.dgvStudents.BackgroundColor = RGBColors.colorBackground
        Me.dgvStudents.RowsDefaultCellStyle.BackColor = RGBColors.colorForeground
        Me.dgvStudents.RowsDefaultCellStyle.ForeColor = RGBColors.colorBackground
        Me.ReportViewerTranscript.RefreshReport()
    End Sub

    Private Sub reset()
        ' mappDB.MATNO = "ENG1234567" 'TODO Test
        'GetDataWhere(String.Format(STR_SQL_ALL_RESULTS_WHERE, mappDB.StaffID.ToString))

        mappDB.GetDataWhere(String.Format(STR_SQL_ALL_RESULTS_WHERE, mappDB.MATNO.ToString))

        mappDB.GetDataWhere(String.Format(STR_SQL_ALL_RESULTS_WHERE, mappDB.MATNO.ToString))
    End Sub

    Private Sub ButtonAddResult_Click(sender As Object, e As EventArgs)
        'update
        Dim str As String
        Dim p0, p1 As String
        p0 = Me.TextBoxMATNO.Text
        p1 = Me.TextBoxDate.Text

        str = String.Format(STR_SQL_INSERT_RESULTS, p0, p1) ', p2, p3, p4, p5, p6
        mappDB.UpdateRecordWhere(str)
        MsgBox("Result Addedd!")
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        TextBoxDate.Text = Me.DateTimePicker1.Value.ToShortDateString
    End Sub







    Private Function searchTranscripts(dMATNO As String)
        Dim tmpDSStudent As DataSet

        Dim strStudentFullName As String = ""
        Try
            mappDB.MATNO = dMATNO
            tmpDSStudent = mappDB.GetDataWhere(String.Format(STR_SQL_COURSES_REGS_WHERE, dMATNO), "Courses") 'todo
            dgvStudents.DataSource = tmpDSStudent.Tables(0)
            dgvStudents.Refresh()
            resizeDatagrids("Students")

            tmpDSStudentName = mappDB.GetDataWhere(String.Format(STR_SQL_STUDENTS_FULL_NAME, dMATNO))

            With tmpDSStudentName.Tables(0)
                If .Rows.Count > 0 Then
                    strStudentFullName = .Rows(0).Item("student_firstname") & " " & .Rows(0).Item("student_othernames") & " " & .Rows(0).Item("student_surname")
                End If
            End With
            TextBoxName.Text = strStudentFullName
            Dim TMPileNAME As String = Application.StartupPath & "\photos\" & dgvStudents.SelectedRows(0).Cells("matno").Value & ".jpg"
            Dim TMP_PIC_FILE_NAME2 As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\photos\" & dgvStudents.SelectedRows(0).Cells("matno").Value & ".jpg"
            Dim tmpileName3 As String = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\photos\" & dgvStudents.SelectedRows(0).Cells("matno").Value & ".jpg"
            Dim TMPileNAME4 As String = Application.StartupPath & "\photos\photo_female.jpg"




            If My.Computer.FileSystem.FileExists(TMPileNAME) Then
                PictureBoxImg.Image = Image.FromFile(TMPileNAME)
            ElseIf My.Computer.FileSystem.FileExists(TMP_PIC_FILE_NAME2) Then
                PictureBoxImg.Image = Image.FromFile(TMP_PIC_FILE_NAME2)
            ElseIf My.Computer.FileSystem.FileExists(tmpileName3) Then
                PictureBoxImg.Image = Image.FromFile(tmpileName3)
            Else
                PictureBoxImg.Image = Image.FromFile(TMPileNAME4)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Sub resizeDatagrids(dGrid As String)
        If dgvCourses.Rows.Count > 0 And dGrid = "Courses" Then

            For Each col As DataGridViewColumn In dgvCourses.Columns
                col.Width = 0
                col.Visible = False
                If col.HeaderText = "matno" Then
                    col.Width = 70
                    col.Visible = True
                ElseIf col.HeaderText = "CourseCode_1" Then
                    col.Width = 200
                    col.Visible = True
                ElseIf col.HeaderText = "CourseCode_2" Then
                    col.Width = 200
                    col.Visible = True
                End If
            Next
        ElseIf dgvStudents.Rows.Count > 0 And dGrid = "Students" Then

            For Each col As DataGridViewColumn In dgvStudents.Columns
                col.Width = 50
                If col.HeaderText = "matno" Then
                    col.Width = 100
                ElseIf col.HeaderText = "first_name" Then
                    col.Width = 150
                ElseIf col.HeaderText = "surname" Then
                    col.Width = 100
                End If
            Next
        End If
    End Sub
    Private Sub FormResultsTranscripts_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        MainForm.doCloseForm()

    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub
    Private Sub ButtonTranscript_Click(sender As Object, e As EventArgs) Handles ButtonTranscript.Click
        searchTranscripts(TextBoxMATNO.Text)
        objReports.MATNO = TextBoxMATNO.Text 'TODO
        If dgvStudents.Rows.Count > 0 Then
            getTranscripts(dgvStudents.Rows(0).Cells("matno").Value.ToString)
            Dim dt As DataTable = dgvTranscripts.DataSource
            objReports.updateReportDataSource("DataSet1", Me.ReportViewerTranscript, dt)
        End If
        ReportViewerTranscript.BringToFront()
    End Sub
    Private Function getGPCard(dMATNO As String) As DataSet

        Dim tmpDSRegCourses As DataSet
        Dim tmpDSTranscript As New DataSet
        Dim tmpDTResults As New DataTable
        Dim tmpDSBroadsheets As New DataSet
        Dim tmpDTTranscript As New DataTable
        Dim tmpRow As DataRow
        Dim tmpCourseCode As String = ""
        Dim dGrade As String = ""
        Dim dGradePoint As String = ""
        Dim dScore As String = ""
        Dim dGPA As Double
        Dim strGPA As String
        Dim lstCredits As New List(Of Integer)
        Dim lstGradePoints As New List(Of Integer)
        Dim Credits(0 To COURSE_END_COL_2) As Integer
        Dim GradePoints(0 To COURSE_END_COL_2) As Integer
        Dim approvedCourses(0 To COURSE_END_COL_2) As Boolean
        Dim dWeightedGradePoints As Integer()


        tmpDTTranscript.Columns.Add("Session", GetType(System.String))
        tmpDTTranscript.Columns.Add("matno", GetType(System.String))
        tmpDTTranscript.Columns.Add("fullname", GetType(System.String))
        tmpDTTranscript.Columns.Add("CourseCode", GetType(System.String))
        tmpDTTranscript.Columns.Add("Score", GetType(System.String))

        tmpDTTranscript.Columns.Add("course_code_idr", GetType(System.String))
        tmpDTTranscript.Columns.Add("Credits", GetType(System.String))
        tmpDTTranscript.Columns.Add("course_title", GetType(System.String))
        tmpDTTranscript.Columns.Add("remarks", GetType(System.String))
        tmpDTTranscript.Columns.Add("SURNAME", GetType(System.String))
        tmpDTTranscript.Columns.Add("OtherNames", GetType(System.String))
        tmpDTTranscript.Columns.Add("department", GetType(System.String))

        tmpDTTranscript.Columns.Add("bs_level", GetType(System.String))
        tmpDTTranscript.Columns.Add("gpa100", GetType(System.String))
        tmpDTTranscript.Columns.Add("gpa200", GetType(System.String))
        tmpDTTranscript.Columns.Add("gpa300", GetType(System.String))
        tmpDTTranscript.Columns.Add("gpa400", GetType(System.String))
        tmpDTTranscript.Columns.Add("gpa500", GetType(System.String))
        tmpDTTranscript.Columns.Add("wgpa100", GetType(System.String))
        tmpDTTranscript.Columns.Add("wgpa200", GetType(System.String))
        tmpDTTranscript.Columns.Add("fgpa", GetType(System.String))

        tmpDTTranscript.Columns.Add("GPA", Type.GetType("System.String"))
        tmpDTTranscript.Columns.Add("Class", Type.GetType("System.String"))
        tmpDTTranscript.Columns.Add("Category", Type.GetType("System.String"))
        tmpDTTranscript.Columns.Add("Failed", Type.GetType("System.String"))


        'getDeptSessionsIntoDictionaries()
        mappDB.getAllCourses()
        'getCoursesOrderIntoDictionaries()
        'dictCoursesOrderFS
        'dictCoursesOrderSS
        Try
            mappDB.MATNO = dMATNO
            'tmpDSRegCourses = mappDB.GetDataWhere(String.Format(STR_SQL_COURSES_REGS_WHERE, dMATNO), "Courses") 'todo
            tmpDTResults = mappDB.getBroadsheetForTranscript(dMATNO, "100", False)
            Dim j As Integer = COURSE_START_COL
            For i = 0 To tmpDTResults.Rows.Count - 1
                For jIter = 0 To COURSE_START_COL       'initialize
                    approvedCourses(jIter) = False
                    Credits(jIter) = 0
                Next
                For jIter = COURSE_START_COL To COURSE_END_COL_2
                    If jIter = COURSE_END_COL + 1 Then
                        j = COURSE_START_COL_2
                    Else
                        j = jIter
                    End If
                    tmpCourseCode = tmpDTResults.Columns(j).ColumnName
                    dScore = tmpDTResults.Rows(i).Item(tmpCourseCode).ToString
                    'check for cousees and scores to be skipped
                    If tmpCourseCode.Contains("ColUNIQUE") Then
                        Continue For
                        approvedCourses(j) = False
                        Credits(j) = 0
                    Else
                        approvedCourses(j) = True
                    End If

                    'If objBroadsheet.IsRegisteredScore(dScore) = False Then Continue For 'use ths or transcript only

                    'its okay to add the scores
                    tmpRow = tmpDTTranscript.Rows.Add
                    tmpRow("Session") = tmpDTResults.Rows(i).Item("bs_session")
                    'tmpRow("bs_level") = tmpDTResults.Rows(i).Item("bs_level")
                    tmpRow("bs_level") = ((((j - COURSE_START_COL) \ NUM_COURSES_PER_LEVEL_1) + 1) * 100).ToString
                    tmpRow("matno") = tmpDTResults.Rows(i).Item("matno")
                    tmpRow("fullname") = tmpDTResults.Rows(i).Item("FullName")
                    tmpCourseCode = tmpDTResults.Columns(j).ColumnName

                    tmpRow("CourseCode") = tmpCourseCode
                    tmpRow("score") = tmpDTResults.Rows(i).Item(tmpCourseCode).ToString

                    dGrade = objBroadsheet.getGRADE(dScore, Nothing, Nothing)
                    dGradePoint = objBroadsheet.getGradePointFromGrade(dGrade)
                    GradePoints(i) = dGradePoint

                    'todo IMPORTANT get this info from table bcos it may change over time
                    If dictAllCourseCodeKeyAndCourseUnitVal.ContainsKey(tmpCourseCode) Then

                        Credits(i) = dictAllCourseCodeKeyAndCourseUnitVal(tmpCourseCode)
                        lstCredits.Add(Credits(i))
                    End If
                    tmpRow("course_code_idr") = tmpCourseCode
                    tmpRow("Credits") = Credits(i)
                    tmpRow("course_title") = tmpDTResults.Rows(i).Item("bs_faculty_name")
                    'todo getRules(session,level)
                    tmpRow("remarks") = dGrade
                    tmpRow("gpa100") = dGradePoint
                    tmpRow("SURNAME") = tmpDTResults.Rows(i).Item("SURNAME")
                    tmpRow("OtherNames") = tmpDTResults.Rows(i).Item("FullName") & tmpDTResults.Rows(i).Item("OtherNames")
                    tmpRow("department") = tmpDTResults.Rows(i).Item("bs_department_name")

                    tmpRow("gpa200") = "*3.555*"    'tmpDTResults.Rows(i).Item("gpa200")
                    tmpRow("department") = tmpDTResults.Rows(i).Item("bs_department_name")
                Next
                tmpDTTranscript.AcceptChanges()
            Next

            'reiterate through and find GPA
            dWeightedGradePoints = objBroadsheet.getWeightedGRADESPoints(GradePoints, Credits)
            dGPA = objBroadsheet.CalcGPA(dWeightedGradePoints, approvedCourses, Credits, objBroadsheet.Level, objBroadsheet.levelCGPaPercentages)
            strGPA = (Math.Floor(dGPA * 1000) / 1000).ToString
            For i = 0 To tmpDTResults.Rows.Count - 1
                tmpDTTranscript.Rows(i).Item("gpa100") = strGPA
                tmpDTTranscript.Rows(i).Item("gpa200") = strGPA
                tmpDTTranscript.Rows(i).Item("GPA") = strGPA
            Next
            tmpDTTranscript.AcceptChanges()
            dgvTranscripts.DataSource = tmpDTTranscript
            dgvTranscripts.Refresh()
            tmpDSTranscript.Tables.Clear()
            tmpDTTranscript.TableName = "Transcript"
            tmpDTResults.TableName = "Result"

            tmpDSTranscript.Tables.Add(tmpDTTranscript)
            Return tmpDSTranscript
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function


    Private Function getTranscripts(dMATNO As String) As DataSet

        Dim tmpDSRegCourses As DataSet
        Dim tmpDSTranscript As New DataSet
        Dim tmpDTResults As New DataTable
        Dim tmpDSBroadsheets As New DataSet
        Dim tmpDTTranscript As New DataTable
        Dim tmpRow As DataRow
        Dim tmpCourseCode As String = ""
        Dim dGrade As String = ""
        Dim dGradePoint As String = ""
        Dim dScore As String = ""
        Dim dGPA As Double
        Dim strGPA As String
        Dim lstCredits As New List(Of Integer)
        Dim lstGradePoints As New List(Of Integer)
        Dim Credits(0 To COURSE_END_COL_2) As Integer
        Dim GradePoints(0 To COURSE_END_COL_2) As Integer
        Dim approvedCourses(0 To COURSE_END_COL_2) As Boolean
        Dim dWeightedGradePoints As Integer()


        tmpDTTranscript.Columns.Add("Session", GetType(System.String))
        tmpDTTranscript.Columns.Add("matno", GetType(System.String))
        tmpDTTranscript.Columns.Add("fullname", GetType(System.String))
        tmpDTTranscript.Columns.Add("CourseCode", GetType(System.String))
        tmpDTTranscript.Columns.Add("Score", GetType(System.String))

        tmpDTTranscript.Columns.Add("course_code_idr", GetType(System.String))
        tmpDTTranscript.Columns.Add("Credits", GetType(System.String))
        tmpDTTranscript.Columns.Add("course_title", GetType(System.String))
        tmpDTTranscript.Columns.Add("remarks", GetType(System.String))
        tmpDTTranscript.Columns.Add("SURNAME", GetType(System.String))
        tmpDTTranscript.Columns.Add("OtherNames", GetType(System.String))
        tmpDTTranscript.Columns.Add("department", GetType(System.String))

        tmpDTTranscript.Columns.Add("bs_level", GetType(System.String))
        tmpDTTranscript.Columns.Add("gpa100", GetType(System.String))
        tmpDTTranscript.Columns.Add("gpa200", GetType(System.String))

        tmpDTTranscript.Columns.Add("GPA", Type.GetType("System.String"))
        tmpDTTranscript.Columns.Add("Class", Type.GetType("System.String"))
        tmpDTTranscript.Columns.Add("Category", Type.GetType("System.String"))
        tmpDTTranscript.Columns.Add("Failed", Type.GetType("System.String"))


        'getDeptSessionsIntoDictionaries()
        mappDB.getAllCourses()
        'getCoursesOrderIntoDictionaries()
        'dictCoursesOrderFS
        'dictCoursesOrderSS
        Try
            mappDB.MATNO = dMATNO
            'tmpDSRegCourses = mappDB.GetDataWhere(String.Format(STR_SQL_COURSES_REGS_WHERE, dMATNO), "Courses") 'todo
            'we need ti iterattively querythedb
            For x = 100 To 800 Step 100
                tmpDTResults = mappDB.getBroadsheetForTranscript(dMATNO, x.ToString, False)
                If tmpDTResults Is Nothing Then Continue For


                Dim j As Integer = COURSE_START_COL
                For i = 0 To tmpDTResults.Rows.Count - 1
                    For jIter = 0 To COURSE_START_COL       'initialize
                        approvedCourses(jIter) = False
                        Credits(jIter) = 0
                    Next
                    For jIter = COURSE_START_COL To COURSE_END_COL_2
                        If jIter = COURSE_END_COL + 1 Then
                            j = COURSE_START_COL_2
                        Else
                            j = jIter
                        End If
                        tmpCourseCode = tmpDTResults.Columns(j).ColumnName
                        dScore = tmpDTResults.Rows(i).Item(tmpCourseCode).ToString
                        'check for cousees and scores to be skipped
                        If tmpCourseCode.Contains("ColUNIQUE") Then
                            Continue For
                            approvedCourses(j) = False
                            Credits(j) = 0
                        Else
                            approvedCourses(j) = True
                        End If

                        'If objBroadsheet.IsRegisteredScore(dScore) = False Then Continue For 'use ths or transcript only

                        'its okay to add the scores
                        tmpRow = tmpDTTranscript.Rows.Add
                        tmpRow("Session") = tmpDTResults.Rows(i).Item("bs_session")
                        'tmpRow("bs_level") = tmpDTResults.Rows(i).Item("bs_level")
                        tmpRow("bs_level") = ((((j - COURSE_START_COL) \ NUM_COURSES_PER_LEVEL_1) + 1) * 100).ToString
                        tmpRow("matno") = tmpDTResults.Rows(i).Item("matno")
                        tmpRow("fullname") = tmpDTResults.Rows(i).Item("FullName")
                        tmpCourseCode = tmpDTResults.Columns(j).ColumnName

                        tmpRow("CourseCode") = tmpCourseCode
                        tmpRow("score") = tmpDTResults.Rows(i).Item(tmpCourseCode).ToString

                        dGrade = objBroadsheet.getGRADE(dScore, Nothing, Nothing)
                        dGradePoint = objBroadsheet.getGradePointFromGrade(dGrade)
                        GradePoints(i) = dGradePoint

                        'todo IMPORTANT get this info from table bcos it may change over time
                        If dictAllCourseCodeKeyAndCourseUnitVal.ContainsKey(tmpCourseCode) Then

                            Credits(i) = dictAllCourseCodeKeyAndCourseUnitVal(tmpCourseCode)
                            lstCredits.Add(Credits(i))
                        End If
                        tmpRow("course_code_idr") = tmpCourseCode
                        tmpRow("Credits") = Credits(i)
                        tmpRow("course_title") = tmpDTResults.Rows(i).Item("bs_faculty_name")
                        'todo getRules(session,level)
                        tmpRow("remarks") = dGrade
                        tmpRow("gpa100") = dGradePoint
                        tmpRow("SURNAME") = tmpDTResults.Rows(i).Item("SURNAME")
                        tmpRow("OtherNames") = tmpDTResults.Rows(i).Item("FullName") & tmpDTResults.Rows(i).Item("OtherNames")
                        tmpRow("department") = tmpDTResults.Rows(i).Item("bs_department_name")

                        tmpRow("gpa200") = "*3.555*"    'tmpDTResults.Rows(i).Item("gpa200")
                        tmpRow("department") = tmpDTResults.Rows(i).Item("bs_department_name")
                    Next
                    tmpDTTranscript.AcceptChanges()
                Next

                'reiterate through and find GPA
                dWeightedGradePoints = objBroadsheet.getWeightedGRADESPoints(GradePoints, Credits)
                dGPA = objBroadsheet.CalcGPA(dWeightedGradePoints, approvedCourses, Credits, objBroadsheet.Level, objBroadsheet.levelCGPaPercentages)
                strGPA = (Math.Floor(dGPA * 1000) / 1000).ToString
                For i = 0 To 9
                    tmpDTTranscript.Rows(i).Item("gpa200") = strGPA
                    tmpDTTranscript.Rows(i).Item("GPA") = strGPA
                Next
            Next
            'tmpDTResults=mappDB.showBroadsheet()
            'dgvCourses.DataSource = tmpDSRegCourses.Tables(0)
            dgvTranscripts.DataSource = tmpDTTranscript

            'dgvCourses.Refresh()
            dgvTranscripts.Refresh()
            tmpDSTranscript.Tables.Clear()
            tmpDTTranscript.TableName = "Transcript"
            tmpDTResults.TableName = "Result"
            'resizeDatagrids("courses")
            tmpDSTranscript.Tables.Add(tmpDTTranscript)
            'tmpDSTranscript.Tables.Add(tmpDTResults)
            'tmpDSTranscript.Tables.Add(tmpD)
            Return tmpDSTranscript
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function
    Private Sub bgwExportToExcel_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwExportToExcel.DoWork
        'footers(0) = TextBoxCourseAdviser.Text
        'footers(1) = TextBoxDean.Text
        'footers(2) = TextBoxHOD.Text
        Select Case CInt(e.Argument)
            Case 1
            Case 2
                'objExcelFile.modifyExcelFile_NPOI(My.Application.Info.DirectoryPath & "\templates\broadsheet_plain.xlsx", DataGridViewBroadSheet.DataSource) 'worked but NPOI corrupted excel fileobjExcelFile.
                retFileName = objExcelFile.exportTranscriptToExcelFile_NPOI(DTTranscripts, My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData & "\GeneratedResultTranscript" & "MATNO" & ".xlsx")
            Case Else

        End Select
    End Sub
    Private Sub bgwExportToExcel_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgwExportToExcel.RunWorkerCompleted
        If dgvTranscripts.DataSource Is Nothing Then Exit Sub
        MsgBox("Done: GeneratedResultBroadsheet - " & retFileName)
        Me.TextBoxTemplateFileName.Text = retFileName
        ButtonEport.Enabled = True
        TimerBS.Stop()
        Me.ProgressBarBS.Value = 100
    End Sub

    Private Sub ButtonEport_Click(sender As Object, e As EventArgs) Handles ButtonEport.Click
        If MessageBox.Show("Are you sure you want to export to excel?", "Export", MessageBoxButtons.YesNoCancel) = MsgBoxResult.Yes Then
        Else
            Exit Sub
        End If
        If dgvTranscripts.DataSource Is Nothing Then Exit Sub
        DTTranscripts = dgvTranscripts.DataSource
        Me.ButtonEport.Enabled = False
        TimerBS.Enabled = True
        TimerBS.Start()

        bgwExportToExcel.RunWorkerAsync(2)

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


    Private Sub ButtonOpen_Click(sender As Object, e As EventArgs) Handles ButtonOpen.Click
        Try

            System.Diagnostics.Process.Start(TextBoxTemplateFileName.Text)
        Catch ex As Exception
            MsgBox("Could not open excel file" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub ButtonFullScreen_Click(sender As Object, e As EventArgs) Handles ButtonFullScreen.Click
        ReportViewerTranscript.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        ReportViewerGPCard.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        If ReportViewerTranscript.Dock = DockStyle.Fill Then
            ReportViewerTranscript.Dock = DockStyle.None
            ReportViewerGPCard.Dock = DockStyle.None
            ReportViewerGPCARDDIP.Dock = DockStyle.None
        Else
            ReportViewerTranscript.Dock = DockStyle.Fill
            ReportViewerGPCard.Dock = DockStyle.Fill
            ReportViewerGPCARDDIP.Dock = DockStyle.Fill
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub ButtonGPACard_Click(sender As Object, e As EventArgs) Handles ButtonGPACard.Click
        searchTranscripts(TextBoxMATNO.Text)
        objReports.MATNO = "ENG0000001" 'TODO
        If dgvStudents.Rows.Count > 0 Then
            getGPCard(dgvStudents.Rows(0).Cells("matno").Value.ToString)
            Dim dt As DataTable
            If Not dgvTranscripts.DataSource Is Nothing Then
                dt = dgvTranscripts.DataSource
                objReports.updateReportDataSource("DataSet1", Me.ReportViewerGPCard, dt)
                objReports.updateReportDataSource("DataSet1", Me.ReportViewerGPCARDDIP, dt)
            End If
        End If
        If RadioButtonDIP.Checked = True Then
            ReportViewerGPCARDDIP.BringToFront()
        Else
            ReportViewerGPCard.BringToFront()
        End If

    End Sub

    Private Sub TextBoxMATNO_TextChanged(sender As Object, e As EventArgs) Handles TextBoxMATNO.TextChanged

    End Sub
End Class