<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBroadsheets
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxSession = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxDepartment = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LabelProgress = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.toDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.fromDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ButtonGenerateAddResultFromDBtoBS = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ButtonGenerateBroadsheet = New System.Windows.Forms.Button()
        Me.ButtonAutoExcel = New System.Windows.Forms.Button()
        Me.ComboBoxTemplate = New System.Windows.Forms.ComboBox()
        Me.ButtonOLE = New System.Windows.Forms.Button()
        Me.ButtonInsertExcel = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonAddStuRecordstoBS = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(689, 16)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(391, 51)
        Me.ReportViewer1.TabIndex = 35
        '
        'ComboBox5
        '
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"SN", "MATNO", "Surname", "OtherNames", "CA", "Exam", "Score"})
        Me.ComboBox5.Location = New System.Drawing.Point(534, 59)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox5.TabIndex = 34
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"SN", "MATNO", "Surname", "OtherNames", "CA", "Exam", "Score"})
        Me.ComboBox4.Location = New System.Drawing.Point(403, 59)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox4.TabIndex = 33
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"SN", "MATNO", "Surname", "OtherNames", "CA", "Exam", "Score"})
        Me.ComboBox3.Location = New System.Drawing.Point(276, 59)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox3.TabIndex = 32
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"SN", "MATNO", "Surname", "OtherNames", "CA", "Exam", "Score"})
        Me.ComboBox2.Location = New System.Drawing.Point(149, 59)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(685, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Session:"
        '
        'TextBoxSession
        '
        Me.TextBoxSession.Location = New System.Drawing.Point(689, 156)
        Me.TextBoxSession.Name = "TextBoxSession"
        Me.TextBoxSession.Size = New System.Drawing.Size(238, 20)
        Me.TextBoxSession.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(685, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Department:"
        '
        'TextBoxDepartment
        '
        Me.TextBoxDepartment.Location = New System.Drawing.Point(689, 90)
        Me.TextBoxDepartment.Name = "TextBoxDepartment"
        Me.TextBoxDepartment.Size = New System.Drawing.Size(238, 20)
        Me.TextBoxDepartment.TabIndex = 27
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"SN", "MATNO", "Surname", "OtherNames", "CA", "Exam", "Score"})
        Me.ComboBox1.Location = New System.Drawing.Point(22, 59)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 26
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'LabelProgress
        '
        Me.LabelProgress.AutoSize = True
        Me.LabelProgress.Location = New System.Drawing.Point(547, 407)
        Me.LabelProgress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelProgress.Name = "LabelProgress"
        Me.LabelProgress.Size = New System.Drawing.Size(0, 13)
        Me.LabelProgress.TabIndex = 24
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(22, 16)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(634, 35)
        Me.ProgressBar1.TabIndex = 23
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(22, 95)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(634, 528)
        Me.DataGridView1.TabIndex = 22
        '
        'toDateTimePicker
        '
        Me.toDateTimePicker.Location = New System.Drawing.Point(688, 364)
        Me.toDateTimePicker.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.toDateTimePicker.Name = "toDateTimePicker"
        Me.toDateTimePicker.Size = New System.Drawing.Size(298, 20)
        Me.toDateTimePicker.TabIndex = 20
        '
        'fromDateTimePicker
        '
        Me.fromDateTimePicker.Location = New System.Drawing.Point(688, 328)
        Me.fromDateTimePicker.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fromDateTimePicker.Name = "fromDateTimePicker"
        Me.fromDateTimePicker.Size = New System.Drawing.Size(298, 20)
        Me.fromDateTimePicker.TabIndex = 19
        '
        'ButtonGenerateAddResultFromDBtoBS
        '
        Me.ButtonGenerateAddResultFromDBtoBS.Location = New System.Drawing.Point(689, 184)
        Me.ButtonGenerateAddResultFromDBtoBS.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonGenerateAddResultFromDBtoBS.Name = "ButtonGenerateAddResultFromDBtoBS"
        Me.ButtonGenerateAddResultFromDBtoBS.Size = New System.Drawing.Size(242, 43)
        Me.ButtonGenerateAddResultFromDBtoBS.TabIndex = 18
        Me.ButtonGenerateAddResultFromDBtoBS.Text = "iteratively add Results from DB to Broadsheet"
        Me.ButtonGenerateAddResultFromDBtoBS.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        '
        'ButtonGenerateBroadsheet
        '
        Me.ButtonGenerateBroadsheet.Location = New System.Drawing.Point(689, 237)
        Me.ButtonGenerateBroadsheet.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonGenerateBroadsheet.Name = "ButtonGenerateBroadsheet"
        Me.ButtonGenerateBroadsheet.Size = New System.Drawing.Size(167, 40)
        Me.ButtonGenerateBroadsheet.TabIndex = 21
        Me.ButtonGenerateBroadsheet.Text = "Generate Broadsheet"
        Me.ButtonGenerateBroadsheet.UseVisualStyleBackColor = True
        '
        'ButtonAutoExcel
        '
        Me.ButtonAutoExcel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonAutoExcel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonAutoExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.ButtonAutoExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonAutoExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAutoExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAutoExcel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonAutoExcel.Image = Global.eResult.My.Resources.Resources.open16a
        Me.ButtonAutoExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonAutoExcel.Location = New System.Drawing.Point(687, 383)
        Me.ButtonAutoExcel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonAutoExcel.Name = "ButtonAutoExcel"
        Me.ButtonAutoExcel.Size = New System.Drawing.Size(239, 42)
        Me.ButtonAutoExcel.TabIndex = 25
        Me.ButtonAutoExcel.Text = "Fill Datagrid DB"
        Me.ButtonAutoExcel.UseVisualStyleBackColor = False
        '
        'ComboBoxTemplate
        '
        Me.ComboBoxTemplate.FormattingEnabled = True
        Me.ComboBoxTemplate.Items.AddRange(New Object() {"100 Level Computer Engineering", "200 Level Computer Engineering", "300 Level Computer Engineering (pre 2015/2016)"})
        Me.ComboBoxTemplate.Location = New System.Drawing.Point(806, 116)
        Me.ComboBoxTemplate.Name = "ComboBoxTemplate"
        Me.ComboBoxTemplate.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxTemplate.TabIndex = 36
        '
        'ButtonOLE
        '
        Me.ButtonOLE.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonOLE.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonOLE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.ButtonOLE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonOLE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOLE.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOLE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonOLE.Image = Global.eResult.My.Resources.Resources.open16a
        Me.ButtonOLE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonOLE.Location = New System.Drawing.Point(687, 481)
        Me.ButtonOLE.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonOLE.Name = "ButtonOLE"
        Me.ButtonOLE.Size = New System.Drawing.Size(217, 42)
        Me.ButtonOLE.TabIndex = 37
        Me.ButtonOLE.Text = "OLEDB Excel"
        Me.ButtonOLE.UseVisualStyleBackColor = False
        '
        'ButtonInsertExcel
        '
        Me.ButtonInsertExcel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonInsertExcel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonInsertExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.ButtonInsertExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonInsertExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonInsertExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonInsertExcel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonInsertExcel.Image = Global.eResult.My.Resources.Resources.open16a
        Me.ButtonInsertExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonInsertExcel.Location = New System.Drawing.Point(687, 429)
        Me.ButtonInsertExcel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonInsertExcel.Name = "ButtonInsertExcel"
        Me.ButtonInsertExcel.Size = New System.Drawing.Size(283, 42)
        Me.ButtonInsertExcel.TabIndex = 38
        Me.ButtonInsertExcel.Text = "Insert into Excel fr Grid"
        Me.ButtonInsertExcel.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(686, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Select Template:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(689, 287)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(242, 40)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "Format Broadsheet"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ButtonAddStuRecordstoBS
        '
        Me.ButtonAddStuRecordstoBS.Location = New System.Drawing.Point(864, 237)
        Me.ButtonAddStuRecordstoBS.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonAddStuRecordstoBS.Name = "ButtonAddStuRecordstoBS"
        Me.ButtonAddStuRecordstoBS.Size = New System.Drawing.Size(167, 40)
        Me.ButtonAddStuRecordstoBS.TabIndex = 41
        Me.ButtonAddStuRecordstoBS.Text = "Add Stu Reg Records to BS"
        Me.ButtonAddStuRecordstoBS.UseVisualStyleBackColor = True
        '
        'FormBroadsheets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1109, 533)
        Me.Controls.Add(Me.ButtonAddStuRecordstoBS)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonInsertExcel)
        Me.Controls.Add(Me.ButtonOLE)
        Me.Controls.Add(Me.ComboBoxTemplate)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.ComboBox5)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxSession)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxDepartment)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ButtonAutoExcel)
        Me.Controls.Add(Me.LabelProgress)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.toDateTimePicker)
        Me.Controls.Add(Me.fromDateTimePicker)
        Me.Controls.Add(Me.ButtonGenerateAddResultFromDBtoBS)
        Me.Controls.Add(Me.ButtonGenerateBroadsheet)
        Me.Name = "FormBroadsheets"
        Me.Text = "FormBroadsheets"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxSession As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxDepartment As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonAutoExcel As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LabelProgress As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents toDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents fromDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ButtonGenerateAddResultFromDBtoBS As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ButtonGenerateBroadsheet As System.Windows.Forms.Button
    Friend WithEvents ComboBoxTemplate As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonOLE As System.Windows.Forms.Button
    Friend WithEvents ButtonInsertExcel As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ButtonAddStuRecordstoBS As System.Windows.Forms.Button
End Class
