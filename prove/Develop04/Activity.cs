using System.Xml;

public class Activity
{
    private string _chosenActivity;
    private int _chosenDuration;
    private string _actName;
    private string _actDescr;
    private string _startMsg;
    private string _getReady;
    private int _totTime;
    private int timedown;

    public Activity(string choiceA)
    {
        _chosenActivity = choiceA;
        //_chosenDuration = choiceD;
        
    }

    public void SetTime()//do I want this in Main?
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _chosenDuration = int.Parse(Console.ReadLine());

    }

    public int GetTime()
    {
        return _chosenDuration;
    }

    public void SetFirstMsgs(string activity, string description)  //ref the child class desc
    {
        _startMsg = activity;
        _actDescr = description;
    }

    public void PrintStartGetTime()
    {
        Console.WriteLine($"Welcome to the {_actName} Activity");
        Console.WriteLine();
        Console.WriteLine(_actDescr);
        Console.WriteLine();
        SetTime();//do I want this in Main?
        
    }

    public void Spinner(int time)
    {
        int _spintime = time*1000;
        
        _totTime = 0;
        int increment = 200;
        do 
        {
            Console.Write("-"); Thread.Sleep(increment*time); _totTime =_totTime+increment;
            Console.Write("\b\\"); Thread.Sleep(increment*time); _totTime =_totTime+increment;
            Console.Write("\b|"); Thread.Sleep(increment*time); _totTime =_totTime+increment;
            Console.Write("\b/"); Thread.Sleep(increment*time); _totTime =_totTime+increment;
            Console.Write("\b*\b"); Thread.Sleep(increment*time); _totTime =_totTime+increment;
        } while (_totTime <= time);
    }

    public void ReadyMsg()
    {
        Console.WriteLine("Get ready...");
        Spinner(4);
    }

    public void EndMsg()
    {
        Console.WriteLine($"Well done!!");
        Spinner(4);
        Console.WriteLine($"\nYou have completed another {_chosenDuration} seconds of the {_chosenActivity} Activity.");
        Spinner(4);
    }

    public DateTime Timer()
    {
        DateTime begin = DateTime.Now;
        DateTime end = begin.AddSeconds(_chosenDuration);
        return end;
    }

    public void CountDown(int seconds)
    {
        timedown = seconds;
        do
        {
            timedown--;
            Console.Write($"{timedown}\b");
        } while (timedown > 0);
    }
}