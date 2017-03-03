CREATE TABLE [dbo].[CareGiver]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Name] NVARCHAR(50) NOT NULL, 
    [Age] INT NULL, 
    [Gender] BIT NOT NULL, 
    [Photo] NTEXT NULL, 
    [YearsOfExperience ] INT NULL, 
    [HourRate] INT NULL, 
    [CalendarId] INT NULL, 
    [CPRTraining] BIT NULL, 
    [ComfortabelWithPets] BIT NULL, 
    [Smoker] BIT NULL, 
    [FirstAidTraining] BIT NULL, 
    [Address] NVARCHAR(50) NULL,
	[Password] NVARCHAR(50) NOT NULL
)
