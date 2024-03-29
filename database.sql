USE [master]
GO
/****** Object:  Database [QLCUAHANG]    Script Date: 7/25/2022 9:43:46 PM ******/
CREATE DATABASE [QLCUAHANG]
 


begin
EXEC [QLCUAHANG].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLCUAHANG] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLCUAHANG] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLCUAHANG] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLCUAHANG] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLCUAHANG] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLCUAHANG] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QLCUAHANG] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLCUAHANG] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLCUAHANG] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLCUAHANG] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLCUAHANG] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLCUAHANG] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLCUAHANG] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLCUAHANG] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLCUAHANG] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLCUAHANG] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLCUAHANG] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLCUAHANG] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLCUAHANG] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLCUAHANG] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLCUAHANG] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLCUAHANG] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLCUAHANG] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLCUAHANG] SET  MULTI_USER 
GO
ALTER DATABASE [QLCUAHANG] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLCUAHANG] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLCUAHANG] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLCUAHANG] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLCUAHANG] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLCUAHANG] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QLCUAHANG] SET QUERY_STORE = OFF
GO
USE [QLCUAHANG]
GO
/****** Object:  Table [dbo].[GIOHANG]    Script Date: 7/25/2022 9:43:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GIOHANG](
	[stt] [int] IDENTITY(1,1) NOT NULL,
	[magiohang] [int] NOT NULL,
	[mahang] [int] NULL,
	[tenhang] [nvarchar](50) NULL,
	[soluong] [int] NULL,
	[gia] [float] NULL,
	[mskh] [int] NULL,
	[thanhtoan] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[XUATHOADON]    Script Date: 7/25/2022 9:43:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[XUATHOADON] AS SELECT mskh,tenhang,soluong,gia,thanhtoan FROM dbo.GIOHANG
GO
/****** Object:  Table [dbo].[DOANHTHU]    Script Date: 7/25/2022 9:43:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DOANHTHU](
	[STT] [int] IDENTITY(1,1) NOT NULL,
	[tien] [float] NULL,
	[ngay] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[STT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HANGHOA]    Script Date: 7/25/2022 9:43:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HANGHOA](
	[mahang] [int] NOT NULL,
	[loaihang] [nvarchar](20) NULL,
	[tenhang] [nvarchar](50) NULL,
	[hinh] [image] NULL,
	[gia] [float] NULL,
	[soluong] [int] NULL,
	[magiamgia] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[mahang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 7/25/2022 9:43:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[mahoadon] [int] IDENTITY(1,1) NOT NULL,
	[mskh] [int] NULL,
	[magiohang] [int] NULL,
	[tongtien] [float] NULL,
	[ngaymua] [date] NULL,
	[trangthai] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[mahoadon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 7/25/2022 9:43:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[mskh] [int] IDENTITY(1,1) NOT NULL,
	[hoten] [nvarchar](50) NULL,
	[gioitinh] [nvarchar](6) NULL,
	[namsinh] [date] NULL,
	[diachi] [nvarchar](50) NULL,
	[sdt] [char](12) NULL,
	[username] [varchar](20) NULL,
	[password] [varchar](20) NULL,
 CONSTRAINT [PK__KHACHHAN__763F5DE56B2E8D01] PRIMARY KEY CLUSTERED 
(
	[mskh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[mytable]    Script Date: 7/25/2022 9:43:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[mytable](
	[Month] [nvarchar](50) NOT NULL,
	[NVName] [nvarchar](50) NOT NULL,
	[ngay1] [bit] NOT NULL,
	[ngay2] [bit] NOT NULL,
	[ngay3] [bit] NOT NULL,
	[ngay4] [bit] NOT NULL,
	[ngay5] [bit] NOT NULL,
	[ngay6] [bit] NOT NULL,
	[ngay7] [bit] NOT NULL,
	[ngay8] [bit] NOT NULL,
	[ngay9] [bit] NOT NULL,
	[ngay10] [bit] NOT NULL,
	[ngay11] [bit] NOT NULL,
	[ngay12] [bit] NOT NULL,
	[ngay13] [bit] NOT NULL,
	[ngay14] [bit] NOT NULL,
	[ngay15] [bit] NOT NULL,
	[ngay16] [bit] NOT NULL,
	[ngay17] [bit] NOT NULL,
	[ngay18] [bit] NOT NULL,
	[ngay19] [bit] NOT NULL,
	[ngay20] [bit] NOT NULL,
	[ngay21] [bit] NOT NULL,
	[ngay22] [bit] NOT NULL,
	[ngay23] [bit] NOT NULL,
	[ngay24] [bit] NOT NULL,
	[ngay25] [bit] NOT NULL,
	[ngay26] [bit] NOT NULL,
	[ngay27] [bit] NOT NULL,
	[ngay28] [bit] NOT NULL,
	[ngay29] [bit] NOT NULL,
	[ngay30] [bit] NOT NULL,
	[ngay31] [bit] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 7/25/2022 9:43:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[msnv] [int] IDENTITY(1,1) NOT NULL,
	[hoten] [nvarchar](50) NULL,
	[gioitinh] [nvarchar](6) NULL,
	[namsinh] [date] NULL,
	[diachi] [nvarchar](50) NULL,
	[hinh] [image] NULL,
	[username] [varchar](20) NULL,
	[password] [varchar](20) NULL,
 CONSTRAINT [PK__NHANVIEN__763F257082286F22] PRIMARY KEY CLUSTERED 
(
	[msnv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QUANLY]    Script Date: 7/25/2022 9:43:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QUANLY](
	[username] [varchar](20) NULL,
	[password] [varchar](20) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THANHTOAN]    Script Date: 7/25/2022 9:43:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THANHTOAN](
	[mahoadon] [int] NULL,
	[msnv] [int] NULL,
	[ngaythanhtoan] [date] NULL,
	[tongtien] [float] NULL
) ON [PRIMARY]
GO
INSERT into dbo.[QUANLY]
(
    username,
    password
)
VALUES
(   'admin', -- username - varchar(20)
    '123'  -- password - varchar(20)
)
go
ALTER TABLE [dbo].[GIOHANG] ADD  DEFAULT ((0)) FOR [thanhtoan]
GO
ALTER TABLE [dbo].[HANGHOA] ADD  DEFAULT ('khong') FOR [magiamgia]
GO
ALTER TABLE [dbo].[HOADON] ADD  DEFAULT ('0') FOR [trangthai]
GO
ALTER TABLE [dbo].[mytable] ADD  CONSTRAINT [DF__mytable__ngay1__46E78A0C]  DEFAULT ((0)) FOR [ngay1]
GO
ALTER TABLE [dbo].[mytable] ADD  CONSTRAINT [DF__mytable__ngay2__47DBAE45]  DEFAULT ((0)) FOR [ngay2]
GO
ALTER TABLE [dbo].[mytable] ADD  CONSTRAINT [DF__mytable__ngay3__48CFD27E]  DEFAULT ((0)) FOR [ngay3]
GO
ALTER TABLE [dbo].[mytable] ADD  CONSTRAINT [DF__mytable__ngay4__49C3F6B7]  DEFAULT ((0)) FOR [ngay4]
GO
ALTER TABLE [dbo].[mytable] ADD  CONSTRAINT [DF__mytable__ngay5__4AB81AF0]  DEFAULT ((0)) FOR [ngay5]
GO
ALTER TABLE [dbo].[mytable] ADD  CONSTRAINT [DF__mytable__ngay6__4BAC3F29]  DEFAULT ((0)) FOR [ngay6]
GO
ALTER TABLE [dbo].[mytable] ADD  CONSTRAINT [DF__mytable__ngay7__4CA06362]  DEFAULT ((0)) FOR [ngay7]
GO
ALTER TABLE [dbo].[mytable] ADD  CONSTRAINT [DF__mytable__ngay8__4D94879B]  DEFAULT ((0)) FOR [ngay8]
GO
ALTER TABLE [dbo].[mytable] ADD  CONSTRAINT [DF__mytable__ngay9__4E88ABD4]  DEFAULT ((0)) FOR [ngay9]
GO
ALTER TABLE [dbo].[mytable] ADD  CONSTRAINT [DF__mytable__ngay10__4F7CD00D]  DEFAULT ((0)) FOR [ngay10]
GO
ALTER TABLE [dbo].[mytable] ADD  CONSTRAINT [DF__mytable__ngay11__5070F446]  DEFAULT ((0)) FOR [ngay11]
GO
ALTER TABLE [dbo].[mytable] ADD  CONSTRAINT [DF__mytable__ngay12__5165187F]  DEFAULT ((0)) FOR [ngay12]
GO
ALTER TABLE [dbo].[mytable] ADD  CONSTRAINT [DF__mytable__ngay13__52593CB8]  DEFAULT ((0)) FOR [ngay13]
GO
ALTER TABLE [dbo].[mytable] ADD  CONSTRAINT [DF__mytable__ngay14__534D60F1]  DEFAULT ((0)) FOR [ngay14]
GO
ALTER TABLE [dbo].[mytable] ADD  CONSTRAINT [DF__mytable__ngay15__5441852A]  DEFAULT ((0)) FOR [ngay15]
GO
ALTER TABLE [dbo].[mytable] ADD  CONSTRAINT [DF__mytable__ngay16__5535A963]  DEFAULT ((0)) FOR [ngay16]
GO
ALTER TABLE [dbo].[mytable] ADD  CONSTRAINT [DF__mytable__ngay17__5629CD9C]  DEFAULT ((0)) FOR [ngay17]
GO
ALTER TABLE [dbo].[mytable] ADD  CONSTRAINT [DF__mytable__ngay18__571DF1D5]  DEFAULT ((0)) FOR [ngay18]
GO
ALTER TABLE [dbo].[mytable] ADD  CONSTRAINT [DF__mytable__ngay19__5812160E]  DEFAULT ((0)) FOR [ngay19]
GO
ALTER TABLE [dbo].[mytable] ADD  CONSTRAINT [DF__mytable__ngay20__59063A47]  DEFAULT ((0)) FOR [ngay20]
GO
ALTER TABLE [dbo].[mytable] ADD  CONSTRAINT [DF__mytable__ngay21__59FA5E80]  DEFAULT ((0)) FOR [ngay21]
GO
ALTER TABLE [dbo].[mytable] ADD  CONSTRAINT [DF__mytable__ngay22__5AEE82B9]  DEFAULT ((0)) FOR [ngay22]
GO
ALTER TABLE [dbo].[mytable] ADD  CONSTRAINT [DF__mytable__ngay23__5BE2A6F2]  DEFAULT ((0)) FOR [ngay23]
GO
ALTER TABLE [dbo].[mytable] ADD  CONSTRAINT [DF__mytable__ngay24__5CD6CB2B]  DEFAULT ((0)) FOR [ngay24]
GO
ALTER TABLE [dbo].[mytable] ADD  CONSTRAINT [DF__mytable__ngay25__5DCAEF64]  DEFAULT ((0)) FOR [ngay25]
GO
ALTER TABLE [dbo].[mytable] ADD  CONSTRAINT [DF__mytable__ngay26__5EBF139D]  DEFAULT ((0)) FOR [ngay26]
GO
ALTER TABLE [dbo].[mytable] ADD  CONSTRAINT [DF__mytable__ngay27__5FB337D6]  DEFAULT ((0)) FOR [ngay27]
GO
ALTER TABLE [dbo].[mytable] ADD  CONSTRAINT [DF__mytable__ngay28__60A75C0F]  DEFAULT ((0)) FOR [ngay28]
GO
ALTER TABLE [dbo].[mytable] ADD  CONSTRAINT [DF__mytable__ngay29__619B8048]  DEFAULT ((0)) FOR [ngay29]
GO
ALTER TABLE [dbo].[mytable] ADD  CONSTRAINT [DF__mytable__ngay30__628FA481]  DEFAULT ((0)) FOR [ngay30]
GO
ALTER TABLE [dbo].[mytable] ADD  CONSTRAINT [DF_mytable_ngay31]  DEFAULT ((0)) FOR [ngay31]
GO
ALTER TABLE [dbo].[GIOHANG]  WITH CHECK ADD FOREIGN KEY([mahang])
REFERENCES [dbo].[HANGHOA] ([mahang])
GO
ALTER TABLE [dbo].[GIOHANG]  WITH CHECK ADD  CONSTRAINT [FK__GIOHANG__mskh__6383C8BA] FOREIGN KEY([mskh])
REFERENCES [dbo].[KHACHHANG] ([mskh])
GO
ALTER TABLE [dbo].[GIOHANG] CHECK CONSTRAINT [FK__GIOHANG__mskh__6383C8BA]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK__HOADON__mskh__6477ECF3] FOREIGN KEY([mskh])
REFERENCES [dbo].[KHACHHANG] ([mskh])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK__HOADON__mskh__6477ECF3]
GO
ALTER TABLE [dbo].[THANHTOAN]  WITH CHECK ADD FOREIGN KEY([mahoadon])
REFERENCES [dbo].[HOADON] ([mahoadon])
GO
ALTER TABLE [dbo].[THANHTOAN]  WITH CHECK ADD  CONSTRAINT [FK__THANHTOAN__msnv__66603565] FOREIGN KEY([msnv])
REFERENCES [dbo].[NHANVIEN] ([msnv])
GO
ALTER TABLE [dbo].[THANHTOAN] CHECK CONSTRAINT [FK__THANHTOAN__msnv__66603565]
GO
ALTER TABLE [dbo].[GIOHANG]  WITH CHECK ADD CHECK  (([soluong]>(0)))
GO
ALTER TABLE [dbo].[HANGHOA]  WITH CHECK ADD CHECK  (([soluong]>=(0)))
GO
USE [master]
GO
ALTER DATABASE [QLCUAHANG] SET  READ_WRITE 
GO


