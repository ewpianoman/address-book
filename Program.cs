using System;
using System.Threading;
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
                new Command("commands", "List all commands"),
                new Command("list", "List all contact entries")
            };
            
            // Test Entries
            Entry[] entries = 
            {
                new Entry("Emily", "Wilson", "(812) 610-5803"),
                new Entry("Lisa", "Reynolds", "(812) 385-2591 (13139)"),
                new Entry("Lori", "Abel", "(618) 262-1710"),
                new Entry("Eric", "Wilson", "(812) 486-8718")
            };
            
            Console.WriteLine("\nWelcome to your Personal Address Book!");
            Thread.Sleep(500);
            Console.WriteLine("......................................");
            Thread.Sleep(1000);
            Console.WriteLine("You can search for a contact in your address book by typing a search term and pressing \"enter\"");
            Console.WriteLine("To exit this application, type \"exit\"");
            Console.WriteLine("To list all available commands, type \"commands\"\n");

            REPL repl = new REPL(commands);

            bool isRunning = true;

            while (isRunning)
            {
                string input = repl.Eval();

                if (input == "exit")
                {
                    Console.WriteLine("\nGoodbye...");
                    Thread.Sleep(500);
                    Console.WriteLine("\n");
                    isRunning = false;
                } 
                else if (input == "commands")
                {
                    Console.WriteLine("\n");
                    repl.PrintCommands();
                    Console.WriteLine("\n");
                }
                else if (input == "list")
                {
                    Console.WriteLine("\nHere is a list of all the entries in your Address Book:\n");
                }
                else
                {
                    Console.WriteLine($"\nI\'m sorry! The \"{input}\" command was not found.\n");
                    Thread.Sleep(500);
                    Console.WriteLine("Here is a list of all available commands:");
                    repl.PrintCommands();
                    Console.WriteLine("\n");
                }    
            }
        }
    }
}
