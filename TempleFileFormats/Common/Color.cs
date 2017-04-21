using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcanumFileFormats.Common
{
    public class Color
    {
        public byte R;
        public byte G;
        public byte B;
        public byte A;

        public Color()
        {
            R = 255;
            G = 255;
            B = 255;
            A = 0;
        }
     
        public Color(Int32 data)
        {
            var temp = BitConverter.GetBytes(data);
            B = temp[0];
            G = temp[1];
            R = temp[2];
            A = temp[3];
        }

        public override string ToString()
        {
            return "R: " + R + "," + "G: " + G + "," + "B: " + B + "," + "A: " + A;
        }
    }
}
