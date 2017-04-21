using System;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Reflection;

namespace ArcanumFileFormats.Utils
{
	class OrderAttribute : Attribute
	{
		public int Order { get; private set; }
		public OrderAttribute(int order)
		{
			Order = order;
		}
	}


}

