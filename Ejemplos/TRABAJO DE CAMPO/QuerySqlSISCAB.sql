USE [master]
GO
/****** Object:  Database [SISCAB]    Script Date: 11/03/2024 12:20:43 ******/
CREATE DATABASE [SISCAB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SISCAB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\SISCAB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SISCAB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\SISCAB_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SISCAB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SISCAB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SISCAB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SISCAB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SISCAB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SISCAB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SISCAB] SET ARITHABORT OFF 
GO
ALTER DATABASE [SISCAB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SISCAB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SISCAB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SISCAB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SISCAB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SISCAB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SISCAB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SISCAB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SISCAB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SISCAB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SISCAB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SISCAB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SISCAB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SISCAB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SISCAB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SISCAB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SISCAB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SISCAB] SET RECOVERY FULL 
GO
ALTER DATABASE [SISCAB] SET  MULTI_USER 
GO
ALTER DATABASE [SISCAB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SISCAB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SISCAB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SISCAB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SISCAB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SISCAB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'SISCAB', N'ON'
GO
ALTER DATABASE [SISCAB] SET QUERY_STORE = OFF
GO
USE [SISCAB]
GO
/****** Object:  Table [dbo].[Banco]    Script Date: 11/03/2024 12:20:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Banco](
	[id] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Banco] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bitacora]    Script Date: 11/03/2024 12:20:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bitacora](
	[id] [int] NOT NULL,
	[fecha] [datetime] NOT NULL,
	[id_usuario] [int] NOT NULL,
	[modulo] [varchar](50) NOT NULL,
	[operacion] [varchar](50) NOT NULL,
	[criticidad] [int] NOT NULL,
 CONSTRAINT [PK_Bitacora] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 11/03/2024 12:20:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[id] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[dni] [int] NOT NULL,
	[telefono_fijo] [varchar](50) NOT NULL,
	[telefono_movil] [varchar](50) NOT NULL,
	[domicilio] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[borrado] [int] NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente_Bitacora]    Script Date: 11/03/2024 12:20:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente_Bitacora](
	[id] [int] NOT NULL,
	[ultima_modificacion] [datetime] NOT NULL,
	[activo] [int] NOT NULL,
	[tipo] [varchar](50) NOT NULL,
	[id_usuario] [int] NOT NULL,
	[id_cliente] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[dni] [int] NOT NULL,
	[telefono_fijo] [varchar](50) NOT NULL,
	[telefono_movil] [varchar](50) NOT NULL,
	[domicilio] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[borrado] [int] NOT NULL,
 CONSTRAINT [PK_Cliente_Bitacora] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DVH]    Script Date: 11/03/2024 12:20:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DVH](
	[modulo] [varchar](50) NOT NULL,
	[registro] [int] NOT NULL,
	[dv] [varchar](50) NOT NULL,
 CONSTRAINT [PK_DVH] PRIMARY KEY CLUSTERED 
(
	[modulo] ASC,
	[registro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DVV]    Script Date: 11/03/2024 12:20:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DVV](
	[modulo] [varchar](50) NOT NULL,
	[columna] [int] NOT NULL,
	[dv] [varchar](50) NOT NULL,
 CONSTRAINT [PK_DVV] PRIMARY KEY CLUSTERED 
(
	[modulo] ASC,
	[columna] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estadia]    Script Date: 11/03/2024 12:20:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estadia](
	[id] [int] NOT NULL,
	[id_factura] [int] NOT NULL,
	[checkin] [datetime] NOT NULL,
	[checkout] [datetime] NOT NULL,
	[id_habitacion] [int] NOT NULL,
	[id_cliente] [int] NOT NULL,
	[cantidad_huespedes] [int] NOT NULL,
	[estado] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Estadia] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Etiqueta]    Script Date: 11/03/2024 12:20:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Etiqueta](
	[id_etiqueta] [int] NOT NULL,
	[nombre] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Etiqueta] PRIMARY KEY CLUSTERED 
(
	[id_etiqueta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Factura]    Script Date: 11/03/2024 12:20:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura](
	[id] [int] NOT NULL,
	[numero] [varchar](50) NOT NULL,
	[id_cliente] [int] NOT NULL,
	[fecha] [datetime] NOT NULL,
	[lugar] [varchar](50) NOT NULL,
	[id_reserva] [int] NOT NULL,
	[subtotal] [float] NOT NULL,
	[iva] [float] NOT NULL,
	[total] [float] NOT NULL,
	[deposito] [float] NOT NULL,
 CONSTRAINT [PK_Factura] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Factura_Hospedaje]    Script Date: 11/03/2024 12:20:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura_Hospedaje](
	[id] [int] NOT NULL,
	[numero] [varchar](50) NOT NULL,
	[fecha] [datetime] NOT NULL,
	[lugar] [varchar](50) NOT NULL,
	[id_factura_reserva] [int] NOT NULL,
	[id_estadia] [int] NOT NULL,
	[id_cliente] [int] NOT NULL,
	[total_pagar] [float] NOT NULL,
	[deposito] [float] NOT NULL,
	[total_estadia] [float] NOT NULL,
	[estado] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Factura_Hospedaje] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Habitacion]    Script Date: 11/03/2024 12:20:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Habitacion](
	[id] [int] NOT NULL,
	[numero] [int] NOT NULL,
	[id_tipo_habitacion] [int] NOT NULL,
 CONSTRAINT [PK_Habitacion] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Idioma]    Script Date: 11/03/2024 12:20:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Idioma](
	[id_idioma] [int] NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[idioma_default] [bit] NOT NULL,
 CONSTRAINT [PK_Idioma] PRIMARY KEY CLUSTERED 
(
	[id_idioma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pago_Deposito]    Script Date: 11/03/2024 12:20:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pago_Deposito](
	[id] [int] NOT NULL,
	[id_tipo_tarjeta] [int] NOT NULL,
	[id_procesador_pago] [int] NOT NULL,
	[id_banco] [int] NOT NULL,
	[numero] [bigint] NOT NULL,
	[codigo] [int] NOT NULL,
	[vencimiento] [datetime] NOT NULL,
	[id_factura] [int] NOT NULL,
	[cuotas] [int] NOT NULL,
 CONSTRAINT [PK_Pago_Deposito] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pago_Estadia]    Script Date: 11/03/2024 12:20:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pago_Estadia](
	[id] [int] NOT NULL,
	[id_tipo_tarjeta] [int] NOT NULL,
	[id_procesador_pago] [int] NOT NULL,
	[id_banco] [int] NOT NULL,
	[numero] [bigint] NOT NULL,
	[codigo] [int] NOT NULL,
	[vencimiento] [datetime] NOT NULL,
	[id_factura_hospedaje] [int] NOT NULL,
	[cuotas] [int] NOT NULL,
 CONSTRAINT [PK_Pago_Estadia] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permiso]    Script Date: 11/03/2024 12:20:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permiso](
	[nombre] [varchar](100) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[permiso] [varchar](50) NULL,
 CONSTRAINT [PK_Permiso] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permiso_Permiso]    Script Date: 11/03/2024 12:20:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permiso_Permiso](
	[id_padre] [int] NULL,
	[id_hijo] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Procesador_Pago]    Script Date: 11/03/2024 12:20:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Procesador_Pago](
	[id] [int] NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Procesador_Pago] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reserva]    Script Date: 11/03/2024 12:20:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reserva](
	[id] [int] NOT NULL,
	[fecha_inicio] [datetime] NOT NULL,
	[fecha_fin] [datetime] NOT NULL,
	[id_cliente] [int] NOT NULL,
	[cantidad_huespedes] [int] NOT NULL,
	[cantidad_dias] [int] NOT NULL,
	[id_habitacion] [int] NOT NULL,
	[facturada] [varchar](2) NOT NULL,
 CONSTRAINT [PK_Reserva] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_Habitacion]    Script Date: 11/03/2024 12:20:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Habitacion](
	[id] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[precio] [float] NOT NULL,
	[huespedes_maximo] [int] NOT NULL,
 CONSTRAINT [PK_Tipo_Habitacion] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_Tarjeta]    Script Date: 11/03/2024 12:20:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Tarjeta](
	[id] [int] NOT NULL,
	[tipo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Tipo_Tarjeta] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Traduccion]    Script Date: 11/03/2024 12:20:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Traduccion](
	[id_idioma] [int] NOT NULL,
	[traduccion] [varchar](100) NOT NULL,
	[id_etiqueta] [int] NOT NULL,
 CONSTRAINT [PK_Traduccion] PRIMARY KEY CLUSTERED 
(
	[id_idioma] ASC,
	[id_etiqueta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 11/03/2024 12:20:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[id] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[dni] [int] NOT NULL,
	[rol] [varchar](50) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[borrado] [int] NOT NULL,
	[bloqueo] [int] NOT NULL,
	[intentos] [int] NOT NULL,
	[id_idioma] [int] NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario_Permiso]    Script Date: 11/03/2024 12:20:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario_Permiso](
	[id_usuario] [int] NOT NULL,
	[id_permiso] [int] NOT NULL,
 CONSTRAINT [PK_Usuario_Permiso] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC,
	[id_permiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Banco] ([id], [nombre]) VALUES (1, N'Santander Río')
INSERT [dbo].[Banco] ([id], [nombre]) VALUES (2, N'Nación')
INSERT [dbo].[Banco] ([id], [nombre]) VALUES (3, N'Ciudad')
INSERT [dbo].[Banco] ([id], [nombre]) VALUES (4, N'Provincia de Buenos Aires')
INSERT [dbo].[Banco] ([id], [nombre]) VALUES (5, N'Galicia')
INSERT [dbo].[Banco] ([id], [nombre]) VALUES (6, N'Itau')
INSERT [dbo].[Banco] ([id], [nombre]) VALUES (7, N'Macro')
INSERT [dbo].[Banco] ([id], [nombre]) VALUES (8, N'BBVA')
INSERT [dbo].[Banco] ([id], [nombre]) VALUES (9, N'Credicoop')
INSERT [dbo].[Banco] ([id], [nombre]) VALUES (10, N'Patagonia')
GO
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (1, CAST(N'2023-11-27T07:23:26.690' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (2, CAST(N'2023-11-27T07:49:07.033' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (3, CAST(N'2023-11-27T07:50:15.883' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (4, CAST(N'2023-11-27T07:51:43.397' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (5, CAST(N'2023-11-27T08:09:02.670' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (6, CAST(N'2023-11-27T08:09:55.847' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (7, CAST(N'2023-11-27T08:17:58.047' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (8, CAST(N'2023-11-27T08:23:56.617' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (9, CAST(N'2023-11-27T08:31:42.840' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (10, CAST(N'2023-11-27T08:34:18.430' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (11, CAST(N'2023-11-27T08:35:53.967' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (12, CAST(N'2023-11-27T08:43:54.837' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (13, CAST(N'2023-11-27T08:46:33.740' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (14, CAST(N'2023-11-27T09:13:45.657' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (15, CAST(N'2023-11-27T09:16:59.447' AS DateTime), 1, N'Clientes', N'Modificacion', 2)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (16, CAST(N'2023-11-27T09:19:25.360' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (17, CAST(N'2023-11-27T09:19:52.633' AS DateTime), 1, N'Clientes', N'Modificacion', 2)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (18, CAST(N'2023-11-27T09:47:22.353' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (19, CAST(N'2023-11-27T10:20:28.973' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (20, CAST(N'2023-11-27T10:22:01.193' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (21, CAST(N'2023-11-27T11:18:03.120' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (22, CAST(N'2023-11-27T11:19:36.807' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (23, CAST(N'2023-11-27T11:21:33.767' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (24, CAST(N'2023-11-27T11:23:10.720' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (25, CAST(N'2023-11-27T11:26:12.510' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (26, CAST(N'2023-11-27T12:01:26.903' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (27, CAST(N'2023-11-27T12:53:34.493' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (28, CAST(N'2023-11-27T13:02:34.880' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (29, CAST(N'2023-11-27T14:40:50.120' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (30, CAST(N'2023-11-27T14:41:41.230' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (31, CAST(N'2023-11-27T14:42:29.757' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (32, CAST(N'2023-11-27T18:01:28.973' AS DateTime), 1, N'Usuarios', N'Logout', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (33, CAST(N'2023-11-27T19:51:39.720' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (34, CAST(N'2023-11-27T20:01:55.130' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (35, CAST(N'2023-11-27T20:03:34.723' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (36, CAST(N'2023-11-27T20:04:28.780' AS DateTime), 1, N'Usuarios', N'Logout', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (37, CAST(N'2023-11-27T20:04:40.700' AS DateTime), 4, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (38, CAST(N'2023-11-27T20:07:32.237' AS DateTime), 4, N'Usuarios', N'Logout', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (39, CAST(N'2023-11-27T20:16:52.203' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (40, CAST(N'2023-11-28T20:31:11.830' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (41, CAST(N'2023-11-28T20:50:15.140' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (42, CAST(N'2023-11-28T20:51:20.817' AS DateTime), 1, N'Clientes', N'Alta', 2)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (43, CAST(N'2023-11-28T20:59:14.917' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (44, CAST(N'2023-11-28T21:45:49.910' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (45, CAST(N'2023-11-29T18:51:13.050' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (46, CAST(N'2023-11-29T19:06:58.253' AS DateTime), 1, N'Perfiles', N'Asignar', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (47, CAST(N'2023-11-29T19:07:16.277' AS DateTime), 1, N'Perfiles', N'Asignar', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (48, CAST(N'2023-11-29T19:07:54.807' AS DateTime), 1, N'Perfiles', N'Asignar', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (49, CAST(N'2023-11-29T19:08:10.983' AS DateTime), 1, N'Perfiles', N'Asignar', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (50, CAST(N'2023-11-29T19:29:06.017' AS DateTime), 4, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (51, CAST(N'2023-11-29T19:33:09.590' AS DateTime), 4, N'Usuarios', N'Logout', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (52, CAST(N'2023-11-29T19:33:29.797' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (53, CAST(N'2023-11-29T19:37:19.307' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (54, CAST(N'2023-11-29T19:38:36.160' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (55, CAST(N'2023-11-29T19:39:18.563' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (56, CAST(N'2023-11-29T19:39:45.497' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (57, CAST(N'2023-11-29T20:35:18.187' AS DateTime), 1, N'Perfiles', N'Alta', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (58, CAST(N'2023-11-29T20:35:46.590' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (59, CAST(N'2023-11-29T20:35:58.480' AS DateTime), 4, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (60, CAST(N'2023-11-29T20:44:32.080' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (61, CAST(N'2023-11-29T20:45:53.637' AS DateTime), 1, N'Usuarios', N'Logout', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (62, CAST(N'2023-11-29T20:46:06.130' AS DateTime), 4, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (63, CAST(N'2023-11-29T20:48:16.230' AS DateTime), 5, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (64, CAST(N'2023-11-29T20:52:19.443' AS DateTime), 5, N'Usuarios', N'Logout', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (65, CAST(N'2023-11-29T20:52:29.900' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (66, CAST(N'2023-11-29T20:57:06.133' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (67, CAST(N'2023-11-29T20:57:31.030' AS DateTime), 1, N'Perfiles', N'Alta', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (68, CAST(N'2023-11-29T21:08:23.140' AS DateTime), 1, N'Usuarios', N'Logout', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (69, CAST(N'2023-11-29T21:11:16.470' AS DateTime), 4, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (70, CAST(N'2023-11-29T21:12:34.507' AS DateTime), 4, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (71, CAST(N'2023-11-29T21:15:31.183' AS DateTime), 4, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (72, CAST(N'2023-11-29T21:19:46.290' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (73, CAST(N'2023-11-29T21:21:48.043' AS DateTime), 1, N'Perfiles', N'Alta', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (74, CAST(N'2023-11-29T21:32:17.793' AS DateTime), 1, N'Perfiles', N'Alta', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (75, CAST(N'2023-11-29T21:32:36.220' AS DateTime), 1, N'Perfiles', N'Alta', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (76, CAST(N'2023-11-29T21:32:44.510' AS DateTime), 1, N'Usuarios', N'Logout', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (77, CAST(N'2023-11-29T21:34:01.097' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (78, CAST(N'2023-11-29T21:34:36.187' AS DateTime), 1, N'Usuarios', N'Logout', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (79, CAST(N'2023-11-29T21:34:47.420' AS DateTime), 4, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (80, CAST(N'2023-11-29T21:34:58.097' AS DateTime), 4, N'Usuarios', N'Logout', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (81, CAST(N'2023-11-29T21:42:05.413' AS DateTime), 3, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (82, CAST(N'2023-11-29T21:42:25.440' AS DateTime), 3, N'Usuarios', N'Logout', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (83, CAST(N'2023-12-03T09:38:40.570' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (84, CAST(N'2023-12-03T09:38:51.530' AS DateTime), 1, N'Usuarios', N'Logout', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (85, CAST(N'2023-12-03T09:39:18.070' AS DateTime), 4, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (86, CAST(N'2023-12-03T09:44:14.187' AS DateTime), 4, N'Reserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (87, CAST(N'2023-12-03T09:44:56.003' AS DateTime), 4, N'Reserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (88, CAST(N'2023-12-03T09:45:19.487' AS DateTime), 4, N'Reserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (89, CAST(N'2023-12-03T09:45:52.870' AS DateTime), 4, N'Reserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (90, CAST(N'2023-12-03T09:47:20.983' AS DateTime), 4, N'Usuarios', N'Logout', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (91, CAST(N'2023-12-03T09:52:16.017' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (92, CAST(N'2023-12-03T09:52:33.813' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (93, CAST(N'2023-12-03T09:55:42.893' AS DateTime), 1, N'Reserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (94, CAST(N'2023-12-03T09:56:08.233' AS DateTime), 1, N'Reserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (95, CAST(N'2023-12-03T09:56:26.993' AS DateTime), 1, N'Reserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (96, CAST(N'2023-12-03T09:56:52.910' AS DateTime), 1, N'Reserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (97, CAST(N'2023-12-03T09:57:06.610' AS DateTime), 1, N'Usuarios', N'Logout', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (98, CAST(N'2023-12-03T10:12:14.067' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (99, CAST(N'2023-12-03T10:12:49.033' AS DateTime), 1, N'Reserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (100, CAST(N'2023-12-03T10:13:04.203' AS DateTime), 1, N'Usuarios', N'Login', 1)
GO
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (101, CAST(N'2023-12-03T10:13:48.287' AS DateTime), 1, N'Reserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (102, CAST(N'2023-12-03T10:14:07.257' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (103, CAST(N'2023-12-03T10:15:53.800' AS DateTime), 1, N'Reserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (104, CAST(N'2023-12-03T10:16:19.703' AS DateTime), 1, N'Usuarios', N'Logout', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (105, CAST(N'2023-12-03T10:16:37.547' AS DateTime), 4, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (106, CAST(N'2023-12-03T10:23:11.167' AS DateTime), 4, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (107, CAST(N'2023-12-03T10:25:30.537' AS DateTime), 4, N'Clientes', N'Alta', 2)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (108, CAST(N'2023-12-03T10:25:53.073' AS DateTime), 4, N'Reserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (109, CAST(N'2023-12-03T10:26:04.177' AS DateTime), 4, N'Usuarios', N'Logout', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (110, CAST(N'2023-12-03T10:26:20.233' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (111, CAST(N'2023-12-03T10:26:46.790' AS DateTime), 5, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (112, CAST(N'2023-12-03T10:27:21.987' AS DateTime), 5, N'FacturarReserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (113, CAST(N'2023-12-03T10:30:34.103' AS DateTime), 5, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (114, CAST(N'2023-12-03T10:30:55.883' AS DateTime), 5, N'FacturarReserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (115, CAST(N'2023-12-03T10:31:39.297' AS DateTime), 5, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (116, CAST(N'2023-12-03T12:35:49.060' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (117, CAST(N'2023-12-03T12:36:17.927' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (118, CAST(N'2023-12-03T12:41:42.513' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (119, CAST(N'2023-12-03T12:42:04.740' AS DateTime), 1, N'FacturarReserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (120, CAST(N'2023-12-03T12:44:58.837' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (121, CAST(N'2023-12-03T12:45:15.677' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (122, CAST(N'2023-12-03T12:45:37.713' AS DateTime), 1, N'FacturarReserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (123, CAST(N'2023-12-03T12:46:12.507' AS DateTime), 1, N'Usuarios', N'Logout', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (124, CAST(N'2023-12-03T12:47:49.080' AS DateTime), 4, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (125, CAST(N'2023-12-03T12:48:17.197' AS DateTime), 4, N'Checkin', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (126, CAST(N'2023-12-03T12:51:15.430' AS DateTime), 4, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (127, CAST(N'2023-12-03T12:51:47.913' AS DateTime), 4, N'Checkin', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (128, CAST(N'2023-12-03T12:52:27.827' AS DateTime), 4, N'Checkin', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (129, CAST(N'2023-12-03T12:52:51.317' AS DateTime), 4, N'Checkin', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (130, CAST(N'2023-12-03T12:55:15.220' AS DateTime), 4, N'Reserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (131, CAST(N'2023-12-03T12:55:29.153' AS DateTime), 4, N'Usuarios', N'Logout', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (132, CAST(N'2023-12-03T12:55:41.437' AS DateTime), 5, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (133, CAST(N'2023-12-03T12:56:00.480' AS DateTime), 5, N'FacturarReserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (134, CAST(N'2023-12-03T12:59:08.040' AS DateTime), 5, N'Usuarios', N'Logout', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (135, CAST(N'2023-12-03T12:59:29.140' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (136, CAST(N'2023-12-03T13:01:20.153' AS DateTime), 1, N'Clientes', N'Alta', 2)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (137, CAST(N'2023-12-03T13:02:12.760' AS DateTime), 1, N'Reserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (138, CAST(N'2023-12-03T13:02:27.930' AS DateTime), 1, N'FacturarReserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (139, CAST(N'2023-12-03T13:03:08.600' AS DateTime), 1, N'Checkin', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (140, CAST(N'2023-12-03T16:12:15.467' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (141, CAST(N'2023-12-03T16:23:46.937' AS DateTime), 1, N'Clientes', N'Alta', 2)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (142, CAST(N'2023-12-03T16:24:36.580' AS DateTime), 1, N'Reserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (143, CAST(N'2023-12-03T16:24:59.197' AS DateTime), 1, N'FacturarReserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (144, CAST(N'2023-12-03T16:25:58.633' AS DateTime), 1, N'Usuarios', N'Logout', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (145, CAST(N'2023-12-03T16:26:12.597' AS DateTime), 4, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (146, CAST(N'2023-12-03T16:28:45.353' AS DateTime), 4, N'Clientes', N'Alta', 2)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (147, CAST(N'2023-12-03T16:29:30.630' AS DateTime), 4, N'Reserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (148, CAST(N'2023-12-03T16:29:43.177' AS DateTime), 4, N'Usuarios', N'Logout', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (149, CAST(N'2023-12-03T16:30:02.333' AS DateTime), 5, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (150, CAST(N'2023-12-03T16:30:18.637' AS DateTime), 5, N'FacturarReserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (151, CAST(N'2023-12-03T16:38:02.097' AS DateTime), 5, N'Usuarios', N'Logout', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (152, CAST(N'2023-12-03T16:44:50.637' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (153, CAST(N'2023-12-03T16:46:27.550' AS DateTime), 1, N'Reporte', N'ExportarReporte1', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (154, CAST(N'2023-12-03T16:49:21.070' AS DateTime), 1, N'Clientes', N'Alta', 2)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (155, CAST(N'2023-12-03T16:50:17.593' AS DateTime), 1, N'Reserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (156, CAST(N'2023-12-03T16:50:53.107' AS DateTime), 1, N'FacturarReserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (157, CAST(N'2023-12-03T18:07:14.273' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (158, CAST(N'2023-12-03T18:09:54.957' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (159, CAST(N'2023-12-04T07:35:14.273' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (160, CAST(N'2023-12-04T08:17:53.407' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (161, CAST(N'2023-12-04T08:18:15.073' AS DateTime), 1, N'Checkout', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (162, CAST(N'2023-12-04T08:18:59.943' AS DateTime), 1, N'FacturarEstadia', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (163, CAST(N'2023-12-04T08:19:42.353' AS DateTime), 1, N'Checkout', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (164, CAST(N'2023-12-04T08:20:19.893' AS DateTime), 1, N'FacturarEstadia', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (165, CAST(N'2023-12-04T08:20:54.553' AS DateTime), 1, N'Checkout', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (166, CAST(N'2023-12-04T08:21:19.300' AS DateTime), 1, N'FacturarEstadia', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (167, CAST(N'2023-12-04T08:22:48.617' AS DateTime), 1, N'Checkout', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (168, CAST(N'2023-12-04T08:23:11.860' AS DateTime), 1, N'FacturarEstadia', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (169, CAST(N'2023-12-04T09:57:27.793' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (170, CAST(N'2023-12-04T10:12:46.873' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (171, CAST(N'2023-12-04T12:45:21.133' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (172, CAST(N'2023-12-04T13:22:14.713' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (173, CAST(N'2023-12-04T14:25:15.010' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (174, CAST(N'2023-12-04T14:40:40.450' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (175, CAST(N'2023-12-04T16:21:09.703' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (176, CAST(N'2023-12-04T16:25:02.443' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (177, CAST(N'2023-12-04T16:28:10.223' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (178, CAST(N'2023-12-04T18:59:47.027' AS DateTime), 1, N'Reporte', N'ExportarReporte1', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (179, CAST(N'2023-12-04T19:07:41.273' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (180, CAST(N'2023-12-04T19:17:14.387' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (181, CAST(N'2023-12-04T19:19:23.110' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (182, CAST(N'2023-12-04T19:29:57.737' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (183, CAST(N'2023-12-04T19:30:10.937' AS DateTime), 1, N'Reporte', N'ExportarReporte2', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (184, CAST(N'2023-12-04T19:30:42.910' AS DateTime), 1, N'Usuarios', N'Logout', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (185, CAST(N'2023-12-04T19:39:04.620' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (186, CAST(N'2023-12-04T19:44:40.030' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (187, CAST(N'2023-12-04T19:46:30.780' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (188, CAST(N'2023-12-04T19:47:05.210' AS DateTime), 1, N'Perfiles', N'Alta', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (189, CAST(N'2023-12-04T21:28:18.393' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (190, CAST(N'2023-12-04T21:34:44.473' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (191, CAST(N'2023-12-04T22:21:12.603' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (192, CAST(N'2023-12-04T22:35:07.753' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (193, CAST(N'2023-12-04T22:45:53.663' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (194, CAST(N'2023-12-04T22:54:59.797' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (195, CAST(N'2023-12-04T22:58:41.193' AS DateTime), 1, N'Reporte', N'ExportarReporte1', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (196, CAST(N'2023-12-05T09:11:28.413' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (197, CAST(N'2023-12-05T09:14:58.533' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (198, CAST(N'2023-12-05T09:15:33.487' AS DateTime), 1, N'Reporte', N'ExportarReporte1', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (199, CAST(N'2023-12-05T09:17:06.237' AS DateTime), 1, N'Reporte', N'ExportarReporte2', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (200, CAST(N'2023-12-05T14:43:55.170' AS DateTime), 1, N'Usuarios', N'Login', 1)
GO
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (201, CAST(N'2023-12-05T14:44:23.513' AS DateTime), 1, N'Usuarios', N'Logout', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (202, CAST(N'2023-12-05T22:48:50.027' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (203, CAST(N'2023-12-05T22:52:03.383' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (204, CAST(N'2023-12-06T18:56:19.097' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (205, CAST(N'2023-12-06T18:57:35.803' AS DateTime), 1, N'Checkout', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (206, CAST(N'2023-12-06T18:57:57.817' AS DateTime), 1, N'FacturarEstadia', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (207, CAST(N'2023-12-06T18:58:44.797' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (208, CAST(N'2023-12-06T18:59:05.440' AS DateTime), 1, N'Reserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (209, CAST(N'2023-12-06T18:59:25.683' AS DateTime), 1, N'FacturarReserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (210, CAST(N'2023-12-06T19:00:17.330' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (211, CAST(N'2023-12-06T19:00:31.333' AS DateTime), 1, N'Checkin', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (212, CAST(N'2023-12-07T08:24:39.850' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (213, CAST(N'2023-12-07T08:57:20.200' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (214, CAST(N'2023-12-07T09:59:09.273' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (215, CAST(N'2023-12-07T10:03:43.350' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (216, CAST(N'2023-12-07T10:04:16.507' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (217, CAST(N'2023-12-07T10:06:40.660' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (218, CAST(N'2023-12-07T11:07:09.860' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (219, CAST(N'2023-12-07T15:03:12.370' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (220, CAST(N'2023-12-07T15:03:36.857' AS DateTime), 1, N'Checkout', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (221, CAST(N'2023-12-07T15:03:59.303' AS DateTime), 1, N'FacturarEstadia', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (222, CAST(N'2023-12-07T15:06:00.200' AS DateTime), 1, N'Clientes', N'Alta', 2)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (223, CAST(N'2023-12-07T15:07:06.120' AS DateTime), 1, N'Clientes', N'Alta', 2)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (224, CAST(N'2023-12-07T15:08:09.267' AS DateTime), 1, N'Clientes', N'Alta', 2)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (225, CAST(N'2023-12-07T15:08:56.613' AS DateTime), 1, N'Clientes', N'Alta', 2)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (226, CAST(N'2023-12-07T15:10:46.700' AS DateTime), 1, N'Clientes', N'Alta', 2)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (227, CAST(N'2023-12-07T15:11:15.950' AS DateTime), 1, N'Reserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (228, CAST(N'2023-12-07T15:11:57.913' AS DateTime), 1, N'Reserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (229, CAST(N'2023-12-07T15:12:29.683' AS DateTime), 1, N'Reserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (230, CAST(N'2023-12-07T15:12:57.857' AS DateTime), 1, N'Reserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (231, CAST(N'2023-12-07T15:13:24.030' AS DateTime), 1, N'Reserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (232, CAST(N'2023-12-07T15:16:10.530' AS DateTime), 1, N'FacturarReserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (233, CAST(N'2023-12-07T15:16:32.393' AS DateTime), 1, N'FacturarReserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (234, CAST(N'2023-12-07T15:16:55.063' AS DateTime), 1, N'FacturarReserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (235, CAST(N'2023-12-07T15:17:11.330' AS DateTime), 1, N'FacturarReserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (236, CAST(N'2023-12-07T15:17:32.193' AS DateTime), 1, N'FacturarReserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (237, CAST(N'2023-12-07T15:18:42.917' AS DateTime), 1, N'Checkin', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (238, CAST(N'2023-12-07T15:18:59.127' AS DateTime), 1, N'Checkin', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (239, CAST(N'2023-12-07T15:19:13.560' AS DateTime), 1, N'Checkin', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (240, CAST(N'2023-12-07T15:19:27.770' AS DateTime), 1, N'Checkin', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (241, CAST(N'2023-12-07T15:19:46.397' AS DateTime), 1, N'Checkin', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (242, CAST(N'2023-12-10T16:39:21.750' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (243, CAST(N'2023-12-10T16:45:08.217' AS DateTime), 1, N'Checkout', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (244, CAST(N'2023-12-10T16:45:33.703' AS DateTime), 1, N'FacturarEstadia', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (245, CAST(N'2023-12-10T16:46:19.250' AS DateTime), 1, N'Checkout', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (246, CAST(N'2023-12-10T16:46:47.220' AS DateTime), 1, N'FacturarEstadia', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (247, CAST(N'2023-12-10T16:47:45.073' AS DateTime), 1, N'Checkout', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (248, CAST(N'2023-12-10T16:48:59.550' AS DateTime), 1, N'FacturarEstadia', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (249, CAST(N'2023-12-10T16:49:46.753' AS DateTime), 1, N'Checkout', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (250, CAST(N'2023-12-10T16:50:11.167' AS DateTime), 1, N'FacturarEstadia', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (251, CAST(N'2023-12-10T16:51:28.877' AS DateTime), 1, N'Checkout', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (252, CAST(N'2023-12-10T16:51:54.370' AS DateTime), 1, N'FacturarEstadia', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (253, CAST(N'2023-12-10T18:35:10.560' AS DateTime), 1, N'Reporte', N'ExportarReporte2', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (254, CAST(N'2023-12-10T19:14:10.897' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (255, CAST(N'2023-12-11T10:00:46.623' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (256, CAST(N'2023-12-11T10:01:57.350' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (257, CAST(N'2023-12-11T10:04:48.587' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (258, CAST(N'2023-12-11T10:08:43.457' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (259, CAST(N'2023-12-11T14:39:04.390' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (260, CAST(N'2023-12-11T14:54:01.807' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (261, CAST(N'2023-12-11T14:55:57.460' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (262, CAST(N'2023-12-11T14:59:29.360' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (263, CAST(N'2023-12-11T15:06:12.163' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (264, CAST(N'2023-12-11T15:07:53.217' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (265, CAST(N'2023-12-11T15:09:07.257' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (266, CAST(N'2023-12-11T15:33:07.587' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (267, CAST(N'2023-12-11T15:55:57.580' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (268, CAST(N'2023-12-11T17:08:16.393' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (269, CAST(N'2023-12-11T17:39:50.630' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (270, CAST(N'2023-12-11T19:56:35.067' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (271, CAST(N'2023-12-11T20:00:59.093' AS DateTime), 1, N'Reporte', N'ExportarReporte2', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (272, CAST(N'2024-01-06T18:12:26.127' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (273, CAST(N'2024-01-07T11:12:37.577' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (274, CAST(N'2024-01-07T12:16:12.623' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (275, CAST(N'2024-01-10T07:10:32.670' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (276, CAST(N'2024-01-10T07:57:43.043' AS DateTime), 1, N'Clientes', N'Alta', 2)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (277, CAST(N'2024-01-10T07:58:52.057' AS DateTime), 1, N'Reserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (278, CAST(N'2024-01-10T07:59:11.583' AS DateTime), 1, N'FacturarReserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (279, CAST(N'2024-01-10T08:02:33.197' AS DateTime), 1, N'Checkin', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (280, CAST(N'2024-01-10T08:02:37.787' AS DateTime), 1, N'Usuarios', N'Logout', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (281, CAST(N'2024-01-16T10:38:52.833' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (282, CAST(N'2024-01-16T11:47:35.610' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (283, CAST(N'2024-01-16T11:51:31.007' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (284, CAST(N'2024-01-16T14:54:59.067' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (285, CAST(N'2024-01-21T10:33:58.197' AS DateTime), 4, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (286, CAST(N'2024-01-21T10:39:29.260' AS DateTime), 4, N'Reserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (287, CAST(N'2024-01-21T10:39:35.833' AS DateTime), 4, N'Usuarios', N'Logout', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (288, CAST(N'2024-01-21T10:41:23.867' AS DateTime), 5, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (289, CAST(N'2024-01-21T10:41:42.393' AS DateTime), 5, N'FacturarReserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (290, CAST(N'2024-01-21T10:41:51.347' AS DateTime), 5, N'Usuarios', N'Logout', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (291, CAST(N'2024-01-21T10:45:13.813' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (292, CAST(N'2024-01-21T10:45:45.763' AS DateTime), 1, N'Checkin', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (293, CAST(N'2024-01-21T10:55:59.903' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (294, CAST(N'2024-01-21T10:58:13.260' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (295, CAST(N'2024-01-21T11:03:24.283' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (296, CAST(N'2024-01-21T11:05:17.107' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (297, CAST(N'2024-01-21T11:23:07.370' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (298, CAST(N'2024-01-21T11:23:49.337' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (299, CAST(N'2024-01-21T11:25:05.867' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (300, CAST(N'2024-01-21T17:12:40.467' AS DateTime), 1, N'Usuarios', N'Login', 1)
GO
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (301, CAST(N'2024-01-21T17:14:02.857' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (302, CAST(N'2024-01-21T18:05:32.167' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (303, CAST(N'2024-01-21T18:15:52.210' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (304, CAST(N'2024-01-21T18:18:49.103' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (305, CAST(N'2024-01-21T18:20:44.167' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (306, CAST(N'2024-01-22T09:44:25.060' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (307, CAST(N'2024-01-22T09:46:29.433' AS DateTime), 1, N'Checkout', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (308, CAST(N'2024-01-22T09:47:00.390' AS DateTime), 1, N'FacturarEstadia', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (309, CAST(N'2024-01-22T11:40:34.190' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (310, CAST(N'2024-01-27T18:07:55.573' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (311, CAST(N'2024-01-27T18:14:20.490' AS DateTime), 1, N'Clientes', N'Alta', 2)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (312, CAST(N'2024-01-27T18:17:11.070' AS DateTime), 1, N'Reserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (313, CAST(N'2024-01-27T18:17:38.830' AS DateTime), 1, N'FacturarReserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (314, CAST(N'2024-01-27T18:19:56.350' AS DateTime), 1, N'Checkin', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (315, CAST(N'2024-01-27T18:53:50.867' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (316, CAST(N'2024-01-27T18:59:01.220' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (317, CAST(N'2024-01-27T19:00:15.103' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (318, CAST(N'2024-01-27T19:02:53.567' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (319, CAST(N'2024-01-27T19:03:52.520' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (320, CAST(N'2024-01-27T19:18:38.620' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (321, CAST(N'2024-01-27T19:20:11.260' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (322, CAST(N'2024-01-27T19:25:10.217' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (323, CAST(N'2024-01-27T19:29:20.193' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (324, CAST(N'2024-01-27T19:30:35.390' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (325, CAST(N'2024-01-27T19:35:14.540' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (326, CAST(N'2024-01-27T19:36:39.933' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (327, CAST(N'2024-01-27T19:37:34.907' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (328, CAST(N'2024-01-27T20:23:36.503' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (329, CAST(N'2024-01-27T20:35:34.087' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (330, CAST(N'2024-01-30T08:54:42.273' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (331, CAST(N'2024-01-30T08:56:34.547' AS DateTime), 1, N'Checkout', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (332, CAST(N'2024-01-30T08:57:18.627' AS DateTime), 1, N'FacturarEstadia', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (333, CAST(N'2024-01-30T08:59:03.243' AS DateTime), 1, N'Usuarios', N'Logout', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (334, CAST(N'2024-01-30T09:01:40.900' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (335, CAST(N'2024-01-30T09:15:14.240' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (336, CAST(N'2024-01-30T09:16:27.493' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (337, CAST(N'2024-01-30T09:18:40.823' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (338, CAST(N'2024-01-30T09:22:57.867' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (339, CAST(N'2024-01-30T09:25:02.047' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (340, CAST(N'2024-01-30T09:26:39.907' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (341, CAST(N'2024-01-30T09:26:58.247' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (342, CAST(N'2024-01-30T09:28:33.490' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (343, CAST(N'2024-01-30T09:30:25.890' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (344, CAST(N'2024-01-30T09:32:07.917' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (345, CAST(N'2024-01-30T09:34:34.757' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (346, CAST(N'2024-01-30T09:50:59.863' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (347, CAST(N'2024-01-30T10:18:46.553' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (348, CAST(N'2024-01-30T10:20:13.420' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (349, CAST(N'2024-01-30T10:43:51.623' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (350, CAST(N'2024-01-30T10:47:41.000' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (351, CAST(N'2024-01-30T11:10:10.140' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (352, CAST(N'2024-01-30T11:29:21.373' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (353, CAST(N'2024-01-30T11:30:43.817' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (354, CAST(N'2024-01-30T14:16:39.270' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (355, CAST(N'2024-01-30T14:18:10.090' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (356, CAST(N'2024-01-30T14:41:29.883' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (357, CAST(N'2024-01-30T22:18:25.927' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (358, CAST(N'2024-01-30T22:22:23.050' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (359, CAST(N'2024-01-30T22:23:20.723' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (360, CAST(N'2024-01-30T22:36:11.533' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (361, CAST(N'2024-01-30T22:48:09.540' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (362, CAST(N'2024-01-30T22:52:02.840' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (363, CAST(N'2024-01-30T22:56:20.003' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (364, CAST(N'2024-01-30T22:59:14.083' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (365, CAST(N'2024-01-30T23:03:56.497' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (366, CAST(N'2024-01-30T23:09:44.920' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (367, CAST(N'2024-02-01T10:05:19.150' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (368, CAST(N'2024-02-01T10:17:44.827' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (369, CAST(N'2024-02-01T13:52:00.150' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (370, CAST(N'2024-02-01T13:59:53.270' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (371, CAST(N'2024-02-01T14:07:04.623' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (372, CAST(N'2024-02-01T14:36:13.300' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (373, CAST(N'2024-02-03T12:03:35.377' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (374, CAST(N'2024-02-03T12:15:07.923' AS DateTime), 1, N'Reserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (375, CAST(N'2024-02-03T12:15:33.417' AS DateTime), 1, N'FacturarReserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (376, CAST(N'2024-02-03T12:16:45.270' AS DateTime), 1, N'Checkin', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (377, CAST(N'2024-02-03T12:24:42.163' AS DateTime), 1, N'Clientes', N'Alta', 2)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (378, CAST(N'2024-02-03T12:25:15.513' AS DateTime), 1, N'Reserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (379, CAST(N'2024-02-03T12:32:53.760' AS DateTime), 1, N'Clientes', N'Alta', 2)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (380, CAST(N'2024-02-03T12:33:17.890' AS DateTime), 1, N'Reserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (381, CAST(N'2024-02-03T12:33:50.193' AS DateTime), 1, N'FacturarReserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (382, CAST(N'2024-02-03T12:34:10.763' AS DateTime), 1, N'FacturarReserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (383, CAST(N'2024-02-03T12:38:38.497' AS DateTime), 1, N'Checkin', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (384, CAST(N'2024-02-03T12:39:04.310' AS DateTime), 1, N'Checkin', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (385, CAST(N'2024-02-03T18:03:04.753' AS DateTime), 1, N'Usuarios', N'LoginIncorrecto', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (386, CAST(N'2024-02-03T18:03:11.500' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (387, CAST(N'2024-02-03T18:05:52.730' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (388, CAST(N'2024-02-03T18:15:35.170' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (389, CAST(N'2024-02-03T18:19:36.420' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (390, CAST(N'2024-02-03T18:35:42.023' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (391, CAST(N'2024-02-03T18:37:55.270' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (392, CAST(N'2024-02-03T18:43:06.533' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (393, CAST(N'2024-02-03T18:46:26.763' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (394, CAST(N'2024-02-03T18:58:25.600' AS DateTime), 1, N'Clientes', N'Alta', 2)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (395, CAST(N'2024-02-03T18:58:47.473' AS DateTime), 1, N'Reserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (396, CAST(N'2024-02-03T18:59:09.073' AS DateTime), 1, N'FacturarReserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (397, CAST(N'2024-02-03T18:59:51.780' AS DateTime), 1, N'Checkin', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (398, CAST(N'2024-02-03T19:04:41.057' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (399, CAST(N'2024-02-04T10:28:08.797' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (400, CAST(N'2024-02-04T10:34:36.133' AS DateTime), 1, N'Clientes', N'Alta', 2)
GO
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (401, CAST(N'2024-02-04T10:34:56.770' AS DateTime), 1, N'Reserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (402, CAST(N'2024-02-04T10:35:20.303' AS DateTime), 1, N'FacturarReserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (403, CAST(N'2024-02-04T10:35:56.597' AS DateTime), 1, N'Checkin', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (404, CAST(N'2024-02-04T10:36:46.187' AS DateTime), 1, N'Checkout', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (405, CAST(N'2024-02-04T10:37:58.850' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (406, CAST(N'2024-02-04T10:39:09.500' AS DateTime), 1, N'FacturarEstadia', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (407, CAST(N'2024-02-04T10:41:53.190' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (408, CAST(N'2024-02-04T10:45:58.100' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (409, CAST(N'2024-02-04T15:04:26.220' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (410, CAST(N'2024-02-04T16:15:41.700' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (411, CAST(N'2024-02-04T16:26:00.227' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (412, CAST(N'2024-02-04T16:26:36.580' AS DateTime), 1, N'Reporte', N'ExportarReporte3', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (413, CAST(N'2024-02-04T16:27:54.280' AS DateTime), 1, N'Usuarios', N'Logout', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (414, CAST(N'2024-02-05T08:39:20.227' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (415, CAST(N'2024-02-05T15:44:26.507' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (416, CAST(N'2024-02-05T15:44:38.023' AS DateTime), 1, N'Checkout', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (417, CAST(N'2024-02-05T15:45:05.620' AS DateTime), 1, N'Checkout', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (418, CAST(N'2024-02-05T15:45:29.430' AS DateTime), 1, N'Checkout', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (419, CAST(N'2024-02-05T15:45:52.577' AS DateTime), 1, N'FacturarEstadia', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (420, CAST(N'2024-02-05T15:46:11.490' AS DateTime), 1, N'FacturarEstadia', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (421, CAST(N'2024-02-05T15:46:23.717' AS DateTime), 1, N'FacturarEstadia', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (422, CAST(N'2024-02-05T21:07:19.943' AS DateTime), 1, N'Usuarios', N'Logout', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (423, CAST(N'2024-02-10T09:42:45.427' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (424, CAST(N'2024-02-10T09:46:42.253' AS DateTime), 1, N'Reporte', N'ExportarReporte3', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (425, CAST(N'2024-02-10T09:48:40.877' AS DateTime), 1, N'Checkout', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (426, CAST(N'2024-02-10T09:49:14.587' AS DateTime), 1, N'FacturarEstadia', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (427, CAST(N'2024-02-10T09:51:29.613' AS DateTime), 1, N'Usuarios', N'Logout', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (428, CAST(N'2024-02-13T14:58:10.310' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (429, CAST(N'2024-02-13T14:58:42.810' AS DateTime), 1, N'Usuarios', N'Logout', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (430, CAST(N'2024-02-25T19:41:32.420' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (431, CAST(N'2024-02-25T19:41:37.497' AS DateTime), 1, N'Usuarios', N'Logout', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (432, CAST(N'2024-02-25T19:42:10.033' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (433, CAST(N'2024-02-25T19:55:01.590' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (434, CAST(N'2024-02-25T20:01:44.570' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (435, CAST(N'2024-02-25T20:01:50.567' AS DateTime), 1, N'Usuarios', N'Logout', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (436, CAST(N'2024-02-25T20:46:37.270' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (437, CAST(N'2024-02-25T20:50:30.397' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (438, CAST(N'2024-02-25T21:02:50.840' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (439, CAST(N'2024-02-25T21:09:10.783' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (440, CAST(N'2024-02-25T21:10:40.727' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (441, CAST(N'2024-02-25T21:12:10.080' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (442, CAST(N'2024-02-25T21:14:47.800' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (443, CAST(N'2024-02-25T21:18:49.877' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (444, CAST(N'2024-02-25T21:19:12.473' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (445, CAST(N'2024-02-25T22:04:09.553' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (446, CAST(N'2024-02-25T22:04:42.130' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (447, CAST(N'2024-02-25T22:06:14.867' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (448, CAST(N'2024-02-25T22:13:07.397' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (449, CAST(N'2024-02-25T23:41:52.710' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (450, CAST(N'2024-02-25T23:57:30.117' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (451, CAST(N'2024-02-25T23:58:25.490' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (452, CAST(N'2024-02-29T09:30:08.550' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (453, CAST(N'2024-03-02T12:11:03.583' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (454, CAST(N'2024-03-02T12:28:30.637' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (455, CAST(N'2024-03-02T12:47:25.067' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (456, CAST(N'2024-03-02T13:00:03.147' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (457, CAST(N'2024-03-02T20:27:06.853' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (458, CAST(N'2024-03-03T12:37:30.743' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (459, CAST(N'2024-03-03T12:39:06.717' AS DateTime), 1, N'Reporte', N'ExportarReporte1', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (460, CAST(N'2024-03-03T12:41:37.040' AS DateTime), 1, N'Usuarios', N'Logout', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (461, CAST(N'2024-03-03T21:52:19.087' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (462, CAST(N'2024-03-03T22:44:22.227' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (463, CAST(N'2024-03-04T09:21:49.440' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (464, CAST(N'2024-03-04T09:35:32.677' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (465, CAST(N'2024-03-04T10:33:31.520' AS DateTime), 1, N'Clientes', N'Alta', 2)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (466, CAST(N'2024-03-04T10:33:59.417' AS DateTime), 1, N'Reserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (467, CAST(N'2024-03-04T10:46:42.527' AS DateTime), 1, N'FacturarReserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (468, CAST(N'2024-03-04T11:39:57.757' AS DateTime), 1, N'Checkin', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (469, CAST(N'2024-03-04T14:12:08.270' AS DateTime), 1, N'Usuarios', N'Logout', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (470, CAST(N'2024-03-04T14:32:02.813' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (471, CAST(N'2024-03-04T14:49:19.333' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (472, CAST(N'2024-03-04T19:22:46.277' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (473, CAST(N'2024-03-04T19:23:14.380' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (474, CAST(N'2024-03-04T19:59:06.973' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (475, CAST(N'2024-03-05T07:51:29.820' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (476, CAST(N'2024-03-05T09:19:28.390' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (477, CAST(N'2024-03-05T12:39:44.890' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (478, CAST(N'2024-03-05T12:55:58.653' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (479, CAST(N'2024-03-05T13:13:11.613' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (480, CAST(N'2024-03-05T13:18:36.203' AS DateTime), 1, N'GestorUsuario', N'Modificacion', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (481, CAST(N'2024-03-05T13:40:22.077' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (482, CAST(N'2024-03-05T14:30:19.460' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (483, CAST(N'2024-03-05T15:17:26.917' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (484, CAST(N'2024-03-05T15:36:10.830' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (485, CAST(N'2024-03-05T15:36:53.683' AS DateTime), 1, N'Checkout', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (486, CAST(N'2024-03-05T17:47:45.173' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (487, CAST(N'2024-03-05T17:49:04.767' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (488, CAST(N'2024-03-05T18:21:42.997' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (489, CAST(N'2024-03-05T18:29:46.877' AS DateTime), 1, N'Clientes', N'Alta', 2)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (490, CAST(N'2024-03-05T18:30:21.303' AS DateTime), 1, N'Reserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (491, CAST(N'2024-03-05T18:30:55.193' AS DateTime), 1, N'FacturarReserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (492, CAST(N'2024-03-05T20:23:16.133' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (493, CAST(N'2024-03-05T20:24:16.543' AS DateTime), 1, N'Checkin', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (494, CAST(N'2024-03-05T20:59:37.387' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (495, CAST(N'2024-03-05T21:01:10.243' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (496, CAST(N'2024-03-05T21:03:29.760' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (497, CAST(N'2024-03-05T21:11:22.340' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (498, CAST(N'2024-03-05T21:13:31.717' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (499, CAST(N'2024-03-05T21:19:45.283' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (500, CAST(N'2024-03-05T21:26:22.563' AS DateTime), 1, N'Usuarios', N'Login', 1)
GO
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (501, CAST(N'2024-03-05T22:22:05.717' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (502, CAST(N'2024-03-05T22:25:32.670' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (503, CAST(N'2024-03-05T22:26:31.760' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (504, CAST(N'2024-03-05T22:28:14.263' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (505, CAST(N'2024-03-05T22:38:55.933' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (506, CAST(N'2024-03-05T23:10:33.153' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (507, CAST(N'2024-03-05T23:11:45.700' AS DateTime), 1, N'FacturarEstadia', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (508, CAST(N'2024-03-05T23:29:34.367' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (509, CAST(N'2024-03-05T23:31:46.430' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (510, CAST(N'2024-03-05T23:33:55.903' AS DateTime), 4, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (511, CAST(N'2024-03-05T23:35:20.183' AS DateTime), 4, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (512, CAST(N'2024-03-05T23:35:42.203' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (513, CAST(N'2024-03-05T23:35:58.350' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (514, CAST(N'2024-03-05T23:39:16.970' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (515, CAST(N'2024-03-06T07:20:24.913' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (516, CAST(N'2024-03-06T07:25:41.727' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (517, CAST(N'2024-03-06T07:27:45.153' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (518, CAST(N'2024-03-06T07:28:42.493' AS DateTime), 1, N'Usuarios', N'Logout', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (519, CAST(N'2024-03-06T07:35:23.250' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (520, CAST(N'2024-03-06T07:39:34.477' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (521, CAST(N'2024-03-06T07:41:46.953' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (522, CAST(N'2024-03-06T07:50:02.400' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (523, CAST(N'2024-03-06T08:06:58.367' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (524, CAST(N'2024-03-06T08:07:36.107' AS DateTime), 5, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (525, CAST(N'2024-03-06T08:09:07.803' AS DateTime), 4, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (526, CAST(N'2024-03-06T08:09:18.447' AS DateTime), 4, N'Usuarios', N'Logout', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (527, CAST(N'2024-03-06T08:09:29.907' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (528, CAST(N'2024-03-06T08:59:38.007' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (529, CAST(N'2024-03-06T09:42:02.913' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (530, CAST(N'2024-03-06T10:23:03.283' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (531, CAST(N'2024-03-06T10:41:04.517' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (532, CAST(N'2024-03-06T11:24:25.123' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (533, CAST(N'2024-03-06T11:24:36.440' AS DateTime), 1, N'Checkout', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (534, CAST(N'2024-03-06T11:24:58.760' AS DateTime), 1, N'FacturarEstadia', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (535, CAST(N'2024-03-06T11:27:48.833' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (536, CAST(N'2024-03-06T11:28:45.040' AS DateTime), 1, N'Reserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (537, CAST(N'2024-03-06T11:34:07.563' AS DateTime), 1, N'FacturarReserva', N'Alta', 3)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (538, CAST(N'2024-03-06T14:22:38.100' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (539, CAST(N'2024-03-07T13:30:19.030' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (540, CAST(N'2024-03-07T13:32:50.360' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (541, CAST(N'2024-03-07T13:37:09.063' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (542, CAST(N'2024-03-07T13:38:48.590' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (543, CAST(N'2024-03-07T13:41:42.810' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (544, CAST(N'2024-03-07T13:52:41.407' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (545, CAST(N'2024-03-07T16:27:25.983' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (546, CAST(N'2024-03-07T16:28:27.483' AS DateTime), 1, N'Usuarios', N'Logout', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (547, CAST(N'2024-03-07T19:18:32.293' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (548, CAST(N'2024-03-07T21:22:31.133' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (549, CAST(N'2024-03-07T21:23:38.013' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (550, CAST(N'2024-03-07T21:24:46.620' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (551, CAST(N'2024-03-07T21:27:16.260' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (552, CAST(N'2024-03-08T09:52:14.793' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (553, CAST(N'2024-03-08T09:55:05.640' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (554, CAST(N'2024-03-08T10:38:40.557' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (555, CAST(N'2024-03-08T10:39:28.667' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (556, CAST(N'2024-03-08T10:45:00.183' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (557, CAST(N'2024-03-08T10:45:22.333' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (558, CAST(N'2024-03-08T10:47:47.493' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (559, CAST(N'2024-03-08T10:48:40.537' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (560, CAST(N'2024-03-08T10:52:45.893' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (561, CAST(N'2024-03-08T10:59:05.140' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (562, CAST(N'2024-03-08T11:31:13.927' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (563, CAST(N'2024-03-08T11:38:11.463' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (564, CAST(N'2024-03-08T11:48:30.030' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (565, CAST(N'2024-03-08T11:48:49.333' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (566, CAST(N'2024-03-08T13:18:11.180' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (567, CAST(N'2024-03-08T13:53:03.573' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (568, CAST(N'2024-03-08T13:54:33.453' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (569, CAST(N'2024-03-08T14:22:28.200' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (570, CAST(N'2024-03-10T10:15:27.870' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (571, CAST(N'2024-03-10T10:15:53.437' AS DateTime), 1, N'Clientes', N'Consulta', 2)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (572, CAST(N'2024-03-10T10:15:54.127' AS DateTime), 1, N'Clientes', N'Consulta', 2)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (573, CAST(N'2024-03-10T10:15:54.957' AS DateTime), 1, N'Clientes', N'Consulta', 2)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (574, CAST(N'2024-03-10T20:30:37.890' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (575, CAST(N'2024-03-10T20:48:11.813' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (576, CAST(N'2024-03-10T23:14:58.920' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (577, CAST(N'2024-03-10T23:46:09.593' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (578, CAST(N'2024-03-10T23:53:31.893' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (579, CAST(N'2024-03-11T07:44:12.443' AS DateTime), 4, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (580, CAST(N'2024-03-11T09:54:33.700' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (581, CAST(N'2024-03-11T10:53:10.120' AS DateTime), 1, N'Usuarios', N'Login', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [id_usuario], [modulo], [operacion], [criticidad]) VALUES (582, CAST(N'2024-03-11T10:53:33.563' AS DateTime), 1, N'Usuarios', N'Login', 1)
GO
INSERT [dbo].[Cliente] ([id], [nombre], [apellido], [dni], [telefono_fijo], [telefono_movil], [domicilio], [email], [borrado]) VALUES (1, N'Rosario', N'Puppo', 41667517, N'-', N'-', N'-', N'charitopuppo98@gmail.com', 0)
INSERT [dbo].[Cliente] ([id], [nombre], [apellido], [dni], [telefono_fijo], [telefono_movil], [domicilio], [email], [borrado]) VALUES (2, N'Antonella Soledad', N'Maidana', 37460504, N'-', N'-', N'Catamarca 234 - CABA', N'antonellasmaidana@gmail.com', 0)
INSERT [dbo].[Cliente] ([id], [nombre], [apellido], [dni], [telefono_fijo], [telefono_movil], [domicilio], [email], [borrado]) VALUES (3, N'Marcia Adriana', N'Garay', 30861453, N'-', N'-', N'Chile 1836 - CABA', N'garay_mar@hotmail.com', 0)
INSERT [dbo].[Cliente] ([id], [nombre], [apellido], [dni], [telefono_fijo], [telefono_movil], [domicilio], [email], [borrado]) VALUES (4, N'Ayelen', N'Simonetti', 35146448, N'-', N'-', N'Miranda 4571 - CABA', N'ayelen.simonettispf@gmail.com', 0)
INSERT [dbo].[Cliente] ([id], [nombre], [apellido], [dni], [telefono_fijo], [telefono_movil], [domicilio], [email], [borrado]) VALUES (5, N'Walter Marcelo', N'Cejas', 35951531, N'-', N'-', N'Lisandro de la Torre - MERLO', N'-', 0)
INSERT [dbo].[Cliente] ([id], [nombre], [apellido], [dni], [telefono_fijo], [telefono_movil], [domicilio], [email], [borrado]) VALUES (6, N'Andrea Celeste', N'Gomez', 34633294, N'-', N'-', N'San Jose 311 - Barrio La Union', N'gomezlasa@gmail.com', 0)
INSERT [dbo].[Cliente] ([id], [nombre], [apellido], [dni], [telefono_fijo], [telefono_movil], [domicilio], [email], [borrado]) VALUES (7, N'Carlos Antonio', N'Fretes', 35262657, N'-', N'-', N'-', N'carlosfrete25@gmail.com', 0)
INSERT [dbo].[Cliente] ([id], [nombre], [apellido], [dni], [telefono_fijo], [telefono_movil], [domicilio], [email], [borrado]) VALUES (8, N'Marcela Elizabeth', N'Miño', 31630117, N'-', N'-', N'Esteban Echeverria 155 - Wilde', N'marcely_m21@hotmail.com', 0)
INSERT [dbo].[Cliente] ([id], [nombre], [apellido], [dni], [telefono_fijo], [telefono_movil], [domicilio], [email], [borrado]) VALUES (9, N'Lourdes', N'Escobar', 38152056, N'-', N'-', N'Damaso Larrañaga 757 - CABA', N'lourdes.esco94@gmail.com', 0)
INSERT [dbo].[Cliente] ([id], [nombre], [apellido], [dni], [telefono_fijo], [telefono_movil], [domicilio], [email], [borrado]) VALUES (10, N'Gonzalo Andres', N'Vega', 39626457, N'46371813', N'-', N'Francisco Bilbao 2883 - CABA', N'goommza.-@hotmail.com', 0)
INSERT [dbo].[Cliente] ([id], [nombre], [apellido], [dni], [telefono_fijo], [telefono_movil], [domicilio], [email], [borrado]) VALUES (11, N'Nestor Fabian', N'Abarrategui', 18395963, N'-', N'-', N'-', N'-', 0)
INSERT [dbo].[Cliente] ([id], [nombre], [apellido], [dni], [telefono_fijo], [telefono_movil], [domicilio], [email], [borrado]) VALUES (12, N'Evelin Yamila', N'Caceres', 36872608, N'-', N'-', N'-', N'-', 0)
INSERT [dbo].[Cliente] ([id], [nombre], [apellido], [dni], [telefono_fijo], [telefono_movil], [domicilio], [email], [borrado]) VALUES (13, N'Walter Alfredo', N'Reyes', 30174283, N'-', N'-', N'-', N'-', 0)
INSERT [dbo].[Cliente] ([id], [nombre], [apellido], [dni], [telefono_fijo], [telefono_movil], [domicilio], [email], [borrado]) VALUES (14, N'Lucas Ezequiel', N'Andrades', 38067016, N'-', N'-', N'Agustin de Vedia 1978 - San Justo', N'lucaas.lt@live.com', 0)
INSERT [dbo].[Cliente] ([id], [nombre], [apellido], [dni], [telefono_fijo], [telefono_movil], [domicilio], [email], [borrado]) VALUES (15, N'Cielo Ailin', N'Villagra', 42631282, N'-', N'1124093537', N'Chacabuco 28 - Ezeiza', N'ailin06v@gmail.com', 0)
INSERT [dbo].[Cliente] ([id], [nombre], [apellido], [dni], [telefono_fijo], [telefono_movil], [domicilio], [email], [borrado]) VALUES (16, N'Araceli Ramona', N'Costadoni', 38971993, N'-', N'-', N'Lavalle 2966 - CABA', N'aracostadoni@gmail.com', 0)
INSERT [dbo].[Cliente] ([id], [nombre], [apellido], [dni], [telefono_fijo], [telefono_movil], [domicilio], [email], [borrado]) VALUES (17, N'María Agustina', N'Bracamonte', 33881733, N'-', N'-', N'Corrientes 3859 - Piso 16 - Dpto F - CABA', N'magusbral@gmail.com', 0)
INSERT [dbo].[Cliente] ([id], [nombre], [apellido], [dni], [telefono_fijo], [telefono_movil], [domicilio], [email], [borrado]) VALUES (18, N'Federico Ezequiel', N'Vega', 37646007, N'-', N'-', N'Beron de Astrada 2378 - San Miguel', N'fevega@spf.gob.ar', 0)
INSERT [dbo].[Cliente] ([id], [nombre], [apellido], [dni], [telefono_fijo], [telefono_movil], [domicilio], [email], [borrado]) VALUES (19, N'Moira Romina', N'Mansilla', 30380985, N'-', N'-', N'Jose Marmol 124 - CABA', N'moira_romi21@hotmail.com', 0)
INSERT [dbo].[Cliente] ([id], [nombre], [apellido], [dni], [telefono_fijo], [telefono_movil], [domicilio], [email], [borrado]) VALUES (20, N'María de los Angeles', N'Miñarro', 31728351, N'-', N'-', N'Los Troncos 940 - Ezeiza', N'maruminarro@gmail.com', 0)
INSERT [dbo].[Cliente] ([id], [nombre], [apellido], [dni], [telefono_fijo], [telefono_movil], [domicilio], [email], [borrado]) VALUES (21, N'Mauricio Augusto', N'Ramirez', 28214684, N'-', N'-', N'Derqui 465 - Ezeiza', N'mauriaugramirez10@gmail.com', 0)
INSERT [dbo].[Cliente] ([id], [nombre], [apellido], [dni], [telefono_fijo], [telefono_movil], [domicilio], [email], [borrado]) VALUES (22, N'Gabriel Ali', N'Vallejos', 35362826, N'-', N'-', N'Manuel Ugarte 3032 - CABA', N'13kevin@live.com.ar', 0)
GO
INSERT [dbo].[Cliente_Bitacora] ([id], [ultima_modificacion], [activo], [tipo], [id_usuario], [id_cliente], [nombre], [apellido], [dni], [telefono_fijo], [telefono_movil], [domicilio], [email], [borrado]) VALUES (1, CAST(N'2023-11-26T21:45:21.027' AS DateTime), 1, N'Agregado', 1, 1, N'Rosario', N'Puppo', 41667517, N'-', N'-', N'-', N'charitopuppo98@gmail.com', 0)
INSERT [dbo].[Cliente_Bitacora] ([id], [ultima_modificacion], [activo], [tipo], [id_usuario], [id_cliente], [nombre], [apellido], [dni], [telefono_fijo], [telefono_movil], [domicilio], [email], [borrado]) VALUES (2, CAST(N'2023-11-26T22:14:24.207' AS DateTime), 1, N'Agregado', 1, 2, N'Antonella Soledad', N'Maidana', 37460504, N'-', N'-', N'Catamarca 234 - CABA', N'antonellasmaidana@gmail.com', 0)
INSERT [dbo].[Cliente_Bitacora] ([id], [ultima_modificacion], [activo], [tipo], [id_usuario], [id_cliente], [nombre], [apellido], [dni], [telefono_fijo], [telefono_movil], [domicilio], [email], [borrado]) VALUES (3, CAST(N'2023-11-26T22:33:00.687' AS DateTime), 1, N'Agregado', 1, 3, N'Marcia Adriana', N'Garay', 30861453, N'-', N'-', N'Chile 1836 - CABA', N'garay_mar@hotmail.com', 0)
INSERT [dbo].[Cliente_Bitacora] ([id], [ultima_modificacion], [activo], [tipo], [id_usuario], [id_cliente], [nombre], [apellido], [dni], [telefono_fijo], [telefono_movil], [domicilio], [email], [borrado]) VALUES (4, CAST(N'2023-11-27T09:15:16.573' AS DateTime), 0, N'Modificado', 1, 1, N'Rosario', N'Puppo', 41667517, N'-', N'1130687888', N'-', N'charitopuppo98@gmail.com', 0)
INSERT [dbo].[Cliente_Bitacora] ([id], [ultima_modificacion], [activo], [tipo], [id_usuario], [id_cliente], [nombre], [apellido], [dni], [telefono_fijo], [telefono_movil], [domicilio], [email], [borrado]) VALUES (5, CAST(N'2023-11-27T09:19:52.473' AS DateTime), 0, N'Modificado', 1, 1, N'Rosario', N'Puppo', 41667517, N'-', N'1130687888', N'San Vicente', N'charitopuppo98@gmail.com', 0)
INSERT [dbo].[Cliente_Bitacora] ([id], [ultima_modificacion], [activo], [tipo], [id_usuario], [id_cliente], [nombre], [apellido], [dni], [telefono_fijo], [telefono_movil], [domicilio], [email], [borrado]) VALUES (6, CAST(N'2023-11-28T20:51:20.807' AS DateTime), 1, N'Agregado', 1, 4, N'Ayelen', N'Simonetti', 35146448, N'-', N'-', N'Miranda 4571 - CABA', N'ayelen.simonettispf@gmail.com', 0)
INSERT [dbo].[Cliente_Bitacora] ([id], [ultima_modificacion], [activo], [tipo], [id_usuario], [id_cliente], [nombre], [apellido], [dni], [telefono_fijo], [telefono_movil], [domicilio], [email], [borrado]) VALUES (7, CAST(N'2023-12-03T10:25:30.523' AS DateTime), 1, N'Agregado', 4, 5, N'Walter Marcelo', N'Cejas', 35951531, N'-', N'-', N'Lisandro de la Torre - MERLO', N'-', 0)
INSERT [dbo].[Cliente_Bitacora] ([id], [ultima_modificacion], [activo], [tipo], [id_usuario], [id_cliente], [nombre], [apellido], [dni], [telefono_fijo], [telefono_movil], [domicilio], [email], [borrado]) VALUES (8, CAST(N'2023-12-03T13:01:20.097' AS DateTime), 1, N'Agregado', 1, 6, N'Andrea Celeste', N'Gomez', 34633294, N'-', N'-', N'San Jose 311 - Barrio La Union', N'gomezlasa@gmail.com', 0)
INSERT [dbo].[Cliente_Bitacora] ([id], [ultima_modificacion], [activo], [tipo], [id_usuario], [id_cliente], [nombre], [apellido], [dni], [telefono_fijo], [telefono_movil], [domicilio], [email], [borrado]) VALUES (9, CAST(N'2023-12-03T16:23:46.903' AS DateTime), 1, N'Agregado', 1, 7, N'Carlos Antonio', N'Fretes', 35262657, N'-', N'-', N'-', N'carlosfrete25@gmail.com', 0)
INSERT [dbo].[Cliente_Bitacora] ([id], [ultima_modificacion], [activo], [tipo], [id_usuario], [id_cliente], [nombre], [apellido], [dni], [telefono_fijo], [telefono_movil], [domicilio], [email], [borrado]) VALUES (10, CAST(N'2023-12-03T16:28:45.317' AS DateTime), 1, N'Agregado', 4, 8, N'Marcela Elizabeth', N'Miño', 31630117, N'-', N'-', N'Esteban Echeverria 155 - Wilde', N'marcely_m21@hotmail.com', 0)
INSERT [dbo].[Cliente_Bitacora] ([id], [ultima_modificacion], [activo], [tipo], [id_usuario], [id_cliente], [nombre], [apellido], [dni], [telefono_fijo], [telefono_movil], [domicilio], [email], [borrado]) VALUES (11, CAST(N'2023-12-03T16:49:21.060' AS DateTime), 1, N'Agregado', 1, 9, N'Lourdes', N'Escobar', 38152056, N'-', N'-', N'Damaso Larrañaga 757 - CABA', N'lourdes.esco94@gmail.com', 0)
INSERT [dbo].[Cliente_Bitacora] ([id], [ultima_modificacion], [activo], [tipo], [id_usuario], [id_cliente], [nombre], [apellido], [dni], [telefono_fijo], [telefono_movil], [domicilio], [email], [borrado]) VALUES (12, CAST(N'2023-12-07T15:06:00.140' AS DateTime), 1, N'Agregado', 1, 10, N'Gonzalo Andres', N'Vega', 39626457, N'46371813', N'-', N'Francisco Bilbao 2883 - CABA', N'goommza.-@hotmail.com', 0)
INSERT [dbo].[Cliente_Bitacora] ([id], [ultima_modificacion], [activo], [tipo], [id_usuario], [id_cliente], [nombre], [apellido], [dni], [telefono_fijo], [telefono_movil], [domicilio], [email], [borrado]) VALUES (13, CAST(N'2023-12-07T15:07:06.117' AS DateTime), 1, N'Agregado', 1, 11, N'Nestor Fabian', N'Abarrategui', 18395963, N'-', N'-', N'-', N'-', 0)
INSERT [dbo].[Cliente_Bitacora] ([id], [ultima_modificacion], [activo], [tipo], [id_usuario], [id_cliente], [nombre], [apellido], [dni], [telefono_fijo], [telefono_movil], [domicilio], [email], [borrado]) VALUES (14, CAST(N'2023-12-07T15:08:09.260' AS DateTime), 1, N'Agregado', 1, 12, N'Evelin Yamila', N'Caceres', 36872608, N'-', N'-', N'-', N'-', 0)
INSERT [dbo].[Cliente_Bitacora] ([id], [ultima_modificacion], [activo], [tipo], [id_usuario], [id_cliente], [nombre], [apellido], [dni], [telefono_fijo], [telefono_movil], [domicilio], [email], [borrado]) VALUES (15, CAST(N'2023-12-07T15:08:56.590' AS DateTime), 1, N'Agregado', 1, 13, N'Walter Alfredo', N'Reyes', 30174283, N'-', N'-', N'-', N'-', 0)
INSERT [dbo].[Cliente_Bitacora] ([id], [ultima_modificacion], [activo], [tipo], [id_usuario], [id_cliente], [nombre], [apellido], [dni], [telefono_fijo], [telefono_movil], [domicilio], [email], [borrado]) VALUES (16, CAST(N'2023-12-07T15:10:46.693' AS DateTime), 1, N'Agregado', 1, 14, N'Lucas Ezequiel', N'Andrades', 38067016, N'-', N'-', N'Agustin de Vedia 1978 - San Justo', N'lucaas.lt@live.com', 0)
INSERT [dbo].[Cliente_Bitacora] ([id], [ultima_modificacion], [activo], [tipo], [id_usuario], [id_cliente], [nombre], [apellido], [dni], [telefono_fijo], [telefono_movil], [domicilio], [email], [borrado]) VALUES (17, CAST(N'2024-01-10T07:57:43.030' AS DateTime), 1, N'Agregado', 1, 15, N'Cielo Ailin', N'Villagra', 42631282, N'-', N'1124093537', N'Chacabuco 28 - Ezeiza', N'ailin06v@gmail.com', 0)
INSERT [dbo].[Cliente_Bitacora] ([id], [ultima_modificacion], [activo], [tipo], [id_usuario], [id_cliente], [nombre], [apellido], [dni], [telefono_fijo], [telefono_movil], [domicilio], [email], [borrado]) VALUES (18, CAST(N'2024-01-27T18:14:20.453' AS DateTime), 1, N'Agregado', 1, 16, N'Araceli Ramona', N'Costadoni', 38971993, N'-', N'-', N'Lavalle 2966 - CABA', N'aracostadoni@gmail.com', 0)
INSERT [dbo].[Cliente_Bitacora] ([id], [ultima_modificacion], [activo], [tipo], [id_usuario], [id_cliente], [nombre], [apellido], [dni], [telefono_fijo], [telefono_movil], [domicilio], [email], [borrado]) VALUES (19, CAST(N'2024-02-03T12:24:42.060' AS DateTime), 1, N'Agregado', 1, 17, N'María Agustina', N'Bracamonte', 33881733, N'-', N'-', N'Corrientes 3859 - Piso 16 - Dpto F - CABA', N'magusbral@gmail.com', 0)
INSERT [dbo].[Cliente_Bitacora] ([id], [ultima_modificacion], [activo], [tipo], [id_usuario], [id_cliente], [nombre], [apellido], [dni], [telefono_fijo], [telefono_movil], [domicilio], [email], [borrado]) VALUES (20, CAST(N'2024-02-03T12:32:53.753' AS DateTime), 1, N'Agregado', 1, 18, N'Federico Ezequiel', N'Vega', 37646007, N'-', N'-', N'Beron de Astrada 2378 - San Miguel', N'fevega@spf.gob.ar', 0)
INSERT [dbo].[Cliente_Bitacora] ([id], [ultima_modificacion], [activo], [tipo], [id_usuario], [id_cliente], [nombre], [apellido], [dni], [telefono_fijo], [telefono_movil], [domicilio], [email], [borrado]) VALUES (21, CAST(N'2024-02-03T18:58:25.527' AS DateTime), 1, N'Agregado', 1, 19, N'Moira Romina', N'Mansilla', 30380985, N'-', N'-', N'Jose Marmol 124 - CABA', N'moira_romi21@hotmail.com', 0)
INSERT [dbo].[Cliente_Bitacora] ([id], [ultima_modificacion], [activo], [tipo], [id_usuario], [id_cliente], [nombre], [apellido], [dni], [telefono_fijo], [telefono_movil], [domicilio], [email], [borrado]) VALUES (22, CAST(N'2024-02-04T10:34:36.117' AS DateTime), 1, N'Agregado', 1, 20, N'María de los Angeles', N'Miñarro', 31728351, N'-', N'-', N'Los Troncos 940 - Ezeiza', N'maruminarro@gmail.com', 0)
INSERT [dbo].[Cliente_Bitacora] ([id], [ultima_modificacion], [activo], [tipo], [id_usuario], [id_cliente], [nombre], [apellido], [dni], [telefono_fijo], [telefono_movil], [domicilio], [email], [borrado]) VALUES (23, CAST(N'2024-03-04T10:33:31.320' AS DateTime), 1, N'Agregado', 1, 21, N'Mauricio Augusto', N'Ramirez', 28214684, N'-', N'-', N'Derqui 465 - Ezeiza', N'mauriaugramirez10@gmail.com', 0)
INSERT [dbo].[Cliente_Bitacora] ([id], [ultima_modificacion], [activo], [tipo], [id_usuario], [id_cliente], [nombre], [apellido], [dni], [telefono_fijo], [telefono_movil], [domicilio], [email], [borrado]) VALUES (24, CAST(N'2024-03-05T18:29:46.827' AS DateTime), 1, N'Agregado', 1, 22, N'Gabriel Ali', N'Vallejos', 35362826, N'-', N'-', N'Manuel Ugarte 3032 - CABA', N'13kevin@live.com.ar', 0)
GO
INSERT [dbo].[DVH] ([modulo], [registro], [dv]) VALUES (N'Reserva', 1, N'???d????6?:(??')
INSERT [dbo].[DVH] ([modulo], [registro], [dv]) VALUES (N'Reserva', 2, N'%?R???.????;]L?')
INSERT [dbo].[DVH] ([modulo], [registro], [dv]) VALUES (N'Reserva', 3, N'?3.W?1?7???_?c')
INSERT [dbo].[DVH] ([modulo], [registro], [dv]) VALUES (N'Reserva', 4, N'I]??@??tQ?t??|')
INSERT [dbo].[DVH] ([modulo], [registro], [dv]) VALUES (N'Reserva', 5, N'@g?O?P? [3pf')
INSERT [dbo].[DVH] ([modulo], [registro], [dv]) VALUES (N'Reserva', 6, N'dQI??????[t?`\')
INSERT [dbo].[DVH] ([modulo], [registro], [dv]) VALUES (N'Reserva', 7, N',??M?~aK?h?kv*?')
INSERT [dbo].[DVH] ([modulo], [registro], [dv]) VALUES (N'Reserva', 8, N'??[?j?]#??w?Xn')
INSERT [dbo].[DVH] ([modulo], [registro], [dv]) VALUES (N'Reserva', 9, N'?????,J???Xi2?')
INSERT [dbo].[DVH] ([modulo], [registro], [dv]) VALUES (N'Reserva', 10, N'
??????@??ZW???')
INSERT [dbo].[DVH] ([modulo], [registro], [dv]) VALUES (N'Reserva', 11, N'?fH???o	<~?R?e1')
INSERT [dbo].[DVH] ([modulo], [registro], [dv]) VALUES (N'Reserva', 12, N'??Fy(??~]Gk?+C?/')
INSERT [dbo].[DVH] ([modulo], [registro], [dv]) VALUES (N'Reserva', 13, N'????''?hD?L????')
INSERT [dbo].[DVH] ([modulo], [registro], [dv]) VALUES (N'Reserva', 14, N'?G?q??c?? ??u???')
INSERT [dbo].[DVH] ([modulo], [registro], [dv]) VALUES (N'Reserva', 15, N'?G? /=???q?>r?')
INSERT [dbo].[DVH] ([modulo], [registro], [dv]) VALUES (N'Reserva', 16, N'?Z*P?2g??!?cQ?cS')
INSERT [dbo].[DVH] ([modulo], [registro], [dv]) VALUES (N'Reserva', 17, N'??T???x????;a??')
INSERT [dbo].[DVH] ([modulo], [registro], [dv]) VALUES (N'Reserva', 18, N'umF??y
?u$?=?c')
INSERT [dbo].[DVH] ([modulo], [registro], [dv]) VALUES (N'Reserva', 19, N'??eW c???+??F?$')
INSERT [dbo].[DVH] ([modulo], [registro], [dv]) VALUES (N'Reserva', 20, N'J?o0E???
Q?b?')
INSERT [dbo].[DVH] ([modulo], [registro], [dv]) VALUES (N'Reserva', 21, N'?l?N?@5?f???Mkj?')
INSERT [dbo].[DVH] ([modulo], [registro], [dv]) VALUES (N'Reserva', 22, N'\?,k?62_??g-P??')
INSERT [dbo].[DVH] ([modulo], [registro], [dv]) VALUES (N'Reserva', 23, N'>???M?7=?9?X???')
INSERT [dbo].[DVH] ([modulo], [registro], [dv]) VALUES (N'Reserva', 24, N'?{?????Q??%;2??>')
INSERT [dbo].[DVH] ([modulo], [registro], [dv]) VALUES (N'Reserva', 25, N'I??????g?\?bS')
INSERT [dbo].[DVH] ([modulo], [registro], [dv]) VALUES (N'Reserva', 26, N'?k??h???i>?????')
GO
INSERT [dbo].[DVV] ([modulo], [columna], [dv]) VALUES (N'Reserva', 1, N'??? ?''C9??????')
INSERT [dbo].[DVV] ([modulo], [columna], [dv]) VALUES (N'Reserva', 2, N')?
(/HGeF????c?')
INSERT [dbo].[DVV] ([modulo], [columna], [dv]) VALUES (N'Reserva', 3, N's?,?]?{?1?Fk???')
INSERT [dbo].[DVV] ([modulo], [columna], [dv]) VALUES (N'Reserva', 4, N'H? ???a?B:3??')
INSERT [dbo].[DVV] ([modulo], [columna], [dv]) VALUES (N'Reserva', 5, N'?$?=??]ox??)[??')
INSERT [dbo].[DVV] ([modulo], [columna], [dv]) VALUES (N'Reserva', 6, N'?7??0Db????"??8')
INSERT [dbo].[DVV] ([modulo], [columna], [dv]) VALUES (N'Reserva', 7, N'Q???~??m?????')
GO
INSERT [dbo].[Estadia] ([id], [id_factura], [checkin], [checkout], [id_habitacion], [id_cliente], [cantidad_huespedes], [estado]) VALUES (1, 1, CAST(N'2023-12-03T00:00:00.000' AS DateTime), CAST(N'2023-12-04T00:00:00.000' AS DateTime), 2, 2, 1, N'Desactiva')
INSERT [dbo].[Estadia] ([id], [id_factura], [checkin], [checkout], [id_habitacion], [id_cliente], [cantidad_huespedes], [estado]) VALUES (2, 2, CAST(N'2023-12-03T00:00:00.000' AS DateTime), CAST(N'2023-12-04T00:00:00.000' AS DateTime), 4, 4, 1, N'Desactiva')
INSERT [dbo].[Estadia] ([id], [id_factura], [checkin], [checkout], [id_habitacion], [id_cliente], [cantidad_huespedes], [estado]) VALUES (3, 3, CAST(N'2023-12-03T00:00:00.000' AS DateTime), CAST(N'2023-12-04T00:00:00.000' AS DateTime), 3, 5, 1, N'Desactiva')
INSERT [dbo].[Estadia] ([id], [id_factura], [checkin], [checkout], [id_habitacion], [id_cliente], [cantidad_huespedes], [estado]) VALUES (4, 4, CAST(N'2023-12-03T00:00:00.000' AS DateTime), CAST(N'2023-12-06T00:00:00.000' AS DateTime), 5, 3, 1, N'Desactiva')
INSERT [dbo].[Estadia] ([id], [id_factura], [checkin], [checkout], [id_habitacion], [id_cliente], [cantidad_huespedes], [estado]) VALUES (5, 6, CAST(N'2023-12-03T00:00:00.000' AS DateTime), CAST(N'2023-12-04T00:00:00.000' AS DateTime), 7, 6, 2, N'Desactiva')
INSERT [dbo].[Estadia] ([id], [id_factura], [checkin], [checkout], [id_habitacion], [id_cliente], [cantidad_huespedes], [estado]) VALUES (6, 10, CAST(N'2023-12-06T00:00:00.000' AS DateTime), CAST(N'2023-12-07T00:00:00.000' AS DateTime), 1, 2, 1, N'Desactiva')
INSERT [dbo].[Estadia] ([id], [id_factura], [checkin], [checkout], [id_habitacion], [id_cliente], [cantidad_huespedes], [estado]) VALUES (7, 11, CAST(N'2023-12-07T00:00:00.000' AS DateTime), CAST(N'2023-12-10T16:45:06.000' AS DateTime), 1, 10, 1, N'Desactiva')
INSERT [dbo].[Estadia] ([id], [id_factura], [checkin], [checkout], [id_habitacion], [id_cliente], [cantidad_huespedes], [estado]) VALUES (8, 12, CAST(N'2023-12-07T00:00:00.000' AS DateTime), CAST(N'2023-12-10T00:00:00.000' AS DateTime), 5, 11, 1, N'Desactiva')
INSERT [dbo].[Estadia] ([id], [id_factura], [checkin], [checkout], [id_habitacion], [id_cliente], [cantidad_huespedes], [estado]) VALUES (9, 13, CAST(N'2023-12-07T00:00:00.000' AS DateTime), CAST(N'2023-12-10T16:47:43.000' AS DateTime), 22, 14, 4, N'Desactiva')
INSERT [dbo].[Estadia] ([id], [id_factura], [checkin], [checkout], [id_habitacion], [id_cliente], [cantidad_huespedes], [estado]) VALUES (10, 14, CAST(N'2023-12-07T00:00:00.000' AS DateTime), CAST(N'2023-12-10T16:49:42.000' AS DateTime), 3, 12, 1, N'Desactiva')
INSERT [dbo].[Estadia] ([id], [id_factura], [checkin], [checkout], [id_habitacion], [id_cliente], [cantidad_huespedes], [estado]) VALUES (11, 15, CAST(N'2023-12-07T00:00:00.000' AS DateTime), CAST(N'2023-12-10T16:51:26.000' AS DateTime), 10, 13, 2, N'Desactiva')
INSERT [dbo].[Estadia] ([id], [id_factura], [checkin], [checkout], [id_habitacion], [id_cliente], [cantidad_huespedes], [estado]) VALUES (12, 17, CAST(N'2024-01-21T00:00:00.000' AS DateTime), CAST(N'2024-01-22T00:00:00.000' AS DateTime), 19, 15, 4, N'Desactiva')
INSERT [dbo].[Estadia] ([id], [id_factura], [checkin], [checkout], [id_habitacion], [id_cliente], [cantidad_huespedes], [estado]) VALUES (13, 18, CAST(N'2024-01-27T00:00:00.000' AS DateTime), CAST(N'2024-01-30T00:00:00.000' AS DateTime), 22, 16, 4, N'Desactiva')
INSERT [dbo].[Estadia] ([id], [id_factura], [checkin], [checkout], [id_habitacion], [id_cliente], [cantidad_huespedes], [estado]) VALUES (14, 19, CAST(N'2024-02-03T00:00:00.000' AS DateTime), CAST(N'2024-02-04T00:00:00.000' AS DateTime), 20, 3, 4, N'Desactiva')
INSERT [dbo].[Estadia] ([id], [id_factura], [checkin], [checkout], [id_habitacion], [id_cliente], [cantidad_huespedes], [estado]) VALUES (15, 20, CAST(N'2024-02-03T00:00:00.000' AS DateTime), CAST(N'2024-02-05T00:00:00.000' AS DateTime), 16, 17, 3, N'Desactiva')
INSERT [dbo].[Estadia] ([id], [id_factura], [checkin], [checkout], [id_habitacion], [id_cliente], [cantidad_huespedes], [estado]) VALUES (16, 21, CAST(N'2024-02-03T00:00:00.000' AS DateTime), CAST(N'2024-02-05T00:00:00.000' AS DateTime), 18, 18, 3, N'Desactiva')
INSERT [dbo].[Estadia] ([id], [id_factura], [checkin], [checkout], [id_habitacion], [id_cliente], [cantidad_huespedes], [estado]) VALUES (17, 22, CAST(N'2024-02-03T00:00:00.000' AS DateTime), CAST(N'2024-02-05T00:00:00.000' AS DateTime), 8, 19, 2, N'Desactiva')
INSERT [dbo].[Estadia] ([id], [id_factura], [checkin], [checkout], [id_habitacion], [id_cliente], [cantidad_huespedes], [estado]) VALUES (18, 23, CAST(N'2024-02-04T00:00:00.000' AS DateTime), CAST(N'2024-02-10T00:00:00.000' AS DateTime), 23, 20, 4, N'Desactiva')
INSERT [dbo].[Estadia] ([id], [id_factura], [checkin], [checkout], [id_habitacion], [id_cliente], [cantidad_huespedes], [estado]) VALUES (19, 24, CAST(N'2024-03-04T00:00:00.000' AS DateTime), CAST(N'2024-03-05T00:00:00.000' AS DateTime), 2, 21, 1, N'Desactiva')
INSERT [dbo].[Estadia] ([id], [id_factura], [checkin], [checkout], [id_habitacion], [id_cliente], [cantidad_huespedes], [estado]) VALUES (20, 25, CAST(N'2024-03-05T00:00:00.000' AS DateTime), CAST(N'2024-03-06T00:00:00.000' AS DateTime), 2, 22, 1, N'Desactiva')
GO
INSERT [dbo].[Etiqueta] ([id_etiqueta], [nombre]) VALUES (1, N'lbl_idioma')
INSERT [dbo].[Etiqueta] ([id_etiqueta], [nombre]) VALUES (2, N'btn_mostrar')
GO
INSERT [dbo].[Factura] ([id], [numero], [id_cliente], [fecha], [lugar], [id_reserva], [subtotal], [iva], [total], [deposito]) VALUES (1, N'2023-1001', 2, CAST(N'2023-12-03T10:26:55.033' AS DateTime), N'Ciudad de San Rafael, MENDOZA', 1, 20000, 4200, 24200, 2420)
INSERT [dbo].[Factura] ([id], [numero], [id_cliente], [fecha], [lugar], [id_reserva], [subtotal], [iva], [total], [deposito]) VALUES (2, N'2023-1002', 4, CAST(N'2023-12-03T10:30:39.987' AS DateTime), N'Ciudad de San Rafael, MENDOZA', 2, 20000, 4200, 24200, 2420)
INSERT [dbo].[Factura] ([id], [numero], [id_cliente], [fecha], [lugar], [id_reserva], [subtotal], [iva], [total], [deposito]) VALUES (3, N'2023-1003', 5, CAST(N'2023-12-03T12:41:46.690' AS DateTime), N'Ciudad de San Rafael, MENDOZA', 4, 20000, 4200, 24200, 2420)
INSERT [dbo].[Factura] ([id], [numero], [id_cliente], [fecha], [lugar], [id_reserva], [subtotal], [iva], [total], [deposito]) VALUES (4, N'2023-1004', 3, CAST(N'2023-12-03T12:45:23.890' AS DateTime), N'Ciudad de San Rafael, MENDOZA', 3, 60000, 12600, 72600, 7260)
INSERT [dbo].[Factura] ([id], [numero], [id_cliente], [fecha], [lugar], [id_reserva], [subtotal], [iva], [total], [deposito]) VALUES (5, N'2023-1005', 1, CAST(N'2023-12-03T12:55:47.833' AS DateTime), N'Ciudad de San Rafael, MENDOZA', 5, 20000, 4200, 24200, 2420)
INSERT [dbo].[Factura] ([id], [numero], [id_cliente], [fecha], [lugar], [id_reserva], [subtotal], [iva], [total], [deposito]) VALUES (6, N'2023-1006', 6, CAST(N'2023-12-03T13:02:16.193' AS DateTime), N'Ciudad de San Rafael, MENDOZA', 6, 35000, 7350, 42350, 4235)
INSERT [dbo].[Factura] ([id], [numero], [id_cliente], [fecha], [lugar], [id_reserva], [subtotal], [iva], [total], [deposito]) VALUES (7, N'2023-1007', 7, CAST(N'2023-12-03T16:24:41.047' AS DateTime), N'Ciudad de San Rafael, MENDOZA', 7, 156000, 32759.998046875, 188760, 18876)
INSERT [dbo].[Factura] ([id], [numero], [id_cliente], [fecha], [lugar], [id_reserva], [subtotal], [iva], [total], [deposito]) VALUES (8, N'2023-1008', 8, CAST(N'2023-12-03T16:30:06.097' AS DateTime), N'Ciudad de San Rafael, MENDOZA', 8, 729000, 153090, 882090, 88209)
INSERT [dbo].[Factura] ([id], [numero], [id_cliente], [fecha], [lugar], [id_reserva], [subtotal], [iva], [total], [deposito]) VALUES (9, N'2023-1009', 9, CAST(N'2023-12-03T16:50:33.813' AS DateTime), N'Ciudad de San Rafael, MENDOZA', 9, 572000, 120120, 692120, 69212)
INSERT [dbo].[Factura] ([id], [numero], [id_cliente], [fecha], [lugar], [id_reserva], [subtotal], [iva], [total], [deposito]) VALUES (10, N'2023-1010', 2, CAST(N'2023-12-06T18:59:10.163' AS DateTime), N'Ciudad de San Rafael, MENDOZA', 10, 20000, 4200, 24200, 2420)
INSERT [dbo].[Factura] ([id], [numero], [id_cliente], [fecha], [lugar], [id_reserva], [subtotal], [iva], [total], [deposito]) VALUES (11, N'2023-1011', 10, CAST(N'2023-12-07T15:15:55.793' AS DateTime), N'Ciudad de San Rafael, MENDOZA', 11, 20000, 4200, 24200, 2420)
INSERT [dbo].[Factura] ([id], [numero], [id_cliente], [fecha], [lugar], [id_reserva], [subtotal], [iva], [total], [deposito]) VALUES (12, N'2023-1012', 11, CAST(N'2023-12-07T15:16:21.773' AS DateTime), N'Ciudad de San Rafael, MENDOZA', 12, 60000, 12600, 72600, 7260)
INSERT [dbo].[Factura] ([id], [numero], [id_cliente], [fecha], [lugar], [id_reserva], [subtotal], [iva], [total], [deposito]) VALUES (13, N'2023-1013', 14, CAST(N'2023-12-07T15:16:42.733' AS DateTime), N'Ciudad de San Rafael, MENDOZA', 15, 162000, 34020, 196020, 19602)
INSERT [dbo].[Factura] ([id], [numero], [id_cliente], [fecha], [lugar], [id_reserva], [subtotal], [iva], [total], [deposito]) VALUES (14, N'2023-1014', 12, CAST(N'2023-12-07T15:16:59.527' AS DateTime), N'Ciudad de San Rafael, MENDOZA', 13, 40000, 8400, 48400, 4840)
INSERT [dbo].[Factura] ([id], [numero], [id_cliente], [fecha], [lugar], [id_reserva], [subtotal], [iva], [total], [deposito]) VALUES (15, N'2023-1015', 13, CAST(N'2023-12-07T15:17:17.177' AS DateTime), N'Ciudad de San Rafael, MENDOZA', 14, 35000, 7350, 42350, 4235)
INSERT [dbo].[Factura] ([id], [numero], [id_cliente], [fecha], [lugar], [id_reserva], [subtotal], [iva], [total], [deposito]) VALUES (16, N'2024-1016', 15, CAST(N'2024-01-10T07:58:56.547' AS DateTime), N'Ciudad de San Rafael, MENDOZA', 16, 81000, 17010, 98010, 9801)
INSERT [dbo].[Factura] ([id], [numero], [id_cliente], [fecha], [lugar], [id_reserva], [subtotal], [iva], [total], [deposito]) VALUES (17, N'2024-1017', 15, CAST(N'2024-01-21T10:41:28.370' AS DateTime), N'Ciudad de San Rafael, MENDOZA', 17, 81000, 17010, 98010, 9801)
INSERT [dbo].[Factura] ([id], [numero], [id_cliente], [fecha], [lugar], [id_reserva], [subtotal], [iva], [total], [deposito]) VALUES (18, N'2024-1018', 16, CAST(N'2024-01-27T18:17:19.667' AS DateTime), N'Ciudad de San Rafael, MENDOZA', 18, 243000, 51030, 294030, 29403)
INSERT [dbo].[Factura] ([id], [numero], [id_cliente], [fecha], [lugar], [id_reserva], [subtotal], [iva], [total], [deposito]) VALUES (19, N'2024-1019', 3, CAST(N'2024-02-03T12:15:17.580' AS DateTime), N'Ciudad de San Rafael, MENDOZA', 19, 81000, 17010, 98010, 9801)
INSERT [dbo].[Factura] ([id], [numero], [id_cliente], [fecha], [lugar], [id_reserva], [subtotal], [iva], [total], [deposito]) VALUES (20, N'2024-1020', 17, CAST(N'2024-02-03T12:33:28.700' AS DateTime), N'Ciudad de San Rafael, MENDOZA', 20, 104000, 21840, 125840, 12584)
INSERT [dbo].[Factura] ([id], [numero], [id_cliente], [fecha], [lugar], [id_reserva], [subtotal], [iva], [total], [deposito]) VALUES (21, N'2024-1021', 18, CAST(N'2024-02-03T12:33:57.957' AS DateTime), N'Ciudad de San Rafael, MENDOZA', 21, 104000, 21840, 125840, 12584)
INSERT [dbo].[Factura] ([id], [numero], [id_cliente], [fecha], [lugar], [id_reserva], [subtotal], [iva], [total], [deposito]) VALUES (22, N'2024-1022', 19, CAST(N'2024-02-03T18:58:53.783' AS DateTime), N'Ciudad de San Rafael, MENDOZA', 22, 70000, 14700, 84700, 8470)
INSERT [dbo].[Factura] ([id], [numero], [id_cliente], [fecha], [lugar], [id_reserva], [subtotal], [iva], [total], [deposito]) VALUES (23, N'2024-1023', 20, CAST(N'2024-02-04T10:35:10.757' AS DateTime), N'Ciudad de San Rafael, MENDOZA', 23, 486000, 102060, 588060, 58806)
INSERT [dbo].[Factura] ([id], [numero], [id_cliente], [fecha], [lugar], [id_reserva], [subtotal], [iva], [total], [deposito]) VALUES (24, N'2024-1024', 21, CAST(N'2024-03-04T10:36:04.227' AS DateTime), N'Ciudad de San Rafael, MENDOZA', 24, 20000, 4200, 24200, 2420)
INSERT [dbo].[Factura] ([id], [numero], [id_cliente], [fecha], [lugar], [id_reserva], [subtotal], [iva], [total], [deposito]) VALUES (25, N'2024-1025', 22, CAST(N'2024-03-05T18:30:31.000' AS DateTime), N'Ciudad de San Rafael, MENDOZA', 25, 20000, 4200, 24200, 2420)
INSERT [dbo].[Factura] ([id], [numero], [id_cliente], [fecha], [lugar], [id_reserva], [subtotal], [iva], [total], [deposito]) VALUES (26, N'2024-1026', 8, CAST(N'2024-03-06T11:28:56.613' AS DateTime), N'Ciudad de San Rafael, MENDOZA', 26, 81000, 17010, 98010, 9801)
GO
INSERT [dbo].[Factura_Hospedaje] ([id], [numero], [fecha], [lugar], [id_factura_reserva], [id_estadia], [id_cliente], [total_pagar], [deposito], [total_estadia], [estado]) VALUES (1, N'2023-10001', CAST(N'2023-12-04T08:18:23.057' AS DateTime), N'Ciudad de San Rafael, MENDOZA', 1, 1, 2, 21780, 2420, 24200, N'Pago')
INSERT [dbo].[Factura_Hospedaje] ([id], [numero], [fecha], [lugar], [id_factura_reserva], [id_estadia], [id_cliente], [total_pagar], [deposito], [total_estadia], [estado]) VALUES (2, N'2023-10002', CAST(N'2023-12-04T08:19:51.750' AS DateTime), N'Ciudad de San Rafael, MENDOZA', 2, 2, 4, 21780, 2420, 24200, N'Pago')
INSERT [dbo].[Factura_Hospedaje] ([id], [numero], [fecha], [lugar], [id_factura_reserva], [id_estadia], [id_cliente], [total_pagar], [deposito], [total_estadia], [estado]) VALUES (3, N'2023-10003', CAST(N'2023-12-04T08:21:00.823' AS DateTime), N'Ciudad de San Rafael, MENDOZA', 3, 3, 5, 21780, 2420, 24200, N'Pago')
INSERT [dbo].[Factura_Hospedaje] ([id], [numero], [fecha], [lugar], [id_factura_reserva], [id_estadia], [id_cliente], [total_pagar], [deposito], [total_estadia], [estado]) VALUES (4, N'2023-10004', CAST(N'2023-12-04T08:22:53.207' AS DateTime), N'Ciudad de San Rafael, MENDOZA', 6, 5, 6, 38115, 4235, 42350, N'Pago')
INSERT [dbo].[Factura_Hospedaje] ([id], [numero], [fecha], [lugar], [id_factura_reserva], [id_estadia], [id_cliente], [total_pagar], [deposito], [total_estadia], [estado]) VALUES (5, N'2023-10005', CAST(N'2023-12-06T18:57:40.723' AS DateTime), N'Ciudad de San Rafael, MENDOZA', 4, 4, 3, 65340, 7260, 72600, N'Pago')
INSERT [dbo].[Factura_Hospedaje] ([id], [numero], [fecha], [lugar], [id_factura_reserva], [id_estadia], [id_cliente], [total_pagar], [deposito], [total_estadia], [estado]) VALUES (6, N'2023-10006', CAST(N'2023-12-07T15:03:42.687' AS DateTime), N'Ciudad de San Rafael, MENDOZA', 10, 6, 2, 21780, 2420, 24200, N'Pago')
INSERT [dbo].[Factura_Hospedaje] ([id], [numero], [fecha], [lugar], [id_factura_reserva], [id_estadia], [id_cliente], [total_pagar], [deposito], [total_estadia], [estado]) VALUES (7, N'2023-10007', CAST(N'2023-12-10T16:45:17.090' AS DateTime), N'Ciudad de San Rafael, MENDOZA', 11, 7, 10, 21780, 2420, 24200, N'Pago')
INSERT [dbo].[Factura_Hospedaje] ([id], [numero], [fecha], [lugar], [id_factura_reserva], [id_estadia], [id_cliente], [total_pagar], [deposito], [total_estadia], [estado]) VALUES (8, N'2023-10008', CAST(N'2023-12-10T16:46:25.487' AS DateTime), N'Ciudad de San Rafael, MENDOZA', 12, 8, 11, 65340, 7260, 72600, N'Pago')
INSERT [dbo].[Factura_Hospedaje] ([id], [numero], [fecha], [lugar], [id_factura_reserva], [id_estadia], [id_cliente], [total_pagar], [deposito], [total_estadia], [estado]) VALUES (9, N'2023-10009', CAST(N'2023-12-10T16:48:36.910' AS DateTime), N'Ciudad de San Rafael, MENDOZA', 13, 9, 14, 176418, 19602, 196020, N'Pago')
INSERT [dbo].[Factura_Hospedaje] ([id], [numero], [fecha], [lugar], [id_factura_reserva], [id_estadia], [id_cliente], [total_pagar], [deposito], [total_estadia], [estado]) VALUES (10, N'2023-10010', CAST(N'2023-12-10T16:49:51.710' AS DateTime), N'Ciudad de San Rafael, MENDOZA', 14, 10, 12, 43560, 4840, 48400, N'Pago')
INSERT [dbo].[Factura_Hospedaje] ([id], [numero], [fecha], [lugar], [id_factura_reserva], [id_estadia], [id_cliente], [total_pagar], [deposito], [total_estadia], [estado]) VALUES (11, N'2023-10011', CAST(N'2023-12-10T16:51:35.103' AS DateTime), N'Ciudad de San Rafael, MENDOZA', 15, 11, 13, 38115, 4235, 42350, N'Pago')
INSERT [dbo].[Factura_Hospedaje] ([id], [numero], [fecha], [lugar], [id_factura_reserva], [id_estadia], [id_cliente], [total_pagar], [deposito], [total_estadia], [estado]) VALUES (12, N'2024-10012', CAST(N'2024-01-22T09:46:40.547' AS DateTime), N'Ciudad de San Rafael, MENDOZA', 17, 12, 15, 88209, 9801, 98010, N'Pago')
INSERT [dbo].[Factura_Hospedaje] ([id], [numero], [fecha], [lugar], [id_factura_reserva], [id_estadia], [id_cliente], [total_pagar], [deposito], [total_estadia], [estado]) VALUES (13, N'2024-10013', CAST(N'2024-01-30T08:56:46.263' AS DateTime), N'Ciudad de San Rafael, MENDOZA', 18, 13, 16, 264627, 29403, 294030, N'Pago')
INSERT [dbo].[Factura_Hospedaje] ([id], [numero], [fecha], [lugar], [id_factura_reserva], [id_estadia], [id_cliente], [total_pagar], [deposito], [total_estadia], [estado]) VALUES (14, N'2024-10014', CAST(N'2024-02-04T10:38:03.157' AS DateTime), N'Ciudad de San Rafael, MENDOZA', 19, 14, 3, 88209, 9801, 98010, N'Pago')
INSERT [dbo].[Factura_Hospedaje] ([id], [numero], [fecha], [lugar], [id_factura_reserva], [id_estadia], [id_cliente], [total_pagar], [deposito], [total_estadia], [estado]) VALUES (15, N'2024-10015', CAST(N'2024-02-05T15:45:34.060' AS DateTime), N'Ciudad de San Rafael, MENDOZA', 20, 15, 17, 113256, 12584, 125840, N'Pago')
INSERT [dbo].[Factura_Hospedaje] ([id], [numero], [fecha], [lugar], [id_factura_reserva], [id_estadia], [id_cliente], [total_pagar], [deposito], [total_estadia], [estado]) VALUES (16, N'2024-10016', CAST(N'2024-02-05T15:45:55.497' AS DateTime), N'Ciudad de San Rafael, MENDOZA', 21, 16, 18, 113256, 12584, 125840, N'Pago')
INSERT [dbo].[Factura_Hospedaje] ([id], [numero], [fecha], [lugar], [id_factura_reserva], [id_estadia], [id_cliente], [total_pagar], [deposito], [total_estadia], [estado]) VALUES (17, N'2024-10017', CAST(N'2024-02-05T15:46:13.130' AS DateTime), N'Ciudad de San Rafael, MENDOZA', 22, 17, 19, 76230, 8470, 84700, N'Pago')
INSERT [dbo].[Factura_Hospedaje] ([id], [numero], [fecha], [lugar], [id_factura_reserva], [id_estadia], [id_cliente], [total_pagar], [deposito], [total_estadia], [estado]) VALUES (18, N'2024-10018', CAST(N'2024-02-10T09:48:55.847' AS DateTime), N'Ciudad de San Rafael, MENDOZA', 23, 18, 20, 529254, 58806, 588060, N'Pago')
INSERT [dbo].[Factura_Hospedaje] ([id], [numero], [fecha], [lugar], [id_factura_reserva], [id_estadia], [id_cliente], [total_pagar], [deposito], [total_estadia], [estado]) VALUES (19, N'2024-10019', CAST(N'2024-03-05T23:11:08.100' AS DateTime), N'Ciudad de San Rafael, MENDOZA', 24, 19, 21, 21780, 2420, 24200, N'Pago')
INSERT [dbo].[Factura_Hospedaje] ([id], [numero], [fecha], [lugar], [id_factura_reserva], [id_estadia], [id_cliente], [total_pagar], [deposito], [total_estadia], [estado]) VALUES (20, N'2024-10020', CAST(N'2024-03-06T11:24:42.487' AS DateTime), N'Ciudad de San Rafael, MENDOZA', 25, 20, 22, 21780, 2420, 24200, N'Pago')
GO
INSERT [dbo].[Habitacion] ([id], [numero], [id_tipo_habitacion]) VALUES (1, 1, 1)
INSERT [dbo].[Habitacion] ([id], [numero], [id_tipo_habitacion]) VALUES (2, 2, 1)
INSERT [dbo].[Habitacion] ([id], [numero], [id_tipo_habitacion]) VALUES (3, 3, 1)
INSERT [dbo].[Habitacion] ([id], [numero], [id_tipo_habitacion]) VALUES (4, 4, 1)
INSERT [dbo].[Habitacion] ([id], [numero], [id_tipo_habitacion]) VALUES (5, 5, 1)
INSERT [dbo].[Habitacion] ([id], [numero], [id_tipo_habitacion]) VALUES (6, 6, 2)
INSERT [dbo].[Habitacion] ([id], [numero], [id_tipo_habitacion]) VALUES (7, 7, 2)
INSERT [dbo].[Habitacion] ([id], [numero], [id_tipo_habitacion]) VALUES (8, 8, 2)
INSERT [dbo].[Habitacion] ([id], [numero], [id_tipo_habitacion]) VALUES (9, 9, 2)
INSERT [dbo].[Habitacion] ([id], [numero], [id_tipo_habitacion]) VALUES (10, 10, 2)
INSERT [dbo].[Habitacion] ([id], [numero], [id_tipo_habitacion]) VALUES (11, 11, 2)
INSERT [dbo].[Habitacion] ([id], [numero], [id_tipo_habitacion]) VALUES (12, 12, 2)
INSERT [dbo].[Habitacion] ([id], [numero], [id_tipo_habitacion]) VALUES (13, 13, 2)
INSERT [dbo].[Habitacion] ([id], [numero], [id_tipo_habitacion]) VALUES (14, 14, 3)
INSERT [dbo].[Habitacion] ([id], [numero], [id_tipo_habitacion]) VALUES (15, 15, 3)
INSERT [dbo].[Habitacion] ([id], [numero], [id_tipo_habitacion]) VALUES (16, 16, 3)
INSERT [dbo].[Habitacion] ([id], [numero], [id_tipo_habitacion]) VALUES (17, 17, 3)
INSERT [dbo].[Habitacion] ([id], [numero], [id_tipo_habitacion]) VALUES (18, 18, 3)
INSERT [dbo].[Habitacion] ([id], [numero], [id_tipo_habitacion]) VALUES (19, 19, 4)
INSERT [dbo].[Habitacion] ([id], [numero], [id_tipo_habitacion]) VALUES (20, 20, 4)
INSERT [dbo].[Habitacion] ([id], [numero], [id_tipo_habitacion]) VALUES (21, 21, 4)
INSERT [dbo].[Habitacion] ([id], [numero], [id_tipo_habitacion]) VALUES (22, 22, 4)
INSERT [dbo].[Habitacion] ([id], [numero], [id_tipo_habitacion]) VALUES (23, 23, 4)
GO
INSERT [dbo].[Idioma] ([id_idioma], [nombre], [idioma_default]) VALUES (1, N'Ingles', 0)
INSERT [dbo].[Idioma] ([id_idioma], [nombre], [idioma_default]) VALUES (2, N'Español', 1)
GO
INSERT [dbo].[Pago_Deposito] ([id], [id_tipo_tarjeta], [id_procesador_pago], [id_banco], [numero], [codigo], [vencimiento], [id_factura], [cuotas]) VALUES (1, 1, 1, 1, 1234568765215464, 555, CAST(N'2023-12-03T10:26:49.650' AS DateTime), 1, 3)
INSERT [dbo].[Pago_Deposito] ([id], [id_tipo_tarjeta], [id_procesador_pago], [id_banco], [numero], [codigo], [vencimiento], [id_factura], [cuotas]) VALUES (2, 2, 1, 2, 5555555555555555, 555, CAST(N'2023-12-03T10:30:38.260' AS DateTime), 2, 0)
INSERT [dbo].[Pago_Deposito] ([id], [id_tipo_tarjeta], [id_procesador_pago], [id_banco], [numero], [codigo], [vencimiento], [id_factura], [cuotas]) VALUES (3, 1, 1, 4, 5555555555555555, 111, CAST(N'2023-12-03T12:41:45.483' AS DateTime), 3, 6)
INSERT [dbo].[Pago_Deposito] ([id], [id_tipo_tarjeta], [id_procesador_pago], [id_banco], [numero], [codigo], [vencimiento], [id_factura], [cuotas]) VALUES (4, 1, 1, 1, 7777777777777777, 777, CAST(N'2023-12-03T12:45:22.903' AS DateTime), 4, 9)
INSERT [dbo].[Pago_Deposito] ([id], [id_tipo_tarjeta], [id_procesador_pago], [id_banco], [numero], [codigo], [vencimiento], [id_factura], [cuotas]) VALUES (5, 1, 1, 1, 8888888888888888, 888, CAST(N'2023-12-03T12:55:46.610' AS DateTime), 5, 6)
INSERT [dbo].[Pago_Deposito] ([id], [id_tipo_tarjeta], [id_procesador_pago], [id_banco], [numero], [codigo], [vencimiento], [id_factura], [cuotas]) VALUES (6, 2, 1, 1, 9999999999999999, 777, CAST(N'2023-12-03T13:02:15.047' AS DateTime), 6, 0)
INSERT [dbo].[Pago_Deposito] ([id], [id_tipo_tarjeta], [id_procesador_pago], [id_banco], [numero], [codigo], [vencimiento], [id_factura], [cuotas]) VALUES (7, 1, 1, 3, 5555555555555555, 555, CAST(N'2023-12-03T16:24:39.197' AS DateTime), 7, 3)
INSERT [dbo].[Pago_Deposito] ([id], [id_tipo_tarjeta], [id_procesador_pago], [id_banco], [numero], [codigo], [vencimiento], [id_factura], [cuotas]) VALUES (8, 2, 1, 6, 1111111111111111, 111, CAST(N'2023-12-03T16:30:04.830' AS DateTime), 8, 0)
INSERT [dbo].[Pago_Deposito] ([id], [id_tipo_tarjeta], [id_procesador_pago], [id_banco], [numero], [codigo], [vencimiento], [id_factura], [cuotas]) VALUES (9, 2, 4, 3, 5555555555555555, 111, CAST(N'2023-12-03T16:50:32.383' AS DateTime), 9, 0)
INSERT [dbo].[Pago_Deposito] ([id], [id_tipo_tarjeta], [id_procesador_pago], [id_banco], [numero], [codigo], [vencimiento], [id_factura], [cuotas]) VALUES (10, 1, 1, 1, 6666666666666666, 666, CAST(N'2023-12-06T18:59:08.627' AS DateTime), 10, 1)
INSERT [dbo].[Pago_Deposito] ([id], [id_tipo_tarjeta], [id_procesador_pago], [id_banco], [numero], [codigo], [vencimiento], [id_factura], [cuotas]) VALUES (11, 2, 1, 3, 8888888888888888, 888, CAST(N'2023-12-07T15:13:29.113' AS DateTime), 11, 0)
INSERT [dbo].[Pago_Deposito] ([id], [id_tipo_tarjeta], [id_procesador_pago], [id_banco], [numero], [codigo], [vencimiento], [id_factura], [cuotas]) VALUES (12, 1, 1, 1, 1111111111111111, 111, CAST(N'2023-12-07T15:16:17.233' AS DateTime), 12, 3)
INSERT [dbo].[Pago_Deposito] ([id], [id_tipo_tarjeta], [id_procesador_pago], [id_banco], [numero], [codigo], [vencimiento], [id_factura], [cuotas]) VALUES (13, 1, 3, 1, 9999999999999999, 999, CAST(N'2023-12-07T15:16:36.090' AS DateTime), 13, 4)
INSERT [dbo].[Pago_Deposito] ([id], [id_tipo_tarjeta], [id_procesador_pago], [id_banco], [numero], [codigo], [vencimiento], [id_factura], [cuotas]) VALUES (14, 1, 1, 10, 9999999999999999, 999, CAST(N'2023-12-07T15:16:58.610' AS DateTime), 14, 1)
INSERT [dbo].[Pago_Deposito] ([id], [id_tipo_tarjeta], [id_procesador_pago], [id_banco], [numero], [codigo], [vencimiento], [id_factura], [cuotas]) VALUES (15, 1, 1, 3, 3333333333333333, 333, CAST(N'2023-12-07T15:17:15.970' AS DateTime), 15, 1)
INSERT [dbo].[Pago_Deposito] ([id], [id_tipo_tarjeta], [id_procesador_pago], [id_banco], [numero], [codigo], [vencimiento], [id_factura], [cuotas]) VALUES (16, 1, 1, 1, 7777777777777777, 111, CAST(N'2024-01-10T07:58:55.037' AS DateTime), 16, 3)
INSERT [dbo].[Pago_Deposito] ([id], [id_tipo_tarjeta], [id_procesador_pago], [id_banco], [numero], [codigo], [vencimiento], [id_factura], [cuotas]) VALUES (17, 1, 1, 1, 8888888888888888, 888, CAST(N'2024-01-21T10:41:27.340' AS DateTime), 17, 3)
INSERT [dbo].[Pago_Deposito] ([id], [id_tipo_tarjeta], [id_procesador_pago], [id_banco], [numero], [codigo], [vencimiento], [id_factura], [cuotas]) VALUES (18, 1, 1, 3, 8888888888888888, 888, CAST(N'2024-01-27T18:17:15.827' AS DateTime), 18, 3)
INSERT [dbo].[Pago_Deposito] ([id], [id_tipo_tarjeta], [id_procesador_pago], [id_banco], [numero], [codigo], [vencimiento], [id_factura], [cuotas]) VALUES (19, 1, 1, 1, 7777777777777777, 777, CAST(N'2024-02-27T12:15:14.000' AS DateTime), 19, 1)
INSERT [dbo].[Pago_Deposito] ([id], [id_tipo_tarjeta], [id_procesador_pago], [id_banco], [numero], [codigo], [vencimiento], [id_factura], [cuotas]) VALUES (20, 1, 1, 1, 1111111111111111, 111, CAST(N'2024-02-03T12:33:25.013' AS DateTime), 20, 6)
INSERT [dbo].[Pago_Deposito] ([id], [id_tipo_tarjeta], [id_procesador_pago], [id_banco], [numero], [codigo], [vencimiento], [id_factura], [cuotas]) VALUES (21, 1, 1, 1, 8888888888888888, 888, CAST(N'2024-02-03T12:33:54.463' AS DateTime), 21, 8)
INSERT [dbo].[Pago_Deposito] ([id], [id_tipo_tarjeta], [id_procesador_pago], [id_banco], [numero], [codigo], [vencimiento], [id_factura], [cuotas]) VALUES (22, 1, 1, 1, 9999999999999999, 999, CAST(N'2024-02-03T18:58:52.580' AS DateTime), 22, 1)
INSERT [dbo].[Pago_Deposito] ([id], [id_tipo_tarjeta], [id_procesador_pago], [id_banco], [numero], [codigo], [vencimiento], [id_factura], [cuotas]) VALUES (23, 1, 1, 1, 7777777777777777, 777, CAST(N'2024-02-04T10:35:09.123' AS DateTime), 23, 1)
INSERT [dbo].[Pago_Deposito] ([id], [id_tipo_tarjeta], [id_procesador_pago], [id_banco], [numero], [codigo], [vencimiento], [id_factura], [cuotas]) VALUES (24, 1, 1, 3, 5555555555555555, 111, CAST(N'2024-03-04T10:35:45.640' AS DateTime), 24, 5)
INSERT [dbo].[Pago_Deposito] ([id], [id_tipo_tarjeta], [id_procesador_pago], [id_banco], [numero], [codigo], [vencimiento], [id_factura], [cuotas]) VALUES (25, 1, 1, 1, 5478113214564654, 555, CAST(N'2024-03-05T18:30:26.680' AS DateTime), 25, 1)
INSERT [dbo].[Pago_Deposito] ([id], [id_tipo_tarjeta], [id_procesador_pago], [id_banco], [numero], [codigo], [vencimiento], [id_factura], [cuotas]) VALUES (26, 1, 1, 1, 1111111111111111, 111, CAST(N'2024-03-06T11:28:51.457' AS DateTime), 26, 5)
GO
INSERT [dbo].[Pago_Estadia] ([id], [id_tipo_tarjeta], [id_procesador_pago], [id_banco], [numero], [codigo], [vencimiento], [id_factura_hospedaje], [cuotas]) VALUES (1, 1, 1, 1, 5555555555555555, 555, CAST(N'2023-12-04T08:18:36.410' AS DateTime), 1, 1)
INSERT [dbo].[Pago_Estadia] ([id], [id_tipo_tarjeta], [id_procesador_pago], [id_banco], [numero], [codigo], [vencimiento], [id_factura_hospedaje], [cuotas]) VALUES (2, 2, 1, 1, 1111111111111111, 111, CAST(N'2023-12-04T08:20:02.330' AS DateTime), 2, 1)
INSERT [dbo].[Pago_Estadia] ([id], [id_tipo_tarjeta], [id_procesador_pago], [id_banco], [numero], [codigo], [vencimiento], [id_factura_hospedaje], [cuotas]) VALUES (3, 2, 1, 8, 9999999999999999, 999, CAST(N'2023-12-04T08:21:03.340' AS DateTime), 3, 1)
INSERT [dbo].[Pago_Estadia] ([id], [id_tipo_tarjeta], [id_procesador_pago], [id_banco], [numero], [codigo], [vencimiento], [id_factura_hospedaje], [cuotas]) VALUES (4, 1, 1, 1, 9999999999999999, 999, CAST(N'2023-12-04T08:23:00.353' AS DateTime), 4, 1)
INSERT [dbo].[Pago_Estadia] ([id], [id_tipo_tarjeta], [id_procesador_pago], [id_banco], [numero], [codigo], [vencimiento], [id_factura_hospedaje], [cuotas]) VALUES (5, 1, 1, 1, 5555555555555555, 555, CAST(N'2023-12-06T18:57:43.293' AS DateTime), 5, 1)
INSERT [dbo].[Pago_Estadia] ([id], [id_tipo_tarjeta], [id_procesador_pago], [id_banco], [numero], [codigo], [vencimiento], [id_factura_hospedaje], [cuotas]) VALUES (6, 1, 1, 1, 5555555555555555, 555, CAST(N'2023-12-07T15:03:46.850' AS DateTime), 6, 1)
INSERT [dbo].[Pago_Estadia] ([id], [id_tipo_tarjeta], [id_procesador_pago], [id_banco], [numero], [codigo], [vencimiento], [id_factura_hospedaje], [cuotas]) VALUES (7, 1, 1, 1, 9999999999999999, 999, CAST(N'2023-12-10T16:45:20.047' AS DateTime), 7, 1)
INSERT [dbo].[Pago_Estadia] ([id], [id_tipo_tarjeta], [id_procesador_pago], [id_banco], [numero], [codigo], [vencimiento], [id_factura_hospedaje], [cuotas]) VALUES (8, 1, 1, 4, 4444444444444444, 444, CAST(N'2023-12-10T16:46:31.787' AS DateTime), 8, 1)
INSERT [dbo].[Pago_Estadia] ([id], [id_tipo_tarjeta], [id_procesador_pago], [id_banco], [numero], [codigo], [vencimiento], [id_factura_hospedaje], [cuotas]) VALUES (9, 1, 1, 1, 7777777777777777, 777, CAST(N'2023-12-10T16:48:45.257' AS DateTime), 9, 1)
INSERT [dbo].[Pago_Estadia] ([id], [id_tipo_tarjeta], [id_procesador_pago], [id_banco], [numero], [codigo], [vencimiento], [id_factura_hospedaje], [cuotas]) VALUES (10, 1, 1, 1, 1111111111111111, 111, CAST(N'2023-12-10T16:49:57.197' AS DateTime), 10, 1)
INSERT [dbo].[Pago_Estadia] ([id], [id_tipo_tarjeta], [id_procesador_pago], [id_banco], [numero], [codigo], [vencimiento], [id_factura_hospedaje], [cuotas]) VALUES (11, 1, 1, 1, 1111111111111111, 111, CAST(N'2023-12-10T16:51:40.573' AS DateTime), 11, 3)
INSERT [dbo].[Pago_Estadia] ([id], [id_tipo_tarjeta], [id_procesador_pago], [id_banco], [numero], [codigo], [vencimiento], [id_factura_hospedaje], [cuotas]) VALUES (12, 1, 1, 1, 4444444444444444, 444, CAST(N'2024-01-22T09:46:43.970' AS DateTime), 12, 1)
INSERT [dbo].[Pago_Estadia] ([id], [id_tipo_tarjeta], [id_procesador_pago], [id_banco], [numero], [codigo], [vencimiento], [id_factura_hospedaje], [cuotas]) VALUES (13, 1, 1, 1, 1111111111111111, 222, CAST(N'2024-01-30T08:57:00.800' AS DateTime), 13, 3)
INSERT [dbo].[Pago_Estadia] ([id], [id_tipo_tarjeta], [id_procesador_pago], [id_banco], [numero], [codigo], [vencimiento], [id_factura_hospedaje], [cuotas]) VALUES (14, 1, 1, 2, 1111111111111111, 111, CAST(N'2024-02-04T10:38:51.867' AS DateTime), 14, 1)
INSERT [dbo].[Pago_Estadia] ([id], [id_tipo_tarjeta], [id_procesador_pago], [id_banco], [numero], [codigo], [vencimiento], [id_factura_hospedaje], [cuotas]) VALUES (15, 1, 1, 1, 1111111111111111, 111, CAST(N'2024-02-05T15:45:38.053' AS DateTime), 15, 1)
INSERT [dbo].[Pago_Estadia] ([id], [id_tipo_tarjeta], [id_procesador_pago], [id_banco], [numero], [codigo], [vencimiento], [id_factura_hospedaje], [cuotas]) VALUES (16, 1, 1, 1, 5555555555555555, 555, CAST(N'2024-02-05T15:45:58.857' AS DateTime), 16, 1)
INSERT [dbo].[Pago_Estadia] ([id], [id_tipo_tarjeta], [id_procesador_pago], [id_banco], [numero], [codigo], [vencimiento], [id_factura_hospedaje], [cuotas]) VALUES (17, 1, 1, 1, 6666666666666666, 666, CAST(N'2024-02-05T15:46:15.013' AS DateTime), 17, 6)
INSERT [dbo].[Pago_Estadia] ([id], [id_tipo_tarjeta], [id_procesador_pago], [id_banco], [numero], [codigo], [vencimiento], [id_factura_hospedaje], [cuotas]) VALUES (18, 1, 1, 1, 4444444444444444, 444, CAST(N'2024-02-10T09:49:02.380' AS DateTime), 18, 1)
INSERT [dbo].[Pago_Estadia] ([id], [id_tipo_tarjeta], [id_procesador_pago], [id_banco], [numero], [codigo], [vencimiento], [id_factura_hospedaje], [cuotas]) VALUES (19, 1, 1, 1, 1111111111111111, 111, CAST(N'2024-03-05T23:11:18.667' AS DateTime), 19, 1)
INSERT [dbo].[Pago_Estadia] ([id], [id_tipo_tarjeta], [id_procesador_pago], [id_banco], [numero], [codigo], [vencimiento], [id_factura_hospedaje], [cuotas]) VALUES (20, 1, 1, 1, 5555555555555555, 555, CAST(N'2024-03-06T11:24:44.773' AS DateTime), 20, 1)
GO
SET IDENTITY_INSERT [dbo].[Permiso] ON 

INSERT [dbo].[Permiso] ([nombre], [id], [permiso]) VALUES (N'Gestion de Usuarios', 1, N'GestorUsuario')
INSERT [dbo].[Permiso] ([nombre], [id], [permiso]) VALUES (N'Gestion de Perfiles', 2, N'GestorPerfiles')
INSERT [dbo].[Permiso] ([nombre], [id], [permiso]) VALUES (N'Gestor de Idioma', 3, N'GestorIdioma')
INSERT [dbo].[Permiso] ([nombre], [id], [permiso]) VALUES (N'Gestor de Habitaciones', 4, N'GestorHabitacion')
INSERT [dbo].[Permiso] ([nombre], [id], [permiso]) VALUES (N'Gestor de Clientes', 5, N'GestorCliente')
INSERT [dbo].[Permiso] ([nombre], [id], [permiso]) VALUES (N'Gestor de Reservas', 6, N'GestorReservas')
INSERT [dbo].[Permiso] ([nombre], [id], [permiso]) VALUES (N'Gestor de Facturas', 7, N'GestorFacturas')
INSERT [dbo].[Permiso] ([nombre], [id], [permiso]) VALUES (N'Gestor de Reportes', 8, N'GestorReportes')
INSERT [dbo].[Permiso] ([nombre], [id], [permiso]) VALUES (N'Seguridad', 11, NULL)
INSERT [dbo].[Permiso] ([nombre], [id], [permiso]) VALUES (N'Maestros', 12, NULL)
INSERT [dbo].[Permiso] ([nombre], [id], [permiso]) VALUES (N'RFN1', 13, NULL)
INSERT [dbo].[Permiso] ([nombre], [id], [permiso]) VALUES (N'Admin', 14, NULL)
INSERT [dbo].[Permiso] ([nombre], [id], [permiso]) VALUES (N'Gestion de Logout', 16, N'GestorSalidaSistema')
INSERT [dbo].[Permiso] ([nombre], [id], [permiso]) VALUES (N'Gestion Checkin', 17, N'GestorCheckin')
INSERT [dbo].[Permiso] ([nombre], [id], [permiso]) VALUES (N'Gestion Checkout', 18, N'GestorCheckout')
INSERT [dbo].[Permiso] ([nombre], [id], [permiso]) VALUES (N'Facturar Estadia', 19, N'GestorFacturarEstadia')
INSERT [dbo].[Permiso] ([nombre], [id], [permiso]) VALUES (N'Gestor ClienteBitacora', 21, NULL)
INSERT [dbo].[Permiso] ([nombre], [id], [permiso]) VALUES (N'Gestor ClienteBitacora', 22, N'GestorBitacoraCliente')
INSERT [dbo].[Permiso] ([nombre], [id], [permiso]) VALUES (N'Gestor Bitacora', 24, N'GestorBitacora')
INSERT [dbo].[Permiso] ([nombre], [id], [permiso]) VALUES (N'Gestor de Respaldos', 25, N'GestorRespaldos')
INSERT [dbo].[Permiso] ([nombre], [id], [permiso]) VALUES (N'RFN2', 26, NULL)
SET IDENTITY_INSERT [dbo].[Permiso] OFF
GO
INSERT [dbo].[Permiso_Permiso] ([id_padre], [id_hijo]) VALUES (12, 4)
INSERT [dbo].[Permiso_Permiso] ([id_padre], [id_hijo]) VALUES (12, 5)
INSERT [dbo].[Permiso_Permiso] ([id_padre], [id_hijo]) VALUES (12, 22)
INSERT [dbo].[Permiso_Permiso] ([id_padre], [id_hijo]) VALUES (26, 17)
INSERT [dbo].[Permiso_Permiso] ([id_padre], [id_hijo]) VALUES (26, 18)
INSERT [dbo].[Permiso_Permiso] ([id_padre], [id_hijo]) VALUES (26, 19)
INSERT [dbo].[Permiso_Permiso] ([id_padre], [id_hijo]) VALUES (13, 6)
INSERT [dbo].[Permiso_Permiso] ([id_padre], [id_hijo]) VALUES (13, 7)
INSERT [dbo].[Permiso_Permiso] ([id_padre], [id_hijo]) VALUES (11, 1)
INSERT [dbo].[Permiso_Permiso] ([id_padre], [id_hijo]) VALUES (11, 2)
INSERT [dbo].[Permiso_Permiso] ([id_padre], [id_hijo]) VALUES (11, 3)
INSERT [dbo].[Permiso_Permiso] ([id_padre], [id_hijo]) VALUES (11, 16)
INSERT [dbo].[Permiso_Permiso] ([id_padre], [id_hijo]) VALUES (11, 24)
INSERT [dbo].[Permiso_Permiso] ([id_padre], [id_hijo]) VALUES (11, 25)
INSERT [dbo].[Permiso_Permiso] ([id_padre], [id_hijo]) VALUES (14, 11)
INSERT [dbo].[Permiso_Permiso] ([id_padre], [id_hijo]) VALUES (14, 12)
INSERT [dbo].[Permiso_Permiso] ([id_padre], [id_hijo]) VALUES (14, 13)
INSERT [dbo].[Permiso_Permiso] ([id_padre], [id_hijo]) VALUES (14, 26)
INSERT [dbo].[Permiso_Permiso] ([id_padre], [id_hijo]) VALUES (14, 8)
GO
INSERT [dbo].[Procesador_Pago] ([id], [descripcion]) VALUES (1, N'Visa')
INSERT [dbo].[Procesador_Pago] ([id], [descripcion]) VALUES (2, N'Mastercard')
INSERT [dbo].[Procesador_Pago] ([id], [descripcion]) VALUES (3, N'American Express')
INSERT [dbo].[Procesador_Pago] ([id], [descripcion]) VALUES (4, N'Diners Club')
GO
INSERT [dbo].[Reserva] ([id], [fecha_inicio], [fecha_fin], [id_cliente], [cantidad_huespedes], [cantidad_dias], [id_habitacion], [facturada]) VALUES (1, CAST(N'2023-12-03T00:00:00.000' AS DateTime), CAST(N'2023-12-04T00:00:00.000' AS DateTime), 2, 1, 1, 2, N'Si')
INSERT [dbo].[Reserva] ([id], [fecha_inicio], [fecha_fin], [id_cliente], [cantidad_huespedes], [cantidad_dias], [id_habitacion], [facturada]) VALUES (2, CAST(N'2023-12-03T00:00:00.000' AS DateTime), CAST(N'2023-12-04T00:00:00.000' AS DateTime), 4, 1, 1, 4, N'Si')
INSERT [dbo].[Reserva] ([id], [fecha_inicio], [fecha_fin], [id_cliente], [cantidad_huespedes], [cantidad_dias], [id_habitacion], [facturada]) VALUES (3, CAST(N'2023-12-03T00:00:00.000' AS DateTime), CAST(N'2023-12-06T00:00:00.000' AS DateTime), 3, 1, 3, 5, N'Si')
INSERT [dbo].[Reserva] ([id], [fecha_inicio], [fecha_fin], [id_cliente], [cantidad_huespedes], [cantidad_dias], [id_habitacion], [facturada]) VALUES (4, CAST(N'2023-12-03T00:00:00.000' AS DateTime), CAST(N'2023-12-04T00:00:00.000' AS DateTime), 5, 1, 1, 3, N'Si')
INSERT [dbo].[Reserva] ([id], [fecha_inicio], [fecha_fin], [id_cliente], [cantidad_huespedes], [cantidad_dias], [id_habitacion], [facturada]) VALUES (5, CAST(N'2023-12-03T00:00:00.000' AS DateTime), CAST(N'2023-12-04T00:00:00.000' AS DateTime), 1, 1, 1, 1, N'Si')
INSERT [dbo].[Reserva] ([id], [fecha_inicio], [fecha_fin], [id_cliente], [cantidad_huespedes], [cantidad_dias], [id_habitacion], [facturada]) VALUES (6, CAST(N'2023-12-03T00:00:00.000' AS DateTime), CAST(N'2023-12-04T00:00:00.000' AS DateTime), 6, 2, 1, 7, N'Si')
INSERT [dbo].[Reserva] ([id], [fecha_inicio], [fecha_fin], [id_cliente], [cantidad_huespedes], [cantidad_dias], [id_habitacion], [facturada]) VALUES (7, CAST(N'2023-12-03T00:00:00.000' AS DateTime), CAST(N'2023-12-06T00:00:00.000' AS DateTime), 7, 3, 3, 17, N'Si')
INSERT [dbo].[Reserva] ([id], [fecha_inicio], [fecha_fin], [id_cliente], [cantidad_huespedes], [cantidad_dias], [id_habitacion], [facturada]) VALUES (8, CAST(N'2024-01-01T00:00:00.000' AS DateTime), CAST(N'2024-01-10T00:00:00.000' AS DateTime), 8, 4, 9, 22, N'Si')
INSERT [dbo].[Reserva] ([id], [fecha_inicio], [fecha_fin], [id_cliente], [cantidad_huespedes], [cantidad_dias], [id_habitacion], [facturada]) VALUES (9, CAST(N'2024-01-01T00:00:00.000' AS DateTime), CAST(N'2024-01-12T00:00:00.000' AS DateTime), 9, 3, 11, 17, N'Si')
INSERT [dbo].[Reserva] ([id], [fecha_inicio], [fecha_fin], [id_cliente], [cantidad_huespedes], [cantidad_dias], [id_habitacion], [facturada]) VALUES (10, CAST(N'2023-12-06T00:00:00.000' AS DateTime), CAST(N'2023-12-07T00:00:00.000' AS DateTime), 2, 1, 1, 1, N'Si')
INSERT [dbo].[Reserva] ([id], [fecha_inicio], [fecha_fin], [id_cliente], [cantidad_huespedes], [cantidad_dias], [id_habitacion], [facturada]) VALUES (11, CAST(N'2023-12-07T00:00:00.000' AS DateTime), CAST(N'2023-12-08T00:00:00.000' AS DateTime), 10, 1, 1, 1, N'Si')
INSERT [dbo].[Reserva] ([id], [fecha_inicio], [fecha_fin], [id_cliente], [cantidad_huespedes], [cantidad_dias], [id_habitacion], [facturada]) VALUES (12, CAST(N'2023-12-07T00:00:00.000' AS DateTime), CAST(N'2023-12-10T00:00:00.000' AS DateTime), 11, 1, 3, 5, N'Si')
INSERT [dbo].[Reserva] ([id], [fecha_inicio], [fecha_fin], [id_cliente], [cantidad_huespedes], [cantidad_dias], [id_habitacion], [facturada]) VALUES (13, CAST(N'2023-12-07T00:00:00.000' AS DateTime), CAST(N'2023-12-09T00:00:00.000' AS DateTime), 12, 1, 2, 3, N'Si')
INSERT [dbo].[Reserva] ([id], [fecha_inicio], [fecha_fin], [id_cliente], [cantidad_huespedes], [cantidad_dias], [id_habitacion], [facturada]) VALUES (14, CAST(N'2023-12-07T00:00:00.000' AS DateTime), CAST(N'2023-12-08T00:00:00.000' AS DateTime), 13, 2, 1, 10, N'Si')
INSERT [dbo].[Reserva] ([id], [fecha_inicio], [fecha_fin], [id_cliente], [cantidad_huespedes], [cantidad_dias], [id_habitacion], [facturada]) VALUES (15, CAST(N'2023-12-07T00:00:00.000' AS DateTime), CAST(N'2023-12-09T00:00:00.000' AS DateTime), 14, 4, 2, 22, N'Si')
INSERT [dbo].[Reserva] ([id], [fecha_inicio], [fecha_fin], [id_cliente], [cantidad_huespedes], [cantidad_dias], [id_habitacion], [facturada]) VALUES (16, CAST(N'2024-01-10T00:00:00.000' AS DateTime), CAST(N'2024-01-11T00:00:00.000' AS DateTime), 15, 4, 1, 22, N'Si')
INSERT [dbo].[Reserva] ([id], [fecha_inicio], [fecha_fin], [id_cliente], [cantidad_huespedes], [cantidad_dias], [id_habitacion], [facturada]) VALUES (17, CAST(N'2024-01-21T00:00:00.000' AS DateTime), CAST(N'2024-01-22T00:00:00.000' AS DateTime), 15, 4, 1, 19, N'Si')
INSERT [dbo].[Reserva] ([id], [fecha_inicio], [fecha_fin], [id_cliente], [cantidad_huespedes], [cantidad_dias], [id_habitacion], [facturada]) VALUES (18, CAST(N'2024-01-27T00:00:00.000' AS DateTime), CAST(N'2024-01-30T00:00:00.000' AS DateTime), 16, 4, 3, 22, N'Si')
INSERT [dbo].[Reserva] ([id], [fecha_inicio], [fecha_fin], [id_cliente], [cantidad_huespedes], [cantidad_dias], [id_habitacion], [facturada]) VALUES (19, CAST(N'2024-02-03T00:00:00.000' AS DateTime), CAST(N'2024-02-04T00:00:00.000' AS DateTime), 3, 4, 1, 20, N'Si')
INSERT [dbo].[Reserva] ([id], [fecha_inicio], [fecha_fin], [id_cliente], [cantidad_huespedes], [cantidad_dias], [id_habitacion], [facturada]) VALUES (20, CAST(N'2024-02-03T00:00:00.000' AS DateTime), CAST(N'2024-02-05T00:00:00.000' AS DateTime), 17, 3, 2, 16, N'Si')
INSERT [dbo].[Reserva] ([id], [fecha_inicio], [fecha_fin], [id_cliente], [cantidad_huespedes], [cantidad_dias], [id_habitacion], [facturada]) VALUES (21, CAST(N'2024-02-03T00:00:00.000' AS DateTime), CAST(N'2024-02-05T00:00:00.000' AS DateTime), 18, 3, 2, 18, N'Si')
INSERT [dbo].[Reserva] ([id], [fecha_inicio], [fecha_fin], [id_cliente], [cantidad_huespedes], [cantidad_dias], [id_habitacion], [facturada]) VALUES (22, CAST(N'2024-02-03T00:00:00.000' AS DateTime), CAST(N'2024-02-05T00:00:00.000' AS DateTime), 19, 2, 2, 8, N'Si')
INSERT [dbo].[Reserva] ([id], [fecha_inicio], [fecha_fin], [id_cliente], [cantidad_huespedes], [cantidad_dias], [id_habitacion], [facturada]) VALUES (23, CAST(N'2024-02-04T00:00:00.000' AS DateTime), CAST(N'2024-02-10T00:00:00.000' AS DateTime), 20, 4, 6, 23, N'Si')
INSERT [dbo].[Reserva] ([id], [fecha_inicio], [fecha_fin], [id_cliente], [cantidad_huespedes], [cantidad_dias], [id_habitacion], [facturada]) VALUES (24, CAST(N'2024-03-04T00:00:00.000' AS DateTime), CAST(N'2024-03-05T00:00:00.000' AS DateTime), 21, 1, 1, 2, N'Si')
INSERT [dbo].[Reserva] ([id], [fecha_inicio], [fecha_fin], [id_cliente], [cantidad_huespedes], [cantidad_dias], [id_habitacion], [facturada]) VALUES (25, CAST(N'2024-03-05T00:00:00.000' AS DateTime), CAST(N'2024-03-06T00:00:00.000' AS DateTime), 22, 1, 1, 2, N'Si')
INSERT [dbo].[Reserva] ([id], [fecha_inicio], [fecha_fin], [id_cliente], [cantidad_huespedes], [cantidad_dias], [id_habitacion], [facturada]) VALUES (26, CAST(N'2024-03-06T00:00:00.000' AS DateTime), CAST(N'2024-03-07T00:00:00.000' AS DateTime), 8, 4, 1, 23, N'Si')
GO
INSERT [dbo].[Tipo_Habitacion] ([id], [nombre], [precio], [huespedes_maximo]) VALUES (1, N'Simple', 20000, 1)
INSERT [dbo].[Tipo_Habitacion] ([id], [nombre], [precio], [huespedes_maximo]) VALUES (2, N'Doble Matrimonial', 35000, 2)
INSERT [dbo].[Tipo_Habitacion] ([id], [nombre], [precio], [huespedes_maximo]) VALUES (3, N'Triple', 52000, 3)
INSERT [dbo].[Tipo_Habitacion] ([id], [nombre], [precio], [huespedes_maximo]) VALUES (4, N'Cuadruple', 81000, 4)
GO
INSERT [dbo].[Tipo_Tarjeta] ([id], [tipo]) VALUES (1, N'Crédito')
INSERT [dbo].[Tipo_Tarjeta] ([id], [tipo]) VALUES (2, N'Débito')
GO
INSERT [dbo].[Traduccion] ([id_idioma], [traduccion], [id_etiqueta]) VALUES (1, N'Language', 1)
INSERT [dbo].[Traduccion] ([id_idioma], [traduccion], [id_etiqueta]) VALUES (1, N'Show', 2)
INSERT [dbo].[Traduccion] ([id_idioma], [traduccion], [id_etiqueta]) VALUES (2, N'Idioma', 1)
INSERT [dbo].[Traduccion] ([id_idioma], [traduccion], [id_etiqueta]) VALUES (2, N'Mostrar', 2)
GO
INSERT [dbo].[Usuario] ([id], [nombre], [apellido], [dni], [rol], [username], [password], [borrado], [bloqueo], [intentos], [id_idioma]) VALUES (1, N'Dario', N'Vega', 30082687, N'Administrador', N'dvega', N'?
?9I?Y??V?W??>', 0, 0, 0, 2)
INSERT [dbo].[Usuario] ([id], [nombre], [apellido], [dni], [rol], [username], [password], [borrado], [bloqueo], [intentos], [id_idioma]) VALUES (2, N'Natalia Elizabeth', N'Fernandez', 33737438, N'Recepcionista', N'nataliaf', N'?
?9I?Y??V?W??>', 0, 0, 0, 2)
INSERT [dbo].[Usuario] ([id], [nombre], [apellido], [dni], [rol], [username], [password], [borrado], [bloqueo], [intentos], [id_idioma]) VALUES (3, N'Sebastian Roberto', N'Dominguez', 35569511, N'Cajero', N'sebadom', N'?
?9I?Y??V?W??>', 0, 0, 0, 2)
INSERT [dbo].[Usuario] ([id], [nombre], [apellido], [dni], [rol], [username], [password], [borrado], [bloqueo], [intentos], [id_idioma]) VALUES (4, N'Noelia', N'Cuenca', 30746542, N'Recepcionista', N'ncuenca', N'?
?9I?Y??V?W??>', 0, 0, 0, 2)
INSERT [dbo].[Usuario] ([id], [nombre], [apellido], [dni], [rol], [username], [password], [borrado], [bloqueo], [intentos], [id_idioma]) VALUES (5, N'Luis', N'Arredondo', 25027927, N'Cajero', N'larredon', N'?
?9I?Y??V?W??>', 0, 0, 0, 2)
GO
INSERT [dbo].[Usuario_Permiso] ([id_usuario], [id_permiso]) VALUES (1, 14)
INSERT [dbo].[Usuario_Permiso] ([id_usuario], [id_permiso]) VALUES (2, 6)
INSERT [dbo].[Usuario_Permiso] ([id_usuario], [id_permiso]) VALUES (2, 16)
INSERT [dbo].[Usuario_Permiso] ([id_usuario], [id_permiso]) VALUES (2, 17)
INSERT [dbo].[Usuario_Permiso] ([id_usuario], [id_permiso]) VALUES (2, 18)
INSERT [dbo].[Usuario_Permiso] ([id_usuario], [id_permiso]) VALUES (3, 7)
INSERT [dbo].[Usuario_Permiso] ([id_usuario], [id_permiso]) VALUES (3, 16)
INSERT [dbo].[Usuario_Permiso] ([id_usuario], [id_permiso]) VALUES (3, 19)
INSERT [dbo].[Usuario_Permiso] ([id_usuario], [id_permiso]) VALUES (4, 6)
INSERT [dbo].[Usuario_Permiso] ([id_usuario], [id_permiso]) VALUES (4, 16)
INSERT [dbo].[Usuario_Permiso] ([id_usuario], [id_permiso]) VALUES (4, 17)
INSERT [dbo].[Usuario_Permiso] ([id_usuario], [id_permiso]) VALUES (4, 18)
INSERT [dbo].[Usuario_Permiso] ([id_usuario], [id_permiso]) VALUES (5, 7)
INSERT [dbo].[Usuario_Permiso] ([id_usuario], [id_permiso]) VALUES (5, 16)
INSERT [dbo].[Usuario_Permiso] ([id_usuario], [id_permiso]) VALUES (5, 19)
GO
ALTER TABLE [dbo].[Bitacora]  WITH CHECK ADD  CONSTRAINT [FK_Bitacora_Usuario] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[Usuario] ([id])
GO
ALTER TABLE [dbo].[Bitacora] CHECK CONSTRAINT [FK_Bitacora_Usuario]
GO
ALTER TABLE [dbo].[Estadia]  WITH CHECK ADD  CONSTRAINT [FK_Estadia_Cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Cliente] ([id])
GO
ALTER TABLE [dbo].[Estadia] CHECK CONSTRAINT [FK_Estadia_Cliente]
GO
ALTER TABLE [dbo].[Estadia]  WITH CHECK ADD  CONSTRAINT [FK_Estadia_Factura] FOREIGN KEY([id_factura])
REFERENCES [dbo].[Factura] ([id])
GO
ALTER TABLE [dbo].[Estadia] CHECK CONSTRAINT [FK_Estadia_Factura]
GO
ALTER TABLE [dbo].[Estadia]  WITH CHECK ADD  CONSTRAINT [FK_Estadia_Habitacion] FOREIGN KEY([id_habitacion])
REFERENCES [dbo].[Habitacion] ([id])
GO
ALTER TABLE [dbo].[Estadia] CHECK CONSTRAINT [FK_Estadia_Habitacion]
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Cliente] ([id])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [FK_Factura_Cliente]
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Reserva] FOREIGN KEY([id_reserva])
REFERENCES [dbo].[Reserva] ([id])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [FK_Factura_Reserva]
GO
ALTER TABLE [dbo].[Factura_Hospedaje]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Hospedaje_Cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Cliente] ([id])
GO
ALTER TABLE [dbo].[Factura_Hospedaje] CHECK CONSTRAINT [FK_Factura_Hospedaje_Cliente]
GO
ALTER TABLE [dbo].[Factura_Hospedaje]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Hospedaje_Estadia] FOREIGN KEY([id_estadia])
REFERENCES [dbo].[Estadia] ([id])
GO
ALTER TABLE [dbo].[Factura_Hospedaje] CHECK CONSTRAINT [FK_Factura_Hospedaje_Estadia]
GO
ALTER TABLE [dbo].[Factura_Hospedaje]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Hospedaje_Factura] FOREIGN KEY([id_factura_reserva])
REFERENCES [dbo].[Factura] ([id])
GO
ALTER TABLE [dbo].[Factura_Hospedaje] CHECK CONSTRAINT [FK_Factura_Hospedaje_Factura]
GO
ALTER TABLE [dbo].[Habitacion]  WITH CHECK ADD  CONSTRAINT [FK_Habitacion_Tipo_Habitacion] FOREIGN KEY([id_tipo_habitacion])
REFERENCES [dbo].[Tipo_Habitacion] ([id])
GO
ALTER TABLE [dbo].[Habitacion] CHECK CONSTRAINT [FK_Habitacion_Tipo_Habitacion]
GO
ALTER TABLE [dbo].[Pago_Deposito]  WITH CHECK ADD  CONSTRAINT [FK_Pago_Deposito_Banco] FOREIGN KEY([id_banco])
REFERENCES [dbo].[Banco] ([id])
GO
ALTER TABLE [dbo].[Pago_Deposito] CHECK CONSTRAINT [FK_Pago_Deposito_Banco]
GO
ALTER TABLE [dbo].[Pago_Deposito]  WITH CHECK ADD  CONSTRAINT [FK_Pago_Deposito_Procesador_Pago] FOREIGN KEY([id_procesador_pago])
REFERENCES [dbo].[Procesador_Pago] ([id])
GO
ALTER TABLE [dbo].[Pago_Deposito] CHECK CONSTRAINT [FK_Pago_Deposito_Procesador_Pago]
GO
ALTER TABLE [dbo].[Pago_Deposito]  WITH CHECK ADD  CONSTRAINT [FK_Pago_Deposito_Tipo_Tarjeta] FOREIGN KEY([id_tipo_tarjeta])
REFERENCES [dbo].[Tipo_Tarjeta] ([id])
GO
ALTER TABLE [dbo].[Pago_Deposito] CHECK CONSTRAINT [FK_Pago_Deposito_Tipo_Tarjeta]
GO
ALTER TABLE [dbo].[Permiso_Permiso]  WITH CHECK ADD  CONSTRAINT [FK_Permiso_Permiso_Permiso] FOREIGN KEY([id_padre])
REFERENCES [dbo].[Permiso] ([id])
GO
ALTER TABLE [dbo].[Permiso_Permiso] CHECK CONSTRAINT [FK_Permiso_Permiso_Permiso]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_Cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Cliente] ([id])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva_Cliente]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_Habitacion] FOREIGN KEY([id_habitacion])
REFERENCES [dbo].[Habitacion] ([id])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva_Habitacion]
GO
ALTER TABLE [dbo].[Usuario_Permiso]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Permiso_Permiso] FOREIGN KEY([id_permiso])
REFERENCES [dbo].[Permiso] ([id])
GO
ALTER TABLE [dbo].[Usuario_Permiso] CHECK CONSTRAINT [FK_Usuario_Permiso_Permiso]
GO
ALTER TABLE [dbo].[Usuario_Permiso]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Permiso_Usuario] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[Usuario] ([id])
GO
ALTER TABLE [dbo].[Usuario_Permiso] CHECK CONSTRAINT [FK_Usuario_Permiso_Usuario]
GO
USE [master]
GO
ALTER DATABASE [SISCAB] SET  READ_WRITE 
GO
