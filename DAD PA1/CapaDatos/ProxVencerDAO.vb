Imports System.Data.SqlClient
Imports CapaDatos.CpDatos
Public Class ProxVencerDAO
    Inherits ConnectionSQL

    Public Function GetBestSellingVencimiento(fromDate As DateTime, toDate As DateTime) As DataTable
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "SP_ProductoVencimientoSuministro"

                command.Parameters.AddWithValue("@starDate", fromDate)
                command.Parameters.AddWithValue("@endDate", toDate)
                command.CommandType = CommandType.StoredProcedure
                Dim reader = command.ExecuteReader()
                Dim table = New DataTable()
                table.Load(reader)
                reader.Dispose()
                Return table

            End Using
        End Using
    End Function
End Class
