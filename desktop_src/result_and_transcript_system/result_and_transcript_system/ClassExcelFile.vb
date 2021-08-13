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
    Public Function createExcelFile(Optional fileName As String = "GeneratedResult.xlsx") As Boolean
        Dim workbook As IWorkbook = New XSSFWorkbook()
        Dim sheet1 As ISheet = workbook.CreateSheet("Sheet1")
        Dim row1 As IRow = sheet1.CreateRow(0)
        row1.CreateCell(0).SetCellValue("S/N")
        row1.CreateCell(1).SetCellValue("MATNO")
        row1.CreateCell(2).SetCellValue("SCORE")
        Dim row2 As IRow = sheet1.CreateRow(1)
        row2.CreateCell(0).SetCellValue("1")
        row2.CreateCell(1).SetCellValue("ENG0902145")
        row2.CreateCell(2).SetCellValue("80")
        Dim row3 As IRow = sheet1.CreateRow(2)
        row3.CreateCell(0).SetCellValue("2")
        row3.CreateCell(1).SetCellValue("ENG0902345")
        row3.CreateCell(2).SetCellValue("67")
        Dim row4 As IRow = sheet1.CreateRow(3)
        row4.CreateCell(0).SetCellValue("3")
        row4.CreateCell(1).SetCellValue("ENG0902348")
        row4.CreateCell(2).SetCellValue("97")

        Dim row5 As IRow = sheet1.CreateRow(4)
        Dim cell As ICell = row5.CreateCell(1)
        Dim style As ICellStyle = changeStyle(workbook, sheet1, row4, cell)
        cell.SetCellValue(New XSSFRichTextString("This is a test for styling"))

        'TODO. iterate
        row4.Cells(0).CellStyle = (style)
        row4.Cells(1).CellStyle = (style)
        row4.Cells(2).CellStyle = (style)

        setFomula(sheet1, row4.Cells(2))
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
        cell.SetCellValue(New XSSFRichTextString("This is a test of merging"))
        sheet.AddMergedRegion(New CellRangeAddress(fRow, lRow, fCol, lCol)) 'firstRow, lRow, fCol, lCol


        Return True
    End Function
    Public Function changeStyle(workbook As IWorkbook, sheet As ISheet, row As IRow, cell As ICell) As ICellStyle
        'Dim workbook As IWorkbook = New XSSFWorkbook()
        ' Dim sheet As ISheet = workbook.CreateSheet("Sheet A1")
        'Dim row As IRow = sheet.CreateRow(1)
        'Dim cell As ICell = row.CreateCell(1)
        cell.SetCellValue("Styled")
        Dim style As ICellStyle = workbook.CreateCellStyle()
        style.BorderBottom = BorderStyle.Thin
        style.BottomBorderColor = IndexedColors.Black.Index
        style.BorderLeft = BorderStyle.Thin
        style.LeftBorderColor = IndexedColors.Black.Index
        style.BorderRight = BorderStyle.Thin
        style.RightBorderColor = IndexedColors.Black.Index
        style.BorderTop = BorderStyle.Thin
        style.TopBorderColor = IndexedColors.Black.Index
        'style.BorderDiagonalLineStyle = BorderStyle.Medium
        'style.BorderDiagonal = BorderDiagonal.Forward
        ' style.BorderDiagonalColor = IndexedColors.Gold.Index
        cell.CellStyle = style

        Dim cell2 As ICell = row.CreateCell(2)
        'cell2.SetCellValue(5)
        'Dim style2 As ICellStyle = workbook.CreateCellStyle
        'style2.BorderDiagonalLineStyle = BorderStyle.Medium
        'style2.BorderDiagonal = BorderDiagonal.Backward
        'style2.BorderDiagonalColor = IndexedColors.Red.Index
        'cell2.CellStyle = style2




        Return style
    End Function
    Public Sub hideRowsCols(s As ISheet)
        Dim r1 As IRow = s.CreateRow(0)
        Dim r2 As IRow = s.CreateRow(1)
        Dim r3 As IRow = s.CreateRow(2)
        Dim r4 As IRow = s.CreateRow(3)
        Dim r5 As IRow = s.CreateRow(4)
        r2.ZeroHeight = True
        s.SetColumnHidden(2, True)
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
    Public Function setFomula(s1 As ISheet, cell As ICell) As Boolean
        cell.CellFormula = "A2+A3"
        ''set A2
        's1.CreateRow(1).CreateCell(0).SetCellValue(-5)
        ''set B2
        's1.GetRow(1).CreateCell(1).SetCellValue(1111)
        ''set C2
        's1.GetRow(1).CreateCell(2).SetCellValue(7.623)
        ''set A3
        's1.CreateRow(2).CreateCell(0).SetCellValue(2.2)

        ''set A4=A2+A3
        's1.CreateRow(3).CreateCell(0).CellFormula = "A2+A3"
        'set D2=SUM(A2:C2);
        's1.GetRow(1).CreateCell(3).CellFormula = "SUM(A2:C2)"

        'Dim cell As ICell = sheet2.CreateRow(0).CreateCell(0);
        'cell.CellFormula = "Sheet1!A2+Sheet1!A3"

        Return True
    End Function

    Public Function writeToFile(workbook As IWorkbook, fileName As String) As Boolean
        Dim File As FileStream = New FileStream(fileName, FileMode.Create)
        workbook.Write(File)
        File.Close()
        Return True
    End Function
    Public Function modifyExcelFile(fileName As String) As Boolean
        Dim xssfwb As XSSFWorkbook 'HSSFWorkbook for xls xSSFWorkbook for xlsx

        Using file As FileStream = New FileStream(fileName, FileMode.Open, FileAccess.Read)
            xssfwb = New XSSFWorkbook(file)
            file.Close()
        End Using

        Dim sheet As ISheet = xssfwb.GetSheetAt(0)
        Dim row As IRow = sheet.GetRow(0)
        sheet.CreateRow(row.LastCellNum)
        Dim cell As ICell = row.CreateCell(row.LastCellNum)
        cell.SetCellValue("test")

        For i As Integer = 0 To row.LastCellNum - 1
            Console.WriteLine(row.GetCell(i))
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