using System;
using System.Text.Json;
using System.Text.Json.Serialization;

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