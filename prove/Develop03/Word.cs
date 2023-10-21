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

    public Word SetHidden(string toBeHidden)
    {
        // foreach (char letter in toBeHidden)//I could loop through the letters and mask each one
        // {

        // }
        int _wLength = toBeHidden.Count();//or I could get the length of the word and just repeat a mask char that many times to make a new _wordOut
        _wordOut = new string('-',_wLength);//do I want to push the mask to _wordOut or to return the mask to Scripture?
        
        Word _hideThis = new Word(_wordOut);//pushes the masked word through the constructor

        return _hideThis;
    }

}