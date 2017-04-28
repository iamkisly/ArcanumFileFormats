using System;

namespace ArcanumFileFormats.ObjectsNew.Flags
{
	[Flags]
	public enum obj_f_weapon_flags_
	{
		OWF_LOUD = 1,           
		OWF_SILENT,             
		OWF_TWO_HANDED,         
		OWF_HAND_COUNT_FIXED,   
		OWF_THROWABLE,          
		OWF_TRANS_PROJECTILE,
		OWF_BOOMERANGS,         
		OWF_IGNORE_RESISTANCE,
		OWF_DAMAGE_ARMOR,
		OWF_DEFAULT_THROWS
	}
}

