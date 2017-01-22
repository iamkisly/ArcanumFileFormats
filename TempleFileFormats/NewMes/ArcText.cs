using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempleFileFormats.Mes
{
    public class ArcText<T>
    {
        /** The initial comment - before the first line that begins with '{'*/
        protected string headerComment = String.Empty;

        protected Dictionary<int, T> Entries;

        public void Dispose()
        {
            Clear();
        }

        public void Init()
        {
            Entries = new Dictionary<int, T>();
        }

        public bool isLoaded()
        {
            return loaded;
        }

        public void Clear()
        {
            headerComment = String.Empty;
            if (Entries.Count > 0)
            {
                Entries.Clear();
            }
        }

        public int getEntryCount()
        {
            return Entries.Count;
        }

        public bool isEntryContain(int key)
        {
            return Entries.ContainsKey(key);
        }

        protected int itemCount = 0;

        public virtual int getItemCount()
        {
            return itemCount;
        }

        public T getEntryWithIndex(int index)
        {
            return Entries[index];
        }

        public bool ExistEntryWithIndex(int index)
        {
            return Entries.ContainsKey(index);
        }

        public T newEntry(string[] args)
        {
            return (T)Activator.CreateInstance(typeof(T), new object[] { args });
        }

        public bool AddEntry(int index, T entry)
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
    }
}
