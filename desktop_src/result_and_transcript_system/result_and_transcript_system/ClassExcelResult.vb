
Imports System.Data.OleDb
Imports Microsoft.VisualBasic.FileIO
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop

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
            Me._resultTemplateFileName = USER_DIRECTORY & "\templates\results.xlsx"
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

    Public Sub combolist(ByVal this_sql As String, ByVal this_value As String, ByVal this_member As String, ByVal this_cbo As ListBox)
        Try
            Dim oConn As OleDbConnection = Me.getConn(, True)
            Dim oad As New OleDbDataAdapter(this_sql, oConn)
            Dim ds As New DataSet
            Dim strtmp As String = this_cbo.Text.ToString : this_cbo.Text = String.Empty
            oad.Fill(ds)

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

            oConn.Close()
            oConn.Dispose()
            oConn = Nothing
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try
    End Sub


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
    Function importResultFromExcelWB() As DataSet


        Dim strCriteria As String = String.Empty
        Dim startRow As Integer = 1
        Dim endRow As Integer = 200
        Dim r As Integer = 9  'starts at row 9
        Dim strSQLTemp As String = ""
        Dim i As Integer = 0
        Dim strArrayMATNO, strArrayNAME, strArrayCA, strArrayEXAM, strArraySCORE, strArraySURNAME, strArrayOtherNames As String()
        Try
            excelApp = New Excel.Application

            If Me.resultfileNameValue = Nothing Or Not System.IO.File.Exists(Me.resultfileNameValue) Then Exit Function 'todo
            excelWB = excelApp.Workbooks.Open(Me.resultfileNameValue)
            excelWS = CType(excelWB.Sheets(1), Excel.Worksheet)

            Dim strCellContent As String = ""
            Dim MATNoFound As Boolean = False
            r = 8 'textbox
            'Search for MATNO Column
            For i = 1 To 20
                strCellContent = excelWS.Cells(i, ExcelColumns.colB).text

                If strCellContent.Contains("MAT") Then
                    startRow = i + 1
                    MATNoFound = True
                    Exit For
                End If
            Next
            If MATNoFound = False Then
                For i = 1 To 20
                    strCellContent = excelWS.Cells(i, ExcelColumns.colA).text

                    If strCellContent.Contains("MAT") Then
                        startRow = i + 1
                        MATNoFound = True
                        Exit For
                    End If
                Next
            End If

            'get header row

            'check for last row
            'TODO: use a better method to check for usedrange
            'endRow = excelWS.UsedRange.Rows.Count
            For i = startRow To 300
                strCellContent = excelWS.Cells(i, ExcelColumns.colB).text

                If strCellContent.ToString.Length = 0 Then
                    endRow = i - 1
                    Exit For
                End If
            Next



            Me.progress = 30 'update progress bar
        Catch ex As Exception
            Throw ex
        End Try

        '-----------------------------
        '# display on datagrid
        '-----------------------------
        ReDim strArrayMATNO(0 To endRow - startRow - 1)
        ReDim strArrayCA(0 To endRow - startRow - 1)
        ReDim strArrayNAME(0 To endRow - startRow - 1)
        ReDim strArrayEXAM(0 To endRow - startRow - 1)
        ReDim strArraySCORE(0 To endRow - startRow - 1)
        ReDim strArraySURNAME(0 To endRow - startRow - 1)
        ReDim strArrayOtherNames(0 To endRow - 1)
        's/n, matno, name, ca, exam, total, surname, othernames
        For i = startRow To endRow - 1
            strArrayMATNO(i - startRow) = excelWS.Cells(i, ExcelColumns.colB).text
            strArrayNAME(i - startRow) = excelWS.Cells(i, ExcelColumns.colC).text
            strArrayCA(i - startRow) = excelWS.Cells(i, ExcelColumns.colD).text
            strArrayEXAM(i - startRow) = excelWS.Cells(i, ExcelColumns.colE).text
            strArraySCORE(i - startRow) = excelWS.Cells(i, ExcelColumns.colF).text
            'it is possible that fewer columns exist
            If i > 58 Then
                Debug.Print("Few cols")
            End If
            If excelWS.Cells(i, ExcelColumns.colG).text.ToString.Length = 0 Then
                strArraySURNAME(i - startRow) = ""
            Else
                strArraySURNAME(i - startRow) = excelWS.Cells(i, ExcelColumns.colG).text
            End If
            If excelWS.Cells(i, ExcelColumns.colH).text.ToString.Length = 0 Then
                strArrayOtherNames(i - startRow) = ""
            Else
                strArrayOtherNames(i - startRow) = excelWS.Cells(i, ExcelColumns.colH).text
            End If
            If i Mod 2 = 0 Then Me.progress = Me.progress + 1 'update progress bar
        Next


        '# Dataset creation 
        '--------------------------
        'Very good!
        Dim ds As New DataSet
        Dim dt As DataTable
        Dim dr As DataRow
        Dim snCoulumn, matnoCoulumn, nameCoulumn As DataColumn

        Dim caCoulumn, scoreCoulumn, examCoulumn, surnameCoulumn, otherNameCoulumn As DataColumn

        dt = New DataTable()
        snCoulumn = New DataColumn("SN", Type.GetType("System.Int32"))
        matnoCoulumn = New DataColumn("MATNO", Type.GetType("System.String"))
        nameCoulumn = New DataColumn("NAME", Type.GetType("System.String"))
        caCoulumn = New DataColumn("CA", Type.GetType("System.String")) ' Type.GetType("System.Double"))
        examCoulumn = New DataColumn("EXAM", Type.GetType("System.String")) ' Type.GetType("System.Double"))
        scoreCoulumn = New DataColumn("SCORE", Type.GetType("System.String")) ' Type.GetType("System.Double"))
        surnameCoulumn = New DataColumn("SURNAME", Type.GetType("System.String"))
        otherNameCoulumn = New DataColumn("OtherNames", Type.GetType("System.String"))

        dt.TableName = "Result"
        dt.Columns.Add(snCoulumn)
        dt.Columns.Add(matnoCoulumn)
        dt.Columns.Add(nameCoulumn)
        dt.Columns.Add(caCoulumn)
        dt.Columns.Add(examCoulumn)
        dt.Columns.Add(scoreCoulumn)
        dt.Columns.Add(surnameCoulumn)
        dt.Columns.Add(otherNameCoulumn)


        For i = 0 To strArrayMATNO.Length - 1
            dr = dt.NewRow()
            dr("SN") = i + 1
            dr("MATNO") = strArrayMATNO(i)

            dr("NAME") = strArrayNAME(i).ToString
            dr("CA") = strArrayCA(i).ToString
            dr("EXAM") = strArrayEXAM(i).ToString
            dr("SCORE") = strArraySCORE(i).ToString
            dr("SURNAME") = strArraySURNAME(i).ToString
            dr("OtherNames") = "Firstname SURNAME"
            dt.Rows.Add(dr)


        Next

        Me.progress = 80 'update progress
        ds.Tables.Add(dt)



        'clean up
        Try

            excelApp.Quit()
            'clean up variables
            mappDB.close()
            r = Nothing
            excelWS = Nothing
            excelWB = Nothing
            excelApp = Nothing
            GC.Collect() 'Best way to close excel NOTE: It works in release but youmay not notice in debug mode

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return ds

        'Scrap stuff--------------------
        'excelApp.Visible = True 'TODO: check
        'excelApp.ExecuteExcel4Macro()
        'excelApp.Version

        'excelWS.Cells.Range("B" & startRow & ":B" & r).Copy()
        'Debug.Print(My.Computer.Clipboard.GetData("range").ToString)
        'strMATNO = My.Computer.Clipboard.GetData("range")

        'Dim strFormula As String = "H{0} + I{0} + J{0}" ' "=H9 + I9 + J9"
        'If excelApp.GetOpenFilename = objResults.resultFileName Then
        'End If
        'excelWS.UsedRange.Rows.Count,  'excelWS.UsedRange.FillDown(), 'excelWS.UsedRange.Hidden, 'excelWS.UsedRange.RowHeight = 3
        'excelWS.UsedRange.ShrinkToFit, 'excelWS.UsedRange.Cells.Text
        'If r > 6 Then Call selectCells("B9:B" & r)


        'With excelWS.Cells.Range(_range).Borders(Excel.XlBordersIndex.xlEdgeLeft)
        'excelWS.Cells.Range("B" & startRow & ":B" & r).Select() 'select rows

        'dr = dt.NewRow()
        'dr("SN") = 1
        'dr("MATNO") = "ENG0607721"
        'dr("CA") = 20
        'dr("Score") = 60
        'dr("Total") = 80
        'dr("Name") = "Firstname SURNAME"
        'dt.Rows.Add(dr)
    End Function
    'Public Function creatDataSetFromArray(strArrayMAT As String(), strArrayCA As String(), strArrayEXAM As String(),
    '                                      strArrayTOTAL As String(), strArraySURNAME As String(), strArrayOtherNames As String()) As DataSet
    '    'Works perfectly
    '    'Return ds
    'End Function
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

    Function getFromDBResultssDataset() As DataSet
        Try
            Dim strSQL As String = "SELECT * FROM  TableResults"
            Dim cmd As New OleDbCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = strSQL
            cmd.Connection = Me.getConn(, True)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "TableResults")
            ' dgw.DataSource = myDataSet.Tables("TableResults").DefaultView
            Return myDataSet
        Catch ex As Exception
            Throw ex
        Finally
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
