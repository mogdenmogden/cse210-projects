public class Scripture
{
    private List<string> _words = new List<string>();
    // private List<bool> _hidden;
    
    private List<bool> _hidden = new List<bool>();
    
    public Scripture(string wordsString)  //constructor
    {
        _words = wordsString.Split(" ").ToList();
        // foreach (string word in _words)
        // {
        //     Console.WriteLine(word);
        // }

    }
    
    public List<string> GetScripture()
    {
        // foreach (string word in _words)
        // {
        //     Console.WriteLine(word);
        // }
        return _words;
    }

    public void SetBoolList(List<string> verse)
    {
        // List<bool> _hidden = new List<bool>();
        foreach (string word in verse)
        {
            _hidden.Add(false);
        }
        // Console.WriteLine(_hidden);
    }

    public List<bool> GetBoolList()
    {
        return _hidden;
    }
 public List<string> RenewHiddenList()
    {
        return _words;
    }
    
    public void PrintCheckr(string text)
    {
        Console.WriteLine(text);
    }
    // public void SetScripture(string wordsString)
    // {
    //     _words = wordsString.Split(" ").ToList();
    // }


}