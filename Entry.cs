using System;
namespace AddressBook
{
    class Entry
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Entry(string firstName, string lastName, string phone, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
        }
        
        // Since it is acting on the Entries class as a whole, it needs to be in a separate class. Create new AddressBook class
        public void ListNames(Entry[] entries)
        {
            foreach(Entry entry in entries)
            {
                Console.Write(entry.FirstName);
                Console.WriteLine(entry.LastName);
                Console.WriteLine(entry.Phone);
                Console.WriteLine(entry.Email);
                Console.WriteLine("\n");
            }
        }
    }
}