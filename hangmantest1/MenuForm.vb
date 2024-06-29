Imports System.Security

Public Class MenuForm
    Public Property SelectedWordListIndex As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim gameForm As New Form1
        gameForm.SelectedWordListIndex = SelectedWordListIndex
        gameForm.Show()
        Me.Hide()
    End Sub

    Private Sub MenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.BackColor = Color.Transparent
        Button1.ForeColor = Color.White
        Button1.FlatAppearance.BorderSize = 0.7

        Button2.BackColor = Color.Transparent
        Button2.ForeColor = Color.White
        Button2.FlatAppearance.BorderSize = 1

        Button3.BackColor = Color.Transparent
        Button3.ForeColor = Color.White
        Button3.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim newForm As New Form2
        newForm.Show()
        Me.Hide()
    End Sub
End Class
