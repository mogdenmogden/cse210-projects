using System;

class Program
{
    static void Main(string[] args)
    {
        string letter;
        bool passed = false;
        float remainder;
        string plusMinus;
        
        Console.Write("What is your grade percentage? (omit the %) ");
        string usrInputGrade = Console.ReadLine();
        float gradePct = float.Parse(usrInputGrade);

        remainder = gradePct % 10;
        if (remainder >= 7.0)
            {
                plusMinus = "+";
            }
        else if (remainder <3)
            {
                plusMinus = "-";
            }
        else 
            {
                plusMinus = "";
            }
        if (gradePct >= 90.0)
            {
                letter = "A";
            }
        else if (gradePct >= 80.0 && gradePct < 90.0)
            {
                letter = "B"; 
            }
        else if (gradePct >= 70.0 && gradePct < 80.0)
            {
                letter = "C"; 
            }
        else if (gradePct >= 60.0 && gradePct < 70.0)
            {
                letter = "D"; 
            }
        else
            {
                letter = "F"; 
            }
        
        if ((letter == "A" && plusMinus == "+") || letter == "F")
            {
                Console.WriteLine($"Your grade: {letter}");
            }
        else
            {
                Console.WriteLine($"Your grade: {letter}{plusMinus}");
            }
        
        if (gradePct > 70.0)
            {
                passed = true;
            }
        if (passed == true)
            {
                Console.WriteLine("Congratulations! You passed.");
            }
        else
            {
                Console.WriteLine("Sorry, you didn't pass. Better luck next time.");
            }
    }
}