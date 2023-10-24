public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string name, string topic, string section, string probs ) : base(name,topic)
    {
        _textbookSection = section;
        _problems = probs;
        
    }

    public string GetHomeWorkList()
    {
        return _textbookSection+"  "+_problems;
    }
}