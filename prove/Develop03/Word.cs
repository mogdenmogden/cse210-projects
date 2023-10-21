public class Word
{
    private bool _displayedBool;
    private string _wordOut;
    private Word _wordMojo;
    
    public Word(string wordIn)
    {
        _wordOut = wordIn;
        _displayedBool = true;
        // Word _wordMojo = new Word(_wordOut,_displayedBool);
    }
    public Word(string wordIn, bool boolIn)
    {
        _wordOut = wordIn;
        _displayedBool = boolIn;
        // Word _wordMojo = new Word(_wordOut,_displayedBool); //caused stackoverflow error
    }

    public Word MojoMaker()
    {
        Word _wordMojo = new Word(_wordOut,_displayedBool);
        return _wordMojo;
    }

    public string GetWord()
    {
        return _wordOut;
    }


}