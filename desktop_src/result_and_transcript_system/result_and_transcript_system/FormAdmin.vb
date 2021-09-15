Public Class FormAdmin
    Private Sub FormCourseAdviser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = RGBColors.colorBlack2
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub ButtonBrowse_Click(sender As Object, e As EventArgs) Handles ButtonBroadsheets.Click
        MainForm.ChangeMenu("GenerateBroadsheet")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ButtonStudents.Click
        MainForm.ChangeMenu("StudentsRegistration")
    End Sub

    Private Sub ButtonResultList_Click(sender As Object, e As EventArgs) Handles ButtonResultList.Click
        MainForm.ChangeMenu("ResultsTranscripts")
    End Sub

    Private Sub ButtonUpload_Click(sender As Object, e As EventArgs) Handles ButtonUpload.Click
        MainForm.ChangeMenu("UploadResult")
    End Sub

    Private Sub ButtonUser_Click(sender As Object, e As EventArgs) Handles ButtonResults.Click
        MainForm.ChangeMenu("UploadResult")
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub FormAdmin_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MainForm.doCloseForm()
    End Sub
End Class
