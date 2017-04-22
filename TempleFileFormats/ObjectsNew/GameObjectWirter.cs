using System;
using System.IO;
using ArcanumFileFormats.Common;
using ArcanumFileFormats.Utils;
using ArcanumFileFormats.ObjectsNew.Legacy;
using ArcanumFileFormats.ObjectsNew;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using ArcanumFileFormats.Config;

namespace ArcanumFileFormats.ObjectsNew
{
	public static class GameObjectWirter_
	{
		public static void GameObjectWirter (this BinaryWriter writer, GameObject obj)
		{
			writer.GameObjectHeaderWriter (obj.Header);

			GameObject prototype = new GameObject();

			if (!obj.Header.IsPrototype ()) 
			{
				prototype = ObjectConfig.ObjectList.Find (x => x.Header.ObjectId.GetId().CompareTo (obj.Header.ProtoId.GetId()) == 0);
			}

			Type gameobject_obj_type = Type.GetType("ArcanumFileFormats.ObjectsNew." + obj.Header.GameObjectType.ToString()); //TODO: See Key_Ring
			Type binary_writer = Type.GetType ("ArcanumFileFormats.Utils.BinaryWriterUtils"); //TODO: See Key_Ring

			var props = from p in gameobject_obj_type.GetProperties()
					where p.CanWrite
				orderby p.PropertyOrder() 
				select p;

			PropertyInfo[] prop = props.ToArray ();

			for (int i = 0; i < prop.Length; i++) 
			{
				int bit = (int)Enum.Parse (typeof(ObjectField), prop [i].Name);
				if (obj.Header.bitmap.Get (bit, obj.Header.IsPrototype ())) 
				{
					MethodInfo writeMethod = binary_writer.GetMethod(prop[i].PropertyType.Name.Contains("Tuple") ? "WriteArray" : "Write" + prop[i].PropertyType.Name);
					if (writeMethod.IsGenericMethod) 
					{
						string generic_type_name = prop[i].PropertyType.FullName.Replace ("System.Tuple`2[[", "").Split (new char[]{ ',' })[0].Replace("[]","");
						writeMethod = writeMethod.MakeGenericMethod (Type.GetType(generic_type_name));
					}
					writeMethod.Invoke(binary_writer, new Object[] { writer, prop[i].GetValue (obj.Obj) });
				}
			}
		}
	}
}

