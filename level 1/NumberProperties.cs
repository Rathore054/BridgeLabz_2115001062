class NumberProperties
{
    static void Main()
    {
        int[] numbers = new int[5];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());

            if (numbers[i] > 0)
                Console.WriteLine(numbers[i] % 2 == 0 ? $"{numbers[i]} is positive and even." : $"{numbers[i]} is positive and odd.");
            else if (numbers[i] < 0)
                Console.WriteLine($"{numbers[i]} is negative.");
            else
                Console.WriteLine($"{numbers[i]} is zero.");
        }

        if (numbers[0] > numbers[^1])
            Console.WriteLine("First element is greater than last element.");
        else if (numbers[0] < numbers[^1])
            Console.WriteLine("First element is less than last element.");
        else
            Console.WriteLine("First and last elements are equal.");
    }
}
