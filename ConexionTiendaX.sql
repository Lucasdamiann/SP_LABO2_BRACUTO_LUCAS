USE [master]
GO
/****** Object:  Database [tiendaX_db]    Script Date: 23/11/2023 17:58:31 ******/
CREATE DATABASE [tiendaX_db]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'tiendaX_db', FILENAME = N'D:\Instalaciones\Programas\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\tiendaX_db.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'tiendaX_db_log', FILENAME = N'D:\Instalaciones\Programas\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\tiendaX_db_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [tiendaX_db] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [tiendaX_db].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [tiendaX_db] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [tiendaX_db] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [tiendaX_db] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [tiendaX_db] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [tiendaX_db] SET ARITHABORT OFF 
GO
ALTER DATABASE [tiendaX_db] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [tiendaX_db] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [tiendaX_db] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [tiendaX_db] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [tiendaX_db] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [tiendaX_db] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [tiendaX_db] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [tiendaX_db] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [tiendaX_db] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [tiendaX_db] SET  ENABLE_BROKER 
GO
ALTER DATABASE [tiendaX_db] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [tiendaX_db] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [tiendaX_db] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [tiendaX_db] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [tiendaX_db] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [tiendaX_db] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [tiendaX_db] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [tiendaX_db] SET RECOVERY FULL 
GO
ALTER DATABASE [tiendaX_db] SET  MULTI_USER 
GO
ALTER DATABASE [tiendaX_db] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [tiendaX_db] SET DB_CHAINING OFF 
GO
ALTER DATABASE [tiendaX_db] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [tiendaX_db] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [tiendaX_db] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [tiendaX_db] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'tiendaX_db', N'ON'
GO
ALTER DATABASE [tiendaX_db] SET QUERY_STORE = ON
GO
ALTER DATABASE [tiendaX_db] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [tiendaX_db]
GO
/****** Object:  Table [dbo].[clientes]    Script Date: 23/11/2023 17:58:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clientes](
	[id_Cliente] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](20) NULL,
	[apellido] [varchar](20) NULL,
	[direccion] [varchar](50) NULL,
 CONSTRAINT [pk_id_Cliente] PRIMARY KEY CLUSTERED 
(
	[id_Cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 23/11/2023 17:58:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[id_Usuario] [int] IDENTITY(1,1) NOT NULL,
	[tipo] [varchar](20) NULL,
	[usuario] [varchar](15) NULL,
	[clave] [varchar](12) NULL,
 CONSTRAINT [pk_id_Usuario] PRIMARY KEY CLUSTERED 
(
	[id_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[clientes] ON 

INSERT [dbo].[clientes] ([id_Cliente], [nombre], [apellido], [direccion]) VALUES (1, N'Rodie', N'Chilley', N'63 Dunning Way')
INSERT [dbo].[clientes] ([id_Cliente], [nombre], [apellido], [direccion]) VALUES (2, N'Jade', N'Verring', N'65 Sugar Drive')
INSERT [dbo].[clientes] ([id_Cliente], [nombre], [apellido], [direccion]) VALUES (3, N'Kacy', N'Coy', N'16058 Pankratz Place')
INSERT [dbo].[clientes] ([id_Cliente], [nombre], [apellido], [direccion]) VALUES (4, N'Edlin', N'Fearfull', N'2149 Hollow Ridge Court')
INSERT [dbo].[clientes] ([id_Cliente], [nombre], [apellido], [direccion]) VALUES (5, N'Issiah', N'O''Fallone', N'66271 Bashford Hill')
INSERT [dbo].[clientes] ([id_Cliente], [nombre], [apellido], [direccion]) VALUES (6, N'Mavis', N'Meeson', N'4377 Hoard Park')
INSERT [dbo].[clientes] ([id_Cliente], [nombre], [apellido], [direccion]) VALUES (7, N'Westbrook', N'Lawrenceson', N'0 Independence Crossing')
INSERT [dbo].[clientes] ([id_Cliente], [nombre], [apellido], [direccion]) VALUES (8, N'Lilian', N'Burnep', N'18 Westerfield Plaza')
INSERT [dbo].[clientes] ([id_Cliente], [nombre], [apellido], [direccion]) VALUES (9, N'Donovan', N'Caudle', N'0 Orin Park')
INSERT [dbo].[clientes] ([id_Cliente], [nombre], [apellido], [direccion]) VALUES (10, N'Barby', N'Botley', N'7679 Armis Park')
INSERT [dbo].[clientes] ([id_Cliente], [nombre], [apellido], [direccion]) VALUES (19, N'mateo', N'bracuto', N'casita con mami y papi')
SET IDENTITY_INSERT [dbo].[clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[usuarios] ON 

INSERT [dbo].[usuarios] ([id_Usuario], [tipo], [usuario], [clave]) VALUES (1, N'Administrador', N'admin', N'admin')
INSERT [dbo].[usuarios] ([id_Usuario], [tipo], [usuario], [clave]) VALUES (2, N'Usuario', N'usuario', N'1234')
SET IDENTITY_INSERT [dbo].[usuarios] OFF
GO
USE [master]
GO
ALTER DATABASE [tiendaX_db] SET  READ_WRITE 
GO
