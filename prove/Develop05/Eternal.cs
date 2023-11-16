using System.ComponentModel;

public class Eternal : Goal
{
    public Eternal(string goalType,string name, string desc, int points) : base(goalType,name,desc,points)
    {
        List<string> _goalPackage = new List<string>();
        _goalType = "Perpetual";
        SetGoalName(name);
        SetGoalDesc(desc);
        SetPoints(points);
        PackageGoalStrings();
    }


}