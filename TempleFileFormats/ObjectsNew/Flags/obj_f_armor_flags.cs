using System;

namespace ArcanumFileFormats.ObjectsNew.Flags
{
	[Flags]
	public enum obj_f_armor_flags_
	{
		OARF_SIZE_SMALL = 1,
		OARF_SIZE_MEDIUM,
		OARF_SIZE_LARGE,
		OARF_MALE_ONLY,
		OARF_FEMALE_ONLY
	}
}

