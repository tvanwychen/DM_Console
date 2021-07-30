BEGIN
	INSERT INTO dbo.tblBosses(Id, Type, Name, Strength, Dexterity, Constitution, Intelligence, Wisdom, 
	Charisma, HitPoints, ArmorClass, Initiative, Speed, STSuccessCount, STFailCount, AdditionalDetails)
	VALUES
	(1, 'boss', 'Test_Boss_1', '14', '13', '12', '11', '10', '9', '20', '14', '3', '30', '2', '0', 'These details are for testing purposes - Test boss 1'),
	(2, 'boss', 'Test_Boss_2', '9', '10', '11', '12', '13', '14', '4', '16', '1', '35', '0', '1', 'These details are for testing purposes - Test boss 2')
END