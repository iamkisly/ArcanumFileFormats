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

namespace TempleFileFormats.ObjectsNew
{
    public class GameObjectHeaderWriter
    {
        readonly BinaryWriter writer;
        readonly GameObjectHeader header;

        public GameObjectHeaderWriter(BinaryWriter writer, GameObjectHeader header)
        {
            this.writer = writer;
            this.header = header;
        }

        public void Write()
        {
			writer.Write(0x77); //header.version
            writer.WriteObjectGuid(header.ProtoId);
            writer.WriteObjectGuid(header.ObjectId);
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