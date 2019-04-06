use master
go
create database SUPERHEROES_DB
go
use SUPERHEROES_DB
go

USE SUPERHEROES_DB
GO

/****** Object:  Table [dbo].[PERSONAJES]    Script Date: 6/4/2019 11:08:40 ******/
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


insert into PERSONAJES (Nombre, Debilidad) values ('Ironman', 'Peper')
insert into PERSONAJES (Nombre, Debilidad) values ('Thor', 'su padre')
insert into PERSONAJES (Nombre, Debilidad) values ('Capitan America', 'Todo')
insert into PERSONAJES (Nombre, Debilidad) values ('Spiderman', 'Mary Jane')