using System;

public class SpringSeasonChecker
{
    public static bool IsSpringSeason(int month, int day)
    {
        return (month == 3 && day >= 20) || (month == 4) || (month == 5) || (month == 6 && day <= 20);
    }

    public static void Main()
    {
        Console.Write("Enter month: ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Enter day: ");
        int day = int.Parse(Console.ReadLine());

        bool isSpring = IsSpringSeason(month, day);
        Console.WriteLine(isSpring ? "It's a Spring Season" : "Not a Spring Season");
    }
}
