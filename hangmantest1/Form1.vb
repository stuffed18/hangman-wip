Imports System.Reflection.Emit

Public Class Form1
    Dim displayedWord As String
    Dim guessedLetters As New List(Of Char)()
    Dim remainingAttempts As Integer
    Dim maxAttempts As Integer = 6
    Dim letterInput As Char
    Dim gameWon As Boolean
    Dim gameOver As Boolean
    Dim wordToGuess As String
    Dim wordList As New List(Of String)() From {
        "subodh",
        "exploding",
        "test",
        "bangman",
        "benson",
        "raffayharpoon",
        "blue"
    }

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        startGame()
        FormDesign()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        startGame()
    End Sub

    Public Sub FormDesign()
        Panel1.BackColor = ColorTranslator.FromHtml("#0f183c")
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
        displayedWord = New String("_"c, wordToGuess.Length)
        Label1.Text = displayedWord
        Panel2.BackColor = Color.Black

        PictureBoxSet()
    End Sub

    Public Sub PictureBoxSet()

        Dim bombImage As Image = ImageList1.Images(0)

        PictureBox1.Image = bombImage
        PictureBox2.Image = bombImage
        PictureBox3.Image = bombImage
        PictureBox4.Image = bombImage
        PictureBox5.Image = bombImage
        PictureBox6.Image = bombImage
        PictureBox7.Image = bombImage
        PictureBox8.Image = bombImage
        PictureBox9.Image = bombImage
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If gameOver OrElse gameWon Then
            MessageBox.Show("The game is over")
            Return
        End If

        Dim input As String = TextBox1.Text.Trim().ToLower()
        If input.Length = 1 AndAlso Char.IsLetter(input(0)) Then
            letterInput = input(0)
            If Not guessedLetters.Contains(letterInput) Then
                guessedLetters.Add(letterInput)
                updateDisplayedWord()
            Else
                MessageBox.Show("You have already guessed that letter.")
            End If
        Else
            MessageBox.Show("enter a single letter")
        End If

        TextBox1.Clear()
        TextBox1.Focus()
    End Sub

    Private Sub updateDisplayedWord()
        Dim newDisplayedWord As Char() = displayedWord.ToCharArray()
        Dim correctGuess As Boolean = False

        For i As Integer = 0 To wordToGuess.Length - 1
            If wordToGuess(i) = letterInput Then
                newDisplayedWord(i) = letterInput
                correctGuess = True
            End If
        Next

        If Not correctGuess Then
            remainingAttempts -= 1
            Label3.Text = "Remaining Attempts: " & remainingAttempts
        End If

        displayedWord = New String(newDisplayedWord)
        Label1.Text = displayedWord

        If displayedWord = wordToGuess Then
            gameWon = True
            gameOver = True
            MessageBox.Show("You won!")
        ElseIf remainingAttempts <= 0 Then
            gameOver = True
            MessageBox.Show("Game Over! The word was: " & wordToGuess)
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click

    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click

    End Sub
End Class
