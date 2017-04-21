using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;


namespace ArcanumFileFormats.Utils
{
	public static class MarshalUtils
	{
		public static T ByteArrayToStructure<T>(byte[] bytes) where T : struct
		{
			GCHandle handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
			T stuff = (T)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(T));
			handle.Free();
			return stuff;
		}

		public static T ByteArrayToStructure<T>(byte[] bytes, uint index) where T : struct
		{
			int size = Marshal.SizeOf(typeof(T));
			byte[] temp = new byte[size];
			Array.Copy(bytes, index, temp, 0, size);
			return ByteArrayToStructure<T>(temp);
		}

		public static T ByteArrayToStructure<T>(byte[] bytes, uint index, uint size) where T : struct
		{
			byte[] temp = new byte[size];
			Array.Copy(bytes, index, temp, 0, size);
			return ByteArrayToStructure<T>(temp);
		}

		public static T ByteArrayToStructure<T>(BinaryReader reader) //where T : struct
		{
			int count = Marshal.SizeOf(typeof(T));
			byte[] bytes = new byte[count];
			bytes = reader.ReadBytes(count);
			GCHandle handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
			T stuff = (T)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(T));
			handle.Free();
			return stuff;
		}
	}
}


/*
uint x = 0x12345678;  // For example...
byte nibble1 = (byte)(x & 0x0F);
byte nibble2 = (byte)((x & 0xF0) >> 4);
byte nibble3 = (byte)((x & 0xF00) >> 8);
byte nibble4 = (byte)((x & 0xF000) >> 12);
byte nibble5 = (byte)((x & 0xF0000) >> 16);
byte nibble6 = (byte)((x & 0xF00000) >> 20);
byte nibble7 = (byte)((x & 0xF000000) >> 24);
byte nibble8 = (byte)((x & 0xF0000000) >> 28);
Console.WriteLine(nibble1);
Console.WriteLine(nibble2);
Console.WriteLine(nibble3);
Console.WriteLine(nibble4);
Console.WriteLine(nibble5);
Console.WriteLine(nibble6);
Console.WriteLine(nibble7);
Console.WriteLine(nibble8);
*/
