using System.Text;

public class Journal
{
    public List<string> _theJournal = new List<string>();
    public string _inputFileName;

    
    public void AddEntryToJournal(string jEntry)
    {
        _theJournal.Add(jEntry);

    }
    
    public void ShowAllEntries()
    {
        /*pick the selected entry from the list 
        and display it*/
        Console.WriteLine("");
    }

    public void SaveFile(string filename)
    {
        /*save the file here*/
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            StringBuilder concatJournal = new StringBuilder();
            foreach (string entry in _theJournal)
            {
                concatJournal.Append(entry);
                concatJournal.Append("|");
            }
            outputFile.WriteLine(concatJournal);
        } 

    }

    public List<string> LoadFile(string filename)
    {
        /*load the file into a list, entry by entry*/
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            _theJournal.Add(line);
        }
        return _theJournal;     
    }

}