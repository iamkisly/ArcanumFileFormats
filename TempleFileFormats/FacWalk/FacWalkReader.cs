using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArcanumFileFormats.Utils;

namespace ArcanumFileFormats.FacWalk
{
	public class FacWalkReader
	{
		private readonly BinaryReader reader;

		public FacWalkReader(BinaryReader reader)
		{
			this.reader = reader;
		}

		private readonly byte[] FACWALK_MARKER = Encoding.ASCII.GetBytes(new char[] { 'F', 'a', 'c', 'W', 'a', 'l', 'k', ' ', 'V', '1', '0', '1', ' ', ' ' });

		public FacWalk Read()
		{
			var version = reader.ReadBytes(14);
			if (!version.SequenceEqual(FACWALK_MARKER))
			{
				throw new InvalidDataException("Unknown object file version: " + version);
			}

			FacWalk obj = new FacWalk();

			obj.Header = MarshalUtils.ByteArrayToStructure<FacWalkHeader>(reader);
			obj.Entrys = new FacWalkEntry[obj.Header.entryCount];
			for (int i = 0; i < obj.Header.entryCount; i++)
			{
				obj.Entrys[i] = MarshalUtils.ByteArrayToStructure<FacWalkEntry>(reader);
			}

			return obj;
		}
	}
}
