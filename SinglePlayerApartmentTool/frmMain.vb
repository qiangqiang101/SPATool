Public Class frmMain

    Private Sub ReadLanguage()
        Dim file As String = (Application.StartupPath & "\Languages\" & My.Settings.Language & ".cfg")
        btnSettings.Text = ReadCfgValue("TabSettings", file)
        btnSettings.ToolTipText = ReadCfgValue("TabSettings", file)
        btnSpg2Spa.Text = ReadCfgValue("TabConvertSPGToSPA", file)
        btnSpg2Spa.ToolTipText = ReadCfgValue("TabConvertSPGToSPA", file)
        btnLang.Text = ReadCfgValue("TabLanguage", file)
        btnLang.ToolTipText = ReadCfgValue("TabLanguage", file)
        btnWardrobe.Text = ReadCfgValue("TabWardrobe", file)
        btnWardrobe.ToolTipText = ReadCfgValue("TabWardrobe", file)
        btnShopping.Text = ReadCfgValue("TabShopping", file)
        btnShopping.ToolTipText = ReadCfgValue("TabShopping", file)
        btnMenyoo.Text = ReadCfgValue("TabMenyoo", file)
        btnMenyoo.ToolTipText = ReadCfgValue("TabMenyoo", file)
        'ReadCfgValue("", file)
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        Dim NewForm As frmSettings = New frmSettings
        TabControl1.TabPages.Add(NewForm)
    End Sub

    Private Sub btnSpg2Spa_Click(sender As Object, e As EventArgs) Handles btnSpg2Spa.Click
        Dim NewForm As frmSpg2Spa = New frmSpg2Spa
        TabControl1.TabPages.Add(NewForm)
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim NewForm As frmSettings = New frmSettings
        TabControl1.TabPages.Add(NewForm)

        ChangeLanguage()
    End Sub

    Public Sub ChangeLanguage()
        Select Case My.Settings.Language
            Case "american"
                btnLang.Image = My.Resources.american
            Case "chinese"
                btnLang.Image = My.Resources.chinese
            Case "french"
                btnLang.Image = My.Resources.french
            Case "german"
                btnLang.Image = My.Resources.german
            Case "italian"
                btnLang.Image = My.Resources.italian
            Case "japanese"
                btnLang.Image = My.Resources.japanese
            Case "korean"
                btnLang.Image = My.Resources.korean
            Case "mexican"
                btnLang.Image = My.Resources.mexican
            Case "polish"
                btnLang.Image = My.Resources.polish
            Case "portuguese"
                btnLang.Image = My.Resources.portuguese
            Case "russian"
                btnLang.Image = My.Resources.russian
            Case "spanish"
                btnLang.Image = My.Resources.spanish
        End Select

        ReadLanguage()
    End Sub

    Private Sub AmericanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AmericanToolStripMenuItem.Click
        My.Settings.Language = AmericanToolStripMenuItem.Tag
        My.Settings.Save()
        ChangeLanguage()
    End Sub

    Private Sub ChineseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChineseToolStripMenuItem.Click
        My.Settings.Language = ChineseToolStripMenuItem.Tag
        My.Settings.Save()
        ChangeLanguage()
    End Sub

    Private Sub FrenchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FrenchToolStripMenuItem.Click
        My.Settings.Language = FrenchToolStripMenuItem.Tag
        My.Settings.Save()
        ChangeLanguage()
    End Sub

    Private Sub GermanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GermanToolStripMenuItem.Click
        My.Settings.Language = GermanToolStripMenuItem.Tag
        My.Settings.Save()
        ChangeLanguage()
    End Sub

    Private Sub ItalianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItalianToolStripMenuItem.Click
        My.Settings.Language = ItalianToolStripMenuItem.Tag
        My.Settings.Save()
        ChangeLanguage()
    End Sub

    Private Sub JapaneseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JapaneseToolStripMenuItem.Click
        My.Settings.Language = JapaneseToolStripMenuItem.Tag
        My.Settings.Save()
        ChangeLanguage()
    End Sub

    Private Sub KoreanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KoreanToolStripMenuItem.Click
        My.Settings.Language = KoreanToolStripMenuItem.Tag
        My.Settings.Save()
        ChangeLanguage()
    End Sub

    Private Sub MexicanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MexicanToolStripMenuItem.Click
        My.Settings.Language = MexicanToolStripMenuItem.Tag
        My.Settings.Save()
        ChangeLanguage()
    End Sub

    Private Sub PolishToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PolishToolStripMenuItem.Click
        My.Settings.Language = PolishToolStripMenuItem.Tag
        My.Settings.Save()
        ChangeLanguage()
    End Sub

    Private Sub PortugueseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PortugueseToolStripMenuItem.Click
        My.Settings.Language = PortugueseToolStripMenuItem.Tag
        My.Settings.Save()
        ChangeLanguage()
    End Sub

    Private Sub RussianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RussianToolStripMenuItem.Click
        My.Settings.Language = RussianToolStripMenuItem.Tag
        My.Settings.Save()
        ChangeLanguage()
    End Sub

    Private Sub SpanishToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpanishToolStripMenuItem.Click
        My.Settings.Language = SpanishToolStripMenuItem.Tag
        My.Settings.Save()
        ChangeLanguage()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles btnMenyoo.Click
        Dim NewForm As frmMenyoo = New frmMenyoo
        TabControl1.TabPages.Add(NewForm)
    End Sub

    Private Sub btnShopping_Click(sender As Object, e As EventArgs) Handles btnShopping.Click
        Dim NewForm As frmDealer = New frmDealer
        TabControl1.TabPages.Add(NewForm)
    End Sub

    Private Sub btnWardrobe_Click(sender As Object, e As EventArgs) Handles btnWardrobe.Click
        MsgBox("Coming Soon!", MsgBoxStyle.Information, "SPA Tool")
    End Sub
End Class
