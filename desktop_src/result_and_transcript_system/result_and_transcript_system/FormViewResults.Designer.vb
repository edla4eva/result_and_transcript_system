<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormViewResults
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
        Me.TextBoxExcelFilename = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SidePanel = New System.Windows.Forms.Panel()
        Me.ButtonPrint = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.ButtonShowDetails = New System.Windows.Forms.Button()
        Me.ButtonCloud = New System.Windows.Forms.Button()
        Me.ButtonShowAll = New System.Windows.Forms.Button()
        Me.ButtonSearch = New System.Windows.Forms.Button()
        Me.ButtonBrowse = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxSession = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxCourseCode = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListBoxFileNames = New System.Windows.Forms.ListBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.bgwLoad = New System.ComponentModel.BackgroundWorker()
        Me.ProgressBarBS = New System.Windows.Forms.ProgressBar()
        Me.TimerBS = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ButtonCheckHash = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxCheckHash = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxCheckCourseCode = New System.Windows.Forms.TextBox()
        Me.PanelReport = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LabelClose = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonBack = New System.Windows.Forms.Button()
        Me.SidePanel.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.PanelReport.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxExcelFilename
        '
        Me.TextBoxExcelFilename.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxExcelFilename.Location = New System.Drawing.Point(44, 30)
        Me.TextBoxExcelFilename.Name = "TextBoxExcelFilename"
        Me.TextBoxExcelFilename.Size = New System.Drawing.Size(541, 20)
        Me.TextBoxExcelFilename.TabIndex = 1
        Me.TextBoxExcelFilename.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(44, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(357, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Folder/Directory containing Scanned Results(PDF file .pdf; Image File .jpg)"
        Me.Label1.Visible = False
        '
        'SidePanel
        '
        Me.SidePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.SidePanel.Controls.Add(Me.ButtonBack)
        Me.SidePanel.Controls.Add(Me.ButtonPrint)
        Me.SidePanel.Controls.Add(Me.ButtonDelete)
        Me.SidePanel.Controls.Add(Me.ButtonClose)
        Me.SidePanel.Controls.Add(Me.ButtonShowDetails)
        Me.SidePanel.Controls.Add(Me.ButtonCloud)
        Me.SidePanel.Controls.Add(Me.ButtonShowAll)
        Me.SidePanel.Controls.Add(Me.ButtonSearch)
        Me.SidePanel.Controls.Add(Me.ButtonBrowse)
        Me.SidePanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.SidePanel.Location = New System.Drawing.Point(779, 0)
        Me.SidePanel.Name = "SidePanel"
        Me.SidePanel.Size = New System.Drawing.Size(134, 556)
        Me.SidePanel.TabIndex = 6
        '
        'ButtonPrint
        '
        Me.ButtonPrint.FlatAppearance.BorderSize = 0
        Me.ButtonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonPrint.ForeColor = System.Drawing.Color.White
        Me.ButtonPrint.Location = New System.Drawing.Point(3, 359)
        Me.ButtonPrint.Name = "ButtonPrint"
        Me.ButtonPrint.Size = New System.Drawing.Size(128, 55)
        Me.ButtonPrint.TabIndex = 10
        Me.ButtonPrint.Text = "Print Result"
        Me.ButtonPrint.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.FlatAppearance.BorderSize = 0
        Me.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonDelete.ForeColor = System.Drawing.Color.White
        Me.ButtonDelete.Location = New System.Drawing.Point(3, 298)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(128, 55)
        Me.ButtonDelete.TabIndex = 9
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonClose
        '
        Me.ButtonClose.FlatAppearance.BorderSize = 0
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonClose.ForeColor = System.Drawing.Color.White
        Me.ButtonClose.Location = New System.Drawing.Point(0, 498)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(128, 55)
        Me.ButtonClose.TabIndex = 8
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'ButtonShowDetails
        '
        Me.ButtonShowDetails.FlatAppearance.BorderSize = 0
        Me.ButtonShowDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonShowDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonShowDetails.ForeColor = System.Drawing.Color.White
        Me.ButtonShowDetails.Location = New System.Drawing.Point(3, 222)
        Me.ButtonShowDetails.Name = "ButtonShowDetails"
        Me.ButtonShowDetails.Size = New System.Drawing.Size(128, 55)
        Me.ButtonShowDetails.TabIndex = 5
        Me.ButtonShowDetails.Text = "Show Details"
        Me.ButtonShowDetails.UseVisualStyleBackColor = True
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
        'ButtonShowAll
        '
        Me.ButtonShowAll.FlatAppearance.BorderSize = 0
        Me.ButtonShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonShowAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonShowAll.ForeColor = System.Drawing.Color.White
        Me.ButtonShowAll.Location = New System.Drawing.Point(3, 30)
        Me.ButtonShowAll.Name = "ButtonShowAll"
        Me.ButtonShowAll.Size = New System.Drawing.Size(128, 55)
        Me.ButtonShowAll.TabIndex = 2
        Me.ButtonShowAll.Text = "Show All"
        Me.ButtonShowAll.UseVisualStyleBackColor = True
        '
        'ButtonSearch
        '
        Me.ButtonSearch.FlatAppearance.BorderSize = 0
        Me.ButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonSearch.ForeColor = System.Drawing.Color.White
        Me.ButtonSearch.Location = New System.Drawing.Point(3, 161)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(128, 55)
        Me.ButtonSearch.TabIndex = 1
        Me.ButtonSearch.Text = "Search"
        Me.ButtonSearch.UseVisualStyleBackColor = True
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
        Me.ButtonBrowse.Text = "Scans..."
        Me.ButtonBrowse.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBoxSession)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TextBoxCourseCode)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Silver
        Me.GroupBox1.Location = New System.Drawing.Point(601, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(166, 137)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search DataBase"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(9, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Session"
        '
        'TextBoxSession
        '
        Me.TextBoxSession.Location = New System.Drawing.Point(9, 104)
        Me.TextBoxSession.Multiline = True
        Me.TextBoxSession.Name = "TextBoxSession"
        Me.TextBoxSession.Size = New System.Drawing.Size(146, 22)
        Me.TextBoxSession.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Silver
        Me.Label8.Location = New System.Drawing.Point(9, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 16)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Course Code"
        '
        'TextBoxCourseCode
        '
        Me.TextBoxCourseCode.Location = New System.Drawing.Point(9, 43)
        Me.TextBoxCourseCode.Multiline = True
        Me.TextBoxCourseCode.Name = "TextBoxCourseCode"
        Me.TextBoxCourseCode.Size = New System.Drawing.Size(146, 22)
        Me.TextBoxCourseCode.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.ListBoxFileNames)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Silver
        Me.GroupBox2.Location = New System.Drawing.Point(601, 375)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(166, 148)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Scanned Results"
        '
        'ListBoxFileNames
        '
        Me.ListBoxFileNames.FormattingEnabled = True
        Me.ListBoxFileNames.Location = New System.Drawing.Point(9, 19)
        Me.ListBoxFileNames.Name = "ListBoxFileNames"
        Me.ListBoxFileNames.Size = New System.Drawing.Size(144, 121)
        Me.ListBoxFileNames.TabIndex = 23
        '
        'DataGridView2
        '
        Me.DataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView2.GridColor = System.Drawing.Color.Black
        Me.DataGridView2.Location = New System.Drawing.Point(47, 127)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        Me.DataGridView2.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(541, 396)
        Me.DataGridView2.TabIndex = 21
        '
        'bgwLoad
        '
        Me.bgwLoad.WorkerReportsProgress = True
        '
        'ProgressBarBS
        '
        Me.ProgressBarBS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBarBS.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ProgressBarBS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ProgressBarBS.Location = New System.Drawing.Point(44, 100)
        Me.ProgressBarBS.Name = "ProgressBarBS"
        Me.ProgressBarBS.Size = New System.Drawing.Size(544, 23)
        Me.ProgressBarBS.TabIndex = 76
        Me.ProgressBarBS.Value = 1
        '
        'TimerBS
        '
        Me.TimerBS.Interval = 1000
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.ButtonCheckHash)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.TextBoxCheckHash)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.TextBoxCheckCourseCode)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Silver
        Me.GroupBox3.Location = New System.Drawing.Point(601, 193)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(166, 176)
        Me.GroupBox3.TabIndex = 77
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Validate Result"
        '
        'ButtonCheckHash
        '
        Me.ButtonCheckHash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCheckHash.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonCheckHash.ForeColor = System.Drawing.Color.White
        Me.ButtonCheckHash.Location = New System.Drawing.Point(9, 125)
        Me.ButtonCheckHash.Name = "ButtonCheckHash"
        Me.ButtonCheckHash.Size = New System.Drawing.Size(146, 37)
        Me.ButtonCheckHash.TabIndex = 11
        Me.ButtonCheckHash.Text = "Check"
        Me.ButtonCheckHash.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(9, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Hash Code (6 digts)"
        '
        'TextBoxCheckHash
        '
        Me.TextBoxCheckHash.Location = New System.Drawing.Point(9, 92)
        Me.TextBoxCheckHash.Multiline = True
        Me.TextBoxCheckHash.Name = "TextBoxCheckHash"
        Me.TextBoxCheckHash.Size = New System.Drawing.Size(146, 22)
        Me.TextBoxCheckHash.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(9, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Course Code"
        '
        'TextBoxCheckCourseCode
        '
        Me.TextBoxCheckCourseCode.Location = New System.Drawing.Point(9, 43)
        Me.TextBoxCheckCourseCode.Multiline = True
        Me.TextBoxCheckCourseCode.Name = "TextBoxCheckCourseCode"
        Me.TextBoxCheckCourseCode.Size = New System.Drawing.Size(146, 22)
        Me.TextBoxCheckCourseCode.TabIndex = 7
        '
        'PanelReport
        '
        Me.PanelReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelReport.Controls.Add(Me.Panel3)
        Me.PanelReport.Controls.Add(Me.Panel2)
        Me.PanelReport.Location = New System.Drawing.Point(23, 27)
        Me.PanelReport.Name = "PanelReport"
        Me.PanelReport.Size = New System.Drawing.Size(482, 383)
        Me.PanelReport.TabIndex = 78
        Me.PanelReport.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.LabelClose)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(480, 51)
        Me.Panel3.TabIndex = 1
        '
        'LabelClose
        '
        Me.LabelClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelClose.AutoSize = True
        Me.LabelClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelClose.ForeColor = System.Drawing.Color.Silver
        Me.LabelClose.Location = New System.Drawing.Point(445, 10)
        Me.LabelClose.Name = "LabelClose"
        Me.LabelClose.Size = New System.Drawing.Size(16, 16)
        Me.LabelClose.TabIndex = 9
        Me.LabelClose.Text = "X"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.ReportViewer1)
        Me.Panel2.Location = New System.Drawing.Point(3, 61)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(474, 317)
        Me.Panel2.TabIndex = 0
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "result_and_transcript_system.ReportResult.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(26, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.ShowDocumentMapButton = False
        Me.ReportViewer1.ShowExportButton = False
        Me.ReportViewer1.ShowFindControls = False
        Me.ReportViewer1.Size = New System.Drawing.Size(443, 288)
        Me.ReportViewer1.TabIndex = 3
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(47, 56)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(500, 700)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 24
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(422, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(166, 101)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'ButtonBack
        '
        Me.ButtonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBack.Image = Global.result_and_transcript_system.My.Resources.Resources.arrow_back_regular_24
        Me.ButtonBack.Location = New System.Drawing.Point(9, 6)
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.Size = New System.Drawing.Size(119, 23)
        Me.ButtonBack.TabIndex = 93
        Me.ButtonBack.UseVisualStyleBackColor = True
        '
        'FormViewResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(913, 556)
        Me.Controls.Add(Me.PanelReport)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.ProgressBarBS)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SidePanel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxExcelFilename)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormViewResults"
        Me.Text = "View Result"
        Me.SidePanel.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.PanelReport.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxExcelFilename As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SidePanel As Panel
    Friend WithEvents ButtonShowAll As Button
    Friend WithEvents ButtonSearch As Button
    Friend WithEvents ButtonBrowse As Button
    Friend WithEvents ButtonCloud As Button
    Friend WithEvents ButtonShowDetails As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxCourseCode As TextBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ListBoxFileNames As ListBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ButtonClose As Button
    Friend WithEvents bgwLoad As System.ComponentModel.BackgroundWorker
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxSession As TextBox
    Friend WithEvents ProgressBarBS As ProgressBar
    Friend WithEvents TimerBS As Timer
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxCheckHash As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxCheckCourseCode As TextBox
    Friend WithEvents ButtonCheckHash As Button
    Friend WithEvents ButtonPrint As Button
    Friend WithEvents PanelReport As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents LabelClose As Label
    Friend WithEvents ButtonBack As Button
End Class
