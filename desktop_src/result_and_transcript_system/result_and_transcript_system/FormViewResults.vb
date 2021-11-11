Imports System.ComponentModel

Public Class FormViewResults
    Private Sub FormViewResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = RGBColors.colorBlack2

    End Sub

    Private Sub ButtonBrowse_Click(sender As Object, e As EventArgs) Handles ButtonBrowse.Click
        Dim FileOpenDialogBroadsheet As New OpenFileDialog()
        Dim resultFileName As String = ""

        If Not FileOpenDialogBroadsheet.ShowDialog = DialogResult.Cancel Then
            resultFileName = FileOpenDialogBroadsheet.FileName()
        End If
        TextBoxExcelFilename.Text = resultFileName
        objExcelFile.excelFileName = resultFileName

        If Not resultFileName.Contains("\") Then Exit Sub
        Dim fns As String() = FileIO.FileSystem.GetFiles(System.IO.Directory.GetParent(FileOpenDialogBroadsheet.FileName).ToString).ToArray()
        ListBoxFileNames.Items.Clear()
        For Each fn In fns
            ListBoxFileNames.Items.Add(System.IO.Path.GetFileName(fn))
        Next
        'ListBoxFileNames.Items.AddRange(fns)
        showButtons("Preview", True)

    End Sub

    Private Sub ButtonShowAll_Click(sender As Object, e As EventArgs) Handles ButtonShowAll.Click
        Dim strSQL As String = STR_SQL_ALL_RESULTS_SUMMARY
        Try
            DataGridView2.DataSource = mappDB.GetDataWhere(strSQL).Tables(0).DefaultView
        Catch ex As Exception

        End Try


    End Sub


    Sub showButtons(ButtonName As String, enableOnly As Boolean)
        Select Case ButtonName
            Case "Check Result"
                If enableOnly Then Me.ButtonReferesh.Enabled = True Else Me.ButtonReferesh.Visible = True
            Case "upload"
                If enableOnly Then Me.ButtonShowAll.Enabled = True Else Me.ButtonShowAll.Visible = True
            Case "Preview"
                If enableOnly Then Me.ButtonSearch.Enabled = True Else Me.ButtonSearch.Visible = True
        End Select
    End Sub
    Sub hideButtons(enableOnly As Boolean, btn As Button) 'ButtonName As String, 
        If enableOnly Then btn.Enabled = False
        'Select Case ButtonName
        '    Case "Check Result"
        '        If enableOnly Then Me.ButtonCheck.Enabled = True Else Me.ButtonCheck.Visible = False
        '    Case "upload"
        '        If enableOnly Then Me.ButtonUpload.Enabled = True Else Me.ButtonUpload.Visible = False
        '    Case "Preview"
        '        If enableOnly Then Me.ButtonPreview.Enabled = True Else Me.ButtonPreview.Visible = False
        'End Select
    End Sub
    Private Sub ButtonResultList_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        If TextBoxCourseCode.Text = "" Then
            TextBoxCourseCode.BackColor = Color.Pink
            MessageBox.Show("Please enter the session and retry again")
            Exit Sub
        End If
        Dim myDataSet As DataSet = objResult.getFromDBResultssDataset(TextBoxCourseCode.Text)
        DataGridView2.DataSource = myDataSet.Tables(0).DefaultView
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PictureBox2.Visible = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        updatePix()
        PictureBox2.Image = PictureBox1.Image

        PictureBox2.Visible = Not PictureBox2.Visible
    End Sub
    Private Sub ListBoxFileNames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxFileNames.SelectedIndexChanged
        updatePix()
    End Sub
    Public Sub updatePix()
        Try


            If My.Computer.FileSystem.FileExists(ListBoxFileNames.SelectedItem.ToString) Then
                PictureBox1.Image = Image.FromFile(ListBoxFileNames.SelectedItem.ToString)
            Else
                PictureBox1.Image = My.Resources.panel

            End If

        Catch ex As Exception
            logError(ex.ToString)
        End Try

    End Sub

    Private Sub FormViewResults_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

    End Sub

    Private Sub FormViewResults_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MainForm.doCloseForm()
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub TextBoxSession_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCourseCode.TextChanged
        'get col headers
        ' rowHeades("Session")
        On Error Resume Next
        If DataGridView2.Rows.Count > 0 Then
            DataGridView2.DataSource.RowFilter = String.Format(STR_FILTER_RESULTS_BYCOURSECODE, TextBoxCourseCode.Text)
        End If
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        If DataGridView2.SelectedRows Is Nothing Then Exit Sub
        Dim strSQL As String = "DELETE * FROM results WHERE session_idr='{0}' AND course_code_idr='{1}'"
        Dim dSession As String = DataGridView2.SelectedRows(0).Cells("session_idr").Value.ToString
        Dim dCourse As String = DataGridView2.SelectedRows(0).Cells("course_code_idr").Value.ToString
        If MessageBox.Show("Are you sure you want to delete all the selected results?", "Delete", MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
            LoginForm1.Close()

            If LoginForm1.ShowDialog() = DialogResult.OK Then
                mappDB.doQuery(String.Format(strSQL, dSession, dCourse))
                ButtonShowAll.PerformClick()
                MsgBox("Results deleted sucessfully")
            End If
        End If
    End Sub
End Class
