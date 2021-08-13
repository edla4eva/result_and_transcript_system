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
            Dim dMATNO, dScore, strSQL As String
            Dim colMATNO, colScore As Integer
            'get headers
            'if checkBox custom then
            'colMATNO = comboMat.selectedindex
            'colScore = comboScore.selectedindex
            ' else
            '|-|sn|matno|name|ca|exam|score|
            colMATNO = 1
            colScore = 6

            strSQL = SQL_SELECT_ALL_RESULTS_WHERE_MATNO '"INSERT INTO TableResults"
            mappDB.InsertRecord(STR_SQL_INSERT_RESULTS)
            For x = 0 To DataGridView1.Rows.GetRowCount(DataGridViewElementStates.Displayed)
                dMATNO = CStr(DataGridView1.Rows(x).Cells(colMATNO).Value) 'CInt(dgw.SelectedRows(0).Cells("semester").Value)
                dScore = CStr(DataGridView1.Rows(x).Cells(colScore).Value) 'CInt(dgw.SelectedRows(0).Cells("semester").Value)


                'Dim p0, p1, p2, p3, p4, p5, p6, p7, p8, p9 As String
                'INSERT INTO `products` (`productCode`, `productName`, `productLine`, `productScale`,
                '`productVendor`, `productDescription`, `quantityInStock`, `buyPrice`, `MSRP`,
                '`is_product_sold_out`) VALUES ('R012', 'Resistor 4.8 KOhm', 'Resistors', '1:7',
                ''Analog Devices', 'Resistor 4.8 KOhm', '200', '100', '20', 'almost');
                'p0 = Me.ProductCodeTextBox.Text
                'p1 = Me.ProductNameTextBox.Text
                'p2 = Me.cmbProductLine.Text
                'p3 = Me.ProductScaleTextBox.Text
                'p4 = Me.ProductVendortTextBox.Text
                'p5 = Me.ProductdescriptionTextBox.Text
                'p6 = Me.QtyTextBox1.Text
                'p7 = Me.PriceTextBox2.Text
                'p8 = Me.MSRP_Textbox.Text
                'p9 = Me.Is_SoldTextBox.Text

                strSQL = String.Format(STR_SQL_INSERT_RESULTS, dMATNO, dScore) ', p2, p3, p4, p5, p6, p7, p8, p9)

                'strSQL=strSQL& "VALUES (...)" 'TODO
                mappDB.UpdateRecordWhere(strSQL)


            Next
            MsgBox("ProdResultsuct Added Successfully!")


            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ButtonPreview_Click(sender As Object, e As EventArgs) Handles ButtonPreview.Click

        ' objResult.resultFilename = My.Application.Info.DirectoryPath & "\samples\result.xlsx"
        objResult.excelVersion = "2013"
        Dim tmpDS As DataSet = objExcelFile.readResultFile()
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

    Private Sub ButtonResultList_Click(sender As Object, e As EventArgs) Handles ButtonResultList.Click
        Dim myDataSet As DataSet = objResult.getFromDBResultssDataset
        DataGridView1.DataSource = myDataSet.Tables("TableResults").DefaultView
    End Sub

    Private Sub ButtonCheck_Click(sender As Object, e As EventArgs) Handles ButtonCheck.Click

        Dim tmpDV As DataView
        Dim tmpDT As DataTable
        Dim snRow As Integer
        tmpDv = Me.DataGridView1.DataSource
        tmpDT = tmpDV.ToTable()
        'tmpDS.Tables(0).Rows(0).Delete()
        ' tmpDS.Tables(0).Rows(1).Delete()
        For i = 0 To tmpDT.Rows.Count - 1
            If tmpDT.Rows(i).ItemArray().Contains("S/N") Or tmpDT.Rows(i).ItemArray().Contains("MAT") Then
                MsgBox("ColumnHeader at row: " & i)
                TextBoxDepartment.Text = tmpDT.Rows(0).Item(0).ToString
                ' Label10.Text = tmpDS.Tables(0).Rows(0).Item(0)
                snRow = i
                Exit For
            End If
        Next
        'For i = 0 To DataGridView1.Rows.Count - 1
        '    If DataGridView1.Item(0, i).Value.ToString.Contains("S/N") Or DataGridView1.Item(0, i).Value.ToString.Contains("MAT") Then
        '        MsgBox("ColumnHeader at row: " & i)
        '        TextBoxDepartment.Text = DataGridView1.Item(1, 0).Value.ToString
        '        ' Label10.Text = tmpDS.Tables(0).Rows(0).Item(0)
        '        snRow = i
        '        Exit For
        '    End If
        'Next

        DataGridView1.Columns(0).HeaderText = DataGridView1.Item(0, snRow).Value.ToString
        DataGridView1.Columns(1).HeaderText = DataGridView1.Item(1, snRow).Value.ToString
        DataGridView1.Columns(2).HeaderText = DataGridView1.Item(2, snRow).Value.ToString
        DataGridView1.Columns(3).HeaderText = DataGridView1.Item(3, snRow).Value.ToString

        'todo delete data cols
        'tmpDT.Columns(0).delete


        'delete rows
        For j = 0 To snRow
            tmpDT.Rows(0).Delete()

        Next

        'TODO copy useful cols and rows into new data table
        tmpDT.Columns.RemoveAt(0)
        'Dim newDT As New DataTable
        'newDT.Columns.Add(tmpDT.Columns(1))
        'newDT.Columns.Add(tmpDT.Columns(2))
        'newDT.Rows.Add(tmpDT.Rows())

        'display
        Me.TextBoxPrefix.Text = tmpDT.Rows(0).Item(2).ToString
        DataGridView1.DataSource = tmpDT
        DataGridView1.Refresh()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_SizeChanged(sender As Object, e As EventArgs) Handles DataGridView1.SizeChanged

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
    End Sub
End Class
