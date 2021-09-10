Imports System.ComponentModel

Public Class FormUploadResult
    Private Sub FormUploadResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = RGBColors.colorBlack2
        resizeCombosToGrid()
    End Sub

    Private Sub ButtonBrowse_Click(sender As Object, e As EventArgs) Handles ButtonBrowse.Click
        Dim FileOpenDialogBroadsheet As New OpenFileDialog()
        Dim resultFileName As String = ""

        If Not FileOpenDialogBroadsheet.ShowDialog = DialogResult.Cancel Then
            resultFileName = FileOpenDialogBroadsheet.FileName()
        End If
        TextBoxExcelFilename.Text = resultFileName
        objExcelFile.excelFileName = resultFileName

        showButtons("Preview", True)

    End Sub

    Private Sub ButtonUpload_Click(sender As Object, e As EventArgs) Handles ButtonUpload.Click
        Try


            'Write into Database
            'If MessageBox.Show("Are you sure you want to upload the result into DB? Cannot be undone", vbYesNo) = DialogResult.Yes Then
            'Get dataset from displayed datagrid
            'parse dataset record by record
            'insert record by record
            Dim strSQL As String   'dMATNO, dScore,
            Dim dSession, dDept, dCourse As String
            'Dim colMATNO, colScore As Integer
            'get headers
            'if checkBox custom then
            'colMATNO = comboMat.selectedindex
            'colScore = comboScore.selectedindex
            ' else


            strSQL = SQL_SELECT_ALL_RESULTS_WHERE_MATNO '"INSERT INTO TableResults"
            'mappDB.InsertRecord(STR_SQL_INSERT_RESULTS)
            'strSQL=strSQL& "VALUES (...)" 'TODO
            'mappDB.UpdateRecordWhere(strSQL)

            '#method 1 - creates table and inserts
            Dim dt As DataTable
            'Dim dv As DataView


            'NOtE. journey 1. tmpDS.Tables(0).DefaultView 2. tmpDT =tmpDV.ToTable  dt=datagrid.source
            DataGridView1.EndEdit()
            DataGridView1.Update()
            DataGridView1.DataSource.AcceptChanges 'TODO: dataTable or dataView? lazy loading issues
            dt = DataGridView1.DataSource 'causes error if dirty
            'dt = dv.ToTable
            '#method 1 manual Insert or bulkInsert
            '#RODO: VALIDATION we need some AI to check these
            If TextBoxSession.Text = "" Then
                MsgBox("Please enter the session") 'prompt user
                TextBoxSession.BackColor = Color.Pink
                'TODO: check if session is in database and return session_id
            ElseIf TextBoxDepartment.Text = "" Then
                TextBoxDepartment.BackColor = Color.Pink
            Else
                'TODO:
                dSession = TextBoxSession.Text '"2018/2019"
                dDept = mappDB.getDeptID(TextBoxSession.Text).ToString 'Computer Engineering
                dCourse = TextBoxCourseCode.Text 'CPE300"
                mappDB.manualInsertDB(dt, dSession, CInt(dDept), dCourse)
                MsgBox("ProdResultsult Added Successfully!")
            End If


            '#method 2
            'mappDB.InsertRecord(strSQL)

            'method 3
            ' mappDB.getDataReader("TableResults") 'then
            ' mappDB.CompareDataTables(DataGridView1.DataSource.tables(0), dt)





            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ButtonPreview_Click(sender As Object, e As EventArgs) Handles ButtonPreview.Click

        ' objResult.resultFilename = My.Application.Info.DirectoryPath & "\samples\result.xlsx"
        objResult.excelVersion = "2013"
        Dim tmpDS As DataSet = objExcelFile.readResultFile()
        'TODO: reset datagrid
        DataGridView1.DataSource = tmpDS.Tables(0).DefaultView
        showButtons("Check Result", True)
        resizeCombosToGrid()
    End Sub
    Sub showButtons(ButtonName As String, enableOnly As Boolean)
        Select Case ButtonName
            Case "Check Result"
                If enableOnly Then Me.ButtonCheck.Enabled = True Else Me.ButtonCheck.Visible = True
            Case "upload"
                If enableOnly Then Me.ButtonUpload.Enabled = True Else Me.ButtonUpload.Visible = True
            Case "Preview"
                If enableOnly Then Me.ButtonPreview.Enabled = True Else Me.ButtonPreview.Visible = True
        End Select
    End Sub
    Sub hideButtons(enableOnly As Boolean, btn As Button) 'ButtonName As String, 
        If enableOnly Then btn.Enabled = False
        'Select Case ButtonName
        '    Case "Check Result"
        '        If enableOnly Then Me.ButtonCheck.Enabled = True Else Me.ButtonCheck.Visible = False
        '    Case "upload"
        '        If enableOnly Then Me.ButtonUpload.Enabled = True Else Me.ButtonUpload.Visible = False
        '    Case "Preview"
        '        If enableOnly Then Me.ButtonPreview.Enabled = True Else Me.ButtonPreview.Visible = False
        'End Select
    End Sub
    Private Sub ButtonResultList_Click(sender As Object, e As EventArgs) Handles ButtonResultList.Click
        If TextBoxSession.Text = "" Then
            TextBoxSession.BackColor = Color.Pink
            MessageBox.Show("Please enter the session and retry again")
            Exit Sub
        End If
        Dim myDataSet As DataSet = objResult.getFromDBResultssDataset(TextBoxSession.Text)
        DataGridView2.DataSource = myDataSet.Tables(0).DefaultView


        'TODO: show result summary in listbox
        Dim rd As DataTableReader
        Dim rowVals As String() = {}
        rd = myDataSet.Tables(0).CreateDataReader
        Try
            If rd.Read() Then   'while
                rd.GetValues(rowVals)
                ListBoxResults.Items.AddRange(rowVals) 'test
            End If
            DataGridView2.Visible = True
        Catch ex As Exception

        End Try



    End Sub

    Private Sub ButtonCheck_Click(sender As Object, e As EventArgs) Handles ButtonCheck.Click

        Dim tmpDV As DataView
        Dim tmpDT As DataTable
        Dim snRow As Integer
        Dim emptyRow As Integer = 0
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

        '# display header rows
        colCount = DataGridView1.Columns.Count
        For i = 0 To colCount - 1
            DataGridView1.Columns(i).HeaderText = DataGridView1.Item(i, snRow).Value.ToString
        Next

        '#change column names to match header text
        Try

            For i = 0 To colCount - 1
                If DataGridView1.Columns(i).HeaderText.ToUpper.Contains("MAT") Then
                    DataGridView1.Columns(i).Name = "matno"
                    DataGridView1.Columns(i).HeaderText = "matno"
                    tmpDT.Columns(i).ColumnName = "matno"
                ElseIf DataGridView1.Columns(i).HeaderText.ToUpper.Contains("NAME") Then
                    DataGridView1.Columns(i).Name = "name"
                    DataGridView1.Columns(i).HeaderText = "name"
                    tmpDT.Columns(i).ColumnName = "name"
                ElseIf DataGridView1.Columns(i).HeaderText.ToUpper.Contains("S/N") Or DataGridView1.Columns(i).HeaderText.ToUpper.Contains("SN") Then
                    DataGridView1.Columns(i).Name = "sn"
                    DataGridView1.Columns(i).HeaderText = "sn"
                    tmpDT.Columns(i).ColumnName = "sn"
                ElseIf DataGridView1.Columns(i).HeaderText.ToUpper.Contains("SCORE") Or DataGridView1.Columns(i).HeaderText.ToUpper.Contains("TOTAL") Then
                    DataGridView1.Columns(i).Name = "score"
                    DataGridView1.Columns(i).HeaderText = "score"
                    tmpDT.Columns(i).ColumnName = "score"
                ElseIf DataGridView1.Columns(i).HeaderText.ToUpper.Contains("CA") Or DataGridView1.Columns(i).HeaderText.ToUpper.Contains("CONTIN") Then
                    DataGridView1.Columns(i).Name = "ca"
                    DataGridView1.Columns(i).HeaderText = "ca"
                    tmpDT.Columns(i).ColumnName = "ca"
                Else
                    'note column to delete
                    lstCols.Add(i)
                    listcolNames.Add(DataGridView1.Columns(i).Name)
                    'DataGridView1.Columns.RemoveAt(i)
                End If

            Next




            'attempt to get course code dept and other data
            For j = 0 To snRow - 1
                For i = 0 To tmpDT.Columns.Count - 1
                    'TODO: test for null to avoid errors
                    If tmpDT.Rows(j).Item(i).ToString.ToUpper.Contains("DEPARTMENT") Then
                        'note it
                        Me.TextBoxDepartment.Text = mappDB.getDeptName(DataGridView1.Rows(j).Cells(i).Value.ToString)
                    ElseIf tmpDT.Rows(j).Item(i).ToString.ToUpper.Contains("COURSE") Then
                        Me.TextBoxCourseCode.Text = mappDB.getCourseCode(tmpDT.Rows(j).Item(i).ToString)
                    ElseIf tmpDT.Rows(j).Item(i).ToString.ToUpper.Contains("/") Then
                        Me.TextBoxSession.Text = mappDB.getSessionID(tmpDT.Rows(j).Item(i).ToString)
                    ElseIf tmpDT.Rows(j).Item(i).ToString.ToUpper.Contains("SESSION") Then
                        Me.TextBoxSession.Text = mappDB.getSessionID(tmpDT.Rows(j).Item(i).ToString)
                    ElseIf tmpDT.Rows(j).Item(i).ToString.ToUpper.Contains("/201") Then '201X eg 2019 2018
                        Me.TextBoxSession.Text = mappDB.getSessionID(tmpDT.Rows(j).Item(i).ToString)
                        'todo: fix millenum kind of bug after 2050. e.g for i=205 to 999 if contains i.tostring
                    ElseIf tmpDT.Rows(j).Item(i).ToString.ToUpper.Contains("/202") Or tmpDT.Rows(j).Item(i).ToString.ToUpper.Contains("203") Or tmpDT.Rows(j).Item(i).ToString.ToUpper.Contains("204") Or tmpDT.Rows(j).Item(i).ToString.ToUpper.Contains("205") Then '202X eg 2020 2021
                        Me.TextBoxSession.Text = mappDB.getSessionID(tmpDT.Rows(j).Item(i).ToString)
                    Else
                    End If
                Next
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


            'TODO: validate all values
            'tmpDT.containsNulls
            'change ABS = moduleGeneral.Settings.ABS '-1
            'change NR = moduleGeneral.Settings.ABS '-2
            'change N/A = moduleGeneral.Settings.ABS '-3
            rowCount = tmpDT.Rows.Count
            For i = 0 To rowCount - 1
                For col = 0 To tmpDT.Columns.Count - 1
                    If tmpDT.Rows(i).Item(col).ToString.ToUpper.Contains("NR") Or tmpDT.Rows(i).Item(col).ToString.ToUpper.Contains("NR") Then
                        tmpDT.Rows(i).Item(col) = -2
                    ElseIf tmpDT.Rows(i).Item(col).ToString.ToUpper.Contains("NA") Or tmpDT.Rows(i).Item(col).ToString.ToUpper.Contains("N/A") Then
                        tmpDT.Rows(i).Item(col) = -3
                    ElseIf tmpDT.Rows(i).Item(col).ToString.ToUpper.Contains("ABS") Or tmpDT.Rows(i).Item(col).ToString.ToUpper.Contains("ABS") Then
                        tmpDT.Rows(i).Item(col) = -1 'moduleGeneral.Settings.ABS

                    Else

                    End If

                Next

                'check for empty rows
                If Trim(tmpDT.Rows(i).Item("sn").ToString) = "" And Trim(tmpDT.Rows(i).Item("matno").ToString) = "" And i > snRow Then
                    If Trim(tmpDT.Rows(i).Item("sn").ToString) = "" And Trim(tmpDT.Rows(i).Item("score").ToString) = "" Then
                        emptyRow = i
                    ElseIf Trim(tmpDT.Rows(i).Item("matno").ToString) = "" And Trim(tmpDT.Rows(i).Item("score").ToString) = "0" Then
                        emptyRow = i
                    ElseIf Trim(tmpDT.Rows(i).Item("sn").ToString) = "" And Trim(tmpDT.Rows(i).Item("ca").ToString) = "" Then
                        emptyRow = i

                    Else

                    End If

                End If

                'special check for matno
                'validateMATNO(tmpDT.Rows(i).Item("matno"))
                'if its not a matno store it. prompt the user to insert it into db.students table

                'if matno does not exist, search db for name and suggest the matno

                'if name does not exist in db, create MOCK matno and use it. flag mock matnos
                'TODO: AUTO040998990 'eg matno auto
                If Trim(tmpDT.Rows(i).Item("matno").ToString) = "" Then tmpDT.Rows(i).Item("matno") = 0 - CInt(Rnd(5) * 10000)   ' mappDB.getAutoMATNo

                'score cannot be null
                If tmpDT.Rows(i).Item("score").ToString = "" Then tmpDT.Rows(i).Item("score") = -4 'moduleGeneral.Settings.ABS


            Next

            'delete empty rows below
            rowCount = tmpDT.Rows.Count
            If emptyRow > 0 Then
                For j = emptyRow To rowCount - 1
                    tmpDT.Rows(emptyRow).Delete()   'keep deleting the last row
                Next
            End If

            'remove name its not needed anymore
            tmpDT.Columns.Remove("name")

            'TODO copy useful cols and rows into new data table
            'Dim newDT As New DataTable
            'newDT.Columns.Add(tmpDT.Columns(1))
            'newDT.Columns.Add(tmpDT.Columns(2))
            'newDT.Rows.Add(tmpDT.Rows())

            'display
            Me.TextBoxPrefix.Text = tmpDT.Rows(0).Item(2).ToString

            DataGridView1.DataSource = tmpDT
            DataGridView1.Refresh()

            hideButtons(True, Me.ButtonCheck)   'Todo: remove UI code
        Catch ex As Exception
            MessageBox.Show("Result is not in the correct format, please correct ant try again")
            logError(ex.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub DataGridView1_ColumnWidthChanged(sender As Object, e As DataGridViewColumnEventArgs) Handles DataGridView1.ColumnWidthChanged
        resizeCombosToGrid()
    End Sub
    Sub resizeCombosToGrid()
        On Error Resume Next
        ComboBox1.Width = DataGridView1.Columns(0).Width - 5
        ComboBox1.Left = DataGridView1.RowHeadersWidth + DataGridView1.Left ' + DataGridView1.Columns(0).Width
        ComboBox2.Width = DataGridView1.Columns(1).Width
        ComboBox2.Left = ComboBox1.Left + DataGridView1.Columns(0).Width + 5
        ComboBox3.Width = DataGridView1.Columns(2).Width
        ComboBox3.Left = ComboBox2.Left + DataGridView1.Columns(1).Width
        ComboBox4.Width = DataGridView1.Columns(3).Width
        ComboBox4.Left = ComboBox3.Left + DataGridView1.Columns(2).Width
        ComboBox5.Width = DataGridView1.Columns(4).Width
        ComboBox5.Left = ComboBox4.Left + DataGridView1.Columns(3).Width
        ComboBox6.Width = DataGridView1.Columns(5).Width
        ComboBox6.Left = ComboBox5.Left + DataGridView1.Columns(4).Width
        ComboBox7.Width = DataGridView1.Columns(6).Width
        ComboBox7.Left = ComboBox6.Left + DataGridView1.Columns(5).Width
    End Sub

    Private Sub FormUploadResult_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If mappDB.User = "CA" Then
            MainForm.ChangeMenu("CourseAdviser")
        ElseIf mappDB.User = "CL" Then
            MainForm.ChangeMenu("CourseLecturer")
        ElseIf mappDB.User = "ST" Then
            MainForm.ChangeMenu("Student")
        Else
            MainForm.ChangeMenu("User")
        End If
    End Sub

    Private Sub FormUploadResult_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

    End Sub
End Class
