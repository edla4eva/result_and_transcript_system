Imports MySql.Data.MySqlClient
Public Class FormProducts
    Dim con As MySql.Data.MySqlClient.MySqlConnection
    Dim cmd As MySql.Data.MySqlClient.MySqlCommand
    Dim strSQL As String
    Dim strConnectionString As String
    Dim ref As Integer

    Private Sub FormRooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = MDIParentMain
        Me.WindowState = FormWindowState.Maximized
        Me.Reset()

        'resize cols
        For Each col As DataGridViewColumn In dgw.Columns
            col.Width = 50
            If col.HeaderText = "productName" Then
                col.Width = 100
            ElseIf col.HeaderText = "productDescription" Then
                col.Width = 150
            ElseIf col.HeaderText = "buyPrice" Then
                col.Width = 100
            End If
        Next


    End Sub
    Sub Reset()
        txtGuestName.Text = ""
        ref = CInt(CLng(Now.ToOADate * 200) + 100)
        mappDB.ref = ref
        mappDB.rDate = FormatMyDate(Now) & " " & FormatMyTime(Now)  'Now.ToShortDateString & " " & Now.ToShortTimeString
        GetData()
    End Sub
    Public Sub GetData()
        Try
            strConnectionString = mappDB.getConnectionString(False)
            con = New MySql.Data.MySqlClient.MySqlConnection(strConnectionString)
            con.Open()

            '--All rooms
            If mappDB.ProductLine = "" Then
                strSQL = SQL_SELECT_ROOMS
            Else
                strSQL = String.Format(SQL_SELECT_PRODUCTS_WHERE_PRODUCTLINE, mappDB.ProductLine)
            End If

            cmd = New MySql.Data.MySqlClient.MySqlCommand(strSQL, con)
            Dim myDA As MySqlDataAdapter = New MySqlDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Room")
            dgw.DataSource = myDataSet.Tables("Room").DefaultView

            '--Avaliable rooms
            'strSQL = SQL_SELECT_AVAILIABLE_ROOMS
            'cmd = New MySql.Data.MySqlClient.MySqlCommand(strSQL, con)
            'myDA = New MySqlDataAdapter(cmd)
            'myDataSet = New DataSet()
            'myDA.Fill(myDataSet, "Avaliable_Room")
            'dgv_rooms.DataSource = myDataSet.Tables("Avaliable_Room").DefaultView

            con.Close()

            UpdateSaleCart()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub GetBillsDataWhere(s As String)
        Try
            strConnectionString = mappDB.getConnectionString(False)
            con = New MySql.Data.MySqlClient.MySqlConnection(strConnectionString)
            con.Open()
            strSQL = s
            cmd = New MySql.Data.MySqlClient.MySqlCommand(strSQL, con)
            Dim myDA As MySqlDataAdapter = New MySqlDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Guest")
            dgv_rooms.DataSource = myDataSet.Tables("Guest").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub UpdateSaleCart()
        Try

            GetBillsDataWhere(String.Format(STR_SQL_CART_BILLS_WHERE, ref, mappDB.rDate))

            For Each col As DataGridViewColumn In dgv_rooms.Columns
                col.Width = 0
                col.Visible = False
                If col.HeaderText = "date" Then
                    col.Width = 70
                    col.Visible = True
                ElseIf col.HeaderText = "details" Then
                    col.Width = 130
                    col.Visible = True
                ElseIf col.HeaderText = "credit" Then
                    col.Width = 60
                    col.Visible = True
                ElseIf col.HeaderText = "ref" Then
                    col.Width = 50
                    col.Visible = True
                End If
            Next

            dgv_rooms.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub GetDataWhere(s As String)
        Try
            strConnectionString = mappDB.getConnectionString(False)
            con = New MySql.Data.MySqlClient.MySqlConnection(strConnectionString)
            con.Open()
            strSQL = s
            cmd = New MySql.Data.MySqlClient.MySqlCommand(strSQL, con)
            Dim myDA As MySqlDataAdapter = New MySqlDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Room")
            dgw.DataSource = myDataSet.Tables("Room").DefaultView       'all room
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub txtGuestName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGuestName.TextChanged

        strSQL = String.Format(SQL_SELECT_ROOMS_WHERE, txtGuestName.Text)
        GetDataWhere(strSQL)
    End Sub

    Private Sub dgw_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgw.CellContentClick
        updatePix()
    End Sub


    Private Sub dgw_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgw.RowsAdded

        For Each row As DataGridViewRow In Me.dgw.Rows

            If row.Cells.Item("is_product_sold_out").Value.ToString = "no" Then
                row.DefaultCellStyle.BackColor = Color.White
            ElseIf row.Cells.Item("is_product_sold_out").Value.ToString = "almost" Then
                row.DefaultCellStyle.BackColor = Color.Orange
            ElseIf row.Cells.Item("is_product_sold_out").Value.ToString = "yes" Then
                row.DefaultCellStyle.BackColor = Color.PaleVioletRed
            End If
        Next


    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Me.Reset()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub


    Private Sub ButtonSell_Click(sender As Object, e As EventArgs) Handles ButtonSell.Click
        ' Add to cartsell
        'If captured Then
        '    sell(True)
        'Else
        '    CaptureProduct()
        '    sell(False)
        'End If

        sell(False)
    End Sub
    Public Sub CaptureProduct()
        'get quantity first and subtract 1
        Dim qty As Integer = CInt(dgw.SelectedRows(0).Cells("quantityInStock").Value)
        Dim tmpProductCode As String = dgw.SelectedRows(0).Cells(0).Value.ToString
        Dim tmpPrice As Double = CInt(dgw.SelectedRows(0).Cells("buyPrice").Value)


        'Capture Product
        mappDB.ProductCode = tmpProductCode
        mappDB.ProductQty = qty
        Me.TextBoxDetails.Text = "1 No. of " & mappDB.ProductCode.ToString
        Me.TextBoxQty.Text = "1"
        Me.TextBoxUnitPrice.Text = tmpPrice.ToString
        Me.LabelRef.Text = ref.ToString
        Me.TextBoxCredit.Text = tmpPrice.ToString


    End Sub

    Public Sub sell(all As Boolean)
        Dim sDate, sQty, sDet, sCr, sDr, sBal, sRef, sStat As String

        sDet = Me.TextBoxDetails.Text
        sQty = Me.TextBoxQty.Text
        'sU = Me.TextBoxUnitPrice.Text '= tmpPrice.ToString
        sRef = Me.LabelRef.Text
        sCr = Me.TextBoxCredit.Text '= tmpPrice.ToString
        sDr = "0"
        sBal = "0"
        sDate = mappDB.rDate 'FormatMyDate(Now) & " " & FormatMyTime(Now) '' "2018-10-09 00:00:00"
        'sell
        UpdateRecordWhere(String.Format(SQL_UPDATE_PRODUCT, mappDB.ProductQty - CInt(sQty), mappDB.ProductCode))
        'insert into bills
        '(`guest_account_id`, `guest_id_ref`, `date`, `details`, `debit`, `credit`, `balance`, `ref`, `bill_status`) VALUES ('1', '1', '2018-10-09 00:00:00', '1 No of Resistor', '0', '2000', '2000', '55', 'paid');"
        InsertRecord(String.Format(SQL_INSERT_INTO_SALE_CART, sDate, sDet, sDr, sCr, sBal, sRef, "not paid"))
        MsgBox("Product " & mappDB.ProductCode.ToString & " Sold Successfully!, Enter the Sales Details")

        'refresh Datagrid
        UpdateSaleCart()

    End Sub
    Function FormatMyDate(dtp As Date) As String
        Dim StrDate As String = "00000000"
        'mySQL Palaver
        StrDate = dtp.Year.ToString("0000") & "-"
        StrDate = StrDate & dtp.Month.ToString("00") & "-"
        StrDate = StrDate & dtp.Day.ToString("00")
        Return StrDate
    End Function
    Function FormatMyTime(dtp As Date) As String
        Dim StrDate As String = "00000000"
        'mySQL Palaver
        StrDate = dtp.Hour.ToString("00")
        StrDate = StrDate & ":" & dtp.Minute.ToString("00")
        StrDate = StrDate & ":" & dtp.Second.ToString("00")
        Return StrDate
    End Function
    Public Sub updatePix()
        Try
            UpdateRecordWhere(String.Format(SQL_UPDATE_ROOMS, "booked", CInt(dgw.SelectedRows(0).Cells(6).Value) + 1))
            mappDB.ProductCode = CStr(dgw.SelectedRows(0).Cells(0).Value)
            'MsgBox(Application.StartupPath & "\images\")

            If My.Computer.FileSystem.FileExists(Application.StartupPath & "\images\" & mappDB.ProductCode & ".jpg") Then
                PictureBox1.Image = Image.FromFile(Application.StartupPath & "\images\" & mappDB.ProductCode & ".jpg")
            Else
                PictureBox1.Image = Image.FromFile(Application.StartupPath & "\images\" & "img.jpg")

            End If

        Catch ex As Exception

        End Try

    End Sub
    Public Function UpdateRecordWhere(s As String) As String
        Dim returnVal As String = ""
        Try
            strConnectionString = mappDB.getConnectionString(False)
            con = New MySql.Data.MySqlClient.MySqlConnection(strConnectionString)
            con.Open()
            strSQL = s
            cmd = New MySql.Data.MySqlClient.MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return returnVal
    End Function
    Public Function InsertRecord(s As String) As String
        Dim returnVal As String = ""
        Try
            strConnectionString = mappDB.getConnectionString(False)
            con = New MySql.Data.MySqlClient.MySqlConnection(strConnectionString)
            con.Open()
            strSQL = s
            cmd = New MySql.Data.MySqlClient.MySqlCommand(strSQL, con)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return returnVal
    End Function
    Public Function GetRecordWhere(s As String) As String
        Dim returnVal As String = ""
        Try
            strConnectionString = mappDB.getConnectionString(False)
            con = New MySql.Data.MySqlClient.MySqlConnection(strConnectionString)
            con.Open()
            strSQL = s
            cmd = New MySql.Data.MySqlClient.MySqlCommand(strSQL, con)
            Dim rd As MySqlDataReader

            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                returnVal = rd.GetString(0) & " " & rd.GetString(1)
                'TextBoxGuestInfo.Text = rd.GetString(0) & " " & rd.GetString(1)
            End If
            rd.Close()
            rd = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return returnVal
    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonCheckOut.Click
        FormBills.Show()
        FormBills.BringToFront()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        FormAddProduct.Show()
    End Sub



    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click

    End Sub

    Private Sub dgw_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgw.CellContentDoubleClick
        updatePix()
        CaptureProduct()
    End Sub

    Private Sub dgv_rooms_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_rooms.CellContentDoubleClick
        sell(False)

    End Sub

    Private Sub dgw_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgw.RowEnter
        'MsgBox(sender.ToString)
        updatePix()
    End Sub

    Private Sub TextBoxQty_TextChanged(sender As Object, e As EventArgs) Handles TextBoxQty.TextChanged
        On Error Resume Next
        If CInt(TextBoxQty.Text) > 0 Then computeAmount()
    End Sub
    Private Function computeAmount() As Boolean
        Try
            TextBoxCredit.Text = (CDbl(TextBoxQty.Text) * CDbl(TextBoxUnitPrice.Text)).ToString
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PictureBox2.Visible = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PictureBox2.Image = PictureBox1.Image

        PictureBox2.Visible = Not PictureBox2.Visible
    End Sub
End Class