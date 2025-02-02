// I exceeded the requirements by using JSON for storage.

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

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
    public class Journal
    {
        PromptGenerator promptGen;
        List<Entry> _entries = new List<Entry>();

        public Journal()
        {
            promptGen = new PromptGenerator();
        }

        public void WriteNewEntry()
        {
            var newEntry = new Entry(promptGen.RandomPrompt());
            Console.WriteLine($"Here is your prompt: {newEntry.GetPrompt()}");
            Console.WriteLine("Please write your new entry here: ");
            newEntry.SetEntryText(Console.ReadLine());
            _entries.Add(newEntry);
        }

        public void LoadEntries(string filename)
        {
            string jsonString = File.ReadAllText(filename);
            _entries = JsonSerializer.Deserialize<List<Entry>>(jsonString);
        }

        public void SaveEntries(string filename)
        {
            string jsonString = JsonSerializer.Serialize(_entries);
            File.WriteAllText(filename, jsonString);
        }

        public void ShowEntries()
        {
            foreach (Entry entry in _entries)
            {
                Console.WriteLine(entry.FormattedString());
            }
        }
    }
    public class Entry
    {
        public DateTime _date { get; set; }
        public string _text { get; set; }
        public string _prompt { get; set; }

        public Entry(string prompt)
        {
            _date = DateTime.Now;
            _prompt = prompt;
        }

        [JsonConstructor]
        public Entry(DateTime _DATE, string _TEXT, string _PROMPT)
        {
            _date = _DATE;
            _text = _TEXT;
            _prompt = _PROMPT;
        }

        public string GetPrompt()
        {
            return _prompt;
        }

        public void SetEntryText(string text)
        {
            _text = text;
        }

        public string FormattedString()
        {
            return $"Date: {_date} | Prompt: {_prompt}\n{_text}";
        }
    }

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
}
