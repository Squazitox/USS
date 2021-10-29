Imports CapaNegocio
Imports System.String
Imports System.Globalization.CultureInfo
Imports CapaEntidad
Imports System.IO

Public Class FormKardex
    Dim objEntidad As New CpEntidad
    Dim objNegocio As New CpNegocio
    Dim dt As DataTable

    Private Sub FormKardex_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dt = objNegocio.Neg_ListarPro

        CBProdKardex.DataSource = objNegocio.Neg_ListarPro
        CBProdKardex.ValueMember = "idProducto"
        CBProdKardex.DisplayMember = "descripcion"

    End Sub

    Private Sub CargaReporteSuministro(DesdeFecha As DateTime, HastaFecha As DateTime, Producto As Object)
        Dim OrdenSuministroModelo = New Reporte()
        OrdenSuministroModelo.GetBestSupplyReport(DesdeFecha, HastaFecha, Producto
                                                  )
        'ReporteBindingSource.DataSource = OrdenSuministroModelo
        ReporteBindingSource.DataSource = OrdenSuministroModelo.ListBestProducts
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReporteSuministro(DesdeFecha As DateTime, HastaFecha As DateTime)
        Dim SuministroModelo = New Reporte()
        SuministroModelo.SupplyReport(DesdeFecha, HastaFecha)
        'ReporteBindingSource.DataSource = OrdenSuministroModelo
        ReporteBindingSource.DataSource = SuministroModelo.ListBestProducts
        Me.ReportViewer1.RefreshReport()
    End Sub


    Private Sub BKardexConsultar_Click(sender As Object, e As EventArgs) Handles BKardexConsultar.Click

        Dim DesdeFecha = DPTKardexFrom.Value
        Dim HastaFecha = DPTKardexTo.Value
        Dim Producto = CBProdKardex.Text

        'Dim desde = New DateTime(DesdeFecha.Year, DesdeFecha.Month, DesdeFecha.Day, 0, 0, 0)
        'Dim hasta = New DateTime(HastaFecha.Year, HastaFecha.Month, HastaFecha.Day, 23, 59, 59)
        If Producto <> "" Then
            CargaReporteSuministro(DesdeFecha, New DateTime(HastaFecha.Year, HastaFecha.Month, HastaFecha.Day, 23, 59, 59), Producto)

        Else

            ReporteSuministro(DesdeFecha, New DateTime(HastaFecha.Year, HastaFecha.Month, HastaFecha.Day, 23, 59, 59))

        End If


        'MessageBox.Show(DesdeFecha)
        'MessageBox.Show(New DateTime(HastaFecha.Year, HastaFecha.Month, HastaFecha.Day, 23, 59, 59))
        'MessageBox.Show(Producto)



    End Sub

    Private Sub CBProdKardex_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBProdKardex.SelectedIndexChanged

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class