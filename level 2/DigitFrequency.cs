class DigitFrequency
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int[] frequency = new int[10];

        while (number != 0)
        {
            frequency[number % 10]++;
            number /= 10;
        }

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Digit {i}: {frequency[i]} times");
        }
    }
}
