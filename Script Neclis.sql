USE [NecliDB]
GO
/****** Object:  Table [dbo].[Cuenta]    Script Date: 30/03/2025 11:16:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cuenta](
	[Id] [int] NOT NULL,
	[Contrasena] [varchar](20) NOT NULL,
	[Nombres] [varchar](30) NOT NULL,
	[Apellidos] [varchar](30) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Telefono] [varchar](12) NOT NULL,
	[Saldo] [float] NOT NULL,
	[FechaCreacion] [date] NOT NULL,
 CONSTRAINT [PK_Cuenta] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transaccion]    Script Date: 30/03/2025 11:16:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transaccion](
	[Numero] [nvarchar](50) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[NumeroOrigen] [nvarchar](20) NOT NULL,
	[NumeroDestino] [nvarchar](20) NOT NULL,
	[Monto] [decimal](18, 2) NOT NULL,
	[Tipo] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Cuenta] ([Id], [Contrasena], [Nombres], [Apellidos], [Email], [Telefono], [Saldo], [FechaCreacion]) VALUES (1, N'1234', N'Humberto', N'Ramos', N'humberto@gmail.com', N'3135748358', 100000, CAST(N'2025-03-30' AS Date))
INSERT [dbo].[Cuenta] ([Id], [Contrasena], [Nombres], [Apellidos], [Email], [Telefono], [Saldo], [FechaCreacion]) VALUES (2, N'Clave5678', N'Maria', N'Lopez', N'maria.lopez@email.com', N'0987654321', 500000, CAST(N'2025-03-26' AS Date))
INSERT [dbo].[Cuenta] ([Id], [Contrasena], [Nombres], [Apellidos], [Email], [Telefono], [Saldo], [FechaCreacion]) VALUES (3, N'Segura2025', N'Carlos', N'Gomez', N'carlos.gomez@email.com', N'1122334455', 20000, CAST(N'2025-03-26' AS Date))
INSERT [dbo].[Cuenta] ([Id], [Contrasena], [Nombres], [Apellidos], [Email], [Telefono], [Saldo], [FechaCreacion]) VALUES (4, N'Pass4321', N'Ana', N'Martinez', N'ana.martinez@email.com', N'5566778899', 1500000, CAST(N'2025-03-26' AS Date))
INSERT [dbo].[Cuenta] ([Id], [Contrasena], [Nombres], [Apellidos], [Email], [Telefono], [Saldo], [FechaCreacion]) VALUES (5, N'Acceso2025', N'Pedro', N'Ramirez', N'pedro.ramirez@email.com', N'6677889900', 5000000, CAST(N'2025-03-26' AS Date))
INSERT [dbo].[Cuenta] ([Id], [Contrasena], [Nombres], [Apellidos], [Email], [Telefono], [Saldo], [FechaCreacion]) VALUES (6, N'Entry9999', N'Lucia', N'Fernandez', N'lucia.fernandez@email.com', N'1231231234', 2000, CAST(N'2025-03-26' AS Date))
INSERT [dbo].[Cuenta] ([Id], [Contrasena], [Nombres], [Apellidos], [Email], [Telefono], [Saldo], [FechaCreacion]) VALUES (7, N'P@ssw0rd!', N'Diego', N'Hernandez', N'diego.hernandez@email.com', N'9879879876', 450000, CAST(N'2025-03-26' AS Date))
INSERT [dbo].[Cuenta] ([Id], [Contrasena], [Nombres], [Apellidos], [Email], [Telefono], [Saldo], [FechaCreacion]) VALUES (8, N'Login0001', N'Laura', N'Torres', N'laura.torres@email.com', N'7418529630', 28300, CAST(N'2025-03-26' AS Date))
INSERT [dbo].[Cuenta] ([Id], [Contrasena], [Nombres], [Apellidos], [Email], [Telefono], [Saldo], [FechaCreacion]) VALUES (9, N'Secure#2025', N'Andres', N'Mendoza', N'andres.mendoza@email.com', N'8529637410', 126000, CAST(N'2025-03-26' AS Date))
INSERT [dbo].[Cuenta] ([Id], [Contrasena], [Nombres], [Apellidos], [Email], [Telefono], [Saldo], [FechaCreacion]) VALUES (10, N'ABC123XYZ', N'Sofia', N'Gutierrez', N'sofia.gutierrez@email.com', N'3692581470', 43000, CAST(N'2025-03-26' AS Date))
INSERT [dbo].[Cuenta] ([Id], [Contrasena], [Nombres], [Apellidos], [Email], [Telefono], [Saldo], [FechaCreacion]) VALUES (11, N'Pass0001', N'Ricardo', N'Jimenez', N'ricardo.jimenez@email.com', N'1593572468', 83000, CAST(N'2025-03-26' AS Date))
INSERT [dbo].[Cuenta] ([Id], [Contrasena], [Nombres], [Apellidos], [Email], [Telefono], [Saldo], [FechaCreacion]) VALUES (12, N'Access2025', N'Elena', N'Castro', N'elena.castro@email.com', N'7539518524', 1000, CAST(N'2025-03-26' AS Date))
INSERT [dbo].[Cuenta] ([Id], [Contrasena], [Nombres], [Apellidos], [Email], [Telefono], [Saldo], [FechaCreacion]) VALUES (13, N'LoginPass', N'Roberto', N'Alvarez', N'roberto.alvarez@email.com', N'3216549870', 234000, CAST(N'2025-03-26' AS Date))
INSERT [dbo].[Cuenta] ([Id], [Contrasena], [Nombres], [Apellidos], [Email], [Telefono], [Saldo], [FechaCreacion]) VALUES (14, N'Token2025', N'Gabriela', N'Morales', N'gabriela.morales@email.com', N'6547893210', 16000, CAST(N'2025-03-26' AS Date))
INSERT [dbo].[Cuenta] ([Id], [Contrasena], [Nombres], [Apellidos], [Email], [Telefono], [Saldo], [FechaCreacion]) VALUES (15, N'Qwerty2025', N'Fernando', N'Ortiz', N'fernando.ortiz@email.com', N'7418529632', 1200, CAST(N'2025-03-26' AS Date))
INSERT [dbo].[Cuenta] ([Id], [Contrasena], [Nombres], [Apellidos], [Email], [Telefono], [Saldo], [FechaCreacion]) VALUES (16, N'SecureAcc', N'Valeria', N'Dominguez', N'valeria.dominguez@email.com', N'9876543210', 90075, CAST(N'2025-03-26' AS Date))
INSERT [dbo].[Cuenta] ([Id], [Contrasena], [Nombres], [Apellidos], [Email], [Telefono], [Saldo], [FechaCreacion]) VALUES (17, N'Key2025!', N'Oscar', N'Ruiz', N'oscar.ruiz@email.com', N'3217896540', 4806, CAST(N'2025-03-26' AS Date))
INSERT [dbo].[Cuenta] ([Id], [Contrasena], [Nombres], [Apellidos], [Email], [Telefono], [Saldo], [FechaCreacion]) VALUES (18, N'PassAcc20', N'Isabel', N'Vega', N'isabel.vega@email.com', N'9632587410', 67040, CAST(N'2025-03-26' AS Date))
INSERT [dbo].[Cuenta] ([Id], [Contrasena], [Nombres], [Apellidos], [Email], [Telefono], [Saldo], [FechaCreacion]) VALUES (19, N'EntryPass', N'Luis', N'Silva', N'luis.silva@email.com', N'8521479630', 55030, CAST(N'2025-03-26' AS Date))
INSERT [dbo].[Cuenta] ([Id], [Contrasena], [Nombres], [Apellidos], [Email], [Telefono], [Saldo], [FechaCreacion]) VALUES (20, N'P@ssword20', N'Paula', N'Navarro', N'paula.navarro@email.com', N'4567891230', 134580, CAST(N'2025-03-26' AS Date))
GO
INSERT [dbo].[Transaccion] ([Numero], [Fecha], [NumeroOrigen], [NumeroDestino], [Monto], [Tipo]) VALUES (N'1001', CAST(N'2025-03-30T22:44:29.053' AS DateTime), N'1234567890', N'1234567891', CAST(10000.00 AS Decimal(18, 2)), N'salida')
INSERT [dbo].[Transaccion] ([Numero], [Fecha], [NumeroOrigen], [NumeroDestino], [Monto], [Tipo]) VALUES (N'1002', CAST(N'2025-03-30T22:44:29.053' AS DateTime), N'1234567891', N'1234567892', CAST(15000.00 AS Decimal(18, 2)), N'salida')
INSERT [dbo].[Transaccion] ([Numero], [Fecha], [NumeroOrigen], [NumeroDestino], [Monto], [Tipo]) VALUES (N'1003', CAST(N'2025-03-30T22:44:29.053' AS DateTime), N'1234567892', N'1234567893', CAST(30000.00 AS Decimal(18, 2)), N'salida')
INSERT [dbo].[Transaccion] ([Numero], [Fecha], [NumeroOrigen], [NumeroDestino], [Monto], [Tipo]) VALUES (N'1004', CAST(N'2025-03-30T22:44:29.053' AS DateTime), N'1234567893', N'1234567894', CAST(80000.00 AS Decimal(18, 2)), N'salida')
INSERT [dbo].[Transaccion] ([Numero], [Fecha], [NumeroOrigen], [NumeroDestino], [Monto], [Tipo]) VALUES (N'1005', CAST(N'2025-03-30T22:44:29.053' AS DateTime), N'1234567894', N'1234567895', CAST(120000.00 AS Decimal(18, 2)), N'salida')
INSERT [dbo].[Transaccion] ([Numero], [Fecha], [NumeroOrigen], [NumeroDestino], [Monto], [Tipo]) VALUES (N'1006', CAST(N'2025-03-30T22:44:29.053' AS DateTime), N'1234567895', N'1234567896', CAST(500000.00 AS Decimal(18, 2)), N'salida')
INSERT [dbo].[Transaccion] ([Numero], [Fecha], [NumeroOrigen], [NumeroDestino], [Monto], [Tipo]) VALUES (N'1007', CAST(N'2025-03-30T22:44:29.053' AS DateTime), N'1234567896', N'1234567897', CAST(250000.00 AS Decimal(18, 2)), N'salida')
INSERT [dbo].[Transaccion] ([Numero], [Fecha], [NumeroOrigen], [NumeroDestino], [Monto], [Tipo]) VALUES (N'1008', CAST(N'2025-03-30T22:44:29.053' AS DateTime), N'1234567897', N'1234567898', CAST(450000.00 AS Decimal(18, 2)), N'salida')
INSERT [dbo].[Transaccion] ([Numero], [Fecha], [NumeroOrigen], [NumeroDestino], [Monto], [Tipo]) VALUES (N'1009', CAST(N'2025-03-30T22:44:29.053' AS DateTime), N'1234567898', N'1234567899', CAST(999999.00 AS Decimal(18, 2)), N'salida')
INSERT [dbo].[Transaccion] ([Numero], [Fecha], [NumeroOrigen], [NumeroDestino], [Monto], [Tipo]) VALUES (N'1010', CAST(N'2025-03-30T22:44:29.053' AS DateTime), N'1234567899', N'1234567900', CAST(1350000.00 AS Decimal(18, 2)), N'salida')
INSERT [dbo].[Transaccion] ([Numero], [Fecha], [NumeroOrigen], [NumeroDestino], [Monto], [Tipo]) VALUES (N'1011', CAST(N'2025-03-30T22:44:29.053' AS DateTime), N'1234567900', N'1234567901', CAST(2500000.00 AS Decimal(18, 2)), N'salida')
INSERT [dbo].[Transaccion] ([Numero], [Fecha], [NumeroOrigen], [NumeroDestino], [Monto], [Tipo]) VALUES (N'1012', CAST(N'2025-03-30T22:44:29.053' AS DateTime), N'1234567901', N'1234567902', CAST(300000.00 AS Decimal(18, 2)), N'salida')
INSERT [dbo].[Transaccion] ([Numero], [Fecha], [NumeroOrigen], [NumeroDestino], [Monto], [Tipo]) VALUES (N'1013', CAST(N'2025-03-30T22:44:29.053' AS DateTime), N'1234567902', N'1234567903', CAST(4000000.00 AS Decimal(18, 2)), N'salida')
INSERT [dbo].[Transaccion] ([Numero], [Fecha], [NumeroOrigen], [NumeroDestino], [Monto], [Tipo]) VALUES (N'1014', CAST(N'2025-03-30T22:44:29.053' AS DateTime), N'1234567903', N'1234567904', CAST(5000000.00 AS Decimal(18, 2)), N'salida')
INSERT [dbo].[Transaccion] ([Numero], [Fecha], [NumeroOrigen], [NumeroDestino], [Monto], [Tipo]) VALUES (N'1015', CAST(N'2025-03-30T22:44:29.053' AS DateTime), N'1234567904', N'1234567905', CAST(4999999.00 AS Decimal(18, 2)), N'salida')
INSERT [dbo].[Transaccion] ([Numero], [Fecha], [NumeroOrigen], [NumeroDestino], [Monto], [Tipo]) VALUES (N'1016', CAST(N'2025-03-30T22:44:29.053' AS DateTime), N'1234567905', N'1234567906', CAST(123456.00 AS Decimal(18, 2)), N'salida')
INSERT [dbo].[Transaccion] ([Numero], [Fecha], [NumeroOrigen], [NumeroDestino], [Monto], [Tipo]) VALUES (N'1017', CAST(N'2025-03-30T22:44:29.053' AS DateTime), N'1234567906', N'1234567907', CAST(175000.00 AS Decimal(18, 2)), N'salida')
INSERT [dbo].[Transaccion] ([Numero], [Fecha], [NumeroOrigen], [NumeroDestino], [Monto], [Tipo]) VALUES (N'1018', CAST(N'2025-03-30T22:44:29.053' AS DateTime), N'1234567907', N'1234567908', CAST(110000.00 AS Decimal(18, 2)), N'salida')
INSERT [dbo].[Transaccion] ([Numero], [Fecha], [NumeroOrigen], [NumeroDestino], [Monto], [Tipo]) VALUES (N'1019', CAST(N'2025-03-30T22:44:29.053' AS DateTime), N'1234567908', N'1234567909', CAST(2222222.00 AS Decimal(18, 2)), N'salida')
INSERT [dbo].[Transaccion] ([Numero], [Fecha], [NumeroOrigen], [NumeroDestino], [Monto], [Tipo]) VALUES (N'1020', CAST(N'2025-03-30T22:44:29.053' AS DateTime), N'1234567909', N'1234567910', CAST(1750000.00 AS Decimal(18, 2)), N'salida')
INSERT [dbo].[Transaccion] ([Numero], [Fecha], [NumeroOrigen], [NumeroDestino], [Monto], [Tipo]) VALUES (N'1021', CAST(N'2025-03-30T22:44:29.053' AS DateTime), N'1234567910', N'1234567911', CAST(145000.00 AS Decimal(18, 2)), N'salida')
INSERT [dbo].[Transaccion] ([Numero], [Fecha], [NumeroOrigen], [NumeroDestino], [Monto], [Tipo]) VALUES (N'1022', CAST(N'2025-03-30T22:44:29.053' AS DateTime), N'1234567911', N'1234567912', CAST(990000.00 AS Decimal(18, 2)), N'salida')
INSERT [dbo].[Transaccion] ([Numero], [Fecha], [NumeroOrigen], [NumeroDestino], [Monto], [Tipo]) VALUES (N'1023', CAST(N'2025-03-30T22:44:29.053' AS DateTime), N'1234567912', N'1234567913', CAST(3400000.00 AS Decimal(18, 2)), N'salida')
INSERT [dbo].[Transaccion] ([Numero], [Fecha], [NumeroOrigen], [NumeroDestino], [Monto], [Tipo]) VALUES (N'1024', CAST(N'2025-03-30T22:44:29.053' AS DateTime), N'1234567913', N'1234567914', CAST(240000.00 AS Decimal(18, 2)), N'salida')
INSERT [dbo].[Transaccion] ([Numero], [Fecha], [NumeroOrigen], [NumeroDestino], [Monto], [Tipo]) VALUES (N'1025', CAST(N'2025-03-30T22:44:29.053' AS DateTime), N'1234567914', N'1234567890', CAST(360000.00 AS Decimal(18, 2)), N'salida')
GO
