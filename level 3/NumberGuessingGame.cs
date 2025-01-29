using System;

class NumberGuessingGame
{
    static void Main()
    {
        int low = 1, high = 100;
        Random rand = new Random();
        Console.WriteLine("Think of a number between 1 and 100, and I'll guess it.");

        while (true)
        {
            int guess = rand.Next(low, high + 1);
            Console.WriteLine($"Is your number {guess}? (Enter 'h' for too high, 'l' for too low, 'c' for correct)");
            char feedback = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (feedback == 'c')
            {
                Console.WriteLine("I guessed your number!");
                break;
            }
            else if (feedback == 'h')
                high = guess - 1;
            else if (feedback == 'l')
                low = guess + 1;
        }
    }
}
