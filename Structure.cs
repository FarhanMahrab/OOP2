
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

struct BankAccount
{
    // Fields
    public int AccountNumber;
    public string AccountHolderName;
    public double Balance;

    // Constructor
    public BankAccount(int accountNumber, string accountHolderName, double initialBalance)
    {
        AccountNumber = accountNumber;
        AccountHolderName = accountHolderName;
        Balance = initialBalance;
    }

    // Method to deposit money
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Successfully deposited {amount}. New Balance: {Balance}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }

    // Method to withdraw money
    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Successfully withdrew {amount}. New Balance: {Balance}");
        }
        else if (amount > Balance)
        {
            Console.WriteLine("Insufficient balance for the transaction.");
        }
        else
        {
            Console.WriteLine("Withdrawal amount must be positive.");
        }
    }

    // Method to display account details
    public void DisplayDetails()
    {
        Console.WriteLine("Account Details: ");
        Console.WriteLine($"Account Number: {AccountNumber}");
        Console.WriteLine($"Account Holder: {AccountHolderName}");
        Console.WriteLine($"Balance: {Balance}");
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        // Create a new bank account
        BankAccount account = new BankAccount(123456, "Alice Smith", 5000.00);

        // Display initial account details
        account.DisplayDetails();

        // Perform deposit
        Console.WriteLine("\nDepositing 2000...");
        account.Deposit(2000);

        // Perform withdrawal
        Console.WriteLine("\nWithdrawing 1000...");
        account.Withdraw(1000);

        // Attempt to withdraw more than the balance
        Console.WriteLine("\nAttempting to withdraw 10000...");
        account.Withdraw(10000);

        // Display updated account details
        Console.WriteLine("\nUpdated Account Details:");
        account.DisplayDetails();
    }
}

/*
    using System;
using System.Collections.Generic;

// Transaction structure
struct Transaction
{
    public string Type; // Deposit or Withdrawal
    public double Amount;
    public DateTime Date;

    public Transaction(string type, double amount)
    {
        Type = type;
        Amount = amount;
        Date = DateTime.Now;
    }

    public void DisplayTransaction()
    {
        Console.WriteLine($"{Date}: {Type} - {Amount}");
    }
}

// BankAccount class
class BankAccount
{
    // Fields
    public int AccountNumber;
    public string AccountHolderName;
    private double Balance;
    private List<Transaction> Transactions; // To store transaction history

    // Constructor
    public BankAccount(int accountNumber, string accountHolderName, double initialBalance)
    {
        AccountNumber = accountNumber;
        AccountHolderName = accountHolderName;
        Balance = initialBalance;
        Transactions = new List<Transaction>();
    }

    // Method to deposit money
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Successfully deposited {amount}. New Balance: {Balance}");
            Transactions.Add(new Transaction("Deposit", amount));
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }

    // Method to withdraw money
    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Successfully withdrew {amount}. New Balance: {Balance}");
            Transactions.Add(new Transaction("Withdrawal", amount));
        }
        else if (amount > Balance)
        {
            Console.WriteLine("Insufficient balance for the transaction.");
        }
        else
        {
            Console.WriteLine("Withdrawal amount must be positive.");
        }
    }

    // Method to display account details
    public void DisplayDetails()
    {
        Console.WriteLine("=== Account Details ===");
        Console.WriteLine($"Account Number: {AccountNumber}");
        Console.WriteLine($"Account Holder: {AccountHolderName}");
        Console.WriteLine($"Balance: {Balance}");
        Console.WriteLine("========================");
    }

    // Method to display transaction history
    public void DisplayTransactions()
    {
        Console.WriteLine("=== Transaction History ===");
        if (Transactions.Count == 0)
        {
            Console.WriteLine("No transactions found.");
        }
        else
        {
            foreach (var transaction in Transactions)
            {
                transaction.DisplayTransaction();
            }
        }
        Console.WriteLine("============================");
    }
}

// Program class to run the Bank System
class Program
{
    static void Main()
    {
        // Create a new bank account
        BankAccount account = new BankAccount(123456, "Alice Smith", 5000.00);

        // Display initial account details
        account.DisplayDetails();

        // Perform deposit
        Console.WriteLine("\nDepositing 2000...");
        account.Deposit(2000);

        // Perform withdrawal
        Console.WriteLine("\nWithdrawing 1000...");
        account.Withdraw(1000);

        // Attempt to withdraw more than the balance
        Console.WriteLine("\nAttempting to withdraw 10000...");
        account.Withdraw(10000);

       

 */
