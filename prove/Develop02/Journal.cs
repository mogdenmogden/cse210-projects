using System.Text;
using System.IO;

public class Journal
{
    public List<string> _theJournal = new List<string>();
    public string _inputFileName;

    
    public List<string> AddEntryToJournal(string jEntry)
    {
        _theJournal.Add(jEntry);
        return _theJournal;
    }
    
    public void ShowAllEntries(List<string> entries)
    {
        foreach (string thing in entries)
        {
            Console.WriteLine(thing);
            Console.WriteLine("");
        }
        Console.WriteLine("");
    }

    public void SaveFile(string filename)
    {
        if (filename != "")
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                StringBuilder concatJournal = new StringBuilder();
                foreach (string entry in _theJournal)
                {
                    outputFile.WriteLine(entry);
                    
                }
                outputFile.Write(concatJournal);
            } 
        }

    }

    public List<string> LoadFile(string filename)
    {
        /*load the file into a list, entry by entry*/
       string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            if (line != "") /*removes inadvertent blank lines*/
            {
                _theJournal.Add(line);
            }
        }
        return _theJournal;        
    }

}