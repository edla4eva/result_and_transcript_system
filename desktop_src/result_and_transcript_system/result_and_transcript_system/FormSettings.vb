﻿Public Class FormSettings

    Private Sub FormCourseAdviser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = RGBColors.colorBlack2
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub ButtonBrowse_Click(sender As Object, e As EventArgs) Handles ButtonBrowse.Click
        MainForm.ChangeMenu("GenerateBroadsheet")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MainForm.ChangeMenu("StudentsRegistration")
    End Sub

    Private Sub ButtonResultList_Click(sender As Object, e As EventArgs)
        MainForm.ChangeMenu("ResultsTranscripts")
    End Sub

    Private Sub FormSettings_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MainForm.doCloseForm()
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub
End Class
