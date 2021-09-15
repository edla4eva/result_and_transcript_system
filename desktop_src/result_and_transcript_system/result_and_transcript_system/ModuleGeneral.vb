

Imports System.Configuration
Imports MySql.Data.MySqlClient
Imports ExcelInterop = Microsoft.Office.Interop.Excel
'Imports Microsoft.Office.Core
Imports System.Data.OleDb

Module ModuleGeneral


    'Create db objects
    Public mappDB As New ClassDB()
    Public mappDBCloud As New ClassDB() '(cloud)
    Public objResult As New ClassExcelResult()
    Public objBroadsheet As New ClassBroadsheets()


    Public conn As New MySql.Data.MySqlClient.MySqlConnection
    Dim oadDataGrid As MySqlDataAdapter
    Dim oadDataGridLocal As OleDbDataAdapter
    Dim dtDataGrid As DataTable
    'create Excel objects
    Public myExcelApp As New ClassExcel
    Public objExcelFile As New ClassExcelFile() 'ExcelDataReader object

    'App settings
    Public USER_DIRECTORY As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\ResultAndTranscriptSystem"
    Public PROG_DIRECTORY As String = My.Application.Info.DirectoryPath

    'DB defalults
    ' '32 bit Access
    Public STR_connectionString32 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & My.Application.Info.DirectoryPath & "\db\db.mdb;" '& "User ID=admin;" & "Password=" & m_password
    '64 bits
    Public STR_connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Application.Info.DirectoryPath & "\db\db.mdb;" ' "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\db.mdb"
    Public STR_connectionStringCloud As String = "server=localhost;User Id=root;Persist Security Info=True;database=result_and_transript_db"


    'TODO: 'Public STR_connectionString As String = CType(ConfigurationManager.AppSettings("connString").ToString, String)

    'Excel
    Public Const strApplicationName As String = "e-Result"
    Public excelApp As ExcelInterop.Application
    Public excelWS As ExcelInterop.Worksheet
    Public excelWB As ExcelInterop.Workbook
    'General constants
    Public dblQuote As String = """"
    'Public intLoanID As Integer = CType(My.Settings.Item("LoanID").ToString, Integer)

    'Queries
    'FormResult
    'all
    Public STR_SQL_ALL_RESULTS As String = "SELECT * FROM results order by result_id" ' "SELECT `id`, `matno`, `score` FROM `tableResults` WHERE matno='{0}' order by id"
    Public STR_SQL_ALL_COURSES As String = "SELECT * FROM courses order by course_code" ' 

    Public STR_SQL_ALL_DEPARTMENTS_COMBO As String = "SELECT dept_id, dept_name FROM departments"
    Public STR_SQL_ALL_SESSIONS_COMBO As String = "SELECT session_id FROM sessions" ' 
    Public STR_SQL_ALL_STUDENTS_COMBO As String = "SELECT * FROM students" ' 
    'some
    Public STR_SQL_ALL_RESULTS_WHERE As String = "SELECT id, matno, score FROM tableResults WHERE matno='{0}' order by id" ' "SELECT `id`, `matno`, `score` FROM `tableResults` WHERE matno='{0}' order by id"
    Public SQL_SELECT_RESULTS_WHERE_MATNO As String = " SELECT * FROM TableResults WHERE matno= '{0}'"
    Public SQL_SELECT_ALL_RESULTS_WHERE_MATNO As String = "SELECT * FROM TableResults "
    Public STR_SQL_ALL_STUDENTS_IN_DEPT As String = "SELECT * FROM students WHERE student_dept_idr={0}" ' 

    Public STR_SQL_COURSES_WHERE As String = "SELECT * FROM courses WHERE matno='{0}' order by course_code" ' 
    Public STR_SQL_COURSES_SPD_WHERE As String = "SELECT * FROM reg WHERE matno='{0}'"
    'inserts
    Public STR_SQL_INSERT_RESULTS As String = "INSERT INTO `db`.`results` (`result_id`, `matno`, `score``) VALUES ('', '{0}', '{1}');"

    'Course reg combo
    '"SELECT course_code, course_title, course_unit, course_semester FROM Courses WHERE (((course_semester)=2)) ORDER BY Courses.course_code;"

    Public STR_SQL_COURSE_REG_FIRST_SEMESTER = "SELECT FC.CourseCode, FC.CourseTitle, FC.CourseCredit FROM FC WHERE (((FC.CourseSemester)=1)) ORDER BY FC.CourseCode;"
    Public STR_SQL_COURSE_REG_SECOND_SEMESTER = "SELECT CourseCode,CourseTitle,CourseCredit FROM FC WHERE (((CourseSemester)=2)) ORDER BY CourseCode;"
    'EX SCR Expanded 1 - lookup
    'SELECT reg.MatNo, reg.CourseCode_1.Value AS CourseCode, reg.Dept, DLookUp("CourseTitle","FC_1","CourseCode='" & [CourseCode] & "'") AS Course_Title, DLookUp("CourseCredit","FC_1","CourseCode='" & [CourseCode] & "'") AS Course_Credit, IIf(IsNull([Course_Credit]),0,[Course_Credit]*1) AS CourseCredit, reg.Pix, DLookUp("CourseSemester","FC_1","CourseCode='" & [CourseCode] & "'") AS CourseSemester, reg.Surname, reg.OtherNames, reg.Level, reg.Fees_Status
    'FROM reg
    'WHERE (((reg.CourseCode_1.Value)=[Enter Course Code]) And ((reg.Dept)=[Enter Department]));

    'EX CrossTab - course projection
    'TRANSFORM Count(SCR_Expanded_1.MatNo) As CountOfMatNo
    'Select Case SCR_Expanded_1.CourseCode, FC.CourseTitle, FC.TeachingDept, FC.CourseSemester, Count(SCR_Expanded_1.MatNo) As [Total Of MatNo]
    'FROM SCR_Expanded_1 INNER JOIN FC On SCR_Expanded_1.CourseCode = FC.CourseCode
    'GROUP BY SCR_Expanded_1.CourseCode, FC.CourseTitle, FC.TeachingDept, FC.CourseSemester
    'PIVOT SCR_Expanded_1.Dept;

    'QueryCourses_CPE_1  - only cpe first semester courses
    'Select Case Courses.course_code, Courses.course_unit, Courses.course_title, Courses.course_semester, Courses.course_level, Courses.course_dept_idr, Courses.Teaching_dept
    'FROM Courses
    'WHERE (((Courses.course_semester)=1) And ((Courses.Teaching_dept)="Computer Engineering"));


    'BroadSheets
    Public STR_SQL_ALL_BROADSHEET As String = "SELECT * FROM results WHERE( (session='{0}') And (level={1}));"


    Public STR_SQL_APPROVED_COURSES = "SELECT approved_courses_300 from sessions WHERE session_id='{0}';"





    'Public STR_SQL_ALL_USERS As String = "SELECT user_id, username, status as STATUS from tblusers order by status"
    'Public STR_SQL_ALL_GUESTS_BILLS_WHERE As String = "SELECT `guest_account_id`, `guest_id_ref`, `date`, `details`, `debit`, `credit`, `balance`, `ref`, `bill_status` FROM `guest_account` WHERE guest_id_ref='{0}' order by date"
    'Public STR_SQL_GET_BOOKING_FOR_BILL As String = "SELECT `booking_id`, `booking_description`, `booking_type`, `deposited_amount`, `total_amount`, `balance_amount`, `booking_date`, `booking_time`, `booking_method`, `staff_id_ref`, `room_id_ref`, `booking_status`, `start_date`, `end_date`, `guest_id_ref` FROM `bookings` WHERE (guest_id_ref=1 AND (booking_status='occupied' OR booking_status='booked'))"
    'Public STR_SQL_GET_ROOM_FOR_BILL As String = "SELECT `room_id`, `room_name`, `room_description`, `room_cost`, `room_min_deposit`, `suit_id_ref`, `room_status`, `is_room_occupied`, `is_room_booked`, `is_room_paid_for`, `room_image` FROM rooms WHERE   room_id = '{0}'"
    'INSERTS
    'Public STR_SQL_INSERT_BILL As String = "INSERT INTO `crimpsof_ehotel`.`guest_account` (`guest_account_id`, `guest_id_ref`, `date`, `details`, `debit`, `credit`, `balance`, `ref`) VALUES ('', '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');"
    'UPDATES
    'Public STR_SQL_EDIT_BOOKING As String = "UPDATE `crimpsof_ehotel`.`bookings` SET `booking_status` = '{0}' WHERE `bookings`.`booking_id` = {1};"
    'Public STR_SQL_EDIT_ROOMS As String = "UPDATE `crimpsof_ehotel`.`rooms` SET `room_status` = '{0}' WHERE `rooms`.`room_id` = {1};"
    'Public SQL_UPDATE_ROOMS As String = "UPDATE rooms set room_status='{0}' where room_id='{1}'"





    Public Function dblQuoted(dStr As String) As String
        Return dblQuote & dStr & dblQuote
    End Function
    Public Enum ExcelColumns
        colA = 1
        colB = 2
        colC = 3
        colD = 4
        colE = 5
        colF = 6
        colG = 7
        colH = 8
        colI = 9
        colJ = 10
        colK = 11
        colL = 12
        colM = 13
        colN = 14
        colO = 15
        colP = 16
        colQ = 17
        colR = 18
        colS = 19
        colT = 20
        colU = 21
        colV = 22
        colW = 23
        colX = 24
        colY = 25
        colZ = 26

        colAA = 27
        colAB = 28
        colAC = 29
        colAD = 30
        colAE = 31
        colAF = 32
        colAG = 33
        colAH = 34
        colAI = 35
        colAJ = 36
        colAK = 37
        colAL = 38
        colAM = 39
        colAN = 40
        colAO = 41
        colAP = 42
    End Enum
    Public lettersToNum As String() = {"0", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J",
    "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z",
    "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP",
    "AQ", "AR", "AS", "AT", "AU", "AV", "AW", "AX", "AY", "AZ", "BA", "BB", "BC", "BD", "BE", "BF",
    "BG", "BH", "BI", "BJ", "BK", "BL", "BM", "BN", "BO", "BP", "BQ", "BR", "BS", "BT", "BU", "BV",
    "BW", "BX", "BY", "BZ",
    "CA", "CB", "CC", "CD", "CE", "CF",
    "CG", "CH", "CI", "CJ", "CK", "CL", "CM", "CN", "CO", "CP", "CQ", "CR", "CS", "CT", "CU", "CV",
    "CW", "CX", "CY", "CZ", "DA", "DB", "DC", "DD", "DE", "DF",
    "DG", "DH", "DI", "DJ", "DK", "DL", "DM", "DN", "DO", "DP", "DQ", "DR", "DS", "DT", "DU", "DV",
    "DW", "DX", "DY", "DZ", "EA", "EB", "EC", "ED", "EE", "EF",
    "EG", "EH", "EI", "EJ", "EK", "EL", "EM", "EN", "EO", "EP", "EQ", "ER", "ES", "ET", "EU", "EV",
    "EW", "EX", "EY", "EZ"}

    Public Sub combolist(ByVal this_sql As String, ByVal this_value As String, ByVal this_member As String, ByVal this_cbo As ComboBox, Optional dConnMode As String = "local")
        Try
            Dim oad As Object
            Dim ds As New DataSet
            Dim strtmp As String = this_cbo.Text.ToString : this_cbo.Text = String.Empty
            Using xConn As New OleDb.OleDbConnection(ModuleGeneral.STR_connectionString)
                Try
                    xConn.Open()
                Catch ex1 As Exception
                    xConn.ConnectionString = ModuleGeneral.STR_connectionString
                    xConn.Open()
                End Try

                If dConnMode = "local" Then
                    oad = New OleDbDataAdapter(this_sql, xConn)
                    oad.Fill(ds)
                Else
                    'oad = New MySqlDataAdapter(this_sql, xConn)
                    'oad.Fill(ds)
                End If


                With this_cbo
                    .DataSource = ds.Tables(0)
                    .ValueMember = this_value
                    .DisplayMember = this_member
                End With

                xConn.Close()
                this_sql = Nothing
                this_value = Nothing
                this_member = Nothing
                ds = Nothing
                oad = Nothing

            End Using
            'mappDB.close()
        Catch ex As Exception
            log(ex.ToString)
            Throw ex

        End Try
    End Sub
    Public Function combolistDict(ByVal this_sql As String, ByVal this_value As String, ByVal this_member As String, Optional dConnMode As String = "local") As Dictionary(Of String, String)
        Try
            Dim oad As Object
            Dim ds As New DataSet
            Dim strtmp As String = String.Empty
            Dim retDict As New Dictionary(Of String, String)
            Using xConn As New OleDb.OleDbConnection(ModuleGeneral.STR_connectionString)
                Try
                    xConn.Open()
                Catch ex1 As Exception
                    xConn.ConnectionString = ModuleGeneral.STR_connectionString
                    xConn.Open()
                End Try

                If dConnMode = "local" Then
                    oad = New OleDbDataAdapter(this_sql, xConn)
                    oad.Fill(ds)
                Else
                    'oad = New MySqlDataAdapter(this_sql, xConn)
                    'oad.Fill(ds)
                End If


                For i = 0 To ds.Tables(0).Rows.Count - 1
                    retDict.Add(ds.Tables(0).Rows(i).Item(this_value), ds.Tables(0).Rows(i).Item(this_member))
                Next

                xConn.Close()
                this_sql = Nothing
                this_value = Nothing
                this_member = Nothing
                ds = Nothing
                oad = Nothing
            End Using
            Return retDict
        Catch ex As Exception
            log(ex.ToString)
            Throw ex

        End Try
    End Function
    Public Function combolistDS(ByVal this_sql As String, ByVal this_value As String, ByVal this_member As String, Optional dConnMode As String = "local") As DataSet
        Try
            Dim oad As Object
            Dim ds As New DataSet
            Dim strtmp As String = String.Empty
            Using xConn As New OleDb.OleDbConnection(ModuleGeneral.STR_connectionString)
                Try
                    xConn.Open()
                Catch ex1 As Exception
                    xConn.ConnectionString = ModuleGeneral.STR_connectionString
                    xConn.Open()
                End Try

                If dConnMode = "local" Then
                    oad = New OleDbDataAdapter(this_sql, xConn)
                    oad.Fill(ds)
                Else
                    'oad = New MySqlDataAdapter(this_sql, xConn)
                    'oad.Fill(ds)
                End If




                xConn.Close()
                this_sql = Nothing
                this_value = Nothing
                this_member = Nothing
                ds = Nothing
                oad = Nothing

            End Using
            Return ds
        Catch ex As Exception
            log(ex.ToString)
            Throw ex

        End Try
    End Function

    Public Sub fillGrid(ByVal _sql As String, ByVal _criteria As String, ByVal _orderBy As String, ByVal _grid As DataGridView, Optional ByVal _readonly As Boolean = False, Optional ByVal _bindingsource As BindingSource = Nothing)
        'TODO
        Try
            Using xConn As New OleDb.OleDbConnection(ModuleGeneral.STR_connectionString)
                Try
                    xConn.Open()
                Catch ex1 As Exception
                    xConn.ConnectionString = ModuleGeneral.STR_connectionString
                    xConn.Open()
                End Try
                If mappDB.connMode = "local" Or mappDB.connMode = Nothing Then
                    oadDataGridLocal = New OleDbDataAdapter(_sql + _criteria + _orderBy, xConn)
                Else
                    oadDataGrid = New MySqlDataAdapter(_sql + _criteria + _orderBy, mappDB.connRemote)
                End If

                dtDataGrid = New DataTable

                oadDataGrid.Fill(dtDataGrid)

                With _grid

                    .DataSource = Nothing

                    If _bindingsource Is Nothing Then
                        .DataSource = dtDataGrid
                    Else
                        '_bindingsource = New BindingSource
                        _bindingsource.DataSource = dtDataGrid
                        .DataSource = _bindingsource
                    End If
                    'hide column 0 
                    .Columns(0).Visible = False

                    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    .Cursor = Cursors.Hand

                    If _readonly Then
                        .ReadOnly = True
                        .AllowUserToAddRows = False
                    End If
                End With
                xConn.Close()
            End Using

        Catch ex As Exception
            MessageBox.Show("query error : " & ex.Message)
        Finally
            _sql = Nothing
            _criteria = Nothing
            _orderBy = Nothing
            _grid = Nothing

            'bdsource = Nothing

            _bindingsource = Nothing
            oadDataGrid = Nothing
            dtDataGrid = Nothing
            mappDB.closeConn(oadDataGridLocal.SelectCommand.Connection)
        End Try
    End Sub


    Public Sub showError(ByVal _msg As String)
        MessageBox.Show("WARNING : " & _msg & Chr(13) & " Click OK to continue.", strApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub log(ByVal _msg As String)
        On Error Resume Next
        Dim fileName As String = My.Application.Info.DirectoryPath & "\reports\log.txt"
        Dim fileExists As Boolean
        fileExists = My.Computer.FileSystem.FileExists(fileName)
        If fileExists Then
            My.Computer.FileSystem.WriteAllText(fileName, _msg & vbCrLf, True)
        Else
            My.Computer.FileSystem.WriteAllText(fileName, String.Empty, False)
            My.Computer.FileSystem.WriteAllText(fileName, _msg & vbCrLf, True)
        End If
    End Sub

    'store accounts to hastable
    'Structure _accounts
    '    Dim m_table As Hashtable

    '    Public Sub loaddata(ByVal this_sql As String)

    '    End Sub

    '    Public Sub loadtocombobox(ByVal this_cbo As ComboBox)
    '        this_cbo.DataSource = m_table
    '        this_cbo.ValueMember = "Key"
    '        this_cbo.DisplayMember = "Value"
    '    End Sub


    '    Public Sub dispose()
    '        m_table = Nothing
    '    End Sub
    'End Structure
    'Public accounts As New _accounts

    Function creatDataSet() As DataSet
        'Very good!
        Dim ds As New DataSet
        Dim dt As DataTable
        Dim dr As DataRow
        Dim idCoulumn As DataColumn
        Dim nameCoulumn As DataColumn
        Dim drCoulumn, crCoulumn, balCoulumn As DataColumn
        Dim i As Integer
        Dim sumCr As Double = 0
        Dim SumDr As Double = 0

        dt = New DataTable()
        idCoulumn = New DataColumn("ID", Type.GetType("System.Int32"))
        nameCoulumn = New DataColumn("Ref", Type.GetType("System.String"))
        drCoulumn = New DataColumn("Dr", Type.GetType("System.Double"))
        crCoulumn = New DataColumn("Cr", Type.GetType("System.Double"))
        balCoulumn = New DataColumn("Bal", Type.GetType("System.Double"))

        dt.TableName = "Bill"
        dt.Columns.Add(idCoulumn)
        dt.Columns.Add(nameCoulumn)
        dt.Columns.Add(drCoulumn)
        dt.Columns.Add(crCoulumn)
        dt.Columns.Add(balCoulumn)

        SumDr = 500
        sumCr = 0
        dr = dt.NewRow()
        dr("ID") = 1
        dr("Ref") = "ref001"
        dr("Dr") = 500
        dr("Cr") = 0
        dr("Bal") = sumCr - SumDr
        dt.Rows.Add(dr)

        SumDr = SumDr + 0
        sumCr = sumCr + 700
        dr = dt.NewRow()
        dr("ID") = 1
        dr("Ref") = "ref002"
        dr("Dr") = 0
        dr("Cr") = 700
        dr("Bal") = sumCr - SumDr
        dt.Rows.Add(dr)

        ds.Tables.Add(dt)

        For i = 0 To ds.Tables(0).Rows.Count - 1
            'MsgBox(ds.Tables(0).Rows(i).Item(0).ToString & "   --   " & ds.Tables(0).Rows(i).Item(1).ToString)
        Next i

        'Visualization
        'dgw.DataSource = ds.Tables("Bill").DefaultView

        'Report stuff
        'With Me.ReportViewer1.LocalReport

        '    .DataSources.Clear()
        '    '.ReportPath = My.Application.Info.DirectoryPath
        '    .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt))
        'End With
        'Me.ReportViewer1.RefreshReport()
        'Works perfectly
        Return ds
    End Function
    Public Sub drawBorder(ByVal _range As String)
        'excelWS.Range(_range).Select()

        'excelWS.Cells.Range(_range).Borders ()

        With excelWS.Cells.Range(_range).Borders(ExcelInterop.XlBordersIndex.xlEdgeLeft)
            .LineStyle = ExcelInterop.XlLineStyle.xlContinuous
            .Weight = ExcelInterop.XlBorderWeight.xlHairline
            .ColorIndex = ExcelInterop.Constants.xlAutomatic
        End With
        With excelWS.Cells.Range(_range).Borders(ExcelInterop.XlBordersIndex.xlEdgeTop)
            .LineStyle = ExcelInterop.XlLineStyle.xlContinuous
            .Weight = ExcelInterop.XlBorderWeight.xlHairline
            .ColorIndex = ExcelInterop.Constants.xlAutomatic
        End With
        With excelWS.Cells.Range(_range).Borders(ExcelInterop.XlBordersIndex.xlEdgeBottom)
            .LineStyle = ExcelInterop.XlLineStyle.xlContinuous
            .Weight = ExcelInterop.XlBorderWeight.xlHairline
            .ColorIndex = ExcelInterop.Constants.xlAutomatic
        End With
        With excelWS.Cells.Range(_range).Borders(ExcelInterop.XlBordersIndex.xlEdgeRight)
            .LineStyle = ExcelInterop.XlLineStyle.xlContinuous
            .Weight = ExcelInterop.XlBorderWeight.xlHairline
            .ColorIndex = ExcelInterop.Constants.xlAutomatic
        End With
        With excelWS.Cells.Range(_range).Borders(ExcelInterop.XlBordersIndex.xlInsideVertical)
            .LineStyle = ExcelInterop.XlLineStyle.xlContinuous
            .Weight = ExcelInterop.XlBorderWeight.xlHairline
            .ColorIndex = ExcelInterop.Constants.xlAutomatic
        End With
        With excelWS.Cells.Range(_range).Borders(ExcelInterop.XlBordersIndex.xlInsideHorizontal)
            .LineStyle = ExcelInterop.XlLineStyle.xlContinuous
            .Weight = ExcelInterop.XlBorderWeight.xlHairline
            .ColorIndex = ExcelInterop.Constants.xlAutomatic
        End With
    End Sub

End Module

