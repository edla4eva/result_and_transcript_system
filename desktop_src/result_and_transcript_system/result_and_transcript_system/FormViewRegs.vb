Imports System.ComponentModel

Public Class FormViewRegs
    Dim summarryRegsDV As New DataView
    Dim summarryRegDV As New DataView
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
        If TextBoxLevel.Text = "" And TextBoxSession.Text = "" Then
            TextBoxSession.BackColor = Color.Pink
            TextBoxLevel.BackColor = Color.Pink
            MessageBox.Show("Please enter the Session or CourseCode and retry again")
            Exit Sub
        ElseIf Not TextBoxLevel.Text = "" Then
            myDataSet = objResult.getFromDBResultssDataset(TextBoxSession.Text, TextBoxLevel.Text)
            DataGridViewRegs.DataSource = myDataSet.Tables(0).DefaultView
            TextBoxLevel.BackColor = Color.White
            TextBoxLevel.BackColor = Color.White
        ElseIf Not TextBoxSession.Text = "" Then
            myDataSet = objResult.getFromDBResultssDataset(TextBoxSession.Text, TextBoxLevel.Text)
            DataGridViewRegs.DataSource = myDataSet.Tables(0).DefaultView
            TextBoxSession.BackColor = Color.White
            TextBoxLevel.BackColor = Color.White
        End If
    End Sub




    Private Sub FormViewResults_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MainForm.doCloseForm()
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub TextBoxSession_TextChanged(sender As Object, e As EventArgs) Handles TextBoxLevel.TextChanged
        'get col headers
        ' rowHeades("Session")
        On Error Resume Next
        If DataGridViewRegs.Rows.Count > 0 Then
            DataGridViewRegs.DataSource.RowFilter = String.Format(STR_FILTER_REG_BY_LEVEL, TextBoxLevel.Text)
        End If
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Dim strSQL As String = DELETE_FROM_REG_WHERE_SESSION_DEPTID_LEVEL
        Dim dSession As String = DataGridViewRegs.SelectedRows(0).Cells("session_idr").Value.ToString
        Dim dDeptID As String = DataGridViewRegs.SelectedRows(0).Cells("dept_idr").Value.ToString
        Dim dlevel As String = DataGridViewRegs.SelectedRows(0).Cells("level").Value.ToString

        If Not DataGridViewRegs.SelectedRows Is Nothing Or DataGridViewRegs.Columns.Contains("matno") Then
            strSQL = DELETE_FROM_REGS_WHERE_SESSION_DEPTID_LEVEL
        ElseIf Not DataGridViewReg.SelectedRows Is Nothing Or DataGridViewRegs.Columns.Contains("matno") Then
            strSQL = DELETE_FROM_REG_WHERE_SESSION_DEPTID_LEVEL
        Else
            Exit Sub
        End If

        If MessageBox.Show("Are you sure you want to delete all the selected registration data?", "Delete", MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
            LoginForm1.Close()
            LoginForm1.Tag = "adminCheck"

            If LoginForm1.ShowDialog() = DialogResult.OK Then
                If LoginForm1.Tag = "adminOk" Then
                    If mappDB.doQuery(String.Format(strSQL, dSession, dDeptID, dlevel)) = True Then
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
        If DataGridViewRegs.Rows.Count > 0 Then
            DataGridViewRegs.DataSource.RowFilter = String.Format(STR_FILTER_RESULTS_BYSESSION, TextBoxSession.Text)
        End If
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewRegs.CellContentClick

    End Sub

    Private Sub DataGridView2_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewRegs.CellContentDoubleClick
        Dim txtCourseCode, txtSession As String
        Dim myDataSet As DataSet
        If DataGridViewRegs.SelectedRows.Count > 0 And
            DataGridViewRegs.Columns.Contains("course_code_idr") And
            DataGridViewRegs.Columns.Contains("session_idr") Then
            txtCourseCode = DataGridViewRegs.SelectedRows(0).Cells("course_code_idr").Value
            txtSession = DataGridViewRegs.SelectedRows(0).Cells("session_idr").Value
            myDataSet = objResult.getFromDBResultssDataset(txtSession, txtCourseCode)
            DataGridViewRegs.DataSource = myDataSet.Tables(0).DefaultView
        End If
    End Sub

    Private Sub bgwLoad_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgwLoad.DoWork
        TimerBS.Start()
        bgwLoad.ReportProgress(20)
        getRegSummary()
        bgwLoad.ReportProgress(90)
    End Sub

    Private Sub bgwLoad_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgwLoad.RunWorkerCompleted
        DataGridViewRegs.DataSource = summarryRegsDV
        DataGridViewReg.DataSource = summarryRegDV
        Me.ButtonShowAll.Enabled = True
        TimerBS.Stop()
        ProgressBarBS.Value = 100
    End Sub

    Private Sub bgwLoad_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bgwLoad.ProgressChanged
        ProgressBarBS.Value = e.ProgressPercentage
    End Sub
    Private Function getRegSummary() As DataView

        Try
            summarryRegsDV = mappDB.GetDataWhere(STR_SQL_ALL_REGS_SUMMARY).Tables(0).DefaultView
            '
            summarryRegDV = mappDB.GetDataWhere(STR_SQL_ALL_REG_SUMMARY).Tables(0).DefaultView

        Catch ex As Exception

        End Try
        Return summarryRegsDV
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

    Private Sub ButtonUse_Click(sender As Object, e As EventArgs) Handles ButtonUse.Click
        If DataGridViewRegs.SelectedRows Is Nothing Or DataGridViewRegs.Columns.Contains("matno") Then
            MsgBox("Select one of the previously backed up registration data")
            Exit Sub
        End If
        Dim strSQLDelete As String = DELETE_FROM_REG_WHERE_SESSION_DEPTID_LEVEL
        Dim strSQL As String = "SELECT * FROM Reg" ' DELETE_FROM_REG_WHERE_SESSION_DEPTID_LEVEL
        Dim dSession As String = DataGridViewRegs.SelectedRows(0).Cells("session_idr").Value.ToString
        Dim dDeptID As String = DataGridViewRegs.SelectedRows(0).Cells("dept_idr").Value.ToString
        Dim dlevel As String = DataGridViewRegs.SelectedRows(0).Cells("level").Value.ToString

        If mappDB.doQuery(String.Format(strSQLDelete, dSession, dDeptID, dlevel)) = True Then
            ButtonShowAll.PerformClick()
            MsgBox("Existing Registration data deleted sucessfully")
        Else
            MsgBox("Could not delete Registratin data")
        End If

        strSQL = String.Format("Select * From Regs WHERE session_idr='{0}' AND dept_idr={1} AND level={2}", dSession, dDeptID, dlevel)
        Dim dtCurrentReg As DataTable = mappDB.GetDataWhere(strSQL, "Reg").Tables(0)


        If Not mappDB.bulkInsertDBUsingDataAdapter(dtCurrentReg, "Reg") Is Nothing Then
            ButtonShowAll.PerformClick()
            MsgBox("New Registration data copied sucessfully")
        Else
            MsgBox("Could not copy Registratin data")
        End If




    End Sub

    Private Sub ButtonBackup_Click(sender As Object, e As EventArgs) Handles ButtonBackup.Click
        If DataGridViewReg.Rows.Count < 1 Then
            Exit Sub
        End If
        Dim strSQL As String = "SELECT * FROM Reg" ' Get the data
        Dim dtReg As DataTable = mappDB.GetDataWhere(strSQL, "Reg").Tables(0)

        DataGridViewReg.DataSource = mappDB.bulkInsertDBUsingDataAdapter(dtReg, "Regs") 'back it up
        If Not DataGridViewReg.DataSource Is Nothing Then
            ButtonShowAll.PerformClick()
            MsgBox("New Registration data backed up sucessfully")
        Else
            MsgBox("Could not back up Registratin data")
        End If


    End Sub
End Class
