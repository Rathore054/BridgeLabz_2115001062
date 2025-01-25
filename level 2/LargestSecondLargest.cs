class LargestSecondLargest
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int[] digits = new int[10];
        int index = 0;

        while (number != 0)
        {
            if (index == digits.Length)
            {
                Array.Resize(ref digits, digits.Length + 10);
            }
            digits[index++] = number % 10;
            number /= 10;
        }

        int largest = 0, secondLargest = 0;
        for (int i = 0; i < index; i++)
        {
            if (digits[i] > largest)
            {
                secondLargest = largest;
                largest = digits[i];
            }
            else if (digits[i] > secondLargest)
            {
                secondLargest = digits[i];
            }
        }

        Console.WriteLine($"Largest: {largest}");
        Console.WriteLine($"Second Largest: {secondLargest}");
    }
}
