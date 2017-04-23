using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ArcanumFileFormats.Common
{
    public class PrefixedString
    {
        public string value;

        public PrefixedString()
        {
            this.value = String.Empty;
        }

        public PrefixedString(string value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return value;
        }
    }
}