Imports CapaDatos
Imports CapaEntidad
Public Class CpNegocio
    Property objDatos As New CpDatos

    Public Function Neg_Login(obj As CpEntidad) As DataTable
        Return objDatos.Login(obj)

    End Function

End Class
