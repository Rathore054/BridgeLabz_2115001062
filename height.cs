using System;
class height
{
    static void Main()
    {
        Console.Write("Enter your height in centimeters: ");
        double heightCm = Convert.ToDouble(Console.ReadLine());

        double heightInches = heightCm / 2.54;
        int feet = (int)(heightInches / 12);
        double inches = heightInches % 12;

        Console.WriteLine($"Your Height in cm is {heightCm} while in feet is {feet} and inches is {inches:F2}");
    }
}
