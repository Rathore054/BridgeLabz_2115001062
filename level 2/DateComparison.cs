using System;

class DateComparison
{
    static void Main()
    {
        Console.Write("Enter first date (yyyy-MM-dd): ");
        DateTime date1 = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter second date (yyyy-MM-dd): ");
        DateTime date2 = DateTime.Parse(Console.ReadLine());

        int result = date1.CompareTo(date2);

        if (result < 0)
            Console.WriteLine("First date is before the second date.");
        else if (result > 0)
            Console.WriteLine("First date is after the second date.");
        else
            Console.WriteLine("Both dates are the same.");
    }
}
