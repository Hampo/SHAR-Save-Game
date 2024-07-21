local Path = GetPath()
if Path ~= SaveSlot then
	return
end

print("Handling save: " .. Path)

if IsWriting() then
	print("Preventing writing")
	Redirect(nil)
	return
end

print("Outputting custom save")
Output(CustomSave)