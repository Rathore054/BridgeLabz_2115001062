using System;
using System.Collections.Generic;

class Bank {
    public string Name ;
    private List<Customer> customers = new List<Customer>();

    public Bank(string name) {
        this.Name = name;
    }

    public void OpenAccount(Customer customer, string accountNumber, double initialBalance) {
        BankAccount account = new BankAccount(accountNumber, initialBalance, this);
        customer.AddAccount(account);
        if (!customers.Contains(customer)) {
            customers.Add(customer);
        }
    }
}

class Customer {
    public string Name ;
    private List<BankAccount> accounts = new List<BankAccount>();

    public Customer(string name) {
        this.Name = name;
    }

    public void AddAccount(BankAccount account) {
        accounts.Add(account);
    }

    public void ViewBalance() {
        foreach (var account in accounts) {
            Console.WriteLine("Account: "+account.AccountNumber+" Balance:"+account.Balance);
        }
    }
}

class BankAccount {
    public string AccountNumber ;
    public double Balance ;
    public Bank Bank ;
    public BankAccount(string accountNumber, double balance, Bank bank) {
        this.AccountNumber = accountNumber;
        this.Balance = balance;
        this.Bank = bank;
    }
}

class Program {
    static void Main() {
        Bank bank = new Bank("ABC Bank");
        Customer customer = new Customer("Shivansh");

        bank.OpenAccount(customer, "123456", 1000);
        bank.OpenAccount(customer, "789012", 500);

        customer.ViewBalance();
    }
}
