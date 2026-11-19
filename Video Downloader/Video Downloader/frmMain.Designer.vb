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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Dim ImageComboBoxItem49 As Video_Downloader.cImageComboBox.ImageComboBoxItem = New Video_Downloader.cImageComboBox.ImageComboBoxItem()
        Dim ImageComboBoxItem50 As Video_Downloader.cImageComboBox.ImageComboBoxItem = New Video_Downloader.cImageComboBox.ImageComboBoxItem()
        Dim ImageComboBoxItem51 As Video_Downloader.cImageComboBox.ImageComboBoxItem = New Video_Downloader.cImageComboBox.ImageComboBoxItem()
        Dim ImageComboBoxItem52 As Video_Downloader.cImageComboBox.ImageComboBoxItem = New Video_Downloader.cImageComboBox.ImageComboBoxItem()
        Dim ImageComboBoxItem53 As Video_Downloader.cImageComboBox.ImageComboBoxItem = New Video_Downloader.cImageComboBox.ImageComboBoxItem()
        Dim ImageComboBoxItem54 As Video_Downloader.cImageComboBox.ImageComboBoxItem = New Video_Downloader.cImageComboBox.ImageComboBoxItem()
        Dim ImageComboBoxItem55 As Video_Downloader.cImageComboBox.ImageComboBoxItem = New Video_Downloader.cImageComboBox.ImageComboBoxItem()
        Dim ImageComboBoxItem56 As Video_Downloader.cImageComboBox.ImageComboBoxItem = New Video_Downloader.cImageComboBox.ImageComboBoxItem()
        Dim ImageComboBoxItem57 As Video_Downloader.cImageComboBox.ImageComboBoxItem = New Video_Downloader.cImageComboBox.ImageComboBoxItem()
        Dim ImageComboBoxItem58 As Video_Downloader.cImageComboBox.ImageComboBoxItem = New Video_Downloader.cImageComboBox.ImageComboBoxItem()
        Dim ImageComboBoxItem59 As Video_Downloader.cImageComboBox.ImageComboBoxItem = New Video_Downloader.cImageComboBox.ImageComboBoxItem()
        Dim ImageComboBoxItem60 As Video_Downloader.cImageComboBox.ImageComboBoxItem = New Video_Downloader.cImageComboBox.ImageComboBoxItem()
        Dim ImageComboBoxItem61 As Video_Downloader.cImageComboBox.ImageComboBoxItem = New Video_Downloader.cImageComboBox.ImageComboBoxItem()
        Dim ImageComboBoxItem62 As Video_Downloader.cImageComboBox.ImageComboBoxItem = New Video_Downloader.cImageComboBox.ImageComboBoxItem()
        Dim ImageComboBoxItem63 As Video_Downloader.cImageComboBox.ImageComboBoxItem = New Video_Downloader.cImageComboBox.ImageComboBoxItem()
        Dim ImageComboBoxItem64 As Video_Downloader.cImageComboBox.ImageComboBoxItem = New Video_Downloader.cImageComboBox.ImageComboBoxItem()
        Me.Worker = New System.ComponentModel.BackgroundWorker()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewDownloadToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClearToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.FileInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DownloadsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CButton2 = New Video_Downloader.cButton()
        Me.CButton1 = New Video_Downloader.cButton()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.CTabControl1 = New Video_Downloader.cTabControl()
        Me.Downloader = New System.Windows.Forms.TabPage()
        Me.Playlist = New Video_Downloader.cCheckBox()
        Me.DownloadList = New Video_Downloader.cListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DownloaderMenu = New System.Windows.Forms.MenuStrip()
        Me.NewDownloadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DownloadsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Converter = New System.Windows.Forms.TabPage()
        Me.Delete_Original = New Video_Downloader.cCheckBox()
        Me.Additional_Parameter = New Video_Downloader.cTextbox()
        Me.gStatus = New System.Windows.Forms.GroupBox()
        Me.ConverterProgress = New Video_Downloader.cProgressBar()
        Me.Status = New Video_Downloader.cLabel()
        Me.lblAdditionalParameter = New System.Windows.Forms.Label()
        Me.gAudio = New System.Windows.Forms.GroupBox()
        Me.lblVol = New System.Windows.Forms.Label()
        Me.volBar = New System.Windows.Forms.TrackBar()
        Me.audio_Samplerate = New Video_Downloader.XXCombox()
        Me.audio_Chanel = New Video_Downloader.XXCombox()
        Me.audio_Bitrate = New Video_Downloader.XXCombox()
        Me.audio_Codec = New Video_Downloader.XXCombox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.gVideo = New System.Windows.Forms.GroupBox()
        Me.video_AspectRatio = New Video_Downloader.XXCombox()
        Me.video_Framerate = New Video_Downloader.XXCombox()
        Me.video_Size = New Video_Downloader.XXCombox()
        Me.video_Bitrate = New Video_Downloader.XXCombox()
        Me.video_Codec = New Video_Downloader.XXCombox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblvCodec = New System.Windows.Forms.Label()
        Me.Profile = New Video_Downloader.cImageComboBox()
        Me.ConverterMenu = New System.Windows.Forms.MenuStrip()
        Me.PresetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenAndConvertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OutputToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.About = New System.Windows.Forms.TabPage()
        Me.auto_check = New Video_Downloader.cCheckBox()
        Me.btnCheckforupdates = New Video_Downloader.cButton()
        Me.lblDonate = New System.Windows.Forms.LinkLabel()
        Me.txtAbout = New System.Windows.Forms.RichTextBox()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.CTabControl1.SuspendLayout()
        Me.Downloader.SuspendLayout()
        Me.DownloaderMenu.SuspendLayout()
        Me.Converter.SuspendLayout()
        Me.gStatus.SuspendLayout()
        Me.gAudio.SuspendLayout()
        CType(Me.volBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gVideo.SuspendLayout()
        Me.ConverterMenu.SuspendLayout()
        Me.About.SuspendLayout()
        Me.SuspendLayout()
        '
        'Worker
        '
        Me.Worker.WorkerReportsProgress = True
        Me.Worker.WorkerSupportsCancellation = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewDownloadToolStripMenuItem1, Me.ToolStripSeparator2, Me.ClearToolStripMenuItem1, Me.ToolStripSeparator3, Me.FileInfoToolStripMenuItem, Me.ToolStripSeparator1, Me.DownloadsToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(186, 126)
        '
        'NewDownloadToolStripMenuItem1
        '
        Me.NewDownloadToolStripMenuItem1.Image = Global.Video_Downloader.My.Resources.Resources.NewDownload
        Me.NewDownloadToolStripMenuItem1.Name = "NewDownloadToolStripMenuItem1"
        Me.NewDownloadToolStripMenuItem1.Size = New System.Drawing.Size(185, 26)
        Me.NewDownloadToolStripMenuItem1.Text = "New Download"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(182, 6)
        '
        'ClearToolStripMenuItem1
        '
        Me.ClearToolStripMenuItem1.Image = Global.Video_Downloader.My.Resources.Resources.Clear
        Me.ClearToolStripMenuItem1.Name = "ClearToolStripMenuItem1"
        Me.ClearToolStripMenuItem1.Size = New System.Drawing.Size(185, 26)
        Me.ClearToolStripMenuItem1.Text = "Clear"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(182, 6)
        '
        'FileInfoToolStripMenuItem
        '
        Me.FileInfoToolStripMenuItem.Image = Global.Video_Downloader.My.Resources.Resources.Fileinfo
        Me.FileInfoToolStripMenuItem.Name = "FileInfoToolStripMenuItem"
        Me.FileInfoToolStripMenuItem.Size = New System.Drawing.Size(185, 26)
        Me.FileInfoToolStripMenuItem.Text = "MediaInfo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(182, 6)
        '
        'DownloadsToolStripMenuItem1
        '
        Me.DownloadsToolStripMenuItem1.Image = Global.Video_Downloader.My.Resources.Resources.Downloads
        Me.DownloadsToolStripMenuItem1.Name = "DownloadsToolStripMenuItem1"
        Me.DownloadsToolStripMenuItem1.Size = New System.Drawing.Size(185, 26)
        Me.DownloadsToolStripMenuItem1.Text = "Downloads"
        '
        'CButton2
        '
        Me.CButton2.Location = New System.Drawing.Point(1024, 8)
        Me.CButton2.Margin = New System.Windows.Forms.Padding(4)
        Me.CButton2.Name = "CButton2"
        Me.CButton2.Size = New System.Drawing.Size(24, 24)
        Me.CButton2.TabIndex = 2
        Me.CButton2.Text = "X"
        Me.ToolTip1.SetToolTip(Me.CButton2, "Close")
        '
        'CButton1
        '
        Me.CButton1.Location = New System.Drawing.Point(998, 8)
        Me.CButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.CButton1.Name = "CButton1"
        Me.CButton1.Size = New System.Drawing.Size(24, 24)
        Me.CButton1.TabIndex = 1
        Me.CButton1.Text = "_"
        Me.ToolTip1.SetToolTip(Me.CButton1, "Minimize")
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Video Downloader"
        Me.NotifyIcon1.Visible = True
        '
        'CTabControl1
        '
        Me.CTabControl1.Controls.Add(Me.Downloader)
        Me.CTabControl1.Controls.Add(Me.Converter)
        Me.CTabControl1.Controls.Add(Me.About)
        Me.CTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CTabControl1.Font = New System.Drawing.Font("Verdana", 6.75!)
        Me.CTabControl1.ItemSize = New System.Drawing.Size(110, 32)
        Me.CTabControl1.Location = New System.Drawing.Point(19, 56)
        Me.CTabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.CTabControl1.Multiline = True
        Me.CTabControl1.Name = "CTabControl1"
        Me.CTabControl1.SelectedIndex = 0
        Me.CTabControl1.Size = New System.Drawing.Size(1023, 536)
        Me.CTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.CTabControl1.TabIndex = 0
        '
        'Downloader
        '
        Me.Downloader.BackColor = System.Drawing.Color.Transparent
        Me.Downloader.Controls.Add(Me.Playlist)
        Me.Downloader.Controls.Add(Me.DownloadList)
        Me.Downloader.Controls.Add(Me.DownloaderMenu)
        Me.Downloader.ImageIndex = 0
        Me.Downloader.Location = New System.Drawing.Point(4, 36)
        Me.Downloader.Margin = New System.Windows.Forms.Padding(2)
        Me.Downloader.Name = "Downloader"
        Me.Downloader.Padding = New System.Windows.Forms.Padding(2)
        Me.Downloader.Size = New System.Drawing.Size(1015, 496)
        Me.Downloader.TabIndex = 0
        Me.Downloader.Text = "Download"
        '
        'Playlist
        '
        Me.Playlist.BackColor = System.Drawing.Color.Silver
        Me.Playlist.Checked = False
        Me.Playlist.Location = New System.Drawing.Point(439, 8)
        Me.Playlist.Margin = New System.Windows.Forms.Padding(4)
        Me.Playlist.Name = "Playlist"
        Me.Playlist.Size = New System.Drawing.Size(195, 20)
        Me.Playlist.TabIndex = 3
        Me.Playlist.Text = "Download Playlist"
        '
        'DownloadList
        '
        Me.DownloadList.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.DownloadList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DownloadList.Color1 = System.Drawing.Color.Green
        Me.DownloadList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.DownloadList.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DownloadList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DownloadList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.DownloadList.HideSelection = False
        Me.DownloadList.Location = New System.Drawing.Point(2, 28)
        Me.DownloadList.Margin = New System.Windows.Forms.Padding(2)
        Me.DownloadList.Name = "DownloadList"
        Me.DownloadList.OwnerDraw = True
        Me.DownloadList.Size = New System.Drawing.Size(1011, 466)
        Me.DownloadList.TabIndex = 1
        Me.DownloadList.UseCompatibleStateImageBehavior = False
        Me.DownloadList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Title"
        Me.ColumnHeader1.Width = 554
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Status"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Progress"
        Me.ColumnHeader3.Width = 120
        '
        'DownloaderMenu
        '
        Me.DownloaderMenu.BackColor = System.Drawing.Color.Silver
        Me.DownloaderMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.DownloaderMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewDownloadToolStripMenuItem, Me.ClearToolStripMenuItem, Me.DownloadsToolStripMenuItem})
        Me.DownloaderMenu.Location = New System.Drawing.Point(2, 2)
        Me.DownloaderMenu.Name = "DownloaderMenu"
        Me.DownloaderMenu.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        Me.DownloaderMenu.Size = New System.Drawing.Size(1011, 26)
        Me.DownloaderMenu.TabIndex = 0
        Me.DownloaderMenu.Text = "MenuStrip1"
        '
        'NewDownloadToolStripMenuItem
        '
        Me.NewDownloadToolStripMenuItem.Image = Global.Video_Downloader.My.Resources.Resources.NewDownload
        Me.NewDownloadToolStripMenuItem.Name = "NewDownloadToolStripMenuItem"
        Me.NewDownloadToolStripMenuItem.Size = New System.Drawing.Size(146, 24)
        Me.NewDownloadToolStripMenuItem.Text = "New Download"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Image = Global.Video_Downloader.My.Resources.Resources.Clear
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(77, 24)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'DownloadsToolStripMenuItem
        '
        Me.DownloadsToolStripMenuItem.Image = CType(resources.GetObject("DownloadsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DownloadsToolStripMenuItem.Name = "DownloadsToolStripMenuItem"
        Me.DownloadsToolStripMenuItem.Size = New System.Drawing.Size(118, 24)
        Me.DownloadsToolStripMenuItem.Text = "Downloads"
        '
        'Converter
        '
        Me.Converter.BackColor = System.Drawing.Color.Silver
        Me.Converter.Controls.Add(Me.Delete_Original)
        Me.Converter.Controls.Add(Me.Additional_Parameter)
        Me.Converter.Controls.Add(Me.gStatus)
        Me.Converter.Controls.Add(Me.lblAdditionalParameter)
        Me.Converter.Controls.Add(Me.gAudio)
        Me.Converter.Controls.Add(Me.gVideo)
        Me.Converter.Controls.Add(Me.Profile)
        Me.Converter.Controls.Add(Me.ConverterMenu)
        Me.Converter.ImageIndex = 1
        Me.Converter.Location = New System.Drawing.Point(4, 36)
        Me.Converter.Margin = New System.Windows.Forms.Padding(2)
        Me.Converter.Name = "Converter"
        Me.Converter.Padding = New System.Windows.Forms.Padding(2)
        Me.Converter.Size = New System.Drawing.Size(1015, 496)
        Me.Converter.TabIndex = 1
        Me.Converter.Text = "Convert"
        '
        'Delete_Original
        '
        Me.Delete_Original.Checked = False
        Me.Delete_Original.Location = New System.Drawing.Point(665, 66)
        Me.Delete_Original.Margin = New System.Windows.Forms.Padding(4)
        Me.Delete_Original.Name = "Delete_Original"
        Me.Delete_Original.Size = New System.Drawing.Size(335, 18)
        Me.Delete_Original.TabIndex = 26
        Me.Delete_Original.Text = "Delete original file when complete"
        '
        'Additional_Parameter
        '
        Me.Additional_Parameter.Location = New System.Drawing.Point(512, 91)
        Me.Additional_Parameter.Margin = New System.Windows.Forms.Padding(4)
        Me.Additional_Parameter.Name = "Additional_Parameter"
        Me.Additional_Parameter.Size = New System.Drawing.Size(488, 22)
        Me.Additional_Parameter.TabIndex = 12
        '
        'gStatus
        '
        Me.gStatus.Controls.Add(Me.ConverterProgress)
        Me.gStatus.Controls.Add(Me.Status)
        Me.gStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gStatus.Location = New System.Drawing.Point(2, 416)
        Me.gStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.gStatus.Name = "gStatus"
        Me.gStatus.Padding = New System.Windows.Forms.Padding(2)
        Me.gStatus.Size = New System.Drawing.Size(1011, 78)
        Me.gStatus.TabIndex = 25
        Me.gStatus.TabStop = False
        Me.gStatus.Text = "Status"
        '
        'ConverterProgress
        '
        Me.ConverterProgress.BackColor = System.Drawing.Color.White
        Me.ConverterProgress.Color1 = System.Drawing.Color.Green
        Me.ConverterProgress.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ConverterProgress.ForeColor = System.Drawing.Color.Black
        Me.ConverterProgress.Location = New System.Drawing.Point(2, 56)
        Me.ConverterProgress.Margin = New System.Windows.Forms.Padding(2)
        Me.ConverterProgress.Maximum = 100
        Me.ConverterProgress.Name = "ConverterProgress"
        Me.ConverterProgress.Size = New System.Drawing.Size(1007, 20)
        Me.ConverterProgress.TabIndex = 1
        Me.ConverterProgress.Value = 0
        '
        'Status
        '
        Me.Status.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Status.BackColor = System.Drawing.Color.Silver
        Me.Status.Location = New System.Drawing.Point(2, 18)
        Me.Status.Margin = New System.Windows.Forms.Padding(2)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(1005, 39)
        Me.Status.TabIndex = 0
        '
        'lblAdditionalParameter
        '
        Me.lblAdditionalParameter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAdditionalParameter.AutoSize = True
        Me.lblAdditionalParameter.Location = New System.Drawing.Point(509, 68)
        Me.lblAdditionalParameter.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAdditionalParameter.Name = "lblAdditionalParameter"
        Me.lblAdditionalParameter.Size = New System.Drawing.Size(139, 14)
        Me.lblAdditionalParameter.TabIndex = 24
        Me.lblAdditionalParameter.Text = "Additional parameter"
        '
        'gAudio
        '
        Me.gAudio.Controls.Add(Me.lblVol)
        Me.gAudio.Controls.Add(Me.volBar)
        Me.gAudio.Controls.Add(Me.audio_Samplerate)
        Me.gAudio.Controls.Add(Me.audio_Chanel)
        Me.gAudio.Controls.Add(Me.audio_Bitrate)
        Me.gAudio.Controls.Add(Me.audio_Codec)
        Me.gAudio.Controls.Add(Me.Label6)
        Me.gAudio.Controls.Add(Me.Label7)
        Me.gAudio.Controls.Add(Me.Label8)
        Me.gAudio.Controls.Add(Me.Label9)
        Me.gAudio.Location = New System.Drawing.Point(12, 119)
        Me.gAudio.Margin = New System.Windows.Forms.Padding(2)
        Me.gAudio.Name = "gAudio"
        Me.gAudio.Padding = New System.Windows.Forms.Padding(2)
        Me.gAudio.Size = New System.Drawing.Size(488, 279)
        Me.gAudio.TabIndex = 21
        Me.gAudio.TabStop = False
        Me.gAudio.Text = "Video"
        '
        'lblVol
        '
        Me.lblVol.Location = New System.Drawing.Point(3, 227)
        Me.lblVol.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblVol.Name = "lblVol"
        Me.lblVol.Size = New System.Drawing.Size(225, 15)
        Me.lblVol.TabIndex = 15
        Me.lblVol.Text = "Volume -"
        Me.lblVol.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'volBar
        '
        Me.volBar.BackColor = System.Drawing.Color.Black
        Me.volBar.LargeChange = 1
        Me.volBar.Location = New System.Drawing.Point(232, 208)
        Me.volBar.Margin = New System.Windows.Forms.Padding(2)
        Me.volBar.Maximum = 20
        Me.volBar.Name = "volBar"
        Me.volBar.Size = New System.Drawing.Size(225, 56)
        Me.volBar.TabIndex = 14
        Me.volBar.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.volBar.Value = 10
        '
        'audio_Samplerate
        '
        Me.audio_Samplerate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.audio_Samplerate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.audio_Samplerate.FormattingEnabled = True
        Me.audio_Samplerate.ItemHeight = 20
        Me.audio_Samplerate.Items.AddRange(New Object() {"8000", "11025", "12000", "16000", "22050", "24000", "32000", "44100", "48000"})
        Me.audio_Samplerate.Location = New System.Drawing.Point(232, 175)
        Me.audio_Samplerate.Margin = New System.Windows.Forms.Padding(4)
        Me.audio_Samplerate.Name = "audio_Samplerate"
        Me.audio_Samplerate.Size = New System.Drawing.Size(225, 26)
        Me.audio_Samplerate.TabIndex = 13
        '
        'audio_Chanel
        '
        Me.audio_Chanel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.audio_Chanel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.audio_Chanel.FormattingEnabled = True
        Me.audio_Chanel.ItemHeight = 20
        Me.audio_Chanel.Items.AddRange(New Object() {"1 (Mono)", "2 (Stereo)"})
        Me.audio_Chanel.Location = New System.Drawing.Point(232, 125)
        Me.audio_Chanel.Margin = New System.Windows.Forms.Padding(4)
        Me.audio_Chanel.Name = "audio_Chanel"
        Me.audio_Chanel.Size = New System.Drawing.Size(225, 26)
        Me.audio_Chanel.TabIndex = 12
        '
        'audio_Bitrate
        '
        Me.audio_Bitrate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.audio_Bitrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.audio_Bitrate.FormattingEnabled = True
        Me.audio_Bitrate.ItemHeight = 20
        Me.audio_Bitrate.Items.AddRange(New Object() {"8", "16", "24", "32", "48", "56", "64", "96", "112", "128", "160", "192", "224", "256", "320"})
        Me.audio_Bitrate.Location = New System.Drawing.Point(232, 75)
        Me.audio_Bitrate.Margin = New System.Windows.Forms.Padding(4)
        Me.audio_Bitrate.Name = "audio_Bitrate"
        Me.audio_Bitrate.Size = New System.Drawing.Size(225, 26)
        Me.audio_Bitrate.TabIndex = 11
        '
        'audio_Codec
        '
        Me.audio_Codec.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.audio_Codec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.audio_Codec.FormattingEnabled = True
        Me.audio_Codec.ItemHeight = 20
        Me.audio_Codec.Location = New System.Drawing.Point(232, 25)
        Me.audio_Codec.Margin = New System.Windows.Forms.Padding(4)
        Me.audio_Codec.Name = "audio_Codec"
        Me.audio_Codec.Size = New System.Drawing.Size(225, 26)
        Me.audio_Codec.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(6, 184)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(225, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Saplerate -"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(5, 134)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(225, 15)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Chanel -"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(6, 84)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(225, 15)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Bitrate -"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(6, 34)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(225, 15)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Codec -"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gVideo
        '
        Me.gVideo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gVideo.Controls.Add(Me.video_AspectRatio)
        Me.gVideo.Controls.Add(Me.video_Framerate)
        Me.gVideo.Controls.Add(Me.video_Size)
        Me.gVideo.Controls.Add(Me.video_Bitrate)
        Me.gVideo.Controls.Add(Me.video_Codec)
        Me.gVideo.Controls.Add(Me.Label4)
        Me.gVideo.Controls.Add(Me.Label3)
        Me.gVideo.Controls.Add(Me.Label2)
        Me.gVideo.Controls.Add(Me.Label1)
        Me.gVideo.Controls.Add(Me.lblvCodec)
        Me.gVideo.Location = New System.Drawing.Point(511, 119)
        Me.gVideo.Margin = New System.Windows.Forms.Padding(2)
        Me.gVideo.Name = "gVideo"
        Me.gVideo.Padding = New System.Windows.Forms.Padding(2)
        Me.gVideo.Size = New System.Drawing.Size(488, 279)
        Me.gVideo.TabIndex = 20
        Me.gVideo.TabStop = False
        Me.gVideo.Text = "Video"
        '
        'video_AspectRatio
        '
        Me.video_AspectRatio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.video_AspectRatio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.video_AspectRatio.FormattingEnabled = True
        Me.video_AspectRatio.ItemHeight = 20
        Me.video_AspectRatio.Items.AddRange(New Object() {"4:3 (Fullscreen)", "16:9 (Widescreen)"})
        Me.video_AspectRatio.Location = New System.Drawing.Point(232, 225)
        Me.video_AspectRatio.Margin = New System.Windows.Forms.Padding(4)
        Me.video_AspectRatio.Name = "video_AspectRatio"
        Me.video_AspectRatio.Size = New System.Drawing.Size(225, 26)
        Me.video_AspectRatio.TabIndex = 15
        '
        'video_Framerate
        '
        Me.video_Framerate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.video_Framerate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.video_Framerate.FormattingEnabled = True
        Me.video_Framerate.ItemHeight = 20
        Me.video_Framerate.Items.AddRange(New Object() {"8", "10", "12", "15", "20", "23.976", "24", "25", "29.97", "30", "50", "59.94", "60"})
        Me.video_Framerate.Location = New System.Drawing.Point(232, 175)
        Me.video_Framerate.Margin = New System.Windows.Forms.Padding(4)
        Me.video_Framerate.Name = "video_Framerate"
        Me.video_Framerate.Size = New System.Drawing.Size(225, 26)
        Me.video_Framerate.TabIndex = 14
        '
        'video_Size
        '
        Me.video_Size.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.video_Size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.video_Size.FormattingEnabled = True
        Me.video_Size.ItemHeight = 20
        Me.video_Size.Items.AddRange(New Object() {"160x112", "176x144", "220x176", "320x240", "352x240", "352x288", "368x208", "480x272", "480x320", "480x480", "480x576", "512x384", "640x480", "720x480", "720x576", "800x600", "1080x720", "1280x720", "1440x1080", "1920x1080", "2560x1440", "3840x2160"})
        Me.video_Size.Location = New System.Drawing.Point(232, 125)
        Me.video_Size.Margin = New System.Windows.Forms.Padding(4)
        Me.video_Size.Name = "video_Size"
        Me.video_Size.Size = New System.Drawing.Size(225, 26)
        Me.video_Size.TabIndex = 13
        '
        'video_Bitrate
        '
        Me.video_Bitrate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.video_Bitrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.video_Bitrate.FormattingEnabled = True
        Me.video_Bitrate.ItemHeight = 20
        Me.video_Bitrate.Items.AddRange(New Object() {"64", "96", "112", "128", "160", "192", "256", "384", "512", "768", "1024", "1500", "2000", "2500", "3000", "4000", "5000", "6000", "8000", "10000", "12000", "15000"})
        Me.video_Bitrate.Location = New System.Drawing.Point(232, 75)
        Me.video_Bitrate.Margin = New System.Windows.Forms.Padding(4)
        Me.video_Bitrate.Name = "video_Bitrate"
        Me.video_Bitrate.Size = New System.Drawing.Size(225, 26)
        Me.video_Bitrate.TabIndex = 12
        '
        'video_Codec
        '
        Me.video_Codec.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.video_Codec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.video_Codec.FormattingEnabled = True
        Me.video_Codec.ItemHeight = 20
        Me.video_Codec.Location = New System.Drawing.Point(232, 25)
        Me.video_Codec.Margin = New System.Windows.Forms.Padding(4)
        Me.video_Codec.Name = "video_Codec"
        Me.video_Codec.Size = New System.Drawing.Size(225, 26)
        Me.video_Codec.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(5, 234)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(226, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "- Aspect Ratio"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(5, 184)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(226, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "- Framerate"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(5, 134)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(226, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "- Size"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(5, 84)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(226, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "- Bitrate"
        '
        'lblvCodec
        '
        Me.lblvCodec.Location = New System.Drawing.Point(5, 36)
        Me.lblvCodec.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblvCodec.Name = "lblvCodec"
        Me.lblvCodec.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblvCodec.Size = New System.Drawing.Size(226, 15)
        Me.lblvCodec.TabIndex = 5
        Me.lblvCodec.Text = "- Codec"
        '
        'Profile
        '
        Me.Profile.AllowDrop = True
        Me.Profile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Profile.BackColor = System.Drawing.Color.White
        Me.Profile.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Profile.DropDownHeight = 1000
        Me.Profile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Profile.Font = New System.Drawing.Font("Verdana", 6.75!)
        Me.Profile.FormattingEnabled = True
        Me.Profile.IntegralHeight = False
        Me.Profile.ItemHeight = 42
        ImageComboBoxItem49.Image = Global.Video_Downloader.My.Resources.Resources.avi
        ImageComboBoxItem49.Tag = Nothing
        ImageComboBoxItem49.Text = "AVI - Audio Video Interleave (*.avi)"
        ImageComboBoxItem50.Image = Global.Video_Downloader.My.Resources.Resources.flv
        ImageComboBoxItem50.Tag = Nothing
        ImageComboBoxItem50.Text = "FLV - Flash Video (*.flv)"
        ImageComboBoxItem51.Image = Global.Video_Downloader.My.Resources.Resources.mov
        ImageComboBoxItem51.Tag = Nothing
        ImageComboBoxItem51.Text = "MOV - QuickTime Movie (*.mov)"
        ImageComboBoxItem52.Image = Global.Video_Downloader.My.Resources.Resources.mp4
        ImageComboBoxItem52.Tag = Nothing
        ImageComboBoxItem52.Text = "MP4 - MPEG-4 Movie (*.mp4)"
        ImageComboBoxItem53.Image = Global.Video_Downloader.My.Resources.Resources.mpg
        ImageComboBoxItem53.Tag = Nothing
        ImageComboBoxItem53.Text = "MPG - MPG Movie (*.mpg)"
        ImageComboBoxItem54.Image = Global.Video_Downloader.My.Resources.Resources.m2ts
        ImageComboBoxItem54.Tag = Nothing
        ImageComboBoxItem54.Text = "M2TS - MPEG-2 Transport Stream (*.m2ts)"
        ImageComboBoxItem55.Image = Global.Video_Downloader.My.Resources.Resources.webm
        ImageComboBoxItem55.Tag = Nothing
        ImageComboBoxItem55.Text = "WebM - Web Movie (*.webm)"
        ImageComboBoxItem56.Image = Global.Video_Downloader.My.Resources.Resources.wmv
        ImageComboBoxItem56.Tag = Nothing
        ImageComboBoxItem56.Text = "WMV - Windows Media Video (*.wmv)"
        ImageComboBoxItem57.Image = Global.Video_Downloader.My.Resources.Resources.aac
        ImageComboBoxItem57.Tag = Nothing
        ImageComboBoxItem57.Text = "AAC - Advanced Audio Coding (*.aac)"
        ImageComboBoxItem58.Image = Global.Video_Downloader.My.Resources.Resources.ac3
        ImageComboBoxItem58.Tag = Nothing
        ImageComboBoxItem58.Text = "AC3 - Audio Coding 3 (*.ac3)"
        ImageComboBoxItem59.Image = Global.Video_Downloader.My.Resources.Resources.flac
        ImageComboBoxItem59.Tag = Nothing
        ImageComboBoxItem59.Text = "FLAC - Free Lossless Audio Codec (*.flac)"
        ImageComboBoxItem60.Image = Global.Video_Downloader.My.Resources.Resources.mp3
        ImageComboBoxItem60.Tag = Nothing
        ImageComboBoxItem60.Text = "MP3 - MPEG Layer-3 Audio (*.mp3)"
        ImageComboBoxItem61.Image = Global.Video_Downloader.My.Resources.Resources.m4a
        ImageComboBoxItem61.Tag = Nothing
        ImageComboBoxItem61.Text = "M4A - MPEG-4 Audio (*.m4a)"
        ImageComboBoxItem62.Image = Global.Video_Downloader.My.Resources.Resources.Ogg
        ImageComboBoxItem62.Tag = Nothing
        ImageComboBoxItem62.Text = "OGG - Vorbis Audio File (*.ogg)"
        ImageComboBoxItem63.Image = Global.Video_Downloader.My.Resources.Resources.wav
        ImageComboBoxItem63.Tag = Nothing
        ImageComboBoxItem63.Text = "WAV - Waveform Audio File (*.wav)"
        ImageComboBoxItem64.Image = Global.Video_Downloader.My.Resources.Resources.wma
        ImageComboBoxItem64.Tag = Nothing
        ImageComboBoxItem64.Text = "WMA - Windows Media Audio (*.wma)"
        Me.Profile.Items.Add(ImageComboBoxItem49)
        Me.Profile.Items.Add(ImageComboBoxItem50)
        Me.Profile.Items.Add(ImageComboBoxItem51)
        Me.Profile.Items.Add(ImageComboBoxItem52)
        Me.Profile.Items.Add(ImageComboBoxItem53)
        Me.Profile.Items.Add(ImageComboBoxItem54)
        Me.Profile.Items.Add(ImageComboBoxItem55)
        Me.Profile.Items.Add(ImageComboBoxItem56)
        Me.Profile.Items.Add(ImageComboBoxItem57)
        Me.Profile.Items.Add(ImageComboBoxItem58)
        Me.Profile.Items.Add(ImageComboBoxItem59)
        Me.Profile.Items.Add(ImageComboBoxItem60)
        Me.Profile.Items.Add(ImageComboBoxItem61)
        Me.Profile.Items.Add(ImageComboBoxItem62)
        Me.Profile.Items.Add(ImageComboBoxItem63)
        Me.Profile.Items.Add(ImageComboBoxItem64)
        Me.Profile.Location = New System.Drawing.Point(12, 54)
        Me.Profile.Margin = New System.Windows.Forms.Padding(2)
        Me.Profile.Name = "Profile"
        Me.Profile.SelectedItem = Nothing
        Me.Profile.Size = New System.Drawing.Size(486, 48)
        Me.Profile.TabIndex = 19
        '
        'ConverterMenu
        '
        Me.ConverterMenu.BackColor = System.Drawing.Color.Silver
        Me.ConverterMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ConverterMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PresetToolStripMenuItem, Me.OpenAndConvertToolStripMenuItem, Me.CancelToolStripMenuItem, Me.OutputToolStripMenuItem})
        Me.ConverterMenu.Location = New System.Drawing.Point(2, 2)
        Me.ConverterMenu.Name = "ConverterMenu"
        Me.ConverterMenu.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        Me.ConverterMenu.Size = New System.Drawing.Size(1011, 26)
        Me.ConverterMenu.TabIndex = 0
        '
        'PresetToolStripMenuItem
        '
        Me.PresetToolStripMenuItem.Image = Global.Video_Downloader.My.Resources.Resources.Presets
        Me.PresetToolStripMenuItem.Name = "PresetToolStripMenuItem"
        Me.PresetToolStripMenuItem.Size = New System.Drawing.Size(83, 24)
        Me.PresetToolStripMenuItem.Text = "Preset"
        '
        'OpenAndConvertToolStripMenuItem
        '
        Me.OpenAndConvertToolStripMenuItem.Image = CType(resources.GetObject("OpenAndConvertToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenAndConvertToolStripMenuItem.Name = "OpenAndConvertToolStripMenuItem"
        Me.OpenAndConvertToolStripMenuItem.Size = New System.Drawing.Size(163, 24)
        Me.OpenAndConvertToolStripMenuItem.Text = "Open and Convert"
        '
        'CancelToolStripMenuItem
        '
        Me.CancelToolStripMenuItem.Image = Global.Video_Downloader.My.Resources.Resources.cancel_16
        Me.CancelToolStripMenuItem.Name = "CancelToolStripMenuItem"
        Me.CancelToolStripMenuItem.Size = New System.Drawing.Size(87, 24)
        Me.CancelToolStripMenuItem.Text = "Cancel"
        '
        'OutputToolStripMenuItem
        '
        Me.OutputToolStripMenuItem.Image = CType(resources.GetObject("OutputToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OutputToolStripMenuItem.Name = "OutputToolStripMenuItem"
        Me.OutputToolStripMenuItem.Size = New System.Drawing.Size(89, 24)
        Me.OutputToolStripMenuItem.Text = "Output"
        '
        'About
        '
        Me.About.BackColor = System.Drawing.Color.Silver
        Me.About.Controls.Add(Me.auto_check)
        Me.About.Controls.Add(Me.btnCheckforupdates)
        Me.About.Controls.Add(Me.lblDonate)
        Me.About.Controls.Add(Me.txtAbout)
        Me.About.ImageKey = "About"
        Me.About.Location = New System.Drawing.Point(4, 36)
        Me.About.Margin = New System.Windows.Forms.Padding(2)
        Me.About.Name = "About"
        Me.About.Size = New System.Drawing.Size(1015, 496)
        Me.About.TabIndex = 2
        Me.About.Text = "About"
        '
        'auto_check
        '
        Me.auto_check.BackColor = System.Drawing.Color.Silver
        Me.auto_check.Checked = False
        Me.auto_check.Location = New System.Drawing.Point(755, 421)
        Me.auto_check.Margin = New System.Windows.Forms.Padding(4)
        Me.auto_check.Name = "auto_check"
        Me.auto_check.Size = New System.Drawing.Size(239, 21)
        Me.auto_check.TabIndex = 16
        Me.auto_check.Text = "Check for updates at startup"
        '
        'btnCheckforupdates
        '
        Me.btnCheckforupdates.Location = New System.Drawing.Point(755, 445)
        Me.btnCheckforupdates.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCheckforupdates.Name = "btnCheckforupdates"
        Me.btnCheckforupdates.Size = New System.Drawing.Size(239, 29)
        Me.btnCheckforupdates.TabIndex = 15
        Me.btnCheckforupdates.Text = "Check for updates"
        '
        'lblDonate
        '
        Me.lblDonate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDonate.AutoSize = True
        Me.lblDonate.Location = New System.Drawing.Point(494, 450)
        Me.lblDonate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDonate.Name = "lblDonate"
        Me.lblDonate.Size = New System.Drawing.Size(251, 14)
        Me.lblDonate.TabIndex = 2
        Me.lblDonate.TabStop = True
        Me.lblDonate.Text = "Donate to support future development"
        '
        'txtAbout
        '
        Me.txtAbout.BackColor = System.Drawing.Color.White
        Me.txtAbout.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtAbout.Location = New System.Drawing.Point(0, 0)
        Me.txtAbout.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAbout.Name = "txtAbout"
        Me.txtAbout.ReadOnly = True
        Me.txtAbout.Size = New System.Drawing.Size(1015, 414)
        Me.txtAbout.TabIndex = 0
        Me.txtAbout.Text = ""
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1061, 611)
        Me.Controls.Add(Me.CButton2)
        Me.Controls.Add(Me.CButton1)
        Me.Controls.Add(Me.CTabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.DownloaderMenu
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(1041, 562)
        Me.Name = "frmMain"
        Me.Padding = New System.Windows.Forms.Padding(19, 56, 19, 19)
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "Video Downloader"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.CTabControl1.ResumeLayout(False)
        Me.Downloader.ResumeLayout(False)
        Me.Downloader.PerformLayout()
        Me.DownloaderMenu.ResumeLayout(False)
        Me.DownloaderMenu.PerformLayout()
        Me.Converter.ResumeLayout(False)
        Me.Converter.PerformLayout()
        Me.gStatus.ResumeLayout(False)
        Me.gAudio.ResumeLayout(False)
        Me.gAudio.PerformLayout()
        CType(Me.volBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gVideo.ResumeLayout(False)
        Me.ConverterMenu.ResumeLayout(False)
        Me.ConverterMenu.PerformLayout()
        Me.About.ResumeLayout(False)
        Me.About.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CTabControl1 As Video_Downloader.cTabControl
    Friend WithEvents Downloader As System.Windows.Forms.TabPage
    Friend WithEvents Converter As System.Windows.Forms.TabPage
    Friend WithEvents About As System.Windows.Forms.TabPage
    Friend WithEvents lblDonate As System.Windows.Forms.LinkLabel
    Friend WithEvents txtAbout As System.Windows.Forms.RichTextBox
    Friend WithEvents DownloadList As Video_Downloader.cListView
    Friend WithEvents DownloaderMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents NewDownloadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DownloadsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ConverterMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents PresetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenAndConvertToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OutputToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Profile As Video_Downloader.cImageComboBox
    Friend WithEvents lblAdditionalParameter As System.Windows.Forms.Label
    Friend WithEvents gAudio As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents gVideo As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblvCodec As System.Windows.Forms.Label
    Friend WithEvents gStatus As System.Windows.Forms.GroupBox
    Friend WithEvents ConverterProgress As Video_Downloader.cProgressBar
    Friend WithEvents Status As Video_Downloader.cLabel
    Friend WithEvents Worker As System.ComponentModel.BackgroundWorker
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NewDownloadToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ClearToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FileInfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DownloadsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents CButton1 As cButton
    Friend WithEvents CButton2 As cButton
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Playlist As cCheckBox
    Friend WithEvents btnCheckforupdates As cButton
    Friend WithEvents auto_check As cCheckBox
    Friend WithEvents audio_Codec As XXCombox
    Friend WithEvents audio_Bitrate As XXCombox
    Friend WithEvents Additional_Parameter As cTextbox
    Friend WithEvents Delete_Original As cCheckBox
    Friend WithEvents audio_Samplerate As XXCombox
    Friend WithEvents audio_Chanel As XXCombox
    Friend WithEvents video_AspectRatio As XXCombox
    Friend WithEvents video_Framerate As XXCombox
    Friend WithEvents video_Size As XXCombox
    Friend WithEvents video_Bitrate As XXCombox
    Friend WithEvents video_Codec As XXCombox
    Friend WithEvents volBar As TrackBar
    Friend WithEvents lblVol As Label
End Class
