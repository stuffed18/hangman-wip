
Module GlobalVariables
    Public WordList1 As New List(Of String) From {
        "wire",
        "fuse",
        "volt",
        "radio",
        "virus",
        "pixel",
        "laptop",
        "camera",
        "charge",
        "circuit",
        "binary",
        "current",
        "power",
        "battery",
        "cable",
        "conduct",
        "input",
        "output",
        "signal",
        "system",
        "memory",
        "switch",
        "display",
        "remote",
        "reboot",
        "channel",
        "network",
        "program",
        "server",
        "plug",
        "data",
        "boot",
        "chip",
        "port",
        "cable"
    }
    Public WordList2 As New List(Of String) From {
        "file",
        "pick",
        "drill",
        "spade",
        "knife",
        "pliers",
        "wrench",
        "hammer",
        "crowbar",
        "spanner",
        "stapler",
        "trowel",
        "clamp",
        "mallet",
        "shears",
        "punch",
        "shovel",
        "welder",
        "jack",
        "vise",
        "cutter",
        "probe"
    }
    Public WordList3 As New List(Of String) From {
        "bond",
        "cook",
        "ford",
        "saki",
        "smith",
        "jones",
        "obama",
        "tesla",
        "nobel",
        "darwin",
        "watson",
        "cruise",
        "freeman",
        "holmes",
        "caesar",
        "lincoln",
        "mandela",
        "hawking",
        "rowling",
        "tolkien",
        "capulet",
        "james",
        "walker",
        "howard",
        "gomez",
        "taylor",
        "turner",
        "evans",
        "clark",
        "lopez",
        "harris",
        "white",
        "parker",
        "murphy",
        "ross",
        "cooper",
        "bell",
        "nelson"
    }

    Public whichWordList As Integer = 1
    Public timeSelected As Integer = 1
    Public globalUsername As String = ""
End Module

Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Dim menuForm As New MenuForm()
        'menuForm.SelectedWordListIndex = whichWordList
        menuForm.Show()
        Me.Hide()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initial selection
        Dim ThemeRadios = {ThemeRadio1, ThemeRadio2, ThemeRadio3, ThemeRadio4}
        Dim TimeRadios = {TimeRadio1, TimeRadio2, TimeRadio3, TimeRadio4}

        ThemeRadios(GlobalVariables.whichWordList - 1).Checked = True
        TimeRadios(GlobalVariables.timeSelected - 1).Checked = True

        ButtonBack.BackColor = Color.Transparent
        ButtonBack.ForeColor = Color.White
        ButtonBack.FlatAppearance.BorderSize = 1
        ButtonReset.BackColor = Color.Transparent
        ButtonReset.ForeColor = Color.White
        ButtonReset.FlatAppearance.BorderSize = 1

    End Sub

    Private Sub Theme_CheckedChanged(sender As Object, e As EventArgs) Handles ThemeRadio1.CheckedChanged, ThemeRadio2.CheckedChanged
        If ThemeRadio1.Checked Then
            GlobalVariables.whichWordList = 1
        ElseIf ThemeRadio2.Checked Then
            GlobalVariables.whichWordList = 2
        ElseIf ThemeRadio3.Checked Then
            GlobalVariables.whichWordList = 3
        ElseIf ThemeRadio4.Checked Then
            GlobalVariables.whichWordList = 4
        End If
    End Sub

    Private Sub Time_CheckedChanged(sender As Object, e As EventArgs) Handles TimeRadio1.CheckedChanged, TimeRadio2.CheckedChanged, TimeRadio3.CheckedChanged, TimeRadio4.CheckedChanged
        If TimeRadio1.Checked Then
            GlobalVariables.timeSelected = 1
        ElseIf TimeRadio2.Checked Then
            GlobalVariables.timeSelected = 2
        ElseIf TimeRadio3.Checked Then
            GlobalVariables.timeSelected = 3
        ElseIf TimeRadio4.Checked Then
            GlobalVariables.timeSelected = 4
        End If
    End Sub

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        ThemeRadio4.Checked = True
        TimeRadio2.Checked = True
    End Sub
End Class
