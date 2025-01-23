using System;
class km_to_miles
{
    static void Main()
    {
        Console.Write("Enter the distance in kilometers: ");
        double km = Convert.ToDouble(Console.ReadLine());
        double miles = km / 1.6;
        Console.WriteLine($"The total miles is {miles:F2} mile for the given {km} km");
    }
}
