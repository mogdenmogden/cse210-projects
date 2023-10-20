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

    public Word MojoMaker()
    {
        Word _wordMojo = new Word(_wordOut,_displayedBool);
        return _wordMojo;
    }

    private void Show()
    {

    }


}