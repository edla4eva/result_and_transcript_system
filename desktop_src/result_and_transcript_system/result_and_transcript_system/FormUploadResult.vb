Imports System.ComponentModel

Public Class FormUploadResult


    Dim dsDepts As New DataSet
    Dim dsCourses As New DataSet
    Dim dsSessions As New DataSet
    'Variable for Batch Upload
    Dim results As New List(Of String)
    Dim tmpDept, tmpLevel, tmpSession, tmpCourseCode As String

    Dim arrSessions(1) As String
    Dim arrLevel(1) As String
    Dim arrDept(1) As String
    Dim arrCourseCodes(1) As String


    Private Sub FormUploadResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = RGBColors.colorBlack2

        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub ButtonBrowse_Click(sender As Object, e As EventArgs) Handles ButtonBrowse.Click
        Dim FileOpenDialogBroadsheet As New OpenFileDialog()
        Dim resultFileName As String = ""

        If Not FileOpenDialogBroadsheet.ShowDialog = DialogResult.Cancel Then
            resultFileName = FileOpenDialogBroadsheet.FileName()
        End If
        TextBoxExcelFilename.Text = resultFileName
        objExcelFile.excelFileName = resultFileName


        PreviewResult()

    End Sub

    Private Sub ButtonUpload_Click(sender As Object, e As EventArgs) Handles ButtonUpload.Click
        Try

            'Algorithm
            'Check databas if result already exist to avoid duplicates
            'Write into Database
            'If MessageBox.Show("Are you sure you want to upload the result into DB? Cannot be undone", vbYesNo) = DialogResult.Yes Then
            'Get dataset from displayed datagrid
            'parse dataset record by record
            'insert record by record

            'TODO: check if result exists
            'if resultExists then giveUserOptions, exit

            Dim strSQL As String   'dMATNO, dScore,
            Dim dSession, dDept, dCourse, dDeptID As String
            Dim boolSession, boolDept, boolCourse As Boolean
            'Dim colMATNO, colScore As Integer
            'get headers
            'if checkBox custom then
            'colMATNO = comboMat.selectedindex
            'colScore = comboScore.selectedindex
            ' else


            strSQL = SQL_SELECT_RESULTS_WHERE_MATNO '"INSERT INTO TableResults"

            '#method 1 - creates table and inserts
            Dim dt As DataTable
            'Dim dv As DataView


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


            '#method 1 manual Insert or bulkInsert
            '#RODO: VALIDATION we need some AI to check these
            If TextBoxSession.Text = "" Or Not ComboBoxSessions.SelectedIndex >= 0 Then
                MsgBox("Please enter the session") 'prompt user
                ComboBoxSessions.BackColor = Color.Pink
                'TODO: check if session is in database and return session_id
            ElseIf TextBoxDepartment.Text = "" Or Not ComboBoxDepartments.SelectedIndex >= 0 Then
                MsgBox("Please enter the department") 'prompt user
                ComboBoxDepartments.BackColor = Color.Pink
            ElseIf TextBoxCourseCode.Text = "" Or Not ComboBoxCourseCode.SelectedIndex >= 0 Then
                MsgBox("Please enter the coursecode") 'prompt user
                ComboBoxCourseCode.BackColor = Color.Pink
            Else
                dSession = ComboBoxSessions.SelectedItem.ToString
                dDept = TextBoxDepartment.Text 'TODO: implement Function or use comboComputer Engineering
                dDeptID = 1
                dDeptID = mappDB.getDeptID(ComboBoxDepartments.SelectedItem).ToString
                dCourse = TextBoxCourseCode.Text 'CPE300"

                ''TODO: validate inputs from DB
                If (dSession = mappDB.GetRecordWhere(String.Format("SELECT session_id FROM SESSIONS WHERE session_id='{0}'", dSession))) Then boolSession = True
                If dDeptID = mappDB.GetRecordWhere(String.Format("SELECT dept_id FROM departments WHERE dept_id={0}", dDeptID)) Then boolDept = True
                If dCourse = (mappDB.GetRecordWhere(String.Format("SELECT course_code FROM courses WHERE course_code='{0}'", dCourse))) Then boolCourse = True

                If boolSession And boolDept And boolCourse Then
                    mappDB.manualResultInsertDB(dt, dSession, CInt(dDeptID), dCourse)
                ElseIf dSession.Length > 10 Then
                    MsgBox("Input correct Session, department and level")

                End If
                MsgBox("Results Uploaded into Database Successfully! Cross check what was uploaded below")
                DataGridView2.Visible = True
                strSQL = "SELECT * from Results WHERE (session_idr = '{0}' AND Course_Code_idr = '{1}' AND department_idr={2})"
                DataGridView2.DataSource = mappDB.GetDataWhere(String.Format(strSQL, dSession, dCourse, dDeptID)).Tables(0).DefaultView
                DataGridView2.Top = DataGridView1.Top + DataGridView1.Height
                DataGridView2.Refresh()
            End If


            '#method 2:            'mappDB.InsertRecord(strSQL)
            '#method 3:            ' mappDB.getDataReader("TableResults") 'then             ' mappDB.CompareDataTables(DataGridView1.DataSource.tables(0), dt)
        Catch ex As Exception
            MessageBox.Show("Could not upload to database. Please Exit the RTPS Result Software and re-launch as administrator" & vbCrLf & ex.Message)
        End Try

    End Sub

    Private Sub PreviewResult()
        Try
            objResult.excelVersion = "2013"
            Dim tmpDS As DataSet = objExcelFile.readResultFile()
            DataGridView1.DataSource = Nothing
            DataGridView1.Columns.Clear()

            'TODO: reset datagrid
            If tmpDS Is Nothing Then Exit Sub
            DataGridView1.DataSource = tmpDS.Tables(0).DefaultView  'todo: error if cancel file diag
            showButtons("ButtonCheck", True)

        Catch ex As Exception
            MsgBox("Please select an Excel file, Result should be in the correct format")
        End Try

    End Sub
    Sub showButtons(ButtonName As String, enableOnly As Boolean)
        Select Case ButtonName
            Case "ButtonCheck"
                If enableOnly Then Me.ButtonCheck.Enabled = True Else Me.ButtonCheck.Visible = True
            Case "ButtonUpload"
                If enableOnly Then Me.ButtonUpload.Enabled = True Else Me.ButtonUpload.Visible = True
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
        MainForm.ChangeMenu("ViewResults")

    End Sub

    Private Sub ButtonCheck_Click(sender As Object, e As EventArgs) Handles ButtonCheck.Click
        'UI
        DataGridView2.Visible = False   'todo: remove ui code change to this hideButtons(False, "DataGridView2")

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
            If tmpDT.Rows(i).ItemArray().Contains("S/N") Or tmpDT.Rows(i).ItemArray().Contains("MAT") Or
                 tmpDT.Rows(i).ItemArray().Contains("TOTAL") Then
                'tip: can tet for null then test this Or tmpDT.Rows(i).Item(2).Contains("MAT")
                Debug.Print("ColumnHeader at row: " & i)
                snRow = i
                Exit For
            End If
        Next

        '# display header rows
        colCount = DataGridView1.Columns.Count
        For i = 0 To colCount - 1
            DataGridView1.Columns(i).HeaderText = DataGridView1.Item(i, snRow).Value.ToString.Trim
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
                    ElseIf tmpDT.Rows(j).Item(i).ToString.ToUpper.Contains("LEVEL") Then
                        Me.TextBoxLevel.Text = mappDB.getCourseCode(tmpDT.Rows(j).Item(i).ToString)
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


            'Validate them without consulting database

            'TODO:

            For Each item In ComboBoxSessions.Items
                If TextBoxSession.Text.ToUpper.Contains(item.ToString.ToUpper) Then
                    TextBoxSession.Text = item.ToString
                    ComboBoxSessions.SelectedItem = item '?
                    Exit For
                Else
                    TextBoxSession.Text = ""  'clear it it contains info that is not useful and may cause error
                End If
            Next

            For Each item In ComboBoxDepartments.Items
                If TextBoxDepartment.Text.ToUpper.Contains(item.ToString.ToUpper) Then
                    TextBoxDepartment.Text = item.ToString
                    ComboBoxDepartments.SelectedItem = item '?
                    Exit For
                Else
                    TextBoxDepartment.Text = ""  'clear it it contains info that is not useful and may cause error
                End If
            Next
            For Each item In ComboBoxCourseCode.Items
                If TextBoxCourseCode.Text.Contains(item.ToString) Then
                    TextBoxCourseCode.Text = item.ToString
                    ComboBoxCourseCode.SelectedItem = item '?
                    Exit For
                Else
                    TextBoxCourseCode.Text = ""  'clear it it contains info that is not useful and may cause error
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


            'TODO: validate all values
            'tmpDT.containsNulls
            'change ABS = moduleGeneral.Settings.ABS '-1
            'change NR = moduleGeneral.Settings.ABS '-2
            'change N/A = moduleGeneral.Settings.ABS '-3
            rowCount = tmpDT.Rows.Count
            For i = 0 To rowCount - 1
                For col = 0 To tmpDT.Columns.Count - 1
                    If (tmpDT.Rows(i).Item(col).ToString.ToUpper.Contains("NR") Or tmpDT.Rows(i).Item(col).ToString.ToUpper.Contains("NR")) And Not tmpDT.Columns(col).ColumnName = "name" Then     'dont touch naame col
                        tmpDT.Rows(i).Item(col) = -2
                    ElseIf (tmpDT.Rows(i).Item(col).ToString.ToUpper.Contains("NA") Or tmpDT.Rows(i).Item(col).ToString.ToUpper.Contains("N/A")) And Not tmpDT.Columns(col).ColumnName = "name" Then
                        tmpDT.Rows(i).Item(col) = -3
                    ElseIf (tmpDT.Rows(i).Item(col).ToString.ToUpper.Contains("ABS") Or tmpDT.Rows(i).Item(col).ToString.ToUpper.Contains("ABS")) And Not tmpDT.Columns(col).ColumnName = "name" Then
                        tmpDT.Rows(i).Item(col) = -1 'moduleGeneral.Settings.ABS

                    Else

                    End If

                Next

                'check for empty rows
                If Trim(tmpDT.Rows(i).Item("sn").ToString) = "" And i > snRow Then
                    If Trim(tmpDT.Rows(i).Item("sn").ToString) = "" And Trim(tmpDT.Rows(i).Item("score").ToString) = "" Then
                        If Not emptyRowFound Then emptyRow = i
                        emptyRowFound = True
                    ElseIf Trim(tmpDT.Rows(i).Item("matno").ToString) = "" And Trim(tmpDT.Rows(i).Item("score").ToString) = "0" Then
                        If Not emptyRowFound Then emptyRow = i
                        emptyRowFound = True
                    ElseIf i + 1 <= rowCount - 1 Then 'check successive sn
                        If Trim(tmpDT.Rows(i).Item("sn").ToString) = "" And Trim(tmpDT.Rows(i + 1).Item("sn").ToString) = "" Then
                            If Not emptyRowFound Then emptyRow = i
                            emptyRowFound = True
                        End If
                    ElseIf i + 1 <= rowCount - 1 Then 'check successive matno
                        If Trim(tmpDT.Rows(i).Item("matno").ToString) = "" And Trim(tmpDT.Rows(i + 1).Item("matno").ToString) = "" Then
                            If Not emptyRowFound Then emptyRow = i
                            emptyRowFound = True
                        End If
                    Else

                    End If

                End If

                'special check for matno
                'validateMATNO(tmpDT.Rows(i).Item("matno"))
                'if its not a matno store it. prompt the user to insert it into db.students table

                'if matno does not exist, search db for name and suggest the matno

                'if name does not exist in db, create MOCK matno and use it. flag mock matnos
                'TODO: AUTO040998990 'eg matno auto

                If Trim(tmpDT.Rows(i).Item("matno").ToString) = "" And Not (i = emptyRow) Then
                    tmpDT.Rows(i).Item("matno") = "AUTO" & CStr(CInt(Rnd(Now.Second) * 10000) + i)   ' mappDB.getAutoMATNo
                Else
                    If CheckBoxPrefix.Checked = True Then tmpDT.Rows(i).Item("matno") = TextBoxPrefix.Text & tmpDT.Rows(i).Item("matno")
                End If

                'score cannot be null
                If tmpDT.Rows(i).Item("score").ToString = "" And Not (i = emptyRow) Then tmpDT.Rows(i).Item("score") = -4 'moduleGeneral.Settings.ABS


            Next

            'delete empty rows below
            rowCount = tmpDT.Rows.Count
            If emptyRow > 0 Then
                For j = emptyRow To rowCount - 1
                    tmpDT.Rows(emptyRow).Delete()   'keep deleting the last row
                Next
            End If



            'TODO copy useful cols and rows into new data table
            'Dim newDT As New DataTable
            'newDT.Columns.Add(tmpDT.Columns(1))
            'newDT.Columns.Add(tmpDT.Columns(2))
            'newDT.Rows.Add(tmpDT.Rows())

            'display


            DataGridView1.DataSource = tmpDT
            DataGridView1.Refresh()

            hideButtons(True, Me.ButtonCheck)   'Todo: remove UI code
            showButtons("ButtonUpload", True)
        Catch ex As Exception
            MessageBox.Show("Result is not in the correct format, please correct ant try again")
            logError(ex.ToString)
            Exit Sub
        End Try
    End Sub



    Private Sub FormUploadResult_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MainForm.doCloseForm()
    End Sub

    Private Sub FormUploadResult_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        'may not be a good idea to do ui stuff here

        mappDB.getDeptSessionsIntoDictionaries()
        'Not working in BGWorker
        'dsDepts = combolistDS(STR_SQL_ALL_DEPARTMENTS_COMBO, "dept_id", "dept_name")
        'dsCourses = combolistDS(STR_SQL_ALL_COURSES, "course_code", "course_code")
        'dsSessions = combolistDS(STR_SQL_ALL_SESSIONS_COMBO, "session_id", "session_id")

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        'Dim arrCC As String()
        'arrCC =ComboBoxCourseCode.Items.toarray
        'arr.find
        'ComboBoxDepartments.Items.Addarray(dictDepts.ToArray)

        If dictCourses.Count = 0 Then
            If mappDB.getDeptSessionsIntoDictionaries() = False Then
                MsgBox("Cannot retrieve Department and Course info from database")
                Exit Sub
            End If
        End If
        'for dictonaries
        ComboBoxCourseCode.Items.Clear()
        For Each key In dictCourses.Keys
            ComboBoxCourseCode.Items.Add(dictCourses(key))
        Next
        ComboBoxCourseCode.SelectedIndex = 0
        ComboBoxDepartments.Items.Clear()
        For Each key In dictDepts.Keys
            ComboBoxDepartments.Items.Add(dictDepts(key))
        Next
        ComboBoxDepartments.SelectedIndex = 0
        ComboBoxSessions.Items.Clear()
        For Each key In dictSessions.Keys
            ComboBoxSessions.Items.Add(dictSessions(key))
        Next
        ComboBoxSessions.SelectedIndex = 0


        ComboBoxLevel.SelectedIndex = 0
        ''for datasets (NOT WORKING in bgWorker)
        'ComboBoxDepartments.Items.Clear()
        'With ComboBoxDepartments
        '    '.DataSource = dsDepts.Tables(0)
        '    '.ValueMember = "dept_id"
        '    '.DisplayMember = "dept_name"
        'End With

        'ComboBoxSessions.Items.Clear()
        'With ComboBoxSessions
        '    '.DataSource = dsSessions.Tables(0)
        '    '.ValueMember = "session_id"
        '    '.DisplayMember = "session_id"
        'End With
    End Sub

    Private Sub ComboBoxDepartments_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxDepartments.SelectedIndexChanged
        TextBoxDepartment.Text = ComboBoxDepartments.SelectedItem.ToString
    End Sub

    Private Sub ComboBoxSessions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSessions.SelectedIndexChanged
        If Not ComboBoxSessions.SelectedItem = Nothing Then TextBoxSession.Text = ComboBoxSessions.SelectedItem.ToString
    End Sub

    Private Sub ComboBoxLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxLevel.SelectedIndexChanged
        If Not ComboBoxLevel.SelectedItem = Nothing Then TextBoxLevel.Text = ComboBoxLevel.SelectedItem.ToString
    End Sub

    Private Sub ComboBoxCourseCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCourseCode.SelectedIndexChanged
        If Not ComboBoxCourseCode.SelectedItem = Nothing Then TextBoxCourseCode.Text = ComboBoxCourseCode.SelectedItem.ToString
    End Sub

    Private Sub TextBoxCourseCode_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCourseCode.TextChanged
        'ComboBoxCourseCode.SelectedIndex = ComboBoxCourseCode.FindString(TextBoxCourseCode.Text)
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub ButtonBatchUpload_Click(sender As Object, e As EventArgs) Handles ButtonBatchUpload.Click
        Dim FileOpenDialogBroadsheet As New OpenFileDialog()
        Dim resultsDir As String = ""

        ReDim arrSessions(ComboBoxSessions.Items.Count - 1)
        ReDim arrLevel(ComboBoxLevel.Items.Count - 1)
        ReDim arrDept(ComboBoxDepartments.Items.Count - 1)
        ReDim arrCourseCodes(ComboBoxCourseCode.Items.Count - 1)

        ComboBoxSessions.Items.CopyTo(arrSessions, 0)
        ComboBoxLevel.Items.CopyTo(arrLevel, 0)
        ComboBoxDepartments.Items.CopyTo(arrDept, 0)
        ComboBoxCourseCode.Items.CopyTo(arrCourseCodes, 0)

        tmpSession = ComboBoxSessions.Text
        tmpDept = ComboBoxDepartments.Text
        tmpLevel = ComboBoxLevel.Text
        tmpCourseCode = ComboBoxCourseCode.Text

        FileOpenDialogBroadsheet.CheckPathExists = True
        FileOpenDialogBroadsheet.InitialDirectory = TextBoxResultsDir.Text
        If Not FileOpenDialogBroadsheet.ShowDialog = DialogResult.Cancel Then
            resultsDir = System.IO.Path.GetDirectoryName(FileOpenDialogBroadsheet.FileName())

            BackgroundWorkerBatch.RunWorkerAsync(resultsDir)
            'For Each file In My.Computer.FileSystem.GetFiles(resultsDir)
            '    objExcelFile.excelFileName = file
            '    TextBoxResultsDir.Text = file
            'Next
        End If



        showButtons("ButtonPreview", True)
    End Sub

    Private Sub BackgroundWorkerBatch_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorkerBatch.DoWork
        BackgroundWorkerBatch.WorkerReportsProgress = True
        Dim tmpDS As DataSet
        Dim dt As DataTable
        Dim prg As Double = 0
        Dim countFiles As Integer = My.Computer.FileSystem.GetFiles(e.Argument).Count
        Dim iCount As Integer = 0
        For Each file In My.Computer.FileSystem.GetFiles(e.Argument)
            objExcelFile.progress = CInt(iCount / countFiles * 100)
            objExcelFile.progressStr = "Processing " & System.IO.Path.GetFileName(file)
            iCount = iCount + 1
            objExcelFile.excelFileName = file
            '#1. Silent preview
            tmpDS = objExcelFile.readResultFile()
            '#2. Do silent check 
            dt = silentCheck(tmpDS.Tables(0))
            '#3.upload em
            results.Clear()

            If silentUpload(dt, tmpSession, tmpCourseCode, tmpDept, mappDB.getDeptID(tmpDept)) = True Then
                results.Add(System.IO.Path.GetFileNameWithoutExtension(file))
            End If

        Next
    End Sub



    Private Sub BackgroundWorkerBatch_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorkerBatch.RunWorkerCompleted
        MsgBox("Results Uploaded into Database Successfully! Cross check what was uploaded in the list")
        ListBoxBatch.Items.AddRange(results.ToArray)
        'DataGridView2.Visible = True
        'strSQL = "SELECT * from Results WHERE (session_idr = '{0}' AND Course_Code_idr = '{1}' AND department_idr={2})"
        'DataGridView2.DataSource = mappDB.GetDataWhere(String.Format(strSQL, dSession, dCourse, dDeptID)).Tables(0).DefaultView
        'DataGridView2.Top = DataGridView1.Top + DataGridView1.Height
        'DataGridView2.Refresh()

    End Sub
    Function silentCheck(tmpDT As DataTable) As DataTable

        Dim snRow As Integer = 7
        Dim emptyRow As Integer = 0
        Dim emptyRowFound As Boolean = False
        Dim rowCount As Integer = 0
        Dim colCount As Integer = 0
        Dim lstCols As New List(Of Integer)
        Dim listcolNames As New List(Of String)
        Dim trialTmpDept As String = ""
        Dim trialTtmpLevel As String = ""
        Dim trialTmpSession As String = ""
        Dim trialTtmpCourseCode = ""
        '# Detect header row
        rowCount = tmpDT.Rows.Count
        For i = 0 To rowCount - 1
            If tmpDT.Rows(i).ItemArray().Contains("S/N") Or tmpDT.Rows(i).ItemArray().Contains("MAT.") Or tmpDT.Rows(i).ItemArray().Contains("TOTAL") Then
                ' Debug.Print("ColumnHeader at row: " & i)
                snRow = i
                Exit For
            End If
        Next

        '# display header rows and change colNames
        Dim colHeaders(5) As String
        colCount = tmpDT.Columns.Count
        ReDim colHeaders(0 To colCount - 1)
        For i = 0 To colCount - 1
            colHeaders(i) = tmpDT.Rows(snRow).Item(i).ToString
        Next
        '#change column names to match header text
        For i = 0 To colCount - 1
            'tmpDT.Columns(i).ColumnName = tmpDT.Rows(snRow).Item(i).ToString
            If colHeaders(i).ToUpper.Contains("MAT") Then
                tmpDT.Columns(i).ColumnName = "matno"
            ElseIf colHeaders(i).ToUpper.Contains("NAME") Then
                tmpDT.Columns(i).ColumnName = "name"
            ElseIf colHeaders(i).ToUpper.Contains("S/N") Or colHeaders(i).ToUpper.Contains("SN") Then
                tmpDT.Columns(i).ColumnName = "sn"
            ElseIf colHeaders(i).ToUpper.Contains("SCORE") Or colHeaders(i).ToUpper.Contains("TOTAL") Then
                tmpDT.Columns(i).ColumnName = "score"
            ElseIf colHeaders(i).ToUpper.Contains("CA") Or colHeaders(i).ToUpper.Contains("TEST") Then
                tmpDT.Columns(i).ColumnName = "ca"
            Else
                'note column to delete
                lstCols.Add(i)
                listcolNames.Add(tmpDT.Columns(i).ColumnName)
            End If

        Next


        Try
            'use deterministic fixed template approac
            trialTmpDept = tmpDT.Rows(0).Item(0).Value.ToString
            trialTmpSession = mappDB.getSessionID(tmpDT.Rows(3).Item(0).ToString)
            trialTtmpCourseCode = mappDB.getCourseCode(tmpDT.Rows(5).Item(0).ToString)

            trialTtmpCourseCode = trialTtmpCourseCode.Split(";")(1)
            'attempt to get course code dept and other data
            'For j = 0 To snRow - 1
            '    For i = 0 To tmpDT.Columns.Count - 1
            '        'TODO: test for null to avoid errors
            '        If tmpDT.Rows(j).Item(i).ToString.ToUpper.Contains("DEPARTMENT") Then
            '            'note it
            '            trialTmpDept = mappDB.getDeptName(tmpDT.Rows(j).Item(i).Value.ToString)
            '        ElseIf tmpDT.Rows(j).Item(i).ToString.ToUpper.Contains("COURSE") Or tmpDT.Rows(j).Item(i).ToString.ToUpper.Contains(":") Then
            '            trialTtmpCourseCode = mappDB.getCourseCode(tmpDT.Rows(j).Item(i).ToString)
            '        ElseIf tmpDT.Rows(j).Item(i).ToString.ToUpper.Contains("LEVEL") Then
            '            trialTtmpLevel = mappDB.getCourseCode(tmpDT.Rows(j).Item(i).ToString)
            '        ElseIf tmpDT.Rows(j).Item(i).ToString.ToUpper.Contains("/") Then
            '            trialTmpSession = mappDB.getSessionID(tmpDT.Rows(j).Item(i).ToString)
            '        ElseIf tmpDT.Rows(j).Item(i).ToString.ToUpper.Contains("SESSION") Then
            '            trialTmpSession = mappDB.getSessionID(tmpDT.Rows(j).Item(i).ToString)
            '        ElseIf tmpDT.Rows(j).Item(i).ToString.ToUpper.Contains("/201") Then '201X eg 2019 2018
            '            trialTmpSession = mappDB.getSessionID(tmpDT.Rows(j).Item(i).ToString)
            '            'todo: fix millenum kind of bug after 2050. e.g for i=205 to 999 if contains i.tostring
            '        ElseIf tmpDT.Rows(j).Item(i).ToString.ToUpper.Contains("/202") Or tmpDT.Rows(j).Item(i).ToString.ToUpper.Contains("203") Or tmpDT.Rows(j).Item(i).ToString.ToUpper.Contains("204") Or tmpDT.Rows(j).Item(i).ToString.ToUpper.Contains("205") Then '202X eg 2020 2021
            '            trialTmpSession = mappDB.getSessionID(tmpDT.Rows(j).Item(i).ToString)

            '        Else
            '        End If
            '    Next
            'Next


            'If dictAllCourseCodeKeyAndCourseLevelVal.Count = 0 Then

            '    mappDB.getAllCourses() 'fill the dictionaries
            'Else
            '    'TODO: Something is wrong with db access
            'End If
            'If dictAllCourseCodeKeyAndCourseLevelVal.ContainsKey(trialTtmpCourseCode) Then
            '    trialTtmpCourseCode = dictAllCourseCodeKeyAndCourseLevelVal(trialTtmpCourseCode)
            'Else

            'End If



            'Validate them without consulting database
            'For silent mode use arrays of items in conbos
            'TODO:

            For Each item In arrSessions
                If trialTmpSession.ToUpper.Contains(item.ToString.ToUpper) Then
                    tmpSession = item.ToString
                    Exit For
                Else
                    'tmpSession = InputBox("Enter Session")  'TODO
                End If
            Next

            For Each item In arrDept
                If trialTmpDept.ToUpper.Contains(item.ToString.ToUpper) Then
                    tmpDept = mappDB.getDeptID(item.ToString)
                    Exit For
                End If
            Next

            'Use a deterministic method to get Course Code
            For Each item In arrCourseCodes
                If trialTtmpCourseCode.ToUpper.Contains(item.ToString.ToUpper) Or tmpDT.Rows(snRow - 2).Item(0).ToString.ToUpper.Contains(item.ToString.ToUpper) Then
                    tmpCourseCode = item.ToString
                    Exit For
                End If
            Next
            For Each item In arrLevel
                If trialTtmpLevel.ToUpper.Contains(item.ToString.ToUpper) Then
                    tmpLevel = item.ToString
                End If
            Next

            'delete noted useless columns
            Dim delColCount = 0
            For Each iName In listcolNames
                tmpDT.Columns.Remove(iName) 'TODO: its not removing, just moving to the end
                delColCount += 1 'update count of deleted cols
            Next

            tmpDT.AcceptChanges()

            'delete header rows 'TODO not deleting
            For j = snRow To 0 Step -1
                tmpDT.Rows(0).Delete()
                tmpDT.AcceptChanges()
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
                tmpDT.AcceptChanges()

                'check for empty rows
                If Trim(tmpDT.Rows(i).Item("sn").ToString) = "" And i > snRow Then
                    If Trim(tmpDT.Rows(i).Item("sn").ToString) = "" And Trim(tmpDT.Rows(i).Item("score").ToString) = "" Then
                        If Not emptyRowFound Then emptyRow = i
                        emptyRowFound = True
                    ElseIf Trim(tmpDT.Rows(i).Item("matno").ToString) = "" And Trim(tmpDT.Rows(i).Item("score").ToString) = "0" Then
                        If Not emptyRowFound Then emptyRow = i
                        emptyRowFound = True
                    ElseIf i + 1 <= rowCount - 1 Then 'check successive sn
                        If Trim(tmpDT.Rows(i).Item("sn").ToString) = "" And Trim(tmpDT.Rows(i + 1).Item("sn").ToString) = "" Then
                            If Not emptyRowFound Then emptyRow = i
                            emptyRowFound = True
                        End If
                    ElseIf i + 1 <= rowCount - 1 Then 'check successive matno
                        If Trim(tmpDT.Rows(i).Item("matno").ToString) = "" And Trim(tmpDT.Rows(i + 1).Item("matno").ToString) = "" Then
                            If Not emptyRowFound Then emptyRow = i
                            emptyRowFound = True
                        End If
                    Else

                    End If

                End If

                'special check for matno
                'validateMATNO(tmpDT.Rows(i).Item("matno"))
                'if its not a matno store it. prompt the user to insert it into db.students table

                'if matno does not exist, search db for name and suggest the matno

                'if name does not exist in db, create MOCK matno and use it. flag mock matnos
                'TODO: AUTO040998990 'eg matno auto
                'If Trim(tmpDT.Rows(i).Item("matno").ToString) = "" And Not (i = emptyRow) Then tmpDT.Rows(i).Item("matno") = "AUTO" & CStr(CInt(Rnd(Now.Second) * 10000) + i)   ' mappDB.getAutoMATNo

                'score cannot be null
                'If tmpDT.Rows(i).Item("score").ToString = "" And Not (i = emptyRow) Then tmpDT.Rows(i).Item("score") = -4 'moduleGeneral.Settings.ABS


            Next

            Dim dgv As New DataGridView
            'delete empty rows below
            rowCount = tmpDT.Rows.Count
            If emptyRow > 0 Then
                For j = rowCount - 1 To emptyRow Step -1
                    tmpDT.Rows(emptyRow).Delete()   'keep deleting the last row
                    tmpDT.AcceptChanges()
                Next
            End If
            'TODO: A hack to delete rows
            tmpDT.AcceptChanges()
            'dgv.DataSource = tmpDT
            'If emptyRow > 0 Then
            '    For j = rowCount - 1 To emptyRow Step -1
            '        dgv.Rows.RemoveAt(emptyRow)   'keep deleting the last row
            '    Next
            'End If
            'dgv.EndEdit()

            'tmpDT = dgv.DataSource
            tmpDT.AcceptChanges()
            'remove name its not needed anymore
            ' tmpDT.Columns.Remove("name")

            Return tmpDT
        Catch ex As Exception
            MessageBox.Show("Result is not in the correct format, please correct ant try again")
            logError(ex.ToString)
            Return Nothing
        End Try
    End Function

    Private Function silentUpload(dt As DataTable, dSession As String, dCourse As String, dDept As String, dDeptID As String) As Boolean
        Try
            Dim strSQL As String   'dMATNO, dScore,
            Dim boolSession, boolDept, boolCourse As Boolean

            strSQL = SQL_SELECT_RESULTS_WHERE_MATNO '"INSERT INTO results
            '#method 1 - creates table and inserts

            ''TODO: validate inputs
            If (dSession = mappDB.GetRecordWhere(String.Format("SELECT session_id FROM SESSIONS WHERE session_id='{0}'", dSession))) Then boolSession = True
            If dDeptID = mappDB.GetRecordWhere(String.Format("SELECT dept_id FROM departments WHERE dept_id={0}", dDeptID)) Then boolDept = True
            If dCourse = (mappDB.GetRecordWhere(String.Format("SELECT course_code FROM courses WHERE course_code='{0}'", dCourse))) Then boolCourse = True

            If boolSession And boolDept And boolCourse Then
                mappDB.manualResultInsertDB(dt, dSession, CInt(dDeptID), dCourse)
            ElseIf dSession.Length > 10 Then
                logError("Input correct Session, department and level") 'todo
            End If

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try

    End Function

    Private Sub TimerResult_Tick(sender As Object, e As EventArgs) Handles TimerResult.Tick
        If objExcelFile.progress <= 100 Then ProgressBarBS.Value = CInt(objExcelFile.progress)
        Me.LabelProgress.Text = (objExcelFile.progress).ToString & "% - " & objExcelFile.progressStr
    End Sub

    Private Sub ButtonDownloadTemplate_Click(sender As Object, e As EventArgs) Handles ButtonDownloadTemplate.Click
        Try
            Dim tmpileName As String = My.Application.Info.DirectoryPath & "\templates\result.xltx"
            Dim tmpileName2 As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\templates\result.xltx"
            Dim tmpileName3 As String = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\templates\result.xltx"

            If My.Computer.FileSystem.FileExists(tmpileName) Then

            ElseIf My.Computer.FileSystem.FileExists(tmpileName2) Then
                tmpileName = tmpileName2
            ElseIf My.Computer.FileSystem.FileExists(tmpileName3) Then
                tmpileName = tmpileName3
            End If

            Using sfd As New SaveFileDialog
                If sfd.ShowDialog = DialogResult.OK Then
                    My.Computer.FileSystem.CopyFile(tmpileName, sfd.FileName & ".xltx")
                End If
                If MsgBox("Do you want to open the template file in Excel?", MsgBoxStyle.YesNo, "Result Template") = DialogResult.Yes Then
                    System.Diagnostics.Process.Start(tmpileName)
                End If
            End Using
        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub
    Private Sub CheckBoxPrefix_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxPrefix.CheckedChanged
        Try
            Dim dmatno As String
            If CheckBoxPrefix.Checked = True Then
                For i = 0 To DataGridView1.Rows.Count - 1
                    dmatno = DataGridView1.Rows(i).Cells("matno").Value
                    If IsDBNull(dmatno) Or dmatno Is Nothing Then Continue For
                    If dmatno.Contains(TextBoxPrefix.Text) Then
                    Else
                        dmatno = TextBoxPrefix.Text & dmatno
                        DataGridView1.Rows(i).Cells("matno").Value = dmatno
                    End If
                Next
            Else
                For i = 0 To DataGridView1.Rows.Count - 1
                    dmatno = DataGridView1.Rows(i).Cells("matno").Value
                    If IsDBNull(dmatno) Or dmatno Is Nothing Then Continue For
                    If dmatno.Contains(TextBoxPrefix.Text) Then
                        dmatno = dmatno.Replace(TextBoxPrefix.Text, "")
                        DataGridView1.Rows(i).Cells("matno").Value = dmatno
                    Else

                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox("Click on Check result before applying prefix")
            logError(ex.ToString)
        End Try
    End Sub

    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Me.Close()
    End Sub

    Private Sub ButtonCloud_Click(sender As Object, e As EventArgs) Handles ButtonCloud.Click
        Dim FileOpenDialogBroadsheet As New OpenFileDialog()
        Dim resultsDir As String = ""

        ReDim arrSessions(ComboBoxSessions.Items.Count - 1)
        ReDim arrLevel(ComboBoxLevel.Items.Count - 1)
        ReDim arrDept(ComboBoxDepartments.Items.Count - 1)
        ReDim arrCourseCodes(ComboBoxCourseCode.Items.Count - 1)

        ComboBoxSessions.Items.CopyTo(arrSessions, 0)
        ComboBoxLevel.Items.CopyTo(arrLevel, 0)
        ComboBoxDepartments.Items.CopyTo(arrDept, 0)
        ComboBoxCourseCode.Items.CopyTo(arrCourseCodes, 0)

        tmpSession = ComboBoxSessions.Text
        tmpDept = ComboBoxDepartments.Text
        tmpLevel = ComboBoxLevel.Text
        tmpCourseCode = ComboBoxCourseCode.Text

        FileOpenDialogBroadsheet.CheckPathExists = True
        FileOpenDialogBroadsheet.InitialDirectory = TextBoxResultsDir.Text
        If Not FileOpenDialogBroadsheet.ShowDialog = DialogResult.Cancel Then
            resultsDir = System.IO.Path.GetDirectoryName(FileOpenDialogBroadsheet.FileName())
            test_upload(resultsDir)
        End If

        showButtons("ButtonPreview", True)
    End Sub
    Private Sub test_upload(dfile As String)
        Dim tmpDS As DataSet
        For Each file In My.Computer.FileSystem.GetFiles(dfile)
            objExcelFile.excelFileName = file
            '#1. Silent preview
            tmpDS = objExcelFile.readResultFile()
            '#2. Do silent check 
            Dim dt As DataTable = silentCheck(tmpDS.Tables(0))
            '#3.upload em
            results.Clear()
            DataGridView1.DataSource = dt.DefaultView
            'If silentUpload(dt, tmpSession, tmpCourseCode, tmpDept, mappDB.getDeptID(tmpDept)) = True Then
            'results.Add(System.IO.Path.GetFileNameWithoutExtension(file))

            'End If
            Exit For
        Next
    End Sub

    Private Sub BackgroundWorkerBatch_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorkerBatch.ProgressChanged
        ProgressBarBS.Value = e.ProgressPercentage
        LabelProgress.Text = e.ProgressPercentage.ToString & "%"
    End Sub
End Class
