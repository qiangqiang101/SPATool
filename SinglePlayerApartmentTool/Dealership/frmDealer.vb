Public Class frmDealer

    Public BennyFile As String = Application.StartupPath & "\Shopping\bennysoriginalmotorworks.cfg"
    Public DockFile As String = Application.StartupPath & "\Shopping\docktease.cfg"
    Public ElitasFile As String = Application.StartupPath & "\Shopping\elitastravel.cfg"
    Public LegendaryFile As String = Application.StartupPath & "\Shopping\legendarymotorsport.cfg"
    Public PedalFile As String = Application.StartupPath & "\Shopping\padmcycles.cfg"
    Public SouthernFile As String = Application.StartupPath & "\Shopping\southernsanandreassuperautos.cfg"
    Public WarstockFile As String = Application.StartupPath & "\Shopping\warstock-cache-and-carry.cfg"
    Public Parameters As String() = {"[name]", "[price]", "[model]", "[gxt]", "[make]", "[category]", "[desc]"}
    Public ImagePathDir As String = Application.StartupPath & "\Shopping\Images\"
    Public items As New ListViewItem()

    Private Sub tscbDealer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tscbDealer.SelectedIndexChanged
        lvCars.Items.Clear()

        Select Case tscbDealer.SelectedItem
            Case "Benny's Original Motor Works"
                ReadFiles(BennyFile)
            Case "DockTease"
                ReadFiles(DockFile)
            Case "Elitás Travel"
                ReadFiles(ElitasFile)
            Case "Legendary Motorsport"
                ReadFiles(LegendaryFile)
            Case "Pedal and Metal Cycles"
                ReadFiles(PedalFile)
            Case "Southern San Andreas Super Autos"
                ReadFiles(SouthernFile)
            Case "Warstock Cache & Carry"
                ReadFiles(WarstockFile)
        End Select

        NewToolStripMenuItem.Enabled = True
        EditToolStripMenuItem1.Enabled = True
        DeleteToolStripMenuItem1.Enabled = True
        SaveToolStripMenuItem.Enabled = True
    End Sub

    Private Sub ReadFiles(File As String)
        Try
            Dim Format As New Reader(File, Parameters)
            For i As Integer = 0 To Format.Count - 1
                items = lvCars.Items.Add(Format(i)("name"))
                With items
                    .SubItems.Add(Format(i)("price"))
                    .SubItems.Add(Format(i)("model"))
                    .SubItems.Add(Format(i)("gxt"))
                    .SubItems.Add(Format(i)("make"))
                    .SubItems.Add(Format(i)("category"))
                    .SubItems.Add(Format(i)("desc"))
                End With
            Next
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub WriteFiles(File As String)
        Try
            IO.File.WriteAllText(File, "")
            Dim sw As System.IO.StreamWriter
            sw = My.Computer.FileSystem.OpenTextFileWriter(File, True)
            For Each item As ListViewItem In lvCars.Items
                sw.WriteLine("[name]" & item.Text & "[price]" & item.SubItems(1).Text & "[model]" & item.SubItems(2).Text & "[gxt]" & item.SubItems(3).Text & "[make]" & item.SubItems(4).Text & "[category]" & item.SubItems(5).Text & "[desc]" & item.SubItems(6).Text)
            Next
            sw.Close()

            Dim textToSave As TextBox = New TextBox
            textToSave.Multiline = True
            textToSave.Text = IO.File.ReadAllText(File)
            Dim lineList As New List(Of String)
            For Each line As String In textToSave.Lines
                If line.Trim <> "" Then lineList.Add(line)
            Next
            textToSave.Lines = lineList.ToArray
            IO.File.WriteAllText(File, textToSave.Text)

            MsgBox("Save Successfully", MsgBoxStyle.Information, "SPA Tool")
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub EditToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem1.Click
        Try
            If lvCars.SelectedItems.Count = 0 Then
                Exit Sub
            Else
                Dim NewForm As frmDEdit = New frmDEdit
                frmMain.TabControl1.TabPages.Add(NewForm)
                NewForm.EditMode = True
                NewForm.LVItem = lvCars.SelectedItems.Item(0)
                NewForm.xListView = lvCars
                NewForm.Text = "Edit: " & lvCars.SelectedItems.Item(0).Text
                NewForm.txtName.Text = lvCars.SelectedItems.Item(0).Text
                NewForm.numPrice.Value = lvCars.SelectedItems.Item(0).SubItems(1).Text
                NewForm.txtModel.Text = lvCars.SelectedItems.Item(0).SubItems(2).Text
                NewForm.txtGXT.Text = lvCars.SelectedItems.Item(0).SubItems(3).Text
                NewForm.cmbBrand.Text = lvCars.SelectedItems.Item(0).SubItems(4).Text
                NewForm.cmbCategory.SelectedItem = lvCars.SelectedItems.Item(0).SubItems(5).Text
                NewForm.txtDesc.Text = lvCars.SelectedItems.Item(0).SubItems(6).Text
                Dim fs As IO.FileStream = New IO.FileStream(Application.StartupPath & "\Shopping\Images\" & String.Format("{0}{1}", NewForm.txtModel.Text, ".jpg"), IO.FileMode.Open, IO.FileAccess.Read)
                NewForm.pbImage.Image = Image.FromStream(fs)
                fs.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "SPA Tool")
        End Try
    End Sub

    Private Sub lvCars_DoubleClick(sender As Object, e As EventArgs) Handles lvCars.DoubleClick
        EditToolStripMenuItem1.PerformClick()
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        EditToolStripMenuItem1.PerformClick()
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Try
            Dim NewForm As frmDEdit = New frmDEdit
            frmMain.TabControl1.TabPages.Add(NewForm)
            NewForm.EditMode = False
            NewForm.xListView = lvCars
            NewForm.Text = "Untitled"
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "SPA Tool")
        End Try
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Try
            If lvCars.SelectedItems.Count = 0 Then
                Exit Sub
            Else
                If MsgBox("Are you sure you want to delete " & lvCars.SelectedItems.Item(0).Text & "?", MsgBoxStyle.YesNo, "Delete") = MsgBoxResult.Yes Then
                    For Each i As ListViewItem In lvCars.SelectedItems
                        lvCars.Items.Remove(i)
                    Next
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "SPA Tool")
        End Try
    End Sub

    Private Sub DeleteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem1.Click
        DeleteToolStripMenuItem.PerformClick()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Select Case tscbDealer.SelectedItem
            Case "Benny's Original Motor Works"
                WriteFiles(BennyFile)
            Case "DockTease"
                WriteFiles(DockFile)
            Case "Elitás Travel"
                WriteFiles(ElitasFile)
            Case "Legendary Motorsport"
                WriteFiles(LegendaryFile)
            Case "Pedal and Metal Cycles"
                WriteFiles(PedalFile)
            Case "Southern San Andreas Super Autos"
                WriteFiles(SouthernFile)
            Case "Warstock Cache & Carry"
                WriteFiles(WarstockFile)
        End Select
    End Sub
End Class