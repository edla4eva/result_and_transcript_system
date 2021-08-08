Imports MySql.Data.MySqlClient
Public Class FormBills
    Dim con As MySqlConnection
    Dim cmd As MySqlCommand
    Dim strSQL As String
    Dim strConnectionString As String

    Private Sub FormBar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case Me.Tag.ToString
            Case "Bar"
                Me.PictureBoxImg.Image = eAccount.My.Resources.Resources.bar
            Case "Resturant"
                Me.PictureBoxImg.Image = eAccount.My.Resources.Resources.bar
            Case "Pool"
                Me.PictureBoxImg.Image = eAccount.My.Resources.Resources.pool
            Case "Front"
                Me.PictureBoxImg.Image = eAccount.My.Resources.Resources.front
        End Select

        Me.MdiParent = MDIParentMain
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ButtonRoom1_Click(sender As Object, e As EventArgs) Handles ButtonRoom1.Click

        'FormGuests.ShowDialog()
        FormGuests.Show()
        TextBoxGuestID.Text = mappDB.GuestID.ToString
        Me.reset()
    End Sub

    Private Sub FormBar_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        TextBoxGuestID.Text = mappDB.GuestID.ToString
        '    Dim STR_SQL_ALL_GUESTS_BILLS_WHERE As String = "SELECT `guest_account_id`, `guest_id_ref`, `date`, `details`, `debit`, `credit`, `balance`, `ref` FROM `guest_account` WHERE guest_id_ref='{0}' order by date"
        ' Dim STR_SQL_INSERT_BILL As String = "INSERT INTO `crimpsof_ehotel`.`guest_account` (`guest_account_id`, `guest_id_ref`, `date`, `details`, `debit`, `credit`, `balance`, `ref`) VALUES ('', '1', '2018-03-16 00:00:00', '2 No Bottles of Fanta', '0', '300', '', '12344');"
        'Dim STR_SQL_INSERT_BILL As String = "INSERT INTO `crimpsof_ehotel`.`guest_account` (`guest_account_id`, `guest_id_ref`, `date`, `details`, `debit`, `credit`, `balance`, `ref`) VALUES ('', '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');"
        Me.reset()
    End Sub
    Private Sub reset()
        GetDataWhere(String.Format(STR_SQL_ALL_GUESTS_BILLS_WHERE, mappDB.GuestID.ToString))
        TextBoxGuestID.Text = GetRecordWhere(String.Format(STR_SQL_ALL_GUESTS_WHERE, mappDB.GuestID.ToString))

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
            myDA.Fill(myDataSet, "Guest")
            dgw.DataSource = myDataSet.Tables("Guest").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
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
    Public Function UpdateRecordWhere(s As String) As String
        Dim returnVal As String = ""
        Try
            strConnectionString = mappDB.getConnectionString(False)
            con = New MySql.Data.MySqlClient.MySqlConnection(strConnectionString)
            con.Open()
            strSQL = s
            cmd = New MySql.Data.MySqlClient.MySqlCommand(strSQL, con)
            cmd.BeginExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return returnVal
    End Function
    Private Sub ButtonAddBill_Click(sender As Object, e As EventArgs) Handles ButtonAddBill.Click
        'update
        Dim str As String
        Dim p0, p1, p2, p3, p4, p5, p6 As String
        p0 = Me.TextBoxGuestID.Text
        p1 = Me.TextBoxDate.Text
        p2 = Me.TextBoxDetails.Text
        p3 = Me.TextBoxDebit.Text
        p4 = Me.TextBoxCredit.Text
        p5 = Me.TextBoxBalance.Text
        p6 = Me.TextBoxRef.Text
        str = String.Format(STR_SQL_INSERT_BILL, p0, p1, p2, p3, p4, p5, p6)
        UpdateRecordWhere(str)
        MsgBox("Bill Addedd!")
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        TextBoxDate.Text = Me.DateTimePicker1.Value.ToShortDateString
    End Sub

    Private Sub ButtonGenerateBill_Click(sender As Object, e As EventArgs) Handles ButtonGenerateBill.Click
        Me.reset()
    End Sub

    Private Sub ButtonCalc_Click(sender As Object, e As EventArgs) Handles ButtonCalc.Click
        'get the exact booking
        'STR_SQL_GET_BOOKING_FOR_BILL=
        'SELECT `booking_id`, `booking_description`, `booking_type`, `deposited_amount`,
        '`total_amount`, `balance_amount`, `booking_date`, `booking_time`, 
        '`booking_method`, `staff_id_ref`, `room_id_ref`, `booking_status`, 
        '`start_date`, `end_date`, `guest_id_ref` FROM `bookings` WHERE 
        '(guest_id_ref=1 AND (booking_status='occupied' OR booking_status='booked'))
        Me.TextBoxGuestInfo.Text = "Guest Details: "

        '2. get the room rate
        'STR_SQL_GET_ROOM_FOR_BILL As String = 
        '"SELECT `room_id`, `room_name`, `room_description`, `room_cost`, 
        '`room_min_deposit`, `suit_id_ref`, `room_status`, `is_room_occupied`, 
        '`is_room_booked`, `is_room_paid_for`, `room_image` FROM rooms 
        'WHERE   room_id = '{0}'"
        Dim row, rows() As String
        Dim tmpRoomID As Integer = 1
        Dim tmpRoomCost As Double = 0
        Dim tmpSumRoomCost As Double = 0
        For Each row In row
            'room_id=
            String.Format(STR_SQL_GET_ROOM_FOR_BILL, tmpRoomID.ToString)
            'get room_cost
            'tmpRoomCost=
            tmpSumRoomCost = tmpSumRoomCost + tmpRoomCost
        Next
    End Sub

    Private Sub ButtonPayBill_Click(sender As Object, e As EventArgs) Handles ButtonPayBill.Click
        'TODO:
        'Update guest_account table to reflect bills have been paid
        'bill_status=paid

        MsgBox("Bill payment Acknowledged by you")
        log(Now.ToShortDateString & "," & Now.ToShortTimeString & "," & mappDB.UserName & "Bill payment Acknowledged for" & mappDB.GuestID)

    End Sub

    Private Sub ButtonPrintBill_Click(sender As Object, e As EventArgs) Handles ButtonPrintBill.Click
        FormPrintBill.showdialog

    End Sub
End Class