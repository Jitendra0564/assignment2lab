using System;

namespace Class_BankAccount
{
    class BankAccount
    {
        public int AccountNumber { get; }
        public string AccountHolderName { get; }
        public decimal Balance { get; private set; }

        public BankAccount(int accountNumber, string accountHolderName, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid deposit amount. Amount must be positive.");
                return;
            }

            Balance += amount;
            Console.WriteLine($"Deposited {amount:C} into account {AccountNumber}. New balance: {Balance:C}");
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid withdrawal amount. Amount must be positive.");
                return;
            }

            if (amount > Balance)
            {
                Console.WriteLine("Insufficient funds for withdrawal.");
                return;
            }

            Balance -= amount;
            Console.WriteLine($"Withdrawn {amount:C} from account {AccountNumber}. New balance: {Balance:C}");
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Account Holder: {AccountHolderName}");
            Console.WriteLine($"Balance: {Balance:C}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(123456789, "Aditya Mishra", 9999999.00m);

            account.DisplayAccountDetails();

            account.Deposit(500.00m);
            account.Withdraw(200.00m);

            account.DisplayAccountDetails();
        }
    }


}
