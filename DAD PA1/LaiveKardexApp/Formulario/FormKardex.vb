Imports CapaNegocio
Imports System
Imports System.Globalization.CultureInfo

Public Class FormKardex
    Private Sub FormKardex_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub CargaReporteSuministro(startDate As DateTime, endDate As DateTime)
        Dim OrdenSuministroModelo = New Reporte()
        OrdenSuministroModelo.GetBestSupplyReport(startDate, endDate)
        ReporteBindingSource.DataSource = OrdenSuministroModelo
        ReporteBindingSource.DataSource = OrdenSuministroModelo.ListBestProducts
        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub BKardexConsultar_Click(sender As Object, e As EventArgs) Handles BKardexConsultar.Click

        Dim fromDate = DPTKardexFrom.Value
        Dim toDate = DPTKardexTo.Value

        CargaReporteSuministro(fromDate, toDate)
        MessageBox.Show(fromDate)
        'MessageBox.Show(Convert.ToString(Format(toDate, "yyyy-MM-dd")), "Hasta")




    End Sub
End Class