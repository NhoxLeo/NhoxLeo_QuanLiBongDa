USE [master]
GO
/****** Object:  Database [GIAIVODICHBONGDA]    Script Date: 6/4/2018 8:16:46 PM ******/
CREATE DATABASE [GIAIVODICHBONGDA]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GIAIVODICHBONGDA', FILENAME = N'D:\Database\GIAIVODICHBONGDA.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'GIAIVODICHBONGDA_log', FILENAME = N'D:\Database\GIAIVODICHBONGDA_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [GIAIVODICHBONGDA] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GIAIVODICHBONGDA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GIAIVODICHBONGDA] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GIAIVODICHBONGDA] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GIAIVODICHBONGDA] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GIAIVODICHBONGDA] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GIAIVODICHBONGDA] SET ARITHABORT OFF 
GO
ALTER DATABASE [GIAIVODICHBONGDA] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [GIAIVODICHBONGDA] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GIAIVODICHBONGDA] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GIAIVODICHBONGDA] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GIAIVODICHBONGDA] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GIAIVODICHBONGDA] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GIAIVODICHBONGDA] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GIAIVODICHBONGDA] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GIAIVODICHBONGDA] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GIAIVODICHBONGDA] SET  DISABLE_BROKER 
GO
ALTER DATABASE [GIAIVODICHBONGDA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GIAIVODICHBONGDA] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GIAIVODICHBONGDA] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GIAIVODICHBONGDA] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GIAIVODICHBONGDA] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GIAIVODICHBONGDA] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GIAIVODICHBONGDA] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GIAIVODICHBONGDA] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GIAIVODICHBONGDA] SET  MULTI_USER 
GO
ALTER DATABASE [GIAIVODICHBONGDA] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GIAIVODICHBONGDA] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GIAIVODICHBONGDA] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GIAIVODICHBONGDA] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [GIAIVODICHBONGDA] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [GIAIVODICHBONGDA] SET QUERY_STORE = OFF
GO
USE [GIAIVODICHBONGDA]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [GIAIVODICHBONGDA]
GO
/****** Object:  Table [dbo].[BANGXEPHANG_DOIBONG]    Script Date: 6/4/2018 8:16:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BANGXEPHANG_DOIBONG](
	[MaMua] [nchar](10) NOT NULL,
	[MaDoi] [nchar](10) NOT NULL,
	[Diem] [int] NOT NULL,
	[TongSoBangThang] [int] NOT NULL,
	[TongSoBanThua] [int] NOT NULL,
	[HieuSo] [int] NOT NULL,
	[SoBanThangSanKhack] [int] NOT NULL,
	[KetQuaDoiKhang] [int] NOT NULL,
	[Hang] [int] NOT NULL,
 CONSTRAINT [PK_BANGXEPHANG_DOI BONG] PRIMARY KEY CLUSTERED 
(
	[MaMua] ASC,
	[MaDoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BANGXEPHANG_GHIBAN]    Script Date: 6/4/2018 8:16:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BANGXEPHANG_GHIBAN](
	[MaMua] [nchar](10) NOT NULL,
	[MaCauThu] [nchar](10) NOT NULL,
	[MaDoi] [nchar](10) NOT NULL,
	[SoBan] [int] NOT NULL,
 CONSTRAINT [PK_BANGXEPHANG_GHI BAN] PRIMARY KEY CLUSTERED 
(
	[MaMua] ASC,
	[MaCauThu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CAUTHU]    Script Date: 6/4/2018 8:16:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CAUTHU](
	[MaCauThu] [nchar](10) NOT NULL,
	[TenCauThu] [nvarchar](50) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[QuocTich] [nchar](10) NOT NULL,
	[GhiChu] [nchar](10) NULL,
	[MaLoaiCauThu] [nchar](10) NOT NULL,
	[HinhAnh] [image] NULL,
 CONSTRAINT [PK_CAU THU] PRIMARY KEY CLUSTERED 
(
	[MaCauThu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CAUTHU_MUAGIAI]    Script Date: 6/4/2018 8:16:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CAUTHU_MUAGIAI](
	[MaMua] [nchar](10) NOT NULL,
	[MaCauThu] [nchar](10) NOT NULL,
	[MaDoi] [nchar](10) NOT NULL,
 CONSTRAINT [PK_CAUTHU_MUAGI AI] PRIMARY KEY CLUSTERED 
(
	[MaMua] ASC,
	[MaCauThu] ASC,
	[MaDoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CAUTHUGHIBAN]    Script Date: 6/4/2018 8:16:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CAUTHUGHIBAN](
	[MaTranDau] [nchar](10) NOT NULL,
	[MaCauThu] [nchar](10) NOT NULL,
	[MaLoaiBanThang] [nchar](10) NOT NULL,
	[ThoiDiem] [time](7) NOT NULL,
 CONSTRAINT [PK_CAUTHU GHIBAN] PRIMARY KEY CLUSTERED 
(
	[MaTranDau] ASC,
	[MaCauThu] ASC,
	[ThoiDiem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CAUTHURASAN]    Script Date: 6/4/2018 8:16:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CAUTHURASAN](
	[MaTranDau] [nchar](10) NOT NULL,
	[MaCauThu] [nchar](10) NOT NULL,
	[MaDoi] [nchar](10) NOT NULL,
	[ViTri] [nchar](10) NOT NULL,
	[SoAo] [int] NULL,
 CONSTRAINT [PK_CAUTHURASAN] PRIMARY KEY CLUSTERED 
(
	[MaTranDau] ASC,
	[MaCauThu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DIEMSO]    Script Date: 6/4/2018 8:16:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DIEMSO](
	[KetQua] [nchar](10) NOT NULL,
	[Diem] [int] NOT NULL,
 CONSTRAINT [PK_DIEMSO] PRIMARY KEY CLUSTERED 
(
	[KetQua] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DOIBONG]    Script Date: 6/4/2018 8:16:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DOIBONG](
	[MaDoi] [nchar](10) NOT NULL,
	[TenDoi] [nvarchar](50) NOT NULL,
	[NgayThanhLap] [date] NOT NULL,
 CONSTRAINT [PK_DOI BONG] PRIMARY KEY CLUSTERED 
(
	[MaDoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DOIBONG_MUAGIAI]    Script Date: 6/4/2018 8:16:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DOIBONG_MUAGIAI](
	[MaMua] [nchar](10) NOT NULL,
	[MaDoi] [nchar](10) NOT NULL,
	[MaSan] [nchar](10) NOT NULL,
 CONSTRAINT [PK_DOIBONG_MUAGI AI] PRIMARY KEY CLUSTERED 
(
	[MaMua] ASC,
	[MaDoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAIBANTHANG]    Script Date: 6/4/2018 8:16:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIBANTHANG](
	[MaLoaiBanThang] [nchar](10) NOT NULL,
	[TenLoaiBanThang] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_LOAIBANT HANG] PRIMARY KEY CLUSTERED 
(
	[MaLoaiBanThang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAICAUTHU]    Script Date: 6/4/2018 8:16:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAICAUTHU](
	[MaLoaiCauThu] [nchar](10) NOT NULL,
	[TenLoaiCauThu] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_LOAICAU THU] PRIMARY KEY CLUSTERED 
(
	[MaLoaiCauThu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MUAGIAI]    Script Date: 6/4/2018 8:16:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MUAGIAI](
	[MaMua] [nchar](10) NOT NULL,
	[TenMua] [nvarchar](50) NULL,
	[NgayBatDau] [date] NOT NULL,
	[NgayKetThuc] [date] NOT NULL,
	[SoLuotDau] [int] NULL,
 CONSTRAINT [PK_MaMua] PRIMARY KEY CLUSTERED 
(
	[MaMua] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SAN]    Script Date: 6/4/2018 8:16:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SAN](
	[MaSan] [nchar](10) NOT NULL,
	[TenSan] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NULL,
 CONSTRAINT [PK_SA N] PRIMARY KEY CLUSTERED 
(
	[MaSan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THAMSO]    Script Date: 6/4/2018 8:16:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THAMSO](
	[TenThamSo] [nvarchar](50) NOT NULL,
	[GiaTri] [int] NULL,
 CONSTRAINT [PK_THAMSO] PRIMARY KEY CLUSTERED 
(
	[TenThamSo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TRANDAU]    Script Date: 6/4/2018 8:16:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRANDAU](
	[MaTranDau] [nchar](10) NOT NULL,
	[MaMua] [nchar](10) NOT NULL,
	[MaDoi1] [nchar](10) NOT NULL,
	[MaDoi2] [nchar](10) NOT NULL,
	[MaSan] [nchar](10) NOT NULL,
	[MaTrongTai] [nchar](10) NOT NULL,
	[MaLoaiBanThang] [nchar](10) NOT NULL,
	[KetQua] [nchar](10) NOT NULL,
	[Luot] [int] NOT NULL,
	[NgayGioDuKien] [datetime] NOT NULL,
	[NgayGioThucTe] [datetime] NOT NULL,
	[ThoiGianDaThiDau] [time](7) NULL,
	[SoBanThangDoi1] [int] NULL,
	[SoBanThangDoi2] [int] NULL,
 CONSTRAINT [PK_TRAN DAU] PRIMARY KEY CLUSTERED 
(
	[MaTranDau] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TRONGTAI]    Script Date: 6/4/2018 8:16:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRONGTAI](
	[MaTrongTai] [nchar](10) NOT NULL,
	[TenTrongTai] [nvarchar](50) NOT NULL,
	[NgaySinh] [date] NULL,
 CONSTRAINT [PK_TRONG TAI] PRIMARY KEY CLUSTERED 
(
	[MaTrongTai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VITRI]    Script Date: 6/4/2018 8:16:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VITRI](
	[ViTri] [nchar](10) NOT NULL,
 CONSTRAINT [PK_VITRI_1] PRIMARY KEY CLUSTERED 
(
	[ViTri] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[XEPHANG]    Script Date: 6/4/2018 8:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[XEPHANG](
	[TenUuTien] [nvarchar](50) NOT NULL,
	[DoUuTien] [int] NOT NULL,
	[MaMua] [nchar](10) NOT NULL,
 CONSTRAINT [PK_XEP HANG] PRIMARY KEY CLUSTERED 
(
	[TenUuTien] ASC,
	[MaMua] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BANGXEPHANG_DOIBONG]  WITH CHECK ADD  CONSTRAINT [FK_BANGXEPHANG_DOIBONG_DOIBONG] FOREIGN KEY([MaDoi])
REFERENCES [dbo].[DOIBONG] ([MaDoi])
GO
ALTER TABLE [dbo].[BANGXEPHANG_DOIBONG] CHECK CONSTRAINT [FK_BANGXEPHANG_DOIBONG_DOIBONG]
GO
ALTER TABLE [dbo].[BANGXEPHANG_DOIBONG]  WITH CHECK ADD  CONSTRAINT [FK_BANGXEPHANG_DOIBONG_MUAGIAI] FOREIGN KEY([MaMua])
REFERENCES [dbo].[MUAGIAI] ([MaMua])
GO
ALTER TABLE [dbo].[BANGXEPHANG_DOIBONG] CHECK CONSTRAINT [FK_BANGXEPHANG_DOIBONG_MUAGIAI]
GO
ALTER TABLE [dbo].[BANGXEPHANG_GHIBAN]  WITH CHECK ADD  CONSTRAINT [FK_BANGXEPHANG_GHIBAN_CAUTHU] FOREIGN KEY([MaCauThu])
REFERENCES [dbo].[CAUTHU] ([MaCauThu])
GO
ALTER TABLE [dbo].[BANGXEPHANG_GHIBAN] CHECK CONSTRAINT [FK_BANGXEPHANG_GHIBAN_CAUTHU]
GO
ALTER TABLE [dbo].[BANGXEPHANG_GHIBAN]  WITH CHECK ADD  CONSTRAINT [FK_BANGXEPHANG_GHIBAN_DOIBONG] FOREIGN KEY([MaDoi])
REFERENCES [dbo].[DOIBONG] ([MaDoi])
GO
ALTER TABLE [dbo].[BANGXEPHANG_GHIBAN] CHECK CONSTRAINT [FK_BANGXEPHANG_GHIBAN_DOIBONG]
GO
ALTER TABLE [dbo].[BANGXEPHANG_GHIBAN]  WITH CHECK ADD  CONSTRAINT [FK_BANGXEPHANG_GHIBAN_MUAGIAI] FOREIGN KEY([MaMua])
REFERENCES [dbo].[MUAGIAI] ([MaMua])
GO
ALTER TABLE [dbo].[BANGXEPHANG_GHIBAN] CHECK CONSTRAINT [FK_BANGXEPHANG_GHIBAN_MUAGIAI]
GO
ALTER TABLE [dbo].[CAUTHU]  WITH CHECK ADD  CONSTRAINT [FK_CAUTHU_LOAICAUTHU] FOREIGN KEY([MaLoaiCauThu])
REFERENCES [dbo].[LOAICAUTHU] ([MaLoaiCauThu])
GO
ALTER TABLE [dbo].[CAUTHU] CHECK CONSTRAINT [FK_CAUTHU_LOAICAUTHU]
GO
ALTER TABLE [dbo].[CAUTHU_MUAGIAI]  WITH CHECK ADD  CONSTRAINT [FK_CAUTHU_MUAGIAI_CAUTHU] FOREIGN KEY([MaCauThu])
REFERENCES [dbo].[CAUTHU] ([MaCauThu])
GO
ALTER TABLE [dbo].[CAUTHU_MUAGIAI] CHECK CONSTRAINT [FK_CAUTHU_MUAGIAI_CAUTHU]
GO
ALTER TABLE [dbo].[CAUTHU_MUAGIAI]  WITH CHECK ADD  CONSTRAINT [FK_CAUTHU_MUAGIAI_DOIBONG] FOREIGN KEY([MaDoi])
REFERENCES [dbo].[DOIBONG] ([MaDoi])
GO
ALTER TABLE [dbo].[CAUTHU_MUAGIAI] CHECK CONSTRAINT [FK_CAUTHU_MUAGIAI_DOIBONG]
GO
ALTER TABLE [dbo].[CAUTHU_MUAGIAI]  WITH CHECK ADD  CONSTRAINT [FK_CAUTHU_MUAGIAI_MUAGIAI] FOREIGN KEY([MaMua])
REFERENCES [dbo].[MUAGIAI] ([MaMua])
GO
ALTER TABLE [dbo].[CAUTHU_MUAGIAI] CHECK CONSTRAINT [FK_CAUTHU_MUAGIAI_MUAGIAI]
GO
ALTER TABLE [dbo].[CAUTHUGHIBAN]  WITH CHECK ADD  CONSTRAINT [FK_CAUTHUGHIBAN_CAUTHU] FOREIGN KEY([MaCauThu])
REFERENCES [dbo].[CAUTHU] ([MaCauThu])
GO
ALTER TABLE [dbo].[CAUTHUGHIBAN] CHECK CONSTRAINT [FK_CAUTHUGHIBAN_CAUTHU]
GO
ALTER TABLE [dbo].[CAUTHUGHIBAN]  WITH CHECK ADD  CONSTRAINT [FK_CAUTHUGHIBAN_TRANDAU] FOREIGN KEY([MaTranDau])
REFERENCES [dbo].[TRANDAU] ([MaTranDau])
GO
ALTER TABLE [dbo].[CAUTHUGHIBAN] CHECK CONSTRAINT [FK_CAUTHUGHIBAN_TRANDAU]
GO
ALTER TABLE [dbo].[CAUTHURASAN]  WITH CHECK ADD  CONSTRAINT [FK_CAUTHURASAN_CAUTHU] FOREIGN KEY([MaCauThu])
REFERENCES [dbo].[CAUTHU] ([MaCauThu])
GO
ALTER TABLE [dbo].[CAUTHURASAN] CHECK CONSTRAINT [FK_CAUTHURASAN_CAUTHU]
GO
ALTER TABLE [dbo].[CAUTHURASAN]  WITH CHECK ADD  CONSTRAINT [FK_CAUTHURASAN_DOIBONG] FOREIGN KEY([MaDoi])
REFERENCES [dbo].[DOIBONG] ([MaDoi])
GO
ALTER TABLE [dbo].[CAUTHURASAN] CHECK CONSTRAINT [FK_CAUTHURASAN_DOIBONG]
GO
ALTER TABLE [dbo].[CAUTHURASAN]  WITH CHECK ADD  CONSTRAINT [FK_CAUTHURASAN_TRANDAU] FOREIGN KEY([MaTranDau])
REFERENCES [dbo].[TRANDAU] ([MaTranDau])
GO
ALTER TABLE [dbo].[CAUTHURASAN] CHECK CONSTRAINT [FK_CAUTHURASAN_TRANDAU]
GO
ALTER TABLE [dbo].[CAUTHURASAN]  WITH CHECK ADD  CONSTRAINT [FK_CAUTHURASAN_VITRI] FOREIGN KEY([ViTri])
REFERENCES [dbo].[VITRI] ([ViTri])
GO
ALTER TABLE [dbo].[CAUTHURASAN] CHECK CONSTRAINT [FK_CAUTHURASAN_VITRI]
GO
ALTER TABLE [dbo].[DOIBONG]  WITH CHECK ADD  CONSTRAINT [FK_DOIBONG_DOIBONG] FOREIGN KEY([MaDoi])
REFERENCES [dbo].[DOIBONG] ([MaDoi])
GO
ALTER TABLE [dbo].[DOIBONG] CHECK CONSTRAINT [FK_DOIBONG_DOIBONG]
GO
ALTER TABLE [dbo].[DOIBONG_MUAGIAI]  WITH CHECK ADD  CONSTRAINT [FK_DOIBONG_MUAGIAI_DOIBONG] FOREIGN KEY([MaDoi])
REFERENCES [dbo].[DOIBONG] ([MaDoi])
GO
ALTER TABLE [dbo].[DOIBONG_MUAGIAI] CHECK CONSTRAINT [FK_DOIBONG_MUAGIAI_DOIBONG]
GO
ALTER TABLE [dbo].[DOIBONG_MUAGIAI]  WITH CHECK ADD  CONSTRAINT [FK_DOIBONG_MUAGIAI_MUAGIAI] FOREIGN KEY([MaMua])
REFERENCES [dbo].[MUAGIAI] ([MaMua])
GO
ALTER TABLE [dbo].[DOIBONG_MUAGIAI] CHECK CONSTRAINT [FK_DOIBONG_MUAGIAI_MUAGIAI]
GO
ALTER TABLE [dbo].[DOIBONG_MUAGIAI]  WITH CHECK ADD  CONSTRAINT [FK_DOIBONG_MUAGIAI_SAN] FOREIGN KEY([MaSan])
REFERENCES [dbo].[SAN] ([MaSan])
GO
ALTER TABLE [dbo].[DOIBONG_MUAGIAI] CHECK CONSTRAINT [FK_DOIBONG_MUAGIAI_SAN]
GO
ALTER TABLE [dbo].[TRANDAU]  WITH CHECK ADD  CONSTRAINT [FK_TRANDAU_DIEMSO] FOREIGN KEY([KetQua])
REFERENCES [dbo].[DIEMSO] ([KetQua])
GO
ALTER TABLE [dbo].[TRANDAU] CHECK CONSTRAINT [FK_TRANDAU_DIEMSO]
GO
ALTER TABLE [dbo].[TRANDAU]  WITH CHECK ADD  CONSTRAINT [FK_TRANDAU_LOAIBANTHANG] FOREIGN KEY([MaLoaiBanThang])
REFERENCES [dbo].[LOAIBANTHANG] ([MaLoaiBanThang])
GO
ALTER TABLE [dbo].[TRANDAU] CHECK CONSTRAINT [FK_TRANDAU_LOAIBANTHANG]
GO
ALTER TABLE [dbo].[TRANDAU]  WITH CHECK ADD  CONSTRAINT [FK_TRANDAU_MUAGIAI] FOREIGN KEY([MaMua])
REFERENCES [dbo].[MUAGIAI] ([MaMua])
GO
ALTER TABLE [dbo].[TRANDAU] CHECK CONSTRAINT [FK_TRANDAU_MUAGIAI]
GO
ALTER TABLE [dbo].[TRANDAU]  WITH CHECK ADD  CONSTRAINT [FK_TRANDAU_SAN] FOREIGN KEY([MaSan])
REFERENCES [dbo].[SAN] ([MaSan])
GO
ALTER TABLE [dbo].[TRANDAU] CHECK CONSTRAINT [FK_TRANDAU_SAN]
GO
ALTER TABLE [dbo].[TRANDAU]  WITH CHECK ADD  CONSTRAINT [FK_TRANDAU_TRONGTAI] FOREIGN KEY([MaTrongTai])
REFERENCES [dbo].[TRONGTAI] ([MaTrongTai])
GO
ALTER TABLE [dbo].[TRANDAU] CHECK CONSTRAINT [FK_TRANDAU_TRONGTAI]
GO
ALTER TABLE [dbo].[XEPHANG]  WITH CHECK ADD  CONSTRAINT [FK_XEPHANG_MUAGIAI] FOREIGN KEY([MaMua])
REFERENCES [dbo].[MUAGIAI] ([MaMua])
GO
ALTER TABLE [dbo].[XEPHANG] CHECK CONSTRAINT [FK_XEPHANG_MUAGIAI]
GO
USE [master]
GO
ALTER DATABASE [GIAIVODICHBONGDA] SET  READ_WRITE 
GO
