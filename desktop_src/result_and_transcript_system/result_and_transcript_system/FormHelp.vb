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
End Class