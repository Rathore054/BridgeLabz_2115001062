using System;

class TemperatureConverter
{
    static double CelsiusToFahrenheit(double c) => (c * 9 / 5) + 32;
    static double FahrenheitToCelsius(double f) => (f - 32) * 5 / 9;

    static void Main()
    {
        Console.Write("Enter temperature: ");
        double temp = double.Parse(Console.ReadLine());

        Console.Write("Convert to (C/F): ");
        char choice = char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();

        if (choice == 'C')
            Console.WriteLine($"Converted: {FahrenheitToCelsius(temp):F2}°C");
        else if (choice == 'F')
            Console.WriteLine($"Converted: {CelsiusToFahrenheit(temp):F2}°F");
        else
            Console.WriteLine("Invalid choice.");
    }
}
