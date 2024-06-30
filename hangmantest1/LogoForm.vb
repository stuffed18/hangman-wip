Public Class LogoForm
    Dim TimerTime As Integer
    Private Sub LogoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerTime = 0
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TimerTime += 1
        If TimerTime = 5 Then
            My.Computer.Audio.Play("cinematic_boom.wav", AudioPlayMode.Background)
        ElseIf TimerTime = 10 Then
            LogoPicture.Visible = True
        ElseIf TimerTime = 21 Then
            My.Computer.Audio.Play("beep.wav", AudioPlayMode.Background)
            LogoPicture.Image = My.Resources.companylogo2
        ElseIf TimerTime = 30 Then
            My.Computer.Audio.Play("EpicChase.wav", AudioPlayMode.BackgroundLoop)
        ElseIf TimerTime = 40 Then
            Dim menuForm As New MenuForm()
            menuForm.Show()
            Me.Hide()
        End If
    End Sub
End Class