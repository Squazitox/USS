Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports CapaEntidad
Public Class CpDatos
    Private conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("AppLaive").ConnectionString)

    Public Function ListaPaises() As DataTable

        Dim cmd As New SqlCommand("select pais, from tbPais", conexion)
        conexion.Open()
        cmd.CommandType = CommandType.StoredProcedure
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        conexion.Close()
        Return dt

    End Function



    Public Function Login(obj As CpEntidad) As DataTable

        Dim cmd As New SqlCommand("[SP_Logearse]", conexion)
        conexion.Open()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@usuario", obj.Usuario)
        cmd.Parameters.AddWithValue("@password", obj.Password)
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        conexion.Close()
        Return dt

    End Function

End Class
