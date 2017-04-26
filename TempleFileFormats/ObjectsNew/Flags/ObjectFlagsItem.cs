using System;

namespace ArcanumFileFormats.ObjectsNew.Flags
{
	public enum ObjectFlagsItem
	{
		//Obj_Item_Flag
		OIF_IDENTIFIED = 1, //[0] 0x01
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
		OIF_MP_INSERTED
	}
}

