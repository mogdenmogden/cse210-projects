using System.ComponentModel;

public class Eternal : Goal
{
    public Eternal() : base()
    {
        // Console.Write("What is the name of your goal? ");
        // string localName = Console.ReadLine();
        // _goalName = localName;
        // Console.Write("Write a short description for this goal: ");
        // string localDescription = Console.ReadLine();
        // _goalDesc = localDescription;
        // Console.Write("How many points will this goal earn? ");
        // int localGoalPoints = int.Parse(Console.ReadLine());
        // _thisGoalPoints = localGoalPoints;
        _goalType = "Perpetual";
        _isDone = false;
    }
    
    public Eternal(string goalType,string name, string desc, int points) : base(goalType,name,desc,points)
    {
        _goalType = "Perpetual";
        SetGoalName(name);
        SetGoalDesc(desc);
        SetPoints(points);
        PackageGoalStrings();
        _isDone = false;
    }

    protected override void SetComplete(bool doneStatus) 
    {
        _isDone = false;
    }

    public override void RecordEvent()
    {
        if (_isDone == true)
        {
            Console.WriteLine("You have already completed this goal. ");
            
        }
        else
        {
            // _isDone = true;
            //_pointTotal = _pointTotal + _thisGoalPoints;
            PackageGoalStrings();
            AwardPoints();
            Console.WriteLine($"Congratulations! You earned {_thisGoalPoints} points! ");
        }
    }


}