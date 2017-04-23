using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ArcanumFileFormats.ObjectsNew.Legacy
{
    public class ObjectGuid
    {
		public short Type;
		public short Foo0;

		public int Foo2;


		public Guid GUID;


		public bool IsProto()
        {
        	return Type == -1;
        }

		public Int32 GetId()
		{
			return BitConverter.ToInt32 (GUID.ToByteArray (), 0);
		}


        public override string ToString()
        {
			return String.Format("{0} {1} {2} {3}", Type, Foo0.ToString("x8"), Foo2.ToString("x8"), GUID);
        }
    }
}
