using System.Xml;

public class Activity
{
    private string _chosenActivity;
    private int _chosenDuration;
    private string _activDesc;
    private string _startMsg;
    protected DateTime _beginNow;
    protected DateTime _endTime;
    private int _timedown;
    private int _spinTimeSoFar; 
    protected DateTime _now;
    protected string _thisPrompt;
    protected int _spinSeconds = 2;

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

    private void SetStartMsg(string choice)  //set up the start message with activity name and the description
    {
        string startMsg = $"Welcome to the "+choice+" Activity.\n\n"+_activDesc;
        _startMsg = startMsg;
    }

    private void GetStartMsg()  //display the whole start message and prompt for duration
    {
        Console.WriteLine(_startMsg);
        Console.Write("\nHow long, in seconds, would you like for your session?  ");
        _chosenDuration = int.Parse(Console.ReadLine());
    }

    protected void SetTime()
    {
        _beginNow = DateTime.Now;
        
    }
    protected DateTime GetEndTime()
    {
        _endTime =  _beginNow.AddSeconds(_chosenDuration);
        return _endTime;
    }

    protected void GetTimeNow()
    {
        _now = DateTime.Now;
    }

    protected void Spin(int time)  //a spinning bar
    {
        int _spintime = time*1000;
        
        _spinTimeSoFar = 0;
        int increment = 100;
        do 
        {
            Console.Write("- ");        Thread.Sleep(increment);    _spinTimeSoFar =_spinTimeSoFar+increment;
            Console.Write("\b\b\\ ");   Thread.Sleep(increment);    _spinTimeSoFar =_spinTimeSoFar+increment;
            Console.Write("\b\b| ");    Thread.Sleep(increment);    _spinTimeSoFar =_spinTimeSoFar+increment;
            Console.Write("\b\b/ ");    Thread.Sleep(increment);    _spinTimeSoFar =_spinTimeSoFar+increment;
            Console.Write("\b\b");
        } while (_spinTimeSoFar <= time*1000);
        Console.Write(" ");
        Console.WriteLine();

    }

    public void WriteReadyMsg()  //get ready to go
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        Spin(_spinSeconds);
    }

    public void WriteEndMsg()  //displays the ending messages
    {
        Console.WriteLine($"Well done!!");
        Spin(_spinSeconds);
        Console.WriteLine($"You spent {_chosenDuration} seconds practicing mindfulness using the {_chosenActivity} Activity.");
        Spin(_spinSeconds);
    }

    protected void CountDown(int seconds) //the timer counting down ...4  ...3  etc.
    {
        _timedown = seconds;
        do
        {
            Console.Write("\b\b");
            Console.Write($"{_timedown} ");
            Thread.Sleep(1000);
            _timedown--;
        } while (_timedown >= 1);
        Console.Write("\b\b ");
    }

    protected List<int> SetPicks(List<string> reflections, List<string> questions) //choose two things from two lists using a list of two ints
    {
        Random picker = new Random();
        List<int> choices = new List<int>();
        choices.Add(picker.Next(0,reflections.Count));
        choices.Add(picker.Next(0,questions.Count));
        return choices;
    }

    protected void SetPrompt(List<string> list, int pick) //choose one thing from one list
    {
        _thisPrompt = list[pick];
    }

}