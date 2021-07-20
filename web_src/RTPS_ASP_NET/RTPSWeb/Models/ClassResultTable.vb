Public Class ClassResultTable
    Public Function getAllResult() As Table
        Dim dT As New Table
        Dim dRow As New TableRow
        Dim dCells(0 To 4) As TableCell
        Dim objD As New ClassDB
        Dim matno As String = "pending"
        For i = 0 To 4
            dCells(i) = New TableCell
        Next
        dCells(0).Text = ("FixedMATNO")
        dCells(1).Text = ("Name")
        dCells(2).Text = ("GST")
        dCells(3).Text = ("MEE")
        dCells(4).Text = ("DB")
        dRow.Cells.AddRange(dCells)
        dT.Rows.Add(dRow)
        'matno = objD.GetRecordWhere("SELECT matno FROM results WHERE session_idr='2018/2019'")


        dCells(0).Text = ("ENG120111")
        dCells(1).Text = ("Ola Paul")
        dCells(2).Text = ("45")
        dCells(3).Text = ("76")
        dCells(4).Text = (matno)
        dRow.Cells.AddRange(dCells)
        dT.Rows.Add(dRow)


        Return dT
    End Function
End Class
