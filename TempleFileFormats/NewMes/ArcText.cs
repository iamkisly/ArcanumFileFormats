using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempleFileFormats.Mes
{
    public class ArcText
    {
        protected Dictionary<int, Entry> Entries;
        private StreamReader reader;

        public ArcText(StreamReader reader)
        {
            this.reader = reader;
        }

        public ArcText Parse()
        {
            ArcText m = new ArcText(this.reader);
            m.Init();

            while (true)
            {
                string temp = reader.ReadLine();

                if (temp != null && temp != "")
                {
                    temp = temp.TrimStart(new char[] { ' ', '\t' });
                    if (temp.StartsWith("//")) continue;

                    Entry me = new Entry(temp);

                    if (!m.ExistEntryWithIndex(me.getIndex()))
                        m.AddEntry(me.getIndex(), me);
                }
                if (temp == null)
                {
                    break;
                }
            }

            return m;
        }

        public void Dispose()
        {
            Clear();
        }

        public void Clear()
        {
            if (Entries.Count > 0)
            {
                Entries.Clear();
            }
        }

        public void Init()
        {
            Entries = new Dictionary<int, Entry>();
        }


        // verify

        public bool isLoaded()
        {
            return loaded;
        }

        public int getEntryCount()
        {
            return Entries.Count;
        }

        public Entry getEntryWithIndex(int index)
        {
            return Entries[index];
        }

        public bool ExistEntryWithIndex(int index)
        {
            return Entries.ContainsKey(index);
        }

        public Entry newEntry(string[] args)
        {
            return new Entry( args );
        }

        public bool AddEntry(int index, Entry entry)
        {
            try
            {
                if (!Entries.ContainsKey(index))
                {
                    Entries.Add(index, entry);
                    return true;
                }
                else
                {
                    Console.WriteLine("Already in dictionary");
                    return false;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool DelEntry(int index)
        {
            try
            {
                if (Entries.ContainsKey(index))
                {
                    Entries.Remove(index);
                }
                else
                {
                    Console.WriteLine("Not contain in dictionary");
                    return false;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }

        protected int index = 0;
        protected bool loaded = false;
        protected int itemCount = 0;
        private string temp;
    }

}
