IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Products]') AND type in (N'U'))
DROP TABLE [dbo].[Products]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*==============================================================*/
/* Table: Product                                               */
/*==============================================================*/
CREATE TABLE [dbo].[Products](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](40) NOT NULL,
	[PricePerItem] float NULL,
	[AverageCustomerRating] float NULL,
    [CreatedDT] DATETIME default GETDATE(),
    [ModifiedDT] DATETIME default GETDATE()
    constraint PK_PRODUCT_ID primary key (ProductId)
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
