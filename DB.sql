USE [master]
GO
/****** Object:  Database [Ass01]    Script Date: 7/1/2024 1:22:20 PM ******/
CREATE DATABASE [Ass01]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Ass01', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Ass01.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Ass01_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Ass01_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Ass01] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Ass01].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Ass01] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Ass01] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Ass01] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Ass01] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Ass01] SET ARITHABORT OFF 
GO
ALTER DATABASE [Ass01] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Ass01] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Ass01] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Ass01] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Ass01] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Ass01] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Ass01] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Ass01] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Ass01] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Ass01] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Ass01] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Ass01] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Ass01] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Ass01] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Ass01] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Ass01] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Ass01] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Ass01] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Ass01] SET  MULTI_USER 
GO
ALTER DATABASE [Ass01] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Ass01] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Ass01] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Ass01] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Ass01] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Ass01] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Ass01] SET QUERY_STORE = OFF
GO
USE [Ass01]
GO
/****** Object:  Table [dbo].[Member]    Script Date: 7/1/2024 1:22:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Member](
	[MemberId] [int] IDENTITY(1,1) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[CompanyName] [varchar](50) NOT NULL,
	[City] [varchar](50) NOT NULL,
	[Country] [varchar](50) NOT NULL,
	[Password] [varbinary](50) NOT NULL,
 CONSTRAINT [PK_Member] PRIMARY KEY CLUSTERED 
(
	[MemberId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 7/1/2024 1:22:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[MemberId] [int] NOT NULL,
	[OrderDate] [datetime] NOT NULL,
	[RequiredDate] [datetime] NULL,
	[ShippedDate] [datetime] NULL,
	[Freight] [money] NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 7/1/2024 1:22:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[OderId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Discount] [float] NOT NULL,
 CONSTRAINT [PK_OrderDetail] PRIMARY KEY CLUSTERED 
(
	[OderId] ASC,
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 7/1/2024 1:22:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryId] [int] NOT NULL,
	[ProductName] [varchar](50) NOT NULL,
	[Weight] [varchar](50) NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[UnitInStocks] [int] NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Member] ON 

INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (2, N'check', N'Flashdog', N'Jawand', N'Afghanistan', 0x663538346173)
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (3, N'Admin', N'Flipstorm', N'Oji River', N'Nigeria', 0x7246377D292E392925384E43376B)
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (5, N'Admin', N'Flipstorm', N'Oji River', N'Nigeria', 0x313233)
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (6, N'check', N'Flashdog', N'Jawand', N'Afghanistan', 0x313233)
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (7, N'Admin@fstore.com', N'Flipstorm', N'Oji River', N'Nigeria', 0x61646D696E4040)
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (8, N'check', N'Flashdog', N'Jawand', N'Afghanistan', 0x663538346173)
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (9, N'checkkkkk', N'Flashdog', N'Jawand', N'Afghanistan', 0x663538346173)
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (10, N'checkkkkk', N'Flashdog', N'Jawand', N'Afghanistan', 0x663538346173)
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (11, N'Admin', N'Flipstorm', N'Oji River', N'Nigeria', 0x313233)
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (12, N'Admin', N'Flipstorm', N'Oji River', N'Nigeria', 0x7246377D292E392925384E43376B)
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (13, N'Admin', N'Flipstorm', N'Oji River', N'Nigeria', 0x7246377D292E392925384E43376B)
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (14, N'check', N'Flashdog', N'Jawand', N'Afghanistan', 0x663538346173)
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (15, N'checkkkkk', N'Flashdog', N'Jawand', N'Afghanistan', 0x663538346173)
SET IDENTITY_INSERT [dbo].[Member] OFF
GO
SET IDENTITY_INSERT [dbo].[Order] ON 

INSERT [dbo].[Order] ([OrderID], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (1, 2, CAST(N'2019-07-19T00:00:00.000' AS DateTime), CAST(N'2013-05-28T00:00:00.000' AS DateTime), CAST(N'2004-03-26T00:00:00.000' AS DateTime), 4.2800)
INSERT [dbo].[Order] ([OrderID], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (2, 2, CAST(N'2010-06-18T00:00:00.000' AS DateTime), CAST(N'2011-09-02T00:00:00.000' AS DateTime), CAST(N'2017-12-11T00:00:00.000' AS DateTime), 3.6700)
INSERT [dbo].[Order] ([OrderID], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (3, 2, CAST(N'2005-12-21T00:00:00.000' AS DateTime), CAST(N'2009-09-21T00:00:00.000' AS DateTime), CAST(N'2012-11-16T00:00:00.000' AS DateTime), 6.8100)
INSERT [dbo].[Order] ([OrderID], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (4, 3, CAST(N'2010-03-12T00:00:00.000' AS DateTime), CAST(N'2013-10-02T00:00:00.000' AS DateTime), CAST(N'2017-05-10T00:00:00.000' AS DateTime), 9.7900)
INSERT [dbo].[Order] ([OrderID], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (5, 2, CAST(N'2011-06-17T00:00:00.000' AS DateTime), CAST(N'2000-03-28T00:00:00.000' AS DateTime), CAST(N'2008-03-12T00:00:00.000' AS DateTime), 4.7700)
INSERT [dbo].[Order] ([OrderID], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (6, 2, CAST(N'2021-03-24T00:00:00.000' AS DateTime), CAST(N'2015-05-19T00:00:00.000' AS DateTime), CAST(N'2005-05-30T00:00:00.000' AS DateTime), 3.7400)
INSERT [dbo].[Order] ([OrderID], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (7, 3, CAST(N'2008-04-16T00:00:00.000' AS DateTime), CAST(N'2017-03-30T00:00:00.000' AS DateTime), CAST(N'2003-04-11T00:00:00.000' AS DateTime), 7.6900)
INSERT [dbo].[Order] ([OrderID], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (8, 3, CAST(N'2018-09-13T00:00:00.000' AS DateTime), CAST(N'2022-04-23T00:00:00.000' AS DateTime), CAST(N'2013-12-18T00:00:00.000' AS DateTime), 7.8900)
INSERT [dbo].[Order] ([OrderID], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (9, 2, CAST(N'2021-12-05T00:00:00.000' AS DateTime), CAST(N'2005-08-09T00:00:00.000' AS DateTime), CAST(N'2015-08-02T00:00:00.000' AS DateTime), 5.6800)
INSERT [dbo].[Order] ([OrderID], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (10, 2, CAST(N'2003-01-26T00:00:00.000' AS DateTime), CAST(N'2024-12-28T00:00:00.000' AS DateTime), CAST(N'2003-06-29T00:00:00.000' AS DateTime), 8.1300)
SET IDENTITY_INSERT [dbo].[Order] OFF
GO
INSERT [dbo].[OrderDetail] ([OderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (2, 1, 9.9800, 6, 29.39)
INSERT [dbo].[OrderDetail] ([OderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (2, 3, 4.7800, 9, 15.28)
INSERT [dbo].[OrderDetail] ([OderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (3, 5, 3.4000, 5, 0.4)
INSERT [dbo].[OrderDetail] ([OderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (4, 1, 1.2000, 6, 22.28)
INSERT [dbo].[OrderDetail] ([OderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (4, 8, 6.6800, 1, 13.25)
INSERT [dbo].[OrderDetail] ([OderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (5, 8, 6.6700, 9, 5.44)
INSERT [dbo].[OrderDetail] ([OderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (7, 4, 1.9300, 6, 18.25)
INSERT [dbo].[OrderDetail] ([OderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (8, 1, 2.2300, 9, 46.27)
INSERT [dbo].[OrderDetail] ([OderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (8, 2, 5.0000, 9, 46.27)
INSERT [dbo].[OrderDetail] ([OderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (9, 4, 7.9000, 4, 38.25)
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitInStocks]) VALUES (1, 3, N'Shiro Miso', N'1kg', 189535.7200, 875482873)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitInStocks]) VALUES (2, 2, N'Wine - Beringer Founders Estate', N'5kg', 744604.8200, 798109512)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitInStocks]) VALUES (3, 2, N'Steam Pan Full Lid', N'12kg', 734495.9200, 44764562)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitInStocks]) VALUES (4, 2, N'Amaretto', N'25kg', 874084.0900, 285144322)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitInStocks]) VALUES (5, 2, N'Wine - Pinot Grigio Collavini', N'30kg', 189589.7000, 2054114961)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitInStocks]) VALUES (6, 2, N'Cookies - Oreo, 4 Pack', N'1kg', 908960.0500, 1003130680)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitInStocks]) VALUES (7, 1, N'Marzipan 50/50', N'12kg', 821343.4600, 1074498263)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitInStocks]) VALUES (8, 0, N'Pastry - Plain Baked Croissant', N'48kg', 388985.8100, 1523733426)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitInStocks]) VALUES (9, 2, N'Cheese - Montery Jack', N'1kg', 836304.8300, 1612342158)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitInStocks]) VALUES (10, 2, N'Muffin Batt - Blueberry Passion', N'25kg', 39401.2700, 2023881157)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitInStocks]) VALUES (11, 2, N'Muffin Batt - Blueberry Passion', N'25kg', 39401.2700, 2023881157)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitInStocks]) VALUES (12, 3, N'Shiro Miso', N'1kg', 189535.7200, 875482873)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitInStocks]) VALUES (13, 3, N'Shiro Miso', N'1kg', 189535.7200, 875482873)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitInStocks]) VALUES (14, 3, N'Shiro Miso', N'1kg', 189535.7200, 875482873)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitInStocks]) VALUES (15, 3, N'Shiro Misooooo', N'1kg', 189535.7200, 875482873)
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Member] FOREIGN KEY([MemberId])
REFERENCES [dbo].[Member] ([MemberId])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Member]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Order] FOREIGN KEY([OderId])
REFERENCES [dbo].[Order] ([OrderID])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Order]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Product] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([ProductId])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Product]
GO
USE [master]
GO
ALTER DATABASE [Ass01] SET  READ_WRITE 
GO
