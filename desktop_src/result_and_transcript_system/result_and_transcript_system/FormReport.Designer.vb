<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormReport
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
        Me.ClassDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SidePanel.SuspendLayout()
        CType(Me.ClassDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(7, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(131, 426)
        Me.DataGridView1.TabIndex = 1
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "result_and_transcript_system.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(144, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(659, 426)
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
        Me.SidePanel.Size = New System.Drawing.Size(134, 450)
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
        Me.ReportViewerSenateCover.Location = New System.Drawing.Point(144, 12)
        Me.ReportViewerSenateCover.Name = "ReportViewerSenateCover"
        Me.ReportViewerSenateCover.ServerReport.BearerToken = Nothing
        Me.ReportViewerSenateCover.Size = New System.Drawing.Size(659, 426)
        Me.ReportViewerSenateCover.TabIndex = 73
        '
        'ClassDBBindingSource
        '
        Me.ClassDBBindingSource.DataSource = GetType(result_and_transcript_system.ClassDB)
        '
        'FormReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 450)
        Me.Controls.Add(Me.SidePanel)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ReportViewerSenateCover)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormReport"
        Me.Text = "Reports"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SidePanel.ResumeLayout(False)
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
End Class
