using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning04 World!");
        Console.Clear();

        Assignment assignment1 = new Assignment("Fred Flintstone","Geology 100");

        string theSummary1 = assignment1.GetSummary();
        
        MathAssignment assignment2 = new MathAssignment("Barney Rubble","Arithmetic 101","Section 1.0","#1 - 5");
        string theSummary2 = assignment2.GetSummary();
        string hwkList2 = assignment2.GetHomeWorkList();

        WritingAssignment assignment3 = new WritingAssignment("Wilma Flintstone","Home Economics 150","\"How To Feed A Crowd In A Hurry\"");
        string theSummary3 = assignment3.GetSummary();
        string essay = assignment3.GetWritingAssignment();
        
        Console.WriteLine($"{theSummary1}\n");
        Console.WriteLine($"{theSummary2}");
        Console.WriteLine($"{hwkList2}\n");
        Console.WriteLine($"{theSummary3}");
        Console.WriteLine($"{essay}\n");
        


    }
}