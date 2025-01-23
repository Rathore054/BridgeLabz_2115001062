using System;
class quotient
{
    static void Main()
    {
        Console.Write("Enter number1: ");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write("Enter number2: ");
        int number2 = int.Parse(Console.ReadLine());

        int quotient = number1 / number2;
        int remainder = number1 % number2;

        Console.WriteLine($"The Quotient is {quotient} and Remainder is {remainder} of {number1} and {number2}");
    }
}
