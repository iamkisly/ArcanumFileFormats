using System;

namespace ArcanumFileFormats.ObjectsNew.Flags
{
	[Flags]
	public enum obj_f_portal_flags_
	{
		OPF_LOCKED = 1,
		OPF_JAMMED,
		OPF_MAGICALLY_HELD,
		OPF_NEVER_LOCKED,
		OPF_ALWAYS_LOCKED,
		OPF_LOCKED_DAY,
		OPF_LOCKED_NIGHT,
		OPF_BUSTED,
		OPF_STICKY
	}
}

