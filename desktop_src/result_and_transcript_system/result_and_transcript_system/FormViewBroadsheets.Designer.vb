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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxDepartment = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxLevel = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxSession = New System.Windows.Forms.TextBox()
        Me.ComboBoxDepartments = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SidePanel = New System.Windows.Forms.Panel()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.ButtonSearchBroadheet = New System.Windows.Forms.Button()
        Me.ButtonCloud = New System.Windows.Forms.Button()
        Me.ButtonShowAllBroadsheet = New System.Windows.Forms.Button()
        Me.ButtonAdjustTemplate = New System.Windows.Forms.Button()
        Me.ComboBoxSessions = New System.Windows.Forms.ComboBox()
        Me.PanelModify = New System.Windows.Forms.Panel()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelClosePanelModify = New System.Windows.Forms.Label()
        Me.bgwLoad = New System.ComponentModel.BackgroundWorker()
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
        Me.DataGridView1.Size = New System.Drawing.Size(628, 326)
        Me.DataGridView1.TabIndex = 9
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
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"100", "200", "300", "400", "500", "600", "700", "800", "900"})
        Me.ComboBox1.Location = New System.Drawing.Point(16, 70)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(198, 21)
        Me.ComboBox1.TabIndex = 25
        Me.ComboBox1.Text = "100"
        '
        'SidePanel
        '
        Me.SidePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.SidePanel.Controls.Add(Me.ButtonClose)
        Me.SidePanel.Controls.Add(Me.ButtonSearchBroadheet)
        Me.SidePanel.Controls.Add(Me.ButtonCloud)
        Me.SidePanel.Controls.Add(Me.ButtonShowAllBroadsheet)
        Me.SidePanel.Controls.Add(Me.ButtonAdjustTemplate)
        Me.SidePanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.SidePanel.Location = New System.Drawing.Point(666, 0)
        Me.SidePanel.Name = "SidePanel"
        Me.SidePanel.Size = New System.Drawing.Size(134, 517)
        Me.SidePanel.TabIndex = 27
        '
        'ButtonClose
        '
        Me.ButtonClose.FlatAppearance.BorderSize = 0
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonClose.ForeColor = System.Drawing.Color.White
        Me.ButtonClose.Location = New System.Drawing.Point(3, 423)
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
        Me.ButtonCloud.Location = New System.Drawing.Point(3, 362)
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
        Me.PanelModify.Controls.Add(Me.ComboBox2)
        Me.PanelModify.Controls.Add(Me.TextBox2)
        Me.PanelModify.Controls.Add(Me.Label6)
        Me.PanelModify.Controls.Add(Me.ComboBoxSessions)
        Me.PanelModify.Controls.Add(Me.LabelClosePanelModify)
        Me.PanelModify.Controls.Add(Me.ComboBox1)
        Me.PanelModify.Controls.Add(Me.Label2)
        Me.PanelModify.Controls.Add(Me.ComboBoxDepartments)
        Me.PanelModify.Controls.Add(Me.TextBoxDepartment)
        Me.PanelModify.Controls.Add(Me.Label5)
        Me.PanelModify.Controls.Add(Me.TextBoxLevel)
        Me.PanelModify.Controls.Add(Me.TextBoxSession)
        Me.PanelModify.Controls.Add(Me.Label4)
        Me.PanelModify.Location = New System.Drawing.Point(32, 31)
        Me.PanelModify.Name = "PanelModify"
        Me.PanelModify.Size = New System.Drawing.Size(625, 142)
        Me.PanelModify.TabIndex = 30
        '
        'ComboBox2
        '
        Me.ComboBox2.AutoCompleteCustomSource.AddRange(New String() {"2019/2020"})
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"2018/2019", "2019/2020"})
        Me.ComboBox2.Location = New System.Drawing.Point(332, 115)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(161, 21)
        Me.ComboBox2.TabIndex = 32
        Me.ComboBox2.Text = "2018/2019"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(295, 115)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(33, 20)
        Me.TextBox2.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(245, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "to"
        '
        'LabelClosePanelModify
        '
        Me.LabelClosePanelModify.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelClosePanelModify.AutoSize = True
        Me.LabelClosePanelModify.Location = New System.Drawing.Point(606, 6)
        Me.LabelClosePanelModify.Name = "LabelClosePanelModify"
        Me.LabelClosePanelModify.Size = New System.Drawing.Size(14, 13)
        Me.LabelClosePanelModify.TabIndex = 1
        Me.LabelClosePanelModify.Text = "X"
        '
        'bgwLoad
        '
        '
        'FormViewBroadsheets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(800, 517)
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

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxDepartment As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxLevel As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxSession As TextBox
    Friend WithEvents ComboBoxDepartments As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents SidePanel As Panel
    Friend WithEvents ButtonSearchBroadheet As Button
    Friend WithEvents ButtonCloud As Button
    Friend WithEvents ButtonShowAllBroadsheet As Button
    Friend WithEvents ButtonAdjustTemplate As Button
    Friend WithEvents ComboBoxSessions As ComboBox
    Friend WithEvents PanelModify As Panel
    Friend WithEvents LabelClosePanelModify As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ButtonClose As Button
    Friend WithEvents bgwLoad As System.ComponentModel.BackgroundWorker
End Class
