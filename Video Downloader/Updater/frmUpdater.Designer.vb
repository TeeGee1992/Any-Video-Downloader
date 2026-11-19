<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdater
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpdater))
        Me.btnDownload = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Installer = New System.ComponentModel.BackgroundWorker()
        Me.Status = New Updater.cProgressBar()
        Me.SuspendLayout()
        '
        'btnDownload
        '
        Me.btnDownload.Location = New System.Drawing.Point(6, 27)
        Me.btnDownload.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(304, 22)
        Me.btnDownload.TabIndex = 1
        Me.btnDownload.Text = "Download and Install"
        Me.btnDownload.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(314, 27)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(97, 22)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Installer
        '
        Me.Installer.WorkerReportsProgress = True
        Me.Installer.WorkerSupportsCancellation = True
        '
        'Status
        '
        Me.Status.Color1 = System.Drawing.Color.Silver
        Me.Status.Location = New System.Drawing.Point(6, 6)
        Me.Status.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Status.Maximum = 100
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(404, 18)
        Me.Status.TabIndex = 0
        Me.Status.Value = 0
        '
        'frmUpdater
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(416, 56)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDownload)
        Me.Controls.Add(Me.Status)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUpdater"
        Me.Text = "Updater"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Status As Updater.cProgressBar
    Friend WithEvents btnDownload As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Installer As System.ComponentModel.BackgroundWorker

End Class
