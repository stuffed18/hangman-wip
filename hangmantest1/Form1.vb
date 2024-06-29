Imports System.Reflection.Emit

Public Class Form1
    Dim displayedWord As String
    Dim guessedLetters As New List(Of Char)()
    Dim remainingAttempts As Integer
    Dim maxAttempts As Integer = 9
    Dim letterInput As Char
    Dim gameWon As Boolean
    Dim gameOver As Boolean
    Dim wordToGuess As String
    Dim wordList As New List(Of String)() From {
        "subodh",
        "explodin",
        "test",
        "bangman",
        "benson",
        "raffay",
        "blue"
    }
    Dim TimerTime As Integer = 15


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        startGame()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        startGame()
    End Sub

    Public Sub startGame()
        Dim random As New Random()
        Dim randomIndex As Integer = random.Next(wordList.Count)
        wordToGuess = wordList(randomIndex)
        guessedLetters.Clear()
        remainingAttempts = maxAttempts
        gameWon = False
        gameOver = False
        Label2.Text = wordToGuess
        displayedWord = ""
        For i As Integer = 1 To wordToGuess.Length
            displayedWord = displayedWord & "_ "
        Next
        'displayedWord = New String("_"c, wordToGuess.Length)
        Label1.Text = displayedWord
        Panel2.BackColor = Color.Black
        PictureBoxSet()

        Dim keyboardButtons As Button() = {ButtonA, ButtonB, ButtonC, ButtonD, ButtonE, ButtonF, ButtonG, ButtonH, ButtonI, ButtonJ, ButtonK, ButtonL, ButtonM, ButtonN, ButtonO, ButtonP, ButtonQ, ButtonR, ButtonS, ButtonT, ButtonU, ButtonV, ButtonW, ButtonX, ButtonY, ButtonZ}
        For Each btn As Button In keyboardButtons
            btn.Enabled = True ' Disable the button
            btn.BackColor = SystemColors.Control ' Reset BackColor to default (system) color
        Next

        ' Timer code below
        Label4.Text = "0:59"
        TimerTime = 15
        Label4.Text = "0:" & TimerTime

        Timer1.Start()


    End Sub

    Public Sub PictureBoxSet()

        Dim bombImage As Image = ImageList1.Images(0)

        PictureBox1.Image = bombImage
        PictureBox2.Image = bombImage
        PictureBox3.Image = bombImage
        PictureBox4.Image = bombImage
        PictureBox5.Image = bombImage
        PictureBox6.Image = bombImage
        PictureBox9.Image = bombImage
        PictureBox8.Image = bombImage
        PictureBox7.Image = bombImage
    End Sub

    Private Function updateDisplayedWord()
        Dim newDisplayedWord As Char() = displayedWord.ToCharArray()
        Dim correctGuess As Boolean = False

        For i As Integer = 0 To wordToGuess.Length - 1
            If wordToGuess(i) = letterInput Then
                newDisplayedWord(i * 2) = letterInput
                correctGuess = True
            End If
        Next

        If Not correctGuess Then
            remainingAttempts -= 1
        End If

        updateAttemptBoxes()

        displayedWord = New String(newDisplayedWord)
        Label1.Text = displayedWord

        If Not displayedWord.Contains("_") Then
            gameWon = True
            gameOver = True
            MessageBox.Show("You won!")
        ElseIf remainingAttempts <= 0 Then
            gameOver = True
            MessageBox.Show("Game Over! The word was: " & wordToGuess)
        End If

        If correctGuess Then
            Return True
        End If
        Return False
    End Function

    Private Sub ButtonKey_Click(sender As Object, e As EventArgs) Handles ButtonQ.Click, ButtonW.Click, ButtonE.Click, ButtonR.Click, ButtonT.Click, ButtonY.Click, ButtonU.Click, ButtonI.Click, ButtonO.Click, ButtonP.Click, ButtonA.Click, ButtonS.Click, ButtonD.Click, ButtonF.Click, ButtonG.Click, ButtonH.Click, ButtonJ.Click, ButtonK.Click, ButtonL.Click, ButtonZ.Click, ButtonX.Click, ButtonC.Click, ButtonV.Click, ButtonB.Click, ButtonN.Click, ButtonM.Click
        If sender.BackColor = Color.Lime Then
            Return
        End If

        If gameOver OrElse gameWon Then
            MessageBox.Show("The game is over")
            MessageBox.Show("Or is it?")
            Return
        End If

        letterInput = sender.Text.ToLower()
        If Not guessedLetters.Contains(letterInput) Then
            guessedLetters.Add(letterInput)
            Dim correctGuess As Boolean = updateDisplayedWord()

            If correctGuess Then
                sender.BackColor = Color.Lime
            Else
                sender.Enabled = False
            End If
        End If

    End Sub

    Public Sub updateAttemptBoxes()
        Dim attemptBoxes As PictureBox() = {PictureBox1, PictureBox2, PictureBox3, PictureBox6, PictureBox5, PictureBox4, PictureBox7, PictureBox8, PictureBox9}
        Dim index As Integer = maxAttempts - remainingAttempts - 1
        If index >= 0 Then
            attemptBoxes(index).Image = ImageList1.Images(1)
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If TimerTime > 0 Then
            TimerTime -= 1
        End If
        If TimerTime >= 10 Then
            Label4.Text = "0:" & TimerTime
        ElseIf TimerTime < 10 AndAlso TimerTime > 0 Then
            Label4.Text = "0:0" & TimerTime
        ElseIf TimerTime = 0 Then
            Label4.Text = "0:00"
            Timer1.Stop()
            MessageBox.Show("Time's up")

        End If
    End Sub

End Class

