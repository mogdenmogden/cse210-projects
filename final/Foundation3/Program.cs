using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation3 World!");
        Console.Clear();
        string edgeLine = new string('-',25);
        Address lectureAddress = new Address("1311 Skyline Dr","SLC","UT","84119");
        Lecture lecture1 = new Lecture("How to Wash Your Dog","Instructions for every dog owner about how to keep your dog clean.","12/4/2023","4:00 PM","Harold H. Hammer","120 people, plus their dogs",lectureAddress);
        Console.WriteLine("\nStandard Message: ");
        Console.WriteLine(lecture1.GetStandardMsg());
        Console.WriteLine("\nFull Message: ");
        Console.WriteLine(lecture1.GetFullMsg());
        Console.WriteLine("\nShort Message: ");
        Console.WriteLine(lecture1.GetShortMsg());
        Console.WriteLine();
        Console.WriteLine($"\n{edgeLine}\n");

        Address receptionAddress = new Address("11185 Bridge Arch Dr","Temple","TX","76502");
        Reception reception1 = new Reception("Honoring Marco Polo","Come learn about Marco Polo's grand voyages.","12/01/2023","7:00 PM","explorers_club@byui.edu",receptionAddress);
        Console.WriteLine("\nStandard Message: ");
        Console.WriteLine(reception1.GetStandardMsg());
        Console.WriteLine("\nFull Message: ");
        Console.WriteLine(reception1.GetFullMsg());
        Console.WriteLine("\nShort Message: ");
        Console.WriteLine(reception1.GetShortMsg());
        Console.WriteLine();
        Console.WriteLine($"\n{edgeLine}\n");

        Address outdoorAddress = new Address("115 Park Ln","West Vally City","UT","84119");
        Outdoor outdoor1 = new Outdoor("Meet the King of Siam","The king of Siam, Alfred E. Neuman will meet the public. Siamese meatballs served.","12/16/2023","6:00 PM","Cloudy with a chance of meatballs.",outdoorAddress);
        Console.WriteLine("\nStandard Message: ");
        Console.WriteLine(outdoor1.GetStandardMsg());
        Console.WriteLine("\nFull Message: ");
        Console.WriteLine(outdoor1.GetFullMsg());
        Console.WriteLine("\nShort Message: ");
        Console.WriteLine(outdoor1.GetShortMsg());
        Console.WriteLine();
        Console.WriteLine($"\n{edgeLine}\n");


    }
}