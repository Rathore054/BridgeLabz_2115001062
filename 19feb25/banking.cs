using System;
using System.Collections.Generic;

class banking
{
    static void Main()
    {
        Dictionary<int, double> accounts = new Dictionary<int, double>
        {
            { 101, 5000.0 },
            { 102, 10000.0 },
            { 103, 7500.0 }
        };

        SortedDictionary<int, double> sortedAccounts = new SortedDictionary<int, double>(accounts);
        Queue<int> withdrawalQueue = new Queue<int>();

        withdrawalQueue.Enqueue(101);
        withdrawalQueue.Enqueue(103);

        Console.WriteLine("Account Balances:");
        foreach (var acc in sortedAccounts)
        {
            Console.WriteLine($"Account {acc.Key}: {acc.Value}");
        }

        Console.WriteLine("\nProcessing Withdrawals:");
        while (withdrawalQueue.Count > 0)
        {
            int accId = withdrawalQueue.Dequeue();
            Console.WriteLine($"Processing withdrawal for Account {accId}");
        }
    }
}
