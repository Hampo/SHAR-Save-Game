Settings = GetSettings()
SaveSlot = Settings.SaveSlot

if Settings.Preset ~= "No Preset" then
	local presetName = Settings.Preset == "Custom" and Settings.CustomPreset or Settings.Preset
	if #presetName == 0 then
		Alert("No custom preset name entered.")
		os.exit()
		return
	end
	local PresetFile = "/GameData/CustomSavePresets/" .. presetName .. ".lua"
	if not Exists(PresetFile, true, false) then
		Alert("Could not file config file: " .. PresetFile)
		os.exit()
		return
	end
	local preset = dofile(PresetFile)
	if type(preset) ~= "table" then
		Alert("Config file \"" .. PresetFile .. "\" did not return a table.")
		os.exit()
		return
	end
	local requiredSettings = {"PlayerName", "CurrentLevel", "CurrentMission", "HighestLevel", "HighestMission", "Coins", "AllPersistentObjectStates", "ItchyScratchyCBGFirst", "ItchyScratchyTicket", "Level1FMVUnlocked", "Level1CurrentSkin", "Level1Card1", "Level1Card2", "Level1Card3", "Level1Card4", "Level1Card5", "Level1Card6", "Level1Card7", "Level1Mission1", "Level1Mission2", "Level1Mission3", "Level1Mission4", "Level1Mission5", "Level1Mission6", "Level1Mission7", "Level1Mission8", "Level1BonusMission", "Level1Race1", "Level1Race2", "Level1Race3", "Level1GambleRace", "Level1Reward1", "Level1Reward2", "Level1Reward3", "Level1Reward4", "Level1Reward5", "Level1Reward6", "Level1Reward7", "Level1Reward8", "Level1Reward9", "Level1Reward10", "Level1Reward11", "Level1Reward12", "Level1Gag1", "Level1Gag2", "Level1Gag3", "Level1Gag4", "Level1Gag5", "Level1Gag6", "Level1Gag7", "Level1Gag8", "Level1Gag9", "Level1Gag10", "Level1Gag11", "Level1Gag12", "Level1Gag13", "Level1Gag14", "Level1Gag15", "Level1Gag16", "Level1Gag17", "Level1Gag18", "Level1Gag19", "Level1Gag20", "Level1Gag21", "Level1Gag22", "Level1Gag23", "Level1Gag24", "Level1Gag25", "Level1Gag26", "Level1Gag27", "Level1Gag28", "Level1Gag29", "Level1Gag30", "Level1Gag31", "Level1Gag32", "Level2FMVUnlocked", "Level2CurrentSkin", "Level2Card1", "Level2Card2", "Level2Card3", "Level2Card4", "Level2Card5", "Level2Card6", "Level2Card7", "Level2Mission1", "Level2Mission2", "Level2Mission3", "Level2Mission4", "Level2Mission5", "Level2Mission6", "Level2Mission7", "Level2Mission8", "Level2BonusMission", "Level2Race1", "Level2Race2", "Level2Race3", "Level2GambleRace", "Level2Reward1", "Level2Reward2", "Level2Reward3", "Level2Reward4", "Level2Reward5", "Level2Reward6", "Level2Reward7", "Level2Reward8", "Level2Reward9", "Level2Reward10", "Level2Reward11", "Level2Reward12", "Level2Gag1", "Level2Gag2", "Level2Gag3", "Level2Gag4", "Level2Gag5", "Level2Gag6", "Level2Gag7", "Level2Gag8", "Level2Gag9", "Level2Gag10", "Level2Gag11", "Level2Gag12", "Level2Gag13", "Level2Gag14", "Level2Gag15", "Level2Gag16", "Level2Gag17", "Level2Gag18", "Level2Gag19", "Level2Gag20", "Level2Gag21", "Level2Gag22", "Level2Gag23", "Level2Gag24", "Level2Gag25", "Level2Gag26", "Level2Gag27", "Level2Gag28", "Level2Gag29", "Level2Gag30", "Level2Gag31", "Level2Gag32", "Level3FMVUnlocked", "Level3CurrentSkin", "Level3Card1", "Level3Card2", "Level3Card3", "Level3Card4", "Level3Card5", "Level3Card6", "Level3Card7", "Level3Mission1", "Level3Mission2", "Level3Mission3", "Level3Mission4", "Level3Mission5", "Level3Mission6", "Level3Mission7", "Level3Mission8", "Level3BonusMission", "Level3Race1", "Level3Race2", "Level3Race3", "Level3GambleRace", "Level3Reward1", "Level3Reward2", "Level3Reward3", "Level3Reward4", "Level3Reward5", "Level3Reward6", "Level3Reward7", "Level3Reward8", "Level3Reward9", "Level3Reward10", "Level3Reward11", "Level3Reward12", "Level3Gag1", "Level3Gag2", "Level3Gag3", "Level3Gag4", "Level3Gag5", "Level3Gag6", "Level3Gag7", "Level3Gag8", "Level3Gag9", "Level3Gag10", "Level3Gag11", "Level3Gag12", "Level3Gag13", "Level3Gag14", "Level3Gag15", "Level3Gag16", "Level3Gag17", "Level3Gag18", "Level3Gag19", "Level3Gag20", "Level3Gag21", "Level3Gag22", "Level3Gag23", "Level3Gag24", "Level3Gag25", "Level3Gag26", "Level3Gag27", "Level3Gag28", "Level3Gag29", "Level3Gag30", "Level3Gag31", "Level3Gag32", "Level4FMVUnlocked", "Level4CurrentSkin", "Level4Card1", "Level4Card2", "Level4Card3", "Level4Card4", "Level4Card5", "Level4Card6", "Level4Card7", "Level4Mission1", "Level4Mission2", "Level4Mission3", "Level4Mission4", "Level4Mission5", "Level4Mission6", "Level4Mission7", "Level4Mission8", "Level4BonusMission", "Level4Race1", "Level4Race2", "Level4Race3", "Level4GambleRace", "Level4Reward1", "Level4Reward2", "Level4Reward3", "Level4Reward4", "Level4Reward5", "Level4Reward6", "Level4Reward7", "Level4Reward8", "Level4Reward9", "Level4Reward10", "Level4Reward11", "Level4Reward12", "Level4Gag1", "Level4Gag2", "Level4Gag3", "Level4Gag4", "Level4Gag5", "Level4Gag6", "Level4Gag7", "Level4Gag8", "Level4Gag9", "Level4Gag10", "Level4Gag11", "Level4Gag12", "Level4Gag13", "Level4Gag14", "Level4Gag15", "Level4Gag16", "Level4Gag17", "Level4Gag18", "Level4Gag19", "Level4Gag20", "Level4Gag21", "Level4Gag22", "Level4Gag23", "Level4Gag24", "Level4Gag25", "Level4Gag26", "Level4Gag27", "Level4Gag28", "Level4Gag29", "Level4Gag30", "Level4Gag31", "Level4Gag32", "Level5FMVUnlocked", "Level5CurrentSkin", "Level5Card1", "Level5Card2", "Level5Card3", "Level5Card4", "Level5Card5", "Level5Card6", "Level5Card7", "Level5Mission1", "Level5Mission2", "Level5Mission3", "Level5Mission4", "Level5Mission5", "Level5Mission6", "Level5Mission7", "Level5Mission8", "Level5BonusMission", "Level5Race1", "Level5Race2", "Level5Race3", "Level5GambleRace", "Level5Reward1", "Level5Reward2", "Level5Reward3", "Level5Reward4", "Level5Reward5", "Level5Reward6", "Level5Reward7", "Level5Reward8", "Level5Reward9", "Level5Reward10", "Level5Reward11", "Level5Reward12", "Level5Gag1", "Level5Gag2", "Level5Gag3", "Level5Gag4", "Level5Gag5", "Level5Gag6", "Level5Gag7", "Level5Gag8", "Level5Gag9", "Level5Gag10", "Level5Gag11", "Level5Gag12", "Level5Gag13", "Level5Gag14", "Level5Gag15", "Level5Gag16", "Level5Gag17", "Level5Gag18", "Level5Gag19", "Level5Gag20", "Level5Gag21", "Level5Gag22", "Level5Gag23", "Level5Gag24", "Level5Gag25", "Level5Gag26", "Level5Gag27", "Level5Gag28", "Level5Gag29", "Level5Gag30", "Level5Gag31", "Level5Gag32", "Level6FMVUnlocked", "Level6CurrentSkin", "Level6Card1", "Level6Card2", "Level6Card3", "Level6Card4", "Level6Card5", "Level6Card6", "Level6Card7", "Level6Mission1", "Level6Mission2", "Level6Mission3", "Level6Mission4", "Level6Mission5", "Level6Mission6", "Level6Mission7", "Level6Mission8", "Level6BonusMission", "Level6Race1", "Level6Race2", "Level6Race3", "Level6GambleRace", "Level6Reward1", "Level6Reward2", "Level6Reward3", "Level6Reward4", "Level6Reward5", "Level6Reward6", "Level6Reward7", "Level6Reward8", "Level6Reward9", "Level6Reward10", "Level6Reward11", "Level6Reward12", "Level6Gag1", "Level6Gag2", "Level6Gag3", "Level6Gag4", "Level6Gag5", "Level6Gag6", "Level6Gag7", "Level6Gag8", "Level6Gag9", "Level6Gag10", "Level6Gag11", "Level6Gag12", "Level6Gag13", "Level6Gag14", "Level6Gag15", "Level6Gag16", "Level6Gag17", "Level6Gag18", "Level6Gag19", "Level6Gag20", "Level6Gag21", "Level6Gag22", "Level6Gag23", "Level6Gag24", "Level6Gag25", "Level6Gag26", "Level6Gag27", "Level6Gag28", "Level6Gag29", "Level6Gag30", "Level6Gag31", "Level6Gag32", "Level7FMVUnlocked", "Level7CurrentSkin", "Level7Card1", "Level7Card2", "Level7Card3", "Level7Card4", "Level7Card5", "Level7Card6", "Level7Card7", "Level7Mission1", "Level7Mission2", "Level7Mission3", "Level7Mission4", "Level7Mission5", "Level7Mission6", "Level7Mission7", "Level7Mission8", "Level7BonusMission", "Level7Race1", "Level7Race2", "Level7Race3", "Level7GambleRace", "Level7Reward1", "Level7Reward2", "Level7Reward3", "Level7Reward4", "Level7Reward5", "Level7Reward6", "Level7Reward7", "Level7Reward8", "Level7Reward9", "Level7Reward10", "Level7Reward11", "Level7Reward12", "Level7Gag1", "Level7Gag2", "Level7Gag3", "Level7Gag4", "Level7Gag5", "Level7Gag6", "Level7Gag7", "Level7Gag8", "Level7Gag9", "Level7Gag10", "Level7Gag11", "Level7Gag12", "Level7Gag13", "Level7Gag14", "Level7Gag15", "Level7Gag16", "Level7Gag17", "Level7Gag18", "Level7Gag19", "Level7Gag20", "Level7Gag21", "Level7Gag22", "Level7Gag23", "Level7Gag24", "Level7Gag25", "Level7Gag26", "Level7Gag27", "Level7Gag28", "Level7Gag29", "Level7Gag30", "Level7Gag31", "Level7Gag32", "Car1Name", "Car1Health", "Car2Name", "Car2Health", "Car3Name", "Car3Health", "Car4Name", "Car4Health", "Car5Name", "Car5Health", "Car6Name", "Car6Health", "Car7Name", "Car7Health", "Car8Name", "Car8Health", "Car9Name", "Car9Health", "Car10Name", "Car10Health", "Car11Name", "Car11Health", "Car12Name", "Car12Health", "Car13Name", "Car13Health", "Car14Name", "Car14Health", "Car15Name", "Car15Health", "Car16Name", "Car16Health", "Car17Name", "Car17Health", "Car18Name", "Car18Health", "Car19Name", "Car19Health", "Car20Name", "Car20Health", "Car21Name", "Car21Health", "Car22Name", "Car22Health", "Car23Name", "Car23Health", "Car24Name", "Car24Health", "Car25Name", "Car25Health", "Car26Name", "Car26Health", "Car27Name", "Car27Health", "Car28Name", "Car28Health", "Car29Name", "Car29Health", "Car30Name", "Car30Health", "Car31Name", "Car31Health", "Car32Name", "Car32Health", "Car33Name", "Car33Health", "Car34Name", "Car34Health", "Car35Name", "Car35Health", "Car36Name", "Car36Health", "Car37Name", "Car37Health", "Car38Name", "Car38Health", "Car39Name", "Car39Health", "Car40Name", "Car40Health", "Car41Name", "Car41Health", "Car42Name", "Car42Health", "Car43Name", "Car43Health", "Car44Name", "Car44Health", "Car45Name", "Car45Health", "Car46Name", "Car46Health", "Car47Name", "Car47Health", "Car48Name", "Car48Health", "Car49Name", "Car49Health", "Car50Name", "Car50Health", "Car51Name", "Car51Health", "Car52Name", "Car52Health", "Car53Name", "Car53Health", "Car54Name", "Car54Health", "Car55Name", "Car55Health", "Car56Name", "Car56Health", "Car57Name", "Car57Health", "Car58Name", "Car58Health", "Car59Name", "Car59Health", "Car60Name", "Car60Health", "Level1Wasp1", "Level1Wasp2", "Level1Wasp3", "Level1Wasp4", "Level1Wasp5", "Level1Wasp6", "Level1Wasp7", "Level1Wasp8", "Level1Wasp9", "Level1Wasp10", "Level1Wasp11", "Level1Wasp12", "Level1Wasp13", "Level1Wasp14", "Level1Wasp15", "Level1Wasp16", "Level1Wasp17", "Level1Wasp18", "Level1Wasp19", "Level1Wasp20", "Level1Wasp21", "Level1Wasp22", "Level1Wasp23", "Level1Wasp24", "Level1Wasp25", "Level1Wasp26", "Level1Wasp27", "Level1Wasp28", "Level1Wasp29", "Level1Wasp30", "Level1Wasp31", "Level1Wasp32", "Level1Wasp33", "Level1Wasp34", "Level1Wasp35", "Level1Wasp36", "Level1Wasp37", "Level1Wasp38", "Level1Wasp39", "Level1Wasp40", "Level1Wasp41", "Level1Wasp42", "Level1Wasp43", "Level1Wasp44", "Level1Wasp45", "Level1Wasp46", "Level1Wasp47", "Level1Wasp48", "Level1Wasp49", "Level1Wasp50", "Level1Wasp51", "Level1Wasp52", "Level1Wasp53", "Level1Wasp54", "Level1Wasp55", "Level1Wasp56", "Level1Wasp57", "Level1Wasp58", "Level1Wasp59", "Level1Wasp60", "Level1Wasp61", "Level1Wasp62", "Level1Wasp63", "Level1Wasp64", "Level1Wasp65", "Level1Wasp66", "Level1Wasp67", "Level1Wasp68", "Level1Wasp69", "Level1Wasp70", "Level1Wasp71", "Level1Wasp72", "Level1Wasp73", "Level1Wasp74", "Level1Wasp75", "Level1Wasp76", "Level1Wasp77", "Level1Wasp78", "Level1Wasp79", "Level1Wasp80", "Level1Wasp81", "Level1Wasp82", "Level1Wasp83", "Level1Wasp84", "Level1Wasp85", "Level1Wasp86", "Level1Wasp87", "Level1Wasp88", "Level1Wasp89", "Level1Wasp90", "Level1Wasp91", "Level1Wasp92", "Level1Wasp93", "Level1Wasp94", "Level1Wasp95", "Level1Wasp96", "Level1Wasp97", "Level1Wasp98", "Level1Wasp99", "Level1Wasp100", "Level1Wasp101", "Level1Wasp102", "Level1Wasp103", "Level1Wasp104", "Level1Wasp105", "Level1Wasp106", "Level1Wasp107", "Level1Wasp108", "Level1Wasp109", "Level1Wasp110", "Level1Wasp111", "Level1Wasp112", "Level1Wasp113", "Level1Wasp114", "Level1Wasp115", "Level1Wasp116", "Level1Wasp117", "Level1Wasp118", "Level1Wasp119", "Level1Wasp120", "Level1Wasp121", "Level1Wasp122", "Level1Wasp123", "Level1Wasp124", "Level1Wasp125", "Level1Wasp126", "Level1Wasp127", "Level1Wasp128", "Level2Wasp1", "Level2Wasp2", "Level2Wasp3", "Level2Wasp4", "Level2Wasp5", "Level2Wasp6", "Level2Wasp7", "Level2Wasp8", "Level2Wasp9", "Level2Wasp10", "Level2Wasp11", "Level2Wasp12", "Level2Wasp13", "Level2Wasp14", "Level2Wasp15", "Level2Wasp16", "Level2Wasp17", "Level2Wasp18", "Level2Wasp19", "Level2Wasp20", "Level2Wasp21", "Level2Wasp22", "Level2Wasp23", "Level2Wasp24", "Level2Wasp25", "Level2Wasp26", "Level2Wasp27", "Level2Wasp28", "Level2Wasp29", "Level2Wasp30", "Level2Wasp31", "Level2Wasp32", "Level2Wasp33", "Level2Wasp34", "Level2Wasp35", "Level2Wasp36", "Level2Wasp37", "Level2Wasp38", "Level2Wasp39", "Level2Wasp40", "Level2Wasp41", "Level2Wasp42", "Level2Wasp43", "Level2Wasp44", "Level2Wasp45", "Level2Wasp46", "Level2Wasp47", "Level2Wasp48", "Level2Wasp49", "Level2Wasp50", "Level2Wasp51", "Level2Wasp52", "Level2Wasp53", "Level2Wasp54", "Level2Wasp55", "Level2Wasp56", "Level2Wasp57", "Level2Wasp58", "Level2Wasp59", "Level2Wasp60", "Level2Wasp61", "Level2Wasp62", "Level2Wasp63", "Level2Wasp64", "Level2Wasp65", "Level2Wasp66", "Level2Wasp67", "Level2Wasp68", "Level2Wasp69", "Level2Wasp70", "Level2Wasp71", "Level2Wasp72", "Level2Wasp73", "Level2Wasp74", "Level2Wasp75", "Level2Wasp76", "Level2Wasp77", "Level2Wasp78", "Level2Wasp79", "Level2Wasp80", "Level2Wasp81", "Level2Wasp82", "Level2Wasp83", "Level2Wasp84", "Level2Wasp85", "Level2Wasp86", "Level2Wasp87", "Level2Wasp88", "Level2Wasp89", "Level2Wasp90", "Level2Wasp91", "Level2Wasp92", "Level2Wasp93", "Level2Wasp94", "Level2Wasp95", "Level2Wasp96", "Level2Wasp97", "Level2Wasp98", "Level2Wasp99", "Level2Wasp100", "Level2Wasp101", "Level2Wasp102", "Level2Wasp103", "Level2Wasp104", "Level2Wasp105", "Level2Wasp106", "Level2Wasp107", "Level2Wasp108", "Level2Wasp109", "Level2Wasp110", "Level2Wasp111", "Level2Wasp112", "Level2Wasp113", "Level2Wasp114", "Level2Wasp115", "Level2Wasp116", "Level2Wasp117", "Level2Wasp118", "Level2Wasp119", "Level2Wasp120", "Level2Wasp121", "Level2Wasp122", "Level2Wasp123", "Level2Wasp124", "Level2Wasp125", "Level2Wasp126", "Level2Wasp127", "Level2Wasp128", "Level3Wasp1", "Level3Wasp2", "Level3Wasp3", "Level3Wasp4", "Level3Wasp5", "Level3Wasp6", "Level3Wasp7", "Level3Wasp8", "Level3Wasp9", "Level3Wasp10", "Level3Wasp11", "Level3Wasp12", "Level3Wasp13", "Level3Wasp14", "Level3Wasp15", "Level3Wasp16", "Level3Wasp17", "Level3Wasp18", "Level3Wasp19", "Level3Wasp20", "Level3Wasp21", "Level3Wasp22", "Level3Wasp23", "Level3Wasp24", "Level3Wasp25", "Level3Wasp26", "Level3Wasp27", "Level3Wasp28", "Level3Wasp29", "Level3Wasp30", "Level3Wasp31", "Level3Wasp32", "Level3Wasp33", "Level3Wasp34", "Level3Wasp35", "Level3Wasp36", "Level3Wasp37", "Level3Wasp38", "Level3Wasp39", "Level3Wasp40", "Level3Wasp41", "Level3Wasp42", "Level3Wasp43", "Level3Wasp44", "Level3Wasp45", "Level3Wasp46", "Level3Wasp47", "Level3Wasp48", "Level3Wasp49", "Level3Wasp50", "Level3Wasp51", "Level3Wasp52", "Level3Wasp53", "Level3Wasp54", "Level3Wasp55", "Level3Wasp56", "Level3Wasp57", "Level3Wasp58", "Level3Wasp59", "Level3Wasp60", "Level3Wasp61", "Level3Wasp62", "Level3Wasp63", "Level3Wasp64", "Level3Wasp65", "Level3Wasp66", "Level3Wasp67", "Level3Wasp68", "Level3Wasp69", "Level3Wasp70", "Level3Wasp71", "Level3Wasp72", "Level3Wasp73", "Level3Wasp74", "Level3Wasp75", "Level3Wasp76", "Level3Wasp77", "Level3Wasp78", "Level3Wasp79", "Level3Wasp80", "Level3Wasp81", "Level3Wasp82", "Level3Wasp83", "Level3Wasp84", "Level3Wasp85", "Level3Wasp86", "Level3Wasp87", "Level3Wasp88", "Level3Wasp89", "Level3Wasp90", "Level3Wasp91", "Level3Wasp92", "Level3Wasp93", "Level3Wasp94", "Level3Wasp95", "Level3Wasp96", "Level3Wasp97", "Level3Wasp98", "Level3Wasp99", "Level3Wasp100", "Level3Wasp101", "Level3Wasp102", "Level3Wasp103", "Level3Wasp104", "Level3Wasp105", "Level3Wasp106", "Level3Wasp107", "Level3Wasp108", "Level3Wasp109", "Level3Wasp110", "Level3Wasp111", "Level3Wasp112", "Level3Wasp113", "Level3Wasp114", "Level3Wasp115", "Level3Wasp116", "Level3Wasp117", "Level3Wasp118", "Level3Wasp119", "Level3Wasp120", "Level3Wasp121", "Level3Wasp122", "Level3Wasp123", "Level3Wasp124", "Level3Wasp125", "Level3Wasp126", "Level3Wasp127", "Level3Wasp128", "Level4Wasp1", "Level4Wasp2", "Level4Wasp3", "Level4Wasp4", "Level4Wasp5", "Level4Wasp6", "Level4Wasp7", "Level4Wasp8", "Level4Wasp9", "Level4Wasp10", "Level4Wasp11", "Level4Wasp12", "Level4Wasp13", "Level4Wasp14", "Level4Wasp15", "Level4Wasp16", "Level4Wasp17", "Level4Wasp18", "Level4Wasp19", "Level4Wasp20", "Level4Wasp21", "Level4Wasp22", "Level4Wasp23", "Level4Wasp24", "Level4Wasp25", "Level4Wasp26", "Level4Wasp27", "Level4Wasp28", "Level4Wasp29", "Level4Wasp30", "Level4Wasp31", "Level4Wasp32", "Level4Wasp33", "Level4Wasp34", "Level4Wasp35", "Level4Wasp36", "Level4Wasp37", "Level4Wasp38", "Level4Wasp39", "Level4Wasp40", "Level4Wasp41", "Level4Wasp42", "Level4Wasp43", "Level4Wasp44", "Level4Wasp45", "Level4Wasp46", "Level4Wasp47", "Level4Wasp48", "Level4Wasp49", "Level4Wasp50", "Level4Wasp51", "Level4Wasp52", "Level4Wasp53", "Level4Wasp54", "Level4Wasp55", "Level4Wasp56", "Level4Wasp57", "Level4Wasp58", "Level4Wasp59", "Level4Wasp60", "Level4Wasp61", "Level4Wasp62", "Level4Wasp63", "Level4Wasp64", "Level4Wasp65", "Level4Wasp66", "Level4Wasp67", "Level4Wasp68", "Level4Wasp69", "Level4Wasp70", "Level4Wasp71", "Level4Wasp72", "Level4Wasp73", "Level4Wasp74", "Level4Wasp75", "Level4Wasp76", "Level4Wasp77", "Level4Wasp78", "Level4Wasp79", "Level4Wasp80", "Level4Wasp81", "Level4Wasp82", "Level4Wasp83", "Level4Wasp84", "Level4Wasp85", "Level4Wasp86", "Level4Wasp87", "Level4Wasp88", "Level4Wasp89", "Level4Wasp90", "Level4Wasp91", "Level4Wasp92", "Level4Wasp93", "Level4Wasp94", "Level4Wasp95", "Level4Wasp96", "Level4Wasp97", "Level4Wasp98", "Level4Wasp99", "Level4Wasp100", "Level4Wasp101", "Level4Wasp102", "Level4Wasp103", "Level4Wasp104", "Level4Wasp105", "Level4Wasp106", "Level4Wasp107", "Level4Wasp108", "Level4Wasp109", "Level4Wasp110", "Level4Wasp111", "Level4Wasp112", "Level4Wasp113", "Level4Wasp114", "Level4Wasp115", "Level4Wasp116", "Level4Wasp117", "Level4Wasp118", "Level4Wasp119", "Level4Wasp120", "Level4Wasp121", "Level4Wasp122", "Level4Wasp123", "Level4Wasp124", "Level4Wasp125", "Level4Wasp126", "Level4Wasp127", "Level4Wasp128", "Level5Wasp1", "Level5Wasp2", "Level5Wasp3", "Level5Wasp4", "Level5Wasp5", "Level5Wasp6", "Level5Wasp7", "Level5Wasp8", "Level5Wasp9", "Level5Wasp10", "Level5Wasp11", "Level5Wasp12", "Level5Wasp13", "Level5Wasp14", "Level5Wasp15", "Level5Wasp16", "Level5Wasp17", "Level5Wasp18", "Level5Wasp19", "Level5Wasp20", "Level5Wasp21", "Level5Wasp22", "Level5Wasp23", "Level5Wasp24", "Level5Wasp25", "Level5Wasp26", "Level5Wasp27", "Level5Wasp28", "Level5Wasp29", "Level5Wasp30", "Level5Wasp31", "Level5Wasp32", "Level5Wasp33", "Level5Wasp34", "Level5Wasp35", "Level5Wasp36", "Level5Wasp37", "Level5Wasp38", "Level5Wasp39", "Level5Wasp40", "Level5Wasp41", "Level5Wasp42", "Level5Wasp43", "Level5Wasp44", "Level5Wasp45", "Level5Wasp46", "Level5Wasp47", "Level5Wasp48", "Level5Wasp49", "Level5Wasp50", "Level5Wasp51", "Level5Wasp52", "Level5Wasp53", "Level5Wasp54", "Level5Wasp55", "Level5Wasp56", "Level5Wasp57", "Level5Wasp58", "Level5Wasp59", "Level5Wasp60", "Level5Wasp61", "Level5Wasp62", "Level5Wasp63", "Level5Wasp64", "Level5Wasp65", "Level5Wasp66", "Level5Wasp67", "Level5Wasp68", "Level5Wasp69", "Level5Wasp70", "Level5Wasp71", "Level5Wasp72", "Level5Wasp73", "Level5Wasp74", "Level5Wasp75", "Level5Wasp76", "Level5Wasp77", "Level5Wasp78", "Level5Wasp79", "Level5Wasp80", "Level5Wasp81", "Level5Wasp82", "Level5Wasp83", "Level5Wasp84", "Level5Wasp85", "Level5Wasp86", "Level5Wasp87", "Level5Wasp88", "Level5Wasp89", "Level5Wasp90", "Level5Wasp91", "Level5Wasp92", "Level5Wasp93", "Level5Wasp94", "Level5Wasp95", "Level5Wasp96", "Level5Wasp97", "Level5Wasp98", "Level5Wasp99", "Level5Wasp100", "Level5Wasp101", "Level5Wasp102", "Level5Wasp103", "Level5Wasp104", "Level5Wasp105", "Level5Wasp106", "Level5Wasp107", "Level5Wasp108", "Level5Wasp109", "Level5Wasp110", "Level5Wasp111", "Level5Wasp112", "Level5Wasp113", "Level5Wasp114", "Level5Wasp115", "Level5Wasp116", "Level5Wasp117", "Level5Wasp118", "Level5Wasp119", "Level5Wasp120", "Level5Wasp121", "Level5Wasp122", "Level5Wasp123", "Level5Wasp124", "Level5Wasp125", "Level5Wasp126", "Level5Wasp127", "Level5Wasp128", "Level6Wasp1", "Level6Wasp2", "Level6Wasp3", "Level6Wasp4", "Level6Wasp5", "Level6Wasp6", "Level6Wasp7", "Level6Wasp8", "Level6Wasp9", "Level6Wasp10", "Level6Wasp11", "Level6Wasp12", "Level6Wasp13", "Level6Wasp14", "Level6Wasp15", "Level6Wasp16", "Level6Wasp17", "Level6Wasp18", "Level6Wasp19", "Level6Wasp20", "Level6Wasp21", "Level6Wasp22", "Level6Wasp23", "Level6Wasp24", "Level6Wasp25", "Level6Wasp26", "Level6Wasp27", "Level6Wasp28", "Level6Wasp29", "Level6Wasp30", "Level6Wasp31", "Level6Wasp32", "Level6Wasp33", "Level6Wasp34", "Level6Wasp35", "Level6Wasp36", "Level6Wasp37", "Level6Wasp38", "Level6Wasp39", "Level6Wasp40", "Level6Wasp41", "Level6Wasp42", "Level6Wasp43", "Level6Wasp44", "Level6Wasp45", "Level6Wasp46", "Level6Wasp47", "Level6Wasp48", "Level6Wasp49", "Level6Wasp50", "Level6Wasp51", "Level6Wasp52", "Level6Wasp53", "Level6Wasp54", "Level6Wasp55", "Level6Wasp56", "Level6Wasp57", "Level6Wasp58", "Level6Wasp59", "Level6Wasp60", "Level6Wasp61", "Level6Wasp62", "Level6Wasp63", "Level6Wasp64", "Level6Wasp65", "Level6Wasp66", "Level6Wasp67", "Level6Wasp68", "Level6Wasp69", "Level6Wasp70", "Level6Wasp71", "Level6Wasp72", "Level6Wasp73", "Level6Wasp74", "Level6Wasp75", "Level6Wasp76", "Level6Wasp77", "Level6Wasp78", "Level6Wasp79", "Level6Wasp80", "Level6Wasp81", "Level6Wasp82", "Level6Wasp83", "Level6Wasp84", "Level6Wasp85", "Level6Wasp86", "Level6Wasp87", "Level6Wasp88", "Level6Wasp89", "Level6Wasp90", "Level6Wasp91", "Level6Wasp92", "Level6Wasp93", "Level6Wasp94", "Level6Wasp95", "Level6Wasp96", "Level6Wasp97", "Level6Wasp98", "Level6Wasp99", "Level6Wasp100", "Level6Wasp101", "Level6Wasp102", "Level6Wasp103", "Level6Wasp104", "Level6Wasp105", "Level6Wasp106", "Level6Wasp107", "Level6Wasp108", "Level6Wasp109", "Level6Wasp110", "Level6Wasp111", "Level6Wasp112", "Level6Wasp113", "Level6Wasp114", "Level6Wasp115", "Level6Wasp116", "Level6Wasp117", "Level6Wasp118", "Level6Wasp119", "Level6Wasp120", "Level6Wasp121", "Level6Wasp122", "Level6Wasp123", "Level6Wasp124", "Level6Wasp125", "Level6Wasp126", "Level6Wasp127", "Level6Wasp128", "Level7Wasp1", "Level7Wasp2", "Level7Wasp3", "Level7Wasp4", "Level7Wasp5", "Level7Wasp6", "Level7Wasp7", "Level7Wasp8", "Level7Wasp9", "Level7Wasp10", "Level7Wasp11", "Level7Wasp12", "Level7Wasp13", "Level7Wasp14", "Level7Wasp15", "Level7Wasp16", "Level7Wasp17", "Level7Wasp18", "Level7Wasp19", "Level7Wasp20", "Level7Wasp21", "Level7Wasp22", "Level7Wasp23", "Level7Wasp24", "Level7Wasp25", "Level7Wasp26", "Level7Wasp27", "Level7Wasp28", "Level7Wasp29", "Level7Wasp30", "Level7Wasp31", "Level7Wasp32", "Level7Wasp33", "Level7Wasp34", "Level7Wasp35", "Level7Wasp36", "Level7Wasp37", "Level7Wasp38", "Level7Wasp39", "Level7Wasp40", "Level7Wasp41", "Level7Wasp42", "Level7Wasp43", "Level7Wasp44", "Level7Wasp45", "Level7Wasp46", "Level7Wasp47", "Level7Wasp48", "Level7Wasp49", "Level7Wasp50", "Level7Wasp51", "Level7Wasp52", "Level7Wasp53", "Level7Wasp54", "Level7Wasp55", "Level7Wasp56", "Level7Wasp57", "Level7Wasp58", "Level7Wasp59", "Level7Wasp60", "Level7Wasp61", "Level7Wasp62", "Level7Wasp63", "Level7Wasp64", "Level7Wasp65", "Level7Wasp66", "Level7Wasp67", "Level7Wasp68", "Level7Wasp69", "Level7Wasp70", "Level7Wasp71", "Level7Wasp72", "Level7Wasp73", "Level7Wasp74", "Level7Wasp75", "Level7Wasp76", "Level7Wasp77", "Level7Wasp78", "Level7Wasp79", "Level7Wasp80", "Level7Wasp81", "Level7Wasp82", "Level7Wasp83", "Level7Wasp84", "Level7Wasp85", "Level7Wasp86", "Level7Wasp87", "Level7Wasp88", "Level7Wasp89", "Level7Wasp90", "Level7Wasp91", "Level7Wasp92", "Level7Wasp93", "Level7Wasp94", "Level7Wasp95", "Level7Wasp96", "Level7Wasp97", "Level7Wasp98", "Level7Wasp99", "Level7Wasp100", "Level7Wasp101", "Level7Wasp102", "Level7Wasp103", "Level7Wasp104", "Level7Wasp105", "Level7Wasp106", "Level7Wasp107", "Level7Wasp108", "Level7Wasp109", "Level7Wasp110", "Level7Wasp111", "Level7Wasp112", "Level7Wasp113", "Level7Wasp114", "Level7Wasp115", "Level7Wasp116", "Level7Wasp117", "Level7Wasp118", "Level7Wasp119", "Level7Wasp120", "Level7Wasp121", "Level7Wasp122", "Level7Wasp123", "Level7Wasp124", "Level7Wasp125", "Level7Wasp126", "Level7Wasp127", "Level7Wasp128"}
	for i=1,#requiredSettings do
		local requiredSetting = requiredSettings[i]
		local value = preset[requiredSetting]
		if value == nil then
			Alert("Config file \"" .. PresetFile .. "\" is missing required setting \"" .. requiredSetting .. "\".")
			os.exit()
			return
		end
		Settings[requiredSetting] = value
	end
	print("Loaded preset: " .. PresetFile)
