Imports CapaNegocio
Public Class FormProVencimiento
    Private Sub FormProVencimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub CargarProductosVencimeinto(startDate As DateTime, endDate As DateTime)
        Dim ProductosVencimientoModelo = New ReporVencimiento()
        ProductosVencimientoModelo.ProductosProximosVencimeinto(startDate, endDate)
        ReporVencimientoBindingSource.DataSource = ProductosVencimientoModelo
        ProductosVencimientoBindingSource.DataSource = ProductosVencimientoModelo.ListaProVencer
        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fromDate = DateTime.Today
        Dim toDate = DateTime.Now
        CargarProductosVencimeinto(fromDate, toDate)


    End Sub
End Class