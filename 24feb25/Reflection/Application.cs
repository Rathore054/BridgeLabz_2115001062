using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Field)]
class Inject : Attribute { }

class Service
{
    public void Execute() => Console.WriteLine("Service Executed");
}

class Application
{
    [Inject] private Service _service;

    public void Run() => _service.Execute();

    static void Main()
    {
        Application app = new Application();
        foreach (var field in typeof(Application).GetFields(BindingFlags.NonPublic | BindingFlags.Instance))
        {
            if (field.GetCustomAttribute<Inject>() != null)
                field.SetValue(app, Activator.CreateInstance(field.FieldType));
        }
        app.Run();
    }
}

