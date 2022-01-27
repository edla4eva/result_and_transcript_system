<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCourseMarkSheets
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvCourseMarkSheet = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblSet = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProgressBarBS = New System.Windows.Forms.ProgressBar()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.ComboBoxCourseCode = New System.Windows.Forms.ComboBox()
        Me.ComboBoxDepartments = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxdept_idr = New System.Windows.Forms.TextBox()
        Me.ComboBoxSessions = New System.Windows.Forms.ComboBox()
        Me.ComboBoxLevel = New System.Windows.Forms.ComboBox()
        Me.ButtonRefreshFormview = New System.Windows.Forms.Button()
        Me.TextBoxCourseCode = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.ButtonRegToExcel = New System.Windows.Forms.Button()
        Me.TimerBS = New System.Windows.Forms.Timer(Me.components)
        Me.bgwLoad = New System.ComponentModel.BackgroundWorker()
        Me.ButtonOpenCourseMarkSheet = New System.Windows.Forms.Button()
        Me.PanelAllReg = New System.Windows.Forms.Panel()
        Me.ButtonBack = New System.Windows.Forms.Button()
        Me.BindingSourceStudents = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBoxTemplateFileName = New System.Windows.Forms.TextBox()
        Me.ButtonOpen = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvCourseMarkSheet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.PanelAllReg.SuspendLayout()
        CType(Me.BindingSourceStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.dgvCourseMarkSheet)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(19, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(652, 498)
        Me.Panel1.TabIndex = 10
        '
        'dgvCourseMarkSheet
        '
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black
        Me.dgvCourseMarkSheet.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvCourseMarkSheet.BackgroundColor = System.Drawing.Color.Silver
        Me.dgvCourseMarkSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCourseMarkSheet.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgvCourseMarkSheet.GridColor = System.Drawing.Color.Gray
        Me.dgvCourseMarkSheet.Location = New System.Drawing.Point(9, 63)
        Me.dgvCourseMarkSheet.Name = "dgvCourseMarkSheet"
        Me.dgvCourseMarkSheet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCourseMarkSheet.Size = New System.Drawing.Size(630, 413)
        Me.dgvCourseMarkSheet.TabIndex = 77
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.lblSet)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(9, 7)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(723, 50)
        Me.Panel2.TabIndex = 0
        '
        'lblSet
        '
        Me.lblSet.AutoSize = True
        Me.lblSet.Location = New System.Drawing.Point(64, 21)
        Me.lblSet.Name = "lblSet"
        Me.lblSet.Size = New System.Drawing.Size(28, 16)
        Me.lblSet.TabIndex = 1
        Me.lblSet.Text = "Set"
        Me.lblSet.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(234, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Course Mark Sheets"
        '
        'ProgressBarBS
        '
        Me.ProgressBarBS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBarBS.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ProgressBarBS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ProgressBarBS.Location = New System.Drawing.Point(12, 547)
        Me.ProgressBarBS.Name = "ProgressBarBS"
        Me.ProgressBarBS.Size = New System.Drawing.Size(659, 23)
        Me.ProgressBarBS.TabIndex = 75
        Me.ProgressBarBS.Value = 1
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.ComboBoxCourseCode)
        Me.Panel5.Controls.Add(Me.ComboBoxDepartments)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.TextBoxdept_idr)
        Me.Panel5.Controls.Add(Me.ComboBoxSessions)
        Me.Panel5.Controls.Add(Me.ComboBoxLevel)
        Me.Panel5.Controls.Add(Me.ButtonRefreshFormview)
        Me.Panel5.Controls.Add(Me.TextBoxCourseCode)
        Me.Panel5.Location = New System.Drawing.Point(12, 63)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(296, 303)
        Me.Panel5.TabIndex = 42
        '
        'ComboBoxCourseCode
        '
        Me.ComboBoxCourseCode.AutoCompleteCustomSource.AddRange(New String() {"2019/2020"})
        Me.ComboBoxCourseCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxCourseCode.FormattingEnabled = True
        Me.ComboBoxCourseCode.Items.AddRange(New Object() {"CPE375"})
        Me.ComboBoxCourseCode.Location = New System.Drawing.Point(9, 147)
        Me.ComboBoxCourseCode.Name = "ComboBoxCourseCode"
        Me.ComboBoxCourseCode.Size = New System.Drawing.Size(272, 39)
        Me.ComboBoxCourseCode.TabIndex = 94
        Me.ComboBoxCourseCode.Text = "CPE375"
        '
        'ComboBoxDepartments
        '
        Me.ComboBoxDepartments.FormattingEnabled = True
        Me.ComboBoxDepartments.Items.AddRange(New Object() {"Computer Engineering", "Production Engineering"})
        Me.ComboBoxDepartments.Location = New System.Drawing.Point(6, 6)
        Me.ComboBoxDepartments.Name = "ComboBoxDepartments"
        Me.ComboBoxDepartments.Size = New System.Drawing.Size(275, 24)
        Me.ComboBoxDepartments.TabIndex = 25
        Me.ComboBoxDepartments.Text = "Computer Engineering"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 16)
        Me.Label5.TabIndex = 83
        Me.Label5.Text = "Course Code"
        '
        'TextBoxdept_idr
        '
        Me.TextBoxdept_idr.BackColor = System.Drawing.Color.White
        Me.TextBoxdept_idr.Enabled = False
        Me.TextBoxdept_idr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxdept_idr.Location = New System.Drawing.Point(3, 6)
        Me.TextBoxdept_idr.Name = "TextBoxdept_idr"
        Me.TextBoxdept_idr.Size = New System.Drawing.Size(41, 21)
        Me.TextBoxdept_idr.TabIndex = 117
        Me.TextBoxdept_idr.Text = "1"
        '
        'ComboBoxSessions
        '
        Me.ComboBoxSessions.AutoCompleteCustomSource.AddRange(New String() {"2019/2020"})
        Me.ComboBoxSessions.FormattingEnabled = True
        Me.ComboBoxSessions.Items.AddRange(New Object() {"2018/2019", "2019/2020"})
        Me.ComboBoxSessions.Location = New System.Drawing.Point(6, 35)
        Me.ComboBoxSessions.Name = "ComboBoxSessions"
        Me.ComboBoxSessions.Size = New System.Drawing.Size(169, 24)
        Me.ComboBoxSessions.TabIndex = 31
        Me.ComboBoxSessions.Text = "2018/2019"
        '
        'ComboBoxLevel
        '
        Me.ComboBoxLevel.FormattingEnabled = True
        Me.ComboBoxLevel.Items.AddRange(New Object() {"100", "200", "300", "400", "500", "600", "700", "800", "900"})
        Me.ComboBoxLevel.Location = New System.Drawing.Point(6, 65)
        Me.ComboBoxLevel.Name = "ComboBoxLevel"
        Me.ComboBoxLevel.Size = New System.Drawing.Size(169, 24)
        Me.ComboBoxLevel.TabIndex = 30
        Me.ComboBoxLevel.Text = "100"
        '
        'ButtonRefreshFormview
        '
        Me.ButtonRefreshFormview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRefreshFormview.Location = New System.Drawing.Point(9, 202)
        Me.ButtonRefreshFormview.Name = "ButtonRefreshFormview"
        Me.ButtonRefreshFormview.Size = New System.Drawing.Size(272, 73)
        Me.ButtonRefreshFormview.TabIndex = 13
        Me.ButtonRefreshFormview.Text = "Generate Course Marks Sheet"
        Me.ButtonRefreshFormview.UseVisualStyleBackColor = True
        '
        'TextBoxCourseCode
        '
        Me.TextBoxCourseCode.Location = New System.Drawing.Point(85, 145)
        Me.TextBoxCourseCode.Name = "TextBoxCourseCode"
        Me.TextBoxCourseCode.Size = New System.Drawing.Size(10, 22)
        Me.TextBoxCourseCode.TabIndex = 84
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(1000, 645)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(124, 28)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'ButtonRegToExcel
        '
        Me.ButtonRegToExcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonRegToExcel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonRegToExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRegToExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRegToExcel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ButtonRegToExcel.Location = New System.Drawing.Point(1001, 300)
        Me.ButtonRegToExcel.Name = "ButtonRegToExcel"
        Me.ButtonRegToExcel.Size = New System.Drawing.Size(122, 43)
        Me.ButtonRegToExcel.TabIndex = 9
        Me.ButtonRegToExcel.Text = "Export to Excel"
        Me.ButtonRegToExcel.UseVisualStyleBackColor = True
        '
        'TimerBS
        '
        Me.TimerBS.Enabled = True
        Me.TimerBS.Interval = 1000
        '
        'bgwLoad
        '
        '
        'ButtonOpenCourseMarkSheet
        '
        Me.ButtonOpenCourseMarkSheet.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonOpenCourseMarkSheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOpenCourseMarkSheet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonOpenCourseMarkSheet.ForeColor = System.Drawing.Color.White
        Me.ButtonOpenCourseMarkSheet.Location = New System.Drawing.Point(1001, 239)
        Me.ButtonOpenCourseMarkSheet.Name = "ButtonOpenCourseMarkSheet"
        Me.ButtonOpenCourseMarkSheet.Size = New System.Drawing.Size(122, 55)
        Me.ButtonOpenCourseMarkSheet.TabIndex = 84
        Me.ButtonOpenCourseMarkSheet.Text = "Open Course Mark Sheet"
        Me.ButtonOpenCourseMarkSheet.UseVisualStyleBackColor = True
        '
        'PanelAllReg
        '
        Me.PanelAllReg.AutoScroll = True
        Me.PanelAllReg.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanelAllReg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelAllReg.Controls.Add(Me.ButtonOpen)
        Me.PanelAllReg.Controls.Add(Me.TextBoxTemplateFileName)
        Me.PanelAllReg.Controls.Add(Me.Panel5)
        Me.PanelAllReg.Location = New System.Drawing.Point(677, 43)
        Me.PanelAllReg.Name = "PanelAllReg"
        Me.PanelAllReg.Size = New System.Drawing.Size(313, 631)
        Me.PanelAllReg.TabIndex = 85
        '
        'ButtonBack
        '
        Me.ButtonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBack.Image = Global.result_and_transcript_system.My.Resources.Resources.arrow_back_regular_24
        Me.ButtonBack.Location = New System.Drawing.Point(1006, 8)
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.Size = New System.Drawing.Size(119, 23)
        Me.ButtonBack.TabIndex = 91
        Me.ButtonBack.UseVisualStyleBackColor = True
        '
        'TextBoxTemplateFileName
        '
        Me.TextBoxTemplateFileName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBoxTemplateFileName.Location = New System.Drawing.Point(12, 411)
        Me.TextBoxTemplateFileName.Name = "TextBoxTemplateFileName"
        Me.TextBoxTemplateFileName.Size = New System.Drawing.Size(282, 22)
        Me.TextBoxTemplateFileName.TabIndex = 43
        '
        'ButtonOpen
        '
        Me.ButtonOpen.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOpen.ForeColor = System.Drawing.Color.White
        Me.ButtonOpen.Location = New System.Drawing.Point(219, 439)
        Me.ButtonOpen.Name = "ButtonOpen"
        Me.ButtonOpen.Size = New System.Drawing.Size(75, 23)
        Me.ButtonOpen.TabIndex = 44
        Me.ButtonOpen.Text = "Open"
        Me.ButtonOpen.UseVisualStyleBackColor = False
        '
        'FormCourseMarkSheets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1131, 733)
        Me.Controls.Add(Me.ButtonBack)
        Me.Controls.Add(Me.ButtonOpenCourseMarkSheet)
        Me.Controls.Add(Me.ButtonRegToExcel)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelAllReg)
        Me.Controls.Add(Me.ProgressBarBS)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormCourseMarkSheets"
        Me.Text = "Course MarkSheets"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvCourseMarkSheet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.PanelAllReg.ResumeLayout(False)
        Me.PanelAllReg.PerformLayout()
        CType(Me.BindingSourceStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TimerBS As Timer
    Friend WithEvents ProgressBarBS As ProgressBar
    Friend WithEvents dgvCourseMarkSheet As DataGridView
    Friend WithEvents ComboBoxDepartments As ComboBox
    Friend WithEvents ComboBoxSessions As ComboBox
    Friend WithEvents ComboBoxLevel As ComboBox
    Friend WithEvents ButtonRegToExcel As Button
    Friend WithEvents ButtonOpenCourseMarkSheet As Button
    Friend WithEvents PanelAllReg As Panel
    Friend WithEvents ButtonRefreshFormview As Button
    Friend WithEvents BindingSourceStudents As BindingSource
    Friend WithEvents TextBoxdept_idr As TextBox
    Friend WithEvents ButtonBack As Button
    Private WithEvents bgwLoad As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblSet As Label
    Friend WithEvents ComboBoxCourseCode As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxCourseCode As TextBox
    Friend WithEvents TextBoxTemplateFileName As TextBox
    Friend WithEvents ButtonOpen As Button
End Class
