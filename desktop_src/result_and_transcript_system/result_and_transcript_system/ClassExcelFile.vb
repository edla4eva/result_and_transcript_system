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
    Public Function exportBroadsheettoExcelFile_NPOI(dv As DataView, fileName As String, objBS As ClassBroadsheets, dictCr As Dictionary(Of String, Integer), footers As String()) As String
        Dim dt As DataTable = dv.ToTable
        Dim workbook As IWorkbook = New XSSFWorkbook()
        Dim sheet1 As ISheet = workbook.CreateSheet("Sheet1")
        Dim row1, rowCredits As IRow
        'Dim cell As ICell
        Dim cR As CellRangeAddress = New CellRangeAddress(1, 3, 1, 120)

        Dim style As ICellStyle
        Dim styleCenter As ICellStyle '= changeStyle(workbook)
        Dim styleWrap As ICellStyle '= changeStyle(workbook)
        Dim styleMediumBorder As ICellStyle '= changeStyle(workbook)
        Dim styleMediumBorderVertical As ICellStyle '= changeStyle(workbook)
        Dim styleMediumBorderCenter As ICellStyle '= changeStyle(workbook)
        If fileName = "" Then fileName = My.Application.Info.DirectoryPath & "\broadsheets\GeneratedBroadsheet.xlsx"




        'headers
        Dim dFont As New XSSFFont()
        dFont.IsBold = True
        dFont.FontName = "Times New Roman"
        dFont.FontHeightInPoints = 14

        styleMediumBorderCenter = workbook.CreateCellStyle()
        styleMediumBorderCenter.Alignment = HorizontalAlignment.Center
        styleMediumBorderCenter.SetFont(dFont)

        'styleMediumBorder.CloneStyleFrom(style)


        '# Insert values for header
        row1 = sheet1.CreateRow(0)  'row1
        row1.CreateCell(0).SetCellValue("")   'control row
        row1 = sheet1.CreateRow(1)  'row2
        row1.CreateCell(0).SetCellValue(objBS.DepartmentName.ToUpper)   'row1.CreateCell(jCol).SetCellValue("S/N")
        row1.GetCell(0).CellStyle = (styleMediumBorderCenter)

        row1 = sheet1.CreateRow(2)  'row3
        row1.CreateCell(0).SetCellValue(objBS.FacultyName.ToUpper)  ''cell.SetCellValue(New XSSFRichTextString("This is a styled Faculty Name"))
        row1.Cells(0).CellStyle = (styleMediumBorderCenter)
        row1 = sheet1.CreateRow(3)  'row4
        row1.CreateCell(0).SetCellValue(objBS.SchoolName.ToUpper)
        row1.Cells(0).CellStyle = (styleMediumBorderCenter)
        row1 = sheet1.CreateRow(4)  'row5
        row1.CreateCell(0).SetCellValue("EXAMINATION RECORD SHEET (" & objBS.Session & " Academic Session)")
        row1.Cells(0).CellStyle = (styleMediumBorderCenter)
        row1 = sheet1.CreateRow(5)  'row6

        row1.CreateCell(0).SetCellValue("LEVEL: " & objBS.Level.ToString)      'TODO: if 2yrs then 100L=        
        If objBroadsheet.DeptId > 1 Then        'todo objBS.TwoYear=true
            row1.GetCell(0).SetCellValue("YEAR " & (objBS.Level / 100).ToString)
        End If

        row1.Cells(0).CellStyle = (styleMediumBorderCenter)
        row1 = sheet1.CreateRow(6)  'row7
        row1.CreateCell(0).SetCellValue("")
        row1.Cells(0).CellStyle = (styleMediumBorderCenter)

        'Merge headers dept name etc
        'mergeCells(sheet1, sheet1.GetRow(1).Cells(0), sheet1.GetRow(1).RowNum, sheet1.GetRow(1).RowNum, 1, 120)
        'mergeCells(sheet1, sheet1.GetRow(2).Cells(0), sheet1.GetRow(2).RowNum, sheet1.GetRow(2).RowNum, 1, 120)
        'mergeCells(sheet1, sheet1.GetRow(3).Cells(0), sheet1.GetRow(3).RowNum, sheet1.GetRow(3).RowNum, 1, 120)
        'mergeCells(sheet1, sheet1.GetRow(4).Cells(0), sheet1.GetRow(4).RowNum, sheet1.GetRow(4).RowNum, 1, 120)

        '#STYLE: Special case of merged cells border
        cR = New CellRangeAddress(1, 1, 0, 120 - 1 + 9)
        sheet1.AddMergedRegion(cR)
        cR = New CellRangeAddress(2, 2, 0, 120 - 1 + 9)
        sheet1.AddMergedRegion(cR)
        cR = New CellRangeAddress(3, 3, 0, 120 - 1 + 9)
        sheet1.AddMergedRegion(cR)
        cR = New CellRangeAddress(4, 4, 0, 120 - 1 + 9)
        sheet1.AddMergedRegion(cR)
        cR = New CellRangeAddress(5, 5, 0, 120 - 1 + 9)
        sheet1.AddMergedRegion(cR)
        ' applyDBorderToMergedReg(cR, sheet1)
        'sets the border of the merged cells
        cR = New CellRangeAddress(1, 5, 0, 120 - 1 + 9)
        RegionUtil.SetBorderTop(BorderStyle.Medium, cR, sheet1)
        RegionUtil.SetBorderBottom(BorderStyle.Medium, cR, sheet1)
        RegionUtil.SetBorderLeft(BorderStyle.Medium, cR, sheet1)
        RegionUtil.SetBorderRight(BorderStyle.Medium, cR, sheet1)


        '###headers 'all especialy Course Codes
        styleMediumBorder = workbook.CreateCellStyle()
        styleMediumBorder.BorderRight = BorderStyle.Medium
        styleMediumBorder.BorderLeft = BorderStyle.Medium
        styleMediumBorder.BorderTop = BorderStyle.Medium
        styleMediumBorder.BorderBottom = BorderStyle.Medium

        styleMediumBorderVertical = workbook.CreateCellStyle()
        styleMediumBorderVertical.BorderRight = BorderStyle.Medium
        styleMediumBorderVertical.BorderLeft = BorderStyle.Medium
        styleMediumBorderVertical.BorderTop = BorderStyle.Medium
        styleMediumBorderVertical.BorderBottom = BorderStyle.Medium
        styleMediumBorderVertical.Rotation = 90
        row1 = sheet1.CreateRow(ROW_HEADER)  'row 7
        rowCredits = sheet1.CreateRow(ROW_CREDIT)  '8=row 9
        For jCol = 0 To dt.Columns.Count - 1
            'data
            row1.CreateCell(jCol).SetCellValue(dt.Columns(jCol).ColumnName.ToString)
            'Proper headers
            If dt.Columns(jCol).ColumnName.ToString.ToUpper.Contains("SN") Then row1.GetCell(jCol).SetCellValue("S/N")
            If dt.Columns(jCol).ColumnName.ToString.ToUpper.Contains("MATNO") Then row1.GetCell(jCol).SetCellValue("MAT. NO.")
            If dt.Columns(jCol).ColumnName.ToString.ToUpper.Contains("REPEATCOURSES_1") Then row1.GetCell(jCol).SetCellValue("REPEAT COURSES IN CODES AND MARKS (FIRST SEMESTER)")
            If dt.Columns(jCol).ColumnName.ToString.ToUpper.Contains("FULLNAME") Then row1.GetCell(jCol).SetCellValue("NAME OF CANDIDATE (SURNAME LAST AND IN BLOCK LETTERS)")
            If dt.Columns(jCol).ColumnName.ToString.ToUpper.Contains("FAILED") Then row1.GetCell(jCol).SetCellValue("COURSES FAILED/TRAILED")
            If dt.Columns(jCol).ColumnName.ToString.ToUpper.Contains("REPEATCOURSES_2") Then row1.GetCell(jCol).SetCellValue("REPEAT COURSES IN CODES AND MARKS (SECOND SEMESTER)")


            '
            If dictAllCourseCodeKeyAndCourseUnitVal.Count = 0 Then Exit Function 'no need '
            If jCol >= COURSE_START_COL And dictAllCourseCodeKeyAndCourseUnitVal.ContainsKey(dt.Columns(jCol).ColumnName.ToString) Then rowCredits.CreateCell(jCol).SetCellValue(dictAllCourseCodeKeyAndCourseUnitVal(dt.Columns(jCol).ColumnName.ToString))
            'Style
            If jCol < COURSE_START_COL Then row1.Cells(jCol).CellStyle = (styleMediumBorder) Else row1.Cells(jCol).CellStyle = (styleMediumBorderVertical)
            cR = New CellRangeAddress(ROW_HEADER, ROW_HEADER + 1, jCol, jCol)
            sheet1.AddMergedRegion(cR)
            RegionUtil.SetBorderTop(BorderStyle.Medium, cR, sheet1)
            RegionUtil.SetBorderBottom(BorderStyle.Medium, cR, sheet1)
            RegionUtil.SetBorderLeft(BorderStyle.Medium, cR, sheet1)
            RegionUtil.SetBorderRight(BorderStyle.Medium, cR, sheet1)
        Next

        '#### Credits 


        style = changeStyle(workbook)
        styleCenter = changeStyle(workbook)
        styleCenter.Alignment = HorizontalAlignment.Center
        styleWrap = changeStyle(workbook)
        styleWrap.WrapText = True


        '###The results
        For iRow = 0 To dt.Rows.Count - 1
            row1 = sheet1.CreateRow(iRow + ALL_HEADERS_COUNT)
            For jCol = 0 To dt.Columns.Count - 1
                row1.CreateCell(jCol).SetCellValue(dt.Rows(iRow).Item(jCol).ToString)   'row1.CreateCell(jCol).SetCellValue("S/N")
                If dt.Rows(iRow).Item(jCol).ToString = "-2" Then row1.CreateCell(jCol).SetCellValue("NR")
                If dt.Rows(iRow).Item(jCol).ToString = "-1" Then row1.CreateCell(jCol).SetCellValue("ABS")
                row1.Cells(jCol).CellStyle = (style)
                If jCol >= COURSE_START_COL Then row1.Cells(jCol).CellStyle = styleCenter
            Next
            'style
            row1.GetCell(2).CellStyle = styleWrap   'ColC name
            row1.GetCell(4).CellStyle = styleWrap
            row1.GetCell(6).CellStyle = styleWrap   'repeated
            row1.GetCell(7).CellStyle = styleWrap
        Next

        'TODO: Get footer fro db
        Dim strFooter As String() = {
        "(A)              SUCCESSFUL STUDENTS:",
        "(B)              STUDENTS WITH CARRY-OVER COURSES",
        "(C)              STUDENTS WITH PROBATE/TRANSFER",
        "(D)              MEDICAL CASES:",
        "(E)              ABSENCE FROM EXAMINATIONS",
        "(F)              WITHHELD RESULTS Nil",
        "(G)              EXPELLED/RUSTICATED/SUSPENDED STUDENTS:",
        "(H)              TEMPORARY WITHDRAWAL FROM THE UNIVERSITY:",
        "(I)              UNREGISTERED STUDENTS:", "", ""}
        Dim strFooterVal As Integer() = {10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0}
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
        'Footers
        doFooters(sheet1, strFooter, strFooterVal, dt.Rows.Count, style, footers)
        'OR
        Dim rowFooter As IRow
        For i = 0 To 9
            rowFooter = sheet1.CreateRow(dt.Rows.Count + ALL_HEADERS_COUNT + i + 1)    'account for 9 header rows
            rowFooter.CreateCell(2).SetCellValue(strFooter(i))
            rowFooter.CreateCell(3).SetCellValue(strFooterVal(i))  '"=COUNT()"  'total-successful
            rowFooter.GetCell(2).CellStyle = (style)
            rowFooter.GetCell(3).CellStyle = (style)
        Next

        'Hide unused columns such as extra cols for courses '0=A, 1=B, 2=C, 3=D but the Enum has a base of 1
        hideCols(sheet1, ExcelColumns.colD - 1) 'Name
        hideCols(sheet1, ExcelColumns.colE - 1)
        hideCols(sheet1, ExcelColumns.colF - 1)
        'ColG is repeated course wrap
        'col H to AG 100-400L courses
        'colAG = colz+colg
        'colBJ = colz + colz + colj
        For x = COURSE_START_COL To LAST_COL    ' ExcelColumns.colH To (ExcelColumns.colZ * 4 + ExcelColumns.colP) - 1    'H-DP
            If sheet1.GetRow(ROW_HEADER).Cells(x).StringCellValue.Contains("ColUNIQUE") Then
                hideCols(sheet1, x)
            Else
                If dictAllCourseCodeKeyAndCourseLevelVal.ContainsKey(sheet1.GetRow(ROW_HEADER).Cells(x).StringCellValue) Then
                    If Not dictAllCourseCodeKeyAndCourseLevelVal(sheet1.GetRow(ROW_HEADER).Cells(x).StringCellValue) = objBS.Level Then hideCols(sheet1, x)
                End If
            End If
        Next

        ''set formula
        'row1 = sheet1.CreateRow(dt.Rows.Count)
        'cell = row1.CreateCell(0)
        'setFomula(sheet1, cell, "D2+D3+6")

        setWidthHeight(sheet1)   'todo test

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

    Public Sub doFooters(sheet1 As ISheet, strFooter As String(), strFooterVal As Integer(), rowCount As Integer, style As ICellStyle, footers As String())
        Dim rowFooter As IRow
        rowFooter = sheet1.CreateRow(rowCount + ALL_HEADERS_COUNT + 1)
        rowFooter.CreateCell(1).SetCellValue("CATEGORY")   'row1.CreateCell(jCol).SetCellValue("S/N")


        rowFooter = sheet1.CreateRow(rowCount + ALL_HEADERS_COUNT + 2)    'account for 9 header rows
        rowFooter.CreateCell(2).SetCellValue(strFooter(0))
        rowFooter.CreateCell(3).SetCellValue("=COUNTIF(EA10:EA175,'')") 'todo: dblquote
        rowFooter.GetCell(2).CellStyle = (style)
        rowFooter.GetCell(3).CellStyle = (style)

        rowFooter = sheet1.CreateRow(rowCount + ALL_HEADERS_COUNT + 3)    'account for 9 header rows
        rowFooter.CreateCell(2).SetCellValue(strFooter(1))   'row1.CreateCell(jCol).SetCellValue("S/N")
        rowFooter.CreateCell(3).SetCellValue("=BM186-BM177")  '"=COUNT()"  'total-successful
        rowFooter.GetCell(2).CellStyle = (style)
        rowFooter.GetCell(3).CellStyle = (style)


        For i = 0 To 9
            rowFooter = sheet1.CreateRow(rowCount + ALL_HEADERS_COUNT + i + 1)    'account for 9 header rows
            rowFooter.CreateCell(2).SetCellValue(strFooter(i))
            rowFooter.CreateCell(3).SetCellValue(strFooterVal(i))  '"=COUNT()"  'total-successful
            rowFooter.GetCell(2).CellStyle = (style)
            rowFooter.GetCell(3).CellStyle = (style)
        Next
        'firstclass=COUNTIFS(DY10:DY175,"1")    seconclass =COUNTIFS(DY10:DY175,"2.1") 

        'final footers HOD, dean etc
        rowFooter = sheet1.CreateRow(rowCount + ALL_HEADERS_COUNT + 11)    'account for 9 header rows
        rowFooter.CreateCell(2).SetCellValue(footers(0))
        rowFooter.CreateCell(8).SetCellValue(footers(1))
        rowFooter.CreateCell(16).SetCellValue(footers(3))
        rowFooter.GetCell(2).CellStyle = (style)
        rowFooter.GetCell(8).CellStyle = (style)
        rowFooter.GetCell(16).CellStyle = (style)
    End Sub
    Public Function setWidthHeight(sheet1 As ISheet) As Boolean
        'set the width of columns
        sheet1.SetColumnWidth(0, 5 * 256)   'colA   sn
        sheet1.SetColumnWidth(MATNO_COL, 15 * 256)  'colB   matno   =14.29
        sheet1.SetColumnWidth(FULLNAME_COL, 45 * 256)  'ColC   Full Name
        sheet1.SetColumnWidth(REPEATED_1_COL, 60 * 256)  'repeated Fist Semester
        sheet1.SetColumnWidth(REPEATED_1_COL - 1, 60 * 256)  'repeated All
        sheet1.SetColumnWidth(REPEATED_1_COL - 2, 60 * 256)  'surname
        sheet1.SetColumnWidth(REPEATED_1_COL - 3, 60 * 256)  'Other Names

        sheet1.SetColumnWidth(REPEATED_2_COL, 60 * 256)  'repeated 2nd Sem
        sheet1.SetColumnWidth((ExcelColumns.colZ - 1) * 3 + ExcelColumns.colAH - 1, 60 * 256)  'repeated 2nd Sem col CH
        For j = COURSE_START_COL To LAST_COL + 6
            sheet1.SetColumnWidth(j, 4 * 256)  '3.71 or approx 4 for Result cols
        Next

        For j = LAST_COL To LAST_COL + 6
            sheet1.SetColumnWidth(j, 4 * 256)  '5 gor GPA ...
        Next
        'ExcelColumns.colZ+ExcelColumns.colZ + ExcelColumns.colZ + ExcelColumns.colZ + ExcelColumns.colW=dw 26*4+23
        sheet1.SetColumnWidth(LAST_COL - 3, 4 * 256)  'GPA DW
        'set the width of height
        'row.Height = 100 * 20

        'sheet1.SetRowBreak = LinkLabelLinkClickedEventArgs
        sheet1.GetRow(ROW_HEADER).Height = (4 * 256)    'row8 bcos its vertically aligned NOTE different scale from width
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
        Dim File As FileStream = New FileStream(fileName, FileMode.Create)
        workbook.Write(File)
        File.Close()
        Return True
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
    Public Function exportStudentsToExcelFile_NPOI(dv As DataView, fileName As String) As String
        Dim dt As DataTable = dv.ToTable
        Dim workbook As IWorkbook = New XSSFWorkbook()
        Dim sheet1 As ISheet = workbook.CreateSheet("Sheet1")
        Dim row1 As IRow
        'Dim cell As ICell
        Dim cR As CellRangeAddress = New CellRangeAddress(1, 3, 1, 120)

        If fileName = "" Then fileName = My.Application.Info.DirectoryPath & "\broadsheets\SavedStudents.xlsx"

        For jRow = 0 To dt.Rows.Count - 1
            row1 = sheet1.CreateRow(jRow)
            For jCol = 0 To dt.Columns.Count - 1
                'data
                row1.CreateCell(jCol).SetCellValue(dt.Columns(jCol).ColumnName.ToString)
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
        Try 'step 1
            stream = File.Open(objExcelFile.excelFileName, FileMode.Open, FileAccess.Read)
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