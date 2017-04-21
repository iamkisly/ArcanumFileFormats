using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ArcanumFileFormats.FacWalk
{
	public class FacWalk
	{
		public FacWalkHeader Header;
		public FacWalkEntry[] Entrys;
	}


	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct FacWalkHeader
	{
		//public char[] marker;

		// base terrain, index + outdoor + flippable
		[MarshalAs(UnmanagedType.U4)]
		public uint terrain; // index to tilename.mes

		[MarshalAs(UnmanagedType.U4)]
		public uint outdoor; // boolean, 1 = outdoor

		[MarshalAs(UnmanagedType.U4)]
		public uint flippable; // boolean, 1 = flippable

		[MarshalAs(UnmanagedType.U4)]
		public uint width; // width of facade, isometric

		[MarshalAs(UnmanagedType.U4)]
		public uint height; // height of facade, isometric

		[MarshalAs(UnmanagedType.U4)]
		public uint entryCount; // equals to number of frames of equivalent Art file.
	};

	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct FacWalkEntry
	{
		[MarshalAs(UnmanagedType.U4)]
		public uint x; // x position

		[MarshalAs(UnmanagedType.U4)]
		public uint y; // y position

		[MarshalAs(UnmanagedType.U4)]
		public uint walkable; // boolean, 0 = blocked
	};
}
