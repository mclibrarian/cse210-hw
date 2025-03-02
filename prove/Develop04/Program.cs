// I exceeded the requirements by making sure none of the questions for the reflecting activity were repeated.


using System;

class Program
{
    static void Main(string[] args)
    {
        string response = "0";
        while (response != "4")
        {
            Console.WriteLine("Menu options: ");
            Console.WriteLine("1. Start breathing activity \n2. Start reflecting activity \n3. Start listing activity \n4. Quit");
            Console.Write("What would you like to do? ");
            response = Console.ReadLine();

            if (response == "4")
            {
                return;
            }

            Activity activity;
            if (response == "1")
            {
                activity = new BreathingActivity();
            }
            else if (response == "2")
            {
                activity = new ReflectionActivity();
            }
            else
            {
                activity = new ListingActivity();
            }
            activity.DisplayStartMessage();
            activity.RunActivity();
            activity.DisplayEndMessage();
        }
    }
}