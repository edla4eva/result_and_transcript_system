<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSenateResult
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SidePanel = New System.Windows.Forms.Panel()
        Me.ButtonFullScreen = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.ButtonView = New System.Windows.Forms.Button()
        Me.ButtonPrint = New System.Windows.Forms.Button()
        Me.ButtonEport = New System.Windows.Forms.Button()
        Me.ReportViewerSenateCover = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.PanelModify = New System.Windows.Forms.Panel()
        Me.ComboBoxSessions = New System.Windows.Forms.ComboBox()
        Me.ComboBoxLevel = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxDepartments = New System.Windows.Forms.ComboBox()
        Me.TextBoxDepartment = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxLevel = New System.Windows.Forms.TextBox()
        Me.TextBoxSession = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bgwLoad = New System.ComponentModel.BackgroundWorker()
        Me.BgWProcess = New System.ComponentModel.BackgroundWorker()
        Me.ClassDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SidePanel.SuspendLayout()
        Me.PanelModify.SuspendLayout()
        CType(Me.ClassDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(7, 160)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(171, 464)
        Me.DataGridView1.TabIndex = 1
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "result_and_transcript_system.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(184, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(619, 612)
        Me.ReportViewer1.TabIndex = 2
        '
        'SidePanel
        '
        Me.SidePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.SidePanel.Controls.Add(Me.ButtonFullScreen)
        Me.SidePanel.Controls.Add(Me.ButtonClose)
        Me.SidePanel.Controls.Add(Me.ButtonView)
        Me.SidePanel.Controls.Add(Me.ButtonPrint)
        Me.SidePanel.Controls.Add(Me.ButtonEport)
        Me.SidePanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.SidePanel.Location = New System.Drawing.Point(809, 0)
        Me.SidePanel.Name = "SidePanel"
        Me.SidePanel.Size = New System.Drawing.Size(134, 636)
        Me.SidePanel.TabIndex = 72
        '
        'ButtonFullScreen
        '
        Me.ButtonFullScreen.FlatAppearance.BorderSize = 0
        Me.ButtonFullScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonFullScreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonFullScreen.ForeColor = System.Drawing.Color.White
        Me.ButtonFullScreen.Location = New System.Drawing.Point(0, 342)
        Me.ButtonFullScreen.Name = "ButtonFullScreen"
        Me.ButtonFullScreen.Size = New System.Drawing.Size(128, 55)
        Me.ButtonFullScreen.TabIndex = 67
        Me.ButtonFullScreen.Text = "Full Sreen"
        Me.ButtonFullScreen.UseVisualStyleBackColor = True
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
        'ButtonView
        '
        Me.ButtonView.FlatAppearance.BorderSize = 0
        Me.ButtonView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonView.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonView.ForeColor = System.Drawing.Color.White
        Me.ButtonView.Location = New System.Drawing.Point(3, 115)
        Me.ButtonView.Name = "ButtonView"
        Me.ButtonView.Size = New System.Drawing.Size(128, 55)
        Me.ButtonView.TabIndex = 62
        Me.ButtonView.Text = "View"
        Me.ButtonView.UseVisualStyleBackColor = True
        '
        'ButtonPrint
        '
        Me.ButtonPrint.FlatAppearance.BorderSize = 0
        Me.ButtonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonPrint.ForeColor = System.Drawing.Color.White
        Me.ButtonPrint.Location = New System.Drawing.Point(3, 263)
        Me.ButtonPrint.Name = "ButtonPrint"
        Me.ButtonPrint.Size = New System.Drawing.Size(128, 55)
        Me.ButtonPrint.TabIndex = 63
        Me.ButtonPrint.Text = "Print"
        Me.ButtonPrint.UseVisualStyleBackColor = True
        '
        'ButtonEport
        '
        Me.ButtonEport.FlatAppearance.BorderSize = 0
        Me.ButtonEport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonEport.ForeColor = System.Drawing.Color.White
        Me.ButtonEport.Location = New System.Drawing.Point(3, 191)
        Me.ButtonEport.Name = "ButtonEport"
        Me.ButtonEport.Size = New System.Drawing.Size(128, 55)
        Me.ButtonEport.TabIndex = 66
        Me.ButtonEport.Text = "Export"
        Me.ButtonEport.UseVisualStyleBackColor = True
        '
        'ReportViewerSenateCover
        '
        Me.ReportViewerSenateCover.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ClassDBBindingSource
        Me.ReportViewerSenateCover.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewerSenateCover.LocalReport.ReportEmbeddedResource = "result_and_transcript_system.ReportSenateCover.rdlc"
        Me.ReportViewerSenateCover.Location = New System.Drawing.Point(184, 12)
        Me.ReportViewerSenateCover.Name = "ReportViewerSenateCover"
        Me.ReportViewerSenateCover.ServerReport.BearerToken = Nothing
        Me.ReportViewerSenateCover.Size = New System.Drawing.Size(619, 426)
        Me.ReportViewerSenateCover.TabIndex = 73
        '
        'PanelModify
        '
        Me.PanelModify.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelModify.Controls.Add(Me.ComboBoxSessions)
        Me.PanelModify.Controls.Add(Me.ComboBoxLevel)
        Me.PanelModify.Controls.Add(Me.Label2)
        Me.PanelModify.Controls.Add(Me.ComboBoxDepartments)
        Me.PanelModify.Controls.Add(Me.TextBoxDepartment)
        Me.PanelModify.Controls.Add(Me.Label5)
        Me.PanelModify.Controls.Add(Me.TextBoxLevel)
        Me.PanelModify.Controls.Add(Me.TextBoxSession)
        Me.PanelModify.Controls.Add(Me.Label4)
        Me.PanelModify.Location = New System.Drawing.Point(7, 12)
        Me.PanelModify.Name = "PanelModify"
        Me.PanelModify.Size = New System.Drawing.Size(171, 142)
        Me.PanelModify.TabIndex = 74
        '
        'ComboBoxSessions
        '
        Me.ComboBoxSessions.AutoCompleteCustomSource.AddRange(New String() {"2019/2020"})
        Me.ComboBoxSessions.FormattingEnabled = True
        Me.ComboBoxSessions.Items.AddRange(New Object() {"2018/2019", "2019/2020"})
        Me.ComboBoxSessions.Location = New System.Drawing.Point(13, 118)
        Me.ComboBoxSessions.Name = "ComboBoxSessions"
        Me.ComboBoxSessions.Size = New System.Drawing.Size(153, 21)
        Me.ComboBoxSessions.TabIndex = 29
        Me.ComboBoxSessions.Text = "2018/2019"
        '
        'ComboBoxLevel
        '
        Me.ComboBoxLevel.FormattingEnabled = True
        Me.ComboBoxLevel.Items.AddRange(New Object() {"100", "200", "300", "400", "500", "600", "700", "800", "900"})
        Me.ComboBoxLevel.Location = New System.Drawing.Point(10, 70)
        Me.ComboBoxLevel.Name = "ComboBoxLevel"
        Me.ComboBoxLevel.Size = New System.Drawing.Size(156, 21)
        Me.ComboBoxLevel.TabIndex = 25
        Me.ComboBoxLevel.Text = "100"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Department"
        '
        'ComboBoxDepartments
        '
        Me.ComboBoxDepartments.FormattingEnabled = True
        Me.ComboBoxDepartments.Items.AddRange(New Object() {"Computer Engineering", "Production Engineering"})
        Me.ComboBoxDepartments.Location = New System.Drawing.Point(10, 26)
        Me.ComboBoxDepartments.Name = "ComboBoxDepartments"
        Me.ComboBoxDepartments.Size = New System.Drawing.Size(156, 21)
        Me.ComboBoxDepartments.TabIndex = 24
        Me.ComboBoxDepartments.Text = "Computer Engineering"
        '
        'TextBoxDepartment
        '
        Me.TextBoxDepartment.Location = New System.Drawing.Point(10, 28)
        Me.TextBoxDepartment.Name = "TextBoxDepartment"
        Me.TextBoxDepartment.Size = New System.Drawing.Size(33, 20)
        Me.TextBoxDepartment.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Session"
        '
        'TextBoxLevel
        '
        Me.TextBoxLevel.Location = New System.Drawing.Point(10, 70)
        Me.TextBoxLevel.Name = "TextBoxLevel"
        Me.TextBoxLevel.Size = New System.Drawing.Size(33, 20)
        Me.TextBoxLevel.TabIndex = 15
        '
        'TextBoxSession
        '
        Me.TextBoxSession.Location = New System.Drawing.Point(10, 118)
        Me.TextBoxSession.Name = "TextBoxSession"
        Me.TextBoxSession.Size = New System.Drawing.Size(33, 20)
        Me.TextBoxSession.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Level"
        '
        'bgwLoad
        '
        '
        'BgWProcess
        '
        Me.BgWProcess.WorkerSupportsCancellation = True
        '
        'ClassDBBindingSource
        '
        Me.ClassDBBindingSource.DataSource = GetType(result_and_transcript_system.ClassDB)
        '
        'FormSenateResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(943, 636)
        Me.Controls.Add(Me.PanelModify)
        Me.Controls.Add(Me.SidePanel)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ReportViewerSenateCover)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormSenateResult"
        Me.Text = "Reports"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SidePanel.ResumeLayout(False)
        Me.PanelModify.ResumeLayout(False)
        Me.PanelModify.PerformLayout()
        CType(Me.ClassDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SidePanel As Panel
    Friend WithEvents ButtonFullScreen As Button
    Friend WithEvents ButtonClose As Button
    Friend WithEvents ButtonView As Button
    Friend WithEvents ButtonPrint As Button
    Friend WithEvents ButtonEport As Button
    Friend WithEvents ReportViewerSenateCover As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ClassDBBindingSource As BindingSource
    Friend WithEvents PanelModify As Panel
    Friend WithEvents ComboBoxSessions As ComboBox
    Friend WithEvents ComboBoxLevel As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxDepartments As ComboBox
    Friend WithEvents TextBoxDepartment As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxLevel As TextBox
    Friend WithEvents TextBoxSession As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents bgwLoad As System.ComponentModel.BackgroundWorker
    Friend WithEvents BgWProcess As System.ComponentModel.BackgroundWorker
End Class
