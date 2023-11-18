public abstract class Goal
{
    protected string _goalName, _goalDesc, _doneMark = "X", _fileName;
    public string _goalType;
    protected int _thisGoalPoints = 0, _pointTotal = 0;
    protected List<string> _goalPackage;
    protected string _newline;
    protected bool _isDone = false;
    //protected List<string> _goalPackage;

    public Goal()
    {
        Console.Write("What is the name of your goal? ");
        string localName = Console.ReadLine();
        _goalName = localName;
        Console.Write("Write a short description for this goal: ");
        string localDescription = Console.ReadLine();
        _goalDesc = localDescription;
        Console.Write("How many points will this goal earn? ");
        int localGoalPoints = int.Parse(Console.ReadLine());
        _thisGoalPoints = localGoalPoints;
        _goalType = "Simple";
        SetComplete(false);
    }

    public Goal(string goalType,string name, string desc, int points)
    {
        List<string> _goalPackage = new List<string>();
        _goalType = "Simple";
        SetGoalName(name);
        SetGoalDesc(desc);
        SetPoints(points);
        PackageGoalStrings();
    }

    public Goal(string goalType,string name, string desc, int points, bool done)
    {
        List<string> _goalPackage = new List<string>();
        _goalType = goalType; //0
        SetGoalName(name); //1
        SetGoalDesc(desc); //2
        SetPoints(points); //3
        SetComplete(done); //4
        PackageGoalStrings();
    }

    public virtual string ListGoals(string longShort)  //add something to indicate done and then regulate record event by that thing
    {
        _doneMark = " ";
        if (_isDone == true)
        {
            _doneMark = "X";
        };
        if (longShort == "long")
        {
            string lineOut = $"[{_doneMark}] {_goalName} ({_goalDesc}) worth {_thisGoalPoints} points";
            return lineOut;
        }
        else
        {
            string done = (_isDone == true) ? "[DONE]" : "";
            string lineOut = $"{_goalName} ({_goalDesc})  {done} ";
            return lineOut;
        }
        
    }

    public string GetGoalType()
    {
        return _goalType;
    }

    protected void SetGoalName(string name)
    {
        _goalName = name; 
    }

    public string GetGoalName()
    {
        return _goalName;
    }

    protected void SetGoalDesc(string name)
    {
        _goalDesc = name; 
    }

    public string GetGoalDesc()
    {
        return _goalDesc;
    }

    protected void SetPoints(int points)
    {
        _thisGoalPoints = points; 
    }

    public int GetPoints()
    {
        return _thisGoalPoints;
    }

    public int GetTotalPoints()
    {
        return _pointTotal;
    }

    public abstract int GetBonus();

    protected virtual void SetComplete(bool doneStatus)
    {
        _isDone = doneStatus;
    }

    public bool IsComplete()
    {
        return _isDone;
    }

    protected virtual void AwardPoints()
    {
        _pointTotal += _thisGoalPoints;
    }

    private int DisplayPointTotal()  //unused
    {
        return _pointTotal;
    }

    protected virtual void PackageGoalStrings()
    {
        //Console.WriteLine("putting the name, desc,points into a list<String>");
        List<string> goalPackage = new List<string>();
        goalPackage.Add(_goalType); //0
        goalPackage.Add(_goalName); //1
        goalPackage.Add(_goalDesc); //2
        goalPackage.Add(_thisGoalPoints.ToString()); //3
        goalPackage.Add(_isDone.ToString()); //4
        _goalPackage = goalPackage;
        
    }
    
    public List<string> GetGoal()
    {
        return _goalPackage;
    }

    public virtual void RecordEvent()
    {
        if (_isDone == true)
        {
            Console.WriteLine("You have already completed this goal. ");
        }
        else
        {
            SetComplete(true);
            //_pointTotal = _pointTotal + _thisGoalPoints;
            PackageGoalStrings();
            AwardPoints();
            Console.WriteLine($"Congratulations! You earned {_thisGoalPoints} points! ");
        }
    }
    
    public virtual void SetStringRepresentation(Goal goal)
    {
        Goal _lineGoal = new Goal(goal._goalType,goal._goalName,goal._goalDesc,goal._thisGoalPoints,goal._isDone);
        _newline = "";
        _newline = _lineGoal._goalType+"|";
        _newline = _newline+_lineGoal._goalName+"|";
        _newline = _newline+_lineGoal._goalDesc+"|";
        _newline = _newline+_lineGoal._thisGoalPoints+"|";
        _newline += _lineGoal._isDone;
    }
    
    public string GetStringRepresentation()
    {
        return _newline;
    }

    

}