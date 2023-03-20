-- ============================================================================
-- Author:			Arman Stepanian
-- Description:		Create tables Categories,Products,ProductCategories
-- Script:			20230320_1230_DML_Create_tables_Categories_Products_ProductCategories.sql
-- ============================================================================
GO
IF NOT EXISTS(SELECT 1 FROM [sys].[tables] WHERE [Name] = 'Product_Categories_Maping' AND [Schema_ID] = SCHEMA_ID('dbo'))
	BEGIN
		CREATE TABLE [dbo].[Product_Categories_Maping] (
			[ID] BIGINT PRIMARY KEY NOT NULL IDENTITY(1,1),
			[CategoriesID] BIGINT NULL,
			[ProductID] BIGINT NULL
		);
	END
IF NOT EXISTS(SELECT 1 FROM [sys].[tables] WHERE [Name] = 'Products' AND [Schema_ID] = SCHEMA_ID('dbo'))
	BEGIN
		CREATE TABLE [dbo].[Products] (
			[ID] BIGINT PRIMARY KEY NOT NULL IDENTITY(1,1),
			[Name] nvarchar(30) NOT NULL,
		);
	END
IF NOT EXISTS(SELECT 1 FROM [sys].[tables] WHERE [Name] = 'Categories' AND [Schema_ID] = SCHEMA_ID('dbo'))
	BEGIN
		CREATE TABLE [dbo].[Categories] (
			[ID] BIGINT PRIMARY KEY NOT NULL IDENTITY(1,1),
			[Name] nvarchar(30) NOT NULL,
		);
END
SELECT P.name,
    C.name
FROM [dbo].[Products] P
    LEFT JOIN Product_Categories_Maping PC on P.ID = PC.ProductID
    LEFT JOIN Categories C on C.ID = PC.CategoryID;
GO

EXEC [shark].[AddNewDBVersion]
	 @script = N'20230320_1230_DML_Create_tables_Categories_Products_ProductCategories.sql',
	 @description = N'Create tables Categories,Products,ProductCategories',
	 @createdBy = N'Arman Stepanian'
GO