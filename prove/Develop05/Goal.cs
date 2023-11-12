public abstract class Goal
{
    protected string _goalName, _goalDesc, _doneMark = "X", _fileName;
    protected int _thisGoalPoints = 0, _pointTotal = 0;
    protected List<Goal> _goalList;
    protected string[] _loadedLines;
    protected bool _isDone = false;
    protected List<string> _goalPackage;

    public Goal(string name, string desc, int points, bool _Done)
    {
        SetGoalName(name);
        SetGoalDesc(desc);
        SetPoints(points);
        
        
    }

    private Goal(List<string> loadedLines)
    {
        foreach (string line in loadedLines)
        {
        //line[0] is the type of goal, ie "SimpleGoal"
        SetGoalName(line[1]);
        SetGoalDesc(line[2]);
        SetPoints(line[3]);
        if (line[4] is true)
        {
            _isDone = true;
        }

        }
    }

    private void SetGoalName(string name)
    {
        _goalName = name; 
    }

    private string GetGoalName()
    {
        return _goalName;
    }

    private void SetGoalDesc(string name)
    {
        _goalDesc = name; 
    }

    private string GetGoalDesc()
    {
        return _goalDesc;
    }

    private void SetPoints(int points)
    {
        _thisGoalPoints = points; 
    }

    private int GetPoints()
    {
        return _thisGoalPoints;
    }

    private void AwardPoints(int points)
    {
        _pointTotal = _pointTotal + points;
    }

    private int DisplayPointTotal()
    {
        return _pointTotal;
    }

    public void DisplayGoalList()
    {
        int indexNumber = 1;
        Console.WriteLine("The goals are: ");
        foreach (Goal goal in _goalList)
        {
            Console.WriteLine($"{indexNumber}. [{_doneMark}] {goal.[1]} ({goal.[2]})]")
        }
    }

}