using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        
        // Console.WriteLine("Hello Foundation4 World!");
        Console.Clear();
        Running run1 = new Running("11/5/2023",35.00,5.05);
        activities.Add(run1);
        // Console.WriteLine("====================");
        Cycling bike1 = new Cycling("12/13/23",65,17);
        activities.Add(bike1);
        // Console.WriteLine("====================");
        Swimming swim1 = new Swimming("1/15/23",50,20.5);
        activities.Add(swim1);
        Console.WriteLine("====================");
        foreach (Activity thisOne in activities)
        {
            thisOne.GetSummary(thisOne._date,thisOne._duration,thisOne._distance);
            Console.WriteLine("====================");
        }

        Console.WriteLine("\n");
    }
}