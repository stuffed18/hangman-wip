
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
        "conduct"
    }
    Public WordList2 As New List(Of String) From {
        "file",
        "pick",
        "drill",
        "spade",
        "ruler",
        "knife",
        "pliers",
        "wrench",
        "chisel",
        "hammer",
        "crowbar",
        "spanner",
        "scalpel"
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
        "rolwing",
        "tolkien",
        "capulet"
    }
End Module

Public Class Form2
    Dim whichWordList As Integer = 1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim menuForm As New MenuForm()
        menuForm.SelectedWordListIndex = whichWordList
        menuForm.Show()
        Me.Hide()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initial selection
        RadioButton1.Checked = True
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            whichWordList = 1
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            whichWordList = 2
        End If
    End Sub
End Class
