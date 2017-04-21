using System;
using ArcanumFileFormats.Common;
using ArcanumFileFormats.ObjectsNew.Legacy;
using ArcanumFileFormats.Utils;

namespace ArcanumFileFormats.ObjectsNew
{
    public class Weapon : Item
    {
		[Order(60)] public Int32 obj_f_weapon_flags {get; set;}
		[Order(61)] public Int32 obj_f_weapon_paper_doll_aid {get; set;} //string
		[Order(62)] public Int32 obj_f_weapon_bonus_to_hit {get; set;}
		[Order(63)] public Int32 obj_f_weapon_magic_hit_adj {get; set;}
		[Order(64)] public Int32[] obj_f_weapon_damage_lower_idx {get; set;}
		[Order(65)] public Int32[] obj_f_weapon_damage_upper_idx {get; set;}
		[Order(66)] public Int32[] obj_f_weapon_magic_damage_adj_idx {get; set;}
		[Order(67)] public Int32 obj_f_weapon_speed_factor {get; set;}
		[Order(68)] public Int32 obj_f_weapon_magic_speed_adj {get; set;}
		[Order(69)] public Int32 obj_f_weapon_range {get; set;}
		[Order(70)] public Int32 obj_f_weapon_magic_range_adj {get; set;}
		[Order(71)] public Int32 obj_f_weapon_min_strength {get; set;}
		[Order(72)] public Int32 obj_f_weapon_magic_min_strength_adj {get; set;}
		[Order(73)] public Int32 obj_f_weapon_ammo_type {get; set;} //enum
		[Order(74)] public Int32 obj_f_weapon_ammo_consumption {get; set;}
		[Order(75)] public Int32 obj_f_weapon_missile_aid {get; set;} //string
		[Order(76)] public Int32 obj_f_weapon_visual_effect_aid {get; set;} //string
		[Order(77)] public Int32 obj_f_weapon_crit_hit_chart {get; set;}
		[Order(78)] public Int32 obj_f_weapon_magic_crit_hit_chance {get; set;}
		[Order(79)] public Int32 obj_f_weapon_magic_crit_hit_effect {get; set;}
		[Order(80)] public Int32 obj_f_weapon_crit_miss_chart {get; set;}
		[Order(81)] public Int32 obj_f_weapon_magic_crit_miss_chance {get; set;}
		[Order(82)] public Int32 obj_f_weapon_magic_crit_miss_effect {get; set;}

		[Order(83)] public Int32 obj_f_weapon_pad_i_1 {get; set;}
		[Order(84)] public Int32 obj_f_weapon_pad_i_2 {get; set;}
		[Order(85)] public Unknown obj_f_weapon_pad_ias_1 {get; set;} 
		[Order(86)] public Unknown obj_f_weapon_pad_i64as_1 {get; set;} 
    }
}