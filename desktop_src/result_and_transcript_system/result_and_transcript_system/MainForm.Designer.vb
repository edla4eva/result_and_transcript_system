<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Me.PanelContainer = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TextBoxStatus = New System.Windows.Forms.TextBox()
        Me.SidePanel = New System.Windows.Forms.Panel()
        Me.PanelBtn_back = New System.Windows.Forms.Panel()
        Me.Buttonhelp = New System.Windows.Forms.Button()
        Me.PanelBtn = New System.Windows.Forms.Panel()
        Me.ButtonSettings = New System.Windows.Forms.Button()
        Me.ButtonCurrent = New System.Windows.Forms.Button()
        Me.LinkLabelShowHide = New System.Windows.Forms.LinkLabel()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.ButtonUser = New System.Windows.Forms.Button()
        Me.ButtonHome = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabelMax = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.PanelContainer.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SidePanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelContainer
        '
        Me.PanelContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelContainer.AutoScroll = True
        Me.PanelContainer.AutoSize = True
        Me.PanelContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanelContainer.Controls.Add(Me.Panel2)
        Me.PanelContainer.Location = New System.Drawing.Point(134, 30)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(656, 500)
        Me.PanelContainer.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.TextBoxStatus)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 415)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(656, 85)
        Me.Panel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(456, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 85)
        Me.Panel3.TabIndex = 1
        '
        'TextBoxStatus
        '
        Me.TextBoxStatus.Dock = System.Windows.Forms.DockStyle.Left
        Me.TextBoxStatus.Location = New System.Drawing.Point(0, 0)
        Me.TextBoxStatus.Multiline = True
        Me.TextBoxStatus.Name = "TextBoxStatus"
        Me.TextBoxStatus.Size = New System.Drawing.Size(450, 85)
        Me.TextBoxStatus.TabIndex = 0
        '
        'SidePanel
        '
        Me.SidePanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SidePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.SidePanel.Controls.Add(Me.PanelBtn_back)
        Me.SidePanel.Controls.Add(Me.Buttonhelp)
        Me.SidePanel.Controls.Add(Me.PanelBtn)
        Me.SidePanel.Controls.Add(Me.ButtonSettings)
        Me.SidePanel.Controls.Add(Me.ButtonCurrent)
        Me.SidePanel.Controls.Add(Me.LinkLabelShowHide)
        Me.SidePanel.Controls.Add(Me.ButtonExit)
        Me.SidePanel.Controls.Add(Me.ButtonUser)
        Me.SidePanel.Controls.Add(Me.ButtonHome)
        Me.SidePanel.Location = New System.Drawing.Point(0, 30)
        Me.SidePanel.Name = "SidePanel"
        Me.SidePanel.Size = New System.Drawing.Size(134, 500)
        Me.SidePanel.TabIndex = 4
        '
        'PanelBtn_back
        '
        Me.PanelBtn_back.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelBtn_back.BackgroundImage = Global.result_and_transcript_system.My.Resources.Resources.double_arrow_left_small
        Me.PanelBtn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PanelBtn_back.Location = New System.Drawing.Point(96, 9)
        Me.PanelBtn_back.Name = "PanelBtn_back"
        Me.PanelBtn_back.Size = New System.Drawing.Size(32, 25)
        Me.PanelBtn_back.TabIndex = 7
        '
        'Buttonhelp
        '
        Me.Buttonhelp.FlatAppearance.BorderSize = 0
        Me.Buttonhelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Buttonhelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Buttonhelp.ForeColor = System.Drawing.Color.White
        Me.Buttonhelp.Location = New System.Drawing.Point(3, 278)
        Me.Buttonhelp.Name = "Buttonhelp"
        Me.Buttonhelp.Size = New System.Drawing.Size(128, 55)
        Me.Buttonhelp.TabIndex = 7
        Me.Buttonhelp.Text = "Help"
        Me.Buttonhelp.UseVisualStyleBackColor = True
        '
        'PanelBtn
        '
        Me.PanelBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelBtn.BackgroundImage = Global.result_and_transcript_system.My.Resources.Resources.double_arrow_small
        Me.PanelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PanelBtn.Location = New System.Drawing.Point(96, 9)
        Me.PanelBtn.Name = "PanelBtn"
        Me.PanelBtn.Size = New System.Drawing.Size(32, 25)
        Me.PanelBtn.TabIndex = 6
        Me.PanelBtn.Visible = False
        '
        'ButtonSettings
        '
        Me.ButtonSettings.FlatAppearance.BorderSize = 0
        Me.ButtonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonSettings.ForeColor = System.Drawing.Color.White
        Me.ButtonSettings.Location = New System.Drawing.Point(6, 222)
        Me.ButtonSettings.Name = "ButtonSettings"
        Me.ButtonSettings.Size = New System.Drawing.Size(128, 55)
        Me.ButtonSettings.TabIndex = 5
        Me.ButtonSettings.Text = "Settings"
        Me.ButtonSettings.UseVisualStyleBackColor = True
        '
        'ButtonCurrent
        '
        Me.ButtonCurrent.FlatAppearance.BorderSize = 0
        Me.ButtonCurrent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCurrent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonCurrent.ForeColor = System.Drawing.Color.White
        Me.ButtonCurrent.Location = New System.Drawing.Point(3, 415)
        Me.ButtonCurrent.Name = "ButtonCurrent"
        Me.ButtonCurrent.Size = New System.Drawing.Size(128, 55)
        Me.ButtonCurrent.TabIndex = 4
        Me.ButtonCurrent.UseVisualStyleBackColor = True
        '
        'LinkLabelShowHide
        '
        Me.LinkLabelShowHide.ActiveLinkColor = System.Drawing.Color.DimGray
        Me.LinkLabelShowHide.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabelShowHide.AutoSize = True
        Me.LinkLabelShowHide.DisabledLinkColor = System.Drawing.Color.Silver
        Me.LinkLabelShowHide.LinkColor = System.Drawing.Color.Silver
        Me.LinkLabelShowHide.Location = New System.Drawing.Point(87, 11)
        Me.LinkLabelShowHide.Name = "LinkLabelShowHide"
        Me.LinkLabelShowHide.Size = New System.Drawing.Size(44, 13)
        Me.LinkLabelShowHide.TabIndex = 3
        Me.LinkLabelShowHide.TabStop = True
        Me.LinkLabelShowHide.Text = "<< Hide"
        Me.LinkLabelShowHide.Visible = False
        '
        'ButtonExit
        '
        Me.ButtonExit.FlatAppearance.BorderSize = 0
        Me.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonExit.ForeColor = System.Drawing.Color.White
        Me.ButtonExit.Location = New System.Drawing.Point(6, 339)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(128, 55)
        Me.ButtonExit.TabIndex = 2
        Me.ButtonExit.Text = "Exit"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'ButtonUser
        '
        Me.ButtonUser.FlatAppearance.BorderSize = 0
        Me.ButtonUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonUser.ForeColor = System.Drawing.Color.White
        Me.ButtonUser.Location = New System.Drawing.Point(3, 161)
        Me.ButtonUser.Name = "ButtonUser"
        Me.ButtonUser.Size = New System.Drawing.Size(128, 55)
        Me.ButtonUser.TabIndex = 1
        Me.ButtonUser.Text = "User"
        Me.ButtonUser.UseVisualStyleBackColor = True
        '
        'ButtonHome
        '
        Me.ButtonHome.FlatAppearance.BorderSize = 0
        Me.ButtonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonHome.ForeColor = System.Drawing.Color.White
        Me.ButtonHome.Location = New System.Drawing.Point(3, 100)
        Me.ButtonHome.Name = "ButtonHome"
        Me.ButtonHome.Size = New System.Drawing.Size(128, 55)
        Me.ButtonHome.TabIndex = 0
        Me.ButtonHome.Text = "Home"
        Me.ButtonHome.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Crimson
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.LinkLabel3)
        Me.Panel1.Controls.Add(Me.LinkLabelMax)
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(790, 30)
        Me.Panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(21, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(585, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "RTPS - Result and Transcript Processing Sysem Version 1.0.1 Beta 7"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.ActiveLinkColor = System.Drawing.Color.DimGray
        Me.LinkLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.LinkColor = System.Drawing.Color.DarkRed
        Me.LinkLabel3.Location = New System.Drawing.Point(676, 9)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(19, 13)
        Me.LinkLabel3.TabIndex = 2
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "__"
        '
        'LinkLabelMax
        '
        Me.LinkLabelMax.ActiveLinkColor = System.Drawing.Color.DimGray
        Me.LinkLabelMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabelMax.AutoSize = True
        Me.LinkLabelMax.LinkColor = System.Drawing.Color.DarkRed
        Me.LinkLabelMax.Location = New System.Drawing.Point(704, 9)
        Me.LinkLabelMax.Name = "LinkLabelMax"
        Me.LinkLabelMax.Size = New System.Drawing.Size(22, 13)
        Me.LinkLabelMax.TabIndex = 1
        Me.LinkLabelMax.TabStop = True
        Me.LinkLabelMax.Text = "[---]"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.DimGray
        Me.LinkLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkColor = System.Drawing.Color.DarkRed
        Me.LinkLabel1.Location = New System.Drawing.Point(731, 9)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(49, 13)
        Me.LinkLabel1.TabIndex = 0
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Close (X)"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(790, 530)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SidePanel)
        Me.Controls.Add(Me.PanelContainer)
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainForm"
        Me.PanelContainer.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.SidePanel.ResumeLayout(False)
        Me.SidePanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelContainer As Panel
    Friend WithEvents SidePanel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ButtonUser As Button
    Friend WithEvents ButtonHome As Button
    Friend WithEvents ButtonExit As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabelShowHide As LinkLabel
    Friend WithEvents LinkLabelMax As LinkLabel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents ButtonCurrent As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TextBoxStatus As TextBox
    Friend WithEvents ButtonSettings As Button
    Friend WithEvents PanelBtn As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Buttonhelp As Button
    Friend WithEvents PanelBtn_back As Panel
End Class
