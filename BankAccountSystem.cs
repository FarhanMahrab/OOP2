using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSystem
{
    // Base class: BankAccount
    public class BankAccount
    {
        // Properties
        public string AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        protected double Balance { get; set; }

        // Constructor
        public BankAccount(string accountNumber, string accountHolderName, double initialBalance)
        {
            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            Balance = initialBalance;
        }

        // Deposit method
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"{amount} deposited successfully. Current balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be greater than zero.");
            }
        }

        // Withdraw method (virtual to allow overriding)
        public virtual void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"{amount} withdrawn successfully. Current balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or insufficient balance.");
            }
        }

        // Display account details
        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Account Holder: {AccountHolderName}");
            Console.WriteLine($"Balance: {Balance}");
        }
    }

    // Derived class: SavingsAccount
    public class SavingsAccount : BankAccount
    {
        public double InterestRate { get; set; } // Additional field

        // Constructor
        public SavingsAccount(string accountNumber, string accountHolderName, double initialBalance, double interestRate)
            : base(accountNumber, accountHolderName, initialBalance)
        {
            InterestRate = interestRate;
        }

        // Add interest to the balance
        public void AddInterest()
        {
            double interest = Balance * (InterestRate / 100);
            Balance += interest;
            Console.WriteLine($"Interest added: {interest}. Current balance: {Balance}");
        }
    }

    // Main Program
    class Program
    {
        static void Main(string[] args)
        {
            // Create a savings account
            SavingsAccount myAccount = new SavingsAccount("123456789", "John Doe", 1000.0, 5.0);

            // Display account details
            myAccount.DisplayAccountInfo();
            Console.WriteLine();

            // Perform operations
            myAccount.Deposit(500);
            myAccount.Withdraw(200);
            myAccount.AddInterest();
            Console.WriteLine();

            // Display updated account details
            myAccount.DisplayAccountInfo();
        }
    }
}
