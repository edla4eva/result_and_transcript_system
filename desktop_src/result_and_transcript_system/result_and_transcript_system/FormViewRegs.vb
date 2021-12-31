Imports System.ComponentModel

Public Class FormViewRegs
    Dim resultSummarryDV As New DataView
    Private Sub FormViewResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = RGBColors.colorBlack2

    End Sub


    Private Sub ButtonShowAll_Click(sender As Object, e As EventArgs) Handles ButtonShowAll.Click
        Me.ButtonShowAll.Enabled = False

        bgwLoad.RunWorkerAsync()
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
        Dim strSQL As String = DELETE_FROM_REG_WHERE_SESSION_DEPTID_LEVEL
        Dim dSession As String = DataGridView2.SelectedRows(0).Cells("session_idr").Value.ToString
        Dim dCourse As String = DataGridView2.SelectedRows(0).Cells("dept_idr").Value.ToString
        Dim dlevel As String = DataGridView2.SelectedRows(0).Cells("level").Value.ToString
        If MessageBox.Show("Are you sure you want to delete all the selected registration data?", "Delete", MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then

            LoginForm1.Close()
            LoginForm1.Tag = "adminCheck"

            If LoginForm1.ShowDialog() = DialogResult.OK Then
                If LoginForm1.Tag = "adminOk" Then
                    If mappDB.doQuery(String.Format(strSQL, dSession, dCourse, dlevel)) = True Then
                        ButtonShowAll.PerformClick()
                        MsgBox("Registration data deleted sucessfully")
                    Else
                        MsgBox("Could not delete Registratin data")
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
        Dim txtCourseCode, txtSession As String
        Dim myDataSet As DataSet
        If DataGridView2.SelectedRows.Count > 0 And
            DataGridView2.Columns.Contains("course_code_idr") And
            DataGridView2.Columns.Contains("session_idr") Then
            txtCourseCode = DataGridView2.SelectedRows(0).Cells("course_code_idr").Value
            txtSession = DataGridView2.SelectedRows(0).Cells("session_idr").Value
            myDataSet = objResult.getFromDBResultssDataset(txtSession, txtCourseCode)
            DataGridView2.DataSource = myDataSet.Tables(0).DefaultView
        End If
    End Sub

    Private Sub bgwLoad_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgwLoad.DoWork
        TimerBS.Start()
        bgwLoad.ReportProgress(20)
        getRegSummary()
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
    Private Function getRegSummary() As DataView

        Try
            resultSummarryDV = mappDB.GetDataWhere(STR_SQL_ALL_REG_SUMMARY).Tables(0).DefaultView

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

    Private Sub ButtonCoursereg_Click(sender As Object, e As EventArgs) Handles ButtonCoursereg.Click
        MainForm.ChangeMenu("StudentsRegistration")
    End Sub
End Class
