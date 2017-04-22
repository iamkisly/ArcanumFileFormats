using System;
using ArcanumFileFormats.Common;
using ArcanumFileFormats.ObjectsNew.Legacy;
using ArcanumFileFormats.Utils;

namespace ArcanumFileFormats.ObjectsNew
{
    public class PC : Critter
    {
		[Order(70)]public Int32 obj_f_pc_flags {get; set;}
		[Order(71)]public Int32 obj_f_pc_flags_fate {get; set;}
		[Order(72)]public Tuple<Int32[], Int32[]> obj_f_pc_reputation_idx {get; set;}
		[Order(73)]public Tuple<Int32[], Int32[]> obj_f_pc_reputation_ts_idx {get; set;}
		[Order(74)]public Int32 obj_f_pc_background {get; set;}
		[Order(75)]public Int32 obj_f_pc_background_text {get; set;}
		[Order(76)]public Tuple<Int32[], Int32[]> obj_f_pc_quest_idx {get; set;}
		[Order(77)]public Tuple<Int32[], Int32[]> obj_f_pc_blessing_idx {get; set;}
		[Order(78)]public Tuple<Int32[], Int32[]> obj_f_pc_blessing_ts_idx {get; set;}
		[Order(79)]public Tuple<Int32[], Int32[]> obj_f_pc_curse_idx {get; set;}
		[Order(80)]public Tuple<Int32[], Int32[]> obj_f_pc_curse_ts_idx {get; set;}
		[Order(81)]public Int32 obj_f_pc_party_id {get; set;}
		[Order(82)]public Tuple<Int32[], Int32[]> obj_f_pc_rumor_idx {get; set;}
		[Order(83)]public Unknown obj_f_pc_pad_ias_2 {get; set;}
		[Order(84)]public Tuple<Int32[], Int32[]> obj_f_pc_schematics_found_idx {get; set;}
		[Order(85)]public Tuple<Int32[], Int32[]> obj_f_pc_logbook_ego_idx {get; set;}
		[Order(86)]public Int32 obj_f_pc_fog_mask {get; set;}
		[Order(87)]public PrefixedString obj_f_pc_player_name {get; set;} 
		[Order(88)]public Int32 obj_f_pc_bank_money {get; set;}
		[Order(89)]public Tuple<Int32[], Int32[]> obj_f_pc_global_flags {get; set;}
		[Order(90)]public Tuple<Int32[], Int32[]> obj_f_pc_global_variables {get; set;}
		[Order(91)]public Int32 obj_f_pc_pad_i_1 {get; set;}
		[Order(92)]public Int32 obj_f_pc_pad_i_2 {get; set;}
		[Order(93)]public Unknown obj_f_pc_pad_ias_1 {get; set;}
		[Order(94)]public Unknown obj_f_pc_pad_i64as_1 {get; set;}
        [Order(95)] public Unknown obj_f_pc_pad_i64as_2 { get; set; }
    }
}