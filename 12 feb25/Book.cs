using System;

class Book
{
    public string Title;
    public string Author;
    public string Genre;
    public int BookID;
    public bool Available;
    public Book Next;
    public Book Prev;

    public Book(string title, string author, string genre, int bookID, bool available)
    {
        Title = title;
        Author = author;
        Genre = genre;
        BookID = bookID;
        Available = available;
        Next = null;
        Prev = null;
    }
}

class Library
{
    private Book head;

    public void AddBook(string title, string author, string genre, int bookID, bool available)
    {
        Book newBook = new Book(title, author, genre, bookID, available);
        if (head != null)
        {
            newBook.Next = head;
            head.Prev = newBook;
        }
        head = newBook;
    }

    public void RemoveBook(int bookID)
    {
        Book temp = head;
        while (temp != null)
        {
            if (temp.BookID == bookID)
            {
                if (temp.Prev != null)
                {
                    temp.Prev.Next = temp.Next;
                }
                else
                {
                    head = temp.Next;
                }
                if (temp.Next != null)
                {
                    temp.Next.Prev = temp.Prev;
                }
                return;
            }
            temp = temp.Next;
        }
    }

    public void DisplayBooks()
    {
        Book temp = head;
        while (temp != null)
        {
            Console.WriteLine("Title: " + temp.Title + ", Author: " + temp.Author + ", Available: " + temp.Available);
            temp = temp.Next;
        }
    }

    static void Main()
    {
        Library library = new Library();
        library.AddBook("1984", "George Orwell", "Dystopian", 1, true);
        library.AddBook("Brave New World", "Aldous Huxley", "Sci-Fi", 2, false);

        Console.WriteLine("Library Books:");
        library.DisplayBooks();
    }
}
