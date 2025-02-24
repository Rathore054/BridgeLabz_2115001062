using System;
using System.Reflection;

interface IGreeting
{
    void SayHello();
}

class Greeting : IGreeting
{
    public void SayHello() => Console.WriteLine("Hello, World!");
}

class LoggingProxy : IGreeting
{
    private IGreeting _greeting;
    public LoggingProxy(IGreeting greeting) => _greeting = greeting;

    public void SayHello()
    {
        Console.WriteLine("Method Call: SayHello()");
        _greeting.SayHello();
    }
}

class ProxyTest
{
    static void Main()
    {
        IGreeting proxy = new LoggingProxy(new Greeting());
        proxy.SayHello();
    }
}

