USE [master]
GO

/****** Object:  Database [EventAndStatsLog]    Script Date: 10/27/2012 21:34:06 ******/
CREATE DATABASE [EventAndStatsLog] ON  PRIMARY 
( NAME = N'EventAndStatsLog', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\EventAndStatsLog.mdf' , SIZE = 6144KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'EventAndStatsLog_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\EventAndStatsLog_log.ldf' , SIZE = 11200KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [EventAndStatsLog] SET COMPATIBILITY_LEVEL = 100
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EventAndStatsLog].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [EventAndStatsLog] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [EventAndStatsLog] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [EventAndStatsLog] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [EventAndStatsLog] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [EventAndStatsLog] SET ARITHABORT OFF 
GO

ALTER DATABASE [EventAndStatsLog] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [EventAndStatsLog] SET AUTO_CREATE_STATISTICS ON 
GO

ALTER DATABASE [EventAndStatsLog] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [EventAndStatsLog] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [EventAndStatsLog] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [EventAndStatsLog] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [EventAndStatsLog] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [EventAndStatsLog] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [EventAndStatsLog] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [EventAndStatsLog] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [EventAndStatsLog] SET  DISABLE_BROKER 
GO

ALTER DATABASE [EventAndStatsLog] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [EventAndStatsLog] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [EventAndStatsLog] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [EventAndStatsLog] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [EventAndStatsLog] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [EventAndStatsLog] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [EventAndStatsLog] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [EventAndStatsLog] SET  READ_WRITE 
GO

ALTER DATABASE [EventAndStatsLog] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [EventAndStatsLog] SET  MULTI_USER 
GO

ALTER DATABASE [EventAndStatsLog] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [EventAndStatsLog] SET DB_CHAINING OFF 
GO

USE [EventAndStatsLog]
GO

/****** Object:  Table [dbo].[LogTable]    Script Date: 10/27/2012 21:34:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[LogTable](
	[datetime] [datetime] NULL,
	[type] [nvarchar](50) NULL,
	[computer] [nchar](10) NULL,
	[application] [nchar](50) NULL,
	[username] [nchar](10) NULL,
	[description] [nvarchar](max) NULL,
	[object] [nchar](256) NULL,
	[lineNum] [int] NULL,
	[stackTrace] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

