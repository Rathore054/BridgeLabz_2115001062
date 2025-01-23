using System;

class EmployeeBonus
{
    static void Main()
    {
        double salary = double.Parse(Console.ReadLine());
        int yearsOfService = int.Parse(Console.ReadLine());
        if (yearsOfService > 5)
        {
            double bonus = salary * 0.05;
            Console.WriteLine($"Bonus is {bonus}");
        }
    }
}
