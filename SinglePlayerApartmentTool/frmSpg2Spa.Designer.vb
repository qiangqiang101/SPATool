<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSpg2Spa
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsProgress = New System.Windows.Forms.ToolStripProgressBar()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.StartReadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lvGarage = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lvFloor = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvApartment = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGarage = New System.Windows.Forms.TextBox()
        Me.txtFloor = New System.Windows.Forms.TextBox()
        Me.txtApartment = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtLog
        '
        Me.txtLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtLog.Location = New System.Drawing.Point(3, 3)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ReadOnly = True
        Me.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtLog.Size = New System.Drawing.Size(820, 98)
        Me.txtLog.TabIndex = 109
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.Description = "Please Select a Folder contains SPG vehicles..."
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(433, 423)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(78, 64)
        Me.DataGridView1.TabIndex = 110
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsProgress})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 515)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(858, 22)
        Me.StatusStrip1.TabIndex = 113
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsProgress
        '
        Me.tsProgress.Name = "tsProgress"
        Me.tsProgress.Size = New System.Drawing.Size(100, 16)
        Me.tsProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(858, 24)
        Me.MenuStrip1.TabIndex = 112
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.ToolStripSeparator2, Me.StartReadToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OpenToolStripMenuItem.Text = "Browse"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        'StartReadToolStripMenuItem
        '
        Me.StartReadToolStripMenuItem.Name = "StartReadToolStripMenuItem"
        Me.StartReadToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.StartReadToolStripMenuItem.Text = "Start"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 380)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(834, 132)
        Me.TabControl1.TabIndex = 114
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtLog)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(826, 104)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Log"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lvGarage
        '
        Me.lvGarage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.lvGarage.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lvGarage.FullRowSelect = True
        Me.lvGarage.Location = New System.Drawing.Point(12, 85)
        Me.lvGarage.MultiSelect = False
        Me.lvGarage.Name = "lvGarage"
        Me.lvGarage.Size = New System.Drawing.Size(229, 289)
        Me.lvGarage.TabIndex = 115
        Me.lvGarage.UseCompatibleStateImageBehavior = False
        Me.lvGarage.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Garage"
        Me.ColumnHeader1.Width = 200
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 15)
        Me.Label1.TabIndex = 116
        Me.Label1.Text = "Select SPG Garage:"
        '
        'lvFloor
        '
        Me.lvFloor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.lvFloor.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2})
        Me.lvFloor.FullRowSelect = True
        Me.lvFloor.Location = New System.Drawing.Point(247, 85)
        Me.lvFloor.MultiSelect = False
        Me.lvFloor.Name = "lvFloor"
        Me.lvFloor.Size = New System.Drawing.Size(229, 289)
        Me.lvFloor.TabIndex = 117
        Me.lvFloor.UseCompatibleStateImageBehavior = False
        Me.lvFloor.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Floor"
        Me.ColumnHeader2.Width = 200
        '
        'lvApartment
        '
        Me.lvApartment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.lvApartment.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3})
        Me.lvApartment.FullRowSelect = True
        Me.lvApartment.Location = New System.Drawing.Point(482, 85)
        Me.lvApartment.MultiSelect = False
        Me.lvApartment.Name = "lvApartment"
        Me.lvApartment.Size = New System.Drawing.Size(364, 289)
        Me.lvApartment.TabIndex = 118
        Me.lvApartment.UseCompatibleStateImageBehavior = False
        Me.lvApartment.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Apartment"
        Me.ColumnHeader3.Width = 330
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(479, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 15)
        Me.Label2.TabIndex = 119
        Me.Label2.Text = "Select SPA Garage:"
        '
        'txtGarage
        '
        Me.txtGarage.Location = New System.Drawing.Point(12, 56)
        Me.txtGarage.Name = "txtGarage"
        Me.txtGarage.ReadOnly = True
        Me.txtGarage.Size = New System.Drawing.Size(229, 23)
        Me.txtGarage.TabIndex = 120
        '
        'txtFloor
        '
        Me.txtFloor.Location = New System.Drawing.Point(247, 56)
        Me.txtFloor.Name = "txtFloor"
        Me.txtFloor.ReadOnly = True
        Me.txtFloor.Size = New System.Drawing.Size(229, 23)
        Me.txtFloor.TabIndex = 121
        '
        'txtApartment
        '
        Me.txtApartment.Location = New System.Drawing.Point(482, 56)
        Me.txtApartment.Name = "txtApartment"
        Me.txtApartment.ReadOnly = True
        Me.txtApartment.Size = New System.Drawing.Size(364, 23)
        Me.txtApartment.TabIndex = 122
        '
        'frmSpg2Spa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 537)
        Me.Controls.Add(Me.txtApartment)
        Me.Controls.Add(Me.txtFloor)
        Me.Controls.Add(Me.txtGarage)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lvApartment)
        Me.Controls.Add(Me.lvFloor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lvGarage)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Name = "frmSpg2Spa"
        Me.Text = "Transfer SPG vehicles to SPA"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtLog As TextBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tsProgress As ToolStripProgressBar
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents StartReadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents lvGarage As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents lvFloor As ListView
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents lvApartment As ListView
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents Label2 As Label
    Friend WithEvents txtGarage As TextBox
    Friend WithEvents txtFloor As TextBox
    Friend WithEvents txtApartment As TextBox
End Class
