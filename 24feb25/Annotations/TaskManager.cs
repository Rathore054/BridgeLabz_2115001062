using System;

[AttributeUsage(AttributeTargets.Method)]
class TaskInfo : Attribute
{
    public string Priority { get; }
    public string AssignedTo { get; }

    public TaskInfo(string priority, string assignedTo)
    {
        Priority = priority;
        AssignedTo = assignedTo;
    }
}

class TaskManager
{
    [TaskInfo("High", "Alice")]
    public void CompleteTask() { }

    static void Main()
    {
        var method = typeof(TaskManager).GetMethod("CompleteTask");
        var attributes = (TaskInfo[])method.GetCustomAttributes(typeof(TaskInfo), false);

        foreach (var attr in attributes)
        {
            Console.WriteLine($"Priority: {attr.Priority}, AssignedTo: {attr.AssignedTo}");
        }
    }
}
