CREATE TABLE [dbo].[Review]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [ReviewerId] INT NOT NULL, 
    [RevieweeId] INT NOT NULL, 
    [Date] TIMESTAMP NOT NULL, 
    [Rating] SMALLINT NULL, 
    [Content] NTEXT NULL
)
