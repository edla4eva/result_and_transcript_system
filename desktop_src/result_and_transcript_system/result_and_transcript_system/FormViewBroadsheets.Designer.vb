<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormViewBroadsheets
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxDepartment = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxLevel = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxSession = New System.Windows.Forms.TextBox()
        Me.ComboBoxDepartments = New System.Windows.Forms.ComboBox()
        Me.ComboBoxLevel = New System.Windows.Forms.ComboBox()
        Me.SidePanel = New System.Windows.Forms.Panel()
        Me.ButtonShowDetails = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonRework = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.ButtonSearchBroadheet = New System.Windows.Forms.Button()
        Me.ButtonCloud = New System.Windows.Forms.Button()
        Me.ButtonShowAllBroadsheet = New System.Windows.Forms.Button()
        Me.ButtonAdjustTemplate = New System.Windows.Forms.Button()
        Me.ComboBoxSessions = New System.Windows.Forms.ComboBox()
        Me.PanelModify = New System.Windows.Forms.Panel()
        Me.LabelClosePanelModify = New System.Windows.Forms.Label()
        Me.bgwLoad = New System.ComponentModel.BackgroundWorker()
        Me.BgWProcess = New System.ComponentModel.BackgroundWorker()
        Me.TimerBS = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBarBS = New System.Windows.Forms.ProgressBar()
        Me.LabelProgress = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SidePanel.SuspendLayout()
        Me.PanelModify.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(29, 179)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(723, 346)
        Me.DataGridView1.TabIndex = 9
        Me.DataGridView1.Tag = "summary"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Department"
        '
        'TextBoxDepartment
        '
        Me.TextBoxDepartment.Location = New System.Drawing.Point(16, 28)
        Me.TextBoxDepartment.Name = "TextBoxDepartment"
        Me.TextBoxDepartment.Size = New System.Drawing.Size(33, 20)
        Me.TextBoxDepartment.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Level"
        '
        'TextBoxLevel
        '
        Me.TextBoxLevel.Location = New System.Drawing.Point(16, 70)
        Me.TextBoxLevel.Name = "TextBoxLevel"
        Me.TextBoxLevel.Size = New System.Drawing.Size(33, 20)
        Me.TextBoxLevel.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Session"
        '
        'TextBoxSession
        '
        Me.TextBoxSession.Location = New System.Drawing.Point(16, 118)
        Me.TextBoxSession.Name = "TextBoxSession"
        Me.TextBoxSession.Size = New System.Drawing.Size(33, 20)
        Me.TextBoxSession.TabIndex = 22
        '
        'ComboBoxDepartments
        '
        Me.ComboBoxDepartments.FormattingEnabled = True
        Me.ComboBoxDepartments.Items.AddRange(New Object() {"Computer Engineering", "Production Engineering"})
        Me.ComboBoxDepartments.Location = New System.Drawing.Point(16, 26)
        Me.ComboBoxDepartments.Name = "ComboBoxDepartments"
        Me.ComboBoxDepartments.Size = New System.Drawing.Size(198, 21)
        Me.ComboBoxDepartments.TabIndex = 24
        Me.ComboBoxDepartments.Text = "Computer Engineering"
        '
        'ComboBoxLevel
        '
        Me.ComboBoxLevel.FormattingEnabled = True
        Me.ComboBoxLevel.Items.AddRange(New Object() {"100", "200", "300", "400", "500", "600", "700", "800", "900"})
        Me.ComboBoxLevel.Location = New System.Drawing.Point(16, 70)
        Me.ComboBoxLevel.Name = "ComboBoxLevel"
        Me.ComboBoxLevel.Size = New System.Drawing.Size(198, 21)
        Me.ComboBoxLevel.TabIndex = 25
        Me.ComboBoxLevel.Text = "100"
        '
        'SidePanel
        '
        Me.SidePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.SidePanel.Controls.Add(Me.ButtonShowDetails)
        Me.SidePanel.Controls.Add(Me.ButtonDelete)
        Me.SidePanel.Controls.Add(Me.ButtonRework)
        Me.SidePanel.Controls.Add(Me.ButtonClose)
        Me.SidePanel.Controls.Add(Me.ButtonSearchBroadheet)
        Me.SidePanel.Controls.Add(Me.ButtonCloud)
        Me.SidePanel.Controls.Add(Me.ButtonShowAllBroadsheet)
        Me.SidePanel.Controls.Add(Me.ButtonAdjustTemplate)
        Me.SidePanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.SidePanel.Location = New System.Drawing.Point(761, 0)
        Me.SidePanel.Name = "SidePanel"
        Me.SidePanel.Size = New System.Drawing.Size(134, 582)
        Me.SidePanel.TabIndex = 27
        '
        'ButtonShowDetails
        '
        Me.ButtonShowDetails.FlatAppearance.BorderSize = 0
        Me.ButtonShowDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonShowDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonShowDetails.ForeColor = System.Drawing.Color.White
        Me.ButtonShowDetails.Location = New System.Drawing.Point(0, 222)
        Me.ButtonShowDetails.Name = "ButtonShowDetails"
        Me.ButtonShowDetails.Size = New System.Drawing.Size(128, 55)
        Me.ButtonShowDetails.TabIndex = 11
        Me.ButtonShowDetails.Text = "Show Details"
        Me.ButtonShowDetails.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.FlatAppearance.BorderSize = 0
        Me.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonDelete.ForeColor = System.Drawing.Color.White
        Me.ButtonDelete.Location = New System.Drawing.Point(3, 289)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(128, 55)
        Me.ButtonDelete.TabIndex = 10
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonRework
        '
        Me.ButtonRework.FlatAppearance.BorderSize = 0
        Me.ButtonRework.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRework.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonRework.ForeColor = System.Drawing.Color.White
        Me.ButtonRework.Location = New System.Drawing.Point(3, 353)
        Me.ButtonRework.Name = "ButtonRework"
        Me.ButtonRework.Size = New System.Drawing.Size(128, 55)
        Me.ButtonRework.TabIndex = 9
        Me.ButtonRework.Text = "ReWork"
        Me.ButtonRework.UseVisualStyleBackColor = True
        '
        'ButtonClose
        '
        Me.ButtonClose.FlatAppearance.BorderSize = 0
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonClose.ForeColor = System.Drawing.Color.White
        Me.ButtonClose.Location = New System.Drawing.Point(3, 465)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(128, 55)
        Me.ButtonClose.TabIndex = 8
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'ButtonSearchBroadheet
        '
        Me.ButtonSearchBroadheet.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.ButtonSearchBroadheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSearchBroadheet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonSearchBroadheet.ForeColor = System.Drawing.Color.White
        Me.ButtonSearchBroadheet.Location = New System.Drawing.Point(0, 39)
        Me.ButtonSearchBroadheet.Name = "ButtonSearchBroadheet"
        Me.ButtonSearchBroadheet.Size = New System.Drawing.Size(128, 55)
        Me.ButtonSearchBroadheet.TabIndex = 5
        Me.ButtonSearchBroadheet.Text = "Search"
        Me.ButtonSearchBroadheet.UseVisualStyleBackColor = True
        '
        'ButtonCloud
        '
        Me.ButtonCloud.FlatAppearance.BorderSize = 0
        Me.ButtonCloud.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCloud.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonCloud.ForeColor = System.Drawing.Color.White
        Me.ButtonCloud.Location = New System.Drawing.Point(3, 404)
        Me.ButtonCloud.Name = "ButtonCloud"
        Me.ButtonCloud.Size = New System.Drawing.Size(128, 55)
        Me.ButtonCloud.TabIndex = 3
        Me.ButtonCloud.Text = "Sync Cloud"
        Me.ButtonCloud.UseVisualStyleBackColor = True
        '
        'ButtonShowAllBroadsheet
        '
        Me.ButtonShowAllBroadsheet.FlatAppearance.BorderSize = 0
        Me.ButtonShowAllBroadsheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonShowAllBroadsheet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonShowAllBroadsheet.ForeColor = System.Drawing.Color.White
        Me.ButtonShowAllBroadsheet.Location = New System.Drawing.Point(3, 161)
        Me.ButtonShowAllBroadsheet.Name = "ButtonShowAllBroadsheet"
        Me.ButtonShowAllBroadsheet.Size = New System.Drawing.Size(128, 55)
        Me.ButtonShowAllBroadsheet.TabIndex = 1
        Me.ButtonShowAllBroadsheet.Text = "Show All"
        Me.ButtonShowAllBroadsheet.UseVisualStyleBackColor = True
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
        Me.ButtonAdjustTemplate.Text = "Refresh"
        Me.ButtonAdjustTemplate.UseVisualStyleBackColor = True
        '
        'ComboBoxSessions
        '
        Me.ComboBoxSessions.AutoCompleteCustomSource.AddRange(New String() {"2019/2020"})
        Me.ComboBoxSessions.FormattingEnabled = True
        Me.ComboBoxSessions.Items.AddRange(New Object() {"2018/2019", "2019/2020"})
        Me.ComboBoxSessions.Location = New System.Drawing.Point(19, 118)
        Me.ComboBoxSessions.Name = "ComboBoxSessions"
        Me.ComboBoxSessions.Size = New System.Drawing.Size(195, 21)
        Me.ComboBoxSessions.TabIndex = 29
        Me.ComboBoxSessions.Text = "2018/2019"
        '
        'PanelModify
        '
        Me.PanelModify.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelModify.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelModify.Controls.Add(Me.ComboBoxSessions)
        Me.PanelModify.Controls.Add(Me.LabelClosePanelModify)
        Me.PanelModify.Controls.Add(Me.ComboBoxLevel)
        Me.PanelModify.Controls.Add(Me.Label2)
        Me.PanelModify.Controls.Add(Me.ComboBoxDepartments)
        Me.PanelModify.Controls.Add(Me.TextBoxDepartment)
        Me.PanelModify.Controls.Add(Me.Label5)
        Me.PanelModify.Controls.Add(Me.TextBoxLevel)
        Me.PanelModify.Controls.Add(Me.TextBoxSession)
        Me.PanelModify.Controls.Add(Me.Label4)
        Me.PanelModify.Location = New System.Drawing.Point(32, 31)
        Me.PanelModify.Name = "PanelModify"
        Me.PanelModify.Size = New System.Drawing.Size(720, 142)
        Me.PanelModify.TabIndex = 30
        '
        'LabelClosePanelModify
        '
        Me.LabelClosePanelModify.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelClosePanelModify.AutoSize = True
        Me.LabelClosePanelModify.Location = New System.Drawing.Point(701, 6)
        Me.LabelClosePanelModify.Name = "LabelClosePanelModify"
        Me.LabelClosePanelModify.Size = New System.Drawing.Size(14, 13)
        Me.LabelClosePanelModify.TabIndex = 1
        Me.LabelClosePanelModify.Text = "X"
        '
        'bgwLoad
        '
        '
        'BgWProcess
        '
        Me.BgWProcess.WorkerSupportsCancellation = True
        '
        'TimerBS
        '
        Me.TimerBS.Enabled = True
        Me.TimerBS.Interval = 500
        '
        'ProgressBarBS
        '
        Me.ProgressBarBS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBarBS.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ProgressBarBS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ProgressBarBS.Location = New System.Drawing.Point(33, 546)
        Me.ProgressBarBS.Name = "ProgressBarBS"
        Me.ProgressBarBS.Size = New System.Drawing.Size(720, 23)
        Me.ProgressBarBS.TabIndex = 33
        Me.ProgressBarBS.Value = 1
        '
        'LabelProgress
        '
        Me.LabelProgress.AutoSize = True
        Me.LabelProgress.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProgress.Location = New System.Drawing.Point(29, 528)
        Me.LabelProgress.Name = "LabelProgress"
        Me.LabelProgress.Size = New System.Drawing.Size(437, 18)
        Me.LabelProgress.TabIndex = 32
        Me.LabelProgress.Text = "This broadsheet can be used to make final adjustments to scores"
        '
        'FormViewBroadsheets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(895, 582)
        Me.Controls.Add(Me.ProgressBarBS)
        Me.Controls.Add(Me.LabelProgress)
        Me.Controls.Add(Me.PanelModify)
        Me.Controls.Add(Me.SidePanel)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormViewBroadsheets"
        Me.Text = "View Broadsheets"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SidePanel.ResumeLayout(False)
        Me.PanelModify.ResumeLayout(False)
        Me.PanelModify.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxDepartment As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxLevel As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxSession As TextBox
    Friend WithEvents ComboBoxDepartments As ComboBox
    Friend WithEvents ComboBoxLevel As ComboBox
    Friend WithEvents SidePanel As Panel
    Friend WithEvents ButtonSearchBroadheet As Button
    Friend WithEvents ButtonCloud As Button
    Friend WithEvents ButtonShowAllBroadsheet As Button
    Friend WithEvents ButtonAdjustTemplate As Button
    Friend WithEvents ComboBoxSessions As ComboBox
    Friend WithEvents PanelModify As Panel
    Friend WithEvents LabelClosePanelModify As Label
    Friend WithEvents ButtonClose As Button
    Friend WithEvents bgwLoad As System.ComponentModel.BackgroundWorker
    Friend WithEvents ButtonRework As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonShowDetails As Button
    Friend WithEvents BgWProcess As System.ComponentModel.BackgroundWorker
    Friend WithEvents TimerBS As Timer
    Friend WithEvents ProgressBarBS As ProgressBar
    Friend WithEvents LabelProgress As Label
End Class
