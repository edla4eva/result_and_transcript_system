<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAdmin
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SidePanel = New System.Windows.Forms.Panel()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.ButtonStudents = New System.Windows.Forms.Button()
        Me.ButtonCloud = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonResults = New System.Windows.Forms.Button()
        Me.ButtonBroadsheets = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridViewCoursesOrder = New System.Windows.Forms.DataGridView()
        Me.BgWProcess = New System.ComponentModel.BackgroundWorker()
        Me.TimerBS = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBarBS = New System.Windows.Forms.ProgressBar()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonActivate = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBoxDevPass = New System.Windows.Forms.TextBox()
        Me.GroupBoxDev = New System.Windows.Forms.GroupBox()
        Me.ButtonOtherConfig = New System.Windows.Forms.Button()
        Me.TextBoxDev = New System.Windows.Forms.TextBox()
        Me.ButtonAddCourses = New System.Windows.Forms.Button()
        Me.ButtonSaveGrid = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ComboBoxLevel = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ButtonAddSession = New System.Windows.Forms.Button()
        Me.ButtonAddDept = New System.Windows.Forms.Button()
        Me.ComboBoxSessions = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxSession = New System.Windows.Forms.TextBox()
        Me.ComboBoxDepartments = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxDepartment = New System.Windows.Forms.TextBox()
        Me.SidePanel.SuspendLayout()
        CType(Me.DataGridViewCoursesOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBoxDev.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'SidePanel
        '
        Me.SidePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.SidePanel.Controls.Add(Me.ButtonClose)
        Me.SidePanel.Controls.Add(Me.ButtonStudents)
        Me.SidePanel.Controls.Add(Me.ButtonCloud)
        Me.SidePanel.Controls.Add(Me.ButtonDelete)
        Me.SidePanel.Controls.Add(Me.ButtonResults)
        Me.SidePanel.Controls.Add(Me.ButtonBroadsheets)
        Me.SidePanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.SidePanel.Location = New System.Drawing.Point(897, 0)
        Me.SidePanel.Name = "SidePanel"
        Me.SidePanel.Size = New System.Drawing.Size(134, 612)
        Me.SidePanel.TabIndex = 7
        '
        'ButtonClose
        '
        Me.ButtonClose.FlatAppearance.BorderSize = 0
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonClose.ForeColor = System.Drawing.Color.White
        Me.ButtonClose.Location = New System.Drawing.Point(3, 441)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(128, 55)
        Me.ButtonClose.TabIndex = 7
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'ButtonStudents
        '
        Me.ButtonStudents.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.ButtonStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonStudents.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonStudents.ForeColor = System.Drawing.Color.White
        Me.ButtonStudents.Location = New System.Drawing.Point(0, 39)
        Me.ButtonStudents.Name = "ButtonStudents"
        Me.ButtonStudents.Size = New System.Drawing.Size(128, 55)
        Me.ButtonStudents.TabIndex = 5
        Me.ButtonStudents.Text = "Students"
        Me.ButtonStudents.UseVisualStyleBackColor = True
        '
        'ButtonCloud
        '
        Me.ButtonCloud.FlatAppearance.BorderSize = 0
        Me.ButtonCloud.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCloud.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonCloud.ForeColor = System.Drawing.Color.White
        Me.ButtonCloud.Location = New System.Drawing.Point(3, 362)
        Me.ButtonCloud.Name = "ButtonCloud"
        Me.ButtonCloud.Size = New System.Drawing.Size(128, 55)
        Me.ButtonCloud.TabIndex = 3
        Me.ButtonCloud.Text = "Sync Cloud"
        Me.ButtonCloud.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.FlatAppearance.BorderSize = 0
        Me.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonDelete.ForeColor = System.Drawing.Color.White
        Me.ButtonDelete.Location = New System.Drawing.Point(3, 223)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(128, 55)
        Me.ButtonDelete.TabIndex = 2
        Me.ButtonDelete.Text = "Delete Results"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonResults
        '
        Me.ButtonResults.FlatAppearance.BorderSize = 0
        Me.ButtonResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonResults.ForeColor = System.Drawing.Color.White
        Me.ButtonResults.Location = New System.Drawing.Point(3, 161)
        Me.ButtonResults.Name = "ButtonResults"
        Me.ButtonResults.Size = New System.Drawing.Size(128, 55)
        Me.ButtonResults.TabIndex = 1
        Me.ButtonResults.Text = "Clear Results"
        Me.ButtonResults.UseVisualStyleBackColor = True
        '
        'ButtonBroadsheets
        '
        Me.ButtonBroadsheets.FlatAppearance.BorderSize = 0
        Me.ButtonBroadsheets.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBroadsheets.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonBroadsheets.ForeColor = System.Drawing.Color.White
        Me.ButtonBroadsheets.Location = New System.Drawing.Point(3, 100)
        Me.ButtonBroadsheets.Name = "ButtonBroadsheets"
        Me.ButtonBroadsheets.Size = New System.Drawing.Size(128, 55)
        Me.ButtonBroadsheets.TabIndex = 0
        Me.ButtonBroadsheets.Text = "BroadSheets Config"
        Me.ButtonBroadsheets.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(131, 314)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(199, 24)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = " Number of Students"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridViewCoursesOrder
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewCoursesOrder.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewCoursesOrder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewCoursesOrder.BackgroundColor = System.Drawing.Color.Silver
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCoursesOrder.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewCoursesOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCoursesOrder.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewCoursesOrder.GridColor = System.Drawing.Color.Gray
        Me.DataGridViewCoursesOrder.Location = New System.Drawing.Point(25, 264)
        Me.DataGridViewCoursesOrder.Name = "DataGridViewCoursesOrder"
        Me.DataGridViewCoursesOrder.Size = New System.Drawing.Size(848, 235)
        Me.DataGridViewCoursesOrder.TabIndex = 32
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
        Me.ProgressBarBS.Location = New System.Drawing.Point(28, 505)
        Me.ProgressBarBS.Name = "ProgressBarBS"
        Me.ProgressBarBS.Size = New System.Drawing.Size(844, 23)
        Me.ProgressBarBS.TabIndex = 33
        Me.ProgressBarBS.Value = 1
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox7.Controls.Add(Me.Label1)
        Me.GroupBox7.Controls.Add(Me.ButtonActivate)
        Me.GroupBox7.Controls.Add(Me.Button17)
        Me.GroupBox7.Controls.Add(Me.TextBox5)
        Me.GroupBox7.Controls.Add(Me.Label13)
        Me.GroupBox7.Controls.Add(Me.TextBoxDevPass)
        Me.GroupBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox7.Location = New System.Drawing.Point(28, 12)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(162, 237)
        Me.GroupBox7.TabIndex = 36
        Me.GroupBox7.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(41, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 24)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Admin"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonActivate
        '
        Me.ButtonActivate.BackColor = System.Drawing.Color.Transparent
        Me.ButtonActivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonActivate.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonActivate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonActivate.Location = New System.Drawing.Point(11, 153)
        Me.ButtonActivate.Name = "ButtonActivate"
        Me.ButtonActivate.Size = New System.Drawing.Size(138, 30)
        Me.ButtonActivate.TabIndex = 39
        Me.ButtonActivate.Text = "Activate"
        Me.ButtonActivate.UseVisualStyleBackColor = False
        '
        'Button17
        '
        Me.Button17.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button17.BackColor = System.Drawing.Color.Transparent
        Me.Button17.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button17.ForeColor = System.Drawing.Color.Silver
        Me.Button17.Location = New System.Drawing.Point(-53, 329)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(255, 30)
        Me.Button17.TabIndex = 32
        Me.Button17.Text = "Add New Course"
        Me.Button17.UseVisualStyleBackColor = False
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(16, 452)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(255, 20)
        Me.TextBox5.TabIndex = 28
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(3, 46)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(158, 24)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Activation Code"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBoxDevPass
        '
        Me.TextBoxDevPass.Location = New System.Drawing.Point(12, 99)
        Me.TextBoxDevPass.Name = "TextBoxDevPass"
        Me.TextBoxDevPass.Size = New System.Drawing.Size(138, 20)
        Me.TextBoxDevPass.TabIndex = 38
        '
        'GroupBoxDev
        '
        Me.GroupBoxDev.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBoxDev.Controls.Add(Me.ButtonOtherConfig)
        Me.GroupBoxDev.Controls.Add(Me.TextBoxDev)
        Me.GroupBoxDev.Controls.Add(Me.ButtonAddCourses)
        Me.GroupBoxDev.Controls.Add(Me.ButtonSaveGrid)
        Me.GroupBoxDev.Controls.Add(Me.Button5)
        Me.GroupBoxDev.Controls.Add(Me.TextBox2)
        Me.GroupBoxDev.Controls.Add(Me.Label11)
        Me.GroupBoxDev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBoxDev.Location = New System.Drawing.Point(721, 7)
        Me.GroupBoxDev.Name = "GroupBoxDev"
        Me.GroupBoxDev.Size = New System.Drawing.Size(151, 251)
        Me.GroupBoxDev.TabIndex = 37
        Me.GroupBoxDev.TabStop = False
        Me.GroupBoxDev.Visible = False
        '
        'ButtonOtherConfig
        '
        Me.ButtonOtherConfig.BackColor = System.Drawing.Color.Transparent
        Me.ButtonOtherConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOtherConfig.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonOtherConfig.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonOtherConfig.Location = New System.Drawing.Point(6, 161)
        Me.ButtonOtherConfig.Name = "ButtonOtherConfig"
        Me.ButtonOtherConfig.Size = New System.Drawing.Size(138, 30)
        Me.ButtonOtherConfig.TabIndex = 40
        Me.ButtonOtherConfig.Text = "Other Config"
        Me.ButtonOtherConfig.UseVisualStyleBackColor = False
        '
        'TextBoxDev
        '
        Me.TextBoxDev.Location = New System.Drawing.Point(6, 197)
        Me.TextBoxDev.Multiline = True
        Me.TextBoxDev.Name = "TextBoxDev"
        Me.TextBoxDev.Size = New System.Drawing.Size(137, 45)
        Me.TextBoxDev.TabIndex = 37
        '
        'ButtonAddCourses
        '
        Me.ButtonAddCourses.BackColor = System.Drawing.Color.Transparent
        Me.ButtonAddCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAddCourses.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonAddCourses.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonAddCourses.Location = New System.Drawing.Point(6, 127)
        Me.ButtonAddCourses.Name = "ButtonAddCourses"
        Me.ButtonAddCourses.Size = New System.Drawing.Size(138, 30)
        Me.ButtonAddCourses.TabIndex = 35
        Me.ButtonAddCourses.Text = "Add Courses"
        Me.ButtonAddCourses.UseVisualStyleBackColor = False
        '
        'ButtonSaveGrid
        '
        Me.ButtonSaveGrid.BackColor = System.Drawing.Color.Transparent
        Me.ButtonSaveGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSaveGrid.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonSaveGrid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonSaveGrid.Location = New System.Drawing.Point(7, 34)
        Me.ButtonSaveGrid.Name = "ButtonSaveGrid"
        Me.ButtonSaveGrid.Size = New System.Drawing.Size(138, 87)
        Me.ButtonSaveGrid.TabIndex = 34
        Me.ButtonSaveGrid.Text = "Save Broadsheet Config"
        Me.ButtonSaveGrid.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button5.ForeColor = System.Drawing.Color.Silver
        Me.Button5.Location = New System.Drawing.Point(-59, 336)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(255, 30)
        Me.Button5.TabIndex = 32
        Me.Button5.Text = "Add New Course"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(16, 452)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(255, 20)
        Me.TextBox2.TabIndex = 28
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(36, 7)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 24)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Admin"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.ComboBoxLevel)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.ButtonAddSession)
        Me.GroupBox3.Controls.Add(Me.ButtonAddDept)
        Me.GroupBox3.Controls.Add(Me.ComboBoxSessions)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.TextBoxSession)
        Me.GroupBox3.Controls.Add(Me.ComboBoxDepartments)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.TextBoxDepartment)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox3.Location = New System.Drawing.Point(319, 7)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(384, 251)
        Me.GroupBox3.TabIndex = 38
        Me.GroupBox3.TabStop = False
        '
        'ComboBoxLevel
        '
        Me.ComboBoxLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxLevel.FormattingEnabled = True
        Me.ComboBoxLevel.Items.AddRange(New Object() {"100", "200", "300", "400", "500", "600", "700", "800", "Yr.1", "Yr.2"})
        Me.ComboBoxLevel.Location = New System.Drawing.Point(27, 134)
        Me.ComboBoxLevel.Name = "ComboBoxLevel"
        Me.ComboBoxLevel.Size = New System.Drawing.Size(162, 21)
        Me.ComboBoxLevel.TabIndex = 38
        Me.ComboBoxLevel.Text = "100"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(25, 120)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 13)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Level"
        '
        'ButtonAddSession
        '
        Me.ButtonAddSession.BackColor = System.Drawing.Color.Transparent
        Me.ButtonAddSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAddSession.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonAddSession.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonAddSession.Location = New System.Drawing.Point(213, 125)
        Me.ButtonAddSession.Name = "ButtonAddSession"
        Me.ButtonAddSession.Size = New System.Drawing.Size(88, 32)
        Me.ButtonAddSession.TabIndex = 34
        Me.ButtonAddSession.Text = "Add"
        Me.ButtonAddSession.UseVisualStyleBackColor = False
        '
        'ButtonAddDept
        '
        Me.ButtonAddDept.BackColor = System.Drawing.Color.Transparent
        Me.ButtonAddDept.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAddDept.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonAddDept.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonAddDept.Location = New System.Drawing.Point(213, 51)
        Me.ButtonAddDept.Name = "ButtonAddDept"
        Me.ButtonAddDept.Size = New System.Drawing.Size(88, 30)
        Me.ButtonAddDept.TabIndex = 32
        Me.ButtonAddDept.Text = "Add"
        Me.ButtonAddDept.UseVisualStyleBackColor = False
        '
        'ComboBoxSessions
        '
        Me.ComboBoxSessions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxSessions.FormattingEnabled = True
        Me.ComboBoxSessions.Items.AddRange(New Object() {"2018/2019", "2019/2020"})
        Me.ComboBoxSessions.Location = New System.Drawing.Point(27, 96)
        Me.ComboBoxSessions.Name = "ComboBoxSessions"
        Me.ComboBoxSessions.Size = New System.Drawing.Size(161, 21)
        Me.ComboBoxSessions.TabIndex = 31
        Me.ComboBoxSessions.Text = "2018/2019"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Session"
        '
        'TextBoxSession
        '
        Me.TextBoxSession.Location = New System.Drawing.Point(213, 99)
        Me.TextBoxSession.Name = "TextBoxSession"
        Me.TextBoxSession.Size = New System.Drawing.Size(88, 20)
        Me.TextBoxSession.TabIndex = 29
        '
        'ComboBoxDepartments
        '
        Me.ComboBoxDepartments.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxDepartments.FormattingEnabled = True
        Me.ComboBoxDepartments.Items.AddRange(New Object() {"Computer Engineering", "Production Engineering"})
        Me.ComboBoxDepartments.Location = New System.Drawing.Point(28, 51)
        Me.ComboBoxDepartments.Name = "ComboBoxDepartments"
        Me.ComboBoxDepartments.Size = New System.Drawing.Size(161, 21)
        Me.ComboBoxDepartments.TabIndex = 27
        Me.ComboBoxDepartments.Text = "Computer Engineering"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Department"
        '
        'TextBoxDepartment
        '
        Me.TextBoxDepartment.Location = New System.Drawing.Point(213, 30)
        Me.TextBoxDepartment.Name = "TextBoxDepartment"
        Me.TextBoxDepartment.Size = New System.Drawing.Size(88, 20)
        Me.TextBoxDepartment.TabIndex = 25
        '
        'FormAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1031, 612)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBoxDev)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.DataGridViewCoursesOrder)
        Me.Controls.Add(Me.ProgressBarBS)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SidePanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormAdmin"
        Me.Text = "FormAdmin"
        Me.SidePanel.ResumeLayout(False)
        CType(Me.DataGridViewCoursesOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBoxDev.ResumeLayout(False)
        Me.GroupBoxDev.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SidePanel As Panel
    Friend WithEvents ButtonCloud As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonResults As Button
    Friend WithEvents ButtonBroadsheets As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonStudents As Button
    Friend WithEvents ButtonClose As Button
    Friend WithEvents DataGridViewCoursesOrder As DataGridView
    Friend WithEvents BgWProcess As System.ComponentModel.BackgroundWorker
    Friend WithEvents TimerBS As Timer
    Friend WithEvents ProgressBarBS As ProgressBar
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents ButtonActivate As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBoxDevPass As TextBox
    Friend WithEvents GroupBoxDev As GroupBox
    Friend WithEvents ButtonOtherConfig As Button
    Friend WithEvents TextBoxDev As TextBox
    Friend WithEvents ButtonAddCourses As Button
    Friend WithEvents ButtonSaveGrid As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ComboBoxLevel As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ButtonAddSession As Button
    Friend WithEvents ButtonAddDept As Button
    Friend WithEvents ComboBoxSessions As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxSession As TextBox
    Friend WithEvents ComboBoxDepartments As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxDepartment As TextBox
    Friend WithEvents Label1 As Label
End Class
