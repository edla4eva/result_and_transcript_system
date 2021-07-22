Public Class MainForm

    Private currentButton As Button
    Private leftBorderButton As Panel

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChangeMenu("Home")
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        leftBorderButton = New Panel
        leftBorderButton.Size = New Size(7, 55)
        SidePanel.Controls.Add(leftBorderButton)

    End Sub

    Private Sub ActiveButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            currentButton = CType(senderBtn, Button)
            currentButton.BackColor = Color.FromArgb(44, 62, 80)
            currentButton.ForeColor = Color.White
            'currentButton.IconColor = Color.White

            leftBorderButton.BackColor = customColor
            leftBorderButton.Location = New Point(0, currentButton.Location.Y)
            leftBorderButton.Visible = True
            leftBorderButton.BringToFront()

        End If
    End Sub

    Private Sub DisableButton()
        If currentButton IsNot Nothing Then
            currentButton.BackColor = Color.FromArgb(30, 39, 46)
            currentButton.ForeColor = Color.White
            'currentButton.IconColor = Color.white
        End If
    End Sub

    Private Sub addForm(frm As Form)

        PanelContainer.Controls.Clear()
        frm.TopLevel = False
        frm.TopMost = True
        frm.Dock = DockStyle.Fill
        PanelContainer.Controls.Add(frm)
        frm.Show()

    End Sub

    Public Sub ChangeMenu(menu As String)
        Select Case menu
            Case "Home"
                addForm(HomeForm)
            Case "User"
                addForm(LoginForm1)
            Case "CourseAdviser"
                addForm(FormCourseAdviser)
            Case "CourseLecturer"
                addForm(FormCourseLecturer)
            Case "GenerateBroadsheet"
                addForm(FormGenerateBroadsheet)
            Case "CourseAdviser"
                addForm(FormCourseAdviser)
            Case "Student"
                addForm(FormStudent)
            Case "UploadResult"
                addForm(FormUploadResult)
        End Select
    End Sub

    Private Sub ButtonHome_Click(sender As Object, e As EventArgs) Handles ButtonHome.Click
        ActiveButton(sender, RGBColors.colorCrimson)
        ChangeMenu("Home")
    End Sub

    Private Sub ButtonUser_Click(sender As Object, e As EventArgs) Handles ButtonUser.Click
        ActiveButton(sender, RGBColors.colorCrimson)
        ChangeMenu("User")
    End Sub

    Private Sub PanelContainer_Paint(sender As Object, e As PaintEventArgs) Handles PanelContainer.Paint

    End Sub
End Class