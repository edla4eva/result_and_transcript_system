<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormResultsTranscripts
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxGuestID = New System.Windows.Forms.TextBox()
        Me.dgw = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblSet = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxGuestInfo = New System.Windows.Forms.TextBox()
        Me.TextBoxDate = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.PictureBoxImg = New System.Windows.Forms.PictureBox()
        Me.ButtonAddResult = New System.Windows.Forms.Button()
        Me.ButtonResultsTranscripts = New System.Windows.Forms.Button()
        Me.ButtonTranscript = New System.Windows.Forms.Button()
        Me.ButtonCheck = New System.Windows.Forms.Button()
        Me.ButtonCalcGPA = New System.Windows.Forms.Button()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBoxImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(27, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "MATNO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(27, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Name:"
        '
        'TextBoxGuestID
        '
        Me.TextBoxGuestID.Location = New System.Drawing.Point(81, 61)
        Me.TextBoxGuestID.Name = "TextBoxGuestID"
        Me.TextBoxGuestID.Size = New System.Drawing.Size(93, 20)
        Me.TextBoxGuestID.TabIndex = 11
        '
        'dgw
        '
        Me.dgw.AllowUserToAddRows = False
        Me.dgw.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FloralWhite
        Me.dgw.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgw.BackgroundColor = System.Drawing.Color.White
        Me.dgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.PaleGoldenrod
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgw.ColumnHeadersHeight = 24
        Me.dgw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgw.EnableHeadersVisualStyles = False
        Me.dgw.GridColor = System.Drawing.Color.White
        Me.dgw.Location = New System.Drawing.Point(282, 115)
        Me.dgw.MultiSelect = False
        Me.dgw.Name = "dgw"
        Me.dgw.ReadOnly = True
        Me.dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgw.RowHeadersWidth = 25
        Me.dgw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.dgw.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgw.RowTemplate.Height = 18
        Me.dgw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgw.Size = New System.Drawing.Size(584, 411)
        Me.dgw.TabIndex = 41
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.lblSet)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(282, 47)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(584, 62)
        Me.Panel2.TabIndex = 42
        '
        'lblSet
        '
        Me.lblSet.AutoSize = True
        Me.lblSet.Location = New System.Drawing.Point(64, 27)
        Me.lblSet.Name = "lblSet"
        Me.lblSet.Size = New System.Drawing.Size(23, 13)
        Me.lblSet.TabIndex = 1
        Me.lblSet.Text = "Set"
        Me.lblSet.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(206, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Transcript"
        '
        'TextBoxGuestInfo
        '
        Me.TextBoxGuestInfo.Enabled = False
        Me.TextBoxGuestInfo.Location = New System.Drawing.Point(81, 89)
        Me.TextBoxGuestInfo.Name = "TextBoxGuestInfo"
        Me.TextBoxGuestInfo.Size = New System.Drawing.Size(152, 20)
        Me.TextBoxGuestInfo.TabIndex = 43
        '
        'TextBoxDate
        '
        Me.TextBoxDate.Location = New System.Drawing.Point(81, 124)
        Me.TextBoxDate.Name = "TextBoxDate"
        Me.TextBoxDate.Size = New System.Drawing.Size(10, 20)
        Me.TextBoxDate.TabIndex = 47
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(27, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Date:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(95, 125)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(138, 20)
        Me.DateTimePicker1.TabIndex = 58
        '
        'PictureBoxImg
        '
        Me.PictureBoxImg.Location = New System.Drawing.Point(872, 12)
        Me.PictureBoxImg.Name = "PictureBoxImg"
        Me.PictureBoxImg.Size = New System.Drawing.Size(127, 118)
        Me.PictureBoxImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxImg.TabIndex = 59
        Me.PictureBoxImg.TabStop = False
        '
        'ButtonAddResult
        '
        Me.ButtonAddResult.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonAddResult.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonAddResult.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.ButtonAddResult.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonAddResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAddResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddResult.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonAddResult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonAddResult.Location = New System.Drawing.Point(12, 471)
        Me.ButtonAddResult.Name = "ButtonAddResult"
        Me.ButtonAddResult.Size = New System.Drawing.Size(221, 55)
        Me.ButtonAddResult.TabIndex = 45
        Me.ButtonAddResult.Text = "Add Result"
        Me.ButtonAddResult.UseVisualStyleBackColor = False
        '
        'ButtonResultsTranscripts
        '
        Me.ButtonResultsTranscripts.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonResultsTranscripts.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonResultsTranscripts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.ButtonResultsTranscripts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonResultsTranscripts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonResultsTranscripts.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonResultsTranscripts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonResultsTranscripts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonResultsTranscripts.Location = New System.Drawing.Point(12, 313)
        Me.ButtonResultsTranscripts.Name = "ButtonResultsTranscripts"
        Me.ButtonResultsTranscripts.Size = New System.Drawing.Size(221, 57)
        Me.ButtonResultsTranscripts.TabIndex = 44
        Me.ButtonResultsTranscripts.Text = "Print"
        Me.ButtonResultsTranscripts.UseVisualStyleBackColor = False
        '
        'ButtonTranscript
        '
        Me.ButtonTranscript.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonTranscript.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonTranscript.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.ButtonTranscript.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonTranscript.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonTranscript.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTranscript.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ButtonTranscript.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonTranscript.Location = New System.Drawing.Point(12, 223)
        Me.ButtonTranscript.Name = "ButtonTranscript"
        Me.ButtonTranscript.Size = New System.Drawing.Size(221, 64)
        Me.ButtonTranscript.TabIndex = 8
        Me.ButtonTranscript.Text = "Generate Transcript"
        Me.ButtonTranscript.UseVisualStyleBackColor = False
        '
        'ButtonCheck
        '
        Me.ButtonCheck.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonCheck.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonCheck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.ButtonCheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCheck.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonCheck.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonCheck.Location = New System.Drawing.Point(180, 61)
        Me.ButtonCheck.Name = "ButtonCheck"
        Me.ButtonCheck.Size = New System.Drawing.Size(53, 21)
        Me.ButtonCheck.TabIndex = 7
        Me.ButtonCheck.Text = "check..."
        Me.ButtonCheck.UseVisualStyleBackColor = False
        '
        'ButtonCalcGPA
        '
        Me.ButtonCalcGPA.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonCalcGPA.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonCalcGPA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.ButtonCalcGPA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonCalcGPA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCalcGPA.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCalcGPA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonCalcGPA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonCalcGPA.Location = New System.Drawing.Point(12, 393)
        Me.ButtonCalcGPA.Name = "ButtonCalcGPA"
        Me.ButtonCalcGPA.Size = New System.Drawing.Size(221, 59)
        Me.ButtonCalcGPA.TabIndex = 60
        Me.ButtonCalcGPA.Text = "Compute GPA"
        Me.ButtonCalcGPA.UseVisualStyleBackColor = False
        '
        'FormResultsTranscripts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1011, 624)
        Me.Controls.Add(Me.ButtonCalcGPA)
        Me.Controls.Add(Me.PictureBoxImg)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBoxDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ButtonAddResult)
        Me.Controls.Add(Me.ButtonResultsTranscripts)
        Me.Controls.Add(Me.TextBoxGuestInfo)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dgw)
        Me.Controls.Add(Me.TextBoxGuestID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonTranscript)
        Me.Controls.Add(Me.ButtonCheck)
        Me.Name = "FormResultsTranscripts"
        Me.Tag = "Front"
        Me.Text = "Results - Transcript"
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBoxImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonCheck As Button
    Friend WithEvents ButtonTranscript As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxGuestID As TextBox
    Friend WithEvents dgw As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblSet As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxGuestInfo As TextBox
    Friend WithEvents ButtonResultsTranscripts As Button
    Friend WithEvents ButtonAddResult As Button
    Friend WithEvents TextBoxDate As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents PictureBoxImg As PictureBox
    Friend WithEvents ButtonCalcGPA As Button
End Class
