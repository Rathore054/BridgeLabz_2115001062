using System;
using System.Collections.Generic;

abstract class Vehicle
{
    protected int vehicleId;
    protected string driverName;
    protected double ratePerKm;

    public Vehicle(int vehicleId, string driverName, double ratePerKm)
    {
        this.vehicleId = vehicleId;
        this.driverName = driverName;
        this.ratePerKm = ratePerKm;
    }

    public abstract double CalculateFare(double distance);

    public void GetVehicleDetails()
    {
        Console.WriteLine("Vehicle ID: " + vehicleId);
        Console.WriteLine("Driver Name: " + driverName);
        Console.WriteLine("Rate per KM: " + ratePerKm);
    }
}

class Car : Vehicle
{
    public Car(int vehicleId, string driverName, double ratePerKm) : base(vehicleId, driverName, ratePerKm) { }

    public override double CalculateFare(double distance)
    {
        return ratePerKm * distance;
    }
}

class Bike : Vehicle
{
    public Bike(int vehicleId, string driverName, double ratePerKm) : base(vehicleId, driverName, ratePerKm) { }

    public override double CalculateFare(double distance)
    {
        return ratePerKm * distance * 0.8;
    }
}

class Program
{
    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>();
        vehicles.Add(new Car(1, "John", 10));
        vehicles.Add(new Bike(2, "Alice", 5));

        foreach (Vehicle vehicle in vehicles)
        {
            vehicle.GetVehicleDetails();
            Console.WriteLine("Fare for 10 KM: " + vehicle.CalculateFare(10));
            Console.WriteLine();
        }
    }
}
