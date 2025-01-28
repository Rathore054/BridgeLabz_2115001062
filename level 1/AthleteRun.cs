using System;

public class AthleteRun
{
    public static int CalculateRounds(double side1, double side2, double side3)
    {
        double perimeter = side1 + side2 + side3;
        double distance = 5000; 
        return (int)Math.Ceiling(distance / perimeter);
    }

    public static void Main()
    {
        Console.Write("Enter side 1 of the triangle (m): ");
        double side1 = double.Parse(Console.ReadLine());

        Console.Write("Enter side 2 of the triangle (m): ");
        double side2 = double.Parse(Console.ReadLine());

        Console.Write("Enter side 3 of the triangle (m): ");
        double side3 = double.Parse(Console.ReadLine());

        int rounds = CalculateRounds(side1, side2, side3);
        Console.WriteLine($"The athlete needs to complete {rounds} rounds.");
    }
}
