using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using TempleFileFormats.Mes;
using System.IO;

namespace DumpMes
{
    class Program
    {
        static void Main(string[] args)
        {
            string dlgfile = "01013Dante.dlg";
            ArcText obj2;
            using (var reader2 = new StreamReader(new FileStream(dlgfile, FileMode.Open)))
            {
                obj2 = new ArcText(reader2).Parse();
            }

            Console.WriteLine(obj2.getEntryCount());
            Console.WriteLine(obj2.getEntryWithIndex(11).ToString());


            Console.Read();
        }
    }
}
