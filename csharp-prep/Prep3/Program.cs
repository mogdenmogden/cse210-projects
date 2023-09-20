using System;

class Program
{
    static void Main(string[] args)
    {
        int theGuess;
        string playAgain;
        
        do
        {
            int guesses = 0;

            /*Console.Write("What is the magic number? (whole numbers only) ");
            string numberInput = Console.ReadLine();
            int randomNumber = int.Parse(numberInput);*/
            
            Console.WriteLine("The computer will pick a number");
            Console.WriteLine("between 1 and 100. Try to guess it.");
            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(1,101);

            do
            {
                Console.Write("What is your guess? ");
                string guessInput = Console.ReadLine();
                theGuess = int.Parse(guessInput);
                guesses++;
                if (theGuess < randomNumber)
                    {
                        Console.WriteLine("Higher");
                    }
                else if (theGuess > randomNumber)
                    {
                        Console.WriteLine("Lower");
                    }
            } while (theGuess != randomNumber);
            
            Console.WriteLine($"You guessed it in {guesses} guesses!");

            Console.WriteLine(randomNumber);

            Console.Write("Do you want to play again? (yes/no) ");
            playAgain = Console.ReadLine();

        } while (playAgain == "yes");
    }
}