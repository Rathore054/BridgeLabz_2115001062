using System;
class Calculator
{
    static void Main()
    {
        double first = double.Parse(Console.ReadLine());
        double second = double.Parse(Console.ReadLine());
        string op = Console.ReadLine();
        switch (op)
        {
            case "+":
                Console.WriteLine(first + second);
                break;
            case "-":
                Console.WriteLine(first - second);
                break;
            case "*":
                Console.WriteLine(first * second);
                break;
            case "/":
                Console.WriteLine(first / second);
                break;
            default:
                Console.WriteLine("Invalid Operator");
                break;
        }
    }
}
