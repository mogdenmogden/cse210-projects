public class Entry
{
    // public List<string> _promptList;
    // public int _randomNumber;
    public string _rightNowDt;
    
    public string _theEntry;
    public string _fullEntry;
    

    public string GetJournalEntry()
    {
        Console.Write("Begin writing here: ");
        string _theEntry = Console.ReadLine();
        return _theEntry;
    }
    public string prepOneEntry(string entry, string prompter)
    {
        _fullEntry = DateTime.Now.ToShortDateString()+" - Prompt: "+prompter+" |"+entry;
        return _fullEntry;
    }

}