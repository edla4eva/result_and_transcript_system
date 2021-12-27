Imports System.ComponentModel

Public Class FormHelp
    Private Sub FormHelp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        WebBrowser1.Url = New Uri("file:///" & My.Application.Info.DirectoryPath & "\help\guide.html")


    End Sub

    Private Sub FormHelp_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        WebBrowser1.Url = New Uri("file:///" & My.Application.Info.DirectoryPath & "\help\guide.html")

    End Sub





    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        WebBrowser1.Url = New Uri("file:///" & My.Application.Info.DirectoryPath & "\help\help.pdf")

    End Sub

    Private Sub ButtonAbout_Click(sender As Object, e As EventArgs) Handles ButtonAbout.Click
        FormAbout.Show()
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub FormHelp_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MainForm.doCloseForm()
    End Sub
End Class