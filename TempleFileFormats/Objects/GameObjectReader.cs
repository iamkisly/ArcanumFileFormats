using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TempleFileFormats.Utils;
using TempleFileFormats.Common;
using TempleFileFormats.Objects.Fields;

namespace TempleFileFormats.Objects
{
    public class GameObjectReader
    {

        private readonly BinaryReader reader;
        private static ObjectField currentField;

        public GameObjectReader(BinaryReader reader)
        {
            this.reader = reader;
        }

        public GameObject Read()
        {
            var version = reader.ReadInt32();
            if (version != 0x77)
            {
                throw new InvalidDataException("Unknown object file version: " + version);
            }

            var obj = new GameObject();

            obj.ProtoId = reader.ReadObjectGuid();

            if (obj.ProtoId.IsProto)
            {
                //throw new InvalidDataException("Proto not supported at this point.");
            }

            obj.Id = reader.ReadObjectGuid();

            obj.Type = (ObjectType)reader.ReadUInt32();

            if (!obj.ProtoId.IsProto)
            {
                var propCollectionItems = reader.ReadInt16(); // Actually not really used anymore
            }

            var bitmapLength = ObjectFieldBitmap.GetLengthForType(obj.Type);

            var bitmap = new uint[bitmapLength * 4];
            for (var i = 0; i < bitmap.Length; ++i)
            {
                bitmap[i] = reader.ReadByte();
            }

            foreach (var field in ObjectTypeFields.Get(obj.Type))
            {
                currentField = field;
                var fieldDef = ObjectFieldDefs.Get(field);
                // Check if it's set in the bitmap

                if (((bitmap[fieldDef.BitmapIndex] & fieldDef.BitmapMask) != 0) || obj.ProtoId.IsProto)
                {
                    var value = ReadFieldValue(fieldDef, reader);
                    if (value != null)
                    {
                        obj.Properties[field] = value;
                    }
                }

            }
            return obj;
        }

        private static object ReadFieldValue(ObjectFieldDef fieldDef, BinaryReader reader)
        {
            switch (fieldDef.FieldType)
            {
                case ObjectFieldType.Int32:
                    return reader.ReadInt32();

                case ObjectFieldType.Int64:
                    if (reader.ReadByte() == 0)
                    {
                        return null;
                    }
                    else
                    {
                        return reader.ReadLocation(); //.ReadInt64();
                    }
                case ObjectFieldType.Color:
                    return new Color(reader.ReadInt32());

                case ObjectFieldType.Flags:
                    return new ObjectFlagsReader(reader.ReadInt32(), currentField).Read();

                case ObjectFieldType.Float32:
                    return reader.ReadSingle();

                case ObjectFieldType.AbilityArray:
                    return ReadFieldValueArray(fieldDef, reader);

                case ObjectFieldType.Int32Array:
                    return ReadFieldValueArray(fieldDef, reader);

                case ObjectFieldType.Int64Array:
                    return ReadFieldValueArray(fieldDef, reader);

                case ObjectFieldType.ScriptArray:
                    return ReadFieldValueArray(fieldDef, reader);

                case ObjectFieldType.Unk:
                    return reader.ReadByte();

                case ObjectFieldType.ObjArray:
                    return ReadFieldValueArray(fieldDef, reader);

                case ObjectFieldType.SpellArray:
                    return ReadFieldValueArray(fieldDef, reader);

                case ObjectFieldType.String:
                    if (reader.ReadByte() == 0)
                    {
                        return null;
                    }
                    else
                    {
                        var length = reader.ReadInt32();
                        var data = reader.ReadBytes(length);
                        // Decode using local encoding
                        return Encoding.Default.GetString(data);
                    }

                case ObjectFieldType.Obj:
                    if (reader.ReadByte() == 0)
                    {
                        return null;
                    }
                    else
                    {
                        return reader.ReadObjectGuid();
                    }

                case ObjectFieldType.UnkArray:
                    return ReadFieldValueArray(fieldDef, reader);
            }

