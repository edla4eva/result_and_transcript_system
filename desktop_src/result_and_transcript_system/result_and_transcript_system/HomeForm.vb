Public Class HomeForm
    Private Sub HomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PictureBox1.Top = Me.Top + Me.Height / 2
        Me.PictureBox1.Top = Me.Left + Me.Width / 2
    End Sub



End Class