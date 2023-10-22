public class Word
{
    private bool _displayedBool;
    private string _wordOut;
    
    public Word(string wordIn)
    {
        _wordOut = wordIn;
        _displayedBool = true;
        
    }
    public Word(string wordIn, bool boolIn)
    {
        _wordOut = wordIn;
        _displayedBool = boolIn;
        
    }

    public string Hide(string toBeHidden)
    {
        int _wLength = toBeHidden.Length;//or I could get the length of the word and just repeat a mask char that many times to make a new _wordOut
        _wordOut = new string('-',_wLength);
        return _wordOut;
    }

    public string Show()
    {
        return _wordOut;
    }

    public bool IsHidden()
    {
        _displayedBool = false;
        return _displayedBool;
    }

    public string GetWord()
    {
        return _wordOut;
    }

}