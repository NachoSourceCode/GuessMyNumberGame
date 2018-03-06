using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumberGame
{
    class Program
    {
        static void Main()
        {
            
            Console.WriteLine("I'm thinking of a number between 1 and 100.");
            
            HandleGuess();
        }

        static int HandleGuess()
        {
            bool quit = false;
            bool correct = false;
            int guess = 0;
            int answerValue = 47;

            try
            {
                do
                {
                    Console.Write("Guess: ");
                    guess = int.Parse(Console.ReadLine());
                    
                    if (guess < answerValue)
                    {
                        Console.WriteLine($"The number is higher than {guess}.");
                    }
                    else if (guess > answerValue)
                    {
                        Console.WriteLine($"The number is lower than {guess}.");
                    }
                    else
                    {
                        Console.WriteLine($"**  Great job!! You guessed it!  **\nThe answer was: {answerValue}");
                        correct = true;
                    }
                }
                while (!correct && !quit);
            }

            catch (FormatException)
            {
                Console.WriteLine("Invalid characters. Continue guessing and be sure to enter a " +
                                  "positive number between 1 and 100.");
                HandleGuess();
            }
            catch (Exception)
            {
                Console.WriteLine("Error. Continue guessing and be sure to enter a " +
                                  "positive number between 1 and 100.");
                HandleGuess();
            }
            return answerValue;
        }
    }
}
