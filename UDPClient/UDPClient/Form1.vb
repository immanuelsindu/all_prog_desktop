Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Dim udpClient As New Sockets.UdpClient
        udpClient.Connect(txtRemoteHost.Text, Val(txtPort.Text))
        Dim sendBytes As Byte()
        sendBytes = Encoding.ASCII.GetBytes(txtMessage.Text)
        udpClient.Send(sendBytes, sendBytes.Length)
    End Sub
End Class
