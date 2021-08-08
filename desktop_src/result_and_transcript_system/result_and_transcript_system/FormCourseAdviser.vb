Public Class FormCourseAdviser
    Private Sub FormCourseAdviser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = RGBColors.colorBlack2
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub ButtonBrowse_Click(sender As Object, e As EventArgs) Handles ButtonBrowse.Click
        MainForm.ChangeMenu("GenerateBroadsheet")
    End Sub
End Class
