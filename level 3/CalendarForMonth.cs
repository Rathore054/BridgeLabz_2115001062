 using System;

public class CalendarForMonth
{
    public static void Main()
    {
        Console.WriteLine("Enter month (1-12): ");
        int month = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter year: ");
        int year = int.Parse(Console.ReadLine());
        DisplayCalendar(month, year);
    }

    public static void DisplayCalendar(int month, int year)
    {
        string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        int[] daysInMonth = { 31, IsLeapYear(year) ? 29 : 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        Console.WriteLine($"Calendar for {months[month - 1]} {year}");
        Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

        int firstDay = FirstDayOfMonth(month, year);

        for (int i = 0; i < firstDay; i++)
            Console.Write("    ");

        for (int day = 1; day <= daysInMonth[month - 1]; day++)
        {
            Console.Write($"{day,3} ");
            if ((day + firstDay) % 7 == 0)
                Console.WriteLine();
        }
        Console.WriteLine();
    }

    public static bool IsLeapYear(int year) => (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);

    public static int FirstDayOfMonth(int month, int year)
    {
        int y0 = year - (14 - month) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = month + 12 * ((14 - month) / 12) - 2;
        return (x + (31 * m0) / 12) % 7;
    }
}
