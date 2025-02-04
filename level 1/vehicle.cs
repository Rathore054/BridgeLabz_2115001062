using System;
class Vehicle
{
    public static int RegistartionFee;
    private static int totalstudents = 0;
    public string Ownername;
    private readonly int RegistrationNumber;
    public string Vehicletype;
  
    public static void UpdateRegistartionfee(int Fee)
    {
        RegistartionFee=Fee;
        Console.WriteLine("Updated Registration Fee :" + RegistartionFee);
    }
    public Vehicle(string name, int Number, string type)
    {
        this.Ownername = name;
        this.RegistrationNumber = Number;
        this.Vehicletype = type;
    }
    public void DisplayVehicledetails()
    {
        if (this is Vehicle)
        {

            Console.WriteLine("Owner Name :" + Ownername);
            Console.WriteLine("Registartion Number :" + RegistrationNumber);
            Console.WriteLine("Vehicle type :" + Vehicletype);
        }
    }
    static void Main()
    {
        Vehicle v1 = new Vehicle("Shivansh",1225 , "Petrol");
        Vehicle v2 = new Vehicle("Rajeev", 2552, "Diesel");
        v1.DisplayVehicledetails();
        UpdateRegistartionfee(5500);
        Console.WriteLine();
        v2.DisplayVehicledetails();
        UpdateRegistartionfee(4500);
    }
}