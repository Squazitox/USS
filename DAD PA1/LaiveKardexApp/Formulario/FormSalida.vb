Imports CapaEntidad
Imports CapaNegocio
Public Class FormSalida
    'Dim objEntidad As New CpEntidad
    Dim objEntidadDes As New CpEntidadDespacha
    Dim objNegocio As New CpNegocio
    Dim dt As DataTable

    Private Sub FormIngreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVSalida.Columns.Add("producto", "Producto")
        DGVSalida.Columns.Add("cantidad", "Cantidad de Salida")
        DGVSalida.Columns.Add("lote", "Lote")
        DGVSalida.Columns.Add("fv", "F.V")
        DGVSalida.Columns.Add("Ubicacion", "Ubicacion")
        DGVSalida.Columns.Add("destino", "Planta Destino")
        DGVSalida.Columns.Add("Trabajador", "Creado por")
        DGVSalida.Columns.Add("FechaSalida", "Creado el")

        'Formulario Despacha---------------------------------------------------

        'Mostrara datos en cbprodcuto

        dt = objNegocio.Neg_ListarProductosSuministro

        CBSalidaCodigo.DataSource = objNegocio.Neg_ListarProductosSuministro
        CBSalidaCodigo.ValueMember = "idProducto"
        CBSalidaCodigo.DisplayMember = "descripcion"

        'Mostrara datos en cbUbicacion

        'dt = objNegocio.Neg_ListarUbicacion

        'CBSalidaUbicacion.DataSource = objNegocio.Neg_ListarUbicacion
        'CBSalidaUbicacion.ValueMember = "idUbicacion"
        'CBSalidaUbicacion.DisplayMember = "seccion"


        'Mostrara datos en cbTrabajador

        dt = objNegocio.Neg_ListarTrabajador

        CBSalidaTrabajador.DataSource = objNegocio.Neg_ListarTrabajador
        CBSalidaTrabajador.ValueMember = "idTrabajador"
        CBSalidaTrabajador.DisplayMember = "perApellidos"



        'Mostrara datos en cbArea Destino

        dt = objNegocio.Neg_ListarAreaDestino

        CBSalidaArea.DataSource = objNegocio.Neg_ListarAreaDestino
        CBSalidaArea.ValueMember = "idArea"
        CBSalidaArea.DisplayMember = "nombreArea"

    End Sub

    Private Sub BSalidaIngresar_Click(sender As Object, e As EventArgs) Handles BSalidaIngresar.Click
        DGVSalida.Rows.Add(CBSalidaCodigo.Text, TBSalidaCantidad.Text, CBSalidaLote.Text, DTPSalida.Value, CBSalidaUbicacion.Text, CBSalidaArea.Text, CBSalidaTrabajador.Text, DTCreacion.Value)
        CBSalidaCodigo.Text = ""
        CBSalidaLote.Text = ""
        CBSalidaUbicacion.Text = ""
        TBSalidaCantidad.Text = ""
        CBSalidaArea.Text = ""
        CBSalidaTrabajador.Text = ""


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
        DGVSalida.Rows.Clear()

    End Sub
    Private Sub BIngresoExportar_Click(sender As Object, e As EventArgs) 
        ExportarExcel(DGVSalida)
    End Sub

    Private Sub BSalidaGuardar_Click(sender As Object, e As EventArgs) Handles BSalidaGuardar.Click
        Dim verificar As Integer
        verificar = -1

        Dim fila As DataGridViewRow = New DataGridViewRow()

        Try
            For Each fila In DGVSalida.Rows

                objEntidadDes.idProducto = Convert.ToString(fila.Cells("Producto").Value)
                objEntidadDes.cantidad = Convert.ToDouble(fila.Cells("cantidad").Value)
                objEntidadDes.lote = Convert.ToString(fila.Cells("lote").Value)
                objEntidadDes.caducidad = Convert.ToDateTime(fila.Cells("fv").Value)
                objEntidadDes.idUbicacion = Convert.ToString(fila.Cells("Ubicacion").Value)
                objEntidadDes.idArea = Convert.ToString(fila.Cells("destino").Value)
                objEntidadDes.idTrabajador = Convert.ToString(fila.Cells("Trabajador").Value)
                objEntidadDes.fechaCreacion = Convert.ToDateTime(fila.Cells("FechaSalida").Value)

                verificar = objNegocio.Neg_RegistrarDespacha(objEntidadDes)

                MessageBox.Show(Convert.ToString(fila.Cells("Producto").Value))

            Next
        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

        If verificar <> -1 Then

            MessageBox.Show("Se agrego correctamente todos los registros")

        Else
            MessageBox.Show("Error de Ingreso")

        End If
        DGVSalida.Rows.Clear()
    End Sub

    Private Sub CBSalidaCodigo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBSalidaCodigo.SelectedIndexChanged


        CBSalidaUbicacion.DataSource = objNegocio.Neg_ListarUbicacion1(CBSalidaCodigo.Text)

        CBSalidaUbicacion.ValueMember = "idUbicacion"
        CBSalidaUbicacion.DisplayMember = "seccion"






    End Sub

    Private Sub CBSalidaUbicacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBSalidaUbicacion.SelectedIndexChanged


        CBSalidaLote.DataSource = objNegocio.Neg_ListarLote(CBSalidaCodigo.Text, CBSalidaUbicacion.Text)
        CBSalidaLote.ValueMember = "lote"
        CBSalidaLote.DisplayMember = "lote"


    End Sub
End Class

