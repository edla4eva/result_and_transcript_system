Public Class FormGenerateBroadsheet
    Private Sub TextBoxDepartment_TextChanged(sender As Object, e As EventArgs) Handles TextBoxDepartment.TextChanged

    End Sub

    Private Sub FormGenerateBroadsheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = RGBColors.colorBlack2
    End Sub

    Private Sub ButtonProcessBroadsheet_Click(sender As Object, e As EventArgs) Handles ButtonProcessBroadsheet.Click
        objBroadsheet.broadsheetFileName = My.Application.Info.DirectoryPath & "\templates\broadsheet.xltx"
        objBroadsheet.broadsheetSemester = 2

        'objExcelFile.excelFileName = PROG_DIRECTORY & "\templates\broadsheet.xltx"
        Try
            '-----METHOD One Interop
            'If objBroadsheet.openBroadsheetExcelWB = True Then

            '    Me.TextBox1.Text = objBroadsheet.processedBroadsheetFileName
            'Else
            '    MsgBox("Something went wrong!")
            'End If

            '-----Method TWO - file
            '        Try
            '
            objExcelFile.excelFileName = PROG_DIRECTORY & "\samples\broadsheet.xlsx"
            Dim myDataSet As DataSet = objExcelFile.readResultFile()
            'DataGridView1.DataSource = myDataSet.Tables(0).DefaultView
            'myDataSet.Clear()

            'MsgBox("load send sample")

            DataGridView1.DataSource = myDataSet.Tables(0).DefaultView
            myDataSet.Clear()
            myDataSet = Nothing

        Catch ex As Exception
            MsgBox("Cannot create Excel File Object" & vbCrLf & ex.Message)
        End Try


    End Sub

    Private Sub ButtonResultList_Click(sender As Object, e As EventArgs) Handles ButtonResultList.Click
        objExcelFile.createExcelFile()
    End Sub
End Class