class ReverseNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int[] digits = new int[10];
        int index = 0;

        while (number != 0)
        {
            digits[index++] = number % 10;
            number /= 10;
        }

        Console.WriteLine("Reversed digits:");
        for (int i = index - 1; i >= 0; i--)
        {
            Console.Write(digits[i] + " ");
        }
    }
}
