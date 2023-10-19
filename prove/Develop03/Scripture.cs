public class Scripture
{
    private List<string> _words;
    private List<bool> _hidden;
    
    public Scripture(string wordsString)
    {
        _words = wordsString.Split(" ").ToList();
    }

    public List<string> GetScripture()
    {
        return _words;
    }

    public void SetBoolList(List<string> verse)
    {
        foreach (string word in verse)
        {
            _hidden.Add(false);
        }
        Console.WriteLine(_hidden);
        Console.WriteLine(verse);
    }

    public List<bool> GetBoolList()
    {
        return _hidden;
    }
 public List<string> RenewHiddenList()
    {
        return _words;
    }
    
}