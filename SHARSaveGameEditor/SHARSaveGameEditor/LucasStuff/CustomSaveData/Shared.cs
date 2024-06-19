namespace LucasStuff
{
    public partial class CustomSaveData
    {
        public abstract class THackCustomSaveData
        {
            public readonly string Name;

            public override string ToString() => this.Name;

            public THackCustomSaveData(string Name)
            {
                this.Name = Name;
            }

            public virtual void Update()
            {

            }

            public abstract bool ShouldInclude();
            public abstract int GetSize();
            public abstract bool Read(System.IO.BinaryReader Reader, uint Size);
            public abstract void Write(System.IO.BinaryWriter Writer);
            public abstract void Reset();
        }

        public class THackCustomSaveDataUnknown : THackCustomSaveData
        {
            public byte[] Data = null;

            public THackCustomSaveDataUnknown(string Name) : base(Name)
            {

            }

            public override bool ShouldInclude() => true;
            public override int GetSize() => this.Data.Length;

            public override bool Read(System.IO.BinaryReader Reader, uint Size)
            {
                this.Data = (Size > 0) ? Reader.ReadBytes((int)Size) : null;
                return true;
            }

            public override void Write(System.IO.BinaryWriter Writer)
            {
                if (this.Data != null)
                    Writer.Write(this.Data);
            }

            public override void Reset() => throw new System.NotSupportedException();
        }

        public class THackCustomSaveDataGroup : THackCustomSaveData
        {
            public uint Version;
            public uint Version2;

            public readonly System.Collections.Generic.Dictionary<string, THackCustomSaveData> HackCustomSaveDataKnown = [];
            public readonly System.Collections.Generic.List<THackCustomSaveData> HackCustomSaveData = [];
            public readonly System.Collections.Generic.List<THackCustomSaveData> HackCustomSaveDataUnknown = [];

            public readonly System.Collections.Generic.List<THackCustomSaveData> HackData = [];

            public THackCustomSaveDataGroup(string Name) : base(Name)
            {

            }

            public void AddKnownHackCustomSaveData(THackCustomSaveData Data)
            {
                this.HackCustomSaveDataKnown[Data.Name] = Data;
                if (!HackCustomSaveData.Contains(Data))
                    this.HackCustomSaveData.Add(Data);
            }

            public override void Update()
            {
                this.HackData.Clear();
                foreach (var it in this.HackCustomSaveData)
                {
                    it.Update();
                    if (it.ShouldInclude())
                        this.HackData.Add(it);
                }
            }

            public override bool ShouldInclude()
            {
                return this.HackData.Count > 0;
            }

            public override int GetSize()
            {
                var Result =
                    sizeof(uint) +//Version
                    sizeof(uint) +//Version2
                    sizeof(uint);//HackDataCount
                foreach (var Data in this.HackData)
                    Result +=
                        sizeof(byte) +
                        Data.Name.Length +
                        sizeof(uint) +
                        Data.GetSize();
                return Result;
            }

            public override bool Read(System.IO.BinaryReader Reader, uint Size)
            {
                this.Version = Reader.ReadUInt32();
                if (this.Version > 0)
                    return false;
                this.Version2 = Reader.ReadUInt32();
                var HackDataCount = Reader.ReadUInt32();
                for (var I = 0; I < HackDataCount; ++I)
                {
                    var HackNameLength = Reader.ReadByte();
                    var HackName = System.Text.Encoding.Default.GetString(Reader.ReadBytes(HackNameLength));
                    var HackDataSize = Reader.ReadUInt32();
                    if (this.HackCustomSaveDataKnown.TryGetValue(HackName, out var Data))
                    {
                        var StartPosition = Reader.BaseStream.Position;
                        Data.Read(Reader, HackDataSize);
                        var EndPosition = StartPosition + HackDataSize;
                        if (Reader.BaseStream.Position != EndPosition)
                            System.Diagnostics.Debugger.Break();
                        Reader.BaseStream.Seek(EndPosition, System.IO.SeekOrigin.Begin);

                        this.HackData.Add(Data);
                    }
                    else
                    {
                        var HackData = new THackCustomSaveDataUnknown(HackName);
                        if (!HackCustomSaveData.Contains(Data))
                            this.HackCustomSaveData.Add(HackData);
                        this.HackCustomSaveDataUnknown.Add(HackData);
                        var StartPosition = Reader.BaseStream.Position;
                        HackData.Read(Reader, HackDataSize);
                        var EndPosition = StartPosition + HackDataSize;
                        if (Reader.BaseStream.Position != EndPosition)
                            System.Diagnostics.Debugger.Break();
                        Reader.BaseStream.Seek(EndPosition, System.IO.SeekOrigin.Begin);

                        this.HackData.Add(HackData);
                    }
                }
                return true;
            }

            public override void Write(System.IO.BinaryWriter Writer)
            {
                Writer.Write(this.Version);
                Writer.Write(this.Version2);
                Writer.Write((uint)this.HackData.Count);
                foreach (var it in this.HackData)
                {
                    Writer.Write((byte)it.Name.Length);
                    Writer.Write(System.Text.Encoding.Default.GetBytes(it.Name));
                    var Size = it.GetSize();
                    Writer.Write((uint)Size);
                    var StartPosition = Writer.BaseStream.Position;
                    it.Write(Writer);
                    var EndPosition = StartPosition + Size;
                    if (Writer.BaseStream.Position != EndPosition)
                        System.Diagnostics.Debugger.Break();
                    Writer.BaseStream.Seek(EndPosition, System.IO.SeekOrigin.Begin);
                }
            }

            public override void Reset()
            {
                foreach (var it in this.HackCustomSaveDataKnown.Values)
                    it.Reset();
                foreach (var it in this.HackCustomSaveDataUnknown)
                    this.HackCustomSaveData.Remove(it);
                this.HackCustomSaveDataUnknown.Clear();

                this.HackData.Clear();
            }
        }

        private partial void AddKnownHackCustomSaveData(THackCustomSaveData HackCustomSaveData);
    }
}