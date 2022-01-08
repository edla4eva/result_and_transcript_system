Imports NPOI.OpenXml4Net.Util
Imports Excel.Helper
Imports Org.BouncyCastle.Utilities.Net
Imports NPOI.Util.FilterInputStream
Imports ExcelDataReader
Imports ICSharpCode.SharpZipLib.GZip
Imports System.IO
Imports NPOI.SS.UserModel
Imports NPOI.SS.Util
Imports NPOI.XSSF.UserModel
Imports NPOI.XSSF.Util


'Namespace ExcelWriter myUniqueNamespace
Public Class ClassExcelFile


    Private _excelFileName As String = Nothing
    Private _progress As Integer = 0
    Private _progressStr As String = ""

    Public Sub New(Optional subFilePathExcludingProgDir As String = "\samples\broadsheet.xlsx")
        Try
            _excelFileName = My.Application.Info.DirectoryPath & subFilePathExcludingProgDir
        Catch ex As Exception
            MsgBox("Cannot create Excel Automation Object" & vbCrLf & ex.Message)
        End Try
    End Sub
    Public Property progress() As Integer
        Get
            Return _progress
        End Get
        Set(ByVal value As Integer)
            _progress = value
        End Set
    End Property
    Public Property progressStr() As String
        Get
            Return _progressStr
        End Get
        Set(ByVal value As String)
            _progressStr = value
        End Set
    End Property
    Public Function processBroadsheetFileMethod() As DataSet
        Try
            Dim sn As Integer = 7 'todo
            Dim courseResult As Integer() = {}

            'TODO: check if file exists
            'If fileexists (objExcelFile.excelFileNameThen)

            'End If
            Dim myDataSet As DataSet ' = objExcelFile.readResultFile()
            myDataSet = objExcelFile.readBroadSheetTemplateFile()

            'Todo Add results----------------
            ' courseResult = mappDB.getCourseResults(session, courseCode)
            courseResult(0) = 99    'test
            courseResult(1) = 99    'test
            myDataSet.Tables(0).Rows(0 + sn).Item(1) = courseResult(0)
            myDataSet.Tables(0).Rows(1 + sn).Item(1) = courseResult(1)
            'add rows
            'dr = dt.NewRow()
            'dr("SN") = 1
            'dr("MATNO") = "ENG0607721"
            'dr("CA") = 20
            'dr("Score") = 60
            'dr("Total") = 80
            'dr("Name") = "Firstname SURNAME"
            'dt.Rows.Add(dr)
            ''---------------------------------------------------------

            Return myDataSet
            'myDataSet.Clear()
            'myDataSet = Nothing

        Catch ex As Exception
            MsgBox("Cannot create Excel File Object" & vbCrLf & ex.Message)
        End Try

    End Function
    Public Function exportBroadsheettoExcelFile_NPOI(dv As DataView, fileName As String, objBS As ClassBroadsheets, dictCr As Dictionary(Of String, Integer), footers As String(), dOption As Integer, Optional showGrades As Boolean = False, Optional dvGrades As DataView = Nothing) As String
        Dim dt As DataTable = dv.ToTable
        Dim dtGrades As DataTable = Nothing
        Dim workbook As IWorkbook = New XSSFWorkbook()
        Dim sheet1 As ISheet = workbook.CreateSheet("Sheet1")
        Dim row1, rowCourseCodes, rowCredits, rowHeaders, rowResults, rowFooters, rowTitles As IRow
        'Dim cell As ICell
        Dim cR As CellRangeAddress = New CellRangeAddress(1, 3, 1, 120)

        Dim style As ICellStyle
        Dim styleSignfooter As ICellStyle
        Dim styleCenter As ICellStyle '= changeStyle(workbook)
        Dim styleCreditCols As ICellStyle '= changeStyle(workbook)
        Dim styleWrap As ICellStyle '= changeStyle(workbook)
        Dim styleMediumBorder As ICellStyle '= changeStyle(workbook)
        Dim styleMediumBorderVertical As ICellStyle '= changeStyle(workbook)
        Dim styleMediumBorderCenter As ICellStyle '= changeStyle(workbook)
        If fileName = "" Then fileName = My.Application.Info.DirectoryPath & "\broadsheets\GeneratedBroadsheet.xlsx"

        'headers
        Dim dFont As New XSSFFont()
        dFont = workbook.CreateFont()
        dFont.IsBold = True 'formerly dFont.Boldweight = CShort(NPOI.SS.UserModel.FontBoldWeight.Bold)
        dFont.FontName = "Times New Roman"
        dFont.FontHeightInPoints = 14


        styleMediumBorderCenter = workbook.CreateCellStyle()
        styleMediumBorderCenter.Alignment = HorizontalAlignment.Center
        styleMediumBorderCenter.WrapText = True
        styleMediumBorderCenter.VerticalAlignment = VerticalAlignment.Center
        styleMediumBorderCenter.SetFont(dFont)

        '# Insert values for header
        rowTitles = sheet1.CreateRow(0)  'row1
        rowTitles.CreateCell(0).SetCellValue(objBS.DepartmentName.ToUpper)   'row1.CreateCell(jCol).SetCellValue("S/N")
        rowTitles.GetCell(0).CellStyle = (styleMediumBorderCenter)
        rowTitles = sheet1.CreateRow(1)  'row2
        rowTitles.CreateCell(0).SetCellValue(objBS.FacultyName.ToUpper)
        rowTitles.GetCell(0).CellStyle = (styleMediumBorderCenter)

        rowTitles = sheet1.CreateRow(2)  'row3
        rowTitles.CreateCell(0).SetCellValue(objBS.SchoolName.ToUpper)  ''cell.SetCellValue(New XSSFRichTextString("This is a styled Faculty Name"))
        rowTitles.Cells(0).CellStyle = (styleMediumBorderCenter)
        rowTitles = sheet1.CreateRow(3)  'row4
        rowTitles.CreateCell(0).SetCellValue("EXAMINATION RECORD SHEET (" & objBS.Session & " Academic Session)")
        rowTitles.Cells(0).CellStyle = (styleMediumBorderCenter)
        rowTitles = sheet1.CreateRow(4)  'row5
        If dOption = BGW_EXPORT_EXCEL_YR_MILTIPLIER * BGW_EXPORT_EXCEL_1ST_SEM_SCORES Or
            dOption = BGW_EXPORT_EXCEL_YR_MILTIPLIER * BGW_EXPORT_EXCEL_2ND_SEM_SCORES Or
            dOption = BGW_EXPORT_EXCEL_YR_MILTIPLIER * BGW_EXPORT_EXCEL_ALL_SEM_SCORES Then
            rowTitles.CreateCell(0).SetCellValue("YEAR " & (objBS.Level / 100).ToString)
        Else
            rowTitles.CreateCell(0).SetCellValue("LEVEL: " & objBS.Level.ToString)
        End If
        rowTitles.Cells(0).CellStyle = (styleMediumBorderCenter)

        '#STYLE: Special case of merged cells border for headings dept, fac, uni etc
        cR = New CellRangeAddress(0, 0, 0, LAST_COL)
        sheet1.AddMergedRegion(cR)
        cR = New CellRangeAddress(1, 1, 0, LAST_COL)
        sheet1.AddMergedRegion(cR)
        cR = New CellRangeAddress(2, 2, 0, LAST_COL)
        sheet1.AddMergedRegion(cR)
        cR = New CellRangeAddress(3, 3, 0, LAST_COL)
        sheet1.AddMergedRegion(cR)
        cR = New CellRangeAddress(4, 4, 0, LAST_COL)
        sheet1.AddMergedRegion(cR)

        'sets the border of the merged cells
        RegionUtil.SetBorderTop(BorderStyle.Medium, cR, sheet1)
        RegionUtil.SetBorderBottom(BorderStyle.Medium, cR, sheet1)
        RegionUtil.SetBorderLeft(BorderStyle.Medium, cR, sheet1)
        RegionUtil.SetBorderRight(BorderStyle.Medium, cR, sheet1)

        '# Headers especialy coure codes
        rowHeaders = sheet1.CreateRow(ROW_HEADER)
        rowCourseCodes = sheet1.CreateRow(ROW_HEADER + 1)
        rowCredits = sheet1.CreateRow(ROW_CREDIT)  '8=row 9
        For jCol = 0 To dt.Columns.Count - 1
            If dictAllCourseCodeKeyAndCourseUnitVal.Count = 0 Then Exit Function 'no need '
            If jCol >= COURSE_START_COL And dictAllCourseCodeKeyAndCourseUnitVal.ContainsKey(dt.Columns(jCol).ColumnName.ToString) Then rowCredits.CreateCell(jCol).SetCellValue(dictAllCourseCodeKeyAndCourseUnitVal(dt.Columns(jCol).ColumnName.ToString))
            'Style  (course code headers)
            If jCol >= COURSE_START_COL And jCol <= COURSE_END_COL Then
                'data
                rowCourseCodes.CreateCell(jCol).SetCellValue(dt.Columns(jCol).ColumnName.ToString)
                'merge
                cR = New CellRangeAddress(ROW_HEADER + 1, ROW_HEADER + 2, jCol, jCol)
            ElseIf jCol >= COURSE_START_COL_2 And jCol <= COURSE_END_COL_2 Then
                'data
                rowCourseCodes.CreateCell(jCol).SetCellValue(dt.Columns(jCol).ColumnName.ToString)
                'merge
                cR = New CellRangeAddress(ROW_HEADER + 1, ROW_HEADER + 2, jCol, jCol)
            Else    'others like TCP, TCF, TCR etc
                'data
                rowHeaders.CreateCell(jCol).SetCellValue(dt.Columns(jCol).ColumnName.ToString)

                'Proper headers
                If dt.Columns(jCol).ColumnName.ToString.ToUpper.Contains("SN") Then rowHeaders.GetCell(jCol).SetCellValue("S/N")
                If dOption = BGW_EXPORT_EXCEL_YR_MILTIPLIER * BGW_EXPORT_EXCEL_1ST_SEM_SCORES Or
                        dOption = BGW_EXPORT_EXCEL_YR_MILTIPLIER * BGW_EXPORT_EXCEL_2ND_SEM_SCORES Or
                        dOption = BGW_EXPORT_EXCEL_YR_MILTIPLIER * BGW_EXPORT_EXCEL_ALL_SEM_SCORES Then
                    If dt.Columns(jCol).ColumnName.ToString.ToUpper.Contains("MATNO") Then rowHeaders.GetCell(jCol).SetCellValue("MAT. NO. DMI")
                    If dt.Columns(jCol).ColumnName.ToString.ToUpper.Contains("Status") Then rowHeaders.GetCell(jCol).SetCellValue("CATEGORY")

                Else
                    If dt.Columns(jCol).ColumnName.ToString.ToUpper.Contains("MATNO") Then rowHeaders.GetCell(jCol).SetCellValue("MAT. NO. ENG..")
                End If

                If dt.Columns(jCol).ColumnName.ToString.ToUpper.Contains("REPEATCOURSES_1") Then rowHeaders.GetCell(jCol).SetCellValue("REPEAT COURSES IN CODES AND MARKS (FIRST SEMESTER)")
                If dt.Columns(jCol).ColumnName.ToString.ToUpper.Contains("REPEATALL") Then rowHeaders.GetCell(jCol).SetCellValue("REPEAT COURSES IN CODES AND MARKS")

                If dt.Columns(jCol).ColumnName.ToString.ToUpper.Contains("FULLNAME") Then rowHeaders.GetCell(jCol).SetCellValue("NAME OF CANDIDATE (SURNAME LAST AND IN BLOCK LETTERS)")
                If dt.Columns(jCol).ColumnName.ToString.ToUpper.Contains("FAILED") Then rowHeaders.GetCell(jCol).SetCellValue("COURSES FAILED/TRAILED")
                If dt.Columns(jCol).ColumnName.ToString.ToUpper.Contains("REPEATCOURSES_2") Then rowHeaders.GetCell(jCol).SetCellValue("REPEAT COURSES IN CODES AND MARKS (SECOND SEMESTER)")
                'TCP_1_COL
                If dt.Columns(jCol).ColumnName.ToString.ToUpper.Contains("TCP_1") Then rowHeaders.GetCell(jCol).SetCellValue("TCP (1st Sem)")
                If dt.Columns(jCol).ColumnName.ToString.ToUpper.Contains("TCF_1") Then rowHeaders.GetCell(jCol).SetCellValue("TCF (1st Sem)")
                If dt.Columns(jCol).ColumnName.ToString.ToUpper.Contains("TCR_1") Then rowHeaders.GetCell(jCol).SetCellValue("TCR (1st Sem)")
                If dt.Columns(jCol).ColumnName.ToString.ToUpper.Contains("TCP_2") Then rowHeaders.GetCell(jCol).SetCellValue("TCP (2nd Sem)")
                If dt.Columns(jCol).ColumnName.ToString.ToUpper.Contains("TCF_2") Then rowHeaders.GetCell(jCol).SetCellValue("TCF (2nd Sem)")
                If dt.Columns(jCol).ColumnName.ToString.ToUpper.Contains("TCR_2") Then rowHeaders.GetCell(jCol).SetCellValue("TCR (2nd Sem)")

                cR = New CellRangeAddress(ROW_HEADER, ROW_HEADER + (ROW_CREDIT - ROW_HEADER), jCol, jCol) '.merge all the way To credit col
            End If
            sheet1.AddMergedRegion(cR)
            RegionUtil.SetBorderTop(BorderStyle.Medium, cR, sheet1)
            RegionUtil.SetBorderBottom(BorderStyle.Medium, cR, sheet1)
            RegionUtil.SetBorderLeft(BorderStyle.Medium, cR, sheet1)
            RegionUtil.SetBorderRight(BorderStyle.Medium, cR, sheet1)
        Next
        'Headers For Special cases 
        rowHeaders.CreateCell(COURSE_START_COL).SetCellValue("FIRST SEMESTER COURSES")
        rowHeaders.CreateCell(COURSE_START_COL_2).SetCellValue("SECOND SEMESTER COURSES")
        cR = New CellRangeAddress(ROW_HEADER, ROW_HEADER, COURSE_START_COL, COURSE_END_COL - 1)
        sheet1.AddMergedRegion(cR)
        cR = New CellRangeAddress(ROW_HEADER, ROW_HEADER, COURSE_START_COL_2, COURSE_END_COL_2 - 1)
        sheet1.AddMergedRegion(cR)


        '###The results
        For iRow = 0 To dt.Rows.Count - 1
            rowResults = sheet1.CreateRow(iRow + ALL_HEADERS_COUNT)
            For jCol = 0 To dt.Columns.Count - 1
                rowResults.CreateCell(jCol).SetCellValue(dt.Rows(iRow).Item(jCol).ToString)   'row1.CreateCell(jCol).SetCellValue("S/N")
                If dt.Rows(iRow).Item(jCol).ToString = DEFAULT_CODE.ToString Then rowResults.CreateCell(jCol).SetCellValue(DEFAULT_DISP)
                If dt.Rows(iRow).Item(jCol).ToString = NA_CODE.ToString Then rowResults.CreateCell(jCol).SetCellValue(NA_DISP)
                If dt.Rows(iRow).Item(jCol).ToString = NR_CODE.ToString Then rowResults.CreateCell(jCol).SetCellValue(NR_DISP)
                If dt.Rows(iRow).Item(jCol).ToString = ABS_CODE.ToString Then rowResults.CreateCell(jCol).SetCellValue(ABS_DISP)
                'todo: handle probating: *87, *56 etc
                If dt.Rows(iRow).Item("Status").ToString = "PROBATION" And
                    jCol > COURSE_START_COL And
                    jCol < COURSE_END_COL Then rowResults.GetCell(jCol).SetCellValue("*" & dt.Rows(iRow).Item(jCol).ToString)
                'If jCol >= COURSE_START_COL And jCol <= COURSE_END_COL Then
                'ElseIf jCol >= COURSE_START_COL_2 And jCol <= COURSE_END_COL_2 Then
                'end if
                'todo: get previosly passed course
                'lookUpPreviousResult()
            Next
        Next

        '###Test: DO AL STYLING HERE
        'Define styles
        '###headers 'all especialy Course Codes
        styleMediumBorder = workbook.CreateCellStyle()
        styleMediumBorder.BorderRight = BorderStyle.Medium
        styleMediumBorder.BorderLeft = BorderStyle.Medium
        styleMediumBorder.BorderTop = BorderStyle.Medium
        styleMediumBorder.BorderBottom = BorderStyle.Medium
        styleMediumBorder.VerticalAlignment = VerticalAlignment.Center
        styleMediumBorder.Alignment = HorizontalAlignment.Center
        styleMediumBorder.WrapText = True

        styleMediumBorderVertical = workbook.CreateCellStyle()
        styleMediumBorderVertical.Alignment = HorizontalAlignment.Center
        styleMediumBorderVertical.BorderRight = BorderStyle.Medium
        styleMediumBorderVertical.BorderLeft = BorderStyle.Medium
        styleMediumBorderVertical.BorderTop = BorderStyle.Medium
        styleMediumBorderVertical.BorderBottom = BorderStyle.Medium
        styleMediumBorderVertical.Rotation = 90

        rowHeaders = sheet1.GetRow(ROW_HEADER)
        rowCourseCodes = sheet1.GetRow(ROW_HEADER + 1)
        rowCredits = sheet1.GetRow(ROW_CREDIT)  '8=row 9

        rowHeaders.GetCell(SN_COL).CellStyle = styleMediumBorder 'horzontal
        rowHeaders.GetCell(MATNO_COL).CellStyle = styleMediumBorder 'horzontal
        rowHeaders.GetCell(FULLNAME_COL).CellStyle = styleMediumBorder 'horzontal
        rowHeaders.GetCell(REPEATED_ALL_COL).CellStyle = styleMediumBorder 'horzontal
        rowHeaders.GetCell(REPEATED_1_COL).CellStyle = styleMediumBorder 'horzontal
        rowHeaders.GetCell(REPEATED_2_COL).CellStyle = styleMediumBorder 'horzontal
        rowHeaders.GetCell(COURSE_FAIL_COL).CellStyle = styleMediumBorder 'horzontal

        rowHeaders.GetCell(TCP_1_COL).CellStyle = styleMediumBorderVertical 'VERTIAL
        rowHeaders.GetCell(TCP_2_COL).CellStyle = styleMediumBorderVertical 'VERTIAL
        rowHeaders.GetCell(TCF_1_COL).CellStyle = styleMediumBorderVertical 'VERTIAL
        rowHeaders.GetCell(TCF_2_COL).CellStyle = styleMediumBorderVertical 'VERTIAL
        rowHeaders.GetCell(TCR_1_COL).CellStyle = styleMediumBorderVertical 'VERTIAL
        rowHeaders.GetCell(TCR_2_COL).CellStyle = styleMediumBorderVertical 'VERTIAL
        rowHeaders.GetCell(TCP_COL).CellStyle = styleMediumBorderVertical 'VERTIAL
        rowHeaders.GetCell(TCF_COL).CellStyle = styleMediumBorderVertical 'VERTIAL
        rowHeaders.GetCell(TCR_COL).CellStyle = styleMediumBorderVertical 'VERTIAL
        rowHeaders.GetCell(STATUS_COL).CellStyle = styleMediumBorderVertical 'VERTIAL
        rowHeaders.GetCell(CLASS_COL).CellStyle = styleMediumBorderVertical 'VERTIAL

        style = changeStyle(workbook)
        style.VerticalAlignment = VerticalAlignment.Center

        styleCenter = changeStyle(workbook)
        styleCenter.Alignment = HorizontalAlignment.Center
        styleCenter.VerticalAlignment = VerticalAlignment.Center

        styleWrap = changeStyle(workbook)
        styleWrap.WrapText = True
        styleWrap.VerticalAlignment = VerticalAlignment.Center

        For iRow = 0 To dt.Rows.Count - 1
            rowResults = sheet1.GetRow(iRow + ALL_HEADERS_COUNT)
            For jCol = 0 To dt.Columns.Count - 1
                rowResults.Cells(jCol).CellStyle = (style)
                rowCourseCodes.Cells(jCol).CellStyle = (styleMediumBorderVertical)
                If jCol >= COURSE_START_COL Then rowResults.Cells(jCol).CellStyle = styleCenter
                'If jCol = GPA_COL Then row1.Cells(jCol).CellStyle = style
                'If jCol >= COURSE_START_COL And jCol <= COURSE_END_COL Then
                'ElseIf jCol >= COURSE_START_COL_2 And jCol <= COURSE_END_COL_2 Then
                'End If
                If iRow = rowCredits.RowNum Then rowCredits.GetCell(jCol).CellStyle = styleMediumBorder 'horzontal
            Next
            'style
            rowResults.GetCell(FULLNAME_COL).CellStyle = styleWrap   'ColC name
            rowResults.GetCell(4).CellStyle = styleWrap
            rowResults.GetCell(REPEATED_ALL_COL).CellStyle = styleWrap   'repeated
            rowResults.GetCell(7).CellStyle = styleWrap

        Next
        'TODO: Get footer fro db category table NO dont do any database call here
        Dim dtCateGory As DataTable = objBroadsheet.dtCategory
        If dtCateGory Is Nothing Then
            dtCateGory = mappDB.GetDataWhere("SELECT * FROM category ORDER BY category").Tables(0)
        End If
        Dim strFooter As String() = {
        "(A)              SUCCESSFUL STUDENTS:",
        "(B)              STUDENTS WITH CARRY-OVER COURSES",
        "(C)              STUDENTS TO PROBATE/TRANSFER",
        "(D)              MEDICAL CASES:",
        "(E)              ABSENCE FROM EXAMINATIONS",
        "(F)              WITHHELD RESULTS;",
        "(G)              EXPELLED/RUSTICATED/SUSPENDED STUDENTS:",
        "(H)              TEMPORARY WITHDRAWAL FROM THE UNIVERSITY:",
        "(I)              UNREGISTERED STUDENTS:", "", ""}

        ReDim strFooter(dtCategory.Rows.Count)
        For i = 0 To dtCategory.Rows.Count - 1
            strFooter(i) = dtCategory.Rows(i).Item("category") & "     " & dtCategory.Rows(i).Item("description")
        Next

        Dim strFooter500 As String() = {
        "(A)              SUCCESSFUL STUDENTS:",
        "(B)              STUDENTS WITH CARRY-OVER COURSES",
        "(C)              STUDENTS WITH FIRSTCLASS",
        "(D)              STUDENTS WITH SECOND CLASS (UPPER DIVISION)",
        "(E)              ABSENCE FROM EXAMINATIONS",
        "(F)              WITHHELD RESULTS Nil",
        "(G)              EXPELLED/RUSTICATED/SUSPENDED STUDENTS:",
        "(H)              TEMPORARY WITHDRAWAL FROM THE UNIVERSITY:",
        "(I)              UNREGISTERED STUDENTS:", "", ""}
        ReDim strFooter500(dtCateGory.Rows.Count)
        For i = 0 To dtCategory.Rows.Count - 1
            strFooter500(i) = dtCategory.Rows(i).Item("category") & "     " & dtCategory.Rows(i).Item("description_final_year")
        Next
        'merge category cols


        Dim strFooterVal As Integer() = {10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0}



        If dOption = BGW_EXPORT_EXCEL_YR_MILTIPLIER * BGW_EXPORT_EXCEL_1ST_SEM_SCORES Or
            dOption = BGW_EXPORT_EXCEL_YR_MILTIPLIER * BGW_EXPORT_EXCEL_2ND_SEM_SCORES Or
            dOption = BGW_EXPORT_EXCEL_YR_MILTIPLIER * BGW_EXPORT_EXCEL_ALL_SEM_SCORES Then
            doFootersYr(sheet1, strFooter, strFooterVal, dt.Rows.Count, style, footers, styleSignfooter)
            'todo: get count of category in doFooters fxn
        Else
            doFootersLevel(sheet1, strFooter, strFooterVal, dt.Rows.Count, style, footers, styleSignfooter)
        End If

        'OR
        Dim rowFooter, rowHashCodesInfo As IRow
        rowFooter = sheet1.CreateRow(dt.Rows.Count + ALL_HEADERS_COUNT + 1)

        For i = 0 To 9
            rowFooter = sheet1.CreateRow(dt.Rows.Count + ALL_HEADERS_COUNT + i + 1)    'account for 9 header rows
            rowFooter.CreateCell(FULLNAME_COL).SetCellValue(strFooter(i))
            rowFooter.CreateCell(COURSE_START_COL + 1).SetCellValue(strFooterVal(i))  '"=COUNT()"  'total-successful
            rowFooter.GetCell(FULLNAME_COL).CellStyle = (style)
            rowFooter.GetCell(COURSE_START_COL + 1).CellStyle = (style)
            cR = New CellRangeAddress(rowFooter.RowNum, rowFooter.RowNum, FULLNAME_COL, COURSE_START_COL)
            sheet1.AddMergedRegion(cR)
        Next

        ''set formula
        'row1 = sheet1.CreateRow(dt.Rows.Count)
        'cell = row1.CreateCell(0)
        'setFomula(sheet1, cell, "D2+D3+6")

        setWidthHeight(sheet1)   'todo test
        setFormatPerSemesterThenPerLevel(sheet1, objBS.broadsheetSemester, objBS.Level, dt.Columns.Count - 1)



        'sheet1.setRepeatingRows(CellRangeAddress.ValueOf("1:2")) ' Set repeating rows For printing
        '        // set print setup; fit all columns to one page width
        'sheet.setAutobreaks(True);
        'sheet.setFitToPage(True);
        'PrintSetup printSetup = sheet.getPrintSetup();
        'printSetup.setFitHeight((Short)0);
        'printSetup.setFitWidth((Short)1);
        sheet1.PrintSetup.FitHeight = 9999
        'sheet1.PrintSetup.FitWidth = 1
        sheet1.SetRowBreak(rowFooter.RowNum + footers.Count)
        rowHashCodesInfo = sheet1.CreateRow(rowFooter.RowNum + footers.Count + 5)
        rowHashCodesInfo.CreateCell(FULLNAME_COL).SetCellValue("Auto generated Info:" & dt.Rows.Count & "Students; " & Now.Ticks.ToString & "; " & "(special code used to verify authenticity of results only availiable in commercial version)")
        sheet1.RepeatingRows = New CellRangeAddress(rowHeaders.RowNum - 1, rowCredits.RowNum, 0, LAST_COL)



        If showGrades = True Then
            dtGrades = dvGrades.ToTable
            'TODO: convert all scores to grades
            '###The results
            For iRow = 0 To dt.Rows.Count - 1
                row1 = sheet1.GetRow(iRow + ALL_HEADERS_COUNT)
                For jCol = 0 To dt.Columns.Count - 1
                    If jCol >= COURSE_START_COL And jCol <= COURSE_END_COL_2 Then
                        row1.GetCell(jCol).SetCellValue(dtGrades.Rows(iRow).Item(jCol).ToString)   'row1.CreateCell(jCol).SetCellValue("S/N")
                        If dt.Rows(iRow).Item(jCol).ToString = DEFAULT_CODE.ToString Then row1.GetCell(jCol).SetCellValue(DEFAULT_DISP)
                        If dt.Rows(iRow).Item(jCol).ToString = NA_CODE.ToString Then row1.GetCell(jCol).SetCellValue(NA_DISP)
                        If dt.Rows(iRow).Item(jCol).ToString = NR_CODE.ToString Then row1.GetCell(jCol).SetCellValue(NR_DISP)
                        If dt.Rows(iRow).Item(jCol).ToString = ABS_CODE.ToString Then row1.GetCell(jCol).SetCellValue(ABS_DISP)
                        'todo handle probating: *87, *56 etc
                    End If
                    'handle repeated
                    If jCol = REPEATED_ALL_COL Then
                        row1.GetCell(jCol).SetCellValue(dtGrades.Rows(iRow).Item(jCol).ToString)
                    End If

                Next

            Next
        End If

        'todo: finally delete are unused columns here
        For iRow = 0 To dt.Rows.Count - 1
            row1 = sheet1.GetRow(iRow + ALL_HEADERS_COUNT)
            For jCol = 0 To dt.Columns.Count - 1
                If jCol >= COURSE_START_COL And jCol <= COURSE_END_COL_2 Then
                    'sheet1.deletecol 'row1.CreateCell(jCol).SetCellValue("S/N")

                End If
            Next
        Next

        'save work
        'todo: if file exists(fileName) create new filename
        If System.IO.File.Exists(fileName) Then
            fileName = Path.GetDirectoryName(fileName) & "\" & Path.GetFileNameWithoutExtension(fileName) & Rnd(45).ToString & Now.Day.ToString & Path.GetExtension(fileName)
            'System.IO.File.Delete(fileName)
            If System.IO.File.Exists(fileName) Then fileName = Path.GetDirectoryName(fileName) & "\" & Path.GetFileNameWithoutExtension(fileName) & Rnd(45).ToString & Now.Day.ToString & Path.GetExtension(fileName)
            Try
                writeToFile(workbook, fileName)
            Catch ex As Exception

                'hanle
                MsgBox("The Excel file is Open , close it and click ok")

                Try
                    writeToFile(workbook, fileName)
                Catch ex2 As Exception
                    fileName = ""
                End Try

            End Try

            'Throw New Exception("RTPS Error: Excel File Already Exists!")
        Else
            writeToFile(workbook, fileName)
        End If

        Return fileName
    End Function

    Public Sub doFootersLevel(sheet1 As ISheet, strFooter As String(), strFooterVal As Integer(), rowCount As Integer, style As ICellStyle, footers As String(), styleSignFooter As ICellStyle)
        Dim rowFooter As IRow
        rowFooter = sheet1.CreateRow(rowCount + ALL_HEADERS_COUNT + 1)
        rowFooter.CreateCell(1) _
                 .SetCellValue("CATEGORY")   'row1.CreateCell(jCol).SetCellValue("S/N")


        rowFooter = sheet1.CreateRow(rowCount + ALL_HEADERS_COUNT + 2)    'account for 9 header rows
        rowFooter.CreateCell(2).SetCellValue(strFooter(0))
        rowFooter.CreateCell(COURSE_START_COL).SetCellValue("=COUNTIF(EA10:EA175,'')") 'todo: dblquote
        rowFooter.GetCell(2).CellStyle = (style)
        rowFooter.GetCell(COURSE_START_COL).CellStyle = (style)

        rowFooter = sheet1.CreateRow(rowCount + ALL_HEADERS_COUNT + 3)    'account for 9 header rows
        rowFooter.CreateCell(2).SetCellValue(strFooter(1))   'row1.CreateCell(jCol).SetCellValue("S/N")
        rowFooter.CreateCell(COURSE_START_COL).SetCellValue("=BM186-BM177")  'TODO: call numtoCellAddress"  'total-successful
        rowFooter.CreateCell(COURSE_START_COL).SetCellValue("=" & numToLetter(COURSE_START_COL) & COURSE_START_COL & "-" & numToLetter(COURSE_START_COL) & COURSE_START_COL)
        rowFooter.GetCell(COURSE_START_COL).CellStyle = (style)


        For i = 0 To 9
            rowFooter = sheet1.CreateRow(rowCount + ALL_HEADERS_COUNT + i + 1)    'account for 9 header rows
            rowFooter.CreateCell(2).SetCellValue(strFooter(i))
            rowFooter.CreateCell(COURSE_START_COL).SetCellValue(strFooterVal(i))
            rowFooter.CreateCell(8).SetCellValue(strFooterVal(i))
            If Len(strFooter(i)) > 0 Then rowFooter.GetCell(2).CellStyle = (style)  'conditional formatting
            If Len(strFooterVal(i)) > 0 Then rowFooter.GetCell(COURSE_START_COL).CellStyle = (style)
        Next
        'firstclass=COUNTIFS(DY10:DY175,"1")    seconclass =COUNTIFS(DY10:DY175,"2.1") 

        'final footers HOD, dean etc
        Dim footerRowount As Integer = rowCount + ALL_HEADERS_COUNT + 11 + 3
        Dim cRFooter As CellRangeAddress = New CellRangeAddress(footerRowount, footerRowount, 2, 6)

        rowFooter = sheet1.CreateRow(footerRowount)    'account for 9 header rows
        rowFooter.CreateCell(2).SetCellValue(footers(0))
        rowFooter.CreateCell(TCP_1_COL).SetCellValue(footers(1))
        rowFooter.CreateCell(COURSE_FAIL_COL).SetCellValue(footers(2))
        'titles/position
        rowFooter = sheet1.CreateRow(footerRowount + 1)    'account for 9 header rows
        rowFooter.CreateCell(2).SetCellValue("Course Adviser")
        rowFooter.CreateCell(TCP_1_COL).SetCellValue("Dean")
        rowFooter.CreateCell(COURSE_FAIL_COL).SetCellValue("Head of Department")

        'Style
        cRFooter = New CellRangeAddress(footerRowount, footerRowount, FULLNAME_COL, FULLNAME_COL + 1)
        sheet1.AddMergedRegion(cRFooter)
        RegionUtil.SetBorderTop(BorderStyle.Medium, cRFooter, sheet1)
        'todo center text
        cRFooter = New CellRangeAddress(footerRowount, footerRowount, TCP_1_COL, TCP_1_COL + 10)  'merge 10 small cols
        sheet1.AddMergedRegion(cRFooter)
        RegionUtil.SetBorderTop(BorderStyle.Medium, cRFooter, sheet1)
        cRFooter = New CellRangeAddress(footerRowount, footerRowount, COURSE_FAIL_COL, COURSE_FAIL_COL + 1)
        sheet1.AddMergedRegion(cRFooter)
        RegionUtil.SetBorderTop(BorderStyle.Medium, cRFooter, sheet1)


    End Sub
    Public Sub doFootersYr(sheet1 As ISheet, strFooter As String(), strFooterVal As Integer(), rowCount As Integer, style As ICellStyle, footers As String(), styleSignFooter As ICellStyle)
        Dim rowFooter As IRow
        'final footers HOD, dean etc
        Dim footerRowount As Integer = rowCount + ALL_HEADERS_COUNT + 11 + 3
        Dim cRFooter As CellRangeAddress = New CellRangeAddress(footerRowount, footerRowount, 2, 6)

        rowFooter = sheet1.CreateRow(footerRowount)    'account for 9 header rows
        rowFooter.CreateCell(2).SetCellValue(footers(0))
        rowFooter.CreateCell(TCP_1_COL).SetCellValue(footers(1))
        rowFooter.CreateCell(COURSE_FAIL_COL).SetCellValue(footers(2))
        'titles/position
        rowFooter = sheet1.CreateRow(footerRowount + 1)    'account for 9 header rows
        rowFooter.CreateCell(2).SetCellValue("Ag. Director")


        'Style
        cRFooter = New CellRangeAddress(footerRowount, footerRowount, FULLNAME_COL, FULLNAME_COL + 1)
        sheet1.AddMergedRegion(cRFooter)
        RegionUtil.SetBorderTop(BorderStyle.Medium, cRFooter, sheet1)



    End Sub
    'TODO: Create UI settings form and mae all these configurations accessible to user
    'on apply settings, objects are created with these settings appled
    Public Function setFormatPerSemesterThenPerLevel(sheet1 As ISheet, dSem As Integer, dLevel As Integer, lastExtraCol As Integer) As Boolean
        Select Case dSem
            Case 1  'First emester broadsheet
                'hide all second semester courses
                For i = COURSE_START_COL_2 To COURSE_END_COL_2
                    hideCols(sheet1, i)
                Next
                hideCols(sheet1, TCR_2_COL)
                hideCols(sheet1, TCP_2_COL)
                hideCols(sheet1, TCF_2_COL)
                hideCols(sheet1, TCR_COL)
                hideCols(sheet1, TCP_COL)
                hideCols(sheet1, TCF_COL)
                hideCols(sheet1, GPA_COL)
                hideCols(sheet1, STATUS_COL)

                showCols(sheet1, REPEATED_1_COL) 'show 1st sm repeat
                hideCols(sheet1, REPEATED_2_COL)
                hideCols(sheet1, REPEATED_ALL_COL)  'affected by level also
                hideCols(sheet1, CLASS_COL)
                hideCols(sheet1, SESSION_COL)
                'it also depends on level
                Select Case dLevel
                    Case 100
                        hideCols(sheet1, REPEATED_ALL_COL)
                    Case 200
                    Case 300
                    Case 400
                    Case 500
                        hideCols(sheet1, GPA_COL)   'show em
                        hideCols(sheet1, CLASS_COL)
                End Select
            Case 2  'Second semester included 
                hideCols(sheet1, REPEATED_1_COL)
                hideCols(sheet1, REPEATED_2_COL)
                showCols(sheet1, REPEATED_ALL_COL)  'also deal with thi in level 
                'it also depends on level
                Select Case dLevel
                    Case 100
                        hideCols(sheet1, REPEATED_ALL_COL)
                    Case 200
                    Case 300
                    Case 400
                    Case 500
                        showCols(sheet1, GPA_COL)   'show em
                        showCols(sheet1, CLASS_COL)
                End Select
        End Select

        'Now lets format per level
        For x = COURSE_START_COL To LAST_COL   ' ExcelColumns.colH To (ExcelColumns.colZ * 4 + ExcelColumns.colP) - 1    'H-DP
            If sheet1.GetRow(COURSE_CODE_HEADER).Cells(x).StringCellValue.Contains("ColUNIQUE") Then
                hideCols(sheet1, x)
                sheet1.GetRow(COURSE_CODE_HEADER).Cells(x).SetCellValue("")         'display nothing
            Else
                If dictAllCourseCodeKeyAndCourseLevelVal.ContainsKey(sheet1.GetRow(COURSE_CODE_HEADER).Cells(x).StringCellValue) Then
                    If Not dictAllCourseCodeKeyAndCourseLevelVal(sheet1.GetRow(COURSE_CODE_HEADER).Cells(x).StringCellValue) = dLevel Then hideCols(sheet1, x)
                End If
            End If
        Next
        hideCols(sheet1, OTHER_NAMES_COL)
        hideCols(sheet1, SURNAME_COL)
        For x = LAST_COL To lastExtraCol
            hideCols(sheet1, x)
        Next
        showCols(sheet1, GPA_COL)     'todo hide it later, lets just enjoy the cool effect for now
        'Cos we may have missed
        showCols(sheet1, MATNO_COL)      'always show this
        showCols(sheet1, COURSE_FAIL_COL)       'always show this

        Return True
    End Function


    Public Function setWidthHeight(sheet1 As ISheet) As Boolean
        'set the width of columns
        sheet1.SetColumnWidth(SN_COL, 5 * 256)   'colA   sn
        sheet1.SetColumnWidth(MATNO_COL, 10 * 256)  'colB   matno   nb 15= approx 14.29in excel, 10=approx 10
        sheet1.SetColumnWidth(FULLNAME_COL, 30 * 256)  'ColC   Full Name
        sheet1.SetColumnWidth(OTHER_NAMES_COL, 30 * 256)
        sheet1.SetColumnWidth(SURNAME_COL, 15 * 256)
        sheet1.SetColumnWidth(REPEATED_ALL_COL, 40 * 256)  'repeated All

        sheet1.SetColumnWidth(REPEATED_1_COL, 40 * 256)  'repeated Fist Semester
        For j = COURSE_START_COL To LAST_COL + 6
            sheet1.SetColumnWidth(j, 4 * 260)  'approx 4 for Result cols note 260 instead  of 256
        Next

        For j = LAST_COL To LAST_COL + 6
            sheet1.SetColumnWidth(j, 4 * 260)  '
        Next

        sheet1.SetColumnWidth(REPEATED_2_COL, 40 * 256)  'repeated 2nd Sem
        sheet1.SetColumnWidth(COURSE_FAIL_COL, 40 * 256)
        sheet1.SetColumnWidth(GPA_COL, 6 * 256)  'GPA
        sheet1.SetColumnWidth(SESSION_COL, 12 * 256)  'GPA

        sheet1.GetRow(COURSE_CODE_HEADER).Height = (4 * 256)    'bcos its vertically aligned NOTE different scale from width
        Return True
    End Function
    Public Function mergeCells(sheet As ISheet, cell As ICell, fRow As Integer, lRow As Integer, fCol As Integer, lCol As Integer) As Boolean
        'Merge Cells
        'fRow = lRow = 1
        'fCol = 1
        'lCol = 2
        sheet.AddMergedRegion(New CellRangeAddress(fRow, lRow, fCol, lCol)) 'firstRow, lRow, fCol, lCol
        Return True
    End Function
    Public Function changeStyle(workbook As IWorkbook) As ICellStyle
        Dim style As ICellStyle = workbook.CreateCellStyle()
        style.BorderBottom = BorderStyle.Thin
        style.BottomBorderColor = IndexedColors.Black.Index
        style.BorderLeft = BorderStyle.Thin
        style.LeftBorderColor = IndexedColors.Black.Index
        style.BorderRight = BorderStyle.Thin
        style.RightBorderColor = IndexedColors.Black.Index
        style.BorderTop = BorderStyle.Thin
        style.TopBorderColor = IndexedColors.Black.Index
        Return style
    End Function
    Public Sub hideCols(s As ISheet, colNum As Integer)
        s.SetColumnHidden(colNum, True)
    End Sub
    Public Sub showCols(s As ISheet, colNum As Integer)
        s.SetColumnHidden(colNum, False)
    End Sub
    Public Sub hideRows(s As ISheet, colNum As Integer)
        Dim r1 As IRow = s.GetRow(0)
        r1.ZeroHeight = True
    End Sub


    Public Function setFomula(s1 As ISheet, cell As ICell, fmlStr As String) As Boolean
        cell.CellFormula = fmlStr
        Return True
    End Function

    Public Function writeToFile(workbook As IWorkbook, fileName As String) As Boolean
        'TODO: Handle error
        'System.UnauthorizedAccessException: 'Access to the path 'C:\ProgramData\result_and_transcript_system\result_and_transcript_system\1.0.0.0\GeneratedResultBroadsheet3000.705547525.xlsx' is denied
        Try
            Dim File As FileStream = New FileStream(fileName, FileMode.Create)
            workbook.Write(File)
            File.Close()
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try

    End Function
    Public Function exportDataGridViewToExcelFile_NPOI(dv As DataView, fileName As String) As String
        Dim dt As DataTable = dv.ToTable
        Dim workbook As IWorkbook = New XSSFWorkbook()
        Dim sheet1 As ISheet = workbook.CreateSheet("Sheet1")
        Dim row1 As IRow
        'Dim cell As ICell
        Dim cR As CellRangeAddress = New CellRangeAddress(1, 3, 1, 120)


        row1 = sheet1.CreateRow(0)   'headers
        For jCol = 0 To dt.Columns.Count - 1
            row1.CreateCell(jCol).SetCellValue(dt.Columns(jCol).ColumnName)
        Next

        For jRow = 0 To dt.Rows.Count - 1
            row1 = sheet1.CreateRow(jRow + 1)
            For jCol = 0 To dt.Columns.Count - 1
                'data
                row1.CreateCell(jCol).SetCellValue(dt.Rows(jRow).ItemArray(jCol).ToString)
            Next
        Next

        'save work
        'todo: if file exists(fileName) create new filename
        If System.IO.File.Exists(fileName) Then
            fileName = Path.GetDirectoryName(fileName) & "\" & Path.GetFileNameWithoutExtension(fileName) & Rnd(45).ToString & Now.Day.ToString & Path.GetExtension(fileName)
            'System.IO.File.Delete(fileName)
            If System.IO.File.Exists(fileName) Then fileName = Path.GetDirectoryName(fileName) & "\" & Path.GetFileNameWithoutExtension(fileName) & Rnd(45).ToString & Now.Day.ToString & Path.GetExtension(fileName)
            writeToFile(workbook, fileName)
            'Throw New Exception("RTPS Error: Excel File Already Exists!")
        Else
            writeToFile(workbook, fileName)
        End If

        Return fileName
    End Function

    Public Function exportTranscriptToExcelFile_NPOI(dv As DataView, fileName As String) As String
        Dim dt As DataTable = dv.ToTable
        Dim workbook As IWorkbook = New XSSFWorkbook()
        Dim sheet1 As ISheet = workbook.CreateSheet("Sheet1")
        Dim row1 As IRow
        'Dim cell As ICell
        Dim cR As CellRangeAddress = New CellRangeAddress(1, 3, 1, 120)


        row1 = sheet1.CreateRow(0)   'headers
        For jCol = 0 To dt.Columns.Count - 1
            row1.CreateCell(jCol).SetCellValue(dt.Columns(jCol).ColumnName)
        Next

        For jRow = 0 To dt.Rows.Count - 1
            row1 = sheet1.CreateRow(jRow + 1)
            For jCol = 0 To dt.Columns.Count - 1
                'data
                row1.CreateCell(jCol).SetCellValue(dt.Rows(jRow).ItemArray(jCol).ToString)
            Next
        Next

        'save work
        'todo: if file exists(fileName) create new filename
        If System.IO.File.Exists(fileName) Then
            fileName = Path.GetDirectoryName(fileName) & "\" & Path.GetFileNameWithoutExtension(fileName) & Rnd(45).ToString & Now.Day.ToString & Path.GetExtension(fileName)
            'System.IO.File.Delete(fileName)
            If System.IO.File.Exists(fileName) Then fileName = Path.GetDirectoryName(fileName) & "\" & Path.GetFileNameWithoutExtension(fileName) & Rnd(45).ToString & Now.Day.ToString & Path.GetExtension(fileName)
            writeToFile(workbook, fileName)
            'Throw New Exception("RTPS Error: Excel File Already Exists!")
        Else
            writeToFile(workbook, fileName)
        End If

        Return fileName
    End Function
    Public Function modifyExcelFile_NPOI(fileName As String, dv As DataView) As Boolean
        Dim xssfwb As XSSFWorkbook 'HSSFWorkbook for xls xSSFWorkbook for xlsx
        Dim dt As New DataTable("Broadsheet")
        dt = dv.ToTable
        Using file As FileStream = New FileStream(fileName, FileMode.Open, FileAccess.Read)
            xssfwb = New XSSFWorkbook(file)
            file.Close()
        End Using

        Dim sheet As ISheet = xssfwb.GetSheetAt(0)
        Dim row As IRow = sheet.GetRow(0)
        Dim newRow As IRow = sheet.CreateRow(row.LastCellNum)

        Dim cell As ICell = row.CreateCell(row.LastCellNum)


        sheet = xssfwb.GetSheetAt(0)
        row = sheet.GetRow(0)
        cell = row.CreateCell(row.LastCellNum)
        cell.SetCellValue("test")

        newRow = sheet.CreateRow(row.LastCellNum)  'new row

        For i As Integer = 0 To row.LastCellNum - 1
            'Debug.Print(row.GetCell(i).CellFormula)
            'Debug.Print(row.GetCell(i).CellComment.String.ToString)
            'Debug.Print(row.GetCell(i).StringCellValue) 'error if null
        Next
        For i As Integer = 0 To dt.Rows.Count - 1
            cell = sheet.GetRow(i).Cells(1)
            cell.SetCellFormula(dblQuote & dt.Rows(i).Item(0).ToString & dblQuote)
            ''cell.CellComment=("=" & dblQuote & ds_audit.Tables(0).Rows(i).Item(0).ToString & dblQuote)
            Debug.Print(cell.CellFormula)

            cell = sheet.GetRow(i).Cells(2)
            cell.SetCellFormula(dblQuote & dt.Rows(i).Item(2).ToString & dblQuote)

            'Debug.Print(row.GetCell(i).StringCellValue)
        Next

        Using file As FileStream = New FileStream(fileName, FileMode.Open, FileAccess.Write)
            xssfwb.Write(file)
            file.Close()
        End Using
        Return True
    End Function
    Public Function exportRegToExcelFile_NPOI(dv As DataView, fileName As String) As String
        Dim retFilename

        If fileName = "" Then fileName = My.Application.Info.DirectoryPath & "\broadsheets\SavedRegistration.xlsx"
        retFilename = exportDataGridViewToExcelFile_NPOI(dv, fileName)

        Return retFilename
    End Function
    Public Function exportStudentsToExcelFile_NPOI(dv As DataView, fileName As String) As String


        Dim retFilename
        If fileName = "" Then fileName = My.Application.Info.DirectoryPath & "\broadsheets\SavedStudents.xlsx"
        retFilename = exportDataGridViewToExcelFile_NPOI(dv, fileName)

        Return retFilename
    End Function

    Public Property excelFileName() As String
        Get
            Return _excelFileName
        End Get
        Set(ByVal value As String)
            _excelFileName = value
        End Set
    End Property

    Public Function readExcelFile()
        Return Nothing
    End Function
    Public Function readResultFile() As DataSet

        Dim stream As FileStream = Nothing
        Dim endOfRow, colNum, dFieldCount, i, SNCol, matNoCol, sNRow As Integer
        Dim dData As String = ""
        endOfRow = colNum = i = dFieldCount = SNCol = matNoCol = sNRow = 0
        colNum = 1
        Dim excelReader As IExcelDataReader
        Dim resultDS As DataSet
        Try
            stream = File.Open(objExcelFile.excelFileName, FileMode.Open, FileAccess.Read)
        Catch ex As Exception
            MsgBox("The file is already open. To resolve this issue" & vbCrLf & "1. Close the file" & vbCrLf & "2. Click OK")
        End Try
        Try 'step 1
            If stream Is Nothing Then stream = File.Open(objExcelFile.excelFileName, FileMode.Open, FileAccess.Read)
            'read from xml excel .xlsx

            Try 'step 2
                excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream)
                'excelReader.isfirstrowascolumnNames = True 'OPTIONAL TODO:create col name from first row
                resultDS = excelReader.AsDataSet() 'dataset result in results.tables 
                dFieldCount = excelReader.FieldCount
                stream.Dispose()

            Catch ex As Exception
                Return Nothing
                Exit Function
            End Try
        Catch ex As Exception
            If Not stream Is Nothing Then stream.Dispose()
            Return Nothing
            Exit Function
        End Try

        Return resultDS
    End Function
    Public Function readBroadSheetTemplateFile() As DataSet

        Dim stream As FileStream = Nothing
        Dim endOfRow, colNum, dFieldCount, i, SNCol, matNoCol, sNRow As Integer
        Dim dData As String = ""
        endOfRow = colNum = i = dFieldCount = SNCol = matNoCol = sNRow = 0
        colNum = 1
        Dim excelReader As IExcelDataReader
        Dim resultDS As DataSet
        Try 'step 1
            stream = File.Open(objExcelFile.excelFileName, FileMode.Open, FileAccess.Read)
            'read from xml excel .xlsx

            Try 'step 2
                excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream)
                'excelReader.isfirstrowascolumnNames = True 'OPTIONAL TODO:create col name from first row
                resultDS = excelReader.AsDataSet() 'dataset result in results.tables 
                dFieldCount = excelReader.FieldCount
                Try 'step3
                    While excelReader.Read
                        i = i + 1
                        If excelReader.GetValue(colNum) IsNot Null Then
                            dData = excelReader.GetString(colNum) 'throws error
                        Else
                            dData = "" 'handle
                        End If
                        Debug.Print(dData)
                        If dData = Nothing Then
                            Debug.Print("Empty cell founnd at row/col: " & i.ToString & "/" & colNum.ToString)

                        ElseIf dData.Contains("S/N") Then
                            sNRow = i
                            Debug.Print("S/N found at row/col: " & i.ToString & "/" & colNum.ToString)

                            'TODO: Check integrity of template
                            'no of cols, prescence of specific fields
                            'Detect MAT. NO
                        ElseIf dData.Contains("MAT") Or dData.Contains("MAT NO") Then
                            matNoCol = colNum
                            Debug.Print("MAT NO found at row/col: " & i.ToString & "/" & colNum.ToString)
                            Debug.Print("Found MATNO: " & excelReader.GetString(colNum))
                        End If
                    End While

                    'Report analysis
                    If matNoCol = 0 Then Debug.Print("MAT Number Not FOUND")
                Catch ex As Exception
                    If ex.Message.Contains("Object reference not set to an instance of an object") Then endOfRow = i
                    'Throw ex dont throw
                End Try

                Debug.Print("SUMMARY")
                Debug.Print("Row Count: " & excelReader.RowCount.ToString)
                Debug.Print("Row Height: " & excelReader.RowHeight.ToString)
                Debug.Print("FieldCount: " & dFieldCount.ToString)
                stream.Dispose()

            Catch ex As Exception
                Return Nothing
                Exit Function
            End Try
        Catch ex As Exception
            If Not stream Is Nothing Then stream.Dispose()
            Return Nothing
            Exit Function
        End Try





        Return resultDS






    End Function
End Class
'End Namespace