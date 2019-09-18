USE [hospitalmanagementsystem]
GO

/****** Object:  Table [dbo].[PatientTable]    Script Date: 09/16/2019 19:04:59 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PatientTable]') AND type in (N'U'))
DROP TABLE [dbo].[PatientTable]
GO

USE [hospitalmanagementsystem]
GO

/****** Object:  Table [dbo].[PatientTable]    Script Date: 09/16/2019 19:04:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[PatientTable](
	[PatientId] [int] IDENTITY(1,1) NOT NULL,
	[VisitorNo] [numeric](15, 2) NULL,
	[Title] [varchar](50) NULL,
	[PatientName] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
	[ContactNo] [numeric](15, 2) NULL,
	[DOB] [date] NULL,
	[Gender] [varchar](50) NULL,
	[PatientType] [varchar](50) NULL,
	[MaritialStatus] [varchar](50) NULL,
	[BloodGroup] [varchar](50) NULL,
	[Image] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[PatientId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


