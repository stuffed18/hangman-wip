﻿
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

    Public whichWordList As Integer = 1
End Module

Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim menuForm As New MenuForm()
        'menuForm.SelectedWordListIndex = whichWordList
        menuForm.Show()
        Me.Hide()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initial selection
        Dim ThemeRadios = {ThemeRadio1, ThemeRadio2, ThemeRadio3, ThemeRadio4}

        ThemeRadios(GlobalVariables.whichWordList - 1).Checked = True
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
End Class
