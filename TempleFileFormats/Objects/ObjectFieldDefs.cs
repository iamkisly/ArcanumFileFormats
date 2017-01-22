using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempleFileFormats.Objects
{
	public enum ObjectFieldType
	{
		None = 0,
		SectionBegin,
		SectionEnd,
		Int32,
		Int64,
        Float32,
        
        Int32Array,
		Int64Array,
		

        Unk,
        UnkArray,

        String,

		Obj,
		ObjArray,
		
        Flags,
        Color,

        AbilityArray,
        ScriptArray,
        SpellArray

    }

	/// <summary>
	/// Specifies properties of a field.
	/// </summary>
	public class ObjectFieldDef
	{
		public int Field4 { get; private set; }
		public int BitmapIndex { get; private set; }
		public uint BitmapMask { get; private set; }
		public int BitmapBit { get; private set; }
		public bool InCollection { get; private set; }
		public ObjectFieldType FieldType { get; private set; }

		public ObjectFieldDef(int field4, int bitmapIdx, uint bitmapMask, int bitmapBit, bool inCollection, ObjectFieldType fieldType)
		{
			this.Field4 = field4;
			this.BitmapIndex = bitmapIdx;
			this.BitmapMask = bitmapMask;
			this.BitmapBit = bitmapBit;
			this.InCollection = inCollection;
			this.FieldType = fieldType;
		}
	}

	/// <summary>
	/// Specifies properties for all object fields.
	/// </summary>
	public static partial class ObjectFieldDefs
	{

		private static readonly ObjectFieldDef[] fields;

		static ObjectFieldDefs()
		{
			fields = new ObjectFieldDef[430];

			InitializeTable();

			for (int i = 0; i < fields.Length; ++i)
			{
				if (fields[i] == null)
				{
					//throw new InvalidOperationException("Field " + i + " has not been initialized.");
				}
			}
		}

		public static ObjectFieldDef Get(ObjectField field)
		{
			return fields[(int)field];
		}

	}

}
