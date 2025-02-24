using System;

[AttributeUsage(AttributeTargets.Field)]
class MaxLength : Attribute
{
    public int Length { get; }

    public MaxLength(int length)
    {
        Length = length;
    }
}

class User
{
    [MaxLength(10)]
    public string Username;

    public User(string username)
    {
        if (username.Length > 10)
        {
            throw new ArgumentException("Username exceeds max length");
        }
        Username = username;
    }

    static void Main()
    {
        try
        {
            User user = new User("LongUsername");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
