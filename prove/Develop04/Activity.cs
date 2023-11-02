using System.Xml;

public class Activity
{
    private string _chosenActivity;
    private int _chosenDuration;
    // private string _activName;
    private string _activDesc;
    private string _startMsg;
    // private string _getReady;
    protected DateTime _beginNow;
    protected DateTime _endTime;
    private int _timedown;
    private int _spinTimeSoFar; 
    protected DateTime _now;


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
        
        Console.Clear();
        SetStartMsg(_chosenActivity); 
        GetStartMsg(); 
        
    }

    private void SetStartMsg(string choice)
    {
        string startMsg = $"Welcome to the "+choice+" Activity.\n\n"+_activDesc;
        _startMsg = startMsg;
    }

    private void GetStartMsg()
    {
        Console.WriteLine(_startMsg);
        Console.Write("How long, in seconds, would you like for your session?  ");
        _chosenDuration = int.Parse(Console.ReadLine());
    }

    public void SetTime()
    {
        _beginNow = DateTime.Now;
        
    }
    public DateTime GetEndTime()
    {
        _endTime =  _beginNow.AddSeconds(_chosenDuration);
        return _endTime;
    }

    public void GetTimeNow()
    {
        _now = DateTime.Now;
    }

    public void Spin(int time)
    {
        int _spintime = time*1000;
        
        _spinTimeSoFar = 0;
        int increment = 100;
        do 
        {
            Console.Write("- "); Thread.Sleep(increment); _spinTimeSoFar =_spinTimeSoFar+increment;
            Console.Write("\b\b\\ "); Thread.Sleep(increment); _spinTimeSoFar =_spinTimeSoFar+increment;
            Console.Write("\b\b| "); Thread.Sleep(increment); _spinTimeSoFar =_spinTimeSoFar+increment;
            Console.Write("\b\b/ "); Thread.Sleep(increment); _spinTimeSoFar =_spinTimeSoFar+increment;
            Console.Write("\b\b");
        } while (_spinTimeSoFar <= time*1000);
        Console.Write(" ");
        Console.WriteLine();

    }

    public void ReadyMsg()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        Spin(3);
    }

    public void EndMsg()
    {
        Console.WriteLine($"Well done!!");
        Spin(3);
        Console.WriteLine($"You spent {_chosenDuration} seconds practicing mindfulness using the {_chosenActivity} Activity.");
        Spin(3);
    }

    public void CountDown(int seconds)
    {
        _timedown = seconds;
        do
        {
            Console.Write("\b\b");
            Console.Write($"{_timedown} ");
            Thread.Sleep(1000);
            _timedown--;
        } while (_timedown >= 0);
        Console.Write("\b\b ");
    }

    protected List<int> SetPicks(List<string> reflections, List<string> questions)
    {
        Random picker = new Random();
        List<int> choices = new List<int>();
        choices.Add(picker.Next(0,reflections.Count));
        choices.Add(picker.Next(0,questions.Count));
        return choices;
    }

}