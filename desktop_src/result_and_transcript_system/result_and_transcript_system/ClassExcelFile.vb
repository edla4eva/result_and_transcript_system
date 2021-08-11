Imports NPOI.OpenXml4Net.Util
Imports Excel.Helper
Imports Org.BouncyCastle.Utilities.Net
Imports NPOI.Util.FilterInputStream
Imports ExcelDataReader
Imports ICSharpCode.SharpZipLib.GZip
Imports System.IO
Imports NPOI.SS.UserModel
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
        Dim sw As FileStream = File.Create(fileName)
        workbook.Write(sw)
        sw.Close()
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