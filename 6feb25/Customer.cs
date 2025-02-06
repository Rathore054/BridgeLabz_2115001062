using System;
using System.Collections.Generic;

class Customer {
    public string Name;
    public List<Order> Orders = new List<Order>();

    public void PlaceOrder(Order order) {
        Orders.Add(order);
    }
}

class Order {
    public int OrderId;
    public List<Product> Products = new List<Product>();

    public void AddProduct(Product product) {
        Products.Add(product);
    }

    public void ShowOrderDetails() {
        Console.WriteLine("Order ID: " + OrderId);
        Console.WriteLine("Products in order:");
        foreach (var product in Products) {
            Console.WriteLine(product.Name);
        }
    }
}

class Product {
    public string Name;
    public double Price;
}

class Program {
    static void Main() {
        Customer customer = new Customer();
        customer.Name = "Sujal";

        Order order1 = new Order();
        order1.OrderId = 101;

        Product p1 = new Product();
        p1.Name = "Laptop";
        p1.Price = 800.50;

        Product p2 = new Product();
        p2.Name = "Mouse";
        p2.Price = 25.75;

        order1.AddProduct(p1);
        order1.AddProduct(p2);
        customer.PlaceOrder(order1);

        order1.ShowOrderDetails();
    }
}
