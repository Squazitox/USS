Imports System.Data.SqlClient
Imports CapaDatos.CpDatos
Public Class ProxVencerDAO
    Inherits ConnectionSQL

    Public Function GetBestSellingVencimiento(fromDate As DateTime, toDate As DateTime) As DataTable
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "select 
                                        s.IdSuministra,
                                        p.descripcion as[Nombre_Producto],
                                        s.caducidad as[Fecha_Caducidad],
                                        pr.razonSocial as[Proveedor],
                                        s.lote,
                                        u.seccion as[Ubicación]
                                        from 
                                        tbSuministra s 
                                        inner join tbProducto p on p.idProducto = s.idProducto 
                                        inner join tbProveedor pr on pr.idProveedor = s.idProveedor
                                        inner join tbUbicacion u on u.idUbicacion = s.idUbicacion
                                        where s.caducidad between @starDate and @endDate
                                        order by s.caducidad desc "

                command.Parameters.Add("@starDate", SqlDbType.Date).Value = fromDate
                command.Parameters.Add("@endDate", SqlDbType.Date).Value = toDate
                command.CommandType = CommandType.Text
                Dim reader = command.ExecuteReader()
                Dim table = New DataTable()
                table.Load(reader)
                reader.Dispose()
                Return table

            End Using
        End Using
    End Function
End Class
