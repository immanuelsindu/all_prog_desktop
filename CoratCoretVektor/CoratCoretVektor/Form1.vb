Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class frmUtama
    Dim modegambar As String
    Dim warnatepi As Color = Color.Black
    Dim warnaisian As Color = Color.White
    Dim tepi As New Pen(warnatepi, 3)
    Dim isian As New SolidBrush(warnaisian)
    Dim titik As Point = Nothing
    Dim dipencet As Boolean = False
    Dim bmp As Bitmap
    Dim stack As Stack = New Stack()
    Dim stack2 As Stack = New Stack()

    Private Sub frmUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnClear.PerformClick()
        tepi.EndCap = LineCap.Round
    End Sub

    Private Sub RadioBebas_CheckedChanged(sender As Object, e As EventArgs) Handles RadioBebas.CheckedChanged
        modegambar = "bebas"
    End Sub

    Private Sub RadioGaris_CheckedChanged(sender As Object, e As EventArgs) Handles RadioGaris.CheckedChanged
        modegambar = "garis"
    End Sub

    Private Sub RadioKotak_CheckedChanged(sender As Object, e As EventArgs) Handles RadioKotak.CheckedChanged
        modegambar = "kotak"
    End Sub

    Private Sub RadioElips_CheckedChanged(sender As Object, e As EventArgs) Handles RadioElips.CheckedChanged
        modegambar = "elips"
    End Sub

    Private Sub RadioKotakIsi_CheckedChanged(sender As Object, e As EventArgs) Handles RadioKotakIsi.CheckedChanged
        modegambar = "kotakisi"
    End Sub

    Private Sub RadioRadioElipsIsi_CheckedChanged(sender As Object, e As EventArgs) Handles RadioRadioElipsIsi.CheckedChanged
        modegambar = "elipsisi"
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        tepi.Width = NumericUpDown1.Value
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        tepi.Color = warnatepi
        isian.Color = warnaisian
        titik = e.Location
        dipencet = True
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        Select Case modegambar
            Case "bebas"
                If dipencet Then
                    Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                        g.DrawLine(tepi, titik, e.Location)
                    End Using
                    PictureBox1.Invalidate()
                    TextBox1.AppendText("o " + "warnatepi" + " " + warnatepi.R.ToString + " " + warnatepi.G.ToString + " " + warnatepi.B.ToString & vbNewLine)
                    TextBox1.AppendText("o garis " + titik.X.ToString + " " + titik.Y.ToString + " " + e.X.ToString + " " + e.Y.ToString + " " + tepi.Width.ToString & vbNewLine)
                    titik = e.Location
                End If
        End Select
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        Select Case modegambar
            Case "garis"
                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                    g.DrawLine(tepi, titik, e.Location)
                End Using
            Case "kotak"
                Dim rect As New Rectangle(titik.X, titik.Y, e.X - titik.X, e.Y - titik.Y)
                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                    g.DrawRectangle(tepi, rect)
                End Using
            Case "elips"
                Dim rect As New Rectangle(titik.X, titik.Y, e.X - titik.X, e.Y - titik.Y)
                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                    g.DrawEllipse(tepi, rect)
                End Using
            Case "kotakisi"
                Dim rect As New Rectangle(titik.X, titik.Y, e.X - titik.X, e.Y - titik.Y)
                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                    g.FillRectangle(isian, rect)
                    g.DrawRectangle(tepi, rect)
                End Using
            Case "elipsisi"
                Dim rect As New Rectangle(titik.X, titik.Y, e.X - titik.X, e.Y - titik.Y)
                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                    g.FillEllipse(isian, rect)
                    g.DrawEllipse(tepi, rect)
                End Using
        End Select
        PictureBox1.Invalidate()
        dipencet = False
        If (titik.X <> e.X And titik.Y <> e.Y) Then
            Dim perintahGambar As String = ""
            perintahGambar += "o " + "warnatepi" + " " + warnatepi.R.ToString + " " + warnatepi.G.ToString + " " + warnatepi.B.ToString & vbNewLine
            perintahGambar += "o " + "warnaisian" + " " + warnaisian.R.ToString + " " + warnaisian.G.ToString + " " + warnaisian.B.ToString & vbNewLine
            perintahGambar += "o " + modegambar + " " + titik.X.ToString + " " + titik.Y.ToString + " " + e.X.ToString + " " + e.Y.ToString + " " + tepi.Width.ToString & vbNewLine
            stack.Push(perintahGambar)
            TextBox1.AppendText(stack.Peek())
        End If
    End Sub

    Private Sub PanelWarna1_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelWarna1.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = PanelWarna1.BackColor
            PanelShapeTepi.BackColor = warnatepi
        Else
            warnaisian = PanelWarna1.BackColor
            PanelShapeIsian.BackColor = warnaisian
        End If
    End Sub

    Private Sub PanelWarna2_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelWarna2.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = PanelWarna2.BackColor
            PanelShapeTepi.BackColor = warnatepi
        Else
            warnaisian = PanelWarna2.BackColor
            PanelShapeIsian.BackColor = warnaisian
        End If
    End Sub

    Private Sub PanelWarna3_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelWarna3.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = PanelWarna3.BackColor
            PanelShapeTepi.BackColor = warnatepi
        Else
            warnaisian = PanelWarna3.BackColor
            PanelShapeIsian.BackColor = warnaisian
        End If
    End Sub

    Private Sub PanelWarna4_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelWarna4.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = PanelWarna4.BackColor
            PanelShapeTepi.BackColor = warnatepi
        Else
            warnaisian = PanelWarna4.BackColor
            PanelShapeIsian.BackColor = warnaisian
        End If
    End Sub

    Private Sub PanelWarna5_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelWarna5.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = PanelWarna5.BackColor
            PanelShapeTepi.BackColor = warnatepi
        Else
            warnaisian = PanelWarna5.BackColor
            PanelShapeIsian.BackColor = warnaisian
        End If
    End Sub

    Private Sub PanelWarna6_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelWarna6.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = PanelWarna6.BackColor
            PanelShapeTepi.BackColor = warnatepi
        Else
            warnaisian = PanelWarna6.BackColor
            PanelShapeIsian.BackColor = warnaisian
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        bmp = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.Clear(Color.White)
        End Using
        PictureBox1.Image = bmp
    End Sub

    Private Sub btnGambarUlang_Click(sender As Object, e As EventArgs) Handles btnGambarUlang.Click
        If Not (TextBox1.Text = "" Or TextBox1.Text = Nothing) Then
            btnClear.PerformClick()
            Dim a As Integer = TextBox1.Lines.Count
            For i As Integer = 0 To a
                Dim teksbaris As String = TextBox1.Lines(i)
                Dim pecah() As String
                pecah = teksbaris.Split(" "c)
                On Error Resume Next
                pecah(1) = pecah(1).Trim(" "c)
                Select Case pecah(1)
                    Case "warnatepi"
                        warnatepi = Color.FromArgb(CByte(pecah(2)), CByte(pecah(3)), CByte(pecah(4)))
                        tepi.Color = warnatepi
                    Case "warnaisian"
                        warnaisian = Color.FromArgb(CByte(pecah(2)), CByte(pecah(3)), CByte(pecah(4)))
                        isian.Color = warnaisian
                    Case "garis"
                        Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                            tepi.Width = CDec(pecah(6).ToString)
                            g.DrawLine(tepi, CInt(pecah(2)), CInt(pecah(3)), CInt(pecah(4)), CInt(pecah(5)))
                        End Using
                    Case "kotak"
                        Dim rect As New Rectangle(CInt(pecah(2)), CInt(pecah(3)), CInt(pecah(4)) - CInt(pecah(2)), CInt(pecah(5)) - CInt(pecah(3)))
                        Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                            tepi.Width = CDec(pecah(6).ToString)
                            g.DrawRectangle(tepi, rect)
                        End Using
                    Case "elips"
                        Dim rect As New Rectangle(CInt(pecah(2)), CInt(pecah(3)), CInt(pecah(4)) - CInt(pecah(2)), CInt(pecah(5)) - CInt(pecah(3)))
                        Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                            tepi.Width = CDec(pecah(6).ToString)
                            g.DrawEllipse(tepi, rect)
                        End Using
                    Case "kotakisi"
                        Dim rect As New Rectangle(CInt(pecah(2)), CInt(pecah(3)), CInt(pecah(4)) - CInt(pecah(2)), CInt(pecah(5)) - CInt(pecah(3)))
                        Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                            tepi.Width = CDec(pecah(6).ToString)
                            g.FillRectangle(isian, rect)
                            g.DrawRectangle(tepi, rect)
                        End Using
                    Case "elipsisi"
                        Dim rect As New Rectangle(CInt(pecah(2)), CInt(pecah(3)), CInt(pecah(4)) - CInt(pecah(2)), CInt(pecah(5)) - CInt(pecah(3)))
                        Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                            tepi.Width = CDec(pecah(6).ToString)
                            g.FillEllipse(isian, rect)
                            g.DrawEllipse(tepi, rect)
                        End Using
                End Select
            Next
            PictureBox1.Invalidate()
        Else
            MsgBox("Tidak dapat melakukan gambar ulang karena Objek Kosong", MessageBoxButtons.OK + MessageBoxIcon.Error,
       "Terjadi Kesalahan")
        End If

    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub BaruToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BaruToolStripMenuItem.Click
        btnClear.PerformClick()
        TextBox1.Clear()
        stack.Clear()

    End Sub

    Private Sub SimpanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanToolStripMenuItem.Click
        If Not TextBox1.Text = "" Then
            SaveFileDialog1.ShowDialog()
            Dim location As String = SaveFileDialog1.FileName
            My.Computer.FileSystem.WriteAllText(location & ".txt", TextBox1.Text.ToString, False)
        Else
            MsgBox("Tidak dapat menyimpan vektor kosong", MessageBoxButtons.OK + MessageBoxIcon.Error,
      "Terjadi Kesalahan")
        End If

    End Sub

    Private Sub BukaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            TextBox1.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
            btnGambarUlang.PerformClick()
        End If

    End Sub

    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        If TextBox1.Text = String.Empty Then
            MsgBox("Tidak dapat melakukan Undo karena tidak ada aksi sebelumnya", MessageBoxButtons.OK + MessageBoxIcon.Error,
    "Terjadi Kesalahan")
        Else
            Try
                stack.Pop()
                TextBox1.Clear()
                btnClear.PerformClick()

                While stack.Count > 0
                    TextBox1.AppendText(stack.Peek())
                    stack2.Push(stack.Peek())
                    stack.Pop()
                End While

                While stack2.Count > 0
                    stack.Push(stack2.Peek())
                    stack2.Pop()
                End While

                If Not TextBox1.Text = String.Empty Then
                    btnGambarUlang.PerformClick()
                End If
            Catch ex As Exception
                MsgBox("Tidak bisa melakukan Undo Mode bebas", MessageBoxButtons.OK + MessageBoxIcon.Error,
   "Terjadi Kesalahan")
            End Try
        End If
    End Sub
End Class
