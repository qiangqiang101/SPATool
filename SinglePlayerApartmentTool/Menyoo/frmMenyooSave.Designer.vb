<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenyooSave
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
        Me.cmbChoose = New System.Windows.Forms.ComboBox()
        Me.btnTaskStart = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmbChoose
        '
        Me.cmbChoose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbChoose.FormattingEnabled = True
        Me.cmbChoose.Items.AddRange(New Object() {"Online Male", "Online Female"})
        Me.cmbChoose.Location = New System.Drawing.Point(113, 12)
        Me.cmbChoose.Name = "cmbChoose"
        Me.cmbChoose.Size = New System.Drawing.Size(216, 23)
        Me.cmbChoose.TabIndex = 0
        '
        'btnTaskStart
        '
        Me.btnTaskStart.Location = New System.Drawing.Point(227, 41)
        Me.btnTaskStart.Name = "btnTaskStart"
        Me.btnTaskStart.Size = New System.Drawing.Size(102, 35)
        Me.btnTaskStart.TabIndex = 108
        Me.btnTaskStart.Text = "Save"
        Me.btnTaskStart.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(12, 15)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(95, 15)
        Me.Label18.TabIndex = 109
        Me.Label18.Text = "Select Character:"
        '
        'frmMenyooSave
        '
        Me.AcceptButton = Me.btnTaskStart
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 85)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.btnTaskStart)
        Me.Controls.Add(Me.cmbChoose)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMenyooSave"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Save"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbChoose As ComboBox
    Friend WithEvents btnTaskStart As Button
    Friend WithEvents Label18 As Label
End Class
