Imports System.ComponentModel

Public Class FormViewBroadsheets
    Dim txtlevel, txtSession, txtDept As String

    Private Sub TextBoxDepartment_TextChanged(sender As Object, e As EventArgs) Handles TextBoxDepartment.TextChanged

    End Sub

    Private Sub FormViewBroadsheets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = RGBColors.colorBackground
        Me.BackColor = RGBColors.colorBackground
        Me.DataGridView1.BackgroundColor = RGBColors.colorBackground
        Me.DataGridView1.RowsDefaultCellStyle.BackColor = RGBColors.colorForeground
        Me.DataGridView1.RowsDefaultCellStyle.ForeColor = RGBColors.colorBackground
        On Error Resume Next



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
    Sub showBroadsheet(strSQL As String)

        Dim dt As New DataTable
        Dim dictColHeaders As New Dictionary(Of String, String)
        Dim strColNames As String
        Dim strArrColNames As String()
        Dim numColNames As Integer
        'Dim tmpCol As DataColumn
        dt = mappDB.GetDataWhere(strSQL).Tables(0)
        strColNames = dt.Rows(0).Item("ColNames").ToString
        strArrColNames = strColNames.Split(",")
        numColNames = strArrColNames.Length
        DataGridView1.DataSource = dt.DefaultView

        'dt.Rows.InsertAt(dt.Rows(0), 0)     'Add new row at top for headers


        For Each col In DataGridView1.Columns
            If col.index >= numColNames Then Exit For
            col.HeaderText = strArrColNames(col.index)
            col.name = strArrColNames(col.index)

            If col.name.contains("ColUNIQUE") Then col.visible = False
            If col.name.contains("Repeat") Then col.width = 120
            If dictAllCourseCodeKeyAndCourseLevelVal.ContainsKey(col.name) Then
                If Not dictAllCourseCodeKeyAndCourseLevelVal(col.name) = txtlevel Then
                    col.visible = False
                Else
                    col.width = 65
                End If
            End If
        Next
        DataGridView1.Columns(0).Width = 25   's/N
        DataGridView1.Columns(1).Width = 100   'Mat
        DataGridView1.Columns(2).Width = 150   'Name
        DataGridView1.Columns(3).Visible = False   'hide
        DataGridView1.Columns(4).Visible = False   'hide
        DataGridView1.Columns(5).Visible = False   'hide

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        If DataGridView1.SelectedRows Is Nothing Or DataGridView1.Columns.Contains("Col150") Then
            Exit Sub
        End If
        Dim strSQL As String = "DELETE * FROM bradsheets_all WHERE Col171='{0}' AND Col172='{1}' AND Col174='{1}'"
        Dim dSession As String = DataGridView1.SelectedRows(0).Cells("Session").Value.ToString
        Dim dDept As String = DataGridView1.SelectedRows(0).Cells("Col172").Value.ToString
        Dim dLevel As String = DataGridView1.SelectedRows(0).Cells("Col174").Value.ToString

        If MessageBox.Show("Are you sure you want to delete the selected broadsheet?", "Delete", MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
            LoginForm1.Close()

            If LoginForm1.ShowDialog() = DialogResult.OK Then
                mappDB.doQuery(String.Format(strSQL, dSession, dDept, dLevel))
                ButtonShowAllBroadsheet.PerformClick()
                MsgBox("Broadsheet deleted sucessfully")
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        'Dim myDataSet As DataSet
        If e.RowIndex >= 0 And
            Not DataGridView1.Columns.Contains("Col150") Then 'And
            'DataGridView1.Columns.Contains("Col172") Then
            txtlevel = DataGridView1.Rows(e.RowIndex).Cells("Col174").Value
            txtSession = DataGridView1.Rows(e.RowIndex).Cells("Col171").Value
            txtDept = DataGridView1.Rows(e.RowIndex).Cells("Col172").Value


            showBroadsheet(String.Format(STR_SQL_ALL_BROADSHEET_WHERE_SESSION_DEPT_LEVEL, txtSession, txtDept, txtlevel))


        End If
    End Sub

    Private Sub ButtonRework_Click(sender As Object, e As EventArgs) Handles ButtonRework.Click

        MainForm.ChangeMenu("GenerateBroadsheet")
        FormGenerateBroadsheet.importBroadsheetData(DataGridView1.DataSource)

    End Sub
End Class