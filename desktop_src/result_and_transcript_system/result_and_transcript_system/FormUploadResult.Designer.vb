<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUploadResult
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
        Me.TextBoxExcelFilename = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SidePanel = New System.Windows.Forms.Panel()
        Me.ButtonBatchUpload = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.ButtonCheck = New System.Windows.Forms.Button()
        Me.ButtonResultList = New System.Windows.Forms.Button()
        Me.ButtonCloud = New System.Windows.Forms.Button()
        Me.ButtonUpload = New System.Windows.Forms.Button()
        Me.ButtonPreview = New System.Windows.Forms.Button()
        Me.ButtonBrowse = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBoxPrefix = New System.Windows.Forms.TextBox()
        Me.CheckBoxPrefix = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBoxCourseCode = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBoxLevel = New System.Windows.Forms.ComboBox()
        Me.ComboBoxDepartments = New System.Windows.Forms.ComboBox()
        Me.ComboBoxSessions = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBoxCourseCode = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBoxLevel = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxSession = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxDepartment = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.ComboBox7 = New System.Windows.Forms.ComboBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.CheckBoxCustomOrder = New System.Windows.Forms.CheckBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.TextBoxResultsDir = New System.Windows.Forms.TextBox()
        Me.BackgroundWorkerBatch = New System.ComponentModel.BackgroundWorker()
        Me.ListBoxBatch = New System.Windows.Forms.ListBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SidePanel.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxExcelFilename
        '
        Me.TextBoxExcelFilename.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxExcelFilename.Location = New System.Drawing.Point(44, 52)
        Me.TextBoxExcelFilename.Name = "TextBoxExcelFilename"
        Me.TextBoxExcelFilename.Size = New System.Drawing.Size(541, 20)
        Me.TextBoxExcelFilename.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Filename (Excel file .xlsx)"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.GridColor = System.Drawing.Color.Black
        Me.DataGridView1.Location = New System.Drawing.Point(44, 118)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Size = New System.Drawing.Size(505, 388)
        Me.DataGridView1.TabIndex = 3
        '
        'SidePanel
        '
        Me.SidePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.SidePanel.Controls.Add(Me.ButtonBatchUpload)
        Me.SidePanel.Controls.Add(Me.ButtonClose)
        Me.SidePanel.Controls.Add(Me.ButtonCheck)
        Me.SidePanel.Controls.Add(Me.ButtonResultList)
        Me.SidePanel.Controls.Add(Me.ButtonCloud)
        Me.SidePanel.Controls.Add(Me.ButtonUpload)
        Me.SidePanel.Controls.Add(Me.ButtonPreview)
        Me.SidePanel.Controls.Add(Me.ButtonBrowse)
        Me.SidePanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.SidePanel.Location = New System.Drawing.Point(779, 0)
        Me.SidePanel.Name = "SidePanel"
        Me.SidePanel.Size = New System.Drawing.Size(134, 566)
        Me.SidePanel.TabIndex = 6
        '
        'ButtonBatchUpload
        '
        Me.ButtonBatchUpload.FlatAppearance.BorderSize = 0
        Me.ButtonBatchUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBatchUpload.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonBatchUpload.ForeColor = System.Drawing.Color.White
        Me.ButtonBatchUpload.Location = New System.Drawing.Point(3, 20)
        Me.ButtonBatchUpload.Name = "ButtonBatchUpload"
        Me.ButtonBatchUpload.Size = New System.Drawing.Size(128, 55)
        Me.ButtonBatchUpload.TabIndex = 9
        Me.ButtonBatchUpload.Text = "Upload All..."
        Me.ButtonBatchUpload.UseVisualStyleBackColor = True
        '
        'ButtonClose
        '
        Me.ButtonClose.FlatAppearance.BorderSize = 0
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonClose.ForeColor = System.Drawing.Color.White
        Me.ButtonClose.Location = New System.Drawing.Point(3, 508)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(128, 55)
        Me.ButtonClose.TabIndex = 8
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'ButtonCheck
        '
        Me.ButtonCheck.Enabled = False
        Me.ButtonCheck.FlatAppearance.BorderSize = 0
        Me.ButtonCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonCheck.ForeColor = System.Drawing.Color.White
        Me.ButtonCheck.Location = New System.Drawing.Point(3, 222)
        Me.ButtonCheck.Name = "ButtonCheck"
        Me.ButtonCheck.Size = New System.Drawing.Size(128, 55)
        Me.ButtonCheck.TabIndex = 5
        Me.ButtonCheck.Text = "Check Result"
        Me.ButtonCheck.UseVisualStyleBackColor = True
        '
        'ButtonResultList
        '
        Me.ButtonResultList.FlatAppearance.BorderSize = 0
        Me.ButtonResultList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonResultList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonResultList.ForeColor = System.Drawing.Color.White
        Me.ButtonResultList.Location = New System.Drawing.Point(3, 365)
        Me.ButtonResultList.Name = "ButtonResultList"
        Me.ButtonResultList.Size = New System.Drawing.Size(128, 55)
        Me.ButtonResultList.TabIndex = 4
        Me.ButtonResultList.Text = "List Results"
        Me.ButtonResultList.UseVisualStyleBackColor = True
        '
        'ButtonCloud
        '
        Me.ButtonCloud.FlatAppearance.BorderSize = 0
        Me.ButtonCloud.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCloud.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonCloud.ForeColor = System.Drawing.Color.White
        Me.ButtonCloud.Location = New System.Drawing.Point(3, 426)
        Me.ButtonCloud.Name = "ButtonCloud"
        Me.ButtonCloud.Size = New System.Drawing.Size(128, 55)
        Me.ButtonCloud.TabIndex = 3
        Me.ButtonCloud.Text = "Sync Cloud"
        Me.ButtonCloud.UseVisualStyleBackColor = True
        '
        'ButtonUpload
        '
        Me.ButtonUpload.Enabled = False
        Me.ButtonUpload.FlatAppearance.BorderSize = 0
        Me.ButtonUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonUpload.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonUpload.ForeColor = System.Drawing.Color.White
        Me.ButtonUpload.Location = New System.Drawing.Point(3, 316)
        Me.ButtonUpload.Name = "ButtonUpload"
        Me.ButtonUpload.Size = New System.Drawing.Size(128, 55)
        Me.ButtonUpload.TabIndex = 2
        Me.ButtonUpload.Text = "Upload"
        Me.ButtonUpload.UseVisualStyleBackColor = True
        '
        'ButtonPreview
        '
        Me.ButtonPreview.Enabled = False
        Me.ButtonPreview.FlatAppearance.BorderSize = 0
        Me.ButtonPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonPreview.ForeColor = System.Drawing.Color.White
        Me.ButtonPreview.Location = New System.Drawing.Point(3, 161)
        Me.ButtonPreview.Name = "ButtonPreview"
        Me.ButtonPreview.Size = New System.Drawing.Size(128, 55)
        Me.ButtonPreview.TabIndex = 1
        Me.ButtonPreview.Text = "Preview Result"
        Me.ButtonPreview.UseVisualStyleBackColor = True
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
        Me.ButtonBrowse.Text = "Browse..."
        Me.ButtonBrowse.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TextBoxPrefix)
        Me.GroupBox1.Controls.Add(Me.CheckBoxPrefix)
        Me.GroupBox1.Location = New System.Drawing.Point(571, 118)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(189, 65)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MATNO Settings"
        '
        'TextBoxPrefix
        '
        Me.TextBoxPrefix.Location = New System.Drawing.Point(7, 19)
        Me.TextBoxPrefix.Name = "TextBoxPrefix"
        Me.TextBoxPrefix.Size = New System.Drawing.Size(66, 20)
        Me.TextBoxPrefix.TabIndex = 1
        Me.TextBoxPrefix.Text = "ENG"
        '
        'CheckBoxPrefix
        '
        Me.CheckBoxPrefix.AutoSize = True
        Me.CheckBoxPrefix.Location = New System.Drawing.Point(79, 19)
        Me.CheckBoxPrefix.Name = "CheckBoxPrefix"
        Me.CheckBoxPrefix.Size = New System.Drawing.Size(74, 17)
        Me.CheckBoxPrefix.TabIndex = 0
        Me.CheckBoxPrefix.Text = "Add Prefix"
        Me.CheckBoxPrefix.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Button7)
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.ComboBoxCourseCode)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.ComboBoxLevel)
        Me.GroupBox2.Controls.Add(Me.ComboBoxDepartments)
        Me.GroupBox2.Controls.Add(Me.ComboBoxSessions)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.TextBoxCourseCode)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TextBoxLevel)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TextBoxSession)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TextBoxDepartment)
        Me.GroupBox2.Location = New System.Drawing.Point(571, 198)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(189, 273)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Details"
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(158, 70)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(25, 23)
        Me.Button7.TabIndex = 40
        Me.Button7.Text = "R"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(159, 43)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(25, 23)
        Me.Button6.TabIndex = 39
        Me.Button6.Text = "+"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(164, 113)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(25, 23)
        Me.Button4.TabIndex = 38
        Me.Button4.Text = "+"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(136, 113)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(25, 23)
        Me.Button5.TabIndex = 37
        Me.Button5.Text = "R"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(164, 160)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(25, 23)
        Me.Button3.TabIndex = 36
        Me.Button3.Text = "+"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(136, 160)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(25, 23)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "R"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ComboBoxCourseCode
        '
        Me.ComboBoxCourseCode.AutoCompleteCustomSource.AddRange(New String() {"2019/2020"})
        Me.ComboBoxCourseCode.FormattingEnabled = True
        Me.ComboBoxCourseCode.Items.AddRange(New Object() {"CPE375"})
        Me.ComboBoxCourseCode.Location = New System.Drawing.Point(79, 212)
        Me.ComboBoxCourseCode.Name = "ComboBoxCourseCode"
        Me.ComboBoxCourseCode.Size = New System.Drawing.Size(74, 21)
        Me.ComboBoxCourseCode.TabIndex = 34
        Me.ComboBoxCourseCode.Text = "CPE375"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(159, 209)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 23)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBoxLevel
        '
        Me.ComboBoxLevel.FormattingEnabled = True
        Me.ComboBoxLevel.Items.AddRange(New Object() {"100", "200", "300", "400", "500", "600", "700", "800", "900"})
        Me.ComboBoxLevel.Location = New System.Drawing.Point(30, 162)
        Me.ComboBoxLevel.Name = "ComboBoxLevel"
        Me.ComboBoxLevel.Size = New System.Drawing.Size(100, 21)
        Me.ComboBoxLevel.TabIndex = 32
        Me.ComboBoxLevel.Text = "100"
        '
        'ComboBoxDepartments
        '
        Me.ComboBoxDepartments.FormattingEnabled = True
        Me.ComboBoxDepartments.Items.AddRange(New Object() {"Computer Engineering", "Production Engineering"})
        Me.ComboBoxDepartments.Location = New System.Drawing.Point(7, 70)
        Me.ComboBoxDepartments.Name = "ComboBoxDepartments"
        Me.ComboBoxDepartments.Size = New System.Drawing.Size(146, 21)
        Me.ComboBoxDepartments.TabIndex = 31
        Me.ComboBoxDepartments.Text = "Computer Engineering"
        '
        'ComboBoxSessions
        '
        Me.ComboBoxSessions.AutoCompleteCustomSource.AddRange(New String() {"2019/2020"})
        Me.ComboBoxSessions.FormattingEnabled = True
        Me.ComboBoxSessions.Items.AddRange(New Object() {"2018/2019", "2019/2020"})
        Me.ComboBoxSessions.Location = New System.Drawing.Point(30, 115)
        Me.ComboBoxSessions.Name = "ComboBoxSessions"
        Me.ComboBoxSessions.Size = New System.Drawing.Size(100, 21)
        Me.ComboBoxSessions.TabIndex = 30
        Me.ComboBoxSessions.Text = "2018/2019"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 192)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "CourseCode:"
        '
        'TextBoxCourseCode
        '
        Me.TextBoxCourseCode.Location = New System.Drawing.Point(10, 211)
        Me.TextBoxCourseCode.Multiline = True
        Me.TextBoxCourseCode.Name = "TextBoxCourseCode"
        Me.TextBoxCourseCode.Size = New System.Drawing.Size(63, 22)
        Me.TextBoxCourseCode.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 143)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Level:"
        '
        'TextBoxLevel
        '
        Me.TextBoxLevel.Location = New System.Drawing.Point(10, 162)
        Me.TextBoxLevel.Multiline = True
        Me.TextBoxLevel.Name = "TextBoxLevel"
        Me.TextBoxLevel.Size = New System.Drawing.Size(18, 22)
        Me.TextBoxLevel.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Session:"
        '
        'TextBoxSession
        '
        Me.TextBoxSession.Location = New System.Drawing.Point(10, 115)
        Me.TextBoxSession.Multiline = True
        Me.TextBoxSession.Name = "TextBoxSession"
        Me.TextBoxSession.Size = New System.Drawing.Size(18, 22)
        Me.TextBoxSession.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(116, 256)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "#"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(116, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "#"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 256)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Average Score:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 237)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Number of Students:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Department"
        '
        'TextBoxDepartment
        '
        Me.TextBoxDepartment.Location = New System.Drawing.Point(7, 43)
        Me.TextBoxDepartment.Multiline = True
        Me.TextBoxDepartment.Name = "TextBoxDepartment"
        Me.TextBoxDepartment.Size = New System.Drawing.Size(146, 21)
        Me.TextBoxDepartment.TabIndex = 1
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteCustomSource.AddRange(New String() {"S/N", "MATNO", "NAME", "SCORE"})
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"S/N", "MATNO", "NAME", "SCORE"})
        Me.ComboBox1.Location = New System.Drawing.Point(89, 91)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(79, 21)
        Me.ComboBox1.TabIndex = 9
        Me.ComboBox1.Text = "S/N"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"S/N", "MATNO", "NAME", "SCORE", "-"})
        Me.ComboBox2.Location = New System.Drawing.Point(174, 91)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 10
        Me.ComboBox2.Text = "MATNO"
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"S/N", "MATNO", "NAME", "SCORE", "-"})
        Me.ComboBox3.Location = New System.Drawing.Point(301, 91)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox3.TabIndex = 11
        Me.ComboBox3.Text = "NAME"
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"S/N", "MATNO", "NAME", "SCORE", "-"})
        Me.ComboBox4.Location = New System.Drawing.Point(428, 91)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox4.TabIndex = 12
        Me.ComboBox4.Text = "SCORE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(199, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(297, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "NB: Correct Order of Columns: S/N, MATNO, NAME, SCORE"
        '
        'ComboBox5
        '
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"S/N", "MATNO", "NAME", "SCORE", "-"})
        Me.ComboBox5.Location = New System.Drawing.Point(557, 91)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox5.TabIndex = 17
        Me.ComboBox5.Text = "-"
        '
        'ComboBox6
        '
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Items.AddRange(New Object() {"S/N", "MATNO", "NAME", "SCORE", "-"})
        Me.ComboBox6.Location = New System.Drawing.Point(823, 91)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox6.TabIndex = 20
        Me.ComboBox6.Text = "-"
        '
        'ComboBox7
        '
        Me.ComboBox7.FormattingEnabled = True
        Me.ComboBox7.Items.AddRange(New Object() {"S/N", "MATNO", "NAME", "SCORE", "-"})
        Me.ComboBox7.Location = New System.Drawing.Point(694, 91)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox7.TabIndex = 19
        Me.ComboBox7.Text = "-"
        '
        'DataGridView2
        '
        Me.DataGridView2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView2.GridColor = System.Drawing.Color.Black
        Me.DataGridView2.Location = New System.Drawing.Point(44, 512)
        Me.DataGridView2.Name = "DataGridView2"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        Me.DataGridView2.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView2.Size = New System.Drawing.Size(505, 133)
        Me.DataGridView2.TabIndex = 21
        Me.DataGridView2.Visible = False
        '
        'CheckBoxCustomOrder
        '
        Me.CheckBoxCustomOrder.AutoSize = True
        Me.CheckBoxCustomOrder.Location = New System.Drawing.Point(44, 93)
        Me.CheckBoxCustomOrder.Name = "CheckBoxCustomOrder"
        Me.CheckBoxCustomOrder.Size = New System.Drawing.Size(45, 17)
        Me.CheckBoxCustomOrder.TabIndex = 22
        Me.CheckBoxCustomOrder.Text = "Use"
        Me.CheckBoxCustomOrder.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        '
        'TextBoxResultsDir
        '
        Me.TextBoxResultsDir.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxResultsDir.Location = New System.Drawing.Point(44, 10)
        Me.TextBoxResultsDir.Name = "TextBoxResultsDir"
        Me.TextBoxResultsDir.Size = New System.Drawing.Size(541, 20)
        Me.TextBoxResultsDir.TabIndex = 23
        '
        'BackgroundWorkerBatch
        '
        '
        'ListBoxBatch
        '
        Me.ListBoxBatch.FormattingEnabled = True
        Me.ListBoxBatch.Location = New System.Drawing.Point(604, 10)
        Me.ListBoxBatch.Name = "ListBoxBatch"
        Me.ListBoxBatch.Size = New System.Drawing.Size(156, 69)
        Me.ListBoxBatch.TabIndex = 24
        '
        'FormUploadResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(913, 566)
        Me.Controls.Add(Me.ListBoxBatch)
        Me.Controls.Add(Me.TextBoxResultsDir)
        Me.Controls.Add(Me.CheckBoxCustomOrder)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.ComboBox6)
        Me.Controls.Add(Me.ComboBox7)
        Me.Controls.Add(Me.ComboBox5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SidePanel)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxExcelFilename)
        Me.Name = "FormUploadResult"
        Me.Text = "Upload Result"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SidePanel.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxExcelFilename As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SidePanel As Panel
    Friend WithEvents ButtonUpload As Button
    Friend WithEvents ButtonPreview As Button
    Friend WithEvents ButtonBrowse As Button
    Friend WithEvents ButtonCloud As Button
    Friend WithEvents ButtonResultList As Button
    Friend WithEvents ButtonCheck As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBoxPrefix As TextBox
    Friend WithEvents CheckBoxPrefix As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxDepartment As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBoxLevel As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxSession As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents ComboBox7 As ComboBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBoxCourseCode As TextBox
    Friend WithEvents CheckBoxCustomOrder As CheckBox
    Friend WithEvents ComboBoxSessions As ComboBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ComboBoxCourseCode As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBoxLevel As ComboBox
    Friend WithEvents ComboBoxDepartments As ComboBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents ButtonClose As Button
    Friend WithEvents ButtonBatchUpload As Button
    Friend WithEvents TextBoxResultsDir As TextBox
    Friend WithEvents BackgroundWorkerBatch As System.ComponentModel.BackgroundWorker
    Friend WithEvents ListBoxBatch As ListBox
End Class
