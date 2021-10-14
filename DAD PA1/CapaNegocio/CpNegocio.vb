Imports CapaDatos
Imports CapaEntidad
Public Class CpNegocio
    Property objDatos As New CpDatos

    Public Function Neg_Login() As DataTable
        Return objDatos.Login
    End Function

    Public Sub Neg_LoginUser(EntCliente As CpEntidad)
        objDatos.LoginUser(EntCliente)

    End Sub
End Class
