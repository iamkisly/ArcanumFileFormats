﻿using System;

namespace ArcanumFileFormats.ObjectsNew.Flags
{
	[Flags]
	public enum obj_f_container_flags_
	{
		OCOF_LOCKED = 1,
		OCOF_JAMMED,
		OCOF_MAGICALLY_HELD,
		OCOF_NEVER_LOCKED,
		OCOF_ALWAYS_LOCKED,
		OCOF_LOCKED_DAY,
		OCOF_LOCKED_NIGHT,
		OCOF_BUSTED,
		OCOF_STICKY
	}
}

