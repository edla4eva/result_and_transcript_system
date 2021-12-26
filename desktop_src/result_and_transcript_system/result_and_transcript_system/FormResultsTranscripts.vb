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
    Dim DVTranscripts As DataView
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
        Me.ReportViewer1.RefreshReport
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
            dgvStudents.DataSource = tmpDSStudent.Tables(0).DefaultView
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
        objReports.MATNO = "ENG0000001" 'TODO
        If dgvStudents.Rows.Count > 0 Then
            getTranscripts(dgvStudents.Rows(0).Cells("matno").Value.ToString)
            Dim dv As DataView = dgvTranscripts.DataSource
            objReports.updateReportDataSource("DataSet1", Me.ReportViewer1, dv.ToTable)
        End If
    End Sub

    Private Function getTranscripts(dMATNO As String) As DataSet
        Dim tmpDSRegCourses As DataSet

        Dim tmpDSResults As New DataSet
        Dim tmpDSBroadsheets As New DataSet
        Try
            mappDB.MATNO = dMATNO
            tmpDSRegCourses = mappDB.GetDataWhere(String.Format(STR_SQL_COURSES_REGS_WHERE, dMATNO), "Courses") 'todo
            tmpDSResults = mappDB.GetDataWhere(String.Format(STR_SQL_JOIN_QUERY_EXTRACTED_RESULTS_OF_STUDENTS_TO_TRANSCRIPT_BY_MATNO, dMATNO), "Results") 'todo
            Debug.Print(String.Format(STR_SQL_JOIN_QUERY_EXTRACTED_RESULTS_OF_STUDENTS_TO_TRANSCRIPT_BY_MATNO, dMATNO), "Results") 'todo

            dgvCourses.DataSource = tmpDSRegCourses.Tables(0).DefaultView
            dgvTranscripts.DataSource = tmpDSResults.Tables(0).DefaultView

            dgvCourses.Refresh()
            dgvTranscripts.Refresh()

            resizeDatagrids("courses")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return tmpDSResults
    End Function

    Private Sub bgwExportToExcel_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwExportToExcel.DoWork
        'footers(0) = TextBoxCourseAdviser.Text
        'footers(1) = TextBoxDean.Text
        'footers(2) = TextBoxHOD.Text
        Select Case CInt(e.Argument)
            Case 1
            Case 2
                'objExcelFile.modifyExcelFile_NPOI(My.Application.Info.DirectoryPath & "\templates\broadsheet_plain.xlsx", DataGridViewBroadSheet.DataSource) 'worked but NPOI corrupted excel fileobjExcelFile.
                retFileName = objExcelFile.exportTranscriptToExcelFile_NPOI(DVTranscripts, My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData & "\GeneratedResultTranscript" & "MATNO" & ".xlsx")
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
        DVTranscripts = dgvTranscripts.DataSource
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
        If ReportViewer1.Dock = DockStyle.Fill Then
            ReportViewer1.Dock = DockStyle.None
            ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        Else
            ReportViewer1.Dock = DockStyle.Fill
            ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class