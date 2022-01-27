<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormStudentRegFORM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormStudentRegFORM))
        Me.ProgressBarBS = New System.Windows.Forms.ProgressBar()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.ComboBoxDepartments = New System.Windows.Forms.ComboBox()
        Me.TextBoxdept_idr = New System.Windows.Forms.TextBox()
        Me.ComboBoxSessions = New System.Windows.Forms.ComboBox()
        Me.ComboBoxLevel = New System.Windows.Forms.ComboBox()
        Me.ButtonRefreshFormview = New System.Windows.Forms.Button()
        Me.TextBoxsession_idr = New System.Windows.Forms.TextBox()
        Me.ButtonImportStudentsFromExcel = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxstudent_dept_idr = New System.Windows.Forms.TextBox()
        Me.txtStudentMATNO = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonAccess = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.LabelAvaliable = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonImportRegRTPS = New System.Windows.Forms.Button()
        Me.ButtonSaveReg = New System.Windows.Forms.Button()
        Me.ButtonRegToExcel = New System.Windows.Forms.Button()
        Me.ButtonImportRegFERMAExcel = New System.Windows.Forms.Button()
        Me.TimerBS = New System.Windows.Forms.Timer(Me.components)
        Me.bgwLoad = New System.ComponentModel.BackgroundWorker()
        Me.PanelGegSingle = New System.Windows.Forms.Panel()
        Me.ComboBoxCourseCode = New System.Windows.Forms.ComboBox()
        Me.TextBoxCourseCode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ButtonUnregister = New System.Windows.Forms.Button()
        Me.ButtonRegister = New System.Windows.Forms.Button()
        Me.TextBoxTotalCredits = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ButtonSaveRecord = New System.Windows.Forms.Button()
        Me.PanelCourses = New System.Windows.Forms.Panel()
        Me.ButtonCancelReg = New System.Windows.Forms.Button()
        Me.ButtonOKReg = New System.Windows.Forms.Button()
        Me.CheckedListBoxCourses = New System.Windows.Forms.CheckedListBox()
        Me.ButtonDownloadTemplate = New System.Windows.Forms.Button()
        Me.PanelAllReg = New System.Windows.Forms.Panel()
        Me.ButtonDeleteReg = New System.Windows.Forms.Button()
        Me.PanelForm = New System.Windows.Forms.Panel()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.ButtonLast = New System.Windows.Forms.Button()
        Me.ButtonFirst = New System.Windows.Forms.Button()
        Me.ButtonAddNewRecordInFORM = New System.Windows.Forms.Button()
        Me.TextBoxNA_CourseCode = New System.Windows.Forms.TextBox()
        Me.ComboBoxGender = New System.Windows.Forms.ComboBox()
        Me.ComboBoxStatus = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TextBoxgender = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TextBoxyear_of_entry = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextBoxemail = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TextBoxphone = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TextBoxdob = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxstatus = New System.Windows.Forms.TextBox()
        Me.TextBoxlevel = New System.Windows.Forms.TextBox()
        Me.TextBoxFees_Status = New System.Windows.Forms.TextBox()
        Me.ComboBoxEntryMode = New System.Windows.Forms.ComboBox()
        Me.ComboBoxShortCuts2 = New System.Windows.Forms.ComboBox()
        Me.ButtonMovePrevious = New System.Windows.Forms.Button()
        Me.ComboBoxShortCuts1 = New System.Windows.Forms.ComboBox()
        Me.TextBoxCourseCode_2 = New System.Windows.Forms.TextBox()
        Me.TextBoxCourseCode_1 = New System.Windows.Forms.TextBox()
        Me.ButtonClosePanelForm = New System.Windows.Forms.Button()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.TextBoxmode_of_entry = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxsession_idr_of_entry = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBoxstudent_othernames = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBoxstudent_firstname = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBoxstudent_surname = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBoxMATNO = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ButtonNext = New System.Windows.Forms.Button()
        Me.ButtonFormView = New System.Windows.Forms.Button()
        Me.ButtonSaveGrid = New System.Windows.Forms.Button()
        Me.ButtonImportRegFERMAAccess = New System.Windows.Forms.Button()
        Me.ButtonBack = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BindingSourceStudents = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.PanelGegSingle.SuspendLayout()
        Me.PanelCourses.SuspendLayout()
        Me.PanelAllReg.SuspendLayout()
        Me.PanelForm.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgressBarBS
        '
        Me.ProgressBarBS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBarBS.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ProgressBarBS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ProgressBarBS.Location = New System.Drawing.Point(19, 390)
        Me.ProgressBarBS.Name = "ProgressBarBS"
        Me.ProgressBarBS.Size = New System.Drawing.Size(659, 23)
        Me.ProgressBarBS.TabIndex = 75
        Me.ProgressBarBS.Value = 1
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.ComboBoxDepartments)
        Me.Panel5.Controls.Add(Me.TextBoxdept_idr)
        Me.Panel5.Controls.Add(Me.ComboBoxSessions)
        Me.Panel5.Controls.Add(Me.ComboBoxLevel)
        Me.Panel5.Controls.Add(Me.ButtonRefreshFormview)
        Me.Panel5.Location = New System.Drawing.Point(689, 196)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(296, 137)
        Me.Panel5.TabIndex = 42
        '
        'ComboBoxDepartments
        '
        Me.ComboBoxDepartments.FormattingEnabled = True
        Me.ComboBoxDepartments.Items.AddRange(New Object() {"Computer Engineering", "Production Engineering"})
        Me.ComboBoxDepartments.Location = New System.Drawing.Point(6, 6)
        Me.ComboBoxDepartments.Name = "ComboBoxDepartments"
        Me.ComboBoxDepartments.Size = New System.Drawing.Size(285, 24)
        Me.ComboBoxDepartments.TabIndex = 25
        Me.ComboBoxDepartments.Text = "Computer Engineering"
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
        Me.ButtonRefreshFormview.Location = New System.Drawing.Point(6, 95)
        Me.ButtonRefreshFormview.Name = "ButtonRefreshFormview"
        Me.ButtonRefreshFormview.Size = New System.Drawing.Size(286, 35)
        Me.ButtonRefreshFormview.TabIndex = 13
        Me.ButtonRefreshFormview.Text = "Reload Specified Students from Database"
        Me.ButtonRefreshFormview.UseVisualStyleBackColor = True
        '
        'TextBoxsession_idr
        '
        Me.TextBoxsession_idr.Enabled = False
        Me.TextBoxsession_idr.Location = New System.Drawing.Point(545, 278)
        Me.TextBoxsession_idr.Name = "TextBoxsession_idr"
        Me.TextBoxsession_idr.Size = New System.Drawing.Size(106, 22)
        Me.TextBoxsession_idr.TabIndex = 92
        '
        'ButtonImportStudentsFromExcel
        '
        Me.ButtonImportStudentsFromExcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonImportStudentsFromExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonImportStudentsFromExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonImportStudentsFromExcel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ButtonImportStudentsFromExcel.Location = New System.Drawing.Point(1006, 84)
        Me.ButtonImportStudentsFromExcel.Name = "ButtonImportStudentsFromExcel"
        Me.ButtonImportStudentsFromExcel.Size = New System.Drawing.Size(119, 50)
        Me.ButtonImportStudentsFromExcel.TabIndex = 6
        Me.ButtonImportStudentsFromExcel.Text = "Add Students"
        Me.ButtonImportStudentsFromExcel.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.TextBoxstudent_dept_idr)
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
        Me.Label9.Location = New System.Drawing.Point(31, 15)
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
        Me.Label8.Size = New System.Drawing.Size(50, 16)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "DeptID"
        '
        'TextBoxstudent_dept_idr
        '
        Me.TextBoxstudent_dept_idr.BackColor = System.Drawing.Color.White
        Me.TextBoxstudent_dept_idr.Enabled = False
        Me.TextBoxstudent_dept_idr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxstudent_dept_idr.Location = New System.Drawing.Point(156, 52)
        Me.TextBoxstudent_dept_idr.Name = "TextBoxstudent_dept_idr"
        Me.TextBoxstudent_dept_idr.Size = New System.Drawing.Size(41, 21)
        Me.TextBoxstudent_dept_idr.TabIndex = 14
        Me.TextBoxstudent_dept_idr.Text = "1"
        '
        'txtStudentMATNO
        '
        Me.txtStudentMATNO.BackColor = System.Drawing.Color.White
        Me.txtStudentMATNO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentMATNO.Location = New System.Drawing.Point(10, 81)
        Me.txtStudentMATNO.Name = "txtStudentMATNO"
        Me.txtStudentMATNO.Size = New System.Drawing.Size(121, 21)
        Me.txtStudentMATNO.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Search  By MATNO :"
        '
        'ButtonAccess
        '
        Me.ButtonAccess.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAccess.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAccess.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAccess.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ButtonAccess.Location = New System.Drawing.Point(1000, 576)
        Me.ButtonAccess.Name = "ButtonAccess"
        Me.ButtonAccess.Size = New System.Drawing.Size(123, 12)
        Me.ButtonAccess.TabIndex = 33
        Me.ButtonAccess.Text = "Export to FERMA (Access)"
        Me.ButtonAccess.UseVisualStyleBackColor = True
        Me.ButtonAccess.Visible = False
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
        'btnReset
        '
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnReset.Location = New System.Drawing.Point(1006, 37)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(119, 33)
        Me.btnReset.TabIndex = 0
        Me.btnReset.Text = "Refresh"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Transparent
        Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel6.Controls.Add(Me.LabelAvaliable)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Location = New System.Drawing.Point(157, 4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(301, 41)
        Me.Panel6.TabIndex = 1
        '
        'LabelAvaliable
        '
        Me.LabelAvaliable.AutoSize = True
        Me.LabelAvaliable.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAvaliable.ForeColor = System.Drawing.Color.White
        Me.LabelAvaliable.Location = New System.Drawing.Point(40, 10)
        Me.LabelAvaliable.Name = "LabelAvaliable"
        Me.LabelAvaliable.Size = New System.Drawing.Size(248, 24)
        Me.LabelAvaliable.TabIndex = 1
        Me.LabelAvaliable.Text = "Course Registration Form"
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
        Me.ButtonImportRegRTPS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonImportRegRTPS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonImportRegRTPS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonImportRegRTPS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ButtonImportRegRTPS.Location = New System.Drawing.Point(1001, 306)
        Me.ButtonImportRegRTPS.Name = "ButtonImportRegRTPS"
        Me.ButtonImportRegRTPS.Size = New System.Drawing.Size(120, 42)
        Me.ButtonImportRegRTPS.TabIndex = 9
        Me.ButtonImportRegRTPS.Text = "Import From RTPS Format"
        Me.ButtonImportRegRTPS.UseVisualStyleBackColor = True
        '
        'ButtonSaveReg
        '
        Me.ButtonSaveReg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSaveReg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonSaveReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSaveReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSaveReg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ButtonSaveReg.Location = New System.Drawing.Point(1001, 354)
        Me.ButtonSaveReg.Name = "ButtonSaveReg"
        Me.ButtonSaveReg.Size = New System.Drawing.Size(122, 28)
        Me.ButtonSaveReg.TabIndex = 8
        Me.ButtonSaveReg.Text = "Save Imported Reg"
        Me.ButtonSaveReg.UseVisualStyleBackColor = True
        '
        'ButtonRegToExcel
        '
        Me.ButtonRegToExcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonRegToExcel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonRegToExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRegToExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRegToExcel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ButtonRegToExcel.Location = New System.Drawing.Point(1001, 388)
        Me.ButtonRegToExcel.Name = "ButtonRegToExcel"
        Me.ButtonRegToExcel.Size = New System.Drawing.Size(122, 43)
        Me.ButtonRegToExcel.TabIndex = 9
        Me.ButtonRegToExcel.Text = "Export to Excel"
        Me.ButtonRegToExcel.UseVisualStyleBackColor = True
        '
        'ButtonImportRegFERMAExcel
        '
        Me.ButtonImportRegFERMAExcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonImportRegFERMAExcel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonImportRegFERMAExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonImportRegFERMAExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonImportRegFERMAExcel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ButtonImportRegFERMAExcel.Location = New System.Drawing.Point(1000, 507)
        Me.ButtonImportRegFERMAExcel.Name = "ButtonImportRegFERMAExcel"
        Me.ButtonImportRegFERMAExcel.Size = New System.Drawing.Size(123, 63)
        Me.ButtonImportRegFERMAExcel.TabIndex = 7
        Me.ButtonImportRegFERMAExcel.Text = "Import From FERMA Format"
        Me.ButtonImportRegFERMAExcel.UseVisualStyleBackColor = True
        '
        'TimerBS
        '
        Me.TimerBS.Enabled = True
        Me.TimerBS.Interval = 1000
        '
        'bgwLoad
        '
        '
        'PanelGegSingle
        '
        Me.PanelGegSingle.BackColor = System.Drawing.Color.Transparent
        Me.PanelGegSingle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelGegSingle.Controls.Add(Me.ComboBoxCourseCode)
        Me.PanelGegSingle.Controls.Add(Me.TextBoxCourseCode)
        Me.PanelGegSingle.Controls.Add(Me.Label5)
        Me.PanelGegSingle.Controls.Add(Me.ButtonUnregister)
        Me.PanelGegSingle.Controls.Add(Me.ButtonRegister)
        Me.PanelGegSingle.Controls.Add(Me.TextBoxTotalCredits)
        Me.PanelGegSingle.Controls.Add(Me.Label7)
        Me.PanelGegSingle.Location = New System.Drawing.Point(52, 380)
        Me.PanelGegSingle.Name = "PanelGegSingle"
        Me.PanelGegSingle.Size = New System.Drawing.Size(599, 50)
        Me.PanelGegSingle.TabIndex = 82
        '
        'ComboBoxCourseCode
        '
        Me.ComboBoxCourseCode.AutoCompleteCustomSource.AddRange(New String() {"2019/2020"})
        Me.ComboBoxCourseCode.FormattingEnabled = True
        Me.ComboBoxCourseCode.Items.AddRange(New Object() {"CPE375"})
        Me.ComboBoxCourseCode.Location = New System.Drawing.Point(86, 10)
        Me.ComboBoxCourseCode.Name = "ComboBoxCourseCode"
        Me.ComboBoxCourseCode.Size = New System.Drawing.Size(184, 24)
        Me.ComboBoxCourseCode.TabIndex = 94
        Me.ComboBoxCourseCode.Text = "CPE375"
        '
        'TextBoxCourseCode
        '
        Me.TextBoxCourseCode.Location = New System.Drawing.Point(150, 10)
        Me.TextBoxCourseCode.Name = "TextBoxCourseCode"
        Me.TextBoxCourseCode.Size = New System.Drawing.Size(10, 22)
        Me.TextBoxCourseCode.TabIndex = 84
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 16)
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
        Me.ButtonUnregister.Location = New System.Drawing.Point(390, 2)
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
        Me.ButtonRegister.Location = New System.Drawing.Point(280, 3)
        Me.ButtonRegister.Name = "ButtonRegister"
        Me.ButtonRegister.Size = New System.Drawing.Size(97, 34)
        Me.ButtonRegister.TabIndex = 81
        Me.ButtonRegister.Text = "Register"
        Me.ButtonRegister.UseVisualStyleBackColor = False
        '
        'TextBoxTotalCredits
        '
        Me.TextBoxTotalCredits.Location = New System.Drawing.Point(493, 18)
        Me.TextBoxTotalCredits.Name = "TextBoxTotalCredits"
        Me.TextBoxTotalCredits.Size = New System.Drawing.Size(66, 22)
        Me.TextBoxTotalCredits.TabIndex = 86
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(487, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 16)
        Me.Label7.TabIndex = 85
        Me.Label7.Text = "Total Units"
        '
        'ButtonSaveRecord
        '
        Me.ButtonSaveRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSaveRecord.Location = New System.Drawing.Point(415, 452)
        Me.ButtonSaveRecord.Name = "ButtonSaveRecord"
        Me.ButtonSaveRecord.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSaveRecord.TabIndex = 99
        Me.ButtonSaveRecord.Text = "Save"
        Me.ButtonSaveRecord.UseVisualStyleBackColor = True
        '
        'PanelCourses
        '
        Me.PanelCourses.Controls.Add(Me.ButtonCancelReg)
        Me.PanelCourses.Controls.Add(Me.ButtonOKReg)
        Me.PanelCourses.Controls.Add(Me.CheckedListBoxCourses)
        Me.PanelCourses.Location = New System.Drawing.Point(328, 58)
        Me.PanelCourses.Name = "PanelCourses"
        Me.PanelCourses.Size = New System.Drawing.Size(211, 361)
        Me.PanelCourses.TabIndex = 83
        Me.PanelCourses.Visible = False
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
        'CheckedListBoxCourses
        '
        Me.CheckedListBoxCourses.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.CheckedListBoxCourses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CheckedListBoxCourses.CheckOnClick = True
        Me.CheckedListBoxCourses.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckedListBoxCourses.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CheckedListBoxCourses.FormattingEnabled = True
        Me.CheckedListBoxCourses.Items.AddRange(New Object() {"CPE311", "CPE313", "CPE362", "CPE375"})
        Me.CheckedListBoxCourses.Location = New System.Drawing.Point(16, 45)
        Me.CheckedListBoxCourses.Name = "CheckedListBoxCourses"
        Me.CheckedListBoxCourses.Size = New System.Drawing.Size(181, 314)
        Me.CheckedListBoxCourses.TabIndex = 76
        '
        'ButtonDownloadTemplate
        '
        Me.ButtonDownloadTemplate.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonDownloadTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDownloadTemplate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonDownloadTemplate.ForeColor = System.Drawing.Color.White
        Me.ButtonDownloadTemplate.Location = New System.Drawing.Point(1001, 239)
        Me.ButtonDownloadTemplate.Name = "ButtonDownloadTemplate"
        Me.ButtonDownloadTemplate.Size = New System.Drawing.Size(122, 55)
        Me.ButtonDownloadTemplate.TabIndex = 84
        Me.ButtonDownloadTemplate.Text = "Download Template"
        Me.ButtonDownloadTemplate.UseVisualStyleBackColor = True
        '
        'PanelAllReg
        '
        Me.PanelAllReg.AutoScroll = True
        Me.PanelAllReg.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanelAllReg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelAllReg.Controls.Add(Me.ButtonDeleteReg)
        Me.PanelAllReg.Location = New System.Drawing.Point(677, 43)
        Me.PanelAllReg.Name = "PanelAllReg"
        Me.PanelAllReg.Size = New System.Drawing.Size(313, 580)
        Me.PanelAllReg.TabIndex = 85
        Me.PanelAllReg.Visible = False
        '
        'ButtonDeleteReg
        '
        Me.ButtonDeleteReg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonDeleteReg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonDeleteReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDeleteReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDeleteReg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ButtonDeleteReg.Location = New System.Drawing.Point(15, 75)
        Me.ButtonDeleteReg.Name = "ButtonDeleteReg"
        Me.ButtonDeleteReg.Size = New System.Drawing.Size(119, 38)
        Me.ButtonDeleteReg.TabIndex = 82
        Me.ButtonDeleteReg.Text = "Delete"
        Me.ButtonDeleteReg.UseVisualStyleBackColor = True
        '
        'PanelForm
        '
        Me.PanelForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelForm.Controls.Add(Me.Label23)
        Me.PanelForm.Controls.Add(Me.ButtonLast)
        Me.PanelForm.Controls.Add(Me.ButtonFirst)
        Me.PanelForm.Controls.Add(Me.ButtonAddNewRecordInFORM)
        Me.PanelForm.Controls.Add(Me.TextBoxNA_CourseCode)
        Me.PanelForm.Controls.Add(Me.PanelCourses)
        Me.PanelForm.Controls.Add(Me.ComboBoxGender)
        Me.PanelForm.Controls.Add(Me.ComboBoxStatus)
        Me.PanelForm.Controls.Add(Me.Label22)
        Me.PanelForm.Controls.Add(Me.TextBoxsession_idr)
        Me.PanelForm.Controls.Add(Me.TextBoxgender)
        Me.PanelForm.Controls.Add(Me.Label21)
        Me.PanelForm.Controls.Add(Me.TextBoxyear_of_entry)
        Me.PanelForm.Controls.Add(Me.Label20)
        Me.PanelForm.Controls.Add(Me.TextBoxemail)
        Me.PanelForm.Controls.Add(Me.Label19)
        Me.PanelForm.Controls.Add(Me.TextBoxphone)
        Me.PanelForm.Controls.Add(Me.Label18)
        Me.PanelForm.Controls.Add(Me.TextBoxdob)
        Me.PanelForm.Controls.Add(Me.Label17)
        Me.PanelForm.Controls.Add(Me.ButtonSaveRecord)
        Me.PanelForm.Controls.Add(Me.Label11)
        Me.PanelForm.Controls.Add(Me.Label2)
        Me.PanelForm.Controls.Add(Me.TextBoxstatus)
        Me.PanelForm.Controls.Add(Me.TextBoxlevel)
        Me.PanelForm.Controls.Add(Me.TextBoxFees_Status)
        Me.PanelForm.Controls.Add(Me.ComboBoxEntryMode)
        Me.PanelForm.Controls.Add(Me.ComboBoxShortCuts2)
        Me.PanelForm.Controls.Add(Me.ButtonMovePrevious)
        Me.PanelForm.Controls.Add(Me.ComboBoxShortCuts1)
        Me.PanelForm.Controls.Add(Me.TextBoxCourseCode_2)
        Me.PanelForm.Controls.Add(Me.TextBoxCourseCode_1)
        Me.PanelForm.Controls.Add(Me.ButtonClosePanelForm)
        Me.PanelForm.Controls.Add(Me.PanelGegSingle)
        Me.PanelForm.Controls.Add(Me.BindingNavigator1)
        Me.PanelForm.Controls.Add(Me.TextBoxmode_of_entry)
        Me.PanelForm.Controls.Add(Me.Label6)
        Me.PanelForm.Controls.Add(Me.TextBoxsession_idr_of_entry)
        Me.PanelForm.Controls.Add(Me.Panel6)
        Me.PanelForm.Controls.Add(Me.Label12)
        Me.PanelForm.Controls.Add(Me.TextBoxstudent_othernames)
        Me.PanelForm.Controls.Add(Me.Label13)
        Me.PanelForm.Controls.Add(Me.TextBoxstudent_firstname)
        Me.PanelForm.Controls.Add(Me.Label14)
        Me.PanelForm.Controls.Add(Me.TextBoxstudent_surname)
        Me.PanelForm.Controls.Add(Me.Label15)
        Me.PanelForm.Controls.Add(Me.TextBoxMATNO)
        Me.PanelForm.Controls.Add(Me.Label16)
        Me.PanelForm.Controls.Add(Me.ButtonNext)
        Me.PanelForm.Location = New System.Drawing.Point(19, 43)
        Me.PanelForm.Name = "PanelForm"
        Me.PanelForm.Size = New System.Drawing.Size(659, 580)
        Me.PanelForm.TabIndex = 87
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(597, 51)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(31, 16)
        Me.Label23.TabIndex = 123
        Me.Label23.Text = "N/A"
        '
        'ButtonLast
        '
        Me.ButtonLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLast.Location = New System.Drawing.Point(288, 452)
        Me.ButtonLast.Name = "ButtonLast"
        Me.ButtonLast.Size = New System.Drawing.Size(33, 23)
        Me.ButtonLast.TabIndex = 122
        Me.ButtonLast.Text = ">|"
        Me.ButtonLast.UseVisualStyleBackColor = True
        '
        'ButtonFirst
        '
        Me.ButtonFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonFirst.Location = New System.Drawing.Point(9, 452)
        Me.ButtonFirst.Name = "ButtonFirst"
        Me.ButtonFirst.Size = New System.Drawing.Size(33, 23)
        Me.ButtonFirst.TabIndex = 121
        Me.ButtonFirst.Text = "|<"
        Me.ButtonFirst.UseVisualStyleBackColor = True
        '
        'ButtonAddNewRecordInFORM
        '
        Me.ButtonAddNewRecordInFORM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAddNewRecordInFORM.Location = New System.Drawing.Point(129, 452)
        Me.ButtonAddNewRecordInFORM.Name = "ButtonAddNewRecordInFORM"
        Me.ButtonAddNewRecordInFORM.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAddNewRecordInFORM.TabIndex = 120
        Me.ButtonAddNewRecordInFORM.Text = "Add "
        Me.ButtonAddNewRecordInFORM.UseVisualStyleBackColor = True
        '
        'TextBoxNA_CourseCode
        '
        Me.TextBoxNA_CourseCode.Location = New System.Drawing.Point(597, 75)
        Me.TextBoxNA_CourseCode.Multiline = True
        Me.TextBoxNA_CourseCode.Name = "TextBoxNA_CourseCode"
        Me.TextBoxNA_CourseCode.Size = New System.Drawing.Size(54, 167)
        Me.TextBoxNA_CourseCode.TabIndex = 119
        '
        'ComboBoxGender
        '
        Me.ComboBoxGender.AutoCompleteCustomSource.AddRange(New String() {"male", "female"})
        Me.ComboBoxGender.FormattingEnabled = True
        Me.ComboBoxGender.Items.AddRange(New Object() {"male", "female"})
        Me.ComboBoxGender.Location = New System.Drawing.Point(247, 292)
        Me.ComboBoxGender.Name = "ComboBoxGender"
        Me.ComboBoxGender.Size = New System.Drawing.Size(75, 24)
        Me.ComboBoxGender.TabIndex = 118
        Me.ComboBoxGender.Text = "male"
        '
        'ComboBoxStatus
        '
        Me.ComboBoxStatus.AutoCompleteCustomSource.AddRange(New String() {"2019/2020"})
        Me.ComboBoxStatus.FormattingEnabled = True
        Me.ComboBoxStatus.Items.AddRange(New Object() {"REGISTERED", "SUCCESSFUL", "STUDENTS WITH CARRY OVER", "PROBATION", "FAIL/WITHDRAW", "TEMPORARY WITHDRAWAL", "UNREGISTERED"})
        Me.ComboBoxStatus.Location = New System.Drawing.Point(427, 306)
        Me.ComboBoxStatus.Name = "ComboBoxStatus"
        Me.ComboBoxStatus.Size = New System.Drawing.Size(224, 24)
        Me.ComboBoxStatus.TabIndex = 117
        Me.ComboBoxStatus.Text = "REGISTERED"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(199, 301)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(56, 16)
        Me.Label22.TabIndex = 116
        Me.Label22.Text = "Gender:"
        '
        'TextBoxgender
        '
        Me.TextBoxgender.Location = New System.Drawing.Point(268, 295)
        Me.TextBoxgender.Name = "TextBoxgender"
        Me.TextBoxgender.Size = New System.Drawing.Size(54, 22)
        Me.TextBoxgender.TabIndex = 115
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(194, 241)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(73, 16)
        Me.Label21.TabIndex = 114
        Me.Label21.Text = "Entry Year:"
        '
        'TextBoxyear_of_entry
        '
        Me.TextBoxyear_of_entry.Location = New System.Drawing.Point(274, 238)
        Me.TextBoxyear_of_entry.Name = "TextBoxyear_of_entry"
        Me.TextBoxyear_of_entry.Size = New System.Drawing.Size(48, 22)
        Me.TextBoxyear_of_entry.TabIndex = 113
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(342, 343)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(45, 16)
        Me.Label20.TabIndex = 112
        Me.Label20.Text = "Email:"
        '
        'TextBoxemail
        '
        Me.TextBoxemail.Location = New System.Drawing.Point(427, 334)
        Me.TextBoxemail.Name = "TextBoxemail"
        Me.TextBoxemail.Size = New System.Drawing.Size(224, 22)
        Me.TextBoxemail.TabIndex = 111
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(49, 326)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(50, 16)
        Me.Label19.TabIndex = 110
        Me.Label19.Text = "Phone:"
        '
        'TextBoxphone
        '
        Me.TextBoxphone.Location = New System.Drawing.Point(138, 320)
        Me.TextBoxphone.Name = "TextBoxphone"
        Me.TextBoxphone.Size = New System.Drawing.Size(184, 22)
        Me.TextBoxphone.TabIndex = 109
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(49, 301)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(40, 16)
        Me.Label18.TabIndex = 108
        Me.Label18.Text = "DOB:"
        '
        'TextBoxdob
        '
        Me.TextBoxdob.Location = New System.Drawing.Point(138, 295)
        Me.TextBoxdob.Name = "TextBoxdob"
        Me.TextBoxdob.Size = New System.Drawing.Size(54, 22)
        Me.TextBoxdob.TabIndex = 107
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(342, 309)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(45, 16)
        Me.Label17.TabIndex = 106
        Me.Label17.Text = "Status"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(50, 273)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 16)
        Me.Label11.TabIndex = 105
        Me.Label11.Text = "Fees Paid?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 241)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "Level:"
        '
        'TextBoxstatus
        '
        Me.TextBoxstatus.Location = New System.Drawing.Point(427, 306)
        Me.TextBoxstatus.Name = "TextBoxstatus"
        Me.TextBoxstatus.Size = New System.Drawing.Size(142, 22)
        Me.TextBoxstatus.TabIndex = 103
        '
        'TextBoxlevel
        '
        Me.TextBoxlevel.Location = New System.Drawing.Point(138, 238)
        Me.TextBoxlevel.Name = "TextBoxlevel"
        Me.TextBoxlevel.Size = New System.Drawing.Size(38, 22)
        Me.TextBoxlevel.TabIndex = 102
        '
        'TextBoxFees_Status
        '
        Me.TextBoxFees_Status.Location = New System.Drawing.Point(182, 267)
        Me.TextBoxFees_Status.Name = "TextBoxFees_Status"
        Me.TextBoxFees_Status.Size = New System.Drawing.Size(140, 22)
        Me.TextBoxFees_Status.TabIndex = 101
        '
        'ComboBoxEntryMode
        '
        Me.ComboBoxEntryMode.AutoCompleteCustomSource.AddRange(New String() {"2019/2020"})
        Me.ComboBoxEntryMode.FormattingEnabled = True
        Me.ComboBoxEntryMode.Items.AddRange(New Object() {"UME", "DE", "DIP", "Full-time", "Part-time"})
        Me.ComboBoxEntryMode.Location = New System.Drawing.Point(201, 210)
        Me.ComboBoxEntryMode.Name = "ComboBoxEntryMode"
        Me.ComboBoxEntryMode.Size = New System.Drawing.Size(121, 24)
        Me.ComboBoxEntryMode.TabIndex = 98
        Me.ComboBoxEntryMode.Text = "UME"
        '
        'ComboBoxShortCuts2
        '
        Me.ComboBoxShortCuts2.AutoCompleteCustomSource.AddRange(New String() {"2019/2020"})
        Me.ComboBoxShortCuts2.FormattingEnabled = True
        Me.ComboBoxShortCuts2.Items.AddRange(New Object() {"Add All 100L Courses", "Add All 200L Courses", "Add All 300L Courses", "Add All 400L Courses", "Add All 500L Courses", "Add All Departmetal Courses", "Add All Faculty Courses"})
        Me.ComboBoxShortCuts2.Location = New System.Drawing.Point(339, 251)
        Me.ComboBoxShortCuts2.Name = "ComboBoxShortCuts2"
        Me.ComboBoxShortCuts2.Size = New System.Drawing.Size(312, 24)
        Me.ComboBoxShortCuts2.TabIndex = 97
        Me.ComboBoxShortCuts2.Text = "--Shortcuts--"
        Me.ComboBoxShortCuts2.Visible = False
        '
        'ButtonMovePrevious
        '
        Me.ButtonMovePrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMovePrevious.Location = New System.Drawing.Point(48, 452)
        Me.ButtonMovePrevious.Name = "ButtonMovePrevious"
        Me.ButtonMovePrevious.Size = New System.Drawing.Size(75, 23)
        Me.ButtonMovePrevious.TabIndex = 96
        Me.ButtonMovePrevious.Text = "<Previous"
        Me.ButtonMovePrevious.UseVisualStyleBackColor = True
        '
        'ComboBoxShortCuts1
        '
        Me.ComboBoxShortCuts1.AutoCompleteCustomSource.AddRange(New String() {"2019/2020"})
        Me.ComboBoxShortCuts1.FormattingEnabled = True
        Me.ComboBoxShortCuts1.Items.AddRange(New Object() {"Add All 100L Courses", "Add All 200L Courses", "Add All 300L Courses", "Add All 400L Courses", "Add All 500L Courses", "Add All Departmetal Courses", "Add All Faculty Courses", "Clear all/Unregister All"})
        Me.ComboBoxShortCuts1.Location = New System.Drawing.Point(339, 123)
        Me.ComboBoxShortCuts1.Name = "ComboBoxShortCuts1"
        Me.ComboBoxShortCuts1.Size = New System.Drawing.Size(252, 24)
        Me.ComboBoxShortCuts1.TabIndex = 95
        Me.ComboBoxShortCuts1.Text = "--Shortcuts--"
        '
        'TextBoxCourseCode_2
        '
        Me.TextBoxCourseCode_2.Location = New System.Drawing.Point(339, 161)
        Me.TextBoxCourseCode_2.Multiline = True
        Me.TextBoxCourseCode_2.Name = "TextBoxCourseCode_2"
        Me.TextBoxCourseCode_2.Size = New System.Drawing.Size(252, 81)
        Me.TextBoxCourseCode_2.TabIndex = 38
        '
        'TextBoxCourseCode_1
        '
        Me.TextBoxCourseCode_1.Location = New System.Drawing.Point(339, 51)
        Me.TextBoxCourseCode_1.Multiline = True
        Me.TextBoxCourseCode_1.Name = "TextBoxCourseCode_1"
        Me.TextBoxCourseCode_1.Size = New System.Drawing.Size(252, 72)
        Me.TextBoxCourseCode_1.TabIndex = 37
        '
        'ButtonClosePanelForm
        '
        Me.ButtonClosePanelForm.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.ButtonClosePanelForm.FlatAppearance.BorderSize = 0
        Me.ButtonClosePanelForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClosePanelForm.Location = New System.Drawing.Point(621, 3)
        Me.ButtonClosePanelForm.Name = "ButtonClosePanelForm"
        Me.ButtonClosePanelForm.Size = New System.Drawing.Size(30, 23)
        Me.ButtonClosePanelForm.TabIndex = 36
        Me.ButtonClosePanelForm.Text = "x"
        Me.ButtonClosePanelForm.UseVisualStyleBackColor = True
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SaveToolStripButton1})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 478)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(657, 25)
        Me.BindingNavigator1.TabIndex = 35
        Me.BindingNavigator1.Text = "BindingNavigator1"
        Me.BindingNavigator1.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'SaveToolStripButton1
        '
        Me.SaveToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SaveToolStripButton1.ForeColor = System.Drawing.Color.Black
        Me.SaveToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton1.Name = "SaveToolStripButton1"
        Me.SaveToolStripButton1.Size = New System.Drawing.Size(35, 22)
        Me.SaveToolStripButton1.Text = "Save"
        '
        'TextBoxmode_of_entry
        '
        Me.TextBoxmode_of_entry.Location = New System.Drawing.Point(138, 212)
        Me.TextBoxmode_of_entry.Name = "TextBoxmode_of_entry"
        Me.TextBoxmode_of_entry.Size = New System.Drawing.Size(38, 22)
        Me.TextBoxmode_of_entry.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(49, 215)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Entry Mode:"
        '
        'TextBoxsession_idr_of_entry
        '
        Me.TextBoxsession_idr_of_entry.Location = New System.Drawing.Point(138, 186)
        Me.TextBoxsession_idr_of_entry.Name = "TextBoxsession_idr_of_entry"
        Me.TextBoxsession_idr_of_entry.Size = New System.Drawing.Size(184, 22)
        Me.TextBoxsession_idr_of_entry.TabIndex = 10
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(49, 189)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 16)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Entr Session:"
        '
        'TextBoxstudent_othernames
        '
        Me.TextBoxstudent_othernames.Location = New System.Drawing.Point(138, 151)
        Me.TextBoxstudent_othernames.Name = "TextBoxstudent_othernames"
        Me.TextBoxstudent_othernames.Size = New System.Drawing.Size(184, 22)
        Me.TextBoxstudent_othernames.TabIndex = 8
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(49, 154)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 16)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Other Names:"
        '
        'TextBoxstudent_firstname
        '
        Me.TextBoxstudent_firstname.Location = New System.Drawing.Point(138, 125)
        Me.TextBoxstudent_firstname.Name = "TextBoxstudent_firstname"
        Me.TextBoxstudent_firstname.Size = New System.Drawing.Size(184, 22)
        Me.TextBoxstudent_firstname.TabIndex = 6
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(49, 128)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(73, 16)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "FirstName:"
        '
        'TextBoxstudent_surname
        '
        Me.TextBoxstudent_surname.Location = New System.Drawing.Point(138, 93)
        Me.TextBoxstudent_surname.Name = "TextBoxstudent_surname"
        Me.TextBoxstudent_surname.Size = New System.Drawing.Size(184, 22)
        Me.TextBoxstudent_surname.TabIndex = 4
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(49, 96)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(79, 16)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "SURNAME:"
        '
        'TextBoxMATNO
        '
        Me.TextBoxMATNO.Location = New System.Drawing.Point(138, 67)
        Me.TextBoxMATNO.Name = "TextBoxMATNO"
        Me.TextBoxMATNO.Size = New System.Drawing.Size(184, 22)
        Me.TextBoxMATNO.TabIndex = 2
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(49, 70)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(66, 16)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "MAT. NO."
        '
        'ButtonNext
        '
        Me.ButtonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonNext.Location = New System.Drawing.Point(210, 452)
        Me.ButtonNext.Name = "ButtonNext"
        Me.ButtonNext.Size = New System.Drawing.Size(75, 23)
        Me.ButtonNext.TabIndex = 0
        Me.ButtonNext.Text = "Next >"
        Me.ButtonNext.UseVisualStyleBackColor = True
        '
        'ButtonFormView
        '
        Me.ButtonFormView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonFormView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonFormView.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonFormView.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ButtonFormView.Location = New System.Drawing.Point(1004, 142)
        Me.ButtonFormView.Name = "ButtonFormView"
        Me.ButtonFormView.Size = New System.Drawing.Size(119, 42)
        Me.ButtonFormView.TabIndex = 88
        Me.ButtonFormView.Text = "Grid View"
        Me.ButtonFormView.UseVisualStyleBackColor = True
        '
        'ButtonSaveGrid
        '
        Me.ButtonSaveGrid.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSaveGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSaveGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSaveGrid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ButtonSaveGrid.Location = New System.Drawing.Point(1004, 190)
        Me.ButtonSaveGrid.Name = "ButtonSaveGrid"
        Me.ButtonSaveGrid.Size = New System.Drawing.Size(119, 42)
        Me.ButtonSaveGrid.TabIndex = 89
        Me.ButtonSaveGrid.Text = "Save Grid"
        Me.ButtonSaveGrid.UseVisualStyleBackColor = True
        '
        'ButtonImportRegFERMAAccess
        '
        Me.ButtonImportRegFERMAAccess.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonImportRegFERMAAccess.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonImportRegFERMAAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonImportRegFERMAAccess.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonImportRegFERMAAccess.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ButtonImportRegFERMAAccess.Location = New System.Drawing.Point(998, 491)
        Me.ButtonImportRegFERMAAccess.Name = "ButtonImportRegFERMAAccess"
        Me.ButtonImportRegFERMAAccess.Size = New System.Drawing.Size(123, 13)
        Me.ButtonImportRegFERMAAccess.TabIndex = 90
        Me.ButtonImportRegFERMAAccess.Text = "Import From FERMA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Access)"
        Me.ButtonImportRegFERMAAccess.UseVisualStyleBackColor = True
        Me.ButtonImportRegFERMAAccess.Visible = False
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
        'BindingSourceStudents
        '
        '
        'FormStudentRegFORM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1131, 733)
        Me.Controls.Add(Me.ButtonBack)
        Me.Controls.Add(Me.ButtonImportRegFERMAAccess)
        Me.Controls.Add(Me.ButtonSaveGrid)
        Me.Controls.Add(Me.ButtonFormView)
        Me.Controls.Add(Me.PanelForm)
        Me.Controls.Add(Me.ButtonDownloadTemplate)
        Me.Controls.Add(Me.ButtonSaveReg)
        Me.Controls.Add(Me.ButtonImportStudentsFromExcel)
        Me.Controls.Add(Me.ButtonImportRegRTPS)
        Me.Controls.Add(Me.ButtonRegToExcel)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.ButtonAccess)
        Me.Controls.Add(Me.ButtonImportRegFERMAExcel)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PanelAllReg)
        Me.Controls.Add(Me.ProgressBarBS)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormStudentRegFORM"
        Me.Text = "Students Registration"
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.PanelGegSingle.ResumeLayout(False)
        Me.PanelGegSingle.PerformLayout()
        Me.PanelCourses.ResumeLayout(False)
        Me.PanelAllReg.ResumeLayout(False)
        Me.PanelForm.ResumeLayout(False)
        Me.PanelForm.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtStudentMATNO As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents LabelAvaliable As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TimerBS As Timer
    Friend WithEvents ProgressBarBS As ProgressBar
    Friend WithEvents ButtonImportStudentsFromExcel As Button
    Friend WithEvents ButtonImportRegFERMAExcel As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxstudent_dept_idr As TextBox
    Friend WithEvents ComboBoxDepartments As ComboBox
    Friend WithEvents ComboBoxSessions As ComboBox
    Friend WithEvents ComboBoxLevel As ComboBox
    Friend WithEvents ButtonSaveReg As Button
    Friend WithEvents ButtonRegToExcel As Button
    Friend WithEvents ButtonAccess As Button
    Friend WithEvents ButtonImportRegRTPS As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents PanelGegSingle As Panel
    Friend WithEvents TextBoxsession_idr As TextBox
    Friend WithEvents TextBoxTotalCredits As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxCourseCode As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ButtonRegister As Button
    Friend WithEvents ComboBoxCourseCode As ComboBox
    Friend WithEvents PanelCourses As Panel
    Friend WithEvents ButtonCancelReg As Button
    Friend WithEvents ButtonOKReg As Button
    Friend WithEvents CheckedListBoxCourses As CheckedListBox
    Friend WithEvents ButtonDownloadTemplate As Button
    Friend WithEvents PanelAllReg As Panel
    Friend WithEvents ButtonDeleteReg As Button
    Friend WithEvents PanelForm As Panel
    Friend WithEvents ButtonClosePanelForm As Button
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ButtonRefreshFormview As Button
    Friend WithEvents TextBoxmode_of_entry As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxsession_idr_of_entry As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBoxstudent_othernames As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBoxstudent_firstname As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBoxstudent_surname As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBoxMATNO As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents ButtonNext As Button
    Friend WithEvents ComboBoxShortCuts1 As ComboBox
    Friend WithEvents TextBoxCourseCode_2 As TextBox
    Friend WithEvents TextBoxCourseCode_1 As TextBox
    Friend WithEvents BindingSourceStudents As BindingSource
    Friend WithEvents ButtonMovePrevious As Button
    Friend WithEvents ButtonFormView As Button
    Friend WithEvents ComboBoxShortCuts2 As ComboBox
    Friend WithEvents ButtonUnregister As Button
    Friend WithEvents ComboBoxEntryMode As ComboBox
    Friend WithEvents ButtonSaveRecord As Button
    Friend WithEvents SaveToolStripButton1 As ToolStripButton
    Friend WithEvents TextBoxstatus As TextBox
    Friend WithEvents TextBoxlevel As TextBox
    Friend WithEvents TextBoxFees_Status As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents TextBoxyear_of_entry As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents TextBoxemail As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents TextBoxphone As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TextBoxdob As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents TextBoxgender As TextBox
    Friend WithEvents TextBoxdept_idr As TextBox
    Friend WithEvents ButtonSaveGrid As Button
    Friend WithEvents ComboBoxStatus As ComboBox
    Friend WithEvents ComboBoxGender As ComboBox
    Friend WithEvents ButtonImportRegFERMAAccess As Button
    Friend WithEvents TextBoxNA_CourseCode As TextBox
    Friend WithEvents ButtonAddNewRecordInFORM As Button
    Friend WithEvents ButtonFirst As Button
    Friend WithEvents ButtonLast As Button
    Friend WithEvents Label23 As Label
    Friend WithEvents ButtonBack As Button
    Private WithEvents bgwLoad As System.ComponentModel.BackgroundWorker
End Class
