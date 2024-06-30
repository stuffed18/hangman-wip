﻿Imports System.Security

Public Class MenuForm
    'Public Property SelectedWordListIndex As Integer

    Private Sub ButtonPlay_Click(sender As Object, e As EventArgs) Handles ButtonPlay.Click
        Dim missionForm As New MissionForm
        'gameForm.SelectedWordListIndex = SelectedWordListIndex
        missionForm.Show()
        Me.Hide()
    End Sub

    Private Sub MenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ButtonPlay.BackColor = Color.Transparent
        ButtonPlay.ForeColor = Color.White
        ButtonPlay.FlatAppearance.BorderSize = 0.7

        ButtonSettings.BackColor = Color.Transparent
        ButtonSettings.ForeColor = Color.White
        ButtonSettings.FlatAppearance.BorderSize = 1

        ButtonTutorial.BackColor = Color.Transparent
        ButtonTutorial.ForeColor = Color.White
        ButtonTutorial.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonSettings.Click
        Dim newForm As New Form2
        newForm.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonTutorial_Click(sender As Object, e As EventArgs) Handles ButtonTutorial.Click
        Dim tutorial As New TutorialForm
        tutorial.Show()
        Me.Hide()

    End Sub
End Class