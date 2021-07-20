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
        ' mappDB.MATNO = "ENG1234567" 'TODO Test
        'GetDataWhere(String.Format(STR_SQL_ALL_RESULTS_WHERE, mappDB.StaffID.ToString))

        mappDB.GetDataWhere(String.Format(STR_SQL_ALL_RESULTS_WHERE, mappDB.MATNO.ToString))

        mappDB.GetDataWhere(String.Format(STR_SQL_ALL_RESULTS_WHERE, mappDB.MATNO.ToString))
    End Sub

    Private Sub ButtonAddResult_Click(sender As Object, e As EventArgs)
        'update
        Dim str As String
        Dim p0, p1, p2, p3, p4, p5, p6 As String
        p0 = Me.TextBoxMATNO.Text
        p1 = Me.TextBoxDate.Text

        str = String.Format(STR_SQL_INSERT_RESULTS, p0, p1) ', p2, p3, p4, p5, p6
        mappDB.UpdateRecordWhere(str)
        MsgBox("Result Addedd!")
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        TextBoxDate.Text = Me.DateTimePicker1.Value.ToShortDateString
    End Sub





    Private Sub ButtonCheck_Click(sender As Object, e As EventArgs) Handles ButtonCheck.Click
        Me.reset()
    End Sub



    Private Sub FormResultsTranscripts_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MainForm.doCloseForm()

    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub ButtonTranscript_Click_1(sender As Object, e As EventArgs) Handles ButtonTranscript.Click
        Dim myDataset As DataSet
        mappDB.MATNO = TextBoxMATNO.Text
        'todo query broadsheets or transcript table
        myDataset = mappDB.GetDataWhere(String.Format(SQL_SELECT_RESULTS_WHERE_MATNO, mappDB.MATNO.ToString), "Result")
        dgw.DataSource = myDataset.Tables("Result").DefaultView

    End Sub
End Class