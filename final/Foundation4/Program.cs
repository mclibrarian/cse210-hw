using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        var activity1 = new Running("03 January 2023", 45, 3.7f);
        activities.Add(activity1);
        var activity2 = new Swimming("04 March 2022", 55, 46f);
        activities.Add(activity2);
        var activity3 = new Cycling("05 July 2024", 90, 11.8f);
        activities.Add(activity3);

        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }
    }
}