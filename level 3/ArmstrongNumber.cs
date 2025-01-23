using System;
class ArmstrongNumber
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int sum = 0, originalNumber = number;
        while (number != 0)
        {
            int digit = number % 10;
            sum += digit * digit * digit;
            number /= 10;
        }
        if (sum == originalNumber)
            Console.WriteLine("Armstrong Number");
        else
            Console.WriteLine("Not an Armstrong Number");
    }
}
