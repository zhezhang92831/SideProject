CREATE TABLE [dbo].[ReservationRequest] (
    [Id]         INT        NOT NULL IDENTITY(1,1) PRIMARY KEY,
    [SenderId]   INT        NOT NULL,
    [ReceiverId] INT        NOT NULL,
    [Date]       ROWVERSION NOT NULL,
    [State]      NCHAR (10) DEFAULT ('pending') NOT NULL,
    [Content]    NTEXT      NULL
);

