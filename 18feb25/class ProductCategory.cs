using System;

abstract class ProductCategory { }

class BookCategory : ProductCategory { }
class ClothingCategory : ProductCategory { }

class Product<T> where T : ProductCategory
{
    public string Name { get; set; }
    public double Price { get; set; }

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public void Display()
    {
        Console.WriteLine("Category: " + typeof(T).Name + ", Name: " + Name + ", Price: " + Price);
    }
}

class DiscountHelper
{
    public static void ApplyDiscount<T>(T product, double percentage) where T : Product<ProductCategory>
    {
        product.Price -= product.Price * (percentage / 100);
        Console.WriteLine("Discount applied! New price of " + product.Name + ": " + product.Price);
    }
}

class Program
{
    static void Main()
    {
        Product<BookCategory> book = new Product<BookCategory>("C# Guide", 50);
        Product<ClothingCategory> shirt = new Product<ClothingCategory>("T-Shirt", 20);

        book.Display();
        shirt.Display();

        DiscountHelper.ApplyDiscount(book, 10);
        DiscountHelper.ApplyDiscount(shirt, 20);
    }
}
