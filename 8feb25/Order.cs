using System;

class Order
{
    public int OrderId;
    public string OrderDate;

    public void GetOrderStatus()
    {
        Console.WriteLine("Order ID: " + OrderId);
        Console.WriteLine("Order Date: " + OrderDate);
    }
}

class ShippedOrder : Order
{
    public string TrackingNumber;

    public new void GetOrderStatus()
    {
        base.GetOrderStatus();
        Console.WriteLine("Tracking Number: " + TrackingNumber);
    }
}

class DeliveredOrder : ShippedOrder
{
    public string DeliveryDate;

    public new void GetOrderStatus()
    {
        base.GetOrderStatus();
        Console.WriteLine("Delivery Date: " + DeliveryDate);
    }
}

class Program
{
    static void Main()
    {
        DeliveredOrder order = new DeliveredOrder();
        order.OrderId = 1001;
        order.OrderDate = "2025-02-07";
        order.TrackingNumber = "ABC123";
        order.DeliveryDate = "2025-02-10";

        order.GetOrderStatus();
    }
}
