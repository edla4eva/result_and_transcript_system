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
            Call connect()
            If modeLocalOrCloud = "cloud" Then
                Me.m_connMode = "remote"
                m_connStr = ModuleGeneral.STR_connectionStringCloud
                Call connect()
            Else
                Me.m_connMode = "relocalmote"
                m_connStr = ModuleGeneral.STR_connectionString
                Call connect()
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
    Public ReadOnly Property conn() As Object ' OleDb.OleDbConnection
        Get
            If m_connMode = Nothing Or m_connMode = "local" Then
                If m_connLocal.State = 0 Then Call connect()
                Return m_connLocal
            Else
                If m_conn.State = 0 Then Call connect()
                Return m_conn
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
                m_connStr = ModuleGeneral.STR_connectionString ' "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Application.Info.DirectoryPath & "\db\db.mdb;" & "User ID=admin"
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
                m_conn.ConnectionString = ModuleGeneral.STR_connectionStringCloud
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
            connStr = String.Format("server={0};user id={1}; password={2}; database=result_and_transript_db; pooling=false; convert zero datetime=true", txtIP, txtMySQLUserName, txtMySQLPassword)
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
    Function getConnectionString(defaultStr As Boolean, Optional isLocal As Boolean = True) As String
        Dim tempConn As Object
        If isLocal = True Then tempConn = mappDB.conn Else tempConn = mappDB.conn
        If defaultStr Then
            Return My.Settings.dbConnectionString
        Else
            Return tempConn.ConnectionString
        End If
        tempConn.dispose
        tempConn = Nothing
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
            If Me.conn.state = ConnectionState.Closed Then Me.conn.open()  'todo manage connections
            Dim cmdLocal As New OleDb.OleDbCommand(dstrSQL, conn)
            Dim myDA As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(cmdLocal)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, dTableName)
            'dgw.DataSource = myDataSet.Tables("Result").DefaultView
            Return myDataSet
            If Me.conn.state = ConnectionState.Open Then conn.Close()    'todo manage conn

        Catch ex As Exception
            Throw New Exception("Database access problem, connect and try again" & vbCrLf & ex.Message)
            'MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public Function GetDataWhereCloud(dstrSQL As String, Optional dTableName As String = "Table") As DataSet
        Dim retVal As DataSet = Nothing
        Try
            If Me.conn.connectionstate = ConnectionState.Closed Then Me.conn.open()  'todo manage connections
            Dim cmdLocal As New OleDb.OleDbCommand(dstrSQL, conn)
            Dim myDA As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(cmdLocal)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, dTableName)
            If Me.conn.connectionstate = ConnectionState.Open Then conn.Close()    'todo manage conn
            retVal = myDataSet

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return retVal
    End Function
    Public Function GetRecordWhere(dstrSQL As String, Optional dTableName As String = "Table") As String
        Try
            If Me.conn.state = ConnectionState.Closed Then Me.conn.open()
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
            If Me.conn.state = ConnectionState.Open Then conn.Close()
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
            If Me.conn.connectionstate = ConnectionState.Open Then conn.Close()
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
            If Me.conn.connectionstate = ConnectionState.Closed Then Me.conn.open()
            Dim cmdLocal As New OleDb.OleDbCommand(dstrSQL, conn)
            cmdLocal.ExecuteNonQuery()  'BeginExecuteNonQuery()
            If Me.conn.connectionstate = ConnectionState.Open Then conn.Close()
        Catch ex As Exception
            Throw New Exception("Database access problem, connect and try again" & vbCrLf & ex.Message)
            ' MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return returnVal
    End Function
End Class
