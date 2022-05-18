Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading
Public Class Form1
    Dim isClient As Boolean = False

    Private Sub updateTicTacToe(ByVal teks As String)
        If Me.InvokeRequired Then
            Me.Invoke(New Action(Of String)(AddressOf updateTicTacToe), teks)
            Return
        End If
        Select Case teks

            Case 1 And isClient = False
                Button1.Text = "O"
                Button2.Enabled = True
                Button3.Enabled = True
                lblStatus.Text = "Giliran kamu"
            Case 2 And isClient = False
                Button2.Text = "O"
                Button1.Enabled = True
                Button3.Enabled = True
                lblStatus.Text = "Giliran kamu"
            Case 3 And isClient = False
                Button3.Text = "O"
                Button1.Enabled = True
                Button2.Enabled = True
                lblStatus.Text = "Giliran kamu"
            Case Else
                lblStatus.Text = teks
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


            'Dim informationsent = "from " & RemoteIpEndPoint.Address.ToString() + ":" & returnData.ToString()
            'updatelistbox(informationsent)
        End While
    End Sub

    Private Sub btnHostGame_Click(sender As Object, e As EventArgs) Handles btnHostGame.Click
        Dim thdUDPServer = New Thread(New ThreadStart(AddressOf serverThread))
        thdUDPServer.Start()
    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        isClient = True
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        lblStatus.Text = "Giliran Kamu"
        'Dim udpClient As New Sockets.UdpClient
        'udpClient.Connect(txtIP.Text, 8083)
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
            Button1.Text = "O"
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
            Button2.Text = "O"
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
            Button3.Text = "O"
        End If
    End Sub
End Class
