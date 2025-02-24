using System;

class LegacyAPI
{
    [Obsolete("Use NewFeature instead")]
    public void OldFeature()
    {
        Console.WriteLine("Old feature executed");
    }

    public void NewFeature()
    {
        Console.WriteLine("New feature executed");
    }
}

class Program
{
    static void Main()
    {
        LegacyAPI api = new LegacyAPI();
        api.OldFeature();
        api.NewFeature();
    }
}

