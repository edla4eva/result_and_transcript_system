Imports System.ComponentModel

Public Class FormSettings
    Dim Session_idr As String = "2018/2019"
    Dim course_dept_idr As Integer = 1
    Dim course_level As Integer = 100
    Dim ds As New DataSet
    Private Sub FormCourseAdviser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.BackColor = RGBColors.colorBlack2
        Me.DataGridViewCoursesOrder.BackgroundColor = RGBColors.colorBlack2
        Me.DataGridViewCoursesOrder.RowsDefaultCellStyle.BackColor = RGBColors.colorSilver
        Me.DataGridViewCoursesOrder.RowsDefaultCellStyle.ForeColor = RGBColors.colorBlack
    End Sub



    Private Sub ButtonApply_Click(sender As Object, e As EventArgs) Handles ButtonApply.Click
        DataGridViewCoursesOrder.EndEdit()
        DataGridViewCoursesOrder.Update()
        'Dim fntSize As Integer = Integer.TryParse(TextBoxFont.Text)
        objRTPS.saveSettings(11)
    End Sub





    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub bgwLoad_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgwLoad.DoWork
        ds = mappDB.GetDataWhere(String.Format(STR_SQL_ALL_COURSES_ORDER_NO_CRITERIA))
        dictCoursesOrderSS = combolistDict(String.Format(STR_SQL_ALL_COURSES_ORDER, Session_idr, course_dept_idr), "SS" & course_level & "L", "SS" & course_level & "L")

        dictDepts = combolistDict(STR_SQL_ALL_DEPARTMENTS_COMBO, "dept_id", "dept_name")
        dictSessions = combolistDict(STR_SQL_ALL_SESSIONS_COMBO, "session_id", "session_id")

        dictCourses = combolistDict(String.Format(STR_SQL_ALL_COURSES_ORDER, Session_idr, course_dept_idr), "all_courses_1", "all_courses_1")
        'dictCoursesOrderFS = combolistDict(String.Format(STR_SQL_ALL_COURSES_ORDER, session_idr, course_dept_idr), "FS" & TextBoxLevel.Text, "FS" & TextBoxLevel.Text)
        dictCoursesOrderSS = combolistDict(String.Format(STR_SQL_ALL_COURSES_ORDER, Session_idr, course_dept_idr), "SS" & course_level & "L", "SS" & course_level & "L")
        dictAllCourses = combolistDict(STR_SQL_ALL_COURSES, "course_code", "course_code")

    End Sub

    Private Sub bgwLoad_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgwLoad.RunWorkerCompleted
        DataGridViewCoursesOrder.DataSource = ds.Tables(0).DefaultView

        'for dictonaries
        ComboBoxCourses.Items.Clear()
        For Each key In dictAllCourses.Keys
            ComboBoxCourses.Items.Add(dictAllCourses(key))
        Next

        ListBoxCoursesOrder.Items.Clear()
        For Each key In dictCourses.Keys
            ListBoxCoursesOrder.Items.Add(dictCourses(key))
        Next

        ListBoxCoursesOrderSS.Items.Clear()
        For Each key In dictCoursesOrderSS.Keys
            ListBoxCoursesOrderSS.Items.Add(dictCoursesOrderSS(key))
        Next

        ComboBoxDepartments.Items.Clear()
        For Each key In dictDepts.Keys
            ComboBoxDepartments.Items.Add(dictDepts(key))
        Next
        TextBoxDepartment.Text = ComboBoxDepartments.Items(0).ToString


        ComboBoxSessions.Items.Clear()
        For Each key In dictSessions.Keys
            ComboBoxSessions.Items.Add(dictSessions(key))
        Next
        TextBoxSession.Text = ComboBoxSessions.Items(0).ToString
    End Sub
    Private Sub ButtonMoveUp_Click(sender As Object, e As EventArgs) Handles ButtonMoveUp.Click
        Dim indx As Integer = 0
        Dim itm As New Object
        indx = ListBoxCoursesOrder.SelectedIndex
        itm = ListBoxCoursesOrder.SelectedItem
        If indx >= 0 Then
            ListBoxCoursesOrder.Items.RemoveAt(indx)
            If indx - 1 >= 0 And Not itm = Nothing Then
                ListBoxCoursesOrder.Items.Insert(indx - 1, itm)
                ListBoxCoursesOrder.SelectedIndex = indx - 1
            Else
                ListBoxCoursesOrder.Items.Insert(0, itm)
                ListBoxCoursesOrder.SelectedIndex = 0
            End If

        End If

    End Sub
    Private Sub ButtonMoveDown_Click(sender As Object, e As EventArgs) Handles ButtonMoveDown.Click
        Dim indx As Integer = 0
        Dim itm As New Object
        indx = ListBoxCoursesOrder.SelectedIndex
        itm = ListBoxCoursesOrder.SelectedItem
        If indx >= 0 Then

            ListBoxCoursesOrder.Items.RemoveAt(indx)
            If indx + 1 <= ListBoxCoursesOrder.Items.Count - 1 And Not itm = Nothing Then
                ListBoxCoursesOrder.Items.Insert(indx + 1, itm)
                ListBoxCoursesOrder.SelectedIndex = indx + 1
            Else
                ListBoxCoursesOrder.Items.Insert(0, itm)
                ListBoxCoursesOrder.SelectedIndex = 0
            End If
        End If


    End Sub

    Private Sub ButtonRefereshListFirst_Click(sender As Object, e As EventArgs) Handles ButtonRefereshListFirst.Click
        bgwLoad.RunWorkerAsync()
    End Sub

    Private Sub ButtonRemoveCourses_Click(sender As Object, e As EventArgs) Handles ButtonRemoveCourses.Click
        Dim indx As Integer = 0
        indx = ListBoxCoursesOrder.SelectedIndex
        If indx >= 0 Then
            ListBoxCoursesOrder.Items.RemoveAt(indx)
        End If
    End Sub

    Private Sub ButtonAddCourse_Click(sender As Object, e As EventArgs) Handles ButtonAddCourse.Click
        If ComboBoxCourses.SelectedIndex >= 0 Then
            If RadioButton1.Checked Then
                ListBoxCoursesOrder.Items.Add(ComboBoxCourses.SelectedItem)
            Else
                ListBoxCoursesOrderSS.Items.Add(ComboBoxCourses.SelectedItem)
            End If

        End If

    End Sub

    Private Sub FormSettings_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MainForm.doCloseForm()
    End Sub



    Private Sub ComboBoxCoor_DropDown(sender As Object, e As EventArgs) Handles ComboBoxColor.DropDown
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            ComboBoxColor.Text = ColorDialog1.Color.ToArgb
            ComboBoxColor.Items.Add(ColorDialog1.Color.ToArgb)
        End If
    End Sub



    Private Sub ComboBoxFonts_DropDown(sender As Object, e As EventArgs) Handles ComboBoxFonts.DropDown

    End Sub

    Private Sub ComboBoxColor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxColor.SelectedIndexChanged
        If ComboBoxColor.SelectedText = "Select..." Then
            If FontDialog1.ShowDialog = DialogResult.OK Then
                ComboBoxFonts.Items.Add(FontDialog1.Font.ToString)
                ComboBoxFonts.Text = (FontDialog1.Font.ToString)
            End If
        End If

    End Sub

    Private Sub DataGridViewCoursesOrder_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewCoursesOrder.CellContentClick

    End Sub

    Private Sub ComboBoxResolution_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxResolution.SelectedIndexChanged
        '1360 x 768
        '1280 x 768
        '1280 x 720 (Recommended)
        '1280 x 600
        '1024 x 600 (Not recommended)
        If ComboBoxResolution.SelectedText.Contains("1280 x 720") Then
            'objRTPS.tmpSettings.resolution=''
        ElseIf ComboBoxResolution.SelectedText.Contains("1280 x 720") Then

        End If
    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        Dim ds As New DataSet
        ds = mappDB.GetDataWhere(STR_COURSES_ORDER_GENERAL_ALL)
        DataGridViewCoursesOrder.DataSource = ds.Tables(0).DefaultView
    End Sub

    Private Sub ComboBoxDepartments_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxDepartments.SelectedIndexChanged
        course_dept_idr = mappDB.getDeptID(ComboBoxDepartments.Text)
        bgwLoad.RunWorkerAsync()
    End Sub

    Private Sub ComboBoxLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxLevel.SelectedIndexChanged
        Dim tmplevel As String = "100"

        If tmplevel = "Yr.1" Then
            tmplevel = "100"
        ElseIf tmplevel = "Yr.2" Then
            tmplevel = "200"
        End If
        course_level = CInt(tmplevel)
    End Sub

    Private Sub ButtonAddDept_Click(sender As Object, e As EventArgs) Handles ButtonAddDept.Click
        Dim strSql As String = "INSERT INTO department (dpt_id,dept_name) VALUES ({0},'{1}')"
        Dim maxID As Long = mappDB.getMaxID("SELECT dept_id FROM departments") + 1
        mappDB.doQuery(String.Format(strSql, maxID, TextBoxDepartment.Text))
        ComboBoxDepartments.Items.Add(TextBoxDepartment.Text)
    End Sub



    Private Sub ButtonAddSession_Click(sender As Object, e As EventArgs) Handles ButtonAddSession.Click
        Dim strSql As String = "INSERT INTO sessions (session_id,session_name) VALUES ({0},'{1}')"

        mappDB.doQuery(String.Format(strSql, TextBoxSession.Text, TextBoxSession.Text))
        ComboBoxSessions.Items.Add(TextBoxSession)
    End Sub
End Class
