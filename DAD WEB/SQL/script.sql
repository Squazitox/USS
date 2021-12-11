USE [master]
GO
/****** Object:  Database [BD_EmpreLaive]    Script Date: 11/12/2021 00:27:44 ******/
CREATE DATABASE [BD_EmpreLaive]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BD_EmpreLaive', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\BD_EmpreLaive.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BD_EmpreLaive_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\BD_EmpreLaive_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [BD_EmpreLaive] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BD_EmpreLaive].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BD_EmpreLaive] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BD_EmpreLaive] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BD_EmpreLaive] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BD_EmpreLaive] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BD_EmpreLaive] SET ARITHABORT OFF 
GO
ALTER DATABASE [BD_EmpreLaive] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BD_EmpreLaive] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BD_EmpreLaive] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BD_EmpreLaive] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BD_EmpreLaive] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BD_EmpreLaive] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BD_EmpreLaive] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BD_EmpreLaive] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BD_EmpreLaive] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BD_EmpreLaive] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BD_EmpreLaive] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BD_EmpreLaive] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BD_EmpreLaive] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BD_EmpreLaive] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BD_EmpreLaive] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BD_EmpreLaive] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BD_EmpreLaive] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BD_EmpreLaive] SET RECOVERY FULL 
GO
ALTER DATABASE [BD_EmpreLaive] SET  MULTI_USER 
GO
ALTER DATABASE [BD_EmpreLaive] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BD_EmpreLaive] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BD_EmpreLaive] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BD_EmpreLaive] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BD_EmpreLaive] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BD_EmpreLaive] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'BD_EmpreLaive', N'ON'
GO
ALTER DATABASE [BD_EmpreLaive] SET QUERY_STORE = OFF
GO
USE [BD_EmpreLaive]
GO
/****** Object:  Table [dbo].[tbArea]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbArea](
	[idArea] [varchar](10) NOT NULL,
	[nombreArea] [varchar](25) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idArea] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbCargoTrabajador]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbCargoTrabajador](
	[idCargoTrabajador] [varchar](10) NOT NULL,
	[cargoTrabajador] [varchar](25) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idCargoTrabajador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbDespacha]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbDespacha](
	[idDespacha] [varchar](10) NOT NULL,
	[idProducto] [varchar](10) NOT NULL,
	[idUbicacion] [varchar](10) NOT NULL,
	[idArea] [varchar](10) NOT NULL,
	[cantidad] [int] NOT NULL,
	[lote] [varchar](10) NOT NULL,
	[caducidad] [date] NOT NULL,
	[fechaCreacion] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idDespacha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbKardex]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbKardex](
	[idKardex] [varchar](10) NOT NULL,
	[idProducto] [varchar](10) NOT NULL,
	[idSuministra] [varchar](10) NOT NULL,
	[idDespacha] [varchar](10) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[stock] [int] NOT NULL,
	[ingresototal] [float] NOT NULL,
	[salidatotal] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idKardex] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbMenu]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbMenu](
	[idMenu] [int] IDENTITY(1,1) NOT NULL,
	[nombreMenu] [varchar](255) NULL,
	[nombreInterno] [varchar](255) NULL,
	[estado] [varchar](2) NULL,
	[padre] [int] NULL,
	[nombreVista] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[idMenu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbPais]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbPais](
	[idPais] [varchar](10) NOT NULL,
	[pais] [varchar](25) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idPais] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbPedidoProducto]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbPedidoProducto](
	[idPedidoProducto] [varchar](10) NOT NULL,
	[idTrabajador] [varchar](10) NOT NULL,
	[idProducto] [varchar](10) NOT NULL,
	[idVendedorProveedor] [varchar](10) NOT NULL,
	[cantidadPedido] [int] NOT NULL,
	[estadoPedido] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idPedidoProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbPermisos]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbPermisos](
	[idPermiso] [varchar](10) NOT NULL,
	[idRoles] [varchar](10) NOT NULL,
	[NombrePermiso] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idPermiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbPersona]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbPersona](
	[idPersona] [varchar](10) NOT NULL,
	[idPais] [varchar](10) NOT NULL,
	[perApellidos] [varchar](50) NOT NULL,
	[perNombres] [varchar](50) NOT NULL,
	[perFechaNac] [date] NOT NULL,
	[perDni] [varchar](8) NOT NULL,
	[perEstado] [bit] NOT NULL,
	[perTelefono] [varchar](40) NOT NULL,
	[perCorreo] [varchar](40) NULL,
	[perDireccion] [varchar](40) NULL,
	[perSexo] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idPersona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbProducto]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbProducto](
	[idProducto] [varchar](10) NOT NULL,
	[idTipoProducto] [varchar](10) NOT NULL,
	[idUnidadMedida] [varchar](10) NOT NULL,
	[descripcion] [varchar](350) NULL,
PRIMARY KEY CLUSTERED 
(
	[idProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbProfesion]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbProfesion](
	[idProfesion] [varchar](10) NOT NULL,
	[profesion] [varchar](25) NOT NULL,
	[estado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idProfesion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbProveedor]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbProveedor](
	[idProveedor] [varchar](10) NOT NULL,
	[idPais] [varchar](10) NOT NULL,
	[razonSocial] [varchar](50) NOT NULL,
	[codigoPostal] [varchar](20) NOT NULL,
	[rucProveedor] [varchar](13) NOT NULL,
	[fonoProveedor] [varchar](12) NOT NULL,
	[emailProveedor] [varchar](50) NOT NULL,
	[direccion] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbRoles]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbRoles](
	[idRoles] [varchar](10) NOT NULL,
	[NombreRol] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idRoles] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbSuministra]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbSuministra](
	[idSuministra] [varchar](10) NOT NULL,
	[idProveedor] [varchar](10) NOT NULL,
	[idProducto] [varchar](10) NOT NULL,
	[idUbicacion] [varchar](10) NOT NULL,
	[lote] [varchar](10) NOT NULL,
	[cantidad] [int] NOT NULL,
	[numFactura] [varchar](10) NOT NULL,
	[paisOrigen] [varchar](10) NOT NULL,
	[precio_compra] [float] NOT NULL,
	[caducidad] [date] NOT NULL,
	[fechaCreacion] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idSuministra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbTipoMenu]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbTipoMenu](
	[idTipoUsuario] [varchar](10) NULL,
	[idMenu] [int] NULL,
	[estado] [varchar](2) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbTipoProducto]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbTipoProducto](
	[idTipoProducto] [varchar](10) NOT NULL,
	[tipoProducto] [varchar](25) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idTipoProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbTipoUsuario]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbTipoUsuario](
	[idTipoUsuario] [varchar](10) NOT NULL,
	[nombreTipoUsuario] [varchar](40) NOT NULL,
	[descripcionTipoUsuario] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idTipoUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbTrabajador]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbTrabajador](
	[idTrabajador] [varchar](10) NOT NULL,
	[idPersona] [varchar](10) NOT NULL,
	[idCargoTrabajador] [varchar](10) NOT NULL,
	[idProfesion] [varchar](10) NOT NULL,
	[idRoles] [varchar](10) NOT NULL,
	[idTurno] [varchar](10) NOT NULL,
	[fechaInicio] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idTrabajador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbTurno]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbTurno](
	[idTurno] [varchar](10) NOT NULL,
	[turno] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idTurno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbUbicacion]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbUbicacion](
	[idUbicacion] [varchar](10) NOT NULL,
	[seccion] [varchar](25) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idUbicacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbUnidadMedida]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbUnidadMedida](
	[idUnidadMedida] [varchar](10) NOT NULL,
	[unidadMedida] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idUnidadMedida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbUsuario]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbUsuario](
	[idUsuario] [varchar](10) NOT NULL,
	[NombreUsuario] [varchar](40) NOT NULL,
	[idTipoUsuario] [varchar](10) NOT NULL,
	[passwordUsuario] [varchar](40) NOT NULL,
	[idTrabajador] [varchar](10) NOT NULL,
	[estadoUsuario] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbVendedorProveedor]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbVendedorProveedor](
	[idVendedorProveedor] [varchar](10) NOT NULL,
	[idPais] [varchar](10) NOT NULL,
	[idProveedor] [varchar](10) NOT NULL,
	[idPersona] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idVendedorProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tbDespacha]  WITH CHECK ADD  CONSTRAINT [FK_Despacha_tbUbicacion] FOREIGN KEY([idUbicacion])
REFERENCES [dbo].[tbUbicacion] ([idUbicacion])
GO
ALTER TABLE [dbo].[tbDespacha] CHECK CONSTRAINT [FK_Despacha_tbUbicacion]
GO
ALTER TABLE [dbo].[tbDespacha]  WITH CHECK ADD  CONSTRAINT [FK_tbDespacha_FK_tbArea] FOREIGN KEY([idArea])
REFERENCES [dbo].[tbArea] ([idArea])
GO
ALTER TABLE [dbo].[tbDespacha] CHECK CONSTRAINT [FK_tbDespacha_FK_tbArea]
GO
ALTER TABLE [dbo].[tbDespacha]  WITH CHECK ADD  CONSTRAINT [FK_tbDespacha_FK_tbProducto] FOREIGN KEY([idProducto])
REFERENCES [dbo].[tbProducto] ([idProducto])
GO
ALTER TABLE [dbo].[tbDespacha] CHECK CONSTRAINT [FK_tbDespacha_FK_tbProducto]
GO
ALTER TABLE [dbo].[tbKardex]  WITH CHECK ADD  CONSTRAINT [FK_tbKardex_tbDespacha] FOREIGN KEY([idDespacha])
REFERENCES [dbo].[tbDespacha] ([idDespacha])
GO
ALTER TABLE [dbo].[tbKardex] CHECK CONSTRAINT [FK_tbKardex_tbDespacha]
GO
ALTER TABLE [dbo].[tbKardex]  WITH CHECK ADD  CONSTRAINT [FK_tbKardex_tbProducto] FOREIGN KEY([idProducto])
REFERENCES [dbo].[tbProducto] ([idProducto])
GO
ALTER TABLE [dbo].[tbKardex] CHECK CONSTRAINT [FK_tbKardex_tbProducto]
GO
ALTER TABLE [dbo].[tbKardex]  WITH CHECK ADD  CONSTRAINT [FK_tbKardex_tbSuministra] FOREIGN KEY([idSuministra])
REFERENCES [dbo].[tbSuministra] ([idSuministra])
GO
ALTER TABLE [dbo].[tbKardex] CHECK CONSTRAINT [FK_tbKardex_tbSuministra]
GO
ALTER TABLE [dbo].[tbPedidoProducto]  WITH CHECK ADD  CONSTRAINT [FK_PedidoProducto_tbProducto] FOREIGN KEY([idProducto])
REFERENCES [dbo].[tbProducto] ([idProducto])
GO
ALTER TABLE [dbo].[tbPedidoProducto] CHECK CONSTRAINT [FK_PedidoProducto_tbProducto]
GO
ALTER TABLE [dbo].[tbPedidoProducto]  WITH CHECK ADD  CONSTRAINT [FK_PedidoProducto_tbTrabajador] FOREIGN KEY([idTrabajador])
REFERENCES [dbo].[tbTrabajador] ([idTrabajador])
GO
ALTER TABLE [dbo].[tbPedidoProducto] CHECK CONSTRAINT [FK_PedidoProducto_tbTrabajador]
GO
ALTER TABLE [dbo].[tbPedidoProducto]  WITH CHECK ADD  CONSTRAINT [FK_PedidoProducto_tbVendedorProveedor] FOREIGN KEY([idVendedorProveedor])
REFERENCES [dbo].[tbVendedorProveedor] ([idVendedorProveedor])
GO
ALTER TABLE [dbo].[tbPedidoProducto] CHECK CONSTRAINT [FK_PedidoProducto_tbVendedorProveedor]
GO
ALTER TABLE [dbo].[tbPermisos]  WITH CHECK ADD  CONSTRAINT [FK_tbPermisos_tbRoles] FOREIGN KEY([idRoles])
REFERENCES [dbo].[tbRoles] ([idRoles])
GO
ALTER TABLE [dbo].[tbPermisos] CHECK CONSTRAINT [FK_tbPermisos_tbRoles]
GO
ALTER TABLE [dbo].[tbPersona]  WITH CHECK ADD  CONSTRAINT [FK_tbPersona_FK_Pais] FOREIGN KEY([idPais])
REFERENCES [dbo].[tbPais] ([idPais])
GO
ALTER TABLE [dbo].[tbPersona] CHECK CONSTRAINT [FK_tbPersona_FK_Pais]
GO
ALTER TABLE [dbo].[tbProducto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_tbTipoProducto] FOREIGN KEY([idTipoProducto])
REFERENCES [dbo].[tbTipoProducto] ([idTipoProducto])
GO
ALTER TABLE [dbo].[tbProducto] CHECK CONSTRAINT [FK_Producto_tbTipoProducto]
GO
ALTER TABLE [dbo].[tbProducto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_tbUnidadMedida] FOREIGN KEY([idUnidadMedida])
REFERENCES [dbo].[tbUnidadMedida] ([idUnidadMedida])
GO
ALTER TABLE [dbo].[tbProducto] CHECK CONSTRAINT [FK_Producto_tbUnidadMedida]
GO
ALTER TABLE [dbo].[tbProveedor]  WITH CHECK ADD  CONSTRAINT [FK_tbProveedor_FK_Pais] FOREIGN KEY([idPais])
REFERENCES [dbo].[tbPais] ([idPais])
GO
ALTER TABLE [dbo].[tbProveedor] CHECK CONSTRAINT [FK_tbProveedor_FK_Pais]
GO
ALTER TABLE [dbo].[tbSuministra]  WITH CHECK ADD  CONSTRAINT [FK_Suministra_tbUbicacion] FOREIGN KEY([idUbicacion])
REFERENCES [dbo].[tbUbicacion] ([idUbicacion])
GO
ALTER TABLE [dbo].[tbSuministra] CHECK CONSTRAINT [FK_Suministra_tbUbicacion]
GO
ALTER TABLE [dbo].[tbSuministra]  WITH CHECK ADD  CONSTRAINT [FK_tbSuministra_FK_Pais] FOREIGN KEY([paisOrigen])
REFERENCES [dbo].[tbPais] ([idPais])
GO
ALTER TABLE [dbo].[tbSuministra] CHECK CONSTRAINT [FK_tbSuministra_FK_Pais]
GO
ALTER TABLE [dbo].[tbSuministra]  WITH CHECK ADD  CONSTRAINT [FK_tbSuministra_FK_Producto] FOREIGN KEY([idProducto])
REFERENCES [dbo].[tbProducto] ([idProducto])
GO
ALTER TABLE [dbo].[tbSuministra] CHECK CONSTRAINT [FK_tbSuministra_FK_Producto]
GO
ALTER TABLE [dbo].[tbSuministra]  WITH CHECK ADD  CONSTRAINT [FK_tbSuministra_FK_Proveedor] FOREIGN KEY([idProveedor])
REFERENCES [dbo].[tbProveedor] ([idProveedor])
GO
ALTER TABLE [dbo].[tbSuministra] CHECK CONSTRAINT [FK_tbSuministra_FK_Proveedor]
GO
ALTER TABLE [dbo].[tbTipoMenu]  WITH CHECK ADD FOREIGN KEY([idMenu])
REFERENCES [dbo].[tbMenu] ([idMenu])
GO
ALTER TABLE [dbo].[tbTipoMenu]  WITH CHECK ADD FOREIGN KEY([idTipoUsuario])
REFERENCES [dbo].[tbTipoUsuario] ([idTipoUsuario])
GO
ALTER TABLE [dbo].[tbTrabajador]  WITH CHECK ADD  CONSTRAINT [FK_tbTrabajador_tbCargoTrabajador] FOREIGN KEY([idCargoTrabajador])
REFERENCES [dbo].[tbCargoTrabajador] ([idCargoTrabajador])
GO
ALTER TABLE [dbo].[tbTrabajador] CHECK CONSTRAINT [FK_tbTrabajador_tbCargoTrabajador]
GO
ALTER TABLE [dbo].[tbTrabajador]  WITH CHECK ADD  CONSTRAINT [FK_tbTrabajador_tbPersona] FOREIGN KEY([idPersona])
REFERENCES [dbo].[tbPersona] ([idPersona])
GO
ALTER TABLE [dbo].[tbTrabajador] CHECK CONSTRAINT [FK_tbTrabajador_tbPersona]
GO
ALTER TABLE [dbo].[tbTrabajador]  WITH CHECK ADD  CONSTRAINT [FK_tbTrabajador_tbProfesion] FOREIGN KEY([idProfesion])
REFERENCES [dbo].[tbProfesion] ([idProfesion])
GO
ALTER TABLE [dbo].[tbTrabajador] CHECK CONSTRAINT [FK_tbTrabajador_tbProfesion]
GO
ALTER TABLE [dbo].[tbTrabajador]  WITH CHECK ADD  CONSTRAINT [FK_tbTrabajador_tbRoles] FOREIGN KEY([idRoles])
REFERENCES [dbo].[tbRoles] ([idRoles])
GO
ALTER TABLE [dbo].[tbTrabajador] CHECK CONSTRAINT [FK_tbTrabajador_tbRoles]
GO
ALTER TABLE [dbo].[tbTrabajador]  WITH CHECK ADD  CONSTRAINT [FK_tbTrabajador_tbTurno] FOREIGN KEY([idTurno])
REFERENCES [dbo].[tbTurno] ([idTurno])
GO
ALTER TABLE [dbo].[tbTrabajador] CHECK CONSTRAINT [FK_tbTrabajador_tbTurno]
GO
ALTER TABLE [dbo].[tbUsuario]  WITH CHECK ADD  CONSTRAINT [FK_tbUsuario_tbTipoTrabajador] FOREIGN KEY([idTipoUsuario])
REFERENCES [dbo].[tbTipoUsuario] ([idTipoUsuario])
GO
ALTER TABLE [dbo].[tbUsuario] CHECK CONSTRAINT [FK_tbUsuario_tbTipoTrabajador]
GO
ALTER TABLE [dbo].[tbUsuario]  WITH CHECK ADD  CONSTRAINT [FK_tbUsuario_tbTrabajador] FOREIGN KEY([idTrabajador])
REFERENCES [dbo].[tbTrabajador] ([idTrabajador])
GO
ALTER TABLE [dbo].[tbUsuario] CHECK CONSTRAINT [FK_tbUsuario_tbTrabajador]
GO
ALTER TABLE [dbo].[tbVendedorProveedor]  WITH CHECK ADD  CONSTRAINT [FK_tbVendedorProveedor_tbPersona] FOREIGN KEY([idPersona])
REFERENCES [dbo].[tbPersona] ([idPersona])
GO
ALTER TABLE [dbo].[tbVendedorProveedor] CHECK CONSTRAINT [FK_tbVendedorProveedor_tbPersona]
GO
ALTER TABLE [dbo].[tbVendedorProveedor]  WITH CHECK ADD  CONSTRAINT [FK_tbVendedorProveedor_tbProveedor] FOREIGN KEY([idProveedor])
REFERENCES [dbo].[tbProveedor] ([idProveedor])
GO
ALTER TABLE [dbo].[tbVendedorProveedor] CHECK CONSTRAINT [FK_tbVendedorProveedor_tbProveedor]
GO
/****** Object:  StoredProcedure [dbo].[IngresosProductos]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[IngresosProductos]
@DesdeFecha Date,
@HastaFecha Date,
@producto Varchar(100)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT 
o.idProducto as codigo,
p.descripcion as Nombre,
o.precio_compra as Precio,
sum(o.cantidad) as CantidadComprada,
sum(o.precio_compra*o.cantidad) as MontoTotal

from 
tbSuministra o inner join tbProducto p on p.idProducto=o.idProducto
where (p.descripcion = @producto) and (o.fechaCreacion between @DesdeFecha and @HastaFecha) 
group by 
o.idProducto, p.descripcion, o.precio_compra

END
GO
/****** Object:  StoredProcedure [dbo].[sp_ActualizarSuministra]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO








--PROCEDIMIENTO ACTUALIZAR LA TABLA SUMINISTRO 
--Agregando Campos nuevos - Manuel VM
CREATE PROCEDURE [dbo].[sp_ActualizarSuministra]
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
/****** Object:  StoredProcedure [dbo].[sp_ListarArea]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ListarArea]
	-- Add the parameters for the stored procedure here


AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select * from tbArea
	
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ListarAreaCod]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ListarAreaCod]
@codArea varchar(10)
AS
	SELECT * FROM tbArea WHERE tbArea.idArea = @codArea

GO
/****** Object:  StoredProcedure [dbo].[sp_ListarLote]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ListarLote] 
	-- Add the parameters for the stored procedure here
@idproducto varchar(10)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select lote from tbSuministra
	WHERE tbSuministra.idProducto = @idproducto
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ListarLoteSuministro]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ListarLoteSuministro] 
	-- Add the parameters for the stored procedure here
@idProducto varchar(100),
@idubicacion varchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT lote from tbSuministra s inner join tbProducto p on s.idProducto = p.idProducto
									 inner join tbUbicacion u on s.idUbicacion = u.idUbicacion
	where p.descripcion = @idProducto and seccion = @idubicacion
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ListarMenuPorTipoUsuario]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ListarMenuPorTipoUsuario] (@idTipoUsuario varchar(19))  
as  
  
select  
b.*  
from tbTipoMenu as a   
left join tbMenu as b on a.idMenu = b.idMenu  
where idTipoUsuario = @idTipoUsuario
GO
/****** Object:  StoredProcedure [dbo].[sp_ListarPais]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_ListarPais]

AS
	BEGIN TRANSACTION 
		BEGIN
			SELECT * FROM tbPais 
		END
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[sp_ListarProducto]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ListarProducto]
AS
	BEGIN TRANSACTION
		BEGIN
			SELECT DISTINCT * from tbProducto
		END
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[sp_ListarProductoCod]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ListarProductoCod]

AS
	BEGIN TRANSACTION 
		BEGIN
			SELECT * FROM tbProducto 
		END
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[sp_ListarProductosSuministro]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ListarProductosSuministro] 
	-- Add the parameters for the stored procedure here


AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT
s.idProducto, p.descripcion, u.seccion, s.lote
	from tbSuministra s join tbProducto p on s.idProducto=p.idProducto
					join tbUbicacion u on s.idUbicacion=u.idUbicacion
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ListarProveedor]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ListarProveedor]
AS
	BEGIN TRANSACTION
		BEGIN
			SELECT * from tbProveedor
		END
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[sp_ListarTrabajador]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ListarTrabajador] 
	-- Add the parameters for the stored procedure here


AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT
			t.idTrabajador,
			p.perApellidos
			
			from tbTrabajador t inner join tbPersona p on t.idPersona =p.idPersona
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ListarUbicacion]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_ListarUbicacion]
AS
	BEGIN TRANSACTION
		BEGIN
			SELECT * from tbUbicacion
		END
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[sp_ListarUbicacionSuministro]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ListarUbicacionSuministro] 
	-- Add the parameters for the stored procedure here
@idProducto varchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT s.idUbicacion, u.seccion from tbSuministra s inner join tbUbicacion u on s.idUbicacion = u.idUbicacion
														inner join tbProducto p on s.idProducto = p.idProducto
	where descripcion = @idProducto
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Logearse]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Logearse] 
@usuario varchar(40),
@password varchar(40)
AS
	BEGIN TRANSACTION 
		BEGIN
			select* from tbUsuario WHERE tbUsuario.NombreUsuario=@usuario AND tbUsuario.passwordUsuario=@password
		END

	COMMIT

GO
/****** Object:  StoredProcedure [dbo].[sp_Login]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Login]
	-- Add the parameters for the stored procedure here
@usuario varchar(40),
@clave varchar(40),
@idUsuario varchar(40)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select u.idUsuario IdUsuario, p.perNombres Nombre, p.perApellidos Apellido, p.perCorreo Correo, u.NombreUsuario Usuario, u.passwordUsuario Clave, u.idTipoUsuario idRol, m.idMenu oRol, m.nombreInterno Menu, u.estadoUsuario Activo, t.fechaInicio FechaRegistro, c.cargoTrabajador Cargo
	from tbPersona p join tbTrabajador t on  p.idpersona =t.idPersona
				 join tbUsuario u on t.idTrabajador=u.idTrabajador
				 join tbTipoMenu tm on u.idTipoUsuario = tm.idTipoUsuario
				 join tbMenu m on tm.idMenu = m.idMenu
				 join tbCargoTrabajador c on t.idCargoTrabajador = c.idCargoTrabajador
	WHERE u.NombreUsuario=@usuario AND u.passwordUsuario=@clave and u.idUsuario = @idUsuario
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerUsusario]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerUsusario]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select u.idUsuario IdUsuario, p.perNombres Nombre, p.perApellidos Apellidos, u.NombreUsuario Usuario, u.passwordUsuario Clave, u.estadoUsuario Activo,
	U.idTipoUsuario, c.cargoTrabajador Cargo
	from tbPersona p join tbTrabajador t on  p.idpersona =t.idPersona
				 join tbUsuario u on t.idTrabajador=u.idTrabajador
				  join tbCargoTrabajador c on t.idCargoTrabajador = c.idCargoTrabajador
				 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ProductosVencimiento]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ProductosVencimiento]
@DesdeFecha Date,
@HastaFecha Date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

select
o.idProducto as codigo,
p.descripcion as Nombre,
o.caducidad as Caducidad,
o.cantidad as Cantidad,
u.seccion as Ubicacion
from 
tbSuministra o inner join tbProducto p on p.idProducto=o.idProducto 
inner join tbUbicacion u on o.idUbicacion =u.idUbicacion
where o.caducidad between @DesdeFecha and @HastaFecha
END
GO
/****** Object:  StoredProcedure [dbo].[SP_RegistraPais]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_RegistraPais]
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
/****** Object:  StoredProcedure [dbo].[SP_RegistraProducto]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_RegistraProducto]
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
/****** Object:  StoredProcedure [dbo].[SP_RegistraProfesion]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_RegistraProfesion]
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
/****** Object:  StoredProcedure [dbo].[SP_RegistraProveedor]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_RegistraProveedor]
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
/****** Object:  StoredProcedure [dbo].[SP_RegistrarArea]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_RegistrarArea]
	-- Add the parameters for the stored procedure here
@CodArea varchar(10),
@area varchar(25)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DECLARE @totalReg int
	DECLARE @enlazado varchar(10)
	SELECT @totalReg = COUNT(*) FROM tbArea
	SET @enlazado = @CodArea +CAST(@totalReg AS varchar(6))
	

	IF EXISTS(SELECT *FROM tbArea WHERE tbArea.idArea= @enlazado)
	BEGIN
		PRINT 'Id ya registrado por favor haga modificacion en letras...';
	END
	ELSE
	BEGIN
		INSERT INTO  tbArea VALUES(@enlazado,@area)
		PRINT 'Los datos  fueron registrados  en la tabla [PAIS] con exito...!'
	END

END
GO
/****** Object:  StoredProcedure [dbo].[sp_RegistrarCargoTrabajador]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_RegistrarCargoTrabajador]
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
/****** Object:  StoredProcedure [dbo].[sp_RegistrarDespacha]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Agregando Campos nuevos - Manuel VM
CREATE PROCEDURE [dbo].[sp_RegistrarDespacha]
@codDespacha varchar(10),
@idProducto varchar(10),
@Ubicacion varchar(200),
@Area varchar(200),
@cantidad int,
@lote varchar(200)

AS

DECLARE 
@idUbicacion varchar(10),
@idArea varchar(10),
@caducidad date,
--@idTrabajador varchar(100),
@fechaCreacion date


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
		
		  set @idUbicacion = (select top 1 idUbicacion from tbUbicacion where seccion = @Ubicacion);  
		  set @idArea = (select top 1 idArea from tbArea where nombreArea = @Area);
		  set @caducidad = (select caducidad from tbSuministra where lote = @lote and idProducto = @idProducto and idUbicacion = @idUbicacion);
		  --set @idTrabajador = (SELECT idTrabajador from tbUsuario where NombreUsuario= CURRENT_USER);

		--Se corrigio las variables - Manuel VM
		INSERT INTO  tbDespacha VALUES(@enlazado,@idProducto,@idUbicacion,@idArea,
		@cantidad,@lote,@caducidad, GETDATE())

		--UPDATE tbProducto set tbProducto.stock = tbProducto.stock - @cantidad
		--modificacion de actualizaciones - Manuel VM
		UPDATE tbKardex set tbKardex .stock = tbKardex.stock - @cantidad 
		WHERE tbKardex .idProducto=@idProducto
		
		UPDATE tbKardex set tbKardex .salidatotal = tbKardex.salidatotal + @cantidad 
		WHERE tbKardex .idProducto=@idProducto

		PRINT 'Los datos fueron registrados  en la tabla [DESPACHO] con exito...!'
	END
GO
/****** Object:  StoredProcedure [dbo].[sp_RegistrarPersona]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_RegistrarPersona]
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
/****** Object:  StoredProcedure [dbo].[sp_RegistrarRoles]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_RegistrarRoles]
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
/****** Object:  StoredProcedure [dbo].[sp_RegistrarTipoProducto]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





----------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------
--PROCEDIMIENTO DE REGISTRO DE TIPO DE PRODUCTO
----------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------
--EMBUTIDOS
--LACTEOS
CREATE PROCEDURE [dbo].[sp_RegistrarTipoProducto]
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
/****** Object:  StoredProcedure [dbo].[SP_RegistrarTipoUsuario]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_RegistrarTipoUsuario]
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
/****** Object:  StoredProcedure [dbo].[sp_RegistrarTrabajador]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_RegistrarTrabajador]
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
/****** Object:  StoredProcedure [dbo].[sp_RegistrarTurno]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_RegistrarTurno]
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
/****** Object:  StoredProcedure [dbo].[SP_RegistrarUsuario]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_RegistrarUsuario]
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
/****** Object:  StoredProcedure [dbo].[SP_RegistraSuministra]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_RegistraSuministra]
@codSuministra varchar(10), 
@razonsocial varchar(200),
@codProducto varchar(10),  
@Ubicacion varchar(200),
@lote varchar(10),  
@cantidad int,  
@numFactura varchar(10),  
@pais varchar(200),
@precio_compra float,  
@caducidad date
--@resultado varchar(100) output 


  
AS  


DECLARE 
@idproveedor varchar(10), 
@idUbicacion varchar(10),  
@paisOrigen varchar(10)  

 DECLARE @totalReg int  
 DECLARE @enlazado varchar(8)  
 SELECT @totalReg = COUNT(*) FROM tbSuministra  
 SET @enlazado = @codSuministra +CAST(@totalReg AS varchar(6))  
  
 IF EXISTS(SELECT *FROM tbSuministra WHERE tbSuministra.idSuministra = @enlazado)  
 BEGIN  
  print 'Id ya registrado por favor haga modificacion en letras...';  
 END  
 ELSE  
 BEGIN  
  
    
    
  set @idproveedor = (select top 1 idProveedor from tbProveedor where razonSocial = @razonsocial);  
  set @idUbicacion = (select top 1 idUbicacion from tbUbicacion where seccion = @Ubicacion);  
  set @paisOrigen = (select top 1 idPais from tbPais where pais = @pais);  
  
  INSERT INTO  tbSuministra VALUES(@enlazado,@idproveedor, @codProducto, @idUbicacion, @lote, @cantidad, @numFactura, @paisOrigen, @precio_compra,@caducidad, GETDATE());  
  
  UPDATE tbKardex  
  set tbKardex.stock = tbKardex.stock + @cantidad  
  WHERE tbKardex.idProducto = @codProducto  
  
  UPDATE tbKardex  
  set tbKardex.ingresototal = tbKardex.ingresototal + @cantidad  
  WHERE tbKardex.idProducto = @codProducto  
  
  --set @resultado = 'Los datos fueron registrados  en la tabla [SUMINISTRA] con exito...!'  
 END
GO
/****** Object:  StoredProcedure [dbo].[SP_RegistraUbicacionProducto]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_RegistraUbicacionProducto]
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
/****** Object:  StoredProcedure [dbo].[SP_RegistraUnidadMedida]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_RegistraUnidadMedida]
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
/****** Object:  StoredProcedure [dbo].[sp_ReporteIngreso]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ReporteIngreso] 
	-- Add the parameters for the stored procedure here
@DesdeFecha Date,
@HastaFecha Date

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT 
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

END
GO
/****** Object:  StoredProcedure [dbo].[usp_ObtenerProveedores]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_ObtenerProveedores]
AS 

select p.idProveedor, p.idPais, p.razonSocial, p.codigoPostal, p.rucProveedor, p.fonoProveedor, p.emailProveedor, p.direccion, o.pais 
from tbProveedor p left join tbPais o on p.idPais = o.idPais
order by idProveedor desc
GO
/****** Object:  StoredProcedure [dbo].[usp_rptVenta]    Script Date: 11/12/2021 00:27:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_rptVenta] 

@idProducto as varchar(50)


AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
select *, ingresos - salidas as stock from (
select p.idProducto, p.descripcion, 
--isnull(sum(s.cantidad),0) as ingresos, 
ingresos = (select isnull(sum(cantidad),0) from tbSuministra where idProducto = p.idProducto),
--isnull(sum(d.cantidad),0) as salidas,
salidas = (select isnull(sum(cantidad),0) from tbDespacha where idProducto = p.idProducto)
from tbProducto as p 
) as x 
where x.idProducto = CASE @idProducto WHEN '' THEN x.idProducto else @idProducto end 
order by stock desc



END
GO
USE [master]
GO
ALTER DATABASE [BD_EmpreLaive] SET  READ_WRITE 
GO
