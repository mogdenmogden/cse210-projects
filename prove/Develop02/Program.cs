using System;
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
        List<string> journalInMemory = new List<string>();
        string pickOne; 
        string todayPrompt = "";
        string enteredText;
        string journalFile = "";

        Console.WriteLine("");
        Console.WriteLine("Welcome to the Journal Program!");

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
                entryOut = todayEntry.DisplayThisEntry(enteredText, todayPrompt);/*puts the todayPrompt and enteredText together AND PRINTS IT*/
                journalInMemory = activeJournal.AddEntryToJournal(entryOut);/*Adds the whole entryOut to the Journal*/
                Console.WriteLine("");
            }
            else if (pickOne == "2")
            {
                foreach (string j in journalInMemory)
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
                if (journalFile != "")
                {
                    journalInMemory = activeJournal.LoadFile(journalFile);
                }
            }
            else if (pickOne == "4")
            {
                if (journalFile != " ")
                {
                    Console.Write($"Would you like to save in {journalFile}? (Y/N) "); /*option to save entries in a new file*/
                    string newFile = Console.ReadLine();
                    if (newFile.ToUpper() == "Y")
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