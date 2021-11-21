Imports System.ComponentModel

Public Class FormViewBroadsheets
    Private Sub TextBoxDepartment_TextChanged(sender As Object, e As EventArgs) Handles TextBoxDepartment.TextChanged

    End Sub

    Private Sub FormViewBroadsheets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = RGBColors.colorBlack2
        Me.BackColor = RGBColors.colorBlack2
        Me.DataGridView1.BackgroundColor = RGBColors.colorBlack2
        Me.DataGridView1.RowsDefaultCellStyle.BackColor = RGBColors.colorSilver
        Me.DataGridView1.RowsDefaultCellStyle.ForeColor = RGBColors.colorBlack
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



            DataGridView1.DataSource = dt.DefaultView



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
        bgwLoad.RunWorkerAsync()

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


        ComboBoxSessions.Items.Clear()
        For Each key In dictSessions.Keys
            ComboBoxSessions.Items.Add(dictSessions(key))
        Next

    End Sub

    Private Sub ButtonAdjustTemplate_Click(sender As Object, e As EventArgs) Handles ButtonAdjustTemplate.Click

    End Sub

    Private Sub ButtonSearchBroadheet_Click(sender As Object, e As EventArgs) Handles ButtonSearchBroadheet.Click
        Try
            Dim strSQL As String = STR_SQL_ALL_BROADSHEET
            Dim dt As New DataTable
            Dim dictColHeaders As New Dictionary(Of String, String)
            Dim strColNames As String
            Dim strArrColNames As String()
            'Dim tmpCol As DataColumn
            dt = mappDB.GetDataWhere(strSQL).Tables(0)
            strColNames = dt.Rows(0).Item("ColNames").ToString
            strArrColNames = strColNames.Split(",")
            DataGridView1.DataSource = dt.DefaultView
            For Each col In dt.Columns
                'If strArrColNames(col.ordinal) <> "" Then col.columnName = strArrColNames(col.ordinal)
                dt.Rows(0).Item(col.Ordinal) = strArrColNames(col.ordinal)
            Next



            DataGridView1.DataSource = dt.DefaultView



        Catch ex As Exception
            MsgBox("Cannot get broadsheets data" & vbCrLf & ex.Message)
        End Try


    End Sub
End Class