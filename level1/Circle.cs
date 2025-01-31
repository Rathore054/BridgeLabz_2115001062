using System;

class Circle
{
    public double Radius;

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public double CalculateCircumference()
    {
        return 2 * Math.PI * Radius;
    }

    public void Display()
    {
        Console.WriteLine($"Area: {CalculateArea()}, Circumference: {CalculateCircumference()}");
    }
}

class Program2
{
    static void Main()
    {
        Circle circle = new Circle(5);
        circle.Display();
    }
}
