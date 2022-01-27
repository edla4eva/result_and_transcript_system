Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class FormCourseMarkSheets
    Dim course_dept_idr As Integer = 1 '
    Dim session_idr As String = "2018/2019"
    Dim strSQL As String
    Dim strConnectionString As String
    Dim ref As Integer

    Dim tmpDS As DataSet
    Dim dsStudents, dsReg As New DataSet

    'forced to do this
    Dim glbRegConn As New OleDb.OleDbConnection(ModuleGeneral.STR_connectionString32)
    Dim glbRegConnFORM As New OleDb.OleDbConnection(ModuleGeneral.STR_connectionString32)
    Dim glbAdapter As New OleDb.OleDbDataAdapter()
    Dim glbAdapterFORM As New OleDb.OleDbDataAdapter()
    Dim glbDTReg As DataTable
    Dim glbBND As New BindingSource

    Private Sub FormCourseMarkSheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.WindowState = FormWindowState.Maximized

            Me.BackColor = RGBColors.colorBackground
            Me.dgvCourseMarkSheet.BackgroundColor = RGBColors.colorBackground
            Me.dgvCourseMarkSheet.RowsDefaultCellStyle.BackColor = RGBColors.colorForeground
            Me.dgvCourseMarkSheet.RowsDefaultCellStyle.ForeColor = RGBColors.colorBackground
        Catch ex As Exception
            MsgBox("Something went wrong, see log for details" & vbCrLf & ex.Message)
            logError(ex.ToString)

        End Try
    End Sub
    Private Sub FormCourseMarkSheet_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        On Error Resume Next
        If dictDepts.Count < 1 Then bgwLoad.RunWorkerAsync(1)
    End Sub
    Private Sub ButtonRegToExcel_Click(sender As Object, e As EventArgs) Handles ButtonRegToExcel.Click
        Dim retFileName As String = ""
        Dim saveDiag As New SaveFileDialog
        saveDiag.Filter = "Excel Files|*.xlsx|All files|*.*"
        If saveDiag.ShowDialog = DialogResult.OK Then
            retFileName = saveDiag.FileName

            retFileName = objExcelFile.exportRegToExcelFile_NPOI(dgvCourseMarkSheet.DataSource, retFileName)
            MsgBox("File exported to: " & retFileName)
            TextBoxTemplateFileName.Text = retFileName
        End If
    End Sub
    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefreshFormview.Click
        Try
            Dim dSession = ComboBoxSessions.SelectedItem
            Dim dDeptID As Integer = mappDB.getDeptID(ComboBoxDepartments.SelectedItem)
            Dim dlvl As Integer = ComboBoxLevel.SelectedItem
            Dim dCourse As String = ComboBoxCourseCode.SelectedItem

            Dim tmpCourseMarkSheet As DataTable
            'Dont use level so that once result is uploaded all course advises for higher levels can use it 
            'DONT-->Dim strSQL As String = String.Format("SELECT * FROM Reg WHERE session_idr='{0}' And dept_idr={1} And [level]={2}", dSession, dDeptID.ToString, dlvl.ToString)
            Dim strSQL As String = String.Format("SELECT * FROM Reg WHERE session_idr='{0}' And dept_idr={1}", dSession, dDeptID.ToString)

            glbDTReg = mappDB.GetDataWhere(strSQL).Tables(0)
            tmpCourseMarkSheet = glbDTReg.Copy
            tmpCourseMarkSheet.Rows.Clear()


            For i = 0 To glbDTReg.Rows.Count - 1
                If glbDTReg.Rows(i).Item("CourseCode_1").ToString.Contains(dCourse) Or
                    glbDTReg.Rows(i).Item("CourseCode_2").ToString.Contains(dCourse) Then
                    tmpCourseMarkSheet.Rows.Add(glbDTReg.Rows(i).ItemArray)
                End If
            Next
            tmpCourseMarkSheet.AcceptChanges()
            Dim listcolNames As New List(Of String)
            For j = 0 To tmpCourseMarkSheet.Columns.Count - 1
                If tmpCourseMarkSheet.Columns(j).ColumnName = "matno" Then
                ElseIf tmpCourseMarkSheet.Columns(j).ColumnName = "student_surname" Then
                ElseIf tmpCourseMarkSheet.Columns(j).ColumnName = "student_firstname" Then

                Else
                    listcolNames.Add(tmpCourseMarkSheet.Columns(j).ColumnName) 'note it
                End If
            Next
            'delete noted useless columns
            Dim delColCount = 0
            For Each iName In listcolNames
                tmpCourseMarkSheet.Columns.Remove(iName) 'TODO: its not removing, just moving to the end
                delColCount += 1 'update count of deleted cols
            Next
            tmpCourseMarkSheet.AcceptChanges()
            dgvCourseMarkSheet.DataSource = tmpCourseMarkSheet.DefaultView
        Catch ex As Exception
            MsgBox("Error occured, see log for details" & vbCrLf & ex.Message)
            logError(ex.ToString)

        End Try
    End Sub
    Public Sub resizeDatagrids(dGrid As String)
        On Error Resume Next
        If dgvCourseMarkSheet.Rows.Count > 0 And dGrid = "Courses" Then

            For Each col As DataGridViewColumn In dgvCourseMarkSheet.Columns
                col.Width = 0
                col.Visible = False
                If col.HeaderText = "matno" Then
                    col.Width = 70
                    col.Visible = True
                ElseIf col.HeaderText = "CourseCode_1" Then
                    col.Width = 200
                    col.Visible = True
                ElseIf col.HeaderText = "CourseCode_2" Then
                    col.Width = 200
                    col.Visible = True
                End If
            Next
        ElseIf dgvCourseMarkSheet.Rows.Count > 0 And dGrid = "Students" Then
            dgvCourseMarkSheet.Columns("matno").Frozen = True
            For Each col As DataGridViewColumn In dgvCourseMarkSheet.Columns
                col.Width = 50
                If col.HeaderText = "matno" Then
                    col.Width = 100
                ElseIf col.HeaderText = "first_name" Then
                    col.Width = 150
                ElseIf col.HeaderText = "surname" Then
                    col.Width = 100
                End If
            Next
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Sub filterStudents(dMATNO As String)
        Try
            If dgvCourseMarkSheet.Rows.Count > 0 Then
                'PROBLEM: how do we filter a datatable
                'glbBND.DataSource.RowFilter = String.Format(STR_FILTER_REG_BY_MATNO_LIKE, dMATNO)
                'glbBND.DataSource = glbBND.DataSource.Select(String.Format(STR_FILTER_REG_BY_MATNO_LIKE, dMATNO)).CopyToDataTable()
                'dgvStudents.DataSource = glbBND

                Dim rowIndex As Integer = -1
                For Each row In dgvCourseMarkSheet.Rows
                    If row.Cells("matno").value Is Nothing Then Continue For
                    If (row.Cells("matno").Value.ToString() = dMATNO.ToUpper) Then
                        rowIndex = row.Index
                        Exit For
                    End If
                Next
                dgvCourseMarkSheet.Rows(rowIndex).Selected = True
                dgvCourseMarkSheet.CurrentCell = dgvCourseMarkSheet.Rows(rowIndex).Cells(0)
                'Catch ex As NullReferenceException
            End If
        Catch ex As Exception
            Throw
        End Try

    End Sub


    Private Sub FormCourseMarkSheet_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        On Error Resume Next
        MainForm.doCloseForm()

        glbRegConn.Close()
        glbRegConnFORM.Close()
        glbRegConn = Nothing
        glbRegConnFORM = Nothing
    End Sub
    Private Sub TimerBS_Tick(sender As Object, e As EventArgs) Handles TimerBS.Tick
        If ProgressBarBS.Value < 97 Then ProgressBarBS.Value = (ProgressBarBS.Value + 3)
    End Sub

    Private Sub bgwLoad_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgwLoad.DoWork
        mappDB.getDeptSessionsIntoDictionaries()
    End Sub

    Private Sub ButtonOpenCourseMarkSheet_Click(sender As Object, e As EventArgs) Handles ButtonOpenCourseMarkSheet.Click
        Try
            System.Diagnostics.Process.Start(TextBoxTemplateFileName.Text)
        Catch ex As Exception
            logError(ex.ToString)
            MsgBox("Could not open excel file" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub ButtonOpen_Click(sender As Object, e As EventArgs) Handles ButtonOpen.Click
        Try
            System.Diagnostics.Process.Start(TextBoxTemplateFileName.Text)
        Catch ex As Exception
            logError(ex.ToString)
            MsgBox("Could not open excel file, you have to generate course marksheet before you can open it" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub bgwLoad_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgwLoad.RunWorkerCompleted
        Try

            'for dictonaries
            ComboBoxDepartments.Items.Clear()
            For Each key In dictDepts.Keys
                ComboBoxDepartments.Items.Add(dictDepts(key))
            Next
            If ComboBoxDepartments.Items.Count > 0 Then ComboBoxDepartments.SelectedIndex = 0

            ComboBoxSessions.Items.Clear()
            For Each key In dictSessions.Keys
                ComboBoxSessions.Items.Add(dictSessions(key))
            Next

            If ComboBoxSessions.Items.Count > 0 Then ComboBoxSessions.SelectedIndex = 0

            ComboBoxCourseCode.Items.Clear()
            For Each key In dictAllCourses.Keys
                ComboBoxCourseCode.Items.Add(dictAllCourses(key))
            Next
            ComboBoxCourseCode.SelectedIndex = 0


            ComboBoxLevel.SelectedIndex = 0
            dgvCourseMarkSheet.DataSource = glbBND
            If dgvCourseMarkSheet.Rows.Count > 0 Then
                resizeDatagrids("students")
            End If

            TimerBS.Stop()

            Me.ProgressBarBS.Value = 100
        Catch ex As Exception
            MsgBox("Something went wrong, see log for details" & vbCrLf & ex.Message)
            logError(ex.ToString)

        End Try
    End Sub



End Class