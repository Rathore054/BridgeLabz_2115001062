using System;

class divisionInputErrors
{
    static void Main()
    {
        try
        {
            Console.Write("Enter the numerator: ");
            double numerator = double.Parse(Console.ReadLine());
            Console.Write("Enter the denominator: ");
            double denominator = double.Parse(Console.ReadLine());

            double result = numerator / denominator;
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input, please enter numeric values");
        }
    }
}

