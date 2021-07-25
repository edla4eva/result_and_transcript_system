<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCourseLecturer
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
        Me.ButtonUploadResult = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonUploadResult
        '
        Me.ButtonUploadResult.Location = New System.Drawing.Point(59, 121)
        Me.ButtonUploadResult.Name = "ButtonUploadResult"
        Me.ButtonUploadResult.Size = New System.Drawing.Size(156, 44)
        Me.ButtonUploadResult.TabIndex = 0
        Me.ButtonUploadResult.Text = "Upload Result "
        Me.ButtonUploadResult.UseVisualStyleBackColor = True
        '
        'FormCourseLecturer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ButtonUploadResult)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormCourseLecturer"
        Me.Text = "FormCourseLecturer"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonUploadResult As Button
End Class