end

if #Settings.PlayerName > 15 then
	Alert("Player Name has a limit of 15 characters.")
	os.exit()
	return
end

if Settings.Car1Name == "n/a" then
	Alert("Car 1 must be a valid car name.")
	os.exit()
	return
end

for car=1,60 do
	local carName = Settings["Car" .. car .. "Name"]
	if carName ~= "n/a" and not Exists("/GameData/art/cars/" .. carName .. ".p3d", true, false) then
		Alert("Car " .. car .. " has an invalid name.\nCould not find file: art\\cars\\" .. carName .. ".p3d")
		os.exit()
		return
	end
end

dofile(GetModPath() .. "/Resources/lib/MFKLexer.lua")

local PersistentObjectSectors = 75
local BytesPerSector = 16
local BitsPerByte = 8
local NumPersistentObjectStates = PersistentObjectSectors * BytesPerSector * BitsPerByte

local RewardsMFK = MFKLexer.Lexer:Parse(ReadFile("/GameData/scripts/missions/rewards.mfk"))
local Rewards = {}
local RewardsIndexed = {}
for BindReward in RewardsMFK:GetFunctions("BindReward") do
	local level = tonumber(BindReward.Arguments[5])
	local levelRewards = Rewards[level]
	if not levelRewards then
		levelRewards = {}
		Rewards[level] = levelRewards
	end
	local levelRewardsIndexed = RewardsIndexed[level]
	if not levelRewardsIndexed then
		levelRewardsIndexed = {}
		RewardsIndexed[level] = levelRewardsIndexed
	end
	levelRewards[BindReward.Arguments[1]] = BindReward.Arguments[3]
	if BindReward.Arguments[4] == "forsale" then
		levelRewardsIndexed[#levelRewardsIndexed + 1] = BindReward.Arguments[1]
	end
end

local Gags = {}
local Wasps = {}
for level=1,7 do
	local levelRewards = Rewards[level]
	
	local skin = Settings["Level" .. level .. "CurrentSkin"]
	if levelRewards[skin] ~= "skin" then
		Alert("Skin \"" .. skin .. "\" for level " .. level .. " not found in rewards.mfk.")
		os.exit()
		return
	end
	
	local levelGags = {}
	Gags[level] = levelGags
	
	local LevelMFK = MFKLexer.Lexer:Parse(ReadFile("/GameData/scripts/missions/level0" .. level .. "/level.mfk"))
	local CurrentGag
	local IsPersistent
	for Function in LevelMFK:GetFunctions() do
		local name = Function.Name:lower()
		if name == "cleargagbindings" then
			levelGags = {}
			Gags[level] = levelGags
		elseif name == "gagbegin" then
			CurrentGag = Function.Arguments[1]
			IsPersistent = false
		elseif name == "gagsetpersist" then
			IsPersistent = tonumber(Function.Arguments[1]) > 0
		elseif name == "gagend" and IsPersistent then
			levelGags[#levelGags + 1] = CurrentGag
		end
	end
	
	local levelWasps = {}
	Wasps[level] = levelWasps
	
	local LevelInitMFK = MFKLexer.Lexer:Parse(ReadFile("/GameData/scripts/missions/level0" .. level .. "/leveli.mfk"))
	for Function in LevelInitMFK:GetFunctions() do
		local name = Function.Name:lower()
		if name == "addspawnpoint" or name == "addspawnpointbylocatorscript" then
			levelWasps[#levelWasps + 1] = Function.Arguments[1]
			if #levelWasps >= 128 then
				break
			end
		end
	end
end

dofile(GetModPath() .. "/Resources/lib/SaveGame.lua")

local SaveData = SaveGame:new()

SaveData.SaveGameInfo.SaveDate.year = Settings.Year
SaveData.SaveGameInfo.SaveDate.month = Settings.Month
SaveData.SaveGameInfo.SaveDate.day = Settings.Day
SaveData.SaveGameInfo.SaveDate.hour = Settings.Hour
SaveData.SaveGameInfo.SaveDate.min = Settings.Minute
SaveData.SaveGameInfo.SaveDate.sec = Settings.Second
SaveData.SaveGameInfo.DisplayLevel = Settings.DisplayLevel
SaveData.SaveGameInfo.DisplayMission = Settings.DisplayMission

SaveData.InputManager.IsRumbleEnabled = Settings.IsRumbleEnabled

SaveData.CharacterSheet.PlayerName = Settings.PlayerName
SaveData.CharacterSheet.CurrentMissionInfo.Level = Settings.CurrentLevel - 1
SaveData.CharacterSheet.CurrentMissionInfo.Mission = Settings.CurrentMission - 1
SaveData.CharacterSheet.HighestMissionInfo.Level = Settings.HighestLevel - 1
SaveData.CharacterSheet.HighestMissionInfo.Mission = Settings.HighestMission - 1
SaveData.CharacterSheet.IsNavSystemEnabled = Settings.IsNavSystemEnabled
SaveData.CharacterSheet.Coins = Settings.Coins
if Settings.AllPersistentObjectStates then
	for i=1,NumPersistentObjectStates do
		SaveData.CharacterSheet.PersistentObjectStates[i] = false
	end
end
SaveData.CharacterSheet.ItchyScratchyCBGFirst = Settings.ItchyScratchyCBGFirst
SaveData.CharacterSheet.ItchyScratchyTicket = Settings.ItchyScratchyTicket

for level=1,7 do
	local levelRewards = Rewards[level]
	local levelRewardsIndexed = RewardsIndexed[level]
	local levelGags = Gags[level]
	local levelWasps = Wasps[level]
	local Level = SaveData.CharacterSheet.Levels[level]
	local LevelPrefix = "Level" .. level
	
	for card=1,7 do
		Level.Cards[card].Collected = Settings[LevelPrefix .. "Card" .. card]
		SaveData.CardGallery.Cards[(level - 1) * 8 + card] = Settings[LevelPrefix .. "Card" .. card]
	end
	
	for mission=1,8 do
		Level.Missions[mission].Completed = Settings[LevelPrefix .. "Mission" .. mission]
	end
	Level.BonusMission.Completed = Settings[LevelPrefix .. "BonusMission"]
	
	for race=1,3 do
		Level.StreetRaces[race].Completed = Settings[LevelPrefix .. "Race" .. race]
	end
	Level.GambleRace.Completed = Settings[LevelPrefix .. "GambleRace"]
	
	Level.FMVUnlocked = Settings[LevelPrefix .. "FMVUnlocked"]
	Level.CurrentSkin = Settings[LevelPrefix .. "CurrentSkin"]
	
	local gagsViewed = 0
	for gag=1,32 do
		local completed = Settings[LevelPrefix .. "Gag" .. gag]
		if completed then
			local gagName = levelGags[gag]
			if gagName then
				gagsViewed = gagsViewed + 1
				Level.GagsCompleted[gag] = true
				Level.GagMask = Level.GagMask | (1 << (gag - 1))
				print("Completed gag \"" .. gagName .. "\" in level " .. level .. ".")
			end
		end
	end
	Level.GagsViewed = gagsViewed
	
	local numCarsPurchased = 0
	local numSkinsPurchased = 0
	for reward=1,12 do
		if Settings[LevelPrefix .. "Reward" .. reward] then
			local rewardName = levelRewardsIndexed[reward]
			if rewardName then
				local rewardType = levelRewards[rewardName]
				if rewardType == "car" then
					numCarsPurchased = numCarsPurchased + 1
				elseif rewardType == "skin" then
					numSkinsPurchased = numSkinsPurchased + 1
				end
				Level.PurchasedRewards[reward] = true
				print("Unlocked " .. rewardType .. " reward \"" .. rewardName .. "\" in level " .. level .. ".")
			end
		end
	end
	Level.NumCarsPurchased = numCarsPurchased
	Level.NumSkinsPurchased = numSkinsPurchased
	
	local waspsDestroyed = 0
	for wasp=1,#levelWasps do
		local destroyed = Settings[LevelPrefix .. "Wasp" .. wasp]
		if destroyed then
			waspsDestroyed = waspsDestroyed + 1
			local index = NumPersistentObjectStates + (level - 1) * BytesPerSector * BitsPerByte + wasp
			SaveData.CharacterSheet.PersistentObjectStates[index] = false
			print("Destroyed wasp \"" .. levelWasps[wasp] .. "\" (" .. index .. ") in level " .. level .. ".")
		end
	end
	Level.WaspsDestroyed = waspsDestroyed
end

local carCounter = 0
for car=1,60 do
	local carName = Settings["Car" .. car .. "Name"]
	if carName ~= "n/a" then
		local Car = SaveData.CharacterSheet.Cars.Cars[car]
		Car.Name = carName
		Car.CurrentHealth = Settings["Car" .. car .. "Health"] / 100
		carCounter = carCounter + 1
	end
end
SaveData.CharacterSheet.Cars.Counter = carCounter

SaveData.SoundSettings.MusicVolume = Settings.MusicVolume / 100
SaveData.SoundSettings.SFXVolume = Settings.SFXVolume / 100
SaveData.SoundSettings.CarVolume = Settings.CarVolume / 100
SaveData.SoundSettings.DialogVolume = Settings.DialogVolume / 100
SaveData.SoundSettings.IsSurround = Settings.IsSurround

SaveData.TutorialManager.EnableTutorialEvents = Settings.EnableTutorialEvents

SaveData.GUISystem.IsRadarEnabled = Settings.IsRadarEnabled

CustomSave = tostring(SaveData)