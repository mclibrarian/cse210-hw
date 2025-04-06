using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> _events = new List<Event>();

        var event1 = new Lecture("Why Cows are the Best", "A lecture about cows", "11/23/2018", "12:00", "Farmer Bob", 25, new Address("Frog Hall", "Goodtowne", "Massachusetts", "USA"));
        _events.Add(event1);
        var event2 = new OutdoorGathering("George and Rachel's Anniversary Picnic", "A picnic to remember an anniversary", "07/04/2006", "2:30", "Wet and gloomy", new Address("1300 Farmer's Field Way", "Drysville", "Kansas", "USA"));
        _events.Add(event2);
        var event3 = new Reception("Hannah and Frederik's Wedding Reception", "A reception to celebrate a wedding", "03/17/2024", "6:45", "weddingRSVP@example.org", new Address("The Arts Center", "Chicago", "Illinois", "USA"));
        _events.Add(event3);

        foreach (Event e in _events)
        {
            Console.WriteLine(e.StandardDetails());
            Console.WriteLine(e.FullDetails());
            Console.WriteLine(e.ShortDescription());
        }
    }
}