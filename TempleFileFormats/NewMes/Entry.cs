using System;
using System.Collections.Generic;
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

        public int getIndex()
        {
            return index;
        }

        public void setIndex(int index)
        {
            this.index = index;
        }

        public int getItemCount()
        {
            return itemcount; 
        }

        public bool IsValid()
        {
            //TODO: Not exist valid = true;
            return valid;
        }

        protected bool valid = false;
        protected int index = 0;
        protected int itemcount = 0;

    }
}
