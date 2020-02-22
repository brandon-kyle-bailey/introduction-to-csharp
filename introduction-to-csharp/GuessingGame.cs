using System;

namespace introduction_to_csharp.guessing
{
    class GuessingGame
    {
        public static void Run(string[] args)
        {
            Console.WriteLine("Welcome to my C# Guessing game.");

            int guessCounter = 5;
            string secretWord = "uranium";
            string guess = "";

            while (guessCounter > 0)
            {
                
                Console.Write("You have {0} guesses remaining. What is your guess? ", guessCounter);
                guess = Console.ReadLine();
                guessCounter--;

                if (guess != secretWord)
                {
                    Console.WriteLine("Wrong! Try again.");
                } else 
                {
                    Console.WriteLine("Success! The correct answer was: {0}", secretWord);
                    break;
                }
            }

            if (guess != secretWord) 
            {
                Console.WriteLine("Opps, you're out of guesses! The correct answer was: {0}", secretWord);
            }
            
            Console.WriteLine("Press the Enter key to exit.");
            Console.ReadLine();
        }
    }
}
