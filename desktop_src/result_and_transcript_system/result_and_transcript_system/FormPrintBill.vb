Public Class FormPrintBill
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ds As New DataSet
        Dim dt As DataTable
        Dim dr As DataRow
        Dim idCoulumn As DataColumn
        Dim nameCoulumn As DataColumn
        Dim drCoulumn, crCoulumn, balCoulumn As DataColumn
        Dim i As Integer
        Dim sumCr As Double = 0
        Dim SumDr As Double = 0

        dt = New DataTable()
        idCoulumn = New DataColumn("ID", Type.GetType("System.Int32"))
        nameCoulumn = New DataColumn("Ref", Type.GetType("System.String"))
        drCoulumn = New DataColumn("Dr", Type.GetType("System.Double"))
        crCoulumn = New DataColumn("Cr", Type.GetType("System.Double"))
        balCoulumn = New DataColumn("Bal", Type.GetType("System.Double"))

        dt.TableName = "Bill"
        dt.Columns.Add(idCoulumn)
        dt.Columns.Add(nameCoulumn)
        dt.Columns.Add(drCoulumn)
        dt.Columns.Add(crCoulumn)
        dt.Columns.Add(BalCoulumn)

        SumDr = 500
        sumCr = 0
        dr = dt.NewRow()
        dr("ID") = 1
        dr("Ref") = "ref001"
        dr("Dr") = 500
        dr("Cr") = 0
        dr("Bal") = sumCr - sumDr
        dt.Rows.Add(dr)

        SumDr = SumDr + 0
        sumCr = sumCr + 700
        dr = dt.NewRow()
        dr("ID") = 1
        dr("Ref") = "ref002"
        dr("Dr") = 0
        dr("Cr") = 700
        dr("Bal") = sumCr - SumDr
        dt.Rows.Add(dr)

        ds.Tables.Add(dt)

        For i = 0 To ds.Tables(0).Rows.Count - 1
            'MsgBox(ds.Tables(0).Rows(i).Item(0).ToString & "   --   " & ds.Tables(0).Rows(i).Item(1).ToString)
        Next i
        dgw.DataSource = ds.Tables("Bill").DefaultView

        'Report stuff
        'Dim ta As New System.Data.SqlClient.SqlDataAdapter
        'ta.Fill(dt)
        With Me.ReportViewer1.LocalReport

            .DataSources.Clear()
            '.ReportPath = My.Application.Info.DirectoryPath
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt))
        End With
        Me.ReportViewer1.RefreshReport()
        'Works perfectly
    End Sub

    Private Sub FormPrintBill_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ds As New DataSet
        Dim dt As DataTable
        Dim dr As DataRow
        Dim idCoulumn As DataColumn
        Dim nameCoulumn As DataColumn
        Dim drCoulumn, crCoulumn, balCoulumn As DataColumn
        Dim i As Integer
        Dim sumCr As Double = 0
        Dim SumDr As Double = 0

        dt = New DataTable()
        idCoulumn = New DataColumn("ID", Type.GetType("System.Int32"))
        nameCoulumn = New DataColumn("Ref", Type.GetType("System.String"))
        drCoulumn = New DataColumn("Dr", Type.GetType("System.Double"))
        crCoulumn = New DataColumn("Cr", Type.GetType("System.Double"))
        balCoulumn = New DataColumn("Bal", Type.GetType("System.Double"))

        dt.TableName = "Bill"
        dt.Columns.Add(idCoulumn)
        dt.Columns.Add(nameCoulumn)
        dt.Columns.Add(drCoulumn)
        dt.Columns.Add(crCoulumn)
        dt.Columns.Add(balCoulumn)

        SumDr = 500
        sumCr = 0
        dr = dt.NewRow()
        dr("ID") = 1
        dr("Ref") = "ref001"
        dr("Dr") = 500
        dr("Cr") = 0
        dr("Bal") = sumCr - SumDr
        dt.Rows.Add(dr)

        SumDr = SumDr + 0
        sumCr = sumCr + 700
        dr = dt.NewRow()
        dr("ID") = 1
        dr("Ref") = "ref001"
        dr("Dr") = 0
        dr("Cr") = 700
        dr("Bal") = sumCr - SumDr
        dt.Rows.Add(dr)

        ds.Tables.Add(dt)

        For i = 0 To ds.Tables(0).Rows.Count - 1
            'MsgBox(ds.Tables(0).Rows(i).Item(0).ToString & "   --   " & ds.Tables(0).Rows(i).Item(1).ToString)
        Next i
        'dgw.DataSource = ds.Tables("Bill").DefaultView

        Dim bs As New BindingSource
        bs.DataSource = dt
        TextBoxID.DataBindings.Add(New Binding("text", bs, "ID"))
        TextBoxRef.DataBindings.Add(New Binding("text", bs, "Ref"))
        BindingNavigator1.BindingSource = bs
    End Sub

    Private Sub FormPrintBill_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer2.RefreshReport()

        'Report stuff
        'With Me.ReportViewer1.LocalReport

        '    .DataSources.Clear()
        '    '.ReportPath = My.Application.Info.DirectoryPath
        '    .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt))
        'End With
        'Me.ReportViewer1.RefreshReport()
    End Sub
End Class