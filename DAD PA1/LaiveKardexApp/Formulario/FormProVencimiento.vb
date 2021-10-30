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

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim fromDate = DateTime.Today.AddDays(+7)
        Dim toDate = DateTime.Now
        CargarProductosVencimeinto(fromDate, toDate)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim fromDate = New DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
        Dim toDate = DateTime.Now
        CargarProductosVencimeinto(fromDate, toDate)
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim fromDate = DateTimePickerInicio.Value
        Dim toDate = DateTimePickerFin.Value
        CargarProductosVencimeinto(fromDate, New DateTime(toDate.Year, toDate.Month, toDate.Day, 23, 59, 59))
    End Sub
End Class