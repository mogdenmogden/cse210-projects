using System.Xml;

public class Activity
{
    private string _chosenActivity;
    private int _chosenDuration;
    // private string _activName;
    private string _activDesc;
    private string _startMsg;
    // private string _getReady;
    private int _totTime;
    private int timedown;

    public Activity(string choice)
    {
        _chosenActivity = choice;
        switch(choice)
        {
            case "1":
                _chosenActivity = "Breathing";
                _activDesc = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
                break;
            case "2":
                _chosenActivity = "Reflecting";
                _activDesc = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                break;
            case "3":
                _chosenActivity = "Listing";
                _activDesc = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                break;
            default: 
                break;
        }
        
        SetStartMsg(_chosenActivity);
        GetStartMsg();
        SetTime();
        
    }

    private void SetStartMsg(string choice)
    {
        string _startMsg = "Welcome to the "+choice+" Activity.\n"+_activDesc;
    }

    private void GetStartMsg()
    {
        Console.WriteLine(_startMsg);
    }

    public void SetTime()
    {
        Console.Write("How long, in seconds, would you like for your session?  ");
        _chosenDuration = int.Parse(Console.ReadLine());
    }
    public int GetTime()
    {
        return _chosenDuration;
    }



    public void Spin(int time)
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
        Console.Clear();
        Console.WriteLine("Get ready...");
        Spin(4);
    }

    public void EndMsg()
    {
        Console.WriteLine($"\nWell done!!");
        Spin(4);
        Console.WriteLine($"\nYou have spent {_chosenDuration} seconds practising mindfulness using the {_chosenActivity} Activity.\n");
        Spin(4);
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