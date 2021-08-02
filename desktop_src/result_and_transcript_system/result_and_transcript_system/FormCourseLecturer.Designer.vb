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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ButtonUploadResult = New System.Windows.Forms.Button()
        Me.CourseLecturerDataGrid = New System.Windows.Forms.DataGridView()
        Me.CourseLecturerFileNameLabel = New System.Windows.Forms.Label()
        Me.CourseLecturerComboSheet = New System.Windows.Forms.ComboBox()
        Me.CourseLectureTextbox = New System.Windows.Forms.TextBox()
        Me.CourseLectureBrowseButton = New System.Windows.Forms.Button()
        Me.CourseLecturerSheetLabel = New System.Windows.Forms.Label()
        CType(Me.CourseLecturerDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonUploadResult
        '
        Me.ButtonUploadResult.ForeColor = System.Drawing.Color.Black
        Me.ButtonUploadResult.Location = New System.Drawing.Point(637, 414)
        Me.ButtonUploadResult.Name = "ButtonUploadResult"
        Me.ButtonUploadResult.Size = New System.Drawing.Size(156, 44)
        Me.ButtonUploadResult.TabIndex = 0
        Me.ButtonUploadResult.Text = "Upload Result "
        Me.ButtonUploadResult.UseVisualStyleBackColor = True
        '
        'CourseLecturerDataGrid
        '
        Me.CourseLecturerDataGrid.BackgroundColor = System.Drawing.Color.SkyBlue
        Me.CourseLecturerDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CourseLecturerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CourseLecturerDataGrid.DefaultCellStyle = DataGridViewCellStyle3
        Me.CourseLecturerDataGrid.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.CourseLecturerDataGrid.Location = New System.Drawing.Point(12, 7)
        Me.CourseLecturerDataGrid.Name = "CourseLecturerDataGrid"
        Me.CourseLecturerDataGrid.Size = New System.Drawing.Size(781, 319)
        Me.CourseLecturerDataGrid.TabIndex = 1
        '
        'CourseLecturerFileNameLabel
        '
        Me.CourseLecturerFileNameLabel.AutoSize = True
        Me.CourseLecturerFileNameLabel.Location = New System.Drawing.Point(18, 354)
        Me.CourseLecturerFileNameLabel.Name = "CourseLecturerFileNameLabel"
        Me.CourseLecturerFileNameLabel.Size = New System.Drawing.Size(51, 13)
        Me.CourseLecturerFileNameLabel.TabIndex = 2
        Me.CourseLecturerFileNameLabel.Text = "FileName"
        '
        'CourseLecturerComboSheet
        '
        Me.CourseLecturerComboSheet.FormattingEnabled = True
        Me.CourseLecturerComboSheet.Location = New System.Drawing.Point(75, 389)
        Me.CourseLecturerComboSheet.Name = "CourseLecturerComboSheet"
        Me.CourseLecturerComboSheet.Size = New System.Drawing.Size(121, 21)
        Me.CourseLecturerComboSheet.TabIndex = 3
        '
        'CourseLectureTextbox
        '
        Me.CourseLectureTextbox.Location = New System.Drawing.Point(75, 351)
        Me.CourseLectureTextbox.Name = "CourseLectureTextbox"
        Me.CourseLectureTextbox.Size = New System.Drawing.Size(527, 20)
        Me.CourseLectureTextbox.TabIndex = 4
        '
        'CourseLectureBrowseButton
        '
        Me.CourseLectureBrowseButton.ForeColor = System.Drawing.Color.Black
        Me.CourseLectureBrowseButton.Location = New System.Drawing.Point(625, 354)
        Me.CourseLectureBrowseButton.Name = "CourseLectureBrowseButton"
        Me.CourseLectureBrowseButton.Size = New System.Drawing.Size(102, 20)
        Me.CourseLectureBrowseButton.TabIndex = 5
        Me.CourseLectureBrowseButton.Text = "Open File"
        Me.CourseLectureBrowseButton.UseVisualStyleBackColor = True
        '
        'CourseLecturerSheetLabel
        '
        Me.CourseLecturerSheetLabel.AutoSize = True
        Me.CourseLecturerSheetLabel.Location = New System.Drawing.Point(18, 397)
        Me.CourseLecturerSheetLabel.Name = "CourseLecturerSheetLabel"
        Me.CourseLecturerSheetLabel.Size = New System.Drawing.Size(35, 13)
        Me.CourseLecturerSheetLabel.TabIndex = 6
        Me.CourseLecturerSheetLabel.Text = "Sheet"
        '
        'FormCourseLecturer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 470)
        Me.Controls.Add(Me.CourseLecturerDataGrid)
        Me.Controls.Add(Me.CourseLecturerSheetLabel)
        Me.Controls.Add(Me.CourseLectureBrowseButton)
        Me.Controls.Add(Me.CourseLectureTextbox)
        Me.Controls.Add(Me.CourseLecturerComboSheet)
        Me.Controls.Add(Me.CourseLecturerFileNameLabel)
        Me.Controls.Add(Me.ButtonUploadResult)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormCourseLecturer"
        Me.Text = "FormCourseLecturer"
        CType(Me.CourseLecturerDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonUploadResult As Button
    Friend WithEvents CourseLecturerDataGrid As DataGridView
    Friend WithEvents CourseLecturerFileNameLabel As Label
    Friend WithEvents CourseLecturerComboSheet As ComboBox
    Friend WithEvents CourseLectureTextbox As TextBox
    Friend WithEvents CourseLectureBrowseButton As Button
    Friend WithEvents CourseLecturerSheetLabel As Label
End Class
