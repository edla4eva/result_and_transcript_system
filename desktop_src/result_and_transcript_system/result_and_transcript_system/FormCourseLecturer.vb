Imports System.IO
Imports ExcelDataReader

Public Class FormCourseLecturer

    Dim tables As DataTableCollection

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonUploadResult_Click(sender As Object, e As EventArgs) Handles ButtonUploadResult.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CourseLecturerComboSheet.SelectedIndexChanged
        Dim data As DataTable = tables(CourseLecturerComboSheet.SelectedItem.ToString())
        CourseLecturerDataGrid.DataSource = data
    End Sub

    Private Sub CourseLectureBrowseButton_Click(sender As Object, e As EventArgs) Handles CourseLectureBrowseButton.Click
        Using ofd As OpenFileDialog = New OpenFileDialog() 'With {.Filter = "Excel 97-2003 workbook|*.xls | Excel Workbook |*.xlsx | *|*.csv"}
            If ofd.ShowDialog() = DialogResult.OK Then
                CourseLectureTextbox.Text = ofd.FileName
                Using stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read)
                    Using reader As IExcelDataReader = ExcelReaderFactory.CreateReader(stream)
                        Dim result As DataSet = reader.AsDataSet(New ExcelDataSetConfiguration() With {
                                                                 .ConfigureDataTable = Function(__) New ExcelDataTableConfiguration With {
                                                                 .UseHeaderRow = True}})

                        tables = result.Tables
                        CourseLecturerComboSheet.Items.Clear()
                        For Each table As DataTable In tables
                            CourseLecturerComboSheet.Items.Add(table.TableName)
                        Next

                    End Using
                End Using
            End If
        End Using
    End Sub

    Private Sub CourseLecturerDataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CourseLecturerDataGrid.CellContentClick
        'Me.color = Color.Transparent
    End Sub
End Class