USE [hospitalmanagementsystem]
GO

/****** Object:  Table [dbo].[DoctorTable]    Script Date: 09/16/2019 19:01:39 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DoctorTable]') AND type in (N'U'))
DROP TABLE [dbo].[DoctorTable]
GO

USE [hospitalmanagementsystem]
GO

/****** Object:  Table [dbo].[DoctorTable]    Script Date: 09/16/2019 19:01:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[DoctorTable](
	[DoctorId] [int] IDENTITY(1,1) NOT NULL,
	[ReferringNo] [numeric](15, 2) NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Speciality] [varchar](100) NULL,
	[ContactNo] [numeric](15, 2) NULL,
	[DOB] [date] NULL,
	[Gender] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
	[ReferringRate] [numeric](15, 2) NULL,
	[BloodGroup] [varchar](50) NULL,
	[Image] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[DoctorId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


