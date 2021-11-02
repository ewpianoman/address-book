using System;
using System.Threading;
using System.Collections.Generic;
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
            List<Entry> entries = new List<Entry>()
            {
                new Entry("Emily", "Wilson", "(812) 610-5803", "emilykwilson17@gmail.com"),
                new Entry("Lisa", "Reynolds", "(812) 385-2591 (13139)", "lreynolds@ngsc.k12.in.us"),
                new Entry("Lori", "Abel", "(618) 262-1710", "xraytech72@icloud.com"),
                new Entry("Eric", "Wilson", "(812) 486-8718", "ewpiano@gmail.com")
            };

            REPL repl = new REPL(commands);
            Rolodex rolodex = new Rolodex(entries);
            
            // Might add this to a class. AddressBook or REPL?
            Console.WriteLine("\nWelcome to your Personal Address Book!");
            Thread.Sleep(500);
            Console.WriteLine("......................................");
            Thread.Sleep(1000);
            Console.WriteLine("You can search for a contact in your address book by typing a search term and pressing \"enter\"");
            Console.WriteLine("To exit this application, type \"exit\"");
            Console.WriteLine("To list all available commands, type \"commands\"\n");

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
                    rolodex.PrintEntries();
                    
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
