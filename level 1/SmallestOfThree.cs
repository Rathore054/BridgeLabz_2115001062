using System;

class SmallestOfThree
{
    static void Main()
    {
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        int number3 = int.Parse(Console.ReadLine());
        Console.WriteLine($"Is the first number the smallest? {number1 < number2 && number1 < number3}");
    }
}
