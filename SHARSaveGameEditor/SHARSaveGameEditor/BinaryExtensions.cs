using System;
using System.IO;
using System.Text;

namespace SHARSaveGameEditor
{
    public static class BinaryExtensions
    {
        public static string ReadNullTerminatedString(BinaryReader reader, int length)
        {
            byte[] bytes = reader.ReadBytes(length);

            int nullIndex = Array.IndexOf(bytes, (byte)0);

            if (nullIndex == -1)
                nullIndex = length;

            return Encoding.ASCII.GetString(bytes, 0, nullIndex);
        }

        public static void WriteNullTerminatedString(BinaryWriter writer, string value, int length)
        {
            if (length <= 0)
                return;

            value ??= string.Empty;

            byte[] bytes = Encoding.ASCII.GetBytes(value);
            Array.Resize(ref bytes, length);
            bytes[length - 1] = 0;

            writer.Write(bytes);
        }
    }
}
