using System;

class simple_interest
{
	static void Main(string[] args)
	{
    	Console.Write("Enter the Principal amount: ");
    	double principal = double.Parse(Console.ReadLine());
    	Console.Write("Enter the Rate of interest (in %): ");
    	double rate = double.Parse(Console.ReadLine());
    	Console.Write("Enter the Time period (in years): ");
    	double time = double.Parse(Console.ReadLine());
    	double simpleInterest = (principal * rate * time) / 100;
    	Console.WriteLine("The Simple Interest is: " + simpleInterest);
	}
}
