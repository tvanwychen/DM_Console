/*
 Pre-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be executed before the build script.	
 Use SQLCMD syntax to include a file in the pre-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the pre-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
drop table if exists dbo.tblBosses
drop table if exists dbo.tblEnemys
drop table if exists dbo.tblFriendlys
drop table if exists dbo.tblPlayers
drop table if exists dbo.tblNotes