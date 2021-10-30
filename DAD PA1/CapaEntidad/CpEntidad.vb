Public Class CpEntidad

    ' logeo 
    Public Property Usuario As String
	Public Property Password As String

	Public Property TipoUsuario As String

	' suministra
	Public Property idSuministra As String
	Public Property idProveedor As String
	Public Property idProducto As String
	Public Property idUbicacion As String
	Public Property lote As String
	Public Property cantidad As Integer
	Public Property numFactura As String
	Public Property paisOrigen As String
	Public Property precio_compra As Double
	Public Property caducidad As DateTime

	'Referencias para el reporte
	Public Property descripcion As String
	Public Property Total As Double
	Public Property FechaCreacion As DateTime

End Class
