
Imports System.Data.OleDb
Imports Microsoft.VisualBasic.FileIO
Imports System.Data.SqlClient
Imports ExcelInterop = Microsoft.Office.Interop.Excel
Imports System.Drawing

Public Class ClassExcelResult
    Structure resultScore
        Dim session As String
        Dim score As Integer
        Dim grade As String
    End Structure

    Public Delegate Sub OnPropertyChanged(ByVal sende As Object, e As ClassAnswerEventArgs)
    Public Event myEventOnPropertyChanged(ByVal sende As Object, e As ClassAnswerEventArgs) 'support for events

    Private resultStrValue As String
    Private fontValue As New Font("Arial", 50, FontStyle.Bold)
    Private resultValue As String()
    Private resultfileNameValue As String
    Private _resultTemplateFileName As String
    Private _progress As Integer
    Private _NetConneced As Boolean

    Private _settings As Dictionary(Of String, String)



    Private _resultFlag As String = ""
    Private _excelVersion As String = ""
    Private _backgroundImage As Image = Nothing




    Public Property sresultIsAltered() As Boolean     'Raises an event
        Get
            Return _resultFlag
        End Get
        Set(ByVal value As Boolean)
            _resultFlag = value
            Dim e As New ClassAnswerEventArgs
            e.VariableChanged = True
            e.Ans = -1
            RaiseEvent myEventOnPropertyChanged(Me, e)
        End Set
    End Property

    Public Property settings() As Dictionary(Of String, String)
        Get
            Return _settings
        End Get
        Set(ByVal value As Dictionary(Of String, String))
            _settings = value
        End Set
    End Property

    Public Property NetConneced() As Boolean
        Get
            Return _NetConneced
        End Get
        Set(ByVal value As Boolean)
            _NetConneced = value
        End Set
    End Property
    Public Property excelVersion() As String
        Get
            Return _excelVersion
        End Get
        Set(ByVal value As String)
            _excelVersion = value
        End Set
    End Property
    Public Property progress() As Integer
        Get
            Return _progress
        End Get
        Set(ByVal value As Integer)
            _progress = value
        End Set
    End Property

    Public Property resultTemplateFileName() As String
        Get
            Return _resultTemplateFileName
        End Get
        Set(ByVal value As String)
            _resultTemplateFileName = value
        End Set
    End Property
    Public Property resultFilename() As String
        Get
            Return resultfileNameValue
        End Get
        Set(ByVal value As String)
            resultfileNameValue = value
        End Set
    End Property
    Public Property font() As Font
        Get
            Return fontValue
        End Get
        Set(ByVal value As Font)
            fontValue = value
        End Set
    End Property

    Public Sub New()
        Try
            Me._excelVersion = "2013"
            Me.fontValue = New Font("Arial", 14, FontStyle.Bold)
            'USER_DIRECTORY
            Me._resultTemplateFileName = PROG_DIRECTORY & "\templates\result.xlsx"
            Me._resultFlag = False
            'load defaults
            Me.settings = getSettings(True)
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try
    End Sub


    Declare Function Win32MessageBox Lib "user32.dll" Alias "MessageBox" (ByVal hWnd As Integer, ByVal txt As String, ByVal caption As String, ByVal type As Integer) As Integer


    Function getSettings(Optional useDefault As Boolean = False) As Dictionary(Of String, String)
        Try
            Dim tmp As New Dictionary(Of String, String)
            If useDefault = True Then
                tmp.Add("mode", "driver")
                tmp.Add("fontSize", "14")
                tmp.Add("fontFamily", "Arial")
                tmp.Add("max_Char", "160")
                tmp.Add("charPerLine", "30")
                tmp.Add("maxLine", "7")
                tmp.Add("foreColor", "-256") 'yellow in argb
                tmp.Add("shadowColor", "-16777216") 'black in argb
                tmp.Add("backgroundImage", "")
                tmp.Add("ip", "127.0.0.1")
                tmp.Add("font", "Arial, 50.25pt, style=Bold") 'TODO: store FONT like this
                tmp.Add("color", "255, 255 ,0")

            Else
                tmp = Me._settings
            End If
            Return tmp
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try
    End Function

    Function Array2sTR(s As String(), Optional removeSlash As Boolean = False, Optional addCrLf As Boolean = False) As String
        Try
            Dim tmpStr As String = ""

            For i = 0 To s.Length - 1
                If removeSlash = True Then
                    tmpStr = tmpStr & s(i) & " "
                ElseIf addCrLf = True Then
                    tmpStr = tmpStr & s(i) & vbCrLf
                Else

                    tmpStr = tmpStr & s(i) & "\"
                End If

            Next
            Return tmpStr
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try
    End Function
    Function str2Array(s As String) As String()
        Try
            Dim tmpStr As String() = {""}


            tmpStr = s.Split("\n")
            'tmpStr = s.Substring(0, 0)
            Return tmpStr
            tmpStr = Nothing
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try
    End Function
    Function getConn(Optional sync As Boolean = False, Optional IsWeb As Boolean = False) As OleDb.OleDbConnection
        'TODO: connection management
        'conn.dispose etc
        Try
            Dim connStr As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & My.Application.Info.DirectoryPath & "\db\db.mdb" 'USER_DIRECTORY & "\db\db.mdb
            If IsWeb = True Then connStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & My.Application.Info.DirectoryPath & "\db\db.mdb"
            Return New OleDb.OleDbConnection(connStr)
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try
    End Function

    Function getFromDBResult(str As String) As String

        'SELECT SONG.SONGID, SONG.TITLE_1, SONG.LYRICS
        'FROM SONG
        'WHERE (((SONG.TITLE_1)="A New Commandment"));
        Try
            Dim dQuery = ""
            Dim conn As OleDb.OleDbConnection
            conn = Me.getConn(, True)
            Dim cmd As New OleDbCommand
            cmd.CommandType = CommandType.Text

            'Just one value
            cmd.CommandText = "SELECT * "
            cmd.CommandText = cmd.CommandText & "FROM TABLERESULTS "
            cmd.CommandText = cmd.CommandText & "WHERE (TABLERESULTS.Session_idr = @SESSION);"
            cmd.Connection = conn

            ' Create a SqlParameter for each parameter in the stored procedure.
            Dim titleParam As New OleDbParameter("@SESSION", str)
            cmd.Parameters.Add(titleParam)

            Dim reader As OleDbDataReader
            Dim previousConnectionState As ConnectionState = conn.State
            Try
                If conn.State = ConnectionState.Closed Then

                    conn.Open() 'TODO: throws excepion if mdb file no found
                End If
                reader = cmd.ExecuteReader()    'TODO: Error "1 Joh 2:4"
                Dim noRecords As Integer = reader.FieldCount
                Dim resultTitle As String = ""



                Dim iCount As Integer = 0
                Using reader
                    While reader.Read
                        resultTitle = (CStr(reader.GetValue(2))) 'get the Result
                        iCount = iCount + 1
                    End While
                End Using
                Return resultTitle
            Finally
                If previousConnectionState = ConnectionState.Closed Then
                    conn.Close()
                End If
            End Try


        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try
    End Function
    Function getFromDBResults(str As String) As String()
        Try
            Dim dQuery = ""
            Dim conn As OleDb.OleDbConnection
            conn = Me.getConn(, True)
            Dim cmd As New OleDbCommand
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "SELECT * "
            cmd.CommandText = cmd.CommandText & "FROM TABLERESULTS "
            cmd.CommandText = cmd.CommandText & "WHERE (TABLERESULTS.Session_idr = @SESSION);"
            cmd.Connection = conn


            ' Create a SqlParameter for each parameter in the stored procedure.

            Dim sParam As New OleDbParameter("@SESSION", str)
            cmd.Parameters.Add(sParam)

            Dim reader As OleDbDataReader
            Dim previousConnectionState As ConnectionState = conn.State
            Try
                If conn.State = ConnectionState.Closed Then

                    conn.Open() 'TODO: throws excepion if mdb file no found
                End If
                reader = cmd.ExecuteReader()    'TODO: Error "1 Joh 2:4"
                Dim noRecords As Integer = reader.FieldCount
                Dim resultTitle As String()
                Dim sresultTitleList As New List(Of String)


                Dim iCount As Integer = 0
                Using reader
                    While reader.Read
                        sresultTitleList.Add(CStr(reader.GetValue(1)))
                        iCount = iCount + 1
                    End While
                    resultTitle = sresultTitleList.ToArray


                End Using
                Return resultTitle
            Finally
                If previousConnectionState = ConnectionState.Closed Then
                    conn.Close()

                End If
            End Try


        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try
    End Function

    Function getFromDBResultssDataset(dSession As String) As DataSet
        Dim myDataSet As DataSet = New DataSet()
        Try
            Using xConn As New OleDb.OleDbConnection(ModuleGeneral.STR_connectionString)
                Try
                    xConn.Open()
                Catch ex1 As Exception
                    xConn.ConnectionString = ModuleGeneral.STR_connectionString
                    xConn.Open()
                End Try
                Dim strSQL As String = String.Format(STR_SQL_QUERY_RESULT_STUDENT_COURSE_WHERE_SESSION, dSession)

                Dim cmd As New OleDbCommand
                cmd.CommandType = CommandType.Text
                cmd.CommandText = strSQL
                cmd.Connection = xConn
                Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)

                myDA.Fill(myDataSet, "results")
                'dgw.DataSource = myDataSet.Tables("TableResults").DefaultView
                xConn.Close()
            End Using

            Return myDataSet
        Catch ex As Exception
            Throw ex
        Finally
            'closeconn(xConn)
            'can cause error
        End Try
    End Function
    Function getUniqueID(dtable As String, dField As String) As Integer
        Try
            Dim dQuery = ""
            Dim conn As OleDb.OleDbConnection
            conn = Me.getConn(, True)
            Dim cmd As New OleDbCommand
            cmd.CommandType = CommandType.Text

            'Just one value
            cmd.CommandText = "SELECT  Max(" & dtable & "." & dField & ") AS MaxID "
            cmd.CommandText = cmd.CommandText & "FROM " & dtable & ";"
            cmd.Connection = conn

            Dim reader As OleDbDataReader
            Dim previousConnectionState As ConnectionState = conn.State
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open() 'TODO: throws excepion if mdb file no found
                End If
                reader = cmd.ExecuteReader()
                Dim noRecords As Integer = reader.FieldCount
                Dim maxID As Integer = 0
                'Dim ddd As ListControl

                Dim iCount As Integer = 0
                Using reader
                    While reader.Read
                        maxID = reader.GetValue(0)
                        iCount = iCount + 1
                    End While
                    If iCount > 1 Then maxID = -1 ' there was an error

                End Using
                Return maxID + 1
            Finally
                If previousConnectionState = ConnectionState.Closed Then
                    conn.Close()

                End If
            End Try
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try
    End Function
    Function insertIntoDBResult(score As Integer, coursecode As String, matno As String) As Boolean
        Try
            Dim strSQL As String = "INSERT INTO TableResults (id, coursecode, matno, score) "
            'strSQL = strSQL & "VALUES ('985', 'My Title', 'My lyrics', 'My Authour');"
            strSQL = strSQL & "VALUES (@id, @coursecode, @matno, @score);"
            Dim cmd As New OleDbCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = strSQL
            cmd.Connection = Me.getConn(, True)
            ' Create a SqlParameter for each parameter in the stored procedure.
            Dim idParam As New OleDbParameter("@id", getUniqueID("TableResults", "id").ToString)
            Dim titleParam As New OleDbParameter("@coursecode", coursecode) ' "a%")
            Dim lyricsParam As New OleDbParameter("@matno", matno)
            Dim authourParam As New OleDbParameter("@score", score)

            cmd.Parameters.Add(idParam)
            cmd.Parameters.Add(titleParam)
            cmd.Parameters.Add(lyricsParam)
            cmd.Parameters.Add(authourParam)

            If cmd.Connection.State = ConnectionState.Closed Then
                cmd.Connection.Open() 'TODO: throews excepion if mdb file no found
            End If
            cmd.ExecuteNonQuery()

            cmd.Connection.Close()
            cmd.Connection.Dispose()
            cmd.Dispose()

            Return True
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try
    End Function

    Function searchDBResult(str As String, sessionStart As String, sessionEnd As String) As String()
        Dim conn As New OleDb.OleDbConnection
        Dim previousConnectionState As ConnectionState
        Try
            conn = Me.getConn()
            previousConnectionState = conn.State
        Catch
        End Try


        Try
            Dim dQuery = ""


            Dim cmd As New OleDbCommand
            cmd.CommandType = CommandType.Text

            'Genesis 1 (ALL VERSES)
            cmd.CommandText = "SELECT * "
            cmd.CommandText = cmd.CommandText & "FROM TableResults "
            cmd.CommandText = cmd.CommandText & "WHERE (((TableResults.matno) like @STR) And "
            cmd.CommandText = cmd.CommandText & "(TableResults.Session)>=" & sessionStart & " And (TableResults.Session)<=" & sessionEnd & ");"
            ''TIP: Problem with OLEDB and Access. canot use Like  in query 
            ''FIXED: use % wildcard instead of *
            Dim strParam As New OleDbParameter("@STR", "%" & str & "%")
            cmd.Parameters.Add(strParam)

            cmd.Connection = conn

            Dim reader As OleDbDataReader
            If conn.State = ConnectionState.Closed Then
                conn.Open() 'TODO: throews excepion if mdb file no found
            End If
            reader = cmd.ExecuteReader()    'TODO: Error "1 Joh 2:4, 1 peter etc"
            Dim noRecords As Integer = reader.RecordsAffected
            Dim dResult(400) As String
            'Dim ddd As ListControl

            Dim iCount As Integer = 0
            Using reader
                While reader.Read
                    Console.WriteLine(reader.GetValue(0))
                    dResult(iCount) = reader.GetValue(0)

                    If iCount >= 30 Then Exit While
                    iCount = iCount + 1
                End While
                ReDim Preserve dResult(0 To iCount - 1)
            End Using
            Return dResult

        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
            If previousConnectionState = ConnectionState.Closed Then
                conn.Close()
            End If
        End Try
    End Function



    Public Function loadAllResultFiles() As String()
        Try
            Dim fileExists As Boolean
            Dim filename As String = Nothing
            Dim dVerStr(0 To 500) As String
            Dim iCount As Integer = 0
            For Each file In FileSystem.GetFiles(My.Application.Info.DirectoryPath & "\templates\") 'leave this in program files so its readonly
                filename = file
                fileExists = My.Computer.FileSystem.FileExists(file)
                If fileExists Then
                    dVerStr(iCount) = System.IO.Path.GetFileNameWithoutExtension(file)
                    iCount = iCount + 1
                End If
            Next
            ReDim Preserve dVerStr(0 To iCount - 1)
            Return dVerStr
            dVerStr = Nothing
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try
    End Function




End Class
