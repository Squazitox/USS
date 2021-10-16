Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports CapaEntidad
Public Class CpDatos
    Private conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("AppLaive").ConnectionString)

    Public Function PaisList() As DataTable

        Dim cmd As New SqlCommand("select pais, from tbPais", conexion)
        conexion.Open()
        cmd.CommandType = CommandType.StoredProcedure
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        conexion.Close()
        Return dt

    End Function

End Class
