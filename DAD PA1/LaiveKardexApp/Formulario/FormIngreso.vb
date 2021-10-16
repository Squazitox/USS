Imports System.IO
Public Class FormIngreso

    Private Sub FormIngreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVIngreso.Columns.Add("codigo", "Código de Producto")
        DGVIngreso.Columns.Add("descripcion", "Descripción del Producto")
        DGVIngreso.Columns.Add("cantidad", "Cantidad de Ingreso")
        DGVIngreso.Columns.Add("valor", "Valor de Producto")
        DGVIngreso.Columns.Add("lote", "Lote")
        DGVIngreso.Columns.Add("fv", "F.V")
        DGVIngreso.Columns.Add("proveedor", "Proveedor")
        DGVIngreso.Columns.Add("factura", "Nº de Factura")
        DGVIngreso.Columns.Add("origen", "Origen")


    End Sub

    Private Sub BIngresoIngresar_Click(sender As Object, e As EventArgs) Handles BIngresoIngresar.Click
        DGVIngreso.Rows.Add(CBIngresoCodigo.Text, TBIngresoDescrip.Text, TBIngresoCantidad.Text, TBIngresoValor.Text, TBIngresoLote.Text, DTPIngreso.Value.Date.ToString("dd/MM/yyyy"), CBIngresoProveedor.Text, TBIngresoFactura.Text, CBIngresoOrigen.Text)
        CBIngresoCodigo.Text = ""
        TBIngresoLote.Text = ""
        TBIngresoValor.Text = ""
        TBIngresoCantidad.Text = ""
        TBIngresoDescrip.Text = ""
        CBIngresoProveedor.Text = ""
        TBIngresoFactura.Text = ""

    End Sub
    Public row As Integer
    Private Sub DGVIngreso_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVIngreso.CellClick
        row = 0
        row = DGVIngreso.CurrentCell.RowIndex.ToString()
    End Sub

    Private Sub BIngresoEliminar_Click(sender As Object, e As EventArgs) Handles BIngresoEliminar.Click
        DGVIngreso.Rows.RemoveAt(row)

    End Sub

    Private Sub BIngresoCancelar_Click(sender As Object, e As EventArgs) Handles BIngresoCancelar.Click
        DGVIngreso.Rows.Clear()
    End Sub
    Private Sub BIngresoExportar_Click(sender As Object, e As EventArgs) Handles BIngresoExportar.Click
        ExportarExcel(DGVIngreso)
    End Sub

    Private Sub TBIngresoLote_TextChanged(sender As Object, e As EventArgs) Handles TBIngresoLote.TextChanged

    End Sub

    Private Sub CBIngresoOrigen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBIngresoOrigen.SelectedIndexChanged



    End Sub
End Class