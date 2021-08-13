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
            Dim myDataSet As DataSet ' = objExcelFile.readResultFile()
            myDataSet = objExcelFile.readResultFile()
            'DataGridView1.DataSource = myDataSet.Tables(0).DefaultView
            'myDataSet.Clear()

            'MsgBox("load send sample")

            DataGridView1.DataSource = myDataSet.Tables(0).DefaultView
            myDataSet.Clear()
            myDataSet = Nothing
            hideButtons("Process", True)
        Catch ex As Exception
            MsgBox("Cannot create Excel File Object" & vbCrLf & ex.Message)
        End Try


    End Sub

    Private Sub ButtonResultList_Click(sender As Object, e As EventArgs) Handles ButtonResultList.Click
        objExcelFile.createExcelFile(My.Application.Info.DirectoryPath & "\GeneratedResult.xlsx")
        objExcelFile.modifyExcelFile(My.Application.Info.DirectoryPath & "\GeneratedResult.xlsx")
        Label6.Text = "Done: check GeneratedResult.xlsx"
        MainForm.status("Done: generated GeneratedResult.xlsx")
    End Sub

    Private Sub SelectBroadsheetTemplate_Click(sender As Object, e As EventArgs) Handles SelectBroadsheetTemplate.Click
        Dim FileOpenDialogBroadsheet As New OpenFileDialog()
        Dim resultFileName As String = ""

        If Not FileOpenDialogBroadsheet.ShowDialog = DialogResult.Cancel Then
            resultFileName = FileOpenDialogBroadsheet.FileName()
        End If
        Me.TextBox1.Text = resultFileName
        objExcelFile.excelFileName = resultFileName

        showButtons("Process", False)
    End Sub

    Sub showButtons(ButtonName As String, enableOnly As Boolean)
        Select Case ButtonName
            Case "Process"
                If enableOnly Then Me.ButtonProcessBroadsheet.Enabled = True Else Me.ButtonProcessBroadsheet.Visible = True

        End Select
    End Sub
    Sub hideButtons(ButtonName As String, disableOnly As Boolean)
        Select Case ButtonName
            Case "Process"
                If disableOnly Then Me.ButtonProcessBroadsheet.Enabled = False Else Me.ButtonProcessBroadsheet.Visible = False

        End Select
    End Sub
End Class