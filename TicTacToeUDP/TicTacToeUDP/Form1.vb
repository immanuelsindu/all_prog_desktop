Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading
Public Class Form1
    Dim isClient As Boolean = False

    Private Sub checkIfButtonDisabled()
        Dim b() As Button = {Button1, Button2, Button3, Button4, Button5, Button6, Button7, Button8, Button9}

        For i As Byte = 0 To 8
            If b(i).Text = "X" Or b(i).Text = "O" Then
                b(i).Enabled = False
            Else
                b(i).Enabled = True
            End If
        Next i
    End Sub

    Private Sub disableAllButton()
        Dim b() As Button = {Button1, Button2, Button3, Button4, Button5, Button6, Button7, Button8, Button9}

        For i As Byte = 0 To 8
            b(i).Enabled = False
        Next i
    End Sub

    Private Sub enableAllButton()
        Dim b() As Button = {Button1, Button2, Button3, Button4, Button5, Button6, Button7, Button8, Button9}

        For i As Byte = 0 To 8
            b(i).Enabled = True
        Next i
    End Sub

    Private Sub updateTicTacToe(ByVal teks As String)
        If Me.InvokeRequired Then
            Me.Invoke(New Action(Of String)(AddressOf updateTicTacToe), teks)
            Return
        End If
        'update bagian server
        Select Case teks
            Case 1 And isClient = False
                checkIfButtonDisabled()
                Button1.Text = "X"
                checkIfButtonDisabled()
                lblStatus.Text = "Giliran kamu"
            Case 2 And isClient = False
                checkIfButtonDisabled()
                Button2.Text = "X"
                checkIfButtonDisabled()
                lblStatus.Text = "Giliran kamu"
            Case 3 And isClient = False
                checkIfButtonDisabled()
                Button3.Text = "X"
                checkIfButtonDisabled()
                lblStatus.Text = "Giliran kamu"
            Case 4 And isClient = False
                checkIfButtonDisabled()
                Button4.Text = "X"
                checkIfButtonDisabled()
                lblStatus.Text = "Giliran kamu"
            Case 5 And isClient = False
                checkIfButtonDisabled()
                Button5.Text = "X"
                checkIfButtonDisabled()
                lblStatus.Text = "Giliran kamu"
            Case 6 And isClient = False
                checkIfButtonDisabled()
                Button6.Text = "X"
                checkIfButtonDisabled()
                lblStatus.Text = "Giliran kamu"
            Case 7 And isClient = False
                checkIfButtonDisabled()
                Button7.Text = "X"
                checkIfButtonDisabled()
                lblStatus.Text = "Giliran kamu"
            Case 8 And isClient = False
                checkIfButtonDisabled()
                Button8.Text = "X"
                checkIfButtonDisabled()
                lblStatus.Text = "Giliran kamu"
            Case 9 And isClient = False
                checkIfButtonDisabled()
                Button9.Text = "X"
                checkIfButtonDisabled()
                lblStatus.Text = "Giliran kamu"
        End Select

        'update bagian client
        Select Case teks
            Case 1 And isClient
                checkIfButtonDisabled()
                Button1.Text = "O"
                checkIfButtonDisabled()
                lblStatus.Text = "Giliran kamu"
            Case 2 And isClient
                checkIfButtonDisabled()
                Button2.Text = "O"
                checkIfButtonDisabled()
                lblStatus.Text = "Giliran kamu"
            Case 3 And isClient
                checkIfButtonDisabled()
                Button3.Text = "O"
                checkIfButtonDisabled()
                lblStatus.Text = "Giliran kamu"
            Case 4 And isClient
                checkIfButtonDisabled()
                Button4.Text = "O"
                checkIfButtonDisabled()
                lblStatus.Text = "Giliran kamu"
            Case 5 And isClient
                checkIfButtonDisabled()
                Button5.Text = "O"
                checkIfButtonDisabled()
                lblStatus.Text = "Giliran kamu"
            Case 6 And isClient
                checkIfButtonDisabled()
                Button6.Text = "O"
                checkIfButtonDisabled()
                lblStatus.Text = "Giliran kamu"
            Case 7 And isClient
                checkIfButtonDisabled()
                Button7.Text = "O"
                checkIfButtonDisabled()
                lblStatus.Text = "Giliran kamu"
            Case 8 And isClient
                checkIfButtonDisabled()
                Button8.Text = "O"
                checkIfButtonDisabled()
                lblStatus.Text = "Giliran kamu"
            Case 9 And isClient
                checkIfButtonDisabled()
                Button9.Text = "O"
                checkIfButtonDisabled()
                lblStatus.Text = "Giliran kamu"
        End Select
        'lbHasil.Items.Add(teks)

    End Sub
    Public Sub serverThread()
        Dim udpClient As New UdpClient(8083)
        While True
            Dim RemoteIpEndPoint As New IPEndPoint(IPAddress.Any, 0)
            Dim receiveBytes As Byte()
            receiveBytes = udpClient.Receive(RemoteIpEndPoint)
            Dim returnData As String = Encoding.ASCII.GetString(receiveBytes)

            updateTicTacToe(returnData)
        End While
    End Sub

    Public Sub serverThread2()
        Dim udpClient As New UdpClient(8084)
        While True
            Dim RemoteIpEndPoint As New IPEndPoint(IPAddress.Any, 0)
            Dim receiveBytes As Byte()
            receiveBytes = udpClient.Receive(RemoteIpEndPoint)
            Dim returnData As String = Encoding.ASCII.GetString(receiveBytes)

            updateTicTacToe(returnData)
        End While
    End Sub

    Private Sub btnHostGame_Click(sender As Object, e As EventArgs) Handles btnHostGame.Click
        lblSebagai.Text = "Sebagai : Server (Player 2)"
        lblStatus.Text = "Tunggu Player Lain"

        Dim thdUDPServer = New Thread(New ThreadStart(AddressOf serverThread))
        thdUDPServer.Start()


    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        lblSebagai.Text = "Sebagai : Server (Player 1)"

        isClient = True
        enableAllButton()
        lblStatus.Text = "Giliran Kamu"

        Dim thdUDPServer = New Thread(New ThreadStart(AddressOf serverThread2))
        thdUDPServer.Start()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (isClient = True) Then
            Dim udpClient As New UdpClient
            udpClient.Connect(txtIP.Text, 8083)
            Dim sendBytes As Byte()
            sendBytes = Encoding.ASCII.GetBytes("1")
            udpClient.Send(sendBytes, sendBytes.Length)

            disableAllButton()
            Button1.Text = "X"
            lblStatus.Text = "Giliran Musuh"
        Else
            Dim udpClient As New UdpClient
            udpClient.Connect(txtIP.Text, 8084)
            Dim sendBytes As Byte()
            sendBytes = Encoding.ASCII.GetBytes("1")
            udpClient.Send(sendBytes, sendBytes.Length)
            Button1.Text = "O"
            disableAllButton()

            lblStatus.Text = "Giliran Musuh"
        End If
    End Sub


    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        If (isClient = True) Then
            Dim udpClient As New UdpClient
            udpClient.Connect(txtIP.Text, 8083)
            Dim sendBytes As Byte()
            sendBytes = Encoding.ASCII.GetBytes("2")
            udpClient.Send(sendBytes, sendBytes.Length)

            disableAllButton()
            Button2.Text = "X"
            lblStatus.Text = "Giliran Musuh"
        Else
            Button2.Text = "O"
            disableAllButton()

            lblStatus.Text = "Giliran Musuh"

            Dim udpClient As New UdpClient
            udpClient.Connect(txtIP.Text, 8084)
            Dim sendBytes As Byte()
            sendBytes = Encoding.ASCII.GetBytes("2")
            udpClient.Send(sendBytes, sendBytes.Length)

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (isClient = True) Then
            Dim udpClient As New UdpClient
            udpClient.Connect(txtIP.Text, 8083)
            Dim sendBytes As Byte()
            sendBytes = Encoding.ASCII.GetBytes("3")
            udpClient.Send(sendBytes, sendBytes.Length)

            disableAllButton()
            Button3.Text = "X"
            lblStatus.Text = "Giliran Musuh"
        Else
            Dim udpClient As New UdpClient
            udpClient.Connect(txtIP.Text, 8084)
            Dim sendBytes As Byte()
            sendBytes = Encoding.ASCII.GetBytes("3")
            udpClient.Send(sendBytes, sendBytes.Length)
            Button3.Text = "O"
            disableAllButton()

            lblStatus.Text = "Giliran Musuh"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (isClient = True) Then
            Dim udpClient As New UdpClient
            udpClient.Connect(txtIP.Text, 8083)
            Dim sendBytes As Byte()
            sendBytes = Encoding.ASCII.GetBytes("4")
            udpClient.Send(sendBytes, sendBytes.Length)

            disableAllButton()
            Button4.Text = "X"
            lblStatus.Text = "Giliran Musuh"
        Else
            Dim udpClient As New UdpClient
            udpClient.Connect(txtIP.Text, 8084)
            Dim sendBytes As Byte()
            sendBytes = Encoding.ASCII.GetBytes("4")
            udpClient.Send(sendBytes, sendBytes.Length)
            Button4.Text = "O"
            disableAllButton()

            lblStatus.Text = "Giliran Musuh"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (isClient = True) Then
            Dim udpClient As New UdpClient
            udpClient.Connect(txtIP.Text, 8083)
            Dim sendBytes As Byte()
            sendBytes = Encoding.ASCII.GetBytes("5")
            udpClient.Send(sendBytes, sendBytes.Length)

            disableAllButton()
            Button5.Text = "X"
            lblStatus.Text = "Giliran Musuh"
        Else
            Dim udpClient As New UdpClient
            udpClient.Connect(txtIP.Text, 8084)
            Dim sendBytes As Byte()
            sendBytes = Encoding.ASCII.GetBytes("5")
            udpClient.Send(sendBytes, sendBytes.Length)
            Button5.Text = "O"
            disableAllButton()

            lblStatus.Text = "Giliran Musuh"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If (isClient = True) Then
            Dim udpClient As New UdpClient
            udpClient.Connect(txtIP.Text, 8083)
            Dim sendBytes As Byte()
            sendBytes = Encoding.ASCII.GetBytes("6")
            udpClient.Send(sendBytes, sendBytes.Length)

            disableAllButton()
            Button6.Text = "X"
            lblStatus.Text = "Giliran Musuh"
        Else
            Dim udpClient As New UdpClient
            udpClient.Connect(txtIP.Text, 8084)
            Dim sendBytes As Byte()
            sendBytes = Encoding.ASCII.GetBytes("6")
            udpClient.Send(sendBytes, sendBytes.Length)
            Button6.Text = "O"
            disableAllButton()

            lblStatus.Text = "Giliran Musuh"
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If (isClient = True) Then
            Dim udpClient As New UdpClient
            udpClient.Connect(txtIP.Text, 8083)
            Dim sendBytes As Byte()
            sendBytes = Encoding.ASCII.GetBytes("7")
            udpClient.Send(sendBytes, sendBytes.Length)

            disableAllButton()
            Button7.Text = "X"
            lblStatus.Text = "Giliran Musuh"
        Else
            Dim udpClient As New UdpClient
            udpClient.Connect(txtIP.Text, 8084)
            Dim sendBytes As Byte()
            sendBytes = Encoding.ASCII.GetBytes("7")
            udpClient.Send(sendBytes, sendBytes.Length)
            Button7.Text = "O"
            disableAllButton()

            lblStatus.Text = "Giliran Musuh"
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If (isClient = True) Then
            Dim udpClient As New UdpClient
            udpClient.Connect(txtIP.Text, 8083)
            Dim sendBytes As Byte()
            sendBytes = Encoding.ASCII.GetBytes("8")
            udpClient.Send(sendBytes, sendBytes.Length)

            disableAllButton()
            Button8.Text = "X"
            lblStatus.Text = "Giliran Musuh"
        Else
            Dim udpClient As New UdpClient
            udpClient.Connect(txtIP.Text, 8084)
            Dim sendBytes As Byte()
            sendBytes = Encoding.ASCII.GetBytes("8")
            udpClient.Send(sendBytes, sendBytes.Length)
            Button8.Text = "O"
            disableAllButton()

            lblStatus.Text = "Giliran Musuh"
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If (isClient = True) Then
            Dim udpClient As New UdpClient
            udpClient.Connect(txtIP.Text, 8083)
            Dim sendBytes As Byte()
            sendBytes = Encoding.ASCII.GetBytes("9")
            udpClient.Send(sendBytes, sendBytes.Length)

            disableAllButton()
            Button9.Text = "X"
            lblStatus.Text = "Giliran Musuh"
        Else
            Dim udpClient As New UdpClient
            udpClient.Connect(txtIP.Text, 8084)
            Dim sendBytes As Byte()
            sendBytes = Encoding.ASCII.GetBytes("9")
            udpClient.Send(sendBytes, sendBytes.Length)
            Button9.Text = "O"
            disableAllButton()

            lblStatus.Text = "Giliran Musuh"
        End If
    End Sub
End Class
