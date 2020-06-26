-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/26/2020 19:17:20
-- Generated from EDMX file: C:\Users\angel\source\repos\Gestion-De-Cafeteria\Gestion De Cafeteria\GestionCafeteriaEntity.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
CREATE DATABASE [GestionCafeteria];
GO
USE [GestionCafeteria];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK__Articulos__Marca__4E88ABD4]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Articulos] DROP CONSTRAINT [FK__Articulos__Marca__4E88ABD4];
GO
IF OBJECT_ID(N'[dbo].[FK__Articulos__Prove__4F7CD00D]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Articulos] DROP CONSTRAINT [FK__Articulos__Prove__4F7CD00D];
GO
IF OBJECT_ID(N'[dbo].[FK__Cafeteria__Encar__31EC6D26]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Cafeterias] DROP CONSTRAINT [FK__Cafeteria__Encar__31EC6D26];
GO
IF OBJECT_ID(N'[dbo].[FK__Cafeteria__ID_Ca__2F10007B]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Cafeterias] DROP CONSTRAINT [FK__Cafeteria__ID_Ca__2F10007B];
GO
IF OBJECT_ID(N'[dbo].[FK__Facturaci__Artic__534D60F1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Facturacion_Articulos] DROP CONSTRAINT [FK__Facturaci__Artic__534D60F1];
GO
IF OBJECT_ID(N'[dbo].[FK__Facturaci__Emple__52593CB8]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Facturacion_Articulos] DROP CONSTRAINT [FK__Facturaci__Emple__52593CB8];
GO
IF OBJECT_ID(N'[dbo].[FK__Facturaci__Usuar__5441852A]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Facturacion_Articulos] DROP CONSTRAINT [FK__Facturaci__Usuar__5441852A];
GO
IF OBJECT_ID(N'[dbo].[FK__Proveedor__Produ__4222D4EF]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProveedoresProductos] DROP CONSTRAINT [FK__Proveedor__Produ__4222D4EF];
GO
IF OBJECT_ID(N'[dbo].[FK__Proveedor__Prove__412EB0B6]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProveedoresProductos] DROP CONSTRAINT [FK__Proveedor__Prove__412EB0B6];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Articulos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Articulos];
GO
IF OBJECT_ID(N'[dbo].[Cafeterias]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cafeterias];
GO
IF OBJECT_ID(N'[dbo].[Campus]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Campus];
GO
IF OBJECT_ID(N'[dbo].[Empleadoes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Empleadoes];
GO
IF OBJECT_ID(N'[dbo].[Facturacion_Articulos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Facturacion_Articulos];
GO
IF OBJECT_ID(N'[dbo].[Marcas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Marcas];
GO
IF OBJECT_ID(N'[dbo].[Productoes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Productoes];
GO
IF OBJECT_ID(N'[dbo].[Proveedores]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Proveedores];
GO
IF OBJECT_ID(N'[dbo].[ProveedoresProductos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProveedoresProductos];
GO
IF OBJECT_ID(N'[dbo].[Tipo_Usuario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tipo_Usuario];
GO
IF OBJECT_ID(N'[dbo].[Usuarios]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Usuarios];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Campus'
CREATE TABLE [dbo].[Campus] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Descripcion] varchar(50)  NOT NULL,
    [Estado] char(2)  NULL
);
GO

-- Creating table 'Marcas'
CREATE TABLE [dbo].[Marcas] (
    [IdMarca] int IDENTITY(1,1) NOT NULL,
    [Descripcion] varchar(250)  NOT NULL,
    [Estado] varchar(10)  NOT NULL
);
GO

-- Creating table 'Proveedores'
CREATE TABLE [dbo].[Proveedores] (
    [IdProveedor] int IDENTITY(1,1) NOT NULL,
    [NombreComercial] varchar(50)  NOT NULL,
    [RNC] varchar(50)  NOT NULL,
    [FechaRegistro] datetime  NOT NULL,
    [Estado] varchar(10)  NOT NULL
);
GO

-- Creating table 'Tipo_Usuario'
CREATE TABLE [dbo].[Tipo_Usuario] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Descripcion] varchar(100)  NOT NULL,
    [Estado] char(2)  NULL
);
GO

-- Creating table 'Usuarios'
CREATE TABLE [dbo].[Usuarios] (
    [IdUsuario] int IDENTITY(1,1) NOT NULL,
    [Nombre] varchar(50)  NOT NULL,
    [Cedula] int  NOT NULL,
    [TipoUsuario] varchar(13)  NOT NULL,
    [LimiteCredito] decimal(10,2)  NULL,
    [FechaRegistro] datetime  NOT NULL,
    [Estado] varchar(10)  NOT NULL
);
GO

-- Creating table 'ProveedoresProductos'
CREATE TABLE [dbo].[ProveedoresProductos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ProveedorId] int  NULL,
    [ProductoId] int  NULL
);
GO

-- Creating table 'Articulos'
CREATE TABLE [dbo].[Articulos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Descripcion] varchar(250)  NOT NULL,
    [MarcaId] int  NOT NULL,
    [Costo] decimal(10,2)  NULL,
    [ProveedorId] int  NOT NULL,
    [Existencia] bit  NOT NULL,
    [Estado] bit  NOT NULL
);
GO

-- Creating table 'Facturacion_Articulos'
CREATE TABLE [dbo].[Facturacion_Articulos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [EmpleadoId] int  NOT NULL,
    [ArticuloId] int  NOT NULL,
    [UsuarioId] int  NOT NULL,
    [Fecha_Venta] datetime  NOT NULL,
    [Monto_De_Articulo] decimal(10,2)  NULL,
    [Unidades_Vendidas] int  NOT NULL,
    [Comentario] varchar(250)  NULL,
    [Estado] bit  NOT NULL
);
GO

-- Creating table 'Empleadoes'
CREATE TABLE [dbo].[Empleadoes] (
    [IdEMpleado] int IDENTITY(1,1) NOT NULL,
    [Nombre] varchar(20)  NOT NULL,
    [Direccion] varchar(50)  NOT NULL,
    [Salario] decimal(10,2)  NOT NULL,
    [Cedula] varchar(20)  NOT NULL,
    [Tanda_labor] varchar(15)  NOT NULL,
    [Porciento_Comision] int  NULL,
    [Fecha_Ingreso] datetime  NOT NULL,
    [Estado] bit  NOT NULL
);
GO

-- Creating table 'Cafeterias'
CREATE TABLE [dbo].[Cafeterias] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Descripcion] varchar(50)  NOT NULL,
    [ID_Campus] int  NOT NULL,
    [Encargado] int  NOT NULL,
    [Estado] char(2)  NULL
);
GO

-- Creating table 'Productoes'
CREATE TABLE [dbo].[Productoes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] varchar(25)  NOT NULL,
    [Precio] decimal(8,2)  NOT NULL,
    [FechaDeVencimiento] datetime  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'Campus'
ALTER TABLE [dbo].[Campus]
ADD CONSTRAINT [PK_Campus]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [IdMarca] in table 'Marcas'
ALTER TABLE [dbo].[Marcas]
ADD CONSTRAINT [PK_Marcas]
    PRIMARY KEY CLUSTERED ([IdMarca] ASC);
GO

-- Creating primary key on [IdProveedor] in table 'Proveedores'
ALTER TABLE [dbo].[Proveedores]
ADD CONSTRAINT [PK_Proveedores]
    PRIMARY KEY CLUSTERED ([IdProveedor] ASC);
GO

-- Creating primary key on [ID] in table 'Tipo_Usuario'
ALTER TABLE [dbo].[Tipo_Usuario]
ADD CONSTRAINT [PK_Tipo_Usuario]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [IdUsuario] in table 'Usuarios'
ALTER TABLE [dbo].[Usuarios]
ADD CONSTRAINT [PK_Usuarios]
    PRIMARY KEY CLUSTERED ([IdUsuario] ASC);
GO

-- Creating primary key on [Id] in table 'ProveedoresProductos'
ALTER TABLE [dbo].[ProveedoresProductos]
ADD CONSTRAINT [PK_ProveedoresProductos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Articulos'
ALTER TABLE [dbo].[Articulos]
ADD CONSTRAINT [PK_Articulos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Facturacion_Articulos'
ALTER TABLE [dbo].[Facturacion_Articulos]
ADD CONSTRAINT [PK_Facturacion_Articulos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [IdEMpleado] in table 'Empleadoes'
ALTER TABLE [dbo].[Empleadoes]
ADD CONSTRAINT [PK_Empleadoes]
    PRIMARY KEY CLUSTERED ([IdEMpleado] ASC);
GO

-- Creating primary key on [ID] in table 'Cafeterias'
ALTER TABLE [dbo].[Cafeterias]
ADD CONSTRAINT [PK_Cafeterias]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [Id] in table 'Productoes'
ALTER TABLE [dbo].[Productoes]
ADD CONSTRAINT [PK_Productoes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ProveedorId] in table 'ProveedoresProductos'
ALTER TABLE [dbo].[ProveedoresProductos]
ADD CONSTRAINT [FK__Proveedor__Prove__412EB0B6]
    FOREIGN KEY ([ProveedorId])
    REFERENCES [dbo].[Proveedores]
        ([IdProveedor])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Proveedor__Prove__412EB0B6'
CREATE INDEX [IX_FK__Proveedor__Prove__412EB0B6]
ON [dbo].[ProveedoresProductos]
    ([ProveedorId]);
GO

-- Creating foreign key on [MarcaId] in table 'Articulos'
ALTER TABLE [dbo].[Articulos]
ADD CONSTRAINT [FK__Articulos__Marca__4E88ABD4]
    FOREIGN KEY ([MarcaId])
    REFERENCES [dbo].[Marcas]
        ([IdMarca])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Articulos__Marca__4E88ABD4'
CREATE INDEX [IX_FK__Articulos__Marca__4E88ABD4]
ON [dbo].[Articulos]
    ([MarcaId]);
GO

-- Creating foreign key on [ProveedorId] in table 'Articulos'
ALTER TABLE [dbo].[Articulos]
ADD CONSTRAINT [FK__Articulos__Prove__4F7CD00D]
    FOREIGN KEY ([ProveedorId])
    REFERENCES [dbo].[Proveedores]
        ([IdProveedor])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Articulos__Prove__4F7CD00D'
CREATE INDEX [IX_FK__Articulos__Prove__4F7CD00D]
ON [dbo].[Articulos]
    ([ProveedorId]);
GO

-- Creating foreign key on [ArticuloId] in table 'Facturacion_Articulos'
ALTER TABLE [dbo].[Facturacion_Articulos]
ADD CONSTRAINT [FK__Facturaci__Artic__534D60F1]
    FOREIGN KEY ([ArticuloId])
    REFERENCES [dbo].[Articulos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Facturaci__Artic__534D60F1'
CREATE INDEX [IX_FK__Facturaci__Artic__534D60F1]
ON [dbo].[Facturacion_Articulos]
    ([ArticuloId]);
GO

-- Creating foreign key on [UsuarioId] in table 'Facturacion_Articulos'
ALTER TABLE [dbo].[Facturacion_Articulos]
ADD CONSTRAINT [FK__Facturaci__Usuar__5441852A]
    FOREIGN KEY ([UsuarioId])
    REFERENCES [dbo].[Usuarios]
        ([IdUsuario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Facturaci__Usuar__5441852A'
CREATE INDEX [IX_FK__Facturaci__Usuar__5441852A]
ON [dbo].[Facturacion_Articulos]
    ([UsuarioId]);
GO

-- Creating foreign key on [EmpleadoId] in table 'Facturacion_Articulos'
ALTER TABLE [dbo].[Facturacion_Articulos]
ADD CONSTRAINT [FK__Facturaci__Emple__52593CB8]
    FOREIGN KEY ([EmpleadoId])
    REFERENCES [dbo].[Empleadoes]
        ([IdEMpleado])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Facturaci__Emple__52593CB8'
CREATE INDEX [IX_FK__Facturaci__Emple__52593CB8]
ON [dbo].[Facturacion_Articulos]
    ([EmpleadoId]);
GO

-- Creating foreign key on [Encargado] in table 'Cafeterias'
ALTER TABLE [dbo].[Cafeterias]
ADD CONSTRAINT [FK__Cafeteria__Encar__31EC6D26]
    FOREIGN KEY ([Encargado])
    REFERENCES [dbo].[Empleadoes]
        ([IdEMpleado])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Cafeteria__Encar__31EC6D26'
CREATE INDEX [IX_FK__Cafeteria__Encar__31EC6D26]
ON [dbo].[Cafeterias]
    ([Encargado]);
GO

-- Creating foreign key on [ID_Campus] in table 'Cafeterias'
ALTER TABLE [dbo].[Cafeterias]
ADD CONSTRAINT [FK__Cafeteria__ID_Ca__2F10007B]
    FOREIGN KEY ([ID_Campus])
    REFERENCES [dbo].[Campus]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Cafeteria__ID_Ca__2F10007B'
CREATE INDEX [IX_FK__Cafeteria__ID_Ca__2F10007B]
ON [dbo].[Cafeterias]
    ([ID_Campus]);
GO

-- Creating foreign key on [ProductoId] in table 'ProveedoresProductos'
ALTER TABLE [dbo].[ProveedoresProductos]
ADD CONSTRAINT [FK__Proveedor__Produ__4222D4EF]
    FOREIGN KEY ([ProductoId])
    REFERENCES [dbo].[Productoes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Proveedor__Produ__4222D4EF'
CREATE INDEX [IX_FK__Proveedor__Produ__4222D4EF]
ON [dbo].[ProveedoresProductos]
    ([ProductoId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------