//creativity -- I stored the entries as json instead of a txt file

using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Journal journal = new Journal();
        string response = "";
        while (response != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            response = Console.ReadLine();
            switch (response)
            {
                case "1":
                {
                    journal.Write();
                    break;
                }
                case "2":
                {
                    journal.Display();
                    break;
                }
                case "3":
                {
                    journal.Load();
                    break;
                }
                case "4":
                {
                    journal.Save();
                    break;
                }
            }
        }
        Console.WriteLine("Great job writing in your journal today! Goodbye.");
    }
}