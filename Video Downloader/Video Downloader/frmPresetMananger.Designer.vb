<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPresetManager
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
        Me.components = New System.ComponentModel.Container()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Category = New System.Windows.Forms.TreeView()
        Me.PresetImage = New System.Windows.Forms.ImageList(Me.components)
        Me.presetList = New System.Windows.Forms.ListBox()
        Me.presetName = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(-1, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(2)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Category)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.presetList)
        Me.SplitContainer1.Size = New System.Drawing.Size(818, 352)
        Me.SplitContainer1.SplitterDistance = 233
        Me.SplitContainer1.SplitterWidth = 2
        Me.SplitContainer1.TabIndex = 0
        '
        'Category
        '
        Me.Category.BackColor = System.Drawing.Color.White
        Me.Category.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Category.ImageIndex = 0
        Me.Category.ImageList = Me.PresetImage
        Me.Category.ItemHeight = 32
        Me.Category.Location = New System.Drawing.Point(0, 0)
        Me.Category.Margin = New System.Windows.Forms.Padding(2)
        Me.Category.Name = "Category"
        Me.Category.SelectedImageIndex = 0
        Me.Category.Size = New System.Drawing.Size(233, 352)
        Me.Category.TabIndex = 1
        '
        'PresetImage
        '
        Me.PresetImage.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.PresetImage.ImageSize = New System.Drawing.Size(32, 32)
        Me.PresetImage.TransparentColor = System.Drawing.Color.Transparent
        '
        'presetList
        '
        Me.presetList.BackColor = System.Drawing.Color.White
        Me.presetList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.presetList.FormattingEnabled = True
        Me.presetList.Location = New System.Drawing.Point(0, 0)
        Me.presetList.Margin = New System.Windows.Forms.Padding(2)
        Me.presetList.Name = "presetList"
        Me.presetList.Size = New System.Drawing.Size(583, 352)
        Me.presetList.TabIndex = 3
        '
        'presetName
        '
        Me.presetName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.presetName.Location = New System.Drawing.Point(6, 356)
        Me.presetName.Margin = New System.Windows.Forms.Padding(2)
        Me.presetName.Name = "presetName"
        Me.presetName.Size = New System.Drawing.Size(801, 20)
        Me.presetName.TabIndex = 1
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Location = New System.Drawing.Point(6, 380)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(607, 24)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add / Update"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemove.Location = New System.Drawing.Point(617, 380)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(94, 24)
        Me.btnRemove.TabIndex = 3
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Location = New System.Drawing.Point(713, 380)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(94, 24)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'frmPresetManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 411)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.presetName)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(833, 450)
        Me.Name = "frmPresetManager"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "Preset Manager"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents presetName As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents Category As System.Windows.Forms.TreeView
    Friend WithEvents presetList As System.Windows.Forms.ListBox
    Friend WithEvents PresetImage As System.Windows.Forms.ImageList
End Class
