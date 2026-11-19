<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMediaInfo
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
        Me.Info = New System.Windows.Forms.RichTextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.lblDragAndDrop = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Info
        '
        Me.Info.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Info.BackColor = System.Drawing.Color.Black
        Me.Info.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Info.ForeColor = System.Drawing.Color.White
        Me.Info.Location = New System.Drawing.Point(-2, -1)
        Me.Info.Margin = New System.Windows.Forms.Padding(2)
        Me.Info.Name = "Info"
        Me.Info.Size = New System.Drawing.Size(821, 371)
        Me.Info.TabIndex = 0
        Me.Info.Text = ""
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Location = New System.Drawing.Point(728, 379)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(78, 24)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnOpen
        '
        Me.btnOpen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpen.Location = New System.Drawing.Point(647, 379)
        Me.btnOpen.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(78, 24)
        Me.btnOpen.TabIndex = 2
        Me.btnOpen.Text = "..."
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'lblDragAndDrop
        '
        Me.lblDragAndDrop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDragAndDrop.AutoSize = True
        Me.lblDragAndDrop.Location = New System.Drawing.Point(14, 380)
        Me.lblDragAndDrop.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDragAndDrop.Name = "lblDragAndDrop"
        Me.lblDragAndDrop.Size = New System.Drawing.Size(125, 13)
        Me.lblDragAndDrop.TabIndex = 3
        Me.lblDragAndDrop.Text = "Drag and drop media file."
        '
        'frmMediaInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 411)
        Me.Controls.Add(Me.lblDragAndDrop)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Info)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(833, 450)
        Me.Name = "frmMediaInfo"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "MediaInfo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Info As System.Windows.Forms.RichTextBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents lblDragAndDrop As System.Windows.Forms.Label
End Class
