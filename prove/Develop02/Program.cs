// I exceeded the requirements by using JSON for storage.

using System;

class Program
{
    static void Main(string[] args)
    {
        var journal = new Journal();

        string response = "0";
        while (response != "5")
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following options to continue: ");
            Console.WriteLine("1. Write \n2. Display \n3. Load \n4. Save \n5. Quit");
            Console.Write("What would you like to do? ");
            response = Console.ReadLine();
            if (response == "1")
            {
                journal.WriteNewEntry();
            }
            else if (response == "2")
            {
                journal.ShowEntries();
            }
            else if (response == "3")
            {
                Console.WriteLine("Please enter the filename you want to load from: ");
                string filename = Console.ReadLine();
                journal.LoadEntries(filename);

            }
            else if (response == "4")
            {
                Console.WriteLine("Please enter the filename you want to save to: ");
                string filename = Console.ReadLine();
                journal.SaveEntries(filename);
            }
            else if (response == "5")
            {
                return;
            }
        }
    }
}
