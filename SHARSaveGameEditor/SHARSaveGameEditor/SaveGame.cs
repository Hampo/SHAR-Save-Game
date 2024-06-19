using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace SHARSaveGameEditor
{
    public class SaveGame
    {
        public const ushort MagicNumber = 1978;
        public const uint VanillaFileSize = 7194;

        public SaveGameInfo SaveGameInfo { get; }
        public InputManager InputManager { get; }
        public CharacterSheet CharacterSheet { get; }
        public SoundSettings SoundSettings { get; }
        public SuperCamCentral[] SuperCamCentrals { get; } = new SuperCamCentral[4];
        public TutorialManager TutorialManager { get; }
        public GUISystem GUISystem { get; }
        public CardGallery CardGallery { get; }
        public CustomSaveData CustomSaveData { get; }

        public SaveGame() {
            SaveGameInfo = new SaveGameInfo();
            InputManager = new InputManager();
            CharacterSheet = new CharacterSheet();
            SoundSettings = new SoundSettings();
            for (int i = 0; i < SuperCamCentrals.Length; i++)
                SuperCamCentrals[i] = new SuperCamCentral();
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
            for (int i = 0; i < SuperCamCentrals.Length; i++)
                SuperCamCentrals[i] = new SuperCamCentral(br);
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
            foreach (SuperCamCentral superCamCentral in SuperCamCentrals)
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
        public byte Hour { get; set; }
        public byte Minute { get; set; }
        public byte Second { get; set; }
        public byte DisplayLevel { get; set; }
        public byte DisplayMission { get; set; }
        public uint FileSize { get; set; }

        public SaveGameInfo()
        {
            SaveDate = DateTime.Now;
            Hour = (byte)SaveDate.Hour;
            Minute = (byte)SaveDate.Minute;
            Second = (byte)SaveDate.Second;
            DisplayLevel = 1;
            DisplayMission = 0;
            FileSize = SaveGame.VanillaFileSize;
        }

        public SaveGameInfo(BinaryReader br)
        {
            ushort year = br.ReadUInt16();
            byte month = br.ReadByte();
            byte day = br.ReadByte();
            Hour = br.ReadByte();
            Minute = br.ReadByte();
            Second = br.ReadByte();
            _ = br.ReadByte(); // Padding
            month = Math.Max((byte)1, month);
            month = Math.Min((byte)12, month);
            day = Math.Max((byte)1, day);
            day = Math.Min((byte)DateTime.DaysInMonth(year, month), day);
            SaveDate = new DateTime(year, month, day);
            
            DisplayLevel = br.ReadByte();
            DisplayMission = br.ReadByte();
            FileSize = br.ReadUInt32();
        }

        public void Write(BinaryWriter bw)
        {
            bw.Write((ushort)SaveDate.Year);
            bw.Write((byte)SaveDate.Month);
            bw.Write((byte)SaveDate.Day);
            bw.Write(Hour);
            bw.Write(Minute);
            bw.Write(Second);
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
        public bool[] PersistentObjectStates { get; } = new bool[1312 * 8]; // Byte Count * Bits Per Byte
        //public byte[] PersistentObjectStates { get; } = new byte[1312];
        public bool ItchyScratchyCBGFirst { get; set; }
        public bool ItchyScratchyTicket { get; set; }

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
                PersistentObjectStates[i] = true;
            /*for (int i = 0; i < PersistentObjectStates.Length; i++)
                PersistentObjectStates[i] = 0;*/

            ItchyScratchyCBGFirst = false;
            ItchyScratchyTicket = false;
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

            byte[] persistentObjectStates = br.ReadBytes(PersistentObjectStates.Length / 8);
            for (int i = 0; i < PersistentObjectStates.Length; i++)
            {
                uint index = (uint)(i / 8);
                PersistentObjectStates[i] = (persistentObjectStates[index] & (1 << i % 8)) != 0;
            }
            /*for (int i = 0; i < PersistentObjectStates.Length; i++)
                PersistentObjectStates[i] = br.ReadByte();*/

            byte state = br.ReadByte();

            ItchyScratchyCBGFirst = (state & 0x01) > 0;
            ItchyScratchyTicket = (state & 0x02) > 0;

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

            byte[] persistentObjectStates = new byte[PersistentObjectStates.Length / 8];
            for (int i = 0; i < persistentObjectStates.Length; i++)
                persistentObjectStates[i] = 0;

            for (int i = 0; i < PersistentObjectStates.Length; i++)
            {
                if (PersistentObjectStates[i])
                {
                    uint index = (uint)(i / 8);
                    persistentObjectStates[index] |= (byte)(1 << (i % 8));
                }
            }

            bw.Write(persistentObjectStates);
            /*foreach (byte persistentObjectState in PersistentObjectStates)
                bw.Write(persistentObjectState);*/

            byte state = 0;

            if (ItchyScratchyCBGFirst)
                state |= 0x01;

            if (ItchyScratchyTicket)
                state |= 0x02;

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
                    Name = $"m{(levelNumber == 1 ? missionNumber - 1 : missionNumber)}";
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
                Car defaultCar = new Car()
                {
                    Name = "famil_v",
                    CurrentHealth = 1,
                    MaxHealth = -1,
                };
                Cars[0] = defaultCar;
                for (int i = 1; i < Cars.Length; i++)
                    Cars[i] = new Car();

                Counter = 1;
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
            IsInvertedCameraEnabled = false;
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
        [Flags]
        public enum TutorialMode
        {
            Break_Camera = 1 << 0,
            Bonus_Mission = 1 << 1,
            Start_Game = 1 << 2,
            Getting_Into_Player_Car = 1 << 3,
            Getting_Into_Traffic_Car = 1 << 4,
            Interactive_Gag = 1 << 5,
            Race = 1 << 6,
            Collector_Card = 1 << 7,
            Collector_Coin = 1 << 8,
            Reward = 1 << 9,
            Getting_Out_Of_Car = 1 << 10,
            Breakable_Approached = 1 << 11,
            Breakable_Destroyed = 1 << 12,
            Interior_Entered = 1 << 13,
            Coin_Collected = 1 << 14,
            Vehicle_Destroyed = 1 << 15,
            Unlocked_Car = 1 << 16,
            Wrench = 1 << 17,
            At_Car_Door = 1 << 18,
            Interactive_Gag_Approached = 1 << 19,
            Wager_Mission = 1 << 20,
        }

        public bool EnableTutorialEvents { get; set; }
        public TutorialMode TutorialsSeen { get; set; }

        public TutorialManager()
        {
            EnableTutorialEvents = true;
            TutorialsSeen = 0;
        }

        public TutorialManager(BinaryReader br)
        {
            EnableTutorialEvents = br.ReadBoolean();
            TutorialsSeen = (TutorialMode)br.ReadInt32();
        }

        public void Write(BinaryWriter bw)
        {
            bw.Write(EnableTutorialEvents);
            bw.Write((int)TutorialsSeen);
        }
    }

    public class GUISystem
    {
        public bool IsRadarEnabled { get; set; }

        public GUISystem()
        {
            IsRadarEnabled = true;
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
        private const int ByteCount = 7;
        private const int BitsPerByte = 8;

        public bool[] CollectedCardIDs { get; } = new bool[ByteCount * BitsPerByte];

        public CardGallery()
        {
            for (int i = 0; i < CollectedCardIDs.Length; i++)
                CollectedCardIDs[i] = false;
        }

        public CardGallery(BinaryReader br)
        {
            byte[] collectedCardIDs = br.ReadBytes(ByteCount);
            for (int i = 0; i < CollectedCardIDs.Length; i++)
            {
                uint index = (uint)(i / BitsPerByte);
                CollectedCardIDs[i] = (collectedCardIDs[index] & (1 << i % BitsPerByte)) > 0;
            }
        }

        public void Write(BinaryWriter bw)
        {
            byte[] collectedCardIDs = new byte[ByteCount];
            for (int i = 0; i < collectedCardIDs.Length; i++)
                collectedCardIDs[i] = 0;

            for (int i = 0; i < CollectedCardIDs.Length; i++)
            {
                if (CollectedCardIDs[i])
                {
                    uint index = (uint)(i / BitsPerByte);
                    collectedCardIDs[index] |= (byte)(1 << (i % BitsPerByte));
                }
            }

            bw.Write(collectedCardIDs);
        }
    }

    public class CustomSaveData
    {
        public byte[] Data { get; set; }
        public LMLD LucasModLauncherData { get; set; }

        public CustomSaveData()
        {
            Data = new byte[0];
            LucasModLauncherData = null;
        }

        public CustomSaveData(BinaryReader br)
        {
            byte[] Data = br.ReadBytes((int)(br.BaseStream.Length - br.BaseStream.Position));

            if (Data.Length >= 16)
            {
                var signature = BitConverter.ToUInt32(Data, 0);
                if (signature != LMLD.Signature)
                {
                    Debugger.Break(); // Weird extra data. Break to investigate.
                    this.Data = Data;
                    return;
                }

                int pos = 12;
                var size = BitConverter.ToInt32(Data, pos);
                pos += sizeof(int);
                int remaining = Data.Length - pos;
                if (size != remaining)
                    throw new InvalidDataException($"Invalid Custom Save Data. Reported size: {size}. Remaining bytes: {remaining}.");

                byte[] data = new byte[size];
                Array.Copy(Data, pos, data, 0, size);
                LucasModLauncherData = new LMLD(data);
            }
            else
            {
                this.Data = Data;
            }
        }

        public void Write(BinaryWriter bw)
        {
            if (LucasModLauncherData == null)
                bw.Write(Data);
            else
                LucasModLauncherData.Write(bw);
        }

        public class LMLD
        {
            public const uint Signature = 0x444C4D4C;
            public int Unknown1 { get; set; }
            public int Unknown2 { get; set; }
            public List<Section> Sections { get; } = new List<Section>();

            public LMLD(byte[] data)
            {
                int pos = 0;

                Unknown1 = BitConverter.ToInt32(data, pos);
                pos += sizeof(int);

                Unknown1 = BitConverter.ToInt32(data, pos);
                pos += sizeof(int);

                int sections = BitConverter.ToInt32(data, pos);
                pos += sizeof(int);

                Sections.Capacity = sections;
                for (int i = 0; i < sections; i++)
                {
                    Section section = new Section(data, ref pos);
                    Sections.Add(section);
                }
            }

            public void Write(BinaryWriter bw)
            {
                bw.Write(Signature);
                bw.Write(0);
                bw.Write(0);

                int length = sizeof(int) + sizeof(int) + sizeof(int); // Unknown1 + Unknown2 + SectionCount
                foreach (var section in Sections)
                    length += section.Length;
                bw.Write(length);

                bw.Write(Unknown1);
                bw.Write(Unknown2);
                bw.Write(Sections.Count);
                foreach (var section in Sections)
                    section.Write(bw);
            }

            public class Section
            {
                public string Name { get; set; }
                public int Unknown1 { get; set; }
                public int Unknown2 { get; set; }
                public string Value { get; set; }
                private string RawValue {
                    get
                    {
                        return string.IsNullOrEmpty(Value) ? "\0" : Value;
                    }
                    set
                    {
                        Value = value == "\0" ? string.Empty : value;
                    }
                }
                public List<SubItem> SubItems { get; } = new List<SubItem>();

                public int DataLength
                {
                    get
                    {
                        int length = sizeof(int) + sizeof(int) + 1 + Encoding.Unicode.GetByteCount(RawValue);
                        foreach (var item in SubItems)
                            length += 1 + item.Length;
                        return length;
                    }
                }

                public int Length
                {
                    get
                    {
                        return 1 + Encoding.ASCII.GetByteCount(Name) + sizeof(int) + DataLength;
                    }
                }

                public Section(byte[] data, ref int pos)
                {
                    byte nameLength = data[pos++];
                    Name = BinaryExtensions.ReadASCIIString(data, pos, nameLength);
                    pos += nameLength;

                    int length = BitConverter.ToInt32(data, pos);
                    pos += sizeof(int);

                    int remaining = data.Length - pos;
                    if (length > remaining)
                        throw new InvalidDataException($"Invalid Custom Save Data Section. Required bytes: {length}. Remaining bytes: {remaining}.");

                    byte[] sectionData = new byte[length];
                    Array.Copy(data, pos, sectionData, 0, length);
                    ProcessSectionData(sectionData);

                    pos += length;
                }

                private void ProcessSectionData(byte[] data)
                {
                    int pos = 0;

                    Unknown1 = BitConverter.ToInt32(data, pos);
                    pos += sizeof(int);

                    Unknown2 = BitConverter.ToInt32(data, pos);
                    pos += sizeof(int);

                    byte valueLength = data[pos++];
                    RawValue = BinaryExtensions.ReadUnicodeString(data, pos, valueLength);
                    pos += valueLength * 2;

                    while (pos < data.Length)
                    {
                        pos += 1; // Separator? Idk
                        SubItem item = new SubItem(data, ref pos);
                        SubItems.Add(item);
                    }
                }

                public void Write(BinaryWriter bw)
                {
                    byte[] nameBytes = Encoding.ASCII.GetBytes(Name);
                    if (nameBytes.Length > byte.MaxValue)
                        throw new InvalidDataException($"{nameof(Name)} has a max length of {byte.MaxValue} bytes. Current value bytes {nameBytes.Length}.");

                    byte[] valueBytes = Encoding.Unicode.GetBytes(RawValue);
                    if (valueBytes.Length > byte.MaxValue * 2)
                        throw new InvalidDataException($"{nameof(RawValue)} has a max length of {byte.MaxValue * 2} bytes. Current value bytes {valueBytes.Length}.");

                    bw.Write((byte)nameBytes.Length);
                    bw.Write(nameBytes);

                    bw.Write(DataLength);

                    bw.Write(Unknown1);
                    bw.Write(Unknown2);

                    bw.Write((byte)(valueBytes.Length / 2));
                    bw.Write(valueBytes);

                    foreach (var subItem in SubItems)
                    {
                        bw.Write((byte)0);
                        subItem.Write(bw);
                    }
                }

                public class SubItem
                {
                    public string Name { get; set; }
                    public int Unknown1 { get; set; }
                    public int Unknown2 { get; set; }
                    public List<List<string>> Values { get; } = new List<List<string>>();

                    public int DataLength
                    {
                        get
                        {
                            int length = sizeof(int) + sizeof(int);
                            foreach (var x in Values)
                            {
                                length += sizeof(int);
                                foreach (var y in x)
                                    length += 1 + Encoding.ASCII.GetByteCount(y);
                            }
                            return length;
                        }
                    }

                    public int Length
                    {
                        get
                        {
                            return 1 + Encoding.ASCII.GetByteCount(Name) + sizeof(int) + DataLength;
                        }
                    }

                    public SubItem(byte[] data, ref int pos)
                    {
                        byte nameLength = data[pos++];
                        Name = BinaryExtensions.ReadASCIIString(data, pos, nameLength);
                        pos += nameLength;

                        int length = BitConverter.ToInt32(data, pos);
                        pos += sizeof(int);

                        int remaining = data.Length - pos;
                        if (length > remaining)
                            throw new InvalidDataException($"Invalid Custom Save Data Section Sub Item. Required bytes: {length}. Remaining bytes: {remaining}.");

                        byte[] itemData = new byte[length];
                        Array.Copy(data, pos, itemData, 0, length);
                        ProcessItemData(itemData);

                        pos += length;
                    }

                    private void ProcessItemData(byte[] data)
                    {
                        int pos = 0;

                        Unknown1 = BitConverter.ToInt32(data, pos);
                        pos += sizeof(int);

                        Unknown2 = BitConverter.ToInt32(data, pos);
                        pos += sizeof(int);

                        while (pos < data.Length)
                        {
                            int itemCount = BitConverter.ToInt32(data, pos);
                            pos += sizeof(int);

                            List<string> items = new List<string>(itemCount);
                            for (int i = 0; i < itemCount; i++)
                            {
                                byte nameLength = data[pos++];
                                items.Add(BinaryExtensions.ReadASCIIString(data, pos, nameLength));
                                pos += nameLength;
                            }
                            Values.Add(items);
                        }
                    }

                    public void Write(BinaryWriter bw)
                    {
                        byte[] nameBytes = Encoding.ASCII.GetBytes(Name);
                        if (nameBytes.Length > byte.MaxValue)
                            throw new InvalidDataException($"{nameof(Name)} has a max length of {byte.MaxValue} bytes. Current value bytes {nameBytes.Length}.");

                        foreach (var x in Values)
                        {
                            foreach (var y in x)
                            {
                                int z = Encoding.ASCII.GetByteCount(y);
                                if (z > byte.MaxValue)
                                    throw new InvalidDataException($"A value has a max length of {byte.MaxValue} bytes. Current value bytes {z}.");
                            }
                        }

                        bw.Write((byte)nameBytes.Length);
                        bw.Write(nameBytes);

                        bw.Write(DataLength);

                        bw.Write(Unknown1);
                        bw.Write(Unknown2);

                        foreach (var x in Values)
                        {
                            bw.Write(x.Count);
                            foreach (var y in x)
                            {
                                byte[] z = Encoding.ASCII.GetBytes(y);
                                bw.Write((byte)z.Length);
                                bw.Write(z);
                            }
                        }
                    }
                }
            }
        }
    }
}
