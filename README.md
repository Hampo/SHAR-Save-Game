# SHAR-Save-Game
 A library for handling SHAR save games

## Overall File Structure
A valid save file starts with a magic number and is composed of various sections, each corresponding to a specific part of the game state. The expected size for a vanilla save file is 7194 bytes.

### Save File Header
- **Magic Number** (`ushort`, 2 bytes): Must be `1978`.
- **SaveGameInfo**: General information about the save.

### Sections
1. **InputManager**
2. **CharacterSheet**
3. **SoundSettings**
4. **PlayerSuperCamCentrals** (Array)
5. **TutorialManager**
6. **GUISystem**
7. **CardGallery**
8. **CustomSaveData**

## Save File Components

### SaveGameInfo
Contains general information about the save file.
- **SaveDate** (`8 bytes`)
  - **Year** (`ushort`, 2 bytes)
  - **Month** (`byte`, 1 byte)
  - **Day** (`byte`, 1 byte)
  - **Hour** (`byte`, 1 byte)
  - **Minute** (`byte`, 1 byte)
  - **Second** (`byte`, 1 byte)
  - **Padding** (`byte`, 1 byte): Reserved byte for alignment.
- **DisplayLevel** (`byte`, 1 byte)
- **DisplayMission** (`byte`, 1 byte)
- **FileSize** (`uint`, 4 bytes)

### InputManager
Handles input settings.
- **IsRumbleEnabled** (`bool`, 1 byte)

### CharacterSheet
Represents the player's progress and state.
- **PlayerName** (`string`, 16 bytes): Null-terminated string of 16 bytes.
- **Levels** (`Level[7]`, 4340 bytes): An array of 7 levels, each containing specific progress data.
- **CurrentMissionInfo** (`CurrentMission`, 8 bytes)
- **HighestMissionInfo** (`CurrentMission`, 8 bytes)
- **IsNavSystemEnabled** (`bool`, 1 byte)
- **Padding** (`byte[3]`): Reserved bytes for alignment.
- **Coins** (`int`, 4 bytes)
- **Cars** (`CarInventory`, 1444 bytes)
- **PersistentObjectStates** (`byte[1312]`): States of persistent/breakable objects in the game.
- **States** (`byte[1]`): Additional states data.
- **Padding** (`byte[3]`): Reserved bytes for alignment.

#### Level
Represents a specific level's data.
- **Cards** (`Card[7]`, 119 bytes): An array of 7 collectible cards.
- **Padding** (`byte`, 1 byte): Reserved byte for alignment.
- **Missions** (`MissionRecord[7]`, 224 bytes): An array of 7 missions.
- **StreetRaces** (`MissionRecord[3]`, 96 bytes): An array of 3 street races.
- **BonusMission** (`MissionRecord`, 32 bytes): The bonus mission.
- **GambleRace** (`MissionRecord`, 32 bytes): The gamble race.
- **FMVUnlocked** (`bool`, 1 byte)
- **Padding** (`byte[3]`): Reserved bytes for alignment.
- **NumCarsPurchased** (`int`, 4 bytes)
- **NumSkinsPurchased** (`int`, 4 bytes)
- **WaspsDestroyed** (`int`, 4 bytes)
- **CurrentSkin** (`string`, 16 bytes): Null-terminated string of 16 bytes.
- **GagsViewed** (`int`, 4 bytes)
- **GagMask** (`uint`, 4 bytes): A bitmask representing the gags.
- **GagsCompleted** (`bool[32]`): An array of 32 booleans.
- **PurchasedRewards** (`bool[12]`): An array of 12 booleans.

#### Card
Represents a collectible card.
- **Name** (`string`, 16 bytes): Null-terminated string of 16 bytes.
- **Collected** (`bool`, 1 byte)

#### MissionRecord
Represents the record for a mission.
- **Name** (`string`, 16 bytes): Null-terminated string of 16 bytes.
- **Completed** (`bool`, 1 byte)
- **BonusObjective** (`bool`, 1 byte)
- **Padding** (`byte[2]`): Reserved bytes for alignment.
- **NumAttempts** (`uint`, 4 bytes)
- **SkippedMission** (`bool`, 1 byte)
- **Padding** (`byte[3]`): Reserved bytes for alignment.
- **BestTime** (`int`, 4 bytes)

