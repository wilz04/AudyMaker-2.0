if exists (select * from sysobjects where id = object_id(N'[dbo].[Auditorias]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Auditorias]
GO

if exists (select * from sysobjects where id = object_id(N'[dbo].[Usuarios]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Usuarios]
GO

CREATE TABLE [dbo].[Auditorias] (
	[Emisor] [nvarchar] (100) NULL ,
	[Fecha] [nvarchar] (100) NULL ,
	[Titulo] [nvarchar] (100) NULL ,
	[Texto] [nvarchar] (1000) NULL ,
	[Id] [int] IDENTITY (1, 1) NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Usuarios] (
	[Login] [nvarchar] (10) NULL ,
	[Password] [nvarchar] (10) NULL ,
	[Nombre] [nvarchar] (40) NULL ,
	[Sexo] [nvarchar] (10) NULL ,
	[Cedula] [nvarchar] (10) NULL ,
	[Direccion] [nvarchar] (100) NULL ,
	[Id] [int] IDENTITY (1, 1) NOT NULL 
) ON [PRIMARY]
GO

