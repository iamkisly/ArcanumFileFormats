using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TempleFileFormats.Common;
using TempleFileFormats.Objects;

namespace TempleFileFormats.Maps
{
	public class Sector
	{

		public IList<SectorLight> Lights { get; private set; }

		public SectorTile[] Tiles { get; private set; }

		public List<GameObject> Objects { get; private set; }

		public ObjectScript SectorScript { get; set; }

		public List<TileScript> TileScripts { get; private set; }

		public Sector()
		{
			Lights = new List<SectorLight>();
			Tiles = new SectorTile[4096];
			Objects = new List<GameObject>();
			TileScripts = new List<TileScript>();
		}

		public static uint GetSectorLoc(int x, int y)
		{
			return ((uint)y << 26) & 0xFC | ((uint)x & 0xFC);
		}

	}

	public struct SectorTile
	{
		public byte[] Data { get; set; }
	}

	public class SectorLight
	{
		public ulong Handle { get; set; }
		public Location Position { get; set; } // x, y, offsx, offsy
        public int offset_X { get; set; }
        public int offset_Y { get; set; }
		public int FLAGS_0 { get; set; }
		public int ART { get; set; }
		public int COLOR_0 { get; set; }
		public int COLOR_1 { get; set; }
		public int UNK_0 { get; set; } // MAYBE FLAGS
        public int UNK_1 { get; set; }

    }

    public class TileScript
	{
		public int F1 { get; set; }
		public int F2 { get; set; }
		public int F3 { get; set; }
		public int F4 { get; set; }
		public int F5 { get; set; }
		public int F6 { get; set; }

		public override string ToString()
		{
			return String.Format("{0} {1} {2} {3} {4} {5}", F1, F2, F3, F4, F5, F6);
		}
	}

}
