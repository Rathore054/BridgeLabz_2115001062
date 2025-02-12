using System;

class Movie
{
    public string Title;
    public string Director;
    public int Year;
    public double Rating;
    public Movie Next;
    public Movie Prev;

    public Movie(string title, string director, int year, double rating)
    {
        Title = title;
        Director = director;
        Year = year;
        Rating = rating;
        Next = null;
        Prev = null;
    }
}

class MovieList
{
    private Movie head;

    public void AddAtBeginning(string title, string director, int year, double rating)
    {
        Movie newMovie = new Movie(title, director, year, rating);
        if (head != null)
        {
            newMovie.Next = head;
            head.Prev = newMovie;
        }
        head = newMovie;
    }

    public void AddAtEnd(string title, string director, int year, double rating)
    {
        Movie newMovie = new Movie(title, director, year, rating);
        if (head == null)
        {
            head = newMovie;
            return;
        }
        Movie temp = head;
        while (temp.Next != null)
        {
            temp = temp.Next;
        }
        temp.Next = newMovie;
        newMovie.Prev = temp;
    }

    public void RemoveMovie(string title)
    {
        Movie temp = head;

        while (temp != null)
        {
            if (temp.Title == title)
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

    public void SearchByDirector(string director)
    {
        Movie temp = head;
        while (temp != null)
        {
            if (temp.Director == director)
            {
                Console.WriteLine("Title: " + temp.Title + ", Director: " + temp.Director + ", Year: " + temp.Year + ", Rating: " + temp.Rating);
            }
            temp = temp.Next;
        }
    }

    public void UpdateRating(string title, double newRating)
    {
        Movie temp = head;
        while (temp != null)
        {
            if (temp.Title == title)
            {
                temp.Rating = newRating;
                Console.WriteLine("Rating updated successfully.");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Movie not found.");
    }

    public void DisplayForward()
    {
        Movie temp = head;
        while (temp != null)
        {
            Console.WriteLine("Title: " + temp.Title + ", Director: " + temp.Director + ", Year: " + temp.Year + ", Rating: " + temp.Rating);
            temp = temp.Next;
        }
    }

    public void DisplayReverse()
    {
        Movie temp = head;
        if (temp == null)
        {
            Console.WriteLine("No movies available.");
            return;
        }
        while (temp.Next != null)
        {
            temp = temp.Next;
        }
        while (temp != null)
        {
            Console.WriteLine("Title: " + temp.Title + ", Director: " + temp.Director + ", Year: " + temp.Year + ", Rating: " + temp.Rating);
            temp = temp.Prev;
        }
    }

    static void Main()
    {
        MovieList list = new MovieList();
        
        list.AddAtBeginning("Inception", "Christopher Nolan", 2010, 8.8);
        list.AddAtEnd("Titanic", "James Cameron", 1997, 7.8);
        list.AddAtEnd("The Dark Knight", "Christopher Nolan", 2008, 9.0);

        Console.WriteLine("All Movies (Forward Order):");
        list.DisplayForward();

        Console.WriteLine("\nSearch for Movies by Director Christopher Nolan:");
        list.SearchByDirector("Christopher Nolan");

        Console.WriteLine("\nUpdating Rating for Titanic:");
        list.UpdateRating("Titanic", 8.0);
        list.DisplayForward();

        Console.WriteLine("\nDeleting Movie The Dark Knight:");
        list.RemoveMovie("The Dark Knight");
        list.DisplayForward();

        Console.WriteLine("\nAll Movies (Reverse Order):");
        list.DisplayReverse();
    }
}
