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
        Me.SidePanel.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonResultsSubmitted
        '
        Me.ButtonResultsSubmitted.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonResultsSubmitted.BackColor = System.Drawing.Color.Transparent
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
        Me.ButtonNoOfStudents.BackColor = System.Drawing.Color.Transparent
        Me.ButtonNoOfStudents.Font = New System.Drawing.Font("Arial Black", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNoOfStudents.ForeColor = System.Drawing.Color.Silver
        Me.ButtonNoOfStudents.Location = New System.Drawing.Point(9, 21)
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
        Me.SidePanel.Location = New System.Drawing.Point(720, 0)
        Me.SidePanel.Name = "SidePanel"
        Me.SidePanel.Size = New System.Drawing.Size(134, 476)
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
        Me.ButtonStudents.Text = "View Students"
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
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(381, 37)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Course Adviser's DashBoard"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.ButtonStudents)
        Me.GroupBox2.Controls.Add(Me.ButtonNoOfStudents)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(262, 58)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 288)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Silver
        Me.Label5.Location = New System.Drawing.Point(6, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(193, 24)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Number of Students"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
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
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
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
        Me.Label3.Text = "Breadsheets"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonNoOfBroadsheets
        '
        Me.ButtonNoOfBroadsheets.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonNoOfBroadsheets.BackColor = System.Drawing.Color.Transparent
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
        Me.TextBoxStatus1.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.TextBoxStatus1.ForeColor = System.Drawing.Color.Silver
        Me.TextBoxStatus1.Location = New System.Drawing.Point(26, 402)
        Me.TextBoxStatus1.Multiline = True
        Me.TextBoxStatus1.Name = "TextBoxStatus1"
        Me.TextBoxStatus1.Size = New System.Drawing.Size(658, 42)
        Me.TextBoxStatus1.TabIndex = 15
        Me.TextBoxStatus1.Text = "All Courses have been marked and graded"
        '
        'TextBoxStatus2
        '
        Me.TextBoxStatus2.Font = New System.Drawing.Font("Arial", 15.75!)
        Me.TextBoxStatus2.ForeColor = System.Drawing.Color.Silver
        Me.TextBoxStatus2.Location = New System.Drawing.Point(25, 450)
        Me.TextBoxStatus2.Multiline = True
        Me.TextBoxStatus2.Name = "TextBoxStatus2"
        Me.TextBoxStatus2.Size = New System.Drawing.Size(658, 42)
        Me.TextBoxStatus2.TabIndex = 16
        Me.TextBoxStatus2.Text = "Departmental Board Meeting is on Friday"
        '
        'FormCourseAdviser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(854, 476)
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
End Class
