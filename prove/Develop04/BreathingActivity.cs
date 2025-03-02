public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _activityName = "Breathing";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public override void RunActivity()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            DisplayBreathingMessages();
        }
    }
    public void DisplayBreathingMessages()
    {
        Console.Write("Breathe in ... ");
        Countdown(4);
        Console.WriteLine("");
        Console.Write("Now breathe out ... ");
        Countdown(6);
        Console.WriteLine("");
        Console.WriteLine("");
    }

}