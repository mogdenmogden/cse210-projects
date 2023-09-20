using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int stopper = 1;
        int theEntry;
        int sumList;
        double avgList;
        int maxList;
        int nearest;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
            {
                Console.Write("Enter a number: ");
                theEntry = int.Parse(Console.ReadLine());
                if (theEntry == 0)
                    {
                        stopper = 0;
                    }
                else
                    numbers.Add(theEntry);

            } while (stopper != 0);
        
        sumList = numbers.Sum();
        Console.WriteLine($"The sum is: {sumList}");
        avgList = numbers.Average();
        Console.WriteLine($"The average is: {avgList}");
        maxList = numbers.Max();
        Console.WriteLine($"The largest is: {maxList}");

        nearest = numbers.Where(x=>x>0).Min();

        Console.WriteLine($"The smallest positive number is: {nearest}");
        Console.WriteLine("The sorted list is: ");
        numbers.Sort();
        foreach (int nbr in numbers)
        {
            Console.WriteLine(nbr);
        }
    }
}