using System;
using ArcanumFileFormats.Common;
using ArcanumFileFormats.ObjectsNew.Legacy;
using ArcanumFileFormats.Utils;

namespace ArcanumFileFormats.ObjectsNew
{
    public partial class Item : Common
    {
		[Order(37)] public Int32 obj_f_item_flags {get; set;}
		[Order(38)] public ObjectGuid obj_f_item_parent {get; set;}
		[Order(39)] public Int32 obj_f_item_weight {get; set;}
		[Order(40)] public Int32 obj_f_item_magic_weight_adj {get; set;}
		[Order(41)] public Int32 obj_f_item_worth {get; set;}
		[Order(42)] public Int32 obj_f_item_mana_store {get; set;}
		[Order(43)] public Int32 obj_f_item_inv_aid {get; set;} //string aid
		[Order(44)] public Int32 obj_f_item_inv_location {get; set;}
		[Order(45)] public Int32 obj_f_item_use_aid_fragment {get; set;} //string aid
		[Order(46)] public Int32 obj_f_item_magic_tech_complexity {get; set;}
		[Order(47)] public Int32 obj_f_item_discipline {get; set;}
		[Order(48)] public Int32 obj_f_item_description_unknown {get; set;}
		[Order(49)] public Int32 obj_f_item_description_effects {get; set;}
		[Order(50)] public Int32 obj_f_item_spell_1 {get; set;}
		[Order(51)] public Int32 obj_f_item_spell_2 {get; set;}
		[Order(52)] public Int32 obj_f_item_spell_3 {get; set;}
		[Order(53)] public Int32 obj_f_item_spell_4 {get; set;}
		[Order(54)] public Int32 obj_f_item_spell_5 {get; set;}
		[Order(55)] public Int32 obj_f_item_spell_mana_store {get; set;}
		[Order(56)] public Int32 obj_f_item_ai_action {get; set;}
		[Order(57)] public Int32 obj_f_item_pad_i_1 {get; set;}
		[Order(58)] public Unknown obj_f_item_pad_ias_1 {get; set;}
		[Order(59)] public Unknown obj_f_item_pad_i64as_1 {get; set;}
    }
}