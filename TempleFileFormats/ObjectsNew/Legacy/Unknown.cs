using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcanumFileFormats.ObjectsNew.Legacy
{
    public class Unknown
    {
        public byte Unk = 0x00;

		public override string ToString()
		{
			return Unk.ToString();
		}
	}
}
