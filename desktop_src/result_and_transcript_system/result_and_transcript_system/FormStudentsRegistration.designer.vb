<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormStudentsRegistration
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvStudents = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblSet = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.ComboBoxDepartments = New System.Windows.Forms.ComboBox()
        Me.ComboBoxSessions = New System.Windows.Forms.ComboBox()
        Me.ComboBoxLevel = New System.Windows.Forms.ComboBox()
        Me.ButtonImportFromAccess = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnExportExcel = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxDeptID = New System.Windows.Forms.TextBox()
        Me.txtStudentMATNO = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonAccess = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dgvCourses = New System.Windows.Forms.DataGridView()
        Me.dgvImportCourses = New System.Windows.Forms.DataGridView()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.LabelAvaliable = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonImportRegRTPS = New System.Windows.Forms.Button()
        Me.ButtonSaveReg = New System.Windows.Forms.Button()
        Me.ButtonRegToExcel = New System.Windows.Forms.Button()
        Me.ButtonImportRegFERMA = New System.Windows.Forms.Button()
        Me.BgWProcess = New System.ComponentModel.BackgroundWorker()
        Me.TimerBS = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBarBS = New System.Windows.Forms.ProgressBar()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.bgwLoad = New System.ComponentModel.BackgroundWorker()
        Me.ButtonShowAllReg = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.TextBoxSession = New System.Windows.Forms.TextBox()
        Me.TextBoxSemester = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxTotalCredits = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxCourseCode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ButtonUnregister = New System.Windows.Forms.Button()
        Me.ButtonRegister = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ComboBoxCourseCode = New System.Windows.Forms.ComboBox()
        Me.PanelCourses = New System.Windows.Forms.Panel()
        Me.CheckedListBoxCourses = New System.Windows.Forms.CheckedListBox()
        Me.ButtonCancelReg = New System.Windows.Forms.Button()
        Me.ButtonOKReg = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgvCourses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvImportCourses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.PanelCourses.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.dgvStudents)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(19, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(659, 346)
        Me.Panel1.TabIndex = 10
        '
        'dgvStudents
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dgvStudents.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvStudents.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvStudents.BackgroundColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStudents.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStudents.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvStudents.GridColor = System.Drawing.Color.Gray
        Me.dgvStudents.Location = New System.Drawing.Point(9, 63)
        Me.dgvStudents.Name = "dgvStudents"
        Me.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStudents.Size = New System.Drawing.Size(863, 265)
        Me.dgvStudents.TabIndex = 77
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
        Me.lblSet.Size = New System.Drawing.Size(23, 13)
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
        Me.Label1.Size = New System.Drawing.Size(151, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "List of Students"
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(81, 127)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(485, 346)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 75
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.ComboBoxDepartments)
        Me.Panel5.Controls.Add(Me.TextBoxSession)
        Me.Panel5.Controls.Add(Me.ComboBoxSessions)
        Me.Panel5.Controls.Add(Me.ComboBoxLevel)
        Me.Panel5.Location = New System.Drawing.Point(689, 212)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(296, 105)
        Me.Panel5.TabIndex = 42
        '
        'ComboBoxDepartments
        '
        Me.ComboBoxDepartments.FormattingEnabled = True
        Me.ComboBoxDepartments.Items.AddRange(New Object() {"Computer Engineering", "Production Engineering"})
        Me.ComboBoxDepartments.Location = New System.Drawing.Point(6, 6)
        Me.ComboBoxDepartments.Name = "ComboBoxDepartments"
        Me.ComboBoxDepartments.Size = New System.Drawing.Size(170, 21)
        Me.ComboBoxDepartments.TabIndex = 25
        Me.ComboBoxDepartments.Text = "Computer Engineering"
        '
        'ComboBoxSessions
        '
        Me.ComboBoxSessions.AutoCompleteCustomSource.AddRange(New String() {"2019/2020"})
        Me.ComboBoxSessions.FormattingEnabled = True
        Me.ComboBoxSessions.Items.AddRange(New Object() {"2018/2019", "2019/2020"})
        Me.ComboBoxSessions.Location = New System.Drawing.Point(6, 42)
        Me.ComboBoxSessions.Name = "ComboBoxSessions"
        Me.ComboBoxSessions.Size = New System.Drawing.Size(169, 21)
        Me.ComboBoxSessions.TabIndex = 31
        Me.ComboBoxSessions.Text = "2018/2019"
        '
        'ComboBoxLevel
        '
        Me.ComboBoxLevel.FormattingEnabled = True
        Me.ComboBoxLevel.Items.AddRange(New Object() {"100", "200", "300", "400", "500", "600", "700", "800", "900"})
        Me.ComboBoxLevel.Location = New System.Drawing.Point(6, 72)
        Me.ComboBoxLevel.Name = "ComboBoxLevel"
        Me.ComboBoxLevel.Size = New System.Drawing.Size(169, 21)
        Me.ComboBoxLevel.TabIndex = 30
        Me.ComboBoxLevel.Text = "100"
        '
        'ButtonImportFromAccess
        '
        Me.ButtonImportFromAccess.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonImportFromAccess.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonImportFromAccess.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonImportFromAccess.Location = New System.Drawing.Point(1006, 81)
        Me.ButtonImportFromAccess.Name = "ButtonImportFromAccess"
        Me.ButtonImportFromAccess.Size = New System.Drawing.Size(123, 28)
        Me.ButtonImportFromAccess.TabIndex = 32
        Me.ButtonImportFromAccess.Text = "Import From Access"
        Me.ButtonImportFromAccess.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1006, 124)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 28)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Import From Excel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnExportExcel
        '
        Me.btnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExportExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportExcel.Location = New System.Drawing.Point(1006, 162)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Size = New System.Drawing.Size(123, 28)
        Me.btnExportExcel.TabIndex = 5
        Me.btnExportExcel.Text = "Export Excel"
        Me.btnExportExcel.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.TextBoxDeptID)
        Me.Panel3.Controls.Add(Me.txtStudentMATNO)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(689, 45)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(139, 145)
        Me.Panel3.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(16, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 24)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Search"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(156, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "DeptID"
        '
        'TextBoxDeptID
        '
        Me.TextBoxDeptID.BackColor = System.Drawing.Color.White
        Me.TextBoxDeptID.Enabled = False
        Me.TextBoxDeptID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDeptID.Location = New System.Drawing.Point(156, 52)
        Me.TextBoxDeptID.Name = "TextBoxDeptID"
        Me.TextBoxDeptID.Size = New System.Drawing.Size(41, 21)
        Me.TextBoxDeptID.TabIndex = 14
        Me.TextBoxDeptID.Text = "1"
        '
        'txtStudentMATNO
        '
        Me.txtStudentMATNO.BackColor = System.Drawing.Color.White
        Me.txtStudentMATNO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentMATNO.Location = New System.Drawing.Point(13, 81)
        Me.txtStudentMATNO.Name = "txtStudentMATNO"
        Me.txtStudentMATNO.Size = New System.Drawing.Size(111, 21)
        Me.txtStudentMATNO.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Search  By MATNO :"
        '
        'ButtonAccess
        '
        Me.ButtonAccess.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAccess.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonAccess.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAccess.Location = New System.Drawing.Point(1006, 496)
        Me.ButtonAccess.Name = "ButtonAccess"
        Me.ButtonAccess.Size = New System.Drawing.Size(123, 51)
        Me.ButtonAccess.TabIndex = 33
        Me.ButtonAccess.Text = "Export to FERMA (Access)"
        Me.ButtonAccess.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(1006, 589)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(119, 28)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(1006, 37)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(119, 33)
        Me.btnReset.TabIndex = 0
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.AutoScroll = True
        Me.Panel4.Controls.Add(Me.dgvCourses)
        Me.Panel4.Controls.Add(Me.dgvImportCourses)
        Me.Panel4.Location = New System.Drawing.Point(19, 424)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(659, 158)
        Me.Panel4.TabIndex = 11
        '
        'dgvCourses
        '
        Me.dgvCourses.AllowUserToAddRows = False
        Me.dgvCourses.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FloralWhite
        Me.dgvCourses.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvCourses.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.dgvCourses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCourses.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvCourses.ColumnHeadersHeight = 24
        Me.dgvCourses.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCourses.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvCourses.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvCourses.EnableHeadersVisualStyles = False
        Me.dgvCourses.GridColor = System.Drawing.Color.White
        Me.dgvCourses.Location = New System.Drawing.Point(5, 30)
        Me.dgvCourses.MultiSelect = False
        Me.dgvCourses.Name = "dgvCourses"
        Me.dgvCourses.ReadOnly = True
        Me.dgvCourses.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCourses.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvCourses.RowHeadersWidth = 25
        Me.dgvCourses.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCourses.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvCourses.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCourses.RowTemplate.Height = 40
        Me.dgvCourses.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCourses.Size = New System.Drawing.Size(630, 128)
        Me.dgvCourses.TabIndex = 41
        '
        'dgvImportCourses
        '
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        Me.dgvImportCourses.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvImportCourses.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvImportCourses.BackgroundColor = System.Drawing.Color.Silver
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvImportCourses.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvImportCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvImportCourses.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgvImportCourses.GridColor = System.Drawing.Color.Gray
        Me.dgvImportCourses.Location = New System.Drawing.Point(5, 17)
        Me.dgvImportCourses.Name = "dgvImportCourses"
        Me.dgvImportCourses.Size = New System.Drawing.Size(630, 155)
        Me.dgvImportCourses.TabIndex = 80
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Transparent
        Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel6.Controls.Add(Me.LabelAvaliable)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Location = New System.Drawing.Point(689, 424)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(301, 55)
        Me.Panel6.TabIndex = 1
        '
        'LabelAvaliable
        '
        Me.LabelAvaliable.AutoSize = True
        Me.LabelAvaliable.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAvaliable.ForeColor = System.Drawing.Color.White
        Me.LabelAvaliable.Location = New System.Drawing.Point(40, 17)
        Me.LabelAvaliable.Name = "LabelAvaliable"
        Me.LabelAvaliable.Size = New System.Drawing.Size(194, 24)
        Me.LabelAvaliable.TabIndex = 1
        Me.LabelAvaliable.Text = "Courses Registered"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(382, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 24)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "List Of Rooms"
        '
        'ButtonImportRegRTPS
        '
        Me.ButtonImportRegRTPS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonImportRegRTPS.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonImportRegRTPS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonImportRegRTPS.Location = New System.Drawing.Point(1006, 360)
        Me.ButtonImportRegRTPS.Name = "ButtonImportRegRTPS"
        Me.ButtonImportRegRTPS.Size = New System.Drawing.Size(117, 42)
        Me.ButtonImportRegRTPS.TabIndex = 9
        Me.ButtonImportRegRTPS.Text = "Import From Excel (RTPS)"
        Me.ButtonImportRegRTPS.UseVisualStyleBackColor = True
        '
        'ButtonSaveReg
        '
        Me.ButtonSaveReg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSaveReg.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonSaveReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSaveReg.Location = New System.Drawing.Point(1006, 408)
        Me.ButtonSaveReg.Name = "ButtonSaveReg"
        Me.ButtonSaveReg.Size = New System.Drawing.Size(119, 28)
        Me.ButtonSaveReg.TabIndex = 8
        Me.ButtonSaveReg.Text = "Save Imported Reg"
        Me.ButtonSaveReg.UseVisualStyleBackColor = True
        '
        'ButtonRegToExcel
        '
        Me.ButtonRegToExcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonRegToExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonRegToExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRegToExcel.Location = New System.Drawing.Point(1006, 311)
        Me.ButtonRegToExcel.Name = "ButtonRegToExcel"
        Me.ButtonRegToExcel.Size = New System.Drawing.Size(123, 28)
        Me.ButtonRegToExcel.TabIndex = 9
        Me.ButtonRegToExcel.Text = "Export Excel"
        Me.ButtonRegToExcel.UseVisualStyleBackColor = True
        '
        'ButtonImportRegFERMA
        '
        Me.ButtonImportRegFERMA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonImportRegFERMA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonImportRegFERMA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonImportRegFERMA.Location = New System.Drawing.Point(1006, 448)
        Me.ButtonImportRegFERMA.Name = "ButtonImportRegFERMA"
        Me.ButtonImportRegFERMA.Size = New System.Drawing.Size(119, 42)
        Me.ButtonImportRegFERMA.TabIndex = 7
        Me.ButtonImportRegFERMA.Text = "Import From Excel (FERMA format)"
        Me.ButtonImportRegFERMA.UseVisualStyleBackColor = True
        '
        'BgWProcess
        '
        '
        'TimerBS
        '
        Me.TimerBS.Enabled = True
        Me.TimerBS.Interval = 1000
        '
        'ProgressBarBS
        '
        Me.ProgressBarBS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBarBS.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ProgressBarBS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ProgressBarBS.Location = New System.Drawing.Point(19, 395)
        Me.ProgressBarBS.Name = "ProgressBarBS"
        Me.ProgressBarBS.Size = New System.Drawing.Size(659, 23)
        Me.ProgressBarBS.TabIndex = 75
        Me.ProgressBarBS.Value = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.result_and_transcript_system.My.Resources.Resources.female_image
        Me.PictureBox1.Location = New System.Drawing.Point(834, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(148, 145)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'ButtonSave
        '
        Me.ButtonSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSave.Location = New System.Drawing.Point(1006, 212)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(123, 23)
        Me.ButtonSave.TabIndex = 76
        Me.ButtonSave.Text = "Save Courses"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'bgwLoad
        '
        '
        'ButtonShowAllReg
        '
        Me.ButtonShowAllReg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonShowAllReg.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonShowAllReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonShowAllReg.Location = New System.Drawing.Point(1006, 248)
        Me.ButtonShowAllReg.Name = "ButtonShowAllReg"
        Me.ButtonShowAllReg.Size = New System.Drawing.Size(119, 28)
        Me.ButtonShowAllReg.TabIndex = 81
        Me.ButtonShowAllReg.Text = "Show All Reg"
        Me.ButtonShowAllReg.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Transparent
        Me.Panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel7.Controls.Add(Me.ComboBoxCourseCode)
        Me.Panel7.Controls.Add(Me.TextBoxSemester)
        Me.Panel7.Controls.Add(Me.Label2)
        Me.Panel7.Controls.Add(Me.TextBoxTotalCredits)
        Me.Panel7.Controls.Add(Me.Label7)
        Me.Panel7.Controls.Add(Me.TextBoxCourseCode)
        Me.Panel7.Controls.Add(Me.Label5)
        Me.Panel7.Controls.Add(Me.ButtonUnregister)
        Me.Panel7.Controls.Add(Me.ButtonRegister)
        Me.Panel7.Controls.Add(Me.Label11)
        Me.Panel7.Location = New System.Drawing.Point(689, 485)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(301, 97)
        Me.Panel7.TabIndex = 82
        '
        'TextBoxSession
        '
        Me.TextBoxSession.Location = New System.Drawing.Point(181, 43)
        Me.TextBoxSession.Name = "TextBoxSession"
        Me.TextBoxSession.Size = New System.Drawing.Size(10, 20)
        Me.TextBoxSession.TabIndex = 92
        '
        'TextBoxSemester
        '
        Me.TextBoxSemester.Location = New System.Drawing.Point(131, 35)
        Me.TextBoxSemester.Name = "TextBoxSemester"
        Me.TextBoxSemester.Size = New System.Drawing.Size(60, 20)
        Me.TextBoxSemester.TabIndex = 90
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "Semester:"
        '
        'TextBoxTotalCredits
        '
        Me.TextBoxTotalCredits.Location = New System.Drawing.Point(131, 62)
        Me.TextBoxTotalCredits.Name = "TextBoxTotalCredits"
        Me.TextBoxTotalCredits.Size = New System.Drawing.Size(60, 20)
        Me.TextBoxTotalCredits.TabIndex = 86
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 85
        Me.Label7.Text = "Total Units"
        '
        'TextBoxCourseCode
        '
        Me.TextBoxCourseCode.Location = New System.Drawing.Point(78, 11)
        Me.TextBoxCourseCode.Name = "TextBoxCourseCode"
        Me.TextBoxCourseCode.Size = New System.Drawing.Size(47, 20)
        Me.TextBoxCourseCode.TabIndex = 84
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 83
        Me.Label5.Text = "Course Code"
        '
        'ButtonUnregister
        '
        Me.ButtonUnregister.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonUnregister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonUnregister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.ButtonUnregister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonUnregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonUnregister.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUnregister.ForeColor = System.Drawing.Color.Black
        Me.ButtonUnregister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonUnregister.Location = New System.Drawing.Point(204, 46)
        Me.ButtonUnregister.Name = "ButtonUnregister"
        Me.ButtonUnregister.Size = New System.Drawing.Size(97, 37)
        Me.ButtonUnregister.TabIndex = 82
        Me.ButtonUnregister.Text = "Unregister"
        Me.ButtonUnregister.UseVisualStyleBackColor = False
        '
        'ButtonRegister
        '
        Me.ButtonRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonRegister.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.ButtonRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRegister.ForeColor = System.Drawing.Color.Black
        Me.ButtonRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonRegister.Location = New System.Drawing.Point(204, 6)
        Me.ButtonRegister.Name = "ButtonRegister"
        Me.ButtonRegister.Size = New System.Drawing.Size(97, 34)
        Me.ButtonRegister.TabIndex = 81
        Me.ButtonRegister.Text = "Register"
        Me.ButtonRegister.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(382, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(139, 24)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "List Of Rooms"
        '
        'ComboBoxCourseCode
        '
        Me.ComboBoxCourseCode.AutoCompleteCustomSource.AddRange(New String() {"2019/2020"})
        Me.ComboBoxCourseCode.FormattingEnabled = True
        Me.ComboBoxCourseCode.Items.AddRange(New Object() {"CPE375"})
        Me.ComboBoxCourseCode.Location = New System.Drawing.Point(131, 10)
        Me.ComboBoxCourseCode.Name = "ComboBoxCourseCode"
        Me.ComboBoxCourseCode.Size = New System.Drawing.Size(62, 21)
        Me.ComboBoxCourseCode.TabIndex = 94
        Me.ComboBoxCourseCode.Text = "CPE375"
        '
        'PanelCourses
        '
        Me.PanelCourses.Controls.Add(Me.ButtonCancelReg)
        Me.PanelCourses.Controls.Add(Me.ButtonOKReg)
        Me.PanelCourses.Controls.Add(Me.CheckedListBoxCourses)
        Me.PanelCourses.Location = New System.Drawing.Point(280, 353)
        Me.PanelCourses.Name = "PanelCourses"
        Me.PanelCourses.Size = New System.Drawing.Size(200, 240)
        Me.PanelCourses.TabIndex = 83
        '
        'CheckedListBoxCourses
        '
        Me.CheckedListBoxCourses.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.CheckedListBoxCourses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CheckedListBoxCourses.CheckOnClick = True
        Me.CheckedListBoxCourses.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckedListBoxCourses.FormattingEnabled = True
        Me.CheckedListBoxCourses.Items.AddRange(New Object() {"CPE311", "CPE313", "CPE362", "CPE375"})
        Me.CheckedListBoxCourses.Location = New System.Drawing.Point(16, 45)
        Me.CheckedListBoxCourses.Name = "CheckedListBoxCourses"
        Me.CheckedListBoxCourses.Size = New System.Drawing.Size(181, 184)
        Me.CheckedListBoxCourses.TabIndex = 76
        Me.CheckedListBoxCourses.Visible = False
        '
        'ButtonCancelReg
        '
        Me.ButtonCancelReg.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonCancelReg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonCancelReg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.ButtonCancelReg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonCancelReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCancelReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancelReg.ForeColor = System.Drawing.Color.Black
        Me.ButtonCancelReg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonCancelReg.Location = New System.Drawing.Point(103, 7)
        Me.ButtonCancelReg.Name = "ButtonCancelReg"
        Me.ButtonCancelReg.Size = New System.Drawing.Size(94, 37)
        Me.ButtonCancelReg.TabIndex = 84
        Me.ButtonCancelReg.Text = "Cancel"
        Me.ButtonCancelReg.UseVisualStyleBackColor = False
        '
        'ButtonOKReg
        '
        Me.ButtonOKReg.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonOKReg.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonOKReg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.ButtonOKReg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonOKReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOKReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOKReg.ForeColor = System.Drawing.Color.Black
        Me.ButtonOKReg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonOKReg.Location = New System.Drawing.Point(16, 8)
        Me.ButtonOKReg.Name = "ButtonOKReg"
        Me.ButtonOKReg.Size = New System.Drawing.Size(81, 34)
        Me.ButtonOKReg.TabIndex = 83
        Me.ButtonOKReg.Text = "OK"
        Me.ButtonOKReg.UseVisualStyleBackColor = False
        '
        'FormStudentsRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1131, 772)
        Me.Controls.Add(Me.PanelCourses)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.ButtonImportFromAccess)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.ButtonSaveReg)
        Me.Controls.Add(Me.btnExportExcel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonImportRegRTPS)
        Me.Controls.Add(Me.ButtonShowAllReg)
        Me.Controls.Add(Me.ButtonRegToExcel)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.ButtonAccess)
        Me.Controls.Add(Me.ButtonImportRegFERMA)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.ProgressBarBS)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormStudentsRegistration"
        Me.Text = "Students Registration"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.dgvCourses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvImportCourses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.PanelCourses.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnExportExcel As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtStudentMATNO As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblSet As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents dgvCourses As DataGridView
    Friend WithEvents Panel6 As Panel
    Friend WithEvents LabelAvaliable As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BgWProcess As System.ComponentModel.BackgroundWorker
    Friend WithEvents TimerBS As Timer
    Friend WithEvents ProgressBarBS As ProgressBar
    Friend WithEvents Button1 As Button
    Friend WithEvents dgvStudents As DataGridView
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonImportRegFERMA As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxDeptID As TextBox
    Friend WithEvents ComboBoxDepartments As ComboBox
    Friend WithEvents bgwLoad As System.ComponentModel.BackgroundWorker
    Friend WithEvents ComboBoxSessions As ComboBox
    Friend WithEvents ComboBoxLevel As ComboBox
    Friend WithEvents ButtonSaveReg As Button
    Friend WithEvents dgvImportCourses As DataGridView
    Friend WithEvents ButtonImportFromAccess As Button
    Friend WithEvents ButtonRegToExcel As Button
    Friend WithEvents ButtonAccess As Button
    Friend WithEvents ButtonImportRegRTPS As Button
    Friend WithEvents ButtonShowAllReg As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents TextBoxSession As TextBox
    Friend WithEvents TextBoxSemester As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxTotalCredits As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxCourseCode As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ButtonUnregister As Button
    Friend WithEvents ButtonRegister As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents ComboBoxCourseCode As ComboBox
    Friend WithEvents PanelCourses As Panel
    Friend WithEvents ButtonCancelReg As Button
    Friend WithEvents ButtonOKReg As Button
    Friend WithEvents CheckedListBoxCourses As CheckedListBox
End Class
