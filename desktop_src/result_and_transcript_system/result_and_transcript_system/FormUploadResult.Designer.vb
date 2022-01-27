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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TextBoxExcelFilename = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SidePanel = New System.Windows.Forms.Panel()
        Me.ButtonDownloadTemplate = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ButtonBatchUpload = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.ButtonCheck = New System.Windows.Forms.Button()
        Me.ButtonResultList = New System.Windows.Forms.Button()
        Me.ButtonCloud = New System.Windows.Forms.Button()
        Me.ButtonUpload = New System.Windows.Forms.Button()
        Me.ButtonBrowse = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBoxPrefix = New System.Windows.Forms.TextBox()
        Me.CheckBoxPrefix = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListBoxBatch = New System.Windows.Forms.ListBox()
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.TextBoxResultsDir = New System.Windows.Forms.TextBox()
        Me.BackgroundWorkerBatch = New System.ComponentModel.BackgroundWorker()
        Me.ProgressBarBS = New System.Windows.Forms.ProgressBar()
        Me.LabelProgress = New System.Windows.Forms.Label()
        Me.TimerResult = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonBack = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SidePanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
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
        Me.TextBoxExcelFilename.Size = New System.Drawing.Size(452, 20)
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
        Me.DataGridView1.Location = New System.Drawing.Point(44, 49)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Size = New System.Drawing.Size(601, 442)
        Me.DataGridView1.TabIndex = 3
        '
        'SidePanel
        '
        Me.SidePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.SidePanel.Controls.Add(Me.ButtonBack)
        Me.SidePanel.Controls.Add(Me.ButtonDownloadTemplate)
        Me.SidePanel.Controls.Add(Me.Panel2)
        Me.SidePanel.Controls.Add(Me.ButtonBatchUpload)
        Me.SidePanel.Controls.Add(Me.ButtonClose)
        Me.SidePanel.Controls.Add(Me.ButtonCheck)
        Me.SidePanel.Controls.Add(Me.ButtonResultList)
        Me.SidePanel.Controls.Add(Me.ButtonCloud)
        Me.SidePanel.Controls.Add(Me.ButtonUpload)
        Me.SidePanel.Controls.Add(Me.ButtonBrowse)
        Me.SidePanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.SidePanel.Location = New System.Drawing.Point(875, 0)
        Me.SidePanel.Name = "SidePanel"
        Me.SidePanel.Size = New System.Drawing.Size(134, 675)
        Me.SidePanel.TabIndex = 6
        '
        'ButtonDownloadTemplate
        '
        Me.ButtonDownloadTemplate.FlatAppearance.BorderSize = 0
        Me.ButtonDownloadTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDownloadTemplate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonDownloadTemplate.ForeColor = System.Drawing.Color.White
        Me.ButtonDownloadTemplate.Location = New System.Drawing.Point(3, 374)
        Me.ButtonDownloadTemplate.Name = "ButtonDownloadTemplate"
        Me.ButtonDownloadTemplate.Size = New System.Drawing.Size(128, 70)
        Me.ButtonDownloadTemplate.TabIndex = 76
        Me.ButtonDownloadTemplate.Text = "Download Result Template"
        Me.ButtonDownloadTemplate.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(139, 33)
        Me.Panel2.TabIndex = 75
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(22, 3)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 24)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Results"
        '
        'ButtonBatchUpload
        '
        Me.ButtonBatchUpload.FlatAppearance.BorderSize = 0
        Me.ButtonBatchUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBatchUpload.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonBatchUpload.ForeColor = System.Drawing.Color.White
        Me.ButtonBatchUpload.Location = New System.Drawing.Point(6, 450)
        Me.ButtonBatchUpload.Name = "ButtonBatchUpload"
        Me.ButtonBatchUpload.Size = New System.Drawing.Size(128, 55)
        Me.ButtonBatchUpload.TabIndex = 9
        Me.ButtonBatchUpload.Text = "Batch..."
        Me.ButtonBatchUpload.UseVisualStyleBackColor = True
        '
        'ButtonClose
        '
        Me.ButtonClose.FlatAppearance.BorderSize = 0
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonClose.ForeColor = System.Drawing.Color.White
        Me.ButtonClose.Location = New System.Drawing.Point(6, 576)
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
        Me.ButtonCheck.Location = New System.Drawing.Point(3, 159)
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
        Me.ButtonResultList.Location = New System.Drawing.Point(3, 306)
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
        Me.ButtonCloud.Location = New System.Drawing.Point(6, 511)
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
        Me.ButtonUpload.Location = New System.Drawing.Point(3, 232)
        Me.ButtonUpload.Name = "ButtonUpload"
        Me.ButtonUpload.Size = New System.Drawing.Size(128, 55)
        Me.ButtonUpload.TabIndex = 2
        Me.ButtonUpload.Text = "Upload"
        Me.ButtonUpload.UseVisualStyleBackColor = True
        '
        'ButtonBrowse
        '
        Me.ButtonBrowse.FlatAppearance.BorderSize = 0
        Me.ButtonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonBrowse.ForeColor = System.Drawing.Color.White
        Me.ButtonBrowse.Location = New System.Drawing.Point(3, 91)
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
        Me.GroupBox1.Location = New System.Drawing.Point(667, 52)
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
        Me.GroupBox2.Controls.Add(Me.ListBoxBatch)
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
        Me.GroupBox2.Location = New System.Drawing.Point(667, 136)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(189, 430)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Details"
        '
        'ListBoxBatch
        '
        Me.ListBoxBatch.FormattingEnabled = True
        Me.ListBoxBatch.Location = New System.Drawing.Point(7, 290)
        Me.ListBoxBatch.Name = "ListBoxBatch"
        Me.ListBoxBatch.Size = New System.Drawing.Size(176, 134)
        Me.ListBoxBatch.TabIndex = 41
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
        Me.Button7.Visible = False
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(159, 43)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(25, 23)
        Me.Button6.TabIndex = 39
        Me.Button6.Text = "+"
        Me.Button6.UseVisualStyleBackColor = True
        Me.Button6.Visible = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(164, 113)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(25, 23)
        Me.Button4.TabIndex = 38
        Me.Button4.Text = "+"
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
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
        Me.Button5.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(164, 160)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(25, 23)
        Me.Button3.TabIndex = 36
        Me.Button3.Text = "+"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
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
        Me.Button2.Visible = False
        '
        'ComboBoxCourseCode
        '
        Me.ComboBoxCourseCode.AutoCompleteCustomSource.AddRange(New String() {"2019/2020"})
        Me.ComboBoxCourseCode.FormattingEnabled = True
        Me.ComboBoxCourseCode.Items.AddRange(New Object() {"CPE375"})
        Me.ComboBoxCourseCode.Location = New System.Drawing.Point(9, 212)
        Me.ComboBoxCourseCode.Name = "ComboBoxCourseCode"
        Me.ComboBoxCourseCode.Size = New System.Drawing.Size(121, 21)
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
        Me.Button1.Visible = False
        '
        'ComboBoxLevel
        '
        Me.ComboBoxLevel.FormattingEnabled = True
        Me.ComboBoxLevel.Items.AddRange(New Object() {"100", "200", "300", "400", "500", "600", "700", "800", "900"})
        Me.ComboBoxLevel.Location = New System.Drawing.Point(7, 162)
        Me.ComboBoxLevel.Name = "ComboBoxLevel"
        Me.ComboBoxLevel.Size = New System.Drawing.Size(123, 21)
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
        Me.ComboBoxSessions.Location = New System.Drawing.Point(7, 115)
        Me.ComboBoxSessions.Name = "ComboBoxSessions"
        Me.ComboBoxSessions.Size = New System.Drawing.Size(123, 21)
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
        Me.TextBoxCourseCode.Visible = False
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
        Me.TextBoxLevel.Visible = False
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
        Me.TextBoxSession.Visible = False
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(199, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(297, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "NB: Correct Order of Columns: S/N, MATNO, NAME, SCORE"
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
        Me.DataGridView2.Location = New System.Drawing.Point(44, 541)
        Me.DataGridView2.Name = "DataGridView2"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        Me.DataGridView2.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView2.Size = New System.Drawing.Size(601, 122)
        Me.DataGridView2.TabIndex = 21
        Me.DataGridView2.Visible = False
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
        Me.TextBoxResultsDir.Size = New System.Drawing.Size(452, 20)
        Me.TextBoxResultsDir.TabIndex = 23
        Me.TextBoxResultsDir.Visible = False
        '
        'BackgroundWorkerBatch
        '
        '
        'ProgressBarBS
        '
        Me.ProgressBarBS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBarBS.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ProgressBarBS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ProgressBarBS.Location = New System.Drawing.Point(44, 512)
        Me.ProgressBarBS.Name = "ProgressBarBS"
        Me.ProgressBarBS.Size = New System.Drawing.Size(601, 23)
        Me.ProgressBarBS.TabIndex = 33
        Me.ProgressBarBS.Value = 1
        '
        'LabelProgress
        '
        Me.LabelProgress.AutoSize = True
        Me.LabelProgress.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProgress.Location = New System.Drawing.Point(40, 494)
        Me.LabelProgress.Name = "LabelProgress"
        Me.LabelProgress.Size = New System.Drawing.Size(20, 18)
        Me.LabelProgress.TabIndex = 32
        Me.LabelProgress.Text = "..."
        '
        'TimerResult
        '
        Me.TimerResult.Enabled = True
        Me.TimerResult.Interval = 1000
        '
        'ButtonBack
        '
        Me.ButtonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBack.Image = Global.result_and_transcript_system.My.Resources.Resources.arrow_back_regular_24
        Me.ButtonBack.Location = New System.Drawing.Point(6, 58)
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.Size = New System.Drawing.Size(119, 23)
        Me.ButtonBack.TabIndex = 92
        Me.ButtonBack.UseVisualStyleBackColor = True
        '
        'FormUploadResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1009, 675)
        Me.Controls.Add(Me.ProgressBarBS)
        Me.Controls.Add(Me.LabelProgress)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SidePanel)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBoxResultsDir)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxExcelFilename)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormUploadResult"
        Me.Text = "Upload Result"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SidePanel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
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
    Friend WithEvents Label7 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBoxCourseCode As TextBox
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
    Friend WithEvents ProgressBarBS As ProgressBar
    Friend WithEvents LabelProgress As Label
    Friend WithEvents TimerResult As Timer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents ButtonDownloadTemplate As Button
    Friend WithEvents ButtonBack As Button
End Class
