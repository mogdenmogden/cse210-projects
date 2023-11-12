public class MenuClass
{
     //update point total at the end of the process, before coming to this spot again
    // List<Goal> goals = new List<Goal>; 
    // points = goal.DisplayPoints();
    string _choice;
    int _points = 0;
    string _goalPick;
    string _myFile;
    string _whichEvent;
    
    public MenuClass()
        {
            Console.Clear();
            Console.WriteLine($"You have {_points} points.\n"); //goal.GetPoints()?
            
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\t1. Create New Goal");
            Console.WriteLine("\t2. List Goals");
            Console.WriteLine("\t3. Save Goals");
            Console.WriteLine("\t4. Load Goals");
            Console.WriteLine("\t5. Record Event");
            Console.WriteLine("\t6. Quit");
            Console.Write("Select a choice from the menu:  ");
            _choice = Console.ReadLine();
            
            switch(_choice)
            {
            case "1":  //new goal
                Console.WriteLine("\nThe types of Goals are:");
                Console.WriteLine("1. Simple Goal (a one-time accomplishment)");
                Console.WriteLine("2. Eternal Goal (a perpetual recurring behavior/accomplishment)");
                Console.WriteLine("3. Checklist Goal (an accomplishment having a behavior that happens multiple times before completion)");
                Console.Write("What type of goal would you like to make? ");
                _goalPick = Console.ReadLine();
                if (_goalPick == "1")
                {
                    Console.WriteLine("making a simple goal");
                }
                else if (_goalPick == "2")
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
                
                //DisplayGoals(Goal myGoal); //Console.WriteLine("The goals are: "); inside the method
                break;
            case "3": //save
                Console.Write("What is the filename for the goal file? ");
                _myFile = Console.ReadLine();
                //SaveGoals(_myFile);  //stick the point total into the file first, then the list of goals
                break;
            case "4": //load
                Console.Write("What is the filename for the goal file? ");
                _myFile = Console.ReadLine();
                //LoadGoals(_myFile);
                break;
            case "5":  //record event
                //DisplayGoals(Goal myGoal);  //"The goals are: " inside that method
                Console.Write("Which goal did you accomplish? ");
                _whichEvent = Console.ReadLine();
                //RecordEvent(_whichEvent);
                //AwardPoints(_whichEvent);
                break;
            default: 
                Console.WriteLine("Good bye.");
                return;
            }
        }
    
    public string GetChoice()
    {
        return _choice;
    }
    
}