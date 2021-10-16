Public Class FormSalida

    Private Sub FormIngreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVSalida.Columns.Add("codigo", "Código de Producto")
        'DGVIngreso.Columns.Add("descripcion", "Descripción del Producto")
        DGVSalida.Columns.Add("cantidad", "Cantidad de Salida")
        DGVSalida.Columns.Add("lote", "Lote")
        DGVSalida.Columns.Add("fv", "F.V")
        DGVSalida.Columns.Add("planta", "planta Destino")

    End Sub

    Private Sub BSalidaIngresar_Click(sender As Object, e As EventArgs) Handles BSalidaIngresar.Click
        DGVSalida.Rows.Add(TBSalidaCodigo.Text, TBSalidaCantidad.Text, TBSalidaLote.Text, DTPSalida.Value.Date.ToString("dd/MM/yyyy"), TBSalidaProveedor.Text)
        TBSalidaCodigo.Text = ""
        TBSalidaLote.Text = ""
        TBSalidaProveedor.Text = ""
        TBSalidaCantidad.Text = ""

    End Sub
    Public row As Integer
    Private Sub DGVIngreso_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVSalida.CellClick
        row = 0
        row = DGVSalida.CurrentCell.RowIndex.ToString()
    End Sub

    Private Sub BIngresoEliminar_Click(sender As Object, e As EventArgs) Handles BSalidaEliminar.Click
        DGVSalida.Rows.RemoveAt(row)

    End Sub

    Private Sub BIngresoCancelar_Click(sender As Object, e As EventArgs) Handles BSalidaCancelar.Click
        End
    End Sub
    Private Sub BIngresoExportar_Click(sender As Object, e As EventArgs) Handles BSalidaExportar.Click
        ExportarExcel(DGVSalida)
    End Sub
End Class

