USE [master]
GO
/****** Object:  Database [OSRSdb]    Script Date: 1/07/2025 20:00:35 ******/
CREATE DATABASE [OSRSdb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'OSRSdb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\OSRSdb.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'OSRSdb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\OSRSdb_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [OSRSdb] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [OSRSdb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [OSRSdb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [OSRSdb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [OSRSdb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [OSRSdb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [OSRSdb] SET ARITHABORT OFF 
GO
ALTER DATABASE [OSRSdb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [OSRSdb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [OSRSdb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [OSRSdb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [OSRSdb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [OSRSdb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [OSRSdb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [OSRSdb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [OSRSdb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [OSRSdb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [OSRSdb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [OSRSdb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [OSRSdb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [OSRSdb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [OSRSdb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [OSRSdb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [OSRSdb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [OSRSdb] SET RECOVERY FULL 
GO
ALTER DATABASE [OSRSdb] SET  MULTI_USER 
GO
ALTER DATABASE [OSRSdb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [OSRSdb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [OSRSdb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [OSRSdb] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [OSRSdb] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'OSRSdb', N'ON'
GO
USE [OSRSdb]
GO
/****** Object:  Table [dbo].[Contacts]    Script Date: 1/07/2025 20:00:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contacts](
	[Contact_Id] [int] NOT NULL,
	[Contact_Info] [nvarchar](50) NOT NULL,
	[Shop_Id] [int] NOT NULL,
 CONSTRAINT [PK_Contacts] PRIMARY KEY CLUSTERED 
(
	[Contact_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Delivery_Options]    Script Date: 1/07/2025 20:00:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Delivery_Options](
	[Delivery_Op_Id] [int] NOT NULL,
	[Delivery_Type] [nvarchar](50) NOT NULL,
	[Shop_Id] [int] NOT NULL,
 CONSTRAINT [PK_Delivery_Options] PRIMARY KEY CLUSTERED 
(
	[Delivery_Op_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Product]    Script Date: 1/07/2025 20:00:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Product_Id] [int] NOT NULL,
	[Product_Name] [nvarchar](50) NOT NULL,
	[Price] [float] NOT NULL,
	[Product_Desc] [nvarchar](100) NULL,
	[Product_Rating] [float] NOT NULL,
	[ReviewCount] [int] NOT NULL DEFAULT ((0)),
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Product_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Product_Photos]    Script Date: 1/07/2025 20:00:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product_Photos](
	[Product_Photo_Id] [int] NOT NULL,
	[Product_Photo] [image] NOT NULL,
	[Shop_Id] [int] NOT NULL,
 CONSTRAINT [PK_Product_Photos] PRIMARY KEY CLUSTERED 
(
	[Product_Photo_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Product_Shop]    Script Date: 1/07/2025 20:00:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product_Shop](
	[Product_Id] [int] NOT NULL,
	[Product_Name] [nvarchar](50) NOT NULL,
	[Price] [float] NOT NULL,
	[Product_Desc] [nvarchar](100) NULL,
	[Product_Rating] [float] NOT NULL,
	[Shop_Id] [int] NOT NULL,
	[ReviewCount] [int] NOT NULL DEFAULT ((0)),
 CONSTRAINT [PK_Product_Shop] PRIMARY KEY CLUSTERED 
(
	[Product_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Report]    Script Date: 1/07/2025 20:00:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Report](
	[Report_Id] [int] NOT NULL,
	[Reason] [nvarchar](50) NOT NULL,
	[Report_Date] [date] NOT NULL,
	[Report_Desc] [nvarchar](100) NULL,
	[Status] [nvarchar](50) NOT NULL,
	[Review_Id] [int] NOT NULL,
	[User_Id] [int] NOT NULL,
 CONSTRAINT [PK_Report] PRIMARY KEY CLUSTERED 
(
	[Report_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Report_PlatformMod]    Script Date: 1/07/2025 20:00:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Report_PlatformMod](
	[Report_Id] [int] NOT NULL,
	[Reason] [nvarchar](50) NOT NULL,
	[Report_Date] [date] NOT NULL,
	[Report_Desc] [nvarchar](100) NULL,
	[Status] [nvarchar](50) NOT NULL,
	[PlatformMod_Id] [int] NOT NULL,
 CONSTRAINT [PK_Report_PlatformMod] PRIMARY KEY CLUSTERED 
(
	[Report_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Review]    Script Date: 1/07/2025 20:00:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Review](
	[Review_Id] [int] NOT NULL,
	[Review_Date] [date] NOT NULL,
	[Rating] [float] NOT NULL,
	[Review_Desc] [nvarchar](max) NULL,
	[Upvotes] [int] NOT NULL,
	[Downvotes] [int] NOT NULL,
	[RegularUser_Id] [int] NOT NULL,
 CONSTRAINT [PK_Review] PRIMARY KEY CLUSTERED 
(
	[Review_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Review_Photos]    Script Date: 1/07/2025 20:00:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Review_Photos](
	[Review_Photo_Id] [int] NOT NULL,
	[Photo] [image] NOT NULL,
	[Review_Id] [int] NOT NULL,
 CONSTRAINT [PK_Review_Photos] PRIMARY KEY CLUSTERED 
(
	[Review_Photo_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Review_PlatformMod]    Script Date: 1/07/2025 20:00:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Review_PlatformMod](
	[Review_Id] [int] NOT NULL,
	[Review_Date] [date] NOT NULL,
	[Rating] [float] NOT NULL,
	[PlatformMod_Id] [int] NOT NULL,
 CONSTRAINT [PK_Review_PlatformMod] PRIMARY KEY CLUSTERED 
(
	[Review_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Review_Product]    Script Date: 1/07/2025 20:00:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Review_Product](
	[Review_Id] [int] NOT NULL,
	[Product_Id] [int] NOT NULL,
	[Shop_id] [int] NULL,
 CONSTRAINT [PK_Review_Product] PRIMARY KEY CLUSTERED 
(
	[Review_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Review_Shop]    Script Date: 1/07/2025 20:00:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Review_Shop](
	[Review_Id] [int] NOT NULL,
	[Shop_Id] [int] NOT NULL,
 CONSTRAINT [PK_Review_Shop] PRIMARY KEY CLUSTERED 
(
	[Review_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Shop]    Script Date: 1/07/2025 20:00:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shop](
	[Shop_Id] [int] NOT NULL,
	[Shop_Name] [nvarchar](50) NOT NULL,
	[Category] [nvarchar](50) NOT NULL,
	[Verified_Status] [bit] NULL,
	[Premium_Status] [bit] NOT NULL,
	[Delivery_Option] [nvarchar](50) NOT NULL,
	[Service_Hour] [nvarchar](50) NOT NULL,
	[Shop_Rating] [float] NOT NULL,
	[ShopAdmin_Id] [int] NOT NULL,
	[City] [nvarchar](50) NOT NULL,
	[Area] [nvarchar](50) NOT NULL,
	[Road] [nvarchar](50) NOT NULL,
	[House_No] [nvarchar](50) NOT NULL,
	[ReviewCount] [int] NOT NULL DEFAULT ((0)),
 CONSTRAINT [PK_Shop] PRIMARY KEY CLUSTERED 
(
	[Shop_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Shop_Photos]    Script Date: 1/07/2025 20:00:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shop_Photos](
	[Shop_Photo_Id] [int] NOT NULL,
	[Photo] [image] NOT NULL,
	[Shop_Id] [int] NOT NULL,
 CONSTRAINT [PK_Shop_Photos] PRIMARY KEY CLUSTERED 
(
	[Shop_Photo_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Subscription]    Script Date: 1/07/2025 20:00:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subscription](
	[Subscription_Id] [int] NOT NULL,
	[Payment_Status] [nchar](10) NOT NULL,
	[Sub_Plan] [nchar](10) NOT NULL,
	[Sub_Start_Date] [date] NOT NULL,
	[Sub_End_Date] [date] NOT NULL,
	[Shop_Id] [int] NOT NULL,
 CONSTRAINT [PK_Subscription] PRIMARY KEY CLUSTERED 
(
	[Subscription_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User]    Script Date: 1/07/2025 20:00:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[User_Id] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Photo] [image] NULL,
	[Type] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[User_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[Contacts] ([Contact_Id], [Contact_Info], [Shop_Id]) VALUES (1, N'01711234567', 1)
INSERT [dbo].[Contacts] ([Contact_Id], [Contact_Info], [Shop_Id]) VALUES (2, N'gadgetworld@mail.com', 1)
INSERT [dbo].[Contacts] ([Contact_Id], [Contact_Info], [Shop_Id]) VALUES (3, N'01811234567', 2)
INSERT [dbo].[Contacts] ([Contact_Id], [Contact_Info], [Shop_Id]) VALUES (4, N'fashionhub@mail.com', 2)
INSERT [dbo].[Contacts] ([Contact_Id], [Contact_Info], [Shop_Id]) VALUES (5, N'01911234567', 3)
INSERT [dbo].[Contacts] ([Contact_Id], [Contact_Info], [Shop_Id]) VALUES (6, N'bookparadise@mail.com', 3)
INSERT [dbo].[Delivery_Options] ([Delivery_Op_Id], [Delivery_Type], [Shop_Id]) VALUES (1, N'Express Delivery (1-2 days)', 1)
INSERT [dbo].[Delivery_Options] ([Delivery_Op_Id], [Delivery_Type], [Shop_Id]) VALUES (2, N'Standard Delivery (3-5 days)', 1)
INSERT [dbo].[Delivery_Options] ([Delivery_Op_Id], [Delivery_Type], [Shop_Id]) VALUES (3, N'Standard Delivery (3-5 days)', 2)
INSERT [dbo].[Delivery_Options] ([Delivery_Op_Id], [Delivery_Type], [Shop_Id]) VALUES (4, N'Express Delivery (1-2 days)', 3)
INSERT [dbo].[Delivery_Options] ([Delivery_Op_Id], [Delivery_Type], [Shop_Id]) VALUES (5, N'Standard Delivery (3-5 days)', 3)
INSERT [dbo].[Product] ([Product_Id], [Product_Name], [Price], [Product_Desc], [Product_Rating], [ReviewCount]) VALUES (1, N'Wireless Headphones', 2999.99, N'Noise cancelling wireless headphones', 5, 1)
INSERT [dbo].[Product] ([Product_Id], [Product_Name], [Price], [Product_Desc], [Product_Rating], [ReviewCount]) VALUES (2, N'Smart Watch', 4999.99, N'Fitness tracking smart watch', 4, 1)
INSERT [dbo].[Product] ([Product_Id], [Product_Name], [Price], [Product_Desc], [Product_Rating], [ReviewCount]) VALUES (3, N'Cotton T-Shirt', 799.99, N'100% cotton premium t-shirt', 4, 1)
INSERT [dbo].[Product] ([Product_Id], [Product_Name], [Price], [Product_Desc], [Product_Rating], [ReviewCount]) VALUES (4, N'Jeans', 1499.99, N'Slim fit denim jeans', 0, 0)
INSERT [dbo].[Product] ([Product_Id], [Product_Name], [Price], [Product_Desc], [Product_Rating], [ReviewCount]) VALUES (5, N'The Alchemist', 499.99, N'Bestselling novel by Paulo Coelho', 0, 0)
INSERT [dbo].[Product] ([Product_Id], [Product_Name], [Price], [Product_Desc], [Product_Rating], [ReviewCount]) VALUES (6, N'aggs', 299.9, N'hdubd', 0, 0)
INSERT [dbo].[Product_Shop] ([Product_Id], [Product_Name], [Price], [Product_Desc], [Product_Rating], [Shop_Id], [ReviewCount]) VALUES (1, N'Wireless Headphones', 2999.99, N'Noise cancelling wireless headphones', 0, 1, 0)
INSERT [dbo].[Product_Shop] ([Product_Id], [Product_Name], [Price], [Product_Desc], [Product_Rating], [Shop_Id], [ReviewCount]) VALUES (2, N'Smart Watch', 4999.99, N'Fitness tracking smart watch', 0, 1, 0)
INSERT [dbo].[Product_Shop] ([Product_Id], [Product_Name], [Price], [Product_Desc], [Product_Rating], [Shop_Id], [ReviewCount]) VALUES (3, N'Cotton T-Shirt', 799.99, N'100% cotton premium t-shirt', 0, 2, 0)
INSERT [dbo].[Product_Shop] ([Product_Id], [Product_Name], [Price], [Product_Desc], [Product_Rating], [Shop_Id], [ReviewCount]) VALUES (4, N'Jeans', 1499.99, N'Slim fit denim jeans', 0, 2, 0)
INSERT [dbo].[Product_Shop] ([Product_Id], [Product_Name], [Price], [Product_Desc], [Product_Rating], [Shop_Id], [ReviewCount]) VALUES (5, N'Novel - The Alchemist', 499.99, N'Bestselling novel by Paulo Coelho', 0, 3, 0)
INSERT [dbo].[Product_Shop] ([Product_Id], [Product_Name], [Price], [Product_Desc], [Product_Rating], [Shop_Id], [ReviewCount]) VALUES (6, N'aggs', 299.9, N'hdubd', 0, 1, 0)
INSERT [dbo].[Report] ([Report_Id], [Reason], [Report_Date], [Report_Desc], [Status], [Review_Id], [User_Id]) VALUES (1, N'Fake Review', CAST(N'2025-01-16' AS Date), N'Review contains false allegation', N'Pending', 5, 7)
INSERT [dbo].[Report_PlatformMod] ([Report_Id], [Reason], [Report_Date], [Report_Desc], [Status], [PlatformMod_Id]) VALUES (1, N'Policy Violation', CAST(N'2025-01-20' AS Date), N'Review contains false allegation', N'Pending', 2)
INSERT [dbo].[Review] ([Review_Id], [Review_Date], [Rating], [Review_Desc], [Upvotes], [Downvotes], [RegularUser_Id]) VALUES (1, CAST(N'2025-01-15' AS Date), 5, N'Excellent product quality', 12, 1, 9)
INSERT [dbo].[Review] ([Review_Id], [Review_Date], [Rating], [Review_Desc], [Upvotes], [Downvotes], [RegularUser_Id]) VALUES (2, CAST(N'2025-02-20' AS Date), 4, N'Good product', 8, 2, 8)
INSERT [dbo].[Review] ([Review_Id], [Review_Date], [Rating], [Review_Desc], [Upvotes], [Downvotes], [RegularUser_Id]) VALUES (3, CAST(N'2025-03-10' AS Date), 3, N'Average experience, could be better', 5, 3, 8)
INSERT [dbo].[Review] ([Review_Id], [Review_Date], [Rating], [Review_Desc], [Upvotes], [Downvotes], [RegularUser_Id]) VALUES (4, CAST(N'2025-04-05' AS Date), 5, N'Amazing service and product quality!', 15, 0, 9)
INSERT [dbo].[Review] ([Review_Id], [Review_Date], [Rating], [Review_Desc], [Upvotes], [Downvotes], [RegularUser_Id]) VALUES (5, CAST(N'2025-05-12' AS Date), 2, N'Late Delivery', 2, 5, 8)
INSERT [dbo].[Review] ([Review_Id], [Review_Date], [Rating], [Review_Desc], [Upvotes], [Downvotes], [RegularUser_Id]) VALUES (6, CAST(N'2025-01-25' AS Date), 4, N'Happy with my purchase', 10, 1, 9)
INSERT [dbo].[Review] ([Review_Id], [Review_Date], [Rating], [Review_Desc], [Upvotes], [Downvotes], [RegularUser_Id]) VALUES (7, CAST(N'2025-06-30' AS Date), 4.5, N'Very good experience', 0, 0, 9)
INSERT [dbo].[Review_PlatformMod] ([Review_Id], [Review_Date], [Rating], [PlatformMod_Id]) VALUES (11, CAST(N'2025-01-10' AS Date), 4, 2)
INSERT [dbo].[Review_PlatformMod] ([Review_Id], [Review_Date], [Rating], [PlatformMod_Id]) VALUES (12, CAST(N'2025-02-15' AS Date), 5, 3)
INSERT [dbo].[Review_PlatformMod] ([Review_Id], [Review_Date], [Rating], [PlatformMod_Id]) VALUES (13, CAST(N'2025-03-20' AS Date), 3, 2)
INSERT [dbo].[Review_PlatformMod] ([Review_Id], [Review_Date], [Rating], [PlatformMod_Id]) VALUES (14, CAST(N'2025-04-25' AS Date), 4, 2)
INSERT [dbo].[Review_PlatformMod] ([Review_Id], [Review_Date], [Rating], [PlatformMod_Id]) VALUES (15, CAST(N'2025-05-30' AS Date), 2, 3)
INSERT [dbo].[Review_Product] ([Review_Id], [Product_Id], [Shop_id]) VALUES (1, 1, 1)
INSERT [dbo].[Review_Product] ([Review_Id], [Product_Id], [Shop_id]) VALUES (2, 2, 1)
INSERT [dbo].[Review_Product] ([Review_Id], [Product_Id], [Shop_id]) VALUES (6, 3, 2)
INSERT [dbo].[Review_Shop] ([Review_Id], [Shop_Id]) VALUES (3, 1)
INSERT [dbo].[Review_Shop] ([Review_Id], [Shop_Id]) VALUES (4, 2)
INSERT [dbo].[Review_Shop] ([Review_Id], [Shop_Id]) VALUES (5, 3)
INSERT [dbo].[Review_Shop] ([Review_Id], [Shop_Id]) VALUES (7, 1)
INSERT [dbo].[Shop] ([Shop_Id], [Shop_Name], [Category], [Verified_Status], [Premium_Status], [Delivery_Option], [Service_Hour], [Shop_Rating], [ShopAdmin_Id], [City], [Area], [Road], [House_No], [ReviewCount]) VALUES (1, N'Gadget World', N'Electronics', 1, 1, N'Express,Standard', N'9AM-9PM', 3, 4, N'Dhaka', N'Mirpur', N'Road 10', N'25/A', 1)
INSERT [dbo].[Shop] ([Shop_Id], [Shop_Name], [Category], [Verified_Status], [Premium_Status], [Delivery_Option], [Service_Hour], [Shop_Rating], [ShopAdmin_Id], [City], [Area], [Road], [House_No], [ReviewCount]) VALUES (2, N'Fashion Hub', N'Clothing', 1, 0, N'Standard', N'10AM-8PM', 5, 6, N'Dhaka', N'Dhanmondi', N'Road 5', N'12', 1)
INSERT [dbo].[Shop] ([Shop_Id], [Shop_Name], [Category], [Verified_Status], [Premium_Status], [Delivery_Option], [Service_Hour], [Shop_Rating], [ShopAdmin_Id], [City], [Area], [Road], [House_No], [ReviewCount]) VALUES (3, N'Book Paradise', N'Books', 0, 0, N'Express,Standard', N'11AM-7PM', 2, 7, N'Chittagong', N'Agrabad', N'Road 2', N'34', 1)
INSERT [dbo].[Shop] ([Shop_Id], [Shop_Name], [Category], [Verified_Status], [Premium_Status], [Delivery_Option], [Service_Hour], [Shop_Rating], [ShopAdmin_Id], [City], [Area], [Road], [House_No], [ReviewCount]) VALUES (5, N'The Book Owls', N'Books', 0, 1, N'Express', N'9AM-7PM', 0, 10, N'Dhaka', N'Gulshan', N'4', N'50', 0)
INSERT [dbo].[Subscription] ([Subscription_Id], [Payment_Status], [Sub_Plan], [Sub_Start_Date], [Sub_End_Date], [Shop_Id]) VALUES (1, N'Paid      ', N'Premium   ', CAST(N'2025-01-01' AS Date), CAST(N'2026-01-01' AS Date), 1)
INSERT [dbo].[Subscription] ([Subscription_Id], [Payment_Status], [Sub_Plan], [Sub_Start_Date], [Sub_End_Date], [Shop_Id]) VALUES (2, N'Paid      ', N'Basic     ', CAST(N'2025-01-15' AS Date), CAST(N'2025-07-15' AS Date), 2)
INSERT [dbo].[Subscription] ([Subscription_Id], [Payment_Status], [Sub_Plan], [Sub_Start_Date], [Sub_End_Date], [Shop_Id]) VALUES (3, N'Paid      ', N'Basic     ', CAST(N'2025-02-01' AS Date), CAST(N'2025-08-01' AS Date), 3)
INSERT [dbo].[Subscription] ([Subscription_Id], [Payment_Status], [Sub_Plan], [Sub_Start_Date], [Sub_End_Date], [Shop_Id]) VALUES (4, N'Paid      ', N'Premium   ', CAST(N'2025-06-30' AS Date), CAST(N'2025-07-01' AS Date), 5)
INSERT [dbo].[Subscription] ([Subscription_Id], [Payment_Status], [Sub_Plan], [Sub_Start_Date], [Sub_End_Date], [Shop_Id]) VALUES (5, N'Paid      ', N'Basic     ', CAST(N'2025-07-02' AS Date), CAST(N'2025-07-03' AS Date), 5)
INSERT [dbo].[User] ([User_Id], [Name], [Email], [Photo], [Type], [Password]) VALUES (1, N'Patrick', N'patrick@mail.com', NULL, N'Admin', N'1111')
INSERT [dbo].[User] ([User_Id], [Name], [Email], [Photo], [Type], [Password]) VALUES (2, N'Sadi', N's@mail.com', NULL, N'Moderator', N'2222')
INSERT [dbo].[User] ([User_Id], [Name], [Email], [Photo], [Type], [Password]) VALUES (3, N'Zidane', N'z@mail.com', NULL, N'Moderator', N'3333')
INSERT [dbo].[User] ([User_Id], [Name], [Email], [Photo], [Type], [Password]) VALUES (4, N'Abrar', N'a@mail.com', NULL, N'ShopAdmin', N'4444')
INSERT [dbo].[User] ([User_Id], [Name], [Email], [Photo], [Type], [Password]) VALUES (6, N'ABC', N'abc@mail.com', NULL, N'ShopAdmin', N'6666')
INSERT [dbo].[User] ([User_Id], [Name], [Email], [Photo], [Type], [Password]) VALUES (7, N'JKL', N'jkl@mail.com', NULL, N'Moderator', N'7777')
INSERT [dbo].[User] ([User_Id], [Name], [Email], [Photo], [Type], [Password]) VALUES (8, N'XYZ', N'xyz@mail.com', NULL, N'Regular', N'8888')
INSERT [dbo].[User] ([User_Id], [Name], [Email], [Photo], [Type], [Password]) VALUES (9, N'MNO', N'mno@mail.com', NULL, N'Regular', N'9999')
INSERT [dbo].[User] ([User_Id], [Name], [Email], [Photo], [Type], [Password]) VALUES (10, N'Latif', N'latif@mail.com', NULL, N'ShopAdmin', N'1010')
ALTER TABLE [dbo].[Shop]  WITH CHECK ADD  CONSTRAINT [FK_Shop_Shop] FOREIGN KEY([Shop_Id])
REFERENCES [dbo].[Shop] ([Shop_Id])
GO
ALTER TABLE [dbo].[Shop] CHECK CONSTRAINT [FK_Shop_Shop]
GO
USE [master]
GO
ALTER DATABASE [OSRSdb] SET  READ_WRITE 
GO
