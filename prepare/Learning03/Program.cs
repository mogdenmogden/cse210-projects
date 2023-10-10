using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Hello Learning03 World!");
        Fraction one = new Fraction();
        one.Numbers();
        one.Numbers(6);
        one.Numbers(6,7);

        Console.WriteLine($"{one.GetTop()} top");
        Console.WriteLine($"{one.GetBottom()} bottom");
        Console.WriteLine($"{one.GetFractionString()} string");
        Console.WriteLine($"{one.GetDecimalValue()} decimal");

        one.Numbers(3,4);
        Console.WriteLine($"{one.GetTop()} top");
        Console.WriteLine($"{one.GetBottom()} bottom");
        Console.WriteLine($"{one.GetFractionString()} string");
        Console.WriteLine($"{one.GetDecimalValue()} decimal");
        
        one.Numbers(8,7);
        Console.WriteLine($"{one.GetTop()} top");
        Console.WriteLine($"{one.GetBottom()} bottom");
        Console.WriteLine($"{one.GetFractionString()} string");
        Console.WriteLine($"{one.GetDecimalValue()} decimal");
        
        

        
    }
}