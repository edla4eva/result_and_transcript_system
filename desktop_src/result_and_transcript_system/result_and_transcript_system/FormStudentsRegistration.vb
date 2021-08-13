Imports MySql.Data.MySqlClient
Public Class FormStudentsRegistration
    Dim con As MySql.Data.MySqlClient.MySqlConnection
    Dim cmd As MySql.Data.MySqlClient.MySqlCommand
    Dim strSQL As String
    Dim strConnectionString As String
    Dim ref As Integer

    Private Sub FormRooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.MdiParent = MDIParentMain
        Me.WindowState = FormWindowState.Maximized
        Me.Reset()

        'resize cols
        For Each col As DataGridViewColumn In dgw.Columns
            col.Width = 50
            If col.HeaderText = "productName" Then
                col.Width = 100
            ElseIf col.HeaderText = "productDescription" Then
                col.Width = 150
            ElseIf col.HeaderText = "buyPrice" Then
                col.Width = 100
            End If
        Next


    End Sub
    Sub Reset()
        txtStudentName.Text = ""
        'ref = CInt(CLng(Now.ToOADate * 200) + 100)
        'mappDB.ref = ref
        'mappDB.rDate = FormatMyDate(Now) & " " & FormatMyTime(Now)  'Now.ToShortDateString & " " & Now.ToShortTimeString
        GetData()
    End Sub
    Public Sub GetData()
        Try
            Dim tmpDS = mappDB.GetDataWhere(String.Format(SQL_SELECT_ALL_RESULTS_WHERE_MATNO, mappDB.MATNO), "Results")
            Dim cmdLocal As New OleDb.OleDbCommand(strSQL, mappDB.connLocal)
            Dim myDA As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(cmdLocal)

            myDA.Fill(tmpDS, "Results")
            dgw.DataSource = tmpDS.Tables("Results").DefaultView
            UpdateCourses()
            'TODO: 
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub UpdateCourses()
        Try
            Dim tmpDS As DataSet
            tmpDS = mappDB.GetDataWhere(String.Format(STR_SQL_COURSES_WHERE, mappDB.MATNO), "Courses") 'todo
            dgv_courses.DataSource = tmpDS.Tables("Courses").DefaultView
            con.Close()

            For Each col As DataGridViewColumn In dgv_courses.Columns
                col.Width = 0
                col.Visible = False
                If col.HeaderText = "date" Then
                    col.Width = 70
                    col.Visible = True
                ElseIf col.HeaderText = "details" Then
                    col.Width = 130
                    col.Visible = True
                ElseIf col.HeaderText = "credit" Then
                    col.Width = 60
                    col.Visible = True
                ElseIf col.HeaderText = "ref" Then
                    col.Width = 50
                    col.Visible = True
                End If
            Next

            dgv_courses.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtStudentName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStudentName.TextChanged
        mappDB.MATNO = txtStudentName.Text
        Dim tmpDS = mappDB.GetDataWhere(String.Format(SQL_SELECT_ALL_RESULTS_WHERE_MATNO, mappDB.MATNO), "Results")
        Dim cmdLocal As New OleDb.OleDbCommand(strSQL, mappDB.connLocal)
        Dim myDA As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(cmdLocal)
        myDA.Fill(tmpDS, "Results")
        dgw.DataSource = tmpDS.Tables("Results").DefaultView
        UpdateCourses()
    End Sub

    Private Sub dgw_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgw.CellContentClick
        updatePix()
    End Sub


    Private Sub dgw_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgw.RowsAdded
        On Error Resume Next
        For Each row As DataGridViewRow In Me.dgw.Rows

            If row.Cells.Item("is_registered").Value.ToString = "no" Then
                row.DefaultCellStyle.BackColor = Color.White
            ElseIf row.Cells.Item("is_registered").Value.ToString = "partial" Then
                row.DefaultCellStyle.BackColor = Color.Orange
            ElseIf row.Cells.Item("is_registered").Value.ToString = "yes" Then
                row.DefaultCellStyle.BackColor = Color.PaleVioletRed
            End If
        Next


    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Me.Reset()
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
        UpdateCourses()

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
            strConnectionString = mappDB.getConnectionString(False)
            con = New MySql.Data.MySqlClient.MySqlConnection(strConnectionString)
            con.Open()
            strSQL = s
            cmd = New MySql.Data.MySqlClient.MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return returnVal
    End Function
    Public Function InsertRecord(s As String) As String
        Dim returnVal As String = ""
        Try
            strConnectionString = mappDB.getConnectionString(False)
            con = New MySql.Data.MySqlClient.MySqlConnection(strConnectionString)
            con.Open()
            strSQL = s
            cmd = New MySql.Data.MySqlClient.MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()

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

End Class