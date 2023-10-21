public class Scripture
{
    private List<Word> _allWords;
    private string _verseRef;
    private string _phraseWords;
    private string _phraseOut;
    //private Word _theMagic;
    //private string _oneWord;
    private int _phraseLength;
    List<int> _itemsNowHidden = new List<int>();  //this will hold a list of hidden things
    private static int _startHere = 0;
    private int _placeInLine = 0;
    //private bool _pickedAlready = true;
    // private string[] _stringSeparated ;
    // private int _hidePicker;
    private int _rand1;
    private int _rand2;
    private int _rand3;
    private bool _hideIt;
    private Random random = new Random();
    
    public Scripture(string verseString,string wordsString)  //constructor
    {
        _verseRef = verseString;
        _phraseWords = wordsString;
        _allWords = new List<Word>();  //make the variable that will hold each single word array
        

        string[] _stringSeparated = _phraseWords.Split(' ');  //split it up into pieces

        _phraseLength = _stringSeparated.Count(); //the _stringSeparated has this many words
        
        PickThreeNumbers();
        // Console.WriteLine(_rand1+" "+_rand2+" "+_rand3);
        
        _startHere++;
        //int _placeInLine = 0;  //this is the sequence number of the word in the phrase
        //put ints into the list. When the _itemsNowHidden length == _phraseLength then all words are hidden
        foreach (string item in _stringSeparated)
        {
            this._placeInLine = _startHere;
            //_placeInLine = _placeInLine++; //increase by one for the next word in the phrase
            //string _masked;
            //_oneWord = item;  //this string can be processed by the Hide tool/method SetHidden and then fed to the process below
            
            //choose a word that hasn't been chosen before
            
            if (_placeInLine == _rand1 || _placeInLine == _rand2 || _placeInLine == _rand3)  //true means hide this word, it's not already hidden
            {
                //Console.WriteLine("should hide "+item);
                Word intoWord = new Word(item);  //make a new instance of a Word object
                intoWord.SetHidden(item);
                Word wordThing = intoWord.MojoMaker();  //make the Word object with str and bool that are already in Word class
                _allWords.Add(wordThing);  //add it to the list of Word objects
            }
            else
            {
                Word intoWord = new Word(item);  //make a new instance of a Word object
                Word wordThing = intoWord.MojoMaker();  //make the Word object with str and bool that are already in Word class
                _allWords.Add(wordThing);  //add it to the list of Word objects
            }
            _startHere++;
        }

    }

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

    public string fraseOut()
    {
        return _phraseOut;
    }
    
    private bool ShouldIHideThisWord(int checkit)  //choose a word that hasn't been chosen before
    {
        // Random random = new Random();
        // int _hidePicker = random.Next(0,_phraseLength+1);
        if (_itemsNowHidden.Contains(checkit) == true)  //check if this item# has already been masked
        {
            _hideIt = false;
        }
        else
        {
            _itemsNowHidden.Add(checkit); //if the word gets hidden, insert this in list
            _hideIt = true;
            
        }
        return _hideIt;  //returns false if the word should be picked for masking
    }
    
    private void PickThreeNumbers()
    {
        do //first
        {
            _rand1 = random.Next(1,_phraseLength+1);
        }
        while (_itemsNowHidden.Contains(_rand1) == true );

         do //second
        {
            _rand2 = random.Next(1,_phraseLength+1);
        }
        while (_itemsNowHidden.Contains(_rand2) == true || _rand2 == _rand1 );

         do //third
        {
            _rand3 = random.Next(1,_phraseLength+1);
        }
        while (_itemsNowHidden.Contains(_rand3) == true || _rand3 == _rand1 || _rand3 == _rand2 );
    }

    public int Placement
    {
        get { return _placeInLine; }
    }


}