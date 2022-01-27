Imports System.ComponentModel

Public Class FormCourseAdviser
    Dim dCountResult1, dCountResult2, dCountBS1, dCountBS2, dCountReg, dCountStudents, dCountSenate As Integer
    Private Sub FormCourseAdviser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.BackColor = RGBColors.colorBackground
            Me.ForeColor = RGBColors.colorForeground
        Catch ex As Exception
            logError(ex.ToString)
            MsgBox("Oops! Something went wrong, see log for details")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonResultsSubmitted.Click
        Try
            ButtonResults.PerformClick()
        Catch ex As Exception
        logError(ex.ToString)
        MsgBox("Oops! Something went wrong, see log for details")
        End Try
    End Sub

    Private Sub ButtonBrowse_Click(sender As Object, e As EventArgs) Handles ButtonBroadsheets.Click
        Try
            MainForm.ChangeMenu("viewBroadsheets")
        Catch ex As Exception
            logError(ex.ToString)
        MsgBox("Oops! Something went wrong, see log for details")
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ButtonStudents.Click
        Try
            MainForm.ChangeMenu("viewRegs")
        Catch ex As Exception
        logError(ex.ToString)
        MsgBox("Oops! Something went wrong, see log for details")
        End Try
    End Sub

    Private Sub ButtonResultList_Click(sender As Object, e As EventArgs) Handles ButtonResultList.Click
        Try
            MainForm.ChangeMenu("ResultsTranscripts")
        Catch ex As Exception
        logError(ex.ToString)
        MsgBox("Oops! Something went wrong, see log for details")
        End Try
    End Sub

    Private Sub ButtonUpload_Click(sender As Object, e As EventArgs) Handles ButtonUpload.Click
        Try
            MainForm.ChangeMenu("UploadResult")
        Catch ex As Exception
        logError(ex.ToString)
        MsgBox("Oops! Something went wrong, see log for details")
        End Try
    End Sub


    Private Sub ButtonResults_Click(sender As Object, e As EventArgs) Handles ButtonResults.Click
        Try
            MainForm.ChangeMenu("ViewResults")
        Catch ex As Exception
            logError(ex.ToString)
            MsgBox("Oops! Something went wrong, see log for details")
        End Try
    End Sub

    Private Sub ButtonGenerateBroadsheet_Click(sender As Object, e As EventArgs) Handles ButtonGenerateBroadsheet.Click
        Try
            MainForm.ChangeMenu("GenerateBroadsheet")
        Catch ex As Exception
            logError(ex.ToString)
            MsgBox("Oops! Something went wrong, see log for details")
        End Try
    End Sub

    Private Sub FormCourseAdviser_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'TODO: Update dashboard
        Try
            BackgroundWorker1.RunWorkerAsync()
        Catch ex As Exception
            logError(ex.ToString)
        MsgBox("Oops! Something went wrong, see log for details")
        End Try
    End Sub


    Private Sub ButtonNoOfStudents_Click(sender As Object, e As EventArgs) Handles ButtonNoOfStudents.Click
        Try
            MainForm.ChangeMenu("students")
        Catch ex As Exception
            logError(ex.ToString)
        MsgBox("Oops! Something went wrong, see log for details")
        End Try
    End Sub

    Private Sub ButtonSenate_Click(sender As Object, e As EventArgs) Handles ButtonSenate.Click
        Try
            MainForm.ChangeMenu("viewSenate")
        Catch ex As Exception
            logError(ex.ToString)
            MsgBox("Oops! Something went wrong, see log for details")
        End Try
    End Sub

    Private Sub ButtonCourseMarkSheet_Click(sender As Object, e As EventArgs) Handles ButtonCourseMarkSheet.Click
        Try
            MainForm.ChangeMenu("CourseMarkSheets")
        Catch ex As Exception
            logError(ex.ToString)
            MsgBox("Oops! Something went wrong, see log for details")
        End Try
    End Sub

    Private Sub ButtonCoursereg_Click(sender As Object, e As EventArgs) Handles ButtonCoursereg.Click
        Try
            MainForm.ChangeMenu("StudentsRegistration")
        Catch ex As Exception
            logError(ex.ToString)
        MsgBox("Oops! Something went wrong, see log for details")
        End Try
    End Sub

    Private Sub ButtonNoOfBroadsheets_Click(sender As Object, e As EventArgs) Handles ButtonNoOfBroadsheets.Click
        ButtonBroadsheets.PerformClick()
    End Sub

    Private Sub FormCourseAdviser_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Try
            MainForm.doCloseForm()
        Catch ex As Exception
            logError(ex.ToString)
        MsgBox("Oops! Something went wrong, see log for details")
        End Try
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            updateDashBoard()
        Catch ex As Exception
        logError(ex.ToString)
        MsgBox("Oops! Something went wrong, see log for details")
        End Try
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Try
            ButtonResultsSubmitted.Text = dCountResult1.ToString & "/" & dCountResult2.ToString
            ButtonNoOfStudents.Text = dCountReg.ToString
            ButtonNoOfBroadsheets.Text = dCountBS1.ToString
        Catch ex As Exception
            logError(ex.ToString)
            MsgBox("Oops! Something went wrong, see log for details")
        End Try
    End Sub
    Sub updateDashBoard()
        On Error Resume Next
        Dim tmpDS As DataSet
        'dCountResult1, dCountResult2, dCountBS1, dCountBS2, dCountStudents,dCountSenate

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

    End Sub
End Class
