Imports System.ComponentModel

Public Class FormCourseLecturer
    Dim dCountResult1, dCountResult2, dCountBS1, dCountBS2, dCountReg, dCountStudents, dCountSenate As Integer

    Private Sub FormCourseLecturer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.BackColor = RGBColors.colorBackground
            Me.ForeColor = RGBColors.colorForeground
        Catch ex As Exception
            logError(ex.ToString)
            MsgBox("Oops! Something went wrong, see log for details")
        End Try
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            updateDashBoard()
        Catch ex As Exception
            logError(ex.ToString)
            MsgBox("Oops! Something went wrong, see log for details")
        End Try
    End Sub
    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Try
            ButtonResultsSubmitted.Text = dCountResult1.ToString & "/" & dCountResult2.ToString
            ButtonNoOfStudents.Text = dCountReg.ToString
            'ButtonNoOfBroadsheets.Text = dCountBS1.ToString
        Catch ex As Exception
            logError(ex.ToString)
            MsgBox("Oops! Something went wrong, see log for details")
        End Try
    End Sub

    Private Sub ButtonResults_Click(sender As Object, e As EventArgs) Handles ButtonResults.Click
        Try
            MainForm.ChangeMenu("ViewResults")
        Catch ex As Exception
            logError(ex.ToString)
            MsgBox("Oops! Something went wrong, see log for details")
        End Try
    End Sub

    Private Sub ButtonUpload_Click(sender As Object, e As EventArgs) Handles ButtonUpload.Click
        Try
            MainForm.ChangeMenu("UploadResult")
        Catch ex As Exception
            logError(ex.ToString)
            MsgBox("Oops! Something went wrong, see log for details")
        End Try
    End Sub

    Private Sub ButtonDownloadTemplate_Click(sender As Object, e As EventArgs) Handles ButtonDownloadTemplate.Click
        Try
            Dim tmpileName As String = My.Application.Info.DirectoryPath & "\templates\result.xltx"
            Dim tmpileName2 As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\templates\result.xltx"
            Dim tmpileName3 As String = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\templates\result.xltx"

            If My.Computer.FileSystem.FileExists(tmpileName) Then

            ElseIf My.Computer.FileSystem.FileExists(tmpileName2) Then
                tmpileName = tmpileName2
            ElseIf My.Computer.FileSystem.FileExists(tmpileName3) Then
                tmpileName = tmpileName3
            End If

            'objResult.resultTemplateFileName
            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                My.Computer.FileSystem.CopyFile(tmpileName, SaveFileDialog1.FileName & ".xltx")
                If MsgBox("Do you want to open the template file in Excel?", "Result Template", vbYesNo) = DialogResult.Yes Then
                    System.Diagnostics.Process.Start(tmpileName)
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Try
            Me.Close()
        Catch ex As Exception
            logError(ex.ToString)
            MsgBox("Oops! Something went wrong, see log for details")
        End Try
    End Sub

    Private Sub FormCourseLecturer_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Try
            MainForm.doCloseForm()
        Catch ex As Exception
            logError(ex.ToString)
            MsgBox("Oops! Something went wrong, see log for details")
        End Try
    End Sub

    Private Sub FormCourseLecturer_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Try
            BackgroundWorker1.RunWorkerAsync()
        Catch ex As Exception
            logError(ex.ToString)
            MsgBox("Oops! Something went wrong, see log for details")
        End Try
    End Sub
    Sub updateDashBoard()
        On Error Resume Next
        Dim tmpDS As DataSet
        'dCountResult1, dCountResult2, dCountBS1, dCountBS2, dCountStudents,dCountSenate

        tmpDS = mappDB.GetDataWhere(STR_SQL_ALL_RESULTS_SUMMARY)
        dCountResult1 = tmpDS.Tables(0).Rows.Count

        tmpDS = mappDB.GetDataWhere(STR_SQL_ALL_COURSES)
        dCountResult2 = tmpDS.Tables(0).Rows.Count

        'tmpDS = mappDB.GetDataWhere(String.Format(STR_SQL_ALL_REG_COUNT, objBroadsheet.Session, objBroadsheet.DeptId))
        'dCountReg = CInt(tmpDS.Tables(0).Rows(0).Item(0).ToString)

        'tmpDS = mappDB.GetDataWhere(STR_SQL_ALL_STUDENTS_COUNT)
        'dCountStudents = CInt(tmpDS.Tables(0).Rows(0).Item(0).ToString)

        'tmpDS = mappDB.GetDataWhere(STR_SQL_ALL_BROADSHEETS_SUMMARY)
        'dCountBS1 = tmpDS.Tables(0).Rows.Count
        dCountBS1 = 0
    End Sub
End Class