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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridViewBroadSheet = New System.Windows.Forms.DataGridView()
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
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.ButtonProcessExcelInteropPlain = New System.Windows.Forms.Button()
        Me.ButtonClosePanelMenu = New System.Windows.Forms.Button()
        Me.ButtonprocessExcelFileFormula = New System.Windows.Forms.Button()
        Me.ButtonprocessExcelInteropFormula = New System.Windows.Forms.Button()
        Me.ButtonprocessExceFilePlain = New System.Windows.Forms.Button()
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
        Me.ButtonApplyModification = New System.Windows.Forms.Button()
        Me.ButtonRefereshListSecond = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
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
        Me.SidePanel.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        Me.PanelModify.SuspendLayout()
        CType(Me.DataGridViewBroadsheetAudit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewBroadSheet
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewBroadSheet.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewBroadSheet.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewBroadSheet.BackgroundColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewBroadSheet.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewBroadSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewBroadSheet.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewBroadSheet.GridColor = System.Drawing.Color.Gray
        Me.DataGridViewBroadSheet.Location = New System.Drawing.Point(29, 158)
        Me.DataGridViewBroadSheet.Name = "DataGridViewBroadSheet"
        Me.DataGridViewBroadSheet.Size = New System.Drawing.Size(724, 235)
        Me.DataGridViewBroadSheet.TabIndex = 9
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
        Me.SidePanel.Controls.Add(Me.PanelMenu)
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
        Me.SidePanel.Size = New System.Drawing.Size(134, 586)
        Me.SidePanel.TabIndex = 27
        '
        'PanelMenu
        '
        Me.PanelMenu.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelMenu.Controls.Add(Me.ButtonProcessExcelInteropPlain)
        Me.PanelMenu.Controls.Add(Me.ButtonClosePanelMenu)
        Me.PanelMenu.Controls.Add(Me.ButtonprocessExcelFileFormula)
        Me.PanelMenu.Controls.Add(Me.ButtonprocessExcelInteropFormula)
        Me.PanelMenu.Controls.Add(Me.ButtonprocessExceFilePlain)
        Me.PanelMenu.Location = New System.Drawing.Point(6, 173)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(125, 321)
        Me.PanelMenu.TabIndex = 35
        Me.PanelMenu.Visible = False
        '
        'ButtonProcessExcelInteropPlain
        '
        Me.ButtonProcessExcelInteropPlain.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.ButtonProcessExcelInteropPlain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonProcessExcelInteropPlain.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonProcessExcelInteropPlain.ForeColor = System.Drawing.Color.White
        Me.ButtonProcessExcelInteropPlain.Location = New System.Drawing.Point(3, 14)
        Me.ButtonProcessExcelInteropPlain.Name = "ButtonProcessExcelInteropPlain"
        Me.ButtonProcessExcelInteropPlain.Size = New System.Drawing.Size(124, 55)
        Me.ButtonProcessExcelInteropPlain.TabIndex = 5
        Me.ButtonProcessExcelInteropPlain.Text = "Use Excel App"
        Me.ButtonProcessExcelInteropPlain.UseVisualStyleBackColor = True
        '
        'ButtonClosePanelMenu
        '
        Me.ButtonClosePanelMenu.FlatAppearance.BorderSize = 0
        Me.ButtonClosePanelMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClosePanelMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonClosePanelMenu.ForeColor = System.Drawing.Color.White
        Me.ButtonClosePanelMenu.Location = New System.Drawing.Point(-1, 258)
        Me.ButtonClosePanelMenu.Name = "ButtonClosePanelMenu"
        Me.ButtonClosePanelMenu.Size = New System.Drawing.Size(128, 55)
        Me.ButtonClosePanelMenu.TabIndex = 3
        Me.ButtonClosePanelMenu.Text = "Cancel"
        Me.ButtonClosePanelMenu.UseVisualStyleBackColor = True
        '
        'ButtonprocessExcelFileFormula
        '
        Me.ButtonprocessExcelFileFormula.FlatAppearance.BorderSize = 0
        Me.ButtonprocessExcelFileFormula.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonprocessExcelFileFormula.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonprocessExcelFileFormula.ForeColor = System.Drawing.Color.White
        Me.ButtonprocessExcelFileFormula.Location = New System.Drawing.Point(3, 205)
        Me.ButtonprocessExcelFileFormula.Name = "ButtonprocessExcelFileFormula"
        Me.ButtonprocessExcelFileFormula.Size = New System.Drawing.Size(128, 55)
        Me.ButtonprocessExcelFileFormula.TabIndex = 2
        Me.ButtonprocessExcelFileFormula.Text = "Built-in Formula"
        Me.ButtonprocessExcelFileFormula.UseVisualStyleBackColor = True
        '
        'ButtonprocessExcelInteropFormula
        '
        Me.ButtonprocessExcelInteropFormula.FlatAppearance.BorderSize = 0
        Me.ButtonprocessExcelInteropFormula.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonprocessExcelInteropFormula.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonprocessExcelInteropFormula.ForeColor = System.Drawing.Color.White
        Me.ButtonprocessExcelInteropFormula.Location = New System.Drawing.Point(3, 149)
        Me.ButtonprocessExcelInteropFormula.Name = "ButtonprocessExcelInteropFormula"
        Me.ButtonprocessExcelInteropFormula.Size = New System.Drawing.Size(128, 55)
        Me.ButtonprocessExcelInteropFormula.TabIndex = 1
        Me.ButtonprocessExcelInteropFormula.Text = "Excel Formula"
        Me.ButtonprocessExcelInteropFormula.UseVisualStyleBackColor = True
        '
        'ButtonprocessExceFilePlain
        '
        Me.ButtonprocessExceFilePlain.FlatAppearance.BorderSize = 0
        Me.ButtonprocessExceFilePlain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonprocessExceFilePlain.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonprocessExceFilePlain.ForeColor = System.Drawing.Color.White
        Me.ButtonprocessExceFilePlain.Location = New System.Drawing.Point(3, 75)
        Me.ButtonprocessExceFilePlain.Name = "ButtonprocessExceFilePlain"
        Me.ButtonprocessExceFilePlain.Size = New System.Drawing.Size(128, 55)
        Me.ButtonprocessExceFilePlain.TabIndex = 0
        Me.ButtonprocessExceFilePlain.Text = "Use Built-in App"
        Me.ButtonprocessExceFilePlain.UseVisualStyleBackColor = True
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
        Me.ButtonAdjustTemplate.Text = "Adjust Template"
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
        Me.PanelModify.Controls.Add(Me.ButtonApplyModification)
        Me.PanelModify.Controls.Add(Me.ButtonRefereshListSecond)
        Me.PanelModify.Controls.Add(Me.Label7)
        Me.PanelModify.Controls.Add(Me.ListBox2)
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
        'ButtonApplyModification
        '
        Me.ButtonApplyModification.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.ButtonApplyModification.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonApplyModification.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonApplyModification.ForeColor = System.Drawing.Color.White
        Me.ButtonApplyModification.Location = New System.Drawing.Point(444, 59)
        Me.ButtonApplyModification.Name = "ButtonApplyModification"
        Me.ButtonApplyModification.Size = New System.Drawing.Size(55, 34)
        Me.ButtonApplyModification.TabIndex = 11
        Me.ButtonApplyModification.Text = "Apply"
        Me.ButtonApplyModification.UseVisualStyleBackColor = True
        '
        'ButtonRefereshListSecond
        '
        Me.ButtonRefereshListSecond.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.ButtonRefereshListSecond.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRefereshListSecond.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonRefereshListSecond.ForeColor = System.Drawing.Color.White
        Me.ButtonRefereshListSecond.Location = New System.Drawing.Point(210, 58)
        Me.ButtonRefereshListSecond.Name = "ButtonRefereshListSecond"
        Me.ButtonRefereshListSecond.Size = New System.Drawing.Size(55, 34)
        Me.ButtonRefereshListSecond.TabIndex = 10
        Me.ButtonRefereshListSecond.Text = "Referesh"
        Me.ButtonRefereshListSecond.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(210, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "2nd Semenster"
        '
        'ListBox2
        '
        Me.ListBox2.AllowDrop = True
        Me.ListBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 16
        Me.ListBox2.Items.AddRange(New Object() {"Drag", "CourseCodes", "To", "Sort"})
        Me.ListBox2.Location = New System.Drawing.Point(282, 8)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(120, 84)
        Me.ListBox2.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 7)
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
        Me.ButtonRefereshListFirst.Location = New System.Drawing.Point(27, 56)
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
        Me.ListBox1.Location = New System.Drawing.Point(84, 6)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 84)
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
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewBroadsheetAudit.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewBroadsheetAudit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewBroadsheetAudit.BackgroundColor = System.Drawing.Color.Silver
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewBroadsheetAudit.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewBroadsheetAudit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewBroadsheetAudit.DefaultCellStyle = DataGridViewCellStyle6
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
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewTemp.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTemp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewTemp.BackgroundColor = System.Drawing.Color.Silver
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTemp.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTemp.DefaultCellStyle = DataGridViewCellStyle9
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
        Me.ClientSize = New System.Drawing.Size(896, 586)
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
        Me.Name = "FormGenerateBroadsheet"
        Me.Text = "Form Generate Broadsheet"
        CType(Me.DataGridViewBroadSheet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SidePanel.ResumeLayout(False)
        Me.PanelMenu.ResumeLayout(False)
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
    Friend WithEvents Label7 As Label
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ButtonApplyModification As Button
    Friend WithEvents ButtonRefereshListSecond As Button
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
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents ButtonProcessExcelInteropPlain As Button
    Friend WithEvents ButtonClosePanelMenu As Button
    Friend WithEvents ButtonprocessExcelFileFormula As Button
    Friend WithEvents ButtonprocessExcelInteropFormula As Button
    Friend WithEvents ButtonprocessExceFilePlain As Button
    Friend WithEvents ButtonExportPDF As Button
    Friend WithEvents DataGridViewTemp As DataGridView
End Class
