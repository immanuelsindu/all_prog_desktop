Public Class Form1
    Private Const WM_DRAWCLIPBOARD As Integer = &H308
    Private idCounter As Integer = 0
    Private Declare Function SetClipboardViewer Lib "user32" Alias "SetClipboardViewer" (ByVal hwnd As Integer) As Integer
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)

        If m.Msg = WM_DRAWCLIPBOARD Then
            If Clipboard.ContainsText Then
                Dim item As New ListViewItem(idCounter)
                item.SubItems.Add("String")
                item.SubItems.Add(Clipboard.GetText())
                ListView1.Items.Add(item)
                idCounter += 1
            End If
        End If


        MyBase.WndProc(m)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim result As Integer = SetClipboardViewer(Me.Handle.ToInt32)
        While result <> Me.Handle.ToInt32
            result = SetClipboardViewer(Me.Handle.ToInt32)
        End While

        If Clipboard.ContainsAudio Then
            lblAudio.Text = "Contains Audio : True"
        Else
            lblAudio.Text = "Contains Audio : False"
        End If

        If Clipboard.ContainsImage Then
            lblImage.Text = "Contains Image: True"
        Else
            lblImage.Text = "Contains Image : False"
        End If

        If Clipboard.ContainsText Then
            lblText.Text = "Contains Text : True"



        Else
            lblText.Text = "Contains Text : False"
        End If

        If Clipboard.ContainsFileDropList Then
            lblDropLIst.Text = "Contains Drop List : True"
        Else
            lblDropLIst.Text = "Contains Drop List : False"
        End If



    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        If Clipboard.ContainsAudio Then
            lblAudio.Text = "Contains Audio : True"
        Else
            lblAudio.Text = "Contains Audio : False"
        End If

        If Clipboard.ContainsImage Then
            lblImage.Text = "Contains Image: True"
        Else
            lblImage.Text = "Contains Image : False"
        End If

        If Clipboard.ContainsText Then
            lblText.Text = "Contains Text : True"

        Else
            lblText.Text = "Contains Text : False"
        End If

        If Clipboard.ContainsFileDropList Then
            lblDropLIst.Text = "Contains Drop List : True"
        Else
            lblDropLIst.Text = "Contains Drop List : False"
        End If


        If Clipboard.ContainsText Then
            Dim item As New ListViewItem(idCounter)
            item.SubItems.Add("String")
            item.SubItems.Add(Clipboard.GetText())
            ListView1.Items.Add(item)
            idCounter += 1
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Clipboard.Clear()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        ListView1.Items.Remove(ListView1.SelectedItems(0))
    End Sub



    Private Sub ShowDetailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowDetailToolStripMenuItem.Click
        Dim x As Integer = ListView1.SelectedItems(0).Index
        Form2.TextBox1.Text = ListView1.Items(x).SubItems(2).Text
        Form2.ShowDialog()
    End Sub

    Private Sub SelectAndUseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAndUseToolStripMenuItem.Click
        Dim x As Integer = ListView1.SelectedItems(0).Index
        Clipboard.SetText(ListView1.Items(x).SubItems(2).Text)
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Hide()
            NotifyIcon1.Visible = True

        End If
    End Sub



    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub HideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HideToolStripMenuItem.Click
        Me.Hide()
    End Sub

    Private Sub ShowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowToolStripMenuItem.Click
        Me.Show()
    End Sub
End Class
