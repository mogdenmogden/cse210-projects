using System.ComponentModel;
using System.Runtime.CompilerServices;

public class Eternal : Goal
{
    public Eternal() : base()
    {
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
            PackageGoalStrings();
            AwardPoints();
            Console.WriteLine($"Congratulations! You earned {_thisGoalPoints} points! ");
            AsciiText congratsEternal = new AsciiText($"Congratulations! You earned {_thisGoalPoints} points! ");
            congratsEternal.PrintAsciiStuff();
            Console.WriteLine(@"
 __    __                                 __   __                            __ 
|  \  /  \                               |  \ |  \                          |  \
| ▓▓ /  ▓▓ ______   ______   ______       \▓▓_| ▓▓_        __    __  ______ | ▓▓
| ▓▓/  ▓▓ /      \ /      \ /      \     |  \   ▓▓ \      |  \  |  \/      \| ▓▓
| ▓▓  ▓▓ |  ▓▓▓▓▓▓\  ▓▓▓▓▓▓\  ▓▓▓▓▓▓\    | ▓▓\▓▓▓▓▓▓      | ▓▓  | ▓▓  ▓▓▓▓▓▓\ ▓▓
| ▓▓▓▓▓\ | ▓▓    ▓▓ ▓▓    ▓▓ ▓▓  | ▓▓    | ▓▓ | ▓▓ __     | ▓▓  | ▓▓ ▓▓  | ▓▓\▓▓
| ▓▓ \▓▓\| ▓▓▓▓▓▓▓▓ ▓▓▓▓▓▓▓▓ ▓▓__/ ▓▓    | ▓▓ | ▓▓|  \    | ▓▓__/ ▓▓ ▓▓__/ ▓▓__ 
| ▓▓  \▓▓\\▓▓     \\▓▓     \ ▓▓    ▓▓    | ▓▓  \▓▓  ▓▓     \▓▓    ▓▓ ▓▓    ▓▓  \
 \▓▓   \▓▓ \▓▓▓▓▓▓▓ \▓▓▓▓▓▓▓ ▓▓▓▓▓▓▓      \▓▓   \▓▓▓▓       \▓▓▓▓▓▓| ▓▓▓▓▓▓▓ \▓▓
                           | ▓▓                                    | ▓▓         
                           | ▓▓                                    | ▓▓         
                            \▓▓                                     \▓▓         

            ");
        }
    }

    public override int GetBonus()
    {
        return 0;
    }


}