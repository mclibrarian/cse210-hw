using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        int response;

        do
        {
            Console.Write("What is your guess? ");
            string userGuess = Console.ReadLine();
            response = int.Parse(userGuess);
            if (response > number)
            {
                Console.WriteLine("Lower");
            }
            else if (response < number)
            {
                Console.WriteLine("Higher");
            }
            else if (response == number)
            {
                Console.WriteLine("You guessed it!");
            }
        } while (response != number);
    }
}