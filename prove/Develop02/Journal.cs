using System.Text;
using System.IO;

public class Journal
{
    public List<string> _theJournal = new List<string>();
    public string _inputFileName;
    public string _betterName;

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
    public bool CheckBadFile(string filename)
    {
        if (filename != "" && filename != null)
        {
            if (File.Exists(filename))
            {
                return true;
            }
        }
        return false;
    }
    public string ReEnterFileName()
    {
        _betterName = " ";
        Console.WriteLine("That file name needs revising. Please re-enter something like \"MyJournal.txt\". ");
        _betterName = Console.ReadLine();
        do
        {
            if (_betterName != null)
            {
                if (_betterName != " ")
                {
                    if (_betterName != "")
                    {
                        Console.WriteLine($"better name is {_betterName}");
                        /*make a new file, if one doesn't exit with the given name*/
                        FileStream file = File.Create(_betterName);
                        file.Close();
                        return _betterName;
                    }
                }
            }  
            else 
            {
                _betterName = " ";
            }
        } while (_betterName == " ");
        return _betterName;
    }
}