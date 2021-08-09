Public Class FormGenerateBroadsheet
    Private Sub TextBoxDepartment_TextChanged(sender As Object, e As EventArgs) Handles TextBoxDepartment.TextChanged

    End Sub

    Private Sub FormGenerateBroadsheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = RGBColors.colorBlack2
    End Sub

    Private Sub ButtonProcessBroadsheet_Click(sender As Object, e As EventArgs) Handles ButtonProcessBroadsheet.Click
        objBroadsheet.broadsheetFileName = My.Application.Info.DirectoryPath & "\templates\broadsheet.xltx"
        objBroadsheet.broadsheetSemester = 2
        Try
            If objBroadsheet.openBroadsheetExcelWB = True Then

                Me.TextBox1.Text = objBroadsheet.processedBroadsheetFileName
            Else
                MsgBox("Something went wrong!")
            End If
        Catch ex As Exception
            MsgBox("Something went wrong! " & vbCrLf & ex.Message)
        End Try

    End Sub
End Class