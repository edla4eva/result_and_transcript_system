Public Class FormStudent
    Private Sub FormStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = RGBColors.colorBackground
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
        checkStudents()
        If MsgBox("Do you want to save the imported students into the database (cannot be undone). You ca also do it later by clicking the upload button", MsgBoxStyle.YesNo) = vbYes Then
            ButtonSave.PerformClick()
        End If
    End Sub
    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
        Dim retFileName As String
        retFileName = objExcelFile.exportStudentsToExcelFile_NPOI(dgvStudents.DataSource, My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData & "\ExportedStudents" & Now.Ticks.ToString & ".xlsx")
        MsgBox("File exported to: " & retFileName)
    End Sub
    Private Sub PreviewStudents()
        ' objResult.resultFilename = My.Application.Info.DirectoryPath & "\samples\result.xlsx"

        Dim tmpDS As DataSet = objExcelFile.readResultFile()
        'TODO: reset datagrid
        dgvStudents.DataSource = tmpDS.Tables(0).DefaultView
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
        tmpDV = Me.dgvStudents.DataSource 'TODO: causes error if dirty
        tmpDT = tmpDV.ToTable()


        snRow = 0


        Dim dictColHeaders As New Dictionary(Of Integer, String)
        '# display header rows
        colCount = dgvStudents.Columns.Count
        '#change column names to match header text
        Try

            For j = 0 To colCount - 1
                dgvStudents.Columns(j).Name = dgvStudents.Rows(snRow).Cells(j).Value.ToString
                dgvStudents.Columns(j).HeaderText = dgvStudents.Item(j, snRow).Value.ToString
                tmpDT.Columns(j).ColumnName = dgvStudents.Item(j, snRow).Value.ToString
            Next


            'delete header row
            tmpDT.Rows(0).Delete()
            tmpDT.AcceptChanges()


            rowCount = tmpDT.Rows.Count
            For i = 0 To rowCount - 1
                'check for empty rows
                If Trim(tmpDT.Rows(i).Item("matno").ToString) = "" And i > snRow Then
                    emptyRow = i
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

            dgvStudents.DataSource = tmpDT
            dgvStudents.Refresh()
        Catch ex As Exception
            MessageBox.Show("Students data is not in the correct format, please correct ant try again")
            logError(ex.ToString)
            Exit Sub
        End Try
    End Sub




    Private Sub ButtonDownloadTemplate_Click(sender As Object, e As EventArgs) Handles ButtonDownloadTemplate.Click
        Try

            'objResult.resultTemplateFileName
            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                My.Computer.FileSystem.CopyFile(My.Application.Info.DirectoryPath & "\templates\students.xltx", SaveFileDialog1.FileName & ".xltx")
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
            TextBoxSurname.DataBindings.Add("Text", BindingSource1, "student_surname")
            TextBoxFirstName.DataBindings.Add("Text", BindingSource1, "student_firstname")
            TextBoxOtherNames.DataBindings.Add("Text", BindingSource1, "student_othernames")
            'TextBoxDept.DataBindings.Add("Text", ds.Tables(0), "student_dept_idr")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ButtonClose.PerformClick()
    End Sub

    Private Sub ButtonViewMode_Click(sender As Object, e As EventArgs) Handles ButtonViewMode.Click
        If PanelForm.Visible = False Then
            PanelForm.Visible = True
            dgvStudents.Visible = False
            ButtonViewMode.Text = "Grid View"
        Else

            PanelForm.Visible = False
            dgvStudents.Visible = True
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
        strSQL = STR_SQL_INSERT_STUDENTS

        '#method 1 - creates table and inserts
        Dim dt As New DataTable
        Dim dv As New DataView
        'Dim dv As DataView
        Try
            'NOtE. journey 1. tmpDS.Tables(0).DefaultView 2. tmpDT =tmpDV.ToTable  dt=datagrid.source
            dgvStudents.EndEdit()
            dgvStudents.Update()
            If Not ((IsDBNull(dgvStudents.DataSource) Or (dgvStudents.Rows.Count = 0))) Then
                dgvStudents.DataSource.AcceptChanges 'TODO: dataTable or dataView? lazy loading issues
                If dgvStudents.DataSource.GetType Is dv.GetType Then
                    dv = dgvStudents.DataSource
                    dt = dv.ToTable
                Else
                    dt = dgvStudents.DataSource
                End If

            Else
                MsgBox("Empty Result")
                Exit Sub
            End If

            'mappDB.genericManualInsertDB(dt, strSQL, {})
            importRegUsingdataAdapter(dt)

            MsgBox("Students Uploaded into Database Successfully! Cross check what was uploaded below")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub importRegUsingdataAdapter(dt As DataTable)
        Try
            Dim strSQL As String

            Dim dtSource As DataTable
            Dim dtDestination As New DataTable
            Dim dSFtomDB As New DataSet ' = dv.ToTable
            dtSource = dt

            'createBroadsheetTables()
            strSQL = "SELECT * FROM Reg" ' WHERE session_idr={1}"

            Using xconn As New OleDb.OleDbConnection(ModuleGeneral.STR_connectionString32)
                xconn.ConnectionString = mappDB.getCorrectConnectionstring()
                xconn.Open()
                Dim adapter As New OleDb.OleDbDataAdapter(strSQL, xconn)
                Dim builder As New OleDb.OleDbCommandBuilder(adapter)       'easy way for single table
                adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey

                'adapter.UpdateCommand = ""
                'adapter.InsertCommand = ""
                '1. fill it
                adapter.Fill(dSFtomDB)
                '2. put it in a datagrid view and all the manipulations can happen there, afterwards an update is used to save in database
                dgvStudents.DataSource = dSFtomDB.Tables(0).DefaultView
                'MsgBox("After fresh fill")

                dSFtomDB.Tables(0).Clear()  'empty table
                adapter.Update(dSFtomDB)    'persist in db
                Dim dRow As DataRow
                'MsgBox("After empty db")
                '3. edit it
                For i = 0 To dtSource.Rows.Count - 1
                    dRow = dSFtomDB.Tables(0).Rows.Add("MOCK00" & i.ToString) 'add mock row
                    For j = 0 To dSFtomDB.Tables(0).Columns.Count - 1       'Take as much as we have cols for to avoid errors
                        If j > dtSource.Columns.Count - 1 Then Exit For
                        dSFtomDB.Tables(0).Rows(i).Item(j) = dtSource.Rows(i).Item(j)   'update the row with data
                        'strColNames = strColNames & "," & dtSource.Columns(j).ColumnName
                    Next
                Next

                '4. load the mock data it in another datagridview
                dgvStudents.DataSource = dSFtomDB.Tables(0).DefaultView
                'MsgBox("After add to datatable")

                '5. use datagridview tecnique to capture it as edited
                dgvStudents.Refresh()
                dgvStudents.EndEdit()
                ' MsgBox("After refresh")

                '6. save the underlying data (change from mock to real) to database (works bcos of datagridview technique)
                adapter.Update(dSFtomDB) 'save
            End Using
        Catch ex As Exception
            MsgBox("Error occured, see log for details" & vbCrLf & ex.Message)
            logError(ex.ToString)
        End Try
    End Sub

    Private Sub ButtonAutoReg_Click(sender As Object, e As EventArgs) Handles ButtonAutoReg.Click
        'TODO": if .. then msg already registered
        'insert into reg and regs
        'get courses fom course order
        Dim txtCourses_1, txtCourses_2 As String
        Dim dLevel, dSession, dDeptID As String
        dLevel = dgvStudents.Rows(0).Cells("level").Value
        dSession = dgvStudents.Rows(0).Cells("session_idr").Value
        dDeptID = dgvStudents.Rows(0).Cells("student_dept_idr").Value

        'todo: use course order ds or dict to auto register
        If Not dictCoursesOrderFS.Count > 0 Then
            getCoursesOrderIntoDictionaries(dSession, dDeptID, dLevel)
        End If

        If dictCoursesOrderFS.Count > 0 Then
            For Each cVal In dictCoursesOrderFS.Values
                If txtCourses_1 = "" Then
                    txtCourses_1 = cVal
                Else
                    txtCourses_1 = txtCourses_1 & ";" & txtCourses_1 & cVal
                End If
            Next
        End If
        If dictCoursesOrderFS.Count > 0 Then
            For Each cVal In dictCoursesOrderSS.Keys
                If txtCourses_2 = "" Then
                    txtCourses_2 = cVal
                Else
                    txtCourses_2 = txtCourses_2 & ";" & txtCourses_2 & cVal
                End If
            Next
        End If

        Dim dv As DataView
        Dim dt As DataTable
        dv = dgvStudents.DataSource
        dt = dv.ToTable()

        For i = 0 To dt.Rows.Count - 1
            dt.Rows(i).Item("CourseCode_1") = txtCourses_1
            dt.Rows(i).Item("CourseCode_1") = txtCourses_2

        Next

        dgvStudents.DataSource = dt.DefaultView
    End Sub
End Class