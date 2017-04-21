using ArcanumFileFormats.Common;
using ArcanumFileFormats.ObjectsNew.Legacy;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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
            writer.Write(Int32.Parse("0x" + id.path));
        }

        public static void WriteArtId(this BinaryWriter writer, Location loc)
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
            WriteObjectGuid(writer, obj, false);
        }

        public static void WriteObjectGuid(this BinaryWriter writer, ObjectGuid obj, bool wo_header)
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

        public static void ReadArray0<T>(this BinaryWriter writer, T[] unk)
        {
            if (unk == null)
            {
                writer.Write((byte)0x00);
                return;
            }
            else
            {
                writer.Write((byte)0x01);

                writer.Write(0x00); //TODO: Inr32
                writer.Write(unk.Length);
                var headerUnk = new Random().Next();
                writer.Write(headerUnk);

                Type this_type = MethodBase.GetCurrentMethod().DeclaringType;
                MethodInfo WriteMethod = this_type.GetMethod("Write" + typeof(T).Name);

                for (int i = 0; i < unk.Length; i++)
                {
                    WriteMethod.Invoke(this_type, new Object[] { writer });
                }
            }
        }

    }
}
