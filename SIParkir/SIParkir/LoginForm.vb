Imports MySql.Data.MySqlClient
Public Class LoginForm

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(sender As System.Object, e As EventArgs) Handles btnLogin.Click
        Dim sql As String = "select username,password from " & tbluser & " where username='" & txtUsername.Text & "' and password='" & txtPassword.Text & "'"
        If myConn.State = ConnectionState.Closed Then
            myConn.Open()
        End If
        If myCommand Is Nothing Then
            myCommand = New MySqlCommand(sql, myConn)
        Else
            myCommand.CommandText = sql
        End If
        myDataReader = myCommand.ExecuteReader
        If myDataReader.HasRows Then
            myDataReader.Close()
            pengguna = txtUsername.Text
            ppassword = txtPassword.Text

            'memanggil formUtama
            setFormUtama()

            'FormUtama.lblInfoUser.Text = "Informasi - (User: " & pengguna & ")"
            'FormUtama.lblTgl.Text = "Tangggal : " & Now.Day & " - " & Now.Month & " - " & Now.Year
            'FormUtama.RefreshGrid()
            'FormUtama.HitungJumlah()
            'FormUtama.Show()
            'Me.Hide()
            'Me.Text = "Login berhasil"



        Else
            MsgBox("Username / Password salah!")
        End If

        If myDataReader.IsClosed = False Then
            myDataReader.Close()
        End If
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateConnection()
    End Sub

    Private Sub LoginForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Return Then
            btnLogin.PerformClick()

        End If
    End Sub

    Private Function setFormUtama()
        FormUtama.lblInfoUser.Text = "Informasi - (User: " & pengguna & ")"
        FormUtama.lblTgl.Text = "Tangggal : " & Now.Day & " - " & Now.Month & " - " & Now.Year
        FormUtama.RefreshGrid()
        FormUtama.HitungJumlah()
        FormUtama.Show()
        Me.Hide()
    End Function
End Class
