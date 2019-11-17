USE [hospitalmanagementsystem]
GO

/****** Object:  Table [dbo].[MedicinesTable]    Script Date: 11/15/2019 22:59:21 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MedicinesTable]') AND type in (N'U'))
DROP TABLE [dbo].[MedicinesTable]
GO

USE [hospitalmanagementsystem]
GO

/****** Object:  Table [dbo].[MedicinesTable]    Script Date: 11/15/2019 22:59:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[MedicinesTable](
	[MedicineId] [int] IDENTITY(1,1) NOT NULL,
	[VisitorNo] [numeric](20, 0) NULL,
	[PatientName] [varchar](50) NULL,
	[DoctorName] [varchar](50) NULL,
	[ReferredMedicines] [varchar](100) NULL,
	[MfgDate] [date] NULL,
	[ExpiredDate] [date] NULL,
	[SupplierName] [varchar](50) NULL,
	[CompanyName] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MedicineId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


