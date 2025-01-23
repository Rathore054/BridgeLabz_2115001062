using System;

class addTwoNo
{
	static void Main(string[] args)
	{
    	Console.Write("Enter the first number: ");
    	int number1 = int.Parse(Console.ReadLine());
    	Console.Write("Enter the second number: ");
    	int number2 = int.Parse(Console.ReadLine());
    	int sum = number1 + number2;
    	Console.WriteLine("The sum of the two numbers is: " + sum);
	}
}
