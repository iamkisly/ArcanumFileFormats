using System;
using ArcanumFileFormats.Common;
using ArcanumFileFormats.ObjectsNew.Legacy;
using ArcanumFileFormats.Utils;

namespace ArcanumFileFormats.ObjectsNew
{
    public partial class Key : Item
    {
		[Order(60)] public Int32 obj_f_key_key_id {get; set;}

		[Order(61)] public Int32 obj_f_key_pad_i_1 {get; set;}
		[Order(62)] public Int32 obj_f_key_pad_i_2 {get; set;}
		[Order(63)] public Unknown obj_f_key_pad_ias_1 {get; set;}        
		[Order(64)] public Unknown obj_f_key_pad_i64as_1 {get; set;}        
    }
}