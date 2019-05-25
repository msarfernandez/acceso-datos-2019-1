use master
go
create database SUPERHEROES_DB
go
USE [SUPERHEROES_DB]
GO
/****** Object:  Table [dbo].[PERSONAJES]    Script Date: 24/5/2019 21:30:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PERSONAJES](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Debilidad] [varchar](50) NULL,
	[UsaCapa] [bit] NULL,
	[Volador] [bit] NULL,
	[IdUniverso] [int] NULL,
 CONSTRAINT [PK_PERSONAJES] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UNIVERSOS]    Script Date: 24/5/2019 21:30:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UNIVERSOS](
	[IdUniverso] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_UNIVERSOS] PRIMARY KEY CLUSTERED 
(
	[IdUniverso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[agregarHeroe]    Script Date: 24/5/2019 21:30:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[agregarHeroe]
@Nombre varchar(30),
@Debilidad varchar(30)
as
insert into PERSONAJES (Nombre, Debilidad) values (@Nombre, @Debilidad)

GO
