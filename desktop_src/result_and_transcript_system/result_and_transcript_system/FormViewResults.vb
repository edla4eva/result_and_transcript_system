Imports System.ComponentModel

Public Class FormViewResults
    Dim resultSummarryDV As New DataView
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
        Me.ButtonShowAll.Enabled = False
        DataGridView2.Tag = "summary"
        bgwLoad.RunWorkerAsync()
    End Sub


    Sub showButtons(ButtonName As String, enableOnly As Boolean)
        Select Case ButtonName
            Case "Check Result"
                If enableOnly Then Me.ButtonShowDetails.Enabled = True Else Me.ButtonShowDetails.Visible = True
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
        Dim myDataSet As DataSet
        If TextBoxCourseCode.Text = "" And TextBoxSession.Text = "" Then
            TextBoxSession.BackColor = Color.Pink
            TextBoxCourseCode.BackColor = Color.Pink
            MessageBox.Show("Please enter the Session or CourseCode and retry again")
            Exit Sub
        ElseIf Not TextBoxCourseCode.Text = "" Then
            myDataSet = objResult.getFromDBResultssDataset(TextBoxSession.Text, TextBoxCourseCode.Text)
            DataGridView2.DataSource = myDataSet.Tables(0).DefaultView
            TextBoxCourseCode.BackColor = Color.White
            TextBoxCourseCode.BackColor = Color.White
        ElseIf Not TextBoxSession.Text = "" Then
            myDataSet = objResult.getFromDBResultssDataset(TextBoxSession.Text, TextBoxCourseCode.Text)
            DataGridView2.DataSource = myDataSet.Tables(0).DefaultView
            TextBoxSession.BackColor = Color.White
            TextBoxCourseCode.BackColor = Color.White
        End If
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
        If DataGridView2.SelectedRows Is Nothing Or DataGridView2.Columns.Contains("matno") Then
            Exit Sub
        End If
        Dim strSQL As String = DELETE_FROM_RESULTS_WHERE_SESSION_COURSECODE_TIMESAMP
        Dim dSession As String = DataGridView2.SelectedRows(0).Cells("session_idr").Value.ToString
        Dim dCourse As String = DataGridView2.SelectedRows(0).Cells("course_code_idr").Value.ToString
        Dim strTimeStamp As String = DataGridView2.SelectedRows(0).Cells("result_timestamp").Value.ToString
        If MessageBox.Show("Are you sure you want to delete all the selected results?", "Delete", MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
            LoginForm1.Close()
            LoginForm1.Tag = "adminCheck"

            If LoginForm1.ShowDialog() = DialogResult.OK Then
                If LoginForm1.Tag = "adminOk" Then
                    If mappDB.doQuery(String.Format(strSQL, dSession, dCourse, strTimeStamp)) = True Then
                        ButtonShowAll.PerformClick()
                        MsgBox("Results deleted sucessfully")
                    Else
                        MsgBox("Could not Delete Result")
                    End If
                End If
                End If
            End If
    End Sub

    Private Sub TextBoxSession_TextChanged_1(sender As Object, e As EventArgs) Handles TextBoxSession.TextChanged
        On Error Resume Next
        If DataGridView2.Rows.Count > 0 Then
            DataGridView2.DataSource.RowFilter = String.Format(STR_FILTER_RESULTS_BYSESSION, TextBoxSession.Text)
        End If
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub DataGridView2_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentDoubleClick
        shoWDetails()
    End Sub
    Sub shoWDetails()
        Dim txtCourseCode, txtSession As String
        Dim myDataSet As DataSet
        If DataGridView2.SelectedRows.Count > 0 And
            DataGridView2.Columns.Contains("course_code_idr") And
            DataGridView2.Columns.Contains("session_idr") Then
            txtCourseCode = DataGridView2.SelectedRows(0).Cells("course_code_idr").Value
            txtSession = DataGridView2.SelectedRows(0).Cells("session_idr").Value
            myDataSet = objResult.getFromDBResultssDataset(txtSession, txtCourseCode)
            DataGridView2.DataSource = myDataSet.Tables(0).DefaultView
            DataGridView2.Tag = "details"
        End If
    End Sub
    Private Sub bgwLoad_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgwLoad.DoWork
        TimerBS.Start()
        bgwLoad.ReportProgress(20)
        getResultSummary()
        bgwLoad.ReportProgress(90)
    End Sub

    Private Sub bgwLoad_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgwLoad.RunWorkerCompleted
        DataGridView2.DataSource = resultSummarryDV
        Me.ButtonShowAll.Enabled = True
        TimerBS.Stop()
        ProgressBarBS.Value = 100
    End Sub

    Private Sub bgwLoad_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bgwLoad.ProgressChanged
        ProgressBarBS.Value = e.ProgressPercentage
    End Sub
    Private Function getResultSummary() As DataView

        Try
            resultSummarryDV = mappDB.GetDataWhere(STR_SQL_ALL_RESULTS_SUMMARY).Tables(0).DefaultView

        Catch ex As Exception

        End Try
        Return resultSummarryDV
    End Function

    Private Sub TimerBS_Tick(sender As Object, e As EventArgs) Handles TimerBS.Tick
        ProgressBarBS.Value = ProgressBarBS.Value + 1
    End Sub

    Private Sub FormViewResults_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        bgwLoad.RunWorkerAsync()
    End Sub

    Private Sub TextBoxCheckCourseCode_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCheckCourseCode.TextChanged
        On Error Resume Next
        If DataGridView2.Rows.Count > 0 Then
            DataGridView2.DataSource.RowFilter = String.Format(STR_FILTER_RESULTS_BYCOURSECODE, TextBoxCourseCode.Text)
        End If
    End Sub

    Private Sub ButtonCheckHash_Click(sender As Object, e As EventArgs) Handles ButtonCheckHash.Click
        Dim dt As DataTable
        Dim dv As DataView
        dv = DataGridView2.DataSource
        dt = dv.ToTable
        If TextBoxCheckHash.Text = "" Then
            MsgBox("Enter the computer generated hash code at the bottom of the printed result")
        ElseIf DataGridView2.Tag = "summary" Then
            'summary mode
            shoWDetails()
            'todo calc for each result and store
            'warn user that it may take some time
        ElseIf DataGridView2.SelectedRows.Count > 0 And DataGridView2.Tag = "details" Then
            If checkHash(DataGridView2.Rows(DataGridView2.SelectedRows(0).Index).Cells("course_code").Value, dt).Contains(TextBoxCheckHash.Text) And TextBoxCheckHash.Text.Length > 5 Then
                TextBoxCheckHash.BackColor = Color.Green
            Else
                TextBoxCheckHash.BackColor = Color.Pink
            End If

        End If
    End Sub
    Function checkHash(courseCode As String, dt As DataTable) As String
        '---Hash parameters
        Dim numStu As Integer
        Dim avrScore As Integer
        Dim sumScore As Integer = 0
        'Dim codedScores As Long
        Dim tmpCode As String = ""
        Dim finalHash As String
        'Dim timeStamp As Long
        'data


        Dim dStr As String = ""
        Dim dL As Integer = 0

        numStu = dt.Rows.Count
        For i = 0 To dt.Rows.Count - 1

            If IsDBNull(dt.Rows(i).Item("matno")) Then dt.Rows(i).Item("matno") = ""
            If IsDBNull(dt.Rows(i).Item("total")) Then dt.Rows(i).Item("total") = ""
            dStr = dt.Rows(i).Item("matno")
            dL = dStr.Length
            tmpCode = tmpCode & dStr.ToString.Substring(dL - 3, 2) & dt.Rows(i).Item("total").ToString
            sumScore = sumScore + CInt(dt.Rows(i).Item("total"))

        Next
        avrScore = sumScore / numStu
        finalHash = getMD5HashCode(tmpCode & avrScore.ToString)

        Return finalHash
    End Function

    Private Sub TextBoxCheckHash_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCheckHash.TextChanged
        TextBoxCheckHash.BackColor = Color.White
    End Sub

    Private Sub ButtonShowDetails_Click(sender As Object, e As EventArgs) Handles ButtonShowDetails.Click
        shoWDetails()
    End Sub

    Private Sub ButtonPrint_Click(sender As Object, e As EventArgs) Handles ButtonPrint.Click
        Dim dt, dtSub As DataTable
        Dim dv As DataView
        Dim txtCourseCode, txtSession As String
        Dim tmpCol As New DataColumn
        Dim resulltHash As String
        dv = DataGridView2.DataSource
        dt = dv.ToTable

        If DataGridView2.Tag = "details" Then
            dt.Columns.Add("remarks", GetType(System.String))
            dt.Columns.Add("score", GetType(System.String))
            dt.Columns.Add("course_code_idr", GetType(System.String))
            dt.Columns.Add("department", GetType(System.String))
            dt.Columns.Add("sn", GetType(System.String))
            dt.AcceptChanges()
            resulltHash = checkHash(DataGridView2.SelectedRows(0).Cells("course_code").Value, dt)
            For i = 0 To dt.Rows.Count - 1
                dt.Rows(i).Item("remarks") = resulltHash
                dt.Rows(i).Item("course_code_idr") = dt.Rows(i).Item("course_code")
                dt.Rows(i).Item("score") = dt.Rows(i).Item("total")
                dt.Rows(i).Item("department") = dt.Rows(i).Item("dept_name")
                dt.Rows(i).Item("sn") = dt.Rows(i).Item("s_n")
            Next
            showResult(dt)
        Else    'If DataGridView2.Tag = "summary" summarry by default
            'Add extra fields for report
            dt.Columns.Add("remarks", GetType(System.String))
            dt.Columns.Add("score", GetType(System.String))
            dt.Columns.Add("matno", GetType(System.String))   'todo make this code_code fiel cosistent across summar and detail
            dt.Columns.Add("department", GetType(System.String))
            dt.Columns.Add("sn", GetType(System.String))
            dt.Columns.Add("SURNAME", GetType(System.String))
            dt.AcceptChanges()
            'get hash or each reuslt and save it in fields
            For i = 0 To dt.Rows.Count - 1
                txtCourseCode = dt.Rows(i).Item("course_code_idr")
                txtSession = dt.Rows(i).Item("session_idr")
                dtSub = objResult.getFromDBResultssDataset(txtSession, txtCourseCode).Tables(0)
                If dtSub.Rows.Count = 0 Then
                    dt.Rows(i).Item("SURNAME") = "Could not retrieve result"
                Else
                    resulltHash = checkHash(dtSub.Rows(0).Item("Course_code").ToString, dtSub)

                    dt.Rows(i).Item("SURNAME") = resulltHash
                    dt.Rows(i).Item("remarks") = dt.Rows(i).Item("course_code_idr") ' resulltHash
                    dt.Rows(i).Item("matno") = dt.Rows(i).Item("course_code_idr")
                    dt.Rows(i).Item("score") = dt.Rows(i).Item("NumStudents")
                    dt.Rows(i).Item("department") = "ALL DEPARTMENTS"
                    dt.Rows(i).Item("sn") = i
                    dt.Rows(i).Item("course_code_idr") = "ALL COURSES"
                    dt.Rows(i).Item("session_idr") = "ALL SESSIONS"
                    'dt.Rows(i).Item("course_title") = "ALL"

                End If



            Next
            showResult(dt)  'showthe report
        End If

        'tmpCol = New DataColumn("cgc", System.Strin)

        'dt.Columns.Add(tmpCol)
    End Sub
    Public Sub showResult(dt As DataTable)
        Try
            With Me.ReportViewer1.LocalReport
                .DataSources.Clear()
                '.ReportPath = My.Application.Info.DirectoryPath
                .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt))
            End With
            Me.ReportViewer1.RefreshReport()
            'Works perfectly
            PanelReport.Dock = DockStyle.Fill
            PanelReport.Show()

        Catch ex As Exception
            MsgBox("Cannot get Senate data" & vbCrLf & ex.Message)
        End Try

        ' Me.ShowDialog()

    End Sub

    Private Sub LabelClose_Click(sender As Object, e As EventArgs) Handles LabelClose.Click
        PanelReport.Hide()
    End Sub

    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Me.Close()
    End Sub
End Class
