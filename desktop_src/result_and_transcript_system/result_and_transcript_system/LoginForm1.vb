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
            MDIParent1Main.Show()
            MDIParent1Main.PanelCourseAdviser.Show()
            MDIParent1Main.PanelStudent.Hide()
            MDIParent1Main.PanelCourseLecturer.Hide()
            FormUploadResult.Show()


        ElseIf Me.UsernameTextBox.Text = "adminST" And
                    Me.PasswordTextBox.Text = "admminST" Then
            MDIParent1Main.Show()
            MDIParent1Main.PanelCourseAdviser.Hide()
            MDIParent1Main.PanelStudent.Show()
            MDIParent1Main.PanelCourseLecturer.Hide()

        ElseIf Me.UsernameTextBox.Text = "adminCL" And
                Me.PasswordTextBox.Text = "adminCL" Then
            MDIParent1Main.Show()
            MDIParent1Main.PanelCourseAdviser.Hide()
            MDIParent1Main.PanelStudent.Hide()
            MDIParent1Main.PanelCourseLecturer.Show()




            Me.Hide()
            End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub UsernameLabel_Click(sender As Object, e As EventArgs) Handles UsernameLabel.Click

    End Sub
End Class
