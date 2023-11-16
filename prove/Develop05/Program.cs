using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop05 World!");
        Console.Clear();
        string choice, name, description, checkMark = " ";;
        string[] choiceSet = {"1","2","3","4","5"};  //controls the do while on the menu
        int pointsTotal = 0, thisGoalPoints = 0, whichEvent;
        string goalPick;
        string myFile;
        List<Goal> myGoals = new List<Goal>();

        Console.Clear();
        Console.WriteLine("Welcome to the Goal Tracking Program.");
        Thread.Sleep(1500);
        //start the do while HERE
        do
        {
            //update point total at the end of the process, before coming to this spot again
            // Console.Clear();
            // goalList.Add()
            // points = goal.DisplayPoints();
            Console.WriteLine($"You have {pointsTotal} points.\n"); //goal.GetPoints()?
            
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
                    Console.WriteLine("making a simple goal");
                    Console.Write("What is the name of your goal? ");
                    string localName = Console.ReadLine();
                    name = localName;
                    Console.Write("Write a short description for this goal: ");
                    string localDescription = Console.ReadLine();
                    description = localDescription;
                    Console.Write("How many points will this goal earn? ");
                    int localGoalPoints = int.Parse(Console.ReadLine());
                    thisGoalPoints = localGoalPoints;
                    // Console.WriteLine($"{name}, {description}, {thisGoalPoints}");
                    // Console.WriteLine("hey, what happened?");
                    Goal simpleGoal = new Goal(choice,name,description,thisGoalPoints);
                    myGoals.Add(simpleGoal);
                }
                else if (goalPick == "2")
                {
                    Console.WriteLine("making an eternal goal");
                }
                else
                {
                    Console.WriteLine("making a checklist goal");
                }
                //SimpleGoal simple = new SimpleGoal();
                //simple.MakeGoal(string name, string description); //includes setting name, desc, points
                //simple.AddGoalToList();
                
                break;
            case "2": //list goals
                int indexNumber = 1;
                Console.WriteLine("The goals are: ");
                foreach (Goal goal in myGoals)
                {
                    checkMark = " ";
                    List<string> goalData = goal.GetGoal();
                    string localName = goalData[1];//goal.GetGoalName();
                    name = localName ;
                    string localDescription = goalData[2];//goal.GetGoalDesc();
                    description = localDescription;
                    int localGoalPoints = int.Parse(goalData[3]);//goal.GetPoints();
                    thisGoalPoints = localGoalPoints;
                    bool thisGoalDone = bool.Parse(goalData[4]);//goal.IsComplete();
                    // if (goalData[4] == "true")
                    if (thisGoalDone == true)
                    {
                        checkMark = "X";
                    };
                    
                    // Console.WriteLine($"{indexNumber}. [{checkMark}] {goalData[1]} ({goalData[2]})");
                    Console.WriteLine($"{indexNumber}. [{checkMark}] {name} ({description}) worth {thisGoalPoints} points");
                    // foreach (string j in goalData)
                    // {
                    //     Console.WriteLine($"{indexNumber}. [?] {j[1]} ({j[2]})");

                    // }
                   
                    indexNumber++;
                }
                Console.WriteLine();
                //DisplayGoals(Goal myGoal); //Console.WriteLine("The goals are: "); inside the method
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
                        saveOne.SetStringRepresentation(goal);
                        outputFile.WriteLine(saveOne.GetStringRepresentation());
                    }
                }
                //stick the point total into the file first, then the list of goals
                break;
            case "4": //load
                Console.Write("What is the filename for the goal file? ");
                myFile = Console.ReadLine();
                //LoadGoals(myFile);
                break;
            case "5":  //record event
                //DisplayGoals(Goal myGoal);  //"The goals are: " inside that method
                int iterationNumber = 1;
                // foreach (Goal in myGoals)
                // {
                    
                // }
                Console.Write("Which goal did you accomplish? ");
                int localEvent = int.Parse(Console.ReadLine())-1;
                Goal recordThisOne = myGoals[localEvent];
                recordThisOne.RecordEvent();
                List<string> thisAchievedSimpleGoal = recordThisOne.GetGoal();
                pointsTotal = pointsTotal + recordThisOne.GetTotalPoints();

                Console.WriteLine($"You have {pointsTotal} points! ");
                // foreach (string word in thisAchievedSimpleGoal)
                // {
                //     Console.WriteLine(word);
                // }
                
                break;
            default: 
                Console.WriteLine("Good bye.");
                return;
            }

            

        } while (choiceSet.Contains(choice));
    }
}