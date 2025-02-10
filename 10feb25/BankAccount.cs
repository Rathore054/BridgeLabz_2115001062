using System;
using System.Collections.Generic;

abstract class BankAccount
{
    protected int accountNumber;
    protected string holderName;
    protected double balance;

    public BankAccount(int accountNumber, string holderName, double balance)
    {
        this.accountNumber = accountNumber;
        this.holderName = holderName;
        this.balance = balance;
    }

    public void Deposit(double amount)
    {
        balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount <= balance)
            balance -= amount;
    }

    public abstract double CalculateInterest();
}

class SavingsAccount : BankAccount
{
    public SavingsAccount(int accountNumber, string holderName, double balance)
        : base(accountNumber, holderName, balance) { }

    public override double CalculateInterest()
    {
        return balance * 0.04;
    }
}

class CurrentAccount : BankAccount
{
    public CurrentAccount(int accountNumber, string holderName, double balance)
        : base(accountNumber, holderName, balance) { }

    public override double CalculateInterest()
    {
        return balance * 0.02;
    }
}

class Program
{
    static void Main()
    {
        List<BankAccount> accounts = new List<BankAccount>();
        accounts.Add(new SavingsAccount(101, "John", 5000));
        accounts.Add(new CurrentAccount(102, "Alice", 10000));

        foreach (BankAccount acc in accounts)
        {
            Console.WriteLine("Account Number: " + acc.accountNumber);
            Console.WriteLine("Holder Name: " + acc.holderName);
            Console.WriteLine("Interest: " + acc.CalculateInterest());
            Console.WriteLine();
        }
    }
}
