using System;

namespace bank_account_sealed
{
    class BankAccount
    {
        public string AccountNumber { get; private set; }
        public decimal Balance { get; protected set; }

        public BankAccount(string accountNumber, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive.");
                return;
            }

            Balance += amount;
            Console.WriteLine($"Deposited: {amount}");
        }

        public virtual void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
                return;
            }

            if (Balance < amount)
            {
                Console.WriteLine("Insufficient balance.");
                return;
            }

            Balance -= amount;
            Console.WriteLine($"Withdrawn: {amount}");
        }

        public virtual void DisplayBalance()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Balance: {Balance:C}");
        }
    }

    sealed class SavingsAccount : BankAccount
    {
        public decimal InterestRate { get; private set; }

        public SavingsAccount(string accountNumber, decimal initialBalance, decimal interestRate)
            : base(accountNumber, initialBalance)
        {
            InterestRate = interestRate;
        }

        public void CalculateInterest()
        {
            decimal interestAmount = Balance * InterestRate;
            Deposit(interestAmount);
            Console.WriteLine($"Interest calculated and deposited: {interestAmount:C}");
        }

        public override void DisplayBalance()
        {
            base.DisplayBalance();
            Console.WriteLine($"Interest Rate: {InterestRate:P}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount savingsAccount = new SavingsAccount("SA123456", 1000, 0.05m);
            savingsAccount.DisplayBalance();

            savingsAccount.Deposit(500);
            savingsAccount.DisplayBalance();

            savingsAccount.Withdraw(200);
            savingsAccount.DisplayBalance();

            savingsAccount.CalculateInterest();
            savingsAccount.DisplayBalance();

            Console.Read();
        }
    }

}
