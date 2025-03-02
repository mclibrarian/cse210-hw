public abstract class Activity
{
    protected string _activityName;
    protected string _description;
    protected int _duration;
    protected DateTime _startTime;

    public abstract void RunActivity();

    public void DisplayStartMessage()
    {
        Console.WriteLine("");
        Console.WriteLine($"Welcome to the {_activityName} Activity.");
        Console.WriteLine(_description);
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Write("Get ready ... ");
        ShowAnimation(3);
        Console.WriteLine("");
        Console.WriteLine("");
    }
    public void DisplayEndMessage()
    {
        Console.WriteLine("Well done!");
        ShowAnimation(4);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName} Activity.");
        ShowAnimation(4);
        Console.WriteLine("");
        Console.WriteLine("");
    }
    public static void ShowAnimation(int length)
    {
        int frameDelay = 100;
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(length);
        while (DateTime.Now < futureTime)
        {
            Console.Write("|");

            Thread.Sleep(frameDelay);

            Console.Write("\b \b"); // Erase the | character
            Console.Write("/"); // Replace it with the / character

            Thread.Sleep(frameDelay);

            Console.Write("\b \b"); // Erase the / character
            Console.Write("-"); // Replace it with the - character

            Thread.Sleep(frameDelay);

            Console.Write("\b \b"); // Erase the - character
            Console.Write("\\"); // Replace it with the \ character

            Thread.Sleep(frameDelay);

            Console.Write("\b \b"); // Erase the character
        }
    }
    public static void Countdown(int duration)
    {
        for (int i = duration; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

}