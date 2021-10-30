Imports CapaEntidad
Imports CapaNegocio
Imports System.IO

Public Class FormIngreso
    Dim objEntidad As New CpEntidad

    Dim objNegocio As New CpNegocio

    Dim dt As DataTable


    Private Sub FormIngreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgproductos.Columns.Add("idProducto", "idProducto")
        dgproductos.Columns.Add("cantidad", "Cantidad de Ingreso")
        dgproductos.Columns.Add("valor", "Valor de Producto")
        dgproductos.Columns.Add("lote", "Lote")
        dgproductos.Columns.Add("fv", "F.V")
        dgproductos.Columns.Add("proveedor", "Proveedor")
        dgproductos.Columns.Add("factura", "Nº de Factura")
        dgproductos.Columns.Add("origen", "Origen")
        dgproductos.Columns.Add("Ubicacion", "Ubicacion")
        dgproductos.Columns.Add("fc", "Creado el")


        'Mostrara datos en cbprodcuto

        dt = objNegocio.Neg_ListarPro

        cbcodproducto.DataSource = objNegocio.Neg_ListarPro
        cbcodproducto.ValueMember = "idProducto"
        cbcodproducto.DisplayMember = "descripcion"

        'Mostrara datos en cbproveedor

        dt = objNegocio.Neg_ListarProve

        cbproveedor.DataSource = objNegocio.Neg_ListarProve
        cbproveedor.ValueMember = "idProveedor"
        cbproveedor.DisplayMember = "razonSocial"

        'Mostrara datos en cbpais

        dt = objNegocio.Neg_ListarPais

        cbpais.DataSource = objNegocio.Neg_ListarPais
        cbpais.ValueMember = "idPais"
        cbpais.DisplayMember = "pais"


        'Mostrara datos en cbUbicacion

        dt = objNegocio.Neg_ListarUbicacion

        cbubicacion.DataSource = objNegocio.Neg_ListarUbicacion
        cbubicacion.ValueMember = "idUbicacion"
        cbubicacion.DisplayMember = "seccion"



    End Sub

    Private Sub BIngresoIngresar_Click(sender As Object, e As EventArgs) Handles BIngresoIngresar.Click

        dgproductos.Rows.Add(cbcodproducto.SelectedValue, TBIngresoCantidad.Text, TBIngresoValor.Text, TBIngresoLote.Text, DTPIngreso.Value, cbproveedor.SelectedValue, TBIngresoFactura.Text, cbpais.SelectedValue, cbubicacion.SelectedValue, DTCreacion.Value)
        cbcodproducto.Text = ""
        TBIngresoLote.Text = ""
        TBIngresoValor.Text = ""
        TBIngresoCantidad.Text = ""
        cbproveedor.Text = ""
        TBIngresoFactura.Text = ""
        cbpais.Text = ""
        cbproveedor.Text = ""





    End Sub
    Public row As Integer
    Private Sub DGVIngreso_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgproductos.CellClick
        row = 0
        row = dgproductos.CurrentCell.RowIndex.ToString()
    End Sub

    Private Sub BIngresoEliminar_Click(sender As Object, e As EventArgs) Handles BIngresoEliminar.Click
        dgproductos.Rows.RemoveAt(row)

    End Sub

    Private Sub BIngresoCancelar_Click(sender As Object, e As EventArgs) Handles BIngresoCancelar.Click
        dgproductos.Rows.Clear()
    End Sub
    Private Sub BIngresoExportar_Click(sender As Object, e As EventArgs) Handles BIngresoExportar.Click
        ExportarExcel(dgproductos)
    End Sub

    Private Sub TBIngresoLote_TextChanged(sender As Object, e As EventArgs) Handles TBIngresoLote.TextChanged

    End Sub

    Private Sub BIngresoGuardar_Click(sender As Object, e As EventArgs) Handles BIngresoGuardar.Click
        Dim verificacion As Integer
        verificacion = -1

        Dim fila As DataGridViewRow = New DataGridViewRow()

        Try
            For Each fila In dgproductos.Rows

                objEntidad.idProveedor = Convert.ToString(fila.Cells("proveedor").Value)
                objEntidad.idProducto = Convert.ToString(fila.Cells("idProducto").Value)
                objEntidad.lote = Convert.ToString(fila.Cells("lote").Value)
                objEntidad.cantidad = Convert.ToInt32(fila.Cells("cantidad").Value)
                objEntidad.numFactura = Convert.ToString(fila.Cells("factura").Value)
                objEntidad.paisOrigen = Convert.ToString(fila.Cells("origen").Value)
                objEntidad.precio_compra = Convert.ToDouble(fila.Cells("valor").Value)
                objEntidad.caducidad = Convert.ToDateTime(fila.Cells("fv").Value)
                objEntidad.FechaCreacion = Convert.ToDateTime(fila.Cells("fc").Value)
                objEntidad.idUbicacion = Convert.ToString(fila.Cells("Ubicacion").Value)

                verificacion = objNegocio.Neg_RegistrarSuministra(objEntidad)

            Next
        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

        If verificacion <> -1 Then

            MessageBox.Show("Se agrego correctamente todos los registros")

        Else
            MessageBox.Show("Error de Ingreso")

        End If
        dgproductos.Rows.Clear()

    End Sub

    Private Sub DTPIngreso_ValueChanged(sender As Object, e As EventArgs) Handles DTPIngreso.ValueChanged

    End Sub

    Private Sub dgproductos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgproductos.CellContentClick

    End Sub

    Private Sub cbcodproducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbcodproducto.SelectedIndexChanged

    End Sub

    Private Sub DTCreacion_ValueChanged(sender As Object, e As EventArgs) Handles DTCreacion.ValueChanged

    End Sub
End Class