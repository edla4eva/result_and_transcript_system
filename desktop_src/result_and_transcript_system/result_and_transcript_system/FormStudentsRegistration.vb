Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class FormStudentsRegistration

    Dim strSQL As String
    Dim strConnectionString As String
    Dim ref As Integer

    Dim tmpDS As DataSet

    Private Sub FormRooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized


    End Sub
    Private Sub FormStudentsRegistration_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        On Error Resume Next
        txtStudentMATNO.Text = ""
        BgWProcess.RunWorkerAsync(1)  'runs GetData()



    End Sub

    Public Sub GetData()
        Try
            mappDB.Dept = 1 'TODO
            tmpDS = mappDB.GetDataWhere(String.Format(STR_SQL_ALL_STUDENTS_IN_DEPT, mappDB.Dept), "students")
            'TODO: 
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub resizeDatagrids(dGrid As String)
        If dgv_courses.Rows.Count > 0 And dGrid = "Courses" Then

            For Each col As DataGridViewColumn In dgv_courses.Columns
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
        ElseIf dgw.Rows.Count > 0 And dGrid = "Students" Then

            For Each col As DataGridViewColumn In dgw.Columns
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
    Public Sub UpdateCourses(dMATNO As String)
        Try
            Dim tmpDS As DataSet
            mappDB.MATNO = dMATNO
            tmpDS = mappDB.GetDataWhere(String.Format(STR_SQL_COURSES_SPD_WHERE, mappDB.MATNO), "Courses") 'todo
            dgv_courses.DataSource = tmpDS.Tables("Courses").DefaultView

            dgv_courses.Refresh()
            resizeDatagrids("courses")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtStudentMATNO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStudentMATNO.TextChanged
        If txtStudentMATNO.Text.Length > 5 Then
            mappDB.MATNO = txtStudentMATNO.Text
            Dim tmpDS = mappDB.GetDataWhere(String.Format(SQL_SELECT_ALL_RESULTS_WHERE_MATNO, mappDB.MATNO), "Results")
            dgw.DataSource = tmpDS.Tables("Results").DefaultView
            UpdateCourses(mappDB.MATNO)
        End If
    End Sub

    Private Sub dgw_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgw.CellContentClick
        updatePix()
    End Sub


    Private Sub dgw_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgw.RowsAdded
        On Error Resume Next
        For Each row As DataGridViewRow In Me.dgw.Rows

            If row.Cells.Item("Fees_Status").Value.ToString = "no" Then
                row.DefaultCellStyle.BackColor = Color.White

            ElseIf row.Cells.Item("Fees_Status").Value.ToString = "yes" Then
                row.DefaultCellStyle.BackColor = Color.PaleVioletRed
            End If
        Next


    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        btnReset.Enabled = False
        Me.ProgressBarBS.Value = 5
        TimerBS.Enabled = True
        TimerBS.Start()

        BgWProcess.RunWorkerAsync(1)  'runs GetData()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Public Sub CaptureCourses()
        ''get quantity first and subtract 1
        Dim units As Integer = CInt(dgw.SelectedRows(0).Cells("units").Value)
        Dim MATNO As String = dgw.SelectedRows(0).Cells(1).Value.ToString
        Dim semester As Double = CInt(dgw.SelectedRows(0).Cells("semester").Value)
        Dim credits As Double = CInt(dgw.SelectedRows(0).Cells("credits").Value)
        Dim courseCode As Double = CInt(dgw.SelectedRows(0).Cells("courseCode").Value)

        ''Capture Studennt TODO
        mappDB.MATNO = MATNO

        Me.TextBoxCourseCode.Text = courseCode.ToString
        Me.TextBoxSemester.Text = semester.ToString
        Me.TextBoxUnits.Text = units.ToString
        Me.LabelRef.Text = ref.ToString
        Me.TextBoxTotalCredits.Text = credits.ToString


    End Sub

    Public Sub unregisterStudent()


    End Sub
    Public Sub registerStudent(all As Boolean)
        Dim sDate, sUnits, sCC, sS, sRef, sTC As String


        sCC = Me.TextBoxCourseCode.Text
        sTC = Me.TextBoxTotalCredits.Text
        sS = Me.TextBoxSemester.Text
        sUnits = Me.TextBoxUnits.Text

        sRef = Me.LabelRef.Text
        sTC = 0

        sDate = FormatMyDate(Now) & " " & FormatMyTime(Now) '' "2018-10-09 00:00:00" 'mappDB.rDate '
        '    'sell
        mappDB.UpdateRecordWhere(String.Format(STR_SQL_COURSES_WHERE, sUnits, mappDB.MATNO)) 'todo
        MsgBox("ProduCoursect " & sCC & " updated Successfully!,")

        '    'refresh Datagrid
        UpdateCourses(mappDB.MATNO)

    End Sub
    Function FormatMyDate(dtp As Date) As String
        Dim StrDate As String = "00000000"
        'mySQL Palaver
        StrDate = dtp.Year.ToString("0000") & "-"
        StrDate = StrDate & dtp.Month.ToString("00") & "-"
        StrDate = StrDate & dtp.Day.ToString("00")
        Return StrDate
    End Function
    Function FormatMyTime(dtp As Date) As String
        Dim StrDate As String = "00000000"
        'mySQL Palaver
        StrDate = dtp.Hour.ToString("00")
        StrDate = StrDate & ":" & dtp.Minute.ToString("00")
        StrDate = StrDate & ":" & dtp.Second.ToString("00")
        Return StrDate
    End Function
    Public Sub updatePix()
        'Try
        '    UpdateRecordWhere(String.Format(SQL_UPDATE_ROOMS, "booked", CInt(dgw.SelectedRows(0).Cells(6).Value) + 1))
        '    mappDB.ProductCode = CStr(dgw.SelectedRows(0).Cells(0).Value)
        '    'MsgBox(Application.StartupPath & "\images\")

        '    If My.Computer.FileSystem.FileExists(Application.StartupPath & "\images\" & mappDB.ProductCode & ".jpg") Then
        '        PictureBox1.Image = Image.FromFile(Application.StartupPath & "\images\" & mappDB.ProductCode & ".jpg")
        '    Else
        '        PictureBox1.Image = Image.FromFile(Application.StartupPath & "\images\" & "img.jpg")

        '    End If

        'Catch ex As Exception

        'End Try

    End Sub
    Public Function UpdateRecordWhere(s As String) As String
        Dim returnVal As String = ""
        Try
            Using con As New OleDb.OleDbConnection(STR_connectionString)
                strSQL = s
                Dim cmd As New OleDb.OleDbCommand(strSQL, con)
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return returnVal
    End Function
    Public Function InsertRecord(s As String) As String
        Dim returnVal As String = ""
        Try

            Using con As New OleDb.OleDbConnection(STR_connectionString)
                'con = mappDB.connLocal
                'comes open con.Open()
                strSQL = s
                Dim cmd As New OleDb.OleDbCommand(strSQL, con)
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return returnVal
    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonUnregister.Click
        unregisterStudent()

    End Sub

    Private Sub dgw_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgw.CellContentDoubleClick
        updatePix()
        CaptureCourses()

    End Sub

    Private Sub dgv_rooms_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_courses.CellContentDoubleClick
        registerStudent(False)

    End Sub

    Private Sub dgw_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgw.RowEnter
        'MsgBox(sender.ToString)
        updatePix()
    End Sub

    Private Function computeCredits() As Integer
        Try
            'for each row
            'sum =sum + row(units)
            Return 0
        Catch ex As Exception
            Return False
        End Try

    End Function

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PictureBox2.Visible = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PictureBox2.Image = PictureBox1.Image
        PictureBox2.Visible = Not PictureBox2.Visible
    End Sub

    Private Sub FormStudentsRegistration_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MainForm.doCloseForm()
    End Sub

    Private Sub dgv_courses_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_courses.CellContentClick
        Dim dLeft As Integer = 0
        CheckedListBox1.Visible = True
        CheckedListBox1.Width = dgv_courses.Columns(e.ColumnIndex).Width    'todo: calc the with as only once
        dLeft = dgv_courses.Left
        For i = 0 To e.ColumnIndex ' dgv_courses.Columns.Count
            dLeft = dLeft + dgv_courses.Columns(i).Width
        Next
        CheckedListBox1.Left = dLeft
    End Sub

    Private Sub BgWProcess_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BgWProcess.DoWork
        Select Case CInt(e.Argument)
            Case 1 'all
                Me.GetData()
            Case 2

            Case Else

        End Select
    End Sub

    Private Sub TimerBS_Tick(sender As Object, e As EventArgs) Handles TimerBS.Tick
        ProgressBarBS.Value = (ProgressBarBS.Value + 3)
    End Sub
    Private Sub BgWProcess_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BgWProcess.RunWorkerCompleted
        dgw.DataSource = tmpDS.Tables("students").DefaultView
        If dgw.Rows.Count > 0 Then
            UpdateCourses(dgw.Rows(0).Cells("matno").ToString)
        End If

        'resize cols
        resizeDatagrids("students")
        TimerBS.Stop()
        btnReset.Enabled = True
        Me.ProgressBarBS.Value = 100
    End Sub


End Class