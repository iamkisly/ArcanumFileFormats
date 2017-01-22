using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempleFileFormats.Objects
{
	/// <summary>
	/// Defines which fields apply to which types and in which order.
	/// </summary>
	public static class ObjectTypeFields
	{

		private static IEnumerable<ObjectField> EnumerateFields(ObjectField start, ObjectField end)
		{
			for (var i = start + 1; i < end; ++i)
			{
				yield return i;
			}
			yield break;
		}

		public static IEnumerable<ObjectField> Get(ObjectType type)
		{

			// All object types support obj fields
			var result = EnumerateFields(ObjectField.obj_f_begin, ObjectField.obj_f_end);

			switch (type)
			{
				case ObjectType.Wall:
					result = result.Concat(EnumerateFields(ObjectField.obj_f_wall_begin, ObjectField.obj_f_wall_end));
					break;
				case ObjectType.Portal:
					result = result.Concat(EnumerateFields(ObjectField.obj_f_portal_begin, ObjectField.obj_f_portal_end));
					break;
				case ObjectType.Container:
					result = result.Concat(EnumerateFields(ObjectField.obj_f_container_begin, ObjectField.obj_f_container_end));
					break;
				case ObjectType.Scenery:
					result = result.Concat(EnumerateFields(ObjectField.obj_f_scenery_begin, ObjectField.obj_f_scenery_end));
					break;
				case ObjectType.Projectile:
					result = result.Concat(EnumerateFields(ObjectField.obj_f_projectile_begin, ObjectField.obj_f_projectile_end));
					break;
				case ObjectType.Weapon:
					result = result.Concat(EnumerateFields(ObjectField.obj_f_item_begin, ObjectField.obj_f_item_end));
					result = result.Concat(EnumerateFields(ObjectField.obj_f_weapon_begin, ObjectField.obj_f_weapon_end));
					break;
				case ObjectType.Ammo:
					result = result.Concat(EnumerateFields(ObjectField.obj_f_item_begin, ObjectField.obj_f_item_end));
					result = result.Concat(EnumerateFields(ObjectField.obj_f_ammo_begin, ObjectField.obj_f_ammo_end));
					break;
				case ObjectType.Armor:
					result = result.Concat(EnumerateFields(ObjectField.obj_f_item_begin, ObjectField.obj_f_item_end));
					result = result.Concat(EnumerateFields(ObjectField.obj_f_armor_begin, ObjectField.obj_f_armor_end));
					break;
				case ObjectType.Gold:
					result = result.Concat(EnumerateFields(ObjectField.obj_f_item_begin, ObjectField.obj_f_item_end));
					result = result.Concat(EnumerateFields(ObjectField.obj_f_gold_begin, ObjectField.obj_f_gold_end));
					break;
				case ObjectType.Food:
					result = result.Concat(EnumerateFields(ObjectField.obj_f_item_begin, ObjectField.obj_f_item_end));
					result = result.Concat(EnumerateFields(ObjectField.obj_f_food_begin, ObjectField.obj_f_food_end));
					break;
				case ObjectType.Scroll:
					result = result.Concat(EnumerateFields(ObjectField.obj_f_item_begin, ObjectField.obj_f_item_end));
					result = result.Concat(EnumerateFields(ObjectField.obj_f_scroll_begin, ObjectField.obj_f_scroll_end));
					break;
				case ObjectType.Key:
					result = result.Concat(EnumerateFields(ObjectField.obj_f_item_begin, ObjectField.obj_f_item_end));
					result = result.Concat(EnumerateFields(ObjectField.obj_f_key_begin, ObjectField.obj_f_key_end));
					break;
				case ObjectType.Key_Ring:
					result = result.Concat(EnumerateFields(ObjectField.obj_f_item_begin, ObjectField.obj_f_item_end));
					result = result.Concat(EnumerateFields(ObjectField.obj_f_key_ring_begin, ObjectField.obj_f_key_ring_end));
					break;
				case ObjectType.Written:
					result = result.Concat(EnumerateFields(ObjectField.obj_f_item_begin, ObjectField.obj_f_item_end));
					result = result.Concat(EnumerateFields(ObjectField.obj_f_written_begin, ObjectField.obj_f_written_end));
					break;
				case ObjectType.Generic:
					result = result.Concat(EnumerateFields(ObjectField.obj_f_item_begin, ObjectField.obj_f_item_end));
					result = result.Concat(EnumerateFields(ObjectField.obj_f_generic_begin, ObjectField.obj_f_generic_end));
					break;
				case ObjectType.PC:
					result = result.Concat(EnumerateFields(ObjectField.obj_f_critter_begin, ObjectField.obj_f_critter_end));
					result = result.Concat(EnumerateFields(ObjectField.obj_f_pc_begin, ObjectField.obj_f_pc_end));
					break;
				case ObjectType.NPC:
					result = result.Concat(EnumerateFields(ObjectField.obj_f_critter_begin, ObjectField.obj_f_critter_end));
					result = result.Concat(EnumerateFields(ObjectField.obj_f_npc_begin, ObjectField.obj_f_npc_end));
					break;
				case ObjectType.Trap:
					result = result.Concat(EnumerateFields(ObjectField.obj_f_trap_begin, ObjectField.obj_f_trap_end));
					break;

			}

			return result;

		}

	}
}
