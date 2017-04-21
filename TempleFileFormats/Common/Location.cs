using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcanumFileFormats.Common
{
	public class Location
	{
		public int X { get; set; }
		public int Y { get; set; }

		public override string ToString()
		{
			return String.Format("{0},{1}", X, Y);
		}
	}
}
