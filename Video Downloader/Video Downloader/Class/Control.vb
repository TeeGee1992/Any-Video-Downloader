
Imports System.Drawing.Drawing2D

Public Class cListView

    Inherits ListView

    Sub New()
        DoubleBuffered = True
        OwnerDraw = True
    End Sub

    Private _Color1 As Color = Color.Silver
    Public Property Color1 As Color
        Get
            Return _Color1
        End Get
        Set(value As Color)
            _Color1 = value
            Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnDrawSubItem(e As System.Windows.Forms.DrawListViewSubItemEventArgs)
        If e.ColumnIndex = 2 Then
            e.Graphics.FillRectangle(Brushes.White, e.Bounds)
            Using lgb = New SolidBrush(Color1)
                e.Graphics.FillRectangle(lgb, e.Bounds.X + 1, e.Bounds.Y + 2, CInt((CDbl(e.SubItem.Text) / 100) * (e.Bounds.Width - 2)), e.Bounds.Height - 3)
            End Using
            Dim tSize = e.Graphics.MeasureString(e.SubItem.Text & " %", Font)
            Using TextBrush = New SolidBrush(ForeColor)
                e.Graphics.DrawString(e.SubItem.Text & " %", Font, TextBrush, e.Bounds.X + e.Bounds.Width / 2 - tSize.Width / 2, e.Bounds.Y + e.Bounds.Height / 2 - tSize.Height / 2 + 1)
            End Using
            ControlPaint.DrawBorder3D(e.Graphics, e.Bounds.X, e.Bounds.Y + 1, e.Bounds.Width - 1, e.Bounds.Height - 2, Border3DStyle.Flat)
        Else
            e.DrawDefault = True
        End If
        MyBase.OnDrawSubItem(e)
    End Sub

    Protected Overrides Sub OnDrawColumnHeader(e As System.Windows.Forms.DrawListViewColumnHeaderEventArgs)
        e.DrawDefault = True
        MyBase.OnDrawColumnHeader(e)
    End Sub

End Class

Public Class cTabControl

    Inherits TabControl

    Private _ImageList As ImageList

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        DoubleBuffered = True
        SizeMode = TabSizeMode.Fixed
        _ImageList = New ImageList
        _ImageList.ColorDepth = ColorDepth.Depth32Bit
        _ImageList.ImageSize = New Size(16, 16)
        _ImageList.Images.Add("Download", My.Resources.Download)
        _ImageList.Images.Add("Convert", My.Resources.Convert)
        _ImageList.Images.Add("Play", My.Resources.Play)
        _ImageList.Images.Add("About", My.Resources.About)
        Me.ImageList = _ImageList
    End Sub

    Protected Overrides Sub OnPaint(e As System.Windows.Forms.PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G As Graphics = Graphics.FromImage(B)

        G.Clear(Color.Silver)

        For index = 0 To TabCount - 1
            Dim TabRect = GetTabRect(index)

            If index = SelectedIndex Then

                G.FillRectangle(Brushes.Silver, TabRect)
            Else
                G.FillRectangle(Brushes.Black, TabRect)
            End If
            Dim tabImage As Image = Nothing
            If Me.TabPages(index).ImageIndex > -1 AndAlso Me.ImageList IsNot Nothing AndAlso Me.ImageList.Images.Count > Me.TabPages(index).ImageIndex Then
                tabImage = Me.ImageList.Images(Me.TabPages(index).ImageIndex)
            ElseIf (Not String.IsNullOrEmpty(Me.TabPages(index).ImageKey) AndAlso Not Me.TabPages(index).ImageKey.Equals("(none)", StringComparison.OrdinalIgnoreCase)) AndAlso Me.ImageList IsNot Nothing AndAlso Me.ImageList.Images.ContainsKey(Me.TabPages(index).ImageKey) Then
                tabImage = Me.ImageList.Images(Me.TabPages(index).ImageKey)
            End If
            If tabImage IsNot Nothing Then
                If Me.RightToLeftLayout Then
                    tabImage.RotateFlip(RotateFlipType.RotateNoneFlipX)
                End If
                Dim rect As Rectangle = Me.GetTabRect(index)
                rect.X = rect.X + 5
                rect.Y = rect.Y + rect.Height \ 2 - tabImage.Height \ 2
                rect.Width = tabImage.Width
                rect.Height = tabImage.Height
                If Me.TabPages(index).Enabled Then
                    G.DrawImage(tabImage, rect)
                Else
                    ControlPaint.DrawImageDisabled(G, tabImage, rect.X, rect.Y, Color.Transparent)
                End If
            End If
            G.DrawString(TabPages(index).Text, Font, Brushes.White, TabRect, New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
            G.DrawRectangle(Pens.WhiteSmoke, TabRect)
        Next
        e.Graphics.DrawImage(B, 0, 0)
        G.Dispose() : B.Dispose()
        MyBase.OnPaint(e)
    End Sub
End Class

Public Class cImageComboBox

    Inherits ComboBox

    Public Sub New()

        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or
        ControlStyles.UserPaint Or ControlStyles.ResizeRedraw Or
                 ControlStyles.SupportsTransparentBackColor, True)
        Font = New Font("Arial", 9)
        Me.DrawMode = Windows.Forms.DrawMode.OwnerDrawFixed
        Me.DropDownStyle = ComboBoxStyle.DropDownList
        _Items = New ImageComboBoxItemCollection(Me)
    End Sub

    Private _Items As ImageComboBoxItemCollection
    <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>
    Public Overloads ReadOnly Property Items() As ImageComboBoxItemCollection
        Get
            Return _Items
        End Get
    End Property

    Private ReadOnly Property baseItems() As ObjectCollection
        Get
            Return MyBase.Items
        End Get
    End Property

    Public Overloads Property SelectedItem() As ImageComboBoxItem
        Get
            Return DirectCast(MyBase.SelectedItem, ImageComboBoxItem)
        End Get
        Set(ByVal value As ImageComboBoxItem)
            MyBase.SelectedItem = value
        End Set
    End Property

    Private _ShowImages As Boolean = True
    <System.ComponentModel.Description("Indicates whether the specified image for each ImageComboBoxItem of the ImageComboBox is displayed beside the item text.")>
    <System.ComponentModel.DefaultValue(True)>
    Public Property ShowImages() As Boolean
        Get
            Return _ShowImages
        End Get
        Set(ByVal value As Boolean)
            If _ShowImages <> value Then
                _ShowImages = value
                Me.Invalidate()
            End If
        End Set
    End Property

    Protected Overrides Sub OnDrawItem(ByVal e As System.Windows.Forms.DrawItemEventArgs)
        Dim bounds As Rectangle = e.Bounds
        If e.Index >= 0 AndAlso e.Index < Me.Items.Count Then
            Dim item As ImageComboBoxItem = Me.Items(e.Index)
            If item IsNot Nothing Then
                e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
                e.Graphics.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
                If Me.ShowImages AndAlso item.Image IsNot Nothing Then
                    Dim tSize As SizeF = e.Graphics.MeasureString(item.Text, e.Font)
                    e.Graphics.FillRectangle(Brushes.Black, e.Bounds)
                    e.Graphics.DrawImage(item.Image, New Rectangle(e.Bounds.Left, e.Bounds.Top + 5, Me.ItemHeight, Me.ItemHeight), 0, 0, Me.ItemHeight, Me.ItemHeight, GraphicsUnit.Pixel)
                    e.Graphics.DrawString(item.Text, e.Font, Brushes.White, bounds.Left + Me.ItemHeight, bounds.Top + (bounds.Height - tSize.Height) / 2)
                End If
            End If
        End If
        MyBase.OnDrawItem(e)
    End Sub


    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim G As Graphics = e.Graphics
        G.SmoothingMode = SmoothingMode.HighQuality
        G.Clear(Parent.BackColor)
        Dim slope As Integer = 4
        Dim mainRect As New Rectangle(0, 0, Width - 1, Height - 1)


        G.FillRectangle(Brushes.Black, mainRect)
        G.DrawRectangle(Pens.WhiteSmoke, mainRect)


        Dim triangle As Point() = New Point() {New Point(Width - 14, 30), New Point(Width - 17, 20), New Point(Width - 11, 20)}

        G.FillPolygon(Brushes.WhiteSmoke, triangle)

        G.DrawLine(Pens.WhiteSmoke, New Point(Width - 25, 1), New Point(Width - 25, Height - 2))
        Try

            If Me.Items.Count > 0 Then
                Dim item As ImageComboBoxItem = Me.Items(SelectedIndex)
                Dim textY As Integer = ((Me.Height - 1) / 2) - (G.MeasureString(item.Text, Font).Height / 2)
                G.DrawString(item.Text, Font, Brushes.White, New Point(40, textY))
                G.DrawImage(item.Image, New Rectangle(2, 8, Me.ItemHeight, Me.ItemHeight), 0, 0, Me.ItemHeight, Me.ItemHeight, GraphicsUnit.Pixel)
            End If

        Catch ex As Exception

        End Try

    End Sub

    Public Class ImageComboBoxItemCollection
        Inherits System.Collections.ObjectModel.Collection(Of ImageComboBoxItem)
        Private _comboBox As cImageComboBox

        Public Sub New(ByVal comboBox As cImageComboBox)
            _comboBox = comboBox
        End Sub

        Public Overloads Function Add() As ImageComboBoxItem
            Return Me.Add("New Item", Nothing)
        End Function

        Public Overloads Function Add(ByVal text As String) As ImageComboBoxItem
            Return Me.Add(text, Nothing)
        End Function

        Public Overloads Function Add(ByVal text As String, ByVal image As Image) As ImageComboBoxItem
            Dim item As New ImageComboBoxItem(text, image)
            Me.InsertItem(Me.Items.Count, item)
            Return item
        End Function

        Protected Overrides Sub ClearItems()
            MyBase.ClearItems()
            _comboBox.baseItems.Clear()
        End Sub

        Protected Overrides Sub InsertItem(ByVal index As Integer, ByVal item As ImageComboBoxItem)
            MyBase.InsertItem(index, item)
            _comboBox.baseItems.Insert(index, item)
        End Sub

        Protected Overrides Sub RemoveItem(ByVal index As Integer)
            MyBase.RemoveItem(index)
            _comboBox.baseItems.RemoveAt(index)
        End Sub

        Protected Overrides Sub SetItem(ByVal index As Integer, ByVal item As ImageComboBoxItem)
            MyBase.SetItem(index, item)
            _comboBox.baseItems(index) = item
        End Sub

        Public Sub AddRange(ByVal items As IEnumerable(Of ImageComboBoxItem))
            For Each item As ImageComboBoxItem In items
                Me.InsertItem(Me.Items.Count, item)
            Next
        End Sub

    End Class

    Public Class ImageComboBoxItem

        Private _text As String
        Private _image As Image
        Private _tag As Object

        Public Sub New()
            Me.New("New Item", Nothing)
        End Sub

        Public Sub New(ByVal text As String)
            Me.New(text, Nothing)
        End Sub

        Public Sub New(ByVal text As String, ByVal image As Image)
            Me.Text = text
            Me.Image = image
        End Sub

        Property Text() As String
            Get
                Return _text
            End Get
            Set(ByVal value As String)
                _text = value
            End Set
        End Property

        Property Image() As Image
            Get
                Return _image
            End Get
            Set(ByVal value As Image)
                _image = value
            End Set
        End Property

        Public Property Tag() As Object
            Get
                Return _tag
            End Get
            Set(ByVal value As Object)
                _tag = value
            End Set
        End Property

        Public Overrides Function ToString() As String
            Return _text
        End Function

    End Class
End Class

Public Class cLabel

    Inherits Control

    Private TextBase As Label

    Sub New()
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        TextBase = New Label
        TextBase.Font = Font
        TextBase.Text = Text
        TextBase.BorderStyle = BorderStyle.None
        TextBase.Width = Width - 2
        TextBase.Height = Height - 2
        TextBase.TextAlign = ContentAlignment.MiddleCenter
        TextBase.AutoEllipsis = True
        TextBase.AutoSize = False
        TextBase.Location = New Point(1, 1)
        Controls.Add(TextBase)
    End Sub

    Overrides Property Text As String
        Get
            Return MyBase.Text
        End Get
        Set(ByVal value As String)
            MyBase.Text = value
            If TextBase IsNot Nothing Then
                TextBase.Text = value
            End If
        End Set
    End Property

    Overrides Property Font As Font
        Get
            Return MyBase.Font
        End Get
        Set(ByVal value As Font)
            MyBase.Font = value
            If TextBase IsNot Nothing Then
                TextBase.Font = value
                TextBase.Location = New Point(1, 1)
                TextBase.Width = Width - 2
                TextBase.Height = Height - 2
            End If
        End Set
    End Property

    Protected Overrides Sub OnResize(ByVal e As EventArgs)
        TextBase.Width = Width - 2
        TextBase.Height = Height - 2
        MyBase.OnResize(e)
    End Sub

    Protected Overrides Sub OnPaint(e As System.Windows.Forms.PaintEventArgs)
        Using B = New Bitmap(Width, Height)
            Using G = Graphics.FromImage(B)
                G.Clear(BackColor)
                ControlPaint.DrawBorder3D(G, ClientRectangle, Border3DStyle.Flat)
                e.Graphics.DrawImage(B, 0, 0)
            End Using
        End Using
        MyBase.OnPaint(e)
    End Sub

End Class

Public Class cProgressBar

    Inherits Control

    Sub New()
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
    End Sub

    Private _Maximum As Integer = 100
    Property Maximum() As Integer
        Get
            Return _Maximum
        End Get
        Set(ByVal v As Integer)
            If v < 1 Then v = 1
            If v < _Value Then _Value = v
            _Maximum = v
            Invalidate()
        End Set
    End Property

    Private _Value As Integer
    Property Value() As Integer
        Get
            Return _Value
        End Get
        Set(ByVal v As Integer)
            If v > _Maximum Then v = _Maximum
            _Value = v
            Invalidate()
        End Set
    End Property

    Private _Color1 As Color = Color.Silver
    Public Property Color1 As Color
        Get
            Return _Color1
        End Get
        Set(value As Color)
            _Color1 = value
            Invalidate()
        End Set
    End Property

    Public Overrides Property Text As String
        Get
            Return MyBase.Text
        End Get
        Set(value As String)
            MyBase.Text = value
            Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnPaint(e As System.Windows.Forms.PaintEventArgs)
        Using B = New Bitmap(Width, Height)
            Using G = Graphics.FromImage(B)
                G.Clear(BackColor)
                Using sb = New SolidBrush(Color1)
                    G.FillRectangle(sb, 0, 0, CInt(_Value / _Maximum * Width), Height)
                End Using
                Using TextBrush = New SolidBrush(ForeColor)
                    G.DrawString(Text, Font, TextBrush, Width \ 2 - G.MeasureString(Text, Font).Width \ 2, Height \ 2 - G.MeasureString(Text, Font).Height \ 2)
                End Using
                ControlPaint.DrawBorder3D(G, ClientRectangle, Border3DStyle.Flat)
                e.Graphics.DrawImage(B, 0, 0)
                G.Dispose() : B.Dispose()
            End Using
        End Using
        MyBase.OnPaint(e)
    End Sub

End Class

Public Class cButton

    Inherits Control
    Sub New()
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
    End Sub

    Protected Enum State As Byte
        MouseNone = 0
        MouseOver = 1
        MouseDown = 2
    End Enum

    Protected MouseState As State
    Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
        ChangeMouseState(State.MouseNone)
        MyBase.OnMouseLeave(e)
    End Sub
    Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
        ChangeMouseState(State.MouseOver)
        MyBase.OnMouseEnter(e)
    End Sub
    Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
        ChangeMouseState(State.MouseOver)
        MyBase.OnMouseUp(e)
    End Sub
    Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then ChangeMouseState(State.MouseDown)
        MyBase.OnMouseDown(e)
    End Sub

    Private Sub ChangeMouseState(ByVal e As State)
        MouseState = e
        Invalidate()
    End Sub
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Using B = New Bitmap(Width, Height)
            Using G = Graphics.FromImage(B)
                G.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
                G.Clear(BackColor)


                If MouseState = State.MouseNone OrElse MouseState = State.MouseDown Then

                    G.FillRectangle(Brushes.Black, ClientRectangle)

                ElseIf MouseState = State.MouseOver Then

                    G.FillRectangle(Brushes.Silver, ClientRectangle)
                Else

                    G.FillRectangle(Brushes.Black, ClientRectangle)
                End If

                Dim strsize = G.MeasureString(Text, Font)
                G.DrawString(Text, Font, New SolidBrush(Color.White), Width \ 2 - strsize.Width \ 2, Height \ 2 - strsize.Height \ 2)
                G.DrawRectangle(Pens.WhiteSmoke, 0, 0, Width - 1, Height - 1)
                e.Graphics.DrawImage(B, 0, 0)
                G.Dispose() : B.Dispose()
            End Using
        End Using
    End Sub

End Class

Public Class cCheckBox

    Inherits Control
    Sub New()

    End Sub

    Private _checked As Boolean
    Public Property Checked As Boolean
        Get
            Return _checked
        End Get
        Set(value As Boolean)
            _checked = value
            Invalidate()
        End Set
    End Property


    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        Using B = New Bitmap(Width, Height)
            Using G = Graphics.FromImage(B)
                G.SmoothingMode = SmoothingMode.HighQuality
                G.Clear(BackColor)
                If Checked Then
                    G.FillRectangle(New Drawing2D.LinearGradientBrush(New Rectangle(0, 0, 12, 12), Color.Silver, Color.Black, 60), 0, 0, 12, 12)
                End If
                Dim strsize = G.MeasureString(Text, Font)

                G.DrawString(Text, Font, New SolidBrush(Color.Black), 20, 0)

                Dim p = New Pen(New SolidBrush(Color.WhiteSmoke), 1)
                G.DrawRectangle(p, 0, 0, 12, 12)
                p.Dispose()
                e.Graphics.DrawImage(B, 0, 0)
                G.Dispose() : B.Dispose()
            End Using
        End Using
    End Sub

    Private Sub cCheckBox_Click(sender As Object, e As EventArgs) Handles Me.Click
        Checked = Not Checked
    End Sub

End Class

Public Class XXCombox

    Inherits ComboBox
    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or
    ControlStyles.UserPaint Or ControlStyles.ResizeRedraw Or
             ControlStyles.SupportsTransparentBackColor, True)
        Me.DrawMode = Windows.Forms.DrawMode.OwnerDrawFixed
        Me.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Protected Overrides Sub OnDrawItem(ByVal e As System.Windows.Forms.DrawItemEventArgs)
        Dim bounds As Rectangle = e.Bounds
        If e.Index >= 0 AndAlso e.Index < Me.Items.Count Then
            If Me.Items(e.Index) IsNot Nothing Then
                e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
                e.Graphics.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
                Dim tSize As SizeF = e.Graphics.MeasureString(Text, e.Font)
                e.Graphics.FillRectangle(Brushes.Black, e.Bounds)
                e.Graphics.DrawString(Items(e.Index).ToString, e.Font, Brushes.White, 2, bounds.Top + (bounds.Height - tSize.Height) / 2)
            End If
        End If
        MyBase.OnDrawItem(e)
    End Sub


    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Using B = New Bitmap(Width, Height)
            Using G = Graphics.FromImage(B)
                G.SmoothingMode = SmoothingMode.HighQuality
                G.Clear(BackColor)
                G.SmoothingMode = SmoothingMode.HighQuality
                G.Clear(Parent.BackColor)
                Dim slope As Integer = 4
                Dim mainRect As New Rectangle(0, 0, Width - 1, Height - 1)

                G.FillRectangle(Brushes.Black, mainRect)
                G.DrawRectangle(Pens.WhiteSmoke, mainRect)
                Dim triangle As Point() = New Point() {New Point(Width - 14, 16), New Point(Width - 17, 10), New Point(Width - 11, 10)}
                G.FillPolygon(Brushes.WhiteSmoke, triangle)
                G.DrawLine(Pens.WhiteSmoke, New Point(Width - 25, 1), New Point(Width - 25, Height - 2))
                Try
                    If Me.Items.Count > 0 Then
                        Dim textY As Integer = ((Me.Height - 1) / 2) - (G.MeasureString(Text, Font).Height / 2)
                        G.DrawString(Text, Font, Brushes.White, New Point(2, textY))
                    End If
                Catch ex As Exception
                End Try
                e.Graphics.DrawImage(B, 0, 0)
                G.Dispose() : B.Dispose()
            End Using
        End Using
    End Sub

