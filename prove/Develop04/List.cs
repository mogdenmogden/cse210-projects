public class List : Activity
{
    private List<string> _prompts; 
    private List<string> _entries; 
    private List<string> _ignore; 
    private List<int> _chosen;
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

        List<string> ignore = new List<string>();  //this is a list<string> to use as a placeholder in SetPicks()
        ignore.Add("this is a placeholder");
        _ignore = ignore;                           //name chosen purposefully, so the dev doesn't get hung up on it
        
    }

    private void InitializeEntries() //a list to keep the user entries in, to be used later for count and display
    {
        List<string> entries = new List<string>();
        _entries = entries;
    }

    public void RunList()
    {
        InitializeEntries();
        _chosen = SetPicks(_prompts,_ignore);  //pick one thing from the prompt list. Don't need a second list except as a placeholder for SetPicks()
        SetPrompt(_prompts,_chosen[0]);         //choose one prompt from the list
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"\n --- {_thisPrompt} --- \n");
        Console.Write($"You may begin in...  "); 
        CountDown(_countDownSeconds);
        // Console.Clear();
        Console.WriteLine();
        SetTime();  //beginning time
        GetEndTime();  //end time calculation and to establish the ending time attribute

        do
        {
            Console.Write("> ");
            _entries.Add(Console.ReadLine());
            GetTimeNow();
        } while (_now < _endTime);
        Console.WriteLine($"You listed {_entries.Count} items!\n");
        Console.WriteLine($"Here are the entries you made: ");
        foreach (string item in _entries)
        {
            if (item == _entries[_entries.Count-1])  //no comma on the last entry in the list
            {
                Console.Write($"{item} \n");
            }
            else
            {
                Console.Write($"{item}, ");
            }
        }
        Console.WriteLine();
    }
}