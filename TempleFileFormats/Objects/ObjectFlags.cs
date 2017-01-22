using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempleFileFormats.Objects
{

    /*
    char *off_58A934[21] =
    {
        "obj_f_flags",
        "obj_f_spell_flags",
        "obj_f_wall_flags",
        "obj_f_portal_flags",
        "obj_f_container_flags",
        "obj_f_scenery_flags",
        "obj_f_item_flags",
        "obj_f_weapon_flags",
        "obj_f_ammo_flags",
        "obj_f_armor_flags",
        "obj_f_gold_flags",
        "obj_f_food_flags",
        "obj_f_scroll_flags",
        "obj_f_key_ring_flags",
        "obj_f_written_flags",
        "obj_f_generic_flags",
        "obj_f_critter_flags",
        "obj_f_critter_flags2",
        "obj_f_pc_flags",
        "obj_f_npc_flags",
        "obj_f_trap_flags"
    }; // weak 
     */

    public enum ObjectFlags
	{
		//Obj_Flag
		OF_DESTROYED = 0,
		OF_OFF,
		OF_FLAT,
		OF_TEXT,
		OF_SEE_THROUGH,
		OF_SHOOT_THROUGH,
		OF_TRANSLUCENT,
		OF_SHRUNK,
		OF_DONTDRAW,
		OF_INVISIBLE,
		OF_NO_BLOCK,
		OF_CLICK_THROUGH,
		OF_INVENTORY,
		OF_DYNAMIC,
		OF_PROVIDES_COVER,
		OF_HAS_OVERLAYS,
		OF_HAS_UNDERLAYS,
		OF_WADING,
		OF_WATER_WALKING,
		OF_STONED,
		OF_DONTLIGHT,
		OF_TEXT_FLOATER,
		OF_INVULNERABLE,
		OF_EXTINCT,
		OF_TRAP_PC,
		OF_TRAP_SPOTTED,
		OF_DISALLOW_WADING,
		OF_MULTIPLAYER_LOCK,
		OF_FROZEN,
		OF_ANIMATED_DEAD,
		OF_TELEPORTED,
    };
    public enum ObjectFlags_Spell
    {
		//Obj_Spell_Flag
		OSF_INVISIBLE = 0,
		OSF_FLOATING,
		OSF_BODY_OF_AIR,
		OSF_BODY_OF_EARTH,
		OSF_BODY_OF_FIRE,
		OSF_BODY_OF_WATER,
		OSF_DETECTING_MAGIC,
		OSF_DETECTING_ALIGNMENT,
		OSF_DETECTING_TRAPS,
		OSF_DETECTING_INVISIBLE,
		OSF_SHIELDED,
		OSF_ANTI_MAGIC_SHELL,
		OSF_BONDS_OF_MAGIC,
		OSF_FULL_REFLECTION,
		OSF_SUMMONED,
		OSF_ILLUSION,
		OSF_STONED,
		OSF_POLYMORPHED,
		OSF_MIRRORED,
		OSF_SHRUNK,
		OSF_PASSWALLED,
		OSF_WATER_WALKING,
		OSF_MAGNETIC_INVERSION,
		OSF_CHARMED,
		OSF_ENTANGLED,
		OSF_SPOKEN_WITH_DEAD,
		OSF_TEMPUS_FUGIT,
		OSF_MIND_CONTROLLED,
		OSF_DRUNK,
		OSF_ENSHROUDED,
		OSF_FAMILIAR,
		OSF_HARDENED_HANDS
    };
    public enum ObjectFlags_Wall
    {
		//Obj_Wall_Flag
		OWAF_TRANS_DISALLOW = 0,
		OWAF_TRANS_LEFT,
		OWAF_TRANS_RIGHT,
		OWAF_TRANS_ALL
    };
    public enum ObjectFlags_Portal
    {
		//Obj_Portal_Flag
		OPF_LOCKED = 0,
		OPF_JAMMED,
		OPF_MAGICALLY_HELD,
		OPF_NEVER_LOCKED,
		OPF_ALWAYS_LOCKED,
		OPF_LOCKED_DAY,
		OPF_LOCKED_NIGHT,
		OPF_BUSTED,
		OPF_STICKY
    };
    public enum ObjectFlags_Container
    {
        //Obj_Container_Flag
        OCOF_LOCKED = 0,
        OCOF_JAMMED,
        OCOF_MAGICALLY_HELD,
        OCOF_NEVER_LOCKED,
        OCOF_ALWAYS_LOCKED,
        OCOF_LOCKED_DAY,
        OCOF_LOCKED_NIGHT,
        OCOF_BUSTED,
        OCOF_STICKY
    };

    public enum ObjectFlags_Scenery
    {
		OSCF_NO_AUTO_ANIMATE,
		OSCF_BUSTED,
		OSCF_NOCTURNAL,
		OSCF_MARKS_TOWNMAP,
		OSCF_IS_FIRE,
		OSCF_RESPAWNABLE,
		OSCF_SOUND_SMALL,
		OSCF_SOUND_MEDIUM,
		OSCF_SOUND_EXTRA_LARGE
    };
    public enum ObjectFlags_Item
    {
		//Obj_Item_Flag
		OIF_IDENTIFIED = 0, //[0] 0x01
		OIF_WONT_SELL,      //[0] 0x02
		OIF_IS_MAGICAL,     //[0] 0x04
		OIF_TRANSFER_LIGHT, //[0] 0x08
		OIF_NO_DISPLAY,     //[0] 0x10 
		OIF_NO_DROP,        //[0] 0x20 
		OIF_HEXED,          //[0] 0x40 
		OIF_CAN_USE_BOX,    //[0] 0x80 
		OIF_NEEDS_TARGET,   //[1] 0x01 
		OIF_LIGHT_SMALL,
		OIF_LIGHT_MEDIUM,
		OIF_LIGHT_LARGE,
		OIF_LIGHT_XLARGE,
		OIF_PERSISTENT,     //[1] 0x20 
		OIF_MT_TRIGGERED,
		OIF_STOLEN,         //[1] 0x80 
		OIF_USE_IS_THROW,
		OIF_NO_DECAY,       //[2] 0x02 
		OIF_UBER,           //[2] 0x04
		OIF_NO_NPC_PICKUP,  //[2] 0x08 
		OIF_NO_RANGED_USE,
		OIF_VALID_AI_ACTION,
		OIF_MP_INSERTED,
    };
    public enum ObjectFlags_Weapon
    {
		//Obj_Weapon_Flag
		OWF_LOUD = 0,           //[0] 0x01
		OWF_SILENT,             //[0] 0x02
		OWF_TWO_HANDED,         //[0] 0x04
		OWF_HAND_COUNT_FIXED,   //[0] 0x08
		OWF_THROWABLE,          //[0] 0x10
		OWF_TRANS_PROJECTILE,
		OWF_BOOMERANGS,         //[0] 0x40
		OWF_IGNORE_RESISTANCE,
		OWF_DAMAGE_ARMOR,
		OWF_DEFAULT_THROWS
    };
    public enum ObjectFlags_Ammo
    {
		//Obj_Ammo_Flag
		OAF_NONE = 0
    };
    public enum ObjectFlags_Armor
    {
		//Obj_Armor_Flag
		OARF_SIZE_SMALL = 0,
		OARF_SIZE_MEDIUM,
		OARF_SIZE_LARGE,
		OARF_MALE_ONLY,
		OARF_FEMALE_ONLY
    };
    public enum ObjectFlags_Gold
    {
		//Obj_Gold_Flag
		OGOF_NONE = 0
    };
    public enum ObjectFlags_Food
    {
		//Obj_Food_Flag
		OFF_NONE = 0
    };
    public enum ObjectFlags_Scroll //TODO: I have no confidence in it. Mb SceneRy ?
    {
		//Obj_Scroll?_Flag
		OSRF_NONE = 0
    };
    public enum ObjectFlags_KeyRing //TODO: I have no confidence in it.
    {
		//Obj_Unk_Flag
		OKRF_PRIMARY_RING = 0
    };

    public enum ObjectFlags_Written
    {
		//Obj_Written_Flag
		OWRF_NONE = 0
    };
    public enum ObjectFlags_Generic //TODO: I have no confidence in it.
    {
		//Obj_Unk_Flag
		OGF_USES_TORCH_SHIELD_LOCATION = 0,
		OGF_IS_LOCKPICK,
		OGF_IS_TRAP_DEVICE
	}; // weak
    public enum ObjectFlags_Critter
    {
        OCF_IS_CONCEALED = 0,
        OCF_MOVING_SILENTLY,
        OCF_UNDEAD,
        OCF_ANIMAL,
        OCF_FLEEING,
        OCF_STUNNED,
        OCF_PARALYZED,
        OCF_BLINDED,
        OCF_CRIPPLED_ARMS_ONE,
        OCF_CRIPPLED_ARMS_BOTH,
        OCF_CRIPPLED_LEGS_BOTH,
        OCF_UNUSED,
        OCF_SLEEPING,
        OCF_MUTE,
        OCF_SURRENDERED,
        OCF_MONSTER,
        OCF_SPELL_FLEE,
        OCF_ENCOUNTER,
        OCF_COMBAT_MODE_ACTIVE,
        OCF_LIGHT_SMALL,
        OCF_LIGHT_MEDIUM,
        OCF_LIGHT_LARGE,
        OCF_LIGHT_XLARGE,
        OCF_UNREVIVIFIABLE,
        OCF_UNRESSURECTABLE,
        OCF_DEMON,
        OCF_FATIGUE_IMMUNE,
        OCF_NO_FLEE,
        OCF_NON_LETHAL_COMBAT,
        OCF_MECHANICAL,
        OCF_ANIMAL_ENSHROUD,
        OCF_FATIGUE_LIMITING
    };
    public enum ObjectFlags_Critter2
    {
        OCF2_ITEM_STOLEN = 0,
        OCF2_AUTO_ANIMATES,
        OCF2_USING_BOOMERANG,
        OCF2_FATIGUE_DRAINING,
        OCF2_SLOW_PARTY,
        OCF2_COMBAT_TOGGLE_FX,
        OCF2_NO_DECAY,
        OCF2_NO_PICKPOCKET,
        OCF2_NO_BLOOD_SPLOTCHES,
        OCF2_NIGH_INVULNERABLE,
        OCF2_ELEMENTAL,
        OCF2_DARK_SIGHT,
        OCF2_NO_SLIP,
        OCF2_NO_DISINTEGRATE,
        OCF2_REACTION_0,
        OCF2_REACTION_1,
        OCF2_REACTION_2,
        OCF2_REACTION_3,
        OCF2_REACTION_4,
        OCF2_REACTION_5,
        OCF2_REACTION_6,
        OCF2_TARGET_LOCK,
        OCF2_PERMA_POLYMORPH,
        OCF2_SAFE_OFF,
        OCF2_CHECK_REACTION_BAD,
        OCF2_CHECK_ALIGN_GOOD,
        OCF2_CHECK_ALIGN_BAD
    };
    public enum ObjectFlags_PC
    {
        OPCF_unused_1 = 0,
        OPCF_unused_2,
        OPCF_USE_ALT_DATA,
        OPCF_unused_4,
        OPCF_unused_5,
        OPCF_FOLLOWER_SKILLS_ON
    };
    public enum ObjectFlags_NPC
    {
        ONF_FIGHTING = 0,
        ONF_WAYPOINTS_DAY,
        ONF_WAYPOINTS_NIGHT,
        ONF_AI_WAIT_HERE,
        ONF_AI_SPREAD_OUT,
        ONF_JILTED,
        ONF_CHECK_WIELD,
        ONF_CHECK_WEAPON,
        ONF_KOS,
        ONF_WAYPOINTS_BED,
        ONF_FORCED_FOLLOWER,
        ONF_KOS_OVERRIDE,
        ONF_WANDERS,
        ONF_WANDERS_IN_DARK,
        ONF_FENCE,
        ONF_FAMILIAR,
        ONF_CHECK_LEADER,
        ONF_ALOOF,
        ONF_CAST_HIGHEST,
        ONF_GENERATOR,
        ONF_GENERATED,
        ONF_GENERATOR_RATE1,
        ONF_GENERATOR_RATE2,
        ONF_GENERATOR_RATE3,
        ONF_DEMAINTAIN_SPELLS,
        ONF_LOOK_FOR_WEAPON,
        ONF_LOOK_FOR_ARMOR,
        ONF_LOOK_FOR_AMMO,
        ONF_BACKING_OFF,
        ONF_NO_ATTACK
    };

    public enum ObjectFlags_Trap
    {
        OTF_BUSTED
    };
}
