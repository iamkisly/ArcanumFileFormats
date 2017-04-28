using System;

namespace ArcanumFileFormats.ObjectsNew.Flags
{
	[Flags]
	public enum obj_f_scenery_flags_
	{
		OSCF_NO_AUTO_ANIMATE = 1,
		OSCF_BUSTED,
		OSCF_NOCTURNAL,
		OSCF_MARKS_TOWNMAP,
		OSCF_IS_FIRE,
		OSCF_RESPAWNABLE,
		OSCF_SOUND_SMALL,
		OSCF_SOUND_MEDIUM,
		OSCF_SOUND_EXTRA_LARGE
	}
}

