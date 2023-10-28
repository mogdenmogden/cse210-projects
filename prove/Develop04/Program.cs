using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop04 World!");
        //Menu system to choose an activity

        string choice;
        string startMsg;
        DateTime endTime;

        Console.WriteLine("Welcome to the Mindfulness Program.");
        
        //start the do while HERE
        Console.Clear();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("\t1. Start breathing activity");
        Console.WriteLine("\t2. Start reflecting activity");
        Console.WriteLine("\t3. Start listing activity");
        Console.WriteLine("\t4. Quit");
        Console.Write("Select a choice from the menu:  ");
        choice = Console.ReadLine();
        
        switch(choice)
        {
        case "1":
            Activity breathe = new Activity(choice);
            breathe.ReadyMsg();
            // breathe.RunBreathe();
            // do //THIS SHOULD BE RUNBREATHE, OR SOMETHING NEAR TO THIS
            // {
            //     endTime = breathe.Timer();  
            //     //do the activity here
            // } while (DateTime.Now <= endTime);
            breathe.EndMsg();
            break;
        case "2":
            Activity reflect = new Activity(choice);
            reflect.ReadyMsg();
            // reflect.RunReflect();
            reflect.EndMsg();
            break;
        case "3":
            Activity list = new Activity(choice);
            list.ReadyMsg();
            // list.RunList();
            list.EndMsg();
            break;
        default: 
            Console.WriteLine("something went wrong");
            break;
        }
    }

}