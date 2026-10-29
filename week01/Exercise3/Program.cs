using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        string playAgain = "yes";

        while (playAgain.Trim().ToLower() == "yes")
        {

            int number = randomGenerator.Next(1, 101);
            List <int> history = new List<int>();
            Console.WriteLine("What is your guess?");
            int magicNumber = int.Parse(Console.ReadLine());
            int attemptsNumber = 0;

            while (magicNumber != number)
            {
                history = AddGuess(history, magicNumber);
                if(magicNumber < number)
                {
                    Console.WriteLine("Higher");
                }
                else if(magicNumber > number)
                {
                    Console.WriteLine("Lower");
                }
                Console.WriteLine("What is your guess?");
                magicNumber = int.Parse(Console.ReadLine());
            }

            history = AddGuess(history, magicNumber);
            Console.WriteLine("You guessed it!");

            Console.WriteLine("This is the history of your guesses");
            foreach (int pastGuesses in history)
            {
                Console.WriteLine(pastGuesses);
                attemptsNumber += 1;
            }
            Console.WriteLine($"Attempts number: {attemptsNumber}");
            Console.Write("Would you like to play again? (yes/no): ");
            playAgain = Console.ReadLine();
        }

    }
    static List<int> AddGuess(List<int> guess, int number)
    {
        guess.Add(number);
        return guess;
    }
}