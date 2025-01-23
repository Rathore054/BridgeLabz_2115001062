using System;
class volume
{
    static void Main()
    {
        double radiusKm = 6378;
        double conversionFactor = 1.60934; // 1 mile = 1.60934 km
        double volumeKm3 = (4.0 / 3.0) * Math.PI * Math.Pow(radiusKm, 3);
        double volumeMiles3 = volumeKm3 / Math.Pow(conversionFactor, 3);

        Console.WriteLine($"The volume of earth in cubic kilometers is {volumeKm3:F2} and cubic miles is {volumeMiles3:F2}");
    }
}
