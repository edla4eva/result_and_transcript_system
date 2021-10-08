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


'Namespace ExcelWriter myUniqueNamespace
Public Class ClassExcelFile


        Private _excelFileName As String = Nothing

    Public Sub New(Optional subFilePathExcludingProgDir As String = "\samples\broadsheet.xlsx")
        Try
            _excelFileName = My.Application.Info.DirectoryPath & subFilePathExcludingProgDir
        Catch ex As Exception
            MsgBox("Cannot create Excel Automation Object" & vbCrLf & ex.Message)
        End Try
    End Sub
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
    Public Function exportBroadsheettoExcelFile_NPOI(dv As DataView, Optional fileName As String = "") As Boolean
        Dim dt As DataTable = dv.ToTable
        Dim workbook As IWorkbook = New XSSFWorkbook()
        Dim sheet1 As ISheet = workbook.CreateSheet("Sheet1")
        Dim row1 As IRow
        Dim cell As ICell

        If fileName = "" Then fileName = My.Application.Info.DirectoryPath & "\broadsheets\GeneratedBroadsheet.xlsx"

        'headers
        row1 = sheet1.CreateRow(1)
        row1.CreateCell(1).SetCellValue("Name of Department")   'row1.CreateCell(jCol).SetCellValue("S/N")
        row1 = sheet1.CreateRow(2)
        row1.CreateCell(1).SetCellValue("Name of Faculty")
        Dim style As ICellStyle = changeStyle(workbook)
        'cell.SetCellValue(New XSSFRichTextString("This is a styled Department Name"))
        'cell.CellStyle = style

        'TODO:  iterate set style
        style.BorderRight = BorderStyle.Medium
        style.BorderLeft = BorderStyle.Medium
        style.BorderTop = BorderStyle.Medium
        style.BorderBottom = BorderStyle.Medium
        row1.Cells(0).CellStyle = (style)


        row1 = sheet1.CreateRow(8)  'row 9
        For jCol = 0 To dt.Columns.Count - 1
            row1.CreateCell(jCol).SetCellValue(dt.Columns(jCol).ColumnName.ToString)   'row1.CreateCell(jCol).SetCellValue("S/N")
        Next
        row1 = sheet1.CreateRow(8)  'row 9
        For jCol = 0 To dt.Columns.Count - 1
            row1.CreateCell(jCol).SetCellValue("Test")   'row1.CreateCell(jCol).SetCellValue("S/N")
        Next

        For iRow = 0 To dt.Rows.Count - 1
            row1 = sheet1.CreateRow(iRow + 9)
            For jCol = 0 To dt.Columns.Count - 1
                row1.CreateCell(jCol).SetCellValue(dt.Rows(iRow).Item(jCol).ToString)   'row1.CreateCell(jCol).SetCellValue("S/N")
            Next
        Next





        hideCols(sheet1, ExcelColumns.colF - 1) '0=A, 1=B, 2=C, 3=D but the Enum has a base of 1
            hideCols(sheet1, ExcelColumns.colH - 1) 'col H to AG 100-400L courses
        'colAG = colz+colg
        For x = ExcelColumns.colH To ExcelColumns.colZ + ExcelColumns.colG
            hideCols(sheet1, x - 1)
        Next

        'set formula
        row1 = sheet1.CreateRow(dt.Rows.Count)
        cell = row1.CreateCell(0)
        setFomula(sheet1, cell, "D2+D3+6")

        setWidthHeight(sheet1, row1, cell)
        mergeCells(sheet1, row1.Cells(0), row1.RowNum, row1.RowNum, 1, 2)


        'save work
        'todo: if file exists(fileName) create new filename
        If System.IO.File.Exists(fileName) Then
            fileName = Path.GetDirectoryName(fileName) & "\" & Path.GetFileNameWithoutExtension(fileName) & Rnd(45).ToString & Now.Day.ToString & Path.GetExtension(fileName)
            writeToFile(workbook, fileName)
            'Throw New Exception("RTPS Error: Excel File Already Exists!")
        Else
            writeToFile(workbook, fileName)
        End If


        Return True
    End Function

    Public Function createExcelFile_NPOI(Optional fileName As String = "generatedExcelFile.xlsx") As Boolean
        Dim workbook As IWorkbook = New XSSFWorkbook()
        Dim sheet1 As ISheet = workbook.CreateSheet("Sheet1")
        Dim row1 As IRow = sheet1.CreateRow(0)
        row1.CreateCell(0).SetCellValue("Sample Header")
        row1.CreateCell(1).SetCellValue("Col2")
        row1.CreateCell(2).SetCellValue("Col3")
        Dim row2 As IRow = sheet1.CreateRow(1)
        row2.CreateCell(0).SetCellValue("Content 1")
        row2.CreateCell(1).SetCellValue("99")
        row2.CreateCell(2).SetCellValue("99")
        Dim row3 As IRow = sheet1.CreateRow(2)
        row3.CreateCell(0).SetCellValue("Content 2")
        row3.CreateCell(1).SetCellValue("99")
        row3.CreateCell(2).SetCellValue("99")
        Dim row4 As IRow = sheet1.CreateRow(3)
        row4.CreateCell(0).SetCellValue("Content 3")
        row4.CreateCell(1).SetCellValue("88")
        row4.CreateCell(2).SetCellValue("97")

        Dim row5 As IRow = sheet1.CreateRow(4)
        Dim cell As ICell = row5.CreateCell(1)
        Dim style As ICellStyle = changeStyle(workbook)
        cell.SetCellValue(New XSSFRichTextString("Sample Styled Cell"))

        'TODO. iterate
        row4.Cells(0).CellStyle = (style)
        row4.Cells(1).CellStyle = (style)
        row4.Cells(2).CellStyle = (style)

        setFomula(sheet1, row4.Cells(2), "A2+A3")    '"A2+A3"
        setWidthHeight(sheet1, row4, cell)
        'mergeCells(sheet1, row4.Cells(0), row4.RowNum, row4.RowNum, 1, 2)
        'save work
        writeToFile(workbook, fileName)

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

    Public Function setWidthHeight(sheet1 As ISheet, row As IRow, cell As ICell) As Boolean

        'set the width of columns
        sheet1.SetColumnWidth(0, 30 * 256)
        sheet1.SetColumnWidth(1, 60 * 256)
        sheet1.SetColumnWidth(2, 60 * 256)

        'set the width of height
        row.Height = 100 * 20

        Return True
    End Function
    Public Function setFomula(s1 As ISheet, cell As ICell, fmlStr As String) As Boolean
        cell.CellFormula = fmlStr
        Return True
    End Function

    Public Function writeToFile(workbook As IWorkbook, fileName As String) As Boolean
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