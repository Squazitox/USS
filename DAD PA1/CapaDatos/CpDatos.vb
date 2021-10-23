﻿Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports CapaEntidad
Public Class CpDatos
    Private conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("AppLaive").ConnectionString)

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

    Public Function ListarProductos() As DataTable
        Dim cmd As New SqlCommand("[sp_ListarProducto]", conexion)
        conexion.Open()
        cmd.CommandType = CommandType.StoredProcedure
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        conexion.Close()
        Return dt

    End Function

    Public Function ListarProveedor() As DataTable
        Dim cmd As New SqlCommand("[sp_ListarProveedor]", conexion)
        conexion.Open()
        cmd.CommandType = CommandType.StoredProcedure
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        conexion.Close()
        Return dt

    End Function

    Public Function ListarPais() As DataTable
        Dim cmd As New SqlCommand("[sp_ListarPais]", conexion)
        conexion.Open()
        cmd.CommandType = CommandType.StoredProcedure
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        conexion.Close()
        Return dt

    End Function
    Public Function ListarUbicacion() As DataTable
        Dim cmd As New SqlCommand("[sp_ListarUbicacion]", conexion)
        conexion.Open()
        cmd.CommandType = CommandType.StoredProcedure
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        conexion.Close()
        Return dt

    End Function


    Public Function registrarSuministra(obj As CpEntidad) As Integer

        Dim cmd As New SqlCommand("[SP_RegistraSuministra]", conexion)
        Dim respuesta As Integer

        Try
            conexion.Open()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@codSuministra", "RS")
            cmd.Parameters.AddWithValue("@codProveedor", obj.idProveedor)
            cmd.Parameters.AddWithValue("@codProducto", obj.idProducto)
            cmd.Parameters.AddWithValue("@idUbicacion", obj.idUbicacion)
            cmd.Parameters.AddWithValue("@lote", obj.lote)
            cmd.Parameters.AddWithValue("@cantidad", obj.cantidad)
            cmd.Parameters.AddWithValue("@numFactura", obj.numFactura)
            cmd.Parameters.AddWithValue("@paisOrigen", obj.paisOrigen)
            cmd.Parameters.AddWithValue("@precio_compra", obj.precio_compra)
            cmd.Parameters.AddWithValue("@caducidad", obj.caducidad)

            respuesta = cmd.ExecuteNonQuery()

            conexion.Close()
        Catch ex As Exception

            Console.WriteLine(ex.Message)

        End Try

        Return respuesta

    End Function


End Class
