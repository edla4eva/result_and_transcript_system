Imports System.Configuration
Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop
'Imports Microsoft.Office.Core
Imports System.Data.OleDb
Public Class ClassDB
    Private m_connStr As String
    'Private m_password As String
    Private m_user As String
    Private m_connMode As String '= "local" 'or remote
    Private tmpConn As OleDb.OleDbConnection
    Public Sub New(Optional modeLocalOrCloud As String = "local")
        Try
            If modeLocalOrCloud = "cloud" Then
                Me.m_connMode = "remote"
                m_connStr = ModuleGeneral.STR_connectionStringCloud

            Else
                Me.m_connMode = "local"
                m_connStr = ModuleGeneral.STR_connectionString  '64

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

    'This function was once manageable but now it is a BAD idea
    ''Function connLocal() As OleDb.OleDbConnection
    ''    Dim tmpConn As OleDbConnection = New OleDbConnection
    ''    Try
    ''        Try
    ''            m_connStr = ModuleGeneral.STR_connectionString '64
    ''            tmpConn.ConnectionString = ModuleGeneral.STR_connectionString
    ''            tmpConn.Open()  'todo: throws error if called 2nd time must close app--> Attempted to read or write protected memory. This is often an indication that other memory 
    ''        Catch ex As Exception
    ''            m_connStr = ModuleGeneral.STR_connectionString32 '32 bits
    ''            tmpConn.ConnectionString = ModuleGeneral.STR_connectionString32
    ''            tmpConn.Open()
    ''        End Try 'try 64 bit Access

    ''        Return tmpConn

    ''    Catch ex As Exception
    ''        'Call showError(ex.Message)
    ''        Throw New Exception("Database user aunthentication failed. Provide Server details, connect and try again")
    ''    End Try
    ''End Function
    Function connRemote(Optional ByVal strConn As String = "", Optional ByVal AutoDetect As Boolean = False, Optional ByVal txtIP As String = "localhost", Optional ByVal txtMySQLUserName As String = "root", Optional ByVal txtMySQLPassword As String = "", Optional ByVal txtMySQLPasswordtxtIP As String = "") As MySqlConnection


        Dim connStr As String
        Dim tmpConnRemote As New MySqlConnection
        'if AutoDetect Server is check
        If AutoDetect Then
            connStr = My.Settings.dbConnectionString 'server=localhost;user id=root;Password=;database=mysql;pooling=false
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

    Function getCorrectConnectionstring(Optional cloud As Boolean = False) As String
        Dim retStr As String = ""
        Using xConn As New OleDb.OleDbConnection(ModuleGeneral.STR_connectionString)
            Try
                xConn.Open()
                xConn.Close()
                xConn.Dispose()
                retStr = ModuleGeneral.STR_connectionString
            Catch ex1 As Exception
                xConn.ConnectionString = ModuleGeneral.STR_connectionString32
                Try
                    xConn.Open()
                    xConn.Close()
                    xConn.Dispose()
                    retStr = ModuleGeneral.STR_connectionString32
                Catch ex As Exception
                    retStr = Nothing
                End Try

            End Try
        End Using
        Return retStr
    End Function
    Function getCorrectConnectionstringFromAccessFile(dFileName As String, Optional cloud As Boolean = False) As String
        Dim retStr As String = ""
        'Source={0}
        Using xConn As New OleDb.OleDbConnection(ModuleGeneral.STR_AccessFileConnectionString)
            Try
                xConn.Open()
                xConn.Close()
                xConn.Dispose()
                retStr = String.Format(ModuleGeneral.STR_AccessFileConnectionString, dFileName)
            Catch ex1 As Exception
                xConn.ConnectionString = String.Format(ModuleGeneral.STR_AccessFileConnectionString32, dFileName)
                Try
                    xConn.Open()
                    xConn.Close()
                    xConn.Dispose()
                    retStr = String.Format(ModuleGeneral.STR_AccessFileConnectionString32, dFileName)
                Catch ex As Exception
                    retStr = Nothing
                End Try

            End Try
        End Using
        Return retStr
    End Function
    Public Function GetDataWhere(dstrSQL As String, Optional dTableName As String = "Table") As DataSet
        Try
            Using xConn As New OleDb.OleDbConnection(ModuleGeneral.STR_connectionString)
                xConn.ConnectionString = getCorrectConnectionstring()
                xConn.Open()
                Dim cmdLocal As New OleDb.OleDbCommand(dstrSQL, xConn)
                Dim myDA As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(cmdLocal)
                Dim myDataSet As DataSet = New DataSet()
                myDA.Fill(myDataSet, dTableName)
                'dgw.DataSource = myDataSet.Tables("Result").DefaultView
                Return myDataSet
                xConn.Close()
            End Using
        Catch ex As Exception
            Throw New Exception("Database access problem, connect and try again" & vbCrLf & ex.Message)
            'MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function
    'todo: problem with function if dTableName(i) is Nothing or empty or invalid 
    Public Function BatchGetDataWhere(dstrSQL As String(), dTableName As String()) As DataSet
        Try
            Using xConn As New OleDb.OleDbConnection(ModuleGeneral.STR_connectionString)

                xConn.ConnectionString = getCorrectConnectionstring()
                xConn.Open()
                Dim dt(dstrSQL.Count) As DataTable
                Dim cmdLocal As New OleDb.OleDbCommand(dstrSQL(0), xConn)
                Dim myDA As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(cmdLocal)
                Dim myDataSet As DataSet = New DataSet
                For i = 0 To dstrSQL.Count
                    cmdLocal = New OleDb.OleDbCommand(dstrSQL(i), xConn)
                    myDA = New OleDb.OleDbDataAdapter(cmdLocal)
                    myDA.Fill(myDataSet, dTableName(i))
                Next

                'dgw.DataSource = myDataSet.Tables("Result").DefaultView
                Return myDataSet
                xConn.Close()
            End Using
        Catch ex As Exception
            Throw New Exception("Database access problem, connect and try again" & vbCrLf & ex.Message)
            'MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public Function GetDataWhereCloud(dstrSQL As String, Optional dTableName As String = "Table") As DataSet
        Dim retVal As DataSet = Nothing
        Try

            Using xConn As New MySqlConnection(ModuleGeneral.STR_connectionStringCloud)

                xConn.ConnectionString = getCorrectConnectionstring(True)
                xConn.Open()


                Dim cmd As New MySqlCommand(dstrSQL, xConn)
                Dim myDA As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim myDataSet As DataSet = New DataSet()
                myDA.Fill(myDataSet, dTableName)
                xConn.Close() 'safely close it
                retVal = myDataSet
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return retVal
    End Function
    Sub closeConn(cn As OleDb.OleDbConnection)
        On Error Resume Next
        If cn.State = ConnectionState.Open Then cn.Close()
        cn.Dispose()
    End Sub
    Public Function GetRecordWhere(dstrSQL As String, Optional dTableName As String = "Table") As String
        Try
            Using xConn As New OleDb.OleDbConnection(ModuleGeneral.STR_connectionString)
                xConn.ConnectionString = getCorrectConnectionstring()
                xConn.Open()

                Dim cmdLocal As New OleDb.OleDbCommand(dstrSQL, xConn)
                Dim returnVal As String = Nothing
                Dim rd As OleDb.OleDbDataReader

                rd = cmdLocal.ExecuteReader
                rd.Read()
                If rd.HasRows Then
                    returnVal = rd.GetValue(0).ToString()
                End If
                rd.Close()
                rd = Nothing
                closeConn(xConn) 'safely close it
                Return returnVal
            End Using

        Catch ex As Exception
            Throw New Exception("Database access problem, connect and try again" & vbCrLf & ex.Message)
            'MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function
    Public Function UpdateRecordWhere(dstrSQL As String) As String
        Dim returnVal As String = ""
        Try
            Using xConn As New OleDb.OleDbConnection(ModuleGeneral.STR_connectionString)
                xConn.ConnectionString = getCorrectConnectionstring()
                xConn.Open()
                Dim cmdLocal As New OleDb.OleDbCommand(dstrSQL, xConn)
                cmdLocal.ExecuteNonQuery()  'BeginExecuteNonQuery()
                closeConn(xConn) 'safely close it
            End Using

        Catch ex As Exception
            Throw New Exception("Database access problem, connect and try again" & vbCrLf & ex.Message)
            ' MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return returnVal
    End Function
    Public Function doQuery(dstrSQL As String) As Boolean
        Dim returnVal As Boolean = False
        Try
            Using xConn As New OleDb.OleDbConnection(ModuleGeneral.STR_connectionString)
                xConn.ConnectionString = getCorrectConnectionstring()
                xConn.Open()
                Dim cmdLocal As New OleDb.OleDbCommand(dstrSQL, xConn)
                cmdLocal.ExecuteNonQuery()  'BeginExecuteNonQuery()
                closeConn(xConn) 'safely close it
            End Using
            returnVal = True
        Catch ex As Exception
            returnVal = False
            logError("Database access problem, connect and try again" & vbCrLf & ex.Message)
            ' MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return returnVal

    End Function


    'TODO: incomplete fxn
    Function getDataReader(TableName As String, Optional isLocal As Boolean = True) As Boolean
        Try
            Using xConn As New OleDb.OleDbConnection(ModuleGeneral.STR_connectionString)

                xConn.ConnectionString = getCorrectConnectionstring()
                xConn.Open()
                Dim Table As DataTable = New DataTable()
                Dim adapterL As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter("Select * from " + TableName, xConn.ConnectionString)
                ' Dim adapterC As OleDb.OleDbDataAdapter = New MySqlDataAdapter("Select * from " + TableName, Me.connRemote.ConnectionString)

                If isLocal Then
                    adapterL.Fill(Table)
                Else

                End If
                adapterL.Dispose()
                closeConn(xConn)
            End Using
        Catch ex As Exception

            Throw ex
        End Try
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

    Public Function bulkInsertDBUsingDataAdapter(dtRecordsToInsert As DataTable, destTableNameInDB As String) As DataTable
        Try
            Using xConn As New OleDb.OleDbConnection(ModuleGeneral.STR_connectionString)
                xConn.ConnectionString = getCorrectConnectionstring()
                xConn.Open()
                'Pull the table records and insert new
                Using adapter = New OleDbDataAdapter("SELECT * FROM " & destTableNameInDB, xConn)
                    Using builder = New OleDbCommandBuilder(adapter)
                        builder.QuotePrefix = "["
                        builder.QuoteSuffix = "]"
                        'adapter.InsertCommand = builder.GetInsertCommand()
                        If dtRecordsToInsert.HasErrors Then
                            MsgBox("Some errors are contained in records: " & dtRecordsToInsert.GetErrors(0).ToString)
                            dtRecordsToInsert = Nothing
                        Else
                            adapter.Update(dtRecordsToInsert)
                        End If

                    End Using
                End Using
                closeConn(xConn)
            End Using
            Return dtRecordsToInsert

        Catch ex As Exception
            Return Nothing
            'todo return datatable wit error info
        End Try
    End Function
    Public Function bulkInsertFERMAUsingDataAdapter(dtRecordsToInsert As DataTable, destTableNameInDB As String, AccessFileName As String) As DataTable
        Try
            Using xConn As New OleDb.OleDbConnection(ModuleGeneral.STR_AccessFileConnectionString)
                xConn.ConnectionString = mappDB.getCorrectConnectionstringFromAccessFile(AccessFileName)
                xConn.Open()
                'Pull the table records and insert new
                Using adapter = New OleDbDataAdapter("SELECT * FROM " & destTableNameInDB, xConn)
                    Using builder = New OleDbCommandBuilder(adapter)
                        builder.QuotePrefix = "["
                        builder.QuoteSuffix = "]"
                        'adapter.InsertCommand = builder.GetInsertCommand()
                        If dtRecordsToInsert.HasErrors Then
                            MsgBox("Some errors are contained in records: " & dtRecordsToInsert.GetErrors(0).ToString)
                            dtRecordsToInsert = Nothing
                        Else
                            adapter.Update(dtRecordsToInsert)
                        End If

                    End Using
                End Using
                closeConn(xConn)
            End Using
            Return dtRecordsToInsert

        Catch ex As Exception
            Return Nothing
            'todo return datatable wit error info
        End Try
    End Function
    Public Function changeUserPassword(usr As String, pass As String) As Boolean
        Dim retVal As Boolean

        Dim strSQL As String = "UPDATE  users SET(password='{0}' WHERE name='{1}' AND password='{2}')"
        retVal = doQuery(String.Format(strSQL, pass, usr, pass))
        Debug.Print(strSQL)
        Return retVal
    End Function
    Public Function saveUser(usr As String, pass As String) As Boolean
        Dim retVal As Boolean
        Dim strSQL As String = ""
        Dim id As Integer
        id = mappDB.getMaxID("select Max(users.id) AS MaxOfresult_id FROM users")
        id = id + 1
        strSQL = "INSERT INTO users  (`id`, `name`, `email`, `password`) VALUES({0},'{1}','admin@admin.com','{2}');"
        retVal = doQuery(String.Format(strSQL, id, usr, pass))
        'Debug.Print(String.Format(strSQL, id,usr, pass))
        Return retVal
    End Function
    Public Function getUser(usr As String, pass As String) As Boolean
        Dim usrFromDB As String = ""
        usrFromDB = GetRecordWhere(String.Format("SELECT name FROM users WHERE name='{0}' AND password='{1}'", usr, pass))
        If usrFromDB = usr Then Return True Else Return False
    End Function
    'TODO: incomplete
    Public Function manualRegExportToEmbeddedAccessSPD(dt As DataTable) As Boolean
        Using xConn As New OleDb.OleDbConnection(ModuleGeneral.STR_connectionString)
            xConn.ConnectionString = getCorrectConnectionstring()
            xConn.Open()
            '1. check for duplicates and delete
            Dim sql As String = ""  'todo: move sql to module
            'access
            Dim cmd As New OleDbCommand
            Dim dLevel As Integer = 100

            For Each row As DataRow In dt.Rows
                'todo: use parameters
                'Notes Fees_Status is Yes/No without quotes, enlose Level in `` 
                If IsDBNull(row.Item("Fees_Status")) Then
                    row.Item("Fees_Status") = "No"
                ElseIf row.Item("Fees_Status") = "" Then
                    row.Item("Fees_Status") = "No"
                    dLevel = CInt(Trim(row.Item("Level")))
                End If
                sql = "INSERT INTO SPD (matno,Surname,OtherNames,`Dept`,`Level`,`Year`,`Mode`,Sex,txtImageName,CourseCode_1,CourseCode_2,Fees_Status,Pix,txtImageName1) "
                sql = sql & "VALUES ('" & row.Item("matno") & "','Surname','Other_Names','Department',100,1,'full time','Male','txtImageNam" & "','" & row.Item("CourseCode_1") & "','" & row.Item("CourseCode_2") & "'," & row.Item("Fees_Status") & ",'" & row.Item("matno") & ".jpg','');"
                Debug.Print(sql)
                'INSERT INTO SPD (matno,Surname,Other_Names,Department,Level,Year,Mode,Sex,txtImageName,CourseCode_1,CourseCode2, 
                'Fees_Status, Pix, txtImageName1) VALUES (ENG1704248,'Surname','Other_Names','Department','Level','Year','full time','Male','txtImageNam','CHM111;CHM113;GST111;GST112;MTH110;MTH112;PHY111;PHY113,CHM122;CHM124;GST121;GST122;GST123;MTH123;MTH125;PHY109;PHY124,'False','100','Computer Engineering' 

                cmd = New OleDbCommand(sql, xConn)
                'cmd.Transaction.Begin()
                'da = New OleDbDataAdapter(cmd)
                'da.Update(dt) 'da.fill() this is a promising mthd
                cmd.ExecuteNonQuery()
                'TODO: Show progress (trigger event)
            Next

            'cmd.Transaction.Commit()

            closeConn(xConn)
            cmd.Dispose()
        End Using
        Return True
    End Function

    Public Function manualRegExportToExternalAccess(dt As DataTable, AccessFileName As String) As Boolean
        Using xConn As New OleDb.OleDbConnection(mappDB.getCorrectConnectionstringFromAccessFile(AccessFileName))
            xConn.ConnectionString = mappDB.getCorrectConnectionstringFromAccessFile(AccessFileName)
            xConn.Open()

            '1. check for duplicates and delete
            Dim sql As String = ""  'todo: move sql to module
            'access
            Dim cmd As New OleDbCommand
            Dim dLevel As Integer = 100

            For Each row As DataRow In dt.Rows
                'todo: use parameters
                'Notes Fees_Status is Yes/No without quotes, enlose Level in `` 
                If IsDBNull(row.Item("Fees_Status")) Then
                    row.Item("Fees_Status") = "No"
                ElseIf row.Item("Fees_Status") = "" Then
                    row.Item("Fees_Status") = "No"
                    dLevel = CInt(Trim(row.Item("Level")))
                End If
                sql = "INSERT INTO SPD (matno,Surname,OtherNames,`Dept`,`Level`,`Year`,`Mode`,Sex,txtImageName,CourseCode_1,CourseCode_2,Fees_Status,Pix,txtImageName1) "
                sql = sql & "VALUES ('" & row.Item("matno") & "','Surname','Other_Names','Department',100,1,'full time','Male','txtImageNam" & "','" & row.Item("CourseCode_1") & "','" & row.Item("CourseCode_2") & "'," & row.Item("Fees_Status") & ",'" & row.Item("matno") & ".jpg','');"
                Debug.Print(sql)
                'INSERT INTO SPD (matno,Surname,Other_Names,Department,Level,Year,Mode,Sex,txtImageName,CourseCode_1,CourseCode2, 
                'Fees_Status, Pix, txtImageName1) VALUES (ENG1704248,'Surname','Other_Names','Department','Level','Year','full time','Male','txtImageNam','CHM111;CHM113;GST111;GST112;MTH110;MTH112;PHY111;PHY113,CHM122;CHM124;GST121;GST122;GST123;MTH123;MTH125;PHY109;PHY124,'False','100','Computer Engineering' 

                cmd = New OleDbCommand(sql, xConn)
                'cmd.Transaction.Begin()
                'da = New OleDbDataAdapter(cmd)
                'da.Update(dt) 'da.fill() this is a promising mthd
                cmd.ExecuteNonQuery()
                'TODO: Show progress (trigger event)
            Next

            'cmd.Transaction.Commit()

            closeConn(xConn)
            cmd.Dispose()
        End Using
        Return True
    End Function
    'TODO: copy documentation from here
    Public Function genericManualInsertDTtoDB(dt As DataTable, dTableName As String, Optional maxColNum As Integer = 255) As Boolean
        '
        ' Summary:
        '     Manually  inserts records into a database table 
        '
        ' Parameters:
        '   dt:
        '     The DataTable from which records will be obtained
        '
        ' Returns:
        '     True if successful, False otherwise.
        '
        ' Exceptions:
        '   T:System.InvalidOperationException:
        '     Cannot execute a command within a transaction context that differs from the context
        '     in which the connection was originally enlisted.


        Using xConn As New OleDb.OleDbConnection(ModuleGeneral.STR_connectionString)
            xConn.ConnectionString = getCorrectConnectionstring()
            xConn.Open()
            '1. check for duplicates and delete
            'access
            Dim cmd As New OleDbCommand
            Dim sqlInsert, sql As String
            'Dim da As OleDbDataAdapter
            sqlInsert = "INSERT INTO " & dTableName & " ( "
            For j = 0 To dt.Columns.Count - 1
                If j = dt.Columns.Count - 1 Or j >= maxColNum Then
                    sqlInsert = sqlInsert & "[" & dt.Columns(j).ColumnName & "]" & ")"
                    Exit For
                Else
                    sqlInsert = sqlInsert & "[" & dt.Columns(j).ColumnName & "]" & ","
                End If
            Next

            For i = 0 To dt.Rows.Count - 1
                sql = sqlInsert & " VALUES ("
                For j = 0 To dt.Columns.Count - 1
                    If j = dt.Columns.Count - 1 Or j >= maxColNum Then
                        sql = sql & "'" & dt.Rows(i).Item(j).ToString & "'); "
                        Exit For
                    Else
                        sql = sql & "'" & dt.Rows(i).Item(j).ToString & "', "
                    End If
                    'todo: use parameters
                    'cmd.Transaction.Begin()

                    'TODO: Show progress (trigger event)
                Next
                cmd = New OleDbCommand(sql, xConn)     'insert row by row
                cmd.ExecuteNonQuery()
            Next
            'cmd.Transaction.Commit()
            closeConn(xConn)
            cmd.Dispose()
        End Using
        Return True
    End Function
    Public Function manualStudentsInsertDB(dt As DataTable) As Boolean
        Using xConn As New OleDb.OleDbConnection(ModuleGeneral.STR_connectionString)
            xConn.ConnectionString = getCorrectConnectionstring()
            xConn.Open()
            '1. check for duplicates and delete
            Dim sql As String = ""  'todo: move sql to module
            'access
            Dim cmd As New OleDbCommand
            'Dim da As OleDbDataAdapter
            For Each row As DataRow In dt.Rows
                'todo: use parameters
                sql = "INSERT INTO students (students.matno, students.student_firstname, students.student_surname, students.student_othernames, students.student_dept_idr, students.status, students.level, students.year_of_entry,students.session_idr_of_entry, students.mode_of_entry) "
                sql = sql & "VALUES (" & row.Item("matno") & "','" & row.Item("student_firstname") & "'," & row.Item("student_othernames") & "'," & row.Item("student_dept_idr") & "'," & row.Item("status") & "'," & row.Item("level") & "'," & row.Item("year_of_entry") & "'," & row.Item("session_idr_of_entry") & "'," & row.Item("mode_of_entry") & "');"
                'Debug.Print(sql)
                cmd = New OleDbCommand(sql, xConn)
                'cmd.Transaction.Begin()
                'da = New OleDbDataAdapter(cmd)
                'da.Update(dt) 'da.fill() this is a promising mthd
                cmd.ExecuteNonQuery()
                'TODO: Show progress (trigger event)

            Next

            'cmd.Transaction.Commit()

            closeConn(xConn)
            cmd.Dispose()
        End Using
        Return True
    End Function

    Public Function manualResultInsertDB(dt As DataTable, dSession As String, dDept As Integer, dCourse As String) As Boolean
        Using xConn As New OleDb.OleDbConnection(ModuleGeneral.STR_connectionString)
            xConn.ConnectionString = getCorrectConnectionstring()
            xConn.Open()
            '1. check for duplicates and delete
            Dim sql As String = "INSERT INTO results (result_id, student_idr, total, result_timestamp) "  'todo: move sql to module
            Dim strTimestmp As String = Now.ToString
            'access
            Dim cmd As New OleDbCommand
            'Dim da As OleDbDataAdapter
            Dim id As Long = 0

            id = mappDB.getMaxID("select Max(Results.result_id) AS MaxOfresult_id FROM Results")
            For Each row As DataRow In dt.Rows
                id = id + 1
                'todo: use parameters
                sql = "INSERT INTO results (result_id,s_n,matno,fullname,total,department_idr, course_code_idr, session_idr,result_timestamp) "
                sql = sql & "VALUES (" & id & "," & row.Item("sn") & ",'" & row.Item("matno") & "','" & row.Item("name") & "'," & row.Item("score") & "," & dDept & ",'" & dCourse & "','" & dSession & "','" & strTimestmp & "');"   '

                'Debug.Print(sql)
                cmd = New OleDbCommand(sql, xConn)
                'cmd.Transaction.Begin()
                'da = New OleDbDataAdapter(cmd)
                'da.Update(dt) 'da.fill() this is a promising mthd
                cmd.ExecuteNonQuery()
                'TODO: Show progress (trigger event)

            Next

            'cmd.Transaction.Commit()

            closeConn(xConn)
            cmd.Dispose()
        End Using
        Return True
    End Function
    Public Function manualRegInsertDB(dt As DataTable) As Boolean
        Using xConn As New OleDb.OleDbConnection(ModuleGeneral.STR_connectionString)
            xConn.ConnectionString = getCorrectConnectionstring()
            xConn.Open()
            '1. check for duplicates and delete
            Dim sql As String = STR_SQL_INSERT_STUDENTS_WITH_PARAMS ' "INSERT INTO Reg (result_id, student_idr, total, result_timestamp) "  'todo: move sql to module
            Dim strTimestmp As String = Now.ToString
            'access
            Dim cmd As New OleDbCommand
            'Dim da As OleDbDataAdapter
            Dim matno As String = ""
            Dim retmatno As String = ""
            Dim dtSingleRow As DataTable
            Dim retFailed As String = "Failed to insert the following: "
            For Each row As DataRow In dt.Rows
                matno = row.Item("matno")
                retmatno = mappDB.GetRecordWhere(String.Format("select matno from Reg WHERE matno='{0}'", matno))
                If retmatno = matno Then
                    ' record already exits
                    'option 1. update (ovewrite)
                    'option 2 donothing and add it to a datatable to tell the user
                Else
                    'todo: use parameters
                    sql = STR_SQL_INSERT_STUDENTS_WITH_PARAMS   ' "INSERT INTO results (result_id,s_n,matno,fullname,total,department_idr, course_code_idr, session_idr,result_timestamp) "
                    dtSingleRow = dt.Copy
                    dtSingleRow.Rows.Clear()
                    dtSingleRow.Rows.Add(row.ItemArray)
                    dtSingleRow.AcceptChanges()

                    cmd = New OleDbCommand(sql, xConn)
                    cmd.Parameters.AddRange(getParamsFromDatatable(dt).ToArray)
                    'cmd.Transaction.Begin()
                    'da = New OleDbDataAdapter(cmd)
                    'da.Update(dt) 'da.fill() this is a promising mthd

                    Try
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        retFailed = retFailed & vbCrLf & row.Item("matno")
                    End Try
                    'TODO: Show progress (trigger event)
                End If
            Next
            'cmd.Transaction.Commit()
            MsgBox(retFailed)
            closeConn(xConn)
            cmd.Dispose()
        End Using
        Return True
    End Function
    Public Function manualInsertDBCloud(dt As DataTable, dSession As String, dDept As Integer, dCourse As String) As Boolean
        ''1. check for duplicates and delete

        ''update the table
        '' Public STR_SQL_INSERT_RESULTS As String = "INSERT INTO `db`.`results` (`result_id`, `matno`, `score`) VALUES ('', '{0}', '{1}');"
        'Dim id As Integer
        'id = mappDB.getMaxID("select Max(Results.result_id) AS MaxOfresult_id FROM Results")
        'Dim sql As String = "INSERT INTO results (result_id, student_idr, total) "

        ''mysql
        'For Each row As DataRow In dt.Rows
        '    sql += " VALUES (id, " & row.Item("matno") & "," & row.Item("score") & "),"
        'Next
        'sql = sql.TrimEnd(New Char() {","c}) & ";"

        ''mySQL
        'Dim cmd As New MySqlCommand
        'Dim da As MySqlDataAdapter
        'Dim id As Long = 0

        'cmd = New OleDbCommand(sql, connLocal())
        ''cmd.Transaction.Begin()
        'da = New OleDbDataAdapter(cmd)
        ''da.Update(dt) 'da.fill() this is a promising mthd
        'cmd.ExecuteNonQuery()
        ''TODO: Show progress (trigger event)



        ''cmd.Transaction.Commit()

        'closeConn(cmd.Connection)
        Return True
    End Function
    Public Function getMaxID(dstrSQL) As Long
        Dim returnVal As Long = Nothing
        Using xConn As New OleDb.OleDbConnection(ModuleGeneral.STR_connectionString)
            xConn.ConnectionString = getCorrectConnectionstring()
            xConn.Open()

            Dim cmdLocal As New OleDb.OleDbCommand(dstrSQL, xConn)
            Dim rd As OleDb.OleDbDataReader

            rd = cmdLocal.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                returnVal = CLng(rd.GetValue(0).ToString())
            End If
            rd.Close()
            rd = Nothing
            closeConn(xConn) 'safely close it
        End Using

        Return returnVal

    End Function

    'TODO:: incomplete
    Function getDeptName(strDept As String, Optional forceStrict As Boolean = False) As String
        Dim retVal As String = "COMPUTER ENGINEERING"
        Try
            If dictDepts.Count > 0 And dictDepts.ContainsKey(strDept) Then
                retVal = dictDepts(strDept)
            Else
                getDeptSessionsIntoDictionaries()
                retVal = dictDepts(strDept)
            End If
            Return retVal
        Catch ex As Exception
            Return retVal
        End Try
    End Function
    'TODO:: use dictonaries
    Function getDeptID(strDept As String, Optional forceStrict As Boolean = False) As Integer
        Dim retVal As Integer = 1
        If dictDepts.Count > 0 And dictDepts.ContainsKey(strDept) Then
            retVal = CInt(dictDepts.Keys(strDept))
        Else
            getDeptSessionsIntoDictionaries()  'so we dont have to do db call again
            If forceStrict = True Then
                retVal = CInt(mappDB.GetRecordWhere(String.Format("SELECT dept_id FROM departments WHERE dept_name='{0}'", strDept)))
            Else
                'todo: Where Like in sql
                retVal = CInt(mappDB.GetRecordWhere(String.Format("SELECT dept_id FROM departments WHERE dept_name='{0}'", strDept)))

            End If
        End If
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

        Dim dstrSQL As String = "SELECT minimum(matno) FROM Results"    'TODO: move sql
        Dim returnVal As Long = Nothing
        Using xConn As New OleDb.OleDbConnection(ModuleGeneral.STR_connectionString)
            xConn.ConnectionString = getCorrectConnectionstring()
            xConn.Open()
            'get the firt record  and add 1
            Dim cmdLocal As New OleDb.OleDbCommand(dstrSQL, xConn)

            Dim rd As OleDb.OleDbDataReader

            rd = cmdLocal.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                returnVal = CLng(rd.GetValue(0).ToString())
            End If
            rd.Close()
            rd = Nothing
            closeConn(xConn) 'safely close it
            returnVal = returnVal + rd.RecordsAffected ' 1
        End Using
        Return "AUTO" & Strings.FormatNumber(returnVal, 0, TriState.True, TriState.False, TriState.False)
        Return Strings.FormatNumber(returnVal, 0, TriState.True, TriState.False, TriState.False)

    End Function
    Public Function getAllCourses() As DataSet
        Dim AllCoursesDS As New DataSet
        Dim countC As Integer

        AllCoursesDS = mappDB.GetDataWhere(STR_ALL_COURSES_ORDERED, "Courses")
        countC = AllCoursesDS.Tables(0).Rows.Count
        'Get All Courses in Array
        dictAllCourseCodeKeyAndCourseUnitVal.Clear()
        dictAllCourseCodeKeyAndCourseLevelVal.Clear()
        dictAllCourseCodeKeyAndCourseSemesterVal.Clear()

        For j = 0 To countC - 1 'create columns for courses 'TODO: 1st and second
            dictAllCourseCodeKeyAndCourseUnitVal.Add(AllCoursesDS.Tables(0).Rows(j).Item("course_code").ToString, CInt(AllCoursesDS.Tables(0).Rows(j).Item("course_unit").ToString))
            dictAllCourseCodeKeyAndCourseLevelVal.Add(AllCoursesDS.Tables(0).Rows(j).Item("course_code").ToString, CInt(AllCoursesDS.Tables(0).Rows(j).Item("course_level").ToString))
            dictAllCourseCodeKeyAndCourseSemesterVal.Add(AllCoursesDS.Tables(0).Rows(j).Item("course_code").ToString, CInt(AllCoursesDS.Tables(0).Rows(j).Item("course_semester").ToString))
        Next

        Return AllCoursesDS
    End Function
    Function showBroadsheet(txtSession As String, txtDept As String, txtlevel As String, Optional strTimestamp As String = Nothing, Optional silent As Boolean = True) As DataTable
        Dim dictColHeaders As New Dictionary(Of String, String)
        Dim dtHeaders As DataSet
        Dim tmpDT As DataTable

        Dim strSQL As String = STR_SQL_ALL_BROADSHEET_WHERE_SESSION_DEPT_LEVEL_WITHOUT_TIMESTAMP
        tmpDT = mappDB.GetDataWhere(String.Format(strSQL, txtSession, txtDept, txtlevel)).Tables(0)
        If strTimestamp Is Nothing Then strTimestamp = ""   'dt.Rows(0).Item("bs_timestamp").ToString

        'NOW TO HEADERS
        strSQL = STR_SQL_ALL_BROADSHEETS_COLNAMES_WHERE_SESSION_DEPT_LEVEL
        dtHeaders = mappDB.GetDataWhere(String.Format(strSQL, txtSession, txtDept, txtlevel))
        Dim clCount As Integer = tmpDT.Columns.Count - 1        'todo: cross thread
        Dim j As Integer = 0
        Try

            For j = COURSE_START_COL To LEVEL_COL
                If (dtHeaders.Tables(0).Rows(0).Item(j) = "") Then
                    'avoid nasty errors, leave name intact
                ElseIf (tmpDT.Columns(j).ColumnName = "bs_session") Then
                ElseIf (tmpDT.Columns(j).ColumnName = "bs_department_name") Then
                ElseIf (tmpDT.Columns(j).ColumnName = "bs_faculty_name") Then
                ElseIf (tmpDT.Columns(j).ColumnName = "bs_level") Then
                Else
                    tmpDT.Columns(j).ColumnName = dtHeaders.Tables(0).Rows(0).Item(j)   'get name from first row where it as saved
                End If
                tmpDT.AcceptChanges()
                objBroadsheet.progress = j / clCount * 100
                objBroadsheet.progressStr = "Processing : " & tmpDT.Columns(j).ColumnName
            Next
            objBroadsheet.progress = 100
            objBroadsheet.progressStr = "Done! "

            tmpDT.AcceptChanges()
            Return tmpDT
        Catch ex As Exception
            objBroadsheet.progress = 0
            objBroadsheet.progressStr = ""
            If Not silent Then MsgBox("The broadsheet was not properly saved or the data has been corrupted")
            Return Nothing
        End Try
    End Function

    Function getBroadsheetForTranscript(dmatno As String, Optional txtlevel As String = "500", Optional strTimestamp As String = Nothing, Optional silent As Boolean = True) As DataTable
        Dim dictColHeaders As New Dictionary(Of String, String)
        Dim dtHeaders As DataSet
        Dim tmpDT As DataTable
        Dim dSession, dDept As String

        Dim strSQL As String = STR_SQL_EXTRACT_FROM_BROADSHEET_ALL_SUMMARY_TO_TRANSCRIPT_BY_MATNO_LEVEL
        tmpDT = mappDB.GetDataWhere(String.Format(strSQL, dmatno, txtlevel)).Tables(0)
        If strTimestamp Is Nothing Then strTimestamp = ""   'dt.Rows(0).Item("bs_timestamp").ToString
        dSession = tmpDT.Rows(0).Item("bs_session")
        dDept = tmpDT.Rows(0).Item("bs_department_name")
        'NOW TO HEADERS
        strSQL = STR_SQL_ALL_BROADSHEETS_COLNAMES_WHERE_SESSION_DEPT_LEVEL
        dtHeaders = mappDB.GetDataWhere(String.Format(strSQL, dSession, dDept, txtlevel))
        Dim clCount As Integer = tmpDT.Columns.Count - 1        'todo: cross thread
        Try
            For j = COURSE_START_COL To LEVEL_COL
                If (dtHeaders.Tables(0).Rows(0).Item(j) = "") Then
                    'avoid nasty errors, leave name intact
                ElseIf (tmpDT.Columns(j).ColumnName = "bs_session") Then
                ElseIf (tmpDT.Columns(j).ColumnName = "bs_department_name") Then
                ElseIf (tmpDT.Columns(j).ColumnName = "bs_faculty_name") Then
                ElseIf (tmpDT.Columns(j).ColumnName = "bs_level") Then
                Else
                    tmpDT.Columns(j).ColumnName = dtHeaders.Tables(0).Rows(0).Item(j)   'get name from first row where it as saved
                End If
                tmpDT.AcceptChanges()
                'objBroadsheet.progress = j / clCount * 100
                'objBroadsheet.progressStr = "Processing : " & tmpDT.Columns(j).ColumnName
            Next
            'objBroadsheet.progress = 100
            'objBroadsheet.progressStr = "Done! "

            tmpDT.AcceptChanges()
            Return tmpDT
        Catch ex As Exception
            objBroadsheet.progress = 0
            objBroadsheet.progressStr = ""
            If Not silent Then MsgBox("The transcript data was not properly saved or the data has been corrupted")
            Return Nothing
        End Try
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
