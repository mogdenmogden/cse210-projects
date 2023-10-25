public class Activity
{
    private string _chosenActivity;
    private int _chosenDuration;
    private string _actName;
    private string _actDescr;
    private string _startMsg;
    private string _getReady;
    private int _totTime;

    public Activity(string choiceA)
    {
        _chosenActivity = choiceA;
        
        
    }

    public int PrintStartGetTime(string entry)
    {
        Console.WriteLine($"Welcome to the {_actName} Activity\t");
        Console.WriteLine(_actDescr);
        Console.WriteLine();
        SetTime();//do I want this in Main?
        return _chosenDuration;
    }

    public void SetStartMsg(string activity)
        {
            _startMsg = "some Get here ref the child classes";
        }

    private void SetDescr(string description)  //ref the child class desc
    {
        _actDescr = description;
    }

    public void SetTime()//do I want this in Main?
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _chosenDuration = int.Parse(Console.ReadLine());

    }

    private void Spinner(int time)
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

    private void GetReady()
    {
        Console.WriteLine("Get ready...");
        Spinner(4);
    }

    private void EndMsg()
    {
        Console.WriteLine($"Well done!!\n\nYou have completed another {_chosenDuration} seconds of the {_chosenActivity} Activity.");
        Spinner(4);
    }
}