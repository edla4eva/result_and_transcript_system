
'This imports the MainForm classes
Imports result_and_transcript_system.MainForm


Public Class LoginForm1

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.




    Private Sub UsernameLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)
        Me.BackColor = RGBColors.colorBlue
    End Sub


    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)
        'Me.BackColor = RGBColors.colorCrimson
    End Sub



    Private Sub LoginMiddlePanel_Paint(sender As Object, e As PaintEventArgs) Handles LoginMiddlePanel.Paint
        'Me.BackColor = RGBColors.colorBlack2

    End Sub

    'This is for when the ok button is clicked
    Private Sub OK_Click(sender As Object, e As EventArgs) Handles LoginOKButton.Click
        'This is an if statement to check if the username and password is correct
        If Me.UsernameTextBox.Text = "adminCO" And
                Me.PasswordTextBox.Text = "adminCO" Then
            'If password id correct, change the panel menu
            MainForm.ChangeMenu("CourseAdviser")    'This passes the form name to the changeMenu method in the mainForm

        ElseIf Me.UsernameTextBox.Text = "adminST" And
                    Me.PasswordTextBox.Text = "adminST" Then
            MainForm.ChangeMenu("Student")

        ElseIf Me.UsernameTextBox.Text = "adminCL" And
                Me.PasswordTextBox.Text = "adminCL" Then
            MainForm.ChangeMenu("CourseLecturer")
        End If
    End Sub

    'This is for when the cancle button is clicked
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles LoginCancelButton.Click
        'Changes the panel to the home form
        MainForm.ChangeMenu("Home")
        Me.Close()
    End Sub

    Private Sub UsernameLabel_Click_1(sender As Object, e As EventArgs) Handles UsernameLabel.Click

    End Sub
End Class
