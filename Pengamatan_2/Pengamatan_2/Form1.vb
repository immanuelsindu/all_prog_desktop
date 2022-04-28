Public Class Form1
    Private valHolder1 As Double
    Private valHolder2 As Double
    Private tmpValue As Double
    Private hasDecimal As Boolean
    Private inputStatus As Boolean = True
    Private clearText As Boolean
    Private calcFunc As String

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If TextBox1.Text.Length <> 0 AndAlso valHolder1 <> 0 Then
            CalculateTotals()
            calcFunc = ""
            hasDecimal = False
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If inputStatus = True Then
            If Not hasDecimal Then
                If TextBox1.Text.Length > 1 Then
                    If Not TextBox1.Text = "0" Then
                        TextBox1.Text &= Button11.Text
                        hasDecimal = True
                    End If
                Else
                    TextBox1.Text = "0."
                    inputStatus = False
                End If
            End If
        ElseIf inputStatus = False And TextBox1.Text = "" Then
            TextBox1.Text = "0."
        Else

        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If inputStatus = False Then
            TextBox1.Text &= Button6.Text
        Else
            TextBox1.Text = Button6.Text
            inputStatus = False
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If inputStatus = False Then
            TextBox1.Text &= Button5.Text
        Else
            TextBox1.Text = Button5.Text
            inputStatus = False
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If inputStatus = False Then
            TextBox1.Text &= Button4.Text
        Else
            TextBox1.Text = Button4.Text
            inputStatus = False
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If inputStatus = False Then
            TextBox1.Text &= Button8.Text
        Else
            TextBox1.Text = Button8.Text
            inputStatus = False
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If inputStatus = False Then
            TextBox1.Text &= Button7.Text
        Else
            TextBox1.Text = Button7.Text
            inputStatus = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If inputStatus = False Then
            TextBox1.Text &= Button3.Text
        Else
            TextBox1.Text = Button3.Text
            inputStatus = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If inputStatus = False Then
            TextBox1.Text &= Button2.Text
        Else
            TextBox1.Text = Button2.Text
            inputStatus = False
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If inputStatus = False Then
            TextBox1.Text &= Button10.Text
        Else
            TextBox1.Text = Button10.Text
            inputStatus = False
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If inputStatus = False Then
            TextBox1.Text &= Button9.Text
        Else
            TextBox1.Text = Button9.Text
            inputStatus = False
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        TextBox1.Text = String.Empty
        valHolder1 = 0
        valHolder2 = 0
        calcFunc = String.Empty
        hasDecimal = False

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If inputStatus = False Then
            TextBox1.Text &= Button13.Text
        Else
            TextBox1.Text = Button13.Text
            inputStatus = False
        End If
    End Sub

    Private Sub CalculateTotals()
        valHolder2 = CType(TextBox1.Text, Double)
        Select Case calcFunc
            Case "Add"
                valHolder1 = valHolder1 + valHolder2
            Case "Subtract"
                valHolder1 = valHolder1 - valHolder2
            Case "Divide"
                valHolder1 = valHolder1 / valHolder2
            Case "Multiply"
                valHolder1 = valHolder1 * valHolder2
            Case "PowerOf"
                valHolder1 = System.Math.Pow(valHolder1, valHolder2)
        End Select
        TextBox1.Text = CType(valHolder1, String)
        inputStatus = True
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        TextBox1.Text = String.Empty
        hasDecimal = False
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str As String
        Dim loc As Integer
        If TextBox1.Text.Length > 0 Then
            str = TextBox1.Text.Chars(TextBox1.Text.Length - 1)
            'Jika karakter terakhir adalah , (desimal)
            If str = "." Then
                hasDecimal = False
                TextBox1.Text = ""
            End If
            loc = TextBox1.Text.Length
            TextBox1.Text = TextBox1.Text.Remove(loc - 1, 1)
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        If TextBox1.Text.Length <> 0 Then
            If calcFunc = String.Empty Then
                valHolder1 = CDbl(TextBox1.Text)
                TextBox1.Text = String.Empty
            Else
                CalculateTotals()
            End If
            calcFunc = "Add"
            hasDecimal = False
        End If
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        If TextBox1.Text.Length <> 0 Then
            If calcFunc = String.Empty Then
                valHolder1 = CType(TextBox1.Text, Double)
                TextBox1.Text = String.Empty
            Else
                CalculateTotals()
            End If
            calcFunc = "Subtract"
            hasDecimal = False
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        If TextBox1.Text.Length <> 0 Then
            If calcFunc = String.Empty Then
                valHolder1 = CDbl(TextBox1.Text)
                TextBox1.Text = String.Empty
            Else
                CalculateTotals()
            End If
            calcFunc = "Multiply"
            hasDecimal = False
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If TextBox1.Text.Length <> 0 Then
            If calcFunc = String.Empty Then
                valHolder1 = CType(TextBox1.Text, Double)
                TextBox1.Text = String.Empty
            Else
                CalculateTotals()
            End If
            calcFunc = "Divide"
            hasDecimal = False
        End If
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        If TextBox1.Text.Length <> 0 Then
            tmpValue = CType(TextBox1.Text, Double)
            tmpValue = System.Math.Sqrt(tmpValue)
            TextBox1.Text = CType(tmpValue, String)
            hasDecimal = False
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If TextBox1.Text.Length <> 0 Then
            If calcFunc = String.Empty Then
                valHolder1 = CType(TextBox1.Text, Double)
                TextBox1.Text = String.Empty
            Else
                CalculateTotals()
            End If
            calcFunc = "PowerOf"
            hasDecimal = False
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If inputStatus = False Then
            If TextBox1.Text.Length > 0 Then
                valHolder1 = -1 * CDbl(TextBox1.Text)
                TextBox1.Text = CStr(valHolder1)
            End If
        End If

    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        If TextBox1.Text.Length <> 0 Then
            tmpValue = CDbl(TextBox1.Text)
            tmpValue = 1 / tmpValue
            TextBox1.Text = CStr(tmpValue)
            hasDecimal = False
        End If
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Dim hasil As Double = 1
        Dim until = CDbl(TextBox1.Text)
        For i As Double = 1 To until
            hasil *= i
        Next

        TextBox1.Text = CStr(hasil)
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Dim hasil As Double = 1
        For i As Double = 1 To 3
            hasil *= CDbl(TextBox1.Text)
        Next

        TextBox1.Text = CStr(hasil)

    End Sub
End Class
