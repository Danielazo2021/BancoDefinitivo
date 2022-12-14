USE [BancoDB]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 15/11/2022 12:31:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[id_cliente] [int] NOT NULL,
	[nom_cliente] [varchar](50) NULL,
	[ape_cliente] [varchar](50) NULL,
	[dni] [numeric](10, 0) NULL,
	[id_estado] [int] NULL,
	[mail] [nchar](50) NULL,
 CONSTRAINT [pk_clientes] PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cuentas]    Script Date: 15/11/2022 12:31:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cuentas](
	[cbu] [numeric](22, 0) NOT NULL,
	[saldo] [numeric](20, 2) NULL,
	[id_tipo] [int] NULL,
	[id_cliente] [int] NULL,
	[ultimo_mov] [datetime] NULL,
	[fecha_baja] [datetime] NULL,
 CONSTRAINT [pk_cuentas] PRIMARY KEY CLUSTERED 
(
	[cbu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estado_Civil]    Script Date: 15/11/2022 12:31:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estado_Civil](
	[id_estado] [int] IDENTITY(1,1) NOT NULL,
	[nom_estado] [varchar](25) NULL,
 CONSTRAINT [pk_estados] PRIMARY KEY CLUSTERED 
(
	[id_estado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_cuentas]    Script Date: 15/11/2022 12:31:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_cuentas](
	[id_tipo] [int] NOT NULL,
	[nom_cuenta] [varchar](30) NULL,
 CONSTRAINT [pk_tipo_cuentas] PRIMARY KEY CLUSTERED 
(
	[id_tipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 15/11/2022 12:31:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[dni] [int] NOT NULL,
	[nom_usuario] [varchar](30) NULL,
	[pass] [varchar](10) NULL,
 CONSTRAINT [pk_usuarios] PRIMARY KEY CLUSTERED 
(
	[dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [ape_cliente], [dni], [id_estado], [mail]) VALUES (5, N'Pedro', N'Vivas', CAST(33669850 AS Numeric(10, 0)), 1, NULL)
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [ape_cliente], [dni], [id_estado], [mail]) VALUES (6, N'Daniel', N'Saigo', CAST(35658961 AS Numeric(10, 0)), 2, NULL)
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [ape_cliente], [dni], [id_estado], [mail]) VALUES (7, N'Alberto', N'Suearez', CAST(25896314 AS Numeric(10, 0)), 1, NULL)
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [ape_cliente], [dni], [id_estado], [mail]) VALUES (8, N'Samanta', N'Rivas', CAST(36985656 AS Numeric(10, 0)), 1, NULL)
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [ape_cliente], [dni], [id_estado], [mail]) VALUES (9, N'Pablo', N'Escobar', CAST(14563214 AS Numeric(10, 0)), 2, NULL)
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [ape_cliente], [dni], [id_estado], [mail]) VALUES (10, N'Lucas', N'Selaya', CAST(11563654 AS Numeric(10, 0)), 1, NULL)
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [ape_cliente], [dni], [id_estado], [mail]) VALUES (11, N'Diego', N'Guizzo', CAST(3658962 AS Numeric(10, 0)), 4, N'diego_123@gmail.com                               ')
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [ape_cliente], [dni], [id_estado], [mail]) VALUES (12, N'Sergio', N'Barreda', CAST(20555556 AS Numeric(10, 0)), 1, N'ser_bar@chotmail.com                              ')
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [ape_cliente], [dni], [id_estado], [mail]) VALUES (13, N'Lorena', N'Muzo', CAST(15265742 AS Numeric(10, 0)), 3, N'Lalore_alberdi@gmail.com                          ')
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [ape_cliente], [dni], [id_estado], [mail]) VALUES (25, N'Juan Carlos', N'Hola', CAST(66993322 AS Numeric(10, 0)), 1, NULL)
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [ape_cliente], [dni], [id_estado], [mail]) VALUES (26, N'William', N'Magic', CAST(19563325 AS Numeric(10, 0)), 2, NULL)
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [ape_cliente], [dni], [id_estado], [mail]) VALUES (27, N'Ivan', N'Bacco', CAST(6655663 AS Numeric(10, 0)), 2, N'capitan_marin@gmail.com                           ')
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [ape_cliente], [dni], [id_estado], [mail]) VALUES (29, N'Wilys', N'Stone', CAST(8880009 AS Numeric(10, 0)), 2, NULL)
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [ape_cliente], [dni], [id_estado], [mail]) VALUES (30, N'daniel', N'Wlintong', CAST(12548759 AS Numeric(10, 0)), 2, NULL)
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [ape_cliente], [dni], [id_estado], [mail]) VALUES (31, N'Marcelo', N'Catoni', CAST(14247896 AS Numeric(10, 0)), 2, NULL)
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [ape_cliente], [dni], [id_estado], [mail]) VALUES (32, N'Dario', N'Benavidez', CAST(21548763 AS Numeric(10, 0)), 2, NULL)
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [ape_cliente], [dni], [id_estado], [mail]) VALUES (33, N'Pedro', N'Ardhu', CAST(40568963 AS Numeric(10, 0)), 2, N'Pedrito_elmarginal@gmail.com                      ')
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [ape_cliente], [dni], [id_estado], [mail]) VALUES (34, N'daniel', N'grecco', CAST(34131648 AS Numeric(10, 0)), 4, N'El_Wily@gmail.com                                 ')
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [ape_cliente], [dni], [id_estado], [mail]) VALUES (35, N'Alberto', N'Stone', CAST(6586586 AS Numeric(10, 0)), 2, NULL)
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [ape_cliente], [dni], [id_estado], [mail]) VALUES (36, N'Fabrizio', N'Trejo', CAST(3565980 AS Numeric(10, 0)), 2, N'Fabri_matador@hotmail.com                         ')
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [ape_cliente], [dni], [id_estado], [mail]) VALUES (37, N'toro', N'ñoño', CAST(15256598 AS Numeric(10, 0)), 1, N'toroñoño_22@gmail.com                             ')
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [ape_cliente], [dni], [id_estado], [mail]) VALUES (38, N'Jean ', N'Carlos', CAST(24568970 AS Numeric(10, 0)), 4, N'Elnegro_jean@gmail.com                            ')
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [ape_cliente], [dni], [id_estado], [mail]) VALUES (39, N'Disney', N'Toor', CAST(30258369 AS Numeric(10, 0)), 3, N'Disneyqdisney                                     ')
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [ape_cliente], [dni], [id_estado], [mail]) VALUES (40, N'Romina', N'Insfran', CAST(38002538 AS Numeric(10, 0)), 4, N'makucita@gmail.com                                ')
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [ape_cliente], [dni], [id_estado], [mail]) VALUES (41, N'Carlos', N'Tejeiro', CAST(25899635 AS Numeric(10, 0)), 2, N'carlo_blaco@hotmai..com                           ')
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [ape_cliente], [dni], [id_estado], [mail]) VALUES (42, N'Valeria', N'Gomez', CAST(56565898 AS Numeric(10, 0)), 1, N'vale_gomez@gmail.com                              ')
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [ape_cliente], [dni], [id_estado], [mail]) VALUES (43, N'Juan', N'XXIII', CAST(25698756 AS Numeric(10, 0)), 4, N'JuanXXII@gmail.com                                ')
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [ape_cliente], [dni], [id_estado], [mail]) VALUES (44, N'Nicolas', N'Martin', CAST(34565654 AS Numeric(10, 0)), 2, N'nicolas_martin@gmail.com                          ')
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [ape_cliente], [dni], [id_estado], [mail]) VALUES (45, N'kari', N'Luna', CAST(35656564 AS Numeric(10, 0)), 1, N'kari@gmail.com                                    ')
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [ape_cliente], [dni], [id_estado], [mail]) VALUES (46, N'Jhon', N'Volt', CAST(20532678 AS Numeric(10, 0)), 3, N'jon_v@outlook.com                                 ')
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [ape_cliente], [dni], [id_estado], [mail]) VALUES (47, N'Julieta', N'Venegas', CAST(28456780 AS Numeric(10, 0)), 1, N'juli_36@gmail.com                                 ')
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [ape_cliente], [dni], [id_estado], [mail]) VALUES (48, N'Mika', N'Blasco', CAST(33258697 AS Numeric(10, 0)), 4, N'mikita@gmail.com                                  ')
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [ape_cliente], [dni], [id_estado], [mail]) VALUES (49, N'Jime', N'Blasco', CAST(33569805 AS Numeric(10, 0)), 1, N'Jime_blas@gmail.com                               ')
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [ape_cliente], [dni], [id_estado], [mail]) VALUES (50, N'Mateo', N'Aguirre', CAST(35265980 AS Numeric(10, 0)), 4, N'mateo_2@gmail.com                                 ')
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [ape_cliente], [dni], [id_estado], [mail]) VALUES (51, N'Carla', N'Paz', CAST(25896316 AS Numeric(10, 0)), 2, N'carla_paz@gmail.com                               ')
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [ape_cliente], [dni], [id_estado], [mail]) VALUES (52, N'carlos', N'manson', CAST(25897892 AS Numeric(10, 0)), 1, N'carlos_manson@gmail.com                           ')
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [ape_cliente], [dni], [id_estado], [mail]) VALUES (53, N'Daniel', N'Prueba', CAST(326598741 AS Numeric(10, 0)), 1, N'mail_prueba@gmail.com                             ')
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [ape_cliente], [dni], [id_estado], [mail]) VALUES (54, N'Carlos', N'Juanres', CAST(4527866 AS Numeric(10, 0)), 1, N'mail_propio@gmail.com                             ')
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [ape_cliente], [dni], [id_estado], [mail]) VALUES (55, N'gr', N'ge', CAST(26565656 AS Numeric(10, 0)), 1, N'daniel_la@gmail.com                               ')
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [ape_cliente], [dni], [id_estado], [mail]) VALUES (56, N'Nicolas', N'Martin', CAST(41963767 AS Numeric(10, 0)), 1, N'nemartinr@gmail.com                               ')
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [ape_cliente], [dni], [id_estado], [mail]) VALUES (57, N'Roberto', N'Martin', CAST(41963768 AS Numeric(10, 0)), 1, N'nemartinr@gmail.com                               ')
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [ape_cliente], [dni], [id_estado], [mail]) VALUES (58, N'Claudio', N'Garcia', CAST(34131640 AS Numeric(10, 0)), 4, N'claudio_garcia@gmail.com                          ')
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [ape_cliente], [dni], [id_estado], [mail]) VALUES (59, N'Carlos', N'Ponce', CAST(35698564 AS Numeric(10, 0)), 1, N'danielalbertogrecco@gmail.com                     ')
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [ape_cliente], [dni], [id_estado], [mail]) VALUES (60, N'Romina', N'Macarena', CAST(38002537 AS Numeric(10, 0)), 4, N'romimak11@gmail.com                               ')
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [ape_cliente], [dni], [id_estado], [mail]) VALUES (61, N'Carlos', N'Masur', CAST(20599870 AS Numeric(10, 0)), 1, N'carlos_mansur@gmail.com                           ')
GO
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000014 AS Numeric(22, 0)), CAST(66699963.00 AS Numeric(20, 2)), 1, 35, CAST(N'2022-10-21T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000015 AS Numeric(22, 0)), CAST(7777444.00 AS Numeric(20, 2)), 3, 33, CAST(N'2022-10-10T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000016 AS Numeric(22, 0)), CAST(47852.00 AS Numeric(20, 2)), 2, 7, CAST(N'2020-10-10T00:00:00.000' AS DateTime), CAST(N'2022-11-20T00:00:00.000' AS DateTime))
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000017 AS Numeric(22, 0)), CAST(2589.00 AS Numeric(20, 2)), 2, 6, CAST(N'2022-05-15T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000018 AS Numeric(22, 0)), CAST(5656598.00 AS Numeric(20, 2)), 1, 34, CAST(N'2022-10-25T00:00:00.000' AS DateTime), CAST(N'2022-11-06T11:00:33.053' AS DateTime))
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000019 AS Numeric(22, 0)), CAST(255745.00 AS Numeric(20, 2)), 3, 11, CAST(N'2022-11-09T13:56:21.630' AS DateTime), NULL)
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000020 AS Numeric(22, 0)), CAST(256855.00 AS Numeric(20, 2)), 1, 11, CAST(N'2022-11-09T13:56:21.630' AS DateTime), NULL)
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000021 AS Numeric(22, 0)), CAST(69300.00 AS Numeric(20, 2)), 3, 10, CAST(N'2021-09-26T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000022 AS Numeric(22, 0)), CAST(1000.00 AS Numeric(20, 2)), 2, 12, CAST(N'2022-10-25T00:00:00.000' AS DateTime), CAST(N'2020-11-05T00:00:00.000' AS DateTime))
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000023 AS Numeric(22, 0)), CAST(250.00 AS Numeric(20, 2)), 2, 36, CAST(N'2015-10-10T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000024 AS Numeric(22, 0)), CAST(1000.00 AS Numeric(20, 2)), 1, 13, CAST(N'2022-10-25T00:00:00.000' AS DateTime), CAST(N'2020-11-06T00:00:00.000' AS DateTime))
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000025 AS Numeric(22, 0)), CAST(500897.00 AS Numeric(20, 2)), 3, 7, CAST(N'2022-12-08T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000026 AS Numeric(22, 0)), CAST(9800.00 AS Numeric(20, 2)), 2, 7, CAST(N'2021-02-28T00:00:00.000' AS DateTime), CAST(N'2021-11-20T00:00:00.000' AS DateTime))
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000027 AS Numeric(22, 0)), CAST(99999.00 AS Numeric(20, 2)), 3, 9, CAST(N'2009-03-31T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000028 AS Numeric(22, 0)), CAST(10000.00 AS Numeric(20, 2)), 1, 27, CAST(N'2022-11-02T17:34:02.760' AS DateTime), CAST(N'2021-05-02T00:00:00.000' AS DateTime))
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000029 AS Numeric(22, 0)), CAST(4000.00 AS Numeric(20, 2)), 3, 7, CAST(N'2019-02-10T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000030 AS Numeric(22, 0)), CAST(25800.00 AS Numeric(20, 2)), 1, 8, CAST(N'2014-09-30T00:00:00.000' AS DateTime), CAST(N'2021-05-15T00:00:00.000' AS DateTime))
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000031 AS Numeric(22, 0)), CAST(6565.00 AS Numeric(20, 2)), 2, 32, CAST(N'2022-10-10T00:00:00.000' AS DateTime), CAST(N'2021-05-21T00:00:00.000' AS DateTime))
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000032 AS Numeric(22, 0)), CAST(4000.00 AS Numeric(20, 2)), 1, 36, CAST(N'2020-11-03T00:00:00.000' AS DateTime), CAST(N'2021-05-14T00:00:00.000' AS DateTime))
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000033 AS Numeric(22, 0)), CAST(6900.00 AS Numeric(20, 2)), 3, 27, CAST(N'2021-10-10T00:00:00.000' AS DateTime), CAST(N'2021-03-03T00:00:00.000' AS DateTime))
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000034 AS Numeric(22, 0)), CAST(15000500.00 AS Numeric(20, 2)), 1, 30, CAST(N'2022-11-03T00:00:00.000' AS DateTime), CAST(N'2021-01-05T00:00:00.000' AS DateTime))
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000035 AS Numeric(22, 0)), CAST(141958.00 AS Numeric(20, 2)), 1, 34, CAST(N'2022-11-08T14:54:32.577' AS DateTime), CAST(N'2021-05-15T00:00:00.000' AS DateTime))
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000036 AS Numeric(22, 0)), CAST(2020.00 AS Numeric(20, 2)), 2, 37, CAST(N'2022-01-01T00:00:00.000' AS DateTime), CAST(N'2022-04-15T00:00:00.000' AS DateTime))
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000037 AS Numeric(22, 0)), CAST(90000.00 AS Numeric(20, 2)), 2, 34, CAST(N'2022-11-07T00:00:00.000' AS DateTime), CAST(N'2022-04-15T00:00:00.000' AS DateTime))
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000038 AS Numeric(22, 0)), CAST(4569.00 AS Numeric(20, 2)), 3, 9, CAST(N'2012-10-10T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000039 AS Numeric(22, 0)), CAST(650.00 AS Numeric(20, 2)), 3, 34, CAST(N'2022-11-04T00:00:00.000' AS DateTime), CAST(N'2022-11-05T19:06:49.893' AS DateTime))
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000040 AS Numeric(22, 0)), CAST(6084.00 AS Numeric(20, 2)), 4, 42, CAST(N'2022-11-07T20:10:22.363' AS DateTime), CAST(N'2022-11-07T20:11:10.173' AS DateTime))
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000041 AS Numeric(22, 0)), CAST(50000.00 AS Numeric(20, 2)), 2, 39, CAST(N'2022-11-06T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000042 AS Numeric(22, 0)), CAST(25000.00 AS Numeric(20, 2)), 4, 34, CAST(N'2021-01-01T00:00:00.000' AS DateTime), CAST(N'2022-11-05T12:09:45.107' AS DateTime))
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000043 AS Numeric(22, 0)), CAST(999.00 AS Numeric(20, 2)), 1, 40, CAST(N'2022-10-25T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000044 AS Numeric(22, 0)), CAST(500.00 AS Numeric(20, 2)), 1, 31, CAST(N'2020-12-20T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000045 AS Numeric(22, 0)), CAST(46479.00 AS Numeric(20, 2)), 3, 42, CAST(N'2022-11-07T20:10:22.363' AS DateTime), CAST(N'2022-10-04T00:00:00.000' AS DateTime))
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000046 AS Numeric(22, 0)), CAST(999.00 AS Numeric(20, 2)), 4, 27, CAST(N'2012-01-01T00:00:00.000' AS DateTime), CAST(N'2022-10-01T00:00:00.000' AS DateTime))
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000047 AS Numeric(22, 0)), CAST(1500000.00 AS Numeric(20, 2)), 1, 30, CAST(N'2022-11-03T00:00:00.000' AS DateTime), CAST(N'2022-09-15T00:00:00.000' AS DateTime))
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000048 AS Numeric(22, 0)), CAST(150000.00 AS Numeric(20, 2)), 4, 41, CAST(N'2021-01-01T00:00:00.000' AS DateTime), CAST(N'2022-08-15T00:00:00.000' AS DateTime))
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000049 AS Numeric(22, 0)), CAST(980.00 AS Numeric(20, 2)), 4, 43, CAST(N'2022-11-05T00:00:00.000' AS DateTime), CAST(N'2022-07-21T00:00:00.000' AS DateTime))
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000050 AS Numeric(22, 0)), CAST(25000.00 AS Numeric(20, 2)), 3, 38, CAST(N'2022-11-05T00:00:00.000' AS DateTime), CAST(N'2022-07-15T00:00:00.000' AS DateTime))
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000051 AS Numeric(22, 0)), CAST(80.00 AS Numeric(20, 2)), 1, 25, CAST(N'2022-10-31T00:00:00.000' AS DateTime), CAST(N'2022-07-15T00:00:00.000' AS DateTime))
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000052 AS Numeric(22, 0)), CAST(883237.00 AS Numeric(20, 2)), 4, 34, CAST(N'2022-11-15T12:14:06.383' AS DateTime), NULL)
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000053 AS Numeric(22, 0)), CAST(2000.00 AS Numeric(20, 2)), 1, 29, CAST(N'2012-10-30T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000054 AS Numeric(22, 0)), CAST(10501.00 AS Numeric(20, 2)), 3, 34, CAST(N'2022-11-07T11:44:33.900' AS DateTime), CAST(N'2022-11-08T14:29:57.340' AS DateTime))
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000055 AS Numeric(22, 0)), CAST(503541.00 AS Numeric(20, 2)), 1, 34, CAST(N'2022-11-08T20:30:09.723' AS DateTime), CAST(N'2022-11-08T20:30:44.570' AS DateTime))
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000056 AS Numeric(22, 0)), CAST(5000.00 AS Numeric(20, 2)), 3, 44, CAST(N'2022-11-05T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000057 AS Numeric(22, 0)), CAST(2564.00 AS Numeric(20, 2)), 1, 45, CAST(N'2021-11-20T00:00:00.000' AS DateTime), CAST(N'2021-12-05T00:00:00.000' AS DateTime))
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000058 AS Numeric(22, 0)), CAST(100.00 AS Numeric(20, 2)), 2, 45, CAST(N'2022-01-30T00:00:00.000' AS DateTime), CAST(N'2021-12-09T00:00:00.000' AS DateTime))
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000059 AS Numeric(22, 0)), CAST(350521.00 AS Numeric(20, 2)), 3, 46, CAST(N'2022-11-09T10:52:11.770' AS DateTime), CAST(N'2022-03-01T00:00:00.000' AS DateTime))
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000060 AS Numeric(22, 0)), CAST(749479.00 AS Numeric(20, 2)), 4, 46, CAST(N'2022-11-09T10:52:11.770' AS DateTime), CAST(N'2022-04-14T00:00:00.000' AS DateTime))
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000061 AS Numeric(22, 0)), CAST(70000.00 AS Numeric(20, 2)), 2, 46, CAST(N'2022-07-24T00:00:00.000' AS DateTime), CAST(N'2022-11-09T10:52:36.427' AS DateTime))
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000062 AS Numeric(22, 0)), CAST(50000.00 AS Numeric(20, 2)), 1, 47, CAST(N'2016-05-21T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000063 AS Numeric(22, 0)), CAST(15000.00 AS Numeric(20, 2)), 2, 47, CAST(N'2020-05-21T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000064 AS Numeric(22, 0)), CAST(15000.00 AS Numeric(20, 2)), 3, 47, CAST(N'2022-05-12T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000065 AS Numeric(22, 0)), CAST(350000.00 AS Numeric(20, 2)), 4, 47, CAST(N'2022-11-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000066 AS Numeric(22, 0)), CAST(25896.00 AS Numeric(20, 2)), 1, 48, CAST(N'2022-01-01T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000067 AS Numeric(22, 0)), CAST(200.00 AS Numeric(20, 2)), 2, 48, CAST(N'2022-11-01T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000068 AS Numeric(22, 0)), CAST(80000.00 AS Numeric(20, 2)), 3, 48, CAST(N'2022-08-21T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000069 AS Numeric(22, 0)), CAST(3500000.00 AS Numeric(20, 2)), 4, 48, CAST(N'2022-03-21T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000070 AS Numeric(22, 0)), CAST(15000.00 AS Numeric(20, 2)), 1, 49, CAST(N'2022-03-03T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000071 AS Numeric(22, 0)), CAST(80.00 AS Numeric(20, 2)), 2, 49, CAST(N'2022-07-03T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000072 AS Numeric(22, 0)), CAST(3000.00 AS Numeric(20, 2)), 3, 49, CAST(N'2022-11-06T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000073 AS Numeric(22, 0)), CAST(600500.00 AS Numeric(20, 2)), 4, 49, CAST(N'2022-11-02T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000074 AS Numeric(22, 0)), CAST(2000.00 AS Numeric(20, 2)), 2, 11, CAST(N'2022-11-01T00:00:00.000' AS DateTime), CAST(N'2022-11-09T13:57:19.487' AS DateTime))
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000075 AS Numeric(22, 0)), CAST(900.00 AS Numeric(20, 2)), 1, 50, CAST(N'2021-10-25T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000076 AS Numeric(22, 0)), CAST(800.00 AS Numeric(20, 2)), 2, 51, CAST(N'2021-10-01T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000077 AS Numeric(22, 0)), CAST(17000.00 AS Numeric(20, 2)), 4, 51, CAST(N'2022-12-31T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000078 AS Numeric(22, 0)), CAST(9800.00 AS Numeric(20, 2)), 4, 52, CAST(N'2021-10-25T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000079 AS Numeric(22, 0)), CAST(3500.00 AS Numeric(20, 2)), 2, 52, CAST(N'2022-10-11T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000080 AS Numeric(22, 0)), CAST(63000.00 AS Numeric(20, 2)), 4, 34, CAST(N'2022-11-09T19:48:27.760' AS DateTime), CAST(N'2022-11-14T13:38:03.770' AS DateTime))
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000081 AS Numeric(22, 0)), CAST(425.00 AS Numeric(20, 2)), 2, 34, CAST(N'2022-11-15T12:13:46.250' AS DateTime), NULL)
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000082 AS Numeric(22, 0)), CAST(50000.00 AS Numeric(20, 2)), 1, 34, CAST(N'2021-10-01T00:00:00.000' AS DateTime), CAST(N'2022-11-09T19:49:16.727' AS DateTime))
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000083 AS Numeric(22, 0)), CAST(5000.00 AS Numeric(20, 2)), 1, 34, CAST(N'2022-02-02T00:00:00.000' AS DateTime), CAST(N'2022-11-09T19:49:25.783' AS DateTime))
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000084 AS Numeric(22, 0)), CAST(65971.00 AS Numeric(20, 2)), 1, 34, CAST(N'2022-11-15T12:14:06.383' AS DateTime), NULL)
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000085 AS Numeric(22, 0)), CAST(1000.00 AS Numeric(20, 2)), 1, 53, CAST(N'2022-01-01T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000086 AS Numeric(22, 0)), CAST(1000.00 AS Numeric(20, 2)), 1, 54, CAST(N'2022-10-21T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000087 AS Numeric(22, 0)), CAST(200.00 AS Numeric(20, 2)), 1, 55, CAST(N'2020-10-10T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000088 AS Numeric(22, 0)), CAST(5000.00 AS Numeric(20, 2)), 1, 56, CAST(N'2020-01-01T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000089 AS Numeric(22, 0)), CAST(5000.00 AS Numeric(20, 2)), 1, 57, CAST(N'2022-01-01T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000090 AS Numeric(22, 0)), CAST(500.00 AS Numeric(20, 2)), 2, 58, CAST(N'2022-11-09T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000091 AS Numeric(22, 0)), CAST(500.00 AS Numeric(20, 2)), 3, 58, CAST(N'2022-11-09T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000092 AS Numeric(22, 0)), CAST(1375.00 AS Numeric(20, 2)), 2, 34, CAST(N'2022-11-15T12:13:46.250' AS DateTime), NULL)
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000093 AS Numeric(22, 0)), CAST(500.00 AS Numeric(20, 2)), 1, 59, CAST(N'2022-11-12T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000094 AS Numeric(22, 0)), CAST(50.00 AS Numeric(20, 2)), 1, 60, CAST(N'2022-11-09T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000095 AS Numeric(22, 0)), CAST(5000.00 AS Numeric(20, 2)), 2, 61, CAST(N'2022-11-15T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Cuentas] ([cbu], [saldo], [id_tipo], [id_cliente], [ultimo_mov], [fecha_baja]) VALUES (CAST(123456789000096 AS Numeric(22, 0)), CAST(250000.00 AS Numeric(20, 2)), 1, 34, CAST(N'2021-01-01T00:00:00.000' AS DateTime), CAST(N'2022-11-15T12:13:25.100' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Estado_Civil] ON 

INSERT [dbo].[Estado_Civil] ([id_estado], [nom_estado]) VALUES (1, N'Soltero/a')
INSERT [dbo].[Estado_Civil] ([id_estado], [nom_estado]) VALUES (2, N'Casado/a')
INSERT [dbo].[Estado_Civil] ([id_estado], [nom_estado]) VALUES (3, N'Viudo/a')
INSERT [dbo].[Estado_Civil] ([id_estado], [nom_estado]) VALUES (4, N'Conviviente de hecho')
SET IDENTITY_INSERT [dbo].[Estado_Civil] OFF
GO
INSERT [dbo].[Tipo_cuentas] ([id_tipo], [nom_cuenta]) VALUES (1, N'Caja de Ahorro en Pesos')
INSERT [dbo].[Tipo_cuentas] ([id_tipo], [nom_cuenta]) VALUES (2, N'Caja de Ahorro en USD')
INSERT [dbo].[Tipo_cuentas] ([id_tipo], [nom_cuenta]) VALUES (3, N'Cuenta Corriente')
INSERT [dbo].[Tipo_cuentas] ([id_tipo], [nom_cuenta]) VALUES (4, N'CUENTA SUPER QATAR 2022')
GO
INSERT [dbo].[usuarios] ([dni], [nom_usuario], [pass]) VALUES (20532670, N'Marta', N'Cordoba+99')
INSERT [dbo].[usuarios] ([dni], [nom_usuario], [pass]) VALUES (20532671, N'Merlo', N'Cba+567890')
INSERT [dbo].[usuarios] ([dni], [nom_usuario], [pass]) VALUES (20532699, N'daniel', N'Cordoba+22')
INSERT [dbo].[usuarios] ([dni], [nom_usuario], [pass]) VALUES (34131640, N'Magic', N'Cordoba 22')
INSERT [dbo].[usuarios] ([dni], [nom_usuario], [pass]) VALUES (34131642, N'daniel12', N'Cordoba+30')
INSERT [dbo].[usuarios] ([dni], [nom_usuario], [pass]) VALUES (34131648, N'cwcd', N'Cba+567890')
INSERT [dbo].[usuarios] ([dni], [nom_usuario], [pass]) VALUES (38002537, N'Mak', N'Makucita+1')
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [fk_estadocivil_clientes] FOREIGN KEY([id_estado])
REFERENCES [dbo].[Estado_Civil] ([id_estado])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [fk_estadocivil_clientes]
GO
ALTER TABLE [dbo].[Cuentas]  WITH CHECK ADD  CONSTRAINT [fk_cliente_cuentas] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Clientes] ([id_cliente])
GO
ALTER TABLE [dbo].[Cuentas] CHECK CONSTRAINT [fk_cliente_cuentas]
GO
ALTER TABLE [dbo].[Cuentas]  WITH CHECK ADD  CONSTRAINT [fk_tipo_cuentas_cuentas] FOREIGN KEY([id_tipo])
REFERENCES [dbo].[Tipo_cuentas] ([id_tipo])
GO
ALTER TABLE [dbo].[Cuentas] CHECK CONSTRAINT [fk_tipo_cuentas_cuentas]
GO
/****** Object:  StoredProcedure [dbo].[pa_altaNuevoEstadoCivil]    Script Date: 15/11/2022 12:31:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[pa_altaNuevoEstadoCivil]
@AgregarEstado varchar(30)
as
begin
insert into Estado_Civil( nom_estado) values(@AgregarEstado)
end
GO
/****** Object:  StoredProcedure [dbo].[pa_Baja_Cbu]    Script Date: 15/11/2022 12:31:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  create proc [dbo].[pa_Baja_Cbu]
  @cbu numeric(22,0)
  as
  begin
  update Cuentas
  set fecha_baja= GETDATE()
  where cbu= @cbu
  end
GO
/****** Object:  StoredProcedure [dbo].[pa_Cargar_Combo]    Script Date: 15/11/2022 12:31:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[pa_Cargar_Combo]
as
begin
select * from Tipo_cuentas
end
GO
/****** Object:  StoredProcedure [dbo].[pa_Cargar_ComboEstados]    Script Date: 15/11/2022 12:31:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  create proc [dbo].[pa_Cargar_ComboEstados]
  as
  begin
  select * 
  from Estado_Civil
  end
GO
/****** Object:  StoredProcedure [dbo].[pa_Consultar_Cuentas_Por_DNI]    Script Date: 15/11/2022 12:31:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[pa_Consultar_Cuentas_Por_DNI]
@dni int
as
begin
select cl.id_cliente'Id'  ,cl.ape_cliente'Apellido', cl. nom_cliente 'Nombre',  cl.dni 'DNI', 
		tp.nom_cuenta'Tipo de cuenta', cu.cbu'CBU', cu.saldo'Saldo', cu.ultimo_mov'Ultimo movimiento' 
from Cuentas cu
join Clientes cl
on cl.id_cliente= cu.id_cliente
join Tipo_cuentas tp
on tp.id_tipo = cu.id_tipo
where dni= @dni
and cu.fecha_baja is  null
end
GO
/****** Object:  StoredProcedure [dbo].[pa_Insertar_Cliente_Maestro]    Script Date: 15/11/2022 12:31:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[pa_Insertar_Cliente_Maestro]
@apellido varchar(50),
@nombre varchar(50),
@dni numeric(10,0),
@id_cliente int ,
@id_estado int,
@mail varchar(50)
as
begin
insert into Clientes ( id_cliente,  nom_cliente , ape_cliente, dni, id_estado,mail)
values (@id_cliente, @nombre, @apellido , @dni,@id_estado, @mail)
end
GO
/****** Object:  StoredProcedure [dbo].[pa_Insertar_Cuenta_Detalle]    Script Date: 15/11/2022 12:31:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



create proc [dbo].[pa_Insertar_Cuenta_Detalle]
@cbu numeric(22,0),
@saldo numeric(20,2),
@id_tipo int,
@id_cliente int,
@ultimoMov datetime
as
begin
insert into Cuentas( cbu, saldo, id_tipo, id_cliente, ultimo_mov)
values	(@cbu, @saldo, @id_tipo, @id_cliente, @ultimoMov)

end
GO
/****** Object:  StoredProcedure [dbo].[pa_ModificacionNuevoEstadoCivil]    Script Date: 15/11/2022 12:31:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[pa_ModificacionNuevoEstadoCivil]
@idEstadoViejo int,
@nomNuevoEstado varchar(30)
as
begin
update Estado_Civil
set nom_estado= @nomNuevoEstado
where id_estado= @idEstadoViejo

end
GO
/****** Object:  StoredProcedure [dbo].[pa_Proximo_CBU]    Script Date: 15/11/2022 12:31:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[pa_Proximo_CBU]
@next numeric(22,0) output
as
begin
select  @next= max(cbu)
from Cuentas
end

begin
if (@next>=1) select('ok')
else
begin set @next = 100000000000021
end
end
GO
/****** Object:  StoredProcedure [dbo].[pa_Proximo_Cliente]    Script Date: 15/11/2022 12:31:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[pa_Proximo_Cliente]
@next int output
as
begin
select @next= max(id_cliente)
from Clientes
end

begin
if (@next>=1) select('ok') -- ver si hace falta sumar 1 directamente al resultado
else
begin set @next = 1
end
end
GO
/****** Object:  StoredProcedure [dbo].[sp_actualizar_login]    Script Date: 15/11/2022 12:31:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[sp_actualizar_login]
@dni int,
@nom_usuario varchar(30),
@pass varchar(30)
as
begin
update usuarios
set nom_usuario = @nom_usuario,
	pass = @pass
	where dni = @dni

end
GO
/****** Object:  StoredProcedure [dbo].[sp_borrar_login]    Script Date: 15/11/2022 12:31:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[sp_borrar_login]

@dni int
as
begin
delete usuarios
where dni=@dni

end
GO
/****** Object:  StoredProcedure [dbo].[sp_consultar_cliente_por_DNI]    Script Date: 15/11/2022 12:31:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  create proc [dbo].[sp_consultar_cliente_por_DNI]
 
  @dni int
   as
  begin
  select * from Clientes
  where dni= @dni
  end
GO
/****** Object:  StoredProcedure [dbo].[sp_consultar_todos_los_clientes]    Script Date: 15/11/2022 12:31:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

  create proc [dbo].[sp_consultar_todos_los_clientes]
  as
  begin
  select * from Clientes
  end
GO
/****** Object:  StoredProcedure [dbo].[sp_crear_login]    Script Date: 15/11/2022 12:31:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_crear_login]

@dni int,
@nom_usuario varchar(30),
@pass varchar(30)
as
begin
insert into usuarios( dni, nom_usuario, pass) values( @dni, @nom_usuario, @pass)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_CuentasDadasDeBaja_Con_Parametros]    Script Date: 15/11/2022 12:31:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[sp_CuentasDadasDeBaja_Con_Parametros]
@Fecha_Desde datetime,
@Fecha_Hasta datetime
as
begin
SELECT YEAR(fecha_baja) AS ANIO, DATENAME(MONTH ,fecha_baja)  AS MES, nom_cliente, ape_cliente, dni 
FROM Cuentas c 
join Clientes C2 
on c.id_cliente = C2.id_cliente 
WHERE fecha_baja between  @Fecha_Desde and @Fecha_Hasta 
order by 1, 2
end
GO
/****** Object:  StoredProcedure [dbo].[sp_ModificarEstadoCivilporDNI]    Script Date: 15/11/2022 12:31:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  create proc [dbo].[sp_ModificarEstadoCivilporDNI]
  @dni int,
  @nuevoEstadoCivil int
  as
  begin
  update Clientes
  set id_estado= @nuevoEstadoCivil
  where dni= @dni
  end
GO
/****** Object:  StoredProcedure [dbo].[sp_ModificarMailporDNI]    Script Date: 15/11/2022 12:31:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  create proc [dbo].[sp_ModificarMailporDNI]
  @dni int,
  @nuevoMail varchar(50)
  as
  begin
  update Clientes
  set mail= @nuevoMail
  where dni= @dni
  end
GO
/****** Object:  StoredProcedure [dbo].[SP_REPORTE_CLIENTES]    Script Date: 15/11/2022 12:31:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  CREATE PROCEDURE [dbo].[SP_REPORTE_CLIENTES]
AS
    select nom_cliente as nombre,ape_cliente as apellido,dni,cbu,saldo,ultimo_mov,fecha_baja,nom_cuenta as tipo_cuenta 
	from clientes 
	join Cuentas C 
	on Clientes.id_cliente = C.id_cliente 
	join Tipo_cuentas Tc 
	on C.id_tipo = Tc.id_tipo

ORDER BY nom_cliente asc
GO
/****** Object:  StoredProcedure [dbo].[SP_REPORTE_SALDOS_CUENTAS]    Script Date: 15/11/2022 12:31:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_REPORTE_SALDOS_CUENTAS]
@precio_dolar int
    as
select T.nom_cuenta, ct.saldo , 
case WHEN t.nom_cuenta='Caja de Ahorro en USD' THEN ct.saldo*@precio_dolar 
	when T.nom_cuenta != 'Caja de Ahorro en USD' THEN ct.saldo  end AS valor_pesos 
	from  Cuentas ct  
	join Tipo_cuentas T 
	on ct.id_tipo = T.id_tipo
GO
/****** Object:  StoredProcedure [dbo].[sp_transferencia_cuentas]    Script Date: 15/11/2022 12:31:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_transferencia_cuentas]
@cbu_Origen numeric (22,0),
@cbu_Destino numeric (22,0),
@importe numeric (22,0)
as
begin
update cuentas set saldo = saldo - @importe, ultimo_mov = getdate() where cbu = @cbu_Origen
update cuentas set saldo = saldo + @importe, ultimo_mov = getdate() where cbu = @cbu_Destino
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_validar_dni]    Script Date: 15/11/2022 12:31:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

  create proc [dbo].[sp_validar_dni]
  
  @dni int
  as
  begin
  select * from usuarios
  where dni= @dni
  end
GO
/****** Object:  StoredProcedure [dbo].[sp_validar_login]    Script Date: 15/11/2022 12:31:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_validar_login]
@dni int, 
@pass varchar(30)
as
begin
select nom_usuario
from usuarios
where (dni= @dni) and (pass= @pass)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_verEstadoCivilporDNI]    Script Date: 15/11/2022 12:31:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_verEstadoCivilporDNI]

@dni int

as
begin
select  nom_cliente,ape_cliente, nom_estado
from Clientes c join
Estado_Civil e
on c.id_estado= e.id_estado
where c.dni= @dni
end
GO
/****** Object:  StoredProcedure [dbo].[sp_verMailporDNI]    Script Date: 15/11/2022 12:31:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[sp_verMailporDNI]

@dni int

as
begin
select  nom_cliente,ape_cliente, dni ,mail
from Clientes 
where dni= @dni
end
GO
