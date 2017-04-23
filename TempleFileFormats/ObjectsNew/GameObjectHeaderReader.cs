using System;
using System.IO;
using ArcanumFileFormats.Common;
using ArcanumFileFormats.Utils;
using ArcanumFileFormats.ObjectsNew.Legacy;
using System.Collections;

namespace ArcanumFileFormats.ObjectsNew
{
    public static class GameObjectHeaderReader_
    {
		public static GameObjectHeader GameObjectHeaderReader(this BinaryReader reader)
        {
            GameObjectHeader header = new GameObjectHeader();

            header.version = reader.ReadInt32();
            if (header.version != 0x77)
            {
                throw new InvalidDataException("Unknown object file version: " + header.version);
            }

            header.ProtoId = reader.ReadObjectGuid_(true);
			header.ObjectId = reader.ReadObjectGuid_(true);

            header.GameObjectType = (ObjectType)reader.ReadUInt32();

			if (!header.ProtoId.IsProto())
            {
                header.propCollectionItems = reader.ReadInt16(); // Actually not really used anymore
            }

            int bitmapLength = (int)Enum.Parse(typeof(Bitmap), header.GameObjectType.ToString());

            header.bitmap = new BitArray(reader.ReadBytes(bitmapLength));

            return header;
        }
    }
}
