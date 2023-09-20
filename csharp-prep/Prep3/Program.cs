using System;

class Program
{
    static void Main(string[] args)
    {
        int theGuess;
        
        Console.Write("What is the magic number? (whole numbers only) ");
        string numberInput = Console.ReadLine();
        int randomNumber = int.Parse(numberInput);
        

        do
        {
            Console.Write("What is your guess? ");
            string guessInput = Console.ReadLine();
            theGuess = int.Parse(guessInput);

            if (theGuess < randomNumber)
                {
                    Console.WriteLine("Higher");
                }
            else if (theGuess > randomNumber)
                {
                    Console.WriteLine("Lower");
                }
        } while (theGuess != randomNumber);
        
        Console.WriteLine("You guessed it!");

        Console.WriteLine(randomNumber);
    }
}