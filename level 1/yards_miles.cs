using System;
class yards_miles
{
    static void Main()
    {
        Console.Write("Enter the distance in feet: ");
        double distanceInFeet = Convert.ToDouble(Console.ReadLine());

        double distanceInYards = distanceInFeet / 3;
        double distanceInMiles = distanceInYards / 1760;

        Console.WriteLine($"The distance in yards is {distanceInYards:F2} and in miles is {distanceInMiles:F5}");
    }
}

