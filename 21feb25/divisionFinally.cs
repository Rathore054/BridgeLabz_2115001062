using System;

class divisionFinally
{
    static void Main()
    {
        try
        {
            Console.Write("Enter the numerator: ");
            int numerator = int.Parse(Console.ReadLine());
            Console.Write("Enter the denominator: ");
            int denominator = int.Parse(Console.ReadLine());

            Console.WriteLine("Result: " + (numerator / denominator));
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        finally
        {
            Console.WriteLine("Operation completed");
        }
    }
}
