using System;

public class SimpleInterestCalculator
{
    public static double CalculateSimpleInterest(double principal, double rate, double time)
    {
        return (principal * rate * time) / 100;
    }

    public static void Main()
    {
        Console.Write("Enter Principal: ");
        double principal = double.Parse(Console.ReadLine());

        Console.Write("Enter Rate: ");
        double rate = double.Parse(Console.ReadLine());

        Console.Write("Enter Time: ");
        double time = double.Parse(Console.ReadLine());

        double interest = CalculateSimpleInterest(principal, rate, time);
        Console.WriteLine($"The Simple Interest is {interest} for Principal {principal}, Rate of Interest {rate}, and Time {time}");
    }
}
