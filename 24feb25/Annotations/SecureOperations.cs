using System;

[AttributeUsage(AttributeTargets.Method)]
class RoleAllowed : Attribute
{
    public string Role { get; }

    public RoleAllowed(string role)
    {
        Role = role;
    }
}

class SecureOperations
{
    [RoleAllowed("ADMIN")]
    public void SecureTask()
    {
        Console.WriteLine("Secure task executed");
    }

    static void Main()
    {
        string currentUserRole = "USER";
        var method = typeof(SecureOperations).GetMethod("SecureTask");
        var attribute = (RoleAllowed)Attribute.GetCustomAttribute(method, typeof(RoleAllowed));

        if (attribute != null && attribute.Role != currentUserRole)
        {
            Console.WriteLine("Access Denied!");
        }
        else
        {
            SecureOperations operations = new SecureOperations();
            operations.SecureTask();
        }
    }
}

