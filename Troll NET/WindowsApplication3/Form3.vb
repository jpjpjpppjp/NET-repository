Public Class Form3
    Dim RND As New Random
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        SetDesktopLocation(1000, 50)
    End Sub
    Public Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.BackColor = Color.Orange
        Me.Location = New Point(RND.Next(1, 1700), RND.Next(1, 1500))
        Timer2.Enabled = True
    End Sub

    Sub Audio()


    End Sub


    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.BackColor = Color.Red
        Timer3.Enabled = True


    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Me.BackColor = Color.AliceBlue
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
End Class