namespace LucasStuff
{
    public partial class CustomSaveData
    {
        public class THackCustomSaveDataIncreasedRewardLimitsMerchandiseUnlocked : THackCustomSaveData
        {
            public uint Version;
            public uint Version2;
            public readonly System.Collections.Generic.List<int>[] Indices = new System.Collections.Generic.List<int>[7];

            public THackCustomSaveDataIncreasedRewardLimitsMerchandiseUnlocked() : base("Unlocked")
            {
                for (var I = 0; I < this.Indices.Length; ++I)
                    this.Indices[I] = [];
            }

            public void Set(uint Level, int Index, bool Unlocked)
            {
                if (Unlocked)
                    if (!this.Indices[Level].Contains(Index))
                        this.Indices[Level].Add(Index);
                else
                    this.Indices[Level].Remove(Index);
            }

            public override bool ShouldInclude()
            {
                foreach (var Indices in this.Indices)
                    if (Indices.Count > 0)
                        return true;
                return false;
            }

            public override int GetSize()
            {
                var Result =
                    sizeof(uint) +//Version
                    sizeof(uint);//Version2
                foreach (var Indices in this.Indices)
                {
                    Result +=
                        sizeof(uint) +//Count
                        Indices.Count * sizeof(int);
                }
                return Result;
            }

            public override bool Read(System.IO.BinaryReader Reader, uint Size)
            {
                foreach (var Indices in this.Indices)
                    Indices.Clear();
                this.Version = Reader.ReadUInt32();
                if (this.Version > 0)
                    return false;
                this.Version2 = Reader.ReadUInt32();
                foreach (var Indices in this.Indices)
                {
                    var UnlockedMerchandiseCount = Reader.ReadUInt32();
                    for (var I = 0; I < UnlockedMerchandiseCount; ++I)
                    {
                        var Index = Reader.ReadInt32();
                        Indices.Add(Index);
                    }
                }
                return true;
            }

            public override void Write(System.IO.BinaryWriter Writer)
            {
                Writer.Write(this.Version);
                Writer.Write(this.Version2);
                foreach (var Indices in this.Indices)
                {
                    Writer.Write((uint)Indices.Count);
                    foreach (var it in Indices)
                        Writer.Write(it);
                }
            }

            public override void Reset()
            {
                foreach (var Indices in this.Indices)
                    Indices.Clear();
            }
        }

        public THackCustomSaveDataGroup HackCustomSaveDataIncreasedRewardLimits = null;
        public THackCustomSaveDataGroup HackCustomSaveDataIncreasedRewardLimitsMerchandise = null;
        public THackCustomSaveDataIncreasedRewardLimitsMerchandiseUnlocked HackCustomSaveDataIncreasedRewardLimitsMerchandiseUnlocked = null;

        private void OnIncreasedRewardLimitsLoad()
        {
            this.HackCustomSaveDataIncreasedRewardLimits = new("IncreasedRewardLimits");
            this.HackCustomSaveDataIncreasedRewardLimitsMerchandise = new("Merchandise");
            this.HackCustomSaveDataIncreasedRewardLimitsMerchandiseUnlocked = new();
        }

        private void OnIncreasedRewardLimitsAddHack()
        {
            AddKnownHackCustomSaveData(this.HackCustomSaveDataIncreasedRewardLimits);
            this.HackCustomSaveDataIncreasedRewardLimits.AddKnownHackCustomSaveData(this.HackCustomSaveDataIncreasedRewardLimitsMerchandise);
            this.HackCustomSaveDataIncreasedRewardLimitsMerchandise.AddKnownHackCustomSaveData(this.HackCustomSaveDataIncreasedRewardLimitsMerchandiseUnlocked);
        }
    }
}