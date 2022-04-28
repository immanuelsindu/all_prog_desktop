Public Class Form1
    Dim myrandom As Random

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim hasil As Integer = myrandom.Next(65, 90)
        Label1.Text = Chr(hasil).ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
        Timer2.Enabled = True
        Timer3.Enabled = True
        Timer4.Enabled = True
        Randomize()
        myrandom = New Random
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim hasil As Integer = myrandom.Next(65, 90)
        Label2.Text = CStr(Chr(hasil))
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Dim hasil As Integer = myrandom.Next(65, 90)
        Label3.Text = Chr(hasil).ToString
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Timer1.Enabled = False
        Timer2.Enabled = False
        Timer3.Enabled = False
        Timer4.Enabled = False

        If Label1.Text = Label2.Text And Label2.Text = Label3.Text Then
            LabelStatus.Text = "Jackpot"
        ElseIf Label1.Text = Label2.Text Or Label2.Text = Label3.Text Then
            LabelStatus.Text = "2 Sama!"
        Else
            LabelStatus.Text = "Bad!"
        End If

    End Sub
End Class
