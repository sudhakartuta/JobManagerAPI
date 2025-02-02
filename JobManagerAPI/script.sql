USE [master]
GO
/****** Object:  Database [JobManager]    Script Date: 12/17/2020 9:19:18 PM ******/
CREATE DATABASE [JobManager]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'JobManager', FILENAME = N'JobManager.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'JobManager_log', FILENAME = N'JobManager_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [JobManager] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [JobManager].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [JobManager] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [JobManager] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [JobManager] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [JobManager] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [JobManager] SET ARITHABORT OFF 
GO
ALTER DATABASE [JobManager] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [JobManager] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [JobManager] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [JobManager] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [JobManager] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [JobManager] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [JobManager] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [JobManager] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [JobManager] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [JobManager] SET  DISABLE_BROKER 
GO
ALTER DATABASE [JobManager] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [JobManager] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [JobManager] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [JobManager] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [JobManager] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [JobManager] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [JobManager] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [JobManager] SET RECOVERY FULL 
GO
ALTER DATABASE [JobManager] SET  MULTI_USER 
GO
ALTER DATABASE [JobManager] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [JobManager] SET DB_CHAINING OFF 
GO
ALTER DATABASE [JobManager] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [JobManager] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [JobManager] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [JobManager] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'JobManager', N'ON'
GO
ALTER DATABASE [JobManager] SET QUERY_STORE = OFF
GO
USE [JobManager]
GO
/****** Object:  User [sudha]    Script Date: 12/17/2020 9:19:18 PM ******/
CREATE USER [sudha] FOR LOGIN [sudha] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 12/17/2020 9:19:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bankdetails]    Script Date: 12/17/2020 9:19:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bankdetails](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BankName] [nvarchar](255) NULL,
	[AccountNo] [nvarchar](255) NULL,
	[IFSC] [nvarchar](255) NULL,
 CONSTRAINT [PK_Bankdetails] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[material_tmp]    Script Date: 12/17/2020 9:19:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[material_tmp](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[type] [nvarchar](255) NULL,
	[typeofmaterial] [nvarchar](255) NULL,
	[material] [nvarchar](255) NULL,
	[code] [nvarchar](255) NULL,
	[qty] [float] NULL,
	[unit_type] [nvarchar](255) NULL,
	[unit_price] [float] NULL,
	[total_amt] [float] NULL,
	[updatedby] [nvarchar](255) NULL,
	[L] [float] NULL,
	[W] [float] NULL,
	[smts] [float] NULL,
	[Sunit_price] [float] NULL,
 CONSTRAINT [PK_material_tmp] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Paste Errors]    Script Date: 12/17/2020 9:19:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paste Errors](
	[F1] [float] NULL,
	[F2] [nvarchar](255) NULL,
	[F3] [nvarchar](255) NULL,
	[F4] [nvarchar](255) NULL,
	[F5] [nvarchar](255) NULL,
	[F6] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_address]    Script Date: 12/17/2020 9:19:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_address](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[add1] [nvarchar](255) NULL,
	[add2] [nvarchar](255) NULL,
 CONSTRAINT [PK_tbl_address] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_bag_MSTR]    Script Date: 12/17/2020 9:19:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_bag_MSTR](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[bag] [nvarchar](255) NULL,
	[bag_code] [nvarchar](255) NULL,
	[image] [nvarchar](255) NULL,
 CONSTRAINT [PK_tbl_bag_MSTR] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_balance_payments]    Script Date: 12/17/2020 9:19:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_balance_payments](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[baldate] [datetime] NULL,
	[MRNID] [nvarchar](255) NULL,
	[suplier] [nvarchar](255) NULL,
	[totalamt] [float] NULL,
	[paid] [float] NULL,
	[bal] [float] NULL,
 CONSTRAINT [PK_tbl_balance_payments] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_BalanceSheet]    Script Date: 12/17/2020 9:19:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_BalanceSheet](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[datec] [datetime] NULL,
	[particulars] [nvarchar](255) NULL,
	[ref] [nvarchar](255) NULL,
	[d1] [float] NULL,
	[d2] [float] NULL,
	[d3] [float] NULL,
	[d4] [float] NULL,
	[d5] [float] NULL,
	[d6] [float] NULL,
	[d7] [float] NULL,
	[d8] [float] NULL,
	[d9] [float] NULL,
	[d10] [float] NULL,
	[d_total] [float] NULL,
	[c1] [float] NULL,
	[c2] [float] NULL,
	[c3] [float] NULL,
	[c4] [float] NULL,
	[c5] [float] NULL,
	[c6] [float] NULL,
	[c7] [float] NULL,
	[c8] [float] NULL,
	[c9] [float] NULL,
	[c10] [float] NULL,
	[c_total] [float] NULL,
 CONSTRAINT [PK_tbl_BalanceSheet] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_cashbook]    Script Date: 12/17/2020 9:19:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_cashbook](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[datec] [datetime] NULL,
	[d_particulars] [nvarchar](255) NULL,
	[d_details] [nvarchar](255) NULL,
	[d_ref] [nvarchar](255) NULL,
	[d_amount] [float] NULL,
	[c_particulars] [nvarchar](255) NULL,
	[c_details] [nvarchar](255) NULL,
	[c_ref] [nvarchar](255) NULL,
	[c_amount] [float] NULL,
 CONSTRAINT [PK_tbl_cashbook] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_customer]    Script Date: 12/17/2020 9:19:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_customer](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CID] [int] NULL,
	[customerID] [nvarchar](255) NOT NULL,
	[customer] [nvarchar](255) NULL,
	[contact_no] [nvarchar](255) NULL,
	[email] [nvarchar](255) NULL,
	[address] [nvarchar](255) NULL,
	[bank] [nvarchar](255) NULL,
	[bankAcNo] [nvarchar](255) NULL,
	[branch] [nvarchar](255) NULL,
	[ifsc] [nvarchar](255) NULL,
	[gstno] [nvarchar](255) NULL,
	[pan] [nvarchar](255) NULL,
	[aadhaar] [nvarchar](255) NULL,
	[place_city] [nvarchar](255) NULL,
	[BR] [nvarchar](255) NULL,
 CONSTRAINT [PK_tbl_customer] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_damages]    Script Date: 12/17/2020 9:19:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_damages](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[date] [datetime] NULL,
	[MRNID] [nvarchar](255) NULL,
	[type] [nvarchar](255) NULL,
	[materialType] [nvarchar](255) NULL,
	[material] [nvarchar](255) NULL,
	[qty] [nvarchar](255) NULL,
	[remarks] [nvarchar](255) NULL,
 CONSTRAINT [PK_tbl_damages] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_date]    Script Date: 12/17/2020 9:19:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_date](
	[Date] [datetime] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_employees]    Script Date: 12/17/2020 9:19:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_employees](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[EmpID] [int] NULL,
	[EmpName] [nvarchar](255) NULL,
	[phone] [nvarchar](255) NULL,
	[address] [nvarchar](255) NULL,
	[exist] [bit] NOT NULL,
	[DOJ] [datetime] NULL,
	[DOR] [datetime] NULL,
	[Remarks] [nvarchar](255) NULL,
	[salary] [float] NULL,
 CONSTRAINT [PK_tbl_employees] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_estimation]    Script Date: 12/17/2020 9:19:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_estimation](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Jobcardno] [int] NULL,
	[JobcardID] [nvarchar](255) NULL,
	[customerID] [nvarchar](255) NULL,
	[JobType] [nvarchar](255) NULL,
	[itemcode] [nvarchar](255) NULL,
	[item] [nvarchar](255) NULL,
	[totalitems] [float] NULL,
	[balanceitems] [float] NULL,
	[itemcost] [float] NULL,
	[materialCost] [float] NULL,
	[totalexp] [float] NULL,
	[totallabchrg] [float] NULL,
	[MRP] [float] NULL,
	[totalamtWOP] [float] NULL,
	[profit_per] [int] NULL,
	[profit] [float] NULL,
	[totalamt] [float] NULL,
	[createdon] [datetime] NULL,
	[createdby] [nvarchar](255) NULL,
	[status] [nvarchar](255) NULL,
	[closedon] [datetime] NULL,
	[closedby] [nvarchar](255) NULL,
	[westage] [float] NULL,
 CONSTRAINT [PK_tbl_estimation] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_estimation_production]    Script Date: 12/17/2020 9:19:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_estimation_production](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UID] [int] NOT NULL,
	[proddate] [datetime] NULL,
	[JobcardID] [nvarchar](255) NULL,
	[workerID] [int] NULL,
	[workername] [nvarchar](255) NULL,
	[jobtype] [nvarchar](255) NULL,
	[qty] [float] NULL,
	[dayofwork] [float] NULL,
	[cost] [float] NULL,
 CONSTRAINT [PK_tbl_estimation_production] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_estimation_workers]    Script Date: 12/17/2020 9:19:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_estimation_workers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TID] [int] NOT NULL,
	[materialID] [int] NULL,
	[JobcardID] [nvarchar](255) NULL,
	[workerID] [int] NULL,
	[workerName] [nvarchar](255) NULL,
	[type] [nvarchar](255) NULL,
	[materialType] [nvarchar](255) NULL,
	[material] [nvarchar](255) NULL,
	[qty] [float] NULL,
	[price_per_unit] [float] NULL,
	[price] [float] NULL,
 CONSTRAINT [PK_tbl_estimation_workers] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Expense_MSTR]    Script Date: 12/17/2020 9:19:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Expense_MSTR](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[transactionType] [nvarchar](255) NULL,
	[expenceType] [nvarchar](255) NULL,
	[fileds] [nvarchar](255) NULL,
 CONSTRAINT [PK_tbl_Expense_MSTR] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Expenses]    Script Date: 12/17/2020 9:19:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Expenses](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[expdate] [datetime] NULL,
	[Trantype] [nvarchar](255) NULL,
	[expense] [nvarchar](255) NULL,
	[totalamt] [float] NULL,
	[updatedon] [datetime] NULL,
	[updatedby] [nvarchar](255) NULL,
	[particulars] [nvarchar](255) NULL,
	[cheque] [nvarchar](255) NULL,
 CONSTRAINT [PK_tbl_Expenses] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_invoice]    Script Date: 12/17/2020 9:19:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_invoice](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[invoiceID] [int] NULL,
	[invoice] [nvarchar](255) NULL,
	[invoicedate] [datetime] NULL,
	[customerID] [nvarchar](255) NULL,
	[totalamt] [float] NULL,
	[aftertax] [float] NULL,
	[roundamount] [float] NULL,
	[paidamt] [float] NULL,
	[balance] [float] NULL,
	[CGSTP] [float] NULL,
	[CGST] [float] NULL,
	[SGSTP] [float] NULL,
	[SGST] [float] NULL,
	[IGSTP] [float] NULL,
	[IGST] [float] NULL,
	[MISC] [float] NULL,
	[transport] [float] NULL,
	[Transport_mode] [nvarchar](255) NULL,
	[VechicleNumber] [nvarchar](255) NULL,
	[SupplyDate] [datetime] NULL,
	[SupplyPlace] [nvarchar](255) NULL,
	[PaymentMode] [nvarchar](255) NULL,
	[tranno] [nvarchar](255) NULL,
	[updatedby] [nvarchar](255) NULL,
	[updatedon] [datetime] NULL,
 CONSTRAINT [PK_tbl_invoice] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_invoice_items]    Script Date: 12/17/2020 9:19:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_invoice_items](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[wid] [int] NULL,
	[JobcardID] [nvarchar](255) NULL,
	[invoice] [nvarchar](255) NULL,
	[jobtype] [nvarchar](255) NULL,
	[MaterialType] [nvarchar](255) NULL,
	[itemcode] [nvarchar](255) NULL,
	[item] [nvarchar](255) NULL,
	[itemcost] [float] NULL,
	[totalitems] [float] NULL,
	[amount] [float] NULL,
	[updatedby] [nvarchar](255) NULL,
 CONSTRAINT [PK_tbl_invoice_items] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_jobcards]    Script Date: 12/17/2020 9:19:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_jobcards](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Jobcardno] [int] NULL,
	[JobcardID] [nvarchar](255) NULL,
	[customerID] [nvarchar](255) NULL,
	[JobType] [nvarchar](255) NULL,
	[itemcode] [nvarchar](255) NULL,
	[item] [nvarchar](255) NULL,
	[totalitems] [float] NULL,
	[balanceitems] [float] NULL,
	[damages] [float] NULL,
	[itemcost] [float] NULL,
	[materialCost] [float] NULL,
	[westage] [float] NULL,
	[totalexp] [float] NULL,
	[totallabchrg] [float] NULL,
	[MRP] [float] NULL,
	[totalamtWOP] [float] NULL,
	[profit_per] [int] NULL,
	[profit] [float] NULL,
	[totalamt] [float] NULL,
	[createdon] [datetime] NULL,
	[createdby] [nvarchar](255) NULL,
	[status] [nvarchar](255) NULL,
	[closedon] [datetime] NULL,
	[closedby] [nvarchar](255) NULL,
	[expected] [datetime] NULL,
 CONSTRAINT [PK_tbl_jobcards] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_jobcards_workers]    Script Date: 12/17/2020 9:19:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_jobcards_workers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[materialID] [int] NULL,
	[JobcardID] [nvarchar](255) NULL,
	[workerID] [int] NULL,
	[workerName] [nvarchar](255) NULL,
	[type] [nvarchar](255) NULL,
	[materialType] [nvarchar](255) NULL,
	[material] [nvarchar](255) NULL,
	[qty] [float] NULL,
	[price_per_unit] [float] NULL,
	[price] [float] NULL,
	[unit_type] [nvarchar](255) NULL,
 CONSTRAINT [PK_tbl_jobcards_workers] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_materials]    Script Date: 12/17/2020 9:19:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_materials](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[type] [nvarchar](255) NOT NULL,
	[MaterialType] [nvarchar](255) NOT NULL,
	[code] [nvarchar](255) NOT NULL,
	[Material] [nvarchar](255) NOT NULL,
	[imgpath] [nvarchar](255) NULL,
 CONSTRAINT [PK_tbl_materials] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_MRN]    Script Date: 12/17/2020 9:19:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_MRN](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MRNID] [nvarchar](255) NULL,
	[materialID] [int] NULL,
	[type] [nvarchar](255) NULL,
	[materialType] [nvarchar](255) NULL,
	[bill_invoice_no] [nvarchar](255) NULL,
	[bill_invoice_date] [datetime] NULL,
	[material] [nvarchar](255) NULL,
	[code] [nvarchar](255) NULL,
	[qty] [float] NULL,
	[bal_qty] [float] NULL,
	[damages] [float] NULL,
	[unit_type] [nvarchar](255) NULL,
	[price_per_unit] [float] NULL,
	[MRP] [float] NULL,
	[tranceport_charge] [float] NULL,
	[total_amt] [float] NULL,
	[remarks] [nvarchar](max) NULL,
	[updatedby] [nvarchar](255) NULL,
	[updatedon] [datetime] NULL,
	[L] [float] NULL,
	[W] [float] NULL,
	[smts] [float] NULL,
	[Sunit_price] [float] NULL,
 CONSTRAINT [PK_tbl_MRN] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_MRN_MSTR]    Script Date: 12/17/2020 9:19:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_MRN_MSTR](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MRN] [int] NULL,
	[MRNID] [nvarchar](255) NULL,
	[SuplierID] [nvarchar](255) NULL,
	[bill_invoice_no] [nvarchar](255) NULL,
	[bill_invoice_date] [datetime] NULL,
	[invoice_amt] [float] NULL,
	[misc_amt] [float] NULL,
	[tranceport_charge] [float] NULL,
	[paid_amt] [float] NULL,
	[payment_mode] [nvarchar](255) NULL,
	[tran_no] [nvarchar](255) NULL,
	[total_amt] [int] NULL,
	[bal_amt] [int] NULL,
	[remarks] [nvarchar](255) NULL,
 CONSTRAINT [PK_tbl_MRN_MSTR] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_prodType]    Script Date: 12/17/2020 9:19:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_prodType](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[productionType] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_tbl_prodType] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_production]    Script Date: 12/17/2020 9:19:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_production](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[proddate] [datetime] NULL,
	[JobcardID] [nvarchar](255) NULL,
	[workerID] [int] NULL,
	[workername] [nvarchar](255) NULL,
	[jobtype] [nvarchar](255) NULL,
	[qty] [float] NULL,
	[dayofwork] [float] NULL,
 CONSTRAINT [PK_tbl_production] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_suplier]    Script Date: 12/17/2020 9:19:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_suplier](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SID] [int] NULL,
	[SuplierID] [nvarchar](255) NOT NULL,
	[suplier] [nvarchar](255) NULL,
	[tin_no] [nvarchar](255) NULL,
	[contact_no] [nvarchar](255) NULL,
	[email] [nvarchar](255) NULL,
	[address] [nvarchar](255) NULL,
	[bank] [nvarchar](255) NULL,
	[bankAcNo] [nvarchar](255) NULL,
	[branch] [nvarchar](255) NULL,
	[ifsc] [nvarchar](255) NULL,
	[gstno] [nvarchar](255) NULL,
	[pan] [nvarchar](255) NULL,
	[aadhaar] [nvarchar](255) NULL,
	[place_city] [nvarchar](255) NULL,
	[BR] [nvarchar](255) NULL,
 CONSTRAINT [PK_tbl_suplier] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_users]    Script Date: 12/17/2020 9:19:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_users](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[userID] [nvarchar](50) NULL,
	[userName] [nvarchar](50) NULL,
	[password] [nvarchar](50) NULL,
	[accessLevel] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[Token] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_users] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_westage]    Script Date: 12/17/2020 9:19:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_westage](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[WRKID] [nvarchar](255) NULL,
	[MID] [nvarchar](255) NULL,
	[Material] [nvarchar](255) NULL,
	[W] [float] NULL,
	[L] [float] NULL,
	[smts] [float] NULL,
	[unitprice] [float] NULL,
	[units] [float] NULL,
	[bal] [float] NULL,
	[price] [float] NULL,
 CONSTRAINT [PK_tbl_westage] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [JobManager] SET  READ_WRITE 
GO
