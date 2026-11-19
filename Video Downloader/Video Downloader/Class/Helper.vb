Module Helper

    Public Function GoogleDriveDirectLink(ByVal url As String) As String
        If (url.Contains("/open?id=")) Then
            url = url.Replace("/open?id=", "/uc?export=download&id=")
            Return url
        End If
        Return ""
    End Function

    Public Function DownloadString(ByVal Url As String) As String
        Try
            Dim html As String = Nothing
            With CType(Net.HttpWebRequest.Create(Url), Net.HttpWebRequest)
                .UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.31 (KHTML, like Gecko) Chrome/26.0.1410.64 Safari/537.31"
                .KeepAlive = False
                .ReadWriteTimeout = 15000
                Dim Response = .GetResponse
                Dim Reader As New IO.StreamReader(Response.GetResponseStream, System.Text.ASCIIEncoding.UTF8)
                html = Reader.ReadToEnd()
                Reader.Close()
                Response.Close()
            End With
            Return html
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Sub ShowInfo(ByVal strFile As String)
        If IO.File.Exists(strFile) Then
            frmMediaInfo.Show()
            frmMediaInfo.GetInfo(strFile)
        Else
            frmMediaInfo.Show()
        End If
    End Sub

    Public Function GetThreads() As Integer
        Return Environment.ProcessorCount
    End Function

    Public Function FormatBytes(ByVal value As Long) As String
        Dim PB As Long = 1125899906842624
        Dim TB As Long = 1099511627776
        Dim GB As Long = 1073741824
        Dim MB As Long = 1048576
        Dim KB As Long = 1024
        Select Case value
            Case Is > PB
                Return Math.Round(value / PB, 2) & " PB"
            Case Is > TB
                Return Math.Round(value / TB, 2) & " TB"
            Case Is > GB
                Return Math.Round(value / GB, 2) & " GB"
            Case Is > MB
                Return Math.Round(value / MB, 2) & " MB"
            Case Is > KB
                Return Math.Round(value / KB, 2) & " KB"
        End Select
        Return value & " Bytes"
    End Function
    Public Sub Snooze(ByVal seconds As Integer)
        For i As Integer = 0 To seconds * 100
            Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub

    Public Function GetFileVersionInfo(ByVal filename As String) As String
        If IO.File.Exists(filename) Then Return FileVersionInfo.GetVersionInfo(filename).FileVersion.ToString
        Return "n/a"
    End Function

    Public Function ABOUT() As String
        Dim str As New Text.StringBuilder(260)
        str.AppendLine("Video Downloader")
        str.AppendLine("Version " & My.Application.Info.Version.ToString)
        str.AppendLine("Copyright TGProduction's")
        str.AppendLine("https://tg6699.wordpress.com/" & vbNewLine)
        str.AppendLine("Download, Convert and Play Videos from almost any sites.")
        str.AppendLine("Supported sites: https://ytdl-org.github.io/youtube-dl/supportedsites.html" & vbNewLine)
        str.AppendLine("Using" & vbNewLine & getffmpegversion())
        str.AppendLine("https://www.ffmpeg.org/" & vbNewLine)
        str.AppendLine("MediaInfo version " & GetFileVersionInfo("mediainfo.dll") & vbNewLine & "https://mediaarea.net/en/MediaInfo" & vbNewLine)
        str.AppendLine("yt-dlp version " & GetFileVersionInfo("yt-dlp.exe") & vbNewLine & "https://github.com/yt-dlp")
        Return str.ToString
    End Function

    Function getffmpegversion() As String
        Try
            If (IO.File.Exists("ffmpeg.exe")) Then
                Dim v As String = ""
                Using ffmpeg As New Process
                    With ffmpeg.StartInfo
                        .FileName = "ffmpeg.exe"
                        .WorkingDirectory = CurDir()
                        .UseShellExecute = False
                        .RedirectStandardError = True
                        .CreateNoWindow = True
                    End With
                    ffmpeg.Start()
                    v = ffmpeg.StandardError.ReadToEnd
                    ffmpeg.Close()
                End Using
                v = v.Remove(v.IndexOf("Copy"))
                v = v.Replace("ffmpeg", "FFmpeg")
                Return v
            End If
        Catch ex As Exception
        End Try
        Return ""
    End Function

End Module