using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        /*THIS IS THE JOURNAL PROGRAM*/
        WritingPrompts aPrompt = new WritingPrompts();
        Entry todayEntry = new Entry();
        string pickOne; 
        string todayPrompt = "";
        string enteredText;
        Journal activeJournal = new Journal();
        string journalFile;

        Console.WriteLine("");
        Console.WriteLine("Welcome to the Journal Program!");
        Console.Write("What is the name of your personal journal file? (Example: MyJournal.txt) ");
        journalFile = Console.ReadLine();
        if (File.Exists(journalFile))
        {
            activeJournal.LoadFile(journalFile);
        }
        else 
        {
            /*make a new file if one doesn't exit with the given name*/
            FileStream file = File.Create(journalFile);
            file.Close();
        }

        do 
        { 
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("[1] Write");
            Console.WriteLine("[2] Display");
            Console.WriteLine("[3] Load");
            Console.WriteLine("[4] Save");
            Console.WriteLine("[0] Quit");
            Console.Write("What would you like to do? ");
            pickOne = Console.ReadLine();
 
            //WRITE THE IF STATEMENT HERE
            //AFTER TESTING EACH CLASS IN THE MENU
            if (pickOne == "1")
            {
                Console.WriteLine($"{pickOne}");
                string entryOut;
                todayPrompt = aPrompt.PickAPrompt();
                enteredText = todayEntry.GetJournalEntry();
                Console.WriteLine("");
                entryOut = todayEntry.DisplayThisEntry(enteredText, todayPrompt);
                Console.WriteLine(entryOut);
                activeJournal.AddEntryToJournal(entryOut);
                Console.WriteLine("");
            }
            else if (pickOne == "2")
            {
                Console.WriteLine($"{pickOne}");
                Console.WriteLine(activeJournal);
                Console.WriteLine();
            }
            else if (pickOne == "3")
            {
                Console.WriteLine($"{pickOne}");
                activeJournal.LoadFile(journalFile);
            }
            else if (pickOne == "4")
            {
                Console.WriteLine($"{pickOne}");
                activeJournal.SaveFile(journalFile);
            }
            else
            {
                Console.WriteLine($"{pickOne}");
                activeJournal.SaveFile(journalFile);
            }

            /*Console.WriteLine("testing WriteEntry");
            string todayPrompt = aPrompt.PickAPrompt();
            string enteredText = todayEntry.GetJournalEntry();*/





            /*Console.WriteLine();
            Console.WriteLine("testing DisplayThisEntry");
            todayEntry.DisplayThisEntry(enteredText, todayPrompt);
            Console.WriteLine();*/

        } while (pickOne != "0");
        Console.WriteLine("");
    }
}