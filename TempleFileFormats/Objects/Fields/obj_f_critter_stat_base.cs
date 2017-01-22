using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempleFileFormats.Objects.Fields
{
	public enum obj_f_critter_stat_base_enum : int
	{
		stat_strength = 0,  
		stat_dexterity = 1,
		stat_constitution = 2,
		stat_beauty = 3,
		stat_intelligence = 4,
		stat_perception = 5,
		stat_willpower = 6,
		stat_charisma = 7,
		carry = 8,
		damage = 9,
		ac = 10,
		speed = 11,
		healrate = 12,
		poisonrate = 13,
		beautyreaction = 14,
		maxfollowers = 15,
		aptitude = 16,
		level = 17,
		xps_UNUSED = 18,
		alignment = 19,
		fate_UNUSED = 20,
		unspent_UNUSED = 21,
		magicpts = 22,
		techpts = 23,
		poison_level = 24,
		AGE = 25,
		Gender = 26, //(00 – Male, 01 – Female или наоборот ? )
		Race = 27
	}

}

/*
01 | IS_NULL
04 00 00 00 | ELEMENT_SIZE
1C 00 00 00 | ELEMENT_COUNT (28)
6D 25 00 00 | HEADER_UNK
08 00 00 00 | 00 => stat_strength
14 00 00 00 | 01 => stat_dexterity
08 00 00 00 | 02 => stat_constitution
08 00 00 00 | 03 => stat_beauty
08 00 00 00 | 04 => stat_intelligence
08 00 00 00 | 05 => stat_perception
08 00 00 00 | 06 => stat_willpower
08 00 00 00 | 07 => stat_charisma
00 00 00 00 | 08 => carry
00 00 00 00 | 09 => damage
00 00 00 00 | 10 => ac
00 00 00 00 | 11 => speed
00 00 00 00 | 12 => healrate
00 00 00 00 | 13 => poisonrate
00 00 00 00 | 14 => beautyreaction
00 00 00 00 | 15 => maxfollowers
00 00 00 00 | 16 => aptitude
01 00 00 00 | 17 => level
00 00 00 00 | 18 => xpsUNUSED
D3 FE FF FF | 19 => alignment
00 00 00 00 | 20 => fateUNUSED
05 00 00 00 | 21 => unspentUNUSED
00 00 00 00 | 22 => magicpts
00 00 00 00 | 23 => techpts
00 00 00 00 | 24 => POISON_LEVEL
14 00 00 00 | 25 => AGE
01 00 00 00 | 26 => Gender (00 – Male, 01 – Female или наоборот ? )
08 00 00 00 | 27 => Race
02 00 00 00 | COUNT
FF FF FF 0F | FLAG_0
00 00 00 00 | FLAG_1

*/