using System;
namespace AddressBook
{
    class Entry
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        // Separate Class with fields for each part of the address eventually...
        public string Email { get; set; }
        public Entry(string firstName, string middleName, string lastName, string phone, string address, string email)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Phone = phone;
            Address = address;
            Email = email;
        }

        public Entry(string firstName, string lastName, string phone, string address, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Address = address;
            Email = email;
        }
    }
}