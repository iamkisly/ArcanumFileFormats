using System;
using ArcanumFileFormats.Common;
using ArcanumFileFormats.ObjectsNew.Legacy;
using ArcanumFileFormats.Utils;

namespace ArcanumFileFormats.ObjectsNew
{
    public class Wall : Common
    {
		[Order(37)] public int obj_f_wall_flags {get; set;}

		[Order(38)] public Int32 obj_f_wall_pad_i_1 {get; set;}
		[Order(39)] public Int32 obj_f_wall_pad_i_2 {get; set;}
		[Order(40)] public Unknown obj_f_wall_pad_ias_1 {get; set;}
		[Order(41)] public Unknown obj_f_wall_pad_i64as_1 {get; set;}
    }
}