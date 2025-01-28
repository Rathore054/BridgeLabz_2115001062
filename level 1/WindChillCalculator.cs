using System;

public class WindChillCalculator
{
    public static double CalculateWindChill(double temperature, double windSpeed)
    {
        return 35.74 + 0.6215 * temperature + (0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16);
    }

    public static void Main()
    {
        Console.Write("Enter temperature (°F): ");
        double temperature = double.Parse(Console.ReadLine());

        Console.Write("Enter wind speed (mph): ");
        double windSpeed = double.Parse(Console.ReadLine());

        double windChill = CalculateWindChill(temperature, windSpeed);
        Console.WriteLine($"Wind Chill Temperature: {windChill:F2} °F");
    }
}
