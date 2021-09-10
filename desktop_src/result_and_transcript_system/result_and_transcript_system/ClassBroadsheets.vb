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
    Function createDataSetBS(strArrayMATNO As String()) As DataSet
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

            'dr("NAME") = strArrayNAME(i).ToString
            'dr("CA") = strArrayCA(i).ToString
            'dr("EXAM") = strArrayEXAM(i).ToString
            'dr("SCORE") = strArraySCORE(i).ToString
            'dr("SURNAME") = strArraySURNAME(i).ToString
            dr("OtherNames") = "Firstname SURNAME"
            dt.Rows.Add(dr)


        Next

        Me.progress = 80 'update progress
        ds.Tables.Add(dt)

        Return ds
    End Function

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
    Function serializeCourses(dt As DataTable) As String
        'todo: take courses order from datagrid (or excel) and save in a comma seperated string in sessions table
        'select * from cOURSES_ORDER
        Return ""
    End Function
    Function expandCourses(courses As String) As DataTable
        'TOD: consider using a dedicated table fo this
        'SESSION|100FS|200FS.....100SS|200LSS
        Return Nothing
    End Function
    Function generateFormulaCO() As String()
        'carry over
        'sample formula (full)
        '=IF(H12<>"", $H$7 & "/" & $H$9 & "/" & H12 & ", ","") & IF(I12<>"", $I$7 & "/" & $I$9 & "/" & I12 & ", ","") & IF(J12<>"", $J$7 & "/" & $J$9 & "/" & J12 & ", ","") & IF(K12<>"", $K$7 & "/" & $K$9 & "/" & K12 & ", ","") & IF(L12<>"", $L$7 & "/" & $L$9 & "/" & L12 & ", ","") & IF(M12<>"", $M$7 & "/" & $M$9 & "/" & M12 & ", ","") & IF(N12<>"", $N$7 & "/" & $N$9 & "/" & N12 & ", ","") & IF(O12<>"", $O$7 & "/" & $O$9 & "/" & O12 & ", ","") & IF(P12<>"", $P$7 & "/" & $P$9 & "/" & P12 & ", ","") & IF(Q12<>"", $Q$7 & "/" & $Q$9 & "/" & Q12 & ", ","") & IF(R12<>"", $R$7 & "/" & $R$9 & "/" & R12 & ", ","") & IF(S12<>"", $S$7 & "/" & $S$9 & "/" & S12 & ", ","") & IF(T12<>"", $T$7 & "/" & $T$9 & "/" & T12 & ", ","") & IF(AY12<>"", $AY$7 & "/" & $AY$9 & "/" & AY12 & ", ","") & IF(AZ12<>"", $AZ$7 & "/" & $AZ$9 & "/" & AZ12 & ", ","") & IF(BA12<>"", $BA$7 & "/" & $BA$9 & "/" & BA12 & ", ","") & IF(BB12<>"", $BB$7 & "/" & $BB$9 & "/" & BB12 & ", ","") & IF(BC12<>"", $BC$7 & "/" & $BC$9 & "/" & BC12 & ", ","") & IF(BD12<>"", $BD$7 & "/" & $BD$9 & "/" & BD12 & ", ","") & IF(BE12<>"", $BE$7 & "/" & $BE$9 & "/" & BE12 & ", ","") & IF(BF12<>"", $BF$7 & "/" & $BF$9 & "/" & BF12 & ", ","") & IF(BG12<>"", $BG$7 & "/" & $BG$9 & "/" & BG12 & ", ","") & IF(BH12<>"", $BH$7 & "/" & $BH$9 & "/" & BH12 & ", ","") & IF(BI12<>"", $BI$7 & "/" & $BI$9 & "/" & BI12 & ", ","") & IF(BJ12<>"", $BJ$7 & "/" & $BJ$9 & "/" & BJ12 & ", ","")
        Dim strRet(2) As String
        'iterate formula
        Dim maxCoursesFS As Integer = 55
        Dim maxCoursesSS As Integer = 55
        Dim startCol As Integer = 8 'TODO: Depends on template starting letter H = 8 (A=1, B=2, C=3
        Dim headRowCourse As Integer = 7
        Dim headRowCredit As Integer = 9
        Dim startRow As Integer = 10
        Dim Col As String = lettersToNum(startCol)

        'First Semester
        Dim strFml As String = "="
        For j = startCol To startCol + maxCoursesFS
            Col = lettersToNum(j)
            strFml = strFml & String.Format("IF({0}{1}<>``, ${0}${2} & `/` & ${0}${3} & `/` & {0}{1} & `, `,``)", Col, startRow, headRowCourse, headRowCredit) & " & "
        Next
        strFml = strFml.Replace("`"c, """"c)
        strFml = Trim(strFml)
        If strFml.EndsWith("&") Then strFml = strFml.Replace("&"c, "")  'remoe trailing &
        strFml = Trim(strFml)
        If strFml.EndsWith("&") Then strFml = strFml.Replace(","c, "")  'remoe trailing &
        strFml = Trim(strFml)
        Debug.Print(strFml)
        strRet(0) = strFml

        '2nd Semester  Skip 4 cols for TCF, TCP, TC and Repeat 2nd
        strFml = "="
        startCol = (startCol + maxCoursesFS + 4) - 1    'excellent
        For j = startCol To startCol + maxCoursesSS
            Col = lettersToNum(j)
            strFml = strFml & String.Format("IF({0}{1}<>``, ${0}${2} & `/` & ${0}${3} & `/` & {0}{1} & `, `,``)", Col, startRow, headRowCourse, headRowCredit) & " & "
        Next
        strFml = strFml.Replace("`"c, """"c)
        strFml = Trim(strFml)
        If strFml.EndsWith("&") Then strFml = strFml.Replace("&"c, "")  'remoe trailing &
        strFml = Trim(strFml)
        If strFml.EndsWith("&") Then strFml = strFml.Replace(","c, "")  'remoe trailing &
        strFml = Trim(strFml)
        Debug.Print(strFml)
        strRet(1) = strFml

        'Generate formula for TCR_first
        '=SUM(IF(BO10>data!$I$9,Broadsheet!$BO$9,0),IF(BP10>data!$I$9,Broadsheet!$BP$9,0),IF(BQ10>data!$I$9,Broadsheet!$BQ$9,0),IF(BR10>data!$I$9,Broadsheet!$BR$9,0),IF(BS10>data!$I$9,Broadsheet!$BS$9,0),IF(BT10>data!$I$9,Broadsheet!$BT$9,0),IF(BU10>data!$I$9,Broadsheet!$BU$9,0),IF(BV10>data!$I$9,Broadsheet!$BV$9,0),IF(BW10>data!$I$9,Broadsheet!$BW$9,0),IF(BX10>data!$I$9,Broadsheet!$BX$9,0),IF(BY10>data!$I$9,Broadsheet!$BY$9,0),IF(BZ10>data!$I$9,Broadsheet!$BZ$9,0),IF(CA10>data!$I$9,Broadsheet!$CA$9,0),IF(CB10>data!$I$9,Broadsheet!$CB$9,0),IF(DG10>data!$I$9,Broadsheet!$DG$9,0),IF(DH10>data!$I$9,Broadsheet!$DH$9,0),IF(DI10>data!$I$9,Broadsheet!$DI$9,0),IF(DJ10>data!$I$9,Broadsheet!$DJ$9,0),IF(DK10>data!$I$9,Broadsheet!$DK$9,0),IF(DL10>data!$I$9,Broadsheet!$DL$9,0),IF(DM10>data!$I$9,Broadsheet!$DM$9,0),IF(DN10>data!$I$9,Broadsheet!$DN$9,0),IF(DO10>data!$I$9,Broadsheet!$DO$9,0),IF(DP10>data!$I$9,Broadsheet!$DP$9,0),IF(DQ10>data!$I$9,Broadsheet!$DQ$9,0))
        '=SUM(IF(BO10>data!$I$9,Broadsheet!$BO$9,0),
        strFml = "="
        For j = startCol To startCol + maxCoursesFS
            Col = lettersToNum(j)
            strFml = strFml & String.Format("IF({0}{1}>data!$I$9, ${0}${2}, 0)+", Col, startRow, headRowCourse, headRowCredit) & " & "
        Next
        strFml = strFml.Replace("+"c, """"c)
        Debug.Print(strFml)



        'TCP
        '=SUM(IF(AK10>data!$I$9,Broadsheet!$AK$9,0),IF(AL10>data!$I$9,Broadsheet!$AL$9,0),IF(AM10>data!$I$9,Broadsheet!$AM$9,0),IF(AN10>data!$I$9,Broadsheet!$AN$9,0))
        Return strRet
    End Function
    Function updateExcelBroadSheetInterop(resultfileNameValue As String, dt As DataSet) As String
        Dim strCriteria As String = String.Empty
        Dim startRow As Integer = 1
        Dim headerRow As Integer = 8
        Dim endRow As Integer = 200
        Dim r As Integer = 9  'starts at row 9
        Dim strSQLTemp As String = ""
        Dim i As Integer = 0
        Dim strMATNO As String = Nothing
        'Dim strArrayMATNO, strArrayNAME, strArrayCA, strArrayEXAM, strArraySCORE, strArraySURNAME, strArrayOtherNames As String()

        Dim strCellContent As String = ""
        Dim strCellContent2 As String = ""
        Dim MATNoFound As Boolean = False
        Dim templateCourses(50) As String
        Dim fn As String = Nothing
        Try
            excelApp = New ExcelInterop.Application

            If resultfileNameValue = Nothing Or Not System.IO.File.Exists(resultfileNameValue) Then Exit Function 'todo
            excelWB = excelApp.Workbooks.Open(resultfileNameValue)
            excelWS = CType(excelWB.Sheets(1), ExcelInterop.Worksheet)


            r = 8 'textbox
            'Search for MATNO Column
            For i = 1 To 20
                strCellContent = excelWS.Cells(i, ExcelColumns.colB).text
                strCellContent2 = excelWS.Cells(i, ExcelColumns.colA).text
                If strCellContent.ToUpper.Contains("MAT") Or strCellContent2.ToUpper.Contains("MAT") Then
                    startRow = i + 2    'allow one for course credit
                    MATNoFound = True
                    Exit For
                End If
            Next
            headerRow = i
            'The Courses in the template (Use assuming it overrides soft)
            For j = 0 To templateCourses.Count - 1
                templateCourses(i) = excelWS.Cells(headerRow, ExcelColumns.colH + j)

            Next
            'check for last row
            'TODO: use a better method to check for usedrange
            'endRow = excelWS.UsedRange.Rows.Count
            'For i = startRow To 300
            '    strCellContent = excelWS.Cells(i, ExcelColumns.colB).text

            '    If strCellContent.ToString.Length = 0 Then
            '        endRow = i - 1
            '        Exit For
            '    End If
            'Next
            endRow = dt.Tables(0).Rows.Count
            Me.progress = 30 'update progress bar
        Catch ex As Exception
            Throw ex
        End Try


        excelApp.Visible = True 'TODO: check


        Dim strFormulaTC As String = "H{0} + I{0} + J{0}" ' "=H9 + I9 + J9"
        Dim strFormulaFullName As String = "D{0} + E{0}" ' D9+E9" wont need fml if template is good
        For i = startRow To 50
            excelWS.Cells(i, ExcelColumns.colA) = i
            excelWS.Cells(i, ExcelColumns.colB) = i * 345 'TODO: place holder for MAT
            excelWS.Cells(i, ExcelColumns.colC) = String.Format(strFormulaFullName, i, i, i) ' "First Name SURNAME" 'TODO: place holder Name
            excelWS.Cells(i, ExcelColumns.colD) = "First Name" & i

            excelWS.Cells(i, ExcelColumns.colE) = dt.Tables(0).Rows(i).Item("Surname") ' "SURNAME" & i
            excelWS.Cells(i, ExcelColumns.colF) = "CPE333/2/55, CPE311/3/75," 'TODO: place holder CO  objbroadsheet.sturecord(MATNO).co
            excelWS.Cells(i, ExcelColumns.colG) = "*79" 'TODO: place holder course  objbroadsheet.sturecord(MATNO).co
            excelWS.Cells(i, ExcelColumns.colH) = "80" 'objbroadsheet.sturecord(MATNO).COURSE002.score
            excelWS.Cells(i, ExcelColumns.colI) = "68"
            excelWS.Cells(i, ExcelColumns.colI) = dt.Tables(0).Rows(i).Item(templateCourses(0))
            '...

            'Total credits
            excelWS.Cells(i, ExcelColumns.colO) = "3" 'objbroadsheet.sturecord(MATNO).COURSE003.FAILED1STsEM  or calcFailed(courses1stSem)
            excelWS.Cells(i, ExcelColumns.colP) = "24" 'objbroadsheet.sturecord(MATNO).COURSE003.Passed1STsEM  or calcPassed(courses1stSem)
            excelWS.Cells(i, ExcelColumns.colQ) = String.Format(strFormulaTC, i, i, i)
        Next
        Debug.Print(excelWS.UsedRange.Rows.Count) ',  'excelWS.UsedRange.FillDown(), 'excelWS.UsedRange.Hidden, 'excelWS.UsedRange.RowHeight = 3
        'excelWS.UsedRange.ShrinkToFit, 'excelWS.UsedRange.Cells.Text  'excelApp.ExecuteExcel4Macro()  excelApp.Version
        Debug.Print(excelWS.UsedRange.Cells.Text)
        'If r > 6 Then Call selectCells("B9:B" & r)
        'With excelWS.Cells.Range(_range).Borders(ExcelInterop.XlBordersIndex.xlEdgeLeft)
        '    excelWS.Cells.Range("B" & startRow & ":B" & r).Select() 'select rows
        'End With
        'excelWS.Cells.Range("B" & startRow & ":B" & r).Copy()
        'Debug.Print(My.Computer.Clipboard.GetData("range").ToString)
        strMATNO = My.Computer.Clipboard.GetData("range")

        'clean up
        Try

            excelApp.Quit()
            fn = broadsheetFileName & "_saved" & endRow & Rnd(5).ToString
            excelWB.SaveAs(broadsheetFileName & "_saved" & endRow & Rnd(5).ToString)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelWB)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelWS)
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


        Return fn
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
