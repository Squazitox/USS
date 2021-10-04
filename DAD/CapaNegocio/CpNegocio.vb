Imports CapaDatos
Imports CapaEntidad
Public Class CpNegocio
    Property objDatos As New CpDatos

    Public Function Neg_ClientList() As DataTable
        Return objDatos.ClientList
    End Function

End Class
