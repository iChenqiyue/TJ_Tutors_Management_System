USE [master]
GO
/****** Object:  Database [TJ_Tutors_System]    Script Date: 2019/3/25 19:09:26 ******/
CREATE DATABASE [TJ_Tutors_System] ON  PRIMARY 
( NAME = N'TJ_Tutors_System', FILENAME = N'D:\system\WindowsFormsApp1\WindowsFormsApp1\db\TJ_Tutors_System.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TJ_Tutors_System_log', FILENAME = N'D:\system\WindowsFormsApp1\WindowsFormsApp1\db\TJ_Tutors_System_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [TJ_Tutors_System] SET COMPATIBILITY_LEVEL = 90
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TJ_Tutors_System].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TJ_Tutors_System] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TJ_Tutors_System] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TJ_Tutors_System] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TJ_Tutors_System] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TJ_Tutors_System] SET ARITHABORT OFF 
GO
ALTER DATABASE [TJ_Tutors_System] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TJ_Tutors_System] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [TJ_Tutors_System] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TJ_Tutors_System] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TJ_Tutors_System] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TJ_Tutors_System] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TJ_Tutors_System] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TJ_Tutors_System] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TJ_Tutors_System] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TJ_Tutors_System] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TJ_Tutors_System] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TJ_Tutors_System] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TJ_Tutors_System] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TJ_Tutors_System] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TJ_Tutors_System] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TJ_Tutors_System] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TJ_Tutors_System] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TJ_Tutors_System] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TJ_Tutors_System] SET RECOVERY FULL 
GO
ALTER DATABASE [TJ_Tutors_System] SET  MULTI_USER 
GO
ALTER DATABASE [TJ_Tutors_System] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TJ_Tutors_System] SET DB_CHAINING OFF 
GO
EXEC sys.sp_db_vardecimal_storage_format N'TJ_Tutors_System', N'ON'
GO
USE [TJ_Tutors_System]
GO
/****** Object:  Table [dbo].[Parents]    Script Date: 2019/3/25 19:09:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Parents](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[家长编号] [varchar](6) NOT NULL,
	[打印编号] [varchar](8) NOT NULL,
	[接待人] [varchar](30) NOT NULL,
	[接入时间] [date] NOT NULL,
	[家长称呼] [varchar](20) NOT NULL,
	[联系方式] [varchar](11) NOT NULL,
	[家教地址简单] [varchar](50) NOT NULL,
	[家教地址详细] [varchar](100) NOT NULL,
	[年级科目] [varchar](30) NOT NULL,
	[学员性别] [char](2) NOT NULL,
	[家教价格] [float] NOT NULL,
	[家教时间] [varchar](50) NOT NULL,
	[教员要求性别] [char](2) NULL,
	[教员要求地域] [varchar](30) NULL,
	[教员要求年级] [varchar](20) NULL,
	[教员要求专业] [varchar](30) NULL,
	[教员要求其他] [varchar](100) NULL,
	[家教状态] [varchar](max) NOT NULL,
	[经办时间] [varchar](max) NULL,
	[重要备注] [varchar](100) NULL,
	[缴费状态] [varchar](8) NOT NULL,
	[缴费时间] [datetime] NULL,
	[经办人] [varchar](max) NULL,
	[进行状态] [varchar](4) NULL,
 CONSTRAINT [PK_Parents_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Parents-Tutors]    Script Date: 2019/3/25 19:09:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Parents-Tutors](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[家长编号] [varchar](6) NOT NULL,
	[打印编号] [varchar](8) NOT NULL,
	[教员编号] [varchar](6) NULL,
	[教员姓名] [varchar](max) NULL,
	[经办状态] [varchar](max) NOT NULL,
	[经办时间] [varchar](max) NOT NULL,
	[经办人] [varchar](max) NOT NULL,
	[处理备注] [varchar](100) NULL,
 CONSTRAINT [PK_Relationship] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Responsibility]    Script Date: 2019/3/25 19:09:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Responsibility](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[家长编号] [varchar](6) NOT NULL,
	[打印编号] [varchar](8) NOT NULL,
	[经办状态] [varchar](4) NULL,
	[经办时间] [date] NULL,
	[经办人] [varchar](30) NULL,
	[处理备注] [varchar](100) NULL,
 CONSTRAINT [PK_Responsibility] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Subject]    Script Date: 2019/3/25 19:09:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Subject](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[专业] [varchar](max) NULL,
 CONSTRAINT [PK_Subject] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tutors]    Script Date: 2019/3/25 19:09:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tutors](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[教员编号] [varchar](6) NOT NULL,
	[姓名] [varchar](30) NOT NULL,
	[学号] [varchar](7) NOT NULL,
	[院系专业] [varchar](50) NOT NULL,
	[在读学位] [varchar](4) NOT NULL,
	[性别] [varchar](2) NOT NULL,
	[联系方式] [varchar](11) NOT NULL,
	[生源地] [varchar](50) NOT NULL,
	[是否黑名单] [varchar](2) NOT NULL,
	[相关说明及监禁期] [varchar](100) NULL,
	[重要备注] [varchar](100) NULL,
 CONSTRAINT [PK_Tutors] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tutors-Parents]    Script Date: 2019/3/25 19:09:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tutors-Parents](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[家长编号] [varchar](6) NOT NULL,
	[打印编号] [varchar](8) NOT NULL,
	[教员编号] [varchar](8) NOT NULL,
	[经办状态] [varchar](max) NOT NULL,
	[经办时间] [varchar](max) NOT NULL,
	[经办人] [varchar](max) NOT NULL,
	[处理备注] [varchar](100) NULL,
 CONSTRAINT [PK_Tutors-Parents] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[User]    Script Date: 2019/3/25 19:09:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Level] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Workers]    Script Date: 2019/3/25 19:09:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Workers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[姓名] [varchar](30) NOT NULL,
	[性别] [varchar](2) NOT NULL,
	[学号] [varchar](7) NOT NULL,
	[院系专业] [varchar](50) NOT NULL,
	[联系方式] [varchar](11) NOT NULL,
	[职位] [varchar](20) NULL,
	[本月业务积分] [float] NOT NULL,
	[累计业务积分] [float] NOT NULL,
 CONSTRAINT [PK_Workers] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([UserId], [Username], [Password], [Level]) VALUES (1, N'admin', N'admin', N'管理员')
SET IDENTITY_INSERT [dbo].[User] OFF
ALTER TABLE [dbo].[Workers] ADD  CONSTRAINT [DF__Workers__本月业务积分__164452B1]  DEFAULT ((0)) FOR [本月业务积分]
GO
ALTER TABLE [dbo].[Workers] ADD  CONSTRAINT [DF__Workers__累计业务积分__173876EA]  DEFAULT ((0)) FOR [累计业务积分]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User', @level2type=N'COLUMN',@level2name=N'UserId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User', @level2type=N'COLUMN',@level2name=N'Username'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'密码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User', @level2type=N'COLUMN',@level2name=N'Password'
GO
USE [master]
GO
ALTER DATABASE [TJ_Tutors_System] SET  READ_WRITE 
GO
