USE [master]
GO
/****** Object:  Database [movie_C]    Script Date: 1/06/2021 5:21:22 PM ******/
CREATE DATABASE [movie_C]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'movie_C_Data', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\movie_C.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'movie_C_Log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\movie_C.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [movie_C] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [movie_C].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [movie_C] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [movie_C] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [movie_C] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [movie_C] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [movie_C] SET ARITHABORT OFF 
GO
ALTER DATABASE [movie_C] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [movie_C] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [movie_C] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [movie_C] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [movie_C] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [movie_C] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [movie_C] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [movie_C] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [movie_C] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [movie_C] SET  DISABLE_BROKER 
GO
ALTER DATABASE [movie_C] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [movie_C] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [movie_C] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [movie_C] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [movie_C] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [movie_C] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [movie_C] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [movie_C] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [movie_C] SET  MULTI_USER 
GO
ALTER DATABASE [movie_C] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [movie_C] SET DB_CHAINING OFF 
GO
ALTER DATABASE [movie_C] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [movie_C] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [movie_C] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [movie_C] SET QUERY_STORE = OFF
GO
USE [movie_C]
GO
/****** Object:  Table [dbo].[bookingData]    Script Date: 1/06/2021 5:21:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bookingData](
	[bookID] [int] IDENTITY(1,1) NOT NULL,
	[movieID] [varchar](50) NULL,
	[clientID] [varchar](50) NULL,
	[bookingDate] [varchar](50) NULL,
	[returnDate] [varchar](50) NULL,
 CONSTRAINT [PK_bookingData] PRIMARY KEY CLUSTERED 
(
	[bookID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClientData]    Script Date: 1/06/2021 5:21:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClientData](
	[clientID] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[mobile] [varchar](50) NULL,
	[address] [varchar](50) NULL,
 CONSTRAINT [PK_ClientData] PRIMARY KEY CLUSTERED 
(
	[clientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MovieData]    Script Date: 1/06/2021 5:21:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MovieData](
	[movieID] [int] IDENTITY(1,1) NOT NULL,
	[title] [varchar](50) NULL,
	[ratting] [varchar](50) NULL,
	[year] [varchar](50) NULL,
	[copies] [int] NULL,
	[cost] [int] NULL,
	[plot] [varchar](50) NULL,
	[genre] [varchar](50) NULL,
 CONSTRAINT [PK_MovieData] PRIMARY KEY CLUSTERED 
(
	[movieID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[bookingData] ON 

INSERT [dbo].[bookingData] ([bookID], [movieID], [clientID], [bookingDate], [returnDate]) VALUES (1, N'1', N'1', N'6/1/2021', N'6/1/2021')
INSERT [dbo].[bookingData] ([bookID], [movieID], [clientID], [bookingDate], [returnDate]) VALUES (2, N'1', N'1', N'6/01/2021', N'1/06/2021')
SET IDENTITY_INSERT [dbo].[bookingData] OFF
SET IDENTITY_INSERT [dbo].[ClientData] ON 

INSERT [dbo].[ClientData] ([clientID], [name], [mobile], [address]) VALUES (1, N'rakesh Kumar', N'7897897845', N'NZ')
INSERT [dbo].[ClientData] ([clientID], [name], [mobile], [address]) VALUES (3, N'John Singh', N'987582569', N'Papatoe')
SET IDENTITY_INSERT [dbo].[ClientData] OFF
SET IDENTITY_INSERT [dbo].[MovieData] ON 

INSERT [dbo].[MovieData] ([movieID], [title], [ratting], [year], [copies], [cost], [plot], [genre]) VALUES (1, N'Rowdy', N'5.6', N'2018', 3, 5, N'Krishna', N'Goodies')
SET IDENTITY_INSERT [dbo].[MovieData] OFF
USE [master]
GO
ALTER DATABASE [movie_C] SET  READ_WRITE 
GO
