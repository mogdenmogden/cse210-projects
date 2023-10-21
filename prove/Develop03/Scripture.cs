public class Scripture
{
    private List<Word> _allWords;
    private string _verseRef;
    private string _phraseWords;
    private Word _theMagic;
    private string _oneWord;
    
    public Scripture(string verseString,string wordsString)  //constructor
    {
        _verseRef = verseString;
        _phraseWords = wordsString;
        _allWords = new List<Word>();  //instantiate the variable that will hold each single word array
        
        string[] stringSeparated = _phraseWords.Split(' ');
        foreach (string item in stringSeparated)
        {
            _oneWord = item;
            Word intoWord = new Word(item);
            Word wordThing = intoWord.MojoMaker();
            _allWords.Add(wordThing);
        }

    }

    public string GetRenderedText()
    {
        return _oneWord;
    }

    // public void SeparateWords()
    // {
    //     string[] holder = _phraseWords.Split(' ');
    //     foreach (string item in holder)
    //     {
    //         Word wordItem = new Word(item);
    //         _theMagic = wordItem.MojoMaker();
    //         _allWords.Add(_theMagic);
    //     }
    //     Console.WriteLine("separated");
    //     Console.WriteLine(_allWords.Count);
        
    // }

    public void DisplayScripture()
    {
       Console.Write(_verseRef+" ");
       // print the word, hidden or not
       
       foreach (Word item in _allWords)
       {
        // Word wordy = new Word(item);
        Console.Write(item.GetWord()+" ");
        
        //Console.Write(item+"* ");

       }


    }
    
    public void HideWords(Word list)
    {
        foreach (Word item in _allWords)
        {
            break;
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