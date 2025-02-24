using System;
using System.Reflection;

class Calculator
{
    private int Multiply(int a, int b) => a * b;
}

class ReflectionInvoke
{
    static void Main()
    {
        Calculator calc = new Calculator();
        MethodInfo method = typeof(Calculator).GetMethod("Multiply", BindingFlags.NonPublic | BindingFlags.Instance);
        object result = method.Invoke(calc, new object[] { 5, 10 });
        Console.WriteLine("Result: " + result);
    }
}
