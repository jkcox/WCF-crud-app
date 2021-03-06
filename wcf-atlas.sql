USE [master]
GO
/****** Object:  Database [Customer]    Script Date: 2/16/2018 5:43:53 AM ******/
CREATE DATABASE [Customer]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Customer', FILENAME = N'D:\MS-SQL-Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Customer.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Customer_log', FILENAME = N'D:\MS-SQL-Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Customer_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Customer] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Customer].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Customer] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Customer] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Customer] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Customer] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Customer] SET ARITHABORT OFF 
GO
ALTER DATABASE [Customer] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Customer] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Customer] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Customer] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Customer] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Customer] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Customer] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Customer] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Customer] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Customer] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Customer] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Customer] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Customer] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Customer] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Customer] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Customer] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Customer] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Customer] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Customer] SET  MULTI_USER 
GO
ALTER DATABASE [Customer] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Customer] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Customer] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Customer] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Customer] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Customer]
GO
/****** Object:  Table [dbo].[data]    Script Date: 2/16/2018 5:43:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[data](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [nvarchar](50) NOT NULL,
	[last_name] [nvarchar](50) NOT NULL,
	[email] [nvarchar](150) NOT NULL,
	[address_1] [nvarchar](150) NULL,
	[address_2] [nvarchar](150) NULL,
	[city] [nvarchar](100) NULL,
	[state] [nvarchar](50) NULL,
	[zip] [nvarchar](10) NULL,
	[country] [nvarchar](150) NULL,
 CONSTRAINT [PK_data] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[usp_dataInsert]    Script Date: 2/16/2018 5:43:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_dataInsert] 
    @first_name nvarchar(50),
    @last_name nvarchar(50),
    @email nvarchar(150),
    @address_1 nvarchar(150) = NULL,
    @address_2 nvarchar(150) = NULL,
    @city nvarchar(100) = NULL,
    @state nvarchar(50) = NULL,
    @zip nvarchar(10) = NULL,
    @country nvarchar(150) = NULL
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[data] ([first_name], [last_name], [email], [address_1], [address_2], [city], [state], [zip], [country])
	SELECT @first_name, @last_name, @email, @address_1, @address_2, @city, @state, @zip, @country
	
	
	SELECT [id], [first_name], [last_name], [email], [address_1], [address_2], [city], [state], [zip], [country]
	FROM   [dbo].[data]
	WHERE  [id] = SCOPE_IDENTITY()
	
               
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_dataSelect]    Script Date: 2/16/2018 5:43:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_dataSelect] 
    
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT *
	FROM   [dbo].[data] 


	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_dataUpdate]    Script Date: 2/16/2018 5:43:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_dataUpdate] 
    @id int,
    @first_name nvarchar(50),
    @last_name nvarchar(50),
    @email nvarchar(150),
    @address_1 nvarchar(150) = NULL,
    @address_2 nvarchar(150) = NULL,
    @city nvarchar(100) = NULL,
    @state nvarchar(50) = NULL,
    @zip nvarchar(10) = NULL,
    @country nvarchar(150) = NULL
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[data]
	SET    [first_name] = @first_name, [last_name] = @last_name, [email] = @email, [address_1] = @address_1, [address_2] = @address_2, [city] = @city, [state] = @state, [zip] = @zip, [country] = @country
	WHERE  [id] = @id
	
	SELECT [id], [first_name], [last_name], [email], [address_1], [address_2], [city], [state], [zip], [country]
	FROM   [dbo].[data]
	WHERE  [id] = @id	

	COMMIT
GO
USE [master]
GO
ALTER DATABASE [Customer] SET  READ_WRITE 
GO
