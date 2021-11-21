Public Class FormStudent
    Private Sub FormStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = RGBColors.colorBlack2
    End Sub

    Private Sub FormStudent_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MainForm.doCloseForm()
    End Sub

    Private Sub ButtonImport_Click(sender As Object, e As EventArgs) Handles ButtonImport.Click
        Dim FileOpenDialogBroadsheet As New OpenFileDialog()
        Dim resultFileName As String = ""

        If Not FileOpenDialogBroadsheet.ShowDialog = DialogResult.Cancel Then
            resultFileName = FileOpenDialogBroadsheet.FileName()
        End If
        TextBoxExcelFilename.Text = resultFileName
        objExcelFile.excelFileName = resultFileName


        PreviewStudents()
        CheckStudents()
    End Sub
    Private Sub PreviewStudents()
        ' objResult.resultFilename = My.Application.Info.DirectoryPath & "\samples\result.xlsx"

        Dim tmpDS As DataSet = objExcelFile.readResultFile()
        'TODO: reset datagrid
        DataGridView1.DataSource = tmpDS.Tables(0).DefaultView
    End Sub
    Private Sub checkStudents()
        'UI
        'DataGridView2.Visible = False   'todo: remove ui code change to this hideButtons(False, "DataGridView2")

        Dim tmpDV As DataView
        Dim tmpDT As DataTable
        Dim snRow As Integer
        Dim emptyRow As Integer = 0
        Dim emptyRowFound As Boolean = False
        Dim rowCount As Integer = 0
        Dim colCount As Integer = 0
        Dim lstCols As New List(Of Integer)
        Dim listcolNames As New List(Of String)
        tmpDV = Me.DataGridView1.DataSource 'TODO: causes error if dirty
        tmpDT = tmpDV.ToTable()

        '# Detect header row
        rowCount = tmpDT.Rows.Count
        For i = 0 To rowCount - 1
            If tmpDT.Rows(i).ItemArray().Contains("S/N") Or tmpDT.Rows(i).ItemArray().Contains("MAT") Then
                Debug.Print("ColumnHeader at row: " & i)
                snRow = i
                Exit For
            End If
        Next

        Dim dictColHeaders As New Dictionary(Of Integer, String)
        '# display header rows
        colCount = DataGridView1.Columns.Count
        For i = 0 To colCount - 1
            DataGridView1.Columns(i).HeaderText = DataGridView1.Item(i, snRow).Value.ToString
            dictColHeaders.Add(i, DataGridView1.Item(i, snRow).Value.ToString)
        Next

        '#change column names to match header text
        Try

            For i = 0 To colCount - 1
                If dictColHeaders.ContainsValue(DataGridView1.Columns(i).HeaderText) Then
                    DataGridView1.Columns(i).Name = DataGridView1.Rows(snRow).Cells(i).Value.ToString

                Else
                    'note column to delete
                    lstCols.Add(i)
                    listcolNames.Add(DataGridView1.Columns(i).Name)
                    'DataGridView1.Columns.RemoveAt(i)
                End If

            Next


            'delete noted useless columns
            Dim delColCount = 0
            For Each iName In listcolNames
                tmpDT.Columns.Remove(iName) 'TODO: its not removing, just moving to the end
                'DataGridView1.InvalidateColumn(iName)
                delColCount += 1 'update count of deleted cols
            Next

            'delete header rows
            For j = 0 To snRow
                tmpDT.Rows(0).Delete()
            Next

            rowCount = tmpDT.Rows.Count
            For i = 0 To rowCount - 1

                'check for empty rows
                If Trim(tmpDT.Rows(i).Item("sn").ToString) = "" And i > snRow Then

                    If Trim(tmpDT.Rows(i).Item("matno").ToString) = "" Then
                        If Not emptyRowFound Then emptyRow = i
                        emptyRowFound = True
                    ElseIf i + 1 <= rowCount - 1 Then 'check successive matno
                        If Trim(tmpDT.Rows(i).Item("matno").ToString) = "" And Trim(tmpDT.Rows(i + 1).Item("matno").ToString) = "" Then
                            If Not emptyRowFound Then emptyRow = i
                            emptyRowFound = True
                        End If
                    Else

                    End If

                End If
            Next

            'delete empty rows below
            tmpDT.AcceptChanges()
            rowCount = tmpDT.Rows.Count
            If emptyRow > 0 Then
                For j = emptyRow To rowCount - 1
                    tmpDT.Rows(emptyRow).Delete()   'keep deleting the last row
                    tmpDT.AcceptChanges()
                Next
            End If

            'display

            DataGridView1.DataSource = tmpDT
            DataGridView1.Refresh()
        Catch ex As Exception
            MessageBox.Show("Result is not in the correct format, please correct ant try again")
            logError(ex.ToString)
            Exit Sub
        End Try
    End Sub




    Private Sub ButtonDownloadTemplate_Click(sender As Object, e As EventArgs) Handles ButtonDownloadTemplate.Click
        Try

            'objResult.resultTemplateFileName
            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                My.Computer.FileSystem.CopyFile(My.Application.Info.DirectoryPath & "\templates\students.xlts", SaveFileDialog1.FileName & ".xltx")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()

    End Sub

    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click
        BindingSource1.MoveNext()
    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        'matno   student_firstname	student_surname	student_othernames	student_dept_idr	status	level	year_of_entry	session_idr_of_entry	mode_of_entry
        '1102339 Aminu	AMALACHI	John	1	probation	300		2018/2019	UME
        'INSERT INTO
        Dim ds As New DataSet
        'Dim rd As OleDb.OleDbDataReader
        'ds = mappDB.GetRecordWhere("SELECT * FROM students")
        ds = mappDB.GetDataWhere("SELECT * FROM students")
        BindingSource1.DataSource = ds.Tables(0)
        BindingNavigator1.BindingSource = BindingSource1
        'TextBoxMATNO.DataBindings.Item(0).DataSource =
        If TextBoxMATNO.DataBindings.Count = 0 Then
            TextBoxMATNO.DataBindings.Add("Text", BindingSource1, "matno")
            TextBoxSurname.DataBindings.Add("Text", ds.Tables(0), "student_surname")
            TextBoxFirstName.DataBindings.Add("Text", ds.Tables(0), "student_firstname")
            TextBoxOtherNames.DataBindings.Add("Text", ds.Tables(0), "student_othernames")
            'TextBoxDept.DataBindings.Add("Text", ds.Tables(0), "student_dept_idr")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ButtonClose.PerformClick()
    End Sub

    Private Sub ButtonViewMode_Click(sender As Object, e As EventArgs) Handles ButtonViewMode.Click
        If PanelForm.Visible = False Then
            PanelForm.Visible = True
            DataGridView1.Visible = False
            ButtonViewMode.Text = "Grid View"
        Else

            PanelForm.Visible = False
            DataGridView1.Visible = True
            ButtonViewMode.Text = "Form View"
        End If
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        'Algorithm
        'Check databas if result already exist to avoid duplicates
        'Write into Database
        'If MessageBox.Show("Are you sure you want to upload the result into DB? Cannot be undone", vbYesNo) = DialogResult.Yes Then
        'Get dataset from displayed datagrid
        'parse dataset record by record
        'insert record by record

        Dim strSQL As String   'dMATNO, dScore,
        strSQL = SQL_SELECT_RESULTS_WHERE_MATNO '"INSERT INTO TableResults"

        '#method 1 - creates table and inserts
        Dim dt As DataTable
        'Dim dv As DataView
        Try

            'NOtE. journey 1. tmpDS.Tables(0).DefaultView 2. tmpDT =tmpDV.ToTable  dt=datagrid.source
            DataGridView1.EndEdit()
            DataGridView1.Update()
            If Not (IsDBNull(DataGridView1.DataSource) Or (DataGridView1.Rows.Count = 0)) Then
                DataGridView1.DataSource.AcceptChanges 'TODO: dataTable or dataView? lazy loading issues
                dt = DataGridView1.DataSource 'causes error if dirty
            Else
                MsgBox("Empty Result")
                Exit Sub
            End If

            mappDB.genericManualInsertDB(dt, STR_SQL_INSERT_STUDENTS, {})

            MsgBox("Students Uploaded into Database Successfully! Cross check what was uploaded below")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class