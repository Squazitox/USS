Imports CapaEntidad
Imports CapaNegocio
Public Class FormAgregar

    Dim objNegocio As New CpNegocio
    Dim objEntidad As New CpEntidad

    Private Sub BTAceptar_Click(sender As Object, e As EventArgs) Handles BTAceptar.Click
        objEntidad.NomCliente = TBNombre.Text
        objEntidad.ApeCliente = TBApellido.Text
        objEntidad.DNICliente = TBDNI.Text
        objEntidad.FechaNacimientoCliente = TBFechadeNacimiento.Text
        If CBGenero.Text = "M" Then
            objEntidad.GeneroCliente = 1
        Else
            objEntidad.GeneroCliente = 2
        End If
        objEntidad.RUCCliente = TBRUC.Text
        objEntidad.EstCliente = 1
        objEntidad.TipoCliente = 1

        objNegocio.Neg_ClientList(objEntidad)
        MessageBox.Show("Correcto")

    End Sub
End Class