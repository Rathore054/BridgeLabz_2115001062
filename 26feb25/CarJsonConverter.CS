using System;
using Newtonsoft.Json;

class CarJsonConverter
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }

    static void Main()
    {
        Car car = new Car();
        car.Make = "Toyota";
        car.Model = "Corolla";
        car.Year = 2022;

        string json = JsonConvert.SerializeObject(car, Formatting.Indented);
        Console.WriteLine(json);
    }
}
