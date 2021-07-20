
'This imports the MainForm classes
Imports result_and_transcript_system.MainForm


Public Class LoginForm1


    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)
        ' Me.BackColor = RGBColors.colorCrimson
    End Sub


    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)
        'Me.BackColor = RGBColors.colorCrimson
    End Sub



    'This is for when the ok button is clicked
    Private Sub OK_Click(sender As Object, e As EventArgs) Handles LoginOKButton.Click
        If Me.UsernameTextBox.Text = "admin" Then
            'admin mode
            If PasswordTextBox.Text = "admin" Then
                Me.Close()
                Exit Sub
            Else
                MsgBox("Only Admin can access this feature")
            End If
        End If

            'This is an if statement to check if the username and password is correct
            If Me.UsernameTextBox.Text = "adminCA" And
                Me.PasswordTextBox.Text = "adminCA" Then
            'If password id correct, change the panel menu
            mappDB.User = "CA"
            MainForm.ChangeMenu("CourseAdviser")    'This passes the form name to the changeMenu method in the mainForm
            MainForm.setDCurrentForm("CourseAdviser")
        ElseIf Me.UsernameTextBox.Text = "adminST" And
                    Me.PasswordTextBox.Text = "adminST" Then
            mappDB.User = "ST"
            MainForm.ChangeMenu("Student")
            MainForm.setDCurrentForm("Student")

        ElseIf Me.UsernameTextBox.Text = "adminCL" And
                Me.PasswordTextBox.Text = "adminCL" Then
            mappDB.User = "CL"
            MainForm.ChangeMenu("CourseLecturer")
            MainForm.setDCurrentForm("CourseLecturer")
        ElseIf Me.UsernameTextBox.Text = "admin" And
                mappDB.User = "admin" Then
            Me.PasswordTextBox.Text = "admin"
            MainForm.ChangeMenu("admin")
            MainForm.setDCurrentForm("admin")

        End If
    End Sub

    'This is for when the cancle button is clicked
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles LoginCancelButton.Click
        'Changes the panel to the home form
        MainForm.ChangeMenu("Home")
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.BackColor = RGBColors.colorBlack2
    End Sub

    Private Sub LoginForm1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        ' If e.KeyChar = Keys.Return Then AcceptButton.PerformClick()
    End Sub
End Class
