CREATE TABLE [dbo].[Parent]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Age] INT NULL, 
    [Gender] BIT NOT NULL, 
    [Photo] NTEXT NULL,  
    [Address] NVARCHAR(50) NULL, 
    [KidInfo] NTEXT NULL,
	[Password] NVARCHAR(50) NOT NULL
)
