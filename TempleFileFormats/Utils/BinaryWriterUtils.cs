using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempleFileFormats.Utils
{
	static class BinaryWriterUtils
	{

		/// <summary>
		/// Writes a string prefixed with its length as a 32-bit integer using the default platform encoding.
		/// The string is not null terminated.
		/// </summary>
		/// <param name="writer"></param>
		/// <param name="str"></param>
		public static void WritePrefixedString(this BinaryWriter writer, string str)
		{
			var bytes = Encoding.Default.GetBytes(str);
			writer.Write(bytes.Length);
			writer.Write(bytes);
		}

	}
}
