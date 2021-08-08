

Imports System.Data.OleDb
Imports Microsoft.VisualBasic.FileIO
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop

Public Class ClassExcel
    Public Delegate Sub OnPropertyChanged(ByVal sende As Object, e As ClassAnswerEventArgs)
    Public Event myEventOnPropertyChanged(ByVal sende As Object, e As ClassAnswerEventArgs) 'support for events

    Private _fileNameWB As String
    Private _previewImageFileName As String
    Private slideStrValue As String
    Private _font As New Font("Arial", 50, FontStyle.Bold)
    Private _settings As Dictionary(Of String, String)
    Private _WBDataSet As DataSet

    Public Property WBDataSet() As DataSet
        Get
            Return _WBDataSet
        End Get
        Set(ByVal value As DataSet)
            _WBDataSet = value
        End Set
    End Property
    Public Property FileNameWB() As String
        Get
            Return _fileNameWB
        End Get
        Set(ByVal value As String)
            _fileNameWB = value
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


    Public Property FileName() As String
        Get
            Return _previewImageFileName
        End Get
        Set(ByVal value As String)
            _previewImageFileName = value
        End Set
    End Property


    Public Sub New()
        Try
            Me._font = New Font("Arial", 50, FontStyle.Bold)
            'USER_DIRECTORY
            Me._fileNameWB = USER_DIRECTORY & "\Samples\Result.xlsx"
            Me.slideStrValue = "In the begining God created the heaven and the earth."
            Me.settings = getSettings(True)
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try
    End Sub

    Function openBroadsheetExcelWB() As Boolean

        Dim strCriteria As String = String.Empty
        Dim startRow As Integer = 1
        Dim endRow As Integer = 200
        Dim r As Integer = 9  'starts at row 9
        Dim strSQLTemp As String = ""
        Dim i As Integer = 0
        Dim strArrayMATNO, strArrayNAME, strArrayCA, strArrayEXAM, strArrayTOTAL, strArraySURNAME, strArrayOtherNames As String()
        Try
            excelApp = New Excel.Application

            If objBroadsheet.broadsheetFileName = Nothing Or Not System.IO.File.Exists(objBroadsheet.broadsheetFileName) Then Exit Function 'todo
            excelWB = excelApp.Workbooks.Open(objBroadsheet.broadsheetFileName)
            excelWS = CType(excelWB.Sheets(1), Excel.Worksheet)
            'show it
            excelApp.Visible = False

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
            objBroadsheet.progress = 30

            '-----------------------------------------
            '#  Pupulate broadsheet with data
            '------------------------------------------
            'objbroadsheet.sturecord.MATNO.sort()
            'Add serial numbers, matno etc
            For i = startRow To 50
                excelWS.Cells(i, ExcelColumns.colA) = i
                excelWS.Cells(i, ExcelColumns.colB) = i * 345 'TODO: place holder for MAT
                excelWS.Cells(i, ExcelColumns.colC) = "=D" & i & "+E" & i ' "First Name SURNAME" 'TODO: place holder Name
                excelWS.Cells(i, ExcelColumns.colD) = "First Name" & i
                excelWS.Cells(i, ExcelColumns.colE) = "SURNAME" & i
                excelWS.Cells(i, ExcelColumns.colF) = "CPE333/2/55, CPE311/3/75," 'TODO: place holder CO  objbroadsheet.sturecord(MATNO).co
                excelWS.Cells(i, ExcelColumns.colG) = "*79" 'TODO: place holder course  objbroadsheet.sturecord(MATNO).co
                excelWS.Cells(i, ExcelColumns.colH) = "80" 'objbroadsheet.sturecord(MATNO).COURSE002.score
                excelWS.Cells(i, ExcelColumns.colI) = "68" 'objbroadsheet.sturecord(MATNO).COURSE003.score
                '...


                excelWS.Cells(i, ExcelColumns.colO) = "3" 'objbroadsheet.sturecord(MATNO).COURSE003.FAILED1STsEM  or calcFailed(courses1stSem)
                excelWS.Cells(i, ExcelColumns.colP) = "24" 'objbroadsheet.sturecord(MATNO).COURSE003.Passed1STsEM  or calcPassed(courses1stSem)
                excelWS.Cells(i, ExcelColumns.colQ) = "27"


                excelWS.Cells(i, ExcelColumns.colAJ) = "3.579" 'GP AJ, Class AK, Status AL
                excelWS.Cells(i, ExcelColumns.colAK) = "2.1"
                excelWS.Cells(i, ExcelColumns.colAJ) = "A"


                excelWS.Cells(i, ExcelColumns.colAM) = "CPE211 (WAIVED)" 'cOURSE fAILED tRAILED
                If i Mod 2 = 0 Then objBroadsheet.progress = objBroadsheet.progress + 1
                GC.KeepAlive(Me)
            Next

            excelApp.Visible = True

            objBroadsheet.progress = 95 'update progress bar
        Catch ex As Exception
            Throw ex
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

            If objResults.resultFileName = Nothing Or Not System.IO.File.Exists(objResults.resultFileName) Then Exit Function 'todo
            excelWB = excelApp.Workbooks.Open(objResults.resultFileName)
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



            objResults.progress = 30 'update progress bar
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
            If i Mod 2 = 0 Then objResults.progress = objResults.progress + 1 'update progress bar
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

        objResults.progress = 80 'update progress
        ds.Tables.Add(dt)

        Return ds

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

    Function getSettings(Optional useDefault As Boolean = False) As Dictionary(Of String, String)
        Try
            Dim tmp As New Dictionary(Of String, String)
            If useDefault = True Then
                tmp.Add("fontSize", "50")
                tmp.Add("fontFamily", "Arial")
                tmp.Add("max_Char", "160")

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



End Class
