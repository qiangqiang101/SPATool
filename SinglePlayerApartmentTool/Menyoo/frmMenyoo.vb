Imports System.Xml
Imports System.Threading

Public Class frmMenyoo

    Public Directory As String = Nothing
    Public MThread As Thread = New Thread(AddressOf StartThreading)

    Private Sub ReadLanguage()
        Dim file As String = (Application.StartupPath & "\Languages\" & My.Settings.Language & ".cfg")
        FileToolStripMenuItem.Text = ReadCfgValue("ToolStripFile", file)
        FileToolStripMenuItem.ToolTipText = ReadCfgValue("ToolStripFile", file)
        NewToolStripMenuItem.Text = ReadCfgValue("ToolStripNew", file)
        NewToolStripMenuItem.ToolTipText = ReadCfgValue("ToolStripNew", file)
        OpenToolStripMenuItem.Text = ReadCfgValue("ToolStripOpen", file)
        OpenToolStripMenuItem.ToolTipText = ReadCfgValue("ToolStripOpen", file)
        SaveToolStripMenuItem.Text = ReadCfgValue("SaveButton", file)
        SaveToolStripMenuItem.ToolTipText = ReadCfgValue("SaveButton", file)
        StartReadToolStripMenuItem.Text = ReadCfgValue("ConvertButton", file)
        StartReadToolStripMenuItem.Text = ReadCfgValue("ConvertButton", file)
        AboutToolStripMenuItem.Text = ReadCfgValue("ToolStripAbout", file)
        AboutToolStripMenuItem.ToolTipText = ReadCfgValue("ToolStripAbout", file)
        Text = ReadCfgValue("TabMenyoo", file)
        'ReadCfgValue("", file)
    End Sub

    Private Sub frmMenyoo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        ReadLanguage()
        FolderBrowserDialog1.Description = "Please select a folder contains Menyoo Outfit..." & Environment.NewLine & "Example: 'MyCustomOutfit.xml'"
    End Sub

    Private Sub GetData(filename As String, filename_without_extension As String)
        Dim xmldata As XmlDataDocument = New XmlDataDocument()
        xmldata.DataSet.ReadXml(filename)

        DataGridView1.DataSource = xmldata.DataSet
        DataGridView1.DataMember = "PedComps"

        txtResult.Text = txtResult.Text & "[name]" & filename_without_extension & "[set1]1," & DataGridView1.Item(1, 0).Value & ",3," & DataGridView1.Item(3, 0).Value & ",4," & DataGridView1.Item(4, 0).Value & ",6," & DataGridView1.Item(6, 0).Value & ",7," & DataGridView1.Item(7, 0).Value & ",8," & DataGridView1.Item(8, 0).Value & ",9," & DataGridView1.Item(9, 0).Value & ",11," & DataGridView1.Item(11, 0).Value & "[set2]"

        DataGridView1.DataSource = Nothing
        DataGridView1.Rows.Clear()
        DataGridView1.DataSource = xmldata.DataSet
        DataGridView1.DataMember = "PedProps"

        txtResult.Text = txtResult.Text & "0," & DataGridView1.Item(0, 0).Value & ",1," & DataGridView1.Item(1, 0).Value & ",2," & DataGridView1.Item(2, 0).Value & vbNewLine

        If txtResult.Text.Contains(",") Then txtResult.Text = txtResult.Text.Replace(",", "#")
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        txtResult.Clear()
        Directory = Nothing
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            Directory = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        'If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
        '    My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, txtResult.Text, False)
        'End If

        frmMenyooSave.Show()
        frmMenyooSave.resultText = txtResult.Text
    End Sub

    Private Sub StartReadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartReadToolStripMenuItem.Click
        If MThread.ThreadState = ThreadState.Running Then
            MsgBox("Please wait until Loading Complete.", MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        Else
            MThread.Start()
        End If
    End Sub

    Private Sub StartThreading()
        Dim complete As Integer = 0, errors As Integer = 0
        tsProgress.Value = 0
        Select Case Directory
            Case Nothing
                MsgBox("Really Nigga?", MsgBoxStyle.Critical, "Error")
            Case Else
                Try
                    For Each file As String In IO.Directory.GetFiles(Directory, "*.xml")
                        tsProgress.Maximum = IO.Directory.GetFiles(Directory, "*.xml").Length
                        If IO.File.Exists(file) Then
                            tsProgress.Value += 1
                            GetData(file, IO.Path.GetFileNameWithoutExtension(file))
                            txtResult.Refresh()
                        End If
                    Next
                Catch ex As Exception
                    errors += 1
                    complete -= 1
                End Try
                MsgBox("Conversion Complete." & Environment.NewLine & "Complete: " & (tsProgress.Maximum - complete) & ", Error: " & errors, MsgBoxStyle.Information, "Done")
        End Select
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox(ReadCfgValue("AboutMenyoo", Application.StartupPath & "\Languages\" & My.Settings.Language & ".cfg"), MsgBoxStyle.Information, "About")
    End Sub
End Class