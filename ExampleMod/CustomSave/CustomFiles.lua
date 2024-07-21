Settings = GetSettings()
SaveSlot = Settings.SaveSlot

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
	
	local LevelInitMFK = MFKLexer.Lexer:Parse(ReadFile("/GameData/scripts/missions/level0" .. level .. "/leveli.mfk"))
	local wasps = 0
	for Function in LevelInitMFK:GetFunctions() do
		local name = Function.Name:lower()
		if name == "addspawnpoint" or name == "addspawnpointbylocatorscript" then
			wasps = wasps + 1
		end
	end
	Wasps[level] = wasps
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
	for i=1,#SaveData.CharacterSheet.PersistentObjectStates do
		SaveData.CharacterSheet.PersistentObjectStates[i] = 0
	end
end
SaveData.CharacterSheet.ItchyScratchyCBGFirst = Settings.ItchyScratchyCBGFirst
SaveData.CharacterSheet.ItchyScratchyTicket = Settings.ItchyScratchyTicket

for level=1,7 do
	local levelRewards = Rewards[level]
	local levelRewardsIndexed = RewardsIndexed[level]
	local levelGags = Gags[level]
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
	Level.WaspsDestroyed = Settings.AllPersistentObjectStates and Wasps[level] or 0
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