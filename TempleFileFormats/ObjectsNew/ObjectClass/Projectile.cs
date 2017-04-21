using System;
using ArcanumFileFormats.Common;
using ArcanumFileFormats.ObjectsNew.Legacy;
using ArcanumFileFormats.Utils;

namespace ArcanumFileFormats.ObjectsNew
{
    public class Projectile : Common
    {
		[Order(37)] public Int32 obj_f_projectile_flags_combat {get; set;}
		[Order(38)] public Int32 obj_f_projectile_flags_combat_damage {get; set;}
		[Order(39)] public Location obj_f_projectile_hit_loc {get; set;}
		[Order(40)] public Int32 obj_f_projectile_parent_weapon {get; set;}

		[Order(41)] public Int32 obj_f_projectile_pad_i_1 {get; set;}
		[Order(42)] public Int32 obj_f_projectile_pad_i_2 {get; set;}
		[Order(43)] public Unknown obj_f_projectile_pad_ias_1 {get; set;}
		[Order(44)] public Unknown obj_f_projectile_pad_i64as_1 {get; set;}
    }
}