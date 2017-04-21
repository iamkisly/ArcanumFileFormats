using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ArcanumFileFormats.Common
{
	public class Export<T>
	{
		private readonly T obj;
		private string text;

		public Export(T obj)
		{
			this.obj = obj;
			text = JsonConvert.SerializeObject(obj);
		}

		public string GetText()
		{
			return text;
		}
	}
}
