USE [hospitalmanagementsystem]
GO

/****** Object:  Table [dbo].[SaleTable]    Script Date: 09/16/2019 19:06:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SaleTable]') AND type in (N'U'))
DROP TABLE [dbo].[SaleTable]
GO

USE [hospitalmanagementsystem]
GO

/****** Object:  Table [dbo].[SaleTable]    Script Date: 09/16/2019 19:06:12 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[SaleTable](
	[SaleId] [int] IDENTITY(1,1) NOT NULL,
	[VisitorNo] [numeric](15, 2) NULL,
	[PatientName] [varchar](50) NULL,
	[ReferringNo] [numeric](15, 2) NULL,
	[DoctorName] [varchar](50) NULL,
	[ReferredMedicines] [varchar](100) NULL,
	[SalesPrice] [numeric](20, 2) NULL,
	[Quantity] [numeric](20, 2) NULL,
	[TotalPrice] [numeric](20, 2) NULL,
	[Image1] [image] NULL,
	[Image2] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[SaleId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


