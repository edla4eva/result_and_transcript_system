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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ClassBroadsheetsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxMATNO = New System.Windows.Forms.TextBox()
        Me.dgvTranscripts = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblSet = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.TextBoxDate = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.ButtonTranscript = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgvStudents = New System.Windows.Forms.DataGridView()
        Me.dgvCourses = New System.Windows.Forms.DataGridView()
        Me.ButtonEport = New System.Windows.Forms.Button()
        Me.TimerBS = New System.Windows.Forms.Timer(Me.components)
        Me.bgwExportToExcel = New System.ComponentModel.BackgroundWorker()
        Me.TextBoxTemplateFileName = New System.Windows.Forms.TextBox()
        Me.ButtonDownload = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ProgressBarBS = New System.Windows.Forms.ProgressBar()
        Me.ButtonOpen = New System.Windows.Forms.Button()
        Me.SidePanel = New System.Windows.Forms.Panel()
        Me.ButtonGPACard = New System.Windows.Forms.Button()
        Me.ButtonFullScreen = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ReportViewerTranscript = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.PictureBoxImg = New System.Windows.Forms.PictureBox()
        Me.ReportViewerGPCard = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ClassReportsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.ClassBroadsheetsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTranscripts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCourses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SidePanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBoxImg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassReportsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ClassBroadsheetsBindingSource
        '
        Me.ClassBroadsheetsBindingSource.DataMember = "ClassBroadsheets"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(31, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "MATNO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(27, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Name:"
        '
        'TextBoxMATNO
        '
        Me.TextBoxMATNO.Location = New System.Drawing.Point(19, 85)
        Me.TextBoxMATNO.Name = "TextBoxMATNO"
        Me.TextBoxMATNO.Size = New System.Drawing.Size(93, 20)
        Me.TextBoxMATNO.TabIndex = 11
        Me.TextBoxMATNO.Text = "ENG1503585"
        '
        'dgvTranscripts
        '
        Me.dgvTranscripts.AllowUserToAddRows = False
        Me.dgvTranscripts.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FloralWhite
        Me.dgvTranscripts.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTranscripts.BackgroundColor = System.Drawing.Color.White
        Me.dgvTranscripts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.PaleGoldenrod
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTranscripts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvTranscripts.ColumnHeadersHeight = 24
        Me.dgvTranscripts.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTranscripts.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvTranscripts.EnableHeadersVisualStyles = False
        Me.dgvTranscripts.GridColor = System.Drawing.Color.White
        Me.dgvTranscripts.Location = New System.Drawing.Point(30, 385)
        Me.dgvTranscripts.MultiSelect = False
        Me.dgvTranscripts.Name = "dgvTranscripts"
        Me.dgvTranscripts.ReadOnly = True
        Me.dgvTranscripts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTranscripts.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvTranscripts.RowHeadersWidth = 25
        Me.dgvTranscripts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.dgvTranscripts.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvTranscripts.RowTemplate.Height = 18
        Me.dgvTranscripts.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTranscripts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTranscripts.Size = New System.Drawing.Size(309, 178)
        Me.dgvTranscripts.TabIndex = 41
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.lblSet)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(352, 47)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(514, 62)
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
        'TextBoxName
        '
        Me.TextBoxName.Enabled = False
        Me.TextBoxName.Location = New System.Drawing.Point(81, 52)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(254, 20)
        Me.TextBoxName.TabIndex = 43
        '
        'TextBoxDate
        '
        Me.TextBoxDate.Location = New System.Drawing.Point(81, 87)
        Me.TextBoxDate.Name = "TextBoxDate"
        Me.TextBoxDate.Size = New System.Drawing.Size(10, 20)
        Me.TextBoxDate.TabIndex = 47
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(27, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Date:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(95, 88)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(240, 20)
        Me.DateTimePicker1.TabIndex = 58
        '
        'ButtonClose
        '
        Me.ButtonClose.FlatAppearance.BorderSize = 0
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonClose.ForeColor = System.Drawing.Color.White
        Me.ButtonClose.Location = New System.Drawing.Point(888, 491)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(128, 55)
        Me.ButtonClose.TabIndex = 61
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'ButtonTranscript
        '
        Me.ButtonTranscript.FlatAppearance.BorderSize = 0
        Me.ButtonTranscript.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonTranscript.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonTranscript.ForeColor = System.Drawing.Color.White
        Me.ButtonTranscript.Location = New System.Drawing.Point(3, 115)
        Me.ButtonTranscript.Name = "ButtonTranscript"
        Me.ButtonTranscript.Size = New System.Drawing.Size(128, 55)
        Me.ButtonTranscript.TabIndex = 62
        Me.ButtonTranscript.Text = "Transcript"
        Me.ButtonTranscript.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(3, 329)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 55)
        Me.Button1.TabIndex = 63
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgvStudents
        '
        Me.dgvStudents.AllowUserToAddRows = False
        Me.dgvStudents.AllowUserToDeleteRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FloralWhite
        Me.dgvStudents.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvStudents.BackgroundColor = System.Drawing.Color.White
        Me.dgvStudents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.PaleGoldenrod
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStudents.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvStudents.ColumnHeadersHeight = 24
        Me.dgvStudents.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvStudents.EnableHeadersVisualStyles = False
        Me.dgvStudents.GridColor = System.Drawing.Color.White
        Me.dgvStudents.Location = New System.Drawing.Point(30, 120)
        Me.dgvStudents.MultiSelect = False
        Me.dgvStudents.Name = "dgvStudents"
        Me.dgvStudents.ReadOnly = True
        Me.dgvStudents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStudents.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvStudents.RowHeadersWidth = 25
        Me.dgvStudents.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        Me.dgvStudents.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvStudents.RowTemplate.Height = 18
        Me.dgvStudents.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStudents.Size = New System.Drawing.Size(123, 134)
        Me.dgvStudents.TabIndex = 64
        '
        'dgvCourses
        '
        Me.dgvCourses.AllowUserToAddRows = False
        Me.dgvCourses.AllowUserToDeleteRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FloralWhite
        Me.dgvCourses.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvCourses.BackgroundColor = System.Drawing.Color.White
        Me.dgvCourses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.PaleGoldenrod
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCourses.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvCourses.ColumnHeadersHeight = 24
        Me.dgvCourses.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvCourses.EnableHeadersVisualStyles = False
        Me.dgvCourses.GridColor = System.Drawing.Color.White
        Me.dgvCourses.Location = New System.Drawing.Point(30, 260)
        Me.dgvCourses.MultiSelect = False
        Me.dgvCourses.Name = "dgvCourses"
        Me.dgvCourses.ReadOnly = True
        Me.dgvCourses.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCourses.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvCourses.RowHeadersWidth = 25
        Me.dgvCourses.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCourses.RowsDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvCourses.RowTemplate.Height = 45
        Me.dgvCourses.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCourses.Size = New System.Drawing.Size(309, 119)
        Me.dgvCourses.TabIndex = 65
        '
        'ButtonEport
        '
        Me.ButtonEport.FlatAppearance.BorderSize = 0
        Me.ButtonEport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonEport.ForeColor = System.Drawing.Color.White
        Me.ButtonEport.Location = New System.Drawing.Point(3, 257)
        Me.ButtonEport.Name = "ButtonEport"
        Me.ButtonEport.Size = New System.Drawing.Size(128, 55)
        Me.ButtonEport.TabIndex = 66
        Me.ButtonEport.Text = "Export"
        Me.ButtonEport.UseVisualStyleBackColor = True
        '
        'TimerBS
        '
        Me.TimerBS.Enabled = True
        Me.TimerBS.Interval = 500
        '
        'bgwExportToExcel
        '
        '
        'TextBoxTemplateFileName
        '
        Me.TextBoxTemplateFileName.Enabled = False
        Me.TextBoxTemplateFileName.Location = New System.Drawing.Point(322, 14)
        Me.TextBoxTemplateFileName.Name = "TextBoxTemplateFileName"
        Me.TextBoxTemplateFileName.Size = New System.Drawing.Size(327, 20)
        Me.TextBoxTemplateFileName.TabIndex = 67
        '
        'ButtonDownload
        '
        Me.ButtonDownload.FlatAppearance.BorderSize = 0
        Me.ButtonDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDownload.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonDownload.ForeColor = System.Drawing.Color.White
        Me.ButtonDownload.Location = New System.Drawing.Point(655, 15)
        Me.ButtonDownload.Name = "ButtonDownload"
        Me.ButtonDownload.Size = New System.Drawing.Size(95, 21)
        Me.ButtonDownload.TabIndex = 68
        Me.ButtonDownload.Text = "Download"
        Me.ButtonDownload.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Excel Files|*.xlsx"
        Me.SaveFileDialog1.RestoreDirectory = True
        '
        'ProgressBarBS
        '
        Me.ProgressBarBS.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ProgressBarBS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ProgressBarBS.Location = New System.Drawing.Point(3, 14)
        Me.ProgressBarBS.Name = "ProgressBarBS"
        Me.ProgressBarBS.Size = New System.Drawing.Size(302, 20)
        Me.ProgressBarBS.TabIndex = 69
        Me.ProgressBarBS.Value = 1
        '
        'ButtonOpen
        '
        Me.ButtonOpen.FlatAppearance.BorderSize = 0
        Me.ButtonOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonOpen.ForeColor = System.Drawing.Color.White
        Me.ButtonOpen.Location = New System.Drawing.Point(766, 12)
        Me.ButtonOpen.Name = "ButtonOpen"
        Me.ButtonOpen.Size = New System.Drawing.Size(63, 25)
        Me.ButtonOpen.TabIndex = 70
        Me.ButtonOpen.Text = "Open"
        Me.ButtonOpen.UseVisualStyleBackColor = True
        '
        'SidePanel
        '
        Me.SidePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.SidePanel.Controls.Add(Me.ButtonGPACard)
        Me.SidePanel.Controls.Add(Me.ButtonFullScreen)
        Me.SidePanel.Controls.Add(Me.Button2)
        Me.SidePanel.Controls.Add(Me.ButtonTranscript)
        Me.SidePanel.Controls.Add(Me.Button1)
        Me.SidePanel.Controls.Add(Me.ButtonEport)
        Me.SidePanel.Controls.Add(Me.Label1)
        Me.SidePanel.Controls.Add(Me.TextBoxMATNO)
        Me.SidePanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.SidePanel.Location = New System.Drawing.Point(885, 0)
        Me.SidePanel.Name = "SidePanel"
        Me.SidePanel.Size = New System.Drawing.Size(134, 624)
        Me.SidePanel.TabIndex = 71
        '
        'ButtonGPACard
        '
        Me.ButtonGPACard.FlatAppearance.BorderSize = 0
        Me.ButtonGPACard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGPACard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonGPACard.ForeColor = System.Drawing.Color.White
        Me.ButtonGPACard.Location = New System.Drawing.Point(5, 176)
        Me.ButtonGPACard.Name = "ButtonGPACard"
        Me.ButtonGPACard.Size = New System.Drawing.Size(128, 55)
        Me.ButtonGPACard.TabIndex = 68
        Me.ButtonGPACard.Text = "GPA Card"
        Me.ButtonGPACard.UseVisualStyleBackColor = True
        '
        'ButtonFullScreen
        '
        Me.ButtonFullScreen.FlatAppearance.BorderSize = 0
        Me.ButtonFullScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonFullScreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonFullScreen.ForeColor = System.Drawing.Color.White
        Me.ButtonFullScreen.Location = New System.Drawing.Point(3, 408)
        Me.ButtonFullScreen.Name = "ButtonFullScreen"
        Me.ButtonFullScreen.Size = New System.Drawing.Size(125, 55)
        Me.ButtonFullScreen.TabIndex = 67
        Me.ButtonFullScreen.Text = "Full Sreen"
        Me.ButtonFullScreen.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(3, 496)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(128, 55)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ProgressBarBS)
        Me.Panel1.Controls.Add(Me.TextBoxTemplateFileName)
        Me.Panel1.Controls.Add(Me.ButtonOpen)
        Me.Panel1.Controls.Add(Me.ButtonDownload)
        Me.Panel1.Location = New System.Drawing.Point(30, 582)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(836, 42)
        Me.Panel1.TabIndex = 72
        '
        'ReportViewerTranscript
        '
        Me.ReportViewerTranscript.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "DataSetReportBoadSheet"
        ReportDataSource1.Value = Me.ClassBroadsheetsBindingSource
        Me.ReportViewerTranscript.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewerTranscript.LocalReport.ReportEmbeddedResource = "result_and_transcript_system.ReportTranscript.rdlc"
        Me.ReportViewerTranscript.Location = New System.Drawing.Point(352, 115)
        Me.ReportViewerTranscript.Name = "ReportViewerTranscript"
        Me.ReportViewerTranscript.ServerReport.BearerToken = Nothing
        Me.ReportViewerTranscript.Size = New System.Drawing.Size(514, 448)
        Me.ReportViewerTranscript.TabIndex = 73
        Me.ReportViewerTranscript.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        '
        'PictureBoxImg
        '
        Me.PictureBoxImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxImg.Location = New System.Drawing.Point(159, 120)
        Me.PictureBoxImg.Name = "PictureBoxImg"
        Me.PictureBoxImg.Size = New System.Drawing.Size(180, 134)
        Me.PictureBoxImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxImg.TabIndex = 59
        Me.PictureBoxImg.TabStop = False
        '
        'ReportViewerGPCard
        '
        Me.ReportViewerGPCard.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.ClassReportsBindingSource
        Me.ReportViewerGPCard.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewerGPCard.LocalReport.ReportEmbeddedResource = "result_and_transcript_system.ReportGPCard.rdlc"
        Me.ReportViewerGPCard.Location = New System.Drawing.Point(352, 116)
        Me.ReportViewerGPCard.Name = "ReportViewerGPCard"
        Me.ReportViewerGPCard.ServerReport.BearerToken = Nothing
        Me.ReportViewerGPCard.Size = New System.Drawing.Size(514, 448)
        Me.ReportViewerGPCard.TabIndex = 74
        Me.ReportViewerGPCard.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        '
        'ClassReportsBindingSource
        '
        Me.ClassReportsBindingSource.DataSource = GetType(result_and_transcript_system.ClassReports)
        '
        'FormResultsTranscripts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1019, 624)
        Me.Controls.Add(Me.ReportViewerGPCard)
        Me.Controls.Add(Me.ReportViewerTranscript)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SidePanel)
        Me.Controls.Add(Me.dgvCourses)
        Me.Controls.Add(Me.dgvStudents)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.PictureBoxImg)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBoxDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dgvTranscripts)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormResultsTranscripts"
        Me.Tag = "Front"
        Me.Text = "Results - Transcript"
        CType(Me.ClassBroadsheetsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTranscripts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCourses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SidePanel.ResumeLayout(False)
        Me.SidePanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBoxImg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassReportsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxMATNO As TextBox
    Friend WithEvents dgvTranscripts As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblSet As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBoxDate As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents PictureBoxImg As PictureBox
    Friend WithEvents ButtonClose As Button
    Friend WithEvents ButtonTranscript As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents dgvStudents As DataGridView
    Friend WithEvents dgvCourses As DataGridView
    Friend WithEvents ButtonEport As Button
    Friend WithEvents TimerBS As Timer
    Friend WithEvents bgwExportToExcel As System.ComponentModel.BackgroundWorker
    Friend WithEvents TextBoxTemplateFileName As TextBox
    Friend WithEvents ButtonDownload As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ProgressBarBS As ProgressBar
    Friend WithEvents ButtonOpen As Button
    Friend WithEvents SidePanel As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ReportViewerTranscript As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ClassBroadsheetsBindingSource As BindingSource
    Friend WithEvents ButtonFullScreen As Button
    Friend WithEvents ButtonGPACard As Button
    Friend WithEvents ReportViewerGPCard As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ClassReportsBindingSource As BindingSource
End Class
