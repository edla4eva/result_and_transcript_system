Imports System.ComponentModel

Public Class FormViewBroadsheets
    Dim txtlevel, txtSession, txtDept As String
    Dim dt As New DataTable

    Private Sub FormViewBroadsheets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        Me.BackColor = RGBColors.colorBackground
        Me.BackColor = RGBColors.colorBackground
        Me.DataGridView1.BackgroundColor = RGBColors.colorBackground
        Me.DataGridView1.RowsDefaultCellStyle.BackColor = RGBColors.colorForeground
        Me.DataGridView1.RowsDefaultCellStyle.ForeColor = RGBColors.colorBackground
    End Sub

    Private Sub ButtonShowAllBroadsheet_Click(sender As Object, e As EventArgs) Handles ButtonShowAllBroadsheet.Click

        'objExcelFile.excelFileName = PROG_DIRECTORY & "\templates\broadsheet.xltx"
        Try
            Dim strSQL As String = STR_SQL_ALL_BROADSHEETS_SUMMARY
            Dim dt As New DataTable
            Dim dictColHeaders As New Dictionary(Of String, String)
            dt = mappDB.GetDataWhere(strSQL).Tables(0)
            DataGridView1.Tag = "summary"

            'Note this is necessary to add user readale headings. query returns machine obscure headings
            DataGridView1.DataSource = dt.DefaultView
            DataGridView1.Columns(0).HeaderText = "Session"
            'DataGridView1.Columns("bs_department").HeaderText = "Department"

            DataGridView1.Columns("Footers").HeaderText = "Info"
            DataGridView1.Columns("Footers").Width = 160

        Catch ex As Exception
            MsgBox("Cannot get broadsheets data" & vbCrLf & ex.Message)
        End Try


    End Sub


    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles LabelClosePanelModify.Click
        PanelModify.Visible = False
    End Sub
    Private Sub FormViewBroadsheets_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MainForm.doCloseForm()
    End Sub
    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub FormViewBroadsheets_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        bgwLoad.RunWorkerAsync()        'load comboboxes at background
        ButtonShowAllBroadsheet.PerformClick()
    End Sub

    Private Sub bgwLoad_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgwLoad.DoWork
        mappDB.getDeptSessionsIntoDictionaries()
    End Sub

    Private Sub bgwLoad_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgwLoad.RunWorkerCompleted

        ComboBoxDepartments.Items.Clear()
        For Each key In dictDepts.Keys
            ComboBoxDepartments.Items.Add(dictDepts(key))
        Next
        TextBoxDepartment.Text = ComboBoxDepartments.Items(0).ToString
        ComboBoxDepartments.SelectedIndex = 0

        ComboBoxSessions.Items.Clear()
        For Each key In dictSessions.Keys
            ComboBoxSessions.Items.Add(dictSessions(key))
        Next
        ComboBoxSessions.SelectedIndex = 0
        TextBoxSession.Text = ComboBoxSessions.Items(0).ToString

        ComboBoxLevel.SelectedIndex = 0
        TextBoxLevel.Text = ComboBoxLevel.Items(0).ToString
    End Sub

    Private Sub ButtonAdjustTemplate_Click(sender As Object, e As EventArgs) Handles ButtonApprove.Click
        MsgBox("This feature is only supported in the Commercial version")
    End Sub

    Private Sub ButtonSearchBroadheet_Click(sender As Object, e As EventArgs) Handles ButtonSearchBroadheet.Click
        Try
            Dim txtlevel, txtSession, txtDept As String
            txtlevel = "100"
            txtSession = "2018/2019"
            txtDept = "Computer Engineering".ToUpper
            txtlevel = ComboBoxLevel.SelectedItem
            txtSession = ComboBoxSessions.SelectedItem
            txtDept = ComboBoxDepartments.SelectedItem

            dt = mappDB.showBroadsheet(txtSession, txtDept, txtlevel, Nothing, False)

        Catch ex As Exception
            MsgBox("Cannot get broadsheets data" & vbCrLf & ex.Message)
        End Try


    End Sub



    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        If DataGridView1.SelectedRows Is Nothing Or DataGridView1.Columns.Contains("Col150") Then
            Exit Sub
        End If 'todo: change col171 to session, col172 to dept etc in db table & across code for easy maintainance
        Dim strSQL As String = STR_SQL_ALL_BROADSHEET_WHERE_SESSION_DEPT_LEVEL_WITHOUT_TIMESTAMP
        Dim dSession As String = DataGridView1.SelectedRows(0).Cells("bs_session").Value.ToString       'todo put fieldnames in constants in general module
        Dim dDept As String = DataGridView1.SelectedRows(0).Cells("bs_department_name").Value.ToString
        Dim dLevel As String = DataGridView1.SelectedRows(0).Cells("bs_level").Value.ToString
        Dim strTimeStamp As String = DataGridView1.SelectedRows(0).Cells("bs_timestamp").Value.ToString
        'todo: ColNames is now used as timestamp may make soft difficult to maintain, change to timestamp across db, queries and code
        If MessageBox.Show("Are you sure you want to delete the selected broadsheet?", "Delete", MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
            LoginForm1.Close()
            LoginForm1.Tag = "adminCheck"

            If LoginForm1.ShowDialog() = DialogResult.OK Then
                If LoginForm1.Tag = "adminOk" Then
                    'todo if loginForm.isSignedInAsAdmin then
                    If mappDB.doQuery(String.Format(strSQL, dSession, dDept, dLevel, strTimeStamp)) Then
                        ButtonShowAllBroadsheet.PerformClick()
                        MsgBox("Broadsheet deleted sucessfully")
                    Else
                        MsgBox("Something went wrong")
                    End If

                End If
            End If
        End If
    End Sub

    Private Sub BgWProcess_DoWork(sender As Object, e As DoWorkEventArgs) Handles BgWProcess.DoWork

        dt = mappDB.showBroadsheet(txtSession, txtDept, txtlevel, e.Argument.ToString, False) 'txtSession, txtDept, txtlevel,

    End Sub
    Private Sub BgWProcess_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BgWProcess.RunWorkerCompleted
        TimerBS.Stop()
        DataGridView1.DataSource = Nothing
        DataGridView1.Rows.Clear()
        DataGridView1.Columns.Clear()
        DataGridView1.DataSource = dt.DefaultView
        DataGridView1.Columns(0).Width = 25   's/N
        DataGridView1.Columns(1).Width = 100   'Mat
        DataGridView1.Columns(2).Width = 150   'Name
        DataGridView1.Columns(3).Visible = False   'hide
        DataGridView1.Columns(4).Visible = False   'hide
        DataGridView1.Columns(5).Visible = False   'hide
        For Each col In DataGridView1.Columns
            col.name = dt.Columns(col.index).ColumnName
            col.headertext = dt.Columns(col.index).ColumnName
            If col.name.contains("ColUNIQUE") Then col.visible = False
            If col.name.contains("Repeat") Then col.width = 120
            'todo: if dictionary dictAllCourseCodeKeyAndCourseLevelVal is nothing load it--> mappdb.dict...()
            If dictAllCourseCodeKeyAndCourseLevelVal.ContainsKey(col.name) Then
                If Not dictAllCourseCodeKeyAndCourseLevelVal(col.name) = txtlevel Then
                    col.visible = False
                Else
                    col.width = 65
                End If
            End If
        Next
        objBroadsheet.progressStr = ""
        objBroadsheet.progress = 0
        Me.ProgressBarBS.Value = 100
        Me.LabelProgress.Text = "Done"
    End Sub

    Private Sub ButtonShowDetails_Click(sender As Object, e As EventArgs) Handles ButtonShowDetails.Click
        If Not DataGridView1.Tag = "detail" Then 'And
            'DataGridView1.Columns.Contains("Col172") Then
            If IsDBNull(DataGridView1.SelectedRows(0).Cells("bs_session").Value) Or
                    IsDBNull(DataGridView1.SelectedRows(0).Cells("bs_session").Value) Or
                    IsDBNull(DataGridView1.SelectedRows(0).Cells("bs_session").Value) Then
                MsgBox("Session, level or deparment is missing")
                Exit Sub
            End If
            txtlevel = DataGridView1.SelectedRows(0).Cells("bs_level").Value
            txtSession = DataGridView1.SelectedRows(0).Cells("bs_session").Value
            txtDept = DataGridView1.SelectedRows(0).Cells("bs_department_name").Value
            TimerBS.Start()
            BgWProcess.RunWorkerAsync(DataGridView1.SelectedRows(0).Cells("bs_timestamp").Value)
            DataGridView1.Tag = "detail"
        Else
            DataGridView1.Tag = "summary"
        End If
    End Sub

    Private Sub TimerBS_Tick(sender As Object, e As EventArgs) Handles TimerBS.Tick
        If objBroadsheet.progress <= 100 Then ProgressBarBS.Value= CInt(objBroadsheet.progress)
        Me.LabelProgress.Text= (objBroadsheet.progress).ToString & "% - " & objBroadsheet.progressStr

    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        'Dim myDataSet As DataSet
        If e.RowIndex >= 0 Then
            ButtonShowDetails.PerformClick()
        End If
    End Sub

    Private Sub ButtonRework_Click(sender As Object, e As EventArgs) Handles ButtonRework.Click

        MainForm.ChangeMenu("GenerateBroadsheet")
        FormGenerateBroadsheet.importBroadsheetData(DataGridView1.DataSource)

    End Sub


End Class