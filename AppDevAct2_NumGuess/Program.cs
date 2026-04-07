using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("==========================================");
        Console.WriteLine("   Welcome to this Simple C# Application!  ");
        Console.WriteLine("==========================================");
        Console.WriteLine();

        // Get user's name
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        // Greet the user
        Console.WriteLine($"\nHello, {name}! Nice to meet you.");
        Console.WriteLine();

        // Simple number guessing game
        Console.WriteLine("Let's play a number guessing game!");
        Console.WriteLine("I'm thinking of a number between 1 and 100...");
        Console.WriteLine("Tip: Try guessing in the middle!");
        Console.WriteLine();

        Random random = new Random();
        int secretNumber = random.Next(1, 101);
        int attempts = 0;
        int maxAttempts = 7;
        bool guessed = false;

        while (!guessed && attempts < maxAttempts)
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

        if (!guessed)
        {
            Console.WriteLine($"\nGame over! The number was {secretNumber}.");
        }

        Console.WriteLine();
        Console.WriteLine("Thanks for playing, " + name + "!");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}