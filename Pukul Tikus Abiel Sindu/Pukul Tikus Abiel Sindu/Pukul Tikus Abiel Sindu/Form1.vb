Public Class Form1
    Dim started As Boolean = False
    Shared randomX As New Random()
    Shared randomY As New Random()
    Dim skor As String = 0
    Dim gridX As Integer = 3 'Default Baris adalah 3
    Dim gridY As Integer = 3 'Default Kolom adalah 3
    Dim LenX As Integer = 469 \ gridX 'LenX ini berfungsi sebagai multiplier untuk menentukan posisi gridnya nanti (untuk sumbu X)
    Dim LenY As Integer = 306 \ gridY 'LenY ini berfungsi sebagai multiplier untuk menentukan posisi gridnya nanti (untuk sumbu Y)


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
        Dim titikX = randomX.Next(0, gridX)
        Dim titikY = randomY.Next(0, gridY)
        lblPosition.Text = "Random : (" + CStr(titikX) + "," + CStr(titikY) + ")"
        btnTikus.Location = New Point(titikX * LenX, titikY * LenY)
        btnTikus.Visible = True
    End Sub

    Private Sub btnTikus_Click(sender As Object, e As EventArgs) Handles btnTikus.Click
        skor += 100
        lblSkor.Text = "SKOR : " + CStr(skor)
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        gridX = txtGridX.Text
        gridY = txtGridY.Text
        LenX \= gridX
        LenY \= gridY
    End Sub
End Class
