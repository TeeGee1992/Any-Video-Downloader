
Public Class frmMain

#Region "Others"

    Private MainDir As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Video Downloader"
    Private SettingPath As String = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Settings.ini"

    Sub CheckVersion(auto As Boolean)
        Try
            Dim databaseversion = DownloadString("https://drive.google.com/uc?export=download&id=11XXs5zog5Y4sBD6fLZ457VAnmDPojHXx")
            Dim appversion = String.Format("{0}{1}{2}", My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build)
            If auto = True Then
                If CInt(databaseversion) > CInt(appversion) Then If MsgBox("There is a new version available for download, would you like to download now?",
                                                                           MsgBoxStyle.YesNo, appversion & " ---> " & databaseversion) = MsgBoxResult.Yes Then LaunchUpdater()
            Else
                If CInt(databaseversion) > CInt(appversion) Then
                    If MsgBox("There is a new version available for download, would you like to download now?",
                              MsgBoxStyle.YesNo, appversion & " ---> " & databaseversion) = MsgBoxResult.Yes Then LaunchUpdater()
                Else
                    MsgBox("Current Version: " & appversion & vbCrLf & "Data Base Version: " & databaseversion, MsgBoxStyle.Information, "Your'e up to date.")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Sub LaunchUpdater()
        If IO.File.Exists("Updater.exe") Then
            Using Updater As New Process
                With Updater.StartInfo
                    .FileName = "Updater.exe"
                    .WorkingDirectory = CurDir()
                    .Arguments = "-U https://drive.google.com/uc?export=download&id=1TfOXR7B1AJBLjJyLqECiQc2gxB11hdTU """ & Application.ExecutablePath & """"
                    .Verb = "runas"
                    Updater.Start()
                End With
            End Using
            Me.Close()
        Else
            MsgBox("System cannot find the file specified: Updater.exe", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)

        LoadSettings()

        If auto_check.Checked = True Then
            CheckVersion(True)
            Check_youtube_dl_Version()
        End If

        '//CreateDir
        If Not IO.Directory.Exists(MainDir) Then IO.Directory.CreateDirectory(MainDir)
        If Not IO.Directory.Exists(DownloadDir) Then IO.Directory.CreateDirectory(DownloadDir)
        If Not IO.Directory.Exists(ConvertDir) Then IO.Directory.CreateDirectory(ConvertDir)
        If Not IO.Directory.Exists(Mp3Dir) Then IO.Directory.CreateDirectory(Mp3Dir)
        If Not IO.Directory.Exists(M4aDir) Then IO.Directory.CreateDirectory(M4aDir)
        If Not IO.Directory.Exists(Mp4Dir) Then IO.Directory.CreateDirectory(Mp4Dir)
        If Not IO.Directory.Exists(AviDir) Then IO.Directory.CreateDirectory(AviDir)
        If Not IO.Directory.Exists(WmaDir) Then IO.Directory.CreateDirectory(WmaDir)
        If Not IO.Directory.Exists(WmvDir) Then IO.Directory.CreateDirectory(WmvDir)
        If Not IO.Directory.Exists(OggDir) Then IO.Directory.CreateDirectory(OggDir)
        If Not IO.Directory.Exists(FlvDir) Then IO.Directory.CreateDirectory(FlvDir)
        If Not IO.Directory.Exists(WavDir) Then IO.Directory.CreateDirectory(WavDir)
        If Not IO.Directory.Exists(WebMDir) Then IO.Directory.CreateDirectory(WebMDir)
        If Not IO.Directory.Exists(FlacDir) Then IO.Directory.CreateDirectory(FlacDir)
        If Not IO.Directory.Exists(MovDir) Then IO.Directory.CreateDirectory(MovDir)
        If Not IO.Directory.Exists(AacDir) Then IO.Directory.CreateDirectory(AacDir)
        If Not IO.Directory.Exists(Ac3Dir) Then IO.Directory.CreateDirectory(Ac3Dir)
        If Not IO.Directory.Exists(MpgDir) Then IO.Directory.CreateDirectory(MpgDir)
        If Not IO.Directory.Exists(M2tsDir) Then IO.Directory.CreateDirectory(M2tsDir)

        txtAbout.Text = Helper.ABOUT
    End Sub

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Worker.IsBusy Then
            If MsgBox("Conversion in progress. Do you want to cancel it?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                CanceledConversion()
            Else
                e.Cancel = True
                Exit Sub
            End If
        End If
        SaveSettings()
    End Sub


    Private Sub lblDonate_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblDonate.LinkClicked
        Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=C88UYUHSZLTBS")
    End Sub

    Private Sub txtAbout_LinkClicked(sender As Object, e As LinkClickedEventArgs) Handles txtAbout.LinkClicked
        Process.Start(e.LinkText)
    End Sub

    Private Sub CButton2_Click(sender As Object, e As EventArgs) Handles CButton2.Click
        Close()
    End Sub

    Private Sub CButton1_Click(sender As Object, e As EventArgs) Handles CButton1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub frmMain_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Using B = New Bitmap(Width, Height)
            Using G = Graphics.FromImage(B)
                G.SmoothingMode = SmoothingMode.HighQuality
                G.Clear(BackColor)
                G.FillRectangle(New Drawing2D.LinearGradientBrush(ClientRectangle, Color.Silver, Color.Black, 90), ClientRectangle)
                G.FillRectangle(New SolidBrush(Color.Black), 10, 40, Width - 20, Height - 50)
                Dim brush1 = New Drawing2D.HatchBrush(HatchStyle.Trellis, Color.Silver, Color.Black)
                Dim brush2 = New SolidBrush(Color.Black)
                G.FillRectangle(brush2, CInt(Width / 4), 10, CInt(Width / 2), 20)
                brush2.Dispose()
                G.FillRectangle(brush1, 10, 5, CInt(Width / 4), 30)
                G.FillRectangle(brush1, Width - CInt(Width / 4) - 10, 5, CInt(Width / 4), 30)
                brush1.Dispose()
                G.DrawRectangle(Pens.WhiteSmoke, 0, 0, Width - 1, Height - 1)
                Dim strsize = G.MeasureString(Text, New Font("Microsoft Sans Serif", 8, FontStyle.Bold))
                G.DrawString(Text, New Font("Microsoft Sans Serif", 8, FontStyle.Bold), New SolidBrush(Color.White), Width \ 2 - strsize.Width \ 2, 20 - strsize.Height \ 2)
                G.DrawIcon(Icon, 10, 5)
                e.Graphics.DrawImage(B, 0, 0)
                G.Dispose() : B.Dispose()
            End Using
        End Using
    End Sub


    Dim mouseOffset As Point

    Private Sub Me_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown
        mouseOffset = New Point(-e.X, -e.Y)
    End Sub

    Private Sub BtnCheckforupdates_Click(sender As Object, e As EventArgs) Handles btnCheckforupdates.Click
        CheckVersion(False)
        Check_youtube_dl_Version()
    End Sub

    Private Sub Me_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove

        If e.Button = MouseButtons.Left Then
            Dim mousePos = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Location = mousePos
        End If
    End Sub


#End Region

#Region " Downloader "

    Private DownloadDir As String = MainDir & "\Downloads"

    Sub Download(ByVal url As String)
        Dim lvi As ListViewItem = DownloadList.Items.Add("Getting title info...")
        Dim bw As New ComponentModel.BackgroundWorker
        With bw
            .WorkerReportsProgress = True
            .WorkerSupportsCancellation = True
            AddHandler bw.DoWork, Sub()
                                      Try
                                          Using ytd As New Process
                                              With ytd.StartInfo
                                                  .FileName = "yt-dlp.exe"
                                                  .WorkingDirectory = DownloadDir
                                                  If Playlist.Invoke(Function() Playlist.Checked) = True Then
                                                      .Arguments = String.Format("-f bestvideo[ext=mp4]+bestaudio[ext=m4a]/mp4 {0}", url)
                                                  Else
                                                      .Arguments = String.Format("-f bestvideo[ext=mp4]+bestaudio[ext=m4a]/mp4 --no-playlist {0}", url)
                                                  End If
                                                  .UseShellExecute = False
                                                  .RedirectStandardOutput = True
                                                  .CreateNoWindow = True
                                              End With
                                              ytd.Start()
                                              DownloadList.Invoke(Sub() lvi.SubItems.AddRange(New String() {"Initializing...", 0, 0}))
                                              Do
                                                  Dim info = ytd.StandardOutput.ReadLine
                                                  If Not String.IsNullOrEmpty(info) Then
                                                      If info.Contains("downloaded and merged") Then
                                                          DownloadList.Invoke(Sub() lvi.SubItems(0).Text = "Has already been downloaded and merged.")
                                                          DownloadList.Invoke(Sub() lvi.SubItems(2).Text = 100)
                                                      ElseIf info.Contains("Destination:") Then
                                                          DownloadList.Invoke(Sub() lvi.SubItems(0).Text = info.Substring(info.IndexOf("Destination:") + 12))
                                                      ElseIf info.Contains("% of ") Then
                                                          Dim percentage = info.Substring(info.IndexOf("% of ") - 4)
                                                          percentage = percentage.Remove(percentage.IndexOf("%"))
                                                          DownloadList.Invoke(Sub() lvi.SubItems(1).Text = "Downloading...")
                                                          DownloadList.Invoke(Sub() lvi.SubItems(2).Text = CInt(percentage))
                                                      ElseIf info.Contains("[Merger] Merging formats into") Then
                                                          Dim title = info.Substring(info.IndexOf("[Merger] Merging formats into") + 31)
                                                          DownloadList.Invoke(Sub() lvi.SubItems(0).Text = title.Remove(title.IndexOf("""")))
                                                          DownloadList.Invoke(Sub() lvi.SubItems(1).Text = "Merging formats...")
                                                      End If
                                                  End If
                                              Loop Until ytd.HasExited
                                              DownloadList.Invoke(Sub() lvi.SubItems(1).Text = "Finish!")
                                          End Using
                                      Catch ex As Exception
                                          DownloadList.Invoke(Sub() lvi.SubItems(1).Text = "Error!")
                                      End Try
                                  End Sub
            .RunWorkerAsync()
        End With
    End Sub

    Private Sub NewDownloadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewDownloadToolStripMenuItem.Click, NewDownloadToolStripMenuItem1.Click
        If My.Computer.Network.IsAvailable Then
            frmNewDownload.Show()
        Else
            MsgBox("No internet connections are available.", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click, ClearToolStripMenuItem1.Click
        For i As Integer = DownloadList.Items.Count - 1 To 0 Step -1
            If DownloadList.Items(i).SubItems(1).Text = "Finish!" OrElse DownloadList.Items(i).SubItems(1).Text = "Error!" Then
                DownloadList.Items(i).Remove()
            End If
        Next
    End Sub

    Private Sub DownloadsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DownloadsToolStripMenuItem.Click, DownloadsToolStripMenuItem1.Click
        Process.Start(DownloadDir)
    End Sub

    Private Sub FileInfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileInfoToolStripMenuItem.Click
        If DownloadList.SelectedItems.Count = 1 Then
            If IO.File.Exists(DownloadDir & "\" & DownloadList.SelectedItems(0).SubItems(0).Text) Then
                frmMediaInfo.GetInfo(DownloadDir & "\" & DownloadList.SelectedItems(0).SubItems(0).Text)
                frmMediaInfo.Show()
            Else
                frmMediaInfo.Show()
            End If
        Else
            frmMediaInfo.Show()
        End If
    End Sub

    Sub Check_youtube_dl_Version()
        Try
            Using Updater As New Process
                With Updater.StartInfo
                    .FileName = "yt-dlp.exe"
                    .WorkingDirectory = CurDir()
                    .Verb = "runas"
                    .Arguments = "-U"
                    Updater.Start()
                End With
            End Using
        Catch ex As Exception
        End Try
    End Sub

#End Region

#Region " Converter "

    Private FFmpegProcess As New Process
    Private Stopwatch As New Stopwatch
    Private OutputFile As String
    Private Items As New ArrayList
    Private ConvertDir As String = MainDir & "\Converted"
    Private Mp3Dir As String = ConvertDir & "\MP3"
    Private M4aDir As String = ConvertDir & "\M4A"
    Private Mp4Dir As String = ConvertDir & "\MP4"
    Private AviDir As String = ConvertDir & "\AVI"
    Private WmaDir As String = ConvertDir & "\WMA"
    Private WmvDir As String = ConvertDir & "\WMV"
    Private OggDir As String = ConvertDir & "\OGG"
    Private FlvDir As String = ConvertDir & "\FLV"
    Private WavDir As String = ConvertDir & "\WAV"
    Private WebMDir As String = ConvertDir & "\WEBM"
    Private FlacDir As String = ConvertDir & "\FLAC"
    Private MovDir As String = ConvertDir & "\MOV"
    Private AacDir As String = ConvertDir & "\AAC"
    Private Ac3Dir As String = ConvertDir & "\AC3"
    Private MpgDir As String = ConvertDir & "\MPG"
    Private M2tsDir As String = ConvertDir & "\M2TS"
    Private Vol As Single = 1.0
    Private ToAudio = "-y -threads {0} -i ""{1}"" -c:a {2} -b:a {3}k -ac {4} -ar {5} -af ""volume={6}"" {7} ""{8}"""
    Private ToVideo = "-y -threads {0} -i ""{1}"" -c:a {2} -b:a {3}k -ac {4} -ar {5} -af ""volume={6}"" -c:v {7} -b:v {8}k -s {9} -aspect {10} -r {11} {12} ""{13}"""
    Private FFmpegPath As String = My.Computer.FileSystem.CurrentDirectory & "\ffmpeg.exe"

    Function GetAudioCodec() As String
        Select Case audio_Codec.Invoke(Function() audio_Codec.Text)
            Case "Original"
                Return "copy"
            Case "aac"
                Return "aac"
            Case "ac3"
                Return "ac3"
            Case "mp2"
                Return "mp2"
            Case "mp3"
                Return "libmp3lame"
            Case "pcm"
                Return "pcm_s16le"
            Case "wmav1"
                Return "wmav1"
            Case "wmav2"
                Return "wmav2"
            Case "vorbis"
                Return "libvorbis"
            Case "flac"
                Return "flac"
            Case "opus"
                Return "libopus"
            Case "eac3"
                Return "eac3"
            Case Else
                Return "libmp3lame"
        End Select
    End Function

    Private Sub audio_Codec_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Select Case audio_Codec.Text
            Case "opus"
                audio_Samplerate.Items.Clear()
                audio_Samplerate.Items.AddRange(New Object() {8000, 12000, 16000, 24000, 48000})
                audio_Samplerate.SelectedIndex = 4
            Case Else
                audio_Samplerate.Items.Clear()
                audio_Samplerate.Items.AddRange(New Object() {8000, 11025, 12000, 16000, 22050, 24000, 32000, 44100, 48000})
                audio_Samplerate.SelectedIndex = 7
        End Select
    End Sub

    Function GetAudioChanel() As Integer
        If audio_Chanel.Invoke(Function() audio_Chanel.SelectedIndex) = 0 Then Return 1
        Return 2
    End Function

    Function GetBitrate() As Integer
        Return audio_Bitrate.Invoke(Function() audio_Bitrate.Text)
    End Function

    Function GetSampleRate() As Integer
        Return audio_Samplerate.Invoke(Function() audio_Samplerate.Text)
    End Function

    Private Function GetVideoCodec() As String
        Select Case video_Codec.Invoke(Function() video_Codec.Text)
            Case "Original"
                Return "copy"
            Case "x264"
                Return "libx264"
            Case "XviD"
                Return "libxvid"
            Case "mpeg1"
                Return "mpeg1video"
            Case "mpeg2"
                Return "mpeg2video"
            Case "mpeg4"
                Return "mpeg4"
            Case "msmpeg4"
                Return "msmpeg4"
            Case "msmpeg4v2"
                Return "msmpeg4v2"
            Case "msmpeg4v3"
                Return "msmpeg4v3"
            Case "Microsoft Video 1"
                Return "msvideo1"
            Case "mjpeg"
                Return "mjpeg"
            Case "wmv1"
                Return "wmv1"
            Case "wmv2"
                Return "wmv2"
            Case "h263p"
                Return "h263p"
            Case "ffv1"
                Return "flv1"
            Case "huffyuv"
                Return "huffyuv"
            Case "flv"
                Return "flv"
            Case "vp8"
                Return "libvpx"
            Case "vp9"
                Return "libvpx-vp9"
            Case Else
                Return "copy"
        End Select
    End Function

    Function GetVideoBitrate() As Integer
        If video_Bitrate.Invoke(Function() video_Bitrate.Text) = "" Then video_Bitrate.Invoke(Sub() video_Bitrate.Text = 1000)
        Return video_Bitrate.Invoke(Function() video_Bitrate.Text)
    End Function

    Function GetVideoSize() As String
        If video_Size.Invoke(Function() video_Size.Text) = "" Then video_Size.Invoke(Sub() video_Size.Text = "1080x720")
        Return video_Size.Invoke(Function() video_Size.Text)
    End Function

    Function GetAspectRatio() As String
        If video_AspectRatio.Invoke(Function() video_AspectRatio.SelectedIndex) = 0 Then Return "4:3"
        Return "16:9"
    End Function

    Function GetVideoFramerate() As String
        Return video_Framerate.Invoke(Function() video_Framerate.Text)
    End Function


    Private Sub Worker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles Worker.DoWork
        Dim index As Integer = 0
        For index = 0 To Items.Count - 1
            Dim OriginalFile = Items(index).ToString
            Select Case Profile.Invoke(Function() Profile.Text)
                Case "MP3 - MPEG Layer-3 Audio (*.mp3)"
                    OutputFile = Mp3Dir & "\" & IO.Path.GetFileNameWithoutExtension(OriginalFile) & ".mp3"
                    FFmpegProcess.StartInfo.Arguments = String.Format(ToAudio, GetThreads, OriginalFile, GetAudioCodec, GetBitrate, GetAudioChanel, GetSampleRate, Vol, Additional_Parameter.Text, OutputFile)
                Case "MP4 - MPEG-4 Movie (*.mp4)"
                    OutputFile = Mp4Dir & "\" & IO.Path.GetFileNameWithoutExtension(OriginalFile) & ".mp4"
                    FFmpegProcess.StartInfo.Arguments = String.Format(ToVideo, GetThreads, OriginalFile, GetAudioCodec, GetBitrate, GetAudioChanel, GetSampleRate, Vol,
                    GetVideoCodec, GetVideoBitrate, GetVideoSize, GetAspectRatio, GetVideoFramerate, Additional_Parameter.Text, OutputFile)
                Case "AVI - Audio Video Interleave (*.avi)"
                    OutputFile = AviDir & "\" & IO.Path.GetFileNameWithoutExtension(OriginalFile) & ".avi"
                    FFmpegProcess.StartInfo.Arguments = String.Format(ToVideo, GetThreads, OriginalFile, GetAudioCodec, GetBitrate, GetAudioChanel, GetSampleRate, Vol,
                     GetVideoCodec, GetVideoBitrate, GetVideoSize, GetAspectRatio, GetVideoFramerate, Additional_Parameter.Text, OutputFile)
                Case "M4A - MPEG-4 Audio (*.m4a)"
                    OutputFile = M4aDir & "\" & IO.Path.GetFileNameWithoutExtension(OriginalFile) & ".m4a"
                    FFmpegProcess.StartInfo.Arguments = String.Format(ToAudio, GetThreads, OriginalFile, GetAudioCodec, GetBitrate, GetAudioChanel, GetSampleRate, Vol, Additional_Parameter.Text, OutputFile)
                Case "WMA - Windows Media Audio (*.wma)"
                    OutputFile = WmaDir & "\" & IO.Path.GetFileNameWithoutExtension(OriginalFile) & ".wma"
                    FFmpegProcess.StartInfo.Arguments = String.Format(ToAudio, GetThreads, OriginalFile, GetAudioCodec, GetBitrate, GetAudioChanel, GetSampleRate, Vol, Additional_Parameter.Text, OutputFile)
                Case "WMV - Windows Media Video (*.wmv)"
                    OutputFile = WmvDir & "\" & IO.Path.GetFileNameWithoutExtension(OriginalFile) & ".wmv"
                    FFmpegProcess.StartInfo.Arguments = String.Format(ToVideo, GetThreads, OriginalFile, GetAudioCodec, GetBitrate, GetAudioChanel, GetSampleRate, Vol,
                   GetVideoCodec, GetVideoBitrate, GetVideoSize, GetAspectRatio, GetVideoFramerate, Additional_Parameter.Text, OutputFile)
                Case "OGG - Vorbis Audio File (*.ogg)"
                    OutputFile = OggDir & "\" & IO.Path.GetFileNameWithoutExtension(OriginalFile) & ".ogg"
                    FFmpegProcess.StartInfo.Arguments = String.Format(ToAudio, GetThreads, OriginalFile, GetAudioCodec, GetBitrate, GetAudioChanel, GetSampleRate, Vol, Additional_Parameter.Text, OutputFile)
                Case "FLV - Flash Video (*.flv)"
                    OutputFile = FlvDir & "\" & IO.Path.GetFileNameWithoutExtension(OriginalFile) & ".flv"
                    FFmpegProcess.StartInfo.Arguments = String.Format(ToVideo, GetThreads, OriginalFile, GetAudioCodec, GetBitrate, GetAudioChanel, GetSampleRate, Vol,
                   GetVideoCodec, GetVideoBitrate, GetVideoSize, GetAspectRatio, GetVideoFramerate, Additional_Parameter.Text, OutputFile)
                Case "WebM - Web Movie (*.webm)"
                    OutputFile = WebMDir & "\" & IO.Path.GetFileNameWithoutExtension(OriginalFile) & ".webm"
                    FFmpegProcess.StartInfo.Arguments = String.Format(ToVideo, GetThreads, OriginalFile, GetAudioCodec, GetBitrate, GetAudioChanel, GetSampleRate, Vol,
                                                                      GetVideoCodec, GetVideoBitrate, GetVideoSize, GetAspectRatio, GetVideoFramerate, Additional_Parameter.Text, OutputFile)
                Case "WAV - Waveform Audio File (*.wav)"
                    OutputFile = WavDir & "\" & IO.Path.GetFileNameWithoutExtension(OriginalFile) & ".wav"
                    FFmpegProcess.StartInfo.Arguments = String.Format(ToAudio, GetThreads, OriginalFile, GetAudioCodec, GetBitrate, GetAudioChanel, GetSampleRate, Vol, Additional_Parameter.Text, OutputFile)
                Case "FLAC - Free Lossless Audio Codec (*.flac)"
                    OutputFile = FlacDir & "\" & IO.Path.GetFileNameWithoutExtension(OriginalFile) & ".flac"
                    FFmpegProcess.StartInfo.Arguments = String.Format(ToAudio, GetThreads, OriginalFile, GetAudioCodec, GetBitrate, GetAudioChanel, GetSampleRate, Vol, Additional_Parameter.Text, OutputFile)
                Case "MOV - QuickTime Movie (*.mov)"
                    OutputFile = MovDir & "\" & IO.Path.GetFileNameWithoutExtension(OriginalFile) & ".mov"
                    FFmpegProcess.StartInfo.Arguments = String.Format(ToVideo, GetThreads, OriginalFile, GetAudioCodec, GetBitrate, GetAudioChanel, GetSampleRate, Vol,
                   GetVideoCodec, GetVideoBitrate, GetVideoSize, GetAspectRatio, GetVideoFramerate, Additional_Parameter.Text, OutputFile)
                Case "MPG - MPG Movie (*.mpg)"
                    OutputFile = MpgDir & "\" & IO.Path.GetFileNameWithoutExtension(OriginalFile) & ".mpg"
                    FFmpegProcess.StartInfo.Arguments = String.Format(ToVideo, GetThreads, OriginalFile, GetAudioCodec, GetBitrate, GetAudioChanel, GetSampleRate, Vol,
                   GetVideoCodec, GetVideoBitrate, GetVideoSize, GetAspectRatio, GetVideoFramerate, "-target ntsc-dvd " & Additional_Parameter.Text, OutputFile)
                Case "M2TS - MPEG-2 Transport Stream (*.m2ts)"
                    OutputFile = M2tsDir & "\" & IO.Path.GetFileNameWithoutExtension(OriginalFile) & ".m2ts"
                    FFmpegProcess.StartInfo.Arguments = String.Format(ToVideo, GetThreads, OriginalFile, GetAudioCodec, GetBitrate, GetAudioChanel, GetSampleRate, Vol,
                   GetVideoCodec, GetVideoBitrate, GetVideoSize, GetAspectRatio, GetVideoFramerate, Additional_Parameter.Text, OutputFile)
                Case "AAC - Advanced Audio Coding (*.aac)"
                    OutputFile = AacDir & "\" & IO.Path.GetFileNameWithoutExtension(OriginalFile) & ".aac"
                    FFmpegProcess.StartInfo.Arguments = String.Format(ToAudio, GetThreads, OriginalFile, GetAudioCodec, GetBitrate, GetAudioChanel, GetSampleRate, Vol, Additional_Parameter.Text, OutputFile)
                Case "AC3 - Audio Coding 3 (*.ac3)"
                    OutputFile = Ac3Dir & "\" & IO.Path.GetFileNameWithoutExtension(OriginalFile) & ".ac3"
                    FFmpegProcess.StartInfo.Arguments = String.Format(ToAudio, GetThreads, OriginalFile, GetAudioCodec, GetBitrate, GetAudioChanel, GetSampleRate, Vol, Additional_Parameter.Text, OutputFile)
            End Select
            FFmpegProcess.StartInfo.FileName = FFmpegPath
            FFmpegProcess.StartInfo.WorkingDirectory = My.Computer.FileSystem.CurrentDirectory
            FFmpegProcess.StartInfo.UseShellExecute = False
            FFmpegProcess.StartInfo.RedirectStandardError = True
            FFmpegProcess.StartInfo.CreateNoWindow = True
            FFmpegProcess.Start()
            Stopwatch.Reset()
            Stopwatch.Start()
            Do
                If Worker.CancellationPending Then
                    e.Cancel = True
                    FFmpegProcess.Kill()
                    Exit Do
                End If
                Status.Invoke(Sub() Status.Text = "Converting: " & IO.Path.GetFileName(OriginalFile))
                Dim cLine = FFmpegProcess.StandardError.ReadLine
                If Not cLine Is Nothing Then
                    Static Duration As Double
                    If cLine.Contains("Duration:") Then
                        Dim str = cLine.Substring(cLine.IndexOf(":") + 2)
                        Duration = TimeSpan.Parse(str.Remove(str.IndexOf(","))).TotalSeconds
                    ElseIf cLine.Contains("time=") Then
                        Dim str = cLine.Substring(cLine.IndexOf(":") - 2)
                        Dim Percent = Convert.ToInt32(TimeSpan.Parse(str.Remove(str.IndexOf("b") - 1)).TotalSeconds / Duration * 100)
                        If Percent > 0 Then
                            Dim Dec As Decimal = Convert.ToDecimal((Convert.ToInt32(Stopwatch.Elapsed.TotalSeconds) / Percent) * 100)
                            Dim TimeLeft As New TimeSpan(0, 0, Convert.ToInt32(Dec - Stopwatch.Elapsed.TotalSeconds))
                            ConverterProgress.Invoke(Sub()
                                                         ConverterProgress.Value = Percent
                                                         ConverterProgress.Text = index + 1 & " of " & Items.Count & " | Time Left " & TimeLeft.ToString & " | " & Percent & " %"
                                                     End Sub)
                        End If
                    End If
                End If
            Loop Until FFmpegProcess.HasExited
            If Delete_Original.Invoke(Function() Delete_Original.Checked) Then
                Snooze(3)
                Try
                    My.Computer.FileSystem.DeleteFile(OriginalFile, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.DoNothing)
                Catch
                End Try
            End If
        Next
        FFmpegProcess.Close()
    End Sub


    Private Sub Worker_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles Worker.RunWorkerCompleted
        If e.Error IsNot Nothing Then
            Status.Text = e.Error.Message
        ElseIf e.Cancelled Then
            Status.Text = "Conversion Canceled"
        Else
            Status.Text = "Conversion Completed"
        End If
        ConverterProgress.Text = ""
        ConverterProgress.Value = 0
    End Sub

    Sub CanceledConversion()
        If Worker.IsBusy Then Worker.CancelAsync()
        Snooze(3)
        Try
            For Each FFmpeg In Process.GetProcessesByName("FFmpeg")
                FFmpeg.Kill()
            Next
            IO.File.Delete(OutputFile)
        Catch
        End Try
    End Sub

    Sub SetAudioCodec(ByVal codec As String(), ByVal [default] As String)
        audio_Codec.Items.Clear()
        audio_Codec.Items.AddRange(codec)
        audio_Codec.Text = [default]
        gVideo.Enabled = False
    End Sub

    Sub SetVideoCodec(ByVal codec As String(), ByVal [default] As String)
        video_Codec.Items.Clear()
        video_Codec.Items.AddRange(codec)
        video_Codec.Text = [default]
        gVideo.Enabled = True
    End Sub

    Private Sub Profile_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Profile.SelectedIndexChanged
        Additional_Parameter.Text = ""
        Select Case Profile.Text
            Case "AVI - Audio Video Interleave (*.avi)"
                SetAudioCodec(New String() {"Original", "aac", "ac3", "mp2", "mp3", "pcm"}, "mp3")
                SetVideoCodec(New String() {"Original", "x264", "XviD", "mpeg4", "msmpeg4", "msmpeg4v2", "msmpeg4v3", "Microsoft Video 1", "mjpeg", "mpeg1", "mpeg2", "h263p", "huffyuv", "ffv1", "wmv1", "wmv2"}, "XviD")
            Case "MP4 - MPEG-4 Movie (*.mp4)"
                SetAudioCodec(New String() {"aac", "mp3"}, "aac")
                SetVideoCodec(New String() {"x264", "mpeg4"}, "x264")
            Case "WMV - Windows Media Video (*.wmv)"
                SetAudioCodec(New String() {"wmav1", "wmav2"}, "wmav2")
                SetVideoCodec(New String() {"wmv1", "wmv2"}, "wmv2")
            Case "FLV - Flash Video (*.flv)"
                SetAudioCodec(New String() {"aac", "mp3"}, "mp3")
                SetVideoCodec(New String() {"flv"}, "flv")
            Case "WebM - Web Movie (*.webm)"
                SetAudioCodec(New String() {"vorbis", "opus"}, "vorbis")
                SetVideoCodec(New String() {"vp8", "vp9"}, "vp8")
            Case "MOV - QuickTime Movie (*.mov)"
                SetAudioCodec(New String() {"aac", "mp3"}, "aac")
                SetVideoCodec(New String() {"x264", "mpeg4"}, "x264")
            Case "MPG - MPG Movie (*.mpg)"
                SetAudioCodec(New String() {"ac3"}, "ac3")
                SetVideoCodec(New String() {"mpeg2"}, "mpeg2")
            Case "M2TS - MPEG-2 Transport Stream (*.m2ts)"
                SetAudioCodec(New String() {"ac3"}, "ac3")
                SetVideoCodec(New String() {"x264"}, "x264")
            Case "AAC - Advanced Audio Coding (*.aac)"
                SetAudioCodec(New String() {"aac"}, "aac")
            Case "AC3 - Audio Coding 3 (*.ac3)"
                SetAudioCodec(New String() {"ac3", "eac3"}, "ac3")
            Case "WAV - Waveform Audio File (*.wav)"
                SetAudioCodec(New String() {"pcm"}, "pcm")
            Case "FLAC - Free Lossless Audio Codec (*.flac)"
                SetAudioCodec(New String() {"flac"}, "flac")
            Case "MP3 - MPEG Layer-3 Audio (*.mp3)"
                SetAudioCodec(New String() {"mp3"}, "mp3")
            Case "M4A - MPEG-4 Audio (*.m4a)"
                SetAudioCodec(New String() {"aac"}, "aac")
            Case "WMA - Windows Media Audio (*.wma)"
                SetAudioCodec(New String() {"wmav1", "wmav2"}, "wmav2")
            Case "OGG - Vorbis Audio File (*.ogg)"
                SetAudioCodec(New String() {"vorbis"}, "vorbis")
        End Select
    End Sub



    Private Sub OpenAndConvertToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenAndConvertToolStripMenuItem.Click
        If IO.File.Exists(FFmpegPath) Then
            If Not Worker.IsBusy Then
                With New OpenFileDialog
                    .FileName = ""
                    .Filter = "All file types |*.*|AAC |*.acc|AC3 |*.ac3|AVI |*.avi|FLV |*.flv|MOV |*.mov|MP4 |*.mp4|MPG |*.mpg|M2TS |*.m2ts|WEBM |*.webm|WMV |*.wmv|FLAC |*.flac|MP3 |*.mp3|M4A |*.m4a|OGG |*.ogg|WAV |*.wav|WMA |*.wma"
                    .InitialDirectory = DownloadDir
                    .Multiselect = True
                    If .ShowDialog = 1 Then
                        Items.Clear()
                        For Each file In .FileNames
                            Items.Add(file)
                        Next
                        Worker.RunWorkerAsync()
                    End If
                End With
            Else
                MsgBox("Conversion in progress. Do you want to cancel it?", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
            End If
        Else
            Status.Text = "The system cannot find the file specified: FFmpeg.exe"
        End If
    End Sub

    Private Sub CancelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelToolStripMenuItem.Click
        CanceledConversion()
    End Sub

    Private Sub OutputToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OutputToolStripMenuItem.Click
        Select Case Profile.SelectedIndex
            Case 0
                Process.Start(AviDir)
            Case 1
                Process.Start(FlvDir)
            Case 2
                Process.Start(MovDir)
            Case 3
                Process.Start(Mp4Dir)
            Case 4
                Process.Start(MpgDir)
            Case 5
                Process.Start(M2tsDir)
            Case 6
                Process.Start(WebMDir)
            Case 7
                Process.Start(WmvDir)
            Case 8
                Process.Start(AacDir)
            Case 9
                Process.Start(Ac3Dir)
            Case 10
                Process.Start(FlacDir)
            Case 11
                Process.Start(Mp3Dir)
            Case 12
                Process.Start(M4aDir)
            Case 13
                Process.Start(OggDir)
            Case 14
                Process.Start(WavDir)
            Case 15
                Process.Start(WmaDir)
            Case Else
                Process.Start(ConvertDir)
        End Select
    End Sub

    Sub SaveSettings()
        Dim IniWriter As New IniFile(SettingPath)
        IniWriter.Section = "Converter"
        IniWriter.WriteString("Profile", Profile.Text)
        IniWriter.WriteString("Audio_Codec", audio_Codec.Text)
        IniWriter.WriteString("Audio_Bitrate", audio_Bitrate.Text)
        IniWriter.WriteString("Audio_Chanel", audio_Chanel.Text)
        IniWriter.WriteString("Audio_Samplerate", audio_Samplerate.Text)
        IniWriter.WriteString("Video_Codec", video_Codec.Text)
        IniWriter.WriteString("Video_Bitrate", video_Bitrate.Text)
        IniWriter.WriteString("Video_Size", video_Size.Text)
        IniWriter.WriteString("Video_Framerate", video_Framerate.Text)
        IniWriter.WriteString("Video_AspectRatio", video_AspectRatio.Text)
        IniWriter.WriteString("Additional_Parameter", Additional_Parameter.Text)
        IniWriter.WriteString("Delete_Original_File", Delete_Original.Checked)
        IniWriter.WriteString("Auto_Updates", auto_check.Checked)
    End Sub

    Sub LoadSettings()
        Dim IniReader As New IniFile(SettingPath)
        IniReader.Section = "Converter"
        Profile.Text = IniReader.ReadString("Profile", "MP4 - MPEG-4 Movie (*.mp4)")
        audio_Codec.Text = IniReader.ReadString("Audio_Codec", "aac")
        audio_Bitrate.Text = IniReader.ReadString("Audio_Bitrate", 160)
        audio_Chanel.Text = IniReader.ReadString("Audio_Chanel", "2 (Stereo)")
        audio_Samplerate.Text = IniReader.ReadString("Audio_Samplerate", 44100)
        If String.IsNullOrEmpty(video_Codec.Text) Then
            video_Codec.Items.Clear()
            video_Codec.Items.Add(IniReader.ReadString("Video_Codec", "x264"))
        End If
        video_Codec.Text = IniReader.ReadString("Video_Codec", "x264")
        video_Bitrate.Text = IniReader.ReadString("Video_Bitrate", 1500)
        video_Size.Text = IniReader.ReadString("Video_Size", "1080x720")
        video_Framerate.Text = IniReader.ReadString("Video_Framerate", 25)
        video_AspectRatio.Text = IniReader.ReadString("Video_AspectRatio", "16:9 (Widescreen)")
        Delete_Original.Checked = CBool(IniReader.ReadString("Delete_Original_File", False))
        Additional_Parameter.Text = IniReader.ReadString("Additional_Parameter", "")
        auto_check.Checked = CBool(IniReader.ReadString("Auto_Updates", False))
    End Sub

    Private Sub PresetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PresetToolStripMenuItem.Click
        frmPresetManager.Show()
    End Sub


    Private Sub volBar_Scroll_1(sender As Object, e As EventArgs) Handles volBar.Scroll, volBar.ValueChanged
        Vol = (volBar.Value * 0.1)
        ToolTip1.Show("Volume: " & volBar.Value * 10, volBar, 0, -20, 1000)
    End Sub

#End Region

End Class