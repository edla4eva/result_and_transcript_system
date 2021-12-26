Public Class Form2
    Private Sub DepartmentsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DepartmentsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DepartmentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbDataSet.Departments' table. You can move, or remove it, as needed.
        Me.DepartmentsTableAdapter.Fill(Me.DbDataSet.Departments)

    End Sub
End Class