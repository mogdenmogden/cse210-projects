using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string numberInput = Console.ReadLine();
        int randomNumber = int.Parse(numberInput);
        
        Console.Write("What is your guess? ");
        string guessInput = Console.ReadLine();
        int theGuess = int.Parse(guessInput);

        if (theGuess < randomNumber)
            {
                Console.WriteLine("Higher");
            }
        else if (theGuess > randomNumber)
            {
                Console.WriteLine("Lower");
            }
        else
        Console.WriteLine("You guessed it!");
        
        Console.WriteLine(randomNumber);
    }
}