CREATE TABLE [dbo].[tblPlayers]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Type] VARCHAR(50) NOT NULL, 
    [Name] VARCHAR(50) NOT NULL, 
    [Strength] VARCHAR(50) NULL, 
    [Dexterity] VARCHAR(50) NULL, 
    [Constitution] VARCHAR(50) NULL, 
    [Intelligence] VARCHAR(50) NULL, 
    [Wisdom] VARCHAR(50) NULL, 
    [Charisma] VARCHAR(50) NULL, 
    [HitPoints] VARCHAR(50) NULL, 
    [ArmorClass] VARCHAR(50) NULL, 
    [Initiative] VARCHAR(50) NULL, 
    [Speed] VARCHAR(50) NULL, 
    [STSuccessCount] INT NULL, 
    [STFailCount] INT NULL, 
    [AdditionalDetails] VARCHAR(MAX) NULL
)
