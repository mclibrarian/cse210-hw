// I exceeded the requirements by adding another type of goal that is time-based and is marked complete after a specified amount of minutes are logged.

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        string response = "0";
        while (response != "6")
        {
            goalManager.DisplayScore();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Create New Goal \n2. List Goals \n3. Save Goals \n4. Load Goals \n5. Record Event \n6. Quit");
            Console.Write("What would you like to do? ");
            response = Console.ReadLine();

            if (response == "6")
            {
                return;
            }

            if (response == "1")
            {
                Console.WriteLine("The types of Goals are: ");
                Console.WriteLine("1. Simple Goal \n2. Eternal Goal \n3. Checklist Goal \n4. Time Goal");
                Console.Write("Which type of Goal would you like to create? ");
                string createGoal = Console.ReadLine();
                if (createGoal == "1")
                {
                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int points = int.Parse(Console.ReadLine());
                    Goal newGoal = new SimpleGoal(name, description, points);
                    goalManager.AddGoal(newGoal);
                }
                else if (createGoal == "2")
                {
                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int points = int.Parse(Console.ReadLine());
                    Goal newGoal = new EternalGoal(name, description, points);
                    goalManager.AddGoal(newGoal);
                }
                else if (createGoal == "3")
                {
                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int points = int.Parse(Console.ReadLine());
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int completionThreshold = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int completionPointBonus = int.Parse(Console.ReadLine());
                    Goal newGoal = new ChecklistGoal(name, description, points, completionPointBonus, completionThreshold);
                    goalManager.AddGoal(newGoal);
                }
                else if (createGoal == "4")
                {
                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int points = int.Parse(Console.ReadLine());
                    Console.Write("How much time (in minutes) is needed for this goal to be completed? ");
                    int completionThreshold = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing this goal? ");
                    int completionPointBonus = int.Parse(Console.ReadLine());
                    Goal newGoal = new TimeGoal(name, description, points, completionPointBonus, completionThreshold);
                    goalManager.AddGoal(newGoal);
                }
                else
                {
                    Console.WriteLine("Sorry, that isn't an option.");
                }
            }
            else if (response == "2")
            {
                goalManager.ListGoals();
            }
            else if (response == "3")
            {
                Console.Write("What is the filename for the goal file? ");
                string filename = Console.ReadLine();
                goalManager.SaveGoals(filename);
            }
            else if (response == "4")
            {
                Console.Write("What is the filename for the goal file? ");
                string filename = Console.ReadLine();
                goalManager.LoadGoals(filename);
            }
            else if (response == "5")
            {
                goalManager.DisplayGoals();
                Console.Write("What goal did you accomplish? ");
                int accomplishedGoal = int.Parse(Console.ReadLine());
                goalManager.RecordGoal(accomplishedGoal - 1);
            }
            else
            {
                Console.WriteLine("Sorry, that isn't an option.");
            }
        }
    }
}