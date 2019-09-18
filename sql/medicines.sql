USE [hospitalmanagementsystem]
GO

/****** Object:  Table [dbo].[MedicineTable]    Script Date: 09/16/2019 19:03:30 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MedicineTable]') AND type in (N'U'))
DROP TABLE [dbo].[MedicineTable]
GO

USE [hospitalmanagementsystem]
GO

/****** Object:  Table [dbo].[MedicineTable]    Script Date: 09/16/2019 19:03:30 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[MedicineTable](
	[MedicineId] [int] IDENTITY(1,1) NOT NULL,
	[VisitorNo] [numeric](15, 2) NULL,
	[PatientName] [varchar](50) NULL,
	[ReferringNo] [numeric](15, 2) NULL,
	[DoctorName] [varchar](50) NULL,
	[ReferredMedicines] [varchar](100) NULL,
	[MfgDate] [date] NULL,
	[ExpiredDate] [date] NULL,
	[SupplierName] [varchar](100) NULL,
	[CompanyName] [varchar](100) NULL,
	[Image1] [image] NULL,
	[Image2] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[MedicineId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


