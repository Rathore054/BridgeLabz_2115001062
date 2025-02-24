using System;
using System.Reflection;

class MathOperations
{
    public int Add(int a, int b) => a + b;
    public int Subtract(int a, int b) => a - b;
    public int Multiply(int a, int b) => a * b;
}

class DynamicCall
{
    static void Main()
    {
        Console.Write("Enter method name (Add/Subtract/Multiply): ");
        string methodName = Console.ReadLine();

        MathOperations math = new MathOperations();
        MethodInfo method = typeof(MathOperations).GetMethod(methodName);
        
        if (method != null)
        {
            object result = method.Invoke(math, new object[] { 5, 3 });
            Console.WriteLine("Result: " + result);
        }
        else
        {
            Console.WriteLine("Method not found.");
        }
    }
}

