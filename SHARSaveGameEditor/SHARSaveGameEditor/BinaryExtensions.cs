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

        public static string ReadASCIIString(byte[] data, int pos, int length) => Encoding.ASCII.GetString(data, pos, length);

        public static string ReadUnicodeString(byte[] data, int pos, int length) => Encoding.Unicode.GetString(data, pos, length * 2);

        public static void WriteNullTerminatedString(BinaryWriter writer, string value, int length)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(value);

            if (bytes.Length >= length)
            {
                writer.Write(bytes, 0, length);
            }
            else
            {
                writer.Write(bytes);
                for (int i = bytes.Length; i < length; i++)
                    writer.Write((byte)0);
            }
        }
    }
}
