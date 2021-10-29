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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim fromDate = DateTime.Today.AddDays(+7)
        Dim toDate = DateTime.Now
        CargarProductosVencimeinto(fromDate, toDate)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Dim fromDate = DateTime.Today.AddDays(+30)
        'Dim toDate = DateTime.Now
        'CargarProductosVencimeinto(fromDate, toDate)

        Dim fromDate = New DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
        Dim toDate = DateTime.Now
        CargarProductosVencimeinto(fromDate, toDate)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class