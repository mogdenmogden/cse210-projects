public class Scripture
{
    private List<Word> _allWords;
    private string _verseRef;
    private string _phraseWords;
    private Word _theMagic;
    private string _oneWord;
    List<int> _itemsNowHidden = new List<int>();  //this will hold a list of hidden things
    private int _placeInLine;
    private bool _pickedAlready = true;
    private string[] _stringSeparated ;
    private int _hidePicker;
    
    public Scripture(string verseString,string wordsString)  //constructor
    {
        _verseRef = verseString;
        _phraseWords = wordsString;
        _allWords = new List<Word>();  //make the variable that will hold each single word array
        
        string[] _stringSeparated = _phraseWords.Split(' ');  //split it up into pieces

        int _phraseLength = _stringSeparated.Count(); //the _stringSeparated has this many words

        

          //put ints into the list. When the list length == _phraseLength then all words are hidden
        _placeInLine = 0;  //this is the sequence number of the word in the phrase
        
        foreach (string item in _stringSeparated)
        {
            
            _oneWord = item;  //this string can be processed by the Hide tool/method SetHidden and then fed to the process below
            //come up with a way to hide certain words with SetHidden
            
            do  //choose a word that hasn't been chosen before
            {
                Random random = new Random();
                int _hidePicker = random.Next(0,_phraseLength+1);
                if (_itemsNowHidden.Contains(_hidePicker) == true)  //check if this item# has already been masked
                {
                    _pickedAlready = true;
                }
                else
                {
                    _pickedAlready = false;
                    _itemsNowHidden.Add(_hidePicker); //if the word gets hidden, insert this in list

                }
            } while (_pickedAlready == true);
            

            Word intoWord = new Word(item);  //make a new instance of a Word object
            Word wordThing = intoWord.MojoMaker();  //make the Word object with str and bool
            _allWords.Add(wordThing);  //add it to the list of Word objects
            
            _placeInLine = _placeInLine++; //increase by one for the next word in the phrase
        }

    }

    public void DisplayScripture()
    {
        Console.Write(_verseRef+" ");
        // print the word, hidden or not

        foreach (Word item in _allWords)
        {
            Console.Write(item.GetWord()+" ");
        }
    }
    
    // private void HideAWord(string wordie)
    // {
    //     foreach (string item in _stringSeparated)
    //     {
            
    //         _oneWord = item;  //this string can be processed by the Hide tool/method SetHidden and then fed to the process below
    //         //come up with a way to hide certain words with SetHidden
            
    //         do  //choose a word that hasn't been chosen before
    //         {
    //             Random random = new Random();
    //             int _hidePicker = random.Next(0,_phraseLength+1);
    //             if (_pickedAlready = _itemsNowHidden.Contains(_hidePicker) == true)  //check if this item# has already been masked
    //             {
    //                 _pickedAlready = true;
    //             }
    //             else
    //             {
    //                 _pickedAlready = false;
    //                 _placeInLine = _hidePicker;
    //                 // _itemsNowHidden.Add(_placeInLine);
    //             }
    //         } while (_pickedAlready == true);
    // }
    

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