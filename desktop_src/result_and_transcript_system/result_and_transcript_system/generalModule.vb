

Imports System.Configuration
Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Core
Imports System.Data.OleDb

Module generalModule
    ''form bills
    'Public STR_SQL_ALL_USERS As String = "SELECT user_id, username, status as STATUS from tblusers order by status"
    'Public STR_SQL_ALL_GUESTS_BILLS_WHERE As String = "SELECT `guest_account_id`, `guest_id_ref`, `date`, `details`, `debit`, `credit`, `balance`, `ref`, `bill_status` FROM `guest_account` WHERE guest_id_ref='{0}' order by date"

    'Public STR_SQL_UNPAID_BILLS_WHERE As String = "SELECT `guest_account_id`, `guest_id_ref`, `date`, `details`, `debit`, `credit`, `balance`, `ref` FROM `guest_account` WHERE guest_id_ref='{0}' and bill_status!='paid' order by date"
    'Public STR_SQL_INSERT_BILL As String = "INSERT INTO `crimpsof_ehotel`.`guest_account` (`guest_account_id`, `guest_id_ref`, `date`, `details`, `debit`, `credit`, `balance`, `ref`) VALUES ('', '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');"
    'Public STR_SQL_GET_BOOKING_FOR_BILL As String = "SELECT `booking_id`, `booking_description`, `booking_type`, `deposited_amount`, `total_amount`, `balance_amount`, `booking_date`, `booking_time`, `booking_method`, `staff_id_ref`, `room_id_ref`, `booking_status`, `start_date`, `end_date`, `guest_id_ref` FROM `bookings` WHERE (guest_id_ref=1 AND (booking_status='occupied' OR booking_status='booked'))"
    'Public STR_SQL_GET_ROOM_FOR_BILL As String = "SELECT `room_id`, `room_name`, `room_description`, `room_cost`, `room_min_deposit`, `suit_id_ref`, `room_status`, `is_room_occupied`, `is_room_booked`, `is_room_paid_for`, `room_image` FROM rooms WHERE   room_id = '{0}'"
    ''form bookings
    'Public STR_SQL_ALL_GUESTS_COMBO As String = "SELECT `guest_id`, concat(`guest_id`, ' ', `first_name` , ' ', `surname`) as surname  FROM `guests_hrs` order by surname"
    'Public STR_SQL_ALL_BOOKINGS As String = "SELECT `booking_id`, `booking_description`, `booking_type`, `deposited_amount`, `total_amount`, `balance_amount`, `booking_date`, `booking_time`, `booking_method`, `staff_id_ref`, `room_id_ref`, `booking_status`, `guest_id_ref` FROM `bookings` WHERE booking_status='booked' or booking_status='occupied'"
    'Public STR_SQL_NEW_BOOKING As String = "INSERT INTO `crimpsof_ehotel`.`bookings` (`booking_id`, `booking_description`, `booking_type`, `deposited_amount`, `total_amount`, `balance_amount`, `booking_date`, `booking_time`, `booking_method`, `staff_id_ref`, `room_id_ref`, `booking_status`, `start_date`, `end_date`, `guest_id_ref`) VALUES (NULL, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}');"
    'Public STR_SQL_EDIT_BOOKING As String = "UPDATE `crimpsof_ehotel`.`bookings` SET `booking_status` = '{0}' WHERE `bookings`.`booking_id` = {1};"
    'Public STR_SQL_EDIT_ROOMS As String = "UPDATE `crimpsof_ehotel`.`rooms` SET `room_status` = '{0}' WHERE `rooms`.`room_id` = {1};"
    ''booked    'occupied    'empty
    ''form Guests
    'Public STR_SQL_ALL_GUESTS As String = "SELECT `guest_id`, `first_name`, `surname`, `title`, `cc_info`, `confirm_type`, `street_addr`, `city`, `country`, `phone`, `email`, `additional_comments`, `ip` FROM `guests_hrs` order by surname"
    'Public STR_SQL_ALL_GUESTS_WHERE As String = "SELECT `guest_id`, `first_name`, `surname`, `title`, `cc_info`, `confirm_type`, `street_addr`, `city`, `country`, `phone`, `email`, `additional_comments`, `ip` FROM `guests_hrs` where surname like '{0}%' order by surname"
    'Public STR_SQL_ALL_BOOKINGS_PER_DATE As String = ""
    ''form rooms
    'Public SQL_SELECT_ROOMS As String = "SELECT `room_id`, `room_name`, `room_description`, `room_cost`, `room_min_deposit`, `suit_id_ref`, `room_status`, `is_room_occupied`, `is_room_booked`, `is_room_paid_for`, `room_image` FROM `rooms`"
    'Public SQL_SELECT_AVAILIABLE_ROOMS As String = "SELECT `room_id`, `room_name`, `room_description` FROM rooms  WHERE (`is_room_occupied`=0 or `is_room_booked`=0 or `is_room_paid_for`=0) and room_status='empty'"
    'Public SQL_UPDATE_ROOMS As String = "UPDATE rooms set room_status='{0}' where room_id='{1}'"
    'Public SQL_SELECT_ROOMS_WHERE As String = "SELECT `room_id`, `room_name`, `room_description`, `room_cost`, `room_min_deposit`, `suit_id_ref`, `room_status`, `is_room_occupied`, `is_room_booked`, `is_room_paid_for`, `room_image` FROM `rooms` WHERE room_name like '{0}%' order by room_name"
    'Public SQL_INSERT_ROOMS As String = "INSERT INTO `crimpsof_ehotel`.`rooms` (`room_id`, `room_name`, `room_description`, `room_cost`, `room_min_deposit`, `suit_id_ref`, `room_status`, `is_room_occupied`, `is_room_booked`, `is_room_paid_for`) VALUES (NULL, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}');"

    Public objResults As New ClassResults()
    Public objBroadsheet As New ClassBroadsheets()

    Public Const strApplicationName As String = "e-Result"
    Public excelApp As Excel.Application
    Public excelWS As Excel.Worksheet
    Public excelWB As Excel.Workbook

    Public USER_DIRECTORY As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\eResult"
    Public PROG_DIRECTORY As String = My.Application.Info.DirectoryPath

    'Public intLoanID As Integer = CType(My.Settings.Item("LoanID").ToString, Integer)

    Public STR_connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\db.accdb"
    'TODO:
    'Public STR_connectionString As String = CType(ConfigurationManager.AppSettings("connString").ToString, String)
    Public conn As New MySql.Data.MySqlClient.MySqlConnection

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


    Structure appDB
        Private m_connStr As String
        'Private m_password As String
        Private m_conn As MySqlConnection ' OleDb.OleDbConnection
        Private m_connLocal As OleDb.OleDbConnection
        Private m_user As String
        Private m_connMode As String '= "local" 'or remote
        Public Property connMode() As String
            Get
                Return m_connMode
            End Get
            Set(ByVal value As String)
                m_connMode = value
            End Set
        End Property
        Public Property UserName() As String
            Get
                Return m_user
            End Get
            Set(ByVal value As String)
                m_user = value
            End Set
        End Property
        Private m_dept As String
        Public Property Dept() As String
            Get
                Return m_dept
            End Get
            Set(ByVal value As String)
                m_dept = value
            End Set
        End Property
        Private m_password As String
        Public Property Password() As String
            Get
                Return m_password
            End Get
            Set(ByVal value As String)
                m_password = value
            End Set
        End Property

        Private staff_id As Integer
        Public Property StaffID() As Integer
            Get
                Return staff_id
            End Get
            Set(ByVal value As Integer)
                staff_id = value
            End Set
        End Property


        Public Property ConnStr() As String
            Get
                Return m_connStr
            End Get
            Set(ByVal value As String)
                m_connStr = value
            End Set
        End Property
        Public ReadOnly Property conn() As Object ' OleDb.OleDbConnection
            Get
                If m_connMode = Nothing Or m_connMode = "local" Then
                    Return Me.connLocal
                Else
                    Return Me.connRemote
                End If

            End Get
        End Property
        Public ReadOnly Property connRemote() As MySqlConnection ' OleDb.OleDbConnection
            Get
                If m_conn Is Nothing Then m_conn = New MySqlConnection
                If m_conn.State = 0 Then Call connect()
                Return m_conn
            End Get
        End Property
        Public ReadOnly Property connLocal() As OleDb.OleDbConnection
            Get
                If m_connLocal Is Nothing Then m_connLocal = New OleDbConnection
                If m_connLocal.State = 0 Then Call connect()
                Return m_connLocal
            End Get
        End Property
        Sub connect()
            Try
                If m_connMode = Nothing Or m_connMode = "local" Then

                    If m_connLocal Is Nothing Then m_connLocal = New OleDbConnection
                    '32 bit Access
                    'm_connStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & My.Application.Info.DirectoryPath & "\db\abacuspro.mdb;" & "User ID=admin;" & "Password=" & m_password
                    '64 bit Access
                    m_connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Application.Info.DirectoryPath & "\db\db.accdb;" & "User ID=admin"
                    'TODO: m_conn.ConnectionString = STR_connectionString
                    m_connLocal.ConnectionString = m_connStr
                    m_connLocal.Open()

                Else


                    'm_conn = New OleDbConnection
                    If m_conn Is Nothing Then m_conn = New MySqlConnection
                    '32 bit Access
                    'm_conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & My.Application.Info.DirectoryPath & "\db\abacuspro.mdb;" & "User ID=admin;" & "Password=" & m_password
                    '64 bit Access
                    'm_conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Application.Info.DirectoryPath & "\db\db.accdb;" & "User ID=admin"
                    'mySQL
                    'm_conn.ConnectionString = "server=localhost;User Id=crimpsof_TrussN;password=crimpsof_TrussN;Persist Security Info=True;database=crimpsof_trussnet"
                    m_conn.ConnectionString = m_connStr
                    m_conn.Open()
                    m_conn.ChangeDatabase("crimpsof_ehotel")
                End If
            Catch ex As Exception
                'Call showError(ex.Message)
                Throw New Exception("Database user aunthentication failed. Provide Server details, connect and try again")
            End Try
        End Sub
        Sub connectToMySQLServer(Optional ByVal strConn As String = "", Optional ByVal AutoDetect As Boolean = False, Optional ByVal txtIP As String = "localhost", Optional ByVal txtMySQLUserName As String = "crimpsof_ehotel", Optional ByVal txtMySQLPassword As String = "crimpsof_ehotel", Optional ByVal txtMySQLPasswordtxtIP As String = "crimpsof_TrussN")
            If m_conn Is Nothing Then m_conn = New MySqlConnection
            'server=localhost;user id=root;Password=sibigem;database=nsdc_reg;persist security info=True
            Dim connStr As String
            'if AutoDetect Server is check
            If AutoDetect Then
                connStr = My.Settings.dbConnectionString 'server=localhost;user id=root;Password=1tl3ola8;database=mysql;pooling=false
            Else
                connStr = String.Format("server={0};user id={1}; password={2}; database=crimpsof_ehotel; pooling=false; convert zero datetime=true", txtIP, txtMySQLUserName, txtMySQLPassword)
                'ensure forms can connect to data
                My.Settings.Item("crimpsof_ehotelConnectionString") = connStr
            End If
            If strConn <> "" Then connStr = strConn

            Try
                If m_conn.State = ConnectionState.Open Then m_conn.Close()
                m_conn.ConnectionString = connStr
                m_conn.Open()
                conn.ChangeDatabase("crimpsof_ehotel")
                m_connStr = connStr          'Note the connection string
            Catch ex As MySqlException
                Throw New Exception("Database user aunthentication failed. " & vbCrLf & ex.Message)
            End Try

        End Sub
        Function getConnectionString(defaultStr As Boolean) As String
            If defaultStr Then
                Return My.Settings.dbConnectionString
            Else
                Return mappDB.conn.ConnectionString
            End If
        End Function
        Sub close()
            Try
                m_conn.Close()
            Catch
            End Try
        End Sub
        Sub dispose()
            Call close()
            m_connStr = Nothing
            m_user = Nothing
            m_password = Nothing
            m_conn = Nothing
        End Sub
    End Structure
    Public mappDB As New appDB

    Public Sub combolist(ByVal this_sql As String, ByVal this_value As String, ByVal this_member As String, ByVal this_cbo As ComboBox, Optional dConnMode As String = "local")
        Dim oad As Object
        Dim ds As New DataSet
        Dim strtmp As String = this_cbo.Text.ToString : this_cbo.Text = String.Empty
        If dConnMode = "local" Then
            oad = New OleDbDataAdapter(this_sql, mappDB.connLocal)
            oad.Fill(ds)
        Else
            oad = New MySqlDataAdapter(this_sql, mappDB.connRemote)
            oad.Fill(ds)
        End If


        With this_cbo
            .DataSource = ds.Tables(0)
            .ValueMember = this_value
            .DisplayMember = this_member
        End With

        this_sql = Nothing
        this_value = Nothing
        this_member = Nothing
        ds = Nothing
        oad = Nothing

        mappDB.close()

    End Sub



    Dim oadDataGrid As MySqlDataAdapter
    Dim oadDataGridLocal As OleDbDataAdapter
    Dim dtDataGrid As DataTable
    Public Sub fillGrid(ByVal _sql As String, ByVal _criteria As String, ByVal _orderBy As String, ByVal _grid As DataGridView, Optional ByVal _readonly As Boolean = False, Optional ByVal _bindingsource As BindingSource = Nothing)
        'TODO
        If mappDB.connMode = "local" Or mappDB.connMode = Nothing Then
            oadDataGridLocal = New OleDbDataAdapter(_sql + _criteria + _orderBy, mappDB.connLocal)
        Else
            oadDataGrid = New MySqlDataAdapter(_sql + _criteria + _orderBy, mappDB.connRemote)
        End If

        dtDataGrid = New DataTable

        Try
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
            mappDB.close()
        End Try
    End Sub


    Public Sub drawBorder(ByVal _range As String)
        'excelWS.Range(_range).Select()

        'excelWS.Cells.Range(_range).Borders ()

        With excelWS.Cells.Range(_range).Borders(Excel.XlBordersIndex.xlEdgeLeft)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.Constants.xlAutomatic
        End With
        With excelWS.Cells.Range(_range).Borders(Excel.XlBordersIndex.xlEdgeTop)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.Constants.xlAutomatic
        End With
        With excelWS.Cells.Range(_range).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.Constants.xlAutomatic
        End With
        With excelWS.Cells.Range(_range).Borders(Excel.XlBordersIndex.xlEdgeRight)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.Constants.xlAutomatic
        End With
        With excelWS.Cells.Range(_range).Borders(Excel.XlBordersIndex.xlInsideVertical)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.Constants.xlAutomatic
        End With
        With excelWS.Cells.Range(_range).Borders(Excel.XlBordersIndex.xlInsideHorizontal)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.Constants.xlAutomatic
        End With
    End Sub

    Public Sub showError(ByVal _msg As String)
        MessageBox.Show("WARNING : " & _msg & Chr(13) & " Click OK to continue.", strApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub log(ByVal _msg As String)
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

       Public Sub logError(str As String)
        On Error Resume Next
        Dim fileExists As Boolean

        fileExists = My.Computer.FileSystem.FileExists(USER_DIRECTORY & "\db\error_log" & Now.Date.ToString & ".txt")
        If fileExists = True Then
            My.Computer.FileSystem.WriteAllText(USER_DIRECTORY & "\db\error_log" & Now.ToLongDateString & ".txt", str, True)
        Else
            My.Computer.FileSystem.WriteAllText(USER_DIRECTORY & "\db\error_log" & Now.ToLongDateString & ".txt", String.Empty, False)


        End If
    End Sub
End Module

