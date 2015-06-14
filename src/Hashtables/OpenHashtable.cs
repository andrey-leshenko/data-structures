using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Hashtables
{
    class OpenHashtable<TKey, TValue>
    {
        public bool debugLog = false;

        Entry[] table;

        public OpenHashtable(int size)
        {
            table = new Entry[size];
        }

        public TValue this[TKey key]
        {
            get { return Get(key); }
            set { Set(key, value); }
        }

        public TValue Get(TKey key)
        {
            Entry entry = FindEntry(key);
            return entry == null ? default(TValue) : entry.value;
        }

        public void Set(TKey key, TValue value)
        {
            int index = GetTableIndex(key);
            Entry entry = FindEntryAtIndex(key, index);

            if (entry == null) {
                Entry newEntry = new Entry {
                    key = key,
                    value = value,
                    next = table[index]
                };
                if (table[index] != null) {
                    Console.WriteLine("OpenHashtable: Collision at index {0}.", index);
                }
                table[index] = newEntry;
            }
            else {
                entry.value = value;
            }
        }

        public void Remove(TKey key)
        {
            Entry entry = FindEntry(key);

            if (entry != null) {
                if (entry.next != null) {
                    entry.key = entry.next.key;
                    entry.value = entry.next.value;
                    entry.next = entry.next.next;
                }
            }
        }

        Entry FindEntryAtIndex(TKey key, int tableIndex)
        {
            Entry entry = table[tableIndex];

            while (entry != null) {
                if (entry.key.Equals(key)) {
                    return entry;
                }
                entry = entry.next;
            }

            return null;
        }

        Entry FindEntry(TKey key)
        {
            return FindEntryAtIndex(key, GetTableIndex(key));
        }

        int GetTableIndex(TKey key)
        {
            // HashCode can be negative, indexes can't.
            return ((key.GetHashCode() % table.Length) + table.Length) % table.Length;
        }

        class Entry
        {
            public TKey key;
            public TValue value;
            public Entry next;
        }
    }
}
