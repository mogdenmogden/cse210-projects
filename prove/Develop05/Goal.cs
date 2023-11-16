public class Goal
{
    protected string _goalName, _goalDesc, _doneMark = "X", _fileName,_goalType;
    protected int _thisGoalPoints = 0, _pointTotal = 0;
    protected List<string> _goalList;
    protected List<string> _loadedLines;
    protected bool _isDone = false;
    //protected List<string> _goalPackage;

    public Goal(string goalType,string name, string desc, int points)
    {
        List<string> _goalList = new List<string>();
        _goalType = "Simple";
        SetGoalName(name);
        SetGoalDesc(desc);
        SetPoints(points);
        PackageGoalStrings();
    }

    public Goal(Goal goal) //(string goalType,string name, string desc, int points, bool done)
    {
        List<string> _goalList = new List<string>();
        _goalType = goal._goalType; //0
        SetGoalName(goal._goalName); //1
        SetGoalDesc(goal._goalDesc); //2
        SetPoints(goal._thisGoalPoints); //3
        SetComplete(goal._isDone); //4
        PackageGoalStrings();
    }

    private void SetGoalName(string name)
    {
        _goalName = name; 
    }

    public string GetGoalName()
    {
        return _goalName;
    }

    private void SetGoalDesc(string name)
    {
        _goalDesc = name; 
    }

    public string GetGoalDesc()
    {
        return _goalDesc;
    }

    private void SetPoints(int points)
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

    private void SetComplete(bool doneStatus)
    {
        _isDone = doneStatus;
    }

    public bool IsComplete()
    {
        
        return _isDone;
    }

    private void AwardPoints()
    {
        _pointTotal = _pointTotal + _thisGoalPoints;
    }

    private int DisplayPointTotal()
    {
        return _pointTotal;
    }

    private void PackageGoalStrings()
    {
        //Console.WriteLine("putting the name, desc,points into a list<String>");
        List<string> goalPackage = new List<string>();
        goalPackage.Add(_goalType); //0
        goalPackage.Add(_goalName); //1
        goalPackage.Add(_goalDesc); //2
        goalPackage.Add(_thisGoalPoints.ToString()); //3
        goalPackage.Add(_isDone.ToString()); //4
        _goalList = goalPackage;
        
    }
    
    public List<string> GetGoal()
    {
        return _goalList;
    }

    public void RecordEvent()
    {
        _isDone = true;
        //_pointTotal = _pointTotal + _thisGoalPoints;
        PackageGoalStrings();
        AwardPoints();
    }
    
    // public void SaveGoals(string filename, List<Goal> goalsList)
    // {
    //     using (StreamWriter outputFile = new StreamWriter(filename))
    //     {
    //         outputFile.WriteLine(_pointTotal);
    //         foreach (Goal goal in goalsList)
    //         {
    //             outputFile.WriteLine(goal.GetGoal());
    //         }
    //     }
    // }
    

}