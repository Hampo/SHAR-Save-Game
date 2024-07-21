local assert = assert
local setmetatable = setmetatable
local type = type
local tostring = tostring

local math_floor = math.floor

local string_pack = string.pack
local string_rep = string.rep
local string_unpack = string.unpack

local table_concat = table.concat
local table_unpack = table.unpack

SaveGame = SaveGame or {}
assert(type(SaveGame) == "table", "Global SaveGame must be a table.")

SaveGameInfo = SaveGameInfo or {}
assert(type(SaveGameInfo) == "table", "Global SaveGameInfo must be a table.")

InputManager = InputManager or {}
assert(type(InputManager) == "table", "Global InputManager must be a table.")

CharacterSheet = CharacterSheet or {}
assert(type(CharacterSheet) == "table", "Global CharacterSheet must be a table.")

SoundSettings = SoundSettings or {}
assert(type(SoundSettings) == "table", "Global SoundSettings must be a table.")

SuperCamCentral = SuperCamCentral or {}
assert(type(SuperCamCentral) == "table", "Global SuperCamCentral must be a table.")

TutorialManager = TutorialManager or {}
assert(type(TutorialManager) == "table", "Global TutorialManager must be a table.")

GUISystem = GUISystem or {}
assert(type(GUISystem) == "table", "Global GUISystem must be a table.")

CardGallery = CardGallery or {}
assert(type(CardGallery) == "table", "Global CardGallery must be a table.")

CustomSaveData = CustomSaveData or {}
assert(type(CustomSaveData) == "table", "Global CustomSaveData must be a table.")

SaveGame.MagicNumber = 1978
SaveGame.VanillaFileSize = 7194

local function NullTerminateString(str)
	if str == nil then return nil end
	local strLen = str:len()
	if strLen == 0 then return str end
	local null = str:find("\0", 1, true)
	if null == nil then return str end
	return str:sub(1, null-1)
end

