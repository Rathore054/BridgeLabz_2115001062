class DigitFrequencyArray
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Math.Abs(int.Parse(Console.ReadLine()));
        int[] frequency = new int[10];

        while (number != 0)
        {
            int digit = number % 10;
            frequency[digit]++;
            number /= 10;
        }

        Console.WriteLine("Frequency of each digit:");
        for (int i = 0; i < 10; i++)
        {
            if (frequency[i] > 0)
            {
                Console.WriteLine($"Digit {i}: {frequency[i]} times");
            }
        }
    }
}

