Imports System.ComponentModel

Public Class FormSettings
    Dim Session_idr As String = "2018/2019"
    Dim course_dept_idr As Integer = 1
    Dim course_level As Integer = 100
    Dim ds As New DataSet
    Private Sub FormCourseAdviser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refreshcolors(Me, Me.Controls, True)
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

        getCoursesOrderIntoDictionaries(Session_idr, course_dept_idr, course_level)
        'dictCoursesOrderFS = combolistDict(String.Format(STR_SQL_ALL_COURSES_ORDER, Session_idr, course_dept_idr), "FS" & course_level & "L", "FS" & course_level & "L")
        'dictCoursesOrderSS = combolistDict(String.Format(STR_SQL_ALL_COURSES_ORDER, Session_idr, course_dept_idr), "SS" & course_level & "L", "SS" & course_level & "L")

        getDeptSessionsIntoDictionaries()
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
        If RadioButton1.Checked Then
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
        Else
            indx = ListBoxCoursesOrderSS.SelectedIndex
            itm = ListBoxCoursesOrderSS.SelectedItem
            If indx >= 0 Then
                ListBoxCoursesOrderSS.Items.RemoveAt(indx)
                If indx - 1 >= 0 And Not itm = Nothing Then
                    ListBoxCoursesOrderSS.Items.Insert(indx - 1, itm)
                    ListBoxCoursesOrderSS.SelectedIndex = indx - 1
                Else
                    ListBoxCoursesOrderSS.Items.Insert(0, itm)
                    ListBoxCoursesOrderSS.SelectedIndex = 0
                End If

            End If

        End If


    End Sub
    Private Sub ButtonMoveDown_Click(sender As Object, e As EventArgs) Handles ButtonMoveDown.Click
        Dim indx As Integer = 0
        Dim itm As New Object
        If RadioButton1.Checked Then
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
        Else
            indx = ListBoxCoursesOrderSS.SelectedIndex
            itm = ListBoxCoursesOrderSS.SelectedItem
            If indx >= 0 Then

                ListBoxCoursesOrderSS.Items.RemoveAt(indx)
                If indx + 1 <= ListBoxCoursesOrderSS.Items.Count - 1 And Not itm = Nothing Then
                    ListBoxCoursesOrderSS.Items.Insert(indx + 1, itm)
                    ListBoxCoursesOrderSS.SelectedIndex = indx + 1
                Else
                    ListBoxCoursesOrderSS.Items.Insert(0, itm)
                    ListBoxCoursesOrderSS.SelectedIndex = 0
                End If
            End If
        End If



    End Sub

    Private Sub ButtonRefereshListFirst_Click(sender As Object, e As EventArgs) Handles ButtonRefereshListFirst.Click
        'bgwLoad.RunWorkerAsync()
        'todo: save
        MsgBox("This feature in not supported in the free version. Upgrade to accesss")
    End Sub

    Private Sub ButtonRemoveCourses_Click(sender As Object, e As EventArgs) Handles ButtonRemoveCourses.Click
        Dim indx As Integer = 0
        If RadioButton1.Checked Then
            indx = ListBoxCoursesOrder.SelectedIndex
            If indx >= 0 Then
                ListBoxCoursesOrder.Items.RemoveAt(indx)
            End If
        Else
            indx = ListBoxCoursesOrderSS.SelectedIndex
            If indx >= 0 Then
                ListBoxCoursesOrderSS.Items.RemoveAt(indx)
            End If
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


    Private Sub ComboBoxColor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxColor.SelectedIndexChanged
        If ComboBoxColor.SelectedItem = "Select..." Then
            If ColorDialog1.ShowDialog = DialogResult.OK Then
                ComboBoxColor.Items.Add(ColorDialog1.Color.ToArgb.ToString)
                ComboBoxColor.Text = (ColorDialog1.Color.ToArgb.ToString)
            Else
                ComboBoxColor.ForeColor = Color.FromArgb(ComboBoxColor.SelectedItem)
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
        If My.Settings.trial > 0 Then
            MsgBox("This feature in not supported in the free version. You can only save twice. Upgrade to accesss")
            My.Settings.trial = My.Settings.trial - 1
            My.Settings.Save()
            Dim ds As New DataSet
            ds = mappDB.GetDataWhere(STR_COURSES_ORDER_GENERAL_ALL)
            DataGridViewCoursesOrder.DataSource = ds.Tables(0).DefaultView
        Else
            MsgBox("This feature in not supported in the free version. You have exhaused your trial. Upgrade to accesss")

        End If


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
        MsgBox("This feature in not supported in the free version. Upgrade to accesss")

        'Dim strSql As String = "INSERT INTO department (dpt_id,dept_name) VALUES ({0},'{1}')"
        'Dim maxID As Long = mappDB.getMaxID("SELECT dept_id FROM departments") + 1
        'mappDB.doQuery(String.Format(strSql, maxID, TextBoxDepartment.Text))
        'ComboBoxDepartments.Items.Add(TextBoxDepartment.Text)
    End Sub



    Private Sub ButtonAddSession_Click(sender As Object, e As EventArgs) Handles ButtonAddSession.Click
        MsgBox("This feature in not supported in the free version. Upgrade to accesss")

        'Dim strSql As String = "INSERT INTO sessions (session_id,session_name) VALUES ('{0}','{1}')"

        'mappDB.doQuery(String.Format(strSql, TextBoxSession.Text, TextBoxSession.Text))
        'ComboBoxSessions.Items.Add(TextBoxSession)
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonDarkTheme.CheckedChanged
        'NOT Activated
        'If LightTheme.Checked Then
        '    RGBColors.colorBackground = RGBColors.colorWhite
        '    RGBColors.colorForeground = RGBColors.colorBlack2
        '    refreshcolors(Me, Me.Controls, False)
        'Else
        '    RGBColors.colorBackground = RGBColors.colorBlack2
        '    RGBColors.colorForeground = RGBColors.colorSilver
        '    refreshcolors(Me, Me.Controls, True)
        'End If

    End Sub

    Private Sub ComboBoxFonts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxFonts.SelectedIndexChanged
        If ComboBoxFonts.SelectedItem = "Select..." Then
            If FontDialog1.ShowDialog = DialogResult.OK Then
                ComboBoxFonts.Items.Add(FontDialog1.Font.ToHfont.ToString)
                ComboBoxFonts.Text = (FontDialog1.Font.ToHfont.ToString)
            End If
        Else
            'objRTPS.getFont = Font.FromLogFont(ComboBoxFonts.SelectedItem)
            'ComboBoxFonts.Font = Font.FromHfont(CType(ComboBoxFonts.SelectedItem, System.IntPtr))
        End If
    End Sub


End Class