-- Start SaveGame
function SaveGame:new(data)
	self.__index = self
	if data == nil then
		return setmetatable({
			SaveGameInfo = SaveGameInfo:new(),
			InputManager = InputManager:new(),
			CharacterSheet = CharacterSheet:new(),
			SoundSettings = SoundSettings:new(),
			SuperCamCentrals = {
				SuperCamCentral:new(),
				SuperCamCentral:new(),
				SuperCamCentral:new(),
				SuperCamCentral:new(),
			},
			TutorialManager = TutorialManager:new(),
			GUISystem = GUISystem:new(),
			CardGallery = CardGallery:new(),
			CustomSaveData = CustomSaveData:new(),
		}, self)
	end
	
	assert(type(data) == "string", "Input data must be a string.")
	assert(#data >= SaveGame.VanillaFileSize, "Input data must be at least " .. SaveGame.VanillaFileSize .. " bytes.")
	
	local magicNumber, pos = string_unpack("<H", data)
	assert(magicNumber == SaveGame.MagicNumber, "Magic number does not match expected.")
	
	local saveData = {}
	
	saveData.SaveGameInfo, pos = SaveGameInfo:new(data, pos)
	saveData.InputManager, pos = InputManager:new(data, pos)
	saveData.CharacterSheet, pos = CharacterSheet:new(data, pos)
	saveData.SoundSettings, pos = SoundSettings:new(data, pos)
	self.SuperCamCentrals = {}
	for i=1,4 do
		self.SuperCamCentrals[i], pos = SuperCamCentral:new(data, pos)
	end
	saveData.TutorialManager, pos = TutorialManager:new(data, pos)
	saveData.GUISystem, pos = GUISystem:new(data, pos)
	saveData.CardGallery, pos = CardGallery:new(data, pos)
	saveData.CustomSaveData, pos = CustomSaveData:new(data, pos)
	
	return setmetatable(saveData, self)
end

function SaveGame:__tostring()
	local data = {}
	data[1] = string.pack("<H", SaveGame.MagicNumber)
	data[2] = tostring(self.SaveGameInfo)
	data[3] = tostring(self.InputManager)
	data[4] = tostring(self.CharacterSheet)
	data[5] = tostring(self.SoundSettings)
	for i = 1, 4 do
		data[5 + i] = tostring(self.SuperCamCentrals[i])
	end
	data[10] = tostring(self.TutorialManager)
	data[11] = tostring(self.GUISystem)
	data[12] = tostring(self.CardGallery)
	data[13] = tostring(self.CustomSaveData)
	return table_concat(data)
end
-- End SaveGame

-- Start SaveGameInfo
function SaveGameInfo:new(data, pos)
	self.__index = self
	if data == nil then
		return setmetatable({
			SaveDate = os.date("*t"),
			DisplayLevel = 1,
			DisplayMission = 0,
			FileSize = SaveGame.VanillaFileSize,
		}, self)
	end
	
	assert(type(data) == "string", "Input data must be a string.")
	assert(#data + 1 >= pos + 14, "Not enough input data.")
	
	pos = pos or 1
	
	local saveGameInfo = {}
	
	saveGameInfo.SaveDate = {}
	saveGameInfo.SaveDate.year, saveGameInfo.SaveDate.month, saveGameInfo.SaveDate.day, saveGameInfo.SaveDate.hour, saveGameInfo.SaveDate.min, saveGameInfo.SaveDate.sec, saveGameInfo.DisplayLevel, saveGameInfo.DisplayMission, saveGameInfo.FileSize, pos = string_unpack("HBBBBBxBBI", data, pos)
	
	return setmetatable(saveGameInfo, self), pos
end

function SaveGameInfo:__tostring()
	return string_pack("HBBBBBxBBI", self.SaveDate.year, self.SaveDate.month, self.SaveDate.day, self.SaveDate.hour, self.SaveDate.min, self.SaveDate.sec, self.DisplayLevel, self.DisplayMission, self.FileSize)
end
-- End SaveGameInfo

-- Start Input Manager
function InputManager:new(data, pos)
	self.__index = self
	if data == nil then
		return setmetatable({
			IsRumbleEnabled = true,
		}, self)
	end
	
	assert(type(data) == "string", "Input data must be a string.")
	assert(#data + 1 >= pos + 1, "Not enough input data.")
	
	pos = pos or 1
	
	local inputManager = {}
	
	inputManager.IsRumbleEnabled, pos = string_unpack("B", data, pos)
	inputManager.IsRumbleEnabled = inputManager.IsRumbleEnabled ~= 0
	
	return setmetatable(inputManager, self), pos
end

function InputManager:__tostring()
	return string_pack("B", self.IsRumbleEnabled and 255 or 0)
end
-- End Input Manager

-- Start Character Sheet
function CharacterSheet:new(data, pos)
	self.__index = self
	if data == nil then
		data = {}
		data.PlayerName = "Player1"
		data.Levels = {}
		for i=1,7 do
			data.Levels[i] = CharacterSheet.Level:new()
		end
		data.CurrentMissionInfo = CharacterSheet.CurrentMission:new()
		data.HighestMissionInfo = CharacterSheet.CurrentMission:new()
		data.IsNavSystemEnabled = true
		data.Coins = 0
		data.Cars = CharacterSheet.CarInventory:new()
		data.PersistentObjectStates = {}
		for i=1,1312 do
			data.PersistentObjectStates[i] = 255
		end
		data.ItchyScratchyCBGFirst = false
		data.ItchyScratchyTicket = false
		return setmetatable(data, self)
	end
	
	assert(type(data) == "string", "Input data must be a string.")
	assert(#data + 1 >= pos + 7140, "Not enough input data.")
	
	pos = pos or 1
	
	local characterSheet = {}
	
	characterSheet.PlayerName, pos = string_unpack("c16", data, pos)
	characterSheet.PlayerName = NullTerminateString(characterSheet.PlayerName)
	characterSheet.Levels = {}
	for i=1,7 do
		characterSheet.Levels[i], pos = CharacterSheet.Level:new(data, pos)
	end
	characterSheet.CurrentMissionInfo, pos = CharacterSheet.CurrentMission:new(data, pos)
	characterSheet.HighestMissionInfo, pos = CharacterSheet.CurrentMission:new(data, pos)
	characterSheet.IsNavSystemEnabled, characterSheet.Coins, pos = string_unpack("Bxxxi", data, pos)
	characterSheet.Cars, pos = CharacterSheet.CarInventory:new(data, pos)
	characterSheet.PersistentObjectStates = {string_unpack(string_rep("B", 1312), data, pos)}
	pos = characterSheet.PersistentObjectStates[#characterSheet.PersistentObjectStates]
	characterSheet.PersistentObjectStates[#characterSheet.PersistentObjectStates] = nil
	local state
	state, pos = string_unpack("Bxxx", data, pos)
	characterSheet.ItchyScratchyCBGFirst = (state & 0x01) > 0
	characterSheet.ItchyScratchyTicket = (state & 0x02) > 0
	
	return setmetatable(characterSheet, self), pos
end

function CharacterSheet:__tostring()
	local data = {}
	data[1] = string_pack("c16", self.PlayerName)
	for i=1,7 do
		data[1 + i] = tostring(self.Levels[i])
	end
	data[9] = tostring(self.CurrentMissionInfo)
	data[10] = tostring(self.HighestMissionInfo)
	data[11] = string_pack("Bxxxi", self.IsNavSystemEnabled and 1 or 0, self.Coins)
	data[12] = tostring(self.Cars)
	data[13] = string_pack(string_rep("B", 1312), table_unpack(self.PersistentObjectStates))
	local state = 0
	if self.ItchyScratchyCBGFirst then
		state = state | 0x01
	end
	if self.ItchyScratchyTicket then
		state = state | 0x02
	end
	data[14] = string_pack("Bxxx", state)
	return table_concat(data)
end

CharacterSheet.Level = {}
function CharacterSheet.Level:new(data, pos)
	self.__index = self
	if data == nil then
		data = {}
		data.Cards = {}
		for i=1,7 do
			data.Cards[i] = CharacterSheet.Level.Card:new()
		end
		data.Missions = {}
		for i=1,8 do
			data.Missions[i] = CharacterSheet.Level.MissionRecord:new()
		end
		data.StreetRaces = {}
		for i=1,3 do
			data.StreetRaces[i] = CharacterSheet.Level.MissionRecord:new()
		end
		data.BonusMission = CharacterSheet.Level.MissionRecord:new()
		data.GambleRace = CharacterSheet.Level.MissionRecord:new()
		data.FMVUnlocked = false
		data.NumCarsPurchased = 0
		data.NumSkinsPurchased = 0
		data.WaspsDestroyed = 0
		data.CurrentSkin = "NULL"
		data.GagsViewed = 0
		data.GagMask = 0
		data.GagsCompleted = {}
		for i=1,32 do
			data.GagsCompleted[i] = false
		end
		data.PurchasedRewards = {}
		for i=1,12 do
			data.PurchasedRewards[i] = false
		end
		return setmetatable(data, self)
	end
	
	assert(type(data) == "string", "Input data must be a string.")
	assert(#data + 1 >= pos + 8, "Not enough input data.")
	
	pos = pos or 1
	
	local level = {}
	
	level.Cards = {}
	for i=1,7 do
		level.Cards[i], pos = CharacterSheet.Level.Card:new(data, pos)
	end
	pos = pos + 1 -- Padding
	level.Missions = {}
	for i=1,8 do
		level.Missions[i], pos = CharacterSheet.Level.MissionRecord:new(data, pos)
	end
	level.StreetRaces = {}
	for i=1,3 do
		level.StreetRaces[i], pos = CharacterSheet.Level.MissionRecord:new(data, pos)
	end
	level.BonusMission, pos = CharacterSheet.Level.MissionRecord:new(data, pos)
	level.GambleRace, pos = CharacterSheet.Level.MissionRecord:new(data, pos)
	level.FMVUnlocked, level.NumCarsPurchased, level.NumSkinsPurchased, level.WaspsDestroyed, level.CurrentSkin, level.GagsViewed, level.GagMask, pos = string_unpack("Bxxxiiic16iI", data, pos)
	level.FMVUnlocked = level.FMVUnlocked ~= 0
	level.CurrentSkin = NullTerminateString(level.CurrentSkin)
	level.GagsCompleted = {}
	for i=1,32 do
		level.GagsCompleted[i], pos = string_unpack("B", data, pos)
		level.GagsCompleted[i] = level.GagsCompleted[i] ~= 0
	end
	level.PurchasedRewards = {}
	for i=1,12 do
		level.PurchasedRewards[i], pos = string_unpack("B", data, pos)
		level.PurchasedRewards[i] = level.PurchasedRewards[i] ~= 0
	end
	
	return setmetatable(level, self), pos
end

function CharacterSheet.Level:__tostring()
	local data = {}
	for i=1,7 do
		data[i] = tostring(self.Cards[i])
	end
	data[8] = string_pack("x")
	for i=1,8 do
		data[8 + i] = tostring(self.Missions[i])
	end
	for i=1,3 do
		data[16 + i] = tostring(self.StreetRaces[i])
	end
	data[20] = tostring(self.BonusMission)
	data[21] = tostring(self.GambleRace)
	data[22] = string_pack("Bxxxiiic16iI", self.FMVUnlocked and 1 or 0, self.NumCarsPurchased, self.NumSkinsPurchased, self.WaspsDestroyed, self.CurrentSkin, self.GagsViewed, self.GagMask)
	for i=1,32 do
		data[22 + i] = string_pack("B", self.GagsCompleted[i] and 1 or 0)
	end
	for i=1,12 do
		data[54 + i] = string_pack("B", self.PurchasedRewards[i] and 1 or 0)
	end
	return table_concat(data)
end

CharacterSheet.Level.Card = {}
function CharacterSheet.Level.Card:new(data, pos)
	self.__index = self
	if data == nil then
		return setmetatable({
			Name = "Cardx",
			Collected = false,
		}, self)
	end
	
	assert(type(data) == "string", "Input data must be a string.")
	assert(#data + 1 >= pos + 17, "Not enough input data.")
	
	pos = pos or 1
	
	local card = {}
	
	card.Name, card.Collected, pos = string_unpack("c16B", data, pos)
	card.Name = NullTerminateString(card.Name)
	card.Collected = card.Collected ~= 0
	
	return setmetatable(card, self), pos
end

function CharacterSheet.Level.Card:__tostring()
	return string_pack("c16B", self.Name, self.Collected and 1 or 0)
end

CharacterSheet.Level.MissionRecord = {}
function CharacterSheet.Level.MissionRecord:new(data, pos)
	self.__index = self
	if data == nil then
		return setmetatable({
			Name = "NULL",
			Completed = false,
			BonusObjective = false,
			NumAttempts = 0,
			SkippedMission = false,
			BestTime = -1,
		}, self)
	end
	
	assert(type(data) == "string", "Input data must be a string.")
	assert(#data + 1 >= pos + 32, "Not enough input data.")
	
	pos = pos or 1
	
	local missionRecord = {}
	
	missionRecord.Name, missionRecord.Completed, missionRecord.BonusObjective, missionRecord.NumAttempts, missionRecord.SkippedMission, missionRecord.BestTime, pos = string_unpack("c16BBxxIBxxxi", data, pos)
	missionRecord.Name = NullTerminateString(missionRecord.Name)
	missionRecord.Completed = missionRecord.Completed ~= 0
	missionRecord.BonusObjective = missionRecord.BonusObjective ~= 0
	missionRecord.SkippedMission = missionRecord.SkippedMission ~= 0
	
	return setmetatable(missionRecord, self), pos
end

function CharacterSheet.Level.MissionRecord:__tostring()
	return string_pack("c16BBxxIBxxxi", self.Name, self.Completed and 1 or 0, self.BonusObjective and 1 or 0, self.NumAttempts, self.SkippedMission and 1 or 0, self.BestTime)
end

CharacterSheet.CurrentMission = {}
function CharacterSheet.CurrentMission:new(data, pos)
	self.__index = self
	if data == nil then
		return setmetatable({
			Level = 0,
			Mission = 0,
		}, self)
	end
	
	assert(type(data) == "string", "Input data must be a string.")
	assert(#data + 1 >= pos + 8, "Not enough input data.")
	
	pos = pos or 1
	
	local currentMission = {}
	
	currentMission.Level, currentMission.Mission, pos = string_unpack("II", data, pos)
	
	return setmetatable(currentMission, self), pos
end

function CharacterSheet.CurrentMission:__tostring()
	return string_pack("II", self.Level, self.Mission)
end

CharacterSheet.CarInventory = {}
function CharacterSheet.CarInventory:new(data, pos)
	self.__index = self
	if data == nil then
		data = {}
		data.Cars = {}
		for i=1,60 do
			data.Cars[i] = CharacterSheet.CarInventory.Car:new()
		end
		data.Counter = 0
		return setmetatable(data, self)
	end
	
	assert(type(data) == "string", "Input data must be a string.")
	assert(#data + 1 >= pos + 1444, "Not enough input data.")
	
	pos = pos or 1
	
	local carInventory = {}
	carInventory.Cars = {}
	for i=1,60 do
		carInventory.Cars[i], pos = CharacterSheet.CarInventory.Car:new(data, pos)
	end
	carInventory.Counter, pos = string_unpack("i", data, pos)
	
	return setmetatable(carInventory, self), pos
end

function CharacterSheet.CarInventory:__tostring()
	local data = {}
	for i=1,60 do
		data[i] = tostring(self.Cars[i])
	end
	data[61] = string_pack("i", self.Counter)
	return table_concat(data)
end

CharacterSheet.CarInventory.Car = {}
function CharacterSheet.CarInventory.Car:new(data, pos)
	self.__index = self
	if data == nil then
		return setmetatable({
			Name = "n/a",
			CurrentHealth = -1,
			MaxHealth = -1,
		}, self)
	end
	
	assert(type(data) == "string", "Input data must be a string.")
	assert(#data + 1 >= pos + 24, "Not enough input data.")
	
	pos = pos or 1
	
	local car = {}
	
	car.Name, car.CurrentHealth, car.MaxHealth, pos = string_unpack("c16ff", data, pos)
	car.Name = NullTerminateString(car.Name)
	
	return setmetatable(car, self), pos
end

function CharacterSheet.CarInventory.Car:__tostring()
	return string_pack("c16ff", self.Name, self.CurrentHealth, self.MaxHealth)
end
-- End Character Sheet

-- Start Sound Settings
function SoundSettings:new(data, pos)
	self.__index = self
	if data == nil then
		return setmetatable({
			MusicVolume = 1,
			SFXVolume = 1,
			CarVolume = 1,
			DialogVolume = 1,
			IsSurround = false,
		}, self)
	end
	
	assert(type(data) == "string", "Input data must be a string.")
	assert(#data + 1 >= pos + 20, "Not enough input data.")
	
	pos = pos or 1
	
	local soundSettings = {}
	
	soundSettings.MusicVolume, soundSettings.SFXVolume, soundSettings.CarVolume, soundSettings.DialogVolume, soundSettings.IsSurround, pos = string_unpack("ffffBxxx", data, pos)
	soundSettings.IsSurround = soundSettings.IsSurround ~= 0
	
	return setmetatable(soundSettings, self), pos
end

function SoundSettings:__tostring()
	return string_pack("ffffBxxx", self.MusicVolume, self.SFXVolume, self.CarVolume, self.DialogVolume, self.IsSurround and 1 or 0)
end
-- End Sound Settings

-- Start Super Cam Central
function SuperCamCentral:new(data, pos)
	self.__index = self
	if data == nil then
		return setmetatable({
			JumpCamsEnabled = true,
			IsInvertedCameraEnabled = true,
			PreferredFollowCam = 3,
		}, self)
	end
	
	assert(type(data) == "string", "Input data must be a string.")
	assert(#data + 1 >= pos + 1, "Not enough input data.")
	
	pos = pos or 1
	
	local superCamCentral = {}
	
	local bitmask
	bitmask, pos = string_unpack("B", data, pos)
	
	superCamCentral.JumpCamsEnabled = (bitmask & 0x01) > 0
	superCamCentral.IsInvertedCameraEnabled = (bitmask & 0x02) > 0
	superCamCentral.PreferredFollowCam = bitmask >> 2
	if superCamCentral.PreferredFollowCam == 0 then
		superCamCentral.PreferredFollowCam = 3
	end
	
	return setmetatable(superCamCentral, self), pos
end

function SuperCamCentral:__tostring()
	local bitmask = 0
	
	if self.JumpCamsEnabled then
		bitmask = bitmask | 0x01
	end
	
	if self.IsInvertedCameraEnabled then
		bitmask = bitmask | 0x02
	end
	
	assert(self.PreferredFollowCam & 0xC0 == 0, "Not enough bits to save preferred follow cam")
	
	bitmask = bitmask | (self.PreferredFollowCam << 2)
	
	return string_pack("B", bitmask)
end
-- End Super Cam Central

-- Start Tutorial Manager
function TutorialManager:new(data, pos)
	self.__index = self
	if data == nil then
		return setmetatable({
			EnableTutorialEvents = true,
			TutorialsSeen = 0,
		}, self)
	end
	
	assert(type(data) == "string", "Input data must be a string.")
	assert(#data + 1 >= pos + 5, "Not enough input data.")
	
	pos = pos or 1
	
	local tutorialManager = {}
	
	tutorialManager.EnableTutorialEvents, tutorialManager.TutorialsSeen, pos = string_unpack("Bi", data, pos)
	tutorialManager.EnableTutorialEvents = tutorialManager.EnableTutorialEvents ~= 0
	
	return setmetatable(tutorialManager, self), pos
end

function TutorialManager:__tostring()
	return string_pack("Bi", self.EnableTutorialEvents and 1 or 0, self.TutorialsSeen)
end
-- End Tutorial Manager

-- Start GUI System
function GUISystem:new(data, pos)
	self.__index = self
	if data == nil then
		return setmetatable({
			IsRadarEnabled = false,
		}, self)
	end
	
	assert(type(data) == "string", "Input data must be a string.")
	assert(#data + 1 >= pos + 1, "Not enough input data.")
	
	pos = pos or 1
	
	local guiSystem = {}
	
	guiSystem.IsRadarEnabled, pos = string_unpack("B", data, pos)
	guiSystem.IsRadarEnabled = guiSystem.IsRadarEnabled ~= 0
	
	return setmetatable(guiSystem, self), pos
end

function GUISystem:__tostring()
	return string_pack("B", self.IsRadarEnabled and 1 or 0)
end
-- End GUI System

-- Start Card Gallery
local ByteCount = 7
local BitsPerByte = 8
function CardGallery:new(data, pos)	
	self.__index = self
	if data == nil then
		local Cards = {}
		for i=1,ByteCount*BitsPerByte do
			Cards[i] = false
		end
		return setmetatable({
			Cards = Cards,
		}, self)
	end
	
	assert(type(data) == "string", "Input data must be a string.")
	assert(#data + 1 >= pos + 7, "Not enough input data.")
	
	pos = pos or 1
	
	local cardGallery = {}
	
	local cards = {}
	cardGallery.Cards = cards
	
	local bytes = {string_unpack("BBBBBBB", data, pos)}
	pos = bytes[8]
	bytes[8] = nil
	for i=1,ByteCount*BitsPerByte do
		local index = math_floor((i - 1) / BitsPerByte)
		cards[i] = (bytes[index + 1] & (1 << (i - 1) % BitsPerByte)) > 0
	end
	
	return setmetatable(cardGallery, self), pos
end

function CardGallery:__tostring()
	local bytes = {}
	for i=1,ByteCount do
		bytes[i] = 0
	end
	
	for i=1,#self.Cards do
		if self.Cards[i] then
			local index = math_floor((i - 1) / BitsPerByte)
			bytes[index + 1] = bytes[index + 1] | (1 << (i - 1) % BitsPerByte)
		end
	end
	
	return string_pack("BBBBBBB", table_unpack(bytes))
end
-- End Card Gallery

-- TODO: Actual handling
-- Start Custom Save Data
function CustomSaveData:new(data, pos)
	self.__index = self
	if data == nil then
		return setmetatable({
			Data = "",
		}, self)
	end
	
	assert(type(data) == "string", "Input data must be a string.")
	
	pos = pos or 1
	
	local customSaveData = {}
	
	if pos > #data then
		customSaveData.Data = ""
	else
		customSaveData.Data = data:sub(pos)
	end
	
	return setmetatable(customSaveData, self), pos
end

function CustomSaveData:__tostring()
	return self.Data
end
-- End Custom Save Data