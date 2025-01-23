using System;
class HarshadNumber
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int sum = 0, temp = number;
        while (temp != 0)
        {
            sum += temp % 10;
            temp /= 10;
        }
        if (number % sum == 0)
            Console.WriteLine("Harshad Number");
        else
            Console.WriteLine("Not a Harshad Number");
    }
}
