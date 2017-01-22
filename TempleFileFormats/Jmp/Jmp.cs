using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace TempleFileFormats.Jmp
{
	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct Jmp
	{
		[MarshalAs(UnmanagedType.U4)]
		public uint jump_count;

		[MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.Struct)]
		public Jump[] jumps;
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct Jump
	{
		[MarshalAs(UnmanagedType.U4)]
		public uint unk1; //always 0

		[MarshalAs(UnmanagedType.U4)]
		public uint unk2; //always 0

		[MarshalAs(UnmanagedType.U4)]
		public uint x_coord;

		[MarshalAs(UnmanagedType.U4)]
		public uint y_coord;

		[MarshalAs(UnmanagedType.U4)]
		public uint jump_map_id;

		[MarshalAs(UnmanagedType.U4)]
		public uint unk4;

		[MarshalAs(UnmanagedType.U4)]
		public uint dest_x_coord;

		[MarshalAs(UnmanagedType.U4)]
		public uint dest_y_coord;
	}
}
