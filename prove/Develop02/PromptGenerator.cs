public class PromptGenerator
{
    Random _rnd;

    public PromptGenerator()
    {
        _rnd = new Random();
    }

    List<string> _prompts = new List<string> {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "What was the best part of my day?",
            "What was one thing I wish I had done differently today?",
            "What was the most interesting thing I learned today?"
            };

    public string RandomPrompt()
    {
        int r = _rnd.Next(_prompts.Count);
        return _prompts[r];
    }
}