<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCourseAdviser
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SidePanel = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ButtonResultList = New System.Windows.Forms.Button()
        Me.ButtonCloud = New System.Windows.Forms.Button()
        Me.ButtonUpload = New System.Windows.Forms.Button()
        Me.ButtonUser = New System.Windows.Forms.Button()
        Me.ButtonBrowse = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SidePanel.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Font = New System.Drawing.Font("Arial Black", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Silver
        Me.Button1.Location = New System.Drawing.Point(17, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(178, 143)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "23/40"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Font = New System.Drawing.Font("Arial Black", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Silver
        Me.Button2.Location = New System.Drawing.Point(9, 15)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(173, 143)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "55"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'SidePanel
        '
        Me.SidePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.SidePanel.Controls.Add(Me.Button4)
        Me.SidePanel.Controls.Add(Me.ButtonResultList)
        Me.SidePanel.Controls.Add(Me.ButtonCloud)
        Me.SidePanel.Controls.Add(Me.ButtonUpload)
        Me.SidePanel.Controls.Add(Me.ButtonUser)
        Me.SidePanel.Controls.Add(Me.ButtonBrowse)
        Me.SidePanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.SidePanel.Location = New System.Drawing.Point(659, 0)
        Me.SidePanel.Name = "SidePanel"
        Me.SidePanel.Size = New System.Drawing.Size(134, 431)
        Me.SidePanel.TabIndex = 7
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(0, 39)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(128, 55)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Students"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ButtonResultList
        '
        Me.ButtonResultList.FlatAppearance.BorderSize = 0
        Me.ButtonResultList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonResultList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonResultList.ForeColor = System.Drawing.Color.White
        Me.ButtonResultList.Location = New System.Drawing.Point(3, 284)
        Me.ButtonResultList.Name = "ButtonResultList"
        Me.ButtonResultList.Size = New System.Drawing.Size(128, 55)
        Me.ButtonResultList.TabIndex = 4
        Me.ButtonResultList.Text = "List Results/ Transcripts"
        Me.ButtonResultList.UseVisualStyleBackColor = True
        '
        'ButtonCloud
        '
        Me.ButtonCloud.FlatAppearance.BorderSize = 0
        Me.ButtonCloud.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCloud.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonCloud.ForeColor = System.Drawing.Color.White
        Me.ButtonCloud.Location = New System.Drawing.Point(3, 362)
        Me.ButtonCloud.Name = "ButtonCloud"
        Me.ButtonCloud.Size = New System.Drawing.Size(128, 55)
        Me.ButtonCloud.TabIndex = 3
        Me.ButtonCloud.Text = "Sync Cloud"
        Me.ButtonCloud.UseVisualStyleBackColor = True
        '
        'ButtonUpload
        '
        Me.ButtonUpload.FlatAppearance.BorderSize = 0
        Me.ButtonUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonUpload.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonUpload.ForeColor = System.Drawing.Color.White
        Me.ButtonUpload.Location = New System.Drawing.Point(3, 223)
        Me.ButtonUpload.Name = "ButtonUpload"
        Me.ButtonUpload.Size = New System.Drawing.Size(128, 55)
        Me.ButtonUpload.TabIndex = 2
        Me.ButtonUpload.Text = "Upload"
        Me.ButtonUpload.UseVisualStyleBackColor = True
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
        Me.ButtonUser.Text = "Check Result"
        Me.ButtonUser.UseVisualStyleBackColor = True
        '
        'ButtonBrowse
        '
        Me.ButtonBrowse.FlatAppearance.BorderSize = 0
        Me.ButtonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonBrowse.ForeColor = System.Drawing.Color.White
        Me.ButtonBrowse.Location = New System.Drawing.Point(3, 100)
        Me.ButtonBrowse.Name = "ButtonBrowse"
        Me.ButtonBrowse.Size = New System.Drawing.Size(128, 55)
        Me.ButtonBrowse.TabIndex = 0
        Me.ButtonBrowse.Text = "BroadSheets"
        Me.ButtonBrowse.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 37)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "DashBoard"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(12, 223)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(199, 24)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = " Number of Students"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(262, 58)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 247)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Silver
        Me.Label5.Location = New System.Drawing.Point(6, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(193, 24)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Number of Students"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox3.Location = New System.Drawing.Point(16, 55)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(201, 251)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(13, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 24)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Results Submitted"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormCourseAdviser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(793, 431)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SidePanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormCourseAdviser"
        Me.Text = "FormCourseAdviser"
        Me.SidePanel.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents SidePanel As Panel
    Friend WithEvents ButtonResultList As Button
    Friend WithEvents ButtonCloud As Button
    Friend WithEvents ButtonUpload As Button
    Friend WithEvents ButtonUser As Button
    Friend WithEvents ButtonBrowse As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label4 As Label
End Class
