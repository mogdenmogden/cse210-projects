using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation4 World!");
        List<Activity> activities = new List<Activity>();
        Console.Clear();
        Running run1 = new Running("05 Nov 2023",35.00,5.05);
        activities.Add(run1);
        Cycling bike1 = new Cycling("12 Dec 2023",65,17);
        activities.Add(bike1);
        Swimming swim1 = new Swimming("15 Jan 2023",50,20.5);
        activities.Add(swim1);
        foreach (Activity thisOne in activities)
        {
            thisOne.GetSummary();
        }
        Console.WriteLine("\n");
    }
}