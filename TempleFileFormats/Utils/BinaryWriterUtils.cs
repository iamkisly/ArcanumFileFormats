using ArcanumFileFormats.Common;
using ArcanumFileFormats.ObjectsNew.Legacy;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ArcanumFileFormats.Config;
using System.Runtime.InteropServices;

namespace ArcanumFileFormats.Utils
{
	public static class BinaryWriterUtils
	{

		/// <summary>
		/// Writes a string prefixed with its length as a 32-bit integer using the default platform encoding.
		/// The string is not null terminated.
		/// </summary>
		/// <param name="writer"></param>
		/// <param name="str"></param>
		public static void WritePrefixedString(this BinaryWriter writer, string str)
		{
            if(str != String.Empty)
            {
                writer.Write((byte)0x01);
                var bytes = Encoding.Default.GetBytes(str);
                writer.Write(bytes.Length);
                writer.Write(bytes);
            }
            else
            {
                writer.Write((byte)0x00);
            }
		}

        public static void WriteArtId(this BinaryWriter writer, ArtId id)
        {
			Int32 i = Convert.ToInt32(id.path, 16);
			writer.Write(i);
        }

		public static void WriteLocation(this BinaryWriter writer, Location loc)
        {
            if (loc.X != 0 && loc.Y != 0)
            {
                writer.Write((byte)0x01);
                writer.Write(loc.X);
                writer.Write(loc.Y);
            }
            else
            {
                writer.Write((byte)0x00);
            }
        }

        public static void WriteObjectGuid(this BinaryWriter writer, ObjectGuid obj)
        {
            WriteObjectGuid_(writer, obj, false);
        }

        public static void WriteObjectGuid_(this BinaryWriter writer, ObjectGuid obj, bool wo_header)
        {
            //
            if(!wo_header)
            {
                writer.Write((byte)0x01);
            }
            writer.Write(obj.Type);
            writer.Write(obj.Foo0);
            writer.Write(obj.Foo2);
            writer.Write(obj.GUID.ToByteArray());
        }

        public static void WriteColor(this BinaryWriter writer, Color color)
        {
            var bytes = new byte[]
            {
                color.B,
                color.G,
                color.R,
                color.A
            };
            writer.Write(bytes);
        }

        public static void WriteInt32(this BinaryWriter writer, Int32 integer)
        {
            writer.Write(integer);
        }
        public static void WriteUnknown(this BinaryWriter writer, Unknown unk)
        {
            writer.Write(unk.Unk);
        }

		public static void WriteArray<T>(this BinaryWriter writer, Tuple<T[], Int32[]> unk)
        {
            if (unk == null)
            {
                writer.Write((byte)0x00);
                return;
            }
            else
            {
                writer.Write((byte)0x01);
				int size = Marshal.SizeOf (default(T));
				writer.Write(size); //TODO: Inr32
				writer.Write(unk.Item1.Length);
				var headerUnk = ObjectConfig.random.Next();
                writer.Write(headerUnk);

                Type this_type = MethodBase.GetCurrentMethod().DeclaringType;
                MethodInfo WriteMethod = this_type.GetMethod("Write" + typeof(T).Name);

				for (int i = 0; i < unk.Item1.Length; i++)
                {
					WriteMethod.Invoke(this_type, new Object[] { writer, unk.Item1[i] });
                }

				int count = unk.Item2.Length;

				writer.Write(count);

				for (var j = 0; j < count; j++)
				{
					writer.Write (unk.Item2 [j]);
				}

            }
        }

    }
}
