Public Class Alert

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1
        If (Label1.Visible) Then
            Label1.Visible = False
        Else
            Label1.Visible = True
        End If

        If (ProgressBar1.Value = 10) Then
            PictureBox1.Width = Me.Width
            PictureBox1.Height = Me.Height
            Label1.Visible = False
            ProgressBar1.Visible = False
            PictureBox1.Visible = True
            Timer1.Stop()
        End If

        If (ProgressBar1.Value > 6) Then
            Label1.Text = "Sending Coordinates"
        End If

    End Sub
End Class