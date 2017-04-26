using System;

namespace ArcanumFileFormats.ObjectsNew.Flags
{
	public enum ObjectFlagsWeapon
	{
		//Obj_Weapon_Flag
		OWF_LOUD = 1,           //[0] 0x01
		OWF_SILENT,             //[0] 0x02
		OWF_TWO_HANDED,         //[0] 0x04
		OWF_HAND_COUNT_FIXED,   //[0] 0x08
		OWF_THROWABLE,          //[0] 0x10
		OWF_TRANS_PROJECTILE,
		OWF_BOOMERANGS,         //[0] 0x40
		OWF_IGNORE_RESISTANCE,
		OWF_DAMAGE_ARMOR,
		OWF_DEFAULT_THROWS
	}
}

