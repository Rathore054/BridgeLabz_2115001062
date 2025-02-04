using System;
public class Product {
    public static double Discount;
    private readonly int ProductID;
    public string ProductName;
    public int Price, Quantity;
    public static void UpdateDiscount(double di) {
        Discount = di;
        Console.WriteLine("updated discount " + Discount);
    }
    public Product(string name, int price, int quantity) {
    this.ProductName = name;
        this.Price = price;
        this.Quantity = quantity;

    }
    public void display() {
        if (this is Product) { 
        Console.WriteLine("Product ID :"+ProductID);
            Console.WriteLine("Price :" + Price);
            Console.WriteLine("Quantity :" + Quantity); 
        }
    }
    static void Main(string[] args)
    {
        Product prd = new Product("Asus Tuf F15", 70000, 1);
        Product prd2 = new Product("Realme 7 Pro", 23000, 1);
        prd.display();
        UpdateDiscount(5);
        prd2.display();
        UpdateDiscount(10); 
    }
}
