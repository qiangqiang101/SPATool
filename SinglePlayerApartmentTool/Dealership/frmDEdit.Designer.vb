<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDEdit
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbBrand = New System.Windows.Forms.ComboBox()
        Me.txtGXT = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.numPrice = New System.Windows.Forms.NumericUpDown()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.pbImage = New System.Windows.Forms.PictureBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.ofDialog = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        CType(Me.numPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDesc)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmbCategory)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmbBrand)
        Me.GroupBox1.Controls.Add(Me.txtGXT)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtModel)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.numPrice)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(371, 233)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "General"
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(79, 196)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(276, 23)
        Me.txtDesc.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 199)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Description"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Category"
        '
        'cmbCategory
        '
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Items.AddRange(New Object() {"Garage", "Pegasus"})
        Me.cmbCategory.Location = New System.Drawing.Point(79, 167)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(276, 23)
        Me.cmbCategory.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Brand GXT"
        '
        'cmbBrand
        '
        Me.cmbBrand.AutoCompleteCustomSource.AddRange(New String() {"", "dundreary", "vapid", "declasse", "karin", "bravado", "albany", "willard", "bucking", "lampadati", "nagasaki", "pegassi", "dinka", "shitzu", "speedoph", "western", "mammoth", "grotti", "enus", "benefac", "dewbauch", "pfister", "imponte", "gallivan", "coil", "inverto", "progen", "principl", "hijak", "truffade", "overflod", "obey", "canis", "vulcar", "bf", "ubermach", "weeny", "ocelot", "schyster", "maibatsu", "cheval", "zirconiu", "lcc", "hvy"})
        Me.cmbBrand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbBrand.FormattingEnabled = True
        Me.cmbBrand.Items.AddRange(New Object() {"", "dundreary", "vapid", "declasse", "karin", "bravado", "albany", "willard", "bucking", "lampadati", "nagasaki", "pegassi", "dinka", "shitzu", "speedoph", "western", "mammoth", "grotti", "enus", "benefac", "dewbauch", "pfister", "imponte", "gallivan", "coil", "inverto", "progen", "principl", "hijak", "truffade", "overflod", "obey", "canis", "vulcar", "bf", "ubermach", "weeny", "ocelot", "schyster", "maibatsu", "cheval", "zirconiu", "lcc", "hvy"})
        Me.cmbBrand.Location = New System.Drawing.Point(79, 138)
        Me.cmbBrand.Name = "cmbBrand"
        Me.cmbBrand.Size = New System.Drawing.Size(276, 23)
        Me.cmbBrand.TabIndex = 8
        '
        'txtGXT
        '
        Me.txtGXT.Location = New System.Drawing.Point(79, 109)
        Me.txtGXT.Name = "txtGXT"
        Me.txtGXT.Size = New System.Drawing.Size(276, 23)
        Me.txtGXT.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Model GXT"
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(79, 80)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(276, 23)
        Me.txtModel.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Model"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Price"
        '
        'numPrice
        '
        Me.numPrice.Location = New System.Drawing.Point(79, 51)
        Me.numPrice.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.numPrice.Name = "numPrice"
        Me.numPrice.Size = New System.Drawing.Size(140, 23)
        Me.numPrice.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(79, 22)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(276, 23)
        Me.txtName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.pbImage)
        Me.GroupBox2.Location = New System.Drawing.Point(389, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(388, 233)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Image (Click to Change)"
        '
        'pbImage
        '
        Me.pbImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbImage.Image = Global.SinglePlayerApartmentTool.My.Resources.Resources.no_image_thumb
        Me.pbImage.Location = New System.Drawing.Point(3, 19)
        Me.pbImage.Name = "pbImage"
        Me.pbImage.Size = New System.Drawing.Size(382, 211)
        Me.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImage.TabIndex = 0
        Me.pbImage.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(564, 251)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(102, 35)
        Me.btnSave.TabIndex = 71
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(672, 251)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(102, 35)
        Me.btnClose.TabIndex = 72
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'ofDialog
        '
        Me.ofDialog.Filter = "JPEG files|*.jpg"
        '
        'frmDEdit
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(843, 596)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Name = "frmDEdit"
        Me.Text = "Dealership Editor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.numPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents numPrice As NumericUpDown
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbBrand As ComboBox
    Friend WithEvents txtGXT As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtModel As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents pbImage As PictureBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents ofDialog As OpenFileDialog
End Class
