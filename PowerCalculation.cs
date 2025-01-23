using System;

class PowerCalculation
{
	static void Main(string[] args)
	{
    	Console.Write("Enter the base: ");
    	double baseNumber = double.Parse(Console.ReadLine());
    	Console.Write("Enter the exponent: ");
    	double exponent = double.Parse(Console.ReadLine());
    	double result = Math.Pow(baseNumber, exponent);
    	Console.WriteLine($"The result of {baseNumber} raised to the power of {exponent} is: {result}");
	}
}
