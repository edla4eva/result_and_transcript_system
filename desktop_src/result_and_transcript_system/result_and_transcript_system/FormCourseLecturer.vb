Public Class FormCourseLecturer
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = RGBColors.colorBlack2
    End Sub

    Private Sub ButtonUpload_Click(sender As Object, e As EventArgs) Handles ButtonUpload.Click
        MainForm.ChangeMenu("UploadResult")
    End Sub

    Private Sub ButtonDownloadTemplate_Click(sender As Object, e As EventArgs) Handles ButtonDownloadTemplate.Click
        Try

            'objResult.resultTemplateFileName
            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                My.Computer.FileSystem.CopyFile(My.Application.Info.DirectoryPath & "\templates\result.xltx", SaveFileDialog1.FileName & ".xltx")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'System.Diagnostics.Process.Start(objResult.resultTemplateFileName)
    End Sub
End Class