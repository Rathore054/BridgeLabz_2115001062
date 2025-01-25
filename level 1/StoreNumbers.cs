class StoreNumbers
{
    static void Main()
    {
        double[] numbers = new double[10];
        double total = 0.0;
        int index = 0;

        while (true)
        {
            Console.Write("Enter a number: ");
            double input = double.Parse(Console.ReadLine());

            if (input <= 0 || index == 10)
                break;

            numbers[index++] = input;
        }

        for (int i = 0; i < index; i++)
            total += numbers[i];

        Console.WriteLine("Numbers entered: " + string.Join(", ", numbers[0..index]));
        Console.WriteLine($"Total: {total}");
    }
}
