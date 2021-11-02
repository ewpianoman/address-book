using System;
namespace AddressBook
{
    class Entry
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        // Separate Class with fields for each part of the address eventually...
        public string Email { get; set; }
        public Entry(string firstName, string lastName, string phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
        }
    }
}