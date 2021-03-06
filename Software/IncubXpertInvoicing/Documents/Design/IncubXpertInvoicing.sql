USE [master]
GO
/****** Object:  Database [IncubXpertInvoicing]    Script Date: 10/4/2017 11:53:16 PM ******/
CREATE DATABASE [IncubXpertInvoicing]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'IncubXpertInvoicing', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\IncubXpertInvoicing.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'IncubXpertInvoicing_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\IncubXpertInvoicing_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [IncubXpertInvoicing] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [IncubXpertInvoicing].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [IncubXpertInvoicing] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [IncubXpertInvoicing] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [IncubXpertInvoicing] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [IncubXpertInvoicing] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [IncubXpertInvoicing] SET ARITHABORT OFF 
GO
ALTER DATABASE [IncubXpertInvoicing] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [IncubXpertInvoicing] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [IncubXpertInvoicing] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [IncubXpertInvoicing] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [IncubXpertInvoicing] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [IncubXpertInvoicing] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [IncubXpertInvoicing] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [IncubXpertInvoicing] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [IncubXpertInvoicing] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [IncubXpertInvoicing] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [IncubXpertInvoicing] SET  DISABLE_BROKER 
GO
ALTER DATABASE [IncubXpertInvoicing] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [IncubXpertInvoicing] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [IncubXpertInvoicing] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [IncubXpertInvoicing] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [IncubXpertInvoicing] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [IncubXpertInvoicing] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [IncubXpertInvoicing] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [IncubXpertInvoicing] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [IncubXpertInvoicing] SET  MULTI_USER 
GO
ALTER DATABASE [IncubXpertInvoicing] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [IncubXpertInvoicing] SET DB_CHAINING OFF 
GO
ALTER DATABASE [IncubXpertInvoicing] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [IncubXpertInvoicing] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [IncubXpertInvoicing]
GO
/****** Object:  Table [dbo].[MasterCustomer]    Script Date: 10/4/2017 11:53:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MasterCustomer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[City] [nvarchar](max) NULL,
	[Pincode] [nvarchar](6) NULL,
	[ContactNo] [nvarchar](max) NULL,
	[EmailId] [nvarchar](max) NULL,
 CONSTRAINT [PK_MasterCustomer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MasterProduct]    Script Date: 10/4/2017 11:53:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MasterProduct](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](max) NULL,
	[Category] [nvarchar](max) NULL,
	[Rate] [int] NOT NULL,
	[GstRate] [int] NOT NULL,
 CONSTRAINT [PK_MasterProduct] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Order]    Script Date: 10/4/2017 11:53:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [int] NOT NULL,
	[OrderDate] [nvarchar](max) NULL,
	[ScheduledDeliveryDate] [nvarchar](max) NULL,
	[TotalOrderPrice] [int] NOT NULL,
	[TotalGst] [int] NOT NULL,
 CONSTRAINT [PK_Order1_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrderLineItem]    Script Date: 10/4/2017 11:53:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderLineItem](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [int] NOT NULL,
	[Gst] [int] NOT NULL,
	[TotalPrice] [int] NOT NULL,
 CONSTRAINT [PK_OrderLineItem] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_MasterCustomer] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[MasterCustomer] ([Id])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_MasterCustomer]
GO
ALTER TABLE [dbo].[OrderLineItem]  WITH CHECK ADD  CONSTRAINT [FK_OrderLineItem_MasterProduct] FOREIGN KEY([ProductId])
REFERENCES [dbo].[MasterProduct] ([Id])
GO
ALTER TABLE [dbo].[OrderLineItem] CHECK CONSTRAINT [FK_OrderLineItem_MasterProduct]
GO
ALTER TABLE [dbo].[OrderLineItem]  WITH CHECK ADD  CONSTRAINT [FK_OrderLineItem_Order] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Order] ([Id])
GO
ALTER TABLE [dbo].[OrderLineItem] CHECK CONSTRAINT [FK_OrderLineItem_Order]
GO
USE [master]
GO
ALTER DATABASE [IncubXpertInvoicing] SET  READ_WRITE 
GO
