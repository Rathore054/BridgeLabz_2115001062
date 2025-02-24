using System;

[AttributeUsage(AttributeTargets.Method)]
class ImportantMethod : Attribute
{
    public string Level { get; }

    public ImportantMethod(string level = "HIGH")
    {
        Level = level;
    }
}

class ImportantTask
{
    [ImportantMethod]
    public void CriticalMethod() { }

    [ImportantMethod("MEDIUM")]
    public void SecondaryMethod() { }

    static void Main()
    {
        var methods = typeof(ImportantTask).GetMethods();
        foreach (var method in methods)
        {
            var attributes = (ImportantMethod[])method.GetCustomAttributes(typeof(ImportantMethod), false);
            foreach (var attr in attributes)
            {
                Console.WriteLine($"{method.Name}: Importance Level - {attr.Level}");
            }
        }
    }
}

