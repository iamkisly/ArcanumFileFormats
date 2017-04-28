using System;
using ArcanumFileFormats.Common;
using ArcanumFileFormats.ObjectsNew.Legacy;
using ArcanumFileFormats.Utils;
using ArcanumFileFormats.ObjectsNew.Flags;

namespace ArcanumFileFormats.ObjectsNew
{
    public class Scenery : Common
    {
		[Order(37)] public Int32 obj_f_scenery_flags {get; set;}
		[Order(38)] public ObjectGuid obj_f_scenery_whos_in_me {get; set;}
		[Order(39)] public Int32 obj_f_scenery_respawn_delay {get; set;}
		[Order(40)] public Int32 obj_f_scenery_pad_i_2 {get; set;}

		[Order(41)] public Unknown obj_f_scenery_pad_ias_1 {get; set;} //byte
		[Order(42)] public Unknown obj_f_scenery_pad_i64as_1 {get; set;} //byte
    }
}