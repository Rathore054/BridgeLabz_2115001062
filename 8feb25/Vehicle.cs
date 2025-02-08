using System;
class Vehicle
{
    public int MaxSpeed;
    public string FuelType;

    public void DisplayInfo()
    {
        Console.WriteLine("Max Speed: " + MaxSpeed);
        Console.WriteLine("Fuel Type: " + FuelType);
    }
}

class Car : Vehicle
{
    public int SeatCapacity;

    public new void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Seat Capacity: " + SeatCapacity);
    }
}

class Truck : Vehicle
{
    public int PayloadCapacity;

    public new void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Payload Capacity: " + PayloadCapacity);
    }
}

class Motorcycle : Vehicle
{
    public bool HasSidecar;

    public new void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Has Sidecar: " + (HasSidecar ? "Yes" : "No"));
    }
}

class Program
{
    static void Main()
    {
        Vehicle[] vehicles = new Vehicle[]
        {
            new Car { MaxSpeed = 200, FuelType = "Petrol", SeatCapacity = 5 },
            new Truck { MaxSpeed = 120, FuelType = "Diesel", PayloadCapacity = 10000 },
            new Motorcycle { MaxSpeed = 150, FuelType = "Petrol", HasSidecar = true }
        };

        foreach (Vehicle v in vehicles)
        {
            v.DisplayInfo();
            Console.WriteLine();
        }
    }
}
