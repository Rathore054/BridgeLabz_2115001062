class BonusCalculation
{
    static void Main()
    {
        double[] salaries = new double[10];
        double[] yearsOfService = new double[10];
        double[] bonuses = new double[10];
        double[] newSalaries = new double[10];
        double totalBonus = 0, totalOldSalary = 0, totalNewSalary = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Enter salary for employee {i + 1}: ");
            if (!double.TryParse(Console.ReadLine(), out double salary) || salary <= 0)
            {
                i--;
                continue;
            }
            salaries[i] = salary;

            Console.Write($"Enter years of service for employee {i + 1}: ");
            if (!double.TryParse(Console.ReadLine(), out double years) || years < 0)
            {
                i--;
                continue;
            }
            yearsOfService[i] = years;
        }

        for (int i = 0; i < 10; i++)
        {
            bonuses[i] = yearsOfService[i] > 5 ? salaries[i] * 0.05 : salaries[i] * 0.02;
            newSalaries[i] = salaries[i] + bonuses[i];
            totalBonus += bonuses[i];
            totalOldSalary += salaries[i];
            totalNewSalary += newSalaries[i];
        }

        Console.WriteLine($"Total bonus payout: {totalBonus}");
        Console.WriteLine($"Total old salary: {totalOldSalary}");
        Console.WriteLine($"Total new salary: {totalNewSalary}");
    }
}
