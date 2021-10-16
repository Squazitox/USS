Imports CapaDatos
Imports CapaEntidad
Public Class CpNegocio
    Property objDatos As New CpDatos

    Public Function Neg_ListPais() As DataTable
        Return objDatos.PaisList
    End Function

    'Public Sub Neg_ListPais(EntCliente As CpEntidad)
    '    objDatos.D_ListPais(EntCliente)

    'End Sub
End Class
