public class ListingActivity : Activity
{
    private List<string> _prompts;
    private Random _rnd;

    public ListingActivity()
    {
        _activityName = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        _prompts = new List<string>();
        _prompts.Add("Who are people that you appreciate? ");
        _prompts.Add("What are personal strengths of yours? ");
        _prompts.Add("Who are people that you have helped this week? ");
        _prompts.Add("When have you felt the Holy Ghost this month? ");
        _prompts.Add("Who are some of your personal heroes? ");

        _rnd = new Random();
    }

    public override void RunActivity()
    {
        DisplayPrompt();
        Console.Write("You may begin in: ");
        Countdown(5);
        Console.WriteLine("");
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        int responseCount = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            responseCount++;
        }
        Console.WriteLine($"You listed {responseCount} items!");
        Console.WriteLine("");
    }

    public void DisplayPrompt()
    {
        int r = _rnd.Next(_prompts.Count);
        Console.WriteLine("List as many responses as you can to the following prompt: ");
        Console.WriteLine(_prompts[r]);
    }
}