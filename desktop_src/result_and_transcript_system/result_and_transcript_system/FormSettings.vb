Imports System.ComponentModel

Public Class FormSettings

    Private Sub FormCourseAdviser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = RGBColors.colorBlack2
    End Sub



    Private Sub ButtonApply_Click(sender As Object, e As EventArgs) Handles ButtonApply.Click
        DataGridViewCoursesOrder.EndEdit()
        DataGridViewCoursesOrder.Update()

    End Sub





    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub bgwLoad_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgwLoad.DoWork
        DataGridViewCoursesOrder.DataSource = mappDB.GetDataWhere(String.Format(STR_SQL_ALL_COURSES_ORDER_NO_CRITERIA)).Tables(0).DefaultView
        'dictCoursesOrderSS = combolistDict(String.Format(STR_SQL_ALL_COURSES_ORDER, session_idr, course_dept_idr), "SS" & TextBoxLevel.Text & "L", "SS" & TextBoxLevel.Text & "L")

        'dictDepts = combolistDict(STR_SQL_ALL_DEPARTMENTS_COMBO, "dept_id", "dept_name")
        'dictSessions = combolistDict(STR_SQL_ALL_SESSIONS_COMBO, "session_id", "session_id")

        'dictCourses = combolistDict(String.Format(STR_SQL_ALL_COURSES_ORDER, session_idr, course_dept_idr), "all_courses_1", "all_courses_1")
        ''dictCoursesOrderFS = combolistDict(String.Format(STR_SQL_ALL_COURSES_ORDER, session_idr, course_dept_idr), "FS" & TextBoxLevel.Text, "FS" & TextBoxLevel.Text)
        'dictCoursesOrderSS = combolistDict(String.Format(STR_SQL_ALL_COURSES_ORDER, session_idr, course_dept_idr), "SS" & TextBoxLevel.Text & "L", "SS" & TextBoxLevel.Text & "L")
        'dictAllCourses = combolistDict(STR_SQL_ALL_COURSES, "course_code", "course_code")

    End Sub

    Private Sub bgwLoad_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgwLoad.RunWorkerCompleted

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
    Private Sub ButtonMoveUp_Click(sender As Object, e As EventArgs)
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
    Private Sub ButtonMoveDown_Click(sender As Object, e As EventArgs)
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

    Private Sub ButtonRefereshListFirst_Click(sender As Object, e As EventArgs)
        bgwLoad.RunWorkerAsync()
    End Sub

    Private Sub ButtonRemoveCourses_Click(sender As Object, e As EventArgs)
        Dim indx As Integer = 0
        indx = ListBoxCoursesOrder.SelectedIndex
        If indx >= 0 Then
            ListBoxCoursesOrder.Items.RemoveAt(indx)
        End If
    End Sub

    Private Sub ButtonAddCourse_Click(sender As Object, e As EventArgs)
        ListBoxCoursesOrder.Items.Add(ComboBoxCourses.SelectedItem)
    End Sub
End Class
