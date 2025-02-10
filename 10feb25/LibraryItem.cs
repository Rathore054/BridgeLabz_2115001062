using System;
using System.Collections.Generic;

abstract class LibraryItem
{
    protected int itemId;
    protected string title;
    protected string author;

    public LibraryItem(int itemId, string title, string author)
    {
        this.itemId = itemId;
        this.title = title;
        this.author = author;
    }

    public abstract int GetLoanDuration();
}

class Book : LibraryItem
{
    public Book(int itemId, string title, string author) : base(itemId, title, author) { }

    public override int GetLoanDuration()
    {
        return 14;
    }
}

class Program
{
    static void Main()
    {
        List<LibraryItem> items = new List<LibraryItem>();
        items.Add(new Book(1, "C# Basics", "John Doe"));

        foreach (LibraryItem item in items)
        {
            Console.WriteLine("Item ID: " + item.itemId);
            Console.WriteLine("Title: " + item.title);
            Console.WriteLine("Loan Duration: " + item.GetLoanDuration() + " days");
            Console.WriteLine();
        }
    }
}
