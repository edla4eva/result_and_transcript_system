<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class LoginForm1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LoginMiddlePanel = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonAddUser = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.LabelNewPassword = New System.Windows.Forms.Label()
        Me.TextBoxNewPassword = New System.Windows.Forms.TextBox()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.LoginCancelButton = New System.Windows.Forms.Button()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.LoginOKButton = New System.Windows.Forms.Button()
        Me.ButtonChangePassword = New System.Windows.Forms.Button()
        Me.LoginMiddlePanel.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LoginMiddlePanel
        '
        Me.LoginMiddlePanel.AutoSize = True
        Me.LoginMiddlePanel.Controls.Add(Me.GroupBox1)
        Me.LoginMiddlePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LoginMiddlePanel.Location = New System.Drawing.Point(0, 0)
        Me.LoginMiddlePanel.Name = "LoginMiddlePanel"
        Me.LoginMiddlePanel.Size = New System.Drawing.Size(643, 446)
        Me.LoginMiddlePanel.TabIndex = 16
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.ButtonAddUser)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.LabelNewPassword)
        Me.GroupBox1.Controls.Add(Me.TextBoxNewPassword)
        Me.GroupBox1.Controls.Add(Me.UsernameLabel)
        Me.GroupBox1.Controls.Add(Me.UsernameTextBox)
        Me.GroupBox1.Controls.Add(Me.LoginCancelButton)
        Me.GroupBox1.Controls.Add(Me.PasswordLabel)
        Me.GroupBox1.Controls.Add(Me.PasswordTextBox)
        Me.GroupBox1.Controls.Add(Me.LoginOKButton)
        Me.GroupBox1.Controls.Add(Me.ButtonChangePassword)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(111, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(340, 394)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'ButtonAddUser
        '
        Me.ButtonAddUser.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonAddUser.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonAddUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.ButtonAddUser.Location = New System.Drawing.Point(35, 350)
        Me.ButtonAddUser.Name = "ButtonAddUser"
        Me.ButtonAddUser.Size = New System.Drawing.Size(271, 51)
        Me.ButtonAddUser.TabIndex = 13
        Me.ButtonAddUser.Text = "Add User"
        Me.ButtonAddUser.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(35, 152)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(164, 17)
        Me.CheckBox1.TabIndex = 15
        Me.CheckBox1.Text = "I want to chane my password"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'LabelNewPassword
        '
        Me.LabelNewPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelNewPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNewPassword.Location = New System.Drawing.Point(32, 175)
        Me.LabelNewPassword.Name = "LabelNewPassword"
        Me.LabelNewPassword.Size = New System.Drawing.Size(274, 21)
        Me.LabelNewPassword.TabIndex = 13
        Me.LabelNewPassword.Text = "New Password"
        Me.LabelNewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelNewPassword.Visible = False
        '
        'TextBoxNewPassword
        '
        Me.TextBoxNewPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBoxNewPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TextBoxNewPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNewPassword.Location = New System.Drawing.Point(35, 200)
        Me.TextBoxNewPassword.Name = "TextBoxNewPassword"
        Me.TextBoxNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxNewPassword.Size = New System.Drawing.Size(274, 29)
        Me.TextBoxNewPassword.TabIndex = 14
        Me.TextBoxNewPassword.Text = "adminCA"
        Me.TextBoxNewPassword.Visible = False
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.UsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.Location = New System.Drawing.Point(35, 33)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(274, 23)
        Me.UsernameLabel.TabIndex = 6
        Me.UsernameLabel.Text = "&User name"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.UsernameTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.UsernameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTextBox.Location = New System.Drawing.Point(35, 61)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(274, 29)
        Me.UsernameTextBox.TabIndex = 7
        Me.UsernameTextBox.Text = "adminCA"
        '
        'LoginCancelButton
        '
        Me.LoginCancelButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LoginCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.LoginCancelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.LoginCancelButton.Location = New System.Drawing.Point(35, 293)
        Me.LoginCancelButton.Name = "LoginCancelButton"
        Me.LoginCancelButton.Size = New System.Drawing.Size(271, 51)
        Me.LoginCancelButton.TabIndex = 11
        Me.LoginCancelButton.Text = "&Cancel"
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.Location = New System.Drawing.Point(32, 93)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(274, 21)
        Me.PasswordLabel.TabIndex = 8
        Me.PasswordLabel.Text = "&Password"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PasswordTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.PasswordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.Location = New System.Drawing.Point(35, 117)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(274, 29)
        Me.PasswordTextBox.TabIndex = 9
        Me.PasswordTextBox.Text = "adminCA"
        '
        'LoginOKButton
        '
        Me.LoginOKButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LoginOKButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.LoginOKButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginOKButton.Location = New System.Drawing.Point(35, 237)
        Me.LoginOKButton.Name = "LoginOKButton"
        Me.LoginOKButton.Size = New System.Drawing.Size(271, 51)
        Me.LoginOKButton.TabIndex = 10
        Me.LoginOKButton.Text = "&OK"
        '
        'ButtonChangePassword
        '
        Me.ButtonChangePassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonChangePassword.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonChangePassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.ButtonChangePassword.Location = New System.Drawing.Point(35, 237)
        Me.ButtonChangePassword.Name = "ButtonChangePassword"
        Me.ButtonChangePassword.Size = New System.Drawing.Size(271, 51)
        Me.ButtonChangePassword.TabIndex = 12
        Me.ButtonChangePassword.Text = "C&hange Password"
        Me.ButtonChangePassword.Visible = False
        '
        'LoginForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 446)
        Me.Controls.Add(Me.LoginMiddlePanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginForm1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Login"
        Me.LoginMiddlePanel.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LoginMiddlePanel As Panel
    Friend WithEvents LoginCancelButton As Button
    Friend WithEvents LoginOKButton As Button
    Friend WithEvents LogInFlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LabelNewPassword As Label
    Friend WithEvents TextBoxNewPassword As TextBox
    Friend WithEvents ButtonChangePassword As Button
    Friend WithEvents ButtonAddUser As Button
    Friend WithEvents CheckBox1 As CheckBox
End Class
