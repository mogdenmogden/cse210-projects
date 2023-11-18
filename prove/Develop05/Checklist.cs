using System.Runtime.CompilerServices;

public class Checklist : Goal
{
    private string _goalName, _goalDesc,,_goalType;
    private int _thisGoalPoints = 0, _pointTotal = 0;
    private int _repetitionsDone, _repetitionsRequired, _bonusPoints;
    
    public Checklist() : base()
    {
        SetRepetitionsDone(0);
        Console.Write("How many repetitions are needed to finish it? ");
        int localCheckReps = int.Parse(Console.ReadLine());
        Console.Write("How many bonus points will be awarded when it is done? ");
        int localCheckBonus = int.Parse(Console.ReadLine());
        _repetitionsRequired = localCheckReps;
        _bonusPoints = localCheckBonus;
        _repetitionsDone = 0;
        _goalType = "Checklist";
        _goalName = GetGoalName();
        _goalDesc = GetGoalDesc();
        _thisGoalPoints = GetPoints();
        _pointTotal = GetTotalPoints();
    }

    public Checklist(string goalType,string name, string desc, int points,bool done,int addEvent,int repsRequired, int bonus) : base(goalType,name,desc,points,done)
    {
        _goalType = goalType;
        _goalName = GetGoalName();
        _goalDesc = GetGoalDesc();
        SetPoints(points);
        SetRepetitionsDone(addEvent);
        SetRepetitionsRequired(repsRequired);
        SetBonus(bonus);
        PackageGoalStrings();
        SetComplete(false); 
             
    }

    public override string ListGoals(string longShort)  //add something to indicate done and then regulate record event by that thing
    {
        _doneMark = " ";
        if (_isDone == true)
        {
            _doneMark = "X";
        };
        if (longShort == "long")
        {
            string lineOut = $"[{_doneMark}] {_goalName} ({_goalDesc}) worth {_thisGoalPoints} points ({_bonusPoints} completion bonus). {_repetitionsDone}/{_repetitionsRequired} completed.";
            return lineOut;
        }
        else
        {
            string done = (_isDone == true) ? "[DONE]" : "";
            string lineOut = $"{_goalName} ({_goalDesc}) {_repetitionsRequired-_repetitionsDone} more needed. {done} ";
            return lineOut;
        }
        
    }

    public override void RecordEvent()
    {   
        if (_isDone == true)
        {
            Console.WriteLine("You have already completed this goal. ");
        }
        else if ((_repetitionsDone < _repetitionsRequired) && (_isDone = false))
        {
            _repetitionsDone++;
            
            if (_repetitionsDone < _repetitionsRequired)
            {
                AwardPoints();
                PackageGoalStrings();
                Console.WriteLine($"Congratulations! You earned {_thisGoalPoints} points! {_repetitionsDone}/{_repetitionsRequired} events complete.");
            }
            else if (_repetitionsDone == _repetitionsRequired)
            {
                SetComplete(true);
                AwardPoints(); 
                PackageGoalStrings(); 
                Console.WriteLine($"Congratulations! You earned {_thisGoalPoints} points plus the {_bonusPoints} point bonus award!  {_repetitionsDone}/{_repetitionsRequired} events complete.");
            }
            
        }
        else if ((_repetitionsDone == _repetitionsRequired) && (_isDone = false))
        {
            SetComplete(true);
        }
        else if ((_repetitionsDone < _repetitionsRequired) && (_isDone = true))
        {
            SetComplete(false);
        }
        else
        {
            Console.WriteLine("what happened?");
        }
        
    }

    protected override void AwardPoints() 
    {
        if (_isDone == true)
        {
            _pointTotal = _pointTotal + _thisGoalPoints + _bonusPoints;
        }
        else
        {
            _pointTotal += _thisGoalPoints;
        }
    }

    protected override void PackageGoalStrings()
    {
        List<string> goalPackage = new List<string>();
        goalPackage.Add(_goalType); //0
        goalPackage.Add(_goalName); //1
        goalPackage.Add(_goalDesc); //2
        goalPackage.Add(_thisGoalPoints.ToString()); //3
        goalPackage.Add(_isDone.ToString()); //4
        goalPackage.Add(_repetitionsDone.ToString()); //5
        goalPackage.Add(_repetitionsRequired.ToString()); //6
        goalPackage.Add(_bonusPoints.ToString()); //7
        _goalPackage = goalPackage;
        
    }
        //                           Checklist(string goalType,string name, string desc
        // , int points,bool done,int addEvent,int repsRequired, int bonus) : base(goalType,name,desc,points,done)
    public override void SetStringRepresentation(Goal checklist)
    {
        Checklist _lineGoal = new Checklist(checklist._goalType,checklist._goalName,checklist._goalDesc
        ,checklist._thisGoalPoints,checklist._isDone,checklist._repetitionsDone,checklist._repetitionsRequired
        ,checklist._bonusPoints) : base(goalType,name,desc,points,done);
        _newline = "";
        _newline = _lineGoal._goalType+"|";
        _newline = _newline+_lineGoal._goalName+"|";
        _newline = _newline+_lineGoal._goalDesc+"|";
        _newline = _newline+_lineGoal._thisGoalPoints+"|";
        _newline += _lineGoal._isDone;
    }
        

    private void SetRepetitionsDone(int addEvent)
    {
        _repetitionsDone += addEvent;
    }

    private int GetRepetitionsDone()
    {
        return _repetitionsDone;
    }

    private void SetRepetitionsRequired(int repsRequired)
    {
        _repetitionsRequired += repsRequired;
    }

    private int GetRepetitionsRequired()
    {
        return _repetitionsRequired;
    }

    private void SetBonus(int bonus)
    {
        _bonusPoints = bonus;
    }

    private int GetBonus()
    {
        return _bonusPoints;
    }
}