<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStudent
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
        Me.SidePanel = New System.Windows.Forms.Panel()
        Me.ButtonComplain = New System.Windows.Forms.Button()
        Me.ButtonSearch = New System.Windows.Forms.Button()
        Me.ButtonView = New System.Windows.Forms.Button()
        Me.SidePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'SidePanel
        '
        Me.SidePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.SidePanel.Controls.Add(Me.ButtonComplain)
        Me.SidePanel.Controls.Add(Me.ButtonSearch)
        Me.SidePanel.Controls.Add(Me.ButtonView)
        Me.SidePanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.SidePanel.Location = New System.Drawing.Point(591, 0)
        Me.SidePanel.Name = "SidePanel"
        Me.SidePanel.Size = New System.Drawing.Size(134, 361)
        Me.SidePanel.TabIndex = 7
        '
        'ButtonComplain
        '
        Me.ButtonComplain.FlatAppearance.BorderSize = 0
        Me.ButtonComplain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonComplain.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonComplain.ForeColor = System.Drawing.Color.White
        Me.ButtonComplain.Location = New System.Drawing.Point(3, 223)
        Me.ButtonComplain.Name = "ButtonComplain"
        Me.ButtonComplain.Size = New System.Drawing.Size(128, 55)
        Me.ButtonComplain.TabIndex = 2
        Me.ButtonComplain.Text = "Complains"
        Me.ButtonComplain.UseVisualStyleBackColor = True
        '
        'ButtonSearch
        '
        Me.ButtonSearch.FlatAppearance.BorderSize = 0
        Me.ButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonSearch.ForeColor = System.Drawing.Color.White
        Me.ButtonSearch.Location = New System.Drawing.Point(3, 161)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(128, 55)
        Me.ButtonSearch.TabIndex = 1
        Me.ButtonSearch.Text = "Search"
        Me.ButtonSearch.UseVisualStyleBackColor = True
        '
        'ButtonView
        '
        Me.ButtonView.FlatAppearance.BorderSize = 0
        Me.ButtonView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonView.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonView.ForeColor = System.Drawing.Color.White
        Me.ButtonView.Location = New System.Drawing.Point(3, 100)
        Me.ButtonView.Name = "ButtonView"
        Me.ButtonView.Size = New System.Drawing.Size(128, 55)
        Me.ButtonView.TabIndex = 0
        Me.ButtonView.Text = "View Result"
        Me.ButtonView.UseVisualStyleBackColor = True
        '
        'FormStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(725, 361)
        Me.Controls.Add(Me.SidePanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormStudent"
        Me.Text = "FormStudent"
        Me.SidePanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SidePanel As Panel
    Friend WithEvents ButtonComplain As Button
    Friend WithEvents ButtonSearch As Button
    Friend WithEvents ButtonView As Button
End Class
