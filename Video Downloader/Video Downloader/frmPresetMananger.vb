Public Class frmPresetManager

    Private Sub frmPresetMananger_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PresetImage.Images.Clear()
        For Each presetDir In IO.Directory.GetDirectories("Presets")
            PresetImage.Images.Add(IO.Path.GetFileName(presetDir), Image.FromFile(presetDir & "\" & IO.Path.GetFileName(presetDir) & ".png"))
            Dim MainNode = Category.Nodes.Add(IO.Path.GetFileName(presetDir), IO.Path.GetFileName(presetDir), IO.Path.GetFileName(presetDir))
            MainNode.SelectedImageKey = MainNode.ImageKey
            For Each preset In IO.Directory.GetFiles(presetDir, "*.txt")
                Dim img = presetDir & "\" & IO.Path.GetFileNameWithoutExtension(preset) & ".png"
                If IO.File.Exists(img) Then
                    PresetImage.Images.Add(IO.Path.GetFileName(img), Image.FromFile(img))
                    Dim tNode As TreeNode = MainNode.Nodes.Add(IO.Path.GetFileName(img), IO.Path.GetFileNameWithoutExtension(preset), IO.Path.GetFileName(img))
                    tNode.Tag = preset
                    tNode.SelectedImageKey = tNode.ImageKey
                Else
                    MainNode.Tag = preset
                End If
            Next
        Next
    End Sub

    Private Sub Category_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles Category.AfterSelect
        presetName.Text = ""
        presetList.Items.Clear()
        If IO.File.Exists(e.Node.Tag) Then
            Dim Reader As New IniFile(e.Node.Tag)
            For Each section In Reader.GetSectionNames
                presetList.Items.Add(section)
            Next
        End If
    End Sub

    Private Sub presetList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles presetList.SelectedIndexChanged
        If presetList.SelectedItems.Count = 1 Then
            presetName.Text = presetList.SelectedItem
            If IO.File.Exists(Category.SelectedNode.Tag.ToString) Then
                Dim Reader = New IniFile(Category.SelectedNode.Tag.ToString)
                Reader.Section = presetList.SelectedItem
                frmMain.Profile.Text = Reader.ReadString("Profile", "MP4 - MPEG-4 Movie (*.mp4)")
                frmMain.audio_Codec.Text = Reader.ReadString("audio_Codec", "aac")
                frmMain.audio_Bitrate.Text = Reader.ReadString("audio_Bitrate", 160)
                frmMain.audio_Chanel.Text = Reader.ReadString("audio_Chanel", "2 (Stereo)")
                frmMain.audio_Samplerate.Text = Reader.ReadString("audio_Samplerate", 44100)
                frmMain.video_Codec.Text = Reader.ReadString("video_Codec", "x264")
                frmMain.video_Bitrate.Text = Reader.ReadString("video_Bitrate", 1500)
                frmMain.video_Size.Text = Reader.ReadString("video_Size", "1080x720")
                frmMain.video_Framerate.Text = Reader.ReadString("video_Framerate", 25)
                frmMain.video_AspectRatio.Text = Reader.ReadString("video_AspectRatio", "16:9 (Widescreen)")
                frmMain.Additional_Parameter.Text = Reader.ReadString("Additional_Parameter", "")
            End If
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            If Not Category.SelectedNode Is Nothing Then
                If IO.File.Exists(Category.SelectedNode.Tag) Then
                    If Not String.IsNullOrEmpty(presetName.Text) Then
                        Dim Writer As New IniFile(Category.SelectedNode.Tag)
                        Writer.Section = presetName.Text
                        Writer.WriteString("Profile", frmMain.Profile.Text)
                        Writer.WriteString("audio_Codec", frmMain.audio_Codec.Text)
                        Writer.WriteString("audio_Bitrate", frmMain.audio_Bitrate.Text)
                        Writer.WriteString("audio_Chanel", frmMain.audio_Chanel.Text)
                        Writer.WriteString("audio_Samplerate", frmMain.audio_Samplerate.Text)
                        Writer.WriteString("video_Codec", frmMain.video_Codec.Text)
                        Writer.WriteString("video_Bitrate", frmMain.video_Bitrate.Text)
                        Writer.WriteString("video_Size", frmMain.video_Size.Text)
                        Writer.WriteString("video_Framerate", frmMain.video_Framerate.Text)
                        Writer.WriteString("video_AspectRatio", frmMain.video_AspectRatio.Text)
                        Writer.WriteString("Additional_Parameter", frmMain.Additional_Parameter.Text)
                        presetList.Items.Clear()
                        For Each section In Writer.GetSectionNames
                            presetList.Items.Add(section)
                        Next
                    Else
                        MsgBox("Preset name cannot be null.", MsgBoxStyle.Exclamation)
                    End If
                End If
            Else
                MsgBox("Please select a category to add/update.", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox("To save presets you may need to run this program with administrator privileges.", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        If presetList.SelectedItems.Count = 1 Then
            If MsgBox("Are you sure you want to permanently remove this item?", MsgBoxStyle.YesNo, presetList.SelectedItem) = MsgBoxResult.Yes Then
                Dim Ini As New IniFile(Category.SelectedNode.Tag)
                Ini.DeleteSection(presetList.SelectedItem)
                presetList.Items.Remove(presetList.SelectedItem)
                presetName.Text = ""
            End If
        End If
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub

End Class