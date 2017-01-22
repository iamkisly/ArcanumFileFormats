using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TempleFileFormats.Utils;

namespace TempleFileFormats.Jmp
{
	public class JmpReader
	{
		private readonly BinaryReader reader;

		public JmpReader(BinaryReader reader)
		{
			this.reader = reader;
		}

		public Jmp Read()
		{
			Jmp j = new Jmp();
			j.jump_count = reader.ReadUInt32();

			if (j.jump_count != 0x00)
			{
				j.jumps = new Jump[j.jump_count];

				for (int i = 0; i < j.jump_count; i++)
				{
					j.jumps[i] = MarshalUtils.ByteArrayToStructure<Jump>(reader);
				}
			}
			return j;
		}
	}
}