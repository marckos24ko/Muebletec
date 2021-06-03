
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/07/2021 00:13:26
-- Generated from EDMX file: A:\Trabajo\Financiera\DAL\ModeloFinanciera.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [FinancieraDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ClienteCredito]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Creditos] DROP CONSTRAINT [FK_ClienteCredito];
GO
IF OBJECT_ID(N'[dbo].[FK_CreditoRecibo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Recibos] DROP CONSTRAINT [FK_CreditoRecibo];
GO
IF OBJECT_ID(N'[dbo].[FK_ClienteRecibo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Recibos] DROP CONSTRAINT [FK_ClienteRecibo];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Clientes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Clientes];
GO
IF OBJECT_ID(N'[dbo].[Creditos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Creditos];
GO
IF OBJECT_ID(N'[dbo].[Recibos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Recibos];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Clientes'
CREATE TABLE [dbo].[Clientes] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Apellido] nvarchar(max)  NOT NULL,
    [Dni] int  NOT NULL,
    [DireccionComercial] nvarchar(max)  NOT NULL,
    [DireccionParticular] nvarchar(max)  NOT NULL,
    [Telefono] nvarchar(max)  NOT NULL,
    [Celular] nvarchar(max)  NOT NULL,
    [NumeroCliente] int  NOT NULL,
    [Estado] bit  NOT NULL
);
GO

-- Creating table 'Creditos'
CREATE TABLE [dbo].[Creditos] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [Monto] decimal(18,0)  NOT NULL,
    [FechaEmision] datetime  NOT NULL,
    [CantidadCuotas] int  NOT NULL,
    [MontoCuota] decimal(18,0)  NOT NULL,
    [Estado] nvarchar(max)  NOT NULL,
    [TotalAbonado] decimal(18,0)  NOT NULL,
    [ClienteId] bigint  NOT NULL,
    [FechaCancelacion] datetime  NOT NULL,
    [CodigoCredito] int  NOT NULL,
    [Interes] int  NULL,
    [TipoCredito] nvarchar(max)  NOT NULL,
    [Refinanciado] bit  NULL,
    [Extension] bit  NULL,
    [CodigoCreditoBase] int  NULL
);
GO

-- Creating table 'Recibos'
CREATE TABLE [dbo].[Recibos] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [Numero] int  NOT NULL,
    [MontoCredito] decimal(18,0)  NOT NULL,
    [NumeroCuota] int  NOT NULL,
    [CuotasPendiente] int  NOT NULL,
    [MontoCuota] decimal(18,0)  NOT NULL,
    [Saldo] decimal(18,0)  NOT NULL,
    [UltimoPago] nvarchar(max)  NOT NULL,
    [Atraso] decimal(18,0)  NOT NULL,
    [Pagado] decimal(18,0)  NOT NULL,
    [FechaPago] datetime  NOT NULL,
    [Pago] decimal(18,0)  NOT NULL,
    [CreditoId] bigint  NOT NULL,
    [ClienteId] bigint  NOT NULL,
    [Estado] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Clientes'
ALTER TABLE [dbo].[Clientes]
ADD CONSTRAINT [PK_Clientes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Creditos'
ALTER TABLE [dbo].[Creditos]
ADD CONSTRAINT [PK_Creditos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Recibos'
ALTER TABLE [dbo].[Recibos]
ADD CONSTRAINT [PK_Recibos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ClienteId] in table 'Creditos'
ALTER TABLE [dbo].[Creditos]
ADD CONSTRAINT [FK_ClienteCredito]
    FOREIGN KEY ([ClienteId])
    REFERENCES [dbo].[Clientes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteCredito'
CREATE INDEX [IX_FK_ClienteCredito]
ON [dbo].[Creditos]
    ([ClienteId]);
GO

-- Creating foreign key on [CreditoId] in table 'Recibos'
ALTER TABLE [dbo].[Recibos]
ADD CONSTRAINT [FK_CreditoRecibo]
    FOREIGN KEY ([CreditoId])
    REFERENCES [dbo].[Creditos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CreditoRecibo'
CREATE INDEX [IX_FK_CreditoRecibo]
ON [dbo].[Recibos]
    ([CreditoId]);
GO

-- Creating foreign key on [ClienteId] in table 'Recibos'
ALTER TABLE [dbo].[Recibos]
ADD CONSTRAINT [FK_ClienteRecibo]
    FOREIGN KEY ([ClienteId])
    REFERENCES [dbo].[Clientes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteRecibo'
CREATE INDEX [IX_FK_ClienteRecibo]
ON [dbo].[Recibos]
    ([ClienteId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------