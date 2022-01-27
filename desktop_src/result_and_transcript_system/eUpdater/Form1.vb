Imports System.Net
Imports System.Xml
Imports KnightsWarriorAutoupdater

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim bHasError As Boolean = False
        Dim autoUpdater As IAutoUpdater = New AutoUpdater()
        Try

            autoUpdater.Update()

        Catch exp As WebException

            MessageBox.Show("Can not find the specified resource")
            bHasError = True

        Catch exp As XmlException

            bHasError = True
            MessageBox.Show("Download the upgrade file error")

        Catch exp As NotSupportedException

            bHasError = True
            MessageBox.Show("Upgrade address configuration error")

        Catch exp As ArgumentException

            bHasError = True
            MessageBox.Show("Download the upgrade file error")

        Catch exp As Exception

            bHasError = True
            MessageBox.Show("An error occurred during the upgrade process")

        Finally

            If (bHasError = True) Then
                Try

                    autoUpdater.RollBack()

                Catch ex As Exception

                    'Log the message to your file Or database
                End Try
            End If
        End Try
    End Sub
#Region "check And download New version program"

#End Region

End Class
