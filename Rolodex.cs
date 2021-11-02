using System;
using System.Collections.Generic;

namespace AddressBook
{
    class Rolodex
    {
        private List<Entry> _entries;
        public Rolodex(List<Entry> entries)
        {
            _entries = entries;
        }

        public void PrintEntries()
        {
            foreach(Entry entry in _entries)
            {
                Console.WriteLine($"{entry.FirstName} {entry.LastName}");
                Console.WriteLine(entry.Phone);
                Console.WriteLine(entry.Email);
                Console.WriteLine("\n");
            }
        }
    }
}