using System;
class price
{
    static void Main()
    {
        Console.Write("Enter the unit price of the item: ");
        double unitPrice = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the quantity to be bought: ");
        int quantity = Convert.ToInt32(Console.ReadLine());

        double totalPrice = unitPrice * quantity;

        Console.WriteLine($"The total purchase price is INR {totalPrice:F2} if the quantity {quantity} and unit price is INR {unitPrice:F2}");
    }
}
