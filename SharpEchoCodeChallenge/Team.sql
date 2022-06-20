﻿CREATE TABLE [dbo].[Team]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL
)

GO

CREATE UNIQUE INDEX [IX_Team_Name] ON [dbo].[Team] ([Name])
