public class List : Activity
{
    private List<string> _prompts; 
    private List<string> _entries; 
    private List<string> _ignore; 
    // private Random _random;
    // private int _entryTally; 
    // private string _thisPrompt;
    private List<int> _pickTheseOne;
    private int _countDownSeconds;

    public List(string choiceA) : base(choiceA)
    {
        _countDownSeconds = 3;
        
        List<string> prompts = new List<string>();
        prompts.Add("Who are people that you appreciate?");
        prompts.Add("What are personal strengths of yours?");
        prompts.Add("Who are people that you have helped this week?");
        prompts.Add("When have you felt the Holy Ghost this month?");
        prompts.Add("Who are some of your personal heroes?");
        _prompts = prompts;

        List<string> ignore = new List<string>();
        ignore.Add("this is a placeholder");
        _ignore = ignore;
        
    }

    // private void SetPrompt(int pick) 
    // {
    //     _thisPrompt = _prompts[pick];
    // }

    // private string GetPrompt() 
    // {
    //     return _thisPrompt;
    // }

    private void InitializeEntries() //a list to keep the user entries in
    {
        List<string> entries = new List<string>();
        _entries = entries;
    }

    public void RunList()
    {
        InitializeEntries();
        _pickTheseOne = SetPicks(_prompts,_ignore);
        SetPrompt(_prompts,_pickTheseOne[0]);
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"\n --- {_thisPrompt} --- \n");
        Console.Write($"You may begin in...  "); 
        CountDown(_countDownSeconds);
        // Console.Clear();
        Console.WriteLine();
        SetTime();
        GetEndTime();

        do
        {
            Console.Write("> ");
            _entries.Add(Console.ReadLine());
            GetTimeNow();
        } while (_now < _endTime);
        Console.WriteLine($"You listed {_entries.Count} items!\n");
    }
}