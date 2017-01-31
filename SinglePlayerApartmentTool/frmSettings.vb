Public Class frmSettings

    Private settingFile As String = Application.StartupPath & "\setting.cfg"

    Private Sub ReadLanguage()
        Dim file As String = (Application.StartupPath & "\Languages\" & My.Settings.Language & ".cfg")
        Me.Text = ReadCfgValue("TabSettings", file)
        Me.Label1.Text = CFGread.ReadCfgValue("KeyboardKey", file)
        Me.Label22.Text = CFGread.ReadCfgValue("ControllerKeys", file)
        Me.Label2.Text = CFGread.ReadCfgValue("AlwaysEnableOnlineMapsTitle", file)
        Me.Label8.Text = CFGread.ReadCfgValue("AlwaysEnableOnlineMapsDesc", file)
        Me.Label3.Text = CFGread.ReadCfgValue("NeverEnableOnlineMapsTitle", file)
        Me.Label9.Text = CFGread.ReadCfgValue("NeverEnableOnlineMapsDesc", file)
        Me.Label4.Text = CFGread.ReadCfgValue("WardrobeScenarioTitle", file)
        Me.Label10.Text = CFGread.ReadCfgValue("WardrobeScenarioDesc", file)
        Me.Label12.Text = CFGread.ReadCfgValue("CreateFileMethodTitle", file)
        Me.Label11.Text = CFGread.ReadCfgValue("CreateFileMethodDesc", file)
        Me.Label19.Text = CFGread.ReadCfgValue("PicturePreviewPos", file)
        Me.Label20.Text = CFGread.ReadCfgValue("VehicleSpawn", file)
        Me.Label21.Text = CFGread.ReadCfgValue("Volume", file)
        Me.GroupBox2.Text = CFGread.ReadCfgValue("AptEnableDisable", file)
        Me.Label13.Text = CFGread.ReadCfgValue("AptHighEnd", file)
        Me.Label14.Text = CFGread.ReadCfgValue("AptStiltHouse", file)
        Me.Label15.Text = CFGread.ReadCfgValue("AptMediumEnd", file)
        Me.Label16.Text = CFGread.ReadCfgValue("AptLowEnd", file)
        Me.cb3AS.Text = CFGread.ReadCfgValue("3AltaName", file)
        Me.cb4IW.Text = CFGread.ReadCfgValue("4IntegrityName", file)
        Me.cbDPH.Text = CFGread.ReadCfgValue("DelPerroName", file)
        Me.cbET.Text = CFGread.ReadCfgValue("EclipseName", file)
        Me.cbRM.Text = CFGread.ReadCfgValue("RichardName", file)
        Me.cbTT.Text = CFGread.ReadCfgValue("TinselName", file)
        Me.cbWP.Text = CFGread.ReadCfgValue("WeazelName", file)
        Me.cb2862.Text = ("2862 " & CFGread.ReadCfgValue("2862Name", file))
        Me.cb2868.Text = ("2868 " & CFGread.ReadCfgValue("2868Name", file))
        Me.cb2874.Text = ("2874 " & CFGread.ReadCfgValue("2874Name", file))
        Me.cb2113.Text = ("2113 " & CFGread.ReadCfgValue("2113Name", file))
        Me.cb2117.Text = ("2117 " & CFGread.ReadCfgValue("2117Name", file))
        Me.cb2044.Text = ("2044 " & CFGread.ReadCfgValue("2044Name", file))
        Me.cb2045.Text = ("2045 " & CFGread.ReadCfgValue("2045Name", file))
        Me.cb3677.Text = ("3677 " & CFGread.ReadCfgValue("3677Name", file))
        Me.cb3655.Text = ("3655 " & CFGread.ReadCfgValue("3655Name", file))
        Me.cbDT.Text = CFGread.ReadCfgValue("DreamName", file)
        Me.cbCA.Text = CFGread.ReadCfgValue("CougarName", file)
        Me.cbBCA.Text = CFGread.ReadCfgValue("BayCityName", file)
        Me.cb0184MR.Text = CFGread.ReadCfgValue("MiltonRdName", file)
        Me.cbSRD.Text = CFGread.ReadCfgValue("0325SouthRockfordName", file)
        Me.cbSMMD.Text = CFGread.ReadCfgValue("SouthMoMiltonName", file)
        Me.cb0604LLB.Text = CFGread.ReadCfgValue("0604LasLagunasName", file)
        Me.cbSA.Text = CFGread.ReadCfgValue("SpanishAveName", file)
        Me.cbBDP.Text = CFGread.ReadCfgValue("BlvdDelPerroName", file)
        Me.cb1162PS.Text = CFGread.ReadCfgValue("PowerStName", file)
        Me.cb1237PS.Text = CFGread.ReadCfgValue("ProsperityStName", file)
        Me.cbSVS.Text = CFGread.ReadCfgValue("SanVitasStName", file)
        Me.cb2143LLB.Text = CFGread.ReadCfgValue("2143LasLagunasName", file)
        Me.cbTR.Text = CFGread.ReadCfgValue("TheRoyaleName", file)
        Me.cbHA.Text = CFGread.ReadCfgValue("HangmanAveName", file)
        Me.cbSR.Text = CFGread.ReadCfgValue("SustanciaRdName", file)
        Me.cb4401PD.Text = ("4401 " & CFGread.ReadCfgValue("4401ProcopioDrName", file))
        Me.cb4584PD.Text = ("4584 " & CFGread.ReadCfgValue("4584ProcopioDrName", file))
        Me.cbVB.Text = CFGread.ReadCfgValue("VespucciName", file)
        Me.cbZA.Text = CFGread.ReadCfgValue("ZancudoAveName", file)
        Me.cbPB.Text = CFGread.ReadCfgValue("PaletoBlvdName", file)
        Me.cbGA.Text = CFGread.ReadCfgValue("GrapeseedAveName", file)
        Me.cb0112SRD.Text = CFGread.ReadCfgValue("0112SouthRockfordName", file)
        Me.GroupBox1.Text = CFGread.ReadCfgValue("PhoneIndex", file)
        Me.Label5.Text = CFGread.ReadCfgValue("Michael", file)
        Me.Label6.Text = CFGread.ReadCfgValue("Franklin", file)
        Me.Label7.Text = CFGread.ReadCfgValue("Trevor", file)
        Me.LinkLabel1.Text = CFGread.ReadCfgValue("HowToGetPhoneIndex", file)
        Me.btnSaveSetting.Text = CFGread.ReadCfgValue("SaveButton", file)
        Label17.Text = ReadCfgValue("PhoneContact", file)
    End Sub

    Private Sub txtPhoneKey_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPhoneKey.KeyDown
        Dim keyDown As Integer = e.KeyCode
        txtPhoneKey.Text = [Enum].GetName(GetType(Keys), keyDown)
    End Sub

    Private Enum XboxKeys
        LeftAxisX = 218
        LeftAxisY = 219
        RightAxisX = 220
        RightAxisY = 221
        Y = 222
        A = 223
        X = 224
        B = 225
        LB = 226
        RB = 227
        LT = 228
        RT = 229
        LS = 230
        RS = 231
        PadUp = 232
        PadDown = 233
        PadLeft = 234
        PadRight = 235
        [Select] = 236
    End Enum

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ReadLanguage()
            txtPhoneKey.Text = ReadCfgValue("Mechanic", settingFile)
            cbXBOX.SelectedItem = [Enum].GetName(GetType(XboxKeys), CInt(ReadCfgValue("PadMechanic", settingFile)))
            cbXBOX2.SelectedItem = [Enum].GetName(GetType(XboxKeys), CInt(ReadCfgValue("SecondPadMechanic", settingFile)))
            cmbAlysEnabMP.SelectedItem = ReadCfgValue("AlwaysEnableMPMaps", settingFile)
            cmbNeverEnbMP.SelectedItem = ReadCfgValue("NeverEnableMPMaps", settingFile)
            cmbWardrobe.Text = ReadCfgValue("WardrobeScenario", settingFile)
            cmbCreateFileMethod.SelectedItem = ReadCfgValue("CreateFileMethod", settingFile)
            numFranklin.Value = ReadCfgValue("FranklinPhoneIndex", settingFile)
            numMichael.Value = ReadCfgValue("MichaelPhoneIndex", settingFile)
            numTrevor.Value = ReadCfgValue("TrevorPhoneIndex", settingFile)
            txtPointX.Text = ReadCfgValue("PointX", settingFile)
            txtPointY.Text = ReadCfgValue("PointY", settingFile)
            Dim VS As String = ReadCfgValue("VehicleSpawn", settingFile)
            If VS = "1" Then cbVehSpawn.SelectedItem = "Mechanic Drive to your Position" Else cbVehSpawn.SelectedItem = "Nearest Position on Street"
            tbVolume.Value = CInt(ReadCfgValue("Volume", settingFile))
            lblVolumePercentage.Text = tbVolume.Value & "%"
            cmbPhoneContact.SelectedItem = ReadCfgValue("PhoneContact", settingFile)
            If ReadCfgValue("3AltaStreet", settingFile) = "Enable" Then cb3AS.Checked = True
            If ReadCfgValue("4IntegrityWay", settingFile) = "Enable" Then cb4IW.Checked = True
            If ReadCfgValue("DelPerroHeights", settingFile) = "Enable" Then cbDPH.Checked = True
            If ReadCfgValue("DreamTower", settingFile) = "Enable" Then cbDT.Checked = True
            If ReadCfgValue("EclipseTower", settingFile) = "Enable" Then cbET.Checked = True
            If ReadCfgValue("RichardMajestic", settingFile) = "Enable" Then cbRM.Checked = True
            If ReadCfgValue("TinselTower", settingFile) = "Enable" Then cbTT.Checked = True
            If ReadCfgValue("VespucciBlvd", settingFile) = "Enable" Then cbVB.Checked = True
            If ReadCfgValue("WeazelPlaza", settingFile) = "Enable" Then cbWP.Checked = True
            If ReadCfgValue("2862Hillcrest", settingFile) = "Enable" Then cb2862.Checked = True
            If ReadCfgValue("2868Hillcrest", settingFile) = "Enable" Then cb2868.Checked = True
            If ReadCfgValue("2874Hillcrest", settingFile) = "Enable" Then cb2874.Checked = True
            If ReadCfgValue("2113MadWayne", settingFile) = "Enable" Then cb2113.Checked = True
            If ReadCfgValue("2117MiltonRd", settingFile) = "Enable" Then cb2117.Checked = True
            If ReadCfgValue("2044NorthConker", settingFile) = "Enable" Then cb2044.Checked = True
            If ReadCfgValue("2045NorthConker", settingFile) = "Enable" Then cb2045.Checked = True
            If ReadCfgValue("3677Whispymound", settingFile) = "Enable" Then cb3677.Checked = True
            If ReadCfgValue("3655WildOats", settingFile) = "Enable" Then cb3655.Checked = True
            If ReadCfgValue("CougarAve", settingFile) = "Enable" Then cbCA.Checked = True
            If ReadCfgValue("BayCityAve", settingFile) = "Enable" Then cbBCA.Checked = True
            If ReadCfgValue("0184MiltonRd", settingFile) = "Enable" Then cb0184MR.Checked = True
            If ReadCfgValue("0325SouthRockfordDr", settingFile) = "Enable" Then cbSRD.Checked = True
            If ReadCfgValue("SouthMoMiltonDr", settingFile) = "Enable" Then cbSMMD.Checked = True
            If ReadCfgValue("0604LasLagunasBlvd", settingFile) = "Enable" Then cb0604LLB.Checked = True
            If ReadCfgValue("SpanishAve", settingFile) = "Enable" Then cbSA.Checked = True
            If ReadCfgValue("BlvdDelPerro", settingFile) = "Enable" Then cbBDP.Checked = True
            If ReadCfgValue("PowerSt", settingFile) = "Enable" Then cb1162PS.Checked = True
            If ReadCfgValue("ProsperitySt", settingFile) = "Enable" Then cb1237PS.Checked = True
            If ReadCfgValue("SanVitasSt", settingFile) = "Enable" Then cbSVS.Checked = True
            If ReadCfgValue("2143LasLagunasBlvd", settingFile) = "Enable" Then cb2143LLB.Checked = True
            If ReadCfgValue("TheRoyale", settingFile) = "Enable" Then cbTR.Checked = True
            If ReadCfgValue("HangmanAve", settingFile) = "Enable" Then cbHA.Checked = True
            If ReadCfgValue("SustanciaRd", settingFile) = "Enable" Then cbSR.Checked = True
            If ReadCfgValue("4401ProcopioDr", settingFile) = "Enable" Then cb4401PD.Checked = True
            If ReadCfgValue("4584ProcopioDr", settingFile) = "Enable" Then cb4584PD.Checked = True
            If ReadCfgValue("0112SouthRockfordDr", settingFile) = "Enable" Then cb0112SRD.Checked = True
            If ReadCfgValue("ZancudoAve", settingFile) = "Enable" Then cbZA.Checked = True
            If ReadCfgValue("PaletoBlvd", settingFile) = "Enable" Then cbPB.Checked = True
            If ReadCfgValue("GrapeseedAve", settingFile) = "Enable" Then cbGA.Checked = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Single Player Apartment")
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MsgBox("To get Phone Index, Bring up your Phone in game, Go to Contacts, and count for yourself. Start from 0.", MsgBoxStyle.Information, "Phone Indexes")
    End Sub

    Private Sub btnSaveSetting_Click(sender As Object, e As EventArgs) Handles btnSaveSetting.Click
        Try
            WriteCfgValue("Mechanic", txtPhoneKey.Text, settingFile)
            WriteCfgValue("PadMechanic", CInt(DirectCast([Enum].Parse(GetType(XboxKeys), cbXBOX.SelectedItem), XboxKeys)), settingFile)
            WriteCfgValue("SecondPadMechanic", CInt(DirectCast([Enum].Parse(GetType(XboxKeys), cbXBOX2.SelectedItem), XboxKeys)), settingFile)
            WriteCfgValue("AlwaysEnableMPMaps", cmbAlysEnabMP.SelectedItem, settingFile)
            WriteCfgValue("NeverEnableMPMaps", cmbNeverEnbMP.SelectedItem, settingFile)
            WriteCfgValue("WardrobeScenario", cmbWardrobe.Text, settingFile)
            WriteCfgValue("CreateFileMethod", cmbCreateFileMethod.SelectedItem, settingFile)
            WriteCfgValue("FranklinPhoneIndex", numFranklin.Value, settingFile)
            WriteCfgValue("MichaelPhoneIndex", numMichael.Value, settingFile)
            WriteCfgValue("TrevorPhoneIndex", numTrevor.Value, settingFile)
            WriteCfgValue("PointX", txtPointX.Text, settingFile)
            WriteCfgValue("PointY", txtPointY.Text, settingFile)
            WriteCfgValue("PhoneContact", cmbPhoneContact.SelectedItem, settingFile)
            If cbVehSpawn.SelectedItem = "Mechanic Drive to your Position" Then WriteCfgValue("VehicleSpawn", "1", settingFile) Else WriteCfgValue("VehicleSpawn", "2", settingFile)
            WriteCfgValue("Volume", tbVolume.Value, settingFile)
            If cb3AS.Checked = True Then WriteCfgValue("3AltaStreet", "Enable", settingFile) Else WriteCfgValue("3AltaStreet", "Disabled", settingFile)
            If cb4IW.Checked = True Then WriteCfgValue("4IntegrityWay", "Enable", settingFile) Else WriteCfgValue("4IntegrityWay", "Disabled", settingFile)
            If cbDPH.Checked = True Then WriteCfgValue("DelPerroHeights", "Enable", settingFile) Else WriteCfgValue("DelPerroHeights", "Disabled", settingFile)
            If cbDT.Checked = True Then WriteCfgValue("DreamTower", "Enable", settingFile) Else WriteCfgValue("DreamTower", "Disabled", settingFile)
            If cbET.Checked = True Then WriteCfgValue("EclipseTower", "Enable", settingFile) Else WriteCfgValue("EclipseTower", "Disabled", settingFile)
            If cbRM.Checked = True Then WriteCfgValue("RichardMajestic", "Enable", settingFile) Else WriteCfgValue("RichardMajestic", "Disabled", settingFile)
            If cbTT.Checked = True Then WriteCfgValue("TinselTower", "Enable", settingFile) Else WriteCfgValue("TinselTower", "Disabled", settingFile)
            If cbVB.Checked = True Then WriteCfgValue("VespucciBlvd", "Enable", settingFile) Else WriteCfgValue("VespucciBlvd", "Disabled", settingFile)
            If cbWP.Checked = True Then WriteCfgValue("WeazelPlaza", "Enable", settingFile) Else WriteCfgValue("WeazelPlaza", "Disabled", settingFile)
            If cb2862.Checked = True Then WriteCfgValue("2862Hillcrest", "Enable", settingFile) Else WriteCfgValue("2862Hillcrest", "Disabled", settingFile)
            If cb2868.Checked = True Then WriteCfgValue("2868Hillcrest", "Enable", settingFile) Else WriteCfgValue("2868Hillcrest", "Disabled", settingFile)
            If cb2874.Checked = True Then WriteCfgValue("2874Hillcrest", "Enable", settingFile) Else WriteCfgValue("2874Hillcrest", "Disabled", settingFile)
            If cb2113.Checked = True Then WriteCfgValue("2113MadWayne", "Enable", settingFile) Else WriteCfgValue("2113MadWayne", "Disabled", settingFile)
            If cb2117.Checked = True Then WriteCfgValue("2117MiltonRd", "Enable", settingFile) Else WriteCfgValue("2117MiltonRd", "Disabled", settingFile)
            If cb2044.Checked = True Then WriteCfgValue("2044NorthConker", "Enable", settingFile) Else WriteCfgValue("2044NorthConker", "Disabled", settingFile)
            If cb2045.Checked = True Then WriteCfgValue("2045NorthConker", "Enable", settingFile) Else WriteCfgValue("2045NorthConker", "Disabled", settingFile)
            If cb3677.Checked = True Then WriteCfgValue("3677Whispymound", "Enable", settingFile) Else WriteCfgValue("3677Whispymound", "Disabled", settingFile)
            If cb3655.Checked = True Then WriteCfgValue("3655WildOats", "Enable", settingFile) Else WriteCfgValue("3655WildOats", "Disabled", settingFile)
            If cbCA.Checked = True Then WriteCfgValue("CougarAve", "Enable", settingFile) Else WriteCfgValue("CougarAve", "Disabled", settingFile)
            If cbBCA.Checked = True Then WriteCfgValue("BayCityAve", "Enable", settingFile) Else WriteCfgValue("BayCityAve", "Disabled", settingFile)
            If cb0184MR.Checked = True Then WriteCfgValue("0184MiltonRd", "Enable", settingFile) Else WriteCfgValue("0184MiltonRd", "Disabled", settingFile)
            If cbSRD.Checked = True Then WriteCfgValue("0325SouthRockfordDr", "Enable", settingFile) Else WriteCfgValue("0325SouthRockfordDr", "Disabled", settingFile)
            If cbSMMD.Checked = True Then WriteCfgValue("SouthMoMiltonDr", "Enable", settingFile) Else WriteCfgValue("SouthMoMiltonDr", "Disabled", settingFile)
            If cb0604LLB.Checked = True Then WriteCfgValue("0604LasLagunasBlvd", "Enable", settingFile) Else WriteCfgValue("0604LasLagunasBlvd", "Disabled", settingFile)
            If cbSA.Checked = True Then WriteCfgValue("SpanishAve", "Enable", settingFile) Else WriteCfgValue("SpanishAve", "Disabled", settingFile)
            If cbBDP.Checked = True Then WriteCfgValue("BlvdDelPerro", "Enable", settingFile) Else WriteCfgValue("BlvdDelPerro", "Disabled", settingFile)
            If cb1162PS.Checked = True Then WriteCfgValue("PowerSt", "Enable", settingFile) Else WriteCfgValue("PowerSt", "Disabled", settingFile)
            If cb1237PS.Checked = True Then WriteCfgValue("ProsperitySt", "Enable", settingFile) Else WriteCfgValue("ProsperitySt", "Disabled", settingFile)
            If cbSVS.Checked = True Then WriteCfgValue("SanVitasSt", "Enable", settingFile) Else WriteCfgValue("SanVitasSt", "Disabled", settingFile)
            If cb2143LLB.Checked = True Then WriteCfgValue("2143LasLagunasBlvd", "Enable", settingFile) Else WriteCfgValue("2143LasLagunasBlvd", "Disabled", settingFile)
            If cbTR.Checked = True Then WriteCfgValue("TheRoyale", "Enable", settingFile) Else WriteCfgValue("TheRoyale", "Disabled", settingFile)
            If cbHA.Checked = True Then WriteCfgValue("HangmanAve", "Enable", settingFile) Else WriteCfgValue("HangmanAve", "Disabled", settingFile)
            If cbSR.Checked = True Then WriteCfgValue("SustanciaRd", "Enable", settingFile) Else WriteCfgValue("SustanciaRd", "Disabled", settingFile)
            If cb4401PD.Checked = True Then WriteCfgValue("4401ProcopioDr", "Enable", settingFile) Else WriteCfgValue("4401ProcopioDr", "Disabled", settingFile)
            If cb4584PD.Checked = True Then WriteCfgValue("4584ProcopioDr", "Enable", settingFile) Else WriteCfgValue("4584ProcopioDr", "Disabled", settingFile)
            If cb0112SRD.Checked = True Then WriteCfgValue("0112SouthRockfordDr", "Enable", settingFile) Else WriteCfgValue("0112SouthRockfordDr", "Disabled", settingFile)
            If cbZA.Checked = True Then WriteCfgValue("ZancudoAve", "Enable", settingFile) Else WriteCfgValue("ZancudoAve", "Disabled", settingFile)
            If cbPB.Checked = True Then WriteCfgValue("PaletoBlvd", "Enable", settingFile) Else WriteCfgValue("PaletoBlvd", "Disabled", settingFile)
            If cbGA.Checked = True Then WriteCfgValue("GrapeseedAve", "Enable", settingFile) Else WriteCfgValue("GrapeseedAve", "Disabled", settingFile)
            MsgBox("Settings File Saved Successfully.", MsgBoxStyle.Information, "Single Player Apartment")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Single Player Apartment")
        End Try
    End Sub

    Private Sub tbVolume_Scroll(sender As Object, e As EventArgs) Handles tbVolume.Scroll
        lblVolumePercentage.Text = tbVolume.Value & "%"
    End Sub
End Class