            throw new InvalidOperationException("Could not handle field type " + fieldDef.FieldType);
        }

        private static IList ReadFieldValueArray(ObjectFieldDef fieldDef, BinaryReader reader)
        {
            if (reader.ReadByte() == 0)
            {
                return null;
            }

            var elementSize = reader.ReadInt32();
            var elementCount = reader.ReadInt32();
            var headerUnk = reader.ReadInt32();

            var payloadSize = elementCount * elementSize;

            IList result = null;
            
            if (payloadSize > 0)
            {
                switch (fieldDef.FieldType)
                {
                    case ObjectFieldType.AbilityArray:
                        //ObjectField.obj_f_critter_basic_skill_idx
                        //ObjectField.obj_f_critter_tech_skill_idx
                        result = ReadArrayValues(reader, elementCount, r => new Ability(r.ReadInt32()));
                        break;

                    case ObjectFieldType.SpellArray:
                        break;

                    case ObjectFieldType.Int32Array:
                        Debug.Assert(elementSize == 4);
                        result = ReadArrayValues(reader, elementCount, r => r.ReadInt32());
                        break;

                    case ObjectFieldType.Int64Array:
                        Debug.Assert(elementSize == 8);
                        result = ReadArrayValues(reader, elementCount, r => r.ReadLocation());//ReadInt64());
                        break;

                    case ObjectFieldType.ScriptArray:
                        Debug.Assert(elementSize == 12);
                        result = ReadArrayValues(reader, elementCount, r =>
                        {
                            return new ObjectScript()
                            {
                                Counters = r.ReadBytes(4),
                                Flags = r.ReadInt32(),
                                ScriptId = r.ReadInt32()
                            };
                        });
                        break;

                    case ObjectFieldType.ObjArray:
                        Debug.Assert(elementSize == 0x18);
                        result = ReadArrayValues(reader, elementCount, r => r.ReadObjectGuid());
                        break;

                    case ObjectFieldType.UnkArray:
                        Debug.Assert(elementSize == 4);
                        result = ReadArrayValues(reader, elementCount, r => r.ReadInt32());
                        break;

                    default:
                        throw new InvalidDataException("Unsupported array type: " + fieldDef.FieldType);
                }

                var count = reader.ReadInt32();
                var Idx = 0;

                for (var i = 0; i < count; i++)
                {
                    uint bitmask = reader.ReadUInt32();
                    for (var j = 0; j < 32; j++)
                    {
                        if ((bitmask & (1 << j)) != 0)
                        {
                            string subFieldName = GetNameFromIdx(j + i*32);
                            if (subFieldName != "null" && fieldDef.FieldType == ObjectFieldType.Int32Array)
                            {
                                result[Idx] = new KeyValuePair<string, int>(subFieldName, ((KeyValuePair<string, int>)result[Idx]).Value);

                                Idx++;
                            }
                        }
                    }
                }
                // Check for sparse arrays
            }

            return result;
        }

        private static List<KeyValuePair<string, T>> ReadArrayValues<T>(BinaryReader reader, int elementCount, Func<BinaryReader, T> readFunc)
        {
            //List<T> array = new List<T>();
            List<KeyValuePair<string, T>> array = new List<KeyValuePair<string, T>>();
            for (int i = 0; i < elementCount; ++i)
            {
                array.Add(new KeyValuePair<string, T>(i.ToString(), readFunc.Invoke(reader)));
                //array.Add(i.ToString() ,readFunc.Invoke(reader));
            }
            return array;
        }

        public static string GetNameFromIdx (int num)
        {
            return GetNameFromIdx(currentField, num);
        }

