'Imports Microsoft.Office.Interop.Excel
Imports ExcelInterop = Microsoft.Office.Interop.Excel

Public Class ClassBroadsheets
    Public Delegate Sub OnPropertyChanged(ByVal sende As Object, e As ClassAnswerEventArgs)
    Public Event myEventOnPropertyChanged(ByVal sende As Object, e As ClassAnswerEventArgs) 'support for events

    Public Delegate Sub OnProgressChanged(ByVal sender As Object, e As ClassAnswerEventArgs)
    Public Event myEventOnPrgressChanged(ByVal sender As Object, e As ClassAnswerEventArgs) 'support for events

    Public Sub New()
        Try
            'Me._excelWB.FileNameWB = PROG_DIRECTORY & "\templates\broadsheet.xltx"
            _broadsheetFileName = My.Application.Info.DirectoryPath & "\templates\broadsheet.xltx"
            '_excelWB = New ExcelInterop.Workbook

        Catch ex As Exception
            MsgBox("Cannot create Excel Automation Object" & vbCrLf & ex.Message)
        End Try
    End Sub
#Region "Broadsheet Properties"
    Private _broadsheetSemester As String = ""
    Private _strMATNO As String() = Nothing
    Private _broadsheetFileName As String = Nothing
    Private _progress As Integer = 0
    Private _excelWB As ExcelInterop.Workbook
    Private _regInfoCoursesFirstSem As List(Of String)
    Private _regInfoCoursesSecondSem As List(Of String)
    Private _processedBroadsheetFileName As String = Nothing
    Public Property processedBroadsheetFileName() As String
        Get
            Return _processedBroadsheetFileName
        End Get
        Set(ByVal value As String)
            _processedBroadsheetFileName = value
        End Set
    End Property
    Public Property regInfoCoursesSecondSem() As List(Of String)
        Get
            Return _regInfoCoursesSecondSem
        End Get
        Set(ByVal value As List(Of String))
            _regInfoCoursesSecondSem = value
        End Set
    End Property
    Public Property regInfoCoursesFirstSem() As List(Of String)
        Get
            Return _regInfoCoursesFirstSem
        End Get
        Set(ByVal value As List(Of String))
            _regInfoCoursesFirstSem = value
        End Set
    End Property
    Public Property excelWB() As ExcelInterop.Workbook
        Get
            Return _excelWB
        End Get
        Set(ByVal value As ExcelInterop.Workbook)
            _excelWB = value
        End Set
    End Property
    Public Property progress() As String
        Get
            Return _progress
        End Get
        Set(ByVal value As String)
            _progress = value
            Dim e As New ClassAnswerEventArgs
            e.VariableChanged = True
            e.Ans = value
            RaiseEvent myEventOnPrgressChanged(Me, e) 'MATNOChanged
        End Set
    End Property
    Public Property broadsheetFileName() As String
        Get
            Return _broadsheetFileName
        End Get
        Set(ByVal value As String)
            _broadsheetFileName = value
            Dim e As New ClassAnswerEventArgs
            e.VariableChanged = True
            e.Ans = -1
            RaiseEvent myEventOnPropertyChanged(Me, e) 'MATNOChanged
        End Set
    End Property
    Public Property strMATNO() As String()
        Get
            Return _strMATNO
        End Get
        Set(ByVal value As String())
            _strMATNO = value
            Dim e As New ClassAnswerEventArgs
            e.VariableChanged = True
            e.Ans = -1
            RaiseEvent myEventOnPropertyChanged(Me, e) 'MATNOChanged
        End Set
    End Property
    Public Property broadsheetSemester() As String
        Get
            Return _broadsheetSemester
        End Get
        Set(ByVal value As String)
            _broadsheetSemester = value
        End Set
    End Property

#End Region


    Function openBroadsheetExcelWBInterop() As Boolean

        Dim strCriteria As String = String.Empty
        Dim startRow As Integer = 1
        Dim endRow As Integer = 200
        Dim r As Integer = 9  'starts at row 9
        Dim strSQLTemp As String = ""
        Dim i As Integer = 0
        ' Dim strArrayMATNO, strArrayNAME, strArrayCA, strArrayEXAM, strArrayTOTAL, strArraySURNAME, strArrayOtherNames As String()
        Try
            excelApp = New ExcelInterop.Application

            If _broadsheetFileName = Nothing Or Not System.IO.File.Exists(_broadsheetFileName) Then Exit Function 'todo
            excelWB = excelApp.Workbooks.Open(Me.broadsheetFileName)
            excelWS = CType(excelWB.Sheets(1), ExcelInterop.Worksheet)
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
            Return True
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Function iterateRegisteredCoursesAndAddToBroadsheetTemplate() As String()
        Dim firstSemCourses As List(Of String) = Nothing
        Dim secondSemCourses As List(Of String) = Nothing

        ' possibilities: secondSemCourses.Contains(), secondSemCourses.FindAll, secondSemCourses.ToLookup


        'firstsemcourses.sort ?   
        'for each matno in me.reginfo
        ' in not firstsemcourses.contains(Me._regInfoCoursesFirstSem.course(i)) then firstsemcourses.add(Me.reginfo.course(i))

        'next
        Return Nothing
    End Function

    'Function openBroadsheetExcelWB() As Boolean
    '    Me.excelWB.openBroadsheetExcelWB()

    '    Return True
    'End Function
End Class
