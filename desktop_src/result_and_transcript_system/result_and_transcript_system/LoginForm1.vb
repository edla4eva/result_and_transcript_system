Imports result_and_transcript_system.MainForm


Public Class LoginForm1

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If Me.UsernameTextBox.Text = "adminCO" And
                Me.PasswordTextBox.Text = "adminCO" Then
            'If password id correct, show main form 
            MainForm.ChangeMenu("CourseAdviser")

        ElseIf Me.UsernameTextBox.Text = "adminST" And
                    Me.PasswordTextBox.Text = "adminST" Then
            MainForm.ChangeMenu("Student")

        ElseIf Me.UsernameTextBox.Text = "adminCL" And
                Me.PasswordTextBox.Text = "adminCL" Then
            MainForm.ChangeMenu("CourseLecturer")
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        MainForm.ChangeMenu("Home")
        Me.Close()
    End Sub

    Private Sub UsernameLabel_Click(sender As Object, e As EventArgs) Handles UsernameLabel.Click

    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.TextChanged

    End Sub
End Class
