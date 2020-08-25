using System;

namespace guessinggame
{
    class Program
    {
        static void Main(string[] args)
        {
            // variable that hold the secretNumber
            int secretNumber = new Random().Next(1, 101);
            // holds the number of Attempts
            int numberOfAttempts = 0;
            // holds the number of Attempts Available 
            int attemptsAvailable = 0;
            // setting the difficulty
            bool difficultySet = false;
            bool isCheater = false;

            while (!difficultySet)
            {
                Console.WriteLine("Select difficulty easy medium or hard");
                string difficulty = Console.ReadLine();
                {

                    if (difficulty == "easy")
                    {
                        attemptsAvailable = 8;
                        difficultySet = true;
                    }
                    else if (difficulty == "medium")
                    {
                        attemptsAvailable = 6;
                        difficultySet = true;
                    }
                    else if (difficulty == "hard")
                    {
                        attemptsAvailable = 4;
                        difficultySet = true;
                    }
                    else if (difficulty == "Cheater")
                    {
                        attemptsAvailable = 4;
                        difficultySet = true;
                        isCheater = true;

                    }
                }
            }
            // message asking the question 
            Console.WriteLine($"Can you guess the secret number? >>");

            // loops through the question base on the  difficulty
            while (numberOfAttempts < attemptsAvailable)
            {
                // shows how many guesses you have left 
                Console.WriteLine($"You have {attemptsAvailable - numberOfAttempts} guesses left.");
                // the int32.Parse  into an intger
                int numberGuess = Int32.Parse(Console.ReadLine());
                // if answer is right then break
                if (numberGuess == secretNumber)
                {
                    Console.Write("Congrats you got it right!");
                    break;

                }
                else if (numberGuess > secretNumber)
                {
                    Console.WriteLine("Your guess was too high");
                    if (!isCheater) numberOfAttempts++;
                }
                else if (numberGuess < secretNumber)
                {
                    Console.WriteLine("Your guess was too low");
                    if (!isCheater) numberOfAttempts++;
                }
                else
                {
                    // give you four guesses 
                    if (!isCheater) numberOfAttempts++;
                    Console.WriteLine("Try Again!");
                }
            }
        }
    }
}