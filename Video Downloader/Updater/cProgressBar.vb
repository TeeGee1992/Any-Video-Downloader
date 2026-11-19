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

    Private _Color1 As Color = Color.Green
    Public Property Color1 As Color
        Get
            Return _Color1
        End Get
        Set(ByVal value As Color)
            _Color1 = value
            Invalidate()
        End Set
    End Property

    Public Overrides Property Text As String
        Get
            Return MyBase.Text
        End Get
        Set(ByVal value As String)
            MyBase.Text = value
            Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
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