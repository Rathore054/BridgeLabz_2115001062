using System;

class MultiplicationTable
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        for (int i = 6; i <= 9; i++)
        {
            Console.WriteLine($"{number} * {i} = {number * i}");
        }
    }
}
