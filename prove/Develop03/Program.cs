// I exceeded the requirements by making it so the program only selects words to hide
// from those that are not already hidden.

using System;

class Program
{
    static void Main(string[] args)
    {
        var scripture = new Scripture();

        string response = "";
        while (response != "quit")
        {
            Console.WriteLine(scripture.GetRenderedText());
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            response = Console.ReadLine();
            if (response == "")
            {
                if (scripture.IsCompletelyHidden())
                {
                    return;
                }
                scripture.HideWords();
                Console.Clear();
            }
        }
    }
}