<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGenerateBroadsheet
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridViewBroadSheet = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UpgradeTo40ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpgradeWith1MarkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpgradeWith2MarksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeToToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ApplyChangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxDepartment = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxLevel = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxTemplateFileName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxSession = New System.Windows.Forms.TextBox()
        Me.ComboBoxDepartments = New System.Windows.Forms.ComboBox()
        Me.ComboBoxLevel = New System.Windows.Forms.ComboBox()
        Me.SidePanel = New System.Windows.Forms.Panel()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.ButtonExportPDF = New System.Windows.Forms.Button()
        Me.ButtonExportToExcel = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SelectBroadsheetTemplate = New System.Windows.Forms.Button()
        Me.ButtonSaveBroadsheet = New System.Windows.Forms.Button()
        Me.ButtonCloud = New System.Windows.Forms.Button()
        Me.ButtonUpload = New System.Windows.Forms.Button()
        Me.ButtonProcessBroadsheet = New System.Windows.Forms.Button()
        Me.ButtonAdjustTemplate = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBoxSessions = New System.Windows.Forms.ComboBox()
        Me.PanelModify = New System.Windows.Forms.Panel()
        Me.RadioButtonUseBuiltInFormula = New System.Windows.Forms.RadioButton()
        Me.RadioButtonUseExcelWithFormula = New System.Windows.Forms.RadioButton()
        Me.RadioButtonUseBuiltIn = New System.Windows.Forms.RadioButton()
        Me.RadioButtonUseExcel = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ButtonRefereshListFirst = New System.Windows.Forms.Button()
        Me.LabelClosePanelModify = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ProgressBarBS = New System.Windows.Forms.ProgressBar()
        Me.TimerBS = New System.Windows.Forms.Timer(Me.components)
        Me.BgWProcess = New System.ComponentModel.BackgroundWorker()
        Me.DataGridViewBroadsheetAudit = New System.Windows.Forms.DataGridView()
        Me.ButtonAddSession = New System.Windows.Forms.Button()
        Me.ButtonDownload = New System.Windows.Forms.Button()
        Me.bgwExportToExcel = New System.ComponentModel.BackgroundWorker()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.bgwLoad = New System.ComponentModel.BackgroundWorker()
        Me.DataGridViewTemp = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridViewBroadSheet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SidePanel.SuspendLayout()
        Me.PanelModify.SuspendLayout()
        CType(Me.DataGridViewBroadsheetAudit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewBroadSheet
        '
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewBroadSheet.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewBroadSheet.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewBroadSheet.BackgroundColor = System.Drawing.Color.Silver
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewBroadSheet.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewBroadSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewBroadSheet.ContextMenuStrip = Me.ContextMenuStrip1
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewBroadSheet.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewBroadSheet.GridColor = System.Drawing.Color.Gray
        Me.DataGridViewBroadSheet.Location = New System.Drawing.Point(29, 158)
        Me.DataGridViewBroadSheet.Name = "DataGridViewBroadSheet"
        Me.DataGridViewBroadSheet.Size = New System.Drawing.Size(724, 235)
        Me.DataGridViewBroadSheet.TabIndex = 9
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpgradeTo40ToolStripMenuItem, Me.UpgradeWith1MarkToolStripMenuItem, Me.UpgradeWith2MarksToolStripMenuItem, Me.ChangeToToolStripMenuItem, Me.ToolStripTextBox1, Me.ApplyChangeToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(190, 139)
        Me.ContextMenuStrip1.Text = "Action"
        '
        'UpgradeTo40ToolStripMenuItem
        '
        Me.UpgradeTo40ToolStripMenuItem.Name = "UpgradeTo40ToolStripMenuItem"
        Me.UpgradeTo40ToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.UpgradeTo40ToolStripMenuItem.Text = "Upgrade to 40"
        '
        'UpgradeWith1MarkToolStripMenuItem
        '
        Me.UpgradeWith1MarkToolStripMenuItem.Name = "UpgradeWith1MarkToolStripMenuItem"
        Me.UpgradeWith1MarkToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.UpgradeWith1MarkToolStripMenuItem.Text = "Upgrade with 1 mark"
        '
        'UpgradeWith2MarksToolStripMenuItem
        '
        Me.UpgradeWith2MarksToolStripMenuItem.Name = "UpgradeWith2MarksToolStripMenuItem"
        Me.UpgradeWith2MarksToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.UpgradeWith2MarksToolStripMenuItem.Text = "Upgrade with 2 marks"
        '
        'ChangeToToolStripMenuItem
        '
        Me.ChangeToToolStripMenuItem.Name = "ChangeToToolStripMenuItem"
        Me.ChangeToToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.ChangeToToolStripMenuItem.Text = "Change to:"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 23)
        '
        'ApplyChangeToolStripMenuItem
        '
        Me.ApplyChangeToolStripMenuItem.Name = "ApplyChangeToolStripMenuItem"
        Me.ApplyChangeToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.ApplyChangeToolStripMenuItem.Text = "Apply Change"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Department"
        '
        'TextBoxDepartment
        '
        Me.TextBoxDepartment.Location = New System.Drawing.Point(29, 31)
        Me.TextBoxDepartment.Name = "TextBoxDepartment"
        Me.TextBoxDepartment.Size = New System.Drawing.Size(33, 20)
        Me.TextBoxDepartment.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 450)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(436, 24)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "as approved by departmental board or facuty board"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Level"
        '
        'TextBoxLevel
        '
        Me.TextBoxLevel.Location = New System.Drawing.Point(29, 73)
        Me.TextBoxLevel.Name = "TextBoxLevel"
        Me.TextBoxLevel.Size = New System.Drawing.Size(33, 20)
        Me.TextBoxLevel.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 481)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Filename (Excel file .xlsx)"
        '
        'TextBoxTemplateFileName
        '
        Me.TextBoxTemplateFileName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBoxTemplateFileName.Location = New System.Drawing.Point(32, 501)
        Me.TextBoxTemplateFileName.Name = "TextBoxTemplateFileName"
        Me.TextBoxTemplateFileName.Size = New System.Drawing.Size(636, 20)
        Me.TextBoxTemplateFileName.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Session"
        '
        'TextBoxSession
        '
        Me.TextBoxSession.Location = New System.Drawing.Point(29, 121)
        Me.TextBoxSession.Name = "TextBoxSession"
        Me.TextBoxSession.Size = New System.Drawing.Size(33, 20)
        Me.TextBoxSession.TabIndex = 22
        '
        'ComboBoxDepartments
        '
        Me.ComboBoxDepartments.FormattingEnabled = True
        Me.ComboBoxDepartments.Items.AddRange(New Object() {"Computer Engineering", "Production Engineering"})
        Me.ComboBoxDepartments.Location = New System.Drawing.Point(66, 29)
        Me.ComboBoxDepartments.Name = "ComboBoxDepartments"
        Me.ComboBoxDepartments.Size = New System.Drawing.Size(161, 21)
        Me.ComboBoxDepartments.TabIndex = 24
        Me.ComboBoxDepartments.Text = "Computer Engineering"
        '
        'ComboBoxLevel
        '
        Me.ComboBoxLevel.FormattingEnabled = True
        Me.ComboBoxLevel.Items.AddRange(New Object() {"100", "200", "300", "400", "500", "600", "700", "800", "900"})
        Me.ComboBoxLevel.Location = New System.Drawing.Point(66, 73)
        Me.ComboBoxLevel.Name = "ComboBoxLevel"
        Me.ComboBoxLevel.Size = New System.Drawing.Size(161, 21)
        Me.ComboBoxLevel.TabIndex = 25
        Me.ComboBoxLevel.Text = "100"
        '
        'SidePanel
        '
        Me.SidePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.SidePanel.Controls.Add(Me.ButtonClose)
        Me.SidePanel.Controls.Add(Me.ButtonExportPDF)
        Me.SidePanel.Controls.Add(Me.ButtonExportToExcel)
        Me.SidePanel.Controls.Add(Me.Button3)
        Me.SidePanel.Controls.Add(Me.SelectBroadsheetTemplate)
        Me.SidePanel.Controls.Add(Me.ButtonSaveBroadsheet)
        Me.SidePanel.Controls.Add(Me.ButtonCloud)
        Me.SidePanel.Controls.Add(Me.ButtonUpload)
        Me.SidePanel.Controls.Add(Me.ButtonProcessBroadsheet)
        Me.SidePanel.Controls.Add(Me.ButtonAdjustTemplate)
        Me.SidePanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.SidePanel.Location = New System.Drawing.Point(762, 0)
        Me.SidePanel.Name = "SidePanel"
        Me.SidePanel.Size = New System.Drawing.Size(134, 660)
        Me.SidePanel.TabIndex = 27
        '
        'ButtonClose
        '
        Me.ButtonClose.FlatAppearance.BorderSize = 0
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonClose.ForeColor = System.Drawing.Color.White
        Me.ButtonClose.Location = New System.Drawing.Point(6, 602)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(128, 55)
        Me.ButtonClose.TabIndex = 36
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'ButtonExportPDF
        '
        Me.ButtonExportPDF.FlatAppearance.BorderSize = 0
        Me.ButtonExportPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonExportPDF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonExportPDF.ForeColor = System.Drawing.Color.White
        Me.ButtonExportPDF.Location = New System.Drawing.Point(3, 347)
        Me.ButtonExportPDF.Name = "ButtonExportPDF"
        Me.ButtonExportPDF.Size = New System.Drawing.Size(128, 55)
        Me.ButtonExportPDF.TabIndex = 8
        Me.ButtonExportPDF.Text = "Export to PDF"
        Me.ButtonExportPDF.UseVisualStyleBackColor = True
        '
        'ButtonExportToExcel
        '
        Me.ButtonExportToExcel.FlatAppearance.BorderSize = 0
        Me.ButtonExportToExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonExportToExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonExportToExcel.ForeColor = System.Drawing.Color.White
        Me.ButtonExportToExcel.Location = New System.Drawing.Point(3, 292)
        Me.ButtonExportToExcel.Name = "ButtonExportToExcel"
        Me.ButtonExportToExcel.Size = New System.Drawing.Size(128, 55)
        Me.ButtonExportToExcel.TabIndex = 7
        Me.ButtonExportToExcel.Text = "Export to Excel"
        Me.ButtonExportToExcel.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(6, 546)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(128, 55)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Cancel"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'SelectBroadsheetTemplate
        '
        Me.SelectBroadsheetTemplate.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.SelectBroadsheetTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SelectBroadsheetTemplate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.SelectBroadsheetTemplate.ForeColor = System.Drawing.Color.White
        Me.SelectBroadsheetTemplate.Location = New System.Drawing.Point(3, 39)
        Me.SelectBroadsheetTemplate.Name = "SelectBroadsheetTemplate"
        Me.SelectBroadsheetTemplate.Size = New System.Drawing.Size(128, 55)
        Me.SelectBroadsheetTemplate.TabIndex = 5
        Me.SelectBroadsheetTemplate.Text = "Select Template"
        Me.SelectBroadsheetTemplate.UseVisualStyleBackColor = True
        '
        'ButtonSaveBroadsheet
        '
        Me.ButtonSaveBroadsheet.FlatAppearance.BorderSize = 0
        Me.ButtonSaveBroadsheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSaveBroadsheet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonSaveBroadsheet.ForeColor = System.Drawing.Color.White
        Me.ButtonSaveBroadsheet.Location = New System.Drawing.Point(3, 409)
        Me.ButtonSaveBroadsheet.Name = "ButtonSaveBroadsheet"
        Me.ButtonSaveBroadsheet.Size = New System.Drawing.Size(128, 55)
        Me.ButtonSaveBroadsheet.TabIndex = 4
        Me.ButtonSaveBroadsheet.Text = "Save"
        Me.ButtonSaveBroadsheet.UseVisualStyleBackColor = True
        '
        'ButtonCloud
        '
        Me.ButtonCloud.FlatAppearance.BorderSize = 0
        Me.ButtonCloud.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCloud.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonCloud.ForeColor = System.Drawing.Color.White
        Me.ButtonCloud.Location = New System.Drawing.Point(3, 485)
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
        Me.ButtonUpload.Location = New System.Drawing.Point(3, 225)
        Me.ButtonUpload.Name = "ButtonUpload"
        Me.ButtonUpload.Size = New System.Drawing.Size(128, 55)
        Me.ButtonUpload.TabIndex = 2
        Me.ButtonUpload.Text = "Modify"
        Me.ButtonUpload.UseVisualStyleBackColor = True
        '
        'ButtonProcessBroadsheet
        '
        Me.ButtonProcessBroadsheet.FlatAppearance.BorderSize = 0
        Me.ButtonProcessBroadsheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonProcessBroadsheet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonProcessBroadsheet.ForeColor = System.Drawing.Color.White
        Me.ButtonProcessBroadsheet.Location = New System.Drawing.Point(3, 161)
        Me.ButtonProcessBroadsheet.Name = "ButtonProcessBroadsheet"
        Me.ButtonProcessBroadsheet.Size = New System.Drawing.Size(128, 55)
        Me.ButtonProcessBroadsheet.TabIndex = 1
        Me.ButtonProcessBroadsheet.Text = "Process"
        Me.ButtonProcessBroadsheet.UseVisualStyleBackColor = True
        '
        'ButtonAdjustTemplate
        '
        Me.ButtonAdjustTemplate.FlatAppearance.BorderSize = 0
        Me.ButtonAdjustTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAdjustTemplate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonAdjustTemplate.ForeColor = System.Drawing.Color.White
        Me.ButtonAdjustTemplate.Location = New System.Drawing.Point(3, 100)
        Me.ButtonAdjustTemplate.Name = "ButtonAdjustTemplate"
        Me.ButtonAdjustTemplate.Size = New System.Drawing.Size(128, 55)
        Me.ButtonAdjustTemplate.TabIndex = 0
        Me.ButtonAdjustTemplate.Text = "Options"
        Me.ButtonAdjustTemplate.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 426)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(551, 24)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "This broadsheet can be used to make final adjustments to scores"
        '
        'ComboBoxSessions
        '
        Me.ComboBoxSessions.AutoCompleteCustomSource.AddRange(New String() {"2019/2020"})
        Me.ComboBoxSessions.FormattingEnabled = True
        Me.ComboBoxSessions.Items.AddRange(New Object() {"2018/2019", "2019/2020"})
        Me.ComboBoxSessions.Location = New System.Drawing.Point(66, 121)
        Me.ComboBoxSessions.Name = "ComboBoxSessions"
        Me.ComboBoxSessions.Size = New System.Drawing.Size(161, 21)
        Me.ComboBoxSessions.TabIndex = 29
        Me.ComboBoxSessions.Text = "2018/2019"
        '
        'PanelModify
        '
        Me.PanelModify.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelModify.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelModify.Controls.Add(Me.RadioButtonUseBuiltInFormula)
        Me.PanelModify.Controls.Add(Me.RadioButtonUseExcelWithFormula)
        Me.PanelModify.Controls.Add(Me.RadioButtonUseBuiltIn)
        Me.PanelModify.Controls.Add(Me.RadioButtonUseExcel)
        Me.PanelModify.Controls.Add(Me.Label8)
        Me.PanelModify.Controls.Add(Me.ButtonRefereshListFirst)
        Me.PanelModify.Controls.Add(Me.LabelClosePanelModify)
        Me.PanelModify.Controls.Add(Me.ListBox1)
        Me.PanelModify.Location = New System.Drawing.Point(250, 31)
        Me.PanelModify.Name = "PanelModify"
        Me.PanelModify.Size = New System.Drawing.Size(503, 124)
        Me.PanelModify.TabIndex = 30
        Me.PanelModify.Visible = False
        '
        'RadioButtonUseBuiltInFormula
        '
        Me.RadioButtonUseBuiltInFormula.AutoSize = True
        Me.RadioButtonUseBuiltInFormula.Location = New System.Drawing.Point(8, 35)
        Me.RadioButtonUseBuiltInFormula.Name = "RadioButtonUseBuiltInFormula"
        Me.RadioButtonUseBuiltInFormula.Size = New System.Drawing.Size(153, 17)
        Me.RadioButtonUseBuiltInFormula.TabIndex = 15
        Me.RadioButtonUseBuiltInFormula.Text = "UseBuilt-in Ap with Formula"
        Me.RadioButtonUseBuiltInFormula.UseVisualStyleBackColor = True
        '
        'RadioButtonUseExcelWithFormula
        '
        Me.RadioButtonUseExcelWithFormula.AutoSize = True
        Me.RadioButtonUseExcelWithFormula.Location = New System.Drawing.Point(8, 95)
        Me.RadioButtonUseExcelWithFormula.Name = "RadioButtonUseExcelWithFormula"
        Me.RadioButtonUseExcelWithFormula.Size = New System.Drawing.Size(154, 17)
        Me.RadioButtonUseExcelWithFormula.TabIndex = 14
        Me.RadioButtonUseExcelWithFormula.Text = "Use Excel App with Fomula"
        Me.RadioButtonUseExcelWithFormula.UseVisualStyleBackColor = True
        '
        'RadioButtonUseBuiltIn
        '
        Me.RadioButtonUseBuiltIn.AutoSize = True
        Me.RadioButtonUseBuiltIn.Checked = True
        Me.RadioButtonUseBuiltIn.Location = New System.Drawing.Point(8, 12)
        Me.RadioButtonUseBuiltIn.Name = "RadioButtonUseBuiltIn"
        Me.RadioButtonUseBuiltIn.Size = New System.Drawing.Size(100, 17)
        Me.RadioButtonUseBuiltIn.TabIndex = 13
        Me.RadioButtonUseBuiltIn.TabStop = True
        Me.RadioButtonUseBuiltIn.Text = "Use Built-in App"
        Me.RadioButtonUseBuiltIn.UseVisualStyleBackColor = True
        '
        'RadioButtonUseExcel
        '
        Me.RadioButtonUseExcel.AutoSize = True
        Me.RadioButtonUseExcel.Location = New System.Drawing.Point(8, 71)
        Me.RadioButtonUseExcel.Name = "RadioButtonUseExcel"
        Me.RadioButtonUseExcel.Size = New System.Drawing.Size(95, 17)
        Me.RadioButtonUseExcel.TabIndex = 12
        Me.RadioButtonUseExcel.Text = "Use Excel App"
        Me.RadioButtonUseExcel.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(209, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "First Semenster"
        '
        'ButtonRefereshListFirst
        '
        Me.ButtonRefereshListFirst.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.ButtonRefereshListFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRefereshListFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonRefereshListFirst.ForeColor = System.Drawing.Color.White
        Me.ButtonRefereshListFirst.Location = New System.Drawing.Point(423, 83)
        Me.ButtonRefereshListFirst.Name = "ButtonRefereshListFirst"
        Me.ButtonRefereshListFirst.Size = New System.Drawing.Size(55, 34)
        Me.ButtonRefereshListFirst.TabIndex = 6
        Me.ButtonRefereshListFirst.Text = "Referesh"
        Me.ButtonRefereshListFirst.UseVisualStyleBackColor = True
        '
        'LabelClosePanelModify
        '
        Me.LabelClosePanelModify.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelClosePanelModify.AutoSize = True
        Me.LabelClosePanelModify.Location = New System.Drawing.Point(484, 6)
        Me.LabelClosePanelModify.Name = "LabelClosePanelModify"
        Me.LabelClosePanelModify.Size = New System.Drawing.Size(14, 13)
        Me.LabelClosePanelModify.TabIndex = 1
        Me.LabelClosePanelModify.Text = "X"
        '
        'ListBox1
        '
        Me.ListBox1.AllowDrop = True
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Items.AddRange(New Object() {"Drag", "CourseCodes", "To", "Sort"})
        Me.ListBox1.Location = New System.Drawing.Point(294, 6)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 116)
        Me.ListBox1.TabIndex = 0
        '
        'ProgressBarBS
        '
        Me.ProgressBarBS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBarBS.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ProgressBarBS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ProgressBarBS.Location = New System.Drawing.Point(32, 399)
        Me.ProgressBarBS.Name = "ProgressBarBS"
        Me.ProgressBarBS.Size = New System.Drawing.Size(720, 23)
        Me.ProgressBarBS.TabIndex = 31
        Me.ProgressBarBS.Value = 1
        '
        'TimerBS
        '
        Me.TimerBS.Enabled = True
        Me.TimerBS.Interval = 1000
        '
        'BgWProcess
        '
        '
        'DataGridViewBroadsheetAudit
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewBroadsheetAudit.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewBroadsheetAudit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewBroadsheetAudit.BackgroundColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewBroadsheetAudit.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewBroadsheetAudit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewBroadsheetAudit.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewBroadsheetAudit.GridColor = System.Drawing.Color.Gray
        Me.DataGridViewBroadsheetAudit.Location = New System.Drawing.Point(29, 158)
        Me.DataGridViewBroadsheetAudit.Name = "DataGridViewBroadsheetAudit"
        Me.DataGridViewBroadsheetAudit.Size = New System.Drawing.Size(724, 187)
        Me.DataGridViewBroadsheetAudit.TabIndex = 32
        '
        'ButtonAddSession
        '
        Me.ButtonAddSession.Location = New System.Drawing.Point(221, 121)
        Me.ButtonAddSession.Name = "ButtonAddSession"
        Me.ButtonAddSession.Size = New System.Drawing.Size(23, 23)
        Me.ButtonAddSession.TabIndex = 33
        Me.ButtonAddSession.Text = "+"
        Me.ButtonAddSession.UseVisualStyleBackColor = True
        '
        'ButtonDownload
        '
        Me.ButtonDownload.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDownload.ForeColor = System.Drawing.Color.White
        Me.ButtonDownload.Location = New System.Drawing.Point(674, 500)
        Me.ButtonDownload.Name = "ButtonDownload"
        Me.ButtonDownload.Size = New System.Drawing.Size(75, 23)
        Me.ButtonDownload.TabIndex = 34
        Me.ButtonDownload.Text = "Download"
        Me.ButtonDownload.UseVisualStyleBackColor = False
        '
        'bgwExportToExcel
        '
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Excel Files|*.xlsx"
        Me.SaveFileDialog1.RestoreDirectory = True
        '
        'bgwLoad
        '
        '
        'DataGridViewTemp
        '
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewTemp.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTemp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewTemp.BackgroundColor = System.Drawing.Color.Silver
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTemp.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridViewTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTemp.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridViewTemp.GridColor = System.Drawing.Color.Gray
        Me.DataGridViewTemp.Location = New System.Drawing.Point(32, 428)
        Me.DataGridViewTemp.Name = "DataGridViewTemp"
        Me.DataGridViewTemp.Size = New System.Drawing.Size(717, 66)
        Me.DataGridViewTemp.TabIndex = 35
        '
        'FormGenerateBroadsheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 660)
        Me.Controls.Add(Me.DataGridViewTemp)
        Me.Controls.Add(Me.ButtonDownload)
        Me.Controls.Add(Me.ButtonAddSession)
        Me.Controls.Add(Me.ProgressBarBS)
        Me.Controls.Add(Me.PanelModify)
        Me.Controls.Add(Me.ComboBoxSessions)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.SidePanel)
        Me.Controls.Add(Me.ComboBoxLevel)
        Me.Controls.Add(Me.ComboBoxDepartments)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxSession)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxTemplateFileName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxLevel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxDepartment)
        Me.Controls.Add(Me.DataGridViewBroadSheet)
        Me.Controls.Add(Me.DataGridViewBroadsheetAudit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormGenerateBroadsheet"
        Me.Text = "Generate Broadsheet"
        CType(Me.DataGridViewBroadSheet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ContextMenuStrip1.PerformLayout()
        Me.SidePanel.ResumeLayout(False)
        Me.PanelModify.ResumeLayout(False)
        Me.PanelModify.PerformLayout()
        CType(Me.DataGridViewBroadsheetAudit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewTemp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewBroadSheet As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxDepartment As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxLevel As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxTemplateFileName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxSession As TextBox
    Friend WithEvents ComboBoxDepartments As ComboBox
    Friend WithEvents ComboBoxLevel As ComboBox
    Friend WithEvents SidePanel As Panel
    Friend WithEvents SelectBroadsheetTemplate As Button
    Friend WithEvents ButtonSaveBroadsheet As Button
    Friend WithEvents ButtonCloud As Button
    Friend WithEvents ButtonUpload As Button
    Friend WithEvents ButtonProcessBroadsheet As Button
    Friend WithEvents ButtonAdjustTemplate As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBoxSessions As ComboBox
    Friend WithEvents PanelModify As Panel
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ButtonRefereshListFirst As Button
    Friend WithEvents LabelClosePanelModify As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ProgressBarBS As ProgressBar
    Friend WithEvents TimerBS As Timer
    Friend WithEvents BgWProcess As System.ComponentModel.BackgroundWorker
    Friend WithEvents DataGridViewBroadsheetAudit As DataGridView
    Friend WithEvents ButtonExportToExcel As Button
    Friend WithEvents ButtonAddSession As Button
    Friend WithEvents ButtonDownload As Button
    Friend WithEvents bgwExportToExcel As System.ComponentModel.BackgroundWorker
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents bgwLoad As System.ComponentModel.BackgroundWorker
    Friend WithEvents ButtonExportPDF As Button
    Friend WithEvents DataGridViewTemp As DataGridView
    Friend WithEvents ButtonClose As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents UpgradeTo40ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpgradeWith1MarkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpgradeWith2MarksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeToToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ApplyChangeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RadioButtonUseBuiltInFormula As RadioButton
    Friend WithEvents RadioButtonUseExcelWithFormula As RadioButton
    Friend WithEvents RadioButtonUseBuiltIn As RadioButton
    Friend WithEvents RadioButtonUseExcel As RadioButton
End Class
