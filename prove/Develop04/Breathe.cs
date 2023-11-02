public class Breathe : Activity
{
    private int _inhale;
    private int _exhale;

    public Breathe(string choiceA) : base(choiceA)
    {
        _inhale = 3;
        _exhale = 4;
    }

    public void RunBreathe() 
    {
        SetTime(); 
        GetEndTime(); 
        do
        {
            Console.Write($"Breathe in...  "); 
            CountDown(_inhale);
            Console.WriteLine();
            Console.Write($"Breathe out...  ");
            CountDown(_exhale);
            Console.WriteLine();
            Console.WriteLine();
            GetTimeNow();
        } while (_now < _endTime);
    }
}