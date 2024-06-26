if IsWriting() then
	return
end

local Path = GetPath()
local GamePath = "/GameData/" .. Path

print("Loading save: " .. Path)

if GetSetting("NewSaves") then
	local SaveData = SaveGame:new()

	SaveData.SaveGameInfo.SaveDate.hour = 69

	for i=1,7 do
		local Level = SaveData.CharacterSheet.Levels[i]
		for j=1,8 do
			local Mission = Level.Missions[j]
			print("L" .. i .. "M" .. (i == 1 and j - 1 or j), Mission.Completed)
		end
	end

	Output(tostring(SaveData))
else
	if not Exists(GamePath, true, false) then
		return
	end

	local SaveData = SaveGame:new(ReadFile(GamePath))

	SaveData.SaveGameInfo.SaveDate.hour = 69

	for i=1,7 do
		local Level = SaveData.CharacterSheet.Levels[i]
		for j=1,8 do
			local Mission = Level.Missions[j]
			print("L" .. i .. "M" .. (i == 1 and j - 1 or j), Mission.Completed)
		end
	end

	Output(tostring(SaveData))
end