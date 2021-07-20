Public Class FormAddNewStuff
    Private Sub FormAddNewStuff_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Function AddEm() As Boolean
        DataGridViewAdd.DataSource = mappDB.GetDataWhere(STR_SQL_ALL_COURSES).Tables(0).DefaultView
    End Function

    Public Function saveEm() As Boolean
        DataGridViewAdd.EndEdit()
        DataGridViewAdd.Update()

    End Function
End Class