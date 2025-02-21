using System;

class interestCalculation
{
    static double CalculateInterest(double amount, double rate, int years)
    {
        if (amount < 0 || rate < 0)
        {
            throw new ArgumentException("Invalid input: Amount and rate must be positive");
        }
        return amount * rate * years / 100;
    }

    static void Main()
    {
        try
        {
            Console.Write("Enter the amount: ");
            double amount = double.Parse(Console.ReadLine());
            Console.Write("Enter the rate: ");
            double rate = double.Parse(Console.ReadLine());
            Console.Write("Enter the number of years: ");
            int years = int.Parse(Console.ReadLine());

            double interest = CalculateInterest(amount, rate, years);
            Console.WriteLine("Interest: " + interest);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
