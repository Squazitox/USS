Imports CapaDatos
Imports CapaEntidad
Public Class CpNegocio
    Property objDatos As New CpDatos

    Public Function Neg_Login(obj As CpEntidad) As DataTable
        Return objDatos.Login(obj)

    End Function


    Public Function Neg_ListarPro() As DataTable
        Return objDatos.ListarProductos()

    End Function

    Public Function Neg_ListarProve() As DataTable
        Return objDatos.ListarProveedor()

    End Function

    Public Function Neg_ListarPais() As DataTable
        Return objDatos.ListarPais()

    End Function

    Public Function Neg_ListarUbicacion() As DataTable
        Return objDatos.ListarUbicacion()

    End Function

    Public Function Neg_RegistrarSuministra(obj As CpEntidad) As Integer

        Return objDatos.registrarSuministra(obj)
    End Function

    Public Function Neg_ListarTrabajador() As DataTable
        Return objDatos.ListarTrabajador()

    End Function

    Public Function Neg_ListarAreaDestino() As DataTable
        Return objDatos.ListarArea()

    End Function

    Public Function Neg_ListarProductosSuministro() As DataTable
        Return objDatos.ListarProductosSuministro()

    End Function

    Public Function Neg_RegistrarDespacha(objd As CpEntidadDespacha) As Integer
        Return objDatos.registrarDespacha(objd)
    End Function

End Class
