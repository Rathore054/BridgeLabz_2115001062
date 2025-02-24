using System;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
class BugReport : Attribute
{
    public string Description { get; }

    public BugReport(string description)
    {
        Description = description;
    }
}

class BugTracker
{
    [BugReport("Null reference issue")]
    [BugReport("Performance lag detected")]
    public void FixBugs() { }

    static void Main()
    {
        var method = typeof(BugTracker).GetMethod("FixBugs");
        var attributes = (BugReport[])method.GetCustomAttributes(typeof(BugReport), false);

        foreach (var attr in attributes)
        {
            Console.WriteLine($"Bug: {attr.Description}");
        }
    }
}
