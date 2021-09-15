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


        Dim fns As String() = FileIO.FileSystem.GetFiles(System.IO.Directory.GetParent(FileOpenDialogBroadsheet.FileName).ToString).ToArray()
        ListBoxFileNames.Items.AddRange(fns)
        showButtons("Preview", True)

    End Sub

    Private Sub ButtonUpload_Click(sender As Object, e As EventArgs) Handles ButtonShowAll.Click
        If TextBoxSession.Text = "" Then
            TextBoxSession.BackColor = Color.Pink
            MessageBox.Show("Please enter the session and retry again")
            Exit Sub
        End If
        Dim myDataSet As DataSet = objResult.getFromDBResultssDataset(TextBoxSession.Text)
        DataGridView2.DataSource = myDataSet.Tables(0).DefaultView


        'TODO: show result summary in listbox
        Dim rd As DataTableReader
        Dim rowVals As String() = {}
        rd = myDataSet.Tables(0).CreateDataReader
        Try
            If rd.Read() Then   'while
                rd.GetValues(rowVals)
                ListBoxResults.Items.AddRange(rowVals) 'test
            End If
            DataGridView2.Visible = True
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
        If TextBoxSession.Text = "" Then
            TextBoxSession.BackColor = Color.Pink
            MessageBox.Show("Please enter the session and retry again")
            Exit Sub
        End If
        Dim myDataSet As DataSet = objResult.getFromDBResultssDataset(TextBoxSession.Text)
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
End Class
