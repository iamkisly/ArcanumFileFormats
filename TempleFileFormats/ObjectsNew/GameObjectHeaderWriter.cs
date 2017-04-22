using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using ArcanumFileFormats.Common;
using ArcanumFileFormats.Utils;
using ArcanumFileFormats.ObjectsNew.Legacy;
using System.Collections;
using ArcanumFileFormats.ObjectsNew;

namespace ArcanumFileFormats.ObjectsNew
{
    public static class GameObjectHeaderWriter_
    {

		public static void GameObjectHeaderWriter(this BinaryWriter writer, GameObjectHeader header)
        {
			writer.Write(0x77); //header.version
            writer.WriteObjectGuid_(header.ProtoId, true);
			writer.WriteObjectGuid_(header.ObjectId, true);
			writer.Write ((Int32)header.GameObjectType);
			if (!header.ProtoId.IsProto ())  //TODO: ARGS & save as proto ?
			{
				writer.Write (header.propCollectionItems);
			}
			var bytes = new byte[header.bitmap.Length/8];
			header.bitmap.CopyTo (bytes, 0);
			writer.Write(bytes);
        }
    }
}