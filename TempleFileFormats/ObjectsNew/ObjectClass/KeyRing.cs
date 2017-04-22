using System;
using ArcanumFileFormats.Common;
using ArcanumFileFormats.ObjectsNew.Legacy;
using ArcanumFileFormats.Utils;

namespace ArcanumFileFormats.ObjectsNew
{
    public class KeyRing : Item
    {
		[Order(60)] public Int32 obj_f_key_ring_flags {get; set;}
		[Order(61)] public Tuple<Int32[], Int32[]> obj_f_key_ring_list_idx {get; set;}
        
		[Order(62)] public Int32 obj_f_key_ring_pad_i_1 {get; set;}
		[Order(63)] public Int32 obj_f_key_ring_pad_i_2 {get; set;}
		[Order(64)] public Unknown obj_f_key_ring_pad_ias_1 {get; set;}        
		[Order(65)] public Unknown obj_f_key_ring_pad_i64as_1 {get; set;}        
    }
}