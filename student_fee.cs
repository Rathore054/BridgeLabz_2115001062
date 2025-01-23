using System;
class student_fee
{
    static void Main()
    {
        Console.Write("Enter the student fee (INR): ");
        double fee = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the university discount percentage: ");
        double discountPercent = Convert.ToDouble(Console.ReadLine());

        double discount = (fee * discountPercent) / 100;
        double discountedFee = fee - discount;

        Console.WriteLine($"discount amount is{discount:F2} and final discounted {discountedFee:F2}");
    }
}

