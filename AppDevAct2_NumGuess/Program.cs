using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("===================================");
        Console.WriteLine("   Welcome to My C# Application!  ");
        Console.WriteLine("===================================");
        Console.WriteLine();

        // Get user's name
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        // Greet the user
        Console.WriteLine($"\nHello, {name}! Nice to meet you.");
        Console.WriteLine();

        // Simple number guessing game
        Console.WriteLine("Let's play a number guessing game!");
        Console.WriteLine("I'm thinking of a number between 1 and 10...");
        Console.WriteLine();

        Random random = new Random();
        int secretNumber = random.Next(1, 11);
        int attempts = 0;
        bool guessed = false;

        while (!guessed)
        {
            Console.Write("Your guess: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int guess))
            {
                attempts++;
                if (guess < secretNumber)
                    Console.WriteLine("Too low! Try again.");
                else if (guess > secretNumber)
                    Console.WriteLine("Too high! Try again.");
                else
                {
                    guessed = true;
                    Console.WriteLine($"\nCorrect! You guessed it in {attempts} attempt(s)!");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }

        Console.WriteLine();
        Console.WriteLine("Thanks for playing! Goodbye, " + name + "!");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}