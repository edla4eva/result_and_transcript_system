Imports System.ComponentModel

Public Class FormHelp
    Private Sub FormHelp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            WebBrowser1.Url = New Uri("file:///" & My.Application.Info.DirectoryPath & "\help\guide.html")
        Catch ex As Exception
            logError(ex.ToString)
            'silent
        End Try

    End Sub

    Private Sub FormHelp_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Try
            WebBrowser1.Url = New Uri("file:///" & My.Application.Info.DirectoryPath & "\help\guide.html")
        Catch ex As Exception
            logError(ex.ToString)
            'silent
        End Try
    End Sub





    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        Try
            WebBrowser1.Url = New Uri("file:///" & My.Application.Info.DirectoryPath & "\help\help.pdf")
        Catch ex As Exception
            logError(ex.ToString)
            MsgBox("Could not open help file" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub ButtonAbout_Click(sender As Object, e As EventArgs) Handles ButtonAbout.Click
        On Error Resume Next
        FormAbout.Show()
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        On Error Resume Next
        Me.Close()
    End Sub

    Private Sub FormHelp_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MainForm.doCloseForm()
    End Sub
End Class