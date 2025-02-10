using System;
using System.Collections.Generic;

abstract class FoodItem
{
    protected string itemName;
    protected double price;
    protected int quantity;

    public FoodItem(string itemName, double price, int quantity)
    {
        this.itemName = itemName;
        this.price = price;
        this.quantity = quantity;
    }

    public abstract double CalculateTotalPrice();
}

class VegItem : FoodItem
{
    public VegItem(string itemName, double price, int quantity) : base(itemName, price, quantity) { }

    public override double CalculateTotalPrice()
    {
        return price * quantity;
    }
}

class Program
{
    static void Main()
    {
        List<FoodItem> items = new List<FoodItem>();
        items.Add(new VegItem("Salad", 100, 2));

        foreach (FoodItem item in items)
        {
            Console.WriteLine("Item Name: " + item.itemName);
            Console.WriteLine("Total Price: " + item.CalculateTotalPrice());
            Console.WriteLine();
        }
    }
}
