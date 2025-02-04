using System;
class BankAccount
{
    public static string bankName = "uditbank";
    public string AccountHolderName;
    private readonly int AccountNumber;
    public static int TotalNoOfAccounts = 0;
    public static void GetTotalAccounts()
    {
        Console.WriteLine("TotalNoOfAccounts :"+TotalNoOfAccounts);
    }
    public BankAccount(string name, int num)
    {
        this.AccountHolderName = name;
        this.AccountNumber = num;
        TotalNoOfAccounts++;
    }
    public void display()
    {
        if (this is BankAccount)
        {
            Console.WriteLine("bankname :"+bankName );
            Console.WriteLine("Account Holder :"+AccountHolderName );
            Console.WriteLine("Account Number :"+AccountNumber);
        }
    }
	static void Main(String[] args)
    {
        BankAccount bk = new BankAccount("Shivansh", 28767);
        BankAccount bk2 = new BankAccount("udit", 24232);
        bk.display();
        bk2.display();
        BankAccount.GetTotalAccounts();

    }
	
}

