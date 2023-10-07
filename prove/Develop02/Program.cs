using System;
using System.ComponentModel.Design;
using System.Data;
using System.IO;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        /*THIS IS THE JOURNAL PROGRAM*/
        WritingPrompts aPrompt = new WritingPrompts();
        Entry todayEntry = new Entry();
        Journal activeJournal = new Journal();
        /*List<string> journalInMemory = new List<string>();*/
        string pickOne; 
        string todayPrompt = "";
        string enteredText;
        string journalFile = "";
        bool checkIt;
        
        Console.WriteLine("");
        Console.WriteLine("Welcome to the Journal Program!");
        
        /*pre-load an existing journal or create a new one
        if the file name that gets entered is wonky, we reprompt for a new one*/
        Console.WriteLine("What is the name of your personal journal file? (Example: MyJournal.txt) ");
        Console.Write("If you don't have one, enter a name for a new journal. ");
        journalFile = Console.ReadLine();
        checkIt = false;
        do 
        {
            if (activeJournal.CheckBadFile(journalFile) is true)
            {
                activeJournal.LoadFile(journalFile); /*load the file if it already exists*/
                checkIt = true;
            }
            else /*re-prompt for a good filename ending in .txt*/
            {
                do
                {
                    journalFile = activeJournal.ReEnterFileName();
                    Console.WriteLine(journalFile);
                    checkIt = activeJournal.CheckBadFile(journalFile);
                    Console.WriteLine($"checkIt is now {checkIt}");
                } while (checkIt is false);
            }
        } while (checkIt is false);

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
                string entryOut;
                todayPrompt = aPrompt.PickAPrompt(); /*get a prompt*/
                enteredText = todayEntry.GetJournalEntry(); /*put some stuff in a new Entry named todayEntry*/
                Console.WriteLine("");
                entryOut = todayEntry.prepOneEntry(enteredText, todayPrompt);/*puts the todayPrompt and enteredText together */
                /*journalInMemory = activeJournal.AddEntryToJournal(entryOut);Adds the whole entryOut to the Journal*/
                activeJournal.AddEntryToJournal(entryOut);
                
            }
            else if (pickOne == "2")
            {
                foreach (string j in activeJournal._theJournal)
                {
                    if (j != "") /*prevents error when blank lines are found in the txt file*/
                    {
                        string[] part = j.Split("|");
                        Console.WriteLine(part[0]);
                        Console.WriteLine(part[1]);
                        Console.WriteLine();
                    }
                }
                
            }
            else if (pickOne == "3")
            {
                Console.Write("What is the name of your journal file? (Ex: MyJournal.txt) > ");
                journalFile = Console.ReadLine();
                if (activeJournal.CheckBadFile(journalFile) is true)
                {
                    /*journalInMemory = activeJournal.LoadFile(journalFile);*/
                    activeJournal.LoadFile(journalFile);
                }
                Console.WriteLine();
            }
            else if (pickOne == "4")
            {
                if (journalFile != " ")
                {
                    Console.Write($"Would you like to save in {journalFile}? (Y/N) "); /*option to save entries in a new file*/
                    string newOne = Console.ReadLine().ToUpper();
                    Console.WriteLine(newOne);
                    if (newOne == "N")
                    {
                        Console.Write("Enter a new file name (Example: MyJournal.txt) ");
                        journalFile = Console.ReadLine();
                    }
                }
                else
                {
                    while (journalFile == " ") 
                    {
                        Console.Write("What file name will you use for your journal file? (Example: MyJournal.txt) ");
                        journalFile = Console.ReadLine();   
                        if (journalFile == " ")
                        {
                            Console.WriteLine("Please try again.");
                        }
                    }
                }
                activeJournal.SaveFile(journalFile);
                Console.WriteLine($"{journalFile} saved.");
                Console.WriteLine();
            }
            else
            {
                activeJournal.SaveFile(journalFile);
                Console.WriteLine();
            }
        } while (pickOne != "0");
        Console.WriteLine("");
    }
}