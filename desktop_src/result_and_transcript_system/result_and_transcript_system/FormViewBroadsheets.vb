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
            ' Dim strColNames As String
            ' Dim strArrColNames As String()
            dt = mappDB.GetDataWhere(strSQL).Tables(0)
            'strColNames = dt.Rows(0).Item("ColNames").ToString
            'strArrColNames = strColNames.Split(",")
            'DataGridView1.DataSource = dt.DefaultView
            'For Each col In dt.Columns
            '    If strArrColNames(col) <> "" Then col.coloumnName = strArrColNames(col)
            '    dt.Rows(0).Item(col.index) = strArrColNames(col)
            'Next


            'Note this is necessary to add user readale headings. quer retus machine useful eadings like col172
            DataGridView1.DataSource = dt.DefaultView
            DataGridView1.Columns(0).HeaderText = "Session"
            DataGridView1.Columns("Col172").HeaderText = "Department"
            'Already handled in query-->DataGridView1.Columns("Col173").HeaderText = "Faculty"
            DataGridView1.Columns("Col174").HeaderText = "Level"
            DataGridView1.Columns("Footers").HeaderText = "Info"
            DataGridView1.Columns("Footers").Width = 160
            DataGridView1.Tag = "summary"
        Catch ex As Exception
            MsgBox("Cannot get broadsheets data" & vbCrLf & ex.Message)
        End Try


    End Sub

    Private Sub ButtonResultList_Click(sender As Object, e As EventArgs)
        ' objExcelFile.createExcelFile_NPOI(My.Application.Info.DirectoryPath & "\GeneratedResult.xlsx")
        'objExcelFile.modifyExcelFile_npoi(My.Application.Info.DirectoryPath & "\GeneratedResult.xlsx")
        'Label6.Text = "Done: check GeneratedResult.xlsx"
        'MainForm.status("Done: generated GeneratedResult.xlsx")
    End Sub



    Sub showButtons(ButtonName As String, enableOnly As Boolean)
        Select Case ButtonName
            Case "Process"
                If enableOnly Then Me.ButtonShowAllBroadsheet.Enabled = True Else Me.ButtonShowAllBroadsheet.Visible = True

        End Select
    End Sub
    Sub hideButtons(ButtonName As String, disableOnly As Boolean)
        Select Case ButtonName
            Case "Process"
                If disableOnly Then Me.ButtonShowAllBroadsheet.Enabled = False Else Me.ButtonShowAllBroadsheet.Visible = False

        End Select
    End Sub

    Private Sub ButtonUpload_Click(sender As Object, e As EventArgs)
        DataGridView1.AllowUserToAddRows = True
        DataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken
    End Sub


    Function getCoursesList() As String()
        Dim str As New List(Of String)
        str.Add("PRE571")
        str.Add("CPE571")
        str.Add("CPE591")

        Return str.ToArray
    End Function

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

        dictDepts = combolistDict(STR_SQL_ALL_DEPARTMENTS_COMBO, "dept_id", "dept_name")

        dictSessions = combolistDict(STR_SQL_ALL_SESSIONS_COMBO, "session_id", "session_id")

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

    Private Sub ButtonAdjustTemplate_Click(sender As Object, e As EventArgs) Handles ButtonAdjustTemplate.Click

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

            showBroadsheet(String.Format(STR_SQL_ALL_BROADSHEET_WHERE_SESSION_DEPT_LEVEL, txtSession, txtDept, txtlevel))

        Catch ex As Exception
            MsgBox("Cannot get broadsheets data" & vbCrLf & ex.Message)
        End Try


    End Sub
    Sub showBroadsheet(strSQL As String, Optional strTimestamp As String = Nothing)

        Dim dictColHeaders As New Dictionary(Of String, String)
        Dim dtHeaders As DataSet
        Dim numColNames As Integer

        'Dim tmpCol As DataColumn
        dt = mappDB.GetDataWhere(strSQL).Tables(0)
        If strTimestamp Is Nothing Then strTimestamp = dt.Rows(0).Item("ColNames").ToString
        dtHeaders = mappDB.GetDataWhere(String.Format(STR_SQL_ALL_BROADSHEETS_WHERE_COLNAMES, strTimestamp))
        'col names are now at row (0)

        'dt.Rows.InsertAt(dt.Rows(0), 0)     'Add new row at top for headers

        Dim clCount As Integer = dt.Columns.Count - 1        'todo: cross thread
        Dim j As Integer = 0
        For Each col In dt.Columns
            'If col.index >= numColNames Then Exit For
            ' handle these specially( (Col171='{0}') And (Col172='{1}') And (Col174='{2}'))
            'dSFtomDB.Tables(0).Rows(0).Item("Col171") = objBroadsheet.Session ' ComboBoxSessions.SelectedText
            'dSFtomDB.Tables(0).Rows(0).Item("Col172") = objBroadsheet.DepartmentName ' ComboBoxDepartments.SelectedText
            'dSFtomDB.Tables(0).Rows(0).Item("Col174") = objBroadsheet.Level   'todo getLevel(comboboxlevel)
            If col.Columnname = "Col171" Then
                'leave name intact or change to session
            ElseIf col.Columnname = "Col172" Then
                'leave name intact or change to department
            ElseIf col.Columnname = "Col174" Then
                'leave name intact or change to level
            ElseIf col.Columnname = "Col173" Then
                'leave name intact or change to level
            ElseIf isdbnull(dtHeaders.Tables(0).Rows(0).Item(col.ordinal)) Then
                'avoid nasty errors, leave name intact
            ElseIf (dtHeaders.Tables(0).Rows(0).Item(col.ordinal) = "") Then
                'avoid nasty errors, leave name intact
            Else
                'col.HeaderText = dtHeaders.Tables(0).Rows(0).Item(col.index) 'get name from first row
                col.Columnname = dtHeaders.Tables(0).Rows(0).Item(col.ordinal)   'get name from first row where it as saved

            End If
            dt.AcceptChanges()
            objBroadsheet.progress = j / clCount * 100
            objBroadsheet.progressStr = "Processing : " & col.Columnname
        Next
        dt.AcceptChanges()


    End Sub


    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        If DataGridView1.SelectedRows Is Nothing Or DataGridView1.Columns.Contains("Col150") Then
            Exit Sub
        End If 'todo: change col171 to session, col172 to dept etc in db table & across code for easy maintainance
        Dim strSQL As String = "DELETE * FROM broadsheets_all WHERE Col171='{0}' AND Col172='{1}' AND Col174='{2}' AND  ColNames='{3}'"
        Dim dSession As String = DataGridView1.SelectedRows(0).Cells("Col171").Value.ToString
        Dim dDept As String = DataGridView1.SelectedRows(0).Cells("Col172").Value.ToString
        Dim dLevel As String = DataGridView1.SelectedRows(0).Cells("Col174").Value.ToString
        Dim strTimeStamp As String = DataGridView1.SelectedRows(0).Cells("ColNames").Value.ToString

        If MessageBox.Show("Are you sure you want to delete the selected broadsheet?", "Delete", MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
            LoginForm1.Close()

            If LoginForm1.ShowDialog() = DialogResult.OK Then
                'todo if loginForm.isSignedInAsAdmin then
                If mappDB.doQuery(String.Format(strSQL, dSession, dDept, dLevel, strTimeStamp)) Then
                    ButtonShowAllBroadsheet.PerformClick()
                    MsgBox("Broadsheet deleted sucessfully")
                Else
                    MsgBox("Something went wrong")
                End If

            End If
        End If
    End Sub

    Private Sub BgWProcess_DoWork(sender As Object, e As DoWorkEventArgs) Handles BgWProcess.DoWork

        showBroadsheet(String.Format(STR_SQL_ALL_BROADSHEET_WHERE_SESSION_DEPT_LEVEL, txtSession, txtDept, txtlevel, e.Argument), e.Argument)

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
        Me.ProgressBarBS.Value = 100
        Me.LabelProgress.Text = "Done"
    End Sub

    Private Sub ButtonShowDetails_Click(sender As Object, e As EventArgs) Handles ButtonShowDetails.Click
        If Not DataGridView1.Tag = "detail" Then 'And
            'DataGridView1.Columns.Contains("Col172") Then
            If IsDBNull(DataGridView1.SelectedRows(0).Cells("Col171").Value) Or
                    IsDBNull(DataGridView1.SelectedRows(0).Cells("Col171").Value) Or
                    IsDBNull(DataGridView1.SelectedRows(0).Cells("Col171").Value) Then
                MsgBox("Session, leve or deparment is missing")
                Exit Sub
            End If
            txtlevel = DataGridView1.SelectedRows(0).Cells("Col174").Value
            txtSession = DataGridView1.SelectedRows(0).Cells("Col171").Value
            txtDept = DataGridView1.SelectedRows(0).Cells("Col172").Value
            TimerBS.Start()
            BgWProcess.RunWorkerAsync(DataGridView1.SelectedRows(0).Cells("ColNames").Value)
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