Imports NPOI.OpenXml4Net.Util
Imports Excel.Helper
Imports Org.BouncyCastle.Utilities.Net
Imports NPOI.Util.FilterInputStream
Imports ExcelDataReader
Imports ICSharpCode.SharpZipLib.GZip

Public Class ClassExcelFile


    Private _cellRange As CellRange
    Private dt As ExcelDataReaderHelper
    Private _excelFile As XmlHelper

    Public Function readResultFile() As DataSet
        Dim retVal As Integer
        retVal = dt.WorksheetCount()
        '_cellRange = dt.GetRangeCells(1, 1, 1, 10, 20)
        Return Nothing
    End Function
End Class
