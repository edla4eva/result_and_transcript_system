<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCourseAdviser
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
        Me.ButtonGenerateBroadsheet = New System.Windows.Forms.Button()
        Me.ButtonTranscript = New System.Windows.Forms.Button()
        Me.ButtonImportCourseReg = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonGenerateBroadsheet
        '
        Me.ButtonGenerateBroadsheet.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.ButtonGenerateBroadsheet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonGenerateBroadsheet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonGenerateBroadsheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGenerateBroadsheet.Location = New System.Drawing.Point(29, 25)
        Me.ButtonGenerateBroadsheet.Name = "ButtonGenerateBroadsheet"
        Me.ButtonGenerateBroadsheet.Size = New System.Drawing.Size(136, 51)
        Me.ButtonGenerateBroadsheet.TabIndex = 0
        Me.ButtonGenerateBroadsheet.Text = "Generate Broadsheet"
        Me.ButtonGenerateBroadsheet.UseVisualStyleBackColor = True
        '
        'ButtonTranscript
        '
        Me.ButtonTranscript.Location = New System.Drawing.Point(29, 96)
        Me.ButtonTranscript.Name = "ButtonTranscript"
        Me.ButtonTranscript.Size = New System.Drawing.Size(136, 48)
        Me.ButtonTranscript.TabIndex = 1
        Me.ButtonTranscript.Text = "Process Transcript "
        Me.ButtonTranscript.UseVisualStyleBackColor = True
        '
        'ButtonImportCourseReg
        '
        Me.ButtonImportCourseReg.Location = New System.Drawing.Point(29, 165)
        Me.ButtonImportCourseReg.Name = "ButtonImportCourseReg"
        Me.ButtonImportCourseReg.Size = New System.Drawing.Size(136, 46)
        Me.ButtonImportCourseReg.TabIndex = 2
        Me.ButtonImportCourseReg.Text = "Import Course Registration Form "
        Me.ButtonImportCourseReg.UseVisualStyleBackColor = True
        '
        'FormCourseAdviser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 338)
        Me.Controls.Add(Me.ButtonImportCourseReg)
        Me.Controls.Add(Me.ButtonTranscript)
        Me.Controls.Add(Me.ButtonGenerateBroadsheet)
        Me.Name = "FormCourseAdviser"
        Me.Text = "FormCourseAdviser"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonGenerateBroadsheet As Button
    Friend WithEvents ButtonTranscript As Button
    Friend WithEvents ButtonImportCourseReg As Button
End Class
