using System.Runtime.CompilerServices;

public class Checklist : Goal
{
    private int _repetitionsDone, _repetitionsRequired, _bonusPoints;
    
    public Checklist() : base()
    {
        _goalType = "Checklist";
        Console.Write("How many repetitions are needed to finish it? ");
        int localCheckReps = int.Parse(Console.ReadLine());
        Console.Write("How many bonus points will be awarded when it is done? ");
        int localCheckBonus = int.Parse(Console.ReadLine());
        _repetitionsRequired = localCheckReps;
        _bonusPoints = localCheckBonus;
        SetRepetitionsDone(0);        
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

    public override string ListGoals(string longShort)  
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
        else if ((_repetitionsDone < _repetitionsRequired) & (_isDone == false))
        {
            _repetitionsDone++;
            
            if (_repetitionsDone < _repetitionsRequired)
            {
                AwardPoints();
                PackageGoalStrings();
                AsciiText congratsEvent = new AsciiText($"Congratulations! You earned {_thisGoalPoints} points!");
                congratsEvent.PrintAsciiStuff();
                Console.WriteLine($"Congratulations! You earned {_thisGoalPoints} points! {_repetitionsDone}/{_repetitionsRequired} events complete.");
            }
            else if (_repetitionsDone == _repetitionsRequired)
            {
                SetComplete(true);
                AwardPoints(); 
                PackageGoalStrings(); 
                AsciiText congratsChecklist = new AsciiText($"Yes! You earned {_thisGoalPoints} and {_bonusPoints} bonus!");
                congratsChecklist.PrintAsciiStuff();
                Console.WriteLine($"Congratulations! You earned {_thisGoalPoints} points plus the {_bonusPoints} point bonus award!  {_repetitionsDone}/{_repetitionsRequired} events complete.");
            }
            
        }
        else if ((_repetitionsDone == _repetitionsRequired) & (_isDone == false))
        {
            SetComplete(true);
            Console.WriteLine("RecordEvent else if set _isDone to true bc done == reqd");
        }
        else if ((_repetitionsDone < _repetitionsRequired) & (_isDone == true))
        {
            SetComplete(false);
            Console.WriteLine("RecordEvent else if set _isDone to false bc done < reqd");
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
    
    public override string GetStringRepresentation()
    {
        return $"{_goalType}|{_goalName}|{_goalDesc}|{_thisGoalPoints}|{_isDone}|{_repetitionsDone}|{_repetitionsRequired}|{_bonusPoints}";
    }    
        

    private void SetRepetitionsDone(int addEvent)
    {
        _repetitionsDone += addEvent;
    }

    public int GetRepetitionsDone()
    {
        return _repetitionsDone;
    }

    private void SetRepetitionsRequired(int repsRequired)
    {
        _repetitionsRequired += repsRequired;
    }

    public int GetRepetitionsRequired()
    {
        return _repetitionsRequired;
    }

    private void SetBonus(int bonus)
    {
        _bonusPoints = bonus;
    }

    public override int GetBonus()
    {
        return _bonusPoints;
    }
}