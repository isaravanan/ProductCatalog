IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProductAttributes]') AND type in (N'U'))
DROP TABLE [dbo].[ProductAttributes]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*==============================================================*/
/* Table: ProductAttributes                                      */
/*==============================================================*/
CREATE TABLE [dbo].[ProductAttributes](
	[ProductAttributeId] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] int NOT NULL,
	Color nvarchar(10) null,
	Width int  null,
	Height int null,
    [CreatedDT] DATETIME default GETDATE(),
    [ModifiedDT] DATETIME default GETDATE()
    constraint PK_ProductAttribute_ID primary key (ProductAttributeId)
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO


/*==============================================================*/
/* FK: ProductAttributes  to Products                           */
/*==============================================================*/
alter table [ProductAttributes]
   add constraint FK_ProductAttribute_REF_Product foreign key (ProductId)
      references Products (ProductId)
GO



/*==============================================================*/
/*      Object:  Index [NonCIndex_ProductAttribute_ProductID]   */
/*==============================================================*/
CREATE NONCLUSTERED INDEX [NonCIndex_ProductAttribute_ProductID] ON [dbo].[ProductAttributes]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO


