using System;
using System.IO;

public class SaveGame
{
	public const ushort MagicNumber = 1978;
	public const uint VanillaFileSize = 7194;

	public SaveGameInfo SaveGameInfo { get; }
	public InputManager InputManager { get; }
	public CharacterSheet CharacterSheet { get; }
	public SoundSettings SoundSettings { get; }
	public SuperCamCentral[] PlayerSuperCamCentrals { get; } = new SuperCamCentral[4];
	public TutorialManager TutorialManager { get; }
	public GUISystem GUISystem { get; }
	public CardGallery CardGallery { get; }
	public CustomSaveData CustomSaveData { get; }

	public SaveGame() {
		SaveGameInfo = new SaveGameInfo();
		InputManager = new InputManager();
		CharacterSheet = new CharacterSheet();
		SoundSettings = new SoundSettings();
		for (int i = 0; i < PlayerSuperCamCentrals.Length; i++)
			PlayerSuperCamCentrals[i] = new SuperCamCentral();
		TutorialManager = new TutorialManager();
		GUISystem = new GUISystem();
		CardGallery = new CardGallery();
		CustomSaveData = new CustomSaveData();
	}

	public SaveGame(BinaryReader br)
	{
		if (br.BaseStream.Length < VanillaFileSize)
			throw new InvalidDataException("File is not long enough to be a SHAR save game.");

		ushort magicNumber = br.ReadUInt16();
		if (magicNumber != MagicNumber)
			throw new InvalidDataException($"Magic Number {magicNumber} does not match expected value {MagicNumber}.");

		SaveGameInfo = new SaveGameInfo(br);
		InputManager = new InputManager(br);
		CharacterSheet = new CharacterSheet(br);
		SoundSettings = new SoundSettings(br);
		for (int i = 0; i < PlayerSuperCamCentrals.Length; i++)
			PlayerSuperCamCentrals[i] = new SuperCamCentral(br);
		TutorialManager = new TutorialManager(br);
		GUISystem = new GUISystem(br);
		CardGallery = new CardGallery(br);
		CustomSaveData = new CustomSaveData(br);
	}

	public void Write(BinaryWriter bw)
	{
		bw.Write(MagicNumber);
		SaveGameInfo.Write(bw);
		InputManager.Write(bw);
		CharacterSheet.Write(bw);
		SoundSettings.Write(bw);
		foreach (SuperCamCentral superCamCentral in PlayerSuperCamCentrals)
			superCamCentral.Write(bw);
		TutorialManager.Write(bw);
		GUISystem.Write(bw);
		CardGallery.Write(bw);
		CustomSaveData.Write(bw);
	}
}

public class SaveGameInfo
{
	public DateTime SaveDate { get; set; }
	public byte DisplayLevel { get; set; }
	public byte DisplayMission { get; set; }
	public uint FileSize { get; set; }

	public SaveGameInfo()
	{
		SaveDate = DateTime.Now;
		DisplayLevel = 1;
		DisplayMission = 0;
		FileSize = SaveGame.VanillaFileSize;
	}

	public SaveGameInfo(BinaryReader br)
	{
		ushort year = br.ReadUInt16();
		byte month = br.ReadByte();
		byte day = br.ReadByte();
		byte hour = br.ReadByte();
		byte minute = br.ReadByte();
		byte second = br.ReadByte();
		_ = br.ReadByte(); // Padding
		SaveDate = new DateTime(year, month, day, hour, minute, second);

		DisplayLevel = br.ReadByte();
		DisplayMission = br.ReadByte();
		FileSize = br.ReadUInt32();
	}

	public void Write(BinaryWriter bw)
	{
		bw.Write((ushort)SaveDate.Year);
		bw.Write((byte)SaveDate.Month);
		bw.Write((byte)SaveDate.Day);
		bw.Write((byte)SaveDate.Hour);
		bw.Write((byte)SaveDate.Minute);
		bw.Write((byte)SaveDate.Second);
		bw.Write((byte)0); // Padding

		bw.Write(DisplayLevel);
		bw.Write(DisplayMission);
		bw.Write(FileSize);
	}
}

public class InputManager
{
	public bool IsRumbleEnabled { get; set; }

	public InputManager()
	{
		IsRumbleEnabled = true;
	}

	public InputManager(BinaryReader br)
	{
		IsRumbleEnabled = br.ReadBoolean();
	}

	public void Write(BinaryWriter bw)
	{
		bw.Write((byte)(IsRumbleEnabled ? 255 : 0));
	}
}

public class CharacterSheet
{
	public string PlayerName { get; set; }
	public Level[] Levels { get; } = new Level[7];
	public CurrentMission CurrentMissionInfo { get; set; }
	public CurrentMission HighestMissionInfo { get; set; }
	public bool IsNavSystemEnabled { get; set; }
	public int Coins { get; set; }
	public CarInventory Cars { get; set; }
	public byte[] PersistentObjectStates { get; } = new byte[1312];
	public byte[] States { get; } = new byte[1];

	public CharacterSheet()
	{
		PlayerName = "Player1";

		for (int i = 0; i < Levels.Length; i++)
			Levels[i] = new Level(i + 1);

		CurrentMissionInfo = new CurrentMission();
		HighestMissionInfo = new CurrentMission();

		IsNavSystemEnabled = true;

		Coins = 0;

		Cars = new CarInventory();

		for (int i = 0; i < PersistentObjectStates.Length; i++)
			PersistentObjectStates[i] = 0;

		for (int i = 0; i < States.Length; i++)
			States[i] = 0;
	}

	public CharacterSheet(BinaryReader br)
	{
		PlayerName = BinaryExtensions.ReadNullTerminatedString(br, 16);

		for (int i = 0; i < Levels.Length; i++)
			Levels[i] = new Level(br);

		CurrentMissionInfo = new CurrentMission(br);
		HighestMissionInfo = new CurrentMission(br);

		IsNavSystemEnabled = br.ReadBoolean();
		_ = br.ReadBytes(3); // Padding

		Coins = br.ReadInt32();

		Cars = new CarInventory(br);

		for (int i = 0; i < PersistentObjectStates.Length; i++)
			PersistentObjectStates[i] = br.ReadByte();

		for (int i = 0; i < States.Length; i++)
			States[i] = br.ReadByte();

		_ = br.ReadBytes(3); // Padding
	}

	public void Write(BinaryWriter bw)
	{
		BinaryExtensions.WriteNullTerminatedString(bw, PlayerName, 16);

		foreach (Level level in Levels)
			level.Write(bw);

		CurrentMissionInfo.Write(bw);
		HighestMissionInfo.Write(bw);

		bw.Write(IsNavSystemEnabled);
		bw.Write((byte)0); // Padding
		bw.Write((byte)0); // Padding
		bw.Write((byte)0); // Padding

		bw.Write(Coins);

		Cars.Write(bw);

		foreach (byte persistentObjectState in PersistentObjectStates)
			bw.Write(persistentObjectState);

		foreach (byte state in States)
			bw.Write(state);

		bw.Write((byte)0); // Padding
		bw.Write((byte)0); // Padding
		bw.Write((byte)0); // Padding
	}

	public class Level
	{
		public Card[] Cards { get; } = new Card[7];
		public MissionRecord[] Missions { get; } = new MissionRecord[8];
		public MissionRecord[] StreetRaces { get; } = new MissionRecord[3];
		public MissionRecord BonusMission { get; set; }
		public MissionRecord GambleRace { get; set; }
		public bool FMVUnlocked { get; set; }
		public int NumCarsPurchased { get; set; }
		public int NumSkinsPurchased { get; set; }
		public int WaspsDestroyed { get; set; }
		public string CurrentSkin { get; set; }
		public int GagsViewed { get; set; }
		public uint GagMask { get; set; }
		public bool[] GagsCompleted { get; } = new bool[32];
		public bool[] PurchasedRewards { get; } = new bool[12];

		private static readonly string[] DefaultSkins = { "homer", "bart", "lisa", "marge", "apu", "bart", "homer" };

		public Level(int levelNumber)
		{
			for (int i = 0; i < Cards.Length; i++)
				Cards[i] = new Card();

			for (int i = 0; i < Missions.Length; i++)
				Missions[i] = new MissionRecord(levelNumber, i + 1);

			for (int i = 0; i < StreetRaces.Length; i++)
				StreetRaces[i] = new MissionRecord("sr", i + 1);

			BonusMission = new MissionRecord("bm", 1);
			GambleRace = new MissionRecord("gr", 1);

			FMVUnlocked = false;

			NumCarsPurchased = 0;
			NumSkinsPurchased = 0;
			WaspsDestroyed = 0;
			CurrentSkin = DefaultSkins[levelNumber - 1];
			GagsViewed = 0;
			GagMask = 0;

			for (int i = 0; i < GagsCompleted.Length; i++)
				GagsCompleted[i] = false;

			for (int i = 0; i < PurchasedRewards.Length; i++)
				GagsCompleted[i] = false;
		}

		public Level(BinaryReader br)
		{
			for (int i = 0; i < Cards.Length; i++)
				Cards[i] = new Card(br);

			_ = br.ReadByte(); // Padding

			for (int i = 0; i < Missions.Length; i++)
				Missions[i] = new MissionRecord(br);

			for (int i = 0; i < StreetRaces.Length; i++)
				StreetRaces[i] = new MissionRecord(br);

			BonusMission = new MissionRecord(br);
			GambleRace = new MissionRecord(br);

			FMVUnlocked = br.ReadBoolean();
			_ = br.ReadBytes(3); // Padding

			NumCarsPurchased = br.ReadInt32();
			NumSkinsPurchased = br.ReadInt32();
			WaspsDestroyed = br.ReadInt32();
			CurrentSkin = BinaryExtensions.ReadNullTerminatedString(br, 16);
			GagsViewed = br.ReadInt32();
			GagMask = br.ReadUInt32();

			for (int i = 0; i < GagsCompleted.Length; i++)
				GagsCompleted[i] = br.ReadBoolean();

			for (int i = 0; i < PurchasedRewards.Length; i++)
				PurchasedRewards[i] = br.ReadBoolean();
		}

		public void Write(BinaryWriter bw)
		{
			foreach (Card card in Cards)
				card.Write(bw);

			bw.Write((byte)0); // Padding

			foreach (MissionRecord mission in Missions)
				mission.Write(bw);

			foreach (MissionRecord streetRace in StreetRaces)
				streetRace.Write(bw);

			BonusMission.Write(bw);
			GambleRace.Write(bw);

			bw.Write(FMVUnlocked);
			bw.Write((byte)0); // Padding
			bw.Write((byte)0); // Padding
			bw.Write((byte)0); // Padding

			bw.Write(NumCarsPurchased);
			bw.Write(NumSkinsPurchased);
			bw.Write(WaspsDestroyed);
			BinaryExtensions.WriteNullTerminatedString(bw, CurrentSkin, 16);
			bw.Write(GagsViewed);
			bw.Write(GagMask);

			foreach (bool gagCompleted in GagsCompleted)
				bw.Write(gagCompleted);

			foreach (bool purchasedReward in PurchasedRewards)
				bw.Write(purchasedReward);
		}

		public class Card
		{
			public string Name { get; set; }
			public bool Collected { get; set; }

			public Card()
			{
				Name = "Cardx";
				Collected = false;
			}

			public Card(BinaryReader br)
			{
				Name = BinaryExtensions.ReadNullTerminatedString(br, 16);
				Collected = br.ReadBoolean();
			}

			public void Write(BinaryWriter bw)
			{
				BinaryExtensions.WriteNullTerminatedString(bw, Name, 16);
				bw.Write(Collected);
			}
		}

		public class MissionRecord
		{
			public string Name { get; set; }
			public bool Completed { get; set; }
			public bool BonusObjective { get; set; }
			public uint NumAttempts { get; set; }
			public bool SkippedMission { get; set; }
			public int BestTime { get; set; }

			public MissionRecord(int levelNumber, int missionNumber)
			{
				Name = $"m{(levelNumber == 1 ? missionNumber - 1 : missionNumber)}L";
				Completed = false;
				BonusObjective = false;
				NumAttempts = 0;
				SkippedMission = false;
				BestTime = -1;
			}

			public MissionRecord(string prefix, int streetRaceNumber)
			{
				Name = $"{prefix}{streetRaceNumber}";
				Completed = false;
				BonusObjective = false;
				NumAttempts = 0;
				SkippedMission = false;
				BestTime = -1;
			}

			public MissionRecord(BinaryReader br)
			{
				Name = BinaryExtensions.ReadNullTerminatedString(br, 16);
				Completed = br.ReadBoolean();
				BonusObjective = br.ReadBoolean();
				_ = br.ReadBytes(2); // Padding
				NumAttempts = br.ReadUInt32();
				SkippedMission = br.ReadBoolean();
				_ = br.ReadBytes(3); // Padding
				BestTime = br.ReadInt32();
			}

			public void Write(BinaryWriter bw)
			{
				BinaryExtensions.WriteNullTerminatedString(bw, Name, 16);
				bw.Write(Completed);
				bw.Write(BonusObjective);
				bw.Write((byte)0); // Padding
				bw.Write((byte)0); // Padding
				bw.Write(NumAttempts);
				bw.Write(SkippedMission);
				bw.Write((byte)0); // Padding
				bw.Write((byte)0); // Padding
				bw.Write((byte)0); // Padding
				bw.Write(BestTime);
			}
		}
	}

	public class CurrentMission
	{
		public enum Levels
		{
			L1,
			L2,
			L3,
			L4,
			L5,
			L6,
			L7,
			B00,
			B01,
			B02,
			B03,
			B04,
			B05,
			B06,
			B07,
		}

		public enum Missions
		{
			M1,
			M2,
			M3,
			M4,
			M5,
			M6,
			M7,
			M8,
			M9,
			M10,
		}

		public Levels Level { get; set; }
		public Missions Mission { get; set; }

		public CurrentMission()
		{
			Level = Levels.L1;
			Mission = Missions.M1;
		}

		public CurrentMission(BinaryReader br)
		{
			Level = (Levels)br.ReadUInt32();
			Mission = (Missions)br.ReadUInt32();
		}

		public void Write(BinaryWriter bw)
		{
			bw.Write((uint)Level);
			bw.Write((uint)Mission);
		}
	}

	public class CarInventory
	{
		public Car[] Cars { get; } = new Car[60];
		public int Counter { get; set; }

		public CarInventory()
		{
			for (int i = 0; i < Cars.Length; i++)
				Cars[i] = new Car();

			Counter = 0;
		}

		public CarInventory(BinaryReader br)
		{
			for (int i = 0; i < Cars.Length; i++)
				Cars[i] = new Car(br);

			Counter = br.ReadInt32();
		}

		public void Write(BinaryWriter bw)
		{
			foreach (Car car in Cars)
				car.Write(bw);

			bw.Write(Counter);
		}

		public class Car
		{
			public string Name { get; set; }
			public float CurrentHealth { get; set; }
			public float MaxHealth { get; set; }

			public Car()
			{
				Name = "n/a";
				CurrentHealth = -1;
				MaxHealth = -1;
			}

			public Car(BinaryReader br)
			{
				Name = BinaryExtensions.ReadNullTerminatedString(br, 16);
				CurrentHealth = br.ReadSingle();
				MaxHealth = br.ReadSingle();
			}

			public void Write(BinaryWriter bw)
			{
				BinaryExtensions.WriteNullTerminatedString(bw, Name, 16);
				bw.Write(CurrentHealth);
				bw.Write(MaxHealth);
			}
		}
	}
}

public class SoundSettings
{
	public float MusicVolume { get; set; }
	public float SFXVolume { get; set; }
	public float CarVolume { get; set; }
	public float DialogVolume { get; set; }
	public bool IsSurround { get; set; }

	public SoundSettings()
	{
		MusicVolume = 1;
		SFXVolume = 1;
		CarVolume = 1;
		DialogVolume = 1;
		IsSurround = false;
	}

	public SoundSettings(BinaryReader br)
	{
		MusicVolume = br.ReadSingle();
		SFXVolume = br.ReadSingle();
		CarVolume = br.ReadSingle();
		DialogVolume = br.ReadSingle();
		IsSurround = br.ReadBoolean();
		_ = br.ReadBytes(3); // Padding
	}

	public void Write(BinaryWriter bw)
	{
		bw.Write(MusicVolume);
		bw.Write(SFXVolume);
		bw.Write(CarVolume);
		bw.Write(DialogVolume);
		bw.Write(IsSurround);
		bw.Write((byte)0); // Padding
		bw.Write((byte)0); // Padding
		bw.Write((byte)0); // Padding
	}
}

public class SuperCamCentral
{
	public enum PreferredFollowCams
	{
		Default,
		Follow,
		Near_Follow,
		Far_Follow,
		Bumper,
		Chase,
		Debug,
		Wreckless,
		Walker,
		Comedy,
		Kull,
		Tracker,
		Spline,
		Rail,
		Conversation,
		Static,
		Burnout,
		Reverse,
		Snapshot,
		Surveillance,
		Animated,
		Relative_Animated,
		Super_Sprint,
		First_Person,
		On_Foot,
		PC
	}

	public bool JumpCamsEnabled { get; set; }
	public bool IsInvertedCameraEnabled { get; set; }
	public PreferredFollowCams PreferredFollowCam { get; set; }

	public SuperCamCentral()
	{
		JumpCamsEnabled = true;
		IsInvertedCameraEnabled = true;
		PreferredFollowCam = PreferredFollowCams.Far_Follow;
	}

	public SuperCamCentral(BinaryReader br)
	{
		byte bitmask = br.ReadByte();

		JumpCamsEnabled = (bitmask & 0x01) > 0;
		IsInvertedCameraEnabled = (bitmask & 0x02) > 0;

		var x = (bitmask >> 2);
		PreferredFollowCam = (PreferredFollowCams)(x == 0 ? 3 : x);
	}

	public void Write(BinaryWriter bw)
	{
		byte bitmask = 0;

		if (JumpCamsEnabled)
			bitmask |= 0x01;

		if (IsInvertedCameraEnabled)
			bitmask |= 0x02;

		byte preferredFollowCam = (byte)PreferredFollowCam;
		if ((preferredFollowCam & 0xC0) != 0)
			throw new InvalidDataException("Not enough bits to save preferred follow cam");

		bitmask |= (byte)(preferredFollowCam << 2);
		bw.Write(bitmask);
	}
}

public class TutorialManager
{
	public bool EnableTutorialEvents { get; set; }
	public int TutorialsSeen { get; set; }

	public TutorialManager()
	{
		EnableTutorialEvents = false;
		TutorialsSeen = 0;
	}

	public TutorialManager(BinaryReader br)
	{
		EnableTutorialEvents = br.ReadBoolean();
		TutorialsSeen = br.ReadInt32();
	}

	public void Write(BinaryWriter bw)
	{
		bw.Write(EnableTutorialEvents);
		bw.Write(TutorialsSeen);
	}
}

public class GUISystem
{
	public bool IsRadarEnabled { get; set; }

	public GUISystem()
	{
		IsRadarEnabled = false;
	}

	public GUISystem(BinaryReader br)
	{
		IsRadarEnabled = br.ReadBoolean();
	}

	public void Write(BinaryWriter bw)
	{
		bw.Write(IsRadarEnabled);
	}
}

public class CardGallery
{
	public bool[] CollectedCardIDs { get; } = new bool[7 * 8]; // Byte Count * Bits Per Byte

	public CardGallery()
	{
		for (int i = 0; i < CollectedCardIDs.Length; i++)
			CollectedCardIDs[i] = false;
	}

	public CardGallery(BinaryReader br)
	{
		byte[] Data = br.ReadBytes(CollectedCardIDs.Length / 8);

		for (int i = 0; i < CollectedCardIDs.Length; i++)
		{
			uint index = (uint)(i / 8);
			CollectedCardIDs[i] = (Data[index] & (1 << i % 8)) > 0;
		}
	}

	public void Write(BinaryWriter bw)
	{
		byte[] Data = new byte[7];

		for (int i = 0; i < Data.Length; i++)
			Data[i] = 0;

		for (int i = 0; i < CollectedCardIDs.Length; i++)
		{
			if (CollectedCardIDs[i])
			{
				uint index = (uint)(i / 8);
				Data[index] |= (byte)(1 << (i % 8));
			}
		}

		bw.Write(Data);
	}
}

public class CustomSaveData
{
	public byte[] Data { get; set; }

	public CustomSaveData()
	{
		Data = new byte[0];
	}

	public CustomSaveData(BinaryReader br)
	{
		Data = br.ReadBytes((int)(br.BaseStream.Length - br.BaseStream.Position));
	}

	public void Write(BinaryWriter bw)
	{
		bw.Write(Data);
	}
}