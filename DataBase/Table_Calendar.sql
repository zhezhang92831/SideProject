CREATE TABLE [dbo].[Calendar]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [OwnerId] INT NOT NULL, 
    [AvailableTime] TIMESTAMP NOT NULL
)
