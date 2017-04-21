using System;
using ArcanumFileFormats.Common;
using ArcanumFileFormats.ObjectsNew.Legacy;
using ArcanumFileFormats.Utils;

namespace ArcanumFileFormats.ObjectsNew
{
    public partial class Armor : Item
    {
		[Order(60)] public Int32 obj_f_armor_flags {get; set;}
		[Order(61)] public Int32 obj_f_armor_paper_doll_aid {get; set;}
		[Order(62)] public Int32 obj_f_armor_ac_adj {get; set;}
		[Order(63)] public Int32 obj_f_armor_magic_ac_adj {get; set;}
		[Order(64)] public Int32[] obj_f_armor_resistance_adj_idx {get; set;}
		[Order(65)] public Int32[] obj_f_armor_magic_resistance_adj_idx {get; set;}
		[Order(66)] public Int32 obj_f_armor_silent_move_adj {get; set;}
		[Order(67)] public Int32 obj_f_armor_magic_silent_move_adj {get; set;}
		[Order(68)] public Int32 obj_f_armor_unarmed_bonus_damage {get; set;}
		[Order(69)] public Int32 obj_f_armor_pad_i_2 {get; set;}
		[Order(70)] public Unknown obj_f_armor_pad_ias_1 {get; set;}
		[Order(71)] public Unknown obj_f_armor_pad_i64as_1 {get; set;}
    }
}