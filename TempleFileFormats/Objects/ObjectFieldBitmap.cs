using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempleFileFormats.Objects
{
	public enum Bitmap : int
	{
		Wall = 3,
		Portal = 3,
		Container = 3,
		Scenery = 3,
		Projectile = 3,
		Weapon = 4,
		Ammo = 4,
		Armor = 4,
		Gold = 4,
		Food = 4,
		Scroll = 4,
		Key = 4,
		Key_Ring = 4,
		Written = 4,
		Generic = 4,
		PC = 5,
		NPC = 5,
		Trap = 3
	}

	class ObjectFieldBitmap
	{
		public static int GetLengthForType(ObjectType type)
		{


			int result;

			switch (type)
			{
				case ObjectType.Wall:
					result = (int)Bitmap.Wall;
					break;
				case ObjectType.Portal:
					result = (int)Bitmap.Portal;
					break;
				case ObjectType.Container:
					result = (int)Bitmap.Container;
					break;
				case ObjectType.Scenery:
					result = (int)Bitmap.Scenery;
					break;
				case ObjectType.Projectile:
					result = (int)Bitmap.Projectile;
					break;
				case ObjectType.Weapon:
					result = (int)Bitmap.Weapon;
					break;
				case ObjectType.Ammo:
					result = (int)Bitmap.Ammo;
					break;
				case ObjectType.Armor:
					result = (int)Bitmap.Armor;
					break;
				case ObjectType.Gold:
					result = (int)Bitmap.Gold;
					break;
				case ObjectType.Food:
					result = (int)Bitmap.Food;
					break;
				case ObjectType.Scroll:
					result = (int)Bitmap.Scroll;
					break;
				case ObjectType.Key:
					result = (int)Bitmap.Key;
					break;
				case ObjectType.Key_Ring:
					result = (int)Bitmap.Key;
					break;
				case ObjectType.Written:
					result = (int)Bitmap.Written;
					break;
				case ObjectType.Generic:
					result = (int)Bitmap.Generic;
					break;
				case ObjectType.PC:
					result = (int)Bitmap.PC;
					break;
				case ObjectType.NPC:
					result = (int)Bitmap.NPC;
					break;
				case ObjectType.Trap:
					result = (int)Bitmap.Trap;
					break;
				default:
					result = -1;
					break;
			}

			return result;
		}

	}
}
