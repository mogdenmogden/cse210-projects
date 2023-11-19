using System.Text;

public class AsciiText
{
    private string _upperCaseString; 
    private List<List<string>> _outputString;
    private Dictionary<string, List<string>> _alphaNumeric;
    private List<List<string>> _intermediateList = new List<List<string>>();
    
    public List<List<string>> MakeAsciiCharacters(string inputString)
    {
        _upperCaseString = inputString.ToUpper();
        char[] singleCharacters = _upperCaseString.ToCharArray();
        List<List<string>> intermediateList = new List<List<string>>();
        foreach (char i in singleCharacters) 
        {
            string j = i.ToString();
            intermediateList.Add(GetCharacterArt(j));            
         } 
        _intermediateList = intermediateList;
        return _intermediateList;
     } 

    public List<string> GetCharacterArt(string character)
    {
        List<string> theValue = _alphaNumeric[character];
        return theValue;
     } 

    public AsciiText(string stringIn)
    {
        Dictionary<string, List<string>> alphaNumeric = new Dictionary<string, List<string>>(); 
        
        alphaNumeric.Add("A", new List<string> { "░█▀▀▄","▒█▄▄█","▒█░▒█" });
        alphaNumeric.Add("B", new List<string> { "░▒█▀▀▄","░▒█▀▀▄","░▒█▄▄█" });
        alphaNumeric.Add("C", new List<string> { "░▒█▀▀▄","░▒█░░░","░▒█▄▄▀" });
        alphaNumeric.Add("D", new List<string> { "░▒█▀▀▄","░▒█░▒█","░▒█▄▄█" });
        alphaNumeric.Add("E", new List<string> { "░▒█▀▀▀","░▒█▀▀▀","░▒█▄▄▄" });
        alphaNumeric.Add("F", new List<string> { "░▒█▀▀▀","░▒█▀▀░","░▒█░░░" });
        alphaNumeric.Add("G", new List<string> { "░▒█▀▀█","░▒█░▄▄","░▒█▄▄▀" });
        alphaNumeric.Add("H", new List<string> { "░▒█░▒█","░▒█▀▀█","░▒█░▒█" });
        alphaNumeric.Add("I", new List<string> { "░▀█▀","░▒█░","░▄█▄" });
        alphaNumeric.Add("J", new List<string> { "░░░░▒█","░░░▒█","░▒█▄▄█" });
        alphaNumeric.Add("K", new List<string> { "░▒█░▄▀","░▒█▀▄░","░▒█░▒█" });
        alphaNumeric.Add("L", new List<string> { "░▒█░░░","░▒█░░░","░▒█▄▄█" });
        alphaNumeric.Add("M", new List<string> { "░▒█▀▄▀█","░▒█▒█▒█","░▒█░░▒█" });
        alphaNumeric.Add("N", new List<string> { "░▒█▄░▒█","░▒█▒█▒█","░▒█░░▀█" });
        alphaNumeric.Add("O", new List<string> { "░▒█▀▀▀█","░▒█░░▒█","░▒█▄▄▄█" });
        alphaNumeric.Add("P", new List<string> { "░▒█▀▀█","░▒█▄▄█","░▒█░░░" });
        alphaNumeric.Add("Q", new List<string> { "░▒█▀▀█","░▒█░▒█","░░▀▀█▄" });
        alphaNumeric.Add("R", new List<string> { "░▒█▀▀▄","░▒█▄▄▀","░▒█░▒█" });
        alphaNumeric.Add("S", new List<string> { "░▒█▀▀▀█","░░▀▀▀▄▄","░▒█▄▄▄█" });
        alphaNumeric.Add("T", new List<string> { "░▀▀█▀▀","░░▒█░░","░░▒█░░" });
        alphaNumeric.Add("U", new List<string> { "░▒█░▒█","░▒█░▒█","░░▀▄▄▀" });
        alphaNumeric.Add("V", new List<string> { "░▒█░░▒█","░░▒█▒█░","░░░▀▄▀░" });
        alphaNumeric.Add("W", new List<string> { "░▒█░░▒█","░▒█▒█▒█","░▒▀▄▀▄▀" });
        alphaNumeric.Add("X", new List<string> { "░▀▄░▄▀","░░▒█░░","░▄▀▒▀▄" });
        alphaNumeric.Add("Y", new List<string> { "░▒█░░▒█","░▒▀▄▄▄▀","░░░▒█░░" });
        alphaNumeric.Add("Z", new List<string> { "░▒█▀▀▀█","░░▄▄▄▀▀","░▒█▄▄▄█" });
        alphaNumeric.Add("0", new List<string> { "░█▀▀█","░█▄▀█","░█▄▄█" });
        alphaNumeric.Add("1", new List<string> { "░▄█░","░░█▒","░▄█▄" });
        alphaNumeric.Add("2", new List<string> { "░█▀█","░▒▄▀","░█▄▄" });
        alphaNumeric.Add("3", new List<string> { "░█▀▀█","░░▒▀▄","░█▄▄█" });
        alphaNumeric.Add("4", new List<string> { "░░█▀█░","░█▄▄█▄","░░░░█░" });
        alphaNumeric.Add("5", new List<string> { "░█▀▀","░▀▀▄","░▄▄▀" });
        alphaNumeric.Add("6", new List<string> { "░▄▀▀▄","░█▄▄░","░▀▄▄▀" });
        alphaNumeric.Add("7", new List<string> { "░▀▀▀█","░░░█░","░░▐▌░" });
        alphaNumeric.Add("8", new List<string> { "░▄▀▀▄","░▄▀▀▄","░▀▄▄▀" });
        alphaNumeric.Add("9", new List<string> { "░▄▀▀▄","░▀▄▄█","░░▄▄▀" });
        alphaNumeric.Add(" ", new List<string> { "░░","░░","░░" });
        alphaNumeric.Add(".", new List<string> { "░░░","░▄▄","░▀▀" });
        alphaNumeric.Add("!", new List<string> { "░█","░▀","░▄" });
        alphaNumeric.Add(":", new List<string> { "░▄","░░","░▀" });
        
        _alphaNumeric = alphaNumeric;
        _outputString = MakeAsciiCharacters(stringIn);
    } 

    public List<List<string>> GetOutput()
    {
        return _outputString;
    } 

    public void PrintAsciiStuff()
    {
        

        foreach (List<string> i in _outputString)
        {
            var bigCharacterT = i[0];
            Console.Write(bigCharacterT);
        }
            Console.WriteLine();
        foreach (List<string> i in _outputString)
        {
            var bigCharacterM = i[1];
            Console.Write(bigCharacterM);
        }
            Console.WriteLine();
        foreach (List<string> i in _outputString)
        {
            var bigCharacterB = i[2];
            Console.Write(bigCharacterB);
        }
            Console.WriteLine();


Console.WriteLine(); 
    }

 } 