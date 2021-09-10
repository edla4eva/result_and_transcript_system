Public Class FormGenerateBroadsheet
    Private Sub TextBoxDepartment_TextChanged(sender As Object, e As EventArgs) Handles TextBoxDepartment.TextChanged

    End Sub

    Private Sub FormGenerateBroadsheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = RGBColors.colorBlack2


    End Sub

    Private Sub ButtonProcessBroadsheet_Click(sender As Object, e As EventArgs) Handles ButtonProcessBroadsheet.Click
        objBroadsheet.broadsheetFileName = My.Application.Info.DirectoryPath & "\templates\broadsheet.xltx"
        objBroadsheet.broadsheetSemester = 2


        objBroadsheet.generateFormulaCO()

        'objExcelFile.excelFileName = PROG_DIRECTORY & "\templates\broadsheet.xltx"
        '##-----METHOD One Interop
        'processBroadsheetExcelInteropMethod()


        '##-----Method TWO - file
        'processBroadsheetFileMethod()

    End Sub
    Private Sub processBroadsheetExcelInteropMethod()
        Dim tmpDS As DataSet
        Dim dSession As String = "2018/2019"
        Dim dLevel As Integer = 300
        Dim dCourseCode As String = "CPE375"
        Dim strapprovedCourses As String
        Dim arrayapprovedCourses() As String
        tmpDS = mappDB.GetDataWhere(String.Format(STR_SQL_ALL_BROADSHEET, dSession, dLevel))
        For i = 0 To tmpDS.Tables(0).Rows.Count - 1

        Next
        '#Get couses approved for session
        'public STR_SQL_APPROVED_COURSES = "SELECT approved_courses_300 from sessions WHERE session_id='{0}';
        strapprovedCourses = mappDB.GetRecordWhere(String.Format(STR_SQL_APPROVED_COURSES, dSession))
        arrayapprovedCourses = strapprovedCourses.Split(";")
        For j = 0 To arrayapprovedCourses.Count - 1
            tmpDS.Tables(0).Columns.Add(arrayapprovedCourses(j))
        Next

        DataGridView1.DataSource = tmpDS.Tables(0).DefaultView
        '#use dlookup to add specific results to col
        'string.Format(str_dlookup_sql


        objBroadsheet.updateExcelBroadSheetInterop(objBroadsheet.broadsheetFileName, tmpDS)
        'end if
    End Sub
    Private Sub processBroadsheetFileMethod()
        Try

            '
            Dim sn As Integer = 7 'todo
            Dim courseResult As Integer() = {}

            objExcelFile.excelFileName = PROG_DIRECTORY & "\samples\broadsheet.xlsx"
            If TextBoxTemplateFileName.Text.Contains(".xls") Then
                'TODO: warn msgbox
                objExcelFile.excelFileName = TextBoxTemplateFileName.Text
            End If
            Dim myDataSet As DataSet ' = objExcelFile.readResultFile()
            myDataSet = objExcelFile.readBroadSheetTemplateFile()

            'Todo Add results----------------
            ' courseResult = mappDB.getCourseResults(session, courseCode)
            courseResult(0) = 99    'test
            courseResult(1) = 99    'test
            myDataSet.Tables(0).Rows(0 + sn).Item(1) = courseResult(0)
            myDataSet.Tables(0).Rows(1 + sn).Item(1) = courseResult(1)
            'add rows
            'dr = dt.NewRow()
            'dr("SN") = 1
            'dr("MATNO") = "ENG0607721"
            'dr("CA") = 20
            'dr("Score") = 60
            'dr("Total") = 80
            'dr("Name") = "Firstname SURNAME"
            'dt.Rows.Add(dr)
            ''---------------------------------------------------------

            DataGridView1.DataSource = myDataSet.Tables(0).DefaultView
            DataGridView1.Refresh()
            MsgBox("done updating")
            myDataSet.Clear()
            myDataSet = Nothing
            hideButtons("Process", True)
        Catch ex As Exception
            MsgBox("Cannot create Excel File Object" & vbCrLf & ex.Message)
        End Try

    End Sub

    Private Sub ButtonResultList_Click(sender As Object, e As EventArgs) Handles ButtonResultList.Click
        objExcelFile.createExcelFile(My.Application.Info.DirectoryPath & "\GeneratedResult.xlsx")
        objExcelFile.modifyExcelFile(My.Application.Info.DirectoryPath & "\GeneratedResult.xlsx")
        Label6.Text = "Done: check GeneratedResult.xlsx"
        MainForm.status("Done: generated GeneratedResult.xlsx")
    End Sub

    Private Sub SelectBroadsheetTemplate_Click(sender As Object, e As EventArgs) Handles SelectBroadsheetTemplate.Click
        Dim FileOpenDialogBroadsheet As New OpenFileDialog()
        Dim resultFileName As String = ""

        If Not FileOpenDialogBroadsheet.ShowDialog = DialogResult.Cancel Then
            resultFileName = FileOpenDialogBroadsheet.FileName()
        End If
        Me.TextBoxTemplateFileName.Text = resultFileName
        objExcelFile.excelFileName = resultFileName

        showButtons("Process", False)
    End Sub

    Sub showButtons(ButtonName As String, enableOnly As Boolean)
        Select Case ButtonName
            Case "Process"
                If enableOnly Then Me.ButtonProcessBroadsheet.Enabled = True Else Me.ButtonProcessBroadsheet.Visible = True

        End Select
    End Sub
    Sub hideButtons(ButtonName As String, disableOnly As Boolean)
        Select Case ButtonName
            Case "Process"
                If disableOnly Then Me.ButtonProcessBroadsheet.Enabled = False Else Me.ButtonProcessBroadsheet.Visible = False

        End Select
    End Sub

    Private Sub ButtonUpload_Click(sender As Object, e As EventArgs) Handles ButtonUpload.Click
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

    Private Sub ButtonAdjustTemplate_Click(sender As Object, e As EventArgs) Handles ButtonAdjustTemplate.Click
        If PanelModify.Visible = False Then
            PanelModify.Visible = True
        Else
            PanelModify.Visible = False
        End If
    End Sub

    Private Sub FormGenerateBroadsheet_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        On Error Resume Next

        'mappDB.combolist()
        combolist(STR_SQL_ALL_DEPARTMENTS_COMBO, "dept_id", "dept_name", ComboBoxDepartments)
        combolist(STR_SQL_ALL_SESSIONS_COMBO, "session", "session", ComboBoxDepartments)
    End Sub
End Class