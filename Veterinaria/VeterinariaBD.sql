USE [master]
GO
/****** Object:  Database [Veterinaria]    Script Date: 9/3/2022 22:48:03 ******/
CREATE DATABASE [Veterinaria]
GO

USE [Veterinaria]
GO
/****** Object:  Table [dbo].[tbMascota]    Script Date: 9/3/2022 22:48:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbMascota](
	[id] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[idGenero] [int] NULL,
	[color] [varchar](50) NULL,
	[idPersona] [int] NULL,
	[animal] [varchar](50) NULL,
 CONSTRAINT [PK_tbMascota] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbPersona]    Script Date: 9/3/2022 22:48:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbPersona](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[idGenero] [int] NULL,
 CONSTRAINT [PK_tbPersona] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbPersona] ON 

INSERT [dbo].[tbPersona] ([id], [nombre], [apellido], [idGenero]) VALUES (1, N'7687', N'7687', 1)
INSERT [dbo].[tbPersona] ([id], [nombre], [apellido], [idGenero]) VALUES (3, N'paco', N'relics', 1)
INSERT [dbo].[tbPersona] ([id], [nombre], [apellido], [idGenero]) VALUES (4, N'Luis', N'bolear', 1)
INSERT [dbo].[tbPersona] ([id], [nombre], [apellido], [idGenero]) VALUES (5, N'Peter', N'Pan', 1)
INSERT [dbo].[tbPersona] ([id], [nombre], [apellido], [idGenero]) VALUES (6, N'Julio', N'Meza', 1)
SET IDENTITY_INSERT [dbo].[tbPersona] OFF
GO
ALTER TABLE [dbo].[tbMascota]  WITH CHECK ADD  CONSTRAINT [FK_tbMascota_tbPersona] FOREIGN KEY([idPersona])
REFERENCES [dbo].[tbPersona] ([id])
GO
ALTER TABLE [dbo].[tbMascota] CHECK CONSTRAINT [FK_tbMascota_tbPersona]
GO
USE [master]
GO
ALTER DATABASE [Veterinaria] SET  READ_WRITE 
GO
