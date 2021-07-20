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
            connStr = My.Settings.dbConnectionString '
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


    Public Function GetDataWhere(dstrSQL As String, Optional dTableName As String = "Table") As DataSet
        Try
            Using xConn As New OleDb.OleDbConnection(ModuleGeneral.STR_connectionString)
                Try
                    xConn.Open()
                Catch ex1 As Exception
                    xConn.ConnectionString = ModuleGeneral.STR_connectionString32
                    xConn.Open()
                End Try
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

    Public Function GetDataWhereCloud(dstrSQL As String, Optional dTableName As String = "Table") As DataSet
        Dim retVal As DataSet = Nothing
        Try

            Using xConn As New MySqlConnection(ModuleGeneral.STR_connectionStringCloud)

                xConn.Open()


                Dim cmd As New MySqlCommand(dstrSQL, xConn)
                Dim myDA As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim myDataSet As DataSet = New DataSet()
                myDA.Fill(myDataSet, dTableName)
                xConn.Close() 'safely close it
                retVal = myDataSet
            End Using
        Catch ex As Exception
            ' MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'ClientScript.registerstartupscript(TypeOf Me, "myalert", "alert('" & _msg & "');", True)

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
                Try
                    xConn.Open()
                Catch ex1 As Exception
                    xConn.ConnectionString = ModuleGeneral.STR_connectionString
                    xConn.Open()
                End Try
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
                Try
                    xConn.Open()
                Catch ex1 As Exception
                    xConn.ConnectionString = ModuleGeneral.STR_connectionString
                    xConn.Open()
                End Try
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
        Dim returnVal As String = ""
        Try
            Using xConn As New OleDb.OleDbConnection(ModuleGeneral.STR_connectionString)
                Try
                    xConn.Open()
                Catch ex1 As Exception
                    xConn.ConnectionString = ModuleGeneral.STR_connectionString
                    xConn.Open()
                End Try
                Dim cmdLocal As New OleDb.OleDbCommand(dstrSQL, xConn)
                cmdLocal.ExecuteNonQuery()  'BeginExecuteNonQuery()
                closeConn(xConn) 'safely close it
            End Using
            Return True
        Catch ex As Exception
            Return False
            'logError("Database access problem, connect and try again" & vbCrLf & ex.Message)
            ' MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function

    Public Function InsertRecord(dstrSQL As String) As String
        'ToDo: optimize for speed
        'support parameters
        Dim returnVal As String = ""
        Try
            Using xConn As New OleDb.OleDbConnection(ModuleGeneral.STR_connectionString)
                Try
                    xConn.Open()
                Catch ex1 As Exception
                    xConn.ConnectionString = ModuleGeneral.STR_connectionString
                    xConn.Open()
                End Try
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
    Public Fun
    'TODO: incomplete fxn
    Function getDataReader(TableName As String, Optional isLocal As Boolean = True) As Boolean
        Try
            Using xConn As New OleDb.OleDbConnection(ModuleGeneral.STR_connectionString)

                Try
                    xConn.Open()
                Catch ex1 As Exception
                    xConn.ConnectionString = ModuleGeneral.STR_connectionString
                    xConn.Open()
                End Try
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

    Public Function bulkInsertDB(dt As DataTable, strSQL As String, tmpTableName As String) As DataTable
        Using xConn As New OleDb.OleDbConnection(ModuleGeneral.STR_connectionString)

            Try
                xConn.Open()
            Catch ex1 As Exception
                xConn.ConnectionString = ModuleGeneral.STR_connectionString
                xConn.Open()
            End Try
            Dim cmd As OleDbCommand = New OleDbCommand(strSQL, xConn)
            Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            cmd.ExecuteNonQuery()

            closeConn(cmd.Connection)

            'Pull the table records and insert new
            Using adapter = New OleDbDataAdapter("SELECT * FROM " & tmpTableName, xConn)

                Using builder = New OleDbCommandBuilder(adapter)
                    'adapter.InsertCommand = builder.GetInsertCommand()
                    adapter.Update(dt)
                End Using
                closeConn(adapter.SelectCommand.Connection)
            End Using
            closeConn(xConn)
        End Using
        Return dt
    End Function
    Public Function manualRegInsertDB(dt As DataTable) As Boolean
        Using xConn As New OleDb.OleDbConnection(ModuleGeneral.STR_connectionString)
            Try
                xConn.Open()
            Catch ex1 As Exception
                xConn.ConnectionString = ModuleGeneral.STR_connectionString
                xConn.Open()
            End Try
            '1. check for duplicates and delete
            Dim sql As String = ""  'todo: move sql to module
            'access
            Dim cmd As New OleDbCommand
            For Each row As DataRow In dt.Rows
                'todo: use parameters
                sql = "INSERT INTO Reg (matno,session_idr,CourseCode_1,CourseCode2, Fees_Status, level,dept_idr) "
                sql = sql & "VALUES (" & row.Item("matno") & ",'" & row.Item("session_idr") & "','" & row.Item("session_idr") & "'," & row.Item("CourseCode_1") & "," & row.Item("CourseCode_2") & ",'" & row.Item("Fees_Status") & "','" & row.Item("level") & "','" & row.Item("dept_idr") & "');"

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

    Public Function genericManualInsertDB(dt As DataTable, sql As String, values As String()) As Boolean
        Using xConn As New OleDb.OleDbConnection(ModuleGeneral.STR_connectionString)
            Try
                xConn.Open()
            Catch ex1 As Exception
                xConn.ConnectionString = ModuleGeneral.STR_connectionString
                xConn.Open()
            End Try
            '1. check for duplicates and delete

            'access
            Dim cmd As New OleDbCommand
            Dim tableValues As String()
            'Dim da As OleDbDataAdapter
            For Each row As DataRow In dt.Rows
                tableValues = row.ItemArray
                'todo: use parameters
                String.Format(sql, tableValues) 'add values
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
    Public Function manualStudentsInsertDB(dt As DataTable) As Boolean
        Using xConn As New OleDb.OleDbConnection(ModuleGeneral.STR_connectionString)
            Try
                xConn.Open()
            Catch ex1 As Exception
                xConn.ConnectionString = ModuleGeneral.STR_connectionString
                xConn.Open()
            End Try
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

    Public Function manualInsertDB(dt As DataTable, dSession As String, dDept As Integer, dCourse As String) As Boolean
        Using xConn As New OleDb.OleDbConnection(ModuleGeneral.STR_connectionString)
            Try
                xConn.Open()
            Catch ex1 As Exception
                xConn.ConnectionString = ModuleGeneral.STR_connectionString
                xConn.Open()
            End Try
            '1. check for duplicates and delete
            Dim sql As String = "INSERT INTO results (result_id, student_idr, total) "  'todo: move sql to module
            'access
            Dim cmd As New OleDbCommand
            'Dim da As OleDbDataAdapter
            Dim id As Long = 0

            id = mappDB.getMaxID("select Max(Results.result_id) AS MaxOfresult_id FROM Results")
            For Each row As DataRow In dt.Rows
                id = id + 1
                'todo: use parameters
                sql = "INSERT INTO results (result_id,s_n,matno,fullname,total,department_idr, course_code_idr, session_idr) "
                sql = sql & "VALUES (" & id & "," & row.Item("sn") & ",'" & row.Item("matno") & "','" & row.Item("name") & "'," & row.Item("score") & "," & dDept & ",'" & dCourse & "','" & dSession & "');"

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
            Try
                xConn.Open()
            Catch ex1 As Exception
                xConn.ConnectionString = ModuleGeneral.STR_connectionString
                xConn.Open()
            End Try

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
        Dim retVal As Integer = 1
        If forceStrict = True Then
            retVal = CInt(mappDB.GetRecordWhere(String.Format("SELECT dept_id FROM departments WHERE dept_name='{0}'", strDept)))
        Else
            'todo: Where Like in sql
            retVal = CInt(mappDB.GetRecordWhere(String.Format("SELECT dept_id FROM departments WHERE dept_name='{0}'", strDept)))

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
            Try
                xConn.Open()
            Catch ex1 As Exception
                xConn.ConnectionString = ModuleGeneral.STR_connectionString
                xConn.Open()
            End Try
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
