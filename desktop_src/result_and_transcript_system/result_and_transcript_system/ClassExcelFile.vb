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
        cell.SetCellValue(New XSSFRichTextString("This is a test for styling"))
        changeStyle(workbook, sheet1, row4, cell)

        'save work
        writeToFile(workbook, fileName)

        Return True
    End Function

    Public Function changeStyle(workbook As IWorkbook, sheet As ISheet, row As IRow, cell As ICell) As Boolean
        'Dim workbook As IWorkbook = New XSSFWorkbook()
        ' Dim sheet As ISheet = workbook.CreateSheet("Sheet A1")
        'Dim row As IRow = sheet.CreateRow(1)
        'Dim cell As ICell = row.CreateCell(1)
        cell.SetCellValue(4)
        Dim style As ICellStyle = workbook.CreateCellStyle()
        style.BorderBottom = BorderStyle.Thin
        style.BottomBorderColor = IndexedColors.Black.Index
        style.BorderLeft = BorderStyle.DashDotDot
        style.LeftBorderColor = IndexedColors.Green.Index
        style.BorderRight = BorderStyle.Hair
        style.RightBorderColor = IndexedColors.Blue.Index
        style.BorderTop = BorderStyle.MediumDashed
        style.TopBorderColor = IndexedColors.Orange.Index
        style.BorderDiagonalLineStyle = BorderStyle.Medium
        style.BorderDiagonal = BorderDiagonal.Forward
        style.BorderDiagonalColor = IndexedColors.Gold.Index
        cell.CellStyle = style
        Dim cell2 As ICell = row.CreateCell(2)
        cell2.SetCellValue(5)
        Dim style2 As ICellStyle = workbook.CreateCellStyle()
        style2.BorderDiagonalLineStyle = BorderStyle.Medium
        style2.BorderDiagonal = BorderDiagonal.Backward
        style2.BorderDiagonalColor = IndexedColors.Red.Index
        cell2.CellStyle = style2


        'Merge Cells
        cell2.SetCellValue(New XSSFRichTextString("This is a test of merging"))
        sheet.AddMergedRegion(New CellRangeAddress(1, 1, 1, 2))

        writeToFile(workbook)

        Return True
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

    Public Function setWidthHeight(sheet1 As ISheet) As Boolean

        'set the width of columns
        sheet1.SetColumnWidth(0, 50 * 256)
        sheet1.SetColumnWidth(1, 100 * 256)
        sheet1.SetColumnWidth(2, 150 * 256)

        'set the width of height
        sheet1.CreateRow(0).Height = 100 * 20
        sheet1.CreateRow(1).Height = 200 * 20
        sheet1.CreateRow(2).Height = 300 * 20
        Return True
    End Function
    Public Function setFomula(s1 As ISheet) As Boolean
        'set A2
        s1.CreateRow(1).CreateCell(0).SetCellValue(-5)
        'set B2
        s1.GetRow(1).CreateCell(1).SetCellValue(1111)
        'set C2
        s1.GetRow(1).CreateCell(2).SetCellValue(7.623)
        'set A3
        s1.CreateRow(2).CreateCell(0).SetCellValue(2.2)

        'set A4=A2+A3
        s1.CreateRow(3).CreateCell(0).CellFormula = "A2+A3"
        'set D2=SUM(A2:C2);
        s1.GetRow(1).CreateCell(3).CellFormula = "SUM(A2:C2)"

        'Dim cell As ICell = sheet2.CreateRow(0).CreateCell(0);
        'cell.CellFormula = "Sheet1!A2+Sheet1!A3"

        Return True
    End Function

    Public Function writeToFile(workbook As IWorkbook, Optional fileName As String = "test.xlsx") As Boolean
        Dim File As FileStream = New FileStream(fileName, FileMode.Create)
        workbook.Write(File)
        File.Close()
        Return True
    End Function
    Public Function modifyExcelFile(Optional fileName As String = "c:\temp\testfile.xls") As Boolean
        Dim xssfwb As XSSFWorkbook 'HSSFWorkbook for xls xSSFWorkbook for

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
        Try
            stream = File.Open(objExcelFile.excelFileName, FileMode.Open, FileAccess.Read)
            'read from xml excel .xlsx
        Catch ex As Exception
            stream.Dispose()
            Throw ex
            Exit Function
        End Try


        Try
            excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream)
            'excelReader.isfirstrowascolumnNames = True 'OPTIONAL TODO:create col name from first row
            resultDS = excelReader.AsDataSet() 'dataset result in results.tables 
            dFieldCount = excelReader.FieldCount
        Catch ex As Exception
            Throw ex
        End Try
        Try
            While excelReader.Read
                i = i + 1
                dData = excelReader.GetValue(colNum).ToString
                Debug.Print(dData)
                If dData.Contains("S/N") Then
                    sNRow = i
                    Debug.Print("S/N found at row: " & i.ToString)
                End If

                'TODO: Check integrity of template
                'no of cols, prescence of specific fields
                'Detect MAT. NO
                If dData.Contains("MAT") Or dData.Contains("MAT NO") Then
                    matNoCol = colNum
                    Debug.Print("MAT NO found at: " & matNoCol.ToString)
                End If
            End While

            'Report analysis
            If matNoCol = 0 Then Debug.Print("MAT Number Not FOUND")
        Catch ex As Exception
            If ex.Message.Contains("Object reference not set to an instance of an object") Then endOfRow = i
        End Try

        Debug.Print("SUMMARY")
        Debug.Print("Row Count: " & excelReader.RowCount.ToString)
        Debug.Print("Row Height: " & excelReader.RowHeight.ToString)
        Debug.Print("FieldCount: " & dFieldCount.ToString)
        stream.Dispose()
        Return resultDS






    End Function
End Class
'End Namespace