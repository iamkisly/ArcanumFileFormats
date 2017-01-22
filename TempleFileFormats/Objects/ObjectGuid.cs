using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempleFileFormats.Objects
{

	public class ObjectGuid
	{

		public const short TYPE_PROTO = -1;

		public short Type { get; set; }

		public short Foo { get; set; }

		public int Foo2 { get; set; }

		public Guid GUID { get; set; }

		public bool IsProto
		{
			get
			{
				return Type == TYPE_PROTO;
			}
		}

		public override string ToString()
		{
			return String.Format("{0} {1} {2} {3}", Type, Foo, Foo2, GUID);
		}

	}
}
