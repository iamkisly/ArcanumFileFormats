using System;
using System.IO;
using ArcanumFileFormats.Common;
using ArcanumFileFormats.Utils;
using ArcanumFileFormats.ObjectsNew.Legacy;
using System.Collections;


namespace ArcanumFileFormats.ObjectsNew
{
    public class GameObjectHeader
    {
        public string filename;

        public int version;
        public ObjectGuid ProtoId { get; set; }
        public ObjectGuid ObjectId { get; set; } 
        public ObjectType GameObjectType { get; set; }
        public short propCollectionItems;
        public BitArray bitmap;

        public bool IsPrototype()
        {
			return ProtoId.IsProto();
        }
    }
}