using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop04 World!");
        //Menu system to choose an activity

        string choice;
        string startMsg;

        Console.WriteLine("Welcome to the Mindfulness Program");
        Console.WriteLine("\t1. Start breathing activity");
        Console.WriteLine("\t2. Start reflecting activity");
        Console.WriteLine("\t3. Start listing activity");
        Console.WriteLine("\t4. Quit");
        Console.Write("Select a choice from the menu:  ");
        choice = Console.ReadLine();
        
        switch(choice)
        {
        case "1":
            startMsg = "something to begin each activity routine";
            break;
        case "2":
            startMsg = "";
            break;
        case "3":
            startMsg = "";
            break;
        default: 
            startMsg = "something went wrong";
            break;
        }
    }


    }
}