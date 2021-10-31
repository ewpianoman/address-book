using System;
namespace AddressBook
{
    class Command
    {
        public string KeyWord { get; private set; }
        public string Description { get; private set; }
        public Command(string keyWord, string description)
        {
            KeyWord = keyWord;
            Description = description;
        }
    }
}