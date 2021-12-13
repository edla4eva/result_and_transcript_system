
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
        If mappDB.getUser(UsernameTextBox.Text, getMD5HashCode(PasswordTextBox.Text)) Then
            'If password id correct, change the panel menuu
            ' MsgBox("User Authentication passed")
            If Me.UsernameTextBox.Text = "adminCA" Then 'todo if mappdb.getUserRole="CA"
                mappDB.User = "CA"
                MainForm.ChangeMenu("CourseAdviser")    'This passes the form name to the changeMenu method in the mainForm
                MainForm.setDCurrentForm("CourseAdviser")
            ElseIf Me.UsernameTextBox.Text = "adminST" Then
                mappDB.User = "ST"
                MainForm.ChangeMenu("Student")
                MainForm.setDCurrentForm("Student")

            ElseIf Me.UsernameTextBox.Text = "adminCL" Then
                mappDB.User = "CL"
                MainForm.ChangeMenu("CourseLecturer")
                MainForm.setDCurrentForm("CourseLecturer")
            ElseIf Me.UsernameTextBox.Text = "admin" Then
                Me.PasswordTextBox.Text = "admin"
            MainForm.ChangeMenu("admin")
            MainForm.setDCurrentForm("admin")
        End If
            'clear passwordsothat an unauthorized person cannot use it
            UsernameTextBox.Text = ""
            PasswordTextBox.Text = ""
            TextBoxNewPassword.Text = ""
        Else
            MsgBox("User Authentication failed")

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

    Private Sub ButtonChangePassword_Click(sender As Object, e As EventArgs) Handles ButtonChangePassword.Click
        If TextBoxNewPassword.Text = TextBoxNewPassword.Text Then
            If mappDB.getUser(UsernameTextBox.Text, getMD5HashCode(PasswordTextBox.Text)) Then
                mappDB.changeUserPassword(UsernameTextBox.Text, getMD5HashCode(PasswordTextBox.Text))
                UsernameTextBox.Text = ""
                PasswordTextBox.Text = ""
                TextBoxNewPassword.Text = ""
                MsgBox("Password changed")
            Else
                MsgBox("Not a valid user")
            End If
        End If
        Me.LabelNewPassword.Visible = False
        Me.TextBoxNewPassword.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonAddUser.Click
        Try

            mappDB.saveUser(UsernameTextBox.Text, getMD5HashCode(PasswordTextBox.Text))
            UsernameTextBox.Text = ""
            PasswordTextBox.Text = ""
            TextBoxNewPassword.Text = ""
            ButtonAddUser.Visible = False
            MsgBox("User addes sucessfully")
        Catch ex As Exception
            logError(ex.ToString)
            MsgBox("User could not be added")
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If Not Me.CheckBox1.Checked Then
            Me.TextBoxNewPassword.Visible = False
            Me.LabelNewPassword.Visible = False
            Me.ButtonChangePassword.Visible = False

            Me.LoginOKButton.Visible = True
        Else
            Me.TextBoxNewPassword.Visible = True
            Me.LabelNewPassword.Visible = True
            Me.ButtonChangePassword.Visible = True

            Me.LoginOKButton.Visible = False

        End If


    End Sub

    Private Sub LoginMiddlePanel_Paint(sender As Object, e As PaintEventArgs) Handles LoginMiddlePanel.Paint

    End Sub
End Class
