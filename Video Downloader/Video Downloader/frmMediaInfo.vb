Public Class frmMediaInfo

    Sub GetInfo(ByVal Path As String)
        Info.Clear()
        Dim MI As New MediaInfo
        MI.Open(Path)
        MI.Option_("Complete", "")
        Info.Text = MI.Inform
        MI.Close()
    End Sub

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        Using openf As New OpenFileDialog
            With openf
                .FileName = ""
                .Filter = "All media file types |*.*"
                If .ShowDialog = 1 Then
                    GetInfo(.FileName)
                End If
            End With
        End Using
    End Sub

    Private Sub Info_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Info.DragDrop
        Dim data As Array = DirectCast(e.Data.GetData(DataFormats.FileDrop), Array)
        GetInfo(data.GetValue(0).ToString)
    End Sub

    Private Sub Info_LinkClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.LinkClickedEventArgs) Handles Info.LinkClicked
        Process.Start(e.LinkText)
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub

    Private Sub frmMediaInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Info.AllowDrop = True
    End Sub

End Class