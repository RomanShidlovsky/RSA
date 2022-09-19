using System;
using System.IO;


namespace RSA
{
    public class FileProc
    {
        public static byte[] ReadFileByByte(string path)
        {

            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                int length = (int)reader.BaseStream.Length;
                byte[] res = new byte[length];
                res = reader.ReadBytes(length);
                return res;
            }
        }

        public static ushort[] ReadFileByShort(string path)
        {

            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                int length = (int)reader.BaseStream.Length / 2;
                ushort[] res = new ushort[length];
                for (int i = 0; i < length; i++)
                {
                    res[i] = reader.ReadUInt16();
                }
                return res;
            }
        }

        public static string WriteByteBinary(byte[] arr)
        {
            string res = "";
            foreach (byte b in arr)
            {
                res += Convert.ToString(b, 2).PadLeft(8, '0') + " ";
            }
            return res;
        }

        public static void WriteFileByInt16(string path, ushort[] data)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                foreach (ushort us in data)
                {
                    writer.Write(us);
                }
            }
        }

        public static void WriteFileByByte(string path, byte[] data)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                foreach (byte b in data)
                {
                    writer.Write(b);
                }
            }
        }
    }
}
