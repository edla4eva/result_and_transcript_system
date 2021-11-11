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
        Me.ButtonResultsSubmitted = New System.Windows.Forms.Button()
        Me.ButtonNoOfStudents = New System.Windows.Forms.Button()
        Me.SidePanel = New System.Windows.Forms.Panel()
        Me.ButtonGenerateBroadsheet = New System.Windows.Forms.Button()
        Me.ButtonResultList = New System.Windows.Forms.Button()
        Me.ButtonCloud = New System.Windows.Forms.Button()
        Me.ButtonUpload = New System.Windows.Forms.Button()
        Me.ButtonStudents = New System.Windows.Forms.Button()
        Me.ButtonBroadsheets = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ButtonResults = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonNoOfBroadsheets = New System.Windows.Forms.Button()
        Me.TextBoxStatus1 = New System.Windows.Forms.TextBox()
        Me.TextBoxStatus2 = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonNoOfSenate = New System.Windows.Forms.Button()
        Me.ButtonSenate = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.SidePanel.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonResultsSubmitted
        '
        Me.ButtonResultsSubmitted.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonResultsSubmitted.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ButtonResultsSubmitted.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonResultsSubmitted.Font = New System.Drawing.Font("Arial Black", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonResultsSubmitted.ForeColor = System.Drawing.Color.Silver
        Me.ButtonResultsSubmitted.Location = New System.Drawing.Point(17, 19)
        Me.ButtonResultsSubmitted.Name = "ButtonResultsSubmitted"
        Me.ButtonResultsSubmitted.Size = New System.Drawing.Size(178, 143)
        Me.ButtonResultsSubmitted.TabIndex = 0
        Me.ButtonResultsSubmitted.Text = "23/40"
        Me.ButtonResultsSubmitted.UseVisualStyleBackColor = False
        '
        'ButtonNoOfStudents
        '
        Me.ButtonNoOfStudents.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonNoOfStudents.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ButtonNoOfStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonNoOfStudents.Font = New System.Drawing.Font("Arial Black", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNoOfStudents.ForeColor = System.Drawing.Color.Silver
        Me.ButtonNoOfStudents.Location = New System.Drawing.Point(12, 21)
        Me.ButtonNoOfStudents.Name = "ButtonNoOfStudents"
        Me.ButtonNoOfStudents.Size = New System.Drawing.Size(173, 143)
        Me.ButtonNoOfStudents.TabIndex = 1
        Me.ButtonNoOfStudents.Text = "55"
        Me.ButtonNoOfStudents.UseVisualStyleBackColor = False
        '
        'SidePanel
        '
        Me.SidePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.SidePanel.Controls.Add(Me.ButtonGenerateBroadsheet)
        Me.SidePanel.Controls.Add(Me.ButtonResultList)
        Me.SidePanel.Controls.Add(Me.ButtonCloud)
        Me.SidePanel.Controls.Add(Me.ButtonUpload)
        Me.SidePanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.SidePanel.Location = New System.Drawing.Point(927, 0)
        Me.SidePanel.Name = "SidePanel"
        Me.SidePanel.Size = New System.Drawing.Size(134, 525)
        Me.SidePanel.TabIndex = 7
        '
        'ButtonGenerateBroadsheet
        '
        Me.ButtonGenerateBroadsheet.FlatAppearance.BorderSize = 0
        Me.ButtonGenerateBroadsheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGenerateBroadsheet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonGenerateBroadsheet.ForeColor = System.Drawing.Color.White
        Me.ButtonGenerateBroadsheet.Location = New System.Drawing.Point(0, 120)
        Me.ButtonGenerateBroadsheet.Name = "ButtonGenerateBroadsheet"
        Me.ButtonGenerateBroadsheet.Size = New System.Drawing.Size(128, 55)
        Me.ButtonGenerateBroadsheet.TabIndex = 6
        Me.ButtonGenerateBroadsheet.Text = "Generate Broadsheet"
        Me.ButtonGenerateBroadsheet.UseVisualStyleBackColor = True
        '
        'ButtonResultList
        '
        Me.ButtonResultList.FlatAppearance.BorderSize = 0
        Me.ButtonResultList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonResultList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonResultList.ForeColor = System.Drawing.Color.White
        Me.ButtonResultList.Location = New System.Drawing.Point(0, 263)
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
        Me.ButtonCloud.Location = New System.Drawing.Point(0, 336)
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
        Me.ButtonUpload.Location = New System.Drawing.Point(0, 62)
        Me.ButtonUpload.Name = "ButtonUpload"
        Me.ButtonUpload.Size = New System.Drawing.Size(128, 55)
        Me.ButtonUpload.TabIndex = 2
        Me.ButtonUpload.Text = "Upload Results"
        Me.ButtonUpload.UseVisualStyleBackColor = True
        '
        'ButtonStudents
        '
        Me.ButtonStudents.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.ButtonStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonStudents.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonStudents.ForeColor = System.Drawing.Color.White
        Me.ButtonStudents.Location = New System.Drawing.Point(31, 227)
        Me.ButtonStudents.Name = "ButtonStudents"
        Me.ButtonStudents.Size = New System.Drawing.Size(128, 55)
        Me.ButtonStudents.TabIndex = 5
        Me.ButtonStudents.Text = "Course Reg."
        Me.ButtonStudents.UseVisualStyleBackColor = True
        '
        'ButtonBroadsheets
        '
        Me.ButtonBroadsheets.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.ButtonBroadsheets.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBroadsheets.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonBroadsheets.ForeColor = System.Drawing.Color.White
        Me.ButtonBroadsheets.Location = New System.Drawing.Point(34, 223)
        Me.ButtonBroadsheets.Name = "ButtonBroadsheets"
        Me.ButtonBroadsheets.Size = New System.Drawing.Size(128, 55)
        Me.ButtonBroadsheets.TabIndex = 0
        Me.ButtonBroadsheets.Text = "View"
        Me.ButtonBroadsheets.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(18, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(454, 37)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Course Adviser's DashBoard"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.ButtonStudents)
        Me.GroupBox2.Controls.Add(Me.ButtonNoOfStudents)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(252, 58)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(206, 288)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Silver
        Me.Label5.Location = New System.Drawing.Point(3, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(200, 24)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Registered Students"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.ButtonResults)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.ButtonResultsSubmitted)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox3.Location = New System.Drawing.Point(16, 55)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(201, 295)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        '
        'ButtonResults
        '
        Me.ButtonResults.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.ButtonResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonResults.ForeColor = System.Drawing.Color.White
        Me.ButtonResults.Location = New System.Drawing.Point(32, 236)
        Me.ButtonResults.Name = "ButtonResults"
        Me.ButtonResults.Size = New System.Drawing.Size(128, 55)
        Me.ButtonResults.TabIndex = 12
        Me.ButtonResults.Text = "View Results"
        Me.ButtonResults.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(13, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 24)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Results Submitted"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ButtonNoOfBroadsheets)
        Me.GroupBox1.Controls.Add(Me.ButtonBroadsheets)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(484, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 288)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(34, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 24)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Broadsheets"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonNoOfBroadsheets
        '
        Me.ButtonNoOfBroadsheets.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonNoOfBroadsheets.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ButtonNoOfBroadsheets.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonNoOfBroadsheets.Font = New System.Drawing.Font("Arial Black", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNoOfBroadsheets.ForeColor = System.Drawing.Color.Silver
        Me.ButtonNoOfBroadsheets.Location = New System.Drawing.Point(12, 21)
        Me.ButtonNoOfBroadsheets.Name = "ButtonNoOfBroadsheets"
        Me.ButtonNoOfBroadsheets.Size = New System.Drawing.Size(173, 143)
        Me.ButtonNoOfBroadsheets.TabIndex = 1
        Me.ButtonNoOfBroadsheets.Text = "2"
        Me.ButtonNoOfBroadsheets.UseVisualStyleBackColor = False
        '
        'TextBoxStatus1
        '
        Me.TextBoxStatus1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.TextBoxStatus1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxStatus1.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.TextBoxStatus1.ForeColor = System.Drawing.Color.Silver
        Me.TextBoxStatus1.Location = New System.Drawing.Point(26, 379)
        Me.TextBoxStatus1.Multiline = True
        Me.TextBoxStatus1.Name = "TextBoxStatus1"
        Me.TextBoxStatus1.Size = New System.Drawing.Size(877, 72)
        Me.TextBoxStatus1.TabIndex = 15
        Me.TextBoxStatus1.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "All Courses have been marked and graded"
        Me.TextBoxStatus1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxStatus2
        '
        Me.TextBoxStatus2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.TextBoxStatus2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxStatus2.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.TextBoxStatus2.ForeColor = System.Drawing.Color.Silver
        Me.TextBoxStatus2.Location = New System.Drawing.Point(25, 458)
        Me.TextBoxStatus2.Multiline = True
        Me.TextBoxStatus2.Name = "TextBoxStatus2"
        Me.TextBoxStatus2.Size = New System.Drawing.Size(877, 72)
        Me.TextBoxStatus2.TabIndex = 16
        Me.TextBoxStatus2.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Departmental Board Meeting is on Friday"
        Me.TextBoxStatus2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.ButtonNoOfSenate)
        Me.GroupBox4.Controls.Add(Me.ButtonSenate)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox4.Location = New System.Drawing.Point(703, 62)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 288)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(34, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 24)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Senate Versions"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonNoOfSenate
        '
        Me.ButtonNoOfSenate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonNoOfSenate.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ButtonNoOfSenate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonNoOfSenate.Font = New System.Drawing.Font("Arial Black", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNoOfSenate.ForeColor = System.Drawing.Color.Silver
        Me.ButtonNoOfSenate.Location = New System.Drawing.Point(12, 21)
        Me.ButtonNoOfSenate.Name = "ButtonNoOfSenate"
        Me.ButtonNoOfSenate.Size = New System.Drawing.Size(173, 143)
        Me.ButtonNoOfSenate.TabIndex = 1
        Me.ButtonNoOfSenate.Text = "1"
        Me.ButtonNoOfSenate.UseVisualStyleBackColor = False
        '
        'ButtonSenate
        '
        Me.ButtonSenate.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.ButtonSenate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSenate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonSenate.ForeColor = System.Drawing.Color.White
        Me.ButtonSenate.Location = New System.Drawing.Point(34, 223)
        Me.ButtonSenate.Name = "ButtonSenate"
        Me.ButtonSenate.Size = New System.Drawing.Size(128, 55)
        Me.ButtonSenate.TabIndex = 0
        Me.ButtonSenate.Text = "View"
        Me.ButtonSenate.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        '
        'FormCourseAdviser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1061, 525)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.TextBoxStatus2)
        Me.Controls.Add(Me.TextBoxStatus1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
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
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonResultsSubmitted As Button
    Friend WithEvents ButtonNoOfStudents As Button
    Friend WithEvents SidePanel As Panel
    Friend WithEvents ButtonResultList As Button
    Friend WithEvents ButtonCloud As Button
    Friend WithEvents ButtonUpload As Button
    Friend WithEvents ButtonBroadsheets As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonStudents As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonGenerateBroadsheet As Button
    Friend WithEvents ButtonResults As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonNoOfBroadsheets As Button
    Friend WithEvents TextBoxStatus1 As TextBox
    Friend WithEvents TextBoxStatus2 As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonNoOfSenate As Button
    Friend WithEvents ButtonSenate As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
