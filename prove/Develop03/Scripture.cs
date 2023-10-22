public class Scripture
{
    private List<Word> _allWords;
    private string _verseRef;
    private string _phraseWords;
    private string _phraseOut;
    private int _phraseLength = 0;
    List<int> _itemsNowHidden = new List<int>();  //this will hold a list of hidden things
    public string[] _stringSeparated;
    private string _newString;
    private int _rand1;
    private int _rand2;
    private int _rand3;
    private Random random = new Random();
    private bool hideMe;
    private string _masked;
    private string _unmasked;
    
    public Scripture(string verseString,string wordsString)  //constructor
    {
        _verseRef = verseString;
        _phraseWords = wordsString;
        _allWords = new List<Word>();  //make the variable that will hold each single word array
        
        _stringSeparated = _phraseWords.Split(' ');  //split it up into pieces
        _phraseLength = _stringSeparated.Length; //the _stringSeparated has this many words
        _newString = "";
    }

    public string HideWords(string word) //put in a word and true to hide the word
    {
        bool yesHide = true;
        Word hideMe = new Word(word,yesHide);
        hideMe.Hide(word);
        string hidWord = hideMe.Show();
        return hidWord;
    }

    public string[] GetStrSep()
    {
        return _stringSeparated;
    }

    public void SetStrSep(string phrase)
    {
        string[] _stringSeparated = phrase.Split(' ');  //split it up into pieces
    }

    public string GetRenderedText() // put in _stringSeparated
    {
        //_phraseLength = _stringSeparated.Count(); //the _stringSeparated has this many words
        PickThreeNumbers();
        //Console.WriteLine(_rand1+" "+_rand2+" "+_rand3);
        _newString = "";
        int startCounting = 1;
        string[] _stringSeparated = _phraseWords.Split(' ');  //split it up into pieces
        
        string[] _redoString = _stringSeparated;  
        do
        {
            foreach (string j in _redoString)
            {
                if (startCounting == _rand1 || startCounting == _rand2 || startCounting == _rand3)  //true means hide this word, it's not already hidden
                {
                    hideMe = true;
                }
                else
                {
                    hideMe = false;
                }
                if (hideMe == true)
                {
                    Word intoWord = new Word(j,hideMe);  //make a new instance of a Word object
                    intoWord.Hide(j);
                    _masked = intoWord.Show();
                    _newString = _newString+" "+_masked;
                }
                else 
                {
                    Word intoWord = new Word(j);  //make a new instance of a Word object
                    _unmasked = intoWord.Show();
                    _newString = _newString+" "+_unmasked;
                }
                
                startCounting++;
            }
        } while (startCounting <= _phraseLength);
        Console.WriteLine(_verseRef+_newString);
        return _newString;
        
    }

    private void PickThreeNumbers()
    {
        do //first
        {
            _rand1 = random.Next(1,_phraseLength+1);
        }
        while (_itemsNowHidden.Contains(_rand1) == true );
        _itemsNowHidden.Add(_rand1);

         do //second
        {
            _rand2 = random.Next(1,_phraseLength+1);
        }
        while (_itemsNowHidden.Contains(_rand2) == true || _rand2 == _rand1 );
        _itemsNowHidden.Add(_rand2);

         do //third
        {
            _rand3 = random.Next(1,_phraseLength+1);
        }
        while (_itemsNowHidden.Contains(_rand3) == true || _rand3 == _rand1 || _rand3 == _rand2 );
        _itemsNowHidden.Add(_rand3);
        
    }

/*=======================================================================================*/
    public void DisplayScripture()
    {
        Console.Write(_verseRef+" ");
        // print the word, hidden or not

        foreach (Word item in _allWords)
        {
            Console.Write(item.GetWord()+" ");
            _phraseOut = _phraseOut+" "+item.GetWord();
        }
    }

}