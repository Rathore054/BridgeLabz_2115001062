using System;

public class QuadraticSolver
{
    public static void Main()
    {
        Console.Write("Enter value of a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter value of b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter value of c: ");
        double c = double.Parse(Console.ReadLine());

        double delta = Math.Pow(b, 2) - 4 * a * c;

        if (delta > 0)
        {
            double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine("Roots: " + root1 + ", " + root2);
        }
        else if (delta == 0)
        {
            double root = -b / (2 * a);
            Console.WriteLine("Single Root: " + root);
        }
        else
        {
            Console.WriteLine("No Real Roots");
        }
    }
}
