using System;
using ArcanumFileFormats.Common;
using ArcanumFileFormats.ObjectsNew.Legacy;
using ArcanumFileFormats.Utils; 

namespace ArcanumFileFormats.ObjectsNew
{
    public class Written : Item
    {
		[Order(60)] public Int32 obj_f_written_flags {get; set;}
		[Order(61)] public Int32 obj_f_written_subtype {get; set;}
		[Order(62)] public Int32 obj_f_written_text_start_line {get; set;}
		[Order(63)] public Int32 obj_f_written_text_end_line {get; set;}

		[Order(64)] public Int32 obj_f_written_pad_i_1 {get; set;}
		[Order(65)] public Int32 obj_f_written_pad_i_2 {get; set;}
		[Order(66)] public Unknown obj_f_written_pad_ias_1 {get; set;}        
		[Order(67)] public Unknown obj_f_written_pad_i64as_1 {get; set;}        
    }
}