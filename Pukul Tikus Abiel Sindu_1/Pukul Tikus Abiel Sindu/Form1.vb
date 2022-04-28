Public Class Form1
    Dim started As Boolean = False
    Shared randomX As New Random()
    Shared randomY As New Random()
    Dim skor As String = 0


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If started = False Then
            started = True
            Button1.Text = "Stop!"
            lblSkor.Text = "SKOR : 0"
            timerTikus.Enabled = True
            btnTikus.Visible = True
        Else
            started = False
            timerTikus.Enabled = False
            Button1.Text = "Start!"
            lblPosition.Text = "Random : (x,y)"
            skor = 0
            btnTikus.Visible = False
        End If
    End Sub

    Private Sub timerTikus_Tick(sender As Object, e As EventArgs) Handles timerTikus.Tick
        Dim titikX = randomX.Next(0, 335)
        Dim titikY = randomY.Next(0, 227)
        lblPosition.Text = "Random : (" + CStr(titikX) + "," + CStr(titikY) + ")"
        btnTikus.Location = New Point(titikX, titikY)
        btnTikus.Visible = True
    End Sub

    Private Sub btnTikus_Click(sender As Object, e As EventArgs) Handles btnTikus.Click
        skor += 100
        lblSkor.Text = "SKOR : " + CStr(skor)
    End Sub
End Class
