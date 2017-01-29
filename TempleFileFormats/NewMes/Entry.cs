using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempleFileFormats.Mes
{
    public class Entry
    {
        public Entry()
        {

        }

        public Entry(string[] data)
        {
            this.data = data;
        }

        public Entry(string line)
        {
            data = new EntryReader(line).Parse();
            Init();
        }

        public Entry(StreamReader reader)
        {
            data = new EntryReader(reader).Parse();
            Init();
        }

        void Init()
        {
            bool test = int.TryParse(data[0], out index);
            itemCount = data.Length;
            if (test && (itemCount == 2 || itemCount == 7))
            {
                valid = true;
            }
        }
        
        public int getIndex()
        {
            return index;
        }

        public int getItemCount()
        {
            return itemCount; 
        }

        public bool IsValid()
        {
            //TODO: Not exist valid = true;
            return valid;
        }

        protected bool valid = false;
        protected int index = 0;
        protected int itemCount = 0;
        protected string[] data;
    }
}
