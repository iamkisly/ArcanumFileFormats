using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TempleFileFormats.Objects;

namespace TempleFileFormats.Objects
{
    public class ObjectFlagsReader
    {
        protected Int32 data;
        protected ObjectField field;

        public ObjectFlagsReader(Int32 bitmask, ObjectField field)
        {
            this.data = bitmask;
            this.field = field;
        }

        public List<KeyValuePair<string, int>> Read()
        {
            List<KeyValuePair<string, int>> array = new List<KeyValuePair<string,int>>();
            for(int i = 0; i < 32; i++)
            {
                if ((data & (1 << i)) != 0)
                {
                    array.Add(new KeyValuePair<string, int>(GetName(field, i), 1));
                }
            }

            return array;
        }

        private string GetName(ObjectField field, int num)
        {
            switch (field)
            {
                case ObjectField.obj_f_flags:
                    return Enum.GetName(typeof(ObjectFlags), num);

                case ObjectField.obj_f_wall_flags:
                    return Enum.GetName(typeof(ObjectFlags_Wall), num);

                case ObjectField.obj_f_portal_flags:
                    return Enum.GetName(typeof(ObjectFlags_Portal), num);

                case ObjectField.obj_f_container_flags:
                    return Enum.GetName(typeof(ObjectFlags_Container), num);

                case ObjectField.obj_f_scenery_flags:
                    return Enum.GetName(typeof(ObjectFlags_Scenery), num);

                //case ObjectField.obj_f_projectile_flags_combat:
                //    return Enum.GetName(typeof(), num);

                //case ObjectField.obj_f_projectile_flags_combat_damage:
                //    return Enum.GetName(typeof(), num);
                case ObjectField.obj_f_item_flags:
                    return Enum.GetName(typeof(ObjectFlags_Item), num);

                case ObjectField.obj_f_weapon_flags:
                    return Enum.GetName(typeof(ObjectFlags_Weapon), num);

                case ObjectField.obj_f_ammo_flags:
                    return Enum.GetName(typeof(ObjectFlags_Ammo), num);

                case ObjectField.obj_f_armor_flags:
                    return Enum.GetName(typeof(ObjectFlags_Armor), num);

                case ObjectField.obj_f_gold_flags:
                    return Enum.GetName(typeof(ObjectFlags_Gold), num);

                case ObjectField.obj_f_food_flags:
                    return Enum.GetName(typeof(ObjectFlags_Food), num);

                case ObjectField.obj_f_scroll_flags:
                    return Enum.GetName(typeof(ObjectFlags_Scroll), num);

                case ObjectField.obj_f_key_ring_flags:
                    return Enum.GetName(typeof(ObjectFlags_KeyRing), num);

                case ObjectField.obj_f_written_flags:
                    return Enum.GetName(typeof(ObjectFlags_Written), num);

                case ObjectField.obj_f_generic_flags:
                    return Enum.GetName(typeof(ObjectFlags_Generic), num);

                case ObjectField.obj_f_critter_flags:
                    return Enum.GetName(typeof(ObjectFlags_Critter), num);

                case ObjectField.obj_f_critter_flags2:
                    return Enum.GetName(typeof(ObjectFlags_Critter2), num);

                case ObjectField.obj_f_pc_flags:
                    return Enum.GetName(typeof(ObjectFlags_PC), num);

                case ObjectField.obj_f_npc_flags:
                    return Enum.GetName(typeof(ObjectFlags_NPC), num);

                case ObjectField.obj_f_trap_flags:
                    return Enum.GetName(typeof(ObjectFlags_Trap), num);

                default: return "null";
            }
        }
    }
}

/*
	+	Wall = 3,
	+	Portal = 3,
	+	Container = 3,
	+	Scenery = 3,
	-	Projectile = 3,
	+	Weapon = 4,
	+	Ammo = 4,
	+	Armor = 4,
	+	Gold = 4,
	+	Food = 4,
	+	Scroll = 4,
	+	Key_Ring = 4,
	+	Written = 4,
	+	Generic = 4,
	+	PC = 5,
	+	NPC = 5,
		Trap = 3
*/