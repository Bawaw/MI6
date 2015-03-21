Public Class OpenFile

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
        If (Not (String.IsNullOrEmpty(Path.Text))) Then
            Dim ReadMessage As String = ""

            ReadMessage = My.Computer.FileSystem.ReadAllText(Path.Text)
            ShowMessage.message.Text = Database.Decrypt(ReadMessage, Database.KeyCode(Agents.Text))

            Blend.BringToFront()
            ShowMessage.Show()
        Else
            MsgBox("Please fill in all fields")
        End If
    End Sub

End Class