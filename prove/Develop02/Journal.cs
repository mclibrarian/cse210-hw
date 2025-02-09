using System;
using System.Text.Json;
using System.Text.Json.Serialization;

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