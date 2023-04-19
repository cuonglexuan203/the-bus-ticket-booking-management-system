USE [master]
GO

/****** Object:  Database [BusManagement]    Script Date: 4/19/2023 12:49:15 PM ******/
CREATE DATABASE [BusManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BusManagement', FILENAME = N'D:\Applications\MSSQL16.MSSQLSERVER\MSSQL\DATA\BusManagement.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BusManagement_log', FILENAME = N'D:\Applications\MSSQL16.MSSQLSERVER\MSSQL\DATA\BusManagement_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BusManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [BusManagement] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [BusManagement] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [BusManagement] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [BusManagement] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [BusManagement] SET ARITHABORT OFF 
GO

ALTER DATABASE [BusManagement] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [BusManagement] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [BusManagement] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [BusManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [BusManagement] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [BusManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [BusManagement] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [BusManagement] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [BusManagement] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [BusManagement] SET  ENABLE_BROKER 
GO

ALTER DATABASE [BusManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [BusManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [BusManagement] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [BusManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [BusManagement] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [BusManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [BusManagement] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [BusManagement] SET RECOVERY FULL 
GO

ALTER DATABASE [BusManagement] SET  MULTI_USER 
GO

ALTER DATABASE [BusManagement] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [BusManagement] SET DB_CHAINING OFF 
GO

ALTER DATABASE [BusManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [BusManagement] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [BusManagement] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [BusManagement] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [BusManagement] SET QUERY_STORE = ON
GO

ALTER DATABASE [BusManagement] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO

ALTER DATABASE [BusManagement] SET  READ_WRITE 
GO


