using System;
using ArcanumFileFormats.Common;
using ArcanumFileFormats.ObjectsNew.Legacy;
using ArcanumFileFormats.Utils;
using ArcanumFileFormats.ObjectsNew.Flags;

namespace ArcanumFileFormats.ObjectsNew
{
    public class Container : Common
    {
		[Order(37)] public Int32 obj_f_container_flags {get; set;}
		[Order(38)] public Int32 obj_f_container_lock_difficulty {get; set;}
		[Order(39)] public Int32 obj_f_container_key_id {get; set;}
		[Order(40)] public Int32 obj_f_container_inventory_num {get; set;}
		[Order(41)] public Tuple<ObjectGuid[], Int32[]> obj_f_container_inventory_list_idx {get; set;}
		[Order(42)] public Int32 obj_f_container_inventory_source {get; set;}
		[Order(43)] public Int32 obj_f_container_notify_npc {get; set;}
		[Order(44)] public Int32 obj_f_container_pad_i_1 {get; set;}
		[Order(45)] public Int32 obj_f_container_pad_i_2 {get; set;}
		[Order(46)] public Unknown obj_f_container_pad_ias_1 {get; set;} 
		[Order(47)] public Unknown obj_f_container_pad_i64as_1 {get; set;} 
    }
}