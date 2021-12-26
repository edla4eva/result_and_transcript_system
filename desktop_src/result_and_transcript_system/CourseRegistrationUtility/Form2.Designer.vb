<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim Dept_idLabel As System.Windows.Forms.Label
        Dim Dept_nameLabel As System.Windows.Forms.Label
        Dim Dept_facultyLabel As System.Windows.Forms.Label
        Dim CommentsLabel As System.Windows.Forms.Label
        Dim Faculty_idrLabel As System.Windows.Forms.Label
        Dim Courses_1Label As System.Windows.Forms.Label
        Dim Courses_2Label As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.DbDataSet = New CourseRegistrationUtility.dbDataSet()
        Me.DepartmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartmentsTableAdapter = New CourseRegistrationUtility.dbDataSetTableAdapters.DepartmentsTableAdapter()
        Me.TableAdapterManager = New CourseRegistrationUtility.dbDataSetTableAdapters.TableAdapterManager()
        Me.DepartmentsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Dept_idTextBox = New System.Windows.Forms.TextBox()
        Me.Dept_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Dept_facultyTextBox = New System.Windows.Forms.TextBox()
        Me.CommentsTextBox = New System.Windows.Forms.TextBox()
        Me.Faculty_idrTextBox = New System.Windows.Forms.TextBox()
        Me.Courses_1TextBox = New System.Windows.Forms.TextBox()
        Me.Courses_2TextBox = New System.Windows.Forms.TextBox()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.DepartmentsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Dept_idLabel = New System.Windows.Forms.Label()
        Dept_nameLabel = New System.Windows.Forms.Label()
        Dept_facultyLabel = New System.Windows.Forms.Label()
        CommentsLabel = New System.Windows.Forms.Label()
        Faculty_idrLabel = New System.Windows.Forms.Label()
        Courses_1Label = New System.Windows.Forms.Label()
        Courses_2Label = New System.Windows.Forms.Label()
        CType(Me.DbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DepartmentsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'DbDataSet
        '
        Me.DbDataSet.DataSetName = "dbDataSet"
        Me.DbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DepartmentsBindingSource
        '
        Me.DepartmentsBindingSource.DataMember = "Departments"
        Me.DepartmentsBindingSource.DataSource = Me.DbDataSet
        '
        'DepartmentsTableAdapter
        '
        Me.DepartmentsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.auditTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Broadsheet500TableAdapter = Nothing
        Me.TableAdapterManager.Broadsheets_AllTableAdapter = Nothing
        Me.TableAdapterManager.Broadsheets_auditTableAdapter = Nothing
        Me.TableAdapterManager.Broadsheets_regTableAdapter = Nothing
        Me.TableAdapterManager.BroadsheetTmpTableAdapter = Nothing
        Me.TableAdapterManager.Courses_order_copyTableAdapter = Nothing
        Me.TableAdapterManager.Courses_orderTableAdapter = Nothing
        Me.TableAdapterManager.CoursesTableAdapter = Nothing
        Me.TableAdapterManager.DepartmentsTableAdapter = Me.DepartmentsTableAdapter
        Me.TableAdapterManager.facultiesTableAdapter = Nothing
        Me.TableAdapterManager.FCTableAdapter = Nothing
        Me.TableAdapterManager.gpaTableAdapter = Nothing
        Me.TableAdapterManager.RegsTableAdapter = Nothing
        Me.TableAdapterManager.RegTableAdapter = Nothing
        Me.TableAdapterManager.Results_transcriptTableAdapter = Nothing
        Me.TableAdapterManager.ResultsTableAdapter = Nothing
        Me.TableAdapterManager.SessionsTableAdapter = Nothing
        Me.TableAdapterManager.SPDTableAdapter = Nothing
        Me.TableAdapterManager.students_course_dbTableAdapter = Nothing
        Me.TableAdapterManager.students_course_reg_cpeTableAdapter = Nothing
        Me.TableAdapterManager.students_course_regTableAdapter = Nothing
        Me.TableAdapterManager.students_dbTableAdapter = Nothing
        Me.TableAdapterManager.students_regTableAdapter = Nothing
        Me.TableAdapterManager.studentsTableAdapter = Nothing
        Me.TableAdapterManager.transcriptTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = CourseRegistrationUtility.dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        '
        'DepartmentsBindingNavigator
        '
        Me.DepartmentsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DepartmentsBindingNavigator.BindingSource = Me.DepartmentsBindingSource
        Me.DepartmentsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DepartmentsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DepartmentsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DepartmentsBindingNavigatorSaveItem})
        Me.DepartmentsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DepartmentsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DepartmentsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DepartmentsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DepartmentsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DepartmentsBindingNavigator.Name = "DepartmentsBindingNavigator"
        Me.DepartmentsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DepartmentsBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.DepartmentsBindingNavigator.TabIndex = 0
        Me.DepartmentsBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Dept_idLabel
        '
        Dept_idLabel.AutoSize = True
        Dept_idLabel.Location = New System.Drawing.Point(22, 63)
        Dept_idLabel.Name = "Dept_idLabel"
        Dept_idLabel.Size = New System.Drawing.Size(42, 13)
        Dept_idLabel.TabIndex = 1
        Dept_idLabel.Text = "dept id:"
        '
        'Dept_idTextBox
        '
        Me.Dept_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DepartmentsBindingSource, "dept_id", True))
        Me.Dept_idTextBox.Location = New System.Drawing.Point(93, 60)
        Me.Dept_idTextBox.Name = "Dept_idTextBox"
        Me.Dept_idTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Dept_idTextBox.TabIndex = 2
        '
        'Dept_nameLabel
        '
        Dept_nameLabel.AutoSize = True
        Dept_nameLabel.Location = New System.Drawing.Point(22, 89)
        Dept_nameLabel.Name = "Dept_nameLabel"
        Dept_nameLabel.Size = New System.Drawing.Size(60, 13)
        Dept_nameLabel.TabIndex = 3
        Dept_nameLabel.Text = "dept name:"
        '
        'Dept_nameTextBox
        '
        Me.Dept_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DepartmentsBindingSource, "dept_name", True))
        Me.Dept_nameTextBox.Location = New System.Drawing.Point(93, 86)
        Me.Dept_nameTextBox.Name = "Dept_nameTextBox"
        Me.Dept_nameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Dept_nameTextBox.TabIndex = 4
        '
        'Dept_facultyLabel
        '
        Dept_facultyLabel.AutoSize = True
        Dept_facultyLabel.Location = New System.Drawing.Point(22, 115)
        Dept_facultyLabel.Name = "Dept_facultyLabel"
        Dept_facultyLabel.Size = New System.Drawing.Size(65, 13)
        Dept_facultyLabel.TabIndex = 5
        Dept_facultyLabel.Text = "dept faculty:"
        '
        'Dept_facultyTextBox
        '
        Me.Dept_facultyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DepartmentsBindingSource, "dept_faculty", True))
        Me.Dept_facultyTextBox.Location = New System.Drawing.Point(93, 112)
        Me.Dept_facultyTextBox.Name = "Dept_facultyTextBox"
        Me.Dept_facultyTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Dept_facultyTextBox.TabIndex = 6
        '
        'CommentsLabel
        '
        CommentsLabel.AutoSize = True
        CommentsLabel.Location = New System.Drawing.Point(22, 141)
        CommentsLabel.Name = "CommentsLabel"
        CommentsLabel.Size = New System.Drawing.Size(58, 13)
        CommentsLabel.TabIndex = 7
        CommentsLabel.Text = "comments:"
        '
        'CommentsTextBox
        '
        Me.CommentsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DepartmentsBindingSource, "comments", True))
        Me.CommentsTextBox.Location = New System.Drawing.Point(93, 138)
        Me.CommentsTextBox.Name = "CommentsTextBox"
        Me.CommentsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CommentsTextBox.TabIndex = 8
        '
        'Faculty_idrLabel
        '
        Faculty_idrLabel.AutoSize = True
        Faculty_idrLabel.Location = New System.Drawing.Point(22, 167)
        Faculty_idrLabel.Name = "Faculty_idrLabel"
        Faculty_idrLabel.Size = New System.Drawing.Size(55, 13)
        Faculty_idrLabel.TabIndex = 9
        Faculty_idrLabel.Text = "faculty idr:"
        '
        'Faculty_idrTextBox
        '
        Me.Faculty_idrTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DepartmentsBindingSource, "faculty_idr", True))
        Me.Faculty_idrTextBox.Location = New System.Drawing.Point(93, 164)
        Me.Faculty_idrTextBox.Name = "Faculty_idrTextBox"
        Me.Faculty_idrTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Faculty_idrTextBox.TabIndex = 10
        '
        'Courses_1Label
        '
        Courses_1Label.AutoSize = True
        Courses_1Label.Location = New System.Drawing.Point(22, 193)
        Courses_1Label.Name = "Courses_1Label"
        Courses_1Label.Size = New System.Drawing.Size(56, 13)
        Courses_1Label.TabIndex = 11
        Courses_1Label.Text = "courses 1:"
        '
        'Courses_1TextBox
        '
        Me.Courses_1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DepartmentsBindingSource, "courses_1", True))
        Me.Courses_1TextBox.Location = New System.Drawing.Point(93, 190)
        Me.Courses_1TextBox.Name = "Courses_1TextBox"
        Me.Courses_1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Courses_1TextBox.TabIndex = 12
        '
        'Courses_2Label
        '
        Courses_2Label.AutoSize = True
        Courses_2Label.Location = New System.Drawing.Point(22, 219)
        Courses_2Label.Name = "Courses_2Label"
        Courses_2Label.Size = New System.Drawing.Size(56, 13)
        Courses_2Label.TabIndex = 13
        Courses_2Label.Text = "courses 2:"
        '
        'Courses_2TextBox
        '
        Me.Courses_2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DepartmentsBindingSource, "courses_2", True))
        Me.Courses_2TextBox.Location = New System.Drawing.Point(93, 216)
        Me.Courses_2TextBox.Name = "Courses_2TextBox"
        Me.Courses_2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Courses_2TextBox.TabIndex = 14
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
        'DepartmentsBindingNavigatorSaveItem
        '
        Me.DepartmentsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DepartmentsBindingNavigatorSaveItem.Image = CType(resources.GetObject("DepartmentsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DepartmentsBindingNavigatorSaveItem.Name = "DepartmentsBindingNavigatorSaveItem"
        Me.DepartmentsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.DepartmentsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Dept_idLabel)
        Me.Controls.Add(Me.Dept_idTextBox)
        Me.Controls.Add(Dept_nameLabel)
        Me.Controls.Add(Me.Dept_nameTextBox)
        Me.Controls.Add(Dept_facultyLabel)
        Me.Controls.Add(Me.Dept_facultyTextBox)
        Me.Controls.Add(CommentsLabel)
        Me.Controls.Add(Me.CommentsTextBox)
        Me.Controls.Add(Faculty_idrLabel)
        Me.Controls.Add(Me.Faculty_idrTextBox)
        Me.Controls.Add(Courses_1Label)
        Me.Controls.Add(Me.Courses_1TextBox)
        Me.Controls.Add(Courses_2Label)
        Me.Controls.Add(Me.Courses_2TextBox)
        Me.Controls.Add(Me.DepartmentsBindingNavigator)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DepartmentsBindingNavigator.ResumeLayout(False)
        Me.DepartmentsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DbDataSet As dbDataSet
    Friend WithEvents DepartmentsBindingSource As BindingSource
    Friend WithEvents DepartmentsTableAdapter As dbDataSetTableAdapters.DepartmentsTableAdapter
    Friend WithEvents TableAdapterManager As dbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DepartmentsBindingNavigator As BindingNavigator
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
    Friend WithEvents DepartmentsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Dept_idTextBox As TextBox
    Friend WithEvents Dept_nameTextBox As TextBox
    Friend WithEvents Dept_facultyTextBox As TextBox
    Friend WithEvents CommentsTextBox As TextBox
    Friend WithEvents Faculty_idrTextBox As TextBox
    Friend WithEvents Courses_1TextBox As TextBox
    Friend WithEvents Courses_2TextBox As TextBox
End Class
