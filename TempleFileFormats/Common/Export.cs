using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsonFx = Pathfinding.Serialization.JsonFx;

namespace TempleFileFormats.Common
{
	public class Export<T>
	{
		private readonly T obj;
		private string text;

		public Export(T obj)
		{
			this.obj = obj;
			text = JsonFx.JsonWriter.Serialize(obj);
		}

		public string GetText()
		{
			return text;
		}
	}
}
