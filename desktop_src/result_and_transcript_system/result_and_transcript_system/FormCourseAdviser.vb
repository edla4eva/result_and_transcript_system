Public Class FormCourseAdviser
    Private Sub ButtonGenerateBroadsheet_Click(sender As Object, e As EventArgs) Handles ButtonGenerateBroadsheet.Click
        ButtonGenerateBroadsheet.FlatStyle = FlatStyle.Popup
        ButtonGenerateBroadsheet.FlatAppearance.BorderSize = ButtonGenerateBroadsheet.FlatAppearance.BorderSize + 2
    End Sub

    Private Sub ButtonGenerateBroadsheet_ControlAdded(sender As Object, e As ControlEventArgs) Handles ButtonGenerateBroadsheet.ControlAdded

    End Sub

    Private Sub ButtonGenerateBroadsheet_MouseHover(sender As Object, e As EventArgs) Handles ButtonGenerateBroadsheet.MouseHover
        ButtonGenerateBroadsheet.FlatStyle = FlatStyle.Popup

        ButtonGenerateBroadsheet.BackColor = Color.Green




    End Sub

    Private Sub ButtonGenerateBroadsheet_MouseLeave(sender As Object, e As EventArgs) Handles ButtonGenerateBroadsheet.MouseLeave
        ButtonGenerateBroadsheet.FlatStyle = FlatStyle.Flat
        ButtonGenerateBroadsheet.BackColor = Color.White


    End Sub

    Private Sub FormCourseAdviser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
