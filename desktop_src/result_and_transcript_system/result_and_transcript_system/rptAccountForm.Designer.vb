<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptAccountForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.LabelAccount = New System.Windows.Forms.Label()
        Me.fromDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AccntComboBox = New System.Windows.Forms.ComboBox()
        Me.toDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.viewAllToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(15, 73)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(84, 16)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "Dated From :"
        '
        'LabelAccount
        '
        Me.LabelAccount.AutoSize = True
        Me.LabelAccount.Location = New System.Drawing.Point(19, 40)
        Me.LabelAccount.Name = "LabelAccount"
        Me.LabelAccount.Size = New System.Drawing.Size(62, 16)
        Me.LabelAccount.TabIndex = 23
        Me.LabelAccount.Text = "Account :"
        '
        'fromDateTimePicker
        '
        Me.fromDateTimePicker.CustomFormat = "MMM/dd/yyyy"
        Me.fromDateTimePicker.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fromDateTimePicker.Location = New System.Drawing.Point(102, 69)
        Me.fromDateTimePicker.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.fromDateTimePicker.Name = "fromDateTimePicker"
        Me.fromDateTimePicker.Size = New System.Drawing.Size(103, 24)
        Me.fromDateTimePicker.TabIndex = 22
        '
        'AccntComboBox
        '
        Me.AccntComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AccntComboBox.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccntComboBox.FormattingEnabled = True
        Me.AccntComboBox.Location = New System.Drawing.Point(102, 40)
        Me.AccntComboBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AccntComboBox.Name = "AccntComboBox"
        Me.AccntComboBox.Size = New System.Drawing.Size(212, 24)
        Me.AccntComboBox.TabIndex = 21
        '
        'toDateTimePicker
        '
        Me.toDateTimePicker.CustomFormat = "MMM/dd/yyyy"
        Me.toDateTimePicker.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.toDateTimePicker.Location = New System.Drawing.Point(211, 69)
        Me.toDateTimePicker.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.toDateTimePicker.Name = "toDateTimePicker"
        Me.toDateTimePicker.Size = New System.Drawing.Size(103, 24)
        Me.toDateTimePicker.TabIndex = 22
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.viewAllToolStripButton, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(499, 25)
        Me.ToolStrip1.TabIndex = 26
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        'Me.ToolStripButton1.Image = Global.eAccount.My.Resources.Resources.toexcel16
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripButton1.Text = "View"
        '
        'viewAllToolStripButton
        '
        'Me.viewAllToolStripButton.Image = Global.eAccount.My.Resources.Resources.toexcel16
        Me.viewAllToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.viewAllToolStripButton.Name = "viewAllToolStripButton"
        Me.viewAllToolStripButton.Size = New System.Drawing.Size(121, 22)
        Me.viewAllToolStripButton.Text = "View Trial Balance"
        '
        'ToolStripButton2
        '
        'Me.ToolStripButton2.Image = Global.eAccount.My.Resources.Resources.off16a
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(56, 22)
        Me.ToolStripButton2.Text = "&Close"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(214, 107)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 23)
        Me.TextBox1.TabIndex = 27
        Me.TextBox1.Visible = False
        '
        'ReportViewer1
        '
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "eAccount.ReportTrialBalance.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(22, 171)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(465, 246)
        Me.ReportViewer1.TabIndex = 28
        Me.ReportViewer1.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(440, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 23)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "View"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'rptAccountForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        'Me.BackgroundImage = Global.eAccount.My.Resources.Resources.sidbnr
        Me.ClientSize = New System.Drawing.Size(499, 338)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.LabelAccount)
        Me.Controls.Add(Me.toDateTimePicker)
        Me.Controls.Add(Me.fromDateTimePicker)
        Me.Controls.Add(Me.AccntComboBox)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "rptAccountForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Account Report"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents LabelAccount As System.Windows.Forms.Label
    Friend WithEvents fromDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents AccntComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents toDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents viewAllToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Button1 As Button
End Class
