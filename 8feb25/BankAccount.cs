using System;
class BankAccount
{
    public int AccountNumber;
    public double Balance;

    public void DisplayAccountInfo()
    {
        Console.WriteLine("Account Number: " + AccountNumber);
        Console.WriteLine("Balance: " + Balance);
    }
}

class SavingsAccount : BankAccount
{
    public double InterestRate;

    public new void DisplayAccountInfo()
    {
        base.DisplayAccountInfo();
        Console.WriteLine("Interest Rate: " + InterestRate + "%");
    }
}

class CheckingAccount : BankAccount
{
    public double WithdrawalLimit;

    public new void DisplayAccountInfo()
    {
        base.DisplayAccountInfo();
        Console.WriteLine("Withdrawal Limit: " + WithdrawalLimit);
    }
}

class FixedDepositAccount : BankAccount
{
    public int MaturityPeriod;

    public new void DisplayAccountInfo()
    {
        base.DisplayAccountInfo();
        Console.WriteLine("Maturity Period: " + MaturityPeriod + " years");
    }
}

class Program
{
    static void Main()
    {
        SavingsAccount sa = new SavingsAccount();
        sa.AccountNumber = 12345;
        sa.Balance = 5000;
        sa.InterestRate = 3.5;

        sa.DisplayAccountInfo();
    }
}
