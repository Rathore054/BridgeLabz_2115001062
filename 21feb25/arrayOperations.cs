using System;

class arrayOperations
{
    static void Main()
    {
        try
        {
            int[] arr = null;
            Console.Write("Enter an index: ");
            int index = int.Parse(Console.ReadLine());

            Console.WriteLine("Value at index " + index + ": " + arr[index]);
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Invalid index!");
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("Array is not initialized!");
        }
    }
}

