using System;

namespace AddressBook
{
    class Rolodex
    {
        private Entry[] _entries;
        public Rolodex(Entry[] entries)
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