Public Class MainForm
#Region "UI Stuff"
    'This are the variables for the button and panel objects
    Private currentButton As Button
    Private leftBorderButton As Panel

    'This are constant variables for making the form adjustable
    Const WM_NCHITTEST As Integer = &H84
    Const HTCLIENT As Integer = 1
    Const HTCAPTION As Integer = 2
    Private dCurrentForm As String = "User"

    'This overrides the WndProc method to control the main form to make it adjustable
    'This was a borrowed code
    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)

        Select Case m.Msg
            Case WM_NCHITTEST
                If m.Result = CType(HTCLIENT, Integer) Then
                    m.Result = CType(HTCAPTION, IntPtr)
                End If
        End Select

    End Sub


    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.Style = cp.Style Or &H40000
            Return cp
        End Get
    End Property

    'This is the first method that loads first when the main form first runs
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This calls the changemenu method that sets it to the home screen
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


    'This is the method that is implemented on a button when it will be clicked
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

    'This is the method that is implemented.....
    'On an active button when another button Is clicked
    Private Sub DisableButton()
        If currentButton IsNot Nothing Then
            currentButton.BackColor = Color.FromArgb(30, 39, 46)
            currentButton.ForeColor = Color.White
            'currentButton.IconColor = Color.white
        End If
    End Sub

    'This method changes the form displayed on the panel in the main form
    Private Sub addForm(frm As Form)

        PanelContainer.Controls.Clear()     'This first clears the panel
        frm.TopLevel = False
        frm.TopMost = True
        frm.Dock = DockStyle.Fill
        PanelContainer.Controls.Add(frm)    'This adds the new form into the panel
        frm.Show()

    End Sub
    'This is for when the home button is clicked
    Private Sub ButtonHome_Click(sender As Object, e As EventArgs) Handles ButtonHome.Click
        ActiveButton(sender, RGBColors.colorCrimson)
        ChangeMenu("Home")
    End Sub

    'This is for when the user button is clicked
    Private Sub ButtonUser_Click(sender As Object, e As EventArgs) Handles ButtonUser.Click
        ActiveButton(sender, RGBColors.colorCrimson)
        ChangeMenu("User")
    End Sub

    'This variables are used for making the mainForm draggable
    Dim draggable As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer

    'This is for when a mouse is pressed down at the top panel
    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        'when the mouse is clicked down the form follows the position of the mouse
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    'This is for when the mouse moves after mouse down
    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        'if the mouse is still down then the form should follow the mouse position
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub

    'This is for when the mouse is not pressed down
    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        'when mouse is not pressed then the for should not drag
        draggable = False
    End Sub

#End Region
    'This method tells the addForm the right form .....
    'To change to when the right parameter is passed
    'TODO: Let all UI actions be handled in this class (i.e seperate UI from functionality
    Public Sub ChangeMenu(menu As String)
        'This is select case statement for every form that needs to be changed to

        Select Case menu
            Case "Home"
                addForm(HomeForm)
                Me.WindowState = FormWindowState.Normal
            Case "User"
                addForm(LoginForm1)
                Me.WindowState = FormWindowState.Normal
            Case "Settings"
                addForm(FormSettings)
                Me.WindowState = FormWindowState.Maximized
            Case "CourseAdviser"
                addForm(FormCourseAdviser)
                Me.WindowState = FormWindowState.Maximized
            Case "CourseLecturer"
                addForm(FormCourseLecturer)
                Me.WindowState = FormWindowState.Maximized
            Case "GenerateBroadsheet"
                addForm(FormGenerateBroadsheet)
                Me.WindowState = FormWindowState.Maximized
            Case "CourseAdviser"
                addForm(FormCourseAdviser)
                Me.WindowState = FormWindowState.Maximized
            Case "Student"
                addForm(FormStudent)
                Me.WindowState = FormWindowState.Maximized
            Case "UploadResult"
                addForm(FormUploadResult)
                Me.WindowState = FormWindowState.Maximized
            Case "StudentsRegistration"
                addForm(FormStudentsRegistration)
                Me.WindowState = FormWindowState.Maximized
            Case "ResultsTranscripts"
                addForm(FormResultsTranscripts)
                Me.WindowState = FormWindowState.Maximized
            Case "admin"
                addForm(FormAdmin)
                Me.WindowState = FormWindowState.Maximized
            Case "ViewResults"
                addForm(FormViewResults)
                Me.WindowState = FormWindowState.Maximized
            Case "viewBroadsheets"
                addForm(FormViewBroadsheets)
                Me.WindowState = FormWindowState.Maximized
        End Select
    End Sub

    Public Sub status(s As String)
        Me.TextBoxStatus.Text = Me.TextBoxStatus.Text & vbCrLf & s
    End Sub


    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        ActiveButton(sender, RGBColors.colorCrimson)
        If MessageBox.Show("Are you sure you want to close this form?", "Close", MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.ButtonExit.PerformClick()
    End Sub

    Private Sub LinkLabelMax_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelMax.LinkClicked
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ButtonCurrent_Click(sender As Object, e As EventArgs) Handles ButtonCurrent.Click
        ActiveButton(sender, RGBColors.colorCrimson)
        ChangeMenu(dCurrentForm)
    End Sub
    Public Sub setDCurrentForm(s As String)
        dCurrentForm = s
        Me.ButtonCurrent.Text = s

    End Sub

    Private Sub ButtonSettings_Click(sender As Object, e As EventArgs) Handles ButtonSettings.Click
        ActiveButton(sender, RGBColors.colorCrimson)
        ChangeMenu("Settings")
    End Sub

    Private Sub PanelBtn_Paint(sender As Object, e As PaintEventArgs) Handles PanelBtn.Paint

    End Sub

    Private Sub PanelBtn_Click(sender As Object, e As EventArgs) Handles PanelBtn.Click
        If SidePanel.Width = PanelBtn.Width Then
            SidePanel.Width = ButtonExit.Width + ButtonExit.Width / 8
        Else
            SidePanel.Width = PanelBtn.Width
        End If

    End Sub

    Private Sub LinkLabelShowHide_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelShowHide.LinkClicked
        If SidePanel.Width < ButtonExit.Width Then
            SidePanel.Width = ButtonExit.Width + ButtonExit.Width / 10  '5% margin left and right
            LinkLabelShowHide.Text = "<<Hide"
            'todo show text
            ButtonHome.Text = "Home"
        Else
            SidePanel.Width = LinkLabelShowHide.Width
            LinkLabelShowHide.Text = " Show>>"
            'todo
            'show icons in button
            'ButtonHome.BackgroundImage = HomeIcon 
            ButtonHome.Text = "^"
        End If
    End Sub
    Public Sub doCloseForm() 'Todo RemoUI
        If mappDB.User = "CA" Then
            Me.ChangeMenu("CourseAdviser")
        ElseIf mappDB.User = "CL" Then
            Me.ChangeMenu("CourseLecturer")
        ElseIf mappDB.User = "ST" Then
            Me.ChangeMenu("Student")
        Else
            Me.ChangeMenu("User")
        End If
    End Sub
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class

