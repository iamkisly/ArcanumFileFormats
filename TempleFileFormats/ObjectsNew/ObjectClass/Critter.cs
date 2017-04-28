using System;
using ArcanumFileFormats.Common;
using ArcanumFileFormats.ObjectsNew.Legacy;
using ArcanumFileFormats.Utils;
using ArcanumFileFormats.ObjectsNew.Flags;

namespace ArcanumFileFormats.ObjectsNew
{
	public partial class Critter : Common
    {
		[Order(37)] public Int32 obj_f_critter_flags {get; set;}
		[Order(38)] public Int32 obj_f_critter_flags2 {get; set;}
		[Order(39)] public Tuple<Int32[], Int32[]> obj_f_critter_stat_base_idx {get; set;}
		[Order(40)] public Tuple<Int32[], Int32[]> obj_f_critter_basic_skill_idx {get; set;}
		[Order(41)] public Tuple<Int32[], Int32[]> obj_f_critter_tech_skill_idx {get; set;}
		[Order(42)] public Tuple<Int32[], Int32[]> obj_f_critter_spell_tech_idx {get; set;}
		[Order(43)] public Int32 obj_f_critter_fatigue_pts {get; set;}
		[Order(44)] public Int32 obj_f_critter_fatigue_adj {get; set;}
		[Order(45)] public Int32 obj_f_critter_fatigue_damage {get; set;}
		[Order(46)] public Int32 obj_f_critter_crit_hit_chart {get; set;}
		[Order(47)] public Tuple<Int32[], Int32[]> obj_f_critter_effects_idx {get; set;}
		[Order(48)] public Tuple<Int32[], Int32[]> obj_f_critter_effect_cause_idx {get; set;}
		[Order(49)] public ObjectGuid obj_f_critter_fleeing_from {get; set;}
		[Order(50)] public Int32 obj_f_critter_portrait {get; set;} //strinf aid
		[Order(51)] public ObjectGuid obj_f_critter_gold {get; set;}
		[Order(52)] public ObjectGuid obj_f_critter_arrows {get; set;}
		[Order(53)] public ObjectGuid obj_f_critter_bullets {get; set;}
		[Order(54)] public ObjectGuid obj_f_critter_power_cells {get; set;}
		[Order(55)] public ObjectGuid obj_f_critter_fuel {get; set;}
		[Order(56)] public Int32 obj_f_critter_inventory_num {get; set;}
		[Order(57)] public Tuple<ObjectGuid[], Int32[]> obj_f_critter_inventory_list_idx {get; set;}
		[Order(58)] public Int32 obj_f_critter_inventory_source {get; set;}
		[Order(59)] public Int32 obj_f_critter_description_unknown {get; set;}
		[Order(60)] public Tuple<ObjectGuid[], Int32[]> obj_f_critter_follower_idx {get; set;}
		[Order(61)] public Location obj_f_critter_teleport_dest {get; set;}
		[Order(62)] public Int32 obj_f_critter_teleport_map {get; set;}
		[Order(63)] public Int32 obj_f_critter_death_time {get; set;}
		[Order(64)] public Int32 obj_f_critter_auto_level_scheme {get; set;}

		[Order(65)] public Int32 obj_f_critter_pad_i_1 {get; set;}
		[Order(66)] public Int32 obj_f_critter_pad_i_2 {get; set;}
		[Order(67)] public Int32 obj_f_critter_pad_i_3 {get; set;}
		[Order(68)] public Unknown obj_f_critter_pad_ias_1 {get; set;}
		[Order(69)] public Unknown obj_f_critter_pad_i64as_1 {get; set;}
    }
}