Imports System.IO
Imports System.Net
Imports System.Net.Sockets

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            txtPath.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Dim filebuffer As Byte()
        Dim fileStream As Stream
        fileStream = File.OpenRead(txtPath.Text)
        ReDim filebuffer(fileStream.Length)
        fileStream.Read(filebuffer, 0, fileStream.Length)
        Dim clientSocket As New Sockets.TcpClient(txtServer.Text, CInt(txtPort.Text))
        Dim networkStream As NetworkStream
        networkStream = clientSocket.GetStream()
        networkStream.Write(filebuffer, 0, fileStream.Length)
        networkStream.Close()
        MsgBox("File uploaded!")
    End Sub
End Class
