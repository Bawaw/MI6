Public Class Main

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        Login.Close()
    End Sub

    Private Sub NewFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewFileToolStripMenuItem.Click
        Blend.Show()
        WriteFile.Show()
    End Sub

    Private Sub OpenFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenFileToolStripMenuItem.Click
        Blend.Show()
        OpenFile.Show()
    End Sub

    Private Sub EmergencyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmergencyToolStripMenuItem.Click
        Me.Hide()
        Alert.Show()
    End Sub
End Class