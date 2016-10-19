Imports System.Xml

Public Class frmSpg2Spa

    Private settingFile As String = Application.StartupPath & "\setting.cfg"
    Public Directory As String = Nothing

    Private Sub ReadLanguage()
        Dim file As String = (Application.StartupPath & "\Languages\" & My.Settings.Language & ".cfg")
        Me.Text = ReadCfgValue("TabConvertSPGToSPA", file)
        Me.StartReadToolStripMenuItem.Text = CFGread.ReadCfgValue("ConvertButton", file)
        Me.OpenToolStripMenuItem.Text = CFGread.ReadCfgValue("BrowseButton", file)
        Me.TabPage1.Text = CFGread.ReadCfgValue("LoggingLog", file)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ReadLanguage()
            Dim spgPath As String = Application.StartupPath
            spgPath = spgPath.Replace("SinglePlayerApartment", "SinglePlayerGarage")
            Directory = spgPath
            FolderBrowserDialog1.SelectedPath = spgPath
            RefreshListviews()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Single Player Apartment")
        End Try
    End Sub

    Private Sub RefreshListviews()
        lvApartment.Items.Clear()
        lvFloor.Items.Clear()
        lvGarage.Items.Clear()
        txtApartment.Clear()
        txtFloor.Clear()
        txtGarage.Clear()

        For Each spgFolder As String In IO.Directory.GetDirectories(Directory)
            Dim dirInfo As New IO.DirectoryInfo(spgFolder)
            lvGarage.Items.Add(dirInfo.Name)
        Next

        For Each spaFolder As String In IO.Directory.GetDirectories(Application.StartupPath & "\Garage")
            Dim dirInfo As New IO.DirectoryInfo(spaFolder)
            lvApartment.Items.Add(dirInfo.Name)
        Next
    End Sub

    Private Sub Log(Message As Object)
        txtLog.Text = txtLog.Text & Now & ": " & Message & vbNewLine
        txtLog.Refresh()
    End Sub

    Private Sub RenameFilesBackToCFG()
        Try
            Dim searchPattern As String = "*.temp"
            Dim curDir As New IO.DirectoryInfo(Directory & "\" & txtGarage.Text & "\" & txtFloor.Text)

            Dim i As Integer = 0
            For Each fi As IO.FileInfo In curDir.GetFiles(searchPattern).OrderBy(Function(num) num.CreationTime)
                'IO.File.Move(fi.FullName, IO.Path.Combine(fi.Directory.FullName, "vehicle_" & i & ".cfg"))
                IO.File.Move(fi.FullName, IO.Path.Combine(Application.StartupPath & "\Garage\" & txtApartment.Text, "vehicle_" & i & ".cfg"))
                i += 1
            Next
        Catch ex As Exception
            Log(ex.Message)
        End Try
    End Sub

    Private Sub RenameData(filename As String, filename_without_extension As String)
        Try
            Log("Converting " & filename_without_extension & ".xml...")
            Dim value As String = IO.File.ReadAllText(filename)
            Dim i As Integer = 0
            For Each int As String In value
                If value.Contains("<int>") Then
                    value = Replace(value, "<int>", "<int" & i & ">", 1, 1)
                    i = i + 1
                End If
            Next

            Dim e As Integer = 0
            For Each int As String In value
                If value.Contains("</int>") Then
                    value = Replace(value, "</int>", "</int" & e & ">", 1, 1)
                    e = e + 1
                End If
            Next

            Dim b As Integer = 0
            For Each bool As String In value
                If value.Contains("<boolean>") Then
                    value = Replace(value, "<boolean>", "<boolean" & b & ">", 1, 1)
                    b = b + 1
                End If
            Next

            Dim l As Integer = 0
            For Each bool As String In value
                If value.Contains("</boolean>") Then
                    value = Replace(value, "</boolean>", "</boolean" & l & ">", 1, 1)
                    l = l + 1
                End If
            Next
            My.Computer.FileSystem.WriteAllText(filename, value, False)

        Catch ex As Exception
            Log(ex.Message)
        End Try
    End Sub

    Private Sub MakeBackup()
        Try
            For Each files In System.IO.Directory.GetFiles(Directory & "\" & txtGarage.Text & "\" & txtFloor.Text, "*.xml")
                If IO.File.Exists(files) Then
                    If Not IO.Directory.Exists(Directory & "\" & txtGarage.Text & "\" & txtFloor.Text & "\Backup") Then IO.Directory.CreateDirectory(Directory & "\" & txtGarage.Text & "\" & txtFloor.Text & "\Backup")
                    IO.File.Copy(files, IO.Path.Combine(Directory & "\" & txtGarage.Text & "\" & txtFloor.Text & "\Backup", IO.Path.GetFileName(files)), True)
                End If
            Next
        Catch ex As Exception
            Log(ex.Message)
        End Try
    End Sub

    Private Sub RestoreBackup()
        Try
            For Each files In System.IO.Directory.GetFiles(Directory & "\" & txtGarage.Text & "\" & txtFloor.Text & "\Backup", "*.xml")
                If IO.File.Exists(files) Then
                    IO.File.Copy(files, IO.Path.Combine(Directory & "\" & txtGarage.Text & "\" & txtFloor.Text, IO.Path.GetFileName(files)), True)
                End If
            Next
        Catch ex As Exception
            Log(ex.Message)
        End Try
    End Sub

    Private Sub GetData(filename As String, filename_without_extension As String)
        Try
            Log("Reading " & filename_without_extension & ".xml...")
            Dim VehicleHash, PrimaryColor, SecondaryColor, CustomPrimaryColorR, CustomPrimaryColorG, CustomPrimaryColorB, CustomSecondaryColorR, CustomSecondaryColorG, CustomSecondaryColorB, HasCustomSecondaryColor As String
            Dim HasCustomPrimaryColor, ExtraColor1, NeonColorR, NeonColorG, NeonColorB, TireSmokeR, TireSmokeG, TireSmokeB, PlateType, NumberPlate, Tint, CanTyresBurst, WheelType, WheelVariation1, WheelVariation2 As String
            Dim path As String = Directory & "\" & txtGarage.Text & "\" & txtFloor.Text & "\" & filename_without_extension & ".temp"
            IO.File.WriteAllText(path, My.Resources.vehicle)

            Dim document As XmlReader = New XmlTextReader(filename)
            While (document.Read())
                Dim type = document.NodeType
                If type = XmlNodeType.Element Then
                    If document.Name = "VehicleHash" Then
                        VehicleHash = document.ReadInnerXml.ToString()
                        WriteCfgValue("VehicleName", Helper.GetVehicleName(VehicleHash), path)
                        WriteCfgValue("VehicleModel", Nothing, path)
                        WriteCfgValue("VehicleHash", VehicleHash, path)
                    End If
                    If document.Name = "PrimaryColor" Then
                        PrimaryColor = document.ReadInnerXml.ToString()
                        WriteCfgValue("PrimaryColor", PrimaryColor, path)
                    End If
                    If document.Name = "SecondaryColor" Then
                        SecondaryColor = document.ReadInnerXml.ToString()
                        WriteCfgValue("SecondaryColor", SecondaryColor, path)
                        WriteCfgValue("PearlescentColor", 0, path)
                    End If
                    If document.Name = "HasCustomPrimaryColor" Then
                        HasCustomPrimaryColor = document.ReadInnerXml.ToString()
                        If HasCustomPrimaryColor = "true" Then WriteCfgValue("HasCustomPrimaryColor", "True", path)
                        If HasCustomPrimaryColor = "false" Then WriteCfgValue("HasCustomPrimaryColor", "False", path)
                    End If
                    If document.Name = "HasCustomSecondaryColor" Then
                        HasCustomSecondaryColor = document.ReadInnerXml.ToString()
                        If HasCustomSecondaryColor = "true" Then WriteCfgValue("HasCustomSecondaryColor", "True", path)
                        If HasCustomSecondaryColor = "false" Then WriteCfgValue("HasCustomSecondaryColor", "False", path)
                    End If
                    If document.Name = "CustomPrimaryColorR" Then
                        CustomPrimaryColorR = document.ReadInnerXml.ToString()
                        WriteCfgValue("CustomPrimaryColorRed", CustomPrimaryColorR, path)
                    End If
                    If document.Name = "CustomPrimaryColorG" Then
                        CustomPrimaryColorG = document.ReadInnerXml.ToString()
                        WriteCfgValue("CustomPrimaryColorGreen", CustomPrimaryColorG, path)
                    End If
                    If document.Name = "CustomPrimaryColorB" Then
                        CustomPrimaryColorB = document.ReadInnerXml.ToString()
                        WriteCfgValue("CustomPrimaryColorBlue", CustomPrimaryColorB, path)
                    End If
                    If document.Name = "CustomSecondaryColorR" Then
                        CustomSecondaryColorR = document.ReadInnerXml.ToString()
                        WriteCfgValue("CustomSecondaryColorRed", CustomSecondaryColorR, path)
                    End If
                    If document.Name = "CustomSecondaryColorG" Then
                        CustomSecondaryColorG = document.ReadInnerXml.ToString()
                        WriteCfgValue("CustomSecondaryColorGreen", CustomSecondaryColorG, path)
                    End If


                    If document.Name = "CustomSecondaryColorB" Then
                        CustomSecondaryColorB = document.ReadInnerXml.ToString()
                        WriteCfgValue("CustomSecondaryColorBlue", CustomSecondaryColorB, path)
                    End If
                    If document.Name = "ExtraColor1" Then
                        ExtraColor1 = document.ReadInnerXml.ToString()
                        WriteCfgValue("RimColor", ExtraColor1, path)
                    End If
                    If document.Name = "NeonColorR" Then
                        NeonColorR = document.ReadInnerXml.ToString()
                        WriteCfgValue("NeonColorRed", NeonColorR, path)
                    End If
                    If document.Name = "NeonColorG" Then
                        NeonColorG = document.ReadInnerXml.ToString()
                        WriteCfgValue("NeonColorGreen", NeonColorG, path)
                    End If
                    If document.Name = "NeonColorB" Then
                        NeonColorB = document.ReadInnerXml.ToString()
                        WriteCfgValue("NeonColorBlue", NeonColorB, path)
                    End If
                    If document.Name = "TireSmokeR" Then
                        TireSmokeR = document.ReadInnerXml.ToString()
                        WriteCfgValue("TyreSmokeColorRed", TireSmokeR, path)
                    End If
                    If document.Name = "TireSmokeG" Then
                        TireSmokeG = document.ReadInnerXml.ToString()
                        WriteCfgValue("TyreSmokeColorGreen", TireSmokeG, path)
                    End If
                    If document.Name = "TireSmokeB" Then
                        TireSmokeB = document.ReadInnerXml.ToString()
                        WriteCfgValue("TyreSmokeColorBlue", TireSmokeB, path)
                    End If
                    If document.Name = "WheelType" Then
                        WheelType = document.ReadInnerXml.ToString()
                        WriteCfgValue("WheelType", WheelType, path)
                        WriteCfgValue("Livery", -1, path)
                    End If
                    If document.Name = "PlateType" Then
                        PlateType = document.ReadInnerXml.ToString()
                        WriteCfgValue("PlateType", PlateType, path)
                    End If


                    If document.Name = "NumberPlate" Then
                        NumberPlate = document.ReadInnerXml.ToString()
                        WriteCfgValue("PlateNumber", NumberPlate, path)
                    End If
                    If document.Name = "Tint" Then
                        Tint = document.ReadInnerXml.ToString()
                        WriteCfgValue("WindowTint", Tint, path)
                    End If
                    If document.Name = "CanTyresBurst" Then
                        CanTyresBurst = document.ReadInnerXml.ToString()
                        If CanTyresBurst = "true" Then WriteCfgValue("BulletproofTyres", "True", path)
                        If CanTyresBurst = "false" Then WriteCfgValue("BulletproofTyres", "False", path)
                        WriteCfgValue("Active", "False", path)
                    End If
                    If document.Name = "WheelVariation1" Then
                        WheelVariation1 = document.ReadInnerXml.ToString()
                        If WheelVariation1 = "true" Then WriteCfgValue("FrontTireVariation", "True", path)
                        If WheelVariation1 = "false" Then WriteCfgValue("FrontTireVariation", "False", path)
                    End If
                    If document.Name = "WheelVariation2" Then
                        WheelVariation2 = document.ReadInnerXml.ToString()
                        If WheelVariation2 = "true" Then WriteCfgValue("BackTireVariation", "True", path)
                        If WheelVariation2 = "false" Then WriteCfgValue("BackTireVariation", "False", path)
                    End If
                End If
            End While
            document.Close()

            Dim xmldata As XmlDataDocument = New XmlDataDocument()
            xmldata.DataSet.ReadXml(filename)

            DataGridView1.DataSource = xmldata.DataSet
            DataGridView1.DataMember = "Mods"

            WriteCfgValue("Spoiler", DataGridView1.Item(0, 0).Value, path)
            WriteCfgValue("FrontBumper", DataGridView1.Item(1, 0).Value, path)
            WriteCfgValue("RearBumper", DataGridView1.Item(2, 0).Value, path)
            WriteCfgValue("SideSkirt", DataGridView1.Item(3, 0).Value, path)
            WriteCfgValue("Exhaust", DataGridView1.Item(4, 0).Value, path)
            WriteCfgValue("Frame", DataGridView1.Item(5, 0).Value, path)
            WriteCfgValue("Grille", DataGridView1.Item(6, 0).Value, path)
            WriteCfgValue("Hood", DataGridView1.Item(7, 0).Value, path)
            WriteCfgValue("Fender", DataGridView1.Item(8, 0).Value, path)
            WriteCfgValue("RightFender", DataGridView1.Item(9, 0).Value, path)

            WriteCfgValue("Roof", DataGridView1.Item(10, 0).Value, path)
            WriteCfgValue("Engine", DataGridView1.Item(11, 0).Value, path)
            WriteCfgValue("Brakes", DataGridView1.Item(12, 0).Value, path)
            WriteCfgValue("Transmission", DataGridView1.Item(13, 0).Value, path)
            WriteCfgValue("Horn", DataGridView1.Item(14, 0).Value, path)
            WriteCfgValue("Suspension", DataGridView1.Item(15, 0).Value, path)
            WriteCfgValue("Armor", DataGridView1.Item(16, 0).Value, path)
            WriteCfgValue("FrontWheels", DataGridView1.Item(23, 0).Value, path)
            WriteCfgValue("BackWheels", DataGridView1.Item(24, 0).Value, path)
            WriteCfgValue("TwentyFive", DataGridView1.Item(25, 0).Value, path)

            WriteCfgValue("TwentySix", DataGridView1.Item(26, 0).Value, path)
            WriteCfgValue("TwentySeven", DataGridView1.Item(27, 0).Value, path)
            WriteCfgValue("TwentyEight", DataGridView1.Item(28, 0).Value, path)
            WriteCfgValue("TwentyNine", DataGridView1.Item(29, 0).Value, path)
            WriteCfgValue("ThirtyZero", DataGridView1.Item(30, 0).Value, path)
            WriteCfgValue("ThirtyOne", DataGridView1.Item(31, 0).Value, path)
            'WriteCfgValue("ThirtyTwo", DataGridView1.Item(32, 0).Value, path)
            'WriteCfgValue("ThirtyThree", DataGridView1.Item(33, 0).Value, path)
            'WriteCfgValue("ThirtyFour", DataGridView1.Item(34, 0).Value, path)
            'WriteCfgValue("ThirtyFive", DataGridView1.Item(35, 0).Value, path)

            'WriteCfgValue("ThirtySix", DataGridView1.Item(36, 0).Value, path)
            'WriteCfgValue("ThirtySeven", DataGridView1.Item(37, 0).Value, path)
            'WriteCfgValue("ThirtyEight", DataGridView1.Item(38, 0).Value, path)
            'WriteCfgValue("ThirtyNine", DataGridView1.Item(39, 0).Value, path)
            'WriteCfgValue("ForthyZero", DataGridView1.Item(40, 0).Value, path)
            'WriteCfgValue("ForthyOne", DataGridView1.Item(41, 0).Value, path)
            'WriteCfgValue("ForthyTwo", DataGridView1.Item(42, 0).Value, path)
            'WriteCfgValue("ForthyThree", DataGridView1.Item(43, 0).Value, path)
            'WriteCfgValue("ForthyFour", DataGridView1.Item(44, 0).Value, path)
            'WriteCfgValue("ForthyFive", DataGridView1.Item(45, 0).Value, path)

            'WriteCfgValue("ForthySix", DataGridView1.Item(46, 0).Value, path)
            'WriteCfgValue("ForthySeven", DataGridView1.Item(47, 0).Value, path)
            'WriteCfgValue("ForthyEight", DataGridView1.Item(48, 0).Value, path)

            DataGridView1.DataSource = Nothing
            DataGridView1.Rows.Clear()
            DataGridView1.DataSource = xmldata.DataSet
            DataGridView1.DataMember = "ToggleMods"

            If DataGridView1.Item(18, 0).Value = "true" Then WriteCfgValue("Turbo", "True", path)
            If DataGridView1.Item(18, 0).Value = "false" Then WriteCfgValue("Turbo", "False", path)
            If DataGridView1.Item(22, 0).Value = "true" Then WriteCfgValue("XenonHeadlights", "True", path)
            If DataGridView1.Item(22, 0).Value = "false" Then WriteCfgValue("XenonHeadlights", "False", path)

            DataGridView1.DataSource = Nothing
            DataGridView1.Rows.Clear()
            DataGridView1.DataSource = xmldata.DataSet
            DataGridView1.DataMember = "NeonEnabled"

            If DataGridView1.Item(0, 0).Value = "true" Then
                WriteCfgValue("HasNeonLightBack", "False", path)
                WriteCfgValue("HasNeonLightFront", "False", path)
                WriteCfgValue("HasNeonLightLeft", "False", path)
                WriteCfgValue("HasNeonLightRight", "False", path)
            ElseIf DataGridView1.Item(1, 0).Value = "true" Then
                WriteCfgValue("HasNeonLightBack", "False", path)
                WriteCfgValue("HasNeonLightFront", "True", path)
                WriteCfgValue("HasNeonLightLeft", "False", path)
                WriteCfgValue("HasNeonLightRight", "False", path)
            ElseIf DataGridView1.Item(2, 0).Value = "true" Then
                WriteCfgValue("HasNeonLightBack", "True", path)
                WriteCfgValue("HasNeonLightFront", "False", path)
                WriteCfgValue("HasNeonLightLeft", "False", path)
                WriteCfgValue("HasNeonLightRight", "False", path)
            ElseIf DataGridView1.Item(3, 0).Value = "true" Then
                WriteCfgValue("HasNeonLightBack", "False", path)
                WriteCfgValue("HasNeonLightFront", "False", path)
                WriteCfgValue("HasNeonLightLeft", "True", path)
                WriteCfgValue("HasNeonLightRight", "True", path)
            ElseIf DataGridView1.Item(4, 0).Value = "true" Then
                WriteCfgValue("HasNeonLightBack", "True", path)
                WriteCfgValue("HasNeonLightFront", "True", path)
                WriteCfgValue("HasNeonLightLeft", "False", path)
                WriteCfgValue("HasNeonLightRight", "False", path)
            ElseIf DataGridView1.Item(5, 0).Value = "true" Then
                WriteCfgValue("HasNeonLightBack", "False", path)
                WriteCfgValue("HasNeonLightFront", "True", path)
                WriteCfgValue("HasNeonLightLeft", "True", path)
                WriteCfgValue("HasNeonLightRight", "True", path)
            ElseIf DataGridView1.Item(6, 0).Value = "true" Then
                WriteCfgValue("HasNeonLightBack", "True", path)
                WriteCfgValue("HasNeonLightFront", "False", path)
                WriteCfgValue("HasNeonLightLeft", "True", path)
                WriteCfgValue("HasNeonLightRight", "True", path)
            ElseIf DataGridView1.Item(7, 0).Value = "true" Then
                WriteCfgValue("HasNeonLightBack", "True", path)
                WriteCfgValue("HasNeonLightFront", "True", path)
                WriteCfgValue("HasNeonLightLeft", "True", path)
                WriteCfgValue("HasNeonLightRight", "True", path)
            Else
                WriteCfgValue("HasNeonLightBack", "False", path)
                WriteCfgValue("HasNeonLightFront", "False", path)
                WriteCfgValue("HasNeonLightLeft", "False", path)
                WriteCfgValue("HasNeonLightRight", "False", path)
            End If

            DataGridView1.DataSource = Nothing
            DataGridView1.Rows.Clear()
            DataGridView1.DataSource = xmldata.DataSet
            DataGridView1.DataMember = "Extras"

            If DataGridView1.Item(0, 0).Value = 0 Then WriteCfgValue("ExtraOne", "False", path) Else WriteCfgValue("ExtraOne", "True ", path)
            If DataGridView1.Item(1, 0).Value = 0 Then WriteCfgValue("ExtraTwo", "False", path) Else WriteCfgValue("ExtraTwo", "True ", path)
            If DataGridView1.Item(2, 0).Value = 0 Then WriteCfgValue("ExtraThree", "False", path) Else WriteCfgValue("ExtraThree", "True ", path)
            If DataGridView1.Item(3, 0).Value = 0 Then WriteCfgValue("ExtraFour", "False", path) Else WriteCfgValue("ExtraFour", "True ", path)
            If DataGridView1.Item(4, 0).Value = 0 Then WriteCfgValue("ExtraFive", "False", path) Else WriteCfgValue("ExtraFive", "True ", path)
            If DataGridView1.Item(5, 0).Value = 0 Then WriteCfgValue("ExtraSix", "False", path) Else WriteCfgValue("ExtraSix", "True ", path)
            If DataGridView1.Item(6, 0).Value = 0 Then WriteCfgValue("ExtraSeven", "False", path) Else WriteCfgValue("ExtraSeven", "True ", path)
            If DataGridView1.Item(7, 0).Value = 0 Then WriteCfgValue("ExtraEight", "False", path) Else WriteCfgValue("ExtraEight", "True ", path)
            If DataGridView1.Item(8, 0).Value = 0 Then WriteCfgValue("ExtraNine", "False", path) Else WriteCfgValue("ExtraNine", "True ", path)

            DataGridView1.DataSource = Nothing
            DataGridView1.Rows.Clear()
        Catch ex As Exception
            Log(ex.Message)
        End Try
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            Directory = FolderBrowserDialog1.SelectedPath
            RefreshListviews()
        End If
    End Sub

    Private Sub StartReadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartReadToolStripMenuItem.Click
        If txtGarage.Text = Nothing Then
            MsgBox("Really Nigga?", MsgBoxStyle.Critical, "Error")
        ElseIf txtFloor.Text = Nothing Then
            MsgBox("Really Nigga?", MsgBoxStyle.Critical, "Error")
        ElseIf txtApartment.Text = Nothing Then
            MsgBox("Really Nigga?", MsgBoxStyle.Critical, "Error")
        Else
            tsProgress.Value = 0
            StartReadToolStripMenuItem.Enabled = False
            txtLog.Clear()

            Log("Creating Backup...")
            MakeBackup()

            For Each file As String In IO.Directory.GetFiles(Directory & "\" & txtGarage.Text & "\" & txtFloor.Text, "*.xml")
                tsProgress.Maximum = IO.Directory.GetFiles(Directory & "\" & txtGarage.Text & "\" & txtFloor.Text, "*.xml").Length
                If IO.File.Exists(file) Then
                    tsProgress.Value += 1
                    RenameData(file, IO.Path.GetFileNameWithoutExtension(file))
                    GetData(file, IO.Path.GetFileNameWithoutExtension(file))
                End If
            Next
            Log("Restoring data...")
            RestoreBackup()
            Log("Finalizing...")
            RenameFilesBackToCFG()
            Log("Removing temporary data...")
            IO.Directory.Delete(Directory & "\" & txtGarage.Text & "\" & txtFloor.Text & "\Backup", True)

            Log("Complete.")
            'Process.Start(Directory)
            MsgBox("Conversion Complete.", MsgBoxStyle.Information, "Successful")
            StartReadToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub lvGarage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvGarage.SelectedIndexChanged
        txtGarage.Text = lvGarage.SelectedItems(0).Text
        lvFloor.Items.Clear()

        For Each flrFolder As String In IO.Directory.GetDirectories(Directory & "\" & lvGarage.SelectedItems(0).Text)
            Dim dirInfo As New IO.DirectoryInfo(flrFolder)
            lvFloor.Items.Add(dirInfo.Name)
        Next
    End Sub

    Private Sub lvFloor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvFloor.SelectedIndexChanged
        txtFloor.Text = lvFloor.SelectedItems(0).Text
    End Sub

    Private Sub lvApartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvApartment.SelectedIndexChanged
        txtApartment.Text = lvApartment.SelectedItems(0).Text
    End Sub
End Class