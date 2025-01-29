using System;

class DateFormatting
{
    static void Main()
    {
        DateTime currentDate = DateTime.Now;

        Console.WriteLine("Different Date Formats:");
        Console.WriteLine($"dd/MM/yyyy: {currentDate:dd/MM/yyyy}");
        Console.WriteLine($"yyyy-MM-dd: {currentDate:yyyy-MM-dd}");
        Console.WriteLine($"EEE, MMM dd, yyyy: {currentDate:ddd, MMM dd, yyyy}");
    }
}
