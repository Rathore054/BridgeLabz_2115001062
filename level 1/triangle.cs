using System;
class triangle
{
    static void Main()
    {
        Console.Write("Enter the base of the triangle (in cm): ");
        double baseLength = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height of the triangle (in cm): ");
        double height = Convert.ToDouble(Console.ReadLine());

        double areaCm2 = 0.5 * baseLength * height;
        double areaIn2 = areaCm2 / 2.54 / 2.54;  // Convert square cm to square inches

        Console.WriteLine($"The area of the triangle is {areaCm2:F2} square centimeters and {areaIn2:F2} square inches.");
    }
}
