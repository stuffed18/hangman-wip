﻿Imports System.ComponentModel
Imports System.Reflection.Emit
Imports Microsoft.VisualBasic.Devices

Public Class Form1
    Dim displayedWord As String
    Dim guessedLetters As New List(Of Char)()
    Dim remainingAttempts As Integer
    Dim maxAttempts As Integer = 9
    Dim letterInput As Char
    Dim gameWon As Boolean
    Dim gameOver As Boolean
    Dim wordToGuess As String
    Dim TimerTime As Integer = 15
    Dim gameWins As Integer = 0
    Dim gameLosses As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play("Defusing.wav", AudioPlayMode.BackgroundLoop)
        startGame()
        gameWins = 0
        gameLosses = 0
        UpdateWinLossLabels()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        startGame()
    End Sub

    Public Sub startGame()
        Dim wordList As List(Of String)
        Dim wordListOptions = {GlobalVariables.WordList1, GlobalVariables.WordList2, GlobalVariables.WordList3}
        Dim wordListNames = {"ELECTRONICS", "TOOLS", "SURNAMES"}
        If GlobalVariables.whichWordList < 4 Then
            wordList = wordListOptions(GlobalVariables.whichWordList - 1)
            LabelTheme.Text = wordListNames(GlobalVariables.whichWordList - 1)
        Else
            Dim random_ As New Random()
            Dim randomIndex_ As Integer = random_.Next(3)
            wordList = wordListOptions(randomIndex_)
            LabelTheme.Text = wordListNames(randomIndex_)
        End If

        Dim random As New Random()
        Dim randomIndex As Integer = random.Next(wordList.Count)
        wordToGuess = wordList(randomIndex)
        guessedLetters.Clear()
        remainingAttempts = maxAttempts
        gameWon = False
        gameOver = False
        'Label2.Text = wordToGuess
        displayedWord = ""
        For i As Integer = 1 To wordToGuess.Length
            displayedWord &= "_ "
        Next
        Label1.Text = displayedWord
        Panel2.BackColor = Color.Black
        PictureBoxSet()

        Dim keyboardButtons As Button() = {ButtonA, ButtonB, ButtonC, ButtonD, ButtonE, ButtonF, ButtonG, ButtonH, ButtonI, ButtonJ, ButtonK, ButtonL, ButtonM, ButtonN, ButtonO, ButtonP, ButtonQ, ButtonR, ButtonS, ButtonT, ButtonU, ButtonV, ButtonW, ButtonX, ButtonY, ButtonZ}
        For Each btn As Button In keyboardButtons
            btn.Enabled = True
            btn.BackColor = SystemColors.Control
        Next

        ' Timer code below
        Label4.Text = "0:59"
        Dim timerOptions = {120, 60, 45, 30}
        TimerTime = timerOptions(GlobalVariables.timeSelected - 1)

        Dim SecondsRemainder As Integer = 0
        Dim Minutes As Integer = 0
        Minutes = TimerTime \ 60
        SecondsRemainder = TimerTime - (60 * Minutes)

        If SecondsRemainder >= 10 Then
            Label4.Text = "0" & Minutes & ":" & SecondsRemainder
        ElseIf SecondsRemainder < 10 AndAlso TimerTime > 0 Then
            Label4.Text = "0" & Minutes & ":0" & SecondsRemainder
        ElseIf SecondsRemainder = 0 Then
            Label4.Text = "0" & Minutes & ":00"
        End If

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
            Timer1.Stop()
            gameWins += 1
            UpdateWinLossLabels()
            MessageBox.Show("You won!")
        ElseIf remainingAttempts <= 0 Then
            gameOver = True
            gameLosses += 1
            UpdateWinLossLabels()
            Timer1.Stop()
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
            MessageBox.Show("The game has ended")
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

        Dim SecondsRemainder As Integer = 0
        Dim Minutes As Integer = 0
        Minutes = TimerTime \ 60
        SecondsRemainder = TimerTime - (60 * Minutes)

        If SecondsRemainder >= 10 Then
            Label4.Text = "0" & Minutes & ":" & SecondsRemainder
        ElseIf SecondsRemainder < 10 AndAlso TimerTime > 0 Then
            Label4.Text = "0" & Minutes & ":0" & SecondsRemainder
        ElseIf SecondsRemainder = 0 Then
            Label4.Text = "0" & Minutes & ":00"
        End If

        If TimerTime = 0 Then
            Label4.Text = "00:00"
            Timer1.Stop()
            gameOver = True
            MessageBox.Show("Time's up! The word was: " & wordToGuess)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Dim Menu As New MenuForm
        Menu.Show()
        My.Computer.Audio.Play("EpicChase.wav", AudioPlayMode.BackgroundLoop)
        Me.Hide()
    End Sub

    Private Sub UpdateWinLossLabels()
        Label2.Text = gameWins.ToString()
        Label3.Text = gameLosses.ToString()
    End Sub
End Class
