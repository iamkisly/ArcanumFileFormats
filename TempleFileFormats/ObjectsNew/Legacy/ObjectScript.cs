using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ArcanumFileFormats.ObjectsNew.Legacy
{
    public class ObjectScript
    {
        public byte[] Counters;
        public int Flags;
        public int ScriptId;
        
        public ObjectScript()
        {
            this.Counters = new byte[] { 0x00, 0x00, 0x00, 0x00 };
            this.Flags = 0x00;
            this.ScriptId = 0x00;
            
        }

        public ObjectScript(byte C0, byte C1, byte C2, byte C3, int F0, int Id)
        {
            this.Counters = new byte[] { C0, C1, C2, C3 };
            this.Flags = F0;
            this.ScriptId = Id;
        }
    }
}
/*
01
0C 00 00 00 | 
03 00 00 00 | 
6B 25 00 00 | 

--Script #1--
10 20 40 80 | COUNTERS
05 06 07 08 | FLAGS
0B 00 00 00 | SCRIPT# 11

--Script #2--
01 04 10 40 | COUNTERS
09 0A 0B 0C | FLAGS
0D 00 00 00 | SCRIPT# 13

--Script #3--
03 03 03 03 | COUNTERS
04 04 04 04 | FLAGS
14 00 00 00 | SCRIPT# 20


02 00 00 00 | SIZE

13 00 00 00 | SCRIPT IDENTITY FLAG
00 00 00 00 | NULL
*/