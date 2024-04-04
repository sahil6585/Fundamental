using System;

// Abstract class Account
abstract class Account
{
    // Instance variables
    protected int accountNo;
    protected double balance;

    // Constructor
    public Account(int accountNo, double balance)
    {
        this.accountNo = accountNo;
        this.balance = balance;
    }

    // Abstract methods
    public abstract void CheckBalance();
    public abstract void Deposit(double amount);
    public abstract void Withdraw(double amount);
}

// Concrete class Savings inheriting from Account
class Savings : Account
{
    // Instance variable specific to Savings class
    private double interestRate;

    // Constructor
    public Savings(int accountNo, double balance, double interestRate) : base(accountNo, balance)
    {
        this.interestRate = interestRate;
    }

    // Override methods from Account class
    public override void CheckBalance()
    {
        Console.WriteLine("Savings Account Balance: " + balance);
    }

    public override void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine($"Amount {amount} deposited to Savings Account. New balance: {balance}");
    }

    public override void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Amount {amount} withdrawn from Savings Account. New balance: {balance}");
        }
        else
        {
            Console.WriteLine("Insufficient balance in Savings Account.");
        }
    }
}

// Concrete class Current inheriting from Account
class Current : Account
{
    // Instance variable specific to Current class
    private double overdraftLimit;

    // Constructor
    public Current(int accountNo, double balance, double overdraftLimit) : base(accountNo, balance)
    {
        this.overdraftLimit = overdraftLimit;
    }

    // Override methods from Account class
    public override void CheckBalance()
    {
        Console.WriteLine("Current Account Balance: " + balance);
    }

    public override void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine($"Amount {amount} deposited to Current Account. New balance: {balance}");
    }

    public override void Withdraw(double amount)
    {
        if (amount <= balance + overdraftLimit)
        {
            balance -= amount;
            Console.WriteLine($"Amount {amount} withdrawn from Current Account. New balance: {balance}");
        }
        else
        {
            Console.WriteLine("Withdrawal amount exceeds overdraft limit in Current Account.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating objects of Savings and Current classes
        Savings savingsAccount = new Savings(1234, 5000, 0.05);
        Current currentAccount = new Current(5678, 10000, 2000);

        // Performing operations on Savings account
        Console.WriteLine("Savings Account Operations:");
        savingsAccount.CheckBalance();
        savingsAccount.Deposit(2000);
        savingsAccount.Withdraw(1500);
        savingsAccount.Withdraw(6000);

        // Performing operations on Current account
        Console.WriteLine("\nCurrent Account Operations:");
        currentAccount.CheckBalance();
        currentAccount.Deposit(3000);
        currentAccount.Withdraw(5000);
        currentAccount.Withdraw(15000);
    }
}
