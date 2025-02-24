using System;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
class Todo : Attribute
{
    public string Task { get; }
    public string AssignedTo { get; }
    public string Priority { get; }

    public Todo(string task, string assignedTo, string priority = "MEDIUM")
    {
        Task = task;
        AssignedTo = assignedTo;
        Priority = priority;
    }
}

class ProjectTasks
{
    [Todo("Implement authentication", "John")]
    [Todo("Optimize database queries", "Alice", "HIGH")]
    public void WorkOnProject() { }

    static void Main()
    {
        var methods = typeof(ProjectTasks).GetMethods();
        foreach (var method in methods)
        {
            var attributes = (Todo[])method.GetCustomAttributes(typeof(Todo), false);
            foreach (var attr in attributes)
            {
                Console.WriteLine($"{method.Name}: Task - {attr.Task}, AssignedTo - {attr.AssignedTo}, Priority - {attr.Priority}");
            }
        }
    }
}
