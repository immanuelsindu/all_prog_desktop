Imports MySql.Data.MySqlClient
Public Class UbahProfilForm
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtPassword.Text = txtRetype.Text Then
            Dim sql As String = "update users set password='" & txtPassword.Text & "' where username='" & pengguna & "'"
            If myConn.State = ConnectionState.Closed Then
                myConn.Open()
            End If
            If myCommand Is Nothing Then
                myCommand = New MySqlCommand(sql, myConn)
            Else
                myCommand.CommandText = sql
            End If
            If myCommand.ExecuteNonQuery = 1 Then
                MsgBox("Password berhasil diganti, silahkan login ulang!")
                LoginForm.txtPassword.Clear()
                LoginForm.txtUsername.Clear()
                Me.Close()
                LoginForm.Close()
                LoginForm.txtUsername.Focus()
                LoginForm.ShowDialog()
            End If
        ElseIf txtRetype.Text <> "" Then
            MsgBox("Password tidak sama!")
        End If
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub UbahProfilForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Text = pengguna
        txtPassword.Text = ppassword
    End Sub

    Private Sub UbahProfilForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Return Then
            btnSave.PerformClick()
        End If
    End Sub
End Class