class Factors
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int maxFactor = 10;
        int[] factors = new int[maxFactor];
        int index = 0;

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                if (index == maxFactor)
                {
                    maxFactor *= 2;
                    Array.Resize(ref factors, maxFactor);
                }
                factors[index++] = i;
            }
        }

        Console.WriteLine("Factors: " + string.Join(", ", factors[0..index]));
    }
}
