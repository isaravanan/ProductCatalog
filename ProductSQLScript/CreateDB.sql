--Server=localhost;Database=ProductCatalog;Trusted_Connection=False;User=sa;Password=Sql-2019;MultipleActiveResultSets=true;
USE master;  
GO  
IF DB_ID (N'ProductCatalog','TN',1) IS NOT NULL  
DROP DATABASE ProductCatalog;  
GO  
CREATE DATABASE ProductCatalog  
GO