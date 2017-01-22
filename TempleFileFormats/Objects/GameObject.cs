using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempleFileFormats.Objects
{
	public class GameObject
	{

		public ObjectType Type { get; set; }

		public ObjectGuid Id { get; set; }

		public ObjectGuid ProtoId { get; set; }

		public IDictionary<ObjectField, object> Properties { get; private set; }

		public GameObject()
		{
			Properties = new Dictionary<ObjectField, object>();
		}

	}

}
