Imports System.Net
Imports System.Threading
Imports System.Net.Sockets
Imports System.IO
Public Class Form1
    Private alSockets As ArrayList
    Private Sub UpdateListBox(ByVal teks As String)
        If Me.InvokeRequired Then
            Dim args() As String = {teks}
            Me.Invoke(New Action(Of String)(AddressOf UpdateListBox), args)
            Return
        End If
        lbHasil.Items.Add(teks)
    End Sub

    Private Function GetTextBox2() As String
        If Me.InvokeRequired Then
            Me.Invoke(New Action(AddressOf GetTextBox2), Nothing)
            Return txtSaveTo.Text
        End If
        Return txtSaveTo.Text
    End Function

    Public Sub handlerThread()
        Dim handlerSocket As Socket
        handlerSocket = alSockets(alSockets.Count - 1)
        Dim networkStream As NetworkStream = New NetworkStream(handlerSocket)
        Dim blockSize As Int16 = 1024
        Dim thisRead As Int16
        Dim dataByte(blockSize) As Byte
        SyncLock Me
            Dim fileStream As Stream
            fileStream = File.OpenWrite(GetTextBox2())
            While (True)
                thisRead = networkStream.Read(dataByte, 0, blockSize)
                fileStream.Write(dataByte, 0, dataByte.Length)
                If thisRead = 0 Then Exit While
            End While
            fileStream.Close()
        End SyncLock
        UpdateListBox("File Written Successfuly")
        handlerSocket = Nothing
    End Sub

    Public Sub listenerThread()
        Dim tcpListener As New TcpListener(IPAddress.Parse(txtSaveTo.Text), Val(txtPort.Text))
        Dim handlerSocket As Socket
        Dim thdstHandler As ThreadStart
        Dim thdHandler As Thread
        tcpListener.Start()
        Do
            handlerSocket = tcpListener.AcceptSocket()
            If handlerSocket.Connected Then
                UpdateListBox(handlerSocket.RemoteEndPoint.ToString() & " connected.")
                SyncLock (Me)
                    alSockets.Add(handlerSocket)
                End SyncLock
                thdstHandler = New ThreadStart(AddressOf handlerThread)
                thdHandler = New Thread(thdstHandler)
                thdHandler.Start()
            ElseIf handlerSocket.Connected = False Then
                handlerSocket.Close()
            End If
        Loop
    End Sub

    Private Sub btnListen_Click(sender As Object, e As EventArgs) Handles btnListen.Click
        Dim IPHost As IPHostEntry
        IPHost = Dns.GetHostEntry(Dns.GetHostName())
        alSockets = New ArrayList()
        Dim thdListener As New Thread(New ThreadStart(AddressOf listenerThread))
        thdListener.Start()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lbHasil.Items.Clear()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtSaveTo.Text = SaveFileDialog1.FileName
        End If
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class
