public class ReflectionActivity : Activity
{
    private List<string> _initialPrompt;
    private List<string> _questions;
    private Random _rnd;

    public ReflectionActivity()
    {
        _activityName = "Reflection";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

        _initialPrompt = new List<string>();
        _initialPrompt.Add("Think of a time when you stood up for someone else. ");
        _initialPrompt.Add("Think of a time when you did something really difficult. ");
        _initialPrompt.Add("Think of a time when you helped someone in need. ");
        _initialPrompt.Add("Think of a time when you did something truly selfless. ");

        _questions = new List<string>();
        _questions.Add("Why was this experience meaningful to you? ");
        _questions.Add("Have you ever done anything like this before? ");
        _questions.Add("How did you get started? ");
        _questions.Add("How did you feel when it was complete? ");
        _questions.Add("What made this time different than other times when you were not as successful? ");
        _questions.Add("What is your favorite thing about this experience? ");
        _questions.Add("What could you learn from this experience that applies to other situations? ");
        _questions.Add("What did you learn about yourself through this experience? ");
        _questions.Add("How can you keep this experience in mind in the future? ");

        _rnd = new Random();
    }

    public override void RunActivity()
    {
        DisplayInitialPrompt();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience. ");
        Console.Write("You may begin in: ");
        Countdown(5);
        Console.WriteLine("");
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            DisplayQuestions();
        }
        Console.WriteLine();
    }

    public void DisplayInitialPrompt()
    {
        int r = _rnd.Next(_initialPrompt.Count);
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine(_initialPrompt[r]);
        Console.WriteLine("When you have something in mind, press enter to continue. ");
        Console.ReadLine();
    }

    public void DisplayQuestions()
    {
        if (_questions.Count == 0)
        {
            Console.WriteLine("You have answered all the questions, sorry! ");
            Console.Write("Please ponder the meaning of life for the remaining time. ");
        }
        else
        {
            int r = _rnd.Next(_questions.Count);
            Console.Write("> ");
            Console.Write(_questions[r]);
            _questions.RemoveAt(r);
        }
        ShowAnimation(7);
        Console.WriteLine();
    }
}