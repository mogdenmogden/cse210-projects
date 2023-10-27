public class Breathe : Activity
{
    private string _actName;
    private string _actDescr;
    private int _chosenDuration;

    public Breathe(string choiceA) : base(choiceA)
    {
        _actName = "Breathing";
        _actDescr = "This activity will help you relax by walking you thorugh breathing in an dout slowly.\nClear your mind and focus on your breathing.";
        _chosenDuration = GetTime();
    }

    public void PromptBreathing(int inhale, int exhale) 
    {
        do
        {
            Console.Write($"Breathe in...{inhale}\b"); 
            Spinner(inhale);
            Console.WriteLine();
            Console.Write($"Breathe out...{exhale}\b");
            Spinner(exhale);
            Thread.Sleep(1000);Console.WriteLine($"{_chosenDuration}\b");
            _chosenDuration--;
        } while (_chosenDuration > 0);

    }
}