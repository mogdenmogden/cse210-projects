using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string username = Console.ReadLine();
            return username;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int faveNumber = int.Parse(Console.ReadLine());
            return faveNumber;
        }

        static int SquareNumber(int nbr)
        {
            int squared = nbr*nbr;
            return squared;
        }

        static void DisplayResult(string name, int number)
        {
            Console.WriteLine($"{name}, the square of your number is {number}.");
        }

        /*stretch for fun*/
        static string MakeUserName(string name, int number)
        {
            string userLower = name.ToLower();
            string uid = userLower.Replace(' ','_');
            string numid = number.ToString();
            string userNmId = uid+numid;
            Console.WriteLine($"Your userid will be: {userNmId}");
            Console.WriteLine($"Your email address: {userNmId}@theprogram.org");
            return userNmId;
        }

        DisplayWelcome();
        string usrName = PromptUserName();
        int usrNumber = PromptUserNumber();
        int sqrNumber = SquareNumber(usrNumber);
        DisplayResult(usrName,sqrNumber);
        MakeUserName(usrName,usrNumber);

    }
}