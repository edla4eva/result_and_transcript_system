Imports System.Configuration
Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop
'Imports Microsoft.Office.Core
Imports System.Data.OleDb
Public Class ClassDB

    Private m_connStr As String
    'Private m_password As String
    Private m_conn As MySqlConnection ' OleDb.OleDbConnection
    Private m_connLocal As OleDb.OleDbConnection
    Private m_user As String
    Private m_connMode As String '= "local" 'or remote
    Public Sub New(Optional modeLocalOrCloud As String = "local")
        Try
            If modeLocalOrCloud = "cloud" Then
                Me.m_connMode = "remote"
                m_connStr = ModuleGeneral.STR_connectionStringCloud

            Else
                Me.m_connMode = "local"
                m_connStr = ModuleGeneral.STR_connectionString

            End If

        Catch ex As Exception
        End Try
    End Sub
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
    Private _user As String
    Public Property User() As String
        Get
            Return _user
        End Get
        Set(ByVal value As String)
            _user = value
        End Set
    End Property
    Private _matno As String
    Public Property MATNO() As String
        Get
            Return _matno
        End Get
        Set(ByVal value As String)
            _matno = value
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



    Function conn() As Object ' OleDb.OleDbConnection

        If m_connMode = Nothing Or m_connMode = "local" Then
            Return connLocal()

        Else

            Return connRemote()
        End If

    End Function
    Function connLocal() As OleDb.OleDbConnection


        Dim tmpConn As OleDbConnection = New OleDbConnection
        Try

            Try
                m_connStr = ModuleGeneral.STR_connectionString '64
                tmpConn.ConnectionString = ModuleGeneral.STR_connectionString
                tmpConn.Open()  'todo: throws error if called 2nd time must close app--> Attempted to read or write protected memory. This is often an indication that other memory 
            Catch ex As Exception
                m_connStr = ModuleGeneral.STR_connectionString32 '32 bits
                tmpConn.ConnectionString = ModuleGeneral.STR_connectionString32
                tmpConn.Open()
            End Try 'try 64 bit Access

            Return tmpConn

        Catch ex As Exception
            'Call showError(ex.Message)
            Throw New Exception("Database user aunthentication failed. Provide Server details, connect and try again")
        End Try
    End Function
    Function connRemote(Optional ByVal strConn As String = "", Optional ByVal AutoDetect As Boolean = False, Optional ByVal txtIP As String = "localhost", Optional ByVal txtMySQLUserName As String = "root", Optional ByVal txtMySQLPassword As String = "", Optional ByVal txtMySQLPasswordtxtIP As String = "") As MySqlConnection

        If m_conn Is Nothing Then m_conn = New MySqlConnection
        Dim connStr As String
        Dim tmpConnRemote As New MySqlConnection
        'if AutoDetect Server is check
        If AutoDetect Then
            connStr = My.Settings.dbConnectionString 'server=localhost;user id=root;Password=1tl3ola8;database=mysql;pooling=false
        Else
            connStr = String.Format("server={0};user id={1}; password={2}; database=result_and_transript_db; pooling=false; convert zero datetime=true", txtIP, txtMySQLUserName, txtMySQLPassword)
            'ensure forms can connect to data
            My.Settings.Item("crimpsof_ehotelConnectionString") = connStr
        End If
        If strConn <> "" Then connStr = strConn

        Try

            tmpConnRemote.ConnectionString = connStr
            tmpConnRemote.Open()
            tmpConnRemote.ChangeDatabase("result_and_transript_db")
            m_connStr = connStr          'Note the connection string
            Return tmpConnRemote
        Catch ex As MySqlException
            Throw New Exception("Database user aunthentication failed. " & vbCrLf & ex.Message)
        End Try


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


    Public Function GetDataWhere(dstrSQL As String, Optional dTableName As String = "Table") As DataSet
        Try
            Dim cmdLocal As New OleDb.OleDbCommand(dstrSQL, conn)
            Dim myDA As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(cmdLocal)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, dTableName)
            'dgw.DataSource = myDataSet.Tables("Result").DefaultView
            Return myDataSet
            closeConn(cmdLocal.Connection) 'safely close it

        Catch ex As Exception
            Throw New Exception("Database access problem, connect and try again" & vbCrLf & ex.Message)
            'MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public Function GetDataWhereCloud(dstrSQL As String, Optional dTableName As String = "Table") As DataSet
        Dim retVal As DataSet = Nothing
        Try
            Dim cmdLocal As New OleDb.OleDbCommand(dstrSQL, conn)
            Dim myDA As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(cmdLocal)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, dTableName)
            closeConn(cmdLocal.Connection) 'safely close it
            retVal = myDataSet

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return retVal
    End Function
    Sub closeConn(cn As OleDb.OleDbConnection)
        On Error Resume Next
        If cn.State = ConnectionState.Open Then cn.Close()
    End Sub
    Public Function GetRecordWhere(dstrSQL As String, Optional dTableName As String = "Table") As String
        Try
            'If Me.conn.state = ConnectionState.Closed Then Me.conn.open()
            'Using myconn As OleDb.OleDbConnection(str_connectionsting)
            Dim cmdLocal As New OleDb.OleDbCommand(dstrSQL, conn)
            Dim returnVal As String = Nothing
            Dim rd As OleDb.OleDbDataReader

            rd = cmdLocal.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                returnVal = rd.GetValue(0).ToString() & " " & rd.GetValue(1).ToString()
            End If
            rd.Close()
            rd = Nothing
            closeConn(cmdLocal.Connection) 'safely close it
            Return returnVal
        Catch ex As Exception
            Throw New Exception("Database access problem, connect and try again" & vbCrLf & ex.Message)
            'MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function
    Public Function UpdateRecordWhere(dstrSQL As String) As String
        Dim returnVal As String = ""
        Try
            If Me.conn.connectionstate = ConnectionState.Closed Then Me.conn.open()
            Dim cmdLocal As New OleDb.OleDbCommand(dstrSQL, conn)
            cmdLocal.ExecuteNonQuery()  'BeginExecuteNonQuery()
            closeConn(cmdLocal.Connection) 'safely close it
        Catch ex As Exception
            Throw New Exception("Database access problem, connect and try again" & vbCrLf & ex.Message)
            ' MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return returnVal
    End Function


    Public Function InsertRecord(dstrSQL As String) As String
        'ToDo: optimize for speed
        'support parameters
        Dim returnVal As String = ""
        Try

            Dim cmdLocal As New OleDb.OleDbCommand(dstrSQL, conn)
            cmdLocal.ExecuteNonQuery()  'BeginExecuteNonQuery()
            closeConn(cmdLocal.Connection) 'safely close it
        Catch ex As Exception
            Throw New Exception("Database access problem, connect and try again" & vbCrLf & ex.Message)
            ' MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return returnVal
    End Function
    Public Fun
    'TODO: incomplete fxn
    Function getDataReader(TableName As String, Optional isLocal As Boolean = True) As Boolean
        Dim Table As DataTable = New DataTable()
        Dim adapterL As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter("Select * from " + TableName, Me.connLocal.ConnectionString)
        ' Dim adapterC As OleDb.OleDbDataAdapter = New MySqlDataAdapter("Select * from " + TableName, Me.connRemote.ConnectionString)

        If isLocal Then
            adapterL.Fill(Table)
        Else

        End If
        Return True
    End Function
    'Useful for updating and Syncing
    Public Function CompareDataTables(ByVal first As DataTable, ByVal second As DataTable) As DataTable
        first.TableName = "FirstTable"
        second.TableName = "SecondTable"
        Dim table As DataTable = New DataTable("Difference")

        Try

            Using ds As DataSet = New DataSet()
                ds.Tables.AddRange(New DataTable() {first.Copy(), second.Copy()})
                Dim firstcolumns As DataColumn() = New DataColumn(ds.Tables(0).Columns.Count - 1) {}

                For i As Integer = 0 To firstcolumns.Length - 1
                    firstcolumns(i) = ds.Tables(0).Columns(i)
                Next

                Dim secondcolumns As DataColumn() = New DataColumn(ds.Tables(1).Columns.Count - 1) {}

                For i As Integer = 0 To secondcolumns.Length - 1
                    secondcolumns(i) = ds.Tables(1).Columns(i)
                Next

                Dim r As DataRelation = New DataRelation(String.Empty, firstcolumns, secondcolumns, False)
                ds.Relations.Add(r)

                For i As Integer = 0 To first.Columns.Count - 1
                    table.Columns.Add(first.Columns(i).ColumnName, first.Columns(i).DataType)
                Next

                table.BeginLoadData()

                For Each parentrow As DataRow In ds.Tables(0).Rows
                    Dim childrows As DataRow() = parentrow.GetChildRows(r)
                    If childrows Is Nothing OrElse childrows.Length = 0 Then table.LoadDataRow(parentrow.ItemArray, True)
                Next

                table.EndLoadData()
            End Using

        Catch ex As Exception
            Throw ex
        End Try

        Return table
    End Function

    Public Function bulkInsertDB(dt As DataTable) As Boolean
        Dim con As OleDb.OleDbConnection = Me.conn
        'create the table
        Dim sql As String = "Create Table abcd ("
        For Each column As DataColumn In dt.Columns
            sql += "[" & column.ColumnName & "] " & "nvarchar(50)" & ","
        Next

        sql = sql.TrimEnd(New Char() {","c}) & ")"

        Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
        Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
        cmd.ExecuteNonQuery()


        'Pull the table records and insert new
        Using adapter = New OleDbDataAdapter("SELECT * FROM abcd", con)

            Using builder = New OleDbCommandBuilder(adapter)
                adapter.InsertCommand = builder.GetInsertCommand()
                adapter.Update(dt)
            End Using
        End Using

        con.Close()
        Return True
    End Function
    Public Function manualInsertDB(dt As DataTable, dSession As String, dDept As Integer, dCourse As String) As Boolean
        '1. check for duplicates and delete
        Dim con As OleDb.OleDbConnection = Me.conn
        'update the table
        ' Public STR_SQL_INSERT_RESULTS As String = "INSERT INTO `db`.`results` (`result_id`, `matno`, `score`) VALUES ('', '{0}', '{1}');"

        Dim sql As String = "INSERT INTO results (result_id, student_idr, total) "
        'mysql
        'For Each row As DataRow In dt.Rows
        '    sql += " VALUES ('', " & row.Item("matno") & "," & row.Item("score") & "),"
        'Next
        'sql = sql.TrimEnd(New Char() {","c}) & ";"
        'MsgBox(sql)

        'access
        Dim cmd As OleDbCommand
        Dim da As OleDbDataAdapter
        Dim id As Long = 0

        id = mappDB.getMaxID("select Max(Results.result_id) AS MaxOfresult_id FROM Results")
        For Each row As DataRow In dt.Rows
            id = id + 1
            'access
            'INSERT INTO results ( result_id, s_n, matno, total, department_idr, course_code_idr, session_idr )
            'Select 3 As result_id, 1 As s_n, 1102290 As matno, 50 As total, 1 As department_idr, 'CPE272' AS course_code_idr, '2020/2021' AS session_idr;

            sql = "INSERT INTO results (result_id,s_n,matno,total,department_idr, course_code_idr, session_idr) "
            sql = sql & "VALUES (" & id & "," & row.Item("sn") & "," & row.Item("matno") & "," & row.Item("score") & "," & dDept & ",'" & dCourse & "','" & dSession & "');"
            'todo:
            'sql = sql & "Select 5 As result_id, 1 As s_n, 1102290 As matno, 50 As total, 1 As department_idr, 'CPE272' AS course_code_idr, '2020/2021' AS session_idr;"


            Debug.Print(sql)
            cmd = New OleDbCommand(sql, con)
            'cmd.Transaction.Begin()
            da = New OleDbDataAdapter(cmd)
            'da.Update(dt) 'da.fill() this is a promising mthd
            cmd.ExecuteNonQuery()
            'TODO: Show progress (trigger event)

        Next

        'cmd.Transaction.Commit()

        con.Close()
        Return True
    End Function

    Public Function getMaxID(dstrSQL) As Long
        'SELECT Max(Results.result_id) AS MaxOfresult_id
        'From Results
        'Order By Max(Results.result_id) DESC;

        Dim cmdLocal As New OleDb.OleDbCommand(dstrSQL, conn)
        Dim returnVal As Long = Nothing
        Dim rd As OleDb.OleDbDataReader

        rd = cmdLocal.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            returnVal = CLng(rd.GetValue(0).ToString())
        End If
        rd.Close()
        rd = Nothing
        closeConn(cmdLocal.Connection) 'safely close it


        Return returnVal

    End Function

    'TODO:: incomplete
    Function getDeptName(strDept As String, Optional forceStrict As Boolean = False) As String
        Dim retVal As String
        If forceStrict = True Then
            retVal = strDept
        Else
            retVal = strDept
        End If
        Return retVal
    End Function
    'TODO:: incomplete
    Function getDeptID(strDept As String, Optional forceStrict As Boolean = False) As Integer
        Dim retVal As Integer
        If forceStrict = True Then retVal = 1
        Return retVal
    End Function
    Function getSessionID(strSession As String, Optional forceStrict As Boolean = False) As String
        'TODO: If forceStrict=True Then retVal= fromDB
        Return Trim(strSession)
    End Function
    Function getCourseCode(strCourseCode As String, Optional forceStrict As Boolean = False) As String
        Return Trim(strCourseCode)
    End Function

    'TODO:: incomplete
    Public Function getAutoMATNo() As String

        Dim dstrSQL As String = "SELECT minimum(matno) FROM Results"

        'get the firt record  and add 1
        Dim cmdLocal As New OleDb.OleDbCommand(dstrSQL, conn)
        Dim returnVal As Long = Nothing
        Dim rd As OleDb.OleDbDataReader

        rd = cmdLocal.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            returnVal = CLng(rd.GetValue(0).ToString())
        End If
        rd.Close()
        rd = Nothing
        closeConn(cmdLocal.Connection) 'safely close it
        returnVal = returnVal + rd.RecordsAffected ' 1

        Return "AUTO" & Strings.FormatNumber(returnVal, 0, TriState.True, TriState.False, TriState.False)
        Return Strings.FormatNumber(returnVal, 0, TriState.True, TriState.False, TriState.False)

    End Function
    Public Sub logDBError(str As String)
        On Error Resume Next
        Dim fileExists As Boolean

        fileExists = My.Computer.FileSystem.FileExists(USER_DIRECTORY & "\db\error_log" & Now.Date.ToString & ".txt")
        If fileExists = True Then
            My.Computer.FileSystem.WriteAllText(USER_DIRECTORY & "\db\error_log" & Now.ToLongDateString & ".txt", str, True)
        Else
            My.Computer.FileSystem.WriteAllText(USER_DIRECTORY & "\db\error_log" & Now.ToLongDateString & ".txt", String.Empty, False)


        End If
    End Sub
End Class
