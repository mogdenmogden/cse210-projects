using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop04 World!");
        //Menu system to choose an activity

        string choice;
        // string startMsg;
        // DateTime endTime;
        string[] choiceSet = {"1","2","3","4"};

        Console.WriteLine("Welcome to the Mindfulness Program.");
        
        //start the do while HERE
        do
        {
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
                Breathe breathe = new Breathe(choice);
                breathe.ReadyMsg();
                breathe.RunBreathe();
                // do //THIS SHOULD BE RUNBREATHE, OR SOMETHING NEAR TO THIS
                // {
                //     endTime = breathe.Timer();  
                //     //do the activity here
                // } while (DateTime.Now <= endTime);
                breathe.EndMsg();
                break;
            case "2":
                Reflect reflect = new Reflect(choice);
                reflect.ReadyMsg();
                reflect.RunReflect();
                reflect.EndMsg();
                break;
            case "3":
                Activity list = new Activity(choice);
                list.ReadyMsg();
                // list.RunList();
                list.EndMsg();
                break;
            default: 
                Console.WriteLine("Good bye.");
                return;
            }
        } while (choiceSet.Contains(choice));
    }

}