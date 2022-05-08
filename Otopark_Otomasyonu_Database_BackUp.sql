USE [master]
GO
/****** Object:  Database [otopark_simulasyonu]    Script Date: 08.05.2022 11:53:38 ******/
CREATE DATABASE [otopark_simulasyonu]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'otopark_simulasyonu', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\otopark_simulasyonu.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'otopark_simulasyonu_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\otopark_simulasyonu_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [otopark_simulasyonu] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [otopark_simulasyonu].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [otopark_simulasyonu] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [otopark_simulasyonu] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [otopark_simulasyonu] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [otopark_simulasyonu] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [otopark_simulasyonu] SET ARITHABORT OFF 
GO
ALTER DATABASE [otopark_simulasyonu] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [otopark_simulasyonu] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [otopark_simulasyonu] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [otopark_simulasyonu] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [otopark_simulasyonu] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [otopark_simulasyonu] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [otopark_simulasyonu] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [otopark_simulasyonu] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [otopark_simulasyonu] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [otopark_simulasyonu] SET  DISABLE_BROKER 
GO
ALTER DATABASE [otopark_simulasyonu] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [otopark_simulasyonu] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [otopark_simulasyonu] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [otopark_simulasyonu] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [otopark_simulasyonu] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [otopark_simulasyonu] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [otopark_simulasyonu] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [otopark_simulasyonu] SET RECOVERY FULL 
GO
ALTER DATABASE [otopark_simulasyonu] SET  MULTI_USER 
GO
ALTER DATABASE [otopark_simulasyonu] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [otopark_simulasyonu] SET DB_CHAINING OFF 
GO
ALTER DATABASE [otopark_simulasyonu] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [otopark_simulasyonu] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [otopark_simulasyonu] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [otopark_simulasyonu] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'otopark_simulasyonu', N'ON'
GO
ALTER DATABASE [otopark_simulasyonu] SET QUERY_STORE = OFF
GO
USE [otopark_simulasyonu]
GO
/****** Object:  Table [dbo].[araba]    Script Date: 08.05.2022 11:53:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[araba](
	[plaka] [varchar](10) NOT NULL,
	[renk] [varchar](15) NOT NULL,
	[park_yeri] [varchar](5) NULL,
	[marka] [varchar](30) NULL,
	[giris_saati] [datetime] NULL,
	[cikis_saati] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[plaka] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cuzdan]    Script Date: 08.05.2022 11:53:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cuzdan](
	[toplam_kazanc] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[giris]    Script Date: 08.05.2022 11:53:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[giris](
	[kullanici_adi] [varchar](30) NOT NULL,
	[sifre] [varchar](30) NOT NULL,
	[kullanici_adi_soyadi] [varchar](60) NOT NULL,
 CONSTRAINT [PK_giris] PRIMARY KEY CLUSTERED 
(
	[kullanici_adi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[marka]    Script Date: 08.05.2022 11:53:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[marka](
	[marka] [varchar](30) NOT NULL,
 CONSTRAINT [PK_marka] PRIMARY KEY CLUSTERED 
(
	[marka] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[musteri]    Script Date: 08.05.2022 11:53:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[musteri](
	[tc_kimlik_no] [varchar](11) NOT NULL,
	[ad] [varchar](30) NOT NULL,
	[soyad] [varchar](30) NOT NULL,
	[telefon] [varchar](10) NOT NULL,
	[email] [varchar](60) NOT NULL,
	[plaka] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[tc_kimlik_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[otopark]    Script Date: 08.05.2022 11:53:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[otopark](
	[park_yeri] [varchar](5) NOT NULL,
	[otopark_durumu] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[park_yeri] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[araba]  WITH CHECK ADD FOREIGN KEY([marka])
REFERENCES [dbo].[marka] ([marka])
GO
ALTER TABLE [dbo].[araba]  WITH CHECK ADD FOREIGN KEY([park_yeri])
REFERENCES [dbo].[otopark] ([park_yeri])
GO
ALTER TABLE [dbo].[musteri]  WITH CHECK ADD FOREIGN KEY([plaka])
REFERENCES [dbo].[araba] ([plaka])
GO
USE [master]
GO
ALTER DATABASE [otopark_simulasyonu] SET  READ_WRITE 
GO
