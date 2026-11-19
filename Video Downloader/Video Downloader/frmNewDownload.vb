Public Class frmNewDownload
    Private Sub frmNewDownload_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, txtURL.MouseHover
        If Clipboard.GetText().StartsWith("https://") OrElse Clipboard.GetText().StartsWith("http://") Then txtURL.Text = Clipboard.GetText()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If Clipboard.GetText().StartsWith("https://") OrElse Clipboard.GetText().StartsWith("http://") Then
            frmMain.Download(txtURL.Text)
            Me.Close()
        Else
            MsgBox("Invalid Url")
        End If
    End Sub

End Class