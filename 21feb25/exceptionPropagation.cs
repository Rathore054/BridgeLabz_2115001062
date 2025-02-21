using System;

class exceptionPropagation
{
    static void Method1()
    {
        throw new ArithmeticException("Arithmetic exception in Method1");
    }

    static void Method2()
    {
        Method1();
    }

    static void Main()
    {
        try
        {
            Method2();
        }
        catch (ArithmeticException ex)
        {
            Console.WriteLine("Handled exception in Main: " + ex.Message);
        }
    }
}
