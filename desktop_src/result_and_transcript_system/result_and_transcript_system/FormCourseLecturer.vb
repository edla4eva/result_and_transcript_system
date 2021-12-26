Public Class FormCourseLecturer
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = RGBColors.colorBackground
        Me.ForeColor = RGBColors.colorForeground
    End Sub

    Private Sub ButtonUpload_Click(sender As Object, e As EventArgs) Handles ButtonUpload.Click
        MainForm.ChangeMenu("UploadResult")
    End Sub

    Private Sub ButtonDownloadTemplate_Click(sender As Object, e As EventArgs) Handles ButtonDownloadTemplate.Click
        Try
            Dim tmpileName As String = My.Application.Info.DirectoryPath & "\templates\result.xltx"
            Dim tmpileName2 As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\templates\result.xltx"
            Dim tmpileName3 As String = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\templates\result.xltx"

            If My.Computer.FileSystem.FileExists(tmpileName) Then

            ElseIf My.Computer.FileSystem.FileExists(tmpileName2) Then
                tmpileName = tmpileName2
            ElseIf My.Computer.FileSystem.FileExists(tmpileName3) Then
                tmpileName = tmpileName3
            End If

            'objResult.resultTemplateFileName
            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                My.Computer.FileSystem.CopyFile(tmpileName, SaveFileDialog1.FileName & ".xltx")
                If MsgBox("Do you want to open the template file in Excel?", "Result Template", vbYesNo) = DialogResult.Yes Then
                    System.Diagnostics.Process.Start(tmpileName)
                End If

            End If
        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

        'System.Diagnostics.Process.Start(objResult.resultTemplateFileName)
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub FormCourseLecturer_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MainForm.doCloseForm()
    End Sub
End Class