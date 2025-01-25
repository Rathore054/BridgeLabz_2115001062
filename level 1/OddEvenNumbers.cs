class OddEvenNumbers
{
    static void Main()
    {
        Console.Write("Enter a natural number: ");
        int number = int.Parse(Console.ReadLine());

        if (number < 1)
        {
            Console.WriteLine("Error: Not a natural number.");
            return;
        }

        int[] odd = new int[number / 2 + 1];
        int[] even = new int[number / 2 + 1];
        int oddIndex = 0, evenIndex = 0;

        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0)
                even[evenIndex++] = i;
            else
                odd[oddIndex++] = i;
        }

        Console.WriteLine("Odd numbers: " + string.Join(", ", odd[0..oddIndex]));
        Console.WriteLine("Even numbers: " + string.Join(", ", even[0..evenIndex]));
    }
}
