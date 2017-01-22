using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TempleFileFormats.Common;
using TempleFileFormats.Objects;

namespace TempleFileFormats.Utils
{
	static class BinaryReaderUtils
	{
		/// <summary>
		/// Reads a string from the stream that is prefixed with a 32-bit integer containing its length. The
		/// string is assumed to not be null terminated. The string is decoded using the default encoding for
		/// this platform.
		/// </summary>
		/// <param name="reader">The reader to read from.</param>
		/// <returns>The string read from the reader.</returns>
		public static string ReadPrefixedString(this BinaryReader reader)
		{
			var length = reader.ReadInt32();
			var data = reader.ReadBytes(length);

			// Decode using local encoding
			return Encoding.Default.GetString(data);
		}

		/// <summary>
		/// Reads a 8-byte game location from the stream.
		/// </summary>
		/// <param name="reader"></param>
		/// <param name="loc"></param>
		public static Location ReadLocation(this BinaryReader reader)
		{
			var loc = new Location();
			loc.X = reader.ReadInt32();
			loc.Y = reader.ReadInt32();
			return loc;
		}

		/// <summary>
		/// Reads a ToEE object id from the reader.
		/// </summary>
		/// <param name="reader"></param>
		/// <returns></returns>
		public static ObjectGuid ReadObjectGuid(this BinaryReader reader)
		{
			var result = new ObjectGuid();

			result.Type = reader.ReadInt16();
			result.Foo = reader.ReadInt16();
			result.Foo2 = reader.ReadInt32();
			var guidData = reader.ReadBytes(16);
			result.GUID = new Guid(guidData);

			return result;
		}



	}

}
