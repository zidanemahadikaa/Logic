USE [master]
GO
/****** Object:  Database [DB_ENTERTAINER]    Script Date: 9/29/2023 4:28:38 PM ******/
CREATE DATABASE [DB_ENTERTAINER]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DB_ENTERTAINER', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DB_ENTERTAINER.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DB_ENTERTAINER_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DB_ENTERTAINER_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DB_ENTERTAINER] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DB_ENTERTAINER].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DB_ENTERTAINER] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DB_ENTERTAINER] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DB_ENTERTAINER] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DB_ENTERTAINER] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DB_ENTERTAINER] SET ARITHABORT OFF 
GO
ALTER DATABASE [DB_ENTERTAINER] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DB_ENTERTAINER] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DB_ENTERTAINER] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DB_ENTERTAINER] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DB_ENTERTAINER] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DB_ENTERTAINER] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DB_ENTERTAINER] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DB_ENTERTAINER] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DB_ENTERTAINER] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DB_ENTERTAINER] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DB_ENTERTAINER] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DB_ENTERTAINER] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DB_ENTERTAINER] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DB_ENTERTAINER] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DB_ENTERTAINER] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DB_ENTERTAINER] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DB_ENTERTAINER] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DB_ENTERTAINER] SET RECOVERY FULL 
GO
ALTER DATABASE [DB_ENTERTAINER] SET  MULTI_USER 
GO
ALTER DATABASE [DB_ENTERTAINER] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DB_ENTERTAINER] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DB_ENTERTAINER] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DB_ENTERTAINER] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DB_ENTERTAINER] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DB_ENTERTAINER] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'DB_ENTERTAINER', N'ON'
GO
ALTER DATABASE [DB_ENTERTAINER] SET QUERY_STORE = OFF
GO
USE [DB_ENTERTAINER]
GO
/****** Object:  Table [dbo].[artis]    Script Date: 9/29/2023 4:28:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[artis](
	[Kd_artis] [varchar](100) NOT NULL,
	[nm_artis] [varchar](100) NULL,
	[jk] [varchar](100) NULL,
	[bayaran] [int] NULL,
	[award] [int] NULL,
	[negara] [varchar](100) NULL,
 CONSTRAINT [PK_artis] PRIMARY KEY CLUSTERED 
(
	[Kd_artis] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[film]    Script Date: 9/29/2023 4:28:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[film](
	[Kd_film] [varchar](10) NOT NULL,
	[nm_film] [varchar](55) NULL,
	[genre] [varchar](55) NULL,
	[artis] [varchar](55) NULL,
	[produser] [varchar](55) NULL,
	[pendapatan] [money] NULL,
	[nominasi] [int] NULL,
 CONSTRAINT [PK_film] PRIMARY KEY CLUSTERED 
(
	[Kd_film] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[genre]    Script Date: 9/29/2023 4:28:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[genre](
	[kd_genre] [varchar](50) NOT NULL,
	[nm_genre] [varchar](50) NULL,
 CONSTRAINT [pk_genre] PRIMARY KEY CLUSTERED 
(
	[kd_genre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[negara]    Script Date: 9/29/2023 4:28:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[negara](
	[kd_negara] [varchar](100) NOT NULL,
	[nm_negara] [varchar](100) NULL,
 CONSTRAINT [pk_negara] PRIMARY KEY CLUSTERED 
(
	[kd_negara] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[produser]    Script Date: 9/29/2023 4:28:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[produser](
	[kd_produser] [varchar](50) NOT NULL,
	[nm_produser] [varchar](50) NULL,
	[international] [varchar](50) NULL,
	[bayaran] [int] NULL,
	[award] [int] NULL,
	[negara] [varchar](100) NULL,
 CONSTRAINT [PK_produser] PRIMARY KEY CLUSTERED 
(
	[kd_produser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[artis] ([Kd_artis], [nm_artis], [jk], [bayaran], [award], [negara]) VALUES (N'A001', N'ROBERT DOWNEY JR', N'PRIA', 1000000000, 2, N'AS')
INSERT [dbo].[artis] ([Kd_artis], [nm_artis], [jk], [bayaran], [award], [negara]) VALUES (N'A002', N'ANGELINA JOLIE', N'WANITA', 700000000, 1, N'AS')
INSERT [dbo].[artis] ([Kd_artis], [nm_artis], [jk], [bayaran], [award], [negara]) VALUES (N'A003', N'JACKIE CHAN', N'PRIA', 200000000, 7, N'HK')
INSERT [dbo].[artis] ([Kd_artis], [nm_artis], [jk], [bayaran], [award], [negara]) VALUES (N'A004', N'JOE TASLIM', N'PRIA', 350000000, 1, N'ID')
INSERT [dbo].[artis] ([Kd_artis], [nm_artis], [jk], [bayaran], [award], [negara]) VALUES (N'A005', N'CHELSEA ISLAN', N'WANITA', 300000000, 0, N'ID')
GO
INSERT [dbo].[film] ([Kd_film], [nm_film], [genre], [artis], [produser], [pendapatan], [nominasi]) VALUES (N'F001', N'IRON MAN', N'G001', N'A001', N'PD01', 2000000000.0000, 3)
INSERT [dbo].[film] ([Kd_film], [nm_film], [genre], [artis], [produser], [pendapatan], [nominasi]) VALUES (N'F002', N'IRON MAN 2', N'G001', N'A001', N'PD01', 1800000000.0000, 2)
INSERT [dbo].[film] ([Kd_film], [nm_film], [genre], [artis], [produser], [pendapatan], [nominasi]) VALUES (N'F003', N'IRON MAN 3', N'G001', N'A001', N'PD01', 1200000000.0000, 0)
INSERT [dbo].[film] ([Kd_film], [nm_film], [genre], [artis], [produser], [pendapatan], [nominasi]) VALUES (N'F004', N'AVENGER: CIVIL WAR', N'G001', N'A001', N'PD01', 2000000000.0000, 1)
INSERT [dbo].[film] ([Kd_film], [nm_film], [genre], [artis], [produser], [pendapatan], [nominasi]) VALUES (N'F005', N'SPIDERMAN HOME COMING', N'G001', N'A001', N'PD01', 1300000000.0000, 0)
INSERT [dbo].[film] ([Kd_film], [nm_film], [genre], [artis], [produser], [pendapatan], [nominasi]) VALUES (N'F006', N'THE RAID', N'G001', N'A004', N'PD03', 800000000.0000, 5)
INSERT [dbo].[film] ([Kd_film], [nm_film], [genre], [artis], [produser], [pendapatan], [nominasi]) VALUES (N'F007', N'FAST & FURIOUS', N'G001', N'A004', N'PD05', 830000000.0000, 2)
INSERT [dbo].[film] ([Kd_film], [nm_film], [genre], [artis], [produser], [pendapatan], [nominasi]) VALUES (N'F008', N'HABIBIE DAN AINUN', N'G004', N'A005', N'PD03', 670000000.0000, 4)
INSERT [dbo].[film] ([Kd_film], [nm_film], [genre], [artis], [produser], [pendapatan], [nominasi]) VALUES (N'F009', N'POLICE STORY', N'G001', N'A003', N'PD02', 700000000.0000, 3)
INSERT [dbo].[film] ([Kd_film], [nm_film], [genre], [artis], [produser], [pendapatan], [nominasi]) VALUES (N'F010', N'POLICE STORY 2', N'G001', N'A003', N'PD02', 710000000.0000, 1)
INSERT [dbo].[film] ([Kd_film], [nm_film], [genre], [artis], [produser], [pendapatan], [nominasi]) VALUES (N'F011', N'POLICE STORY 3', N'G001', N'A003', N'PD02', 615000000.0000, 0)
INSERT [dbo].[film] ([Kd_film], [nm_film], [genre], [artis], [produser], [pendapatan], [nominasi]) VALUES (N'F012', N'RUSH HOUR', N'G003', N'A003', N'PD05', 695000000.0000, 2)
INSERT [dbo].[film] ([Kd_film], [nm_film], [genre], [artis], [produser], [pendapatan], [nominasi]) VALUES (N'F013', N'KUNGFU PANDA', N'G003', N'A003', N'PD05', 923000000.0000, 5)
GO
INSERT [dbo].[genre] ([kd_genre], [nm_genre]) VALUES (N'G001', N'ACTION')
INSERT [dbo].[genre] ([kd_genre], [nm_genre]) VALUES (N'G002', N'HORROR')
INSERT [dbo].[genre] ([kd_genre], [nm_genre]) VALUES (N'G003', N'COMEDY')
INSERT [dbo].[genre] ([kd_genre], [nm_genre]) VALUES (N'G004', N'DRAMA')
INSERT [dbo].[genre] ([kd_genre], [nm_genre]) VALUES (N'G005', N'THRILLER')
INSERT [dbo].[genre] ([kd_genre], [nm_genre]) VALUES (N'G006', N'FICTION')
GO
INSERT [dbo].[negara] ([kd_negara], [nm_negara]) VALUES (N'AS', N'AMERIKA SERIKAT')
INSERT [dbo].[negara] ([kd_negara], [nm_negara]) VALUES (N'HK', N'HONGKONG')
INSERT [dbo].[negara] ([kd_negara], [nm_negara]) VALUES (N'ID', N'INDONESIA')
INSERT [dbo].[negara] ([kd_negara], [nm_negara]) VALUES (N'IN', N'INDIA')
GO
INSERT [dbo].[produser] ([kd_produser], [nm_produser], [international], [bayaran], [award], [negara]) VALUES (N'PD01', N'MARVEL', N'YA', NULL, NULL, NULL)
INSERT [dbo].[produser] ([kd_produser], [nm_produser], [international], [bayaran], [award], [negara]) VALUES (N'PD02', N'HONGKONG CINEMA', N'YA', NULL, NULL, NULL)
INSERT [dbo].[produser] ([kd_produser], [nm_produser], [international], [bayaran], [award], [negara]) VALUES (N'PD03', N'RAPI FILM', N'TIDAK', NULL, NULL, NULL)
INSERT [dbo].[produser] ([kd_produser], [nm_produser], [international], [bayaran], [award], [negara]) VALUES (N'PD04', N'PARKIT', N'TIDAK', NULL, NULL, NULL)
INSERT [dbo].[produser] ([kd_produser], [nm_produser], [international], [bayaran], [award], [negara]) VALUES (N'PD05', N'PARAMOUNT PICTURE', N'YA', NULL, NULL, NULL)
GO
USE [master]
GO
ALTER DATABASE [DB_ENTERTAINER] SET  READ_WRITE 
GO
