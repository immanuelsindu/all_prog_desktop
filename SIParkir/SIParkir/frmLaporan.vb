﻿
Imports MySql.Data.MySqlClient

Imports Microsoft.Reporting.WinFormsPublic
Class frmLaporan
    Private Sub frmLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        FormUtama.Show()
        Me.Hide()
    End Sub

    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        Dim ds As New DataSet1
        Dim myAdapter As New MySqlDataAdapter
        If myConn.State = ConnectionState.Closed Then
            myConn.Open()
        End If
        myAdapter.SelectCommand = New MySqlCommand("SELECT * FROM tblparkir", myConn)
        myAdapter.Fill(ds.Tables(0))
        ReportViewer1.Reset()
        ReportViewer1.ProcessingMode =
        Microsoft.Reporting.WinForms.ProcessingMode.Local
        ReportViewer1.LocalReport.ReportPath = "Report1.rdlc"
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(0)))
        ReportViewer1.DocumentMapCollapsed = True
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class