<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginForm))
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPageAdvanced = New System.Windows.Forms.TabPage()
        Me.cmdConnect = New System.Windows.Forms.Button()
        Me.CheckBoxAuto = New System.Windows.Forms.CheckBox()
        Me.txtMySQLPassword = New System.Windows.Forms.TextBox()
        Me.txtMySQLUserName = New System.Windows.Forms.TextBox()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.CheckBoxDemo = New System.Windows.Forms.CheckBox()
        Me.comboDepartments = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxAdminPassword = New System.Windows.Forms.TextBox()
        Me.ButtonExpand = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxpassword = New System.Windows.Forms.TextBox()
        Me.TextBoxusername = New System.Windows.Forms.TextBox()
        Me.okButton2 = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TabControl2.SuspendLayout()
        Me.TabPageAdvanced.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPageAdvanced)
        Me.TabControl2.Location = New System.Drawing.Point(10, 91)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(190, 322)
        Me.TabControl2.TabIndex = 15
        '
        'TabPageAdvanced
        '
        Me.TabPageAdvanced.BackgroundImage = Global.eAccount.My.Resources.Resources.sidbnr
        Me.TabPageAdvanced.Controls.Add(Me.cmdConnect)
        Me.TabPageAdvanced.Controls.Add(Me.CheckBoxAuto)
        Me.TabPageAdvanced.Controls.Add(Me.txtMySQLPassword)
        Me.TabPageAdvanced.Controls.Add(Me.txtMySQLUserName)
        Me.TabPageAdvanced.Controls.Add(Me.txtIP)
        Me.TabPageAdvanced.Controls.Add(Me.Label5)
        Me.TabPageAdvanced.Controls.Add(Me.Label6)
        Me.TabPageAdvanced.Controls.Add(Me.Label7)
        Me.TabPageAdvanced.Location = New System.Drawing.Point(4, 25)
        Me.TabPageAdvanced.Name = "TabPageAdvanced"
        Me.TabPageAdvanced.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageAdvanced.Size = New System.Drawing.Size(182, 293)
        Me.TabPageAdvanced.TabIndex = 1
        Me.TabPageAdvanced.Text = "LogIn (Server)"
        Me.TabPageAdvanced.UseVisualStyleBackColor = True
        '
        'cmdConnect
        '
        Me.cmdConnect.Font = New System.Drawing.Font("Candara", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConnect.Location = New System.Drawing.Point(18, 234)
        Me.cmdConnect.Name = "cmdConnect"
        Me.cmdConnect.Size = New System.Drawing.Size(145, 35)
        Me.cmdConnect.TabIndex = 28
        Me.cmdConnect.Text = "Connect"
        Me.cmdConnect.UseVisualStyleBackColor = True
        '
        'CheckBoxAuto
        '
        Me.CheckBoxAuto.AutoCheck = False
        Me.CheckBoxAuto.AutoSize = True
        Me.CheckBoxAuto.Location = New System.Drawing.Point(35, 199)
        Me.CheckBoxAuto.Name = "CheckBoxAuto"
        Me.CheckBoxAuto.Size = New System.Drawing.Size(56, 21)
        Me.CheckBoxAuto.TabIndex = 26
        Me.CheckBoxAuto.Text = "Auto"
        Me.CheckBoxAuto.UseVisualStyleBackColor = True
        '
        'txtMySQLPassword
        '
        Me.txtMySQLPassword.Font = New System.Drawing.Font("Candara", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMySQLPassword.Location = New System.Drawing.Point(18, 162)
        Me.txtMySQLPassword.Name = "txtMySQLPassword"
        Me.txtMySQLPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMySQLPassword.Size = New System.Drawing.Size(145, 31)
        Me.txtMySQLPassword.TabIndex = 25
        '
        'txtMySQLUserName
        '
        Me.txtMySQLUserName.Font = New System.Drawing.Font("Candara", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMySQLUserName.Location = New System.Drawing.Point(18, 98)
        Me.txtMySQLUserName.Name = "txtMySQLUserName"
        Me.txtMySQLUserName.Size = New System.Drawing.Size(145, 31)
        Me.txtMySQLUserName.TabIndex = 24
        Me.txtMySQLUserName.Text = "root"
        '
        'txtIP
        '
        Me.txtIP.Font = New System.Drawing.Font("Candara", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIP.Location = New System.Drawing.Point(18, 34)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(145, 31)
        Me.txtIP.TabIndex = 23
        Me.txtIP.Text = "localhost"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Candara", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(14, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 23)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Password"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Candara", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(31, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 23)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "User"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Candara", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(14, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 23)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Hostname / IP"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(206, 91)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(204, 322)
        Me.TabControl1.TabIndex = 18
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImage = Global.eAccount.My.Resources.Resources.sidbnr
        Me.TabPage1.Controls.Add(Me.CheckBoxDemo)
        Me.TabPage1.Controls.Add(Me.comboDepartments)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.TextBoxAdminPassword)
        Me.TabPage1.Controls.Add(Me.ButtonExpand)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.TextBoxpassword)
        Me.TabPage1.Controls.Add(Me.TextBoxusername)
        Me.TabPage1.Controls.Add(Me.okButton2)
        Me.TabPage1.Controls.Add(Me.ButtonCancel)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(196, 293)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Login (App)"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'CheckBoxDemo
        '
        Me.CheckBoxDemo.AutoSize = True
        Me.CheckBoxDemo.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CheckBoxDemo.Location = New System.Drawing.Point(27, 133)
        Me.CheckBoxDemo.Name = "CheckBoxDemo"
        Me.CheckBoxDemo.Size = New System.Drawing.Size(93, 18)
        Me.CheckBoxDemo.TabIndex = 27
        Me.CheckBoxDemo.Text = "Demo mode"
        Me.CheckBoxDemo.UseVisualStyleBackColor = True
        '
        'comboDepartments
        '
        Me.comboDepartments.FormattingEnabled = True
        Me.comboDepartments.Location = New System.Drawing.Point(24, 103)
        Me.comboDepartments.Name = "comboDepartments"
        Me.comboDepartments.Size = New System.Drawing.Size(154, 24)
        Me.comboDepartments.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(24, 243)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 14)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Admin Password"
        '
        'TextBoxAdminPassword
        '
        Me.TextBoxAdminPassword.Location = New System.Drawing.Point(24, 261)
        Me.TextBoxAdminPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxAdminPassword.Name = "TextBoxAdminPassword"
        Me.TextBoxAdminPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxAdminPassword.Size = New System.Drawing.Size(154, 24)
        Me.TextBoxAdminPassword.TabIndex = 24
        Me.TextBoxAdminPassword.Text = "2015TrussNetAdmin"
        '
        'ButtonExpand
        '
        Me.ButtonExpand.Location = New System.Drawing.Point(142, 222)
        Me.ButtonExpand.Name = "ButtonExpand"
        Me.ButtonExpand.Size = New System.Drawing.Size(36, 23)
        Me.ButtonExpand.TabIndex = 23
        Me.ButtonExpand.Text = ">>"
        Me.ButtonExpand.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(21, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 14)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Password :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(21, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 14)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "User Name :"
        '
        'TextBoxpassword
        '
        Me.TextBoxpassword.Location = New System.Drawing.Point(24, 72)
        Me.TextBoxpassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxpassword.Name = "TextBoxpassword"
        Me.TextBoxpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxpassword.Size = New System.Drawing.Size(154, 24)
        Me.TextBoxpassword.TabIndex = 18
        '
        'TextBoxusername
        '
        Me.TextBoxusername.Location = New System.Drawing.Point(24, 27)
        Me.TextBoxusername.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxusername.Name = "TextBoxusername"
        Me.TextBoxusername.Size = New System.Drawing.Size(154, 24)
        Me.TextBoxusername.TabIndex = 17
        '
        'okButton2
        '
        Me.okButton2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.okButton2.Location = New System.Drawing.Point(24, 156)
        Me.okButton2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.okButton2.Name = "okButton2"
        Me.okButton2.Size = New System.Drawing.Size(154, 28)
        Me.okButton2.TabIndex = 19
        Me.okButton2.Text = "Login"
        Me.okButton2.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCancel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancel.Location = New System.Drawing.Point(24, 192)
        Me.ButtonCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(154, 28)
        Me.ButtonCancel.TabIndex = 21
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Fuchsia
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(10, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(396, 84)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'loginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(418, 420)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TabControl2)
        Me.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "loginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "<title>"
        Me.TabControl2.ResumeLayout(False)
        Me.TabPageAdvanced.ResumeLayout(False)
        Me.TabPageAdvanced.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPageAdvanced As System.Windows.Forms.TabPage
    Friend WithEvents cmdConnect As System.Windows.Forms.Button
    Friend WithEvents CheckBoxAuto As System.Windows.Forms.CheckBox
    Friend WithEvents txtMySQLPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtMySQLUserName As System.Windows.Forms.TextBox
    Friend WithEvents txtIP As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents comboDepartments As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxAdminPassword As System.Windows.Forms.TextBox
    Friend WithEvents ButtonExpand As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxpassword As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxusername As System.Windows.Forms.TextBox
    Friend WithEvents okButton2 As System.Windows.Forms.Button
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents CheckBoxDemo As System.Windows.Forms.CheckBox
End Class
