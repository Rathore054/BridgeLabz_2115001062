using System;
using System.Collections.Generic;

class User
{
    public int UserID;
    public string Name;
    public List<int> FriendIDs;
    public User Next;

    public User(int userID, string name)
    {
        UserID = userID;
        Name = name;
        FriendIDs = new List<int>();
        Next = null;
    }
}

class SocialMedia
{
    private User head;

    public void AddUser(int userID, string name)
    {
        User newUser = new User(userID, name);
        newUser.Next = head;
        head = newUser;
    }

    public void DisplayUsers()
    {
        User temp = head;
        while (temp != null)
        {
            Console.WriteLine("User ID: " + temp.UserID + ", Name: " + temp.Name);
            temp = temp.Next;
        }
    }

    static void Main()
    {
        SocialMedia sm = new SocialMedia();
        sm.AddUser(1, "Alice");
        sm.AddUser(2, "Bob");

        Console.WriteLine("User List:");
        sm.DisplayUsers();
    }
}
