using System;
using System.Collections.Generic;

abstract class Product
{
    protected int productId;
    protected string name;
    protected double price;

    public Product(int productId, string name, double price)
    {
        this.productId = productId;
        this.name = name;
        this.price = price;
    }

    public abstract double CalculateDiscount();
    public double GetPrice() { return price - CalculateDiscount(); }
}

class Electronics : Product
{
    public Electronics(int productId, string name, double price) : base(productId, name, price) { }

    public override double CalculateDiscount()
    {
        return price * 0.1;
    }
}

class Clothing : Product
{
    public Clothing(int productId, string name, double price) : base(productId, name, price) { }

    public override double CalculateDiscount()
    {
        return price * 0.2;
    }
}

class Groceries : Product
{
    public Groceries(int productId, string name, double price) : base(productId, name, price) { }

    public override double CalculateDiscount()
    {
        return price * 0.05;
    }
}

class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>();
        products.Add(new Electronics(1, "Laptop", 50000));
        products.Add(new Clothing(2, "Shirt", 2000));
        products.Add(new Groceries(3, "Apple", 500));

        foreach (Product product in products)
        {
            Console.WriteLine("Product ID: " + product.productId);
            Console.WriteLine("Name: " + product.name);
            Console.WriteLine("Final Price: " + product.GetPrice());
            Console.WriteLine();
        }
    }
}
