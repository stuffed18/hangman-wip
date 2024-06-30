Public Class TutorialForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim menu As New MenuForm
        menu.Show()
        Me.Hide()

    End Sub
End Class