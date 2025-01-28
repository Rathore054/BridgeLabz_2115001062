using System;

public class UnitConverterTemperature
{
    public static void Main()
    {
        Console.WriteLine("100°F to Celsius: " + ((100 - 32) * 5 / 9));
        Console.WriteLine("37.78°C to Fahrenheit: " + ((37.78 * 9 / 5) + 32));
        Console.WriteLine("150 pounds to kg: " + (150 * 0.453592));
        Console.WriteLine("68 kg to pounds: " + (68 * 2.20462));
        Console.WriteLine("10 gallons to liters: " + (10 * 3.78541));
        Console.WriteLine("37.85 liters to gallons: " + (37.85 * 0.264172));
    }
}
