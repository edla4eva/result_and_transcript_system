Imports System.IO         'THIS IMPORTS THE LIBARY THAT CONTAINS THE FILE BROWSER FUNCTIONS
Imports ExcelDataReader   'THIS IMPORTS THE EXCEL DATA READER LIBARY

Public Class FormCourseLecturer

    'This creates a table object that will hold all the data from the table
    Dim tables As DataTableCollection

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonUploadResult_Click(sender As Object, e As EventArgs) Handles ButtonUploadResult.Click

    End Sub

    'This is the method for the comboBox that will hold the names of the sheets
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CourseLecturerComboSheet.SelectedIndexChanged
        'creates an object of the tables object and calls the datasource into it to display the sheets
        Dim data As DataTable = tables(CourseLecturerComboSheet.SelectedItem.ToString())
        CourseLecturerDataGrid.DataSource = data
    End Sub

    'this is the method for the button to browse through system files for excel files
    Private Sub CourseLectureBrowseButton_Click(sender As Object, e As EventArgs) Handles CourseLectureBrowseButton.Click
        'the OpenFileDialog function is passed into the obj and a filter is passed to accept only excel format files
        Using ofd As OpenFileDialog = New OpenFileDialog() With {.Filter = "Excel 97-2003 workbook|*.xls | Excel Workbook |*.xlsx"}
            If ofd.ShowDialog() = DialogResult.OK Then
                CourseLectureTextbox.Text = ofd.FileName
                Using stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read)
                    'here the stream of data is then passed into a reader obj with the IExcelDataReader type to process the steam of data into the table
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