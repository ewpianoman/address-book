using System;
using AddressBook;

namespace address_book
{
    class Program
    {
        static void Main(string[] args)
        {
            Command[] commands =
            {
                new Command("exit", "End Program"),
                new Command("commands", "List all commands")
            };

            Console.WriteLine("Welcome to your Personal Address Book");
            Console.WriteLine("You can search for a contact in your address book by typing a search term and pressing \"enter\"");
            Console.WriteLine("To exit this application, type \"exit\"");
            Console.WriteLine("To list all available commands, type \"commands\"");

            REPL repl = new REPL(commands);

            bool isRunning = true;

            while (isRunning)
            {
                string input = repl.Eval();

                if (input == "exit")
                {
                    Console.WriteLine("Goodbye!");
                    isRunning = false;
                } 
                else if (input == "commands")
                {
                    repl.PrintCommands();
                }
                else
                {
                    Console.WriteLine($"\"{input}\" command not found!");
                    Console.WriteLine("Here is a list of all available commands:");
                    repl.PrintCommands();
                }    
            }
        }
    }
}
