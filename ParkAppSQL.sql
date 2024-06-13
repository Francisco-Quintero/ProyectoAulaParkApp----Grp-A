USE [master]
GO
/****** Object:  Database [ParckAppDB]    Script Date: 13/06/2024 11:19:49 a. m. ******/
CREATE DATABASE [ParckAppDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ParckAppDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\ParckAppDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ParckAppDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\ParckAppDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [ParckAppDB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ParckAppDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ParckAppDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ParckAppDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ParckAppDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ParckAppDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ParckAppDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [ParckAppDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ParckAppDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ParckAppDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ParckAppDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ParckAppDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ParckAppDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ParckAppDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ParckAppDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ParckAppDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ParckAppDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ParckAppDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ParckAppDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ParckAppDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ParckAppDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ParckAppDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ParckAppDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ParckAppDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ParckAppDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ParckAppDB] SET  MULTI_USER 
GO
ALTER DATABASE [ParckAppDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ParckAppDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ParckAppDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ParckAppDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ParckAppDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ParckAppDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ParckAppDB] SET QUERY_STORE = ON
GO
ALTER DATABASE [ParckAppDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [ParckAppDB]
GO
/****** Object:  Table [dbo].[Parqueaderos]    Script Date: 13/06/2024 11:19:49 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Parqueaderos](
	[IdParqueadero] [int] IDENTITY(1,1000) NOT NULL,
	[Tarifa] [decimal](18, 0) NOT NULL,
	[HoraEntrada] [datetime] NOT NULL,
	[HoraSalida] [datetime] NOT NULL,
	[IdVehiculo] [int] NOT NULL,
	[TipoParqueadero] [int] NOT NULL,
 CONSTRAINT [PK_Parqueaderos] PRIMARY KEY CLUSTERED 
(
	[IdParqueadero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personas]    Script Date: 13/06/2024 11:19:49 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personas](
	[IdPersona] [int] IDENTITY(1,1000) NOT NULL,
	[Cedula] [nchar](20) NOT NULL,
	[Nombre] [nchar](20) NOT NULL,
	[Apellido] [nchar](20) NOT NULL,
	[UsuarioId] [int] NULL,
 CONSTRAINT [PK_Personas] PRIMARY KEY CLUSTERED 
(
	[IdPersona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 13/06/2024 11:19:49 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[IdRol] [int] NOT NULL,
	[Nombre] [nchar](20) NOT NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[IdRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tickets]    Script Date: 13/06/2024 11:19:49 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tickets](
	[IdTicket] [int] IDENTITY(1,1000) NOT NULL,
	[HoraEmititido] [datetime] NOT NULL,
	[Estado] [bit] NOT NULL,
	[Descripcion] [nchar](30) NULL,
	[IdPersona] [int] NOT NULL,
	[IdParqueadero] [int] NOT NULL,
 CONSTRAINT [PK_Tickets] PRIMARY KEY CLUSTERED 
(
	[IdTicket] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoParqueadero]    Script Date: 13/06/2024 11:19:49 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoParqueadero](
	[IdTipoParqueadero] [int] IDENTITY(1,1000) NOT NULL,
	[Descripcion] [nchar](20) NOT NULL,
 CONSTRAINT [PK_TipoParqueadero] PRIMARY KEY CLUSTERED 
(
	[IdTipoParqueadero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoVehiculos]    Script Date: 13/06/2024 11:19:49 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoVehiculos](
	[IdTipoVehiculo] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nchar](20) NOT NULL,
 CONSTRAINT [PK_Vehiculo] PRIMARY KEY CLUSTERED 
(
	[IdTipoVehiculo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 13/06/2024 11:19:49 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[IdUsuario] [int] IDENTITY(1,1000) NOT NULL,
	[Nombre] [nchar](20) NOT NULL,
	[Contraseña] [nchar](20) NOT NULL,
	[FechaCreacion] [date] NOT NULL,
	[Estado] [bit] NOT NULL,
	[IdRol] [int] NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehiculos]    Script Date: 13/06/2024 11:19:49 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehiculos](
	[IdVehiculo] [int] IDENTITY(1,1) NOT NULL,
	[Placa] [nchar](7) NOT NULL,
	[IdTipoVehiculo] [int] NOT NULL,
	[Tarifa] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_Vehiculo_1] PRIMARY KEY CLUSTERED 
(
	[IdVehiculo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Roles] ([IdRol], [Nombre], [Estado]) VALUES (1, N'Administrador       ', 1)
GO
INSERT [dbo].[Roles] ([IdRol], [Nombre], [Estado]) VALUES (2, N'Empleado            ', 1)
GO
SET IDENTITY_INSERT [dbo].[TipoParqueadero] ON 
GO
INSERT [dbo].[TipoParqueadero] ([IdTipoParqueadero], [Descripcion]) VALUES (1, N'Parqueadero Carro   ')
GO
INSERT [dbo].[TipoParqueadero] ([IdTipoParqueadero], [Descripcion]) VALUES (1001, N'Parqueadero Carro   ')
GO
SET IDENTITY_INSERT [dbo].[TipoParqueadero] OFF
GO
SET IDENTITY_INSERT [dbo].[TipoVehiculos] ON 
GO
INSERT [dbo].[TipoVehiculos] ([IdTipoVehiculo], [Descripcion]) VALUES (1, N'Moto                ')
GO
INSERT [dbo].[TipoVehiculos] ([IdTipoVehiculo], [Descripcion]) VALUES (4, N'Motocicletas        ')
GO
INSERT [dbo].[TipoVehiculos] ([IdTipoVehiculo], [Descripcion]) VALUES (6, N'Bicicleta           ')
GO
INSERT [dbo].[TipoVehiculos] ([IdTipoVehiculo], [Descripcion]) VALUES (8, N'Carro               ')
GO
INSERT [dbo].[TipoVehiculos] ([IdTipoVehiculo], [Descripcion]) VALUES (9, N'Avion               ')
GO
SET IDENTITY_INSERT [dbo].[TipoVehiculos] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 
GO
INSERT [dbo].[Usuarios] ([IdUsuario], [Nombre], [Contraseña], [FechaCreacion], [Estado], [IdRol]) VALUES (1001, N'Francisco           ', N'123456              ', CAST(N'2024-06-10' AS Date), 1, 2)
GO
INSERT [dbo].[Usuarios] ([IdUsuario], [Nombre], [Contraseña], [FechaCreacion], [Estado], [IdRol]) VALUES (2001, N'Keiner              ', N'123                 ', CAST(N'2024-06-12' AS Date), 1, 1)
GO
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
SET IDENTITY_INSERT [dbo].[Vehiculos] ON 
GO
INSERT [dbo].[Vehiculos] ([IdVehiculo], [Placa], [IdTipoVehiculo], [Tarifa]) VALUES (5, N'ABC1234', 4, CAST(5 AS Decimal(18, 0)))
GO
INSERT [dbo].[Vehiculos] ([IdVehiculo], [Placa], [IdTipoVehiculo], [Tarifa]) VALUES (6, N'DEF5678', 4, CAST(5 AS Decimal(18, 0)))
GO
INSERT [dbo].[Vehiculos] ([IdVehiculo], [Placa], [IdTipoVehiculo], [Tarifa]) VALUES (7, N'GHI9012', 4, CAST(5 AS Decimal(18, 0)))
GO
INSERT [dbo].[Vehiculos] ([IdVehiculo], [Placa], [IdTipoVehiculo], [Tarifa]) VALUES (8, N'JKL3456', 8, CAST(10 AS Decimal(18, 0)))
GO
INSERT [dbo].[Vehiculos] ([IdVehiculo], [Placa], [IdTipoVehiculo], [Tarifa]) VALUES (9, N'MNO7890', 8, CAST(10 AS Decimal(18, 0)))
GO
INSERT [dbo].[Vehiculos] ([IdVehiculo], [Placa], [IdTipoVehiculo], [Tarifa]) VALUES (10, N'ABC1234', 1, CAST(1000 AS Decimal(18, 0)))
GO
INSERT [dbo].[Vehiculos] ([IdVehiculo], [Placa], [IdTipoVehiculo], [Tarifa]) VALUES (11, N'DEF5678', 2, CAST(1500 AS Decimal(18, 0)))
GO
INSERT [dbo].[Vehiculos] ([IdVehiculo], [Placa], [IdTipoVehiculo], [Tarifa]) VALUES (12, N'GHI9012', 1, CAST(1200 AS Decimal(18, 0)))
GO
INSERT [dbo].[Vehiculos] ([IdVehiculo], [Placa], [IdTipoVehiculo], [Tarifa]) VALUES (13, N'JKL3456', 3, CAST(2000 AS Decimal(18, 0)))
GO
INSERT [dbo].[Vehiculos] ([IdVehiculo], [Placa], [IdTipoVehiculo], [Tarifa]) VALUES (14, N'MNO7890', 2, CAST(1800 AS Decimal(18, 0)))
GO
SET IDENTITY_INSERT [dbo].[Vehiculos] OFF
GO
ALTER TABLE [dbo].[Parqueaderos]  WITH CHECK ADD  CONSTRAINT [FK_Parqueadero_TipoParqueadero] FOREIGN KEY([TipoParqueadero])
REFERENCES [dbo].[TipoParqueadero] ([IdTipoParqueadero])
GO
ALTER TABLE [dbo].[Parqueaderos] CHECK CONSTRAINT [FK_Parqueadero_TipoParqueadero]
GO
ALTER TABLE [dbo].[Parqueaderos]  WITH CHECK ADD  CONSTRAINT [FK_Parqueaderos_Vehiculos] FOREIGN KEY([IdVehiculo])
REFERENCES [dbo].[Vehiculos] ([IdVehiculo])
GO
ALTER TABLE [dbo].[Parqueaderos] CHECK CONSTRAINT [FK_Parqueaderos_Vehiculos]
GO
ALTER TABLE [dbo].[Personas]  WITH CHECK ADD  CONSTRAINT [FK_Personas_Usuarios] FOREIGN KEY([UsuarioId])
REFERENCES [dbo].[Usuarios] ([IdUsuario])
GO
ALTER TABLE [dbo].[Personas] CHECK CONSTRAINT [FK_Personas_Usuarios]
GO
ALTER TABLE [dbo].[Tickets]  WITH CHECK ADD  CONSTRAINT [FK_Tickets_Parqueaderos] FOREIGN KEY([IdParqueadero])
REFERENCES [dbo].[Parqueaderos] ([IdParqueadero])
GO
ALTER TABLE [dbo].[Tickets] CHECK CONSTRAINT [FK_Tickets_Parqueaderos]
GO
ALTER TABLE [dbo].[Tickets]  WITH CHECK ADD  CONSTRAINT [FK_Tickets_Personas] FOREIGN KEY([IdPersona])
REFERENCES [dbo].[Personas] ([IdPersona])
GO
ALTER TABLE [dbo].[Tickets] CHECK CONSTRAINT [FK_Tickets_Personas]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Roles1] FOREIGN KEY([IdRol])
REFERENCES [dbo].[Roles] ([IdRol])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_Roles1]
GO
USE [master]
GO
ALTER DATABASE [ParckAppDB] SET  READ_WRITE 
GO