End Class

Public Class cTextbox
    Inherits Control
    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or
ControlStyles.UserPaint Or ControlStyles.ResizeRedraw Or
     ControlStyles.SupportsTransparentBackColor, True)
        Dim t = New TextBox
        t.BackColor = Color.Black
        t.ForeColor = Color.White
        t.BorderStyle = BorderStyle.None
        t.Location = New Point(1, 3)
        t.Width = 485

        Controls.Add(t)
    End Sub
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Using B = New Bitmap(Width, Height)
            Using G = Graphics.FromImage(B)
                G.SmoothingMode = SmoothingMode.HighQuality
                G.Clear(Color.Black)
                Dim mainRect As New Rectangle(0, 0, Width - 1, Height - 1)
                G.DrawRectangle(Pens.WhiteSmoke, mainRect)
                e.Graphics.DrawImage(B, 0, 0)
                G.Dispose() : B.Dispose()
            End Using
        End Using
    End Sub

End Class

Public Class myTrackBar
    Inherits Control
    Private Value As Integer
    Private Pointer As New Bitmap(20, 40)
    Private Rect As New Rectangle(10, 10, 20, 40)
    Private Moving As Boolean
    Private Offset As Integer

    Public Property _volume As Integer

        Get
            Return Value
        End Get
        Set(value As Integer)
            value = value
            Rect.X = Math.Min(Math.Max(CInt((value / 100) * 190), 10), 190)
            Invalidate()
        End Set
    End Property


    Public Sub New()
        Size = New Size(210, 50)


        DoubleBuffered = True
        Using g As Graphics = Graphics.FromImage(Pointer)
            g.Clear(Color.Transparent)
            g.FillRectangle(Brushes.Blue, New Rectangle(0, 0, 10, 15))
            g.FillPolygon(Brushes.Blue, New Point() {New Point(0, 15), New Point(5, 20), New Point(10, 15)})
        End Using
    End Sub
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        e.Graphics.FillRectangle(Brushes.Black, New Rectangle(0, 0, Width, Height))
        Dim X As Integer = 15

        For count As Integer = 1 To 11
            e.Graphics.DrawLine(Pens.White, New Point(X, 35), New Point(X, 40))
            X += 20
        Next

        Using P As New Pen(Brushes.WhiteSmoke, 1)
            P.DashStyle = Drawing2D.DashStyle.Dash
            e.Graphics.DrawRectangle(P, New Rectangle(1, 1, Width - 2, Height - 2))
        End Using
        e.Graphics.DrawImage(Pointer, Rect)
    End Sub
    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        If Rect.Contains(e.Location) Then
            Moving = True
            Offset = e.Location.X - Rect.X
        End If
    End Sub
    Protected Overrides Sub OnMouseup(ByVal e As System.Windows.Forms.MouseEventArgs)
        Moving = False
    End Sub
    Protected Overrides Sub OnMouseMove(ByVal e As System.Windows.Forms.MouseEventArgs)
        If Moving Then
            Rect.X = Math.Min(Math.Max(e.Location.X - Offset, 10), 190)
            Invalidate()
        End If
    End Sub
End Class