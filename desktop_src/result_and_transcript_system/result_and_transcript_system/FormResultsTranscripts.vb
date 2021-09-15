Imports MySql.Data.MySqlClient
Public Class FormResultsTranscripts
    Dim con As MySqlConnection
    Dim cmd As MySqlCommand
    Dim conLocal As OleDb.OleDbConnection
    Dim cmdLocal As OleDb.OleDbCommand
    Dim strSQL As String
    Dim strConnectionString As String

    Private Sub FormResultsTranscript_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub reset()
        mappDB.MATNO = "ENG1234567" 'TODO Test
        'GetDataWhere(String.Format(STR_SQL_ALL_RESULTS_WHERE, mappDB.StaffID.ToString))
        TextBoxGuestID.Text = mappDB.GetRecordWhere(String.Format(STR_SQL_ALL_RESULTS_WHERE, mappDB.MATNO.ToString))
        mappDB.GetDataWhere(String.Format(STR_SQL_ALL_RESULTS_WHERE, mappDB.MATNO.ToString))
    End Sub

    Private Sub ButtonAddResult_Click(sender As Object, e As EventArgs) Handles ButtonAddResult.Click
        'update
        Dim str As String
        Dim p0, p1, p2, p3, p4, p5, p6 As String
        p0 = Me.TextBoxGuestID.Text
        p1 = Me.TextBoxDate.Text

        str = String.Format(STR_SQL_INSERT_RESULTS, p0, p1) ', p2, p3, p4, p5, p6
        mappDB.UpdateRecordWhere(str)
        MsgBox("Result Addedd!")
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        TextBoxDate.Text = Me.DateTimePicker1.Value.ToShortDateString
    End Sub


    Private Sub ButtonCalcGPA_Click(sender As Object, e As EventArgs) Handles ButtonCalcGPA.Click

        Me.TextBoxGuestInfo.Text = "TODO Details: "

        'Dim row, rows() As String
        'Dim tmpRoomID As Integer = 1
        'Dim tmpRoomCost As Double = 0
        'Dim tmpSumRoomCost As Double = 0
        'For Each row In rows
        '    'room_id=
        '    'String.Format(STR_SQL_GET_ROOM_FOR_BILL, tmpRoomID.ToString)
        '    'get room_cost
        '    'tmpRoomCost=
        '    'tmpSumRoomCost = tmpSumRoomCost + tmpRoomCost
        'Next
    End Sub


    Private Sub ButtonCheck_Click(sender As Object, e As EventArgs) Handles ButtonCheck.Click
        Me.reset()
    End Sub

    Private Sub ButtonTranscript_Click(sender As Object, e As EventArgs) Handles ButtonTranscript.Click
        Dim myDataset As DataSet
        mappDB.MATNO = "ENG1234567" 'TODO Test
        myDataset = mappDB.GetDataWhere(String.Format(STR_SQL_ALL_RESULTS_WHERE, mappDB.MATNO.ToString), "Result")
        dgw.DataSource = myDataset.Tables("Result").DefaultView
        myDataset.Clear()
        myDataset = Nothing
    End Sub

    Private Sub FormResultsTranscripts_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MainForm.doCloseForm()

    End Sub
End Class