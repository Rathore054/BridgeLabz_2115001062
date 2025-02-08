using System;

interface IRefuelable
{
    void Refuel();
}

class Vehicle1
{
    public int MaxSpeed;
    public string Model;

    public void DisplayInfo()
    {
        Console.WriteLine("Model: " + Model);
        Console.WriteLine("Max Speed: " + MaxSpeed + " km/h");
    }
}

class ElectricVehicle : Vehicle1
{
    public void Charge()
    {
        Console.WriteLine(Model + " is charging.");
    }
}

class PetrolVehicle : Vehicle1, IRefuelable
{
    public void Refuel()
    {
        Console.WriteLine(Model + " is refueling.");
    }
}

class Program
{
    static void Main()
    {
        ElectricVehicle ev = new ElectricVehicle();
        ev.Model = "Tesla Model 3";
        ev.MaxSpeed = 200;
        ev.DisplayInfo();
        ev.Charge();

        PetrolVehicle pv = new PetrolVehicle();
        pv.Model = "Ford Mustang";
        pv.MaxSpeed = 250;
        pv.DisplayInfo();
        pv.Refuel();
    }
}

