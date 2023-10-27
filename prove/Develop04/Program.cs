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
            Activity breathe = new Activity(choice);
            //set the _actName and _actDescr HERE
            breathe.PrintStartGetTime();
            breathe.ReadyMsg();
            do
            {
                endTime = breathe.Timer();
                //do the activity here
            } while (DateTime.Now <= endTime);
            breathe.EndMsg();
            break;
        case "2":
            Activity reflect = new Activity(choice);
            //set the _actName and _actDescr HERE
            reflect.PrintStartGetTime();
            reflect.ReadyMsg();
            do
            {
                endTime = reflect.Timer();
                //do the activity here
            } while (DateTime.Now <= endTime);
            reflect.EndMsg();
            break;
        case "3":
            Activity listen = new Activity(choice);
            //set the _actName and _actDescr HERE
            listen.PrintStartGetTime();
            listen.ReadyMsg();
            do
            {
                endTime = listen.Timer();
                //do the activity here
            } while (DateTime.Now <= endTime);
            listen.EndMsg();
            break;
        default: 
            Console.WriteLine("something went wrong");
            break;
        }
    }


    }
}