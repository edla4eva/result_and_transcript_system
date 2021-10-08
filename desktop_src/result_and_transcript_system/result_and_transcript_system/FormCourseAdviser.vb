Public Class FormCourseAdviser
    Private Sub FormCourseAdviser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = RGBColors.colorBlack2
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonResultsSubmitted.Click
        ButtonResults.PerformClick()
    End Sub

    Private Sub ButtonBrowse_Click(sender As Object, e As EventArgs) Handles ButtonBroadsheets.Click
        MainForm.ChangeMenu("viewBroadsheets")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ButtonStudents.Click
        MainForm.ChangeMenu("StudentsRegistration")
    End Sub

    Private Sub ButtonResultList_Click(sender As Object, e As EventArgs) Handles ButtonResultList.Click
        MainForm.ChangeMenu("ResultsTranscripts")
    End Sub

    Private Sub ButtonUpload_Click(sender As Object, e As EventArgs) Handles ButtonUpload.Click
        MainForm.ChangeMenu("UploadResult")
    End Sub


    Private Sub ButtonResults_Click(sender As Object, e As EventArgs) Handles ButtonResults.Click
        MainForm.ChangeMenu("ViewResults")
    End Sub

    Private Sub ButtonGenerateBroadsheet_Click(sender As Object, e As EventArgs) Handles ButtonGenerateBroadsheet.Click
        MainForm.ChangeMenu("GenerateBroadsheet")
    End Sub

    Private Sub FormCourseAdviser_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'TODO: Update dashboard
        updateDashboard
    End Sub
    Sub updateDashBoard()
        ButtonResultsSubmitted.Text = "4/32"
        'TODO: Fetch from Database
        'count of broadsheets
    End Sub

    Private Sub ButtonNoOfStudents_Click(sender As Object, e As EventArgs) Handles ButtonNoOfStudents.Click
        ButtonStudents.PerformClick()
    End Sub

    Private Sub ButtonNoOfBroadsheets_Click(sender As Object, e As EventArgs) Handles ButtonNoOfBroadsheets.Click
        ButtonBroadsheets.PerformClick()
    End Sub

    Private Sub FormCourseAdviser_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MainForm.doCloseForm()
    End Sub
End Class
