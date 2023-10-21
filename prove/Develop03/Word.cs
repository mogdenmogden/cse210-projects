public class Word
{
    private bool _displayedBool;
    private string _wordOut;
    private Word _wordMojo;
    
    public Word(string wordIn)
    {
        _wordOut = wordIn;
        _displayedBool = true;
    }
    public Word(string wordIn, bool boolIn)
    {
        _wordOut = wordIn;
        _displayedBool = boolIn;

    public Word MojoMaker()
    {
        Word _wordMojo = new Word(_wordOut,_displayedBool);
        return _wordMojo;
    }

    public string GetWord()
    {
        return _wordOut;
    }

    public void SetHidden(string toBeHidden)
    {
        int _wLength = toBeHidden.Length;//or I could get the length of the word and just repeat a mask char that many times to make a new _wordOut
        _wordOut = new string('-',_wLength);//do I want to push the mask to _wordOut or to return the mask to Scripture?        
    }

    public string GetHidden()
    {
        return _wordOut;
    }

}