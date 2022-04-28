Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim desimal, octal As Double
        Dim hasilBiner As String = ""
        Dim hasilOctal As String = ""

        desimal = Val(TextBox1.Text)

        While desimal > 0
            If desimal = 0 Then
                hasilBiner = "1" & hasilBiner
                Exit While
            Else
                hasilBiner = CStr(desimal Mod 2) & hasilBiner
                desimal = desimal \ 2
            End If
        End While

        TextBox2.Text = hasilBiner

        octal = Val(TextBox1.Text)

        While octal > 0
            If octal < 8 Then
                hasilOctal = octal & hasilOctal
                Exit While
            Else
                hasilOctal = CStr(octal Mod 8) & hasilOctal
                octal = octal \ 8
            End If
        End While

        TextBox3.Text = CStr(hasilOctal)
        TextBox4.Text = CStr(Hex(Val(TextBox1.Text)))


    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)


    End Sub
End Class
