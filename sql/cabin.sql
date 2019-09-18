USE [hospitalmanagementsystem]
GO

/****** Object:  Table [dbo].[CabinTable]    Script Date: 09/16/2019 19:08:36 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CabinTable]') AND type in (N'U'))
DROP TABLE [dbo].[CabinTable]
GO

USE [hospitalmanagementsystem]
GO

/****** Object:  Table [dbo].[CabinTable]    Script Date: 09/16/2019 19:08:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[CabinTable](
	[CabinId] [int] IDENTITY(1,1) NOT NULL,
	[CabinNo] [numeric](15, 2) NULL,
	[RoomNo] [numeric](15, 2) NULL,
	[CabinType] [varchar](50) NULL,
	[Doctor] [varchar](50) NULL,
	[Staff] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[CabinId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


