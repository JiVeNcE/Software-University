USE [master]
GO
/****** Object:  Database [School]    Script Date: 5.2.2015 г. 15:48:51 ******/
CREATE DATABASE [School]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'School', FILENAME = N'D:\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\School.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'School_log', FILENAME = N'D:\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\School_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [School] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [School].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [School] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [School] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [School] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [School] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [School] SET ARITHABORT OFF 
GO
ALTER DATABASE [School] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [School] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [School] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [School] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [School] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [School] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [School] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [School] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [School] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [School] SET  DISABLE_BROKER 
GO
ALTER DATABASE [School] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [School] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [School] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [School] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [School] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [School] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [School] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [School] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [School] SET  MULTI_USER 
GO
ALTER DATABASE [School] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [School] SET DB_CHAINING OFF 
GO
ALTER DATABASE [School] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [School] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [School] SET DELAYED_DURABILITY = DISABLED 
GO
USE [School]
GO
/****** Object:  User [Pesho]    Script Date: 5.2.2015 г. 15:48:51 ******/
CREATE USER [Pesho] FOR LOGIN [Pesho] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [Pesho]
GO
ALTER ROLE [db_datareader] ADD MEMBER [Pesho]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [Pesho]
GO
/****** Object:  Table [dbo].[Classes]    Script Date: 5.2.2015 г. 15:48:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Classes](
	[Name] [nchar](20) NULL,
	[MaxStudents] [nchar](10) NULL,
	[id] [nchar](10) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Students]    Script Date: 5.2.2015 г. 15:48:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[Name] [nchar](20) NULL,
	[Age] [nchar](4) NULL,
	[PhoneNumber] [nchar](15) NULL,
	[id] [nchar](10) NULL
) ON [PRIMARY]

GO
INSERT [dbo].[Classes] ([Name], [MaxStudents], [id]) VALUES (N'C#                  ', N'50        ', NULL)
INSERT [dbo].[Classes] ([Name], [MaxStudents], [id]) VALUES (N'Java                ', N'40        ', NULL)
INSERT [dbo].[Classes] ([Name], [MaxStudents], [id]) VALUES (N'HTML                ', N'70        ', NULL)
INSERT [dbo].[Classes] ([Name], [MaxStudents], [id]) VALUES (N'JavaScript          ', N'30        ', NULL)
INSERT [dbo].[Students] ([Name], [Age], [PhoneNumber], [id]) VALUES (N'Ivan Ivanov         ', N'19  ', N'0883834583     ', NULL)
INSERT [dbo].[Students] ([Name], [Age], [PhoneNumber], [id]) VALUES (N'Pesho Peshev        ', N'21  ', N'0735644354     ', NULL)
INSERT [dbo].[Students] ([Name], [Age], [PhoneNumber], [id]) VALUES (N'Georgi Stoqnov      ', N'25  ', N'0749749635     ', NULL)
INSERT [dbo].[Students] ([Name], [Age], [PhoneNumber], [id]) VALUES (N'Emil Petrov         ', N'34  ', N'0784587789     ', NULL)
USE [master]
GO
ALTER DATABASE [School] SET  READ_WRITE 
GO