#### CurrentMission
Represents the current mission's progress.
- **Level** (`uint`, 4 bytes)
- **Mission** (`uint`, 4 bytes)

#### CarInventory
Represents the player's car inventory.
- **Cars** (`Car[]`, 1440 bytes): An array of cars.
- **Counter** (`int`, 4 bytes): The number of cars in the inventory.

##### Car
Represents a car.
- **Name** (`string`, 16 bytes): Null-terminated string of 16 bytes.
- **CurrentHealth** (`float`, 4 bytes)
- **MaxHealth** (`float`, 4 bytes)

### SoundSettings
Stores volume and audio settings.
- **MusicVolume** (`float`, 4 bytes)
- **SFXVolume** (`float`, 4 bytes)
- **CarVolume** (`float`, 4 bytes)
- **DialogVolume** (`float`, 4 bytes)
- **IsSurround** (`bool`, 1 byte)
- **Padding** (`byte[3]`): Reserved bytes for alignment.

### SuperCamCentral
Handles camera settings.
- **Bitmask** (`byte`)
  - **JumpCamsEnabled** (`bool`, `Bitmask & 0x01`)
  - **IsInvertedCameraEnabled** (`bool`, `Bitmask & 0x02`)
  - **PreferredFollowCam** (`PreferredFollowCams`, `Bitmask  >> 2`)

#### PreferredFollowCams
- Default
- Follow
- Near Follow
- Far Follow
- Bumper
- Chase
- Debug
- Wreckless
- Walker
- Comedy
- Kull
- Tracker
- Spline
- Rail
- Conversation
- Static
- Burnout
- Reverse
- Snapshot
- Surveillance
- Animated
- Relative Animated
- Super Sprint
- First Person
- On Foot
- PC

### TutorialManager
Manages tutorial events.
- **EnableTutorialEvents** (`bool`, 1 byte)
- **TutorialsSeen** (`int`, 4 bytes)

### GUISystem
Handles GUI settings.
- **IsRadarEnabled** (`bool`, 1 byte)

### CardGallery
Represents the collectible card gallery.
- **Data** (`byte[7]`): The data representing the card gallery.
  - Each bit lines up with a card ID. `1` if collected, `0` if not.

### CustomSaveData
Stores any additional custom data.
- **Data** (`byte[]`): The custom data.

## Binary Structure

### Reading a Save File
1. **Magic Number**: Read `ushort` (2 bytes).
2. **SaveGameInfo**: Read `SaveGameInfo` (14 bytes).
3. **InputManager**: Read `InputManager` (1 byte).
4. **CharacterSheet**: Read `CharacterSheet` (7140 bytes).
5. **SoundSettings**: Read `SoundSettings` (20 bytes).
6. **PlayerSuperCamCentrals**: Read 4 `SuperCamCentral`s (4 bytes).
7. **TutorialManager**: Read `TutorialManager` (5 bytes).
8. **GUISystem**: Read `GUISystem` (1 byte).
9. **CardGallery**: Read `CardGallery` (7 bytes).
10. **CustomSaveData**: Read remaining bytes as `CustomSaveData`.

### Writing a Save File
1. **Magic Number**: Write `ushort` (2 bytes).
2. **SaveGameInfo**: Write `SaveGameInfo` (14 bytes).
3. **InputManager**: Write `InputManager` (1 byte).
4. **CharacterSheet**: Write `CharacterSheet` (7140 bytes).
5. **SoundSettings**: Write `SoundSettings` (20 bytes).
6. **PlayerSuperCamCentrals**: Write 4 `SuperCamCentral`s (4 bytes).
7. **TutorialManager**: Write `TutorialManager` (5 bytes).
8. **GUISystem**: Write `GUISystem` (1 byte).
9. **CardGallery**: Write `CardGallery` (7 bytes).
10. **CustomSaveData**: Write `CustomSaveData` (remaining bytes).