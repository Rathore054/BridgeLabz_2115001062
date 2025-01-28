using System;

public class HandshakeCalculator
{
    public static int CalculateHandshakes(int n)
    {
        return (n * (n - 1)) / 2;
    }

    public static void Main()
    {
        Console.Write("Enter number of students: ");
        int numberOfStudents = int.Parse(Console.ReadLine());

        int handshakes = CalculateHandshakes(numberOfStudents);
        Console.WriteLine($"Maximum number of handshakes: {handshakes}");
    }
}
