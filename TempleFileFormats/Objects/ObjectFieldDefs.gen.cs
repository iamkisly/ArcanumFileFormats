using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempleFileFormats.Objects
{
	public static partial class ObjectFieldDefs
	{

		/// <summary>
		/// 
		/// </summary>
		private static void InitializeTable()
		{
			fields[(int)ObjectField.obj_f_begin] = new ObjectFieldDef(-1, -1, 0x00, 0, false, ObjectFieldType.SectionBegin);
			fields[(int)ObjectField.obj_f_current_aid] = new ObjectFieldDef(-1, 0, 0x01, 0, true, ObjectFieldType.Int32);	// TODO: CHANGE INT32 TO ART_SRTUCT
			fields[(int)ObjectField.obj_f_location] = new ObjectFieldDef(-1, 0, 0x02, 1, true, ObjectFieldType.Int64);
			fields[(int)ObjectField.obj_f_offset_x] = new ObjectFieldDef(-1, 0, 0x04, 2, true, ObjectFieldType.Float32);
			fields[(int)ObjectField.obj_f_offset_y] = new ObjectFieldDef(-1, 0, 0x08, 3, true, ObjectFieldType.Float32);
			fields[(int)ObjectField.obj_f_shadow] = new ObjectFieldDef(-1, 0, 0x10, 4, true, ObjectFieldType.Int32);   // TODO: CHANGE INT32 TO ART_SRTUCT
			fields[(int)ObjectField.obj_f_overlay_fore] = new ObjectFieldDef(-1, 0, 0x20, 5, true, ObjectFieldType.UnkArray);
			fields[(int)ObjectField.obj_f_overlay_back] = new ObjectFieldDef(-1, 0, 0x40, 6, true, ObjectFieldType.UnkArray);
			fields[(int)ObjectField.obj_f_underlay] = new ObjectFieldDef(-1, 0, 0x80, 7, true, ObjectFieldType.UnkArray);
			fields[(int)ObjectField.obj_f_blit_flags] = new ObjectFieldDef(-1, 1, 0x01, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_blit_color] = new ObjectFieldDef(-1, 1, 0x02, 1, true, ObjectFieldType.Color);
			fields[(int)ObjectField.obj_f_blit_alpha] = new ObjectFieldDef(-1, 1, 0x04, 2, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_blit_scale] = new ObjectFieldDef(-1, 1, 0x08, 3, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_light_flags] = new ObjectFieldDef(-1, 1, 0x10, 4, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_light_aid] = new ObjectFieldDef(-1, 1, 0x20, 5, true, ObjectFieldType.Int32);   // TODO: CHANGE INT32 TO ART_SRTUCT
			fields[(int)ObjectField.obj_f_light_color] = new ObjectFieldDef(-1, 1, 0x40, 6, true, ObjectFieldType.Color);
			fields[(int)ObjectField.obj_f_overlay_light_flags] = new ObjectFieldDef(-1, 1, 0x80, 7, true, ObjectFieldType.UnkArray);
			fields[(int)ObjectField.obj_f_overlay_light_aid] = new ObjectFieldDef(-1, 2, 0x01, 0, true, ObjectFieldType.UnkArray);	// TODO: CHANGE INT32 TO ART_ARRAY ?
			fields[(int)ObjectField.obj_f_overlay_light_color] = new ObjectFieldDef(-1, 2, 0x02, 1, true, ObjectFieldType.UnkArray);
			fields[(int)ObjectField.obj_f_flags] = new ObjectFieldDef(-1, 2, 0x04, 2, true, ObjectFieldType.Flags);
			fields[(int)ObjectField.obj_f_spell_flags] = new ObjectFieldDef(-1, 2, 0x08, 3, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_blocking_mask] = new ObjectFieldDef(-1, 2, 0x10, 4, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_name] = new ObjectFieldDef(-1, 2, 0x20, 5, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_description] = new ObjectFieldDef(-1, 2, 0x40, 6, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_aid] = new ObjectFieldDef(-1, 2, 0x80, 7, true, ObjectFieldType.Int32);   // TODO: CHANGE INT32 TO ART_SRTUCT
			fields[(int)ObjectField.obj_f_destroyed_aid] = new ObjectFieldDef(-1, 3, 0x01, 0, true, ObjectFieldType.Int32);   // TODO: CHANGE INT32 TO ART_SRTUCT
			fields[(int)ObjectField.obj_f_AC] = new ObjectFieldDef(-1, 3, 0x02, 1, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_hp_pts] = new ObjectFieldDef(-1, 3, 0x04, 2, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_hp_adj] = new ObjectFieldDef(-1, 3, 0x08, 3, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_hp_damage] = new ObjectFieldDef(-1, 3, 0x10, 4, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_material] = new ObjectFieldDef(-1, 3, 0x20, 5, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_resistance_idx] = new ObjectFieldDef(-1, 3, 0x40, 6, true, ObjectFieldType.Int32Array);
			fields[(int)ObjectField.obj_f_scripts_idx] = new ObjectFieldDef(-1, 3, 0x80, 7, true, ObjectFieldType.ScriptArray);
			fields[(int)ObjectField.obj_f_sound_effect] = new ObjectFieldDef(-1, 4, 0x01, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_category] = new ObjectFieldDef(-1, 4, 0x02, 1, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_pad_ias_1] = new ObjectFieldDef(-1, 4, 0x04, 2, true, ObjectFieldType.Unk);
			fields[(int)ObjectField.obj_f_pad_i64as_1] = new ObjectFieldDef(-1, 4, 0x08, 3, true, ObjectFieldType.Unk);
			fields[(int)ObjectField.obj_f_end] = new ObjectFieldDef(-1, -1, 0x00, 0, false, ObjectFieldType.SectionEnd);

			fields[(int)ObjectField.obj_f_wall_begin] = new ObjectFieldDef(-1, -1, 0x00, 0, false, ObjectFieldType.SectionBegin);
			fields[(int)ObjectField.obj_f_wall_flags] = new ObjectFieldDef(-1, 8, 0x01, 0, true, ObjectFieldType.Flags);
			fields[(int)ObjectField.obj_f_wall_pad_i_1] = new ObjectFieldDef(-1, 8, 0x02, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_wall_pad_i_2] = new ObjectFieldDef(-1, 8, 0x04, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_wall_pad_ias_1] = new ObjectFieldDef(-1, 8, 0x08, 0, true, ObjectFieldType.Unk);
			fields[(int)ObjectField.obj_f_wall_pad_i64as_1] = new ObjectFieldDef(-1, 8, 0x10, 0, true, ObjectFieldType.Unk);
			fields[(int)ObjectField.obj_f_wall_end] = new ObjectFieldDef(-1, -1, 0x00, 0, false, ObjectFieldType.SectionEnd);

			fields[(int)ObjectField.obj_f_portal_begin] = new ObjectFieldDef(-1, -1, 0x00, 0, false, ObjectFieldType.SectionBegin);
			fields[(int)ObjectField.obj_f_portal_flags] = new ObjectFieldDef(-1, 8, 0x01, 0, true, ObjectFieldType.Flags);
			fields[(int)ObjectField.obj_f_portal_lock_difficulty] = new ObjectFieldDef(-1, 8, 0x02, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_portal_key_id] = new ObjectFieldDef(-1, 8, 0x04, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_portal_notify_npc] = new ObjectFieldDef(-1, 8, 0x08, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_portal_pad_i_1] = new ObjectFieldDef(-1, 8, 0x10, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_portal_pad_i_2] = new ObjectFieldDef(-1, 8, 0x20, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_portal_pad_ias_1] = new ObjectFieldDef(-1, 8, 0x40, 0, true, ObjectFieldType.Unk);
			fields[(int)ObjectField.obj_f_portal_pad_i64as_1] = new ObjectFieldDef(-1, 8, 0x80, 0, true, ObjectFieldType.Unk);
			fields[(int)ObjectField.obj_f_portal_end] = new ObjectFieldDef(-1, -1, 0x00, 0, false, ObjectFieldType.SectionEnd);

			fields[(int)ObjectField.obj_f_container_begin] = new ObjectFieldDef(-1, -1, 0x00, 0, false, ObjectFieldType.SectionBegin);
			fields[(int)ObjectField.obj_f_container_flags] = new ObjectFieldDef(-1, 8, 0x01, 0, true, ObjectFieldType.Flags);
			fields[(int)ObjectField.obj_f_container_lock_difficulty] = new ObjectFieldDef(-1, 8, 0x02, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_container_key_id] = new ObjectFieldDef(-1, 8, 0x04, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_container_inventory_num] = new ObjectFieldDef(-1, 8, 0x08, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_container_inventory_list_idx] = new ObjectFieldDef(-1, 8, 0x10, 0, true, ObjectFieldType.ObjArray);
			fields[(int)ObjectField.obj_f_container_inventory_source] = new ObjectFieldDef(-1, 8, 0x20, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_container_notify_npc] = new ObjectFieldDef(-1, 8, 0x40, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_container_pad_i_1] = new ObjectFieldDef(-1, 8, 0x80, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_container_pad_i_2] = new ObjectFieldDef(-1, 9, 0x01, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_container_pad_ias_1] = new ObjectFieldDef(-1, 9, 0x02, 0, true, ObjectFieldType.Unk);
			fields[(int)ObjectField.obj_f_container_pad_i64as_1] = new ObjectFieldDef(-1, 9, 0x04, 0, true, ObjectFieldType.Unk);
			fields[(int)ObjectField.obj_f_container_end] = new ObjectFieldDef(-1, -1, 0x00, 0, false, ObjectFieldType.SectionEnd);

			fields[(int)ObjectField.obj_f_scenery_begin] = new ObjectFieldDef(-1, -1, 0x00, 0, false, ObjectFieldType.SectionBegin);
			fields[(int)ObjectField.obj_f_scenery_flags] = new ObjectFieldDef(-1, 8, 0x01, 0, true, ObjectFieldType.Flags);
			fields[(int)ObjectField.obj_f_scenery_whos_in_me] = new ObjectFieldDef(-1, 8, 0x02, 0, true, ObjectFieldType.Obj);    // TODO: Set here questionable data type. OBJ_ARRAY ?
			fields[(int)ObjectField.obj_f_scenery_respawn_delay] = new ObjectFieldDef(-1, 8, 0x04, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_scenery_pad_i_2] = new ObjectFieldDef(-1, 8, 0x08, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_scenery_pad_ias_1] = new ObjectFieldDef(-1, 8, 0x10, 0, true, ObjectFieldType.Unk);
			fields[(int)ObjectField.obj_f_scenery_pad_i64as_1] = new ObjectFieldDef(-1, 8, 0x20, 0, true, ObjectFieldType.Unk);
			fields[(int)ObjectField.obj_f_scenery_end] = new ObjectFieldDef(-1, -1, 0x00, 0, false, ObjectFieldType.SectionEnd);

			fields[(int)ObjectField.obj_f_projectile_begin] = new ObjectFieldDef(-1, -1, 0x00, 0, false, ObjectFieldType.SectionBegin);
			fields[(int)ObjectField.obj_f_projectile_flags_combat] = new ObjectFieldDef(-1, 0, 0x01, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_projectile_flags_combat_damage] = new ObjectFieldDef(-1, 0, 0x02, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_projectile_hit_loc] = new ObjectFieldDef(-1, 0, 0x04, 0, true, ObjectFieldType.Int64);  //TODO: Set here questionable data type.
			fields[(int)ObjectField.obj_f_projectile_parent_weapon] = new ObjectFieldDef(-1, 0, 0x08, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_projectile_pad_i_1] = new ObjectFieldDef(-1, 0, 0x10, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_projectile_pad_i_2] = new ObjectFieldDef(-1, 0, 0x20, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_projectile_pad_ias_1] = new ObjectFieldDef(-1, 0, 0x40, 0, true, ObjectFieldType.Unk);
			fields[(int)ObjectField.obj_f_projectile_pad_i64as_1] = new ObjectFieldDef(-1, 0, 0x80, 0, true, ObjectFieldType.Unk);
			fields[(int)ObjectField.obj_f_projectile_end] = new ObjectFieldDef(-1, -1, 0x00, 0, false, ObjectFieldType.SectionEnd);

			fields[(int)ObjectField.obj_f_item_begin] = new ObjectFieldDef(-1, -1, 0x00, 0, false, ObjectFieldType.SectionBegin);
			fields[(int)ObjectField.obj_f_item_flags] = new ObjectFieldDef(-1, 8, 0x01, 0, true, ObjectFieldType.Flags);
			fields[(int)ObjectField.obj_f_item_parent] = new ObjectFieldDef(-1, 8, 0x02, 0, true, ObjectFieldType.Obj);    //TODO: Set here questionable data type.
			fields[(int)ObjectField.obj_f_item_weight] = new ObjectFieldDef(-1, 8, 0x04, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_item_magic_weight_adj] = new ObjectFieldDef(-1, 8, 0x08, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_item_worth] = new ObjectFieldDef(-1, 8, 0x10, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_item_mana_store] = new ObjectFieldDef(-1, 8, 0x20, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_item_inv_aid] = new ObjectFieldDef(-1, 8, 0x40, 0, true, ObjectFieldType.Int32);   // TODO: CHANGE INT32 TO ART_SRTUCT
			fields[(int)ObjectField.obj_f_item_inv_location] = new ObjectFieldDef(-1, 8, 0x80, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_item_use_aid_fragment] = new ObjectFieldDef(-1, 9, 0x01, 0, true, ObjectFieldType.Int32);   // TODO: CHANGE INT32 TO ART_SRTUCT
			fields[(int)ObjectField.obj_f_item_magic_tech_complexity] = new ObjectFieldDef(-1, 9, 0x02, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_item_discipline] = new ObjectFieldDef(-1, 9, 0x04, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_item_description_unknown] = new ObjectFieldDef(-1, 9, 0x08, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_item_description_effects] = new ObjectFieldDef(-1, 9, 0x10, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_item_spell_1] = new ObjectFieldDef(-1, 9, 0x20, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_item_spell_2] = new ObjectFieldDef(-1, 9, 0x40, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_item_spell_3] = new ObjectFieldDef(-1, 9, 0x80, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_item_spell_4] = new ObjectFieldDef(-1, 10, 0x01, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_item_spell_5] = new ObjectFieldDef(-1, 10, 0x02, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_item_spell_mana_store] = new ObjectFieldDef(-1, 10, 0x04, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_item_ai_action] = new ObjectFieldDef(-1, 10, 0x08, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_item_pad_i_1] = new ObjectFieldDef(-1, 10, 0x10, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_item_pad_ias_1] = new ObjectFieldDef(-1, 10, 0x20, 0, true, ObjectFieldType.Unk);
			fields[(int)ObjectField.obj_f_item_pad_i64as_1] = new ObjectFieldDef(-1, 10, 0x40, 0, true, ObjectFieldType.Unk);
			fields[(int)ObjectField.obj_f_item_end] = new ObjectFieldDef(-1, -1, 0x00, 0, false, ObjectFieldType.SectionEnd);

			fields[(int)ObjectField.obj_f_weapon_begin] = new ObjectFieldDef(-1, -1, 0x00, 0, false, ObjectFieldType.SectionBegin);
			fields[(int)ObjectField.obj_f_weapon_flags] = new ObjectFieldDef(-1, 12, 0x01, 0, true, ObjectFieldType.Flags);
			fields[(int)ObjectField.obj_f_weapon_paper_doll_aid] = new ObjectFieldDef(-1, 12, 0x02, 0, true, ObjectFieldType.Int32);  // TODO: CHANGE INT32 TO ART_SRTUCT
			fields[(int)ObjectField.obj_f_weapon_bonus_to_hit] = new ObjectFieldDef(-1, 12, 0x04, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_weapon_magic_hit_adj] = new ObjectFieldDef(-1, 12, 0x08, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_weapon_damage_lower_idx] = new ObjectFieldDef(-1, 12, 0x10, 0, true, ObjectFieldType.Int32Array);    //TODO: Set here questionable data type.
			fields[(int)ObjectField.obj_f_weapon_damage_upper_idx] = new ObjectFieldDef(-1, 12, 0x20, 0, true, ObjectFieldType.Int32Array);    //TODO: Set here questionable data type.
			fields[(int)ObjectField.obj_f_weapon_magic_damage_adj_idx] = new ObjectFieldDef(-1, 12, 0x40, 0, true, ObjectFieldType.Int32Array);    //TODO: Set here questionable data type.
			fields[(int)ObjectField.obj_f_weapon_speed_factor] = new ObjectFieldDef(-1, 12, 0x80, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_weapon_magic_speed_adj] = new ObjectFieldDef(-1, 13, 0x01, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_weapon_range] = new ObjectFieldDef(-1, 13, 0x02, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_weapon_magic_range_adj] = new ObjectFieldDef(-1, 13, 0x04, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_weapon_min_strength] = new ObjectFieldDef(-1, 13, 0x08, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_weapon_magic_min_strength_adj] = new ObjectFieldDef(-1, 13, 0x10, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_weapon_ammo_type] = new ObjectFieldDef(-1, 13, 0x20, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_weapon_ammo_consumption] = new ObjectFieldDef(-1, 13, 0x40, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_weapon_missile_aid] = new ObjectFieldDef(-1, 13, 0x80, 0, true, ObjectFieldType.Int32);  // TODO: CHANGE INT32 TO ART_SRTUCT
			fields[(int)ObjectField.obj_f_weapon_visual_effect_aid] = new ObjectFieldDef(-1, 14, 0x01, 0, true, ObjectFieldType.Int32);  // TODO: CHANGE INT32 TO ART_SRTUCT
			fields[(int)ObjectField.obj_f_weapon_crit_hit_chart] = new ObjectFieldDef(-1, 14, 0x02, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_weapon_magic_crit_hit_chance] = new ObjectFieldDef(-1, 14, 0x04, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_weapon_magic_crit_hit_effect] = new ObjectFieldDef(-1, 14, 0x08, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_weapon_crit_miss_chart] = new ObjectFieldDef(-1, 14, 0x10, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_weapon_magic_crit_miss_chance] = new ObjectFieldDef(-1, 14, 0x20, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_weapon_magic_crit_miss_effect] = new ObjectFieldDef(-1, 14, 0x40, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_weapon_pad_i_1] = new ObjectFieldDef(-1, 14, 0x80, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_weapon_pad_i_2] = new ObjectFieldDef(-1, 15, 0x01, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_weapon_pad_ias_1] = new ObjectFieldDef(-1, 15, 0x02, 0, true, ObjectFieldType.Unk);
			fields[(int)ObjectField.obj_f_weapon_pad_i64as_1] = new ObjectFieldDef(-1, 15, 0x04, 0, true, ObjectFieldType.Unk);
			fields[(int)ObjectField.obj_f_weapon_end] = new ObjectFieldDef(-1, -1, 0x00, 0, false, ObjectFieldType.SectionEnd);

			fields[(int)ObjectField.obj_f_ammo_begin] = new ObjectFieldDef(-1, -1, 0x00, 0, false, ObjectFieldType.SectionBegin);
			fields[(int)ObjectField.obj_f_ammo_flags] = new ObjectFieldDef(-1, 12, 0x01, 0, true, ObjectFieldType.Flags);
			fields[(int)ObjectField.obj_f_ammo_quantity] = new ObjectFieldDef(-1, 12, 0x02, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_ammo_type] = new ObjectFieldDef(-1, 12, 0x04, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_ammo_pad_i_1] = new ObjectFieldDef(-1, 12, 0x08, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_ammo_pad_i_2] = new ObjectFieldDef(-1, 12, 0x10, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_ammo_pad_ias_1] = new ObjectFieldDef(-1, 12, 0x20, 0, true, ObjectFieldType.Unk);
			fields[(int)ObjectField.obj_f_ammo_pad_i64as_1] = new ObjectFieldDef(-1, 12, 0x40, 0, true, ObjectFieldType.Unk);
			fields[(int)ObjectField.obj_f_ammo_end] = new ObjectFieldDef(-1, -1, 0x00, 0, false, ObjectFieldType.SectionEnd);

			fields[(int)ObjectField.obj_f_armor_begin] = new ObjectFieldDef(-1, -1, 0x00, 0, false, ObjectFieldType.SectionBegin);
			fields[(int)ObjectField.obj_f_armor_flags] = new ObjectFieldDef(-1, 12, 0x01, 0, true, ObjectFieldType.Flags);
			fields[(int)ObjectField.obj_f_armor_paper_doll_aid] = new ObjectFieldDef(-1, 12, 0x02, 0, true, ObjectFieldType.Int32);    // TODO: CHANGE INT32 TO ART_SRTUCT
			fields[(int)ObjectField.obj_f_armor_ac_adj] = new ObjectFieldDef(-1, 12, 0x04, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_armor_magic_ac_adj] = new ObjectFieldDef(-1, 12, 0x08, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_armor_resistance_adj_idx] = new ObjectFieldDef(-1, 12, 0x10, 0, true, ObjectFieldType.Int32Array);
			fields[(int)ObjectField.obj_f_armor_magic_resistance_adj_idx] = new ObjectFieldDef(-1, 12, 0x20, 0, true, ObjectFieldType.Int32Array);
			fields[(int)ObjectField.obj_f_armor_silent_move_adj] = new ObjectFieldDef(-1, 12, 0x40, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_armor_magic_silent_move_adj] = new ObjectFieldDef(-1, 12, 0x80, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_armor_unarmed_bonus_damage] = new ObjectFieldDef(-1, 13, 0x01, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_armor_pad_i_2] = new ObjectFieldDef(-1, 13, 0x02, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_armor_pad_ias_1] = new ObjectFieldDef(-1, 13, 0x04, 0, true, ObjectFieldType.Unk);
			fields[(int)ObjectField.obj_f_armor_pad_i64as_1] = new ObjectFieldDef(-1, 13, 0x08, 0, true, ObjectFieldType.Unk);
			fields[(int)ObjectField.obj_f_armor_end] = new ObjectFieldDef(-1, -1, 0x00, 0, false, ObjectFieldType.SectionEnd);

			fields[(int)ObjectField.obj_f_gold_begin] = new ObjectFieldDef(-1, -1, 0x00, 0, false, ObjectFieldType.SectionBegin);
			fields[(int)ObjectField.obj_f_gold_flags] = new ObjectFieldDef(-1, 12, 0x01, 0, true, ObjectFieldType.Flags);
			fields[(int)ObjectField.obj_f_gold_quantity] = new ObjectFieldDef(-1, 12, 0x02, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_gold_pad_i_1] = new ObjectFieldDef(-1, 12, 0x04, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_gold_pad_i_2] = new ObjectFieldDef(-1, 12, 0x08, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_gold_pad_ias_1] = new ObjectFieldDef(-1, 12, 0x10, 0, true, ObjectFieldType.Unk);
			fields[(int)ObjectField.obj_f_gold_pad_i64as_1] = new ObjectFieldDef(-1, 12, 0x20, 0, true, ObjectFieldType.Unk);
			fields[(int)ObjectField.obj_f_gold_end] = new ObjectFieldDef(-1, -1, 0x00, 0, false, ObjectFieldType.SectionEnd);

			fields[(int)ObjectField.obj_f_food_begin] = new ObjectFieldDef(-1, -1, 0x00, 0, false, ObjectFieldType.SectionBegin);
			fields[(int)ObjectField.obj_f_food_flags] = new ObjectFieldDef(-1, 12, 0x01, 0, true, ObjectFieldType.Flags);
			fields[(int)ObjectField.obj_f_food_pad_i_1] = new ObjectFieldDef(-1, 12, 0x02, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_food_pad_i_2] = new ObjectFieldDef(-1, 12, 0x04, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_food_pad_ias_1] = new ObjectFieldDef(-1, 12, 0x08, 0, true, ObjectFieldType.Unk);
			fields[(int)ObjectField.obj_f_food_pad_i64as_1] = new ObjectFieldDef(-1, 12, 0x10, 0, true, ObjectFieldType.Unk);
			fields[(int)ObjectField.obj_f_food_end] = new ObjectFieldDef(-1, -1, 0x00, 0, false, ObjectFieldType.SectionEnd);

			fields[(int)ObjectField.obj_f_scroll_begin] = new ObjectFieldDef(-1, -1, 0x00, 0, false, ObjectFieldType.SectionBegin);
			fields[(int)ObjectField.obj_f_scroll_flags] = new ObjectFieldDef(-1, 12, 0x01, 0, true, ObjectFieldType.Flags);
			fields[(int)ObjectField.obj_f_scroll_pad_i_1] = new ObjectFieldDef(-1, 12, 0x02, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_scroll_pad_i_2] = new ObjectFieldDef(-1, 12, 0x04, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_scroll_pad_ias_1] = new ObjectFieldDef(-1, 12, 0x08, 0, true, ObjectFieldType.Unk);
			fields[(int)ObjectField.obj_f_scroll_pad_i64as_1] = new ObjectFieldDef(-1, 12, 0x10, 0, true, ObjectFieldType.Unk);
			fields[(int)ObjectField.obj_f_scroll_end] = new ObjectFieldDef(-1, -1, 0x00, 0, false, ObjectFieldType.SectionEnd);

			fields[(int)ObjectField.obj_f_key_begin] = new ObjectFieldDef(-1, -1, 0x00, 0, false, ObjectFieldType.SectionBegin);
			fields[(int)ObjectField.obj_f_key_key_id] = new ObjectFieldDef(-1, 12, 0x01, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_key_pad_i_1] = new ObjectFieldDef(-1, 12, 0x02, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_key_pad_i_2] = new ObjectFieldDef(-1, 12, 0x04, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_key_pad_ias_1] = new ObjectFieldDef(-1, 12, 0x08, 0, true, ObjectFieldType.Unk);
			fields[(int)ObjectField.obj_f_key_pad_i64as_1] = new ObjectFieldDef(-1, 12, 0x10, 0, true, ObjectFieldType.Unk);
			fields[(int)ObjectField.obj_f_key_end] = new ObjectFieldDef(-1, -1, 0x00, 0, false, ObjectFieldType.SectionEnd);

			fields[(int)ObjectField.obj_f_key_ring_begin] = new ObjectFieldDef(-1, -1, 0x00, 0, false, ObjectFieldType.SectionBegin);
			fields[(int)ObjectField.obj_f_key_ring_flags] = new ObjectFieldDef(-1, 12, 0x01, 0, true, ObjectFieldType.Flags);
			fields[(int)ObjectField.obj_f_key_ring_list_idx] = new ObjectFieldDef(-1, 12, 0x02, 0, true, ObjectFieldType.Int32Array);    //TODO: Set here questionable data type. ObjArray ?
			fields[(int)ObjectField.obj_f_key_ring_pad_i_1] = new ObjectFieldDef(-1, 12, 0x04, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_key_ring_pad_i_2] = new ObjectFieldDef(-1, 12, 0x08, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_key_ring_pad_ias_1] = new ObjectFieldDef(-1, 12, 0x10, 0, true, ObjectFieldType.Unk);
			fields[(int)ObjectField.obj_f_key_ring_pad_i64as_1] = new ObjectFieldDef(-1, 12, 0x20, 0, true, ObjectFieldType.Unk);
			fields[(int)ObjectField.obj_f_key_ring_end] = new ObjectFieldDef(-1, -1, 0x00, 0, false, ObjectFieldType.SectionEnd);

			fields[(int)ObjectField.obj_f_written_begin] = new ObjectFieldDef(-1, -1, 0x00, 0, false, ObjectFieldType.SectionBegin);
			fields[(int)ObjectField.obj_f_written_flags] = new ObjectFieldDef(-1, 12, 0x01, 0, true, ObjectFieldType.Flags);
			fields[(int)ObjectField.obj_f_written_subtype] = new ObjectFieldDef(-1, 12, 0x02, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_written_text_start_line] = new ObjectFieldDef(-1, 12, 0x04, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_written_text_end_line] = new ObjectFieldDef(-1, 12, 0x08, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_written_pad_i_1] = new ObjectFieldDef(-1, 12, 0x10, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_written_pad_i_2] = new ObjectFieldDef(-1, 12, 0x20, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_written_pad_ias_1] = new ObjectFieldDef(-1, 12, 0x40, 0, true, ObjectFieldType.Unk);
			fields[(int)ObjectField.obj_f_written_pad_i64as_1] = new ObjectFieldDef(-1, 12, 0x80, 0, true, ObjectFieldType.Unk);
			fields[(int)ObjectField.obj_f_written_end] = new ObjectFieldDef(-1, -1, 0x00, 0, false, ObjectFieldType.SectionEnd);

			fields[(int)ObjectField.obj_f_generic_begin] = new ObjectFieldDef(-1, -1, 0x00, 0, false, ObjectFieldType.SectionBegin);
			fields[(int)ObjectField.obj_f_generic_flags] = new ObjectFieldDef(-1, 0, 0x01, 0, true, ObjectFieldType.Flags);
			fields[(int)ObjectField.obj_f_generic_usage_bonus] = new ObjectFieldDef(-1, 0, 0x02, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_generic_usage_count_remaining] = new ObjectFieldDef(-1, 0, 0x04, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_generic_pad_ias_1] = new ObjectFieldDef(-1, 0, 0x08, 0, true, ObjectFieldType.Unk);
			fields[(int)ObjectField.obj_f_generic_pad_i64as_1] = new ObjectFieldDef(-1, 0, 0x10, 0, true, ObjectFieldType.Unk);
			fields[(int)ObjectField.obj_f_generic_end] = new ObjectFieldDef(-1, -1, 0x00, 0, false, ObjectFieldType.SectionEnd);

			fields[(int)ObjectField.obj_f_critter_begin] = new ObjectFieldDef(-1, -1, 0x00, 0, false, ObjectFieldType.SectionBegin);
			fields[(int)ObjectField.obj_f_critter_flags] = new ObjectFieldDef(-1, 8, 0x01, 0, true, ObjectFieldType.Flags);
			fields[(int)ObjectField.obj_f_critter_flags2] = new ObjectFieldDef(-1, 8, 0x02, 0, true, ObjectFieldType.Flags);
			fields[(int)ObjectField.obj_f_critter_stat_base_idx] = new ObjectFieldDef(-1, 8, 0x04, 0, true, ObjectFieldType.Int32Array);
			fields[(int)ObjectField.obj_f_critter_basic_skill_idx] = new ObjectFieldDef(-1, 8, 0x08, 0, true, ObjectFieldType.AbilityArray);
			fields[(int)ObjectField.obj_f_critter_tech_skill_idx] = new ObjectFieldDef(-1, 8, 0x10, 0, true, ObjectFieldType.AbilityArray);
			fields[(int)ObjectField.obj_f_critter_spell_tech_idx] = new ObjectFieldDef(-1, 8, 0x20, 0, true, ObjectFieldType.Int32Array);
			fields[(int)ObjectField.obj_f_critter_fatigue_pts] = new ObjectFieldDef(-1, 8, 0x40, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_critter_fatigue_adj] = new ObjectFieldDef(-1, 8, 0x80, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_critter_fatigue_damage] = new ObjectFieldDef(-1, 9, 0x01, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_critter_crit_hit_chart] = new ObjectFieldDef(-1, 9, 0x02, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_critter_effects_idx] = new ObjectFieldDef(-1, 9, 0x04, 0, true, ObjectFieldType.Int32Array);
			fields[(int)ObjectField.obj_f_critter_effect_cause_idx] = new ObjectFieldDef(-1, 9, 0x08, 0, true, ObjectFieldType.Int32Array);
			fields[(int)ObjectField.obj_f_critter_fleeing_from] = new ObjectFieldDef(-1, 9, 0x10, 0, true, ObjectFieldType.Obj);
			fields[(int)ObjectField.obj_f_critter_portrait] = new ObjectFieldDef(-1, 9, 0x20, 0, true, ObjectFieldType.Int32);    // TODO: CHANGE INT32 TO ART_SRTUCT
			fields[(int)ObjectField.obj_f_critter_gold] = new ObjectFieldDef(-1, 9, 0x40, 0, true, ObjectFieldType.Obj);
			fields[(int)ObjectField.obj_f_critter_arrows] = new ObjectFieldDef(-1, 9, 0x80, 0, true, ObjectFieldType.Obj);
			fields[(int)ObjectField.obj_f_critter_bullets] = new ObjectFieldDef(-1, 10, 0x01, 0, true, ObjectFieldType.Obj);
			fields[(int)ObjectField.obj_f_critter_power_cells] = new ObjectFieldDef(-1, 10, 0x02, 0, true, ObjectFieldType.Obj);
			fields[(int)ObjectField.obj_f_critter_fuel] = new ObjectFieldDef(-1, 10, 0x04, 0, true, ObjectFieldType.Obj);
			fields[(int)ObjectField.obj_f_critter_inventory_num] = new ObjectFieldDef(-1, 10, 0x08, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_critter_inventory_list_idx] = new ObjectFieldDef(-1, 10, 0x10, 0, true, ObjectFieldType.ObjArray);
			fields[(int)ObjectField.obj_f_critter_inventory_source] = new ObjectFieldDef(-1, 10, 0x20, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_critter_description_unknown] = new ObjectFieldDef(-1, 10, 0x40, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_critter_follower_idx] = new ObjectFieldDef(-1, 10, 0x80, 0, true, ObjectFieldType.ObjArray);
			fields[(int)ObjectField.obj_f_critter_teleport_dest] = new ObjectFieldDef(-1, 11, 0x01, 0, true, ObjectFieldType.Int64);
			fields[(int)ObjectField.obj_f_critter_teleport_map] = new ObjectFieldDef(-1, 11, 0x02, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_critter_death_time] = new ObjectFieldDef(-1, 11, 0x04, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_critter_auto_level_scheme] = new ObjectFieldDef(-1, 11, 0x08, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_critter_pad_i_1] = new ObjectFieldDef(-1, 11, 0x10, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_critter_pad_i_2] = new ObjectFieldDef(-1, 11, 0x20, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_critter_pad_i_3] = new ObjectFieldDef(-1, 11, 0x40, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_critter_pad_ias_1] = new ObjectFieldDef(-1, 11, 0x80, 0, true, ObjectFieldType.Unk);
			fields[(int)ObjectField.obj_f_critter_pad_i64as_1] = new ObjectFieldDef(-1, 12, 0x01, 0, true, ObjectFieldType.Unk);
			fields[(int)ObjectField.obj_f_critter_end] = new ObjectFieldDef(-1, -1, 0x00, 0, false, ObjectFieldType.SectionEnd);

			fields[(int)ObjectField.obj_f_pc_begin] = new ObjectFieldDef(-1, -1, 0x00, 0, false, ObjectFieldType.SectionBegin);
			fields[(int)ObjectField.obj_f_pc_flags] = new ObjectFieldDef(-1, 0, 0x00, 0, true, ObjectFieldType.Flags);
			fields[(int)ObjectField.obj_f_pc_flags_fate] = new ObjectFieldDef(-1, 0, 0x00, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_pc_reputation_idx] = new ObjectFieldDef(-1, 0, 0x00, 0, true, ObjectFieldType.Int32Array);
			fields[(int)ObjectField.obj_f_pc_reputation_ts_idx] = new ObjectFieldDef(-1, 0, 0x00, 0, true, ObjectFieldType.Int32Array);
			fields[(int)ObjectField.obj_f_pc_background] = new ObjectFieldDef(-1, 0, 0x00, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_pc_background_text] = new ObjectFieldDef(-1, 0, 0x00, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_pc_quest_idx] = new ObjectFieldDef(-1, 0, 0x00, 0, true, ObjectFieldType.Int32Array);
			fields[(int)ObjectField.obj_f_pc_blessing_idx] = new ObjectFieldDef(-1, 0, 0x00, 0, true, ObjectFieldType.Int32Array);
			fields[(int)ObjectField.obj_f_pc_blessing_ts_idx] = new ObjectFieldDef(-1, 0, 0x00, 0, true, ObjectFieldType.Int32Array);
			fields[(int)ObjectField.obj_f_pc_curse_idx] = new ObjectFieldDef(-1, 0, 0x00, 0, true, ObjectFieldType.Int32Array);
			fields[(int)ObjectField.obj_f_pc_curse_ts_idx] = new ObjectFieldDef(-1, 0, 0x00, 0, true, ObjectFieldType.Int32Array);
			fields[(int)ObjectField.obj_f_pc_party_id] = new ObjectFieldDef(-1, 0, 0x00, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_pc_rumor_idx] = new ObjectFieldDef(-1, 0, 0x00, 0, true, ObjectFieldType.Int32Array);
			fields[(int)ObjectField.obj_f_pc_pad_ias_2] = new ObjectFieldDef(-1, 0, 0x00, 0, true, ObjectFieldType.Unk);
			fields[(int)ObjectField.obj_f_pc_schematics_found_idx] = new ObjectFieldDef(-1, 0, 0x00, 0, true, ObjectFieldType.Int32Array);
			fields[(int)ObjectField.obj_f_pc_logbook_ego_idx] = new ObjectFieldDef(-1, 0, 0x00, 0, true, ObjectFieldType.Int32Array);
			fields[(int)ObjectField.obj_f_pc_fog_mask] = new ObjectFieldDef(-1, 0, 0x00, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_pc_player_name] = new ObjectFieldDef(-1, 0, 0x00, 0, true, ObjectFieldType.String);
			fields[(int)ObjectField.obj_f_pc_bank_money] = new ObjectFieldDef(-1, 0, 0x00, 0, true, ObjectFieldType.Int32);
            fields[(int)ObjectField.obj_f_pc_global_flags] = new ObjectFieldDef(-1, 0, 0x00, 0, true, ObjectFieldType.Int32Array);
			fields[(int)ObjectField.obj_f_pc_global_variables] = new ObjectFieldDef(-1, 0, 0x00, 0, true, ObjectFieldType.Int32Array);
			fields[(int)ObjectField.obj_f_pc_pad_i_1] = new ObjectFieldDef(-1, 0, 0x00, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_pc_pad_i_2] = new ObjectFieldDef(-1, 0, 0x00, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_pc_pad_ias_1] = new ObjectFieldDef(-1, 0, 0x00, 0, true, ObjectFieldType.Int32Array);
			fields[(int)ObjectField.obj_f_pc_pad_i64as_1] = new ObjectFieldDef(-1, 0, 0x00, 0, true, ObjectFieldType.Int32Array);
			fields[(int)ObjectField.obj_f_pc_end] = new ObjectFieldDef(-1, -1, 0x00, 0, false, ObjectFieldType.SectionEnd);

			fields[(int)ObjectField.obj_f_npc_begin] = new ObjectFieldDef(-1, -1, 0x00, 0, false, ObjectFieldType.SectionBegin);
			fields[(int)ObjectField.obj_f_npc_flags] = new ObjectFieldDef(-1, 16, 0x01, 0, true, ObjectFieldType.Flags);
			fields[(int)ObjectField.obj_f_npc_leader] = new ObjectFieldDef(-1, 16, 0x02, 0, true, ObjectFieldType.Obj);
			fields[(int)ObjectField.obj_f_npc_ai_data] = new ObjectFieldDef(-1, 16, 0x04, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_npc_combat_focus] = new ObjectFieldDef(-1, 16, 0x08, 0, true, ObjectFieldType.Obj);
			fields[(int)ObjectField.obj_f_npc_who_hit_me_last] = new ObjectFieldDef(-1, 16, 0x10, 0, true, ObjectFieldType.Obj);
			fields[(int)ObjectField.obj_f_npc_experience_worth] = new ObjectFieldDef(-1, 16, 0x20, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_npc_experience_pool] = new ObjectFieldDef(-1, 16, 0x40, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_npc_waypoints_idx] = new ObjectFieldDef(-1, 16, 0x80, 0, true, ObjectFieldType.Int64Array);
			fields[(int)ObjectField.obj_f_npc_waypoint_current] = new ObjectFieldDef(-1, 17, 0x01, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_npc_standpoint_day] = new ObjectFieldDef(-1, 17, 0x02, 0, true, ObjectFieldType.Int64);
			fields[(int)ObjectField.obj_f_npc_standpoint_night] = new ObjectFieldDef(-1, 17, 0x04, 0, true, ObjectFieldType.Int64);
			fields[(int)ObjectField.obj_f_npc_origin] = new ObjectFieldDef(-1, 17, 0x08, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_npc_faction] = new ObjectFieldDef(-1, 17, 0x10, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_npc_retail_price_multiplier] = new ObjectFieldDef(-1, 17, 0x20, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_npc_substitute_inventory] = new ObjectFieldDef(-1, 17, 0x40, 0, true, ObjectFieldType.Obj);
			fields[(int)ObjectField.obj_f_npc_reaction_base] = new ObjectFieldDef(-1, 17, 0x80, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_npc_social_class] = new ObjectFieldDef(-1, 18, 0x01, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_npc_reaction_pc_idx] = new ObjectFieldDef(-1, 18, 0x02, 0, true, ObjectFieldType.Int32Array);
			fields[(int)ObjectField.obj_f_npc_reaction_level_idx] = new ObjectFieldDef(-1, 18, 0x04, 0, true, ObjectFieldType.Int32Array);
			fields[(int)ObjectField.obj_f_npc_reaction_time_idx] = new ObjectFieldDef(-1, 18, 0x08, 0, true, ObjectFieldType.Int32Array);
			fields[(int)ObjectField.obj_f_npc_wait] = new ObjectFieldDef(-1, 18, 0x10, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_npc_generator_data] = new ObjectFieldDef(-1, 18, 0x20, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_npc_pad_i_1] = new ObjectFieldDef(-1, 18, 0x40, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_npc_damage_idx] = new ObjectFieldDef(-1, 18, 0x80, 0, true, ObjectFieldType.Int32Array);
			fields[(int)ObjectField.obj_f_npc_shit_list_idx] = new ObjectFieldDef(-1, 19, 0x01, 0, true, ObjectFieldType.Int32Array);
			fields[(int)ObjectField.obj_f_npc_end] = new ObjectFieldDef(-1, -1, 0x00, 0, false, ObjectFieldType.SectionEnd);

			fields[(int)ObjectField.obj_f_trap_begin] = new ObjectFieldDef(-1, -1, 0x00, 0, false, ObjectFieldType.SectionBegin);
			fields[(int)ObjectField.obj_f_trap_flags] = new ObjectFieldDef(-1, 8, 0x01, 0, true, ObjectFieldType.Flags);
			fields[(int)ObjectField.obj_f_trap_difficulty] = new ObjectFieldDef(-1, 8, 0x02, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_trap_pad_i_2] = new ObjectFieldDef(-1, 8, 0x04, 0, true, ObjectFieldType.Int32);
			fields[(int)ObjectField.obj_f_trap_pad_ias_1] = new ObjectFieldDef(-1, 8, 0x08, 0, true, ObjectFieldType.Unk);
			fields[(int)ObjectField.obj_f_trap_pad_i64as_1] = new ObjectFieldDef(-1, 8, 0x10, 0, true, ObjectFieldType.Unk);
			fields[(int)ObjectField.obj_f_trap_end] = new ObjectFieldDef(-1, -1, 0x00, 0, false, ObjectFieldType.SectionEnd);

			/*
			fields[(int)ObjectField.obj_f_total_normal]				= new ObjectFieldDef(-1, 0, 0x00, 0, true, ObjectFieldType.SectionBegin);
			fields[(int)ObjectField.obj_f_transient_begin]			= new ObjectFieldDef(-1, 0, 0x00, 0, true, ObjectFieldType.SectionBegin);
			fields[(int)ObjectField.obj_f_render_color]				= new ObjectFieldDef(-1, 0, 0x00, 0, true, ObjectFieldType.SectionBegin);
			fields[(int)ObjectField.obj_f_render_colors]			= new ObjectFieldDef(-1, 0, 0x00, 0, true, ObjectFieldType.SectionBegin);
			fields[(int)ObjectField.obj_f_render_palette]			= new ObjectFieldDef(-1, 0, 0x00, 0, true, ObjectFieldType.SectionBegin);
			fields[(int)ObjectField.obj_f_render_scale]				= new ObjectFieldDef(-1, 0, 0x00, 0, true, ObjectFieldType.SectionBegin);
			fields[(int)ObjectField.obj_f_render_alpha]				= new ObjectFieldDef(-1, 0, 0x00, 0, true, ObjectFieldType.SectionBegin);
			fields[(int)ObjectField.obj_f_render_x]					= new ObjectFieldDef(-1, 0, 0x00, 0, true, ObjectFieldType.SectionBegin);
			fields[(int)ObjectField.obj_f_render_y]					= new ObjectFieldDef(-1, 0, 0x00, 0, true, ObjectFieldType.SectionBegin);
			fields[(int)ObjectField.obj_f_render_width]				= new ObjectFieldDef(-1, 0, 0x00, 0, true, ObjectFieldType.SectionBegin);
			fields[(int)ObjectField.obj_f_render_height]			= new ObjectFieldDef(-1, 0, 0x00, 0, true, ObjectFieldType.SectionBegin);
			fields[(int)ObjectField.obj_f_palette]					= new ObjectFieldDef(-1, 0, 0x00, 0, true, ObjectFieldType.SectionBegin);
			fields[(int)ObjectField.obj_f_color]					= new ObjectFieldDef(-1, 0, 0x00, 0, true, ObjectFieldType.SectionBegin);
			fields[(int)ObjectField.obj_f_colors]					= new ObjectFieldDef(-1, 0, 0x00, 0, true, ObjectFieldType.SectionBegin);
			fields[(int)ObjectField.obj_f_render_flags]				= new ObjectFieldDef(-1, 0, 0x00, 0, true, ObjectFieldType.SectionBegin);
			fields[(int)ObjectField.obj_f_temp_id]					= new ObjectFieldDef(-1, 0, 0x00, 0, true, ObjectFieldType.SectionBegin);
			fields[(int)ObjectField.obj_f_light_handle]				= new ObjectFieldDef(-1, 0, 0x00, 0, true, ObjectFieldType.SectionBegin);
			fields[(int)ObjectField.obj_f_overlay_light_handles]	= new ObjectFieldDef(-1, 0, 0x00, 0, true, ObjectFieldType.SectionBegin);
			fields[(int)ObjectField.obj_f_shadow_handles]			= new ObjectFieldDef(-1, 0, 0x00, 0, true, ObjectFieldType.SectionBegin);
			fields[(int)ObjectField.obj_f_internal_flags]			= new ObjectFieldDef(-1, 0, 0x00, 0, true, ObjectFieldType.SectionBegin);
			fields[(int)ObjectField.obj_f_find_node]				= new ObjectFieldDef(-1, 0, 0x00, 0, true, ObjectFieldType.SectionBegin);
			fields[(int)ObjectField.obj_f_transient_end]			= new ObjectFieldDef(-1, 0, 0x00, 0, true, ObjectFieldType.SectionBegin);
			fields[(int)ObjectField.obj_f_type]						= new ObjectFieldDef(-1, 0, 0x00, 0, true, ObjectFieldType.SectionBegin);
			fields[(int)ObjectField.obj_f_prototype_handle]			= new ObjectFieldDef(-1, 0, 0x00, 0, true, ObjectFieldType.SectionBegin);
			fields[(int)ObjectField.obj_f_max]						= new ObjectFieldDef(-1, 0, 0x00, 0, true, ObjectFieldType.SectionBegin);
			*/
		}
	}
}
