Imports System.IO

Imports System
Imports System.Windows.Forms
Imports System.Data
Imports System.Data.SqlClient
Imports Excel = Microsoft.Office.Interop.Excel

Public Class FormBroadsheets

    Sub showDataset()
        DataGridView1.DataSource = objBroadsheet.excelWB.WBDataSet.Tables("Result").DefaultView()   'BackgroundWorker1.workcomplete   
        'set variables to anchor the daata to base cell e.f A7=SN 1 , B7 = MATNO1, C7=.....
        ComboBox1.Text = "Select Column Header"
        ComboBox1.Left = DataGridView1.RowHeadersWidth + ComboBox1.Left
        ComboBox1.Width = DataGridView1.Columns(0).Width - 3
        ComboBox2.Left = ComboBox1.Left + ComboBox1.Width + 3
        ComboBox2.Width = DataGridView1.Columns(1).Width - 3
        ComboBox3.Left = ComboBox2.Left + ComboBox2.Width + 3
        ComboBox3.Width = DataGridView1.Columns(2).Width - 3
        ComboBox4.Left = ComboBox3.Left + ComboBox3.Width + 3
        ComboBox4.Width = DataGridView1.Columns(3).Width - 3
        ComboBox5.Left = ComboBox4.Left + ComboBox4.Width + 3
        ComboBox5.Width = DataGridView1.Columns(4).Width - 3
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If objResults.progress < 99 Then
            ProgressBar1.Value = objBroadsheet.progress
        Else
            ProgressBar1.Value = 99
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            With objBroadsheet
                .excelWB.openBroadsheetExcelWB()
                'objBroadsheet.excelWB.WBDataSet = objBroadsheet.excelWB.openBroadsheetExcelWB()

                'objResults.excelWB.WBDataSet = objResults.excelWB.creatDataSetFromArray(.strMATNO, .strMATNO, .strMATNO, .strMATNO, .strMATNO, .strMATNO)
            End With
            'when complete showDataset()
        Catch ex As Exception
            MsgBox("COM Error " & ex.ToString)
        End Try

    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        'showDataset()
        Timer1.Stop()
        ProgressBar1.Value = 100
        ButtonGenerateBroadsheet.Enabled = True
        Me.Cursor = Cursors.Default
        MsgBox("Done!")

        'save it
        Dim fD As New SaveFileDialog
        fD.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        'fD.Filter = "Excel Workbooks (*.xlsx)|*.xlsx"
        If Not (fD.ShowDialog = Windows.Forms.DialogResult.Cancel) Then
            If fD.FileName.Length > 0 Then
                'TODO: Possible Error
                objBroadsheet.processedBroadsheetFileName = fD.FileName
            End If
        End If
    End Sub
    Private Sub ButtonAddStuRecordstoBS_Click(sender As Object, e As EventArgs) Handles ButtonAddStuRecordstoBS.Click
        AddStuRecordstoBS()
    End Sub
    Private Sub ButtonGenerateBroadsheet_Click(sender As Object, e As EventArgs) Handles ButtonGenerateBroadsheet.Click
        ButtonGenerateBroadsheet.Enabled = False
        generateBroadSheet()  'objBroadsheet.generateBroadsheet()
    End Sub

    Sub generateBroadSheet()
        'Get student info and get registration info

        'Get all the results that applies to all students

        'structure broadsheet for dept, level, courses, course credits etc
        '--1. Select, open and adjust EXCEL template
        openBroadsheetInExcel(USER_DIRECTORY & "\templates\100LCPE.xltx") ' "\templates\"  & ComboBoxTemplate.SelectedValue & ".xltx"

        'populate broadsheet with result
        AddStuRecordstoBS()

        'compute carry overs

        'compute tcp, tcf

        'compute GPA

        'determine category


       
    End Sub

    Sub openBroadsheetInExcel(Optional fileBS As String = Nothing)
        '-------------- broadsheet template-------
        Me.Cursor = Cursors.WaitCursor
        Dim templateBS As String
        Dim processedFileBs As String

        'Select Case templateBS
        '    Case "100L Computer Engineering"
        '        fileBS = USER_DIRECTORY & "eResult\templates\100LCPE.xltx"
        If fileBS = Nothing Then filebs = USER_DIRECTORY & "\templates\100LCPE.xltx"
        'End Select

        objBroadsheet.broadsheetFileName = fileBS
        Try
            '--------------------------------------------------
            '# Launch Excel Application through COM automation at the background
            '--------------------------------------------------
            Timer1.Start() 'for visual updates
            BackgroundWorker1.RunWorkerAsync()
            'The following are executed
            '1. objBroadsheet.excelWB.openBroadsheetExcelWB
            '----------------------------------------------------

            Me.Cursor = Cursors.Default
        Catch exIO As IOException
            MsgBox("Error occured! Please close MS Excel. Use task manager to cancel running Excel applications or processes and try again" & vbCrLf & " This error was caused because: " & exIO.GetBaseException().Message)
        Catch ex As Exception

            'can cause error
            objBroadsheet.broadsheetFileName = Nothing
            MsgBox("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
            logError("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
            Return
        Finally
            'can cause error
        End Try
    End Sub
    Sub AddStuRecordstoBS()
        'Select ith course in BS header

        'Query TableResult (Session, CourseCode) for result

        'Load the returned result to datagridview Object (This can be displayed in FormResult for UI)

        '   select ith MATNO of student
        '       filter datagridview for the MATNO
        '       Extract the result for that course (if not found -1)
        '       if (Registered ) then input score into excel BS (or datagrid?)
        '   next MATNO
        'Next Course

        Dim arrCoursesBS As String() = Nothing
        Dim arrMATNO As String() = Nothing
        Dim strMATNO As String = Nothing
        Dim strCourse As String = Nothing
        Dim strQueryTableResult As String = Nothing

        'SELECT TableResults.CourseCodeIdr, TableResults.MATNo, TableResults.SCORE
        'FROM TableResults
        'WHERE (((TableResults.MATNo)="1002311")) OR (((TableResults.MATNo)="1303432")) OR (((TableResults.MATNo)="1303435")) OR 
        '(((TableResults.MATNo)="1303435")) OR (((TableResults.MATNo)="1303427")) OR (((TableResults.MATNo)="1303426"));
        'Get all carry over results for the specific students
        For m = 0 To arrMATNO.Length - 1 'TODO: do it in 20s m=0 to 20; m=21 to 40
            strQueryTableResult = strQueryTableResult & "OR "
            'strQueryTableResult = strQueryTableResult & "(((TableResults.MATNo)=""""1303432"""")) "
            strQueryTableResult = strQueryTableResult & "(((TableResults.MATNo)=""""arrMATNO(m)"""")) "
        Next
    End Sub

    ' --------------------



    'Get Data from DB
    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonAutoExcel.Click
        Dim cnn As SqlConnection
        Dim connectionString As String = Nothing
        Dim sql As String = Nothing
        connectionString = "data source=localhost;initial catalog=databasename;user id=username;password=password;"
        cnn = New SqlConnection(connectionString)
        cnn.Open()
        sql = "SELECT * FROM Product"
        Dim dscmd As SqlDataAdapter = New SqlDataAdapter(sql, cnn)
        Dim ds As DataSet = New DataSet()
        dscmd.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub ButtonInsertExcel_Click(sender As Object, e As EventArgs) Handles ButtonInsertExcel.Click
        'Inserts data from datagrid to excel
        If DataGridView1.Rows.Count < 1 Then
            MessageBox.Show("No records to insert into excel!")
            Return
        End If

        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        xlApp = New Excel.Application()
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = CType(xlWorkBook.Worksheets(1), Excel.Worksheet)
        Dim i As Integer = 0
        Dim j As Integer = 0

        For i = 0 To DataGridView1.RowCount - 1

            For j = 0 To DataGridView1.ColumnCount - 1
                Dim cell As DataGridViewCell = DataGridView1(j, i)
                xlWorkSheet.Cells(i + 1, j + 1) = cell.Value
            Next
        Next

        xlWorkBook.SaveAs(USER_DIRECTORY & "\csharp.net-informations.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)
        xlWorkBook.Close(True, misValue, misValue)
        xlApp.Quit()
        releaseObject(xlWorkSheet)
        releaseObject(xlWorkBook)
        releaseObject(xlApp)
        MessageBox.Show("Excel file created , you can find the file csharp.net-informations.xls")
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
            MessageBox.Show("Exception Occured while releasing object " & ex.ToString())
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub ButtonOLE_Click(sender As Object, e As EventArgs) Handles ButtonOLE.Click
        Try
            Dim MyConnection As System.Data.OleDb.OleDbConnection
            Dim myCommand As System.Data.OleDb.OleDbCommand = New System.Data.OleDb.OleDbCommand()
            Dim sql As String = Nothing
            'MyConnection = New System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & USER_DIRECTORY & "'\generatedResult.xls';Extended Properties=Excel 8.0;")
            '
            MyConnection = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & USER_DIRECTORY & "'\generatedResult.xls';Extended Properties='Excel 12.0; HDR=YES'")

            MyConnection.Open()
            myCommand.Connection = MyConnection
            sql = "Insert into [Sheet1$] (MAT NO, EXAM (70%) ) values('ENG99999999','99')"
            myCommand.CommandText = sql
            myCommand.ExecuteNonQuery()
            MyConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub




End Class