        public static string GetNameFromIdx(ObjectField field, int num)
        {
            switch (field)
            {
                //ObjectField.obj_f_overlay_fore
                //ObjectField.obj_f_overlay_back
                //ObjectField.obj_f_underlay
                //ObjectField.obj_f_overlay_light_flags
                //ObjectField.obj_f_overlay_light_aid
                //ObjectField.obj_f_overlay_light_color

                //ObjectField.obj_f_resistance_idx
                case ObjectField.obj_f_resistance_idx :
                    return Enum.GetName(typeof(obj_f_resistance_enum), num);

                //ObjectField.obj_f_scripts_idx
                case ObjectField.obj_f_scripts_idx :
                    return Enum.GetName(typeof(obj_f_scripts_enum), num);

                //ObjectField.obj_f_container_inventory_list_idx - ObjArray

                //ObjectField.obj_f_weapon_damage_lower_idx
                case ObjectField.obj_f_weapon_damage_lower_idx:
                    return Enum.GetName(typeof(obj_f_resistance_enum), num);

                //ObjectField.obj_f_weapon_damage_upper_idx
                case ObjectField.obj_f_weapon_damage_upper_idx:
                    return Enum.GetName(typeof(obj_f_resistance_enum), num);

                //ObjectField.obj_f_weapon_magic_damage_adj_idx
                case ObjectField.obj_f_weapon_magic_damage_adj_idx:
                    return Enum.GetName(typeof(obj_f_resistance_enum), num);

                //ObjectField.obj_f_armor_resistance_adj_idx
                case ObjectField.obj_f_armor_resistance_adj_idx:
                    return Enum.GetName(typeof(obj_f_resistance_enum), num);

                //ObjectField.obj_f_armor_magic_resistance_adj_idx
                case ObjectField.obj_f_armor_magic_resistance_adj_idx:
                    return Enum.GetName(typeof(obj_f_resistance_enum), num);

                //ObjectField.obj_f_key_ring_list_idx ObjArray/Int32Array

                //ObjectField.obj_f_critter_stat_base_idx
                case ObjectField.obj_f_critter_stat_base_idx:
                    return Enum.GetName(typeof(obj_f_critter_stat_base_enum), num);

                //ObjectField.obj_f_critter_basic_skill_idx
                case ObjectField.obj_f_critter_basic_skill_idx:
                    return Enum.GetName(typeof(obj_f_critter_basic_skill_enum), num);

                //ObjectField.obj_f_critter_tech_skill_idx
                case ObjectField.obj_f_critter_tech_skill_idx:
                    return Enum.GetName(typeof(obj_f_critter_tech_skill_enum), num);
                
                //ObjectField.obj_f_critter_spell_tech_idx
                //ObjectField.obj_f_critter_effects_idx
                //ObjectField.obj_f_critter_effect_cause_idx
                //ObjectField.obj_f_critter_inventory_list_idx
                //ObjectField.obj_f_critter_follower_idx

                //ObjectField.obj_f_npc_waypoints_idx
                //ObjectField.obj_f_npc_reaction_pc_idx
                //ObjectField.obj_f_npc_reaction_level_idx
                //ObjectField.obj_f_npc_reaction_time_idx
                //ObjectField.obj_f_npc_damage_idx
                //ObjectField.obj_f_npc_shit_list_idx

                //ObjectField.obj_f_pc_reputation_idx
                //ObjectField.obj_f_pc_reputation_ts_idx
                //ObjectField.obj_f_pc_quest_idx
                //ObjectField.obj_f_pc_blessing_idx
                //ObjectField.obj_f_pc_blessing_ts_idx
                //ObjectField.obj_f_pc_curse_idx
                //ObjectField.obj_f_pc_curse_ts_idx
                //ObjectField.obj_f_pc_rumor_idx
                //ObjectField.obj_f_pc_schematics_found_idx
                //ObjectField.obj_f_pc_logbook_ego_idx
                //ObjectField.obj_f_pc_global_flags
                //ObjectField.obj_f_pc_global_variables


                default: return "null";
            }      
        }
    }
}