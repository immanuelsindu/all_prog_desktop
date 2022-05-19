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
        End Select

        'update bagian client
        Select Case teks
            Case 1 And isClient
                Button1.Text = "O"
                Button2.Enabled = True
                Button3.Enabled = True
                lblStatus.Text = "Giliran kamu"
            Case 2 And isClient
                Button2.Text = "O"
                Button1.Enabled = True
                Button3.Enabled = True
                lblStatus.Text = "Giliran kamu"
            Case 3 And isClient
                Button3.Text = "O"
                Button1.Enabled = True
                Button2.Enabled = True

                'checkIsButtonDisabled
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

    'Public Sub serverThread2()
    '    Dim udpClient As New UdpClient(8083)
    '    While True
    '        Dim RemoteIpEndPoint As New IPEndPoint(IPAddress.Any, 0)
    '        Dim receiveBytes As Byte()
    '        receiveBytes = udpClient.Receive(RemoteIpEndPoint)
    '        Dim returnData As String = Encoding.ASCII.GetString(receiveBytes)

    '        updateTicTacToe(returnData)
    '    End While
    'End Sub

    Private Sub btnHostGame_Click(sender As Object, e As EventArgs) Handles btnHostGame.Click
        lblSebagai.Text = "Sebagai Server (Player 2)"
        lblStatus.Text = "Tunggu Player Lain"

        Dim thdUDPServer = New Thread(New ThreadStart(AddressOf serverThread))
        thdUDPServer.Start()


    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        lblSebagai.Text = "Sebagai Server (Player 1)"

        isClient = True
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        lblStatus.Text = "Giliran Kamu"

        'Dim thdUDPServer = New Thread(New ThreadStart(AddressOf serverThread))
        'thdUDPServer.Start()

        'Dim udpClient As New Sockets.UdpClient
        'udpClient.Connect(txtIP.Text, 8083)

        'client membuat observer juga

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (isClient = True) Then
            Dim udpClient As New UdpClient
            udpClient.Connect(txtIP.Text, 8083)
            Dim sendBytes As Byte()
            sendBytes = Encoding.ASCII.GetBytes("1")
            udpClient.Send(sendBytes, sendBytes.Length)

            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button1.Text = "X"
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

            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button2.Text = "X"
            lblStatus.Text = "Giliran Musuh"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (isClient = True) Then
            Dim udpClient As New UdpClient
            udpClient.Connect(txtIP.Text, 8083)
            Dim sendBytes As Byte()
            sendBytes = Encoding.ASCII.GetBytes("3")
            udpClient.Send(sendBytes, sendBytes.Length)

            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button3.Text = "X"
            lblStatus.Text = "Giliran Musuh"
        Else
            Dim udpClient As New UdpClient
            udpClient.Connect(txtIP.Text, 8084)
            Dim sendBytes As Byte()
            sendBytes = Encoding.ASCII.GetBytes("3")
            udpClient.Send(sendBytes, sendBytes.Length)

            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button3.Text = "X"
            lblStatus.Text = "Giliran Musuh"
        End If
    End Sub
End Class
