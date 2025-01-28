using System;

public class BMICalculator
{
    public static double CalculateBMI(double weight, double heightInCm)
    {
        double heightInMeters = heightInCm / 100;
        return weight / (heightInMeters * heightInMeters);
    }

    public static string GetBMIStatus(double bmi)
    {
        if (bmi < 18.5) return "Underweight";
        if (bmi < 24.9) return "Normal";
        if (bmi < 29.9) return "Overweight";
        return "Obese";
    }

    public static void Main()
    {
        double[,] data = new double[10, 3];
        string[] statuses = new string[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Enter weight (kg) of person {i + 1}: ");
            data[i, 0] = double.Parse(Console.ReadLine());

            Console.Write($"Enter height (cm) of person {i + 1}: ");
            data[i, 1] = double.Parse(Console.ReadLine());

            data[i, 2] = CalculateBMI(data[i, 0], data[i, 1]);
            statuses[i] = GetBMIStatus(data[i, 2]);
        }

        Console.WriteLine("Weight\tHeight\tBMI\tStatus");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"{data[i, 0]}\t{data[i, 1]}\t{data[i, 2]:F2}\t{statuses[i]}");
        }
    }
}
