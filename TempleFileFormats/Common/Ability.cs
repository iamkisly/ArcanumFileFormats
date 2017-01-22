using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempleFileFormats.Common
{
    public struct Ability
    {
        public int level;
        public int stage;

        public Ability(Int32 data)
        {
            level = data & 0xF;
            stage = (data & 0xF0) >> 4;
        }

        public override string ToString()
        {
            return "L: " + level + "," + "S: " + stage;
        }
    }
    //01 00 00 00 | 0 -> Untrained; 1 -> 4 
    //41 00 00 00 | 4 -> Beginned; 1 -> 4
    //42 00 00 00 | 4 -> Beginned; 2 -> 8

}