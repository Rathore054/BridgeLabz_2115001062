using System;

class LeapYear
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a year: ");
        int year = int.Parse(Console.ReadLine());
        Console.WriteLine(IsLeapYear(year));
    }

    public static string IsLeapYear(int year)
    {
        if (year < 1582)
        {
            return "The Leap Year program only works for year >= 1582";
        }
        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    return $"{year} is a Leap Year";
                }
                else
                {
                    return $"{year} is not a Leap Year";
                }
            }
            else
            {
                return $"{year} is a Leap Year";
            }
        }
        else
        {
            return $"{year} is not a Leap Year";
        }
    }
}
