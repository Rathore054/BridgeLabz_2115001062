using System;
using System.Collections.Generic;

class shopping
{
    static void Main()
    {
        Dictionary<string, double> cart = new Dictionary<string, double>
        {
            { "Laptop", 80000 },
            { "Phone", 30000 },
            { "Tablet", 20000 }
        };

        SortedDictionary<string, double> sortedCart = new SortedDictionary<string, double>(cart);

        Console.WriteLine("Shopping Cart Items:");
        foreach (var item in sortedCart)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}
