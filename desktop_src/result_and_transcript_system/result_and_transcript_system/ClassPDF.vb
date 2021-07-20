Option Strict Off 'Required for Late Binding
Imports ExcelInterop = Microsoft.Office.Interop.Excel
Public Class ClassPDF
    Sub ExcelPDF()
        Dim workbook As New ExcelInterop.Workbook()
        workbook.LoadFromFile("D:\test.xlsx")

        'workbook.ActiveSheet.ExportAsFixedFormat(xlTypePDF, "D:\test.pdf")




    End Sub

    Sub ExcelPDFLateBinding()
        Dim xl As Object
        xl = CreateObject("Excel.Application")
        Dim xwb As Object = xl.Workbooks.Open(objBroadsheet.processedBroadsheetFileName)
        xwb.ActiveSheet.ExportAsFixedFormat(0, objBroadsheet.processedBroadsheetFileName & ".pdf")
        xl.Quit()
        'x1.dispose()
    End Sub
End Class
