<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnSettings = New System.Windows.Forms.ToolStripButton()
        Me.btnSpg2Spa = New System.Windows.Forms.ToolStripButton()
        Me.btnWardrobe = New System.Windows.Forms.ToolStripButton()
        Me.btnShopping = New System.Windows.Forms.ToolStripButton()
        Me.btnMenyoo = New System.Windows.Forms.ToolStripButton()
        Me.btnLang = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ChineseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AmericanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FrenchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GermanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItalianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JapaneseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KoreanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MexicanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PolishToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PortugueseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RussianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpanishToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New MdiTabControl.TabControl()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.SinglePlayerApartmentTool.My.Resources.Resources.spa_header_2
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(857, 131)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSettings, Me.btnSpg2Spa, Me.btnWardrobe, Me.btnShopping, Me.btnMenyoo, Me.btnLang})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 131)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(857, 27)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnSettings
        '
        Me.btnSettings.Image = Global.SinglePlayerApartmentTool.My.Resources.Resources.apartment
        Me.btnSettings.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(69, 24)
        Me.btnSettings.Text = "Settings"
        '
        'btnSpg2Spa
        '
        Me.btnSpg2Spa.Image = Global.SinglePlayerApartmentTool.My.Resources.Resources.garage
        Me.btnSpg2Spa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSpg2Spa.Name = "btnSpg2Spa"
        Me.btnSpg2Spa.Size = New System.Drawing.Size(132, 24)
        Me.btnSpg2Spa.Text = "SPG Transfer to SPA"
        '
        'btnWardrobe
        '
        Me.btnWardrobe.Image = Global.SinglePlayerApartmentTool.My.Resources.Resources.clothing
        Me.btnWardrobe.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnWardrobe.Name = "btnWardrobe"
        Me.btnWardrobe.Size = New System.Drawing.Size(113, 24)
        Me.btnWardrobe.Text = "Wardrobe Editor"
        '
        'btnShopping
        '
        Me.btnShopping.Image = Global.SinglePlayerApartmentTool.My.Resources.Resources.car
        Me.btnShopping.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnShopping.Name = "btnShopping"
        Me.btnShopping.Size = New System.Drawing.Size(116, 24)
        Me.btnShopping.Text = "Dealership Editor"
        '
        'btnMenyoo
        '
        Me.btnMenyoo.Image = Global.SinglePlayerApartmentTool.My.Resources.Resources.michael
        Me.btnMenyoo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMenyoo.Name = "btnMenyoo"
        Me.btnMenyoo.Size = New System.Drawing.Size(188, 24)
        Me.btnMenyoo.Text = "Menyoo Outfit Convert to SPA"
        '
        'btnLang
        '
        Me.btnLang.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChineseToolStripMenuItem, Me.AmericanToolStripMenuItem, Me.FrenchToolStripMenuItem, Me.GermanToolStripMenuItem, Me.ItalianToolStripMenuItem, Me.JapaneseToolStripMenuItem, Me.KoreanToolStripMenuItem, Me.MexicanToolStripMenuItem, Me.PolishToolStripMenuItem, Me.PortugueseToolStripMenuItem, Me.RussianToolStripMenuItem, Me.SpanishToolStripMenuItem})
        Me.btnLang.Image = Global.SinglePlayerApartmentTool.My.Resources.Resources.american
        Me.btnLang.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnLang.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnLang.Name = "btnLang"
        Me.btnLang.Size = New System.Drawing.Size(110, 24)
        Me.btnLang.Text = "Language"
        '
        'ChineseToolStripMenuItem
        '
        Me.ChineseToolStripMenuItem.Image = Global.SinglePlayerApartmentTool.My.Resources.Resources.chinese
        Me.ChineseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ChineseToolStripMenuItem.Name = "ChineseToolStripMenuItem"
        Me.ChineseToolStripMenuItem.Size = New System.Drawing.Size(156, 26)
        Me.ChineseToolStripMenuItem.Tag = "chinese"
        Me.ChineseToolStripMenuItem.Text = "Chinese"
        '
        'AmericanToolStripMenuItem
        '
        Me.AmericanToolStripMenuItem.Image = Global.SinglePlayerApartmentTool.My.Resources.Resources.american
        Me.AmericanToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AmericanToolStripMenuItem.Name = "AmericanToolStripMenuItem"
        Me.AmericanToolStripMenuItem.Size = New System.Drawing.Size(156, 26)
        Me.AmericanToolStripMenuItem.Tag = "american"
        Me.AmericanToolStripMenuItem.Text = "English"
        '
        'FrenchToolStripMenuItem
        '
        Me.FrenchToolStripMenuItem.Image = Global.SinglePlayerApartmentTool.My.Resources.Resources.french
        Me.FrenchToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FrenchToolStripMenuItem.Name = "FrenchToolStripMenuItem"
        Me.FrenchToolStripMenuItem.Size = New System.Drawing.Size(156, 26)
        Me.FrenchToolStripMenuItem.Tag = "french"
        Me.FrenchToolStripMenuItem.Text = "French"
        '
        'GermanToolStripMenuItem
        '
        Me.GermanToolStripMenuItem.Image = Global.SinglePlayerApartmentTool.My.Resources.Resources.german
        Me.GermanToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.GermanToolStripMenuItem.Name = "GermanToolStripMenuItem"
        Me.GermanToolStripMenuItem.Size = New System.Drawing.Size(156, 26)
        Me.GermanToolStripMenuItem.Tag = "german"
        Me.GermanToolStripMenuItem.Text = "German"
        '
        'ItalianToolStripMenuItem
        '
        Me.ItalianToolStripMenuItem.Image = Global.SinglePlayerApartmentTool.My.Resources.Resources.italian
        Me.ItalianToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ItalianToolStripMenuItem.Name = "ItalianToolStripMenuItem"
        Me.ItalianToolStripMenuItem.Size = New System.Drawing.Size(156, 26)
        Me.ItalianToolStripMenuItem.Tag = "italian"
        Me.ItalianToolStripMenuItem.Text = "Italian"
        '
        'JapaneseToolStripMenuItem
        '
        Me.JapaneseToolStripMenuItem.Image = Global.SinglePlayerApartmentTool.My.Resources.Resources.japanese
        Me.JapaneseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.JapaneseToolStripMenuItem.Name = "JapaneseToolStripMenuItem"
        Me.JapaneseToolStripMenuItem.Size = New System.Drawing.Size(156, 26)
        Me.JapaneseToolStripMenuItem.Tag = "japanese"
        Me.JapaneseToolStripMenuItem.Text = "Japanese"
        '
        'KoreanToolStripMenuItem
        '
        Me.KoreanToolStripMenuItem.Image = Global.SinglePlayerApartmentTool.My.Resources.Resources.korean
        Me.KoreanToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.KoreanToolStripMenuItem.Name = "KoreanToolStripMenuItem"
        Me.KoreanToolStripMenuItem.Size = New System.Drawing.Size(156, 26)
        Me.KoreanToolStripMenuItem.Tag = "korean"
        Me.KoreanToolStripMenuItem.Text = "Korean"
        '
        'MexicanToolStripMenuItem
        '
        Me.MexicanToolStripMenuItem.Image = Global.SinglePlayerApartmentTool.My.Resources.Resources.mexican
        Me.MexicanToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MexicanToolStripMenuItem.Name = "MexicanToolStripMenuItem"
        Me.MexicanToolStripMenuItem.Size = New System.Drawing.Size(156, 26)
        Me.MexicanToolStripMenuItem.Tag = "mexican"
        Me.MexicanToolStripMenuItem.Text = "Mexican"
        '
        'PolishToolStripMenuItem
        '
        Me.PolishToolStripMenuItem.Image = Global.SinglePlayerApartmentTool.My.Resources.Resources.polish
        Me.PolishToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PolishToolStripMenuItem.Name = "PolishToolStripMenuItem"
        Me.PolishToolStripMenuItem.Size = New System.Drawing.Size(156, 26)
        Me.PolishToolStripMenuItem.Tag = "polish"
        Me.PolishToolStripMenuItem.Text = "Polish"
        '
        'PortugueseToolStripMenuItem
        '
        Me.PortugueseToolStripMenuItem.Image = Global.SinglePlayerApartmentTool.My.Resources.Resources.portuguese
        Me.PortugueseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PortugueseToolStripMenuItem.Name = "PortugueseToolStripMenuItem"
        Me.PortugueseToolStripMenuItem.Size = New System.Drawing.Size(156, 26)
        Me.PortugueseToolStripMenuItem.Tag = "portuguese"
        Me.PortugueseToolStripMenuItem.Text = "Portuguese"
        '
        'RussianToolStripMenuItem
        '
        Me.RussianToolStripMenuItem.Image = Global.SinglePlayerApartmentTool.My.Resources.Resources.russian
        Me.RussianToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RussianToolStripMenuItem.Name = "RussianToolStripMenuItem"
        Me.RussianToolStripMenuItem.Size = New System.Drawing.Size(156, 26)
        Me.RussianToolStripMenuItem.Tag = "russian"
        Me.RussianToolStripMenuItem.Text = "Russian"
        '
        'SpanishToolStripMenuItem
        '
        Me.SpanishToolStripMenuItem.Image = Global.SinglePlayerApartmentTool.My.Resources.Resources.spanish
        Me.SpanishToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SpanishToolStripMenuItem.Name = "SpanishToolStripMenuItem"
        Me.SpanishToolStripMenuItem.Size = New System.Drawing.Size(156, 26)
        Me.SpanishToolStripMenuItem.Tag = "spanish"
        Me.SpanishToolStripMenuItem.Text = "Spanish"
        '
        'TabControl1
        '
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 158)
        Me.TabControl1.MenuRenderer = Nothing
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Size = New System.Drawing.Size(857, 561)
        Me.TabControl1.TabCloseButtonImage = Nothing
        Me.TabControl1.TabCloseButtonImageDisabled = Nothing
        Me.TabControl1.TabCloseButtonImageHot = Nothing
        Me.TabControl1.TabIconSize = New System.Drawing.Size(0, 0)
        Me.TabControl1.TabIndex = 2
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 719)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Single Player Apartment Tool"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnSettings As ToolStripButton
    Friend WithEvents btnSpg2Spa As ToolStripButton
    Friend WithEvents btnWardrobe As ToolStripButton
    Friend WithEvents btnShopping As ToolStripButton
    Friend WithEvents btnMenyoo As ToolStripButton
    Friend WithEvents TabControl1 As MdiTabControl.TabControl
    Friend WithEvents btnLang As ToolStripDropDownButton
    Friend WithEvents AmericanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChineseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FrenchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GermanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ItalianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JapaneseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KoreanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MexicanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PolishToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PortugueseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RussianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SpanishToolStripMenuItem As ToolStripMenuItem
End Class
