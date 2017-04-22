using System;
using ArcanumFileFormats.Common;
using ArcanumFileFormats.ObjectsNew.Legacy;
using ArcanumFileFormats.Utils;

namespace ArcanumFileFormats.ObjectsNew
{
    public partial class Common
    {
		[Order(01)] public ArtId obj_f_current_aid {get; set;}
		[Order(02)] public Location obj_f_location {get; set;}
		[Order(03)] public Int32 obj_f_offset_x {get; set;}
		[Order(04)] public Int32 obj_f_offset_y {get; set;}
		[Order(05)] public ArtId obj_f_shadow {get; set;} //may be bool/int
		[Order(06)] public Tuple<Int32[], Int32[]> obj_f_overlay_fore {get; set;}
		[Order(07)] public Tuple<Int32[], Int32[]> obj_f_overlay_back {get; set;}
		[Order(08)] public Tuple<Int32[], Int32[]> obj_f_underlay {get; set;}
		[Order(09)] public Int32 obj_f_blit_flags {get; set;}
		[Order(10)] public Color obj_f_blit_color {get; set;}
		[Order(11)] public Int32 obj_f_blit_alpha {get; set;}
		[Order(12)] public Int32 obj_f_blit_scale {get; set;}
		[Order(13)] public Int32 obj_f_light_flags {get; set;}
		[Order(14)] public ArtId obj_f_light_aid {get; set;}
		[Order(15)] public Color obj_f_light_color {get; set;}
		[Order(16)] public Unknown obj_f_overlay_light_flags {get; set;}
		[Order(17)] public Tuple<Int32[], Int32[]> obj_f_overlay_light_aid {get; set;}
		[Order(18)] public Unknown obj_f_overlay_light_color {get; set;}
		[Order(19)] public Int32 obj_f_flags {get; set;}
		[Order(20)] public Int32 obj_f_spell_flags {get; set;}
		[Order(21)] public Int32 obj_f_blocking_mask {get; set;}
		[Order(22)] public Int32 obj_f_name {get; set;}
		[Order(23)] public Int32 obj_f_description {get; set;}
		[Order(24)] public ArtId obj_f_aid {get; set;}
		[Order(25)] public ArtId obj_f_destroyed_aid  {get; set;}
		[Order(26)] public Int32 obj_f_AC {get; set;}
		[Order(27)] public Int32 obj_f_hp_pts {get; set;}
		[Order(28)] public Int32 obj_f_hp_adj {get; set;}
		[Order(29)] public Int32 obj_f_hp_damage {get; set;}
		[Order(30)] public Int32 obj_f_material {get; set;}
		[Order(31)] public Tuple<Int32[], Int32[]> obj_f_resistance_idx {get; set;}
		[Order(32)] public Tuple<ObjectScript[], Int32[]> obj_f_scripts_idx {get; set;}
		[Order(33)] public Int32 obj_f_sound_effect {get; set;}
		[Order(34)] public Int32 obj_f_category {get; set;}
		[Order(35)] public Unknown obj_f_pad_ias_1 {get; set;}
		[Order(36)] public Unknown obj_f_pad_i64as_1 {get; set;}
    }
}