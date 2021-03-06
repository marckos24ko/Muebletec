USE [master]
GO
/****** Object:  Database [FinancieraDB]    Script Date: 31/7/2021 05:20:17 ******/
CREATE DATABASE [FinancieraDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FinancieraDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\FinancieraDB.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'FinancieraDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\FinancieraDB_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [FinancieraDB] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FinancieraDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FinancieraDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FinancieraDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FinancieraDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FinancieraDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FinancieraDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [FinancieraDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FinancieraDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FinancieraDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FinancieraDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FinancieraDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FinancieraDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FinancieraDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FinancieraDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FinancieraDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FinancieraDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FinancieraDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FinancieraDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FinancieraDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FinancieraDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FinancieraDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FinancieraDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FinancieraDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FinancieraDB] SET RECOVERY FULL 
GO
ALTER DATABASE [FinancieraDB] SET  MULTI_USER 
GO
ALTER DATABASE [FinancieraDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FinancieraDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FinancieraDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FinancieraDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [FinancieraDB] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'FinancieraDB', N'ON'
GO
USE [FinancieraDB]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 31/7/2021 05:20:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](max) NOT NULL,
	[Apellido] [nvarchar](max) NOT NULL,
	[Dni] [int] NOT NULL,
	[DireccionComercial] [nvarchar](max) NOT NULL,
	[DireccionParticular] [nvarchar](max) NOT NULL,
	[Telefono] [nvarchar](max) NOT NULL,
	[Celular] [nvarchar](max) NOT NULL,
	[NumeroCliente] [int] NOT NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Creditos]    Script Date: 31/7/2021 05:20:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Creditos](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Monto] [decimal](18, 0) NOT NULL,
	[FechaEmision] [datetime] NOT NULL,
	[CantidadCuotas] [int] NOT NULL,
	[MontoCuota] [decimal](18, 0) NOT NULL,
	[Estado] [nvarchar](max) NOT NULL,
	[TotalAbonado] [decimal](18, 0) NOT NULL,
	[ClienteId] [bigint] NOT NULL,
	[FechaCancelacion] [datetime] NOT NULL,
	[CodigoCredito] [int] NOT NULL,
	[Interes] [int] NULL,
	[TipoCredito] [nvarchar](max) NOT NULL,
	[Refinanciado] [bit] NULL,
	[Extension] [bit] NULL,
	[CodigoCreditoBase] [int] NULL,
 CONSTRAINT [PK_Creditos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Recibos]    Script Date: 31/7/2021 05:20:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Recibos](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Numero] [int] NOT NULL,
	[MontoCredito] [decimal](18, 0) NOT NULL,
	[NumeroCuota] [int] NOT NULL,
	[CuotasPendiente] [int] NOT NULL,
	[MontoCuota] [decimal](18, 0) NOT NULL,
	[Saldo] [decimal](18, 0) NOT NULL,
	[UltimoPago] [nvarchar](max) NOT NULL,
	[Atraso] [decimal](18, 0) NOT NULL,
	[Pagado] [decimal](18, 0) NOT NULL,
	[FechaPago] [datetime] NOT NULL,
	[Pago] [decimal](18, 0) NOT NULL,
	[CreditoId] [bigint] NOT NULL,
	[ClienteId] [bigint] NOT NULL,
	[Estado] [nvarchar](max) NOT NULL,
	[CodigoCredito] [int] NOT NULL,
 CONSTRAINT [PK_Recibos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Index [IX_FK_ClienteCredito]    Script Date: 31/7/2021 05:20:17 ******/
CREATE NONCLUSTERED INDEX [IX_FK_ClienteCredito] ON [dbo].[Creditos]
(
	[ClienteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_ClienteRecibo]    Script Date: 31/7/2021 05:20:17 ******/
CREATE NONCLUSTERED INDEX [IX_FK_ClienteRecibo] ON [dbo].[Recibos]
(
	[ClienteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_CreditoRecibo]    Script Date: 31/7/2021 05:20:17 ******/
CREATE NONCLUSTERED INDEX [IX_FK_CreditoRecibo] ON [dbo].[Recibos]
(
	[CreditoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Creditos]  WITH CHECK ADD  CONSTRAINT [FK_ClienteCredito] FOREIGN KEY([ClienteId])
REFERENCES [dbo].[Clientes] ([Id])
GO
ALTER TABLE [dbo].[Creditos] CHECK CONSTRAINT [FK_ClienteCredito]
GO
ALTER TABLE [dbo].[Recibos]  WITH CHECK ADD  CONSTRAINT [FK_ClienteRecibo] FOREIGN KEY([ClienteId])
REFERENCES [dbo].[Clientes] ([Id])
GO
ALTER TABLE [dbo].[Recibos] CHECK CONSTRAINT [FK_ClienteRecibo]
GO
ALTER TABLE [dbo].[Recibos]  WITH CHECK ADD  CONSTRAINT [FK_CreditoRecibo] FOREIGN KEY([CreditoId])
REFERENCES [dbo].[Creditos] ([Id])
GO
ALTER TABLE [dbo].[Recibos] CHECK CONSTRAINT [FK_CreditoRecibo]
GO
USE [master]
GO
ALTER DATABASE [FinancieraDB] SET  READ_WRITE 
GO
