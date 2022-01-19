Imports System.ComponentModel

Public Class FormSenateResult
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FormReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bgwLoad.RunWorkerAsync()        'load comboboxes at background


    End Sub


    Private Sub ButtonView_Click(sender As Object, e As EventArgs) Handles ButtonView.Click
        'Visualization
        objBroadsheet.matno = "ENG0000001"   'matno col
        Try
            Dim txtlevel, txtSession, txtDept As String
            txtlevel = "100"
            txtSession = "2018/2019"
            txtDept = "Computer Engineering".ToUpper
            txtlevel = ComboBoxLevel.SelectedItem
            txtSession = ComboBoxSessions.SelectedItem
            txtDept = ComboBoxDepartments.SelectedItem





            Dim ds As DataSet = objReports.creatDataSetSenate(String.Format(STR_SQL_ALL_BROADSHEET_WHERE_SESSION_DEPT_LEVEL_WITHOUT_TIMESTAMP, txtSession, txtDept, txtlevel))
            Dim dt As New DataTable()
            dt = ds.Tables(0)
            DataGridView1.DataSource = ds.Tables(0).DefaultView


            'SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);
            'Report stuff

            With Me.ReportViewer1.LocalReport

                .DataSources.Clear()
                '.ReportPath = My.Application.Info.DirectoryPath
                .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt))
            End With
            Me.ReportViewer1.RefreshReport()
            'Works perfectly
        Catch ex As Exception
            MsgBox("Cannot get Senate data" & vbCrLf & ex.Message)
        End Try

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


    Private Sub FormReport_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        MainForm.doCloseForm()
    End Sub

    Private Sub FormSenateResult_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ButtonView.PerformClick()
    End Sub
    Private Sub bgwLoad_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgwLoad.DoWork
        getDeptSessionsIntoDictionaries()
    End Sub

    Private Sub bgwLoad_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgwLoad.RunWorkerCompleted

        ComboBoxDepartments.Items.Clear()
        For Each key In dictDepts.Keys
            ComboBoxDepartments.Items.Add(dictDepts(key))
        Next
        TextBoxDepartment.Text = ComboBoxDepartments.Items(0).ToString
        ComboBoxDepartments.SelectedIndex = 0

        ComboBoxSessions.Items.Clear()
        For Each key In dictSessions.Keys
            ComboBoxSessions.Items.Add(dictSessions(key))
        Next
        ComboBoxSessions.SelectedIndex = 0
        TextBoxSession.Text = ComboBoxSessions.Items(0).ToString

        ComboBoxLevel.SelectedIndex = 0
        TextBoxLevel.Text = ComboBoxLevel.Items(0).ToString

        ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewerSenateCover.RefreshReport()
    End Sub

End Class