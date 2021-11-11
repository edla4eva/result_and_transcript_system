Public Class FormReport
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Visualization
        Dim ds As DataSet = creatDataSet()
        Dim dt As New DataTable()
        dt = ds.Tables(0)
        DataGridView1.DataSource = ds.Tables(0).DefaultView

        ''Report stuff
        'With Me.ReportViewer1.LocalReport

        '    .DataSources.Clear()
        '    '.ReportPath = My.Application.Info.DirectoryPath
        '    .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt))
        'End With
        'Me.ReportViewer1.RefreshReport()
        ''Works perfectly
    End Sub
End Class