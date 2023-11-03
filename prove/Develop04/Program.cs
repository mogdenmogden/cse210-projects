using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        //Menu system to choose an activity

        string _choice;
        string[] _choiceSet = {"1","2","3"};  //controls the do while on the menu

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
            _choice = Console.ReadLine();
            
            switch(_choice)
            {
            case "1":
                Breathe breathe = new Breathe(_choice);
                breathe.WriteReadyMsg();
                breathe.RunBreathe();
                breathe.WriteEndMsg();
                break;
            case "2":
                Reflect reflect = new Reflect(_choice);
                reflect.WriteReadyMsg();
                reflect.RunReflect();
                reflect.WriteEndMsg();
                break;
            case "3":
                List list = new List(_choice);
                list.WriteReadyMsg();
                list.RunList();
                list.WriteEndMsg();
                break;
            default: 
                Console.WriteLine("Good bye.");
                return;
            }
        } while (_choiceSet.Contains(_choice));
    }

}