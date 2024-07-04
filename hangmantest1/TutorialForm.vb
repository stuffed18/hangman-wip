Public Class TutorialForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Dim menu As New MenuForm
        menu.Show()
        Me.Hide()

    End Sub

    Private Sub TutorialForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ButtonBack.BackColor = Color.Transparent
        ButtonBack.ForeColor = Color.White
        ButtonBack.FlatAppearance.BorderSize = 1
    End Sub
End Class