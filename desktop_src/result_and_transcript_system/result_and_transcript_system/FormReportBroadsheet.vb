Public Class FormReportBroadsheet

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FormReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ButtonView_Click(sender As Object, e As EventArgs) Handles ButtonView.Click
        ''Visualization
        'objReports.MATNO = "ENG0000001"
        'Dim txtlevel, txtSession, txtDept As String
        'txtlevel = "100"
        'txtSession = "2018/2019"
        'txtDept = "Computer Engineering".ToUpper
        'txtlevel = ComboBoxLevel.SelectedItem
        'txtSession = ComboBoxSessions.SelectedItem
        'txtDept = ComboBoxDepartments.SelectedItem
        'Dim ds As DataSet = objReports.creatDataSetSenate(String.Format(STR_SQL_ALL_BROADSHEET_WHERE_SESSION_DEPT_LEVEL, txtSession, txtDept, txtlevel))
        'Dim dt As New DataTable()
        'dt = ds.Tables(0)
        'DataGridView1.DataSource = ds.Tables(0).DefaultView


        ''SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);
        ''Report stuff
        'With Me.ReportViewer1.LocalReport

        '    .DataSources.Clear()
        '    '.ReportPath = My.Application.Info.DirectoryPath
        '    .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt))
        'End With
        'Me.ReportViewer1.RefreshReport()
        ''Works perfectly
    End Sub

    Private Sub ButtonFullScreen_Click(sender As Object, e As EventArgs) Handles ButtonFullScreen.Click
        If ReportViewer1.Dock = DockStyle.Fill Then
            ReportViewer1.Dock = DockStyle.None
            ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        Else
            ReportViewer1.Dock = DockStyle.Fill
            ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub
End Class