using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        string choice;
        string[] choiceSet = {"1","2","3","4","5"};  //controls the do while on the menu
        int pointsTotal = 0, recordEventChoice;
        string goalPick;
        string myFile;
        List<Goal> myGoals = new List<Goal>();
        List<int> doneList = new List<int>();

        Console.WriteLine("Welcome to the Goal Tracking Program.");
        AsciiText welcome = new AsciiText("Welcome to the Goal Tracking Program!");
        welcome.PrintAsciiStuff();
        // Thread.Sleep(1500);
        //start the do while HERE
        do
        {
            Console.WriteLine($"\nYou have {pointsTotal} points.\n"); 
            
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\t1. Create New Goal");
            Console.WriteLine("\t2. List Goals");
            Console.WriteLine("\t3. Save Goals");
            Console.WriteLine("\t4. Load Goals");
            Console.WriteLine("\t5. Record Event");
            Console.WriteLine("\t6. Quit");
            Console.Write("Select a choice from the menu:  ");
            choice = Console.ReadLine();
            
            switch(choice)
            {
            case "1":  //new goal
                Console.WriteLine("\nThe types of Goals are:");
                Console.WriteLine("1. Simple Goal (a one-time accomplishment)");
                Console.WriteLine("2. Eternal Goal (a perpetual recurring behavior/accomplishment)");
                Console.WriteLine("3. Checklist Goal (an accomplishment having a behavior that happens multiple times before completion)");
                Console.Write("What type of goal would you like to make? ");
                goalPick = Console.ReadLine();
                if (goalPick == "1")
                {
                    AsciiText simple = new AsciiText("lets make a simple goal");
                    simple.PrintAsciiStuff();  
                    Goal aGoal = new Goal();
                    myGoals.Add(aGoal);
                }
                else if (goalPick == "2")
                {
                    AsciiText eternal = new AsciiText("lets make an eternal goal");
                    eternal.PrintAsciiStuff();  
                    Eternal anEternalGoal = new Eternal();
                    myGoals.Add(anEternalGoal);
                }
                else if (goalPick == "3")
                {
                    AsciiText checklist = new AsciiText("lets make a checklist goal");
                    checklist.PrintAsciiStuff();  
                    Checklist aChecklistGoal = new Checklist();
                    myGoals.Add(aChecklistGoal);
                }
                else 
                {
                    Console.WriteLine("It seems that a wrong value was selected. Please try again.");
                }
               break;
            case "2": //list goals
                int indexNumber = 1;
                AsciiText yourGoals = new AsciiText("your goals:");
                yourGoals.PrintAsciiStuff();  
                Console.WriteLine("The goals are: ");
                foreach (Goal goal in myGoals)
                {
                    string lineOut = goal.ListGoals("long");
                    Console.WriteLine($"{indexNumber}. {lineOut}");
                    indexNumber++;
                }
                break;
            case "3": //save
                Console.Write("What is the filename for the goal file? ");
                myFile = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter(myFile))
                {
                    outputFile.WriteLine(pointsTotal);
                    foreach (Goal goal in myGoals)
                    {
                        Goal saveOne = new Goal(goal.GetGoalType(),goal.GetGoalName(),goal.GetGoalDesc(),goal.GetPoints(),goal.IsComplete());
                        outputFile.WriteLine(saveOne.GetStringRepresentation());
                    }
                }
                break;
            case "4": //load
                doneList.Clear();
                Console.Write("What is the filename for the goal file? ");
                myFile = Console.ReadLine();
                string[] fileLines = System.IO.File.ReadAllLines(myFile);
                foreach (string line in fileLines)
                {
                    string[] parts = line.Split("|");
                    int partsLength  = parts.Length;
                    if (partsLength == 1)
                    {
                        pointsTotal = int.Parse(parts[0]);
                    }
                    else
                    {
                        Goal loadAGoal = new Goal(parts[0],parts[1],parts[2],int.Parse(parts[3]),bool.Parse(parts[4]));
                        myGoals.Add(loadAGoal);
                    }
                }
                break;
            case "5":  //record event
                int itemNumber = 1;
                Console.WriteLine("The goals are: ");
                doneList.Clear();
                foreach (Goal goal in myGoals)
                {
                    if (goal.IsComplete() == true)
                    {
                        doneList.Add(itemNumber) ; 
                        //done = "[DONE]";
                    }
                    string lineOut = goal.ListGoals("short");
                    Console.WriteLine($"{itemNumber}. {lineOut}");
                    itemNumber++;
                }
                Console.Write("Which goal did you accomplish? ");
                recordEventChoice = int.Parse(Console.ReadLine())-1;
                string thisType = myGoals[recordEventChoice].GetGoalType();
                if (thisType == "Checklist")
                {
                    if (doneList.Contains(recordEventChoice+1))
                    {
                        Console.WriteLine("That's already done.");
                        break;
                    }
                    else
                    {
                        
                        myGoals[recordEventChoice].RecordEvent();
                        int pointAddOn = myGoals[recordEventChoice].GetPoints() + myGoals[recordEventChoice].GetBonus();
                        pointsTotal += pointAddOn;
                        bool itsDone = myGoals[recordEventChoice].IsComplete();
                        if (itsDone == true)
                        {
                            doneList.Add(recordEventChoice+1);
                        }

                    }
                }
                else
                {
                    if (doneList.Contains(recordEventChoice+1))
                    {
                        Console.WriteLine("That's already done.");
                        break;
                    }
                    else
                    {
                        myGoals[recordEventChoice].RecordEvent();
                        int pointAddOn = myGoals[recordEventChoice].GetPoints();
                        pointsTotal += pointAddOn;
                        doneList.Add(recordEventChoice++);
                    }
                }
                break;
            default: 
                //Console.WriteLine("Good bye.");
//                 Console.WriteLine(@"
//   __    ___   ___   ___       ___   _     ____
//  / /`_ / / \ / / \ | | \     | |_) \ \_/ | |_ 
//  \_\_/ \_\_/ \_\_/ |_|_/     |_|_)  |_|  |_|__

//                 ");
                
                AsciiText textLine = new AsciiText("Good bye!");
                textLine.PrintAsciiStuff();
                // List<List<string>> printThis = textLine.GetOutput();
                
                // foreach (List<string> i in printThis)
                // {
                //     var bigCharacterT = i[0];
                //     Console.Write(bigCharacterT);
                // }
                //     Console.WriteLine();
                // foreach (List<string> i in printThis)
                // {
                //     var bigCharacterM = i[1];
                //     Console.Write(bigCharacterM);
                // }
                //     Console.WriteLine();
                // foreach (List<string> i in printThis)
                // {
                //     var bigCharacterB = i[2];
                //     Console.Write(bigCharacterB);
                // }
                //     Console.WriteLine();

                
                Console.WriteLine("ASCII art fonts courtesy of https://texteditor.com/multiline-text-art/");
                Console.WriteLine();
                return;
            }
        } while (choiceSet.Contains(choice));
    } 
}