public class Scripture
{
    private List<Word> _words = new List<Word>();
    // private List<bool> _hidden;
    private string[] _phraseWords;
    private string _verseRef;
    private List<bool> _hidden = new List<bool>();
    private Word _theMagic;
    

    public Scripture(string verseString,string wordsString)  //constructor
    {
        _verseRef = verseString;
        _phraseWords = wordsString.Split(" ");
        foreach (string singleWord in _phraseWords)
        {
            //Console.WriteLine(word);
            Word wordArray = new Word(singleWord);
            _theMagic = wordArray.MojoMaker();
            //put theMagic into a list
            Console.WriteLine(_theMagic);
            _words.Add(_theMagic)
        }
        
    }
    
    public void DisplayScripture()
    {
        // print the word, hidden or not
        foreach (thingie in _words)
        {
            if (thingie[1] = false)
        }
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