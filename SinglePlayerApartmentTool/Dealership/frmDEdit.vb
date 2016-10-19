Public Class frmDEdit

    Public ImagePathDir As String = Application.StartupPath & "\Shopping\Images\"
    Private _editMode As Boolean = True
    Private _lvItem As ListViewItem
    Private _pictureChanged As Boolean = False
    Private _lv As ListView
    Private ResizedImage As Image
    Private HiddenPictureBox As PictureBox = New PictureBox

    Public Property EditMode() As Boolean
        Get
            Return _editMode
        End Get
        Set(value As Boolean)
            _editMode = value
        End Set
    End Property

    Public Property LVItem() As ListViewItem
        Get
            Return _lvItem
        End Get
        Set(value As ListViewItem)
            _lvItem = value
        End Set
    End Property

    Public Property PictureChanged() As Boolean
        Get
            Return _pictureChanged
        End Get
        Set(value As Boolean)
            _pictureChanged = value
        End Set
    End Property

    Public Property xListView() As ListView
        Get
            Return _lv
        End Get
        Set(value As ListView)
            _lv = value
        End Set
    End Property

    Private Sub pbImage_Click(sender As Object, e As EventArgs) Handles pbImage.Click
        If ofDialog.ShowDialog = DialogResult.OK Then
            Dim fs As IO.FileStream = New IO.FileStream(ofDialog.FileName, IO.FileMode.Open, IO.FileAccess.Read)
            pbImage.Image = Image.FromStream(fs)
            'HiddenPictureBox.BackgroundImage = Image.FromFile(ofDialog.FileName)
            ResizedImage = New Bitmap(pbImage.Image, New Size(620, 350))
            fs.Close()
            PictureChanged = True
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If txtName.Text = Nothing Then
                MsgBox("Please enter Vehicle Name.", MsgBoxStyle.Exclamation, "SPA Tool")
            ElseIf txtModel.Text = Nothing Then
                MsgBox("Please enter Vehicle Model.", MsgBoxStyle.Exclamation, "SPA Tool")
            ElseIf cmbCategory.SelectedItem = Nothing Then
                MsgBox("Please choose Vehicle Category.", MsgBoxStyle.Exclamation, "SPA Tool")
            ElseIf txtGXT.Text = Nothing Then
                MsgBox("Please enter Model GXT.", MsgBoxStyle.Exclamation, "SPA Tool")
            Else
                If EditMode = True Then
                    LVItem.SubItems(1).Text = numPrice.Value
                    LVItem.SubItems(2).Text = txtModel.Text
                    LVItem.SubItems(3).Text = txtGXT.Text
                    LVItem.SubItems(4).Text = cmbBrand.Text
                    LVItem.SubItems(5).Text = cmbCategory.SelectedItem
                    LVItem.SubItems(6).Text = txtDesc.Text
                    LVItem.Text = txtName.Text
                ElseIf EditMode = False Then
                    If PictureChanged = False Then
                        MsgBox("Please select a Preview Image.", MsgBoxStyle.Exclamation, "SPA Tool")
                        Exit Sub
                    Else
                        Dim items As New ListViewItem()
                        items = xListView.Items.Add(txtName.Text)
                        With items
                            .SubItems.Add(numPrice.Value)
                            .SubItems.Add(txtModel.Text)
                            .SubItems.Add(txtGXT.Text)
                            .SubItems.Add(cmbBrand.Text)
                            .SubItems.Add(cmbCategory.SelectedItem)
                            .SubItems.Add(txtDesc.Text)
                        End With
                    End If
                End If
                If PictureChanged = True Then
                    'pbImage.Image.Save(String.Format("{0}{1}{2}", ImagePathDir, txtModel.Text, ".jpg"), Imaging.ImageFormat.Jpeg)
                    'IO.File.Copy(ofDialog.FileName, String.Format("{0}{1}{2}", ImagePathDir, txtModel.Text, ".jpg"))
                    ResizedImage.Save(String.Format("{0}{1}{2}", ImagePathDir, txtModel.Text, ".jpg"), Imaging.ImageFormat.Jpeg)
                End If
            End If
            Close()
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class