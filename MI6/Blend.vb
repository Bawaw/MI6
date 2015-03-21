Public Class Blend

    Private Sub Blend_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseClick
        WriteFile.BringToFront()
        OpenFile.BringToFront()
        ShowMessage.BringToFront()
    End Sub
End Class