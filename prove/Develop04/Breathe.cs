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
        SetTime(); //beginning time
        GetEndTime(); //end time calculation and to establish the ending time attribute
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
        } while (_now < _endTime);  //time right now vs the established end time
    }
}