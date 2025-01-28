using System;

public class LeapYearChecker
{
    public static bool IsLeapYear(int year)
    {
        return year >= 1582 && (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0));
    }

    public static void Main()
    {
        Console.Write("Enter a year: ");
        int year = int.Parse(Console.ReadLine());

        if (year < 1582)
            Console.WriteLine("Year must be 1582 or later.");
        else if (IsLeapYear(year))
            Console.WriteLine(year + " is a Leap Year.");
        else
            Console.WriteLine(year + " is not a Leap Year.");
    }
}
