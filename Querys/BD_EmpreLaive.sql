

IF DB_ID('BD_EmpreLaive') IS NOT NULL
BEGIN
	USE master
	DROP DATABASE BD_EmpreLaive
END

CREATE DATABASE BD_EmpreLaive

USE BD_EmpreLaive

--TABLA KARDEX 
IF OBJECT_ID('tbKardex') IS NOT NULL
BEGIN
	DROP TABLE tbKardex

END
ELSE
BEGIN
	CREATE TABLE tbKardex(
	idKardex varchar(10) PRIMARY KEY,
	idProducto varchar(10) NOT NULL,
	idSuministra varchar(10) NOT NULL,
	idDespacha varchar(10) NOT NULL,
	descripcion varchar(50) NOT NULL,
	stock int NOT NULL,
	ingresototal float NOT NULL,
	salidatotal float NOT NULL,
	)
END
GO


------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------
--TABLA TURNO
IF OBJECT_ID('tbTurno') IS NOT NULL
BEGIN
	DROP TABLE tbTurno
	--PRINT 'La tabla [tbTurno] fue eliminada'
END
ELSE
BEGIN
--En esta tabla se registran los turnos de los trabajadores Mañana/Tarde/Noche
CREATE TABLE tbTurno(idTurno varchar(10) PRIMARY KEY,
						turno varchar(15) NOT NULL)
		--PRINT 'La tabla [tbTurno] fue creada con exito...!'
END
GO



--TABLA TRABAJADOR
IF OBJECT_ID('tbTrabajador') IS NOT NULL
BEGIN
	DROP TABLE tbTrabajador
END
ELSE
BEGIN
CREATE TABLE tbTrabajador(

idTrabajador varchar(10) NOT NULL PRIMARY KEY, --sera su dni su id
idPersona varchar(10) NOT NULL,
idCargoTrabajador varchar(10) NOT NULL,
idProfesion varchar(10) NOT NULL,
idRoles varchar(10) NOT NULL,
idTurno varchar(10) NOT NULL,
fechaInicio date NOT NULL)
END
GO
------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------

--TABLA SUMINISTRA

IF OBJECT_ID('tbSuministra') IS NOT NULL
BEGIN
	DROP TABLE tbSuministra
END
ELSE
BEGIN
	CREATE TABLE tbSuministra
	(
		idSuministra varchar(10) NOT NULL PRIMARY KEY,
		idProveedor varchar(10) NOT NULL,
		idProducto varchar(10) NOT NULL,
		idUbicacion varchar(10) NOT NULL,
		lote varchar(10) NOT NULL,
		cantidad int NOT NULL,
		numFactura varchar(10) NOT NULL,
		paisOrigen varchar(10) NOT NULL,
		precio_compra float NOT NULL,
		caducidad date NOT NULL,	
		fechaCreacion date NOT NULL
		
	)

END
GO

--TABLA DESPACHA

IF OBJECT_ID('tbDespacha') IS NOT NULL
BEGIN
	DROP TABLE tbDespacha
END
ELSE
BEGIN
	CREATE TABLE tbDespacha
	(
		idDespacha varchar(10) NOT NULL PRIMARY KEY,
		idTrabajador varchar(10) NOT NULL,
		idProducto varchar(10) NOT NULL,
		idUbicacion varchar(10) NOT NULL,
		idArea varchar(10) NOT NULL,
		cantidad int NOT NULL,
		lote varchar(10) NOT NULL,
		caducidad date NOT NULL,	
		fechaCreacion date NOT NULL
	)

END
GO




IF OBJECT_ID('tbPais') IS NOT NULL
BEGIN
	DROP TABLE tbPais
	--PRINT 'La tabla [tbPais] fue eliminada'
END
ELSE
BEGIN
--Esta tabla registra los paises
CREATE TABLE tbPais(idPais varchar(10) NOT NULL PRIMARY KEY,
					pais varchar(25) NOT NULL)
		--PRINT 'La tabla [tbPais] fue creada con exito...!'
END
GO






------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------
--TABLA PROFESION 
IF OBJECT_ID('tbProfesion') IS NOT NULL
BEGIN
	DROP TABLE tbProfesion
	--PRINT 'La tabla [tbProfesion] fue eliminada'
END
ELSE
BEGIN
--Esta tabla registra el grado academico
CREATE TABLE tbProfesion(idProfesion varchar(10) NOT NULL PRIMARY KEY,
							profesion varchar(25) NOT NULL,
							estado bit NOT NULL) --0(En curso) 1(Terminado)
END
GO
------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------


------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------
--TABLA CARGO TRABAJADOR
IF OBJECT_ID('tbCargoTrabajador') IS NOT NULL
BEGIN	
	DROP TABLE tbCargoTrabajador
	
END
ELSE
BEGIN
CREATE TABLE tbCargoTrabajador(idCargoTrabajador varchar(10) NOT NULL PRIMARY KEY,
								cargoTrabajador varchar(25) NOT NULL)
END
GO

--TABLA AREA 
IF OBJECT_ID('tbArea') IS NOT NULL
BEGIN
	DROP TABLE tbArea
END
ELSE
BEGIN
	CREATE TABLE tbArea(idArea varchar(10) NOT NULL PRIMARY KEY,
						nombreArea varchar(25) NOT NULL
	
	)
END
GO


------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------


------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------
--TABLA ROLES
IF OBJECT_ID('tbRoles') IS NOT NULL
BEGIN
	DROP TABLE tbRoles
END
ELSE
BEGIN
	CREATE TABLE tbRoles (
	idRoles varchar(10) NOT NULL PRIMARY KEY,
	NombreRol varchar(30) NOT NULL
	)
END
GO
------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------

------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------
--TABLA PERMISOS
IF OBJECT_ID('tbPermisos') IS NOT NULL
BEGIN
	DROP TABLE tbPermisos
END
ELSE
BEGIN
	CREATE TABLE tbPermisos(
	idPermiso varchar(10) NOT NULL PRIMARY KEY,
	idRoles varchar(10) NOT NULL,
	NombrePermiso varchar(30) NOT NULL

	
	)
END
GO
------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------

IF OBJECT_ID('tbUsuario') IS NOT NULL
BEGIN
	DROP TABLE tbUsuario
END
ELSE
BEGIN
	CREATE TABLE tbUsuario(
	idUsuario varchar(10) NOT NULL PRIMARY KEY,
	NombreUsuario varchar(40) NOT NULL,
	idTipoUsuario varchar(10) NOT NULL,
	--USUARIO IMAGEN
	passwordUsuario varchar(40) NOT NULL,
	idTrabajador varchar(10) NOT NULL,
	estadoUsuario bit NOT NULL,

	
	)
END
GO

------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------


------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------
IF OBJECT_ID('tbTipoUsuario') IS NOT NULL
BEGIN
	DROP TABLE tbTipoUsuario
END
ELSE
BEGIN
	CREATE TABLE tbTipoUsuario(
	idTipoUsuario varchar(10) NOT NULL PRIMARY KEY,
	nombreTipoUsuario varchar(40) NOT NULL,
	descripcionTipoUsuario varchar(50) NOT NULL
	)
END
GO





------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------


--TABLA PERSONA
IF OBJECT_ID('tbPersona') IS NOT NULL
BEGIN
	DROP TABLE tbPersona
END
ELSE
BEGIN
CREATE TABLE tbPersona(
idPersona varchar(10) PRIMARY KEY,
idPais varchar(10) NOT NULL,
perApellidos varchar(50) NOT NULL,
perNombres varchar(50) NOT NULL,
perFechaNac date NOT NULL,
--perFoto
perDni varchar(8) NOT NULL,
perEstado bit NOT NULL,
perTelefono varchar(40) NOT NULL,
perCorreo varchar(40) NULL,
perDireccion varchar(40) NULL,
perSexo bit NOT NULL)

END
GO



--TABLA TIPO PRODUCTO

IF OBJECT_ID('tbTipoProducto') IS NOT NULL
BEGIN
	DROP TABLE tbTipoProducto
	--PRINT 'La tabla [tbTipoProducto] fue eliminada'
END
ELSE
BEGIN
--en esta tabla se registran los diversos tipos de producto
CREATE TABLE tbTipoProducto(idTipoProducto varchar(10) PRIMARY KEY, 
							tipoProducto varchar(25) NOT NULL) 
END
GO

--TABLA UNIDAD DE MEDIDA
IF OBJECT_ID('tbUnidadMedida') IS NOT NULL
BEGIN
	DROP TABLE tbUnidadMedida
	--PRINT 'La tabla [tbUnidadMedida] fue eliminada'
END
ELSE
BEGIN
CREATE TABLE tbUnidadMedida(idUnidadMedida varchar(10) PRIMARY KEY,
							unidadMedida varchar(15) NOT NULL) -- Kilos, Litros, Metros, Centimetros, 
		--PRINT 'La tabla [tbUnidadMedida] fue creada con exito...!'
END
GO
-------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------

--TABLA UBICACION
IF OBJECT_ID('tbUbicacion') IS NOT NULL
BEGIN
	DROP TABLE tbUbicacion
	--PRINT 'La tabla [tbUbicacion] fue eliminada'
END
ELSE
BEGIN
CREATE TABLE tbUbicacion(idUbicacion varchar(10) PRIMARY KEY, --Lugar fisico asignado segun producto
							seccion varchar(25) NOT NULL) 
		--PRINT 'La tabla [tbUbicacion] fue creada con exito...!'
END
GO
-------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------


-------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------
--TABLA PRODUCTO

IF OBJECT_ID('tbProducto') IS NOT NULL
BEGIN
	DROP TABLE tbProducto
END
ELSE
BEGIN
	CREATE TABLE tbProducto(
	idProducto varchar(10) PRIMARY KEY,
	idTipoProducto varchar(10) NOT NULL,
	idUnidadMedida varchar(10) NOT NULL,
	descripcion varchar(350),
	)
END
-------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------



--TABLA PEDIDO PRODUCTO
IF OBJECT_ID('tbPedidoProducto') IS NOT NULL
BEGIN
	DROP TABLE tbPedidoProducto
	--PRINT 'La tabla [tbPedidoProducto] fue eliminada'
END
ELSE
BEGIN
CREATE TABLE tbPedidoProducto(idPedidoProducto varchar(10) PRIMARY KEY,
								idTrabajador varchar(10) NOT NULL,
								idProducto varchar(10) NOT NULL,--OK
								idVendedorProveedor varchar(10) NOT NULL, --OK
								cantidadPedido int NOT NULL,
								estadoPedido bit NOT NULL) -- 0 (En camino), 1 (Recibido)
--PRINT 'La tabla [tbPedidoProducto] fue creada con exito...!'
END
GO
--------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------
--TABLA VENDEDOR PROVEEDOR
IF OBJECT_ID('tbVendedorProveedor') IS NOT NULL
BEGIN
	DROP TABLE tbVendedorProveedor
	--PRINT 'La tabla [tbVendedorProveedor] fue eliminada'
END
ELSE
BEGIN
CREATE TABLE tbVendedorProveedor(idVendedorProveedor varchar(10) PRIMARY KEY, --Numero de documento
									idPais varchar(10) NOT NULL,
									idProveedor varchar(10) NOT NULL,
									idPersona varchar(10) NOT NULL )
		--PRINT 'La tabla [tbVendedorProveedor] fue creada con exito...!'
END
GO
--------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------
--TABLA  PROVEEDOR

--Tablas referentes a proceso de compra
IF OBJECT_ID('tbProveedor') IS NOT NULL
BEGIN
	DROP TABLE tbProveedor
	--PRINT 'La tabla [tbProveedor] fue eliminada'
END
ELSE
BEGIN
CREATE TABLE tbProveedor(idProveedor varchar(10) PRIMARY KEY,
							idPais varchar(10) NOT NULL,
							razonSocial varchar(50) NOT NULL,
							codigoPostal varchar(20) NOT NULL,
							rucProveedor varchar(13) NOT NULL,
							fonoProveedor varchar(12) NOT NULL,--
							emailProveedor varchar(50) NOT NULL,
							direccion varchar(50) NOT NULL)
		--PRINT 'La tabla [tbProveedor] fue creada con exito...!'
END
GO

select * from tbProveedor

------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------
--RELACIONES DE TRABAJADOR
------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------

--RELACION TABLA TRABAJADOR CON LA TABLA CARGO DEL TRABAJADOR
IF OBJECT_ID('FK_tbTrabajador_tbCargoTrabajador') IS NOT NULL
BEGIN
	ALTER TABLE tbTrabajador
	DROP CONSTRAINT FK_tbTrabajador_tbCargoTrabajador
	PRINT 'la relacion FK_tbTrabajador_tbCargoTrabajador fue eliminada'
END
ELSE
BEGIN
	ALTER TABLE tbTrabajador
	ADD CONSTRAINT FK_tbTrabajador_tbCargoTrabajador
	FOREIGN KEY (idCargoTrabajador) REFERENCES tbCargoTrabajador(idCargoTrabajador)
END
GO



IF OBJECT_ID('FK_tbTrabajador_tbPersona') IS NOT NULL
BEGIN
	ALTER TABLE tbTrabajador
	DROP CONSTRAINT FK_tbTrabajador_tbPersona
	PRINT 'la relacion FK_tbTrabajador_tbPersona fue eliminada'
END
ELSE
BEGIN
	ALTER TABLE tbTrabajador
	ADD CONSTRAINT FK_tbTrabajador_tbPersona
	FOREIGN KEY (idPersona) REFERENCES tbPersona(idPersona)
END
GO



--RELACION TABLA TRABAJADOR CON LA TABLA PROFESION
IF OBJECT_ID('FK_tbTrabajador_tbProfesion') IS NOT NULL
BEGIN
	ALTER TABLE tbTrabajador
	DROP CONSTRAINT FK_tbTrabajador_tbProfesion
	PRINT 'la relacion FK_tbTrabajador_tbProfesion fue eliminada'
END
ELSE
BEGIN
	ALTER TABLE tbTrabajador
	ADD CONSTRAINT FK_tbTrabajador_tbProfesion
	FOREIGN KEY (idProfesion)  REFERENCES tbProfesion(idProfesion)
END
GO

--RELACION TABLA TRABAJADOR CON LA TABLA ROLES

IF OBJECT_ID('FK_tbTrabajador_tbRoles') IS NOT NULL
BEGIN
	ALTER TABLE tbTrabajador
	DROP CONSTRAINT FK_tbTrabajador_tbRoles
	PRINT 'la relacion FK_tbTrabajador_tbRoles fue eliminada'
END
ELSE
BEGIN
	ALTER TABLE tbTrabajador
	ADD CONSTRAINT FK_tbTrabajador_tbRoles
	FOREIGN KEY (idRoles) REFERENCES tbRoles(idRoles)
END
GO


------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------


--PERMISOS TABLA PERMISOS
--RELACION TABLA PERMISOS CON LA TABLA ROLES
IF OBJECT_ID('FK_tbPermisos_tbRoles') IS NOT NULL
BEGIN 
	ALTER TABLE tbPermisos
	DROP CONSTRAINT FK_tbPermisos_tbRoles
	PRINT 'la relacion FK_tbPermisos_tbRoles fue eliminada'
END
ELSE
BEGIN
	ALTER TABLE tbPermisos
	ADD CONSTRAINT FK_tbPermisos_tbRoles
	FOREIGN KEY (idRoles) REFERENCES tbRoles (idRoles)
END
GO

--RELACION TABLA USUARIO CON LA TABLA TRABAJADOR

IF OBJECT_ID('FK_tbUsuario_tbTrabajador') IS NOT NULL
BEGIN 
	ALTER TABLE tbUsuario
	DROP CONSTRAINT FK_tbUsuario_tbTrabajador
	PRINT 'la relacion FK_tbUsuario_tbTrabajador fue eliminada'
END
ELSE
BEGIN
	ALTER TABLE tbUsuario
	ADD CONSTRAINT FK_tbUsuario_tbTrabajador
	FOREIGN KEY (idTrabajador) REFERENCES tbTrabajador (idTrabajador)
END
GO


--RELACION TABLA USUARIO CON LA TABLA TIPO USUARIO

IF OBJECT_ID('FK_tbUsuario_tbTipoTrabajador') IS NOT NULL
BEGIN 
	ALTER TABLE tbUsuario
	DROP CONSTRAINT FK_tbUsuario_tbTipoTrabajador
	PRINT 'la relacion FK_tbUsuario_tbTipoTrabajador fue eliminada'
END
ELSE
BEGIN
	ALTER TABLE tbUsuario
	ADD CONSTRAINT FK_tbUsuario_tbTipoTrabajador
	FOREIGN KEY (idTipoUsuario) REFERENCES tbTipoUsuario (idTipoUsuario)
END
GO
------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------

--RELACIONES PROVEEDOR
IF OBJECT_ID('FK_tbProveedor_FK_Pais') IS NOT NULL
BEGIN
	ALTER TABLE tbProveedor
	DROP CONSTRAINT FK_tbProveedor_FK_Pais
	PRINT 'La relacion [FK_tbProveedor_FK_Pais] fue eliminada'
END
ELSE
BEGIN
	ALTER TABLE tbProveedor
	ADD CONSTRAINT FK_tbProveedor_FK_Pais
	FOREIGN KEY(idPais) REFERENCES tbPais(idPais)


END
GO

--RELACIONES PRODUCTO
------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------

--tbUnidadMedida(PK) tbProducto(FK)
IF OBJECT_ID('FK_Producto_tbUnidadMedida') IS NOT NULL
BEGIN
	ALTER TABLE tbProducto
	DROP CONSTRAINT FK_Producto_tbUnidadMedida
	PRINT 'La relacion [FK_Producto_tbUnidadMedida] fue eliminada'
END
ELSE
BEGIN
ALTER TABLE tbProducto
ADD CONSTRAINT FK_Producto_tbUnidadMedida
FOREIGN KEY (idUnidadMedida) REFERENCES tbUnidadMedida(idUnidadMedida)
END
GO

--tbTipoProducto(PK) tbProducto(FK)
IF OBJECT_ID('FK_Producto_tbTipoProducto') IS NOT NULL
BEGIN
	ALTER TABLE tbProducto
	DROP CONSTRAINT FK_Producto_tbTipoProducto
	PRINT 'La relacion [FK_Producto_tbTipoProducto] fue eliminada'
END
ELSE
BEGIN
ALTER TABLE tbProducto
ADD CONSTRAINT FK_Producto_tbTipoProducto
FOREIGN KEY (idTipoProducto) REFERENCES tbTipoProducto(idTipoProducto)
END
GO
--NUEVAS FK MANUEL VM

--tbUbicacion(PK) tbDespachaFK)
IF OBJECT_ID('FK_Despacha_tbUbicacion') IS NOT NULL
BEGIN
	ALTER TABLE tbDespacha
	DROP CONSTRAINT FK_Desapcha_tbUbicacion
	PRINT 'La relacion [FK_Despacha_tbUbicacion] fue eliminada'
END
ELSE
BEGIN
ALTER TABLE tbDespacha
ADD CONSTRAINT FK_Despacha_tbUbicacion
FOREIGN KEY (idUbicacion) REFERENCES tbUbicacion(idUbicacion)
END
GO

--tbUbicacion(PK) tbSuministraFK)
IF OBJECT_ID('FK_Suministra_tbUbicacion') IS NOT NULL
BEGIN
	ALTER TABLE tbSuministra
	DROP CONSTRAINT FK_Suministra_tbUbicacion
	PRINT 'La relacion [FK_Suministra_tbUbicacion] fue eliminada'
END
ELSE
BEGIN
ALTER TABLE tbSuministra
ADD CONSTRAINT FK_Suministra_tbUbicacion
FOREIGN KEY (idUbicacion) REFERENCES tbUbicacion(idUbicacion)
END
GO

--tbUbicacion(PK) tbProducto(FK)
--IF OBJECT_ID('FK_Producto_tbUbicacion') IS NOT NULL
--BEGIN
--	ALTER TABLE tbProducto
--	DROP CONSTRAINT FK_Producto_tbUbicacion
--	PRINT 'La relacion [FK_Producto_tbUbicacion] fue eliminada'
--END
--ELSE
--BEGIN
--ALTER TABLE tbProducto
--ADD CONSTRAINT FK_Producto_tbUbicacion
--FOREIGN KEY (idUbicacion) REFERENCES tbUbicacion(idUbicacion)
--END
--GO


--tbProducto(PK) tbPedidoProducto(FK)
IF OBJECT_ID('FK_PedidoProducto_tbProducto') IS NOT NULL
BEGIN
	ALTER TABLE tbPedidoProducto
	DROP CONSTRAINT FK_PedidoProducto_tbProducto
	PRINT 'La relacion [FK_PedidoProducto_tbTrabajador] fue eliminada'
END
ELSE
BEGIN
ALTER TABLE tbPedidoProducto
ADD CONSTRAINT FK_PedidoProducto_tbProducto
FOREIGN KEY (idProducto) REFERENCES tbProducto(idProducto)
END
GO

--tbVendedorProveedor(PK) tbPedidoProducto(FK)
IF OBJECT_ID('FK_PedidoProducto_tbVendedorProveedor') IS NOT NULL
BEGIN
	ALTER TABLE tbPedidoProducto
	DROP CONSTRAINT FK_PedidoProducto_tbVendedorProveedor
	PRINT 'La relacion [FK_PedidoProducto_tbVendedorProveedor] fue eliminada'
END
ELSE
BEGIN
	ALTER TABLE tbPedidoProducto
	ADD CONSTRAINT FK_PedidoProducto_tbVendedorProveedor
	FOREIGN KEY (idVendedorProveedor) REFERENCES tbVendedorProveedor(idVendedorProveedor)
END
GO

--idTrabajador
IF OBJECT_ID('FK_PedidoProducto_tbTrabajador') IS NOT NULL
BEGIN
	ALTER TABLE tbPedidoProducto
	DROP CONSTRAINT FK_PedidoProducto_tbTrabajador
	PRINT 'La relacion [FK_PedidoProducto_tbTrabajador] fue eliminada'
END
ELSE
BEGIN
	ALTER TABLE tbPedidoProducto
	ADD CONSTRAINT FK_PedidoProducto_tbTrabajador
	FOREIGN KEY (idTrabajador) REFERENCES tbTrabajador(idTrabajador)
END
GO

--tbProveedor(PK) tbVendedorProveedor(FK)
IF OBJECT_ID('FK_tbVendedorProveedor_tbProveedor') IS NOT NULL
BEGIN
	ALTER TABLE tbVendedorProveedor
	DROP CONSTRAINT FK_tbVendedorProveedor_tbProveedor
	PRINT 'La relacion [FK_tbVendedorProveedor_tbProveedor] fue eliminada'
END
ELSE
BEGIN
	ALTER TABLE tbVendedorProveedor
	ADD CONSTRAINT FK_tbVendedorProveedor_tbProveedor
	FOREIGN KEY (idProveedor) REFERENCES tbProveedor(idProveedor)
END
GO




IF OBJECT_ID('FK_tbSuministra_FK_Pais') IS NOT NULL
BEGIN
	ALTER TABLE tbSuministra
	DROP CONSTRAINT FK_tbSuministra_FK_Pais
	PRINT 'La relacion [FK_tbSuministra_FK_Pais] fue eliminada'
END
ELSE
BEGIN
	ALTER TABLE tbSuministra
	ADD CONSTRAINT FK_tbSuministra_FK_Pais
	FOREIGN KEY(paisOrigen) REFERENCES tbPais(idPais)


END
GO


IF OBJECT_ID('FK_tbPersona_FK_Pais') IS NOT NULL
BEGIN
	ALTER TABLE tbPersona
	DROP CONSTRAINT FK_tbPersona_FK_Pais
	PRINT 'La relacion [FK_tbPersona_FK_Pais] fue eliminada'
END
ELSE
BEGIN
	ALTER TABLE tbPersona
	ADD CONSTRAINT FK_tbPersona_FK_Pais
	FOREIGN KEY(idPais) REFERENCES tbPais(idPais)
END
GO






IF OBJECT_ID('FK_tbSuministra_FK_Producto') IS NOT NULL
BEGIN
	ALTER TABLE tbSuministra
	DROP CONSTRAINT FK_tbSuministra_FK_Producto
	PRINT 'La relacion [FK_tbSuministra_FK_Producto] fue eliminada'
END
BEGIN
	ALTER TABLE tbSuministra
	ADD CONSTRAINT FK_tbSuministra_FK_Producto
	FOREIGN KEY(idProducto) REFERENCES tbProducto(idProducto)
END
GO


IF OBJECT_ID('FK_tbSuministra_FK_Proveedor') IS NOT NULL
BEGIN
	ALTER TABLE tbSuministra
	DROP CONSTRAINT FK_tbSuministra_FK_Proveedor
	PRINT 'La relacion [FK_tbSuministra_FK_Proveedor] fue eliminada'
END
BEGIN
	ALTER TABLE tbSuministra
	ADD CONSTRAINT FK_tbSuministra_FK_Proveedor
	FOREIGN KEY(idProveedor) REFERENCES tbProveedor(idProveedor)
END
GO


IF OBJECT_ID('FK_tbDespacha_FK_tbArea') IS NOT NULL
BEGIN
	ALTER TABLE tbDespacha
	DROP CONSTRAINT FK_tbDespacha_FK_tbArea
	PRINT 'La relacion [FK_tbDespacha_FK_tbArea] fue eliminada'
END
ELSE
BEGIN
	ALTER TABLE tbDespacha
	ADD CONSTRAINT FK_tbDespacha_FK_tbArea
	FOREIGN KEY(idArea) REFERENCES tbArea(idArea)
END
GO


IF OBJECT_ID('FK_tbDespacha_FK_tbProducto') IS NOT NULL
BEGIN
	ALTER TABLE tbDespacha
	DROP CONSTRAINT FK_tbDespacha_FK_tbProducto
	PRINT 'La relacion [FK_tbDespacha_FK_tbProducto] fue eliminada'
END
ELSE
BEGIN
	ALTER TABLE tbDespacha
	ADD CONSTRAINT FK_tbDespacha_FK_tbProducto
	FOREIGN KEY(idProducto) REFERENCES tbProducto(idProducto)
END
GO


IF OBJECT_ID('FK_tbDespacha_FK_tbTrabajador') IS NOT NULL
BEGIN
	ALTER TABLE tbDespacha
	DROP CONSTRAINT FK_tbDespacha_FK_tbTrabajador
	PRINT 'La relacion [FK_tbDespacha_FK_tbTrabajador] fue eliminada'
END
ELSE
BEGIN
	ALTER TABLE tbDespacha
	ADD CONSTRAINT FK_tbDespacha_FK_tbTrabajador
	FOREIGN KEY(idTrabajador) REFERENCES tbTrabajador(idTrabajador)
END
GO



IF OBJECT_ID('FK_tbKardex_tbProducto') IS NOT NULL
BEGIN
	ALTER TABLE tbKardex
	DROP CONSTRAINT FK_tbKardex_tbProducto
END
ELSE
BEGIN
	ALTER TABLE tbKardex
	ADD CONSTRAINT FK_tbKardex_tbProducto
	FOREIGN KEY(idProducto) REFERENCES tbProducto(idProducto)
END
GO

IF OBJECT_ID('FK_tbKardex_tbSuministra') IS NOT NULL
BEGIN
	ALTER TABLE tbKardex
	DROP CONSTRAINT FK_tbKardex_tbSuministra
END
ELSE
BEGIN
	ALTER TABLE tbKardex
	ADD CONSTRAINT FK_tbKardex_tbSuministra
	FOREIGN KEY(idSuministra) REFERENCES tbSuministra(idSuministra)

END
GO


IF OBJECT_ID('FK_tbKardex_tbDespacha') IS NOT NULL
BEGIN
	ALTER TABLE tbKardex
	DROP CONSTRAINT FK_tbKardex_tbDespacha
END
ELSE
BEGIN
	ALTER TABLE tbKardex
	ADD CONSTRAINT FK_tbKardex_tbDespacha
	FOREIGN KEY(idDespacha) REFERENCES tbDespacha(idDespacha)

END
GO

--tbTurno(PK)  tbTrabajador(FK)
IF OBJECT_ID('FK_tbTrabajador_tbTurno') IS NOT NULL
BEGIN
	ALTER TABLE tbTrabajador
	DROP CONSTRAINT FK_tbTrabajador_tbTurno
	PRINT 'La relacion [FK_tbTrabajador_tbTurno] fue eliminada'
END
ELSE
BEGIN
	ALTER TABLE tbTrabajador
	ADD CONSTRAINT FK_tbTrabajador_tbTurno
	FOREIGN KEY (idTurno) REFERENCES tbTurno(idTurno)
END
GO

--tbProveedor(PK) tbVendedorProveedor(FK)
IF OBJECT_ID('FK_tbVendedorProveedor_tbPersona') IS NOT NULL
BEGIN
	ALTER TABLE tbVendedorProveedor
	DROP CONSTRAINT FK_tbVendedorProveedor_tbPersona
	PRINT 'La relacion [FK_tbVendedorProveedor_tbPersona] fue eliminada'
END
ELSE
BEGIN
	ALTER TABLE tbVendedorProveedor
	ADD CONSTRAINT FK_tbVendedorProveedor_tbPersona
	FOREIGN KEY (idPersona) REFERENCES tbPersona(idPersona)
END
GO



-------------------------------------------------------------------
-------------------------------------------------------------------
-------------------------------------------------------------------
--						PROCEDIMIENTOS



CREATE PROCEDURE SP_RegistraPais
@CodPais varchar(10),
@pais varchar(25) 

AS
	DECLARE @totalReg int
	DECLARE @enlazado varchar(10)
	SELECT @totalReg = COUNT(*) FROM tbPais
	SET @enlazado = @CodPais +CAST(@totalReg AS varchar(6))
	

	IF EXISTS(SELECT *FROM tbPais WHERE tbPais.idPais= @enlazado)
	BEGIN
		PRINT 'Id ya registrado por favor haga modificacion en letras...';
	END
	ELSE
	BEGIN
		INSERT INTO  tbPais VALUES(@enlazado,@pais)
		PRINT 'Los datos  fueron registrados  en la tabla [PAIS] con exito...!'
	END
GO
EXECUTE SP_RegistraPais 'RP','PERÚ'
EXECUTE SP_RegistraPais 'RP','CHILE'
EXECUTE SP_RegistraPais 'RP','ESTADOS UNIDOS'
EXECUTE SP_RegistraPais 'RP','HOLANDA'
EXECUTE SP_RegistraPais 'RP','ALEMANIA'


-------------------------------------------------------------------
-------------------------------------------------------------------
--PROCEDIMIENTO REGISTRAR PROVEEDORES
-------------------------------------------------------------------
-------------------------------------------------------------------

CREATE PROCEDURE SP_RegistraProveedor
@codProveedor varchar(10),
@codPais varchar(10),
@razonSocial varchar(50),
@codigoPostal varchar(20),
@rucProveedor varchar(13),
@fonoProveedor varchar(12),
@emailProveedor varchar(50),
@direccion varchar(50)
AS
	DECLARE @totalReg int
	DECLARE @enlazado varchar(8)
	SELECT @totalReg = COUNT(*) FROM tbProveedor
	SET @enlazado = @codProveedor +CAST(@totalReg AS varchar(6))
	

	IF EXISTS(SELECT *FROM tbProveedor WHERE tbProveedor.idProveedor= @enlazado)
	BEGIN
		PRINT 'Id ya registrado por favor haga modificacion en letras...';
	END
	ELSE
	BEGIN
		INSERT INTO  tbProveedor VALUES(@enlazado,@codPais,@razonSocial,@codigoPostal,@rucProveedor,
		@fonoProveedor,@emailProveedor,@direccion)
		PRINT 'Los datos  fueron registrados  en la tabla [PROVEEDOR] con exito...!'
	END
GO

EXECUTE SP_RegistraProveedor 'PRO','RP0','JCR INGENIERIA INDUSTRIAL','91600','2062154856', '598-25115121', 'INFO@JCR.COM.UY', 'MATEO CORTE 4941 - CP 11400 MONTEVIDEO'
EXECUTE SP_RegistraProveedor 'PRO','RP1','TROX DO BRASIL DIFUSAO DE','69900-000','2012452545', '55-413316-8418', 'OI_CRISTINA@TROXBRASIL.COM.BR', 'RUA CYRO COREIA PEREIRA, 300-CIC'
EXECUTE SP_RegistraProveedor 'PRO','RP2','UNION CARGO INTERNACIONAL','110911','2032565482', '(57) 1 4215832', 'GCOMERCIAL@UNIONCARGO.NET', 'CR 106 23 D-50 P-3 DISTRITO CAPITAL'
EXECUTE SP_RegistraProveedor 'PRO','RP3','UNION SOUTH INTERNATIONAL','33126','524526548', '305 539-1057', 'INFO@JCR.COM.UY', '1948 NW 82ND AVE, DORAL, FL'
EXECUTE SP_RegistraProveedor 'PRO','RP4','COSBERT SA','91600','2545254858', '59825182965', 'LUCIA.GOMEZ@LATAM.INTERFOOD.COM', 'RUTA 8, KM 17.500 EDIFICIO BIOTEC PLAZAX'
EXECUTE SP_RegistraProveedor 'PRO','RP0','VERBEAI INGREDIENTS & PAI','56130','0033299912485', '598-25115121', 'PHILIPPE.LERAV@VINPAI.FR', '6 PARC DACTIVITÉS DE LA FOUÉE'
EXECUTE SP_RegistraProveedor 'PRO','RP1','VISCOFAN CZ S.R.O.','370 03','10266589455', '34 948 198 444', 'LUIS@QUIMSAPERU.COM', 'XFCP+F2 ?ESKÉ BUD?JOVICE, CHEQUIA'
EXECUTE SP_RegistraProveedor 'PRO','RP2','VISCOFAN DO BRASIL SOC. C','69900-000','202565455552', '(11) 5180-7400', 'LUIS@QUIMSAPERU.COM', 'AV. ROQUE PETRONI JUNIERO,  - 1 ANDAR'



-------------------------------------------------------------------
-------------------------------------------------------------------
--PROCEDIMIENTO MOSTRAR AREAS EMPRESA
CREATE PROCEDURE sp_ListarAreaCod
@codArea varchar(10)
AS
	SELECT * FROM tbArea WHERE tbArea.idArea = @codArea

GO

-------------------------------------------------------------------
-------------------------------------------------------------------
--PROCEDIMIENTO MOSTRAR PRODUCTOS

CREATE PROCEDURE sp_ListarProductoCod
@codProducto varchar(10)
AS
	SELECT * FROM tbProducto WHERE tbProducto.idProducto = @codProducto

GO

--PROCEDIMIENTO REGISTRAR DESPACHA
--Agregando Campos nuevos - Manuel VM
CREATE PROCEDURE sp_RegistrarDespacha
@codDespacha varchar(10),
@idTrabajador varchar(10),
@idProducto varchar(10),
@idUbicacion varchar(10),
@idArea varchar(10),
@cantidad int,
@lote varchar(10),
@caducidad date,
@fechaCreacion date

AS
	DECLARE @totalReg int
	DECLARE @enlazado varchar(8)
	SELECT @totalReg = COUNT(*) FROM tbDespacha
	SET @enlazado = @codDespacha +CAST(@totalReg AS varchar(6))

	IF EXISTS(SELECT *FROM tbDespacha WHERE tbDespacha.idDespacha = @enlazado)
	BEGIN
		PRINT 'Id ya registrado por favor haga modificacion en letras...';
	END
	ELSE
	BEGIN
		--Se corrigio las variables - Manuel VM
		INSERT INTO  tbDespacha VALUES(@enlazado,@idTrabajador,@idProducto,@idUbicacion,@idArea,
		@cantidad,@lote,@caducidad, @fechaCreacion)

		--UPDATE tbProducto set tbProducto.stock = tbProducto.stock - @cantidad
		--modificacion de actualizaciones - Manuel VM
		UPDATE tbKardex set tbKardex .stock = tbKardex.stock - @cantidad 
		WHERE tbKardex .idProducto=@idProducto
		
		UPDATE tbKardex set tbKardex .salidatotal = tbKardex.salidatotal + @cantidad 
		WHERE tbKardex .idProducto=@idProducto

		PRINT 'Los datos fueron registrados  en la tabla [DESPACHO] con exito...!'
	END


GO








--PROCEDIMIENTO ACTUALIZAR LA TABLA SUMINISTRO 
--Agregando Campos nuevos - Manuel VM
CREATE PROCEDURE sp_ActualizarSuministra
@codSuministra varchar(10),
@codProveedor varchar(10),
@codProducto varchar(10),
@idUbicacion varchar(10),
@lote varchar(10),
@cantidad int,
@numFactura varchar(10),
@paisOrigen varchar(10),
@precio_compra float,
@caducidad date,
@fechacreacion date
AS
	BEGIN
		--UPDATE tbSuministra 
		--set tbSuministra.cantidad=@cantidad, tbSuministra.idProducto=@codProducto, 
		--tbSuministra.lote=@lote, tbSuministra.idProveedor=@codProveedor, tbSuministra.numFactura= @numFactura,
		--tbSuministra.paisOrigen = @paisOrigen, tbSuministra.precio_compra = @precio_compra
		--WHERE tbSuministra.idSuministra = @codSuministra

		UPDATE tbSuministra 
		set tbSuministra.cantidad=@cantidad, tbSuministra.idProducto=@codProducto, tbSuministra.idUbicacion = @idUbicacion,
		tbSuministra.lote = @lote, tbSuministra.idProveedor=@codProveedor, tbSuministra.numFactura= @numFactura,
		tbSuministra.paisOrigen = @paisOrigen, tbSuministra.precio_compra = @precio_compra, tbSuministra.caducidad = @caducidad, tbSuministra.fechaCreacion = @fechacreacion
		WHERE tbSuministra.idSuministra = @codSuministra

		--UPDATE tbProducto set tbProducto.stock = tbProducto.stock + @cantidad WHERE tbProducto.idProducto=@codProducto
		UPDATE tbKardex set tbKardex.stock = tbKardex.stock + @cantidad WHERE tbKardex.idProducto=@codProducto

		UPDATE tbKardex set tbKardex.ingresototal = tbKardex.ingresototal + @cantidad WHERE tbKardex.idProducto=@codProducto
		
		PRINT 'Los datos fueron ACTUALIZADOS  en la tabla [SUMINISTRA] con exito...!'
	END
	

GO





----------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------
--PROCEDIMIENTO DE REGISTRO DE TIPO DE PRODUCTO
----------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------
--EMBUTIDOS
--LACTEOS
CREATE PROCEDURE sp_RegistrarTipoProducto
@codTipoProducto varchar(10),
@nomTipoProducto varchar(25)
AS
	DECLARE @totalReg int
	DECLARE @enlazado varchar(8)
	SELECT @totalReg = COUNT(*) FROM tbTipoProducto
	SET @enlazado = @codTipoProducto +CAST(@totalReg AS varchar(6))

	IF EXISTS(SELECT *FROM tbTipoProducto WHERE tbTipoProducto.idTipoProducto = @enlazado)
	BEGIN
		PRINT 'Id ya registrado por favor haga modificacion en letras...';
	END
	ELSE
	BEGIN
		INSERT INTO  tbTipoProducto VALUES(@enlazado,@nomTipoProducto)
		PRINT 'Los datos fueron registrados  en la tabla [TIPO PRODUCTO] con exito...!'
	END
	

GO
EXECUTE  sp_RegistrarTipoProducto 'RTP','AZUCARES'
EXECUTE  sp_RegistrarTipoProducto 'RTP','CARNES'
EXECUTE  sp_RegistrarTipoProducto 'RTP','COLORANTES'
EXECUTE  sp_RegistrarTipoProducto 'RTP','CULTIVOS'
EXECUTE  sp_RegistrarTipoProducto 'RTP','GRASAS'
EXECUTE  sp_RegistrarTipoProducto 'RTP','CONCENTRADO'
EXECUTE  sp_RegistrarTipoProducto 'RTP','LECHES'
EXECUTE  sp_RegistrarTipoProducto 'RTP','ESPECIAS'
EXECUTE  sp_RegistrarTipoProducto 'RTP','ESTABILIZANTES'
--------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------
--PROCEDIMIENTO DE REGISTRO DE UBICACION DE PRODCUCTO
----------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------


CREATE PROCEDURE SP_RegistraUbicacionProducto
@Cod varchar(2),
@seccion varchar(25)

AS
	DECLARE @totalReg int
	DECLARE @enlazado varchar(8)
	SELECT @totalReg = COUNT(*) FROM tbUbicacion
	SET @enlazado = @Cod +CAST(@totalReg AS varchar(6))

	IF EXISTS(SELECT *FROM tbUbicacion WHERE idUbicacion = @enlazado)
	BEGIN
		PRINT 'Id ya registrado por favor haga modificacion en letras...';
	END
	ELSE
	BEGIN
		INSERT INTO  tbUbicacion VALUES(@enlazado,@seccion)--pañales,etc
		PRINT 'Los datos fueron registrados con exito...!'
	END
GO
EXECUTE SP_RegistraUbicacionProducto 'POS', 'NIVEL(1,1)'
EXECUTE SP_RegistraUbicacionProducto 'POS', 'NIVEL(1,2)'
EXECUTE SP_RegistraUbicacionProducto 'POS', 'NIVEL(1,3)'
EXECUTE SP_RegistraUbicacionProducto 'POS', 'NIVEL(1,4)'
EXECUTE SP_RegistraUbicacionProducto 'POS', 'NIVEL(2,1)'
EXECUTE SP_RegistraUbicacionProducto 'POS', 'NIVEL(2,2)'
EXECUTE SP_RegistraUbicacionProducto 'POS', 'NIVEL(2,3)'
EXECUTE SP_RegistraUbicacionProducto 'POS', 'NIVEL(2,4)'
EXECUTE SP_RegistraUbicacionProducto 'POS', 'NIVEL(3,1)'
EXECUTE SP_RegistraUbicacionProducto 'POS', 'NIVEL(3,2)'
EXECUTE SP_RegistraUbicacionProducto 'POS', 'NIVEL(4,1)'
EXECUTE SP_RegistraUbicacionProducto 'POS', 'NIVEL(4,2)'
EXECUTE SP_RegistraUbicacionProducto 'POS', 'NIVEL(4,3)'
EXECUTE SP_RegistraUbicacionProducto 'POS', 'NIVEL(4,4)'
EXECUTE SP_RegistraUbicacionProducto 'POS', 'NIVEL(5,1)'
EXECUTE SP_RegistraUbicacionProducto 'POS', 'NIVEL(5,2)'
EXECUTE SP_RegistraUbicacionProducto 'POS', 'NIVEL(5,3)'
EXECUTE SP_RegistraUbicacionProducto 'POS', 'NIVEL(6,4)'
EXECUTE SP_RegistraUbicacionProducto 'POS', 'NIVEL(7,1)'
EXECUTE SP_RegistraUbicacionProducto 'POS', 'NIVEL(8,2)'

--------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------
--PROCEDIMIENTO DE REGISTRO DE UNIDAD DE MEDIDA
----------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------


CREATE PROCEDURE SP_RegistraUnidadMedida
@Cod varchar(2),
@UnidadMdedida varchar (15)

AS
	DECLARE @totalReg int
	DECLARE @enlazado varchar(8)
	SELECT @totalReg = COUNT(*) FROM tbUnidadMedida
	SET @enlazado = @Cod +CAST(@totalReg AS varchar(6))

	IF EXISTS(SELECT *FROM tbUnidadMedida WHERE idUnidadMedida = @enlazado)
	BEGIN
		PRINT 'Id ya registrado por favor haga modificacion en letras...';
	END
	ELSE
	BEGIN
		INSERT INTO  tbUnidadMedida VALUES(@enlazado,@UnidadMdedida)
		PRINT 'Los datos fueron registrados con exito...!'
	END
GO
EXECUTE SP_RegistraUnidadMedida 'UM', 'KILOS'
EXECUTE SP_RegistraUnidadMedida 'UM', 'CAJAS'
EXECUTE SP_RegistraUnidadMedida 'UM', 'SACOS'
EXECUTE SP_RegistraUnidadMedida 'UM', 'PAQUETES'
EXECUTE SP_RegistraUnidadMedida 'UM', 'UNIDADES'
EXECUTE SP_RegistraUnidadMedida 'UM', 'BARRIL'
--------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------



CREATE PROCEDURE SP_RegistraProducto
@codProducto  varchar(10),
@idTipoProducto varchar(10),
--@idUbicacion varchar(10),
@idUnidadMedida varchar(10),
--@nombreProducto varchar(100),
--@precioCompra float,
@descripcion varchar(350)
--@stock int,
--@caducidad date

AS
	

	DECLARE @totalReg int
	DECLARE @enlazado varchar(8)
	SELECT @totalReg = COUNT(*) FROM tbProducto
	SET @enlazado = @codProducto +CAST(@totalReg AS varchar(6))

	IF EXISTS(SELECT *FROM tbProducto WHERE tbProducto.idProducto = @enlazado)
	BEGIN
		PRINT 'Id ya registrado por favor haga modificacion en letras...';
	END
	ELSE
	BEGIN
	--	INSERT INTO tbProducto VALUES(@codProducto,@idTipoProducto, @idUbicacion,@idUnidadMedida,@nombreProducto,@precioCompra,@descripcion,
	--@stock, @caducidad)

		INSERT INTO tbProducto VALUES(@enlazado,@idTipoProducto,@idUnidadMedida,@descripcion)
		PRINT 'Los datos fueron registrados la tabla PRODUCTO con exito...!'
	END
	

GO
SELECT * FROM tbTipoProducto
SELECT * FROM tbProducto
SELECT * FROM tbUnidadMedida

DELETE FROM tbProducto

EXECUTE SP_RegistraProducto 'PRO', 'RTP5', 'UM5', 'CONCENTRADO DE MANZANA'
EXECUTE SP_RegistraProducto 'PRO', 'RTP1', 'UM0', 'RECORTE 60/40 (CRUDOS)'
EXECUTE SP_RegistraProducto 'PRO', 'RTP7', 'UM2', 'SAL DE MINA SIN YODO'
EXECUTE SP_RegistraProducto 'PRO', 'RTP5', 'UM5', 'SABOR NARANJA SC725055'
EXECUTE SP_RegistraProducto 'PRO', 'RTP4', 'UM5', 'ACEITE DE SOYA'
EXECUTE SP_RegistraProducto 'PRO', 'RTP0', 'UM2', 'AZUCAR BLANCA'
EXECUTE SP_RegistraProducto 'PRO', 'RTP5', 'UM5', 'CONCENTRADO DE MANGO'
EXECUTE SP_RegistraProducto 'PRO', 'RTP6', 'UM2', 'LECHE EN POLVO DESCREMADA LH'
EXECUTE SP_RegistraProducto 'PRO', 'RTP6', 'UM2', 'LECHE EN POLVO DESCREMADA MH'
EXECUTE SP_RegistraProducto 'PRO', 'RTP6', 'UM2', 'LECHE ENTERA EN POLVO MH'
EXECUTE SP_RegistraProducto 'PRO', 'RTP7', 'UM2', 'OREGANO MOLIDO'
EXECUTE SP_RegistraProducto 'PRO', 'RTP7', 'UM2', 'PIMIENTA NEGRA ENTERA'
EXECUTE SP_RegistraProducto 'PRO', 'RTP5', 'UM5', 'PULPA DE MORA'
EXECUTE SP_RegistraProducto 'PRO', 'RTP5', 'UM5', 'PULPA DE LUCUMA'
EXECUTE SP_RegistraProducto 'PRO', 'RTP2', 'UM1', 'GELATINA 230 BLOOM'
EXECUTE SP_RegistraProducto 'PRO', 'RTP8', 'UM2', 'ESTABILIZANTE BASE DE HELADO'
EXECUTE SP_RegistraProducto 'PRO', 'RTP2', 'UM5', 'ESENCIA MORA NATURAL'
------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------






select * from tbProfesion

----------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------
--PROCEDIMIENTO REGISTRO DE PROFESION
----------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------
CREATE PROCEDURE SP_RegistraProfesion
@Cod varchar(2),
@Profesion varchar(25),
@estadoProfesion bit
AS
	DECLARE @totalReg int
	DECLARE @enlazado varchar(8)
	SELECT @totalReg = COUNT(*) FROM tbProfesion
	SET @enlazado = @Cod +CAST(@totalReg AS varchar(6))

	IF EXISTS(SELECT *FROM tbProfesion WHERE idProfesion = @enlazado)
	BEGIN
		PRINT 'Id ya registrado por favor haga modificacion en letras...';
	END
	ELSE
	BEGIN
		INSERT INTO  tbProfesion VALUES(@enlazado,@Profesion,@estadoProfesion)-- MEDICO,ENFERMERO
		PRINT 'Los datos fueron registrados con exito...!'
	END
GO

 EXECUTE SP_RegistraProfesion 'RP','INGENIERO INDUSTRIAL','1'
 EXECUTE SP_RegistraProfesion 'RP','NEGOCIOS INTERNACIONALES','1'
 EXECUTE SP_RegistraProfesion 'RP','ADMINISTRADOR DE EMPRESAS','1'
 EXECUTE SP_RegistraProfesion 'RP','TECNICO EN ADMINISTRACION DE EMPRESAS','1'
 EXECUTE SP_RegistraProfesion 'RP','TECNICO EN COMPUTACIÓN','1'
 EXECUTE SP_RegistraProfesion 'RP','INGENIERO SISTEMAS','1'


 ----------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------
--PROCEDIMIENTO DE REGISTRO  SUMINISTRO
----------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------
 CREATE PROCEDURE SP_RegistraSuministra
@codSuministra varchar(10),
@codProveedor varchar(10),
@codProducto varchar(10),
@idUbicacion varchar(10),
@lote varchar(10),
@cantidad int,
@numFactura varchar(10),
@paisOrigen varchar(10),
@precio_compra float,
@caducidad date,
@fechacreacion date

AS
	DECLARE @totalReg int
	DECLARE @enlazado varchar(8)
	SELECT @totalReg = COUNT(*) FROM tbSuministra
	SET @enlazado = @codSuministra +CAST(@totalReg AS varchar(6))

	IF EXISTS(SELECT *FROM tbSuministra WHERE tbSuministra.idSuministra = @enlazado)
	BEGIN
		PRINT 'Id ya registrado por favor haga modificacion en letras...';
	END
	ELSE
	BEGIN
		INSERT INTO  tbSuministra VALUES(@enlazado,@codProveedor, @codProducto, @idUbicacion, @lote, @cantidad, @numFactura, @paisOrigen, @precio_compra,@caducidad, @fechacreacion);

		UPDATE tbKardex
		set tbKardex.stock = tbKardex.stock + @cantidad
		WHERE tbKardex.idProducto = @codProducto

		UPDATE tbKardex
		set tbKardex.ingresototal = tbKardex.ingresototal + @cantidad
		WHERE tbKardex.idProducto = @codProducto

		PRINT 'Los datos fueron registrados  en la tabla [SUMINISTRA] con exito...!'
	END
	

GO
EXECUTE SP_RegistraSuministra 'RS', 'PRO1','RP', '635121', '4', '123456', 'RP4', 25.7, 

------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------
--LOGEARSE


CREATE PROCEDURE SP_Logearse 
@usuario varchar(40),
@password varchar(40)
AS
	BEGIN TRANSACTION 
		BEGIN
			select* from tbUsuario WHERE tbUsuario.NombreUsuario=@usuario AND tbUsuario.passwordUsuario=@password
		END

	COMMIT

GO



select * from tbTipoUsuario
------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------
--REGISTRAR TIPO DE USUARIO
CREATE PROCEDURE SP_RegistrarTipoUsuario
@codIdTipoUsuario varchar(10),
@nombreTipoUsuario varchar(40),
@descripcionTipoUsuario varchar(50)

AS
	DECLARE @totalReg int
	DECLARE @enlazado varchar(10)
	SELECT @totalReg = COUNT(*) FROM tbTipoUsuario
	SET @enlazado = @codIdTipoUsuario +CAST(@totalReg AS varchar(6))
	

	IF EXISTS(SELECT *FROM tbTipoUsuario WHERE tbTipoUsuario.idTipoUsuario= @enlazado)
	BEGIN
		PRINT 'Id ya registrado por favor haga modificacion en letras...';
	END
	ELSE
	BEGIN
		INSERT INTO  tbTipoUsuario VALUES(@enlazado,@nombreTipoUsuario,@descripcionTipoUsuario )
		PRINT 'Los datos  fueron registrados  en la tabla [TIPO USUARIO] con exito...!'
	END
GO

EXECUTE SP_RegistrarTipoUsuario 'USR', 'GERENCIAL','solo reportes'
EXECUTE SP_RegistrarTipoUsuario 'USR', 'ADMINISTRATIVO','control total'
EXECUTE SP_RegistrarTipoUsuario 'USR', 'OPERARIO','solo inventario'
------------------------------------------------------------------------------------------------------
--REGISTRAR PERSONA
------------------------------------------------------------------------------------------------------

CREATE PROCEDURE sp_RegistrarPersona
@codPersona varchar(10),
@idPais varchar(10),
@perApellidos varchar(50),
@perNombres varchar(50),
@perFechaNac date,
@perDni varchar(8),
@perEstado bit,
@perTelefono varchar(40),
@perCorreo varchar(40),
@perDireccion varchar(40),
@perSexo bit
AS
	DECLARE @totalReg int
	DECLARE @enlazado varchar(10)
	SELECT @totalReg = COUNT(*) FROM tbPersona
	SET @enlazado = @codPersona +CAST(@totalReg AS varchar(6))
	

	IF EXISTS(SELECT *FROM tbPersona WHERE tbPersona.idPersona= @enlazado)
	BEGIN
		PRINT 'Id ya registrado por favor haga modificacion en letras...';
	END
	ELSE
	BEGIN
		INSERT INTO  tbPersona VALUES(@enlazado,@idPais,@perApellidos,@perNombres, @perFechaNac,
		@perDni,@perEstado,@perTelefono, @perCorreo,@perDireccion, @perSexo )
		PRINT 'Los datos  fueron registrados  en la tabla [USUARIO] con exito...!'
	END


GO

EXECUTE sp_RegistrarPersona 'PER', 'RP0','HERNA LOJA','BRYAM ALEXANDER','01/05/1997', '1234567', 1, '2625312','BRY@hotmail.com','av. las brisas 123',1
EXECUTE sp_RegistrarPersona 'PER', 'RP0','CHUQUE DÍAZ','ELBIR DILUVID','01/05/1997', '1234567', 1, '2625312','ELB@hotmail.com','av. las brisas 123',1
EXECUTE sp_RegistrarPersona 'PER', 'RP0','VIVANCO MORENO','MANUEL SANTIAGO','01/05/1997', '1234567', 1, '2625312','MAN@hotmail.com','av. las brisas 123',1
EXECUTE sp_RegistrarPersona 'PER', 'RP0','SOTO VALLE','JORGE','01/05/1997', '1234567', 1, '2625312','JOR@hotmail.com','av. las brisas 123',1
EXECUTE sp_RegistrarPersona 'PER', 'RP0','CUBA RUIZ','GUILLERMO','01/05/1997', '1234567', 1, '2625312','GUI@hotmail.com','av. las brisas 123',1




select * from tbUsuario
select * from tbTrabajador
select * from tbPersona
select * from tbTurno

--PROCEDIMIENTO TURNO
CREATE PROCEDURE sp_RegistrarTurno
@codTurno varchar(10),
@turno varchar(15)
AS
	DECLARE @totalReg int
	DECLARE @enlazado varchar(10)
	SELECT @totalReg = COUNT(*) FROM tbTurno
	SET @enlazado = @codTurno +CAST(@totalReg AS varchar(6))
	

	IF EXISTS(SELECT *FROM tbTurno WHERE tbTurno.idTurno= @enlazado)
	BEGIN
		PRINT 'Id ya registrado por favor haga modificacion en letras...';
	END
	ELSE
	BEGIN
		INSERT INTO  tbTurno VALUES(@enlazado,@turno)
		PRINT 'Los datos  fueron registrados  en la tabla [ROLES] con exito...!'
	END


GO
EXECUTE sp_RegistrarTurno 'RT','MAÑANA'
EXECUTE sp_RegistrarTurno 'RT','TARDE'
EXECUTE sp_RegistrarTurno 'RT','NOCHE'


select * from tbRoles


--PROCEDIMIENTO ROLES
CREATE PROCEDURE sp_RegistrarRoles
@codRoles varchar(10),
@nombreRol varchar(30)
AS
	DECLARE @totalReg int
	DECLARE @enlazado varchar(10)
	SELECT @totalReg = COUNT(*) FROM tbRoles
	SET @enlazado = @codRoles +CAST(@totalReg AS varchar(6))
	

	IF EXISTS(SELECT *FROM tbRoles WHERE tbRoles.idRoles= @enlazado)
	BEGIN
		PRINT 'Id ya registrado por favor haga modificacion en letras...';
	END
	ELSE
	BEGIN
		INSERT INTO  tbRoles VALUES(@enlazado,@nombreRol)
		PRINT 'Los datos  fueron registrados  en la tabla [ROLES] con exito...!'
	END

GO
EXECUTE sp_RegistrarRoles 'RR','CONTROL TOTAL'
EXECUTE sp_RegistrarRoles 'RR','REPORTES'
EXECUTE sp_RegistrarRoles 'RR','INVENTARIOS'



select * from tbCargoTrabajador

--PROCEDIMIENTO REGISTRAR CARGO TRABAJADOR
CREATE PROCEDURE sp_RegistrarCargoTrabajador
@codCargoTrabajador varchar(10),
@cargoTrabajador varchar(25)
AS
	DECLARE @totalReg int
	DECLARE @enlazado varchar(10)
	SELECT @totalReg = COUNT(*) FROM tbCargoTrabajador
	SET @enlazado = @codCargoTrabajador +CAST(@totalReg AS varchar(6))
	

	IF EXISTS(SELECT *FROM tbCargoTrabajador WHERE tbCargoTrabajador.idCargoTrabajador= @enlazado)
	BEGIN
		PRINT 'Id ya registrado por favor haga modificacion en letras...';
	END
	ELSE
	BEGIN
		INSERT INTO  tbCargoTrabajador VALUES(@enlazado,@cargoTrabajador)
		PRINT 'Los datos  fueron registrados  en la tabla [CARGO TRABAJADOR] con exito...!'
	END


GO
EXECUTE sp_RegistrarCargoTrabajador 'RCT', 'SUPERVISOR'
EXECUTE sp_RegistrarCargoTrabajador 'RCT', 'KARDISTA'
EXECUTE sp_RegistrarCargoTrabajador 'RCT', 'ENCARGADO'
EXECUTE sp_RegistrarCargoTrabajador 'RCT', 'SUPERINTENDENTE'



select * from tbTrabajador
select * from tbRoles
select * from tbCargoTrabajador

--PROCEDIMIENTO REGISTRAR TRABAJADOR
CREATE PROCEDURE sp_RegistrarTrabajador
@codTrabajador varchar(10),
@idPersona varchar(10),--ya esta
@idCargoTrabajador varchar(10),--ya esta
@idProfesion varchar(10),--ya esta
@idRoles varchar(10),--ya esta
@idTurno varchar(10),--ya esta
@fechaInicio date
AS
	DECLARE @totalReg int
	DECLARE @enlazado varchar(10)
	SELECT @totalReg = COUNT(*) FROM tbTrabajador
	SET @enlazado = @codTrabajador +CAST(@totalReg AS varchar(6))
	

	IF EXISTS(SELECT *FROM tbTrabajador WHERE tbTrabajador.idTrabajador= @enlazado)
	BEGIN
		PRINT 'Id ya registrado por favor haga modificacion en letras...';
	END
	ELSE
	BEGIN
		INSERT INTO  tbTrabajador VALUES(@enlazado,@idPersona,@idCargoTrabajador,@idProfesion, @idRoles, @idTurno, @fechaInicio  )
		PRINT 'Los datos  fueron registrados  en la tabla [TRABAJADOR] con exito...!'
	END


GO

EXECUTE sp_RegistrarTrabajador 'TRA', 'PER0','RCT0','RP5','RR0', 'RT0', '01/05/2017'
EXECUTE sp_RegistrarTrabajador 'TRA', 'PER1','RCT0','RP5','RR0', 'RT0', '01/05/2017'
EXECUTE sp_RegistrarTrabajador 'TRA', 'PER2','RCT0','RP5','RR0', 'RT0', '01/05/2017'
EXECUTE sp_RegistrarTrabajador 'TRA', 'PER3','RCT1','RP2','RR1', 'RT0', '01/05/2017'
EXECUTE sp_RegistrarTrabajador 'TRA', 'PER4','RCT3','RP3','RR2', 'RT2', '01/05/2017'

--REGISTRAR USUARIO
CREATE PROCEDURE SP_RegistrarUsuario
@CodUsuario varchar(10),
@nombreUsuario varchar(40),
@idTipoUsuario varchar(10),
@passwordUsuario varchar(40),
@idTrabajador varchar(10),
@estadoUsuario bit

AS
	DECLARE @totalReg int
	DECLARE @enlazado varchar(10)
	SELECT @totalReg = COUNT(*) FROM tbUsuario
	SET @enlazado = @CodUsuario +CAST(@totalReg AS varchar(6))
	

	IF EXISTS(SELECT *FROM tbUsuario WHERE tbUsuario.idUsuario= @enlazado)
	BEGIN
		PRINT 'Id ya registrado por favor haga modificacion en letras...';
	END
	ELSE
	BEGIN
		INSERT INTO  tbUsuario VALUES(@enlazado,@nombreUsuario,@idTipoUsuario,@passwordUsuario,@idTrabajador, @estadoUsuario)
		PRINT 'Los datos  fueron registrados  en la tabla [USUARIO] con exito...!'
	END
GO

EXECUTE SP_RegistrarUsuario 'RU', 'BLOJA','USR1','123456','TRA0',1
EXECUTE SP_RegistrarUsuario 'RU', 'ECHUQUE','USR1','123456','TRA1',1
EXECUTE SP_RegistrarUsuario 'RU', 'MVIVANCO','USR1','123456','TRA2',1
EXECUTE SP_RegistrarUsuario 'RU', 'JSOTO','USR0','123456','TRA3',1
EXECUTE SP_RegistrarUsuario 'RU', 'GCUBA','USR2','123456','TRA4',1

--LISTA ED PRODUCTOS
--CREATE PROCEDURE sp_ListarProductoCod
--@codProducto varchar(10)
--AS
--	BEGIN TRANSACTION 
--		BEGIN
--			SELECT * FROM tbProducto WHERE tbProducto.idProducto = @codProducto
--		END
--	COMMIT
--GO


CREATE PROCEDURE sp_ListarProductoCod

AS
	BEGIN TRANSACTION 
		BEGIN
			SELECT * FROM tbProducto 
		END
	COMMIT
GO


CREATE PROCEDURE sp_ListarProducto
AS
	BEGIN TRANSACTION
		BEGIN
			SELECT * from tbProducto
		END
	COMMIT
GO



CREATE PROCEDURE sp_ListarProveedor
AS
	BEGIN TRANSACTION
		BEGIN
			SELECT * from tbProveedor
		END
	COMMIT
GO


CREATE PROCEDURE sp_ListarPais

AS
	BEGIN TRANSACTION 
		BEGIN
			SELECT * FROM tbPais 
		END
	COMMIT
GO


CREATE PROCEDURE sp_ListarUbicacion
AS
	BEGIN TRANSACTION
		BEGIN
			SELECT * from tbUbicacion
		END
	COMMIT
GO


create proc IngresosProductos
@DesdeFecha Date,
@HastaFecha Date
as
select top 10
o.idProducto as codigo,
p.descripcion as Nombre,
o.precio_compra as Precio,
sum(o.cantidad) as CantidadComprada,
sum(o.precio_compra*o.cantidad) as MontoTotal
from 
tbSuministra o
--inner join order_items oi on oi.order_id=o.order_id
inner join tbProducto p on p.idProducto=o.idProducto
where o.fechaCreacion between @DesdeFecha and @HastaFecha
group by 
o.idProducto, p.descripcion, o.precio_compra
order by CantidadComprada desc
go


select * from tbSuministra
execute IngresosProductos '2022-10-27 00:00:00','2022-10-27 23:00:00'


select 
o.idProducto as codigo,
p.descripcion as Nombre,
o.precio_compra as Precio,
sum(o.cantidad) as CantidadComprada,
sum(o.precio_compra*o.cantidad) as MontoTotal
from 
tbSuministra o
--inner join order_items oi on oi.order_id=o.order_id
inner join tbProducto p on p.idProducto=o.idProducto
where o.fechaCreacion between '2021-10-27' and '2021-10-27'
group by 
o.idProducto, p.descripcion, o.precio_compra
order by CantidadComprada desc


select datename(m,fechaCreacion) from tbSuministra