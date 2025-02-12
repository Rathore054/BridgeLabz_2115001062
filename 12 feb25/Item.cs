using System;

class Item
{
    public string ItemName;
    public int ItemID;
    public int Quantity;
    public double Price;
    public Item Next;

    public Item(string itemName, int itemID, int quantity, double price)
    {
        ItemName = itemName;
        ItemID = itemID;
        Quantity = quantity;
        Price = price;
        Next = null;
    }
}

class Inventory
{
    private Item head;

    public void AddItem(string itemName, int itemID, int quantity, double price)
    {
        Item newItem = new Item(itemName, itemID, quantity, price);
        newItem.Next = head;
        head = newItem;
    }

    public void RemoveItem(int itemID)
    {
        Item temp = head, prev = null;
        if (temp != null && temp.ItemID == itemID)
        {
            head = temp.Next;
            return;
        }
        while (temp != null && temp.ItemID != itemID)
        {
            prev = temp;
            temp = temp.Next;
        }
        if (temp == null) return;
        prev.Next = temp.Next;
    }

    public void UpdateQuantity(int itemID, int newQuantity)
    {
        Item temp = head;
        while (temp != null)
        {
            if (temp.ItemID == itemID)
            {
                temp.Quantity = newQuantity;
                return;
            }
            temp = temp.Next;
        }
    }

    public void DisplayInventory()
    {
        Item temp = head;
        while (temp != null)
        {
            Console.WriteLine("Item Name: " + temp.ItemName + ", ID: " + temp.ItemID + ", Quantity: " + temp.Quantity + ", Price: " + temp.Price);
            temp = temp.Next;
        }
    }

    static void Main()
    {
        Inventory inventory = new Inventory();
        inventory.AddItem("Laptop", 101, 5, 750);
        inventory.AddItem("Mouse", 102, 20, 25);
        
        Console.WriteLine("Inventory:");
        inventory.DisplayInventory();

        Console.WriteLine("\nUpdating Quantity:");
        inventory.UpdateQuantity(101, 3);
        inventory.DisplayInventory();
        
        Console.WriteLine("\nRemoving Item ID 102:");
        inventory.RemoveItem(102);
        inventory.DisplayInventory();
    }
}
