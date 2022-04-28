Public Class LaporanPendapatanForm
    Private Sub lblPeriode_Click(sender As Object, e As EventArgs) Handles lblPeriode.Click, lblLaporan.Click

    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Visible = False
        FormUtama.Visible = True
    End Sub
End Class