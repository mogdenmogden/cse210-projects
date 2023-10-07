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
    public string DisplayThisEntry(string entry, string prompter)
    {
        /*Console.WriteLine($"{DateTime.Now.ToShortDateString()} - Prompt: {prompter}\n{entry}");*/
        _fullEntry = DateTime.Now.ToShortDateString()+" - Prompt: "+prompter+"\n"+entry;
        return _fullEntry;
    }

}