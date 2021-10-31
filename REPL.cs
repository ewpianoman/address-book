using System;

namespace AddressBook
{
    class REPL
    {
        private readonly Command[] _commands;

        public string Read() 
        {
           return Console.ReadLine();
        }

        public string Eval()
        {
            string input = Read();
            string output = input;
            foreach (Command command in _commands)
            {
                if (input == command.KeyWord)
                {
                    output = command.KeyWord;
                }
            }

            return output;
        }

        public void PrintCommands()
        {
            foreach (Command command in _commands)
            {
                Console.WriteLine($"{command.KeyWord} - {command.Description}");
            }
        }

        public REPL(Command[] commands)
        {
            _commands = commands;
        }
    }
}