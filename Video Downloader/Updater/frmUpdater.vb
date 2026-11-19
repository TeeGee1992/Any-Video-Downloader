Public Class frmUpdater

#Region " Downloader "

    Dim UpdateUrl As String
    Dim UpdaterDir As String = My.Computer.FileSystem.CurrentDirectory & "\update_tmp"
    Dim Updates As String = UpdaterDir & "\Updates.rar"
    Dim Counter As New Stopwatch
    WithEvents Downloader As New Net.WebClient

    Private Sub btnDownload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDownload.Click
        btnDownload.Enabled = False
        Status.Text = "Please wait while downloading updates..."
        Snooze(3)
        Try
            Downloader.DownloadFileAsync(New Uri(UpdateUrl), Updates)
            Counter.Start()
        Catch ex As Exception
            Status.Text = ex.Message
        End Try
    End Sub

    Private Sub Downloader_DownloadProgressChanged(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs) Handles Downloader.DownloadProgressChanged
        Status.Value = e.ProgressPercentage
        Status.Text = String.Format("Downloading {0} of {1} | Speed {2} | {3} %", FormatBytes(e.BytesReceived), FormatBytes(e.TotalBytesToReceive), FormatBytes(e.BytesReceived / Counter.Elapsed.TotalSeconds), Status.Value)
    End Sub

    Private Sub Downloader_DownloadFileCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs) Handles Downloader.DownloadFileCompleted
        Counter.Reset()
        Status.Value = 0
        If e.Cancelled Then
            Status.Text = "Download canceled"
        ElseIf e.Error IsNot Nothing Then
            Status.Text = e.Error.Message
        Else
            Status.Text = "Please wait while installing updates..."
            Snooze(3)
            Install(Updates, My.Computer.FileSystem.CurrentDirectory, "", True)
        End If
    End Sub

#End Region

#Region " Other "

    Dim ProcessToLaunch As String
  
    Function FormatBytes(ByVal value As Long) As String
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

    Sub Snooze(ByVal seconds As Integer)
        For i As Integer = 0 To seconds * 100
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub


    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Not iDone Then
            If e.Cancel = False Then
                If MsgBox("Are you sure you want to cancel?", MsgBoxStyle.Question + vbYesNo) = MsgBoxResult.Yes Then
                    Enabled = False
                    If Downloader.IsBusy Then
                        Downloader.CancelAsync()
                    ElseIf Installer.IsBusy Then
                        Installer.CancelAsync()
                    End If
                Else
                    e.Cancel = True
                    Exit Sub
                End If
            End If
        End If
        Status.Text = "Exiting..."
        Snooze(1)
        Try : If IO.Directory.Exists(UpdaterDir) Then
                IO.Directory.Delete(UpdaterDir, True)
                IO.File.Delete(UnRarPath)
            End If : Catch ex As Exception : End Try

        If IO.File.Exists(ProcessToLaunch) Then
            Using p As New Process
                With p.StartInfo
                    .FileName = IO.Path.GetFileName(ProcessToLaunch)
                    .WorkingDirectory = IO.Path.GetDirectoryName(ProcessToLaunch)
                End With
                p.Start()
            End Using
        End If

    End Sub

    Private Sub frmUpdater_HelpButtonClicked(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.HelpButtonClicked
        frmAbout.ShowDialog()
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Application.CommandLineArgs.Count > 1 Then
            If Not My.Application.CommandLineArgs.Item(0).ToLower = "-u" Then Environment.Exit(0)
            UpdateUrl = My.Application.CommandLineArgs.Item(1)
            If My.Application.CommandLineArgs.Count = 3 Then ProcessToLaunch = IO.Path.GetFullPath(My.Application.CommandLineArgs.Item(2))
        Else
            MsgBox("[Usage]" & vbCrLf & vbCrLf & "-U (Server to download updates from) ([Optional] Process to launch after update complete)" & vbCrLf & vbCrLf & "[Example]" & vbCrLf & "-U http://Updates.rar/.com" & vbCrLf & "-U http://Updates.rar/.com ""C:\Process.exe""", MsgBoxStyle.Exclamation)
            Environment.Exit(0)
        End If
        IO.Directory.CreateDirectory(UpdaterDir)
        IO.File.WriteAllBytes(UnRarPath, My.Resources.UnRAR)
        Status.Text = "Ready!"
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

#End Region

#Region " Installer "

    Dim iDone As Boolean = False
    Dim UnRarPath As String = My.Computer.FileSystem.CurrentDirectory & "\UnRar.exe"

    Sub Install(ByVal inputFile As String, ByVal outputDir As String, ByVal password As String, ByVal overwrite As Boolean)
        If Not Installer.IsBusy Then Installer.RunWorkerAsync(New Object() {inputFile, outputDir, password, overwrite})
    End Sub

    Sub CancelInstall()
        If Installer.IsBusy Then Installer.CancelAsync()
    End Sub

    Private Sub Installer_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles Installer.ProgressChanged
        Try
            If e.UserState IsNot Nothing Then
                Dim StandardOutput = e.UserState.ToString
                If StandardOutput.Contains("Extracting") AndAlso StandardOutput.Contains("%") Then
                    Dim Percent = StandardOutput.Substring(StandardOutput.LastIndexOf("%") - 3)
                    Percent = Convert.ToInt32(Percent.Remove(Percent.IndexOf("%")))
                    Dim FileName = StandardOutput.Substring(StandardOutput.LastIndexOf("\") + 1)
                    FileName = FileName.Remove(FileName.IndexOf("     "))
                    Status.Text = "Installing: " & FileName & " (" & Percent & " %)"
                    Status.Value = Percent
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Installer_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles Installer.DoWork
        Using pUnRAR As New Process
            With pUnRAR.StartInfo
                .FileName = UnRarPath
                .WorkingDirectory = My.Computer.FileSystem.CurrentDirectory
                Dim Args() = DirectCast(e.Argument, Object())
                If CBool(Args(3)) Then
                    .Arguments = String.Format("x ""{0}"" ""{1}"" -p""{2}"" -y", CStr(Args(0)), CStr(Args(1)), CStr(Args(2)))
                Else
                    .Arguments = String.Format("x ""{0}"" ""{1}"" -p""{2}""", CStr(Args(0)), CStr(Args(1)), CStr(Args(2)))
                End If
                .UseShellExecute = False
                .RedirectStandardOutput = True
                .CreateNoWindow = True
            End With
            pUnRAR.Start()
            Do
                If Installer.CancellationPending Then
                    pUnRAR.Kill()
                    e.Cancel = True
                    Exit Do
                Else
                    Installer.ReportProgress(0, pUnRAR.StandardOutput.ReadLine)
                End If
            Loop Until pUnRAR.HasExited
            pUnRAR.Close()
        End Using
    End Sub

    Private Sub Installer_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles Installer.RunWorkerCompleted
        Status.Value = 0
        If e.Cancelled Then
            Status.Text = "Installation canceled"
        ElseIf e.Error IsNot Nothing Then
            Status.Text = e.Error.Message
        Else
            iDone = True
            Enabled = False
            Status.Text = "Updates installed successfully"
            Snooze(3)
            Close()
        End If
    End Sub

#End Region

End Class