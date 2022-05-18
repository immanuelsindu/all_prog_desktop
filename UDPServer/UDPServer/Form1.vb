Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading
Public Class Form1

    Private Sub UpdateListBox(ByVal teks As String)
        If Me.InvokeRequired Then
            Dim args() As String = {teks}
            Me.Invoke(New Action(Of String)(AddressOf UpdateListBox), args)
            Return
        End If
        lbHasil.Items.Add(teks)
    End Sub

    Public Sub serverThread()
        Dim udpClient As New UdpClient(CInt(txtPort.Text))
        While True
            Dim RemoteIpEndPoint As New IPEndPoint(IPAddress.Any, 0)
            Dim receiveBytes As Byte()
            receiveBytes = udpClient.Receive(RemoteIpEndPoint)
            Dim returnData As String = Encoding.ASCII.GetString(receiveBytes)
            Dim informationSent = "From " & RemoteIpEndPoint.Address.ToString() + ":" & returnData.ToString()
            UpdateListBox(informationSent)
        End While
    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lbHasil.Items.Clear()
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim thdUDPServer = New Thread(New ThreadStart(AddressOf serverThread))
        thdUDPServer.Start()
    End Sub
End Class
