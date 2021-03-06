USE [master]
GO
/****** Object:  Database [worklogs_db]    Script Date: 3/21/2021 12:20:06 AM ******/
CREATE DATABASE [worklogs_db]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'worklogs_db', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\worklogs_db.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'worklogs_db_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\worklogs_db_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [worklogs_db] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [worklogs_db].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [worklogs_db] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [worklogs_db] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [worklogs_db] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [worklogs_db] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [worklogs_db] SET ARITHABORT OFF 
GO
ALTER DATABASE [worklogs_db] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [worklogs_db] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [worklogs_db] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [worklogs_db] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [worklogs_db] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [worklogs_db] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [worklogs_db] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [worklogs_db] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [worklogs_db] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [worklogs_db] SET  DISABLE_BROKER 
GO
ALTER DATABASE [worklogs_db] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [worklogs_db] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [worklogs_db] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [worklogs_db] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [worklogs_db] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [worklogs_db] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [worklogs_db] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [worklogs_db] SET RECOVERY FULL 
GO
ALTER DATABASE [worklogs_db] SET  MULTI_USER 
GO
ALTER DATABASE [worklogs_db] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [worklogs_db] SET DB_CHAINING OFF 
GO
ALTER DATABASE [worklogs_db] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [worklogs_db] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [worklogs_db] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [worklogs_db] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'worklogs_db', N'ON'
GO
ALTER DATABASE [worklogs_db] SET QUERY_STORE = OFF
GO
USE [worklogs_db]
GO
/****** Object:  Table [dbo].[Freelancer]    Script Date: 3/21/2021 12:20:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Freelancer](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Freelancer] [nvarchar](255) NULL,
	[price(hour)] [float] NULL,
	[adress] [nvarchar](255) NULL,
	[zipcode] [float] NULL,
	[city] [nvarchar](255) NULL,
	[state] [nvarchar](255) NULL,
	[county] [nvarchar](255) NULL,
 CONSTRAINT [PK_Freelancer] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[project_freelancer]    Script Date: 3/21/2021 12:20:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[project_freelancer](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_Freelancer] [int] NOT NULL,
	[id_project] [int] NOT NULL,
 CONSTRAINT [PK_project_freelancer] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[projects]    Script Date: 3/21/2021 12:20:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[projects](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[project] [nvarchar](255) NULL,
	[estimation(days)] [float] NULL,
	[customer] [nvarchar](255) NULL,
	[address] [nvarchar](255) NULL,
	[zipcode] [float] NULL,
	[state] [nvarchar](255) NULL,
	[county] [nvarchar](255) NULL,
	[city] [nvarchar](255) NULL,
 CONSTRAINT [PK_projects] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[workday]    Script Date: 3/21/2021 12:20:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[workday](
	[id] [int] NOT NULL,
	[id_Freelancer] [int] NOT NULL,
	[id_project] [int] NOT NULL,
	[workday] [datetime] NULL,
	[hours] [float] NULL,
 CONSTRAINT [PK_workday] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[workday] ADD  CONSTRAINT [DF__workday__id_proj__5FB337D6]  DEFAULT ('0') FOR [id_project]
GO
ALTER TABLE [dbo].[project_freelancer]  WITH CHECK ADD  CONSTRAINT [FK_Freelancer] FOREIGN KEY([id_Freelancer])
REFERENCES [dbo].[Freelancer] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[project_freelancer] CHECK CONSTRAINT [FK_Freelancer]
GO
ALTER TABLE [dbo].[project_freelancer]  WITH CHECK ADD  CONSTRAINT [FK_project] FOREIGN KEY([id_project])
REFERENCES [dbo].[projects] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[project_freelancer] CHECK CONSTRAINT [FK_project]
GO
ALTER TABLE [dbo].[workday]  WITH CHECK ADD  CONSTRAINT [FK_id_proj] FOREIGN KEY([id_project])
REFERENCES [dbo].[projects] ([id])
GO
ALTER TABLE [dbo].[workday] CHECK CONSTRAINT [FK_id_proj]
GO
/****** Object:  StoredProcedure [dbo].[AddWorkload]    Script Date: 3/21/2021 12:20:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddWorkload] (@id_Freelancer  INTEGER,
							 @workday        DATETIME,
							 @hours          FLOAT)
AS 
 BEGIN
       IF (@hours<=8)
 	    BEGIN
	     INSERT INTO dbo.workday
						(id_Freelancer,
						 workday,
						 hours)
	     VALUES         (@id_Freelancer,
						 @workday,
						 @hours)
	  END
	  ELSE
	   BEGIN
	    PRINT 'Give a value smaller or equal than 8 and try again.'
		return;
	  END
END
GO
/****** Object:  StoredProcedure [dbo].[CheckWorkload]    Script Date: 3/21/2021 12:20:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CheckWorkload](@id  INTEGER)
AS 
 BEGIN
	  IF((SELECT COUNT(w.workday) from dbo.workday w join dbo.projects p on w.id_project=p.id  where p.id=@id group by w.id_project, p.id)<(SELECT [estimation(days)] from dbo.projects where id=@id))
	   BEGIN
	         PRINT N'Not enough workload'; 
	   END
	  ELSE 
	   BEGIN
	     PRINT N'Enough workload';
	   END  
  END
GO
/****** Object:  StoredProcedure [dbo].[SelectAllFreelancers]    Script Date: 3/21/2021 12:20:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SelectAllFreelancers]
AS
SELECT * FROM dbo.Freelancer
GO;

EXEC SelectAllFreelancers;
GO
USE [master]
GO
ALTER DATABASE [worklogs_db] SET  READ_WRITE 
GO
