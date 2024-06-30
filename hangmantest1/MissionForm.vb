Public Class MissionForm
    Dim EnterLabelText As String = "ENTER USERNAME:"
    Dim MissionText As String
    Dim TimerIndex As Integer = 0
    Dim TimerWaitIndex As Integer = 0
    Dim WaitLength As Integer = 10
    Private Sub txtPassword_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles TextBox1.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox1.Enabled = False
            GlobalVariables.globalUsername = TextBox1.Text
            MissionText = "Agent " & TextBox1.Text & ", you have been dispatched to defuse a highly dangerous bomb
planted at site C-19. Your mission? Enter the detonation code before the timer
expires or else the entire building will go down.

We don’t know what the code is, so that’s up to you to figure out. You will have
to guess letters one at a time. For each letter you guess correctly, the
corresponding letter will be revealed in the code.

Good luck, Agent " & TextBox1.Text & ". We’re counting on you.
Just don’t let it reach to zero."
            MissionTextLabel.Text = ""
            MissionTextLabel.Visible = True
            Timer2.Start()
        End If
    End Sub

    Private Sub MissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Stop()
        Label2.Text = ""
        Timer1.Start()

        TextBox1.Text = GlobalVariables.globalUsername
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = Truncate(EnterLabelText, TimerIndex, Timer1, 1)
        TimerIndex += 1
    End Sub

    Public Function Truncate(what As String, length As Integer, timer_ As Object, tInd As Integer) As String
        If (what.Length > length) Then
            If length > 0 Then
                If Not (what(length - 1) = " " Or what(length - 1) = vbNewLine) Then
                    My.Computer.Audio.Play("keytype.wav", AudioPlayMode.Background)
                Else

                End If
                If what(length - 1) = "." Or what(length - 1) = "?" Then
                    timer_.Stop()
                    TimerWaitIndex = 0
                    WaitLength = 10
                    TimerWait.Start()
                ElseIf what(length - 1) = "," Then
                    timer_.Stop()
                    TimerWaitIndex = 0
                    WaitLength = 3
                    TimerWait.Start()
                End If
            End If
            Return what.Substring(0, length)
        Else
            timer_.Stop()
            TimerIndex = -1
            If tInd = 2 Then
                TimerContinue.Start()
            End If
            Return what
        End If
    End Function

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        MissionTextLabel.Text = Truncate(MissionText, TimerIndex, Timer2, 2)
        TimerIndex += 1
    End Sub

    Private Sub TimerWait_Tick(sender As Object, e As EventArgs) Handles TimerWait.Tick
        TimerWaitIndex += 1

        If TimerWaitIndex >= WaitLength Then
            TimerWait.Stop()
            Timer2.Start()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, ButtonContinue.Click
        TimerWait.Stop()
        Timer1.Stop()
        Timer2.Stop()

        Dim gameForm As New Form1()
        gameForm.Show()
        Me.Hide()
    End Sub

    Private Sub TimerContinue_Tick(sender As Object, e As EventArgs) Handles TimerContinue.Tick
        TimerContinue.Stop()
        ButtonContinue.Visible = True
        My.Computer.Audio.Play("keytype.wav", AudioPlayMode.Background)
    End Sub
End Class