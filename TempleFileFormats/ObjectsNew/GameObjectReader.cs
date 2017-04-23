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
	public static class GameObjectReader_
    {
		public static GameObject GameObjectReader(this BinaryReader reader)
        {
            GameObject g = new GameObject();
			GameObject prototype = new GameObject();

			g.Header = reader.GameObjectHeaderReader ();

			if (!g.Header.IsPrototype ()) {
				prototype = ObjectConfig.ObjectList.Find (x => x.Header.ObjectId.GetId().CompareTo (g.Header.ProtoId.GetId()) == 0);
			} 

			Type gameobject_obj_type = Type.GetType("ArcanumFileFormats.ObjectsNew." + g.Header.GameObjectType.ToString()); //TODO: See Key_Ring
			Type binary_reader = Type.GetType ("ArcanumFileFormats.Utils.BinaryReaderUtils"); //TODO: See Key_Ring
			g.Obj = Activator.CreateInstance(gameobject_obj_type);


			var props = from p in gameobject_obj_type.GetProperties()
				where p.CanWrite
				orderby p.PropertyOrder() 
				select p;
			
			PropertyInfo[] prop = props.ToArray ();

			for (int i = 0; i < prop.Length; i++) 
			{
				int bit = (int)Enum.Parse (typeof(ObjectField), prop[i].Name);

				MethodInfo readMethod = binary_reader.GetMethod(prop[i].PropertyType.Name.Contains("Tuple") ? "ReadArray" : "Read" + prop[i].PropertyType.Name);
				if (readMethod.IsGenericMethod) 
				{
					string generic_type_name = prop[i].PropertyType.FullName.Replace ("System.Tuple`2[[", "").Split (new char[]{ ',' })[0].Replace("[]","");
					readMethod = readMethod.MakeGenericMethod (Type.GetType(generic_type_name));
				}


				List<Object> parameters = new List<Object>() { reader };
				/*
				if (readMethod.GetParameters ().Length > 1) {
					parameters.Add (false);
				}
				*/

				if (g.Header.bitmap.Get (bit, g.Header.IsPrototype ())) 
				{
					prop[i].SetValue(g.Obj, readMethod.Invoke (binary_reader, parameters.ToArray()));
				} 
				else 
				{
					if (prototype != null) 
					{
						Type temp_type = prototype.Obj.GetType ();
						PropertyInfo temp_property = temp_type.GetProperty (prop [i].Name);
						Object temp_obj = temp_property.GetValue (prototype.Obj);
						prop [i].SetValue (g.Obj, temp_obj);
						//Console.Read ();
					} 
				}
			}
            return g;
        }


    }
}
