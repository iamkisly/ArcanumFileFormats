using System;
using System.IO;
using ArcanumFileFormats.Common;
using ArcanumFileFormats.ObjectsNew.Legacy;
using ArcanumFileFormats.Utils;

namespace ArcanumFileFormats.ObjectsNew
{
    public partial class NPC : Critter
    {
		[Order(70)] public Int32 obj_f_npc_flags {get; set;} 
		[Order(71)] public ObjectGuid obj_f_npc_leader {get; set;}
		[Order(72)] public Int32 obj_f_npc_ai_data {get; set;}
		[Order(73)] public ObjectGuid obj_f_npc_combat_focus {get; set;}
		[Order(74)] public ObjectGuid obj_f_npc_who_hit_me_last {get; set;}
		[Order(75)] public Int32 obj_f_npc_experience_worth {get; set;}
		[Order(76)] public Int32 obj_f_npc_experience_pool {get; set;}
		[Order(77)] public Tuple<Location[], Int32[]> obj_f_npc_waypoints_idx {get; set;}
		[Order(78)] public Int32 obj_f_npc_waypoint_current {get; set;}
		[Order(79)] public Location obj_f_npc_standpoint_day {get; set;}
		[Order(80)] public Location obj_f_npc_standpoint_night {get; set;}
		[Order(81)] public Int32 obj_f_npc_origin {get; set;}
		[Order(82)] public Int32 obj_f_npc_faction {get; set;}
		[Order(83)] public Int32 obj_f_npc_retail_price_multiplier {get; set;}
		[Order(84)] public ObjectGuid obj_f_npc_substitute_inventory {get; set;}
		[Order(85)] public Int32 obj_f_npc_reaction_base {get; set;}
		[Order(86)] public Int32 obj_f_npc_social_class {get; set;}
		[Order(87)] public Tuple<Int32[], Int32[]> obj_f_npc_reaction_pc_idx {get; set;}
		[Order(88)] public Tuple<Int32[], Int32[]> obj_f_npc_reaction_level_idx {get; set;}
		[Order(89)] public Tuple<Int32[], Int32[]> obj_f_npc_reaction_time_idx {get; set;}
		[Order(90)] public Int32 obj_f_npc_wait {get; set;}
		[Order(91)] public Int32 obj_f_npc_generator_data {get; set;}
		[Order(92)] public Int32 obj_f_npc_pad_i_1 {get; set;}
		[Order(93)] public Tuple<Int32[], Int32[]> obj_f_npc_damage_idx {get; set;}
		[Order(94)] public Tuple<Int32[], Int32[]> obj_f_npc_shit_list_idx {get; set;}
    }
}