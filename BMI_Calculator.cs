using System;
class BMI_Calculator
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your weight in kilograms: ");
        double weight = double.Parse(Console.ReadLine());
        Console.Write("Enter your height in centimeters: ");
        double heightCm = double.Parse(Console.ReadLine());
        double heightM = heightCm / 100;
        double bmi = weight / (heightM * heightM);
        string weightStatus;
        if (bmi < 18.5) weightStatus = "Underweight";
        else if (bmi >= 18.5 && bmi < 24.9) weightStatus = "Normal weight";
        else if (bmi >= 25 && bmi < 29.9) weightStatus = "Overweight";
        else weightStatus = "Obesity";
        Console.WriteLine($"\nYour BMI is {bmi:F2}");
        Console.WriteLine($"Weight Status: {weightStatus}");
    }
}

