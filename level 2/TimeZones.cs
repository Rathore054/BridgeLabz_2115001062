using System;

class TimeZones
{
    static void Main()
    {
        DateTimeOffset utcNow = DateTimeOffset.UtcNow;

        Console.WriteLine("Current Time in Different Time Zones:");
        Console.WriteLine($"GMT: {utcNow}");

        TimeZoneInfo ist = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        Console.WriteLine($"IST: {TimeZoneInfo.ConvertTime(utcNow, ist)}");

        TimeZoneInfo pst = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
        Console.WriteLine($"PST: {TimeZoneInfo.ConvertTime(utcNow, pst)}");
    }
}
