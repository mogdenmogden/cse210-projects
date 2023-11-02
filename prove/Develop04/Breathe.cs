public class Breathe : Activity
{
    // private string _actName;
    // private string _actDescr;
    // private int _chosenDuration;
    private int _inhale;
    private int _exhale;

    public Breathe(string choiceA) : base(choiceA)
    {
        // _actName = "Breathing";
        // _actDescr = "This activity will help you relax by walking you thorugh breathing in and out slowly.\nClear your mind and focus on your breathing.";
        _inhale = 3;
        _exhale = 4;
        //_chosenDuration = GetTime();
    }

    public void RunBreathe() 
    {
        SetTime(); //Console.WriteLine(_beginNow);
        GetEndTime(); //Console.WriteLine(_endTime);
        do
        {
            Console.Write($"Breathe in...  "); 
            CountDown(_inhale);
            Console.WriteLine();
            Console.Write($"Breathe out...  ");
            CountDown(_exhale);
            Console.WriteLine();
            Console.WriteLine();
            //DateTime _theTime = DateTime.Now;
            GetTimeNow();
        } while (_now < _endTime);
    }
}