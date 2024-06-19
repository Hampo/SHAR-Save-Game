namespace LucasStuff
{
    public partial class CustomSaveData
    {
        public const string Signature = "LMLD";

        public uint Version;
        public uint Version2;
        public THackCustomSaveDataGroup HackCustomSaveDataGroup = new("CustomSaveData");

        private partial void AddKnownHackCustomSaveData(THackCustomSaveData HackCustomSaveData) => this.HackCustomSaveDataGroup.AddKnownHackCustomSaveData(HackCustomSaveData);

        public void Update() => this.HackCustomSaveDataGroup.Update();
        private bool ShouldInclude() => this.HackCustomSaveDataGroup.ShouldInclude();

        public int GetSize()
        {
            return
                /*System.Text.Encoding.Default.GetByteCount(CustomSaveData.Signature)*/4 +
                sizeof(uint) +//Version
                sizeof(uint) +//Version2
                sizeof(uint) +//Size
                this.HackCustomSaveDataGroup.GetSize();
        }

        public void Write(System.IO.BinaryWriter Writer)
        {
            Writer.Write(System.Text.Encoding.Default.GetBytes(Signature));
            Writer.Write(this.Version);
            Writer.Write(this.Version2);
            Writer.Write((uint)this.HackCustomSaveDataGroup.GetSize());
            this.HackCustomSaveDataGroup.Write(Writer);
        }

        public void Write(System.IO.Stream Stream)
        {
            if (!ShouldInclude())
                return;
            var Writer = new System.IO.BinaryWriter(Stream);
            Write(Writer);
        }

        private bool Read2(System.IO.BinaryReader Reader)
        {
            var Signature = System.Text.Encoding.Default.GetString(Reader.ReadBytes(/*System.Text.Encoding.Default.GetByteCount(CustomSaveData.Signature)*/4));
            if (Signature != CustomSaveData.Signature)
                return false;
            this.Version = Reader.ReadUInt32();
            if (this.Version > 0)
                return false;
            this.Version2 = Reader.ReadUInt32();
            var DataSize = Reader.ReadUInt32();
            {
                var StartPosition = Reader.BaseStream.Position;
                this.HackCustomSaveDataGroup.Read(Reader, DataSize);
                var EndPosition = StartPosition + DataSize;
                if (Reader.BaseStream.Position != EndPosition)
                    System.Diagnostics.Debugger.Break();
                Reader.BaseStream.Seek(EndPosition, System.IO.SeekOrigin.Begin);
            }
            return true;
        }

        private void Reset() => this.HackCustomSaveDataGroup.Reset();

        private bool Read(System.IO.BinaryReader Reader)
        {
            var Result = Read2(Reader);
            if (!Result)
                Reset();
            return Result;
        }

        public class THackCustomSaveDataMerchandiseNames : THackCustomSaveData
        {
            public uint Version;
            public uint Version2;
            public readonly System.Collections.Generic.List<string>[] Names = new System.Collections.Generic.List<string>[7];

            public THackCustomSaveDataMerchandiseNames() : base("Names")
            {
                for (var I = 0; I < this.Names.Length; ++I)
                    this.Names[I] = [];
            }

            public string Get(int Level, int Index) => this.Names[Level][Index];

            public override bool ShouldInclude() => true;

            public override int GetSize()
            {
                var Result =
                    sizeof(uint) +//Version
                    sizeof(uint);//Version2
                foreach (var Names in this.Names)
                {
                    Result += sizeof(uint);
                    foreach (var Name in Names)
                    {
                        Result +=
                            sizeof(byte) +
                            /*System.Text.Encoding.Default.GetByteCount(Name)*/Name.Length;
                    }
                }
                return Result;
            }

            public override bool Read(System.IO.BinaryReader Reader, uint Size)
            {
                foreach (var Names in this.Names)
                    Names.Clear();
                this.Version = Reader.ReadUInt32();
                if (this.Version > 0)
                    return false;
                this.Version2 = Reader.ReadUInt32();
                for (var I = 0; I < this.Names.Length; ++I)
                {
                    var Names = this.Names[I];

                    var MerchandiseCount = Reader.ReadUInt32();
                    for (var I2 = 0; I2 < MerchandiseCount; ++I2)
                    {
                        var Length = Reader.ReadByte();
                        Names.Add(System.Text.Encoding.Default.GetString(Reader.ReadBytes(Length)));
                    }
                }
                return true;
            }

            public override void Write(System.IO.BinaryWriter Writer)
            {
                Writer.Write(this.Version);
                Writer.Write(this.Version2);
                foreach (var Names in this.Names)
                {
                    Writer.Write((uint)Names.Count);
                    foreach (var Name in Names)
                    {
                        Writer.Write((byte)Name.Length);
                        Writer.Write(System.Text.Encoding.Default.GetBytes(Name));
                    }
                }
            }

            public override void Reset()
            {
                for (var I = 0; I < this.Names.Length; ++I)
                    this.Names[I] = [];
            }
        }

        private static string ValueStringToString(string Value) => (Value != null) ? $"\"{Value}\"" : "null";

        public class THackCustomSaveDataMainMod : THackCustomSaveData
        {
            public uint Version;
            public uint Version2;
            public string MainMod2;

            public override string ToString() => $"{base.ToString()} = {ValueStringToString(this.MainMod2)}";

            public THackCustomSaveDataMainMod() : base("MainMod")
            {

            }

            public override bool ShouldInclude()
            {
                if (this.MainMod2 == null)
                    return false;
                return true;
            }

            public override int GetSize()
            {
                return
                    sizeof(uint) +//Version
                    sizeof(uint) +//Version2
                    sizeof(byte) +//Length
                    /*System.Text.Encoding.Unicode.GetByteCount(this.MainMod2)*/sizeof(char) * this.MainMod2.Length;
            }

            public override bool Read(System.IO.BinaryReader Reader, uint Size)
            {
                this.MainMod2 = null;
                this.Version = Reader.ReadUInt32();
                if (this.Version > 0)
                    return false;
                this.Version2 = Reader.ReadUInt32();
                var Length = Reader.ReadByte();
                this.MainMod2 = System.Text.Encoding.Unicode.GetString(Reader.ReadBytes(sizeof(char) * Length));
                return true;
            }

            public override void Write(System.IO.BinaryWriter Writer)
            {
                Writer.Write(this.Version);
                Writer.Write(this.Version2);
                Writer.Write((byte)this.MainMod2.Length);
                Writer.Write(System.Text.Encoding.Unicode.GetBytes(this.MainMod2));
            }

            public override void Reset()
            {
                this.MainMod2 = null;
            }
        }

        public class THackCustomSaveDataLauncherVersion : THackCustomSaveData
        {
            public uint Version;
            public uint Version2;
            public string Version3;

            public override string ToString() => $"{base.ToString()} = {ValueStringToString(this.Version3)}";

            public THackCustomSaveDataLauncherVersion() : base("LauncherVersion")
            {

            }

            public override bool ShouldInclude() => this.Version3 != null;

            public override int GetSize()
            {
                return
                    sizeof(uint) +//Version
                    sizeof(uint) +//Version2
                    sizeof(byte) +//Length
                    /*System.Text.Encoding.Unicode.GetByteCount(this.Version)*/sizeof(char) * this.Version3.Length;
            }

            public override bool Read(System.IO.BinaryReader Reader, uint Size)
            {
                this.Version3 = null;
                this.Version = Reader.ReadUInt32();
                if (this.Version > 0)
                    return false;
                this.Version2 = Reader.ReadUInt32();
                var Length = Reader.ReadByte();
                this.Version3 = System.Text.Encoding.Unicode.GetString(Reader.ReadBytes(sizeof(char) * Length));
                return true;
            }

            public override void Write(System.IO.BinaryWriter Writer)
            {
                Writer.Write((uint)0);//Version
                Writer.Write(this.Version2);
                Writer.Write((byte)this.Version3.Length);
                Writer.Write(System.Text.Encoding.Unicode.GetBytes(this.Version3));
            }

            public override void Reset()
            {
                this.Version3 = null;
            }
        }

        public THackCustomSaveDataGroup HackCustomSaveDataMerchandise = new("Merchandise");
        public THackCustomSaveDataMerchandiseNames HackCustomSaveDataMerchandiseNames = new();
        public THackCustomSaveDataMainMod HackCustomSaveDataMainMod = new();
        public THackCustomSaveDataLauncherVersion HackCustomSaveDataLauncherVersion = new();

        public override string ToString() => this.HackCustomSaveDataGroup.ToString();

        private void OnCustomSaveDataAddHack()
        {
            AddKnownHackCustomSaveData(this.HackCustomSaveDataMerchandise);
            this.HackCustomSaveDataMerchandise.AddKnownHackCustomSaveData(this.HackCustomSaveDataMerchandiseNames);
            AddKnownHackCustomSaveData(this.HackCustomSaveDataMainMod);
            AddKnownHackCustomSaveData(this.HackCustomSaveDataLauncherVersion);
        }

        public CustomSaveData()
        {
            OnIncreasedRewardLimitsLoad();
            OnCustomSaveDataAddHack();
            OnIncreasedRewardLimitsAddHack();
        }

        public bool Load(System.IO.BinaryReader Reader)
        {
            Reset();
            return Read(Reader);
        }
    }
}