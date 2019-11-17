USE [hospitalmanagementsystem]
GO

/****** Object:  Table [dbo].[SaleTable]    Script Date: 11/15/2019 23:11:46 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SaleTable]') AND type in (N'U'))
DROP TABLE [dbo].[SaleTable]
GO

USE [hospitalmanagementsystem]
GO

/****** Object:  Table [dbo].[SaleTable]    Script Date: 11/15/2019 23:11:46 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[SaleTable](
	[SaleId] [int] IDENTITY(1,1) NOT NULL,
	[VisitorNo] [numeric](20, 0) NULL,
	[PatientName] [varchar](50) NULL,
	[DoctorName] [varchar](50) NULL,
	[ReferredMedicines] [varchar](100) NULL,
	[SalesPrice] [numeric](20, 0) NULL,
	[Quantity] [numeric](20, 0) NULL,
	[TotalPrice] [numeric](20, 0) NULL,
	[Discount] [numeric](20, 0) NULL,
	[GrandTotal] [numeric](20, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[SaleId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


