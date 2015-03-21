Public Class WriteFile

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Hide()
        Blend.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Path.Text = OpenFileDialog1.FileName.ToString
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim EncryptMessage As String

        If (Not (String.IsNullOrEmpty(Path.Text) And String.IsNullOrEmpty(Message.Text))) Then
            EncryptMessage = Database.Encrypt(Message.Text, Database.KeyCode(Agents.Text))
            My.Computer.FileSystem.WriteAllText(Path.Text,EncryptMessage, False)
            MsgBox("File Saved")
        Else
            MsgBox("Please fill in all fields")
        End If
    End Sub

End Class