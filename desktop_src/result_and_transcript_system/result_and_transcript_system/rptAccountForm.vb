Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop

Public Class rptAccountForm
    Dim cmdlocal As MySql.Data.MySqlClient.MySqlCommand
    Dim rd As MySql.Data.MySqlClient.MySqlDataReader

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.MdiParent = MDIParentMain
            Me.WindowState = FormWindowState.Maximized
            Call combolist("SELECT pk_accntid,pk_code from tblaccount", "pk_accntid", "pk_code", AccntComboBox)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.ReportViewer1.RefreshReport
    End Sub


    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Cursor = Cursors.WaitCursor
        Dim strCriteria As String = String.Empty
        Dim i As Integer = 1
        Dim r As Integer = 6
        Dim strSQLTemp As String = ""
        Dim StrFromDate As String = "00000000"
        Dim strToDate As String = "00000000"

        Try
            If AccntComboBox.Text.ToUpper <> "ALL" Then strCriteria = " AND pk_accntid=" & AccntComboBox.SelectedValue.ToString

            'mySQL Palaver
            StrFromDate = fromDateTimePicker.Value.Year.ToString("0000")
            StrFromDate = StrFromDate & fromDateTimePicker.Value.Month.ToString("00")
            StrFromDate = StrFromDate & fromDateTimePicker.Value.Day.ToString("00")
            strToDate = toDateTimePicker.Value.Year.ToString("0000")
            strToDate = strToDate & toDateTimePicker.Value.Month.ToString("00")
            strToDate = strToDate & toDateTimePicker.Value.Day.ToString("00")



            excelApp = New Excel.Application
            excelWB = excelApp.Workbooks.Open(Application.StartupPath & "\templates\account_new.xlt")
            excelWS = CType(excelWB.Sheets(1), Excel.Worksheet)
            excelWS.Cells(3, ExcelColumns.colC) = AccntComboBox.Text.ToString
            excelWS.Cells(2, ExcelColumns.colF) = fromDateTimePicker.Value.ToString("MMM dd yyyy") & Chr(10) & toDateTimePicker.Value.ToString("MMM dd yyyy")
            strSQLTemp = "SELECT tblloandetails.*, tblaccount.description, tblaccount.pk_code,tblaccount.type "
            strSQLTemp = strSQLTemp & " FROM tblaccount INNER JOIN tblloandetails ON tblaccount.pk_accntID = tblloandetails.fk_accntID"
            'strSQLTemp = strSQLTemp & " WHERE date(dated) >= date(" & fromDateTimePicker.Value.ToString("yyyymmdd") & ") AND date(dated) <= date(" & toDateTimePicker.Value.ToString("yyyymmdd") & ");"
            strSQLTemp = strSQLTemp & " WHERE date(dated) >= date(" & StrFromDate & ") AND date(dated) <= date(" & strToDate & ");"
            cmdlocal = New MySqlCommand(strSQLTemp, mappDB.conn)
            rd = cmdlocal.ExecuteReader
            'Recall Balance brough down somewhere
            While rd.Read
                With excelWS
                    .Cells(r, ExcelColumns.colA) = CType(rd("dated").ToString, Date).ToString("MMM dd yyyy")
                    .Cells(r, ExcelColumns.colB) = rd("remarks").ToString       'Particular
                    .Cells(r, ExcelColumns.colC) = rd("pk_code").ToString
                    .Cells(r, ExcelColumns.colD) = rd("dr").ToString
                    .Cells(r, ExcelColumns.colE) = rd("cr").ToString
                    Select Case rd("type").ToString
                        Case "D" 'natural debit
                            'Compute Balance =F5+D6-E6
                            .Cells(r, ExcelColumns.colF) = "=F" & r - 1 & "+D" & r & "-E" & r   'rd("Balance").ToString
                        Case Else   'Natural Credit
                            .Cells(r, ExcelColumns.colF) = "=F" & r - 1 & "+E" & r & "-D" & r    'rd("Balance").ToString

                    End Select
                    r += 1
                End With
            End While

            If r > 6 Then Call drawBorder("A6:F" & r)

            'Save a hidden copy
            If MsgBox("Do you want to save a copy of this Report?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                excelWB.SaveCopyAs(Application.StartupPath & "\reports\Account- " & AccntComboBox.Text.ToString & Now.Millisecond.ToString & Rnd(1).ToString)
                MsgBox("Report saved as: " & Application.StartupPath & "\reports\Account- " & AccntComboBox.Text.ToString & Now.Millisecond.ToString & Rnd(1).ToString)
            End If

            excelApp.Visible = True

            'clean up variables
            mappDB.close()
            rd = Nothing
            cmdlocal = Nothing
            r = Nothing
            excelWS = Nothing
            excelWB = Nothing
            excelApp = Nothing

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

    Private Sub viewAllToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles viewAllToolStripButton.Click
        Me.Cursor = Cursors.WaitCursor
        Dim strCriteria As String = String.Empty
        Dim i As Integer = 1
        Dim r As Integer = 5
        Dim strSQL As String = ""
        Dim StrFromDate As String = "00000000"
        Dim strToDate As String = "00000000"
        Try
            'If fromDateTimePicker.Value.ToString("MMM dd yyyy") = toDateTimePicker.Value.ToString("MMM dd yyyy") Then
            '    MsgBox("Please, select a valid date range")
            '    Me.Cursor = Cursors.Arrow
            '    Exit Sub
            'End If
            'mySQL Palaver
            StrFromDate = fromDateTimePicker.Value.Year.ToString("0000")
            StrFromDate = StrFromDate & fromDateTimePicker.Value.Month.ToString("00")
            StrFromDate = StrFromDate & fromDateTimePicker.Value.Day.ToString("00")
            strToDate = toDateTimePicker.Value.Year.ToString("0000")
            strToDate = strToDate & toDateTimePicker.Value.Month.ToString("00")
            strToDate = strToDate & toDateTimePicker.Value.Day.ToString("00")

            strCriteria = " AND pk_accntid>0"       'TODO
            excelApp = New Excel.Application
            excelWB = excelApp.Workbooks.Open(Application.StartupPath & "\templates\TrialBalance.xlt")
            excelWS = CType(excelWB.Sheets(1), Excel.Worksheet)
            'Display period
            excelWS.Cells(2, ExcelColumns.colF) = fromDateTimePicker.Value.ToString("MMM dd yyyy") & Chr(10) & toDateTimePicker.Value.ToString("MMM dd yyyy")

            strSQL = "SELECT tblloandetails.fk_accntID, tblaccount.pk_code, tblaccount.description, tblaccount.type, Sum(tblloandetails.Dr) AS SumOfDr, Sum(tblloandetails.Cr) AS SumOfCr, Sum(dr-cr) AS Balance,"
            strSQL = strSQL & " If(type=""D"",If(Sum(dr)>Sum(cr),Sum(dr-cr),0),If(Sum(dr)>Sum(cr),Sum(dr-cr),0)) AS DebitBalance, If(type<>""D"",If(Sum(cr)>Sum(dr),Sum(cr-dr),0),If(Sum(cr)>Sum(dr),Sum(cr-dr),0)) AS CreditBalance"
            strSQL = strSQL & " FROM tblaccount INNER JOIN tblloandetails ON tblaccount.pk_accntID = tblloandetails.fk_accntID"
            strSQL = strSQL & " WHERE date(dated) >= date(" & StrFromDate & ") AND date(dated) <= date(" & strToDate & ") " & strCriteria
            strSQL = strSQL & " GROUP BY tblloandetails.fk_accntID, tblaccount.pk_code, tblaccount.description, tblaccount.type;"
            TextBox1.Text = strSQL
            'cmdlocal = New MySqlCommand("SELECT * from qrptTrialBalance WHERE dated BETWEEN #" & fromDateTimePicker.Value.ToString("MMM dd yyyy") & "# AND #" & toDateTimePicker.Value.ToString("MMM dd yyyy") & "# " & strCriteria, mappDB.conn)
            cmdlocal = New MySqlCommand(strSQL, mappDB.conn)

            rd = cmdlocal.ExecuteReader

            While rd.Read
                With excelWS
                    .Cells(r, ExcelColumns.colA) = r - 4
                    '.Cells(r, ExcelColumns.colB) = CType(rd("dated").ToString, Date).ToString("MMM dd yyyy")
                    .Cells(r, ExcelColumns.colC) = rd("description").ToString
                    '.Cells(r, ExcelColumns.colD) = rd("fullname").ToString  'rd("pk_code").ToString
                    .Cells(r, ExcelColumns.colE) = rd("DebitBalance").ToString
                    .Cells(r, ExcelColumns.colF) = rd("CreditBalance").ToString
                    r += 1
                End With
            End While

            'add cr and dr sum
            excelWS.Cells(r, ExcelColumns.colA) = "Balance"
            If r - 1 > 5 Then       'avoid circular reference in excel
                excelWS.Cells(r, ExcelColumns.colE) = "=SUM(E5:E" & r - 1 & ")"
                excelWS.Cells(r, ExcelColumns.colF) = "=SUM(F5:F" & r - 1 & ")"
            Else
                excelWS.Cells(r, ExcelColumns.colE) = "-"
                excelWS.Cells(r, ExcelColumns.colF) = "-"
            End If
            excelWS.Range("A" & r & ":D" & r).Merge()
            excelWS.Range("A" & r).HorizontalAlignment = -4131

            If r > 6 Then Call drawBorder("A6:F" & r)
            'Save a hidden copy
            If MsgBox("Do you want to save a copy of this Report?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                excelWB.SaveCopyAs(Application.StartupPath & "\reports\TrialBalance " & Now.Millisecond.ToString & Rnd(1).ToString & ".xls")
                MsgBox("Report saved as: " & Application.StartupPath & "\reports\TrialBalance " & Now.Millisecond.ToString & Rnd(1).ToString)
            End If

            excelApp.Visible = True
            MDIParentMain.WindowState = FormWindowState.Minimized
            'clean up variables
            mappDB.close()
            rd = Nothing
            cmdlocal = Nothing
            r = Nothing
            excelWS = Nothing
            excelWB = Nothing
            excelApp = Nothing

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ReportViewer1.Visible = True
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

        dt.TableName = "TrialBalance"
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
        dr("Ref") = "ref002"
        dr("Dr") = 0
        dr("Cr") = 700
        dr("Bal") = sumCr - SumDr
        dt.Rows.Add(dr)

        ds.Tables.Add(dt)

        For i = 0 To ds.Tables(0).Rows.Count - 1
            'MsgBox(ds.Tables(0).Rows(i).Item(0).ToString & "   --   " & ds.Tables(0).Rows(i).Item(1).ToString)
        Next i


        'Report stuff
        Dim StrFromDate As String = "00000000"
        Dim strToDate As String = "00000000"

        'mySQL Palaver
        StrFromDate = fromDateTimePicker.Value.Year.ToString("0000")
            StrFromDate = StrFromDate & fromDateTimePicker.Value.Month.ToString("00")
            StrFromDate = StrFromDate & fromDateTimePicker.Value.Day.ToString("00")
            strToDate = toDateTimePicker.Value.Year.ToString("0000")
            strToDate = strToDate & toDateTimePicker.Value.Month.ToString("00")
            strToDate = strToDate & toDateTimePicker.Value.Day.ToString("00")

            Dim strSQL1 As String
        strSQL1 = "SELECT tblloandetails.fk_accntID, tblaccount.pk_code, tblaccount.description, tblaccount.type, Sum(tblloandetails.Dr) AS Dr, Sum(tblloandetails.Cr) AS Cr, Sum(dr-cr) AS Bal,"
        strSQL1 = strSQL1 & " If(type=""D"",If(Sum(dr)>Sum(cr),Sum(dr-cr),0),If(Sum(dr)>Sum(cr),Sum(dr-cr),0)) AS DebitBalance, If(type<>""D"",If(Sum(cr)>Sum(dr),Sum(cr-dr),0),If(Sum(cr)>Sum(dr),Sum(cr-dr),0)) AS CreditBalance"
        strSQL1 = strSQL1 & " FROM tblaccount INNER JOIN tblloandetails ON tblaccount.pk_accntID = tblloandetails.fk_accntID"
        strSQL1 = strSQL1 & " WHERE date(dated) >= date(" & StrFromDate & ") AND date(dated) <= date(" & strToDate & ") " & " AND pk_accntid>0"
        strSQL1 = strSQL1 & " GROUP BY tblloandetails.fk_accntID, tblaccount.pk_code, tblaccount.description, tblaccount.type;"
        Dim ta As New MySql.Data.MySqlClient.MySqlDataAdapter(strSQL1, mappDB.conn)
        ta.Fill(dt)

        cmdlocal = New MySqlCommand(strSQL1, mappDB.conn)

        With Me.ReportViewer1.LocalReport

            .DataSources.Clear()
            '.ReportPath = My.Application.Info.DirectoryPath
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt))
        End With
        Me.ReportViewer1.RefreshReport()
        'Works perfectly
    End Sub
End Class