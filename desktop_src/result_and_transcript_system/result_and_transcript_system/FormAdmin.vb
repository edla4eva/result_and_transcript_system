Public Class FormAdmin
    Private Sub FormCourseAdviser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.BackColor = RGBColors.colorBackground
            Me.ForeColor = RGBColors.colorForeground
            Me.BackColor = RGBColors.colorBackground
            Me.DataGridViewCoursesOrder.BackgroundColor = RGBColors.colorBackground
            Me.DataGridViewCoursesOrder.RowsDefaultCellStyle.BackColor = RGBColors.colorForeground
            Me.DataGridViewCoursesOrder.RowsDefaultCellStyle.ForeColor = RGBColors.colorBackground
            Me.DataGridViewCoursesOrder.BackgroundColor = RGBColors.colorBackground
            Me.DataGridViewCoursesOrder.RowsDefaultCellStyle.BackColor = RGBColors.colorForeground
            Me.DataGridViewCoursesOrder.RowsDefaultCellStyle.ForeColor = RGBColors.colorBackground

        Catch ex As Exception
            logError(ex.ToString)
            MsgBox("An error occured, see log for details")
        End Try
    End Sub

    Private Sub ButtonBrowse_Click(sender As Object, e As EventArgs) Handles ButtonBroadsheets.Click
        'Show Courses Order
        'Todo Move
        Dim strSQLCoursesOrder As String
        Dim coursesOrderDS As DataSet
        Try
            strSQLCoursesOrder = "SELECT * FROM Courses_order_new"  ' WHERE (session_idr='{0}' AND dept_idr={1}) ORDER BY sn;" 'and level
            'coursesOrderDS = mappDB.GetDataWhere(String.Format(strSQLCoursesOrder, "2018/2019", 1), "Courses")    'TODO Every inserts in courses_order table mus be 15*5 rows. sn can be used to order
            coursesOrderDS = mappDB.GetDataWhere(strSQLCoursesOrder)    'TODO Every inserts in courses_order table mus be 15*5 rows. sn can be used to order


            DataGridViewCoursesOrder.DataSource = coursesOrderDS.Tables(0).DefaultView
        Catch ex As Exception
            logError(ex.ToString)
        MsgBox("An error occured, see log for details")
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ButtonStudents.Click
        Try
            MainForm.ChangeMenu("StudentsRegistration")
        Catch ex As Exception
            logError(ex.ToString)
            MsgBox("An error occured, see log for details")
        End Try

    End Sub

    Private Sub ButtonResultList_Click(sender As Object, e As EventArgs)
        Try
            MainForm.ChangeMenu("ResultsTranscripts")
        Catch ex As Exception
            logError(ex.ToString)
            MsgBox("Oops! Something went wrong, see log for details")
        End Try
    End Sub

    Private Sub ButtonUpload_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Try
            MainForm.ChangeMenu("UploadResult")
        Catch ex As Exception
            logError(ex.ToString)
        MsgBox("Oops! Something went wrong, see log for details")
        End Try
    End Sub

    Private Sub ButtonUser_Click(sender As Object, e As EventArgs) Handles ButtonResults.Click
        Try
            MainForm.ChangeMenu("UploadResult")
        Catch ex As Exception
            logError(ex.ToString)
        MsgBox("Oops! Something went wrong, see log for details")
        End Try
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Try
            Me.Close()
        Catch ex As Exception
            logError(ex.ToString)
            MsgBox("Oops! Something went wrong, see log for details")
        End Try
    End Sub

    Private Sub FormAdmin_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Try
            MainForm.doCloseForm()
        Catch ex As Exception
            logError(ex.ToString)
            MsgBox("Oops! Something went wrong, see log for details")
        End Try
    End Sub


    Private Sub DataGridViewCoursesOrder_RowLeave(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewCoursesOrder.RowLeave
        Try
            DataGridViewCoursesOrder.Update()
        Catch ex As Exception
        logError(ex.ToString)
        MsgBox("Oops! Something went wrong, see log for details")
        End Try
    End Sub

    Private Sub ButtonActivate_Click(sender As Object, e As EventArgs) Handles ButtonActivate.Click
        If TextBoxDevPass.Text = My.Settings.activation_code Then
            GroupBoxDev.Visible = True

        Else
            GroupBoxDev.Visible = False
        End If
    End Sub

    Private Sub ButtonAddSession_Click(sender As Object, e As EventArgs) Handles ButtonAddSession.Click
        'todo add new row to course_order new copy enries from latest session 
        'into the row

    End Sub
End Class
