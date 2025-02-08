using System;

class Device
{
    public int DeviceId;
    public string Status;

    public void DisplayStatus()
    {
        Console.WriteLine("Device ID: " + DeviceId);
        Console.WriteLine("Status: " + Status);
    }
}

class Thermostat : Device
{
    public int TemperatureSetting;

    public new void DisplayStatus()
    {
        base.DisplayStatus();
        Console.WriteLine("Temperature Setting: " + TemperatureSetting);
    }
}

class Program
{
    static void Main()
    {
        Thermostat thermostat = new Thermostat();
        thermostat.DeviceId = 101;
        thermostat.Status = "On";
        thermostat.TemperatureSetting = 22;

        thermostat.DisplayStatus();
    }
}
