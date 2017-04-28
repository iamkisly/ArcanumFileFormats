using System;
using ArcanumFileFormats.Common;
using ArcanumFileFormats.ObjectsNew.Legacy;
using ArcanumFileFormats.Utils;
using ArcanumFileFormats.ObjectsNew.Flags;

namespace ArcanumFileFormats.ObjectsNew
{
    public class Portal : Common
    {
		[Order(37)] public Int32 obj_f_portal_flags {get; set;}
		[Order(38)] public Int32 obj_f_portal_lock_difficulty {get; set;}
		[Order(39)] public Int32 obj_f_portal_key_id {get; set;}
		[Order(40)] public Int32 obj_f_portal_notify_npc {get; set;}

		[Order(41)] public Int32 obj_f_portal_pad_i_1 {get; set;}
		[Order(42)] public Int32 obj_f_portal_pad_i_2 {get; set;}
		[Order(43)] public Unknown obj_f_portal_pad_ias_1 {get; set;}
		[Order(44)] public Unknown obj_f_portal_pad_i64as_1 {get; set;}
    }
}
