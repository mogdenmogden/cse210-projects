using System;

class Program
{
    static void Main(string[] args)
    {
       /* Console.WriteLine("Hello Learning02 World!");*/
        Job job1 = new Job();
        job1._company = "Bag End Private Gardens, LLC";
        job1._jobTitle = "Gardener";
        job1._startYear = 1811;
        job1._endYear = 1825;

        Job job2 = new Job();
        job2._company = "Thorin and Company";
        job2._jobTitle = "Thief";
        job2._startYear = 1825;
        job2._endYear = 1827;

        /*Console.WriteLine($"{job1._company}");
        Console.WriteLine($"{job2._company}");*/
        Console.WriteLine("");
        job1.DisplayJobLineDetails();
        job2.DisplayJobLineDetails();
        Console.WriteLine("");
    }
}