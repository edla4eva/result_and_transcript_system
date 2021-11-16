Public Class FormAddNewStuff

    Public Function AddEm() As Boolean
        DataGridViewAdd.DataSource = mappDB.GetDataWhere(STR_SQL_ALL_COURSES).Tables(0).DefaultView
        Return True
    End Function

    Public Function saveEm() As Boolean
        DataGridViewAdd.EndEdit()
        DataGridViewAdd.Update()
        Return True
    End Function
End Class