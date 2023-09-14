using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? (omit the %) ");
        string usrInputGrade = Console.ReadLine();
        float gradePct = int.Parse(usrInputGrade);
        string letterGrade;
        bool passed = false;
        if (gradePct >= 90.0)
            {
                letterGrade = "A";
                Console.WriteLine($"Your grade: {letterGrade}");
            }
        else if (gradePct >= 80.0 && gradePct < 90.0)
            {
                letterGrade = "B"; Console.WriteLine($"Your grade: {letterGrade}");
            }
        else if (gradePct >= 70.0 && gradePct < 80.0)
            {
                letterGrade = "C"; Console.WriteLine($"Your grade: {letterGrade}");
            }
        else if (gradePct >= 60.0 && gradePct < 70.0)
            {
                letterGrade = "D"; Console.WriteLine($"Your grade: {letterGrade}");
            }
        else
            {
                letterGrade = "F"; Console.WriteLine($"Your grade: {letterGrade}");
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