using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        List<string> vsLibrary = new List<string>() {
        "4 Nephi|1|15|And it came to pass that there was no contention in the land, because of the love of God which did dwell in the hearts of the people."
        ,"John 13:34|A new commandment I give unto you, That ye love one another; as I have loved you, that ye also love one another."
        ,"Galatians|5|13|14|For, brethren, ye have been called unto liberty; only use not liberty for an occasion to the flesh, but by love serve one another. For all the law is fulfilled in one word, even in this; Thou shalt love thy neighbour as thyself."
        };  
        string bk, ch, vsNum1, vsNumN, workingVerse, onlyRef, printMe;
        List<string> partList;
        Random random = new Random();
        int randPickVs = random.Next(1,1+vsLibrary.Count)-1;
        string fullRef = vsLibrary[randPickVs];
        List<bool> hideBool;
        List<string> hiddenWords;
        
        
        // Console.WriteLine(fullRef);
        
        partList = fullRef.Split("|").ToList();

        if (partList.Count == 5)
        {
            bk = partList[0];
            ch = partList[1];
            vsNum1 = partList[2];
            vsNumN = partList[3];
            workingVerse = partList[4];
            Reference refPart = new Reference(bk,ch,vsNum1,vsNumN);
            onlyRef = refPart.GetRf();
        }
        else if (partList.Count == 4) 
        {
            bk = partList[0];
            ch = partList[1];
            vsNum1 = partList[2];
            vsNumN = "";
            workingVerse = partList[3];
            Reference refPart = new Reference(bk,ch,vsNum1);
            onlyRef = refPart.GetRf();
        }
        else
        {
            onlyRef = partList[0];
            workingVerse = partList[1];
        }

        Console.WriteLine(onlyRef+" "+workingVerse);
        
        Scripture hideMe = new Scripture(workingVerse);
        
        List<string> holder = new List<string>();
        holder = hideMe.GetScripture();
        Console.WriteLine();
        Console.WriteLine(holder);

            //hideMe.SetScripture(workingVerse); //sends the workingVerse in
        // hideMe.SetBoolList(hideMe.GetScripture()); //makes the bool list for switching words to hidden
        
        // hideBool = hideMe.GetBoolList(); 
        
        // hiddenWords = hideMe.RenewHiddenList();
        
            //hideMe.PrintCheckr(workingVerse);
        // printMe = hideMe.GetScripture().ToString();
        
            // Console.WriteLine(workingVerse);
            // Console.WriteLine(hideBool);
            // Console.WriteLine(hiddenWords);
            // Console.WriteLine(printMe);
    }
}