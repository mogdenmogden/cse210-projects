public class Scripture
{
    private List<Word> _allWords;
    // private List<bool> _hidden;
    private string[] _phraseWords;
    private string _verseRef;
    // private List<bool> _hidden = new List<bool>();
    private Word _theMagic;
    

    public Scripture(string verseString,string wordsString)  //constructor
    {
        _verseRef = verseString;
        _allWords = new List<Word>();  //instantiate the variable that will hold each single word array
        string[] _phraseWords = wordsString.Split(" ");
        foreach (string oneWord in _phraseWords)
        {
            //Console.WriteLine(word);
            Word wordItem = new Word(oneWord);
            
            _theMagic = wordItem.MojoMaker();
            //put theMagic into a list
            // Console.WriteLine(_theMagic);
            _allWords.Add(_theMagic);
        }
        Console.WriteLine("end of scripture()");
        Console.WriteLine(_allWords.Count);
    }
    
    public void DisplayScripture()
    {
       Console.Write(_verseRef+" ");
       // print the word, hidden or not
       foreach (Word thingie in _allWords)
       {
        Console.Write(thingie+" ");
       }
    }

//     public void SetBoolList(List<string> verse)
//     {
//         // List<bool> _hidden = new List<bool>();
//         foreach (string word in verse)
//         {
//             _hidden.Add(false);
//         }
//         // Console.WriteLine(_hidden);
//     }

//     public List<bool> GetBoolList()
//     {
//         return _hidden;
//     }
//  public List<Word> RenewHiddenList()
//     {
//         return _allWords;
//     }
    
//     public void PrintCheckr(string text)
//     {
//         Console.WriteLine(text);
//     }
    // public void SetScripture(string wordsString)
    // {
    //     _allWords = wordsString.Split(" ").ToList();
    // }


}