Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports CapaEntidad
Public Class CpDatos
    Private conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("AppUSS").ConnectionString)

    'Para ver los clientes
    Public Function ClientList() As DataTable
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("sp_ListarClientes", conexion)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.Fill(dt)
        Return dt

    End Function
End Class
