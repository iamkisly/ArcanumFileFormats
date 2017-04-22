using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArcanumFileFormats.Common;
using ArcanumFileFormats.Utils;
using ArcanumFileFormats.ObjectsNew.Legacy;
using System.Collections;
using System.Runtime.InteropServices;
using System.Reflection;

namespace ArcanumFileFormats.Utils
{
	public static class BinaryReaderUtils
    {
        /// <summary>
        /// Reads a string from the stream that is prefixed with a 32-bit integer containing its length. The
        /// string is assumed to not be null terminated. The string is decoded using the default encoding for
        /// this platform.
        /// </summary>
        /// <param name="reader">The reader to read from.</param>
        /// <returns>The string read from the reader.</returns>
        public static PrefixedString ReadPrefixedString(this BinaryReader reader)
        {
            if (reader.ReadByte() != 0x00)
            {
                var length = reader.ReadInt32();
                var data = reader.ReadBytes(length);
                return new PrefixedString(Encoding.Default.GetString(data));
            }
            return null;
            // Decode using local encoding

        }

		public static ArtId ReadArtId(this BinaryReader reader)
        {
			return new ArtId(){ path = reader.ReadInt32().ToString("X2") };
        }

        /// <summary>
        /// Reads a 8-byte game location from the stream.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="loc"></param>
        public static Location ReadLocation(this BinaryReader reader)
        {
            var loc = new Location();
            if (reader.ReadByte() != 0x00)
            {
                loc.X = reader.ReadInt32();
                loc.Y = reader.ReadInt32();
            }
            return loc;
        }

        /// <summary>
        /// Reads a ToEE object id from the reader.
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
		public static ObjectGuid ReadObjectGuid_(this BinaryReader reader, bool force = false)
        {
            var result = new ObjectGuid();
			if (force || reader.ReadByte () != 0x00) 
			{
				result.Type = reader.ReadInt16 ();
				result.Foo0 = reader.ReadInt16 ();
				result.Foo2 = reader.ReadInt32 ();
				var guidData = reader.ReadBytes (16);
				result.GUID = new Guid (guidData);
				return result;
			}
			return null;
        }

        public static ObjectGuid ReadObjectGuid(this BinaryReader reader)
        {
            return ReadObjectGuid_(reader, false);
        }

        public static Color ReadColor(this BinaryReader reader)
        {
            Color color = new Color(reader.ReadInt32());
            return color;
        }

		public static Int32 ReadInt32(this BinaryReader reader)
		{
			return reader.ReadInt32();
		}

        public static Unknown ReadUnknown(this BinaryReader reader)
        {
            if (reader.ReadByte() != 0x00)
            {
                throw new Exception("Not Unknown : Exist Data.");
            }

            return new Unknown();
        }

        public static ObjectScript ReadObjectScript(this BinaryReader reader)
        {
            //TODO: Only in Array ?
            ObjectScript script = new ObjectScript();

            script.Counters = reader.ReadBytes(4);
            script.Flags = reader.ReadInt32();
            script.ScriptId = reader.ReadInt32();

            return script;
        }

		public static Tuple<T[], int[]> ReadArray<T>(this BinaryReader reader)
        {
            if (reader.ReadByte() == 0x00)
            {
                return null;
            }

            var elementSize = reader.ReadInt32();
            var elementCount = reader.ReadInt32();
            var headerUnk = reader.ReadInt32();

            var payloadSize = elementCount * elementSize;

            List<T> result = null;
			Int32[] flags = null;

            if (payloadSize > 0)
            {
                result = new List<T>();

                Type this_type = MethodBase.GetCurrentMethod().DeclaringType;
                MethodInfo ReadMethod = this_type.GetMethod("Read" + typeof(T).Name);

                for (int i = 0; i < elementCount; i++)
				{	

					var obj = ReadMethod.Invoke (this_type, new Object[] {reader});
					result.Add ((T)obj);
                }
                var count = reader.ReadInt32();
				flags = new Int32[count];

                for (var i = 0; i < count; i++)
                {
					flags[i] = reader.ReadInt32();
                }


				return new Tuple<T[], int[]>(result.ToArray(), flags);
            }
			return null;
        }
    }

    static class BitArrayUtils
    {
        public static bool Get(this BitArray bitarray, int index, bool is_proto)
        {
            return bitarray.Get(index) || is_proto;
        }
    }

	static class PropertyInfoUtils
	{
		public static int PropertyOrder(this PropertyInfo propInfo)
		{
			int output;
			var orderAttr = (OrderAttribute)propInfo.GetCustomAttributes(typeof(OrderAttribute), true).SingleOrDefault();
			output = orderAttr != null ? orderAttr.Order : Int32.MaxValue;
			return output;
		}
	}
}
