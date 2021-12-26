Imports System.ComponentModel

Public Class FormCourseAdviser
    Dim dCountResult1, dCountResult2, dCountBS1, dCountBS2, dCountReg, dCountStudents, dCountSenate As Integer
    Private Sub FormCourseAdviser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = RGBColors.colorBackground
        Me.ForeColor = RGBColors.colorForeground
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonResultsSubmitted.Click
        ButtonResults.PerformClick()
    End Sub

    Private Sub ButtonBrowse_Click(sender As Object, e As EventArgs) Handles ButtonBroadsheets.Click
        MainForm.ChangeMenu("viewBroadsheets")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ButtonStudents.Click
        MainForm.ChangeMenu("viewRegs")
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
        BackgroundWorker1.RunWorkerAsync()
    End Sub


    Private Sub ButtonNoOfStudents_Click(sender As Object, e As EventArgs) Handles ButtonNoOfStudents.Click
        MainForm.ChangeMenu("students")
    End Sub

    Private Sub ButtonSenate_Click(sender As Object, e As EventArgs) Handles ButtonSenate.Click
      
        MainForm.ChangeMenu("viewSenate")
    End Sub

    Private Sub ButtonCoursereg_Click(sender As Object, e As EventArgs) Handles ButtonCoursereg.Click
        MainForm.ChangeMenu("StudentsRegistration")
    End Sub

    Private Sub ButtonNoOfBroadsheets_Click(sender As Object, e As EventArgs) Handles ButtonNoOfBroadsheets.Click
        ButtonBroadsheets.PerformClick()
    End Sub

    Private Sub FormCourseAdviser_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MainForm.doCloseForm()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        updateDashBoard()
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        ButtonResultsSubmitted.Text = dCountResult1.ToString & "/" & dCountResult2.ToString
        ButtonNoOfStudents.Text = dCountReg.ToString & "/" & dCountStudents.ToString
        ButtonNoOfBroadsheets.Text = dCountBS1.ToString

    End Sub
    Sub updateDashBoard()
        On Error Resume Next
        Dim tmpDS As DataSet
        'dCountResult1, dCountResult2, dCountBS1, dCountBS2, dCountStudents,dCountSenate
        'ButtonResultsSubmitted.Text = "#/##"
        'Debug.Print(STR_SQL_ALL_RESULTS_SUMMARY)
        tmpDS = mappDB.GetDataWhere(STR_SQL_ALL_RESULTS_SUMMARY)

        dCountResult1 = tmpDS.Tables(0).Rows.Count


        tmpDS = mappDB.GetDataWhere(STR_SQL_ALL_COURSES)
        dCountResult2 = tmpDS.Tables(0).Rows.Count
        tmpDS = mappDB.GetDataWhere(String.Format(STR_SQL_ALL_REG_COUNT, objBroadsheet.Session, objBroadsheet.DeptId))
        dCountReg = CInt(tmpDS.Tables(0).Rows(0).Item(0).ToString)

        tmpDS = mappDB.GetDataWhere(STR_SQL_ALL_STUDENTS_COUNT)
        dCountStudents = CInt(tmpDS.Tables(0).Rows(0).Item(0).ToString)

        tmpDS = mappDB.GetDataWhere(STR_SQL_ALL_BROADSHEETS_SUMMARY)
        dCountBS1 = tmpDS.Tables(0).Rows.Count

        'tmpDS = mappDB.GetDataWhere(STR_SQL_ALL_DEPARTMENTS_COMBO)
        'dCountBS2 = tmpDS.Tables(0).Rows.Count * 5

        'getrecordwhere("select count(matno) as countMat from reg")
        'TODO: Fetch from Database
        'count of broadsheets
    End Sub
End Class
