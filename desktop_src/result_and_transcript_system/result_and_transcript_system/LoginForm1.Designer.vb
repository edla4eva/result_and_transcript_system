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
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.LoginCancelButton = New System.Windows.Forms.Button()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.LoginOKButton = New System.Windows.Forms.Button()
        Me.LoginMiddlePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'LoginMiddlePanel
        '
        Me.LoginMiddlePanel.AutoSize = True
        Me.LoginMiddlePanel.Controls.Add(Me.UsernameLabel)
        Me.LoginMiddlePanel.Controls.Add(Me.UsernameTextBox)
        Me.LoginMiddlePanel.Controls.Add(Me.LoginCancelButton)
        Me.LoginMiddlePanel.Controls.Add(Me.PasswordLabel)
        Me.LoginMiddlePanel.Controls.Add(Me.PasswordTextBox)
        Me.LoginMiddlePanel.Controls.Add(Me.LoginOKButton)
        Me.LoginMiddlePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LoginMiddlePanel.Location = New System.Drawing.Point(0, 0)
        Me.LoginMiddlePanel.Name = "LoginMiddlePanel"
        Me.LoginMiddlePanel.Size = New System.Drawing.Size(643, 397)
        Me.LoginMiddlePanel.TabIndex = 16
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.UsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.Location = New System.Drawing.Point(146, 104)
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
        Me.UsernameTextBox.Location = New System.Drawing.Point(146, 132)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(274, 29)
        Me.UsernameTextBox.TabIndex = 7
        Me.UsernameTextBox.Text = "adminCA"
        '
        'LoginCancelButton
        '
        Me.LoginCancelButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LoginCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.LoginCancelButton.Location = New System.Drawing.Point(146, 309)
        Me.LoginCancelButton.Name = "LoginCancelButton"
        Me.LoginCancelButton.Size = New System.Drawing.Size(271, 51)
        Me.LoginCancelButton.TabIndex = 11
        Me.LoginCancelButton.Text = "&Cancel"
        Me.LoginCancelButton.Visible = False
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.Location = New System.Drawing.Point(143, 164)
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
        Me.PasswordTextBox.Location = New System.Drawing.Point(146, 188)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(274, 29)
        Me.PasswordTextBox.TabIndex = 9
        Me.PasswordTextBox.Text = "adminCA"
        '
        'LoginOKButton
        '
        Me.LoginOKButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LoginOKButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginOKButton.Location = New System.Drawing.Point(146, 233)
        Me.LoginOKButton.Name = "LoginOKButton"
        Me.LoginOKButton.Size = New System.Drawing.Size(271, 51)
        Me.LoginOKButton.TabIndex = 10
        Me.LoginOKButton.Text = "&OK"
        '
        'LoginForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 397)
        Me.Controls.Add(Me.LoginMiddlePanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginForm1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Login"
        Me.LoginMiddlePanel.ResumeLayout(False)
        Me.LoginMiddlePanel.PerformLayout()
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
End Class
