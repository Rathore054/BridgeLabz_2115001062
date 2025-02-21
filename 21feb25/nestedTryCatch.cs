using System;

class nestedTryCatch
{
    static void Main()
    {
        try
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.Write("Enter an index: ");
            int index = int.Parse(Console.ReadLine());

            try
            {
                int value = arr[index];
                Console.Write("Enter divisor: ");
                int divisor = int.Parse(Console.ReadLine());

                try
                {
                    Console.WriteLine("Result: " + (value / divisor));
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Cannot divide by zero!");
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid array index!");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input");
        }
    }
