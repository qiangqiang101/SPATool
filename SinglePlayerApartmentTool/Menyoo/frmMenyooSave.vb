Imports System.IO

Public Class frmMenyooSave

    Private onlineMaleFile As String = Application.StartupPath & "\Wardrobe\Player3_M\outfits.cfg"
    Private onlineFemaleFile As String = Application.StartupPath & "\Wardrobe\Player3_F\outfits.cfg"
    Public Shared resultText As String = Nothing

    Private Sub btnTaskStart_Click(sender As Object, e As EventArgs) Handles btnTaskStart.Click
        Select Case cmbChoose.SelectedItem
            Case "Online Male"
                Dim textToSave As TextBox = New TextBox
                textToSave.Multiline = True
                textToSave.Text = File.ReadAllText(onlineMaleFile) & vbCrLf & resultText
                Dim lineList As New List(Of String)
                For Each line As String In textToSave.Lines
                    If line.Trim <> "" Then lineList.Add(line)
                Next
                textToSave.Lines = lineList.ToArray
                File.WriteAllText(onlineMaleFile, textToSave.Text)
            Case "Online Female"
                Dim textToSave As TextBox = New TextBox
                textToSave.Multiline = True
                textToSave.Text = File.ReadAllText(onlineFemaleFile) & vbCrLf & resultText
                Dim lineList As New List(Of String)
                For Each line As String In textToSave.Lines
                    If line.Trim <> "" Then lineList.Add(line)
                Next
                textToSave.Lines = lineList.ToArray
                File.WriteAllText(onlineFemaleFile, textToSave.Text)
        End Select
        Close()
    End Sub

    Private Sub frmMenyooSave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbChoose.SelectedIndex = 0
    End Sub
End Class