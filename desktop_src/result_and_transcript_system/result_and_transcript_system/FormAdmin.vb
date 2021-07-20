Public Class FormAdmin
    Private Sub FormCourseAdviser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = RGBColors.colorBlack2
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub ButtonBrowse_Click(sender As Object, e As EventArgs) Handles ButtonBroadsheets.Click
        'Show Courses Order
        'Todo Move
        Dim strSQLCoursesOrder As String
        Dim coursesOrderDS As DataSet
        strSQLCoursesOrder = "SELECT * FROM Courses_order WHERE (session_idr='{0}' AND dept_idr={1}) ORDER BY sn;" 'and level
        coursesOrderDS = mappDB.GetDataWhere(String.Format(strSQLCoursesOrder, "2018/2019", 1), "Courses")    'TODO Every inserts in courses_order table mus be 15*5 rows. sn can be used to order

        DataGridViewCoursesOrder.DataSource = coursesOrderDS.Tables(0).DefaultView
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ButtonStudents.Click
        MainForm.ChangeMenu("StudentsRegistration")
    End Sub

    Private Sub ButtonResultList_Click(sender As Object, e As EventArgs)
        MainForm.ChangeMenu("ResultsTranscripts")
    End Sub

    Private Sub ButtonUpload_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        MainForm.ChangeMenu("UploadResult")
    End Sub

    Private Sub ButtonUser_Click(sender As Object, e As EventArgs) Handles ButtonResults.Click
        MainForm.ChangeMenu("UploadResult")
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub FormAdmin_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MainForm.doCloseForm()
    End Sub

    Private Sub DataGridViewCoursesOrder_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewCoursesOrder.CellContentClick

    End Sub

    Private Sub DataGridViewCoursesOrder_RowLeave(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewCoursesOrder.RowLeave
        DataGridViewCoursesOrder.Update()

    End Sub
End Class
