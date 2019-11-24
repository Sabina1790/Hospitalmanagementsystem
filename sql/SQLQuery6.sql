USE [hospitalmanagementsystem]
GO

/****** Object:  Table [dbo].[StaffTable]    Script Date: 11/15/2019 23:12:49 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StaffTable]') AND type in (N'U'))
DROP TABLE [dbo].[StaffTable]
GO

USE [hospitalmanagementsystem]
GO

/****** Object:  Table [dbo].[StaffTable]    Script Date: 11/15/2019 23:12:49 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[StaffTable](
	[StaffId] [int] IDENTITY(1,1) NOT NULL,
	[StaffNo] [numeric](20, 0) NULL,
	[StaffName] [varchar](50) NULL,
	[Category] [varchar](50) NULL,
	[WardNo] [numeric](20, 0) NULL,
	[Qualification] [varchar](100) NULL,
	[DOB] [date] NULL,
	[Gender] [varchar](50) NULL,
	[MaritalStatus] [varchar](50) NULL,
	[BloodGroup] [varchar](50) NULL,
	[DutyTime] [time](7) NULL,
	[EndTime] [time](7) NULL,
	[Image] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[StaffId